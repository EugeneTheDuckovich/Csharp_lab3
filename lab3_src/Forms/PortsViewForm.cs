using lab3_src.Controller;
using lab3_src.Models;
using lab3_src.Models.Port;
using lab3_src.Serializers;

namespace lab3_src.Forms;

public partial class PortsViewForm : Form
{
    private IPortController _controller;

    public PortsViewForm(IPortController controller)
    {
        InitializeComponent();
        this.Closed += CommonEvents.OnClosing;
        this.CenterToScreen();
        PortsListView.MultiSelect = false;
        PortsListView.View = View.List;

        _controller = controller;

        UpdateList();

    }
    private void UpdateList()
    {
        PortsListView.Items.Clear();

        foreach (var port in _controller.Ports)
        {
            var item = new ListViewItem();
            item.Tag = port;
            item.Text = port.Name;
            

            PortsListView.Items.Add(item);
        }
    }

    private void DetailedViewButton_Click(object sender, EventArgs e)
    {
        if (PortsListView.SelectedItems.Count == 0) return;
        CommonEvents.ChangeForm(this, FormType.DetailedView, PortsListView.SelectedItems[0].Tag as Port);
    }

    private void AddPortButton_Click(object sender, EventArgs e)
    {
        CommonEvents.ChangeForm(this, FormType.AddPort);
    }

    private void DeletePortButton_Click(object sender, EventArgs e)
    {
        Port? selectedPort = 
            PortsListView.SelectedItems.Count > 0 ? PortsListView.SelectedItems[0].Tag as Port : null;

        if (selectedPort == null) return;
        
        _controller.RemovePort(selectedPort);
        PortsListView.Items.Remove(PortsListView.SelectedItems[0]);
    }

    private void PortsViewForm_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void PortsComparisonButton_Click(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(FirstPortText.Text) 
            || string.IsNullOrEmpty(SecondPortText.Text)) return;

        var first = _controller.FindPortByName(FirstPortText.Text);
        var second = _controller.FindPortByName(SecondPortText.Text);

        if( first == null || second == null) return;

        if(first >= second && first <= second)
        {
            ComparisonResultText.Text = $"{first.Name} = {second.Name}";
        }
        else if (first >= second)
        {
            ComparisonResultText.Text = $"{first.Name} > {second.Name}";
        }
        else
        {
            ComparisonResultText.Text = $"{first.Name} < {second.Name}";
        }
    }
}