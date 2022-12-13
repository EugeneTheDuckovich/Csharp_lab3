using lab3_src.Controller;
using lab3_src.Models.Port;

namespace lab3_src.Forms;

public static class CommonEvents
{
    private static IPortController? _portController = null;

    public static void SetController(IPortController portController)
    {
        _portController = portController;
    }

    public static void OnClosing(object? sender, EventArgs e)
    {
        Application.Exit();
        _portController?.SerializePorts();
    }

    public static void ChangeForm(Form currentForm, FormType type, Port? port = null)
    {
        if (_portController == null) return;

        //_portController.SerializePorts();

        Form form = new();
        switch (type) 
        {
            case FormType.PortsView:
                form = new PortsViewForm(_portController);
                break;
            case FormType.DetailedView:
                form = new DetailedPortViewForm(_portController, port);
                break;
            case FormType.AddPort:
                form = new AddPortForm(_portController);
                break;
            default:
                form = new PortsViewForm(_portController);
                break;
        }

        form.Show();
        currentForm.Hide();
    }

}