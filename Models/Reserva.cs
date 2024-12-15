using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ReservaHotelaria.Models
{
    public class Reserva
    {
        public Reserva(List<Pessoa> pessoas, Suite suite, int diasReservado)
        {
            Pessoas = pessoas;
            Suite = suite;
            DiasReservado = diasReservado;
        }
        public Reserva(int diasReservado){
            DiasReservado = diasReservado;
        }
        public List<Pessoa> _pessoas { get; set; }
        public Suite _suite { get; set; }
        public int _diasReservado { get; set; }

        public List<Pessoa> Pessoas 
        { 
            get =>_pessoas;

            set
            {   
                if (value.Count == 0)
                {
                    //throw new ArgumentException("Não pode ter uma lista de Pessoas vazia");
                    Console.WriteLine(Pessoas.Count);
                } 
                else if(Convert.ToInt32(value.Count) > Convert.ToInt32(Suite.Capacidade))
                {
                    Console.WriteLine($"A suite possue capacidade max. de ({Suite.Capacidade}) hospede inferior ao numero de hóspedes({value.Count}) \nESSA CONFIGURAÇÃO DEVE SER MUDADA");
                    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                }
                
                _pessoas = value;
            }
        }
        public Suite Suite 
        { 
            get => _suite;

            set
            {
                _suite = value;
            }
        }
        public int DiasReservado 
        { 
            get => _diasReservado;
    
            set  
            {
                try
                {
                    if (Convert.ToInt32(value) < 1)
                    {
                        //throw new ArgumentException("A Quantidade de Dias Reservados não pode ser menor que 1 dia.");
                        Console.WriteLine("A Quantidade de Dias Reservados não pode ser menor que 1 dia.");
                    }
                    _diasReservado = Convert.ToInt32(value);
                }
                catch (Exception)
                {
                    //throw new ArgumentException($"Erro: {ex}");
                    Console.WriteLine("Erro Genérico!");
                }     
            }
        }
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            Pessoas = hospedes;
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadesHospedes()
        {
            int qtd = 0;
            foreach (var item in Pessoas)
            {
              qtd++;  
            }
            return qtd;
        }
        public decimal CalcularValorDiaria()
        {
            decimal valorTotal = DiasReservado * Suite.ValorDiario;
        
            if (DiasReservado >= 10) 
            {
                valorTotal = (DiasReservado * Suite.ValorDiario) - ((DiasReservado * Suite.ValorDiario)/10);
            } 
            return valorTotal;
        }
    }
}