


/*Se agrega un nuevo requerimiento al sistema de fechas
 Se espera que pueda arrojar el monto de un presupuesto para 
desarrollo considerando la siguiente información. La hora de desarrollo será de $3000, el programador
trabajará 4 horas por día en el proyecto.
El estimo terminar con la incidencia en 10 días habiles, comenzando el 08 de abril del 2022*/

int[] fechasAbril = { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
string[] diasDelMes = { "Viernes", "Sabado", "Domingo", "Lunes", "Martes", "Miercoles", "Jueves" };
double precio, precioHoras = 3000.0;
int[] diasHabiles= new int[10];
int j = 0, k=0, horas =4;

for(int i = 0;i< fechasAbril.Length;i++)
{
    if (diasDelMes[i-k] != "Sabado" && diasDelMes[i-k] != "Domingo")
    {
        diasHabiles[j] = fechasAbril[i];
        j++;
    }
    if (i == 6) k = 7;
        
}

foreach(int a in diasHabiles)Console.WriteLine(a);

precio = precioHoras*horas*diasHabiles.Length;

Console.WriteLine(precio);




