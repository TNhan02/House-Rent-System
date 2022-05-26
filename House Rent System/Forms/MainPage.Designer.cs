
namespace House_Rent_System
{
    partial class MainPage
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
            this.contractButton = new System.Windows.Forms.Button();
            this.renterButton = new System.Windows.Forms.Button();
            this.roomsButton = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.renterPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.roomsPage = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.contractPage = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.renterPage.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.contractButton);
            this.splitContainer1.Panel1.Controls.Add(this.mainButton);
            this.splitContainer1.Panel1.Controls.Add(this.renterButton);
            this.splitContainer1.Panel1.Controls.Add(this.roomsButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.renterPage);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(1084, 548);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "House Rent System";
            // 
            // contractButton
            // 
            this.contractButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contractButton.FlatAppearance.BorderSize = 0;
            this.contractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractButton.Location = new System.Drawing.Point(0, 276);
            this.contractButton.Name = "contractButton";
            this.contractButton.Size = new System.Drawing.Size(241, 66);
            this.contractButton.TabIndex = 3;
            this.contractButton.Text = "Contract";
            this.contractButton.UseVisualStyleBackColor = false;
            // 
            // renterButton
            // 
            this.renterButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.renterButton.FlatAppearance.BorderSize = 0;
            this.renterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.renterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renterButton.Location = new System.Drawing.Point(1, 213);
            this.renterButton.Name = "renterButton";
            this.renterButton.Size = new System.Drawing.Size(240, 66);
            this.renterButton.TabIndex = 2;
            this.renterButton.Text = "Renter";
            this.renterButton.UseVisualStyleBackColor = false;
            // 
            // roomsButton
            // 
            this.roomsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.roomsButton.FlatAppearance.BorderSize = 0;
            this.roomsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsButton.Location = new System.Drawing.Point(1, 151);
            this.roomsButton.Name = "roomsButton";
            this.roomsButton.Size = new System.Drawing.Size(240, 66);
            this.roomsButton.TabIndex = 1;
            this.roomsButton.Text = "Rooms";
            this.roomsButton.UseVisualStyleBackColor = false;
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainButton.FlatAppearance.BorderSize = 0;
            this.mainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainButton.Location = new System.Drawing.Point(1, 90);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(240, 66);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Main";
            this.mainButton.UseVisualStyleBackColor = false;
            // 
            // renterPage
            // 
            this.renterPage.Controls.Add(this.tabPage1);
            this.renterPage.Controls.Add(this.roomsPage);
            this.renterPage.Controls.Add(this.tabPage3);
            this.renterPage.Controls.Add(this.contractPage);
            this.renterPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.renterPage.Location = new System.Drawing.Point(0, 0);
            this.renterPage.Name = "renterPage";
            this.renterPage.SelectedIndex = 0;
            this.renterPage.Size = new System.Drawing.Size(836, 548);
            this.renterPage.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(828, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // roomsPage
            // 
            this.roomsPage.Location = new System.Drawing.Point(4, 25);
            this.roomsPage.Name = "roomsPage";
            this.roomsPage.Padding = new System.Windows.Forms.Padding(3);
            this.roomsPage.Size = new System.Drawing.Size(828, 516);
            this.roomsPage.TabIndex = 1;
            this.roomsPage.Text = "Rooms";
            this.roomsPage.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(828, 516);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Renter";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // contractPage
            // 
            this.contractPage.Location = new System.Drawing.Point(4, 25);
            this.contractPage.Name = "contractPage";
            this.contractPage.Padding = new System.Windows.Forms.Padding(3);
            this.contractPage.Size = new System.Drawing.Size(828, 516);
            this.contractPage.TabIndex = 3;
            this.contractPage.Text = "Contract";
            this.contractPage.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 548);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainPage";
            this.Text = "Main Page";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.renterPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button contractButton;
        private System.Windows.Forms.Button renterButton;
        private System.Windows.Forms.Button roomsButton;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.TabControl renterPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage roomsPage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage contractPage;
    }
}

