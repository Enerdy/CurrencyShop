﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.ID
{
	public class PrefixID
	{
		public const int Count = 83;
		public const byte None = 0;
		public static string this[byte key]
		{
			get
			{
				return new Dictionary<byte, string>()
				{
					{ 0, "" },
					{ 1, "Large" },
					{ 2, "Massive" },
					{ 3, "Dangerous" },
					{ 4, "Savage" },
					{ 5, "Sharp" },
					{ 6, "Pointy" },
					{ 7, "Tiny" },
					{ 8, "Terrible" },
					{ 9, "Small" },
					{ 10, "Dull" },
					{ 11, "Unhappy" },
					{ 12, "Bulky" },
					{ 13, "Shameful" },
					{ 14, "Heavy" },
					{ 15, "Light" },
					{ 16, "Sighted" },
					{ 17, "Rapid" },
					{ 18, "Hasty" },
					{ 19, "Intimidating" },
					{ 20, "Deadly" },
					{ 21, "Staunch" },
					{ 22, "Awful" },
					{ 23, "Lethargic" },
					{ 24, "Awkward" },
					{ 25, "Powerful" },
					{ 26, "Mystic" },
					{ 27, "Adept" },
					{ 28, "Masterful" },
					{ 29, "Inept" },
					{ 30, "Ignorant" },
					{ 31, "Deranged" },
					{ 32, "Intense" },
					{ 33, "Taboo" },
					{ 34, "Celestial" },
					{ 35, "Furious" },
					{ 36, "Keen" },
					{ 37, "Superior" },
					{ 38, "Forceful" },
					{ 39, "Broken" },
					{ 40, "Damaged" },
					{ 41, "Shoddy" },
					{ 42, "Quick" },
					{ 43, "Deadly" },
					{ 44, "Agile" },
					{ 45, "Nimble" },
					{ 46, "Murderous" },
					{ 47, "Slow" },
					{ 48, "Sluggish" },
					{ 49, "Lazy" },
					{ 50, "Annoying" },
					{ 51, "Nasty" },
					{ 52, "Manic" },
					{ 53, "Hurtful" },
					{ 54, "Strong" },
					{ 55, "Unpleasant" },
					{ 56, "Weak" },
					{ 57, "Ruthless" },
					{ 58, "Frenzying" },
					{ 59, "Godly" },
					{ 60, "Demonic" },
					{ 61, "Zealous" },
					{ 62, "Hard" },
					{ 63, "Guarding" },
					{ 64, "Armored" },
					{ 65, "Warding" },
					{ 66, "Arcane" },
					{ 67, "Precise" },
					{ 68, "Lucky" },
					{ 69, "Jagged" },
					{ 70, "Spiked" },
					{ 71, "Angry" },
					{ 72, "Menacing" },
					{ 73, "Brisk" },
					{ 74, "Fleeting" },
					{ 75, "Hasty" },
					{ 76, "Quick" },
					{ 77, "Wild" },
					{ 78, "Rash" },
					{ 79, "Intrepid" },
					{ 80, "Violent" },
					{ 81, "Legendary" },
					{ 82, "Unreal" },
					{ 83, "Mythical" }
				}[key];
			}
		}
	}
}
