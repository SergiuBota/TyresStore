using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TyresStore.Repository.Models;

namespace TyresStore.Repository
{
    public class VehiclesReponsitory : IVehicleReponsitory
    {
        TyresStoreContext tyreContext = new TyresStoreContext();
        

        public Vehicle GetVehicleById(int vehicleId)
        {
            return tyreContext.Vehicles.FirstOrDefault(x => x.ID == vehicleId);
            
        }

        public List<Vehicle> GetVehicles()
        {
            return tyreContext.Vehicles.ToList();
        }
    }
}
