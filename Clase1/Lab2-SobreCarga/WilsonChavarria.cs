﻿namespace Labs.Lab2;

class Animal
{
    virtual public void comer()
    {
        Console.WriteLine("Los animales comen");
    }

    virtual public void correr()
    {
        Console.WriteLine("Los animales corren");

    }
}

class Humano : Animal
{
    override public void comer()
    {
        Console.WriteLine("Soy human como en platos");
    }
    override public void correr()
    {
        Console.WriteLine("Soy humano y corro con tenis");
    }
}

class Pajaro : Animal
{
    override public void comer()
    {
        Console.WriteLine("Los pajaros comemos frutas del campo");
    }
    public void volar()
    {
        Console.WriteLine("Los pajaros volamos");
    }

}

class Perro : Animal
{
    override public void comer()
    {
        Console.WriteLine("Los perros  comemos consentrado en una taza");
    }
    public override void correr()
    {
        Console.WriteLine("los perros corremos en cuatro patas  ");
    }

}

class Conejo1 : Animal
{
    override public void comer()
    {
        Console.WriteLine("los conejos comemos hierbas");
    }
    public override void correr()
    {
        Console.WriteLine("los conejos corremos dando saltos");
    }
}

internal class WilsonChavarria
{
    public static void Run()
    {

        Animal a = new Animal();
        a.comer();
        a.correr();

        Animal c = new Animal();
        c.correr();
        c.comer();

        Humano h = new Humano();
        h.comer();
        h.correr();

        Perro perro = new Perro();
        perro.comer();
        perro.correr();

        Pajaro pa = new Pajaro();
        pa.comer();
        pa.volar();
    }
}
