using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTickets.Modelos.Abstractos;

public abstract class Person
{
    public string Name { get; protected set; }
    public string Genre { get; protected set; }
    public string Dni { get; protected set; }
    public string Adress { get; protected set; }
    public string Age { get; protected set; }
}
