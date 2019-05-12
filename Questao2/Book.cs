using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    public class Book
    {
        private string Titulo { get; set; }
        private string Ibsn { get; set; }
        private double Preco { get; set; }

        public string GetTitulo()
        {
            return Titulo;
        }

        public void SetTitulo(string titulo)
        {
            Titulo = titulo;
        }

        public string GetIbsn()
        {
            return Ibsn;
        }

        public void SetIbsn(string ibsn)
        {
            Ibsn = ibsn;
        }

        public double GetPreco()
        {
            return Preco;
        }

        public void SetPreco(double preco)
        {
            Preco = preco;
        }
    }
}
