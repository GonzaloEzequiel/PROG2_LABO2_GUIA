﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public abstract class Equipo
    {
        public string nombre;
        private DateTime fechaCreacion;

        public Equipo(string nombre) 
        {
            this.nombre = nombre;
            this.fechaCreacion = DateTime.Now;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return (e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion);
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            return $"{this.nombre} fundado el {this.fechaCreacion}";
        }
    }
}
