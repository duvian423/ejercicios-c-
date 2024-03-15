// See https://aka.ms/new-console-template for more information

//probar si los dos numeros son pares
//Console.WriteLine("ingresa el primer numero");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el segundo numero");
//int num2 = int.Parse(Console.ReadLine());

//if (num1 % 2 != 0)
//{
//    Console.WriteLine($"el numero {num1} no es par");
//}else
//{
//    Console.WriteLine($"el numero {num1} es par");
//}

//if (num2 % 2 != 0)
//{
//    Console.WriteLine($"el numero {num2} no es par");
//}
//else
//{
//    Console.WriteLine($"el numero {num2} es par");
//}

//-----------------------------------------------------------------------------

//programa que solicite edad y genero y diga si se puede jubilar o no 
//Console.WriteLine("digite su edad");
//int edad = int.Parse(Console.ReadLine());

//Console.WriteLine("genero");
//Console.WriteLine("digite m para masculino \n digite f para femenino ");
//string genero = Console.ReadLine();

//int edadHombre = 60;
//int edadMujer = 55;

//if(genero == "m")
//{
//    if (edad >= edadHombre)
//    {
//        Console.WriteLine("puedes jubilarte");
//    }
//    else
//    {
//        Console.WriteLine("aun no puedes jubilarte");
//    }
//}else if(genero == "f")
//{
//    if(edad >= edadMujer)
//    {
//        Console.WriteLine("puedes jubilarte");
//    }else
//    {
//        Console.WriteLine("aun no puedes jubilarte");
//    }
//}

//-----------------------------------------------------------------------------

//mirar si un año es biciesto
//Console.WriteLine("digite un año");
//int año = int.Parse(Console.ReadLine());

//if (año %4 == 0 && año %100 != 0 || año %400 == 0)
//{
//    Console.WriteLine($"el año {año} es biciesto");
//}else
//{
//    Console.WriteLine($"el año {año} no es biciesto");
//}

//-----------------------------------------------------------------------------

//descuento de cine
//Console.WriteLine("digita tu nombre");
//string nom = Console.ReadLine();

//Console.WriteLine("digita tu edad");
//int edad = int.Parse(Console.ReadLine());

//if(edad < 18 || edad > 60)
//{
//    Console.WriteLine($"{nom} tienes un descuento");
//}else
//{
//    Console.WriteLine($"{nom} no tienes descuento");
//}

//-----------------------------------------------------------------------------

//login
//string usuario = "usuario";
//string password = "1234";

//Console.WriteLine("digite su usuario");
//string nom = Console.ReadLine();

//Console.WriteLine("digite su contraseña");
//string contra = Console.ReadLine();

//if(nom == usuario && contra == password)
//{
//    Console.WriteLine("Bienvenido");
//}
//else
//{
//    Console.WriteLine("NO tienes acceso");
//}

//-----------------------------------------------------------------------------

//saber si un numero es negativo
//Console.WriteLine("digita el primer numero");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("digita el segundo numero");
//int num2 = int.Parse(Console.ReadLine());

//Console.WriteLine("digita el tercer numero");
//int num3 = int.Parse(Console.ReadLine());

//if(num1 < 0)
//{
//    Console.WriteLine($"el numero {num1} es negativo");
//}else
//{
//    Console.WriteLine($"el numero {num1} no es negativo");
//}

//if (num2 < 0)
//{
//    Console.WriteLine($"el numero {num2} es negativo");
//}
//else
//{
//    Console.WriteLine($"el numero {num2} no es negativo");
//}

//if (num3 < 0)
//{
//    Console.WriteLine($"el numero {num3} es negativo");
//}
//else
//{
//    Console.WriteLine($"el numero {num3} no es negativo");
//}

//------------------------------------------------------------------------------------

//convertir grados celcius a farenheit
//Console.WriteLine("ingresa los grados celcius");
//double celsius = double.Parse(Console.ReadLine());

//double farenheit = ((9 * celsius) / 5) + 32;

//Console.WriteLine($"{celsius} grados celsius serian {farenheit} grados farenheit");

//-----------------------------------------------------------------------------

//saber si el mes es halowen o navidad
//string hallowen = "10";
//string navidad = "12";

