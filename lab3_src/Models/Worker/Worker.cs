

namespace lab3_src.Models;

public class Worker
{
    public string Id { get; set; }
    public string FullName { get; set; }
    public int Salary { get; set; }
    public string DockId { get; set; }

    public Worker() { }

    public Worker(string id, string fullName, int salary)
    {
        Id = id;
        FullName = fullName;
        Salary = salary;
        DockId = String.Empty;
    }

}
