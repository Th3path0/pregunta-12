using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace chaparrin
{
 class Program
 {
 static void Main(string[] args)
 {

int coke=10,pepsi=10,granola=10,dasani=10,choco=10,oreo=10,lay=10,crack=10,muf=10,jug=10;
 int op,V,h = 0, p = 0, s = 0, sl = 0;
 double a, b, c, d, e, suma=0;
 do
 {
 Console.WriteLine("\n\t\t maquina expendedora *Hola* ");
 Console.WriteLine("el dinero que inserto es :" + suma);
 Console.WriteLine("\n\t\t Inserte monedas o billetes antes de empezar ");

 Console.WriteLine("\n\t\t 1.-Inserte monedas y billetes ");
 Console.WriteLine("\n\t\t 2.- Elegir producto (la cuota minima es de $8)");
 Console.WriteLine("\n\t\t 3.- SALIR");
 Console.Write("\n\t\t opcion: ");
 V = Convert.ToInt16(Console.ReadLine());
 if (V == 1)
 {
 Console.Clear();
Console.Write("\n\t\t inserte la(s) moneda(s) de 50 centavos:");
 a = Convert.ToDouble(Console.ReadLine());
 suma = suma + a * 0.5;
Console.Write("\n\t\t inserte la(s) moneda(s) de 1 pesos: ");
b = Convert.ToDouble(Console.ReadLine());
 suma = suma + b * 1;
Console.Write("\n\t\t inserte la(s) moneda(s) de 2 pesos: ");
c = Convert.ToDouble(Console.ReadLine());
 suma = suma + c * 2;
Console.Write("\n\t\t inserte la(s) moneda(s) de 5 pesos: ");
d = Convert.ToDouble(Console.ReadLine());
 suma = suma + d * 5;
Console.Write("\n\t\t inserte la(s) moneda(s) de 10 pesos: ");
e = Convert.ToDouble(Console.ReadLine());
 suma = suma + e * 10;
Console.Clear();
 }
 
 if (V == 2)
 {
 if (suma >= 8)
{
 Console.Clear();
Console.WriteLine("\n\t seleccione el refresco");
Console.WriteLine("\n\t 1.- Coca Cola");
Console.WriteLine("\n\t 2.- Barra de granola");
Console.WriteLine("\n\t 3.- Agua Dasani");
Console.WriteLine("\n\t 4.- Pepsi Kick");
Console.WriteLine("\n\t 5.- Chocolate Hershey");
Console.WriteLine("\n\t 6.- Galletas Oreo");
Console.WriteLine("\n\t 7.- Papas Lays");
Console.WriteLine("\n\t 8.- Crackers");
Console.WriteLine("\n\t 9.- Muffin de chocolate");
Console.WriteLine("\n\t 10.- Jugos Santal");
Console.Write("\n\t cual es su opcion 1-10: ");
op = Convert.ToInt32(Console.ReadLine());
 if (op == 1)
{
 Console.Clear();
Console.WriteLine("se ha despachado una Coca cola (existencia: {10})",coke); 
Console.WriteLine("Precio:20");
coke=coke-1;
suma = suma - 20;
Console.WriteLine("su cambio es de " + suma);
h++;
Console.ReadKey();
Console.Clear();
 }
if (op == 2)
{
 Console.Clear();
Console.WriteLine("se ha despachado una Barra de granola (existencia: {10})",granola); 
Console.WriteLine("Precio:10");
granola=granola-1;
suma = suma - 10;
Console.WriteLine("su cambio es de " + suma);
p++;
Console.ReadKey();
Console.Clear();
 }
if (op == 3)
{
 Console.Clear();
Console.WriteLine("se ha despachado una coca cola (existencia: {10})",dasani); 
Console.WriteLine("Precio: 15");
dasani=dasani-1;
suma = suma - 15;
 Console.WriteLine("su cambio es de " + suma);
s++;
Console.ReadKey();
Console.Clear();
 }
if (op == 4)
{
 Console.Clear();
 Console.WriteLine("se ha despachado una Pepsi Kick (existencia: {10})",pepsi); 
Console.WriteLine("Precio:25");
pepsi=pepsi-1;
suma = suma - 25;
Console.WriteLine("su cambio es de " + suma);
sl++;
Console.ReadKey();
Console.Clear();
 }
 if (op == 5)
{
 Console.Clear();
 Console.WriteLine("se ha despachado una Chocolate Hershey (existencia: {10})",choco); 
Console.WriteLine("Precio:50");
choco=choco-1;
suma = suma - 50;
Console.WriteLine("su cambio es de " + suma);
sl++;
Console.ReadKey();
Console.Clear();
 }
if (op == 6)
{
 Console.Clear();
 Console.WriteLine("se ha despachado una Galleta Oreo (existencia: {10})",oreo); 
Console.WriteLine("Precio:15");
oreo=oreo-1;
suma = suma - 15;
Console.WriteLine("su cambio es de " + suma);
sl++;
Console.ReadKey();
Console.Clear();
 }
if (op == 7)
{
 Console.Clear();
 Console.WriteLine("se ha despachado unas Papas Lays (existencia: {10})",lay); 
Console.WriteLine("Precio:25");
lay=lay-1;
suma = suma - 25;
Console.WriteLine("su cambio es de " + suma);
sl++;
Console.ReadKey();
Console.Clear();
 }
if (op == 8)
{
 Console.Clear();
 Console.WriteLine("se ha despachado unas Crackers (existencia: {10})",crack); 
Console.WriteLine("Precio:18");
crack=crack-1;
suma = suma - 18;
Console.WriteLine("su cambio es de " + suma);
sl++;
Console.ReadKey();
Console.Clear();
 }
if (op == 9)
{
 Console.Clear();
 Console.WriteLine("se ha despachado un Muffin (existencia: {10})",muf); 
Console.WriteLine("Precio:35");
muf=muf-1;
suma = suma - 35;
Console.WriteLine("su cambio es de " + suma);
sl++;
Console.ReadKey();
Console.Clear();
 }
if (op == 10)
{
 Console.Clear();
 Console.WriteLine("se ha despachado un Jugo (existencia: {10})",jug); 
Console.WriteLine("Precio:30");
pepsi=pepsi-1;
suma = suma - 25;
Console.WriteLine("su cambio es de " + suma);
sl++;
Console.ReadKey();
Console.Clear();
 }

 }
else
{
 Console.WriteLine("inserte mas monedas");
Console.WriteLine("el dinero que inserto es :" + suma);
 }
 }
 if (V == 3)
 {
Console.WriteLine("Imprimir informe");
if (coke<10){Console.WriteLine("\n Se ha vendido una Coca-cola, exist. {0}",coke);} 
if (granola<10){Console.WriteLine("\n Se ha vendido una Barra de granola, exist. {0}",granola);}
if (dasani<10){Console.WriteLine("\n Se ha vendido una Agua Dasani, exist. {0}",dasani);}
if (pepsi<10){Console.WriteLine("\n Se ha vendido una Pepsi Kid, exist. {0}",pepsi);}
if (choco<10){Console.WriteLine("\n Se ha vendido un Chocolate Hershey, exist. {0}",choco);}
if (oreo<10){Console.WriteLine("\n Se ha vendido una Galleta Oreo, exist. {0}",oreo);}
if (lay<10){Console.WriteLine("\n Se han vendido unas papas, exist. {0}",lay);}
if (crack<10){Console.WriteLine("\n Se ha vendido una Galleta Crack, exist. {0}",crack);}
if (muf<10){Console.WriteLine("\n Se ha vendido un Muffin de chocolate, exist. {0}",muf);}
if (jug<10){Console.WriteLine("\n Se ha vendido un Jugo Santal, exist. {0}",jug);}


 Environment.Exit(0);
 }
 } while (V != 3);

 }
 

 }
}




