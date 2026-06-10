using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList lista = new ArrayList();
        lista.Add("Zbigniew"); lista.Add("Wojciech"); lista.Add("Marta"); lista.Add("Karolina"); lista.Add("Adam"); lista.Add("Jan");
        lista.Sort();
        for (int i = 0; i < lista.Count; i++)
        {
            Console.WriteLine(lista[i]);

        }




    }



}