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
	public class BlackKnightsBraceletii : GoldBracelet
	{
		public override int LabelNumber{ get{ return 1061103; } } // Black Knights Bracelet
		public override int ArtifactRarity{ get{ return 4; } }

		[Constructable]
		public BlackKnightsBraceletii()  
		{
		    LootType = LootType.Regular;
		    Name = "<BASEFONT COLOR=#01FD0E>Black Knight's Bracelet"; 
		    Hue = 1175;
			Attributes.BonusHits = 6;
			Attributes.WeaponDamage = 3;
		
		}

		public BlackKnightsBraceletii( Serial serial ) : base( serial )
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