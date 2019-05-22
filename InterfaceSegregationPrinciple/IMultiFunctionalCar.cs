namespace InterfaceSegregationPrinciple
{
    public interface IMultiFunctionalCar : ICar, IAirplane
    {
        void Drive();
        void Fly();
    }
}