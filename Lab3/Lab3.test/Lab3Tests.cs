using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
namespace Lab3NS.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsValidGivenCorrectData()
        {
            Lab3NS.Product product = new Lab3NS.Product(1, "ceapa", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Assert.AreEqual(product.IsValid(), true, "This should be true");
        }

        [TestMethod]
        public void TestIsValidGivenEndDateBeforeStart()
        {
            Lab3NS.Product product = new Lab3NS.Product(1, "ceapa", "de mancat", new System.DateTime(2020, 12, 14), new System.DateTime(2019, 12, 13), 20, 30);
            Assert.AreEqual(product.IsValid(), false, "This should be false");

        }

        [TestMethod]
        public void TestIsValidGivenEndDateBefortToday()
        {
            Lab3NS.Product product = new Lab3NS.Product(1, "ceapa", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2017, 12, 14), 20, 30);
            Assert.AreEqual(product.IsValid(), false, "This should be false");
        }

        [TestMethod]
        public void TestComputeVATGivenValidData()
        {
            Lab3NS.Product product = new Lab3NS.Product(1, "ceapa", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 15.5, 25);
            Assert.AreEqual(product.ComputeVAT(), 19.375, "This should be equal");
        }

        [TestMethod]
        public void TestComputeVATForInvalidOutput()
        {
            Lab3NS.Product product = new Lab3NS.Product(1, "ceapa", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 15.5, 25);
            Assert.AreNotEqual(product.ComputeVAT(), 19, "This shouldn't be equal");
        }
        [TestMethod]
        public void TestProductRepositoryConstructor()
        {
            Lab3NS.Product product = new Lab3NS.Product(1, "ceapa", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.Product product2 = new Lab3NS.Product(2, "strugure", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.Product product3 = new Lab3NS.Product(3, "albina", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.ProductRepository productRepository = new Lab3NS.ProductRepository(product, product2, product3);
        }
        [TestMethod]
        public void TestGetProductByName()
        {

            Lab3NS.Product product = new Lab3NS.Product(1, "ceapa", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.Product product2 = new Lab3NS.Product(2, "strugure", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.Product product3 = new Lab3NS.Product(3, "albina", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.ProductRepository productRepository = new Lab3NS.ProductRepository(product, product2, product3);
            Assert.AreEqual(product.Id, productRepository.GetProductByName("ceapa").Id, "Wrong product returned");
        }
        [TestMethod]
        public void TestAddProduct()
        {
            Lab3NS.Product product = new Lab3NS.Product(1, "ceapa", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.Product product2 = new Lab3NS.Product(2, "strugure", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.Product product3 = new Lab3NS.Product(3, "albina", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.ProductRepository productRepository = new Lab3NS.ProductRepository(product, product2, product3);
            Lab3NS.Product product4 = new Lab3NS.Product(4, "gelu", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            productRepository.AddProduct(product4);
            Assert.AreEqual(product4, productRepository.GetProductByName("gelu"), "Product not added");
        }
        [TestMethod]
        public void TestGetProductByPosition()
        {
            Lab3NS.Product product = new Lab3NS.Product(1, "ceapa", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.Product product2 = new Lab3NS.Product(2, "strugure", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.Product product3 = new Lab3NS.Product(3, "albina", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.ProductRepository productRepository = new Lab3NS.ProductRepository(product, product2, product3);
            Assert.AreEqual(product, productRepository.GetProductbyPosition(1), "Wrong product returned");
        }
        [TestMethod]
        public void TestfindAllProducts()
        {
            Lab3NS.Product product = new Lab3NS.Product(1, "ceapa", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.Product product2 = new Lab3NS.Product(2, "strugure", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.Product product3 = new Lab3NS.Product(3, "albina", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
            Lab3NS.ProductRepository productRepository = new Lab3NS.ProductRepository(product, product2, product3);
            Assert.AreEqual(3, productRepository.findAllProducts().Count, "List of products incomplete");
        }
        // [TestMethod]
        // public void TestRemoveProductByname()
        // {
        //     Lab3NS.Product product = new Lab3NS.Product(1, "ceapa", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
        //     Lab3NS.Product product2 = new Lab3NS.Product(2, "strugure", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
        //     Lab3NS.Product product3 = new Lab3NS.Product(3, "albina", "de mancat", new System.DateTime(2011, 12, 13), new System.DateTime(2019, 12, 14), 20, 30);
        //     Lab3NS.ProductRepository productRepository = new Lab3NS.ProductRepository(product, product2, product3);
        //     productRepository.RemoveProductByName("albina");
        //     Assert.AreEqual(2, productRepository.findAllProducts().Count, "Product not removed");

        // }
        [TestMethod]
        public void TestRetriveActiveProducts()
        {
            QuerySyntax qa = new QuerySyntax();
            Assert.AreEqual(2, qa.RetriveActiveProducts(), "Nu sunt egale");
        }

        [TestMethod]
        public void TestRetriveInactiveProducts()
        {
            QuerySyntax qa = new QuerySyntax();
            Assert.AreNotEqual(2, qa.RetriveInactiveProducts(), "Sunt egale");
        }

        [TestMethod]
        public void TestRetriveAllOrderByPriceAscending()
        {
            QuerySyntax qa = new QuerySyntax();
            IEnumerable<Product> lista = qa.RetriveAllOrderByPriceAscending();
            int[] produse = { 3, 1, 2 };
            int i = 0;
            foreach (Product product in lista)
            {
                Assert.AreEqual(produse[i], product.Id, "Nu sunt ordonate");
                i = i + 1;
            }

        }
        [TestMethod]
        public void TestRetriveAllByName()
        {
            QuerySyntax qa = new QuerySyntax();
            Assert.AreEqual(1, qa.RetriveAllByName("masina"), "Nu sunt egale");

        }
        [TestMethod]
        public void TestRetriveAllBySartEndDate()
        {
            QuerySyntax qa = new QuerySyntax();
            Assert.AreEqual(3, qa.RetriveAllByStartEndDate(new DateTime(2011,1,1), new DateTime(2030,1,1)), "Nu sunt egale");

        }
        [TestMethod]
         public void TestRetriveAllByNameMethodSyntax()
        {
           MethodSyntax qa = new MethodSyntax();
            Assert.AreEqual(1, qa.RetriveAllByName("masina"), "Nu sunt egale");

        }
          [TestMethod]
        public void TestRetriveAllBySartEndDateMethodSyntax()
        {
            MethodSyntax qa = new MethodSyntax();
            Assert.AreEqual(3, qa.RetriveAllByStartEndDate(new DateTime(2011,1,1), new DateTime(2030,1,1)), "Nu sunt egale");

        }
          [TestMethod]
        public void TestRetriveAllOrderByPriceAscendingMethodSyntax()
        {
            MethodSyntax qa = new MethodSyntax();
            IEnumerable<Product> lista = qa.RetriveAllOrderByPriceAscending();
            int[] produse = { 3, 1, 2 };
            int i = 0;
            foreach (Product product in lista)
            {
                Assert.AreEqual(produse[i], product.Id, "Nu sunt ordonate");
                i = i + 1;
            }
        }
        [TestMethod]
        public void TestRetriveInactiveProductsMethodSyntax()
        {
           MethodSyntax qa = new MethodSyntax();
            Assert.AreNotEqual(2, qa.RetriveInactiveProducts(), "Sunt egale");
        }
        [TestMethod]
        public void TestRetriveActiveProductsMethodSyntax()
        {
           MethodSyntax qa = new MethodSyntax();
            Assert.AreEqual(2, qa.RetriveActiveProducts(), "Nu sunt egale");
        }
    }
}
