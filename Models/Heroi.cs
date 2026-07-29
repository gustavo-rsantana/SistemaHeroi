using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHeroi.Models
{
    internal class Heroi
    {
        public string Nome { get; set; }
        public string Classe { get; set; }
        public int Nivel { get; set; } = 1;
        public int VidaMaxima { get; set; } = 100;
        public int Vida { get; set; } = 100;
        public int ManaMaxima { get; set; } = 50;
        public int Mana { get; set; } = 50;
        public int Ataque { get; set; } = 10;
        public int Defesa { get; set; } = 5;
        public bool EstaVivo { get; set; } = true;

        public Heroi(string nome, string classe)
        {
            this.Nome = nome;
            this.Classe = classe;
        }



        public void Atacar()
        {
            if (this.EstaVivo)
            {
                var ataqueTotal = Ataque + (Nivel * 2);
                Console.WriteLine($"O herói está atacando com {ataqueTotal} de dano!");
            }
            else
            {
                Console.WriteLine("O herói está morto e não pode atacar!");
            }

        }

        public void ReceberDano(int dano)
        {
            var danoTotal = dano >= this.Defesa? dano - this.Defesa : 5;
            if ( danoTotal >= this.Vida ) {
                this.Morrer();
                Console.WriteLine("O herói Morrel!");
            } else
            {
                Console.WriteLine($"O herói recebeu {danoTotal} de dano!");
                this.Vida -= danoTotal;
            }
            
        }

        public void Curar()
        {
            if (this.EstaVivo)
            {
                if (this.Mana <= 10)
                {
                    Console.WriteLine("Mana insuficiente para curar!");
                }
                else
                {
                    int cura = Random.Shared.Next(10, 31);
                    if ((this.Vida + cura) >= this.VidaMaxima)
                    {
                        Console.WriteLine("Você Curou toda a Vida!");
                        this.Vida = this.VidaMaxima;
                        this.Mana -= 10;
                    }
                    else
                    {
                        this.Vida += cura;
                        this.Mana -= 10;
                        Console.WriteLine($"O herói se curou em {cura} pontos de vida!");

                    }
                }
            }
            else
            {
                Console.WriteLine("O herói está morto e não pode se curar!");
            }
        }
        public void SubirNivel()
        {
            if (this.EstaVivo)
            {
                this.Nivel++;
                this.VidaMaxima += 20;
                this.ManaMaxima += 10;
                this.Ataque++;
                this.Defesa++;
                this.Vida = this.VidaMaxima;
                this.Mana = this.ManaMaxima;
                Console.WriteLine("O herói alcaçõu o nível {0}!", this.Nivel);
            } else
            {
                Console.WriteLine("O herói está morto e não pode subir de nível!");
            }
            
        }

        private void Morrer()
        {
            this.Vida = 0;
            this.EstaVivo = false;
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Classe: {Classe}");
            Console.WriteLine($"Nível: {Nivel}");
            Console.WriteLine($"Vida: {Vida}/{VidaMaxima}");
            Console.WriteLine($"Mana: {Mana}/{ManaMaxima}");
            Console.WriteLine($"Ataque: {Ataque}");
            Console.WriteLine($"Defesa: {Defesa}");
            Console.WriteLine($"Está Vivo: {EstaVivo}");
        }
    }
}
