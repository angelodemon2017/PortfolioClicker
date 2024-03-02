using System.Collections.Generic;
using Utils;

namespace Assets.Scripts.Data
{
    public class PlayerData
    {
        public List<Currency> Currencies = new();
        public List<Hero> Heroes = new();
        public GameProgress gameProgress = new();
    }

    public class GameProgress
    {
        public int CurrentLevelDungeon = 0;
    }

    public class Currency
    {
        public CurrencyType currencyType;
        public BigInt Count;
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