using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    public class CajeroAutomatico : CuentaBancaria
    {
        public void ConsultarSaldo()
        {
            Console.WriteLine($"Saldo actual: {saldo}");
        }

        public void DepositarFondos(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("Cantidad inválida para depósito.");
            }

            saldo += cantidad;
            Console.WriteLine($"Se depositaron {cantidad} unidades. Nuevo saldo: {saldo}");
        }

        public void RetirarEfectivo(int cantidad)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentException("Cantidad inválida para retiro.");
            }

            if (cantidad > saldo)
            {
                throw new InvalidOperationException("Fondos insuficientes.");
            }

            saldo -= cantidad;
            Console.WriteLine($"Se retiraron {cantidad} unidades. Saldo restante: {saldo}");
        }

        public void CambiarPIN(int nuevoPIN)
        {
            if (nuevoPIN == PIN)
            {
                throw new InvalidOperationException("El nuevo PIN no puede ser igual al PIN actual.");
            }

            if (nuevoPIN <= 999 || nuevoPIN >= 10000)
            {
                throw new ArgumentException("El PIN debe tener 4 dígitos.");
            }

            PIN = nuevoPIN;
            Console.WriteLine("PIN cambiado exitosamente.");
        }
    }
}