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

namespace BiancaO_Assign2
{
    public partial class Form1 : Form
    {
        // List to read and write from directed file and display in the list
        private List<Grocery> SalesProductList = new List<Grocery>();      
        
        private void LoadListBox() //method to update the listbox following list
        {
            // cleaner display
            groceryListBox.Items.Clear();
            string header = string.Format("{0,-16}\t{1,-10}\t{2,-10:C}\t{3,-10}\t{4,-10}\t{5,-10}\t{6,-10}\t{7,-8}\t{8:C}", 
                "ItemName", "ItemCode", "UnitPrice", "StartingQty", "QtyMinRestock", "QtySold", "QtyRestocked", "QuantityOnHand", "TotalSales");
            groceryListBox.Items.Add(header);
            foreach (Grocery saleProd in SalesProductList)
            {
                groceryListBox.Items.Add(saleProd); //add items
            }
        }
        public Form1()
        {
            InitializeComponent();          
        }

        //loading file (bin>debu>localgrocery.csv) into the list
        private void LoadingDataButton_Click(object sender, EventArgs e)
        {         
            SalesProductList.Clear(); //to not have duplicate data, you need to clear the list before.
            try
            {  // reading file bin>debu>localgrocery.csv 
                using (StreamReader myInputStream = new StreamReader("localgrocery.csv"))
                {
                    string eachLine = ""; //just to store line that is read
                    bool isHeader = true;
                    while ((eachLine = myInputStream.ReadLine()) != null)
                    {                                            
                        string[] eachLineFields = eachLine.Split(',');// breaking the lines  
                                              
                        if (!isHeader)  // building the header 1st 
                        {
                            // after the 1st time, it will fill the list and display it on the listbox                           
                            Grocery saleProd = new Grocery(eachLineFields[0], eachLineFields[1], 
                                double.Parse(eachLineFields[2]), int.Parse(eachLineFields[3]), 
                                int.Parse(eachLineFields[4]), int.Parse(eachLineFields[5]), int.Parse(eachLineFields[6])); //making the proper conversions
                                                       
                            SalesProductList.Add(saleProd); //adding sales products
                        }
                        else
                        {
                            string header = string.Format("{0,-10}\t{1,-16}\t{2,-10:C}\t{3,-10}\t{4,-10}\t{5,-10}\t{6,-10}\t{7,-10}\t{8:C}",
                                eachLineFields[0], eachLineFields[1], eachLineFields[2], eachLineFields[3], 
                                eachLineFields[4], eachLineFields[5], eachLineFields[6], 
                                "QuantityOnHand", "TotalSales"); //following the format

                            groceryListBox.Items.Add(header);
                            isHeader = false;
                        }
                    }
                    LoadListBox(); //calling the update
                }               
                StatusLabel.Text = "Loaded " + SalesProductList.Count + " items from the input file"; //update status label
            }           
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);// exception
            }
        }
        private void UpdateQtySoldButton_Click(object sender, EventArgs e)
        {
            {
                if (groceryListBox.SelectedIndex <= 0)
                {                   
                    StatusLabel.Text = "Please selected a grocery item to increment sold qty";
                }
                else
                {              
                    int qtySold;

                    int.TryParse(qtySoldTextBox.Text, out qtySold); //converting .Text
                    if (qtySold <= 0 || qtySold > SalesProductList[groceryListBox.SelectedIndex - 1].QuantityOnHand) //conditionals
                    {                       
                        StatusLabel.Text = "Please enter a valid number of sold qty > 0 and sold qty = or < Quantity On Hand";
                    }
                    else
                    {
                        SalesProductList[groceryListBox.SelectedIndex - 1].QtySold = qtySold;
                       
                        StatusLabel.Text = "Sold Qty has been increased for the item with item code: " + SalesProductList[groceryListBox.SelectedIndex - 1].ItemCode;
                        LoadListBox(); //calling to update list
                    }
                }
                qtySoldTextBox.Clear();
            }
        }
        private void UpdateQtyRestokedButton_Click(object sender, EventArgs e)
        {
            if (groceryListBox.SelectedIndex <= 0)
            {               
                StatusLabel.Text = "Please selected a grocery item to increment restocked qty";
            }
            else
            {               
                int i = groceryListBox.SelectedIndex - 1; // I tried use variable here to try and let the code cleaner
                int qtyRestocked;

                int.TryParse(qtyRestockedTextBox.Text, out qtyRestocked); // values output 
                if (qtyRestocked <= 0)
                {                   
                    StatusLabel.Text = "Please enter a valid number of restocked qty > 0 and restocked qty = or < Quantity On Hand";
                }
                else
                {
                    SalesProductList[i].QtyRestocked = qtyRestocked; //inserting new values                   
                    StatusLabel.Text = "Incremented Restocked Qty for item with item code: " + SalesProductList[i].ItemCode;
                    LoadListBox();
                }
            }
            qtyRestockedTextBox.Clear();
        }
        private void DeleteSelectedItemButton_Click(object sender, EventArgs e)
        {
            if (groceryListBox.SelectedIndex <= 0)
            {                
                StatusLabel.Text = "Please selected a grocery item to delete";
            }
            else
            {           
                StatusLabel.Text = "Deleted item with item code: " + SalesProductList[groceryListBox.SelectedIndex - 1].ItemCode;
                SalesProductList.RemoveAt(groceryListBox.SelectedIndex - 1); //removing the product from list
                LoadListBox();
            }
        }
        private void SaveGroceryDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                // creating  file in the folder /bin/debug
                using (StreamWriter streamWriter = new StreamWriter("updategrocery.csv"))
                {
                    // header as instructed
                    string header = string.Format("{0},{1},{2},{3},{4},{5},{6}", "ItemName", "ItemCode", 
                        "StartingQty", "QtyMinRestock", "QtySold", "QtyRestocked", "UnitPrice");

                    streamWriter.WriteLine(header);

                    foreach (Grocery saleProd in SalesProductList)
                    {
                        // formatting as oriented
                        string row = string.Format("{0},{1},{2},{3},{4},{5},{6}", saleProd.ItemName, saleProd.ItemCode,
                            saleProd.StartingQty, saleProd.QtyMinForRestock, saleProd.QtySold, saleProd.QtyRestocked, saleProd.UnitPrice.ToString("C"));
                        streamWriter.WriteLine(row);
                    }
                    StatusLabel.Text = "Saved " + SalesProductList.Count + "records into the updategrocery.csv  file";
                }
            }        
            catch (Exception ex)
            {
                //exception
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveSalesReportButton_Click(object sender, EventArgs e)
        {           
            int recordSaved = 0; // variable created to display and keep looping of the number of qnt records saved
            try
            {   // creating file in the folder /bin/debug
                using (StreamWriter streamWriter = new StreamWriter("grocerysales.csv"))
                {
                    // formatting the document
                    string header = string.Format("{0},{1},{2},{3},{4}", "ItemCode", "ItemName", "QtySold", "UnitPrice", "Sales");
                    streamWriter.WriteLine(header);

                    foreach (Grocery saleProd in SalesProductList)
                    {
                        if (saleProd.QuantityOnHand < saleProd.QtyMinForRestock)
                        {
                            // formattins using string format as usual
                            string line = string.Format("{0},{1},{2},{3},{4}", saleProd.ItemCode, saleProd.ItemName, 
                                saleProd.QtySold, saleProd.UnitPrice.ToString("C"), saleProd.TotalSales.ToString("C"));

                            streamWriter.WriteLine(line);
                            recordSaved += 1; //looping and count
                        }
                    }
                    StatusLabel.Text = "Saved " + recordSaved + "records into the grocerysales.csv file";
                }
            }
            catch (Exception ex)
            {   //exception
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveRestockNeedsReportButton_Click(object sender, EventArgs e)
        {            
                int numRecordSaved = 0; // variable created to display and accumulate of the number of qnt records saved
                try
                {
                    // creating file in the folder /bin/debug
                    using (StreamWriter streamWriter = new StreamWriter("groceryrestocks.csv"))
                    {
                        // header output file
                        string header = string.Format("{0},{1},{2},{3}", "ItemCode", "ItemName", "QtyMinForRestock", "QtyHand");
                        streamWriter.WriteLine(header);
                        foreach (Grocery saleProd in SalesProductList)
                        {
                            if (saleProd.QtySold > 0)
                            {
                                // formatting in string format
                                string row = string.Format("{0},{1},{2},{3}", saleProd.ItemCode, saleProd.ItemName,
                                    saleProd.QtyMinForRestock, saleProd.QuantityOnHand);

                                streamWriter.WriteLine(row);
                                numRecordSaved += 1;
                            }
                        }
                        StatusLabel.Text = "Saved " + numRecordSaved + "records into groceryrestocks.csv  file";
                    }
                }
                 catch (Exception ex)
                {                    
                    MessageBox.Show(ex.Message);//exception
                }
            }
        }
    }
    




