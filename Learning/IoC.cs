namespace Learning
{
    /*
    Suppose the customer data comes from different databases or web services and,
    in the future, we may need to create different classes,
    so this will lead to changes in the CustomerBusinessLogic class.
     */

    /*
    Because the CustomerBusinessLogic class creates an object of the concrete DataAccess class,
    it cannot be tested independently (TDD).
    The DataAccess class cannot be replaced with a mock class.
    */


    public class CustomerBusinessLogic
    {
        readonly DataAccess _dataAccess;

        public CustomerBusinessLogic()
        {
            //It also creates an object of DataAccess class and manages the lifetime of the object.
            _dataAccess = new DataAccess();
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }

    public class DataAccess
    {
        public DataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name"; // get it from DB in real app
        }
    }
}
