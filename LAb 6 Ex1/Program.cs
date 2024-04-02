/*Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
metoda care va calcula volumul acestuia.
Folositi o clasa care va modela un dulap.
 Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
 Cele trei campuri vor fi initializate cu ajutorul constructorului
 Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si
afisati rezultatul.*/

var Dulap = new Dulap();
Dulap.SetVolume();

Console.WriteLine("O volume do dulap é : {0}", Dulap.GetVolume());

Console.ReadLine();

class Dulap
{
    private int lungimel;
    private int latime;
    private int inaltime;

    public void SetVolume()
    {
        lungimel = 6;
        latime = 4;
        inaltime = 2;
    }
    public int GetVolume()
    {
        return lungimel * latime * inaltime;
    }
}
