namespace DeanM_Assign2
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
            this.loadData = new System.Windows.Forms.GroupBox();
            this.readRetailStockData = new System.Windows.Forms.Button();
            this.updateData = new System.Windows.Forms.GroupBox();
            this.soldQtyTextBox = new System.Windows.Forms.TextBox();
            this.restockedQtyTextBox = new System.Windows.Forms.TextBox();
            this.updateSoldQtyForSelectedItem = new System.Windows.Forms.Button();
            this.restockedQunatity = new System.Windows.Forms.Label();
            this.soldQuantity = new System.Windows.Forms.Label();
            this.sortByDescendingOrderOfSales = new System.Windows.Forms.Button();
            this.updateRestockedQtyForSelectedItem = new System.Windows.Forms.Button();
            this.deleteSelectedRetailItem = new System.Windows.Forms.Button();
            this.saveData = new System.Windows.Forms.GroupBox();
            this.createRestockNeedsReport = new System.Windows.Forms.Button();
            this.createSalesReport = new System.Windows.Forms.Button();
            this.saveRetailStockData = new System.Windows.Forms.Button();
            this.retailStockListBox = new System.Windows.Forms.ListBox();
            this.title = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.loadData.SuspendLayout();
            this.updateData.SuspendLayout();
            this.saveData.SuspendLayout();
            this.SuspendLayout();
            // 
            // loadData
            // 
            this.loadData.BackColor = System.Drawing.Color.LightBlue;
            this.loadData.Controls.Add(this.readRetailStockData);
            this.loadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadData.Location = new System.Drawing.Point(12, 343);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(299, 190);
            this.loadData.TabIndex = 0;
            this.loadData.TabStop = false;
            this.loadData.Text = "Load Data";
            // 
            // readRetailStockData
            // 
            this.readRetailStockData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readRetailStockData.Location = new System.Drawing.Point(7, 54);
            this.readRetailStockData.Name = "readRetailStockData";
            this.readRetailStockData.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.readRetailStockData.Size = new System.Drawing.Size(286, 88);
            this.readRetailStockData.TabIndex = 7;
            this.readRetailStockData.Text = "Read Retail Stock Data";
            this.readRetailStockData.UseVisualStyleBackColor = true;
            this.readRetailStockData.Click += new System.EventHandler(this.readRetailStockData_Click);
            // 
            // updateData
            // 
            this.updateData.BackColor = System.Drawing.Color.LightBlue;
            this.updateData.Controls.Add(this.soldQtyTextBox);
            this.updateData.Controls.Add(this.restockedQtyTextBox);
            this.updateData.Controls.Add(this.updateSoldQtyForSelectedItem);
            this.updateData.Controls.Add(this.restockedQunatity);
            this.updateData.Controls.Add(this.soldQuantity);
            this.updateData.Controls.Add(this.sortByDescendingOrderOfSales);
            this.updateData.Controls.Add(this.updateRestockedQtyForSelectedItem);
            this.updateData.Controls.Add(this.deleteSelectedRetailItem);
            this.updateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateData.Location = new System.Drawing.Point(317, 343);
            this.updateData.Name = "updateData";
            this.updateData.Size = new System.Drawing.Size(646, 190);
            this.updateData.TabIndex = 0;
            this.updateData.TabStop = false;
            this.updateData.Text = "Update Data";
            // 
            // soldQtyTextBox
            // 
            this.soldQtyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldQtyTextBox.Location = new System.Drawing.Point(221, 20);
            this.soldQtyTextBox.Name = "soldQtyTextBox";
            this.soldQtyTextBox.Size = new System.Drawing.Size(99, 24);
            this.soldQtyTextBox.TabIndex = 16;
            this.soldQtyTextBox.TextChanged += new System.EventHandler(this.soldQtyTextBox_TextChanged);
            // 
            // restockedQtyTextBox
            // 
            this.restockedQtyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockedQtyTextBox.Location = new System.Drawing.Point(549, 20);
            this.restockedQtyTextBox.Name = "restockedQtyTextBox";
            this.restockedQtyTextBox.Size = new System.Drawing.Size(88, 24);
            this.restockedQtyTextBox.TabIndex = 15;
            // 
            // updateSoldQtyForSelectedItem
            // 
            this.updateSoldQtyForSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateSoldQtyForSelectedItem.Location = new System.Drawing.Point(6, 50);
            this.updateSoldQtyForSelectedItem.Name = "updateSoldQtyForSelectedItem";
            this.updateSoldQtyForSelectedItem.Size = new System.Drawing.Size(314, 59);
            this.updateSoldQtyForSelectedItem.TabIndex = 8;
            this.updateSoldQtyForSelectedItem.Text = "Update Sold Quantity For Selected Item";
            this.updateSoldQtyForSelectedItem.UseVisualStyleBackColor = true;
            this.updateSoldQtyForSelectedItem.Click += new System.EventHandler(this.updateSoldQtyForSelectedItem_Click);
            // 
            // restockedQunatity
            // 
            this.restockedQunatity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restockedQunatity.Location = new System.Drawing.Point(385, 23);
            this.restockedQunatity.Name = "restockedQunatity";
            this.restockedQunatity.Size = new System.Drawing.Size(158, 23);
            this.restockedQunatity.TabIndex = 11;
            this.restockedQunatity.Text = "Restocked Quantity:";
            // 
            // soldQuantity
            // 
            this.soldQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldQuantity.Location = new System.Drawing.Point(87, 23);
            this.soldQuantity.Name = "soldQuantity";
            this.soldQuantity.Size = new System.Drawing.Size(128, 21);
            this.soldQuantity.TabIndex = 7;
            this.soldQuantity.Text = "Sold Quantity: ";
            // 
            // sortByDescendingOrderOfSales
            // 
            this.sortByDescendingOrderOfSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortByDescendingOrderOfSales.Location = new System.Drawing.Point(326, 113);
            this.sortByDescendingOrderOfSales.Name = "sortByDescendingOrderOfSales";
            this.sortByDescendingOrderOfSales.Size = new System.Drawing.Size(311, 60);
            this.sortByDescendingOrderOfSales.TabIndex = 3;
            this.sortByDescendingOrderOfSales.Text = "Sort By Descending Order of Sales";
            this.sortByDescendingOrderOfSales.UseVisualStyleBackColor = true;
            this.sortByDescendingOrderOfSales.Click += new System.EventHandler(this.sortByDescendingOrderOfSales_Click);
            // 
            // updateRestockedQtyForSelectedItem
            // 
            this.updateRestockedQtyForSelectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateRestockedQtyForSelectedItem.Location = new System.Drawing.Point(326, 50);
            this.updateRestockedQtyForSelectedItem.Name = "updateRestockedQtyForSelectedItem";
            this.updateRestockedQtyForSelectedItem.Size = new System.Drawing.Size(311, 57);
            this.updateRestockedQtyForSelectedItem.TabIndex = 4;
            this.updateRestockedQtyForSelectedItem.Text = "Update Restocked Quantity For Selected Item";
            this.updateRestockedQtyForSelectedItem.UseVisualStyleBackColor = true;
            this.updateRestockedQtyForSelectedItem.Click += new System.EventHandler(this.updateRestockedQtyForSelectedItem_Click);
            // 
            // deleteSelectedRetailItem
            // 
            this.deleteSelectedRetailItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedRetailItem.Location = new System.Drawing.Point(6, 113);
            this.deleteSelectedRetailItem.Name = "deleteSelectedRetailItem";
            this.deleteSelectedRetailItem.Size = new System.Drawing.Size(314, 60);
            this.deleteSelectedRetailItem.TabIndex = 6;
            this.deleteSelectedRetailItem.Text = "Delete Selected Retail Item";
            this.deleteSelectedRetailItem.UseVisualStyleBackColor = true;
            this.deleteSelectedRetailItem.Click += new System.EventHandler(this.deleteSelectedRetailItem_Click);
            // 
            // saveData
            // 
            this.saveData.BackColor = System.Drawing.Color.LightBlue;
            this.saveData.Controls.Add(this.createRestockNeedsReport);
            this.saveData.Controls.Add(this.createSalesReport);
            this.saveData.Controls.Add(this.saveRetailStockData);
            this.saveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveData.Location = new System.Drawing.Point(969, 343);
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(297, 190);
            this.saveData.TabIndex = 0;
            this.saveData.TabStop = false;
            this.saveData.Text = "Save Data";
            this.saveData.Enter += new System.EventHandler(this.saveData_Enter);
            // 
            // createRestockNeedsReport
            // 
            this.createRestockNeedsReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createRestockNeedsReport.Location = new System.Drawing.Point(7, 133);
            this.createRestockNeedsReport.Name = "createRestockNeedsReport";
            this.createRestockNeedsReport.Size = new System.Drawing.Size(284, 46);
            this.createRestockNeedsReport.TabIndex = 2;
            this.createRestockNeedsReport.Text = "Create Restock Needs Report";
            this.createRestockNeedsReport.UseVisualStyleBackColor = true;
            this.createRestockNeedsReport.Click += new System.EventHandler(this.createRestockNeedsReport_Click);
            // 
            // createSalesReport
            // 
            this.createSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSalesReport.Location = new System.Drawing.Point(7, 80);
            this.createSalesReport.Name = "createSalesReport";
            this.createSalesReport.Size = new System.Drawing.Size(284, 47);
            this.createSalesReport.TabIndex = 1;
            this.createSalesReport.Text = "Create Sales Report";
            this.createSalesReport.UseVisualStyleBackColor = true;
            this.createSalesReport.Click += new System.EventHandler(this.createSalesReport_Click);
            // 
            // saveRetailStockData
            // 
            this.saveRetailStockData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRetailStockData.Location = new System.Drawing.Point(7, 26);
            this.saveRetailStockData.Name = "saveRetailStockData";
            this.saveRetailStockData.Size = new System.Drawing.Size(284, 48);
            this.saveRetailStockData.TabIndex = 0;
            this.saveRetailStockData.Text = "Save Retail Stock Data";
            this.saveRetailStockData.UseVisualStyleBackColor = true;
            this.saveRetailStockData.Click += new System.EventHandler(this.saveRetailStockData_Click);
            // 
            // retailStockListBox
            // 
            this.retailStockListBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retailStockListBox.FormattingEnabled = true;
            this.retailStockListBox.ItemHeight = 18;
            this.retailStockListBox.Location = new System.Drawing.Point(12, 63);
            this.retailStockListBox.Name = "retailStockListBox";
            this.retailStockListBox.Size = new System.Drawing.Size(1254, 274);
            this.retailStockListBox.TabIndex = 0;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(387, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(508, 51);
            this.title.TabIndex = 10;
            this.title.Text = "Retail Stock Application";
            this.title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.LightBlue;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(12, 536);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(1254, 71);
            this.statusLabel.TabIndex = 17;
            this.statusLabel.Text = "Status Label";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1278, 631);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.retailStockListBox);
            this.Controls.Add(this.updateData);
            this.Controls.Add(this.saveData);
            this.Controls.Add(this.loadData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loadData.ResumeLayout(false);
            this.updateData.ResumeLayout(false);
            this.updateData.PerformLayout();
            this.saveData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox loadData;
        private System.Windows.Forms.GroupBox updateData;
        private System.Windows.Forms.GroupBox saveData;
        private System.Windows.Forms.ListBox retailStockListBox;
        private System.Windows.Forms.Button readRetailStockData;
        private System.Windows.Forms.Button sortByDescendingOrderOfSales;
        private System.Windows.Forms.Button updateRestockedQtyForSelectedItem;
        private System.Windows.Forms.Button deleteSelectedRetailItem;
        private System.Windows.Forms.Button createRestockNeedsReport;
        private System.Windows.Forms.Button createSalesReport;
        private System.Windows.Forms.Button saveRetailStockData;
        private System.Windows.Forms.Label soldQuantity;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label restockedQunatity;
        private System.Windows.Forms.Button updateSoldQtyForSelectedItem;
        private System.Windows.Forms.TextBox restockedQtyTextBox;
        private System.Windows.Forms.TextBox soldQtyTextBox;
        private System.Windows.Forms.Label statusLabel;
    }
}

