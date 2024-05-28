using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Models
{
    public class Calculadora
    {
        private List<string> _historico;

        public DateTime Date { get; set; } = DateTime.Now;

        public Calculadora()
        {
            _historico = new List<string>();
        }
        public double Somar(params double[] numeros)
        {
           double soma = 0;
            for(int i =0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm");             
            _historico.Insert(0," result: " + soma + " data: " + Date.ToString("dd/MM/yyyy HH:mm"));

            return soma;
        }
          public double Sub(params double[] numeros)
        {
            double soma = numeros[0];
            for(int i =1; i < numeros.Length; i++)
            {
                 soma -= numeros[i];
            }
            _historico.Insert(0," result: " + soma + " data: " + Date.ToString("dd/MM/yyyy HH:mm"));

            return soma;
        }
        
          public double Mult(params double[] numeros)
        {
            double soma = numeros[0];
            for(int i =1; i < numeros.Length; i++)
            {
                soma *= numeros[i];
            }
            _historico.Insert(0," result: " + soma + " data: " + Date.ToString("dd/MM/yyyy HH:mm"));

            return soma;
        }
          public double Dividir(params double[] numeros)
        {
           double soma = numeros[0];

           for(int i =1; i < numeros.Length; i++)
           {
            soma /= numeros[i];
           }
           _historico.Insert(0," result: " + soma + " data: " + Date.ToString("dd/MM/yyyy HH:mm"));
            return soma;
        }


        public List<string> Historico()
        {
            List<string> res;
            _historico.RemoveRange(3,_historico.Count -3);
            return _historico;
        }
    }
}