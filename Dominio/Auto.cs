﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Auto
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public DateTime Fecha { get; set; }
        public bool Usado { get; set; }
        public bool Importado { get; set; }

    }

    public class AutoNegocio
    {
        public List<Auto> listar()
        {

            List<Auto> lista = new List<Auto>();
            lista.Add(new Auto());
            lista.Add(new Auto());

            lista[0].Id = 1;
            lista[0].Modelo = "Renault 12";
            lista[0].Descripcion = "Auto duro";
            lista[0].Color = "Azul";
            lista[0].Fecha = DateTime.Now;
            lista[0].Usado = true;
            lista[0].Importado = true;

            lista[1].Id = 2;
            lista[1].Modelo = "Mini Cooper";
            lista[1].Descripcion = "El mejor";
            lista[1].Color = "Blanco";
            lista[1].Fecha = DateTime.Now;
            lista[1].Usado = false;
            lista[1].Importado = true;

            return lista;
        }
    }
        

    
        

  
}   



