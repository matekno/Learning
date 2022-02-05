using System;
using System.Collections.Generic;
using LearningInterfaces.Interfaces;
namespace LearningInterfaces.Models;

public class Cerveza : IBebidaAlcoholica
{
    public string Presentacion { get; set; }
    public string Marca { get; set; }
    public int Capacidad { get; set; }
    public float Precio { get; set; }

    public void Llenar(int nuevaCantidad)
    {
        this.Capacidad = nuevaCantidad - 10;
    }

    public string Mostrar()
    {
        return $"La cantidad de cerveza es de {this.Capacidad}";
    }

    public float Graduacion { get; set; }
    public float PrecioRetornable()
    {
        return this.Precio / 4;
    }
}