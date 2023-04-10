﻿using System;
namespace Labs.Lab1;


public class Figura
{
    public virtual void Area()
    {
        Console.WriteLine("Area de la figura");
    }
}



public class Rectangulo : Figura
{
    public override void Area()
    {
        Console.WriteLine("El area es lo largo por lo ancho.");
    }
}

public class Rombo : Figura
{
    public override void Area()
    {
        Console.WriteLine("El area es la multiplicacion de las diagonales dibidido en 2.");
    }
}

public class Cuadro : Figura
{
    public override void Area()
    {
        Console.WriteLine("El area del cuadrado es el lado por el lado.");
    }
}




internal class IvánAgüero
{
    public static void Run()
    {
        Figura[] figuras = new Figura[3];
        figuras[0] = new Rectangulo();
        figuras[1] = new Rombo();
        figuras[2] = new Cuadro();

        foreach (Figura figura in figuras)
        {
            figura.Area();
        }

    }
}

