const string nombreComercio = "KIOSCO EL RECREO";
Console.Write("Ingrese  su nombre : ");
string nombre = Console.ReadLine();
Console.WriteLine($"==={nombreComercio}===");
Console.WriteLine($"Nombre del cajero :{nombre}");
Console.WriteLine($"bienvenida. {nombre }.Caja abierta");

//Console.Write("Ingrese el Producto:");
//string  producto =Console.ReadLine();
//Console.Write("ingrese su precio :");
//decimal precio =decimal.Parse(Console.ReadLine());
//Console.WriteLine($"Producto:{producto}. su precio es :${precio}");

decimal total = 0;
int cantidad = 0;
string hacer;
do
{  
    Console.WriteLine("Que desea hacer:");
    Console.WriteLine("1-Cargar un producto");
    Console.WriteLine("2-Cerrar la venta");//lo que muestra en el menu 
    hacer= Console.ReadLine();//leer las opciones que ingresa
    switch (hacer){
        case"1":
            Console.Write("Cargar un producto:");
            string producto = Console.ReadLine();
            Console.Write("Ingrese el precio: ");
             decimal precio = decimal.Parse(Console.ReadLine());
            cantidad++;//guardar la cantidad
            total+= precio;// guardar el precio
            break;
        case"2":
            Console.WriteLine("Cerrar la venta");
            break;
        default:
            Console.WriteLine("la opcion no reconocida.");
            break;
    }


} while (hacer!="2");// si fuera distinto que la opcion 2 entonces se devuelve
Console.WriteLine($"Cantidad de productos: {cantidad}");
Console.WriteLine($"Total: ${total}");

decimal descuento = 0;
if (total > 50000)
{
    descuento = total * 0.10m;
}
else if(total>20000)
{
    descuento = total * 0.05m;
}
else
{
    descuento = 0;
}

decimal totalFinal = total - (total * descuento);
Console.WriteLine($"Subtotal: ${total}");
Console.WriteLine($"Descuento aplicado: ${descuento}");
Console.WriteLine($"Total con descuento: ${totalFinal}");

string mediodepago;
decimal recargo = 0;
do
{
    Console.WriteLine();
    Console.WriteLine("medio de pago:");
    Console.WriteLine("1 - Efectivo");
    Console.WriteLine("2 - Débito");
    Console.WriteLine("3 - Crédito");
    mediodepago = Console.ReadLine()!;
    switch (mediodepago)
    {
        case "1":
            Console.WriteLine("Pago en efectivo.");
            descuento = totalFinal * 0.10m;
            totalFinal -= descuento;
            break;
        case "2":
            Console.WriteLine("Pago con débito.");
            descuento = 0;
            break;
        case "3":
            Console.WriteLine("Pago con crédito.");
            recargo = totalFinal * 0.15m;
            totalFinal += recargo;
            break;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }
} while (mediodepago != "1" && mediodepago != "2" && mediodepago != "3");

Console.WriteLine($"Total a pagar: ${totalFinal}");

Console.WriteLine();
for (int i = 0; i < 25; i++)
{
    Console.Write("-");
}

Console.WriteLine();
Console.WriteLine($"      {nombreComercio}");
for (int i = 0; i < 25; i++)
{
    Console.Write("-");
}

Console.WriteLine();
Console.WriteLine($"nombre del cajero:{nombre}");
Console.WriteLine($"Productos: {cantidad}");
Console.WriteLine($"Subtotal: {total}");
Console.WriteLine($"Descuento: {descuento}");
Console.WriteLine($"Recargo: {recargo}");

for (int i = 0; i < 25; i++)
{
    Console.Write("-");
}

Console.WriteLine();
Console.WriteLine($"TOTAL: {totalFinal}");

for (int i = 0; i < 25; i++)
{
    Console.Write("-");
}
g