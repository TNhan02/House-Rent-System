
namespace House_Rent_System
{
    partial class PrintBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintBill));
            this.printButton = new System.Windows.Forms.Button();
            this.printPDF = new System.Drawing.Printing.PrintDocument();
            this.printPreviewPDF = new System.Windows.Forms.PrintPreviewDialog();
            this.panelPrint = new System.Windows.Forms.Panel();
            this.SecurityCost = new System.Windows.Forms.Label();
            this.InternetCost = new System.Windows.Forms.Label();
            this.WaterCost = new System.Windows.Forms.Label();
            this.WaterPrice = new System.Windows.Forms.Label();
            this.WaterFigure = new System.Windows.Forms.Label();
            this.ElectricityCost = new System.Windows.Forms.Label();
            this.ElectricityPrice = new System.Windows.Forms.Label();
            this.ElectricFigure = new System.Windows.Forms.Label();
            this.Rent = new System.Windows.Forms.Label();
            this.Renter = new System.Windows.Forms.Label();
            this.Room = new System.Windows.Forms.Label();
            this.Period = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.panelPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(468, 18);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(95, 28);
            this.printButton.TabIndex = 29;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // printPDF
            // 
            this.printPDF.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewPDF
            // 
            this.printPreviewPDF.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewPDF.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewPDF.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewPDF.Enabled = true;
            this.printPreviewPDF.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewPDF.Icon")));
            this.printPreviewPDF.Name = "printPreviewPDF";
            this.printPreviewPDF.Visible = false;
            // 
            // panelPrint
            // 
            this.panelPrint.Controls.Add(this.SecurityCost);
            this.panelPrint.Controls.Add(this.InternetCost);
            this.panelPrint.Controls.Add(this.WaterCost);
            this.panelPrint.Controls.Add(this.WaterPrice);
            this.panelPrint.Controls.Add(this.WaterFigure);
            this.panelPrint.Controls.Add(this.ElectricityCost);
            this.panelPrint.Controls.Add(this.ElectricityPrice);
            this.panelPrint.Controls.Add(this.ElectricFigure);
            this.panelPrint.Controls.Add(this.Rent);
            this.panelPrint.Controls.Add(this.Renter);
            this.panelPrint.Controls.Add(this.Room);
            this.panelPrint.Controls.Add(this.Period);
            this.panelPrint.Controls.Add(this.label12);
            this.panelPrint.Controls.Add(this.label11);
            this.panelPrint.Controls.Add(this.label10);
            this.panelPrint.Controls.Add(this.label9);
            this.panelPrint.Controls.Add(this.label8);
            this.panelPrint.Controls.Add(this.label7);
            this.panelPrint.Controls.Add(this.label6);
            this.panelPrint.Controls.Add(this.label5);
            this.panelPrint.Controls.Add(this.Total);
            this.panelPrint.Controls.Add(this.label4);
            this.panelPrint.Controls.Add(this.label3);
            this.panelPrint.Controls.Add(this.label1);
            this.panelPrint.Controls.Add(this.label2);
            this.panelPrint.Controls.Add(this.Date);
            this.panelPrint.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPrint.Location = new System.Drawing.Point(0, 52);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(587, 485);
            this.panelPrint.TabIndex = 30;
            // 
            // SecurityCost
            // 
            this.SecurityCost.AutoSize = true;
            this.SecurityCost.Location = new System.Drawing.Point(141, 395);
            this.SecurityCost.Name = "SecurityCost";
            this.SecurityCost.Size = new System.Drawing.Size(123, 20);
            this.SecurityCost.TabIndex = 66;
            this.SecurityCost.Text = "Security Cost";
            // 
            // InternetCost
            // 
            this.InternetCost.AutoSize = true;
            this.InternetCost.Location = new System.Drawing.Point(141, 358);
            this.InternetCost.Name = "InternetCost";
            this.InternetCost.Size = new System.Drawing.Size(118, 20);
            this.InternetCost.TabIndex = 65;
            this.InternetCost.Text = "Internet Cost";
            // 
            // WaterCost
            // 
            this.WaterCost.AutoSize = true;
            this.WaterCost.Location = new System.Drawing.Point(424, 319);
            this.WaterCost.Name = "WaterCost";
            this.WaterCost.Size = new System.Drawing.Size(104, 20);
            this.WaterCost.TabIndex = 64;
            this.WaterCost.Text = "Water Cost";
            // 
            // WaterPrice
            // 
            this.WaterPrice.AutoSize = true;
            this.WaterPrice.Location = new System.Drawing.Point(268, 319);
            this.WaterPrice.Name = "WaterPrice";
            this.WaterPrice.Size = new System.Drawing.Size(109, 20);
            this.WaterPrice.TabIndex = 63;
            this.WaterPrice.Text = "Water Price";
            // 
            // WaterFigure
            // 
            this.WaterFigure.AutoSize = true;
            this.WaterFigure.Location = new System.Drawing.Point(141, 319);
            this.WaterFigure.Name = "WaterFigure";
            this.WaterFigure.Size = new System.Drawing.Size(59, 20);
            this.WaterFigure.TabIndex = 62;
            this.WaterFigure.Text = "Water";
            // 
            // ElectricityCost
            // 
            this.ElectricityCost.AutoSize = true;
            this.ElectricityCost.Location = new System.Drawing.Point(424, 285);
            this.ElectricityCost.Name = "ElectricityCost";
            this.ElectricityCost.Size = new System.Drawing.Size(139, 20);
            this.ElectricityCost.TabIndex = 61;
            this.ElectricityCost.Text = "Electricity Cost";
            // 
            // ElectricityPrice
            // 
            this.ElectricityPrice.AutoSize = true;
            this.ElectricityPrice.Location = new System.Drawing.Point(268, 285);
            this.ElectricityPrice.Name = "ElectricityPrice";
            this.ElectricityPrice.Size = new System.Drawing.Size(144, 20);
            this.ElectricityPrice.TabIndex = 60;
            this.ElectricityPrice.Text = "Electricity Price";
            // 
            // ElectricFigure
            // 
            this.ElectricFigure.AutoSize = true;
            this.ElectricFigure.Location = new System.Drawing.Point(141, 285);
            this.ElectricFigure.Name = "ElectricFigure";
            this.ElectricFigure.Size = new System.Drawing.Size(74, 20);
            this.ElectricFigure.TabIndex = 59;
            this.ElectricFigure.Text = "Electric";
            // 
            // Rent
            // 
            this.Rent.AutoSize = true;
            this.Rent.Location = new System.Drawing.Point(140, 249);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(48, 20);
            this.Rent.TabIndex = 58;
            this.Rent.Text = "Rent";
            // 
            // Renter
            // 
            this.Renter.AutoSize = true;
            this.Renter.Location = new System.Drawing.Point(140, 203);
            this.Renter.Name = "Renter";
            this.Renter.Size = new System.Drawing.Size(119, 20);
            this.Renter.TabIndex = 57;
            this.Renter.Text = "Renter Name";
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Location = new System.Drawing.Point(239, 154);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(128, 20);
            this.Room.TabIndex = 56;
            this.Room.Text = "Room Number";
            // 
            // Period
            // 
            this.Period.AutoSize = true;
            this.Period.Location = new System.Drawing.Point(239, 120);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(110, 20);
            this.Period.TabIndex = 55;
            this.Period.Text = "Period Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 395);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 44;
            this.label12.Text = "Security:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 358);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 43;
            this.label11.Text = "Internet:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 322);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Water:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 285);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Electricity:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 249);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Rent:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 203);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Renter:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 422);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(646, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "---------------------------------------------------------------------------------" +
    "----------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(646, 20);
            this.label5.TabIndex = 37;
            this.label5.Text = "---------------------------------------------------------------------------------" +
    "----------";
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(428, 445);
            this.Total.Margin = new System.Windows.Forms.Padding(4);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(136, 27);
            this.Total.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 487);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "TOTAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Room:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Period:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Rental Bill";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(13, 27);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(49, 20);
            this.Date.TabIndex = 29;
            this.Date.Text = "Date";
            // 
            // PrintBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 537);
            this.Controls.Add(this.panelPrint);
            this.Controls.Add(this.printButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintBill";
            this.Text = "PrintBill";
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button printButton;
        private System.Drawing.Printing.PrintDocument printPDF;
        private System.Windows.Forms.PrintPreviewDialog printPreviewPDF;
        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label Date;
        public System.Windows.Forms.Label Period;
        public System.Windows.Forms.Label Room;
        public System.Windows.Forms.Label Renter;
        public System.Windows.Forms.Label Rent;
        public System.Windows.Forms.Label ElectricFigure;
        public System.Windows.Forms.Label ElectricityCost;
        public System.Windows.Forms.Label ElectricityPrice;
        public System.Windows.Forms.Label SecurityCost;
        public System.Windows.Forms.Label InternetCost;
        public System.Windows.Forms.Label WaterCost;
        public System.Windows.Forms.Label WaterPrice;
        public System.Windows.Forms.Label WaterFigure;
    }
}