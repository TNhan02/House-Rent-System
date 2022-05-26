
namespace House_Rent_System
{
    partial class deleteButton
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
            this.RenterTable = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addRoom = new System.Windows.Forms.TextBox();
            this.addOrigin = new System.Windows.Forms.TextBox();
            this.addPhone = new System.Windows.Forms.TextBox();
            this.addName = new System.Windows.Forms.TextBox();
            this.addID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.searchID = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RenterTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RenterTable
            // 
            this.RenterTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RenterTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RenterTable.Location = new System.Drawing.Point(334, 69);
            this.RenterTable.Name = "RenterTable";
            this.RenterTable.RowHeadersWidth = 51;
            this.RenterTable.RowTemplate.Height = 24;
            this.RenterTable.Size = new System.Drawing.Size(739, 451);
            this.RenterTable.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addRoom);
            this.groupBox1.Controls.Add(this.addOrigin);
            this.groupBox1.Controls.Add(this.addPhone);
            this.groupBox1.Controls.Add(this.addName);
            this.groupBox1.Controls.Add(this.addID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
            // 
            // addRoom
            // 
            this.addRoom.Location = new System.Drawing.Point(111, 182);
            this.addRoom.Name = "addRoom";
            this.addRoom.Size = new System.Drawing.Size(143, 22);
            this.addRoom.TabIndex = 9;
            // 
            // addOrigin
            // 
            this.addOrigin.Location = new System.Drawing.Point(111, 143);
            this.addOrigin.Name = "addOrigin";
            this.addOrigin.Size = new System.Drawing.Size(143, 22);
            this.addOrigin.TabIndex = 8;
            // 
            // addPhone
            // 
            this.addPhone.Location = new System.Drawing.Point(111, 104);
            this.addPhone.Name = "addPhone";
            this.addPhone.Size = new System.Drawing.Size(143, 22);
            this.addPhone.TabIndex = 7;
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(110, 69);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(144, 22);
            this.addName.TabIndex = 6;
            // 
            // addID
            // 
            this.addID.Location = new System.Drawing.Point(111, 33);
            this.addID.Name = "addID";
            this.addID.Size = new System.Drawing.Size(143, 22);
            this.addID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Place of Origin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Number";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(112, 305);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(93, 33);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID Number";
            // 
            // searchID
            // 
            this.searchID.Location = new System.Drawing.Point(426, 37);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(168, 22);
            this.searchID.TabIndex = 4;
            this.searchID.TextChanged += new System.EventHandler(this.searchID_TextChanged);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(939, 32);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(131, 33);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // deleteButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 558);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RenterTable);
            this.Name = "deleteButton";
            this.Text = "RenterPage";
            ((System.ComponentModel.ISupportInitialize)(this.RenterTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RenterTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addRoom;
        private System.Windows.Forms.TextBox addOrigin;
        private System.Windows.Forms.TextBox addPhone;
        private System.Windows.Forms.TextBox addID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchID;
        private System.Windows.Forms.Button delete;
    }
}