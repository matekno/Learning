using System;
using System.Collections.Generic;
namespace LearningInterfaces.Interfaces;
public interface IBebidaAlcoholica : IBebida
{
    float Graduacion { get; set; }
    float PrecioRetornable();

}