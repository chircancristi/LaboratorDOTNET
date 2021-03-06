﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
namespace Lab3NS
{
    public class QuerySyntax
    {
        Product p1;
        Product p2;
        Product p3;

        ProductRepository pr;

        public QuerySyntax()
        {
            p1 = new Product(1, "ceas", "e un ceas", new DateTime(2017, 5, 2), new DateTime(2017, 6, 2), 100, 23);
            p2 = new Product(2, "masina", "BMW", new DateTime(2017, 5, 2), new DateTime(2019, 6, 2), 500, 23);
            p3 = new Product(3, "cafea", "cafea de automat", new DateTime(2019, 5, 2), new DateTime(2020, 6, 2), 30, 23);
            pr = new ProductRepository(p1, p2, p3);
        }
        public int RetriveActiveProducts(){
            IEnumerable<Product> prodQuery =
            from product in this.pr.products where
            product.IsValid() == true
            select product;

            return prodQuery.Count();
        }

        public int RetriveInactiveProducts(){
            IEnumerable<Product> prodQuery =
            from product in this.pr.products where
            product.IsValid() == false
            select product;

            return prodQuery.Count();
        }
        public IEnumerable<Product> RetriveAllOrderByPriceAscending(){
            IEnumerable<Product> prodQuery =
            from product in this.pr.products
            orderby product.Price
            select product;

            return prodQuery;
        }
        public int RetriveAllByName(string name){
            IEnumerable<Product> prodQuery =
            from product in this.pr.products where
            name == product.Name
            select product;

            return prodQuery.Count();
        }

        public int RetriveAllByStartEndDate(System.DateTime start, System.DateTime end){
            IEnumerable<Product> prodQuery =
            from product in this.pr.products where
            product.StartDate >= start &&
            product.EndDate <= end
            select product;

            return prodQuery.Count();
        }
        static void main()
        {
            Console.WriteLine("ceapapa");
        }
    }
}
