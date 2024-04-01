using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Animal
    {
        public virtual void makesound()
        {
            Console.WriteLine("animals sound");
        }
    }
    public class dog:Animal 
    {
        public override void makesound() { 
        
        Console.WriteLine("barks");
        }
    }


    public class cat:Animal
    {
        public override void makesound()
        {
            Console.WriteLine("Meows");
        }
    }

    internal class problem5
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.makesound();
            
            dog dog= new dog();
            dog.makesound();

            cat cat= new cat();
            cat.makesound();
        }

    }
}
