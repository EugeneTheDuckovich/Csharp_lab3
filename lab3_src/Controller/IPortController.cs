using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3_src.Models.Port;

namespace lab3_src.Controller;

public interface IPortController
{
    ListBox PortsListBox { get; set; }

    void UpdateListBox();

    void AddPort(Port port);

    Port? FindPortByName(string name);

    Port[] Ports { get; }

    void RemovePort(Port port);

    void Clear();

    void SerializePorts();

    void DeserializePorts();
}
