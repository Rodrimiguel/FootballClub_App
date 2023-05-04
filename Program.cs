/*
Se pide para un club de futbol generar una lista de 22 jugadores. 
La clase jugador tiene Nombre, Apellido, Edad y Puesto (enumeraciòn arquero, defensor, mediocampista, delantero).

Se pide:
Ordenar alfabeticamente
Calcular el promedio de edad
Listar todos los arqueros
Buscar por apellido
*/


var equipo=new List<Jugador>();
var enzo=new Jugador("Enzo","Francescoli",34,Jugador.ePuesto.Delantero);
equipo.Add(enzo);
equipo.Add(new Jugador("German","Burgos",30,Jugador.ePuesto.Arquero));
equipo.Add(new Jugador("Roberto","Bonano",29,Jugador.ePuesto.Arquero));
equipo.Add(new Jugador("Hernan","Crespo",22,Jugador.ePuesto.Delantero));
equipo.Add(new Jugador("Ariel","Ortega",25,Jugador.ePuesto.Delantero));
equipo.Add(new Jugador("Hernan","Diaz",31,Jugador.ePuesto.Defensor));
equipo.Add(new Jugador("Leonardo","Astrada",31,Jugador.ePuesto.Mediocampista));
equipo.Add(new Jugador("Marcelo","Gallardo",25,Jugador.ePuesto.Mediocampista));
equipo.Add(new Jugador("Lionel","Messi",35,Jugador.ePuesto.Delantero));

Console.WriteLine($"Cantidad de jugadores: " + equipo.Count);
var equipoOrdenado=equipo.OrderBy(x=>x.Apellido); // ORDEN ALFABETICO / POR APELLIDO
foreach(var jug in equipoOrdenado){
    Console.BackgroundColor=ConsoleColor.Red; // MUESTRA COLOR DE FONDO ROJO
    Console.WriteLine($"Apellido: {jug.Apellido} Nombre: {jug.Nombre}  Edad: {jug.Edad} ");// ES INDEPENDIENTE ESTO, YA QUE LA FUNCION DE ESTO ES COMO LO MUESTRA.
    Console.BackgroundColor=ConsoleColor.White;                                            // EN LO QUE CONCIERNE A SI PRIMERO APELLIDO O NOMBRE.
}
Console.WriteLine($"Promedio de edad: {equipo.Average(x=>x.Edad)}  "); // IMPRIME POR PROMEDIO DE EDAD.

var arqueros=equipo.Where(x=> x.Puesto==Jugador.ePuesto.Arquero); // LISTAR TODOS LOS ARQUEROS.
foreach(var arquero in arqueros){
    Console.WriteLine($"Apellido: {arquero.Apellido} Nombre: {arquero.Nombre}  Edad: {arquero.Edad} "); 
}

var jugconApellidoMessi=equipo.Where(x=>x.Apellido.Equals("Bonano")); //lista con un elemento (NO SABE CUANTO ELEMENTOS VA A ENCONTRAR, SABEMOS QUE HAY UNO SOLO CON APELLIDO MESSI)
var lionel=equipo.Where(x=>x.Apellido.Equals("Messi")).First(); //ME DEVUELVE EL objeto del tipo jugador (EL PRIMERO) // FIRST --> DEVOLVEME EL PRIMERO.

Console.WriteLine($"Jugador: {lionel.Apellido}");

class Jugador{

    public Jugador(string Nombre,string Apellido,int Edad, ePuesto Puesto){
        this.Nombre=Nombre;
        this.Apellido=Apellido;
        this.Edad=Edad;
        this.Puesto=Puesto;
    }
    public string Nombre{get;set;}
    public string Apellido {get;set;}
    public int Edad {get;set;}

    public ePuesto Puesto{get;set;}

    public enum ePuesto{
        Arquero,
        Defensor,
        Mediocampista,
        Delantero
    }
}
