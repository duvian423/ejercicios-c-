// See https://aka.ms/new-console-template for more information
//Ejercicios C#
//“La programación es el arte de crear algo de la nada con solo la imaginación y la habilidad.
//¡Cada línea de código es una oportunidad para crear algo increíble y dejar una huella en el
//mundo digital”




//Suma de números pares e impares:
//Escribe un programa que solicite al usuario un número entero positivo X y luego calcule la
//suma de los números pares y la suma de los números impares desde 1 hasta X. Finalmente,
//muestra ambas sumas.
//----------------------------------------------------------------------------------------------
//Console.WriteLine("ingresa un numero entero mayor a 20");
//string entradaUser = Console.ReadLine();

//int numero;

//bool validacion = int.TryParse(entradaUser, out numero);

//List<int> sumaPares = new List<int>();
//List<int> sumaImpares = new List<int>();
//int totalSumaPares = 0;
//int totalSumaImpares = 0;

//for (int i = 0; i < numero; i++)
//{

//    if (i % 2 == 0)
//    {
//        sumaPares.Add(i);
//    }
//    else
//    {
//        sumaImpares.Add(i);
//    }
//}

//Console.WriteLine("-------------- numeros pares ------------------");

//for(int j = 0; j < sumaPares.Count();j++)
//{
//    totalSumaPares += sumaPares[j];
//    Console.WriteLine(sumaPares[j]);
//}

//Console.WriteLine("-------------- numeros impares ------------------");

//for (int k = 0; k < sumaImpares.Count(); k++)
//{
//    totalSumaImpares += sumaImpares[k];
//    Console.WriteLine(sumaImpares[k]);
//}


//Console.WriteLine("-----------------------------------------------\n");
//Console.WriteLine($"el total de la suma de los numeros pares es {totalSumaPares}");
//Console.WriteLine($"el total de la suma de los numeros impares es  {totalSumaImpares}");




//Tabla de multiplicar:
//Pide al usuario que ingrese un número entero y muestra la tabla de multiplicar
//correspondiente a ese número, desde 1 hasta 10.
//----------------------------------------------------------------------------------------------
//Console.WriteLine("digita tu numero:");
//string digitoUsuario = Console.ReadLine();

//int num;
//List<int> multiplo = new List<int>();
//List<int> resultados = new List<int>();

//multiplo.Add(1);
//multiplo.Add(2);
//multiplo.Add(3);
//multiplo.Add(4);
//multiplo.Add(5);
//multiplo.Add(6);
//multiplo.Add(7);
//multiplo.Add(8);
//multiplo.Add(9);
//multiplo.Add(10);

//bool validacion = int.TryParse(digitoUsuario, out num);

//for(int i = 0; i < multiplo.Count(); i++)
//{
//    resultados.Add(multiplo[i] * num);
//}

//for (int j = 0; j < resultados.Count(); j++)
//{
//    Console.WriteLine( resultados[j]);
//}




//Factorial de un número:
//Solicita al usuario un número entero no negativo y calcula su factorial. La factorial de un
//número n se define como el producto de todos los enteros positivos desde 1 hasta n.
//----------------------------------------------------------------------------------------------
//Console.WriteLine("digita tu numero para sacar el factorial:");
//string digitoUsuario = Console.ReadLine();

//int num;
//List<int> enterosParaMultiplicar = new List<int>();
//bool validacion = int.TryParse(digitoUsuario, out num);

//for(int i = 0; i < num; i++)
//{
//    enterosParaMultiplicar.Add(i);
//}

//for(int j = 1; j < enterosParaMultiplicar.Count(); j++)
//{
//    num *= enterosParaMultiplicar[j];
//    //Console.WriteLine(enterosParaMultiplicar[j]);
//}

//Console.WriteLine(num);





//Números primos en un rango:
//Pide al usuario dos números enteros positivos, A y B (A < B), y muestra todos los números
//primos en el rango de A a B.
//---------------------------------------------------------------------------------------------
//Console.WriteLine("digita 2 numeros de menor a mayor para indicarte que numeros primos hay entre ellos");

//Console.WriteLine("ingresa el primer numero");
//string userDigito1 = Console.ReadLine();

//Console.WriteLine("ingresa el segundo numero");
//string userDigito2 = Console.ReadLine();

//int num1;
//int num2;
//List<int> primos = new List<int>();

//bool validacion1 = int.TryParse(userDigito1, out num1);
//bool validacion2 = int.TryParse(userDigito2, out num2);

//for (int i = num1; i < num2; i++)
//{
//    if(i %i == 0 && i %2 != 0)
//    {
//        primos.Add(i);
//    }   
//}

//for(int j = 0; j < primos.Count(); j++)
//{
//    Console.WriteLine(primos[j]);
//}





//Secuencia de Collatz:
//Escribe un programa que tome un número inicial del usuario y muestre la secuencia de
//Collatz para ese número. La secuencia de Collatz se define como sigue: Si el número es
//par, divídelo por 2; si es impar, multiplícalo por 3 y súmale 1. Repite este proceso hasta
//que el número sea igual a 1.
//--------------------------------------------------------------------------------------------
//Console.WriteLine("digita tu numero");
//string ditioUsuario = Console.ReadLine();

