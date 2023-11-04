using System;

public class Punto
{
    public decimal x;
    public decimal y;
    public decimal z;

    public Punto(decimal x, decimal y, decimal z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double MedirDistancia(Punto otroPunto)
    {
        decimal dx = otroPunto.x - this.x;
        decimal dy = otroPunto.y - this.y;
        decimal dz = otroPunto.z - this.z;

        return Math.Sqrt((double)(dx * dx + dy * dy + dz * dz));
    }
}

public class Program
{
    public static void Main()
    {
        Punto puntoOrigen = new Punto(0, 0, 0);
        Punto puntoDestino = new Punto(3, 4, 5);

        double distancia = puntoOrigen.MedirDistancia(puntoDestino);

        Console.WriteLine("La distancia entre el punto de origen y el punto de destino es " + distancia);
    }
}

