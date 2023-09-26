using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryBuilder
{
    internal class Pokemon : IClassModel
    {
        public int Id { get; set; }
        public int dexNumber { get; set; }
        public string name { get; set; }
        public string form { get; set; }
        public string typeOne { get; set; }
        public string typeTwo { get; set; }
        public int total { get; set; }
        public int hp { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int specialAttack { get; set; }
        public int specialDefense { get; set; }
        public int speed { get; set; }
        public int generation { get; set; }

        public Pokemon()
        {
            Id = 0;
            dexNumber = 0;
            name = "";
            form = "";
            typeOne = "";
            typeTwo = "";
            total = 0;
            hp = 0;
            attack = 0;
            defense = 0;
            specialAttack = 0;
            specialDefense = 0;
            speed = 0;
            generation = 0;
        }

        public Pokemon(int Id, int dexNumber, string name, string form, string typeOne, string typeTwo, int total, int hp, int attack, int defense, int specialAttack, int specialDefense, int speed, int generation)
        {
            this.Id = Id;
            this.dexNumber = dexNumber;
            this.name = name;
            this.form = form;
            this.typeOne = typeOne;
            this.typeTwo = typeTwo;
            this.total = total;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
            this.specialAttack = specialAttack;
            this.specialDefense = specialDefense;
            this.speed = speed;
            this.generation = generation;
        }
    }
}
