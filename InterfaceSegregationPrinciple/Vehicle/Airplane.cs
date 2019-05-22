using System;

namespace InterfaceSegregationPrinciple
{
    public class Airplane : IAirplane
    {
        public void Fly()
        {
            Console.WriteLine("Flying a plane");
        }
    }
}
