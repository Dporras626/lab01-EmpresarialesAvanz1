// See https://aka.ms/new-console-template for more information
using lab01;

Persona persona = new Persona();
persona.Apellidos = "Torrico";
persona.Nombres = "Hugo";
persona.Edad = 35;

Console.WriteLine("Los nombres completos son:");
Console.WriteLine(persona.RetornarNombresCompletos());

if (persona.EsMayorEdad())
    Console.WriteLine("Es Mayor de Edad");
else
    Console.WriteLine("Es Menor de Edad");



Empleado empleado = new Empleado 
{
    Nombres = "Diego",
    Apellidos = "Porras",
    Edad = 19,
    Sueldo = 4000
};

Console.WriteLine("El impuesto es");
Console.WriteLine(empleado.CalcularImpuesto(8));

CajeroAutomatico cajeroAutomatico = new CajeroAutomatico
{
    nro_cuenta = 12345,
    titular = "John Doe",
    saldo = 1000,
    PIN = 1234
};

Console.WriteLine("Bienvenido al Cajero Automático");
Console.WriteLine("Ingrese su número de PIN:");

int pinIngresado = Convert.ToInt32(Console.ReadLine());

try
{
    if (pinIngresado == cajeroAutomatico.PIN)
    {
        Console.WriteLine("PIN correcto. ¿Qué operación desea realizar?");
        Console.WriteLine("1. Consultar saldo");
        Console.WriteLine("2. Retirar dinero");
        Console.WriteLine("3. Depositar dinero");
        Console.WriteLine("4. Cambiar PIN");

        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                cajeroAutomatico.ConsultarSaldo();
                break;
            case 2:
                Console.WriteLine("Ingrese la cantidad a retirar:");
                int cantidadRetiro = Convert.ToInt32(Console.ReadLine());
                cajeroAutomatico.RetirarEfectivo(cantidadRetiro);
                break;
            case 3:
                Console.WriteLine("Ingrese la cantidad a depositar:");
                int cantidadDeposito = Convert.ToInt32(Console.ReadLine());
                cajeroAutomatico.DepositarFondos(cantidadDeposito);
                break;
            case 4:
                Console.WriteLine("Ingrese el nuevo PIN:");
                int nuevoPIN = Convert.ToInt32(Console.ReadLine());
                cajeroAutomatico.CambiarPIN(nuevoPIN);
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
    else
    {
        Console.WriteLine("PIN incorrecto. Operación cancelada.");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
catch (InvalidOperationException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
