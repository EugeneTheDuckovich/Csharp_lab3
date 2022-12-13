using lab3_src.Controller;
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

public partial class AddDock : Form
{
    private Dock _dock;

    public AddDock(Dock dock)
    {
        InitializeComponent();
        this.CenterToScreen();

        _dock = dock;
    }

    private void OkButton_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(IdText.Text))
        {
            MessageBox.Show("Input name!");
            return;
        }

        _dock.Id = IdText.Text;
        this.Close();
    }
}
