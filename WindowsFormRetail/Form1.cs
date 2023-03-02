using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Console;

namespace DeanM_Assign2
{
    public partial class Form1 : Form
    {
        List<RetailProduct> RetailList = new List<RetailProduct>();

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayProductInfo() //Displays the information of each product using a foreach loop
        {

            retailStockListBox.Items.Clear();

            string headerLine = String.Format("{0,-16}{1,-23}{2,-16}{3,-16}{4,-16}{5,-16}{6,-16}{7,-16}", 
                                            "Product Code", "Product Name", "Starting Qty", "Min Qty", 
                                               "Sold Qty", "Unit Price", "Avaliable Qty", "Sales");
            //Header uses the some formatted output as the RetailProduct.cs ToString() method

            retailStockListBox.Items.Add(headerLine);
         


            foreach (RetailProduct myRetailProduct in RetailList)
            {
                retailStockListBox.Items.Add(myRetailProduct.ToString());
            }
        }

        private void readRetailStockData_Click(object sender, EventArgs e)
        {
            RetailList.Clear();

            try
            {
                using (StreamReader myReadFileStream = new StreamReader("retailstock_input.csv"))
                {
                    if (!myReadFileStream.EndOfStream)
                    {
                        string columTitles = myReadFileStream.ReadLine();
                        //header line
                    }

                    while (!myReadFileStream.EndOfStream)
                    {
                        string productInfo = myReadFileStream.ReadLine();
                        string[] columTitlesArray = productInfo.Split(','); //Spliting each colum at the comma character
                        string productCode = columTitlesArray[0];
                        string productName = columTitlesArray[1];
                        int.TryParse(columTitlesArray[2], out int startingQty);
                        int.TryParse(columTitlesArray[3], out int minQty);
                        int.TryParse(columTitlesArray[4], out int soldQty);
                        int.TryParse(columTitlesArray[5], out int restockedQty);
                        double.TryParse(columTitlesArray[6], out double unitPrice);
                        //parsed each string value to its interger or double value so it can be used for arithmetic throughout the program

                        RetailProduct myRetailProduct = new RetailProduct(productCode, productName, startingQty,
                                                                            minQty, soldQty, restockedQty, unitPrice);
                        //Initialized and create object to be used for each colum in listbox

                        RetailList.Add(myRetailProduct);
                    }
                }

                DisplayProductInfo();
                statusLabel.Text = "Loaded " + RetailList.Count + " items from the input file";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Used exception handling to allow the program to run even if something is wrong within the code
            }
        }

        private void updateSoldQtyForSelectedItem_Click(object sender, EventArgs e)
        {
            int selIndex = retailStockListBox.SelectedIndex;

            try
            {
                RetailList[selIndex - 1].SoldQty = int.Parse(soldQtyTextBox.Text);
                //Parse() method to covert the input from user into interger
                // used the same technique for 
            }
            catch { }


            if (selIndex == -1 || selIndex == 0)
            {
                statusLabel.Text = "Please selected a retail product item to increment sold qty";
            } 
            else if (0 < RetailList[selIndex - 1].SoldQty || RetailList[selIndex - 1].SoldQty <= RetailList[selIndex - 1].AvaliableQty)
            {
                retailStockListBox.Items[selIndex] = RetailList[selIndex - 1];
                statusLabel.Text = "Qty Sold has been increased for the item with product code " + RetailList[selIndex - 1].ProductCode;
            } 
            else if (RetailList[selIndex - 1].SoldQty > RetailList[selIndex - 1].AvaliableQty ||
                      RetailList[selIndex - 1].SoldQty <= 0)
            {
                statusLabel.Text = "Please enter an integer equal to or less than the avaliable qty and greater than 0";

            }
            /*Event handler using if and else if statements to display the right error message that 
             pairs with the correct condition*/

        }

        private void updateRestockedQtyForSelectedItem_Click(object sender, EventArgs e)
        {
            int selIndex = retailStockListBox.SelectedIndex;
            /*by putting retailStockListBox.SelectedIndex as selIndex, I ended up writing less coude because selIndex is shorter*/

            try
            {
                RetailList[selIndex - 1].RestockedQty = int.Parse(restockedQtyTextBox.Text);
            }
            catch { }
            //Catching the execption with no message box so first if() condition gets tested


            if (selIndex == -1 || selIndex == 0)
            {
                statusLabel.Text = "Please selected a retail product item to increment restocked qty";
            } 
            else if (RetailList[selIndex - 1].RestockedQty <= 0)
            {
                statusLabel.Text = "Please increment restocked qty greater than 0";
            } 
            else if (RetailList[selIndex - 1].RestockedQty > 0 )
            {
                retailStockListBox.Items[selIndex] = RetailList[selIndex - 1];
                statusLabel.Text = "Incremented Restocked Qty for item with item code " + RetailList[selIndex - 1].ProductCode;
            }

            /*Like updateSoldQtyForSelectedItem_Click() event handler, 
            I used if statements to display the right error message with its correct condition*/ 
        }

