﻿using entitati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    internal class ProduseMgr : ProdusAbstractMgr
    {
        //private Produs[] produse = new Produs[100];
        public int CountProduse { get; set; } = 0;
        
        public void ReadProdus()
        {
            Console.WriteLine("Introdu un produs");
            Console.Write("Numele:");
            string? nume = Console.ReadLine();
            Console.Write("Codul intern:");
            string? codintern = Console.ReadLine();
            Console.Write("Producator:");
            string? producator = Console.ReadLine();
            Produs prod = new Produs(nume, codintern, CountProduse, producator);
            AddElement(prod);
        }
        public void ReadProdus(int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Datele pentru produsul:" + (++CountProduse));
                ReadProdus();
            }
        }
        public void WriteProdus()
        {
            for(int i=0;i< CountElemente;i++)
            {
                if (elemente[i] is Produs)
                {
                    Console.WriteLine(elemente[i].Descriere());
                }
            }
        }
    }
}
