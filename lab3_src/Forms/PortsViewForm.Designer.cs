namespace lab3_src.Forms
{
    partial class PortsViewForm
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
            this.PortsListView = new System.Windows.Forms.ListView();
            this.DetailedViewButton = new System.Windows.Forms.Button();
            this.AddPortButton = new System.Windows.Forms.Button();
            this.DeletePortButton = new System.Windows.Forms.Button();
            this.FirstPortText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondPortText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComparisonResultText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PortsComparisonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortsListView
            // 
            this.PortsListView.Location = new System.Drawing.Point(365, 12);
            this.PortsListView.Name = "PortsListView";
            this.PortsListView.Size = new System.Drawing.Size(200, 300);
            this.PortsListView.TabIndex = 0;
            this.PortsListView.UseCompatibleStateImageBehavior = false;
            // 
            // DetailedViewButton
            // 
            this.DetailedViewButton.Location = new System.Drawing.Point(365, 318);
            this.DetailedViewButton.Name = "DetailedViewButton";
            this.DetailedViewButton.Size = new System.Drawing.Size(200, 29);
            this.DetailedViewButton.TabIndex = 1;
            this.DetailedViewButton.Text = "View details for selected";
            this.DetailedViewButton.UseVisualStyleBackColor = true;
            this.DetailedViewButton.Click += new System.EventHandler(this.DetailedViewButton_Click);
            // 
            // AddPortButton
            // 
            this.AddPortButton.Location = new System.Drawing.Point(365, 353);
            this.AddPortButton.Name = "AddPortButton";
            this.AddPortButton.Size = new System.Drawing.Size(200, 29);
            this.AddPortButton.TabIndex = 2;
            this.AddPortButton.Text = "Add new port";
            this.AddPortButton.UseVisualStyleBackColor = true;
            this.AddPortButton.Click += new System.EventHandler(this.AddPortButton_Click);
            // 
            // DeletePortButton
            // 
            this.DeletePortButton.Location = new System.Drawing.Point(365, 388);
            this.DeletePortButton.Name = "DeletePortButton";
            this.DeletePortButton.Size = new System.Drawing.Size(200, 29);
            this.DeletePortButton.TabIndex = 3;
            this.DeletePortButton.Text = "Delete selected";
            this.DeletePortButton.UseVisualStyleBackColor = true;
            this.DeletePortButton.Click += new System.EventHandler(this.DeletePortButton_Click);
            // 
            // FirstPortText
            // 
            this.FirstPortText.Location = new System.Drawing.Point(707, 53);
            this.FirstPortText.Name = "FirstPortText";
            this.FirstPortText.Size = new System.Drawing.Size(125, 27);
            this.FirstPortText.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "first port:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "second port:";
            // 
            // SecondPortText
            // 
            this.SecondPortText.Location = new System.Drawing.Point(707, 86);
            this.SecondPortText.Name = "SecondPortText";
            this.SecondPortText.Size = new System.Drawing.Size(125, 27);
            this.SecondPortText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "result:";
            // 
            // ComparisonResultText
            // 
            this.ComparisonResultText.BackColor = System.Drawing.SystemColors.Window;
            this.ComparisonResultText.Location = new System.Drawing.Point(707, 119);
            this.ComparisonResultText.Name = "ComparisonResultText";
            this.ComparisonResultText.ReadOnly = true;
            this.ComparisonResultText.Size = new System.Drawing.Size(125, 27);
            this.ComparisonResultText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ports comparison";
            // 
            // PortsComparisonButton
            // 
            this.PortsComparisonButton.Location = new System.Drawing.Point(632, 162);
            this.PortsComparisonButton.Name = "PortsComparisonButton";
            this.PortsComparisonButton.Size = new System.Drawing.Size(200, 29);
            this.PortsComparisonButton.TabIndex = 11;
            this.PortsComparisonButton.Text = "Compare ports";
            this.PortsComparisonButton.UseVisualStyleBackColor = true;
            this.PortsComparisonButton.Click += new System.EventHandler(this.PortsComparisonButton_Click);
            // 
            // PortsViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.PortsComparisonButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComparisonResultText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecondPortText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstPortText);
            this.Controls.Add(this.DeletePortButton);
            this.Controls.Add(this.AddPortButton);
            this.Controls.Add(this.DetailedViewButton);
            this.Controls.Add(this.PortsListView);
            this.Name = "PortsViewForm";
            this.Text = "PortsViewForm";
            this.Load += new System.EventHandler(this.PortsViewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView PortsListView;
        private Button DetailedViewButton;
        private Button AddPortButton;
        private Button DeletePortButton;
        private TextBox FirstPortText;
        private Label label1;
        private Label label2;
        private TextBox SecondPortText;
        private Label label3;
        private TextBox ComparisonResultText;
        private Label label4;
        private Button PortsComparisonButton;
    }
}