        private void deleteSelectedRetailItem_Click(object sender, EventArgs e)
        {
            int selIndex = retailStockListBox.SelectedIndex;
            retailStockListBox.Items.Remove(retailStockListBox.SelectedItem);
            //Remove() method with selected item, so the user can choose the an item to delete

            if (selIndex < 0) 
            {
                statusLabel.Text = "Please select a retail product to delete";
            }
            else
            {
                statusLabel.Text = "Deleted item with item code " + RetailList[selIndex - 1].ProductCode;
            }

        }

        private void sortByDescendingOrderOfSales_Click(object sender, EventArgs e)
        {
            RetailList = RetailList.OrderByDescending(myRetailProduct => myRetailProduct.Sales).ToList(); 
            //myRetailProduct.Sales as the parameter to sort the list by that colum 
            DisplayProductInfo();//Displays RetailList
            statusLabel.Text = "List ordered in descending order of sales";
        }

        private void saveRetailStockData_Click(object sender, EventArgs e)
        {
            using (StreamWriter myWriteFileStream = new StreamWriter("retailStock_output.csv"))
            //StreamWriter writier to comma seperated excel file, like wise for the two event handlers below
            {
                myWriteFileStream.WriteLine("Product Code,Product Name,Starting Qty,Min Qty,Sold Qty,Restocked Qty,Unit Price");

                foreach (RetailProduct myRetailProduct in RetailList)
                {
                    string savedProductInfo = myRetailProduct.ProductCode + "," + myRetailProduct.ProductName + "," + myRetailProduct.StartingQty + "," 
                                        + myRetailProduct.MinQty + "," + myRetailProduct.SoldQty + "," + myRetailProduct.RestockedQty + "," 
                                        + myRetailProduct.UnitPrice.ToString("C");
                    myWriteFileStream.WriteLine(savedProductInfo); 
                }
                statusLabel.Text = "Saved " + RetailList.Count + " records into the output retail stock file";
            }
        }
        
        private void createSalesReport_Click(object sender, EventArgs e)
        {
            using (StreamWriter myWriteFileStream = new StreamWriter("sales_report.csv"))
            {
                myWriteFileStream.WriteLine("Product Code,Product Name,Sold Qty,Unit Price,Sales");
               
                foreach (RetailProduct myRetailProduct in RetailList)
                {                    
                    if (myRetailProduct.Sales > 0)
                    {
                        string salesReport = myRetailProduct.ProductCode + "," + myRetailProduct.ProductName + ","
                                            + myRetailProduct.SoldQty + "," + myRetailProduct.UnitPrice.ToString("C") + ","
                                            + myRetailProduct.Sales.ToString("C");
                        myWriteFileStream.WriteLine(salesReport);
                        

                        statusLabel.Text = "Saved " + RetailList.Count(myProduct => myProduct.Sales > 0) + " records into the output sales file";
                        //Used Count() method and put myProduct.Sales > 0 as a parameter to only get sold objects
                    }
                }
            }
        }

        private void createRestockNeedsReport_Click(object sender, EventArgs e)
        {
            using (StreamWriter myWriteFileStream = new StreamWriter("restock_report.csv"))
            {
                myWriteFileStream.WriteLine("Product Code,Product Name,Min Qty,Avaliable Qty");

                foreach (RetailProduct myRetailProduct in RetailList)
                {
                    if (myRetailProduct.AvaliableQty < myRetailProduct.MinQty)
                    {
                        string restockNeeds = myRetailProduct.ProductCode + "," + myRetailProduct.ProductName + ","
                                            + myRetailProduct.MinQty + "," + myRetailProduct.AvaliableQty;
                        myWriteFileStream.WriteLine(restockNeeds);

                        statusLabel.Text = "Saved " + RetailList.Count(myProduct => myProduct.AvaliableQty < myProduct.MinQty) + " records into the restock needs output file";

                    }
                }
            }
        }



        //Unused event handler for groupbox
        private void saveData_Enter(object sender, EventArgs e)
        {

        }

        private void soldQtyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
