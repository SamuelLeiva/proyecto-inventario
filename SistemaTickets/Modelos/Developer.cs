using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTickets.Modelos;

public class Developer
{
    private static int _nextId = 1;

    public int Id { get; private set; }
    public string Name { get; set; }
    public string Role { get; set; }
    public List<Ticket> AssignedTickets { get; private set; } = new List<Ticket>();

    public Developer()
    {
        Id = _nextId++;
    }
}
