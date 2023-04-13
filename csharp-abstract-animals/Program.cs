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
using static csharp_abstract_animals.Animals;

List<Animal> animals = new List<Animal>();

Animal sparrow1, dog1, dolphin1, dolphin2, eagle1;

sparrow1 = new Sparrow();
dolphin1 = new Dolphin();
dolphin2 = new Dolphin();
dog1 = new Dog();
eagle1 = new Eagle();

animals.Add(sparrow1);
animals.Add(dog1);
animals.Add(eagle1);
animals.Add(dolphin1);
animals.Add(dolphin2);

foreach (Animal animal in animals)
{
    animal.Verse();
    animal.Eat();
}

