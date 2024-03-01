using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Data
{
    public class PlayerData
    {
        public List<Hero> Heroes = new();
    }

    public class Hero
    {
        public List<Equipment> Equipments = new();
    }

    public class Equipment
    {
        public EquipmentType type;
        public int Level;
        public EquipmentQuality quality;

        public int Power => GetPower();

        private int GetPower()
        {
            return 0;
        }
    }
}