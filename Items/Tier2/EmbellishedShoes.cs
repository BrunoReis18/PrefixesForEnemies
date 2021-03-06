﻿using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace EnemyMods.Items.Tier2
{
    [AutoloadEquip(EquipType.Legs)]
    public class EmbellishedShoes : ModItem
    {

        public override void SetDefaults()
        {

            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 3;
            item.defense = 5;

        }

    public override void SetStaticDefaults()
    {
      DisplayName.SetDefault("Embellished Shoes");
      Tooltip.SetDefault("+4% magic damage and crit");
    }

        public override void UpdateEquip(Player player)
        {
            player.magicDamage += .04f;
            player.magicCrit += 4;
        }

        /*
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }*/
    }
}
