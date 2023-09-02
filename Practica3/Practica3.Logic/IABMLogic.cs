using Practica3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3.Logic
{
     interface IABMLogic<T>
    {
        List<T> GetAll();

        void Add(T newshippers);

        void Delete(int id);
        void Update(T shippers);
    }
}
