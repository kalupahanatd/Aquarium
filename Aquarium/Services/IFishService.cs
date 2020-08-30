using Aquarium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aquarium.Services
{
    public interface IFishService
    {
        List<Fish> GetAll();
        Fish Get(int id);

        void Add(Fish newfish);
        void Update(int id, Fish book);
        void Delete(int id);
    }
}
