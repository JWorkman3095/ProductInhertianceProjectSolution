﻿using System;
using System.Collections.Generic;

namespace ProductInhertianceProject {
    class Program {
        static void Main(string[] args) {

            //creating a sales order (a collection of widgets and service)
            //because widgets and service are products we can code with Product

            List<Product> salesOrder = new List<Product>();

            Product widget1 = new Widget("W1", 50, "Small", "Red");
            Product widget2 = new Widget("W2", 100, "Medium", "White");
            Product widget3 = new Widget("W3", 200, "Large", "Blue");
            Product service = new Service("SVC", 500, "Premium", 5);

            salesOrder.Add(widget1);
            salesOrder.Add(widget2);
            salesOrder.Add(widget3);
            salesOrder.Add(service);

            decimal salesOrderTotal = 0;


            foreach(Product p in salesOrder) {
                salesOrderTotal += p.Price;

                if(p is Widget) {
                    Widget w = p as Widget;
                    Console.WriteLine($"{p.Code} {p.Price:c} {w.Size} {w.Color}");
                    continue;
                }
                if(p is Service) {
                    Service s = p as Service;
                    Console.WriteLine($"{s.Code} {s.Price} {s.ServiceLevel} {s.NumberOfYears}");
                    continue;
                }
            }
            Console.WriteLine($"Total sales order is {salesOrderTotal}");


            //Service s1 = new Service("BASIC", 100, "Basic", 3);
            //Console.WriteLine(s1.ToPrint());

            //Widget w = new Widget("Widget", 543.21m, "Large", "MAX Red");
            //Console.WriteLine(w.ToPrint());

            //Widget w1 = new Widget();
            //Console.WriteLine(w1.ToPrint());

            //Product p = new Product("Echo", 123.45m);
            //// call to constructor
            //string message = p.ToPrint();
            //Console.WriteLine(message);
        }
    }
}
