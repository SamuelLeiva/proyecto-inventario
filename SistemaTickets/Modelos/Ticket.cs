using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTickets.Modelos.Enums;

namespace SistemaTickets.Modelos;

public class Ticket
{
    private static int _nextId = 1;

    public int Id { get; private set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public TicketStatus Status { get; set; } = TicketStatus.Open; //Por defecto el ticket empieza como activo (abierto)
    public Priority Priority { get; set; }
    public TicketCategory Category { get; set; }
    public string ReportedBy { get; set; }
    public DateTime CreatedDate { get; private set; } = DateTime.Now;
    public DateTime? LastUpdated { get; set; }
    public Developer? AssignedTo { get; set; }
    public List<Comment> Comments { get; private set; } = new List<Comment>();

    public Ticket()
    {
        Id = _nextId++;
    }

    public void LinkDeveloper(Developer developer) //función para vincular el developer al ticket
    {
        AssignedTo = developer;
    }
}