//int num;

//bool validacion = int.TryParse(ditioUsuario, out num);

//while(num != 1)
//{
//    if (num % 2 == 0)
//    {
//        num = num / 2;
//    }
//    else
//    {
//        num = (num * 3) + 1;
//    }
//    Console.WriteLine(num);
//}





//Conversión de temperatura:
//Crea un programa que permita al usuario convertir temperaturas de grados Celsius a
//Fahrenheit o viceversa. El usuario debe ingresar la temperatura y elegir la conversión
//deseada.
//-------------------------------------------------------------------------------------------
//Console.WriteLine("digite la temperatura");
//string userTem = Console.ReadLine();

//Console.WriteLine("ingresa a que deseas convertir: \n 1: celsius \n 2: farenheit");
//string convertidor = Console.ReadLine();

//int tem;
//int convertida = 0;

//if(userTem != "")
//{
//    bool validacion = int.TryParse(userTem, out tem);
//    if (convertidor == "1")
//    {
//        convertida = ((tem * 9) / 5) + 32;
//        Console.WriteLine($"has convertido {tem} grados celsius a {convertida} grados farenheit");
//    }
//    else if(convertidor == "2")
//    {
//        convertida = ((tem - 32) *5)/9;
//        Console.WriteLine($"has convertido {tem} grados farenheit a {convertida} grados celsius");
//    }
//    else
//    {
//        Console.WriteLine("tu opcion no es valida");
//    }
//}





//Secuencia Fibonacci:
//Pide al usuario un número entero N y muestra los primeros N términos de la secuencia
//Fibonacci. La secuencia Fibonacci comienza con 0 y 1, y cada término subsiguiente es la
//suma de los dos términos anteriores.
//-------------------------------------------------------------------------------------------
//Console.WriteLine("ingresa tu numero");
//string digitoUser = Console.ReadLine();

//int num;
//int fibonacci0 = 0;
//int fibonacci1 = 1;
//int fibonacci2 = 0;
//List<int> fibonacci = new List<int>();

//bool validacion = int.TryParse(digitoUser, out num);

//for (int j = 0; j != num; j++)
//{
//    fibonacci0 = fibonacci1; 
//    fibonacci.Add(fibonacci0);
//    //Console.WriteLine(fibonacci0);
//    //Console.WriteLine("----------------------------------------------------\n\n");
//    fibonacci1 = fibonacci2;
//    //Console.WriteLine(fibonacci1);
//    //Console.WriteLine("----------------------------------------------------\n\n");
//    fibonacci2 = fibonacci0 + fibonacci1;
//    fibonacci.Add(fibonacci2);
//    //Console.WriteLine(fibonacci2);
//}
//for (int i = 0; i < fibonacci.Count(); i++)
//{
//    Console.WriteLine(fibonacci[i]);
//}





//Juego de Piedra, Papel, Tijeras:
//Crea un juego de Piedra, Papel, Tijeras en el que el usuario pueda jugar contra la
//computadora. Utiliza un ciclo do-while para permitir al usuario jugar varias rondas hasta
//que decida salir del juego.
//------------------------------------------------------------------------------------------
//Console.WriteLine("digita un numero de acuerdo con lo que quieras sacar teniendo en cuenta que: " +
//    " \n 1: piedra \n 2: papel \n 3: tijera");

//int contadorPc = 0;
//int contadorUser = 0;

//while (contadorUser < 3 && contadorPc < 3)
//{
//    Random random = new Random();

//    string[] optionsPC = { "piedra", "papel", "tijera" };

//    string pc = optionsPC[random.Next(optionsPC.Length)];

//    string optionUser = Console.ReadLine();

//    string user = "";
//    if (optionUser == "1")
//    {
//        user = "piedra";
//    }
//    else if (optionUser == "2")
//    {
//        user = "papel";
//    }
//    else if (optionUser == "3")
//    {
//        user = "tijera";
//    }

