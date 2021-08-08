namespace Store_App_Solid_Principle
{
    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }

        public static IStoreDataAccess GetStoreDataAccessObj()
        {
            return new StoreDataAccess();
        }
        public static IProductDataAccess GetProductDataAccessObj()
        {
            return new ProductDataAccess();
        }
    }
}
