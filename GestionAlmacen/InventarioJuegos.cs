using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionAlmacen.Modelos;

namespace GestionAlmacen;

public class InventarioJuegos
{
    private List<Videojuego> _videojuegos = new List<Videojuego>();

    public void AgregarNuevoJuego(Videojuego videojuego)
    {
        _videojuegos.Add(videojuego);
    }

    public List<Videojuego> ObtenerVideojuegos()
    {
        return _videojuegos.ToList();
    }

    public Videojuego ObtenerVideojuegoPorTitulo(string titulo)
    {
        return _videojuegos.FirstOrDefault(v => v.Titulo == titulo);
    }
}
