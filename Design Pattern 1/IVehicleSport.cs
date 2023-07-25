using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_1
{
   public interface IVehicleSport
    {

        public IBike CreateBike();
        public ICar  CreateCar(); 
    }
}
