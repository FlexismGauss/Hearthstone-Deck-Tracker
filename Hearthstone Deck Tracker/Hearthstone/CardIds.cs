﻿#region

using System;
using System.Collections.Generic;

#endregion

namespace Hearthstone_Deck_Tracker.Hearthstone
{
	public class CardIds
	{
		public static readonly List<string> InvalidCardIds = new List<string>
		{
			"EX1_tk34",
			"EX1_tk29",
			"EX1_tk28",
			"EX1_tk11",
			"EX1_598",
			"NEW1_032",
			"NEW1_033",
			"NEW1_034",
			"NEW1_009",
			"CS2_052",
			"CS2_082",
			"CS2_051",
			"CS2_050",
			"CS2_152",
			"skele11",
			"skele21",
			"GAME",
			"DREAM",
			"NEW1_006",
			"NAX",
			"FP1_006",
			"PART",
			"BRMA",
			"BRMC",
			"TBA",
			"TB_",
			"TBST_",
			"LOEA",
			"LOE_008",
			"LOE_030"
		};

		// todo: conditional deathrattle summons: Voidcaller
		public static readonly Dictionary<string, int> DeathrattleSummonCardIds = new Dictionary<string, int>
		{
			{HearthDb.CardIds.Collectible.Druid.MountedRaptor, 1},
			{HearthDb.CardIds.Collectible.Hunter.SavannahHighmane, 2},
			{HearthDb.CardIds.Collectible.Rogue.Anubarak, 1},
			{HearthDb.CardIds.Collectible.Warlock.Dreadsteed, 1},
			{HearthDb.CardIds.Collectible.Warlock.Voidcaller, 1}, //false negative better than false positive
			{HearthDb.CardIds.Collectible.Neutral.CairneBloodhoof, 1},
			{HearthDb.CardIds.Collectible.Neutral.HarvestGolem, 1},
			{HearthDb.CardIds.Collectible.Neutral.PilotedShredder, 1},
			{HearthDb.CardIds.Collectible.Neutral.PilotedSkyGolem, 1},
			{HearthDb.CardIds.Collectible.Neutral.SneedsOldShredder, 1},
			{HearthDb.CardIds.Collectible.Neutral.HauntedCreeper, 2},
			{HearthDb.CardIds.Collectible.Neutral.NerubianEgg, 1},
			{HearthDb.CardIds.Collectible.Neutral.SludgeBelcher, 1},
			{HearthDb.CardIds.Collectible.Neutral.WobblingRunts, 3}
		};

		public static readonly Dictionary<string, string> HeroIdDict = new Dictionary<string, string>
		{
			{HearthDb.CardIds.Collectible.Warrior.GarroshHellscream, "Warrior"},
			{HearthDb.CardIds.Collectible.Shaman.Thrall, "Shaman"},
			{HearthDb.CardIds.Collectible.Rogue.ValeeraSanguinar, "Rogue"},
			{HearthDb.CardIds.Collectible.Paladin.UtherLightbringer, "Paladin"},
			{HearthDb.CardIds.Collectible.Hunter.Rexxar, "Hunter"},
			{HearthDb.CardIds.Collectible.Druid.MalfurionStormrage, "Druid"},
			{HearthDb.CardIds.Collectible.Warlock.Guldan, "Warlock"},
			{HearthDb.CardIds.Collectible.Mage.JainaProudmoore, "Mage"},
			{HearthDb.CardIds.Collectible.Priest.AnduinWrynn, "Priest"},
			{HearthDb.CardIds.Collectible.Warlock.LordJaraxxus, "Jaraxxus"},
			{HearthDb.CardIds.Collectible.Neutral.MajordomoExecutus, "Ragnaros the Firelord"}
		};

		public static class Secrets
		{
			public static List<string> FastCombat = new List<string>
			{
				Hunter.FreezingTrap,
				Hunter.ExplosiveTrap,
				Hunter.Misdirection,
				Paladin.NobleSacrifice,
				Mage.Vaporize
			};

