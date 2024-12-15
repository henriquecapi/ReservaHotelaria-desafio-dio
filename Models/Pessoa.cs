using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReservaHotelaria.Models
{
    public class Pessoa
    {   
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;  
        
        private string _sobrenome;

        private int _idade;  
          
        public string Nome 
        { 
            get =>_nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public string Sobrenome 
        { 
            get =>_sobrenome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O Sobrenome, não pode ser vazio");
                }
                _sobrenome = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade { 
            get => _idade;

            set
            {
               if (value < 0)
                {
                    throw new ArgumentException("A Idade não pode ser negativa");
                }
                _idade = value; 
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome Completo: {NomeCompleto}, Idade: {Idade}");
        }
    }    
}