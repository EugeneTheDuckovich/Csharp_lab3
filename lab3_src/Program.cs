using lab3_src.Controller;
using lab3_src.Forms;

namespace lab3_src;

public static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var controller = new PortController();
        CommonEvents.SetController(controller);

        Application.Run(new PortsViewForm(controller));
    }
}