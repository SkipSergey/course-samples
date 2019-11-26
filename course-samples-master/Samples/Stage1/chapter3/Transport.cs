using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stage1.chapter3
{
    public abstract class Transport
    {
        protected object transmission;
        protected object engine;
        protected readonly List<Cargo> baggage;
        protected readonly double maxWeight;
        protected double load;

        protected Transport(object engine, object transmission, double maxWeight)
        {
            this.engine = engine;
            this.transmission = transmission;
            this.maxWeight = maxWeight;
            this.load = 0;
            baggage = new List<Cargo>();
        }

        public string Loading(object cargo, double weight)
        {
            if ((load + weight) <= maxWeight)
            {
                this.load += weight;
                baggage.Add(new Cargo(cargo, weight));

                return "Багаж загружен";
            }
            else
            {
                return "Груз не помещается в багаж";
            }
        }

        public string Unloading(object cargo)
        {
            if (load == 0)
            {
                return "Багажник пуст";
            }

            Cargo searchCargo = baggage.Find(x => x.cargo == cargo);
            if (searchCargo.cargo != null)
            {
                load -= searchCargo.weight;
                baggage.Remove(searchCargo);
                return "Груз выгружен";
            }
            else
            {
                return "Груз не найден";
            }

        }

        public abstract string Move();
        public abstract string Reparing();


    }
}
