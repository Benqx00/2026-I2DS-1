internal class Program
{
    private static void Main(string[] args)
    {
        /* Vetores e Matrizes
            Vetor => é uma estrutura de dados utilizada para armazenar varios valores d eum mesmo tipo dentro de uma unica variavel

            Sintaxe: tipo[] nome_vetor = new  tipo[tamanho];
         */

         /* Iniciar um vetor -> lista de frutas */

        string[] listaFrutas = {"Maça","Manga","Morango","Melancia","Melão"};

        Console.WriteLine("Acessar o terceiro elemento da lista: ");
        Console.WriteLine(listaFrutas[2]);

        Console.WriteLine("Alterar o segundo elemento da lista: ");
        listaFrutas[1] = "Banana";

        for (int indice = 0; indice < listaFrutas.Length; indice++ )
        {
            Console.WriteLine(listaFrutas[indice]);
        }

        /****************************************************************/
        foreach (string fruta in listaFrutas)
        {
            Console.WriteLine(fruta);
        }



    }
}