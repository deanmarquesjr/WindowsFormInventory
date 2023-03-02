using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeanM_Assign2
{
    class RetailProduct
    {
        // My read-only proporties
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int StartingQty { get; set; }
        public int MinQty { get; set; }
        public int SoldQty { get; set; }
        public int RestockedQty { get; set; }
        public double UnitPrice { get; set; }
        
        //Read-only computed proporties
        public int AvaliableQty
        {
            get
            {
                return StartingQty - SoldQty + RestockedQty;
            }
        }

        public double Sales
        {
            get
            {
                return SoldQty * UnitPrice;
            }
        }

        public RetailProduct(string productCode, string productName, int startingQty, 
                                int minQty, int soldQty, int restockedQty, double unitPrice)
        {
            ProductCode = productCode;
            ProductName = productName;
            StartingQty = startingQty;
            MinQty = minQty;
            SoldQty = soldQty;
            RestockedQty = restockedQty;
            UnitPrice = unitPrice;
            //Class constructors that are set than initialized in certain event handlers, and as a list
        }

        public override string ToString()
        {
            return String.Format("{0,-16}{1,-23}{2,-16}{3,-16}{4,-16}{5,-16}{6,-16}{7,-16}", 
                                    ProductCode, ProductName, StartingQty, MinQty, 
                                    SoldQty, UnitPrice.ToString("C"), AvaliableQty, Sales.ToString("C"));


           //ToString() using formatted output
        }
    }
}
