using System;

public class Guerrero
{
    public int vida;
    public int nivelAtaque;
    public string nombre;

    public Guerrero(int vida, int nivelAtaque, string nombre)
    {
        this.vida = vida;
        this.nivelAtaque = nivelAtaque;
        this.nombre = nombre;
    }

    public int Ataque()
    {
        return nivelAtaque;
    }

    public void RecibeAtaque(int ataque)
    {
        vida -= ataque;
    }
}

public class Enfrentamiento
{
    public void Iniciar(Guerrero guerrero1, Guerrero guerrero2)
    {
        Console.WriteLine("El combate ha comenzado entre " + guerrero1.nombre + " y " + guerrero2.nombre);

        while (guerrero1.vida > 0 && guerrero2.vida > 0)
        {
            guerrero2.RecibeAtaque(guerrero1.Ataque());
            Console.WriteLine(guerrero1.nombre + " ataca a " + guerrero2.nombre + ". Vida restante de " + guerrero2.nombre + ": " + guerrero2.vida);

            if (guerrero2.vida <= 0)
                break;

            guerrero1.RecibeAtaque(guerrero2.Ataque());
            Console.WriteLine(guerrero2.nombre + " ataca a " + guerrero1.nombre + ". Vida restante de " + guerrero1.nombre + ": " + guerrero1.vida);
        }

        if (guerrero1.vida > 0)
            Console.WriteLine("El ganador es " + guerrero1.nombre);
        else
            Console.WriteLine("El ganador es " + guerrero2.nombre);
    }
}

public class Program
{
    public static void Main()
    {
        Guerrero guerrero1 = new Guerrero(100, 20, "Guerrero 1");
        Guerrero guerrero2 = new Guerrero(100, 15, "Guerrero 2");

        Enfrentamiento enfrentamiento = new Enfrentamiento();
        enfrentamiento.Iniciar(guerrero1, guerrero2);
    }
}

