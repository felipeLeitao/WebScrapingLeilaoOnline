using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importamos o htmlAgilityPack para a nossa classe, assim comnseguimos
//Usar suas classes
using HtmlAgilityPack;

namespace NetCoders.WebScrapping
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseUrl = "http://www.freitasleiloesonline.com.br";

            var urlHome = "/homesite/filtro.asp?q=materiais";

            //Através deste objeto, vamos se conectar a sites e carregar seus dados
            var client = new HtmlWeb();

            var paginaPrincipal = client.Load(baseUrl + urlHome, "GET").DocumentNode;

            //Aqui estamos pegando a div que contem todos os quadradinhos que informam as páginas
            var divListaLotesPaginacao = paginaPrincipal.SelectSingleNode("//*[@id='listaLotesPaginacao']");

            var ultimaPaginaTexto = divListaLotesPaginacao.SelectNodes("./ul/li").Last().SelectSingleNode("./span").InnerText;

            var ultimaPagina = Convert.ToInt16(ultimaPaginaTexto);

            //Aqui no lugar 2, deveriamos colocar a variavel ultimaPagina,
            //não vamos colocar porquê a internet é ruim (vivo)
            for (int i = 1; i <= 2; i++)
            {
                var urlCorrente = "/homesite/filtro.asp?q=materiais&txBuscar=088&CodSubCategoria=&SubCategoria=&UF=&CodCondicao=&Condicao=&OptValores=0&LblValores=&pagina=" + i;

                var paginaCorrente = client.Load(baseUrl + urlCorrente, "GET").DocumentNode;

                var listaItens = paginaCorrente.SelectSingleNode("//*[@id='listaLotes']").SelectNodes("./ul/li");

                Console.WriteLine(listaItens.Count);
            }

            Console.ReadKey();
        }
    }
}
