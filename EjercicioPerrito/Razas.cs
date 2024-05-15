namespace EjercicioPerrito
{
    public  abstract class Razas
    {
                public int tamaño { get; set; }
        public decimal peso { get; set; }
        public string color { get; set; }
        public string nombre { get; set; }

        public Razas() 
        {

        }
        
        public abstract void Correr ();

         public void Correr (int come)
        {
            Console.WriteLine("El perro corre");
        }

        public void Comer ()
        {
            Console.WriteLine("El perro a comido");
        }

        public void Jugar (int carro)
        {
            Console.WriteLine("El perro a jugado");
        }

        public abstract void Jugar ();

    }
}