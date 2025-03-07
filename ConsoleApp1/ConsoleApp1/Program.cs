namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto(2.50,500,"Lápis");
            Produto produto2 = new Produto(10.50,250,"Paçoca");
            Produto produto3 = new Produto(7.99,221,"Chá Matte");

            Console.WriteLine(produto1.getTotalProduct());
            Console.WriteLine(produto2.getTotalProduct());
            Console.WriteLine(produto3.getTotalProduct());
        }
    }
}
