using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static csharp_abstract_animals.Animals;


// Esercizio 2 : interfacce
// Alcuni degli animali che abbiamo creato volano, altri nuotano.
// Gli animali che volano hanno il seguente metodo : void Vola() (mostra a video “Sto volando!!!”).
// Gli animali che nuotano hanno il seguente metodo : void Nuota() (mostra a video “Sto nuotando!!!”).
// Scrivere un programma avente 2 metodi : void FaiVolare(IVolante animale) void FaiNuotare(INuotante animale).
// Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
// Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro.
namespace csharp_abstract_animals
{
    //1.
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

        public class Dog : Animal
        {
            public override void Verse()
            {
                Console.WriteLine("verso cane");
            }
            public override void Eat()
            {
                Console.WriteLine("cibo cane");
            }
        }

        public class Eagle : Animal
        {
            public override void Verse()
            {
                Console.WriteLine("verso aquila");
            }
            public override void Eat()
            {
                Console.WriteLine("cibo aquila");
            }
        }

        public class Dolphin : Animal
        {
            public override void Verse()
            {
                Console.WriteLine("verso delfino");
            }
            public override void Eat()
            {
                Console.WriteLine("cibo delfino");
            }
        }

    }
}



//2.
internal class AnimalsInterface
{
    //Interfaccia ("classe" completamente astratta (con tutti i metodi astratti))
    public interface IFlyingAnimal{
            public abstract void Fly();

    }

    public interface ISwimmingAnimal
    {
        public abstract void Swim();
    }


    public class Dolphin : ISwimmingAnimal
    {
        public void Swim()
        {
            Console.WriteLine("Sto nuotando!");
        }
    }

    public class Eagle : IFlyingAnimal
    {
        public void Fly()
        {
            Console.WriteLine("Sto volando!");
        }
    }

    public class Sparrow : IFlyingAnimal
    {
        public void Fly()
        {
            Console.WriteLine("Sto volando!");
        }
    }
}