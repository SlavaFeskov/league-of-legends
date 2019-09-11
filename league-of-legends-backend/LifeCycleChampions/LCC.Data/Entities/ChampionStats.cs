﻿using System;
using LoLCommon.Entities;

namespace LCC.Data.Entities
{
    public class ChampionStats : ITrackableEntity
    {
        public int Id { get; set; }
        public double Armor { get; set; }
        public double ArmorPerLevel { get; set; }
        public double AttackDamage { get; set; }       
        public double AttackDamagePerLevel { get; set; }
        public double AttackRange { get; set; }
        public double AttackSpeedOffset { get; set; }
        public double AttackSpeedPerLevel { get; set; }
        public double Crit { get; set; }
        public double CritPerLevel { get; set; }
        public double Hp { get; set; }
        public double HpPerLevel { get; set; }
        public double HpRegen { get; set; }
        public double HpRegenPerLevel { get; set; }
        public double MoveSpeed { get; set; }
        public double Mp { get; set; }
        public double MpPerLevel { get; set; }
        public double MpRegen { get; set; }
        public double MpRegenPerLevel { get; set; }
        public double SpellBlock { get; set; }
        public double SpellBlockPerLevel { get; set; }
        public virtual Champion Champion { get; set; }

        public string CreatedBy { get; set; }
        public string EditedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? EditedDate { get; set; }
    }
}
