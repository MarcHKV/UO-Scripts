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
	public class BlackKnightsSword : VikingSword
	{
		public override int LabelNumber{ get{ return 1061107; } } // The Blade Of The Black Knight
		public override int ArtifactRarity{ get{ return 3; } }

		public override int InitMinHits{ get{ return 75; } }
		public override int InitMaxHits{ get{ return 75; } }

		[Constructable]
		public BlackKnightsSword()
		{
		    Name = "<BASEFONT COLOR=#0198FD>Black Knight's Sword";
			Hue = 1175;
			WeaponAttributes.HitFireball = 5;
			
			WeaponAttributes.HitLightning = 5;
			
			Attributes.Luck = 25;
		
			Attributes.WeaponSpeed = 5;
			
			Attributes.WeaponDamage = 5;
		}

		public BlackKnightsSword( Serial serial ) : base( serial )
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