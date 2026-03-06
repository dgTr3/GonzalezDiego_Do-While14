Console.WriteLine("Determinar número mayor hasta ingresar 0");
int numero;
int mayor= int.MinValue;
do
{
    Console.Write("Ingrese un número (0 para terminar): ");
    numero = int.Parse(Console.ReadLine());

    if (numero > mayor)
    {
        mayor = numero;
    }
} while (numero != 0);
Console.WriteLine("Número mayor:" +mayor);