﻿using CalamityMod.Items.Accessories;
using FargowiltasSouls.Content.Items.Accessories.Souls;
using FargowiltasSouls.Core.Toggler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace FargowiltasCrossmod.Content.Calamity.Toggles
{
    public class CalamityToggles : ToggleCollection
    {
        public override string Mod => "CalamityMod";
        public override string SortCatagory => "Enchantments";
        public override int Priority => 1;
        public override bool Active => true;

        public int CalamityColossusHeader = ModContent.ItemType<ColossusSoul>();
        public string Amalgam;
        public string AsgardianAegis;
        public string RampartofDeities;
        public string Camper;
        public string Sponge;
        public string Purity;

        public int CalamityBerserkerHeader = ModContent.ItemType<BerserkerSoul>();
        public string ElementalGauntlet;

        public int CalamityWizardHeader = ModContent.ItemType<ArchWizardsSoul>();
        public string EtherealTalisman;

        public int CalamitySniperHeader = ModContent.ItemType<SnipersSoul>();
        public string ElementalQuiver;
        public string DaawnlightSpiritOrigin;
        public string QuiverofNihility;
        public string DynamoStemCells;

        public int CalamityConjuristHeader = ModContent.ItemType<ConjuristsSoul>();
        public string Nucleogenesis;

        public int CalamityTrawlerHeader = ModContent.ItemType<TrawlerSoul>();
        public string AbyssalDivingSuit;
    }
}
