using lab3_src.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_src.Forms.AddItemForms;

public partial class AddWorker : Form
{
    Worker _worker;

    public AddWorker(Worker worker)
    {
        InitializeComponent();
        this.CenterToScreen();

        _worker = worker;
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(IdText.Text)
            || string.IsNullOrEmpty(NameText.Text)
            || string.IsNullOrEmpty(SalaryText.Text))
        {
            MessageBox.Show("input all fields!");
            return;
        }

        int salary = 0;
        if (!int.TryParse(SalaryText.Text, out salary)) 
        {
            MessageBox.Show("invalid salary input!");
            return; 
        }

        _worker.Id = IdText.Text;
        _worker.FullName = NameText.Text;
        _worker.Salary = salary;
        this.Close();
    }
}
