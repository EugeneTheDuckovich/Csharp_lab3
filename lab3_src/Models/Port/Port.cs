using System.ComponentModel;
using System.Text.Json.Serialization;

namespace lab3_src.Models.Port;

public class Port
{
    private Dictionary<string, Worker> _workers;
    private List<Dock> _docks;
    public const int ServivePrice = 10000;

    public string Name { get; set; }

    public string Address { get; set; }

    public Dictionary<string, Worker> Workers { get { return _workers; } set { _workers = value; } }
    public List<Dock> Docks { get { return _docks; } set { _docks = value; } }

    [JsonIgnore]
    public int WorkersAmount { get => _workers.Count; }

    [JsonIgnore]
    public int VehiclesAmount { get => _docks.Sum(d => d.Machines.Count); }

    [JsonIgnore]
    public int DocksAmount { get => _docks.Count; }

    public Machine[] Machines { get => _docks.SelectMany(d => d.Machines).ToArray(); }

    public Port()
    {

    }

    public Port(string name, string adress,
        IEnumerable<Dock> docks, IEnumerable<Worker> workers, IEnumerable<Machine> machines)
    {
        Name = name;
        Address = adress;
        _docks = docks.ToList();

        _workers = new();

        foreach (var worker in workers)
        {
            HireWorker(worker);
        }

        foreach (var machine in machines)
        {
            TryAddMachine(machine);
        }
    }

    public Port(Port other)
    {
        Name = other.Name;
        Address = other.Address;
        _docks = new(other._docks);
        _workers = new(other._workers);
    }

    public static bool operator >=(Port first, Port second)
    {
        return first.DocksAmount >= second.DocksAmount;
    }

    public static bool operator <=(Port first, Port second)
    {
        return second >= first;
    }

    private Dock[] GetDocksInvolved(int shipsAmount)
    {
        var docks = new List<Dock>();
        for (int i = 0; shipsAmount > 0; i = (i + 1) % _docks.Count, shipsAmount--)
        {
            docks.Add(_docks[i]);
        }
        return docks.ToArray();
    }

    public int GetIncomeAfterService(int shipsAmount)
    {
        if (shipsAmount <= 0 || _docks.Count == 0) return 0;

        var docksinvolved = GetDocksInvolved(shipsAmount);

        int sumOfSalaries = 0;
        foreach (var dock in docksinvolved)
        {
            sumOfSalaries += _workers.Values.Where(w => dock.WorkersIDs.Contains(w.Id)).Sum(w => w.Salary);
        }

        return shipsAmount * ServivePrice
            - docksinvolved.Sum(d => d.MachineExpences)
            - sumOfSalaries;
    }

    public int GetServiceTime(int shipsAmount)
    {
        if (shipsAmount <= 0 || _docks.Count == 0) return 0;

        int time = 0;

        var iterations = shipsAmount / _docks.Count;

        var maxServiceTime = _docks.MaxBy(d => d.ServiceTime).ServiceTime;

        time += iterations * maxServiceTime;

        if (shipsAmount % _docks.Count != 0) time += _docks[shipsAmount % _docks.Count - 1].ServiceTime;

        return time;
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ Address.GetHashCode() ^ _workers.GetHashCode() ^ _docks.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Port);
    }

    public bool Equals(Port? other)
    {
        if (other == null) return false;
        if (ReferenceEquals(this, other)) return true;

        return GetHashCode() == other.GetHashCode();
    }

    public void AddDock(Dock dock)
    {
        _docks.Add(dock);
        _docks = _docks.OrderBy(d => d.ServiceTime).ToList();
        var workersWithoutDocks = _workers.Values.Where(w => w.DockId == string.Empty);

        foreach (var worker in workersWithoutDocks)
        {
            dock.Hire(worker);
        }
    }

    public void HireWorker(Worker worker)
    {
        var dock = _docks.MinBy(d => d.WorkersIDs.Count);
        if (dock is null || !dock.Hire(worker))
        {
            MessageBox.Show("there are no available docks for this worker!");
        }

        try
        {
            _workers.Add(worker.Id, worker);
        }
        catch
        {
            MessageBox.Show("this workers already works here!");
        }
    }

    public bool FireWorker(Worker worker)
    {
        var dock = _docks.Find(d => d.WorkersIDs.Contains(worker.Id));

        return _workers.Remove(worker.Id) && dock != null && dock.TryFire(worker);
    }

    public bool TryAddMachine(Machine machine)
    {
        var dock = _docks.MinBy(d => d.Machines.Count);

        return dock is not null && dock.TryAddMachine(machine);
    }
}