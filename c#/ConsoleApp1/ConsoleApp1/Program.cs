// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Mi primer array");

// funcion para mostrar un array statico
 static void Arraymanual()
{
    int[] numeros = { 1, 2, 3, 4, 5 };
    Console.WriteLine("Datos del array");
    // con foreach
    foreach (int num in numeros)
    {
        Console.WriteLine(num);
    }
}
//crear array numerico ingresado desde consola


static void ArrayDConsola()
{
    int[] array = new int [2];
    
    for (int i = 0; i < array.Length; i++) 
    {
        Console.WriteLine("Ingresa el valores del array "+ i);
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
    foreach (int num in array)
    {
        Console.WriteLine(num+" ");
    }

}
// esta funcion suma los valores de un arrays
static void SumaArrays()
{
    int sumFore = 0;
    int sumFor = 0;
    int[] numeros = { 1, 2, 3, 4, 5 };
    // con foreach
    foreach (int num in numeros)
    {
        sumFore += num;
        
    }
    Console.WriteLine("La suma del array con for each es: "+ sumFore);
    // con un for

    for (int i = 0; i < numeros.Length; i++)
    {
        sumFor += numeros[i];
       
    }
    Console.WriteLine("La suma del array con for es: " + sumFor);
}

static void MediaArrays()
{
    int sumFore = 0;
    int divisor = 0;
    int[] numeros = { 1, 2, 3, 4, 5 };
    divisor = numeros.Length - 1;
    // con foreach
    foreach (int num in numeros)
    {
        sumFore += num;

    }

    Console.WriteLine("La media del array con for each es: " + sumFore/divisor);
}

static void MultiplicarArrays()
{
    int sumFore = 0;
    int nuevoValor = 0;
    int[] numeros = { 1, 2, 3, 4, 5 };
    Console.WriteLine("Ingresa el numero a multiplicar");
    int multiplicador = Convert.ToInt32(Console.ReadLine());
    // con foreach
    for (int i = 0;i < numeros.Length; i++)
    {
        nuevoValor = numeros[i] * multiplicador;
        numeros[i] = nuevoValor;
    }  
    Array.Sort(numeros);
    foreach (var item in numeros)
    {
        Console.WriteLine(item);
    }
}




// crear un array para separar una cadena
static void SepararCadenaArrays()
{
    int sumFore = 0;
    int nuevoValor = 0;
    string[] cadenaSeparada = { };
    Console.WriteLine("Ingresa la cadena a separar");
    string cadena = Convert.ToString(Console.ReadLine());
    // con foreach
    for (int i = 0; i < cadena.Length; i++)
    {       
        Console.WriteLine(cadena[i]);
        for (int j = 0; j < cadenaSeparada.Length; j++)

        {
            cadenaSeparada[j] = cadena[i].ToString();
        }
    }

    foreach (var item in cadenaSeparada)
    {
        Console.WriteLine(item);
    }
}

static void MaximoMinimoArrays()
{
    int min = 0;
    int max = 0;
    int[] numeros = { 4, 3, 7, 10, 100,5, 7 };
    
    Array.Sort(numeros);

    min = numeros[0];
    max = numeros[numeros.Length-1];
    Console.WriteLine("el valor minimo es: " + min);
    Console.WriteLine("el valor minimo es: " + max);
}
//Arraymanual();
//ArrayDConsola();
//SumaArrays();
//MediaArrays();
//MultiplicarArrays();
MaximoMinimoArrays();
//SepararCadenaArrays();
Console.ReadKey();

