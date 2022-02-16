//////////////////////////////////////////////////////////
//		Creator: Murrer 		Scripter: Murrer		//
//				Server: Lost World UO					//
//////////////////////////////////////////////////////////
//						Testers							//
//////////////////////////////////////////////////////////
//			  Murrer									//
////////////////////////////////////////////////////////// 

using System;
using Server.Items;

namespace Server.Engines.Craft
{
	public class BlackKnightCraft : CraftSystem
	{
		public override SkillName MainSkill
		{
			get	{ return SkillName.Blacksmith; }
		}

		public override int GumpTitleNumber
		{
			get { return 3; } // Black Knight's Enhancement Tool
		}

		private static CraftSystem m_CraftSystem;

		public static CraftSystem CraftSystem
		{
			get
			{
				if ( m_CraftSystem == null )
					m_CraftSystem = new BlackKnightCraft();

				return m_CraftSystem;
			}
		}

		public override CraftECA ECA{ get{ return CraftECA.ChanceMinusSixtyToFourtyFive; } }

		public override double GetChanceAtMin( CraftItem item )
		{
			return 1; // 100%
		
		}

		private BlackKnightCraft() : base( 1, 1, 1.25 )// base( 1, 1, 4.5 )
		{
		}

		/*public override int CanCraft( Mobile from, BaseTool tool, Type itemType )
		{
			if( tool == null || tool.Deleted || tool.UsesRemaining < 0 )
				return 1044038; // You have worn out your tool!
			else if ( !BaseTool.CheckAccessible( tool, from ) )
				return 1044263; // The tool must be on your person to use.

			return 0;
		}*/

		private static Type[] m_TailorColorables = new Type[]
			{
				typeof( GozaMatEastDeed ), typeof( GozaMatSouthDeed ),
				typeof( SquareGozaMatEastDeed ), typeof( SquareGozaMatSouthDeed ),
				typeof( BrocadeGozaMatEastDeed ), typeof( BrocadeGozaMatSouthDeed ),
				typeof( BrocadeSquareGozaMatEastDeed ), typeof( BrocadeSquareGozaMatSouthDeed )
			};

		public override bool RetainsColorFrom( CraftItem item, Type type )
		{
			if ( type != typeof( Cloth ) && type != typeof( UncutCloth ) )
				return false;

			type = item.ItemType;

			bool contains = false;

			for ( int i = 0; !contains && i < m_TailorColorables.Length; ++i )
				contains = ( m_TailorColorables[i] == type );

			return contains;
		}

		public override void PlayCraftEffect( Mobile from )
		{
			from.PlaySound( 0x55 );
		}

		public override int PlayEndingEffect( Mobile from, bool failed, bool lostMaterial, bool toolBroken, int quality, bool makersMark, CraftItem item )
		{
			if ( toolBroken )
				from.SendLocalizedMessage( 1044038 ); // You have worn out your tool

			if ( failed )
			{
				if ( lostMaterial )
					return 1044043; // You failed to create the item, and some of your materials are lost.
				else
					return 1044157; // You failed to create the item, but no materials were lost.
			}
			else
			{
				if ( quality == 0 )
					return 502785; // You were barely able to make this item.  It's quality is below average.
				else if ( makersMark && quality == 2 )
					return 1044156; // You create an exceptional quality item and affix your maker's mark.
				else if ( quality == 2 )
					return 1044155; // You create an exceptional quality item.
				else				
					return 1044154; // You create the item.
			}
		}

