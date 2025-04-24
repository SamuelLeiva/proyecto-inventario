using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlmacen.Interfaces;

public interface IMultimediaItem
{
    string Titulo {  get; set; }
    string Descripcion { get; set; }
    double Duracion { get; set; }
}
