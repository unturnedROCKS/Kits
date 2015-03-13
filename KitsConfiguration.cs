﻿using Rocket.RocketAPI;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace unturned.ROCKS.Kits
{
    public class KitsConfiguration : RocketConfiguration
    {
        [XmlArrayItem(ElementName = "Kit")]
        public List<Kit> Kits;
        public RocketConfiguration DefaultConfiguration
        {
            get {
                KitsConfiguration configuration = new KitsConfiguration();
                configuration.Kits = new List<Kit>() { 
                    new Kit() { Cooldown = 10, Name="Survival", Items = new List<KitItem>() { new KitItem(245, 1), new KitItem(81, 2), new KitItem(16, 1) }},
                    new Kit() { Cooldown = 10, Name="Brute Force", Items = new List<KitItem>() { new KitItem(112, 1), new KitItem(113, 3), new KitItem(254, 3) }},
                    new Kit() { Cooldown = 10, Name="Watcher", Items = new List<KitItem>() { new KitItem(109, 1), new KitItem(111, 3), new KitItem(236, 1) }}
                };
                GlobalCooldown = 10;
                return configuration;
            }
        }
        public int GlobalCooldown = 0;
    }

    public class Kit
    {
        public Kit() { }

        public string Name;

        [XmlArrayItem(ElementName = "Item")]
        public List<KitItem> Items;
        public int Cooldown = 0;
    }

    public class KitItem{

        public KitItem(){ }

        public KitItem(ushort itemId, byte amount)
        {
            ItemId = itemId;
            Amount = amount;
        }

        [XmlAttribute("id")]
        public ushort ItemId;

        [XmlAttribute("amount")]
        public byte Amount;
    }
}