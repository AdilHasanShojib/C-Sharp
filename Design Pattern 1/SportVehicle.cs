using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_1
{
    public class SportVehicle : IVehicleSport
    {


        public IBike CreateBike()
        {
            return new SportBike();
        }

        public ICar CreateCar()
        {
            return new SportCar();
        }





    }
}
