using Aquarium.Data;
using Aquarium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Aquarium.Services
{
    public class FishService: IFishService
    {
        // create an instance of database
        private readonly FishDataContext _fishDataContext;

        public FishService(FishDataContext libraryDataContext)
        {
            _fishDataContext = libraryDataContext;
            // bind libraryDataContext to read only _fishDataContext 
        }


        public List<Fish> GetAll()
        {
            return _fishDataContext.FishTable.ToList();
        }

        public Fish Get(int id)
        {
            return _fishDataContext.FishTable.FirstOrDefault(book => book.Id == id);
        }

        public void Add(Fish newfish)
        {
            _fishDataContext.FishTable.Add(newfish);
            _fishDataContext.SaveChanges();     //  this will save the changes
        }

        public void Update(int id, Fish fish)
        {
            _fishDataContext.FishTable.Update(fish);
            _fishDataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Fish temp = Get(id);                   // we cannot delete by id, therfore find the
            _fishDataContext.FishTable.Remove(temp);  //paticular book first , then delete
            _fishDataContext.SaveChanges();
        }
    }
}
