namespace CDWarehouse
{
    public class PurchaseOrder
    {
        public Title Title { get; set; }

        public void Dispatch()
        {
            Title.Stock--;
        }
    }
}