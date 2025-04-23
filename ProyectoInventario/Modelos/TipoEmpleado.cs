﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoInventario.Modelos;

public class TipoEmpleado
{
    private static int _nextId = 1;

    public int Id { get; private set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }

    public TipoEmpleado()
    {
        Id = _nextId++;
    }

}
