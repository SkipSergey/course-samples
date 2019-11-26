namespace Stage1.chapter3
{
    public class Car : Transport
    {
        public Car(object engine, object transmission, double maxWeight) : base(engine, transmission, maxWeight)
        {
        }

        public override string Move()
        {
            return "Автомобиль едит из города А в город Б";
        }

        public override string Reparing()
        {
            return "Производится ремонт автомобиля";
        }
    }
}