using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Questao2.Tests
{
    [TestClass()]
    public class ShoppingCartTests
    {
        [TestMethod()]
        public void AdicionarLivroTest()
        {
            Book book = new Book();
            book.SetIbsn("123");
            book.SetPreco(19.90);
            book.SetTitulo("Harry Potter");

            ShoppingCart cart = new ShoppingCart();
            cart.AdicionarLivro(book);

            Assert.IsTrue(cart.RetornaQuantidadeTotalLivros() == 1);
        }

        [TestMethod()]
        public void RemoverLivroTest()
        {
            Book book = new Book();
            book.SetIbsn("123");
            book.SetPreco(19.90);
            book.SetTitulo("Harry Potter e a Pedra Filosofal");

            Book book2 = new Book();
            book2.SetIbsn("125");
            book2.SetPreco(29.90);
            book2.SetTitulo("Harry Potter e a Camara Secreta");

            ShoppingCart cart = new ShoppingCart();
            cart.AdicionarLivro(book);
            cart.AdicionarLivro(book2);           

            Assert.IsTrue(cart.RetornaQuantidadeTotalLivros() == 2);

            cart.RemoverLivro("123");

            Assert.IsTrue(cart.RetornaQuantidadeTotalLivros() == 1);
        }

        [TestMethod()]
        public void EsvaziarCarrinhoTest()
        {
            Book book = new Book();
            book.SetIbsn("123");
            book.SetPreco(19.90);
            book.SetTitulo("Harry Potter e a Pedra Filosofal");

            Book book2 = new Book();
            book2.SetIbsn("125");
            book2.SetPreco(29.90);
            book2.SetTitulo("Harry Potter e a Camara Secreta");

            ShoppingCart cart = new ShoppingCart();
            cart.AdicionarLivro(book);
            cart.AdicionarLivro(book2);

            Assert.IsTrue(cart.RetornaQuantidadeTotalLivros() == 2);

            cart.EsvaziarCarrinho();

            Assert.IsTrue(cart.RetornaQuantidadeTotalLivros() == 0);
        }

        [TestMethod()]
        public void RetornaPrecoTotalTest()
        {
            Book book = new Book();
            book.SetIbsn("123");
            book.SetPreco(19.90);
            book.SetTitulo("Harry Potter e a Pedra Filosofal");

            Book book2 = new Book();
            book2.SetIbsn("125");
            book2.SetPreco(29.90);
            book2.SetTitulo("Harry Potter e a Camara Secreta");

            ShoppingCart cart = new ShoppingCart();
            cart.AdicionarLivro(book);
            cart.AdicionarLivro(book2);

            double preco = cart.RetornaPrecoTotal();

            Assert.IsTrue(preco == 29.90 + 19.90);
        }
    }
}