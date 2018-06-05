using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CDWarehouse.Test
{
    [TestClass]
    public class CDWarehouseTests
    {
            //buying title reduces stock
        [TestMethod]
        public void DispatchingCDReducesStock()
        {
            var title = new Title()
            {
                Stock = 10
            };

            var purchaseOrder = new PurchaseOrder
            {
                Title = title
            };

            purchaseOrder.Dispatch();

            Assert.AreEqual(9, title.Stock);
        }

            //payments are processed


            //titles can be rated

            //stock can be added
        [TestMethod]
        public void StockCanBeAdded()
        {
            var title = new Title {Stock = 10, Name = "testName"};

            var warehouse = new Warehouse();

            warehouse.Stock(title);
            
            Assert.AreEqual(title.Stock, warehouse.Titles.First(x=>x.Name == title.Name).Stock);
        }


            //search


        
    }
}
