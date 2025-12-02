using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Character class demonstrates reference types, constructors, methods, structs, and child classes.
/// </summary>
public class Character
{
    public string Name;
    public int Age;

    // Constructor
    public Character(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to print character info
    public virtual void PrintStatsInfo()
    {
        Debug.Log($"Character Name: {Name}, Age: {Age}");
    }

    // Struct to represent a Weapon
    public struct Weapon
    {
        public string WeaponName;
        public int Damage;

        public Weapon(string weaponName, int damage)
        {
            WeaponName = weaponName;
            Damage = damage;
        }

        public void PrintWeaponInfo()
        {
            Debug.Log($"Weapon: {WeaponName}, Damage: {Damage}");
        }
    }
}

// Child class example
public class Paladin : Character
{
    public Character.Weapon WeaponEquipped;

    public Paladin(string name, int age, Character.Weapon weapon) : base(name, age)
    {
        WeaponEquipped = weapon;
    }

    // Override to include weapon info
    public override void PrintStatsInfo()
    {
        Debug.Log($"Paladin Name: {Name}, Age: {Age}, Weapon: {WeaponEquipped.WeaponName} ({WeaponEquipped.Damage} dmg)");
    }
}