			public static class Hunter
			{
				public static List<string> All
				{
					get
					{
						if(DateTime.UtcNow < new DateTime(2015, 12, 3)) //LOE wing 3 release date
							return new List<string> {BearTrap, ExplosiveTrap, FreezingTrap, Misdirection, Snipe, SnakeTrap};
						return new List<string> {BearTrap, DartTrap, ExplosiveTrap, FreezingTrap, Misdirection, Snipe, SnakeTrap};
					}
				}

				public static string BearTrap
				{
					get { return HearthDb.CardIds.Collectible.Hunter.BearTrap; }
				}

				public static string DartTrap
				{
					get { return HearthDb.CardIds.Collectible.Hunter.DartTrap; }
				}

				public static string ExplosiveTrap
				{
					get { return HearthDb.CardIds.Collectible.Hunter.ExplosiveTrap; }
				}

				public static string FreezingTrap
				{
					get { return HearthDb.CardIds.Collectible.Hunter.FreezingTrap; }
				}

				public static string Misdirection
				{
					get { return HearthDb.CardIds.Collectible.Hunter.Misdirection; }
				}

				public static string Snipe
				{
					get { return HearthDb.CardIds.Collectible.Hunter.Snipe; }
				}

				public static string SnakeTrap
				{
					get { return HearthDb.CardIds.Collectible.Hunter.SnakeTrap; }
				}
			}

			public static class Mage
			{
				public static List<string> All
				{
					get { return new List<string> {Counterspell, Duplicate, Effigy, IceBarrier, IceBlock, MirrorEntity, Spellbender, Vaporize}; }
				}

				public static string Counterspell
				{
					get { return HearthDb.CardIds.Collectible.Mage.Counterspell; }
				}

				public static string Duplicate
				{
					get { return HearthDb.CardIds.Collectible.Mage.Duplicate; }
				}

				public static string Effigy
				{
					get { return HearthDb.CardIds.Collectible.Mage.Effigy; }
				}

				public static string IceBarrier
				{
					get { return HearthDb.CardIds.Collectible.Mage.IceBarrier; }
				}

				public static string IceBlock
				{
					get { return HearthDb.CardIds.Collectible.Mage.IceBlock; }
				}

				public static string MirrorEntity
				{
					get { return HearthDb.CardIds.Collectible.Mage.MirrorEntity; }
				}

				public static string Spellbender
				{
					get { return HearthDb.CardIds.Collectible.Mage.Spellbender; }
				}

				public static string Vaporize
				{
					get { return HearthDb.CardIds.Collectible.Mage.Vaporize; }
				}
			}

			public static class Paladin
			{
				public static List<string> All
				{
					get { return new List<string> {Avenge, CompetitiveSpirit, EyeForAnEye, NobleSacrifice, Redemption, Repentance, SacredTrial}; }
				}

				public static string Avenge
				{
					get { return HearthDb.CardIds.Collectible.Paladin.Avenge; }
				}

				public static string CompetitiveSpirit
				{
					get { return HearthDb.CardIds.Collectible.Paladin.CompetitiveSpirit; }
				}

				public static string EyeForAnEye
				{
					get { return HearthDb.CardIds.Collectible.Paladin.EyeForAnEye; }
				}

				public static string NobleSacrifice
				{
					get { return HearthDb.CardIds.Collectible.Paladin.NobleSacrifice; }
				}

				public static string Redemption
				{
					get { return HearthDb.CardIds.Collectible.Paladin.Redemption; }
				}

				public static string Repentance
				{
					get { return HearthDb.CardIds.Collectible.Paladin.Repentance; }
				}

				public static string SacredTrial
				{
					get { return HearthDb.CardIds.Collectible.Paladin.SacredTrial; }
				}
			}
		}
	}
}