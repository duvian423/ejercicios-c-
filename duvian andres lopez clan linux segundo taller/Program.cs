// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
//1.Verifica si un número es positivo.---------------------------------------------------------
//Console.WriteLine("digite un numero");
//double num = double.Parse(Console.ReadLine());

//if(num > 0)
//{
//    Console.WriteLine("su numero es positivo");
//}else
//{
//    Console.WriteLine("su numero es negativo");
//}



//2. Verifica si un número es negativo.--------------------------------------------------------
//Console.WriteLine("digite un numero");
//double num = double.Parse(Console.ReadLine());

//if (num < 0)
//{
//    Console.WriteLine("su numero es negativo");
//}
//else
//{
//    Console.WriteLine("su numero es positivo");
//}



//3. Comprueba si un número es par.------------------------------------------------------------
//Console.WriteLine("digite un numero");
//double num = double.Parse(Console.ReadLine());

//if (num % 2 == 0)
//{
//    Console.WriteLine("su numero es par");
//}
//else
//{
//    Console.WriteLine("su numero es impar");
//}



//4. Comprueba si un número es impar.----------------------------------------------------------
//Console.WriteLine("digite un numero");
//double num = double.Parse(Console.ReadLine());

//if (num % 2 != 0)
//{
//    Console.WriteLine("su numero es impar");
//}
//else
//{
//    Console.WriteLine("su numero es par");
//}



//5. Determina si un número es múltiplo de 5.--------------------------------------------------
//Console.WriteLine("digite un numero");
//double num = double.Parse(Console.ReadLine());

//if (num % 5 == 0)
//{
//    Console.WriteLine("su numero es multiplo de 5");
//}
//else
//{
//    Console.WriteLine("su numero no es multiplo de 5");
//}



//6. Verifica si un número es divisible entre 3.-----------------------------------------------
//Console.WriteLine("digite un numero");
//double num = double.Parse(Console.ReadLine());

//if (num % 3 == 0)
//{
//    Console.WriteLine("su numero es divicible de 3");
//}
//else
//{
//    Console.WriteLine("su numero no es divicible de 3");
//}



//7. Determina si un número es mayor que 100.--------------------------------------------------
//Console.WriteLine("digite un numero");
//int num = int.Parse(Console.ReadLine());

//if (num > 100)
//{
//    Console.WriteLine("su numero es mayor a 100");
//}
//else
//{
//    Console.WriteLine("su numero es menor de 100");
//}



//8. Verifica si un número es menor que -50.---------------------------------------------------
//Console.WriteLine("digite un numero");
//int num = int.Parse(Console.ReadLine());

//if (num < -50)
//{
//    Console.WriteLine("su numero es menor a -50");
//}
//else
//{
//    Console.WriteLine("su numero es mayor a -50");
//}




//9. Comprueba si un número está en el rango de 20 a 50.---------------------------------------
//Console.WriteLine("digite un numero");
//int num = int.Parse(Console.ReadLine());

//if (num > 20 && num < 50)
//{
//    Console.WriteLine("su numero esta entre el rando de 20 a 50");
//}
//else
//{
//    Console.WriteLine("su numero no esta entre el rando de 20 a 50");
//}



//10.Determina si un número es igual a 0.------------------------------------------------------
//Console.WriteLine("digite un numero");
//int num = int.Parse(Console.ReadLine());

//if (num == 0)
//{
//    Console.WriteLine("su numero es 0");
//}
//else
//{
//    Console.WriteLine("su numero no es 0");
//}



//11.Verifica si un número es mayor que -10 y menor que 10.------------------------------------
//Console.WriteLine("digite un numero");
//int num = int.Parse(Console.ReadLine());

//if (num > -10 && num < 10)
//{
//    Console.WriteLine("su numero esta entre el rando de -10 a 10");
//}
//else
//{
//    Console.WriteLine("su numero no esta entre el rando de -10 a 10");
//}



//12.Determina si un número es un año bisiesto.------------------------------------------------




//13.Verifica si una persona es mayor de edad (mayor o igual a 18 años).-----------------------
//Console.WriteLine("ingresa tu edad");
//int edad = int.Parse(Console.ReadLine());

//if(edad > 18)
//{
//    Console.WriteLine("eres mayor de edad");
//}else
//{
//    Console.WriteLine("no eres mayor de edad");
//}



//15.Verifica si un número es un cuadrado perfecto.--------------------------------------------




//16.Determina si un número es un número de Fibonacci------------------------------------------




//17.Verifica si un número es una potencia de 2.-----------------------------------------------
//Console.WriteLine("escribe un numero");
//int num = int.Parse(Console.ReadLine());

//if(num %2 == 0)
//{
//    Console.WriteLine($"{num} es potencia de 2");
//}
//else
//{
//    Console.WriteLine($"{num} no es potencia de 2");
//}



//18.Determina si un número es un palíndromo.--------------------------------------------------




//19.Verifica si una cadena de texto contiene la palabra "JavaScript".-------------------------
//string text = "c# es un lenguaje de programacion distinto de javascript ";

//Console.WriteLine(text.Contains("javascript"));



