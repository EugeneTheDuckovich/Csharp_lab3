using lab3_src.Controller;
using lab3_src.Forms.AddItemForms;
using lab3_src.Models;
using lab3_src.Models.Port;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_src.Forms
{
    public partial class AddPortForm : Form
    {
        private IPortController _controller;

        private List<Dock> _docks;
        private List<Worker> _workers;
        private List<Machine> _machines;

        public AddPortForm( IPortController controller)
        {
            InitializeComponent();
            this.Closed += CommonEvents.OnClosing; 
            this.CenterToScreen();

            _controller = controller;

            _workers = new List<Worker>();
            _machines = new List<Machine>();
            _docks = new List<Dock>();

            UpdateLists();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CommonEvents.ChangeForm(this, FormType.PortsView);
        }

        private void UpdateLists()
        {
            PortsList.Clear();
            WorkersList.Clear();
            DocksList.Clear();
            MachinesList.Clear();

            foreach (var port in _controller.Ports)
            {
                var item = new ListViewItem();
                item.Tag = port;
                item.Text = port.Name;


                PortsList.Items.Add(item);
            }

            foreach (var worker in _workers)
            {
                var item = new ListViewItem();
                item.Tag = worker;
                item.Text = worker.Id;


                WorkersList.Items.Add(item);
            }

            foreach (var dock in _docks)
            {
                var item = new ListViewItem();
                item.Tag = dock;
                item.Text = dock.Id;


                DocksList.Items.Add(item);
            }

            foreach (var machine in _machines)
            {
                var item = new ListViewItem();
                item.Tag = machine;
                item.Text = machine.Id.ToString();


                MachinesList.Items.Add(item);
            }
        }

        private void CreatePortButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameText.Text)
                || string.IsNullOrEmpty(AddressText.Text))
            {
                return;
            }

            var port = new Port(NameText.Text,AddressText.Text,_docks,_workers,_machines);

            _controller.AddPort(port);

            UpdateLists();
        }

        private void AddWorkerButton_Click(object sender, EventArgs e)
        {
            Worker worker = new("","",0);
            var form = new AddWorker(worker);
            form.ShowDialog();
            if (worker != null) _workers.Add(worker);
            UpdateLists();
        }

        private void AddDockButton_Click(object sender, EventArgs e)
        {
            Dock dock = new("");
            var form = new AddDock(dock);
            form.ShowDialog();
            if (dock != null) _docks.Add(dock);
            UpdateLists();
        }

        private void AddMachinePort_Click(object sender, EventArgs e)
        {
            Machine machine = new(0,0,0,0);
            var form = new AddMachine(machine);
            form.ShowDialog();
            if (machine != null) _machines.Add(machine);
            UpdateLists();
        }
    }
}
