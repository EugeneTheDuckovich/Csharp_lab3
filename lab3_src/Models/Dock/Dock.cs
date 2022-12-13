using System.Text.Json.Serialization;

namespace lab3_src.Models;

public class Dock
{
    private List<Machine> _machines;
    private List<string> _workers;

    public List<string> WorkersIDs { get { return _workers; } set { _workers = value; } }
    public List<Machine> Machines { get { return _machines; } set { _machines = value; } }

    public string Id { get; set; }

    private const int MaxWorkers = 35;
    private const int MaxMachines = 10;
    private const int DefaultHoursPerShip = 20;

    [JsonIgnore]
    public int FunctioningMachines
    {
        get
        {
            int result = 0, workersCount = _workers.Count;

            foreach (var machine in _machines)
            {
                workersCount -= machine.NeededWorkers;                
                if (workersCount < 0) break;
                
                result++;
            }

            return result;
        }
    }

    [JsonIgnore]
    public int MachineExpences
    {
        get => _machines.Where(m => m.IsOutOfCapacity()).Sum(m => m.Price);
    }

    [JsonIgnore]
    public int ServiceTime
    {
        get => DefaultHoursPerShip - FunctioningMachines;
    }

    public Dock()
    {

    }

    public Dock(string id)
    {
        Id = id;
        _machines = new();
        _workers = new();
    }

    public Dock(string id, IEnumerable<Machine> machines, IEnumerable<string> workers)
    {
        Id = string.IsNullOrEmpty(id) ? "defaultPort" : id;
        _machines = machines.ToList();
        _workers = workers.ToList();
    }

    public bool Hire(Worker worker)
    {
        bool isAdditionSuccessfull = _workers.Count < MaxWorkers;
        if (isAdditionSuccessfull)
        {
            worker.DockId = Id;
            _workers.Add(worker.Id);
        } 
        return isAdditionSuccessfull;
    }

    public bool TryFire(Worker worker)
    {
        return _workers.Remove(worker.Id);
    }

    public bool TryAddMachine(Machine machine)
    {
        bool isAbleToAdd = _machines.Count < MaxMachines;

        if (isAbleToAdd) 
        {
            _machines.Add(machine);
            _machines = _machines.OrderBy(m => m.NeededWorkers).ToList();
        }
        return isAbleToAdd;
    }

}