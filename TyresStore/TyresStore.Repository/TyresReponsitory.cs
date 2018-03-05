using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyresStore.Repository.Interfaces;
using TyresStore.Repository.Models;

namespace TyresStore.Repository
{
    public class TyresReponsitory : ITyresReponsitory
    {
        TyresStoreContext tyresContext = new TyresStoreContext();

        public Tyre GetTyreById(int tyreId)
        {
            return tyresContext.Tyres.FirstOrDefault(x => x.ID == tyreId);
        }

        public Tyre GetTyreId(int tyreId)
        {
            throw new NotImplementedException();
        }

        public List<Tyre> GetTyres()
        {

            return tyresContext.Tyres.ToList();
        }

        public List<Tyre> GetTyresByVehicle(int vehicleId)
        {
            return tyresContext.Tyres.Where(t => t.VehicleId == vehicleId).ToList();
        }

        public List<Tyre> GetTyresVehicleId(int vehicleId)
        {
            throw new NotImplementedException();
        }
    }
}
