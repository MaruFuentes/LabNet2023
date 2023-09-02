using EF.Data1;
using EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.logic
{
    public class RegionLogic : BaseLogic,IABMLogic<Region>
    {
      
        public List<Region> GetAll()
        {
            return context.Region.ToList();
        }

        public void add(Region newRegion)
        {
            context.Region.Add(newRegion);
            context.SaveChanges();


        }
        public void Delete(int id)
        {
        var regionAEliminar = context.Region.Find(id); 
        context.Region.Remove(regionAEliminar);
        context.SaveChanges();
                
        }
        public void Update(Region region)
        {
            var regionUpdate = context.Region.Find(region.RegionID);
            regionUpdate.RegionDescription = region.RegionDescription;
            context.SaveChanges();
        }

        }
    }

