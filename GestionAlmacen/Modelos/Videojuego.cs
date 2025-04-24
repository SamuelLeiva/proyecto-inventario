using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAlmacen.Interfaces;
using GestionAlmacen.Modelos.Enums;

namespace GestionAlmacen.Modelos;

public class Videojuego : IMultimediaItem
{
    private static int _nextId = 1;
    public int Id { get; private set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public double Duracion { get; set; }
    public bool Terminado { get; set; }
    public Genero Genero { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }

    public Videojuego()
    {
        Id = _nextId++;
    }
}
