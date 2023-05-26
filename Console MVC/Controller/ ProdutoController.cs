using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        // instanciar objeto produto e ProdutoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        //Metodo controlador para acessar a listagem de produtos
        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }

        public void CadastrarProduto()
        {
            Produto novoProduto = produtoView.Cadastrar();

            produto.Inserir(novoProduto);
        }
    }
}