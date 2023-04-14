using _2023_GC_A2_Partiel_POO.Level_2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace _2023_GC_A2_Partiel_POO.Tests.Level_2
{
    public class FightMoreTests
    {
        // Tu as probablement remarqué qu'il y a encore beaucoup de code qui n'a pas été testé ...
        // À présent c'est à toi de créer les TU sur le reste et de les implémenter

        // Ce que tu peux ajouter:
        // - Ajouter davantage de sécurité sur les tests apportés
        // - un heal ne régénère pas plus que les HP Max
        // - si on abaisse les HPMax les HP courant doivent suivre si c'est au dessus de la nouvelle valeur
        // - ajouter un equipement qui rend les attaques prioritaires puis l'enlever et voir que l'attaque n'est plus prioritaire etc)
        // - Le support des status (sleep et burn) qui font des effets à la fin du tour et/ou empeche le pkmn d'agir
        // - Gérer la notion de force/faiblesse avec les différentes attaques à disposition (skills.cs)
        // - Cumuler les force/faiblesses en ajoutant un type pour l'équipement qui rendrait plus sensible/résistant à un type
        [Test]
        public void WeaknessTestOneShot()
        {
            Character salameche = new Character(100, 50, 30, 30, TYPE.FIRE);
            Character bulbizarre = new Character(100, 50, 30, 20, TYPE.GRASS);

            Assert.That(TypeResolver.GetFactor(salameche.BaseType, bulbizarre.BaseType), Is.EqualTo(1.2f));
            Assert.That(TypeResolver.GetFactor(bulbizarre.BaseType, salameche.BaseType), Is.EqualTo(0.8f));
            
        }

        [Test]
        public void HealingTest()
        {
            Character pikachu = new Character(100, 0, 30, 20, TYPE.NORMAL);
            Character bulbizarre = new Character(90, 0, 10, 200, TYPE.NORMAL);
            Fight f = new Fight(pikachu, bulbizarre);
            Punch p = new Punch();

            f.ExecuteTurn(p, p);

            Assert.That(pikachu.IsAlive, Is.EqualTo(true));
            Assert.That(bulbizarre.IsAlive, Is.EqualTo(true));
            Assert.That(f.IsFightFinished, Is.EqualTo(false));

            pikachu.Heal();
            bulbizarre.Heal();

            f.ExecuteTurn(p, p);

            Assert.That(pikachu.IsAlive, Is.EqualTo(true));
            Assert.That(bulbizarre.IsAlive, Is.EqualTo(true));
            Assert.That(f.IsFightFinished, Is.EqualTo(false));

            f.ExecuteTurn(p, p);

            Assert.That(pikachu.IsAlive, Is.EqualTo(true));
            Assert.That(bulbizarre.IsAlive, Is.EqualTo(false));
            Assert.That(f.IsFightFinished, Is.EqualTo(true));
        }

        [Test]
        public void MaxHealthChange()
        {
            Character pikachu = new Character(100, 0, 30, 20, TYPE.NORMAL);

            Assert.That(pikachu.CurrentHealth, Is.EqualTo(100));

            pikachu.MaxHealth = 50;

            Assert.That(pikachu.CurrentHealth, Is.EqualTo(50));

            Character bulbizarre = new Character(100, 0, 10, 200, TYPE.NORMAL);

            Assert.That(bulbizarre.CurrentHealth, Is.EqualTo(100));

            bulbizarre.ReduceHealthBy(60);
            bulbizarre.MaxHealth = 60;

            Assert.That(bulbizarre.CurrentHealth, Is.EqualTo(40));
            Assert.That(bulbizarre.MaxHealth, Is.EqualTo(60));
        }
    }
}
