using SistemaTickets.Modelos;
using SistemaTickets.Modelos.Enums;
using SistemaTickets.Servicios;

namespace SistemaTickets;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========= SISTEMA DE TICKETS ==========\n");

        //iniciar el sistema
        TicketSystem ticketSystem = new TicketSystem();
        TicketService ticketService = new TicketService();

        //rellenar datos
        ticketService.FillData(ticketSystem);

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nTicket Management System Menu:");
            Console.WriteLine("1. Ver tickets");
            Console.WriteLine("2. Añadir ticket");
            Console.WriteLine("0. Salir");

            string option = Console.ReadLine();

            try
            {
                switch (option)
                {
                    case "1":
                        ShowTickets(ticketSystem);
                        break;
                    case "2":
                        //AddTicket(ticketSystem);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Pruebe otra vez.");
                        break;
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error: {ex.Message}");
            }
        }

        Console.WriteLine("Saliendo del sistema......");
    }

    static void ShowTickets(TicketSystem ticketSystem)
    {
        Console.WriteLine("============= Tickets ===============");

        var tickets = ticketSystem.GetAllTickets();

        foreach (var ticket in tickets)
        {
            Console.WriteLine($"{ticket.Id}\t\t{ticket.Title}\t\t{ticket.Priority}\t\t{ticket.Status}\t\t{ticket.AssignedTo.Name}");
        }
    }

    

    
}
