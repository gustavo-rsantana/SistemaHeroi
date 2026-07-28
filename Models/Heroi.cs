using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHeroi.Models
{
    internal class Heroi
    {
        public string nome { get; set; }
        public string classe { get; set; }
        public int nivel { get; set; } = 1;
        public int vida { get; set; } = 100;
        public int mana { get; set; } = 100;
        public int ataque { get; set; } = 10;
        public int defesa { get; set; } = 5;

        public Heroi(string nome, string classe)
        {
            this.nome = nome;
            this.classe = classe;
        }



        public void Atacar()
        {
            var ataqueTotal = ataque + (nivel * 2);
            Console.WriteLine($"O herói está atacando com {ataqueTotal} de dano!");
        }

        public void ReceberDano()
        {
            var danoTotal = 10 - defesa;
            if ( danoTotal > this.vida ) {
                danoTotal = this.vida - 1;
                Console.WriteLine("O herói está prestes a morrer!");
            }
            Console.WriteLine($"O herói recebeu {danoTotal} de dano!");
            this.vida -= danoTotal;
        }

        public void Curar()
        {
            Console.WriteLine("O herói está se curando!");
        }
        public void SubirNivel()
        {
            Console.WriteLine("O herói está subindo de nível!");
            this.nivel++;
            this.vida += 20;
            this.mana += 10;
            this.ataque++;
            this.defesa++;
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Classe: {classe}");
            Console.WriteLine($"Nível: {nivel}");
            Console.WriteLine($"Vida: {vida}");
            Console.WriteLine($"Mana: {mana}");
            Console.WriteLine($"Ataque: {ataque}");
            Console.WriteLine($"Defesa: {defesa}");
        }
    }
}
