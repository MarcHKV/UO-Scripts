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
	public class BlackKnightsSwordiii : VikingSword
	{
		public override int LabelNumber{ get{ return 1061107; } } // The Blade Of The Black Knight
		public override int ArtifactRarity{ get{ return 5; } }

		public override int InitMinHits{ get{ return 125; } }
		public override int InitMaxHits{ get{ return 125; } }

		[Constructable]
		public BlackKnightsSwordiii()
		{
		    Name = "<BASEFONT COLOR=#C201FD>Black Knight's Sword";
			Hue = 1175;
			WeaponAttributes.HitFireball = 7;
			WeaponAttributes.HitLeechHits = 2;
			WeaponAttributes.HitLightning = 12;
			
			Attributes.Luck = 25;
		
			Attributes.WeaponSpeed = 7;
			
			Attributes.WeaponDamage = 8;
		}

		public BlackKnightsSwordiii( Serial serial ) : base( serial )
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