		public override void InitCraftList()
		{
			int index = -1;

			#region Phase 2
			index = AddCraft( typeof( BlackKnightsArmsii ), "Phase 2", "Phase 2: Black Knights Arms", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsArms ), "Phase 1: Black Knights Arms", 1, "You don't have enough arms" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 20, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBreastplateii ), "Phase 2", "Phase 2: Black Knights Breastplate", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBreastplate ), "Phase 1: Black Knights Breastplate", 1, "You don't have enough breastplates" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 20, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGlovesii ), "Phase 2", "Phase 2: Black Knights Gloves", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGloves ), "Phase 1: Black Knights Gloves", 1, "You don't have enough gloves" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 20, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGorgetii ), "Phase 2", "Phase 2: Black Knights Gorget", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGorget ), "Phase 1: Black Knights Gorget", 1, "You don't have enough gorgets" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 20, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsHelmii ), "Phase 2", "Phase 2: Black Knights Helm", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsHelm ), "Phase 1: Black Knights Helm", 1, "You don't have enough helms" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 20, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsLegsii ), "Phase 2", "Phase 2: Black Knights Legs", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsLegs ), "Phase 1: Black Knights Legs", 1, "You don't have enough legs" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 20, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBraceletii ), "Phase 2", "Phase 2: Black Knights Bracelet", 0.0, 1.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddSkill( index, SkillName.Tinkering, 100.0, 120.0 );
			AddRes( index, typeof( BlackKnightsBracelet ), "Phase 1: Black Knights Bracelet", 1, "You don't have enough bracelets" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 20, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsEarringsii ), "Phase 2", "Phase 2: Black Knights Earrings", 0.0, 1.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddSkill( index, SkillName.Tinkering, 100.0, 120.0 );
			AddRes( index, typeof( BlackKnightsEarrings ), "Phase 1: Black Knights Earrings", 1, "You don't have enough earrings" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 20, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRingii ), "Phase 2", "Phase 2: Black Knights Ring", 0.0, 1.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddSkill( index, SkillName.Tinkering, 100.0, 120.0 );
			AddRes( index, typeof( BlackKnightsRing ), "Phase 1: Black Knights Ring", 1, "You don't have enough rings" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 20, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRobeii ), "Phase 2", "Phase 2: Black Knights Robe", 0.0, 1.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddSkill( index, SkillName.Tailoring, 100.0, 120.0 );
			AddRes( index, typeof( BlackKnightsRobe ), "Phase 1: Black Knights Robe", 1, "You don't have enough robes" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 20, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsShieldii ), "Phase 2", "Phase 2: Black Knights Shield", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsShield ), "Phase 1: Black Knights Shield", 1, "You don't have enough shields" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 20, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsSwordii ), "Phase 2", "Phase 2: Black Knights Sword", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsSword ), "Phase 1: Black Knights Sword", 1, "You don't have enough swords" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 20, "You don't have enough tickets" );
			#endregion
			
			#region Phase 3
			index = AddCraft( typeof( BlackKnightsArmsiii ), "Phase 3", "Phase 3: Black Knights Arms", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsArmsii ), "Phase 2: Black Knights Arms", 1, "You don't have enough arms" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 30, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBreastplateiii ), "Phase 3", "Phase 3: Black Knights Breastplate", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBreastplateii ), "Phase 2: Black Knights Breastplate", 1, "You don't have enough breastplates" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 30, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGlovesiii ), "Phase 3", "Phase 3: Black Knights Gloves", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGlovesii ), "Phase 2: Black Knights Gloves", 1, "You don't have enough gloves" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 30, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGorgetiii ), "Phase 3", "Phase 3: Black Knights Gorget", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGorgetii ), "Phase 2: Black Knights Gorget", 1, "You don't have enough gorgets" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 30, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsHelmiii ), "Phase 3", "Phase 3: Black Knights Helm", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsHelmii ), "Phase 2: Black Knights Helm", 1, "You don't have enough helms" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 30, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsLegsiii ), "Phase 3", "Phase 3: Black Knights Legs", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsLegsii ), "Phase 2: Black Knights Legs", 1, "You don't have enough legs" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 30, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBraceletiii ), "Phase 3", "Phase 3: Black Knights Bracelet", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBraceletii ), "Phase 2: Black Knights Bracelet", 1, "You don't have enough bracelets" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 30, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsEarringsiii ), "Phase 3", "Phase 3: Black Knights Earrings", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsEarringsii ), "Phase 2: Black Knights Earrings", 1, "You don't have enough earrings" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 30, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRingiii ), "Phase 3", "Phase 3: Black Knights Ring", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRingii ), "Phase 2: Black Knights Ring", 1, "You don't have enough rings" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 30, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRobeiii ), "Phase 3", "Phase 3: Black Knights Robe", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRobeii ), "Phase 2: Black Knights Robe", 1, "You don't have enough robes" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 30, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsShieldiii ), "Phase 3", "Phase 3: Black Knights Shield", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsShieldii ), "Phase 2: Black Knights Shield", 1, "You don't have enough shields" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 30, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsSwordiii ), "Phase 3", "Phase 3: Black Knights Sword", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsSwordii ), "Phase 2: Black Knights Sword", 1, "You don't have enough swords" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 30, "You don't have enough tickets" );
			#endregion
			
			#region Phase 4
			index = AddCraft( typeof( BlackKnightsArmsiiii ), "Phase 4", "Phase 4: Black Knights Arms", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsArmsiii ), "Phase 3: Black Knights Arms", 1, "You don't have enough arms" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 40, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBreastplateiiii ), "Phase 4", "Phase 4: Black Knights Breastplate", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBreastplateiii ), "Phase 3: Black Knights Breastplate", 1, "You don't have enough breastplates" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 40, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGlovesiiii ), "Phase 4", "Phase 4: Black Knights Gloves", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGlovesiii ), "Phase 3: Black Knights Gloves", 1, "You don't have enough gloves" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 40, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGorgetiiii ), "Phase 4", "Phase 4: Black Knights Gorget", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGorgetiii ), "Phase 3: Black Knights Gorget", 1, "You don't have enough gorgets" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 40, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsHelmiiii ), "Phase 4", "Phase 4: Black Knights Helm", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsHelmiii ), "Phase 3: Black Knights Helm", 1, "You don't have enough helms" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 40, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsLegsiiii ), "Phase 4", "Phase 4: Black Knights Legs", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsLegsiii ), "Phase 3: Black Knights Legs", 1, "You don't have enough legs" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 40, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBraceletiiii ), "Phase 4", "Phase 4: Black Knights Bracelet", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBraceletiii ), "Phase 3: Black Knights Bracelet", 1, "You don't have enough bracelets" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 40, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsEarringsiiii ), "Phase 4", "Phase 4: Black Knights Earrings", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsEarringsiii ), "Phase 3: Black Knights Earrings", 1, "You don't have enough earrings" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 40, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRingiiii ), "Phase 4", "Phase 4: Black Knights Ring", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRingiii ), "Phase 3: Black Knights Ring", 1, "You don't have enough rings" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 40, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRobeiiii ), "Phase 4", "Phase 4: Black Knights Robe", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRobeiii ), "Phase 3: Black Knights Robe", 1, "You don't have enough robes" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 40, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsShieldiiii ), "Phase 4", "Phase 4: Black Knights Shield", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsShieldiii ), "Phase 3: Black Knights Shield", 1, "You don't have enough shields" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 40, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsSwordiiii ), "Phase 4", "Phase 4: Black Knights Sword", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsSwordiii ), "Phase 3: Black Knights Sword", 1, "You don't have enough swords" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 40, "You don't have enough tickets" );
			#endregion
			
			#region Gemmed Items
			//Begin Gem of Blessing
			index = AddCraft( typeof( BlackKnightsArmsBless ), "Gemmed", "Bless: Black Knights Arms", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsArmsiiii ), "Phase 4: Black Knights Arms", 1, "You don't have enough arms" );
			AddRes( index, typeof( BlessGem ), "Gem of Blessing", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBreastplateBless ), "Gemmed", "Bless: Black Knights Breastplate", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBreastplateiiii ), "Phase 4: Black Knights Breastplate", 1, "You don't have enough breastplates" );
			AddRes( index, typeof( BlessGem ), "Gem of Blessing", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGlovesBless ), "Gemmed", "Bless: Black Knights Gloves", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGlovesiiii ), "Phase 4: Black Knights Gloves", 1, "You don't have enough gloves" );
			AddRes( index, typeof( BlessGem ), "Gem of Blessing", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGorgetBless ), "Gemmed", "Bless: Black Knights Gorget", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGorgetiiii ), "Phase 4: Black Knights Gorget", 1, "You don't have enough gorgets" );
			AddRes( index, typeof( BlessGem ), "Gem of Blessing", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsHelmBless ), "Gemmed", "Bless: Black Knights Helm", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsHelmiiii ), "Phase 4: Black Knights Helm", 1, "You don't have enough helms" );
			AddRes( index, typeof( BlessGem ), "Gem of Blessing", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsLegsBless ), "Gemmed", "Bless: Black Knights Legs", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsLegsiiii ), "Phase 4: Black Knights Legs", 1, "You don't have enough legs" );
			AddRes( index, typeof( BlessGem ), "Gem of Blessing", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBraceletBless ), "Gemmed", "Bless: Black Knights Bracelet", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBraceletiiii ), "Phase 4: Black Knights Bracelet", 1, "You don't have enough bracelets" );
			AddRes( index, typeof( BlessGem ), "Gem of Blessing", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsEarringsBless ), "Gemmed", "Bless: Black Knights Earrings", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsEarringsiiii ), "Phase 4: Black Knights Earrings", 1, "You don't have enough earrings" );
			AddRes( index, typeof( BlessGem ), "Gem of Blessing", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRingBless ), "Gemmed", "Bless: Black Knights Ring", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRingiiii ), "Phase 4: Black Knights Ring", 1, "You don't have enough rings" );
			AddRes( index, typeof( BlessGem ), "Gem of Blessing", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRobeBless ), "Gemmed", "Bless: Black Knights Robe", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRobeiiii ), "Phase 4: Black Knights Robe", 1, "You don't have enough robes" );
			AddRes( index, typeof( BlessGem ), "Gem of Blessing", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsShieldBless ), "Gemmed", "Bless: Black Knights Shield", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsShieldiiii ), "Phase 4: Black Knights Shield", 1, "You don't have enough shields" );
			AddRes( index, typeof( BlessGem ), "Gem of Blessing", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsSwordBless ), "Gemmed", "Bless: Black Knights Sword", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsSwordiiii ), "Phase 4: Black Knights Sword", 1, "You don't have enough swords" );
			AddRes( index, typeof( BlessGem ), "Gem of Blessing", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			//End Gem of Blessing
			
			//Begin Gem of Luck
			index = AddCraft( typeof( BlackKnightsArmsLuck ), "Gemmed", "Luck: Black Knights Arms", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsArmsiiii ), "Phase 4: Black Knights Arms", 1, "You don't have enough arms" );
			AddRes( index, typeof( LuckGem ), "Gem of Luck", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBreastplateLuck ), "Gemmed", "Luck: Black Knights Breastplate", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBreastplateiiii ), "Phase 4: Black Knights Breastplate", 1, "You don't have enough breastplates" );
			AddRes( index, typeof( LuckGem ), "Gem of Luck", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGlovesLuck ), "Gemmed", "Luck: Black Knights Gloves", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGlovesiiii ), "Phase 4: Black Knights Gloves", 1, "You don't have enough gloves" );
			AddRes( index, typeof( LuckGem ), "Gem of Luck", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGorgetLuck ), "Gemmed", "Luck: Black Knights Gorget", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGorgetiiii ), "Phase 4: Black Knights Gorget", 1, "You don't have enough gorgets" );
			AddRes( index, typeof( LuckGem ), "Gem of Luck", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsHelmLuck ), "Gemmed", "Luck: Black Knights Helm", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsHelmiiii ), "Phase 4: Black Knights Helm", 1, "You don't have enough helms" );
			AddRes( index, typeof( LuckGem ), "Gem of Luck", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsLegsLuck ), "Gemmed", "Luck: Black Knights Legs", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsLegsiiii ), "Phase 4: Black Knights Legs", 1, "You don't have enough legs" );
			AddRes( index, typeof( LuckGem ), "Gem of Luck", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBraceletLuck ), "Gemmed", "Luck: Black Knights Bracelet", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBraceletiiii ), "Phase 4: Black Knights Bracelet", 1, "You don't have enough bracelets" );
			AddRes( index, typeof( LuckGem ), "Gem of Luck", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsEarringsLuck ), "Gemmed", "Luck: Black Knights Earrings", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsEarringsiiii ), "Phase 4: Black Knights Earrings", 1, "You don't have enough earrings" );
			AddRes( index, typeof( LuckGem ), "Gem of Luck", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRingLuck ), "Gemmed", "Luck: Black Knights Ring", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRingiiii ), "Phase 4: Black Knights Ring", 1, "You don't have enough rings" );
			AddRes( index, typeof( LuckGem ), "Gem of Luck", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRobeLuck ), "Gemmed", "Luck: Black Knights Robe", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRobeiiii ), "Phase 4: Black Knights Robe", 1, "You don't have enough robes" );
			AddRes( index, typeof( LuckGem ), "Gem of Luck", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsShieldLuck ), "Gemmed", "Luck: Black Knights Shield", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsShieldiiii ), "Phase 4: Black Knights Shield", 1, "You don't have enough shields" );
			AddRes( index, typeof( LuckGem ), "Gem of Luck", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsSwordLuck ), "Gemmed", "Luck: Black Knights Sword", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsSwordiiii ), "Phase 4: Black Knights Sword", 1, "You don't have enough swords" );
			AddRes( index, typeof( LuckGem ), "Gem of Luck", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			//End Gem of Luck
			
			//Begin Gem of NightSight
			index = AddCraft( typeof( BlackKnightsArmsNS ), "Gemmed", "NightSight: Black Knights Arms", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsArmsiiii ), "Phase 4: Black Knights Arms", 1, "You don't have enough arms" );
			AddRes( index, typeof( NSGem ), "Gem of NightSight", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBreastplateNS ), "Gemmed", "NightSight: Black Knights Breastplate", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBreastplateiiii ), "Phase 4: Black Knights Breastplate", 1, "You don't have enough breastplates" );
			AddRes( index, typeof( NSGem ), "Gem of NightSight", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGlovesNS ), "Gemmed", "NightSight: Black Knights Gloves", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGlovesiiii ), "Phase 4: Black Knights Gloves", 1, "You don't have enough gloves" );
			AddRes( index, typeof( NSGem ), "Gem of NightSight", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGorgetNS ), "Gemmed", "NightSight: Black Knights Gorget", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGorgetiiii ), "Phase 4: Black Knights Gorget", 1, "You don't have enough gorgets" );
			AddRes( index, typeof( NSGem ), "Gem of NightSight", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsHelmNS ), "Gemmed", "NightSight: Black Knights Helm", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsHelmiiii ), "Phase 4: Black Knights Helm", 1, "You don't have enough helms" );
			AddRes( index, typeof( NSGem ), "Gem of NightSight", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsLegsNS ), "Gemmed", "NightSight: Black Knights Legs", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsLegsiiii ), "Phase 4: Black Knights Legs", 1, "You don't have enough legs" );
			AddRes( index, typeof( NSGem ), "Gem of NightSight", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBraceletNS ), "Gemmed", "NightSight: Black Knights Bracelet", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBraceletiiii ), "Phase 4: Black Knights Bracelet", 1, "You don't have enough bracelets" );
			AddRes( index, typeof( NSGem ), "Gem of NightSight", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsEarringsNS ), "Gemmed", "NightSight: Black Knights Earrings", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsEarringsiiii ), "Phase 4: Black Knights Earrings", 1, "You don't have enough earrings" );
			AddRes( index, typeof( NSGem ), "Gem of NightSight", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRingNS ), "Gemmed", "NightSight: Black Knights Ring", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRingiiii ), "Phase 4: Black Knights Ring", 1, "You don't have enough rings" );
			AddRes( index, typeof( NSGem ), "Gem of NightSight", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRobeNS ), "Gemmed", "NightSight: Black Knights Robe", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRobeiiii ), "Phase 4: Black Knights Robe", 1, "You don't have enough robes" );
			AddRes( index, typeof( NSGem ), "Gem of NightSight", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsShieldNS ), "Gemmed", "NightSight: Black Knights Shield", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsShieldiiii ), "Phase 4: Black Knights Shield", 1, "You don't have enough shields" );
			AddRes( index, typeof( NSGem ), "Gem of NightSight", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsSwordNS ), "Gemmed", "NightSight: Black Knights Sword", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsSwordiiii ), "Phase 4: Black Knights Sword", 1, "You don't have enough swords" );
			AddRes( index, typeof( NSGem ), "Gem of NightSight", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			//End Gem of NightSight
			
			//Begin Gem of SelfRepair
			index = AddCraft( typeof( BlackKnightsArmsSR ), "Gemmed", "SelfRepair: Black Knights Arms", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsArmsiiii ), "Phase 4: Black Knights Arms", 1, "You don't have enough arms" );
			AddRes( index, typeof( SRGem ), "Gem of SelfRepair", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBreastplateSR ), "Gemmed", "SelfRepair: Black Knights Breastplate", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBreastplateiiii ), "Phase 4: Black Knights Breastplate", 1, "You don't have enough breastplates" );
			AddRes( index, typeof( SRGem ), "Gem of SelfRepair", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGlovesSR ), "Gemmed", "SelfRepair: Black Knights Gloves", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGlovesiiii ), "Phase 4: Black Knights Gloves", 1, "You don't have enough gloves" );
			AddRes( index, typeof( SRGem ), "Gem of SelfRepair", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGorgetSR ), "Gemmed", "SelfRepair: Black Knights Gorget", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGorgetiiii ), "Phase 4: Black Knights Gorget", 1, "You don't have enough gorgets" );
			AddRes( index, typeof( SRGem ), "Gem of SelfRepair", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsHelmSR ), "Gemmed", "SelfRepair: Black Knights Helm", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsHelmiiii ), "Phase 4: Black Knights Helm", 1, "You don't have enough helms" );
			AddRes( index, typeof( SRGem ), "Gem of SelfRepair", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsLegsSR ), "Gemmed", "SelfRepair: Black Knights Legs", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsLegsiiii ), "Phase 4: Black Knights Legs", 1, "You don't have enough legs" );
			AddRes( index, typeof( SRGem ), "Gem of SelfRepair", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsShieldSR ), "Gemmed", "SelfRepair: Black Knights Shield", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsShieldiiii ), "Phase 4: Black Knights Shield", 1, "You don't have enough shields" );
			AddRes( index, typeof( SRGem ), "Gem of SelfRepair", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsSwordSR ), "Gemmed", "SelfRepair: Black Knights Sword", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsSwordiiii ), "Phase 4: Black Knights Sword", 1, "You don't have enough swords" );
			AddRes( index, typeof( SRGem ), "Gem of SelfRepair", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			//End Gem of SelfRepair
			
			//Begin Gem of Dexterity
			index = AddCraft( typeof( BlackKnightsArmsDex ), "Gemmed", "Dexterity: Black Knights Arms", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsArmsiiii ), "Phase 4: Black Knights Arms", 1, "You don't have enough arms" );
			AddRes( index, typeof( DexGem ), "Gem of Dexterity", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBreastplateDex ), "Gemmed", "Dexterity: Black Knights Breastplate", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBreastplateiiii ), "Phase 4: Black Knights Breastplate", 1, "You don't have enough breastplates" );
			AddRes( index, typeof( DexGem ), "Gem of Dexterity", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGlovesDex ), "Gemmed", "Dexterity: Black Knights Gloves", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGlovesiiii ), "Phase 4: Black Knights Gloves", 1, "You don't have enough gloves" );
			AddRes( index, typeof( DexGem ), "Gem of Dexterity", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGorgetDex ), "Gemmed", "Dexterity: Black Knights Gorget", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGorgetiiii ), "Phase 4: Black Knights Gorget", 1, "You don't have enough gorgets" );
			AddRes( index, typeof( DexGem ), "Gem of Dexterity", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsHelmDex ), "Gemmed", "Dexterity: Black Knights Helm", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsHelmiiii ), "Phase 4: Black Knights Helm", 1, "You don't have enough helms" );
			AddRes( index, typeof( DexGem ), "Gem of Dexterity", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsLegsDex ), "Gemmed", "Dexterity: Black Knights Legs", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsLegsiiii ), "Phase 4: Black Knights Legs", 1, "You don't have enough legs" );
			AddRes( index, typeof( DexGem ), "Gem of Dexterity", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBraceletDex ), "Gemmed", "Dexterity: Black Knights Bracelet", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBraceletiiii ), "Phase 4: Black Knights Bracelet", 1, "You don't have enough bracelets" );
			AddRes( index, typeof( DexGem ), "Gem of Dexterity", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsEarringsDex ), "Gemmed", "Dexterity: Black Knights Earrings", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsEarringsiiii ), "Phase 4: Black Knights Earrings", 1, "You don't have enough earrings" );
			AddRes( index, typeof( DexGem ), "Gem of Dexterity", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRingDex ), "Gemmed", "Dexterity: Black Knights Ring", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRingiiii ), "Phase 4: Black Knights Ring", 1, "You don't have enough rings" );
			AddRes( index, typeof( DexGem ), "Gem of Dexterity", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRobeDex ), "Gemmed", "Dexterity: Black Knights Robe", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRobeiiii ), "Phase 4: Black Knights Robe", 1, "You don't have enough robes" );
			AddRes( index, typeof( DexGem ), "Gem of Dexterity", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsShieldDex ), "Gemmed", "Dexterity: Black Knights Shield", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsShieldiiii ), "Phase 4: Black Knights Shield", 1, "You don't have enough shields" );
			AddRes( index, typeof( DexGem ), "Gem of Dexterity", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsSwordDex ), "Gemmed", "Dexterity: Black Knights Sword", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsSwordiiii ), "Phase 4: Black Knights Sword", 1, "You don't have enough swords" );
			AddRes( index, typeof( DexGem ), "Gem of Dexterity", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			//End Gem of Dexterity
			
			//Begin Gem of Intelligence
			index = AddCraft( typeof( BlackKnightsArmsInt ), "Gemmed", "Intelligence: Black Knights Arms", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsArmsiiii ), "Phase 4: Black Knights Arms", 1, "You don't have enough arms" );
			AddRes( index, typeof( IntGem ), "Gem of Intelligence", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBreastplateInt ), "Gemmed", "Intelligence: Black Knights Breastplate", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBreastplateiiii ), "Phase 4: Black Knights Breastplate", 1, "You don't have enough breastplates" );
			AddRes( index, typeof( IntGem ), "Gem of Intelligence", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGlovesInt ), "Gemmed", "Intelligence: Black Knights Gloves", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGlovesiiii ), "Phase 4: Black Knights Gloves", 1, "You don't have enough gloves" );
			AddRes( index, typeof( IntGem ), "Gem of Intelligence", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGorgetInt ), "Gemmed", "Intelligence: Black Knights Gorget", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGorgetiiii ), "Phase 4: Black Knights Gorget", 1, "You don't have enough gorgets" );
			AddRes( index, typeof( IntGem ), "Gem of Intelligence", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsHelmInt ), "Gemmed", "Intelligence: Black Knights Helm", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsHelmiiii ), "Phase 4: Black Knights Helm", 1, "You don't have enough helms" );
			AddRes( index, typeof( IntGem ), "Gem of Intelligence", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsLegsInt ), "Gemmed", "Intelligence: Black Knights Legs", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsLegsiiii ), "Phase 4: Black Knights Legs", 1, "You don't have enough legs" );
			AddRes( index, typeof( IntGem ), "Gem of Intelligence", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBraceletInt ), "Gemmed", "Intelligence: Black Knights Bracelet", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBraceletiiii ), "Phase 4: Black Knights Bracelet", 1, "You don't have enough bracelets" );
			AddRes( index, typeof( IntGem ), "Gem of Intelligence", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsEarringsInt ), "Gemmed", "Intelligence: Black Knights Earrings", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsEarringsiiii ), "Phase 4: Black Knights Earrings", 1, "You don't have enough earrings" );
			AddRes( index, typeof( IntGem ), "Gem of Intelligence", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRingInt ), "Gemmed", "Intelligence: Black Knights Ring", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRingiiii ), "Phase 4: Black Knights Ring", 1, "You don't have enough rings" );
			AddRes( index, typeof( IntGem ), "Gem of Intelligence", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRobeInt ), "Gemmed", "Intelligence: Black Knights Robe", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRobeiiii ), "Phase 4: Black Knights Robe", 1, "You don't have enough robes" );
			AddRes( index, typeof( IntGem ), "Gem of Intelligence", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsShieldInt ), "Gemmed", "Intelligence: Black Knights Shield", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsShieldiiii ), "Phase 4: Black Knights Shield", 1, "You don't have enough shields" );
			AddRes( index, typeof( IntGem ), "Gem of Intelligence", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsSwordInt ), "Gemmed", "Intelligence: Black Knights Sword", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsSwordiiii ), "Phase 4: Black Knights Sword", 1, "You don't have enough swords" );
			AddRes( index, typeof( IntGem ), "Gem of Intelligence", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			//End Gem of Intelligence
			
			//Begin Gem of Strength
			index = AddCraft( typeof( BlackKnightsArmsSTR ), "Gemmed", "Strength: Black Knights Arms", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsArmsiiii ), "Phase 4: Black Knights Arms", 1, "You don't have enough arms" );
			AddRes( index, typeof( StrGem ), "Gem of Strength", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBreastplateSTR ), "Gemmed", "Strength: Black Knights Breastplate", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBreastplateiiii ), "Phase 4: Black Knights Breastplate", 1, "You don't have enough breastplates" );
			AddRes( index, typeof( StrGem ), "Gem of Strength", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGlovesSTR ), "Gemmed", "Strength: Black Knights Gloves", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGlovesiiii ), "Phase 4: Black Knights Gloves", 1, "You don't have enough gloves" );
			AddRes( index, typeof( StrGem ), "Gem of Strength", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGorgetSTR ), "Gemmed", "Strength: Black Knights Gorget", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGorgetiiii ), "Phase 4: Black Knights Gorget", 1, "You don't have enough gorgets" );
			AddRes( index, typeof( StrGem ), "Gem of Strength", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsHelmSTR ), "Gemmed", "Strength: Black Knights Helm", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsHelmiiii ), "Phase 4: Black Knights Helm", 1, "You don't have enough helms" );
			AddRes( index, typeof( StrGem ), "Gem of Strength", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsLegsSTR ), "Gemmed", "Strength: Black Knights Legs", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsLegsiiii ), "Phase 4: Black Knights Legs", 1, "You don't have enough legs" );
			AddRes( index, typeof( StrGem ), "Gem of Strength", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBraceletSTR ), "Gemmed", "Strength: Black Knights Bracelet", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBraceletiiii ), "Phase 4: Black Knights Bracelet", 1, "You don't have enough bracelets" );
			AddRes( index, typeof( StrGem ), "Gem of Strength", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsEarringsSTR ), "Gemmed", "Strength: Black Knights Earrings", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsEarringsiiii ), "Phase 4: Black Knights Earrings", 1, "You don't have enough earrings" );
			AddRes( index, typeof( StrGem ), "Gem of Strength", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRingSTR ), "Gemmed", "Strength: Black Knights Ring", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRingiiii ), "Phase 4: Black Knights Ring", 1, "You don't have enough rings" );
			AddRes( index, typeof( StrGem ), "Gem of Strength", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRobeSTR ), "Gemmed", "Strength: Black Knights Robe", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRobeiiii ), "Phase 4: Black Knights Robe", 1, "You don't have enough robes" );
			AddRes( index, typeof( StrGem ), "Gem of Strength", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsShieldSTR ), "Gemmed", "Strength: Black Knights Shield", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsShieldiiii ), "Phase 4: Black Knights Shield", 1, "You don't have enough shields" );
			AddRes( index, typeof( StrGem ), "Gem of Strength", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsSwordSTR ), "Gemmed", "Strength: Black Knights Sword", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsSwordiiii ), "Phase 4: Black Knights Sword", 1, "You don't have enough swords" );
			AddRes( index, typeof( StrGem ), "Gem of Strength", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			//End Gem of Strength
			
			//Begin Gem of Sorcery
			index = AddCraft( typeof( BlackKnightsArmsMag ), "Gemmed", "Sorcery: Black Knights Arms", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsArmsiiii ), "Phase 4: Black Knights Arms", 1, "You don't have enough arms" );
			AddRes( index, typeof( MagGem ), "Gem of Sorcery", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBreastplateMag ), "Gemmed", "Sorcery: Black Knights Breastplate", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBreastplateiiii ), "Phase 4: Black Knights Breastplate", 1, "You don't have enough breastplates" );
			AddRes( index, typeof( MagGem ), "Gem of Sorcery", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGlovesMag ), "Gemmed", "Sorcery: Black Knights Gloves", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGlovesiiii ), "Phase 4: Black Knights Gloves", 1, "You don't have enough gloves" );
			AddRes( index, typeof( MagGem ), "Gem of Sorcery", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsGorgetMag ), "Gemmed", "Sorcery: Black Knights Gorget", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsGorgetiiii ), "Phase 4: Black Knights Gorget", 1, "You don't have enough gorgets" );
			AddRes( index, typeof( MagGem ), "Gem of Sorcery", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsHelmMag ), "Gemmed", "Sorcery: Black Knights Helm", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsHelmiiii ), "Phase 4: Black Knights Helm", 1, "You don't have enough helms" );
			AddRes( index, typeof( MagGem ), "Gem of Sorcery", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsLegsMag ), "Gemmed", "Sorcery: Black Knights Legs", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsLegsiiii ), "Phase 4: Black Knights Legs", 1, "You don't have enough legs" );
			AddRes( index, typeof( MagGem ), "Gem of Sorcery", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsBraceletMag ), "Gemmed", "Sorcery: Black Knights Bracelet", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsBraceletiiii ), "Phase 4: Black Knights Bracelet", 1, "You don't have enough bracelets" );
			AddRes( index, typeof( MagGem ), "Gem of Sorcery", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsEarringsMag ), "Gemmed", "Sorcery: Black Knights Earrings", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsEarringsiiii ), "Phase 4: Black Knights Earrings", 1, "You don't have enough earrings" );
			AddRes( index, typeof( MagGem ), "Gem of Sorcery", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRingMag ), "Gemmed", "Sorcery: Black Knights Ring", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRingiiii ), "Phase 4: Black Knights Ring", 1, "You don't have enough rings" );
			AddRes( index, typeof( MagGem ), "Gem of Sorcery", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsRobeMag ), "Gemmed", "Sorcery: Black Knights Robe", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsRobeiiii ), "Phase 4: Black Knights Robe", 1, "You don't have enough robes" );
			AddRes( index, typeof( MagGem ), "Gem of Sorcery", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsShieldMag ), "Gemmed", "Sorcery: Black Knights Shield", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsShieldiiii ), "Phase 4: Black Knights Shield", 1, "You don't have enough shields" );
			AddRes( index, typeof( MagGem ), "Gem of Sorcery", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			
			index = AddCraft( typeof( BlackKnightsSwordMag ), "Gemmed", "Sorcery: Black Knights Sword", 100.0, 120.0, typeof( BlackKnightsSoul ), "Black Knights Soul", 1, "You don't have enough souls" );
			AddRes( index, typeof( BlackKnightsSwordiiii ), "Phase 4: Black Knights Sword", 1, "You don't have enough swords" );
			AddRes( index, typeof( MagGem ), "Gem of Sorcery", 1, "You don't have enough gems" );
			AddRes( index, typeof( LostWorldTicket ), "Lost World Tickets", 50, "You don't have enough tickets" );
			//End Gem of Sorcery
			#endregion
			
			//Example mutliple resources and/or skills
/*
			index = AddCraft( typeof( Name ), "Catagorie", "Name", 100.0, 150.0, typeof( Resource ), "Name Resource", 2, "You need more Key Rings" );
			AddSkill( index, SkillName.Carpentry, 100.0, 150.0 );
			AddSkill( index, SkillName.Blacksmith, 100.0, 150.0 );
			AddSkill( index, SkillName.Tailoring, 100.0, 150.0 );
			AddRes( index, typeof( Gold ), "Gold", 6000, "You need more Gold" );
			AddRes( index, typeof( resource 2 ), "", 100, "" );
			AddRes( index, typeof( resource 3 ), "", 20, "" );
*/
			
		


			// Set the overridable material
			//SetSubRes( typeof( GemShard ), 1049150 );

			// Add every material you want the player to be able to choose from
			// This will override the overridable material
			/*AddSubRes( typeof( Leather ),		1049150, 00.0, 1044462, 1049311 );
			AddSubRes( typeof( SpinedLeather ),	1049151, 65.0, 1044462, 1049311 );
			AddSubRes( typeof( HornedLeather ),	1049152, 80.0, 1044462, 1049311 );
			AddSubRes( typeof( BarbedLeather ),	1049153, 99.0, 1044462, 1049311 );*/

		//	MarkOption = true;
		//	Repair = Core.AOS;
		//	CanEnhance = Core.AOS;
		}

		public override int CanCraft(Mobile from, ITool tool, Type itemType)
		{
			int num = 0;

			if (tool == null || tool.Deleted || tool.UsesRemaining <= 0)
				return 1044038; // You have worn out your tool!
			else if (!tool.CheckAccessible(from, ref num))
				return num; // The tool must be on your person to use.

			return 0;
		}
	}
}