//20.Determina si una cadena tiene más de 10 caracteres.---------------------------------------
//string text = "esto es un texto";
//int caracteres = text.Length;
//if(caracteres == 10)
//{
//    Console.WriteLine("este texto tiene 10 caracteres");
//}
//else
//{
//    Console.WriteLine("este texto no tiene 10 caracteres");
//}


//21.Verifica si una cadena de texto está en minúsculas.---------------------------------------
//string text = "esto es una cadena de texto";

//if (text == text.ToLower())
//{
//    Console.WriteLine("este texto esta todo en minuscula");
//}
//else
//{
//    Console.WriteLine("este texto tiene mayusculas");
//}



//22.Determina si una cadena de texto contiene al menos un número.-----------------------------
//string text = "este texto tiene 1 entero";

//int resultado = 0;

//bool entero = int.TryParse(text, out  resultado);

//Console.WriteLine(entero);


//23.Verifica si una cadena de texto termina con un punto (.).---------------------------------
//string text = "este texto solo va tener un punto.";

//Console.WriteLine(text.Contains("."));


//24.Determina si una cadena de texto es un pangrama (contiene todas
//las letras del alfabeto).--------------------------------------------------------------------




//25.Verifica si un día de la semana es laborable (de lunes a viernes).------------------------
//Console.WriteLine("digita un dia de la semana ");
//string dia = Console.ReadLine();

//if (dia == "")
//{
//    Console.WriteLine("no dijitaste nada");
//}
//else
//{
//    switch (dia)
//    {
//        case "lunes":
//            Console.WriteLine("este dia puedes laborar");
//            break;

//        case "martes":
//            Console.WriteLine("este dia puedes laborar");
//            break;

//        case "miercoles":
//            Console.WriteLine("este dia puedes laborar");
//            break;

//        case "jueves":
//            Console.WriteLine("este dia puedes laborar");
//            break;

//        case "viernes":
//            Console.WriteLine("este dia puedes laborar");
//            break;

//        case "sabado":
//            Console.WriteLine("este dia es no es laborable");
//            break;

//        case "domingo":
//            Console.WriteLine("este dia es no es laborable");
//            break;

//        default:
//            Console.WriteLine("no has elegido un valor valido se cierra el programa");
//            break;
//    }
//}



//26.Determina si un día es fin de semana (sábado o domingo).----------------------------------
//Console.WriteLine("digita un dia de la semana ");
//string dia = Console.ReadLine();

//if (dia == "")
//{
//    Console.WriteLine("no dijitaste nada");
//}
//else
//{
//    switch (dia)
//    {
//        case "lunes":
//            Console.WriteLine("este dia no es fin de semana");
//            break;

//        case "martes":
//            Console.WriteLine("este dia no es fin de semana");
//            break;

//        case "miercoles":
//            Console.WriteLine("este dia no es fin de semana");
//            break;

//        case "jueves":
//            Console.WriteLine("este dia no es fin de semana");
//            break;

//        case "viernes":
//            Console.WriteLine("este dia no es fin de semana");
//            break;

//        case "sabado":
//            Console.WriteLine("este dia es fin de semana");
//            break;

//        case "domingo":
//            Console.WriteLine("este dia es fin de semana");
//            break;

//        default:
//            Console.WriteLine("no has elegido un valor valido se cierra el programa");
//            break;
//    }
//}



//27.Verifica si un número representa un mes válido (del 1 al 12).-----------------------------
//Console.WriteLine("digita un numero para verificar que mes es:");
//string numDia = Console.ReadLine();

//if(numDia != "" )
//{
//    switch(numDia)
//    {
//        case "1":
//            Console.WriteLine("este seria el mes de enero");
//            break;

//        case "2":
//            Console.WriteLine("este seria el mes de febrero");
//            break;

//        case "3":
//            Console.WriteLine("este seria el mes de marzo");
//            break;

//        case "4":
//            Console.WriteLine("este seria el mes de abril");
//            break;

//        case "5":
//            Console.WriteLine("este seria el mes de mayo");
//            break;

//        case "6":
//            Console.WriteLine("este seria el mes de junio");
//            break;

//        case "7":
//            Console.WriteLine("este seria el mes de julio");
//            break;

//        case "8":
//            Console.WriteLine("este seria el mes de agosto");
//            break;

//        case "9":
//            Console.WriteLine("este seria el mes de septiembre");
//            break;

//        case "10":
//            Console.WriteLine("este seria el mes de octubre");
//            break;

//        case "11":
//            Console.WriteLine("este seria el mes de noviembre");
//            break;

//        case "12":
//            Console.WriteLine("este seria el mes de diciembre");
//            break;

//        default:
//            Console.WriteLine("tu numero no corresponde a ningun mes");
//            break;
//    }
//}else
//{
//    Console.WriteLine("no dijitaste ningun valor");
//}



//28.Determina si una hora está en el rango de 9 AM a 6 PM.------------------------------------




//29.Verifica si una persona es mayor de 65 años o menor de 18 años.---------------------------
//Console.WriteLine("digita tu edad");
//string entradaEdad = Console.ReadLine();
//int edad;
//bool success = int.TryParse(entradaEdad, out edad);

