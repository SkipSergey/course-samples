namespace Stage1.chapter3
{
    public class Ship : Transport
    {
        public Ship(object engine, object transmission, double maxWeight) : base(engine, transmission, maxWeight)
        {
        }

        public override string Move()
        {
            return "Корабль идет по воде из гпорта А в порт Б";
        }

        public override string Reparing()
        {
            return "Корабль проходит ремонт в гавани";
        }
    }
}