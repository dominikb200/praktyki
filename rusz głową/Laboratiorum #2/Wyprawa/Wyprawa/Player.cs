﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    internal class Player : Mover
    {
        private Weapon equippedWeapon;
        public int HitPoints { get; private set; }
        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }
        public Player(Game game, Point location) : base(game, location) { HitPoints = 10; }
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
        }
        public void Move(Direction direction)
        {
            this.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (Nearby(game.WeaponInRoom.Location, 15))
                { 
                    inventory.Add(game.WeaponInRoom);
                    game.WeaponInRoom.PickUpWeapon();
                    if (inventory.Count == 1)
                    {
                        Weapon first = inventory.First();
                        Equip((string)first.Name);
                    }
                }
            }
        }
        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon == null)
                return;
            else
            {
                equippedWeapon.Attack(direction, random);
                if (equippedWeapon is IPotion)
                {
                    equippedWeapon.Attack(direction, random);
                    equippedWeapon = null;
                    Weapon frst = inventory.First();
                    Equip((string)frst.Name);
                }
            }
        }
        public bool WasPotionUsed(string potionName)
        {
            bool potionUsed = false;
            foreach (Weapon weapon in inventory)
            {
                IPotion potion;
                if (weapon is IPotion && potionName == weapon.Name)
                {
                    potion = weapon as IPotion;

                    potionUsed = potion.Used;
                }
            }
            return potionUsed;
        }
    }
}
