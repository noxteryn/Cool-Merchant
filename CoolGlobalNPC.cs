using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CoolMerchant.NPCs
{
	public class CoolGlobalNPC : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (type == NPCID.TravellingMerchant)
			{
				if (CoolMerchant.chance1 == 0)
				{
					switch(CoolMerchant.itemForSale1)
					{
						case 0:
							shop.item[nextSlot].SetDefaults(ItemID.MagicMirror);
							break;
						case 1:
							shop.item[nextSlot].SetDefaults(ItemID.IceMirror);
							break;
						case 2:
							shop.item[nextSlot].SetDefaults(ItemID.DepthMeter);
							break;
						case 3:
							shop.item[nextSlot].SetDefaults(ItemID.Compass);
							break;
						case 4:
							shop.item[nextSlot].SetDefaults(ItemID.Radar);
							break;
						case 5:
							shop.item[nextSlot].SetDefaults(ItemID.TallyCounter);
							break;
						case 6:
							shop.item[nextSlot].SetDefaults(ItemID.MetalDetector);
							break;
						case 7:
							shop.item[nextSlot].SetDefaults(ItemID.FishermansGuide);
							break;
						case 8:
							shop.item[nextSlot].SetDefaults(ItemID.WeatherRadio);
							break;
						case 9:
							shop.item[nextSlot].SetDefaults(ItemID.Sextant);
							break;
						case 10:
							shop.item[nextSlot].SetDefaults(ItemID.SandstorminaBottle);
							break;
					}
					nextSlot++;
				}
				if (Main.hardMode == true)
				{
					if (CoolMerchant.chance2 == 0)
					{
						switch(CoolMerchant.itemForSale2)
						{
							case 0:
								shop.item[nextSlot].SetDefaults(ItemID.CobaltShield);
								break;
							case 1:
								shop.item[nextSlot].SetDefaults(ItemID.TrifoldMap);
								break;
							case 2:
								shop.item[nextSlot].SetDefaults(ItemID.FastClock);
								break;
							case 3:
								shop.item[nextSlot].SetDefaults(ItemID.Vitamins);
								break;
							case 4:
								shop.item[nextSlot].SetDefaults(ItemID.ArmorPolish);
								break;
							case 5:
								shop.item[nextSlot].SetDefaults(ItemID.Blindfold);
								break;
							case 6:
								shop.item[nextSlot].SetDefaults(ItemID.Nazar);
								break;
							case 7:
								shop.item[nextSlot].SetDefaults(ItemID.Megaphone);
								break;
							case 8:
								shop.item[nextSlot].SetDefaults(ItemID.Bezoar);
								break;
							case 9:
								shop.item[nextSlot].SetDefaults(ItemID.AdhesiveBandage);
								break;
						}
						nextSlot++;
					}
				}
			}
		}
	}
}