namespace Learning.LooslyCoupled_Step2
{
    /*
        1. High-level modules should not depend on low-level modules.
        Both should depend on the abstraction.
        
        2. Abstractions should not depend on details. Details should depend on abstractions.

        Abstraction in programming means to create an interface or an abstract class which
        is non-concrete
    */

    /*
        After applying DIP there still a problem, we used DataAccessFactory 
        inside the CustomerBusinessLogic class. So, suppose there is another implementation of 
        IDataAccess and we want to use that
        new class inside CustomerBusinessLogic.
     */
    public class CustomerBusinessLogic
    {
        IDataAccess _custDataAccess;

        public CustomerBusinessLogic()
        {
            _custDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }
    }

    public class DataAccessFactory
    {
        public static IDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }


    //(IDataAccess) does not depend on details(CustomerDataAccess),
    //but the details depend on the abstraction.
    public class CustomerDataAccess : IDataAccess
    {
        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }

    public interface IDataAccess
    {
        string GetCustomerName(int id);
    }
}
