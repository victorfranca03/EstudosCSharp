﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    internal class Conta
    {
<<<<<<< HEAD
        public int Id { get; set; }
        public string Titular { get; set; }
        public int saldo {  get; set; }

        public int senha { get; set; }
=======
        public int Id;
        public string Titular = string.Empty;
        public int saldo;
        public int senha;
>>>>>>> e4f3dd9615e2d7c1c1a3eb19f790b445059783e6

        public void ExibirContaBanco() 
        {
            Console.WriteLine($"Nome do titular :{Titular}");
            Console.WriteLine($"Saldo: {saldo}");
            Console.WriteLine($"Id da conta do banco: {Id}");
            Console.WriteLine($"Senha do Usuario: {senha}");
            Console.WriteLine("\n");
        
        }

    }
}


//Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha.
//Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
//Desenvolver um método da classe Conta que exibe suas informações.

//