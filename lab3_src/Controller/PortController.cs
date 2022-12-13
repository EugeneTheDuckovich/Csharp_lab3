using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using lab3_src.Models.Port;
using lab3_src.Serializers;

namespace lab3_src.Controller;

public class PortController : IPortController
{
    private Dictionary<string,Port> _ports;
    public ListBox PortsListBox { get; set; }

    public PortController()
    {
        _ports = new Dictionary<string, Port>();
        PortsListBox = new ListBox();

        DeserializePorts();
    }

    public void AddPort(Port port)
    {
        try 
        {
            _ports.Add(port.Name, port);
        }
        catch(ArgumentException)
        {
            MessageBox.Show("this port already exists!", "warning");
        }
    }

    public void Clear()
    {
        _ports.Clear();
    }

    public Port? FindPortByName([DisallowNull]string name)
    {
        try
        {
            return _ports[name];
        }
        catch (ArgumentException)
        {
            return null;
        }
    }

    public Port[] Ports
    {
        get=> _ports.Values.ToArray();
    }

    public void RemovePort(Port port)
    {
        var pair = _ports.FirstOrDefault(p => p.Value == port).Key;
        if(string.IsNullOrEmpty(pair)) return;

        _ports.Remove(pair);
    }

    public void UpdateListBox()
    {
        PortsListBox.BeginUpdate();
        PortsListBox.Items.Clear();
        foreach (var port in Ports)
        {
            PortsListBox.Items.Add(port.Name);
        }
        PortsListBox.EndUpdate();
    }

    public void SerializePorts()
    {
        foreach (var port in _ports.Values)
        {
            PortSerializer.Serialize(port);
        }
    }

    public void DeserializePorts()
    {
        var jsonFiles = Directory.EnumerateFiles("Save\\");

        foreach (var file in jsonFiles)
        {
            var port = PortSerializer.Deserialize(file);
            
            if(port != null) _ports.Add(port.Name, port);
        }
    }
}