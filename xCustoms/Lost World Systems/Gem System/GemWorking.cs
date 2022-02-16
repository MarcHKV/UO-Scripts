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
	public class DefGemWorking : CraftSystem
	{
		public override SkillName MainSkill
		{
			get	{ return SkillName.Tinkering; }
		}

		public override int GumpTitleNumber
		{
			get { return 1; } // Gem Working
		}

		private static CraftSystem m_CraftSystem;

		public static CraftSystem CraftSystem
		{
			get
			{
				if ( m_CraftSystem == null )
					m_CraftSystem = new DefGemWorking();

				return m_CraftSystem;
			}
		}

		public override CraftECA ECA{ get{ return CraftECA.ChanceMinusSixtyToFourtyFive; } }

		public override double GetChanceAtMin( CraftItem item )
		{
			return 0.5; // 50%
		}

		private DefGemWorking() : base( 1, 1, 1.25 )// base( 1, 1, 4.5 )
		{
		}

		//public int CanCraft( Mobile from, BaseTool tool, Type itemType )
		//{
		//	if( tool == null || tool.Deleted || tool.UsesRemaining < 0 )
		//		return 1044038; // You have worn out your tool!
		//	else if ( !BaseTool.CheckAccessible( tool, from ) )
		//		return 1044263; // The tool must be on your person to use.

		//	return 0;
		//}

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

			#region Gems
			AddCraft( typeof( LuckGem ), "Gems", "Gem of Luck", 65, 85, typeof( GemShard ), "Gem Shards", 3, "You do not have enough Gem Shards!" );
			AddCraft( typeof( NSGem ), "Gems", "Gem of NightSight", 75, 95, typeof( GemShard ), "Gem Shards", 4, "You do not have enough Gem Shards!" );
			AddCraft( typeof( SRGem ), "Gems", "Gem of SelfRepair", 75, 95, typeof( GemShard ), "Gem Shards", 4, "You do not have enough Gem Shards!" );
			AddCraft( typeof( BlessGem ), "Gems", "Gem of Blessing", 85, 120, typeof( GemShard ), "Gem Shards", 5, "You do not have enough Gem Shards!" );
			AddCraft( typeof( DexGem ), "Gems", "Gem of Dexterity", 95, 150.0, typeof( GemShard ), "Gem Shards", 7, "You do not have enough Gem Shards!" );
			AddCraft( typeof( IntGem ), "Gems", "Gem of Intelligence", 95, 150.0, typeof( GemShard ), "Gem Shards", 7, "You do not have enough Gem Shards!" );
			AddCraft( typeof( StrGem ), "Gems", "Gem of Strength", 95, 150.1, typeof( GemShard ), "Gem Shards", 7, "You do not have enough Gem Shards!" );
			AddCraft( typeof( MagGem ), "Gems", "Gem of Sorcery", 100, 200, typeof( GemShard ), "Gem Shards", 10, "You do not have enough Gem Shards!" );
			
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
			
			#endregion



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