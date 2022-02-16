//////////////////////////////////////////////////////////
//		Creator: Murrer 		Scripter: Murrer		//
//				Server: Lost World UO					//
//////////////////////////////////////////////////////////
//						Testers							//
//////////////////////////////////////////////////////////
//			  Murrer				Camelin				//
////////////////////////////////////////////////////////// 

using System;
using Server;

namespace Server.Items
{
	public class BlackKnightsBracelet : GoldBracelet
	{
		public override int LabelNumber{ get{ return 1061103; } } // Black Knights Bracelet
		public override int ArtifactRarity{ get{ return 3; } }

		[Constructable]
		public BlackKnightsBracelet()  
		{
		    LootType = LootType.Regular;
		    Name = "<BASEFONT COLOR=#0198FD>Black Knight's Bracelet"; 
		    Hue = 1175;
			Attributes.BonusHits = 5;
			Attributes.WeaponDamage = 2;

		}

		public BlackKnightsBracelet( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#0198FD>Phase 1<BASEFONT COLOR=#75FBEB><BR>There is nothing special<BR>about this item" );
 } 
	}
}