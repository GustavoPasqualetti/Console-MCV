namespace Console_MVC.Model
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        // caminho da pasta e do arquivo definido
        private const string PATH = "Database/Produt.csv";


        //  criar um construtor
        public Produto()
        {
            // obter o caminho da pasta
            string pasta = PATH.Split("/")[0];

            // se nao existir uma pasta Database, entao cria-se uma
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // se nao existir um arquivo csv no caminho, enato cria-se uma
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Produto> Ler()
        {
            // Instanciar uma lista de produto
            List<Produto> produtos = new List<Produto>();

            // array de string que recebe cada linha do csv-
            string[] linhas = File.ReadAllLines(PATH);

            foreach (string item in linhas)
            {
                string[] atributos = item.Split(";");

                // atributos[0] = "001"
                // atributos[1] = "coca"
                // atributos[2] = "6,50"

                Produto p = new Produto();

                p.Codigo = int.Parse(atributos[0]); //001
                p.Nome = atributos[1];  //coca
                p.Preco = float.Parse(atributos[2]); //6,50

                produtos.Add(p);

            }
            // retorna a lista de produtos
            return produtos;
        }

        // metodo para prepara a linha do csv
        public string PrepararLinhaCSV(Produto p)
        {
            return $"{p.Codigo};{p.Nome};{p.Preco}";
        }
        // metodo para inserir um produto no arquivo csv
        public void Inserir(Produto p)
        {
            //array 
            string[] linhas = {PrepararLinhaCSV(p)};

            //vai ate o arquivo e insere todas as linhas
            File.AppendAllLines(PATH, linhas);
        }
    }
}