//    if (user == pc)
//    {
//        Console.WriteLine("empate");
//    }
//    else if (user == "piedra" && pc == "tijera")
//    {
//        contadorUser = contadorUser + 1;
//        Console.WriteLine("ganas un punto");
//        Console.WriteLine($"el tablero esta asi en este momento pc lleva {contadorPc} puntos" +
//            $" y UD lleva {contadorUser} puntos");
//    }
//    else if (user == "piedra" && pc == "papel")
//    {
//        contadorPc = contadorPc + 1;
//        Console.WriteLine("pc gana un punto");
//        Console.WriteLine($"el tablero esta asi en este momento pc lleva {contadorPc} puntos" +
//            $" y UD lleva {contadorUser} puntos");
//    }
//    else if (user == "tijera" && pc == "papel")
//    {
//        contadorUser = contadorUser + 1;
//        Console.WriteLine("ganas un punto");
//        Console.WriteLine($"el tablero esta asi en este momento pc lleva {contadorPc} puntos" +
//            $" y UD lleva {contadorUser} puntos");
//    }
//    else if (user == "tijera" && pc == "piedra")
//    {
//        contadorPc = contadorPc + 1;
//        Console.WriteLine("pc gana un punto");
//        Console.WriteLine($"el tablero esta asi en este momento pc lleva {contadorPc} puntos" +
//            $" y UD lleva {contadorUser} puntos");
//    }
//    else if (user == "papel" && pc == "piedra")
//    {
//        contadorUser = contadorUser + 1;
//        Console.WriteLine("ganas un punto");
//        Console.WriteLine($"el tablero esta asi en este momento pc lleva {contadorPc} puntos" +
//            $" y UD lleva {contadorUser} puntos");
//    }
//    else if (user == "papel" && pc == "tijera")
//    {
//        contadorPc = contadorPc + 1;
//        Console.WriteLine("pc gana un punto");
//        Console.WriteLine($"el tablero esta asi en este momento pc lleva {contadorPc} puntos" +
//            $" y UD lleva {contadorUser} puntos");
//    }
//}


//if(contadorUser == 3)
//{
//    Console.WriteLine("\n ¡¡¡¡¡Felicitaciones has ganado!!!!!");
//}else if(contadorPc == 3)
//{
//    Console.WriteLine(" \n Perdiste vuelve a intentarlo");
//}



//Cálculo del salario semanal:
//Solicita al usuario el número de horas trabajadas en una semana y la tarifa por hora. Calcula
//y muestra el salario semanal, considerando que se paga la tarifa normal por las primeras
//40 horas y una tarifa y media por las horas extras (más de 40 horas).
//------------------------------------------------------------------------------------------
//Console.WriteLine("ingresa el numero de horas laboradas: ");
//string horasUser = Console.ReadLine();

//Console.WriteLine("ingresa el valor por hora laborado:");
//string valorUser = Console.ReadLine();

//double horas;
//double valor;
//double horasExtras = 0;
//double totalNormal = 0;
//double totalExtras = 0;
//double totalSueldo = 0;

//bool validacion1 = double.TryParse(horasUser, out horas);
//bool validacion2 = double.TryParse(valorUser, out valor);

//if (horas <= 40)
//{
//    totalNormal = horas * valor;
//    totalSueldo = totalNormal;
//    Console.WriteLine($"su sueldo esta semana es de ${totalSueldo}");
//}
//else if (horas > 40)
//{
//    horasExtras = horas - 40;
//    totalNormal = valor * 40;
//    totalExtras = (valor * 1.5) * horasExtras;
//    totalSueldo = totalNormal + totalExtras;
//    Console.WriteLine($"tu sueldo esta semana es de {totalSueldo}");
//}




//Juego de adivinanza:
//Crea un programa que genere un número aleatorio entre 1 y 100. Luego, pide al usuario
//que adivine el número. Si el número ingresado es mayor que el número generado, muestra
//"Más bajo", si es menor, muestra "Más alto". Continúa hasta que el usuario adivine el
//número.
//-----------------------------------------------------------------------------------------
//Console.WriteLine("Bienvenido al juego de adivina el numero");
//Console.WriteLine("comienza a digitar de a un numero para tratar de adivinar");

//int num;
//Random random = new Random();
//int numRandom = random.Next(1,101);

//do
//{
//    string numUser = Console.ReadLine();
//    bool validacion = int.TryParse(numUser, out num);

//    if (num < numRandom)
//    {
//        Console.WriteLine("el numero es mas alto");
//    }
//    else if (num > numRandom)
//    {
//        Console.WriteLine("el numero es mas bajo");
//    }
//}

//while (num != numRandom);

//Console.WriteLine($"Felicitaciones has ganado el numero era {numRandom}!!!!!!!!");




//Contador de dígitos:
//Solicita al usuario un número entero positivo y cuenta la cantidad de dígitos pares e
//impares que contiene.
//----------------------------------------------------------------------------------------
Console.WriteLine("ingresa un numero");
string entradaUser = Console.ReadLine();

int numero;

bool validacion = int.TryParse(entradaUser, out numero);

List<int> sumaPares = new List<int>();
List<int> sumaImpares = new List<int>();
int totalSumaPares = 0;
int totalSumaImpares = 0;

for (int i = 0; i < numero; i++)
{

   if (i % 2 == 0)
   {
       sumaPares.Add(i);
   }
   else
   {
       sumaImpares.Add(i);
   }
}
Console.WriteLine("los numeros pares antes de llegar a el numero que escojiste son:");
for(int j = 0; j < sumaPares.Count(); j++)
{
   Console.WriteLine(sumaPares[j]);
}
Console.WriteLine("\n ------------------------------------------------------ \n");
Console.WriteLine("los numeros impares antes de llegar a el numero que escojiste son:");
for(int k = 0; k < sumaImpares.Count(); k++)
{
   Console.WriteLine(sumaImpares[k]);
}




//Factorización de números:
//Solicita al usuario un número entero positivo y muestra todos sus factores primos
//utilizando un ciclo while para encontrar los factores y dividir el número por ellos.
