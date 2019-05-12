using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Questao2
{
    public class ShoppingCart
    {
        List<Book> Carrinho = new List<Book>();
        public void AdicionarLivro(Book book)
        {
            Carrinho.Add(book);
        }

        public void RemoverLivro(string ibsn)
        {
            List<Book> booksToBeRemoved = new List<Book>();

            foreach(Book book in Carrinho)
            {
                if(book.GetIbsn() == ibsn)
                {
                    booksToBeRemoved.Add(book);
                }
            }
            
            if(booksToBeRemoved.Any())
            {
                foreach(Book book in booksToBeRemoved)
                {
                    Carrinho.Remove(book);
                }
            }
        }

        public void EsvaziarCarrinho()
        {
            if (Carrinho.Any())
            {
                foreach(Book book in Carrinho)
                {
                    Carrinho.Remove(book);
                }
            }
        }

        public int RetornaQuantidadeTotalLivros()
        {
            int count = 0;

            foreach(Book book in Carrinho)
            {
                count += 1;
            }

            return count;
        }
        public double RetornaPrecoTotal()
        {
            double precototal = 0;

            foreach(Book book in Carrinho)
            {
                var preco = book.GetPreco();
                precototal += preco;
            }

            return precototal;
        }
    }
}
