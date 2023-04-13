using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Animals
    {
        //Classe astratta (classe sia con metodi atratti sia con metodi non astatti)
        public abstract class Animal
        {

            //metodo astratto (metodo privo di corpo che deve essere utilizzato e implementato dalle sottoclassi poichè non uguale per tutte)
            public abstract void Verse();
            public abstract void Eat();

            //metodo non astratto (uguale per tutte le sottoclassì) ma statico (pochè non utilizza gli attributi)
            public static void Sleep()
            {
                Console.WriteLine("ZZZ");
            }
        }
        public class Sparrow : Animal
        {
            public override void Verse()
            {
                Console.WriteLine("verso passero");
            }
            public override void Eat()
            {
                Console.WriteLine("cibo passero");
            }
        }
    }
}
