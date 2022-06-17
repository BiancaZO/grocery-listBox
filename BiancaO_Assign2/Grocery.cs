using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiancaO_Assign2
{
    class Grocery
    { // Read-write auto-property
        public string ItemName
        {
            get;
            set;
        }

        public string ItemCode
        {
            get;
            set;
        }

        public int StartingQty
        {
            get;
            set;
        }

        public int QtyMinForRestock
        {
            get;
            set;
        }

        public int QtySold
        {
            get;
            set;
        }

        public int QtyRestocked
        {
            get;
            set;
        }

        public double UnitPrice
        {
            get;
            set;
        }
        // read-only properties
        public int QuantityOnHand
        {
            get
            {
                return StartingQty - QtySold + QtyRestocked;
            }
        }


        public double TotalSales
        {
            get
            {
                return QtySold * UnitPrice;
            }
        }
        // constructor
        public Grocery( string itemName, string itemCode, double unitPrice, int startingQty, int qtyMinForRestock, int qtysold, int qtyRestocked)
        {
            ItemName = itemName;
            ItemCode = itemCode;  
            UnitPrice = unitPrice;
            StartingQty = startingQty;
            QtyMinForRestock = qtyMinForRestock;
            QtySold = qtysold;
            QtyRestocked = qtyRestocked;            
        }
        public override string ToString()
        {
            return string.Format("{0,-16}\t{1,-14}\t{2,-10:C}\t{3,-10}\t{4,-10}\t{5,-10}\t{6,-8}\t{7,-10}\t{8:C}",
                                 ItemName,
                                 ItemCode,
                                 UnitPrice,
                                 StartingQty,
                                 QtyMinForRestock,
                                 QtySold,
                                 QtyRestocked,                                 
                                 QuantityOnHand,
                                 TotalSales);
        }
    }
}

