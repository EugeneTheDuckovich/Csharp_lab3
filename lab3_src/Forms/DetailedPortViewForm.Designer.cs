namespace lab3_src.Forms
{
    partial class DetailedPortViewForm
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
            this.DocksList = new System.Windows.Forms.ListView();
            this.WorkersList = new System.Windows.Forms.ListView();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.DocksLabel = new System.Windows.Forms.Label();
            this.WorkersLabel = new System.Windows.Forms.Label();
            this.DocksCountLabel = new System.Windows.Forms.Label();
            this.WorkersCountLabel = new System.Windows.Forms.Label();
            this.DocksCountText = new System.Windows.Forms.TextBox();
            this.WorkersCountText = new System.Windows.Forms.TextBox();
            this.AddDockButton = new System.Windows.Forms.Button();
            this.AddMachineButton = new System.Windows.Forms.Button();
            this.HireButton = new System.Windows.Forms.Button();
            this.FireButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ServiceButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ServicePriceText = new System.Windows.Forms.TextBox();
            this.ServiceTimeText = new System.Windows.Forms.TextBox();
            this.ShipsAmountText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.MachinesCountText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MachinesList = new System.Windows.Forms.ListView();
            this.WorkerDetails = new System.Windows.Forms.Button();
            this.DockDetails = new System.Windows.Forms.Button();
            this.MachineDetails = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DocksList
            // 
            this.DocksList.Location = new System.Drawing.Point(169, 95);
            this.DocksList.Name = "DocksList";
            this.DocksList.Size = new System.Drawing.Size(151, 204);
            this.DocksList.TabIndex = 0;
            this.DocksList.UseCompatibleStateImageBehavior = false;
            this.DocksList.View = System.Windows.Forms.View.List;
            // 
            // WorkersList
            // 
            this.WorkersList.Location = new System.Drawing.Point(12, 95);
            this.WorkersList.Name = "WorkersList";
            this.WorkersList.Size = new System.Drawing.Size(151, 204);
            this.WorkersList.TabIndex = 1;
            this.WorkersList.UseCompatibleStateImageBehavior = false;
            this.WorkersList.View = System.Windows.Forms.View.List;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(169, 9);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(65, 20);
            this.AddressLabel.TabIndex = 3;
            this.AddressLabel.Text = "Address:";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(12, 32);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(151, 27);
            this.NameText.TabIndex = 4;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(169, 32);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(151, 27);
            this.AddressText.TabIndex = 5;
            // 
            // DocksLabel
            // 
            this.DocksLabel.AutoSize = true;
            this.DocksLabel.Location = new System.Drawing.Point(169, 72);
            this.DocksLabel.Name = "DocksLabel";
            this.DocksLabel.Size = new System.Drawing.Size(52, 20);
            this.DocksLabel.TabIndex = 6;
            this.DocksLabel.Text = "Docks:";
            this.DocksLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // WorkersLabel
            // 
            this.WorkersLabel.AutoSize = true;
            this.WorkersLabel.Location = new System.Drawing.Point(12, 72);
            this.WorkersLabel.Name = "WorkersLabel";
            this.WorkersLabel.Size = new System.Drawing.Size(65, 20);
            this.WorkersLabel.TabIndex = 7;
            this.WorkersLabel.Text = "Workers:";
            // 
            // DocksCountLabel
            // 
            this.DocksCountLabel.AutoSize = true;
            this.DocksCountLabel.Location = new System.Drawing.Point(12, 305);
            this.DocksCountLabel.Name = "DocksCountLabel";
            this.DocksCountLabel.Size = new System.Drawing.Size(51, 20);
            this.DocksCountLabel.TabIndex = 8;
            this.DocksCountLabel.Text = "Count:";
            this.DocksCountLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // WorkersCountLabel
            // 
            this.WorkersCountLabel.AutoSize = true;
            this.WorkersCountLabel.Location = new System.Drawing.Point(169, 308);
            this.WorkersCountLabel.Name = "WorkersCountLabel";
            this.WorkersCountLabel.Size = new System.Drawing.Size(93, 20);
            this.WorkersCountLabel.TabIndex = 9;
            this.WorkersCountLabel.Text = "Docks count:";
            // 
            // DocksCountText
            // 
            this.DocksCountText.Location = new System.Drawing.Point(264, 305);
            this.DocksCountText.Name = "DocksCountText";
            this.DocksCountText.Size = new System.Drawing.Size(56, 27);
            this.DocksCountText.TabIndex = 10;
            // 
            // WorkersCountText
            // 
            this.WorkersCountText.Location = new System.Drawing.Point(69, 305);
            this.WorkersCountText.Name = "WorkersCountText";
            this.WorkersCountText.Size = new System.Drawing.Size(94, 27);
            this.WorkersCountText.TabIndex = 11;
            // 
            // AddDockButton
            // 
            this.AddDockButton.Location = new System.Drawing.Point(169, 373);
            this.AddDockButton.Name = "AddDockButton";
            this.AddDockButton.Size = new System.Drawing.Size(151, 29);
            this.AddDockButton.TabIndex = 15;
            this.AddDockButton.Text = "Add dock";
            this.AddDockButton.UseVisualStyleBackColor = true;
            this.AddDockButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMachineButton
            // 
            this.AddMachineButton.Location = new System.Drawing.Point(326, 373);
            this.AddMachineButton.Name = "AddMachineButton";
            this.AddMachineButton.Size = new System.Drawing.Size(151, 29);
            this.AddMachineButton.TabIndex = 16;
            this.AddMachineButton.Text = "Add machine";
            this.AddMachineButton.UseVisualStyleBackColor = true;
            this.AddMachineButton.Click += new System.EventHandler(this.AddMachineButton_Click);
            // 
            // HireButton
            // 
            this.HireButton.Location = new System.Drawing.Point(12, 373);
            this.HireButton.Name = "HireButton";
            this.HireButton.Size = new System.Drawing.Size(151, 29);
            this.HireButton.TabIndex = 17;
            this.HireButton.Text = "Hire worker";
            this.HireButton.UseVisualStyleBackColor = true;
            this.HireButton.Click += new System.EventHandler(this.HireButton_Click);
            // 
            // FireButton
            // 
            this.FireButton.Location = new System.Drawing.Point(12, 412);
            this.FireButton.Name = "FireButton";
            this.FireButton.Size = new System.Drawing.Size(151, 29);
            this.FireButton.TabIndex = 18;
            this.FireButton.Text = "Fire selected";
            this.FireButton.UseVisualStyleBackColor = true;
            this.FireButton.Click += new System.EventHandler(this.FireButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "ships amount:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.ServiceButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ServicePriceText);
            this.panel1.Controls.Add(this.ServiceTimeText);
            this.panel1.Controls.Add(this.ShipsAmountText);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(523, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 165);
            this.panel1.TabIndex = 20;
            // 
            // ServiceButton
            // 
            this.ServiceButton.Location = new System.Drawing.Point(3, 129);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.Size = new System.Drawing.Size(173, 29);
            this.ServiceButton.TabIndex = 30;
            this.ServiceButton.Text = "Calculate";
            this.ServiceButton.UseVisualStyleBackColor = true;
            this.ServiceButton.Click += new System.EventHandler(this.ServiceButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ships service";
            // 
            // ServicePriceText
            // 
            this.ServicePriceText.BackColor = System.Drawing.SystemColors.Window;
            this.ServicePriceText.Location = new System.Drawing.Point(109, 96);
            this.ServicePriceText.Name = "ServicePriceText";
            this.ServicePriceText.ReadOnly = true;
            this.ServicePriceText.Size = new System.Drawing.Size(67, 27);
            this.ServicePriceText.TabIndex = 23;
            // 
            // ServiceTimeText
            // 
            this.ServiceTimeText.BackColor = System.Drawing.SystemColors.Window;
            this.ServiceTimeText.Location = new System.Drawing.Point(109, 63);
            this.ServiceTimeText.Name = "ServiceTimeText";
            this.ServiceTimeText.ReadOnly = true;
            this.ServiceTimeText.Size = new System.Drawing.Size(67, 27);
            this.ServiceTimeText.TabIndex = 22;
            // 
            // ShipsAmountText
            // 
            this.ShipsAmountText.Location = new System.Drawing.Point(109, 30);
            this.ShipsAmountText.Name = "ShipsAmountText";
            this.ShipsAmountText.Size = new System.Drawing.Size(67, 27);
            this.ShipsAmountText.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "service time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "service price:";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(691, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(179, 29);
            this.BackButton.TabIndex = 25;
            this.BackButton.Text = "Go to main view";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // MachinesCountText
            // 
            this.MachinesCountText.Location = new System.Drawing.Point(383, 305);
            this.MachinesCountText.Name = "MachinesCountText";
            this.MachinesCountText.Size = new System.Drawing.Size(94, 27);
            this.MachinesCountText.TabIndex = 29;
            this.MachinesCountText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Count:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Machines:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // MachinesList
            // 
            this.MachinesList.Location = new System.Drawing.Point(326, 95);
            this.MachinesList.Name = "MachinesList";
            this.MachinesList.Size = new System.Drawing.Size(151, 204);
            this.MachinesList.TabIndex = 26;
            this.MachinesList.UseCompatibleStateImageBehavior = false;
            this.MachinesList.View = System.Windows.Forms.View.List;
            this.MachinesList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // WorkerDetails
            // 
            this.WorkerDetails.Location = new System.Drawing.Point(12, 338);
            this.WorkerDetails.Name = "WorkerDetails";
            this.WorkerDetails.Size = new System.Drawing.Size(151, 29);
            this.WorkerDetails.TabIndex = 30;
            this.WorkerDetails.Text = "Details";
            this.WorkerDetails.UseVisualStyleBackColor = true;
            this.WorkerDetails.Click += new System.EventHandler(this.WorkerDetails_Click);
            // 
            // DockDetails
            // 
            this.DockDetails.Location = new System.Drawing.Point(169, 338);
            this.DockDetails.Name = "DockDetails";
            this.DockDetails.Size = new System.Drawing.Size(151, 29);
            this.DockDetails.TabIndex = 31;
            this.DockDetails.Text = "Details";
            this.DockDetails.UseVisualStyleBackColor = true;
            this.DockDetails.Click += new System.EventHandler(this.DockDetails_Click);
            // 
            // MachineDetails
            // 
            this.MachineDetails.Location = new System.Drawing.Point(326, 338);
            this.MachineDetails.Name = "MachineDetails";
            this.MachineDetails.Size = new System.Drawing.Size(151, 29);
            this.MachineDetails.TabIndex = 32;
            this.MachineDetails.Text = "Details";
            this.MachineDetails.UseVisualStyleBackColor = true;
            this.MachineDetails.Click += new System.EventHandler(this.MachineDetails_Click);
            // 
            // DetailedPortViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.MachineDetails);
            this.Controls.Add(this.DockDetails);
            this.Controls.Add(this.WorkerDetails);
            this.Controls.Add(this.MachinesCountText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MachinesList);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FireButton);
            this.Controls.Add(this.HireButton);
            this.Controls.Add(this.AddMachineButton);
            this.Controls.Add(this.AddDockButton);
            this.Controls.Add(this.WorkersCountText);
            this.Controls.Add(this.DocksCountText);
            this.Controls.Add(this.WorkersCountLabel);
            this.Controls.Add(this.DocksCountLabel);
            this.Controls.Add(this.WorkersLabel);
            this.Controls.Add(this.DocksLabel);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.WorkersList);
            this.Controls.Add(this.DocksList);
            this.Name = "DetailedPortViewForm";
            this.Text = "DetailedPortViewForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView DocksList;
        private ListView WorkersList;
        private Label NameLabel;
        private Label AddressLabel;
        private TextBox NameText;
        private TextBox AddressText;
        private Label DocksLabel;
        private Label WorkersLabel;
        private Label DocksCountLabel;
        private Label WorkersCountLabel;
        private TextBox DocksCountText;
        private TextBox WorkersCountText;
        private Button AddDockButton;
        private Button AddMachineButton;
        private Button HireButton;
        private Button FireButton;
        private Label label2;
        private Panel panel1;
        private Label label5;
        private TextBox ServicePriceText;
        private TextBox ServiceTimeText;
        private TextBox ShipsAmountText;
        private Label label4;
        private Label label3;
        private Button BackButton;
        private TextBox MachinesCountText;
        private Label label7;
        private Label label8;
        private ListView MachinesList;
        private Button ServiceButton;
        private Button WorkerDetails;
        private Button DockDetails;
        private Button MachineDetails;
    }
}