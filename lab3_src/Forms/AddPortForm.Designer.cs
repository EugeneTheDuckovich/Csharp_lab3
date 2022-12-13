namespace lab3_src.Forms
{
    partial class AddPortForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.MachinesList = new System.Windows.Forms.ListView();
            this.WorkersLabel = new System.Windows.Forms.Label();
            this.DocksLabel = new System.Windows.Forms.Label();
            this.WorkersList = new System.Windows.Forms.ListView();
            this.DocksList = new System.Windows.Forms.ListView();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.CreatePortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PortsList = new System.Windows.Forms.ListView();
            this.AddWorkerButton = new System.Windows.Forms.Button();
            this.AddDockButton = new System.Windows.Forms.Button();
            this.AddMachinePort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Machines:";
            // 
            // MachinesList
            // 
            this.MachinesList.Location = new System.Drawing.Point(501, 115);
            this.MachinesList.Name = "MachinesList";
            this.MachinesList.Size = new System.Drawing.Size(151, 250);
            this.MachinesList.TabIndex = 32;
            this.MachinesList.UseCompatibleStateImageBehavior = false;
            this.MachinesList.View = System.Windows.Forms.View.List;
            // 
            // WorkersLabel
            // 
            this.WorkersLabel.AutoSize = true;
            this.WorkersLabel.Location = new System.Drawing.Point(187, 92);
            this.WorkersLabel.Name = "WorkersLabel";
            this.WorkersLabel.Size = new System.Drawing.Size(65, 20);
            this.WorkersLabel.TabIndex = 31;
            this.WorkersLabel.Text = "Workers:";
            // 
            // DocksLabel
            // 
            this.DocksLabel.AutoSize = true;
            this.DocksLabel.Location = new System.Drawing.Point(344, 92);
            this.DocksLabel.Name = "DocksLabel";
            this.DocksLabel.Size = new System.Drawing.Size(52, 20);
            this.DocksLabel.TabIndex = 30;
            this.DocksLabel.Text = "Docks:";
            // 
            // WorkersList
            // 
            this.WorkersList.Location = new System.Drawing.Point(187, 115);
            this.WorkersList.Name = "WorkersList";
            this.WorkersList.Size = new System.Drawing.Size(151, 250);
            this.WorkersList.TabIndex = 29;
            this.WorkersList.UseCompatibleStateImageBehavior = false;
            this.WorkersList.View = System.Windows.Forms.View.List;
            // 
            // DocksList
            // 
            this.DocksList.Location = new System.Drawing.Point(344, 115);
            this.DocksList.Name = "DocksList";
            this.DocksList.Size = new System.Drawing.Size(151, 250);
            this.DocksList.TabIndex = 28;
            this.DocksList.UseCompatibleStateImageBehavior = false;
            this.DocksList.View = System.Windows.Forms.View.List;
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(402, 51);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(151, 27);
            this.AddressText.TabIndex = 37;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(245, 51);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(151, 27);
            this.NameText.TabIndex = 36;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(402, 28);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(65, 20);
            this.AddressLabel.TabIndex = 35;
            this.AddressLabel.Text = "Address:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(245, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 34;
            this.NameLabel.Text = "Name:";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(609, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(179, 29);
            this.BackButton.TabIndex = 38;
            this.BackButton.Text = "Go to main view";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CreatePortButton
            // 
            this.CreatePortButton.Location = new System.Drawing.Point(329, 407);
            this.CreatePortButton.Name = "CreatePortButton";
            this.CreatePortButton.Size = new System.Drawing.Size(179, 29);
            this.CreatePortButton.TabIndex = 39;
            this.CreatePortButton.Text = "Create port";
            this.CreatePortButton.UseVisualStyleBackColor = true;
            this.CreatePortButton.Click += new System.EventHandler(this.CreatePortButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Existing ports:";
            // 
            // PortsList
            // 
            this.PortsList.Location = new System.Drawing.Point(12, 28);
            this.PortsList.Name = "PortsList";
            this.PortsList.Size = new System.Drawing.Size(151, 365);
            this.PortsList.TabIndex = 40;
            this.PortsList.UseCompatibleStateImageBehavior = false;
            this.PortsList.View = System.Windows.Forms.View.List;
            // 
            // AddWorkerButton
            // 
            this.AddWorkerButton.Location = new System.Drawing.Point(187, 371);
            this.AddWorkerButton.Name = "AddWorkerButton";
            this.AddWorkerButton.Size = new System.Drawing.Size(151, 29);
            this.AddWorkerButton.TabIndex = 42;
            this.AddWorkerButton.Text = "Add";
            this.AddWorkerButton.UseVisualStyleBackColor = true;
            this.AddWorkerButton.Click += new System.EventHandler(this.AddWorkerButton_Click);
            // 
            // AddDockButton
            // 
            this.AddDockButton.Location = new System.Drawing.Point(344, 371);
            this.AddDockButton.Name = "AddDockButton";
            this.AddDockButton.Size = new System.Drawing.Size(151, 29);
            this.AddDockButton.TabIndex = 43;
            this.AddDockButton.Text = "Add";
            this.AddDockButton.UseVisualStyleBackColor = true;
            this.AddDockButton.Click += new System.EventHandler(this.AddDockButton_Click);
            // 
            // AddMachinePort
            // 
            this.AddMachinePort.Location = new System.Drawing.Point(501, 371);
            this.AddMachinePort.Name = "AddMachinePort";
            this.AddMachinePort.Size = new System.Drawing.Size(151, 29);
            this.AddMachinePort.TabIndex = 44;
            this.AddMachinePort.Text = "Add";
            this.AddMachinePort.UseVisualStyleBackColor = true;
            this.AddMachinePort.Click += new System.EventHandler(this.AddMachinePort_Click);
            // 
            // AddPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddMachinePort);
            this.Controls.Add(this.AddDockButton);
            this.Controls.Add(this.AddWorkerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PortsList);
            this.Controls.Add(this.CreatePortButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AddressText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MachinesList);
            this.Controls.Add(this.WorkersLabel);
            this.Controls.Add(this.DocksLabel);
            this.Controls.Add(this.WorkersList);
            this.Controls.Add(this.DocksList);
            this.Name = "AddPortForm";
            this.Text = "AddPortForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label8;
        private ListView MachinesList;
        private Label WorkersLabel;
        private Label DocksLabel;
        private ListView WorkersList;
        private ListView DocksList;
        private TextBox AddressText;
        private TextBox NameText;
        private Label AddressLabel;
        private Label NameLabel;
        private Button BackButton;
        private Button CreatePortButton;
        private Label label1;
        private ListView PortsList;
        private Button AddWorkerButton;
        private Button AddDockButton;
        private Button AddMachinePort;
    }
}