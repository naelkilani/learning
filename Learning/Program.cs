using Learning.LooslyCoupled_Step4;
using Unity;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();

            //Here, container.RegisterType<ICar, BMW>() requests
            //Unity to create an object of the BMW class and inject it through a constructor
            //whenever you need to inject an object of ICar.
            container.RegisterType<ICar, BMW>();

            var driver = container.Resolve<Driver>();
            driver.RunCar();
        }
    }
}
