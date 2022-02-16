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
	public class BlackKnightsRingii : GoldRing
	{
		public override int LabelNumber{ get{ return 1061102; } } // Black Knights Ring
		public override int ArtifactRarity{ get{ return 4; } }

		[Constructable]
		public BlackKnightsRingii()
		{
			Name = "<BASEFONT COLOR=#01FD0E>Black Knight's Ring";
			Hue = 1175;
			Attributes.BonusStr = 3;
			SkillBonuses.SetValues( 0, SkillName.Swords, 4.0 );
			
		}

		public BlackKnightsRingii( Serial serial ) : base( serial )
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