//Console.WriteLine("digite un numero para escoger un mes \n teniendo en cuenta que \n" +
//    "1: enero \n 2: febrero \n 3: marzo \n 4: abril \n 5: mayo \n 6: junio \n" +
//    "7: julio \n 8: agosto \n 9: septiembre \n 10: cotubre \n 11: noviembre \n 12: diciembre \n");

//string mes = Console.ReadLine();

//if (mes == hallowen)
//{
//    Console.WriteLine("octubre es el mes de hallowen!! ");
//}else if(mes == navidad)
//{
//    Console.WriteLine("diciembre es el mes de la navidad!!");
//}else
//{
//    Console.WriteLine("este mes no es ni hallowen ni navidad  :(");
//}

//-----------------------------------------------------------------------------

//determinar que tipo de triangulo es
//Console.WriteLine("ingresa las longitudes del triangulo");

//Console.WriteLine("ingresa la primera longitud");
//double lado1 = double.Parse(Console.ReadLine());

//Console.WriteLine("ingresa la segunda longitud");
//double lado2 = double.Parse(Console.ReadLine());

//Console.WriteLine("ingresa la tercera longitud");
//double lado3 = double.Parse(Console.ReadLine());

//if(lado1 == lado2 && lado2== lado3  )
//{
//    Console.WriteLine("este es un triangulo equilatero");
//}else if(lado1 == lado2 && lado2 != lado3 || lado1 != lado2 && lado1 == lado3 )
//{
//    Console.WriteLine("este es un triangulo isosceles");
//}
//else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
//{
//    Console.WriteLine("este es un triangulo escaleno");
//}

//-----------------------------------------------------------------------------

//saber si los numeros ingresados son menores a 10
//Console.WriteLine("ingresa los numeros");

//Console.WriteLine("ingresa el primer numero");
//double num1 = double.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el segundo numero");
//double num2 = double.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el tercer numero");
//double num3 = double.Parse(Console.ReadLine());

//if(num1<10)
//{
//    Console.WriteLine($"{num1} es menor que 10");
//}else if(num1 == 10)
//{
//    Console.WriteLine($"tu numero es 10");
//}
//else
//{
//    Console.WriteLine($"{num1} es mayor que 10");
//}

//if (num2 < 10)
//{
//    Console.WriteLine($"{num2} es menor que 10");
//}
//else if (num2 == 10)
//{
//    Console.WriteLine($"tu numero es 10");
//}
//else
//{
//    Console.WriteLine($"{num2} es mayor que 10");
//}

//if (num3 < 10)
//{
//    Console.WriteLine($"{num3} es menor que 10");
//}
//else if (num3 == 10)
//{
//    Console.WriteLine($"tu numero es 10");
//}
//else
//{
//    Console.WriteLine($"{num3} es mayor que 10");
//}

//-----------------------------------------------------------------------------

//total de la factura
//Console.WriteLine("digite cuanto fue el total de la compra:");
//double cuenta = double.Parse(Console.ReadLine());

//Console.WriteLine("que porcentaje desea dar de propina?");
//double propina = double.Parse(Console.ReadLine());

//double porcentaje = (cuenta * propina) / 100;

//double cuentaTotal = cuenta + porcentaje;

//Console.WriteLine($"su total a pagar es ${cuentaTotal} gracias por su compra");

//-----------------------------------------------------------------------------

//cuanto vale el producto con el descuento 
//Console.WriteLine("cuanto es el precio del producto");
//double precioProducto = double.Parse(Console.ReadLine());

//Console.WriteLine("cuanto descuento tiene?");
//double descuento = double.Parse(Console.ReadLine());

//double totalDescuento = (precioProducto * descuento) / 100;

//double totalPagar = precioProducto - totalDescuento;

//Console.WriteLine($"su producto tiene un precio al final de {totalPagar}");

//-----------------------------------------------------------------------------

//sumar y multiplicar si son iguales
//Console.WriteLine("ingresa tus tres numeros");

//Console.WriteLine("ingresa el primer numero");
//double num1 = double.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el segundo numero");
//double num2 = double.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el tercer numero");
//double num3 = double.Parse(Console.ReadLine());

//if(num1 == num2 && num2 == num3)
//{
//    Console.WriteLine((num1 + num2)* num3);
//}

//-----------------------------------------------------------------------------

//



