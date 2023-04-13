// Esercizio 1 : classi astratte
// Dobbiamo realizzare un programma che rappresenti il regno animale.
// Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
// Vogliamo che gli animali abbiano i seguenti metodi: void Dormi() (mostra a video “Zzz”), void Verso() (mostra a video il verso fatto dall'animale specifico), void Mangia() (mostra a video quello che mangia : erba, carne, ...?).
// Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono?
// Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.

// Esercizio 2 : interfacce
// Alcuni degli animali che abbiamo creato volano, altri nuotano.
// Gli animali che volano hanno il seguente metodo : void Vola() (mostra a video “Sto volando!!!”).
// Gli animali che nuotano hanno il seguente metodo : void Nuota() (mostra a video “Sto nuotando!!!”).
// Scrivere un programma avente 2 metodi : void FaiVolare(IVolante animale) void FaiNuotare(INuotante animale).
// Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
// Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro.


//1.
using csharp_abstract_animals;
using static AnimalsInterface;
using static csharp_abstract_animals.Animals;

Animal sparrow1, dog1, dog2, dolphin1, eagle1;

sparrow1 = new Animals.Sparrow();
dolphin1 = new Animals.Dolphin();
dog1 = new Animals.Dog();
dog2 = new Animals.Dog();
eagle1 = new Animals.Eagle();


Console.WriteLine("PASSERO 1");
sparrow1.Verse();
sparrow1.Eat();
Animal.Sleep();

Console.WriteLine("DELFINO 1");
dolphin1.Verse();
dolphin1.Eat();
Animal.Sleep();

Console.WriteLine("CANE 1");
dog1.Verse();
dog1.Eat();
Animal.Sleep();

Console.WriteLine("CANE 2");
dog2.Verse();
dog2.Eat();
Animal.Sleep();

Console.WriteLine("AQUILA 1");
eagle1.Verse();
eagle1.Eat();
Animal.Sleep();


//2.
ISwimmingAnimal dolphin2, dolphin3;
IFlyingAnimal sparrow2, eagle2; 

dolphin2 = new AnimalsInterface.Dolphin();
dolphin3 = new AnimalsInterface.Dolphin();
sparrow2 = new AnimalsInterface.Sparrow();
eagle2 = new AnimalsInterface.Eagle();


Console.WriteLine("DELFINO 2");
dolphin2.Swim();

Console.WriteLine("DELFINO 3");
dolphin3.Swim();

Console.WriteLine("PASSERO 2");
sparrow2.Fly();

Console.WriteLine("AQUILA 2");
eagle2.Fly();

