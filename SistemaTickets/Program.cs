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
                switch (opcion)
                {
                    case "1":
                        ticketService.GetAllTickets(ticketSystem);
                        break;
                    case "2":
                        ticketService.AddTicket(ticketSystem);
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

    
}
