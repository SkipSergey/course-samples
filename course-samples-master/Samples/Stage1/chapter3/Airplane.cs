namespace Stage1.chapter3
{
    public class Airplane : Transport
    {
        private int engineCount;

        public Airplane(object engine, object transmission, double maxWeight, int engineCount) : base(engine, transmission, maxWeight)
        {
            this.engineCount = engineCount;
        }

        public override string Move()
        {
            return "Самолёт летит из города А в город Б";
        }

        public override string Reparing()
        {
            return "Самолет проходит ремонт в ангаре";
        }
    }
}