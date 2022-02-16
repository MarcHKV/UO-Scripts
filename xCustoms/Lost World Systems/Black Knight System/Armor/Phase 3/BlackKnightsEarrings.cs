//////////////////////////////////////////////////////////
//		Creator: Murrer 		Scripter: Murrer		//
//				Server: Lost World UO					//
//////////////////////////////////////////////////////////
//						Testers							//
//////////////////////////////////////////////////////////
//			  Murrer									//
////////////////////////////////////////////////////////// 

using System;
using Server;

namespace Server.Items
{
	public class BlackKnightsEarringsiii : GoldEarrings
	{
		public override int LabelNumber{ get{ return 1061103; } } // Black Knights Earrings
		public override int ArtifactRarity{ get{ return 5; } }

		[Constructable]
		public BlackKnightsEarringsiii()  
		{
		    LootType = LootType.Regular;
		    Name = "<BASEFONT COLOR=#C201FD>Black Knight's Earrings"; 
		    Hue = 1175;
			Attributes.RegenHits = 2;
			Attributes.AttackChance = 5;
			SkillBonuses.SetValues( 0, SkillName.Parry, 3.0 );
		}

		public BlackKnightsEarringsiii( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
		


public override void GetProperties( ObjectPropertyList list )
 {
 base.GetProperties( list );
 list.Add( "<BASEFONT COLOR=#C201FD>Phase 3<BR><BASEFONT COLOR=#75FBEB>There's something about this item<BR>You noticed there's a hole in the item<BR>But can't figure out what they're for" );
 } 
	}
}