
namespace House_Rent_System
{
    partial class Main
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.renterButton = new System.Windows.Forms.Button();
            this.contractButton = new System.Windows.Forms.Button();
            this.roomButton = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MainPage = new System.Windows.Forms.TabPage();
            this.RoomPage = new System.Windows.Forms.TabPage();
            this.ContractPage = new System.Windows.Forms.TabPage();
            this.RenterPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.renterButton);
            this.splitContainer1.Panel1.Controls.Add(this.contractButton);
            this.splitContainer1.Panel1.Controls.Add(this.roomButton);
            this.splitContainer1.Panel1.Controls.Add(this.mainButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1398, 569);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "House Rent System";
            // 
            // renterButton
            // 
            this.renterButton.FlatAppearance.BorderSize = 0;
            this.renterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renterButton.Location = new System.Drawing.Point(0, 304);
            this.renterButton.Name = "renterButton";
            this.renterButton.Size = new System.Drawing.Size(252, 63);
            this.renterButton.TabIndex = 3;
            this.renterButton.Text = "Renter";
            this.renterButton.UseVisualStyleBackColor = true;
            this.renterButton.Click += new System.EventHandler(this.renterButton_Click);
            // 
            // contractButton
            // 
            this.contractButton.FlatAppearance.BorderSize = 0;
            this.contractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractButton.Location = new System.Drawing.Point(0, 235);
            this.contractButton.Name = "contractButton";
            this.contractButton.Size = new System.Drawing.Size(252, 63);
            this.contractButton.TabIndex = 2;
            this.contractButton.Text = "Contract";
            this.contractButton.UseVisualStyleBackColor = true;
            this.contractButton.Click += new System.EventHandler(this.contractButton_Click);
            // 
            // roomButton
            // 
            this.roomButton.FlatAppearance.BorderSize = 0;
            this.roomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomButton.Location = new System.Drawing.Point(0, 166);
            this.roomButton.Name = "roomButton";
            this.roomButton.Size = new System.Drawing.Size(252, 63);
            this.roomButton.TabIndex = 1;
            this.roomButton.Text = "Room";
            this.roomButton.UseVisualStyleBackColor = true;
            this.roomButton.Click += new System.EventHandler(this.roomButton_Click);
            // 
            // mainButton
            // 
            this.mainButton.FlatAppearance.BorderSize = 0;
            this.mainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.Location = new System.Drawing.Point(0, 97);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(252, 63);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Main";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.MainPage);
            this.tabControl1.Controls.Add(this.RoomPage);
            this.tabControl1.Controls.Add(this.ContractPage);
            this.tabControl1.Controls.Add(this.RenterPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1139, 569);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.MainPage.Location = new System.Drawing.Point(4, 25);
            this.MainPage.Name = "MainPage";
            this.MainPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainPage.Size = new System.Drawing.Size(1131, 540);
            this.MainPage.TabIndex = 0;
            this.MainPage.Text = "Main";
            this.MainPage.UseVisualStyleBackColor = true;
            // 
            // RoomPage
            // 
            this.RoomPage.Location = new System.Drawing.Point(4, 25);
            this.RoomPage.Name = "RoomPage";
            this.RoomPage.Padding = new System.Windows.Forms.Padding(3);
            this.RoomPage.Size = new System.Drawing.Size(1131, 540);
            this.RoomPage.TabIndex = 1;
            this.RoomPage.Text = "Room";
            this.RoomPage.UseVisualStyleBackColor = true;
            // 
            // ContractPage
            // 
            this.ContractPage.Location = new System.Drawing.Point(4, 25);
            this.ContractPage.Name = "ContractPage";
            this.ContractPage.Padding = new System.Windows.Forms.Padding(3);
            this.ContractPage.Size = new System.Drawing.Size(1131, 540);
            this.ContractPage.TabIndex = 2;
            this.ContractPage.Text = "Contract";
            this.ContractPage.UseVisualStyleBackColor = true;
            // 
            // RenterPage
            // 
            this.RenterPage.Location = new System.Drawing.Point(4, 25);
            this.RenterPage.Name = "RenterPage";
            this.RenterPage.Padding = new System.Windows.Forms.Padding(3);
            this.RenterPage.Size = new System.Drawing.Size(1131, 540);
            this.RenterPage.TabIndex = 3;
            this.RenterPage.Text = "Renter";
            this.RenterPage.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 569);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "Main";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button renterButton;
        private System.Windows.Forms.Button contractButton;
        private System.Windows.Forms.Button roomButton;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MainPage;
        private System.Windows.Forms.TabPage RoomPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage ContractPage;
        private System.Windows.Forms.TabPage RenterPage;
    }
}