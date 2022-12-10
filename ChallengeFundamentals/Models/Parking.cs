using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private decimal totalValue = 0;
        private String licensePlate;
        private int hours = 0;

        private List<string> vehicles = new List<string>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            this.pricePerHour = initialPrice;
            this.pricePerHour = pricePerHour;
        }

        public void AddVehicle()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar: ");
            licensePlate = Console.ReadLine();
            vehicles.Add(licensePlate);
        }

        public void RemoveVehicle()
        {
            Console.WriteLine("Digite a placa do veiculo para remover: ");
            licensePlate = Console.ReadLine();
            

            if (vehicles.Any(x => x.ToUpper() == licensePlate.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
                hours = Convert.ToInt32(Console.ReadLine());

                totalValue = initialPrice + pricePerHour * hours;

                vehicles.Remove(licensePlate);

                Console.WriteLine($"O veículo {licensePlate} foi removido e o preço total foi de: R$ {totalValue}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }

        }

        public void ListVehicles()
        {
            if (vehicles.Any())
            { 
                Console.WriteLine("Veículos: ");

                int contForeach = 1;
                foreach (String vehicle in vehicles)
                {
                    Console.WriteLine($"{contForeach}° Veiculo - {vehicle}");
                    contForeach++;
                }
            }
            else
            { 
                Console.WriteLine("Nenhum veículo estacionado: ");
            }
        }

    }
}