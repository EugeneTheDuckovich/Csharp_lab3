using lab3_src.Controller;
using lab3_src.Forms.AddItemForms;
using lab3_src.Models;
using lab3_src.Models.Port;

namespace lab3_src.Forms
{
    public partial class DetailedPortViewForm : Form
    {
        IPortController _controller;
        Port _currentPort;

        public DetailedPortViewForm(IPortController controller, Port port)
        {
            InitializeComponent();
            this.Closed += CommonEvents.OnClosing;
            this.CenterToScreen();
            _controller = controller;
            _currentPort = port;

            UpdateData();
        }

        private void UpdateData()
        {
            NameText.Text = _currentPort.Name;
            AddressText.Text = _currentPort.Address;

            DocksList.Items.Clear();
            foreach (var dock in _currentPort.Docks)
            {
                var item = new ListViewItem();
                item.Tag = dock;
                item.Text = dock.Id;


                DocksList.Items.Add(item);
            }
            DocksCountText.Text = _currentPort.DocksAmount.ToString();

            WorkersList.Items.Clear();
            foreach (var worker in _currentPort.Workers.Values)
            {
                var item = new ListViewItem();
                item.Tag = worker;
                item.Text = worker.Id;


                WorkersList.Items.Add(item);
            }
            WorkersCountText.Text = _currentPort.WorkersAmount.ToString();

            MachinesList.Items.Clear();
            foreach (var machine in _currentPort.Machines)
            {
                var item = new ListViewItem();
                item.Tag = machine;
                item.Text = machine.Id.ToString();


                MachinesList.Items.Add(item);
            }
            MachinesCountText.Text = _currentPort.VehiclesAmount.ToString();
        }

        #region garbage
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
        #endregion

        private void FireButton_Click(object sender, EventArgs e)
        {
            if (WorkersList.SelectedItems.Count == 0) return;

            _currentPort.FireWorker(WorkersList.SelectedItems[0].Tag as Worker);

            UpdateData();
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            int shipsAmount;
            if (string.IsNullOrEmpty(ShipsAmountText.Text) 
                || !int.TryParse(ShipsAmountText.Text,out shipsAmount)) return;

            ServiceTimeText.Text = _currentPort.GetServiceTime(shipsAmount).ToString();
            ServicePriceText.Text = _currentPort.GetIncomeAfterService(shipsAmount).ToString();

            UpdateData();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CommonEvents.ChangeForm(this,FormType.PortsView);
        }

        private void WorkerDetails_Click(object sender, EventArgs e)
        {
            if(WorkersList.SelectedItems.Count == 0) return;

            var worker = WorkersList.SelectedItems[0].Tag as Worker;

            if (worker == null) return;

            MessageBox.Show($"Id: {worker.Id}\r\nName: {worker.FullName}\r\nSalary: {worker.Salary}$\r\n" +
                $"Dock: {worker.DockId}");
        }

        private void DockDetails_Click(object sender, EventArgs e)
        {
            if (DocksList.SelectedItems.Count == 0) return;

            var dock = DocksList.SelectedItems[0].Tag as Dock;

            if (dock == null) return;

            MessageBox.Show($"Id: {dock.Id}\r\n" +
                $"Service time: {dock.ServiceTime}\r\n" +
                $"Workers count: {dock.WorkersIDs.Count}\r\n" +
                $"Machines count: {dock.Machines.Count}");
        }

        private void MachineDetails_Click(object sender, EventArgs e)
        {
            if (MachinesList.SelectedItems.Count == 0) return;

            var machine = MachinesList.SelectedItems[0].Tag as Machine;

            if (machine == null) return;

            MessageBox.Show($"Id: {machine.Id}\r\n" +
                $"Price: {machine.Price}" +
                $"Workers needed: {machine.NeededWorkers}\r\n" +
                $"Capacity: {machine.Capacity} usages");
        }

        private void HireButton_Click(object sender, EventArgs e)
        {
            Worker worker = new("", "", 0);
            var form = new AddWorker(worker);
            form.ShowDialog();
            if (worker != null) _currentPort.HireWorker(worker);
            UpdateData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dock dock = new("");
            var form = new AddDock(dock);
            form.ShowDialog();
            if (dock != null) _currentPort.AddDock(dock);
            UpdateData();
        }

        private void AddMachineButton_Click(object sender, EventArgs e)
        {
            Machine machine = new(0, 0, 0, 0);
            var form = new AddMachine(machine);
            form.ShowDialog();
            if (machine != null) _currentPort.TryAddMachine(machine);
            UpdateData();
        }
    }
}