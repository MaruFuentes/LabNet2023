using EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.logic
{
     interface IABMLogic<T>
    {
        List<T> GetAll();
        void add(T newRegion);

        void Delete(int id);
        void Update(T region);
    }
}
