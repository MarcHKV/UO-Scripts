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
	public class BlackKnightsEarringsii : GoldEarrings
	{
		public override int LabelNumber{ get{ return 1061103; } } // Black Knights Earrings
		public override int ArtifactRarity{ get{ return 4; } }

		[Constructable]
		public BlackKnightsEarringsii()  
		{
		    LootType = LootType.Regular;
		    Name = "<BASEFONT COLOR=#01FD0E>Black Knight's Earrings"; 
		    Hue = 1175;
			Attributes.RegenHits = 1;
			Attributes.AttackChance = 4;
			SkillBonuses.SetValues( 0, SkillName.Parry, 1.0 );
		
		}

		public BlackKnightsEarringsii( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#01FD0E>Phase 2<BR><BASEFONT COLOR=#75FBEB>There's something about this item<BR>But you can't figure out what" );
 } 
	}
}