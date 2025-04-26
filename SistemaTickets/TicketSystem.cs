using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTickets.Modelos;

namespace SistemaTickets;

public class TicketSystem
{
    private List<Ticket> _ticketList = new List<Ticket>();
    private List<Developer> _developerList = new List<Developer>();

    public void AddTicket(Ticket ticket) //creación de ticket
    {
        _ticketList.Add(ticket);
    }

    public Ticket? GetTicket (int id)
    {
        return _ticketList.FirstOrDefault(t => t.Id == id);
    }

    public void AddDeveloper(Developer developer) //creación de usuario
    {
        _developerList.Add(developer);
    }

    //asignar tickets
    public void LinkTicket(int idTicket, Developer developer)
    {
        var ticket = GetTicket(idTicket);
        if(ticket != null)
        {
            ticket.LinkDeveloper(developer);
            developer.AssignedTickets.Add(ticket);
        } else
        {
            throw new KeyNotFoundException($"El ticket con id {idTicket} no existe.");
        }
        
    }
}
