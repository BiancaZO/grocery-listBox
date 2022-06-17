
namespace BiancaO_Assign2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groceryListBox = new System.Windows.Forms.ListBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.loadingDataGroupBox = new System.Windows.Forms.GroupBox();
            this.LoadingDataButton = new System.Windows.Forms.Button();
            this.updateDataGroupBox = new System.Windows.Forms.GroupBox();
            this.qtyRestockedTextBox = new System.Windows.Forms.TextBox();
            this.qtyRestockedLabel = new System.Windows.Forms.Label();
            this.qtySoldLabel = new System.Windows.Forms.Label();
            this.qtySoldTextBox = new System.Windows.Forms.TextBox();
            this.UpdateQtyRestokedButton = new System.Windows.Forms.Button();
            this.UpdateQtySoldButton = new System.Windows.Forms.Button();
            this.DeleteSelectedItemButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.saveDataGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveRestockNeedsReportButton = new System.Windows.Forms.Button();
            this.SaveSalesReportButton = new System.Windows.Forms.Button();
            this.SaveGroceryDataButton = new System.Windows.Forms.Button();
            this.loadingDataGroupBox.SuspendLayout();
            this.updateDataGroupBox.SuspendLayout();
            this.saveDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groceryListBox
            // 
            this.groceryListBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groceryListBox.FormattingEnabled = true;
            this.groceryListBox.ItemHeight = 19;
            this.groceryListBox.Location = new System.Drawing.Point(13, 131);
            this.groceryListBox.Margin = new System.Windows.Forms.Padding(4);
            this.groceryListBox.Name = "groceryListBox";
            this.groceryListBox.Size = new System.Drawing.Size(1623, 270);
            this.groceryListBox.TabIndex = 2;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(542, 29);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(531, 76);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Grocery Application";
            // 
            // loadingDataGroupBox
            // 
            this.loadingDataGroupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.loadingDataGroupBox.Controls.Add(this.LoadingDataButton);
            this.loadingDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingDataGroupBox.Location = new System.Drawing.Point(176, 429);
            this.loadingDataGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.loadingDataGroupBox.Name = "loadingDataGroupBox";
            this.loadingDataGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.loadingDataGroupBox.Size = new System.Drawing.Size(217, 153);
            this.loadingDataGroupBox.TabIndex = 4;
            this.loadingDataGroupBox.TabStop = false;
            this.loadingDataGroupBox.Text = "Loading Data";
            // 
            // LoadingDataButton
            // 
            this.LoadingDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LoadingDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadingDataButton.Location = new System.Drawing.Point(25, 49);
            this.LoadingDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadingDataButton.Name = "LoadingDataButton";
            this.LoadingDataButton.Size = new System.Drawing.Size(168, 68);
            this.LoadingDataButton.TabIndex = 0;
            this.LoadingDataButton.Text = "Load Grocery Data";
            this.LoadingDataButton.UseVisualStyleBackColor = false;
            this.LoadingDataButton.Click += new System.EventHandler(this.LoadingDataButton_Click);
            // 
            // updateDataGroupBox
            // 
            this.updateDataGroupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.updateDataGroupBox.Controls.Add(this.qtyRestockedTextBox);
            this.updateDataGroupBox.Controls.Add(this.qtyRestockedLabel);
            this.updateDataGroupBox.Controls.Add(this.qtySoldLabel);
            this.updateDataGroupBox.Controls.Add(this.qtySoldTextBox);
            this.updateDataGroupBox.Controls.Add(this.UpdateQtyRestokedButton);
            this.updateDataGroupBox.Controls.Add(this.UpdateQtySoldButton);
            this.updateDataGroupBox.Controls.Add(this.DeleteSelectedItemButton);
            this.updateDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDataGroupBox.Location = new System.Drawing.Point(452, 429);
            this.updateDataGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.updateDataGroupBox.Name = "updateDataGroupBox";
            this.updateDataGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.updateDataGroupBox.Size = new System.Drawing.Size(703, 180);
            this.updateDataGroupBox.TabIndex = 5;
            this.updateDataGroupBox.TabStop = false;
            this.updateDataGroupBox.Text = "Update Data";
            // 
            // qtyRestockedTextBox
            // 
            this.qtyRestockedTextBox.Location = new System.Drawing.Point(543, 39);
            this.qtyRestockedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.qtyRestockedTextBox.Name = "qtyRestockedTextBox";
            this.qtyRestockedTextBox.Size = new System.Drawing.Size(151, 26);
            this.qtyRestockedTextBox.TabIndex = 8;
            // 
            // qtyRestockedLabel
            // 
            this.qtyRestockedLabel.AutoSize = true;
            this.qtyRestockedLabel.Location = new System.Drawing.Point(353, 43);
            this.qtyRestockedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qtyRestockedLabel.Name = "qtyRestockedLabel";
            this.qtyRestockedLabel.Size = new System.Drawing.Size(160, 20);
            this.qtyRestockedLabel.TabIndex = 7;
            this.qtyRestockedLabel.Text = "Quantity Restocked:";
            // 
            // qtySoldLabel
            // 
            this.qtySoldLabel.AutoSize = true;
            this.qtySoldLabel.Location = new System.Drawing.Point(9, 43);
            this.qtySoldLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qtySoldLabel.Name = "qtySoldLabel";
            this.qtySoldLabel.Size = new System.Drawing.Size(114, 20);
            this.qtySoldLabel.TabIndex = 6;
            this.qtySoldLabel.Text = "Quantity Sold:";
            // 
            // qtySoldTextBox
            // 
            this.qtySoldTextBox.Location = new System.Drawing.Point(147, 39);
            this.qtySoldTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.qtySoldTextBox.Name = "qtySoldTextBox";
            this.qtySoldTextBox.Size = new System.Drawing.Size(188, 26);
            this.qtySoldTextBox.TabIndex = 5;
            // 
            // UpdateQtyRestokedButton
            // 
            this.UpdateQtyRestokedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UpdateQtyRestokedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateQtyRestokedButton.Location = new System.Drawing.Point(357, 81);
            this.UpdateQtyRestokedButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateQtyRestokedButton.Name = "UpdateQtyRestokedButton";
            this.UpdateQtyRestokedButton.Size = new System.Drawing.Size(337, 42);
            this.UpdateQtyRestokedButton.TabIndex = 4;
            this.UpdateQtyRestokedButton.Text = "Update Restocked Qty For Selected Item";
            this.UpdateQtyRestokedButton.UseVisualStyleBackColor = false;
            this.UpdateQtyRestokedButton.Click += new System.EventHandler(this.UpdateQtyRestokedButton_Click);
            // 
            // UpdateQtySoldButton
            // 
            this.UpdateQtySoldButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UpdateQtySoldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateQtySoldButton.Location = new System.Drawing.Point(8, 81);
            this.UpdateQtySoldButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateQtySoldButton.Name = "UpdateQtySoldButton";
            this.UpdateQtySoldButton.Size = new System.Drawing.Size(328, 42);
            this.UpdateQtySoldButton.TabIndex = 3;
            this.UpdateQtySoldButton.Text = "Update Sold Qty For Selected Item";
            this.UpdateQtySoldButton.UseVisualStyleBackColor = false;
            this.UpdateQtySoldButton.Click += new System.EventHandler(this.UpdateQtySoldButton_Click);
            // 
            // DeleteSelectedItemButton
            // 
            this.DeleteSelectedItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DeleteSelectedItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSelectedItemButton.Location = new System.Drawing.Point(185, 130);
            this.DeleteSelectedItemButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteSelectedItemButton.Name = "DeleteSelectedItemButton";
            this.DeleteSelectedItemButton.Size = new System.Drawing.Size(328, 42);
            this.DeleteSelectedItemButton.TabIndex = 1;
            this.DeleteSelectedItemButton.Text = "Delete Selected Grocery Item";
            this.DeleteSelectedItemButton.UseVisualStyleBackColor = false;
            this.DeleteSelectedItemButton.Click += new System.EventHandler(this.DeleteSelectedItemButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(380, 654);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.StatusLabel.Size = new System.Drawing.Size(841, 87);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Operation Status Update Displayed Here";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveDataGroupBox
            // 
            this.saveDataGroupBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.saveDataGroupBox.Controls.Add(this.SaveRestockNeedsReportButton);
            this.saveDataGroupBox.Controls.Add(this.SaveSalesReportButton);
            this.saveDataGroupBox.Controls.Add(this.SaveGroceryDataButton);
            this.saveDataGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataGroupBox.Location = new System.Drawing.Point(1207, 429);
            this.saveDataGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.saveDataGroupBox.Name = "saveDataGroupBox";
            this.saveDataGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.saveDataGroupBox.Size = new System.Drawing.Size(236, 180);
            this.saveDataGroupBox.TabIndex = 7;
            this.saveDataGroupBox.TabStop = false;
            this.saveDataGroupBox.Text = "Saving Data";
            // 
            // SaveRestockNeedsReportButton
            // 
            this.SaveRestockNeedsReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveRestockNeedsReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveRestockNeedsReportButton.Location = new System.Drawing.Point(8, 134);
            this.SaveRestockNeedsReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveRestockNeedsReportButton.Name = "SaveRestockNeedsReportButton";
            this.SaveRestockNeedsReportButton.Size = new System.Drawing.Size(220, 38);
            this.SaveRestockNeedsReportButton.TabIndex = 7;
            this.SaveRestockNeedsReportButton.Text = "Save Restock Needs Report";
            this.SaveRestockNeedsReportButton.UseVisualStyleBackColor = false;
            this.SaveRestockNeedsReportButton.Click += new System.EventHandler(this.SaveRestockNeedsReportButton_Click);
            // 
            // SaveSalesReportButton
            // 
            this.SaveSalesReportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveSalesReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSalesReportButton.Location = new System.Drawing.Point(8, 90);
            this.SaveSalesReportButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveSalesReportButton.Name = "SaveSalesReportButton";
            this.SaveSalesReportButton.Size = new System.Drawing.Size(220, 34);
            this.SaveSalesReportButton.TabIndex = 6;
            this.SaveSalesReportButton.Text = "Save Sales Report";
            this.SaveSalesReportButton.UseVisualStyleBackColor = false;
            this.SaveSalesReportButton.Click += new System.EventHandler(this.SaveSalesReportButton_Click);
            // 
            // SaveGroceryDataButton
            // 
            this.SaveGroceryDataButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SaveGroceryDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveGroceryDataButton.Location = new System.Drawing.Point(8, 43);
            this.SaveGroceryDataButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveGroceryDataButton.Name = "SaveGroceryDataButton";
            this.SaveGroceryDataButton.Size = new System.Drawing.Size(220, 34);
            this.SaveGroceryDataButton.TabIndex = 5;
            this.SaveGroceryDataButton.Text = "Save Grocery Data";
            this.SaveGroceryDataButton.UseVisualStyleBackColor = false;
            this.SaveGroceryDataButton.Click += new System.EventHandler(this.SaveGroceryDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1649, 821);
            this.Controls.Add(this.saveDataGroupBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.updateDataGroupBox);
            this.Controls.Add(this.loadingDataGroupBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.groceryListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loadingDataGroupBox.ResumeLayout(false);
            this.updateDataGroupBox.ResumeLayout(false);
            this.updateDataGroupBox.PerformLayout();
            this.saveDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox groceryListBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox loadingDataGroupBox;
        private System.Windows.Forms.Button LoadingDataButton;
        private System.Windows.Forms.GroupBox updateDataGroupBox;
        private System.Windows.Forms.TextBox qtyRestockedTextBox;
        private System.Windows.Forms.Label qtyRestockedLabel;
        private System.Windows.Forms.Label qtySoldLabel;
        private System.Windows.Forms.TextBox qtySoldTextBox;
        private System.Windows.Forms.Button UpdateQtyRestokedButton;
        private System.Windows.Forms.Button UpdateQtySoldButton;
        private System.Windows.Forms.Button DeleteSelectedItemButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.GroupBox saveDataGroupBox;
        private System.Windows.Forms.Button SaveRestockNeedsReportButton;
        private System.Windows.Forms.Button SaveSalesReportButton;
        private System.Windows.Forms.Button SaveGroceryDataButton;
    }
}

