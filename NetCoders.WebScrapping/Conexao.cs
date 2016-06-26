using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;


namespace NetCoders.WebScrapping
{
    public class Conexao : DbContext
    {
        //Método construtor é um método que é chamado, sempre que um objeto desta classe é criado
        public Conexao() : base(@"Data Source = (localdb)\v11.0; Initial Catalog= MaterialLeilao; Integrated Security= true")
        {

        }

        public DbSet<MaterialMOD> Material { get; set; }
    }
}
