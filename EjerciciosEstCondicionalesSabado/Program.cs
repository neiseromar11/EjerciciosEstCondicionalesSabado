// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese la cantidad de trajes");
int trajes=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el precio unitario por traje");
double preciou=double.Parse(Console.ReadLine());

double sub, descuento, total;

if (trajes == 1)
{

   descuento = 0.5;
}
else if (trajes == 2)
{

    descuento = 0.55;
}

else if (trajes == 3)
{ 

    descuento = 0.6;

}
else {

    descuento = 0.65;
}


sub = trajes * preciou;
double descuentom = sub * descuento;
total = sub - descuentom;
Console.WriteLine("subtotal a pagar : "+sub+ "\n" +
    "Descuento aplicado:"+ descuentom +"\n"
    +"Total a pagar: "+ total);