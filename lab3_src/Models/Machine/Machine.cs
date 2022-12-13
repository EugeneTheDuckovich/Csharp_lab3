using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_src.Models;

public class Machine
{
    public int Id { get; set; }
    private int _maxCapacity;
    private int _capacity;
    public int Capacity 
    { 
        get => _capacity;  
        set 
        { 
            _capacity = value; 
            _maxCapacity = _capacity; 
        } 
    }
    public int NeededWorkers { get; set; }
    public int Price { get; set; }

    public Machine()
    {

    }

    public Machine(int id, int capacity, int price, int neededWorkers)
    {
        Id = id;
        Capacity = capacity;
        NeededWorkers = neededWorkers;
        Price = price;
    }

    public bool IsOutOfCapacity()
    {
        _capacity--;

        var result = false;
        if(Capacity == 0)
        {
            result = true;
            _capacity = _maxCapacity;
        }

        return result;
    }

}
