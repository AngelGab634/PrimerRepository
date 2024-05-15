using System.Reflection;
using  EjercicioPerrito;
internal class Program
{
    private static void Main(string[] args)
    {
       Dog perro = new Dog();
       perro.nombre = "Alex";
       perro.tamaño = 30;
       perro.peso = 8;
       perro.color = "Cafe";

       perro.Correr();
       perro.Comer();
       perro.Jugar();

       Pego italian = new Pego();

       italian.nombre = "Rattatouie";
       italian.peso = 10;
       italian.color = "Blanco";
       italian.tamaño = 50;

       italian.Correr();
       italian.Comer();
       italian.Jugar();

       Dog perrito = new Dog();
       {
        perrito.nombre = "Sebastian";

        MostrarHijos(perrito);

       }


    }

    public static void MostrarHijos(Imamiferos m)
    {
        m.Tenerhijos();
    }

    public static void MostrarPresas(Imamiferos p)
    {
        p.BuscarPresa();
    }

    public class Dog : Razas, Imamiferos
    {
        public void BuscarPresa()
        {
            throw new NotImplementedException();
        }

        public override void Correr()
        {
            throw new NotImplementedException();
        }

        public override void Jugar()
        {
            throw new NotImplementedException();
        }

        public void Tenerhijos()
        {
            throw new NotImplementedException();
            
            Console.WriteLine("Tiene Hijos el Dog");
        }
    }
}