
using PruebaDecorador;

IOrdenable OrdenadorManolo = new OrdenadorBase();
IOrdenable OrdenadorAna = new OrdenadorDecoradorRamMaxima(new OrdenadorBase());
IOrdenable OrdenadorLuisa = new OrdenadorDecoradorDiscoSolido(new OrdenadorDecoradorRamMaxima(new OrdenadorBase()));
IOrdenable OrdenadorGeronimo = new OrdenadorDecoradorAverSiCuela(new OrdenadorDecoradorDiscoSolido(new OrdenadorBase()));

IOrdenable OrdenadorTocho = new DecoradorOferta(new DecoradorTera(new DecoradorGigaRam(new OrdenadorBase())));

Console.WriteLine(OrdenadorManolo);
Console.WriteLine(OrdenadorAna);
Console.WriteLine(OrdenadorLuisa);
Console.WriteLine(OrdenadorGeronimo);
Console.WriteLine(OrdenadorTocho);