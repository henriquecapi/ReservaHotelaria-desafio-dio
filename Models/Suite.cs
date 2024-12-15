using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaHotelaria.Models
{
    public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiario){
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiario = valorDiario;
        }
        public string _tipoSuite { get; set; }
        public int _capacidade { get; set; }
        public decimal _valorDiario { get; set; }
        public string TipoSuite 
        { 
            get =>_tipoSuite.ToUpper();

            set
            {
                if (value == "")
                {
                    //throw new ArgumentException("O Tipo de Suite não pode ser vazio");
                    Console.WriteLine("O Tipo de Suite não pode ser vazio");
                }
                _tipoSuite = value;
            }
        }
        public int Capacidade 
        { 
            get => _capacidade;
    
            set  
            {
                try
                {
                    if (Convert.ToInt32(value) < 1)
                    {
                        //throw new ArgumentException("A Capacidade não pode ser menor que 1 pessoa");
                        Console.WriteLine("A Capacidade não pode ser menor que 1 pessoa");
                    }
                    else if (Convert.ToInt32(value) > 6)
                    {
                        //throw new ArgumentException("A Capacidade não pode ser maior que 6 pessoas");   
                        Console.WriteLine("A Capacidade não pode ser maior que 6 pessoas"); 
                    }
                    _capacidade = Convert.ToInt32(value);
                }
                catch (Exception)
                {
                    //throw new ArgumentException($"Erro: {ex}");
                    Console.WriteLine("Erro Generico!"); 
                }
            }
        }
        public decimal ValorDiario 
        { 
            get => _valorDiario;
    
            set  
            {
                try
                {
                    if (Convert.ToDecimal(value) < 60.00M)
                    {
                        //throw new ArgumentException("A Valor da Diária não pode ser menor que o valor da mais barata Hospedagem");
                        Console.WriteLine("O Valor da Diária não pode ser menor que 60 reais, que é o valor da mais barato de Hospedagem");
                    }
                    _valorDiario = Convert.ToDecimal(value);
                }
                catch (Exception)
                {
                    //throw new ArgumentException($"Erro: {ex}");
                    Console.WriteLine("Erro Generico!"); 
                }   
            }
        }
    }
}