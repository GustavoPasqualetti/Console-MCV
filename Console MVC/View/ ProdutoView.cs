using Console_MVC.Model;

namespace Console_MVC.View
{
    public class ProdutoView
    {
        //Metodo para exibir os dados da lista de produtos

        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"Codigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preco: {item.Preco:c}");
                Console.WriteLine($"");

            }
        }


        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();


            Console.WriteLine($"Informe o Codigo: ");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome:");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o Preco: ");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;
        }

    }
}
