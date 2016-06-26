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

            var ultimaPagina = divListaLotesPaginacao.SelectNodes("./ul/li").Last().SelectSingleNode("./span").InnerText;


        }
    }
}
