using System;

namespace AnimalesHerencia
{
    public abstract class Animal { 
        public abstract void Saludar();         
    } 

    public class Perro : Animal 
    { 
        public override void Saludar() 
        {
            Console.WriteLine("GUAU! Soy un perro!"); 
        } 
    }

    public class Gato : Animal 
    { 
        public override void Saludar() 
        {
            Console.WriteLine("MIAU! No me jodas!"); 
        } 
    }

    public class Tortuga : Animal 
    { 
        public override void Saludar() 
        {
            //al ser Saludar un método abstracto, obligo que se implemente
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Animal animal = new Animal();  //no es posible crear objetos abstractos
            // animal.Saludar(); 
            Perro dog = new Perro(); 
            dog.Saludar();
            Gato gato = new Gato();
            gato.Saludar();

        }
    }
}
