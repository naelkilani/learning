namespace Learning.LooslyCoupled_Step3
{
    // Client.
    public class CustomerBusinessLogic
    {
        IDataAccess _dataAccess;

        public CustomerBusinessLogic(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public CustomerBusinessLogic()
        {
            _dataAccess = new CustomerDataAccess();
        }

        public string GetCustomerName(int id)
        {
            return _dataAccess.GetCustomerName(id);
        }
    }

    public interface IDataAccess
    {
        string GetCustomerName(int id);
    }

    // Service
    public class CustomerDataAccess : IDataAccess
    {
        public CustomerDataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            //get the customer name from the db in real application        
            return "Dummy Customer Name";
        }
    }

    // Injector.
    public class CustomerService
    {
        CustomerBusinessLogic _customerBL;

        public CustomerService()
        {
            _customerBL = new CustomerBusinessLogic(new CustomerDataAccess());
        }

        public string GetCustomerName(int id)
        {
            return _customerBL.GetCustomerName(id);
        }
    }
}
