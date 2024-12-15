using System.Text;
using ReservaHotelaria.Models;

namespace ReservaHotelaria;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        //Cria modelos de hóspedes e cadastra na lista de hospedes
        List<Pessoa> hospedes = new List<Pessoa>();

        Pessoa p1 = new Pessoa("Henrique","Capibaribe");
        Pessoa p2 = new Pessoa("Johan","Carvalho");

        hospedes.Add(p1);
        hospedes.Add(p2);

        //Cria Suite 
        Suite suite = new Suite("Premium",1,60);

        // Cria uma nova reserva, passando a suite e os hospedes
        //Reserva reserva = new Reserva(hospedes,suite,5);
        Reserva reserva = new Reserva(diasReservado:10);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        //Exibe a qunatidade de hospedes e o valor da diária
        Console.WriteLine($"Tipo de Suite: {reserva.Suite.TipoSuite}");
        Console.WriteLine($"nº de Hópedes: {reserva.ObterQuantidadesHospedes()}");
        Console.WriteLine($"Valor da Diária: {reserva.Suite.ValorDiario:C2}");
        Console.WriteLine($"Dias reservado: {reserva.DiasReservado}");
        Console.WriteLine($"Total a pagar: {reserva.CalcularValorDiaria():C2}");

    }
}
