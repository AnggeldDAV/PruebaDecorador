using PruebaDecorador;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDecorador
{
    public class OrdenadorBase : IOrdenable
    {
        public decimal Precio { get; set; } = 100;
        public int Ram { get; set; } = 10;
        public int Almacenamiento { get; set; } = 100;
        public override string ToString()
        {
            return $"OrdenadorBase, precio {this.Precio}, Ram {this.Ram}, Almacenamiento {this.Almacenamiento}";
        }
    }
    public class OrdenadorDecoradorRamMaxima : IOrdenable
    {
        IOrdenable PC;
        public OrdenadorDecoradorRamMaxima(IOrdenable pc)
        {
            this.PC = pc;
        }
        public decimal Precio { get { return this.PC.Precio + 200; } set { } }
        public int Ram { get; set; } = 100;
        public int Almacenamiento { get { return this.PC.Almacenamiento; } set { } }
        public override string ToString()
        {
            return $"OrdenadorRam, precio {this.Precio}, Ram {this.Ram}, Almacenamiento {this.Almacenamiento}";
        }

    }
    public class OrdenadorDecoradorDiscoSolido : IOrdenable
    {
        IOrdenable PC;
        public OrdenadorDecoradorDiscoSolido(IOrdenable pc)
        {
            this.PC = pc;
        }
        public decimal Precio { get { return this.PC.Precio+100; } set { } }
        public int Ram { get { return this.PC.Ram; } set { } }
        public int Almacenamiento { get { return this.PC.Almacenamiento*2; } set { } }
        public override string ToString()
        {
            return $"OrdenadorDisco, precio {this.Precio}, Ram {this.Ram}, Almacenamiento {this.Almacenamiento}";
        }
    }
    public class OrdenadorDecoradorAverSiCuela : IOrdenable
    {
        IOrdenable PC;
        public OrdenadorDecoradorAverSiCuela(IOrdenable pc)
        {
            this.PC = pc;
        }
        public decimal Precio { get { return this.PC.Precio*2; } set { } }
        public int Ram { get { return this.PC.Ram; } set { } }
        public int Almacenamiento { get { return this.PC.Almacenamiento; } set { } }
        public override string ToString()
        {
            return $"OrdenadorSicuela, precio {this.Precio}, Ram {this.Ram}, Almacenamiento {this.Almacenamiento}";
        }
    }
    //Otro decorador, es la super bomba que multiplica la potencia de fuego por 10.
    public class DecoradorGigaRam : IOrdenable
    { 
    IOrdenable PC;
    public DecoradorGigaRam(IOrdenable pc)
        {
            this.PC = pc;
        }
        public decimal Precio { get { return this.PC.Precio; } set { } }
        public int Ram { get { return ((this.PC.Ram *10)/100)+this.PC.Ram; }set { } }
        public int Almacenamiento { get { return this.PC.Almacenamiento; } set { } }
        public override string ToString()
        {
            return $"OrdenadorGigaRam, precio {this.Precio}, Ram {this.Ram}, Almacenamiento {this.Almacenamiento}";
        }
    }
    public class DecoradorOferta  : IOrdenable
    {
        IOrdenable PC;
        public DecoradorOferta(IOrdenable pc)
        {
            this.PC = pc;
        }
        public decimal Precio { get 
            {
                var oferta = (this.PC.Precio *20) /100;
                return this.PC.Precio - oferta; 
            } set { } }

        public int Ram { get { return this.PC.Ram; } set { } }
        public int Almacenamiento { get { return this.PC.Almacenamiento; } set { } }
        public override string ToString()
        {
            return $"Oferton, precio {this.Precio}, Ram {this.Ram}, Almacenamiento {this.Almacenamiento}";
        }
    }
    public class DecoradorTera : IOrdenable
    {
        IOrdenable PC;
        public DecoradorTera(IOrdenable pc)
        {
            this.PC = pc;
        }
        public decimal Precio { get { return this.PC.Precio +500; } set {} }
        public int Ram { get { return this.PC.Ram; } set {} }
        public int Almacenamiento { get { return this.PC.Almacenamiento + 1000; } set {} }
        public override string ToString()
        {
            return $"OrdenadorTera, precio {this.Precio}, Ram {this.Ram}, Almacenamiento {this.Almacenamiento}";
        }
    }
}