//if(edad > 65)
//{
//    Console.WriteLine("eres mayor de 65 años");
//}else if(edad < 18 && edad > 0)
//{
//    Console.WriteLine("eres menor de 18 años");
//}else if(edad >=18 && edad <= 65)
//{
//    Console.WriteLine("tu edad esta entre 18 y 65 años");
//}else
//{
//    Console.WriteLine("no has ingresado algo valido");
//    Console.WriteLine(edad);
//}



//30.Determina si un triángulo es equilátero (tres lados iguales).-----------------------------
//Console.WriteLine("ingresa la longitud de los lados del triangulo");

//Console.WriteLine("ingresa el primer lado:");
//int lado1 = int.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el segundo lado:");
//int lado2 = int.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el tercer lado:");
//int lado3 = int.Parse(Console.ReadLine());

//if (lado1 == lado2 && lado2 == lado3)
//{
//    Console.WriteLine("tu triangulo es equilatero");
//}



//31.Verifica si un triángulo es isósceles (dos lados iguales).--------------------------------
//Console.WriteLine("ingresa la longitud de los lados del triangulo");

//Console.WriteLine("ingresa el primer lado:");
//int lado1 = int.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el segundo lado:");
//int lado2 = int.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el tercer lado:");
//int lado3 = int.Parse(Console.ReadLine());

//if (lado1 == lado2 && lado2 == lado3 || lado1 != lado2 && lado2 == lado3 || lado1 != lado2 && lado1 == lado3)
//{
//    Console.WriteLine("tu triangulo es isosceles");
//}



//32.Determina si un triángulo es escaleno (todos los lados diferentes).-----------------------
//Console.WriteLine("ingresa la longitud de los lados del triangulo");

//Console.WriteLine("ingresa el primer lado:");
//int lado1 = int.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el segundo lado:");
//int lado2 = int.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el tercer lado:");
//int lado3 = int.Parse(Console.ReadLine());

//if (lado1 != lado2 && lado2 == lado3 && lado1 != lado3)
//{
//    Console.WriteLine("tu triangulo es escaleno");
//}



//33.Verifica si un número es mayor que el doble de otro número.-------------------------------




//34.Determina si la suma de dos números es mayor que 100.-------------------------------------
//Console.WriteLine("ingresa 2 numeros para sumarlos y decirte si son mayores que 100");

//Console.WriteLine("ingresa el primer numero");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el segundo numero");
//int num2 = int.Parse(Console.ReadLine());

//int suma = num1 + num2;

//if (suma > 100)
//{
//    Console.WriteLine($"{num1} + {num2} seria {suma} y es mayor que 100");
//}
//else
//{
//    Console.WriteLine($"{num1} + {num2} seria {suma} y es menor que 100");
//}




//35.Verifica si la resta de dos números es menor que 50.--------------------------------------

//Console.WriteLine("ingresa el primer numero");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el segundo numero");
//int num2 = int.Parse(Console.ReadLine());

//int resta = num1 - num2;

//if (resta > 50)
//{
//    Console.WriteLine($"{num1} - {num2} seria {resta} y es mayor que 50");
//}
//else
//{
//    Console.WriteLine($"{num1} - {num2} seria {resta} y es menor que 50");
//}



//36.Determina si un número es el doble del otro número.---------------------------------------
//Console.WriteLine("ingresa el primer numero");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el segundo numero");
//int num2 = int.Parse(Console.ReadLine());

//if(num1 + num1 == num2)
//{
//    Console.WriteLine($"{num2} es el doble que {num1}");
//}else if(num2 + num2 == num1)
//{
//    Console.WriteLine($"{num1} es el doble que {num2}");
//}else
//{
//    Console.WriteLine("ningun numero es doble del otro");
//}



//37.Verifica si el doble de un número es igual al triple de otro número.----------------------
//Console.WriteLine("ingresa el primer numero");
//int num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("ingresa el segundo numero");
//int num2 = int.Parse(Console.ReadLine());

//if(num1 + num1 == num2 + num2 + num2)
//{
//    Console.WriteLine($"si sumamos {num1} + {num1} su resultado seria igual a sumar {num2} tres veces");
//}else if(num2 + num2 == num1 + num1 + num1)
//{
//    Console.WriteLine($"si sumamos {num2} + {num2} su resultado seria igual a sumar {num1} tres veces");
//}
//else
//{
//    Console.WriteLine("el doble de un número no es igual al triple de otro número");
//}



//38.Determina si la suma de dos números es igual a 50.----------------------------------------
Console.WriteLine("ingresa el primer numero");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("ingresa el segundo numero");
int num2 = int.Parse(Console.ReadLine());

if(num1 + num2 == 50)
{
    Console.WriteLine("tus numeros sumados dan 50");
}else
{
    Console.WriteLine("tus numeros sumados no dan 50");
}



//39.Verifica si el producto de dos números es mayor que 500.----------------------------------



//40.Determina si la división de dos números es menor que 10.----------------------------------
