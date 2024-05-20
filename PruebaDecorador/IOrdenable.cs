using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDecorador
{
    public interface IOrdenable
    {
        public decimal Precio {  get; set; }
        public int Ram {  get; set; }
        public int Almacenamiento { get; set; }
    }
}
