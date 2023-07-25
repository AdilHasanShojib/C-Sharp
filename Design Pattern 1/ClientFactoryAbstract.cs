using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_1
{
    public class ClientFactoryAbstract {           

        public static void UseAbstractFactory()
        {

            /// Regular Factory

            IVehicleSport regular = new RegularVehicle();
            IBike bike = regular.CreateBike();
            bike.Details();
            ICar car = regular.CreateCar();
            car.Details();

            //Sport Factory

            IVehicleSport sport = new SportVehicle();
            IBike bike1 = sport.CreateBike();
            bike1.Details();
            ICar car1 = sport.CreateCar();
            car1.Details();

        }

    }
}
