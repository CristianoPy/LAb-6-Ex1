/* Ex 2
Scrieti un program care va modela un autoturism. Un autoturism va avea o
marca (string), un numar de inmatriculare (string), precum si o
capacitate cilindrica(int).
Autoturismul va avea:
 Campurile corespunzatoare caracteristicilor autoturismului.
 Un constructor care va initializa campurile acestuia
 O metoda “Tiparire” care va afisa pe consola descrierea acestuia sub forma : “marca,
numarDeInmatriculare, capacitateCilindrica”.
Folositi: clase, campuri, metode, modificatorii de acces adecvati, comentarii
xml pentru metodele publice.
Creeati doua obiecte de tipul autoturism in functia “Main” si apelati-le
metodele “Tipareste”*/

Car Ford = new Car("Transit", "123443", 2200);


Car Opel = new Car("Corsa", "543765", 1000);


Console.WriteLine($"The {Ford.model}, with number {Ford.number}, has {Ford.capCil} cc");
Console.WriteLine($"The {Opel.model}, with number {Opel.number}, has {Opel.capCil} cc");


class Car
{
    public string model;
    public string number;
    public int capCil;

    public Car(string modelName, string modelnumber, int modelcapCil)
    {
        model = modelName;
        number = modelnumber;
        capCil = modelcapCil;
    }
}

