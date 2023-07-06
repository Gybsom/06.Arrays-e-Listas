internal class Program
{
    private static void Main(string[] args)
    {
        //int[] meuVetor = new int[3];
        //meuVetor[0] = 3;
        //meuVetor[1] = 6;
        //meuVetor[2] = 9;

        //int[] meuVetor = new int[3] {4,3,5};

        int[] meuVetor2 = new int[3];

        int[] meuVetor = {5,3,5};

        //Console.WriteLine(meuVetor[2]);

        //Console.WriteLine(meuVetor);

        meuVetor.Min();
        meuVetor.Max();

        Array.Sort(meuVetor);

        Array.Reverse(meuVetor);

        Array.Clear(meuVetor);

        meuVetor2 = meuVetor;

        // =======================

        List<string> minhaLista = new List<string>();
        minhaLista.Add("Tiago");
        minhaLista.Add("Joao");
        minhaLista.Add("Bolda");
        minhaLista.Add("Le");
        minhaLista.Add("Max");
        minhaLista.Add("Adolfo");

        List<int> minhaListaInteira = new List<int>();
        int numero = 1;
        minhaListaInteira.Add(numero);

        

        Console.WriteLine(minhaLista.Find(var => var.StartsWith("T")));

        minhaLista.FindAll(nome => nome.Length == 4);

        minhaLista.RemoveAt(0);

        minhaListaInteira.RemoveAll(x => x == 1);

        minhaLista.Clear();

        Console.ReadKey();
    }
}