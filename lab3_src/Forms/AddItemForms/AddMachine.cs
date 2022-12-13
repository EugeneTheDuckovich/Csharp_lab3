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

public partial class AddMachine : Form
{
    private Machine _machine;

    public AddMachine(Machine machine)
    {
        InitializeComponent();

        _machine = machine;
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(IdText.Text)
                || string.IsNullOrEmpty(PriceText.Text)
                || string.IsNullOrEmpty(CapacityText.Text)
                || string.IsNullOrEmpty(WorkersNeededText.Text))
        {
            MessageBox.Show("input all fields!");
            return;
        }

        int id = 0, price = 0, capacity = 0, workersNeeded = 0;
        if (!int.TryParse(IdText.Text,out id)
            || !int.TryParse(PriceText.Text, out price)
            || !int.TryParse(CapacityText.Text, out capacity)
            || !int.TryParse(WorkersNeededText.Text, out workersNeeded)
            )
        {
            MessageBox.Show("invalid input!");
            return;
        }

        _machine.Id = id;
        _machine.Capacity = capacity;
        _machine.Price = price;
        _machine.NeededWorkers = workersNeeded;
        this.Close();
    }
}
