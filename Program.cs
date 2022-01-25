using System;
using Desafio_RPG_Orientação_Objetos_Csharp.src.Entities;

namespace dotnet__poo 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight",749,72);    
            Wizard wizard = new Wizard("Jennica", 42, "White Wizard",601,482); 
            Ninja ninja = new Ninja("Wedge", 42, "Ninja",374,89);       
            BlackWizard blackWizard = new BlackWizard("Topapa", 42, "BlackWizard",385,641);

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(blackWizard.Attack());
            Console.WriteLine(ninja.Attack());
            
        }
    }
}