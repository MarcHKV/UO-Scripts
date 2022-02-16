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
	public class BlackKnightsSwordDex : VikingSword
	{
		public override int LabelNumber{ get{ return 1061107; } } // The Blade Of The Black Knight
		public override int ArtifactRarity{ get{ return 6; } }

		public override int InitMinHits{ get{ return 175; } }
		public override int InitMaxHits{ get{ return 175; } }

		[Constructable]
		public BlackKnightsSwordDex()
		{
		    Name = "<BASEFONT COLOR=#FD8801>Black Knight's Sword";
			Hue = 1175;
			WeaponAttributes.HitFireball = 15;
			WeaponAttributes.HitLeechHits = 5;
			WeaponAttributes.HitLightning = 15;
			
			Attributes.Luck = 25;
		
			Attributes.WeaponSpeed = 15;
			
			Attributes.WeaponDamage = 10;
		}

		public BlackKnightsSwordDex( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#FD8801>Phase 4<BR><BASEFONT COLOR=#E0FA76>Socket: <BASEFONT COLOR=#31C41A>Gem of Dexterity<BASEFONT COLOR=#68FCAD><br>+5% Attack Speed" );
 } 
	}
}