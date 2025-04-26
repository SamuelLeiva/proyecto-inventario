using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTickets.Modelos.Abstractos;

public abstract class Person
{
    public string Name { get; set; }
    public string Genre { get; set; }
    public string Dni { get; set; }
    public string Adress { get; set; }
    public int Age { get; set; }
}
