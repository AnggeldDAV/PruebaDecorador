
using PruebaDecorador;

IOrdenable OrdenadorBase = new OrdenadorBase();
IOrdenable OrdenadorRam = new OrdenadorDecoradorRamMaxima(OrdenadorBase);
IOrdenable OrdenadorDisco = new OrdenadorDecoradorDiscoSolido(OrdenadorBase);

IOrdenable OrdenadorManolo = OrdenadorBase;
IOrdenable OrdenadorAna = OrdenadorRam;
IOrdenable OrdenadorLuisa = new OrdenadorDecoradorDiscoSolido(OrdenadorRam);
IOrdenable OrdenadorGeronimo = new OrdenadorDecoradorAverSiCuela(OrdenadorDisco);

Console.WriteLine(OrdenadorManolo);
Console.WriteLine(OrdenadorAna);
Console.WriteLine(OrdenadorLuisa);
Console.WriteLine(OrdenadorGeronimo);