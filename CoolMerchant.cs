using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace CoolMerchant
{
	class CoolMerchant : Mod
	{
		public static Random random = new Random();
		public static int chance1, chance2, itemForSale1, itemForSale2;
		private static bool isHere;

		public CoolMerchant()
		{
			
		}
		
		public override void Load()
		{
			isHere = false;
			chance1 = random.Next(2);
			chance2 = random.Next(2);
			itemForSale1 = random.Next(11);
			itemForSale2 = random.Next(10);
		}
		
		public override void UpdateUI(GameTime gameTime)
		{
			if (NPC.CountNPCS(NPCID.TravellingMerchant) > 0)
			{
				if (isHere == false)
				{
					isHere = true;
					chance1 = random.Next(2);
					chance2 = random.Next(2);
					itemForSale1 = random.Next(11);
					itemForSale2 = random.Next(10);
				}
			}
			else
			{
				isHere = false;
			}
			
/*			if ((Main.dayTime == true) && (Main.time == 0.0))
			{	
				Main.sundialCooldown = 0;
			}
*/		}
	}
}
