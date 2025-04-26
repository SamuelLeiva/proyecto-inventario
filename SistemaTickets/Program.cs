using SistemaTickets.Modelos;
using SistemaTickets.Modelos.Enums;

namespace SistemaTickets;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========= SISTEMA DE TICKETS ==========\n");

        //iniciar el sistema
        //rellenar datos
    }

    static void FillData(TicketSystem ticketSystem)
    {
        ticketSystem.AddDeveloper(new Developer { Name = "Samuel", Adress = "Pueblo Libre", Age = 27, Dni = "78945625", Genre = "Masculino", Role = "Desarrollador" });
        ticketSystem.AddDeveloper(new Developer { Name = "Jorge", Adress = "Pueblo Libre", Age = 27, Dni = "451658115", Genre = "Masculino", Role = "Desarrollador" });
        ticketSystem.AddDeveloper(new Developer { Name = "Juan", Adress = "Pueblo Libre", Age = 27, Dni = "54561655615", Genre = "Masculino", Role = "Desarrollador" });

        var ticket1 = new Ticket
        {
            Title = "Error en el inventario",
            Description = "Los elementos del inventario no cargan ni se visualizan en la página.",
            Priority = Priority.High,
            Category = TicketCategory.Bug,
            ReportedBy = "Cliente 1"
        };

        var ticket2 = new Ticket
        {
            Title = "Añadir pasarela de pago",
            Description = "Se necesita añadir una pasarela de pago que acepte tarjeta y depósito.",
            Priority = Priority.Low,
            Category = TicketCategory.Feature,
            ReportedBy = "Equipo de desarrollo"
        };

        ticketSystem.AddTicket(ticket1);
        ticketSystem.AddTicket(ticket2);

        //vincular tickets a los developers

    }
}
