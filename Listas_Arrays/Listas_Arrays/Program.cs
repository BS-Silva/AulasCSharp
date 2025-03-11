namespace Listas_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            double[] notas = new double[5];
            string[] arrayFrutas = {"Banana","Maça","Pêra"};

           // string nome = "158.86";

           // Console.WriteLine(nome.Replace(".",""));
       

           // Console.WriteLine(arrayFrutas.Length);

            List<string> fruitList = new List<string>();

            fruitList.Add("Banana");
            fruitList.Add("Maça");
            fruitList.Add("Pêra");

           // fruitList.Remove("Banana");

            //Console.WriteLine(string.Join(",", fruitList));

           // foreach(string fruta in arrayFrutas)
            {
           //     Console.WriteLine(fruta);
            }

            // fruitList.ForEach(fruta => Console.WriteLine(fruta));

            Aluno aluno1 = new Aluno("Anne", 445467, "Transforme-se", "anee@go", "11944647766");
            Aluno aluno2 = new Aluno("Bruna", 445467, "Transforme-se", "bruna@go", "11944647766");
            Aluno aluno3 = new Aluno("Luis", 445467, "Transforme-se", "luis@go", "11944647766");
        
            List<Aluno> listaAlunos = new List<Aluno>();

            listaAlunos.Add(aluno1);
            listaAlunos.Add(aluno2);
            listaAlunos.Add(aluno3);

            foreach (Aluno aluno in listaAlunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Matrícula: {aluno.Matricula}");
                Console.WriteLine($"Telefone: {aluno.Telefone}");
                Console.WriteLine();


            }
        }
    }
}
