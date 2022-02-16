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
	public class BlackKnightsRingInt : GoldRing
	{
		public override int LabelNumber{ get{ return 1061102; } } // Black Knights Ring
		public override int ArtifactRarity{ get{ return 6; } }

		[Constructable]
		public BlackKnightsRingInt()
		{
			Name = "<BASEFONT COLOR=#FD8801>Black Knight's Ring";
			Hue = 1175;
			Attributes.BonusStr = 5;
			Attributes.BonusInt = 5;
			SkillBonuses.SetValues( 0, SkillName.Swords, 5.0 );
			Attributes.WeaponSpeed = 3;
		}

		public BlackKnightsRingInt( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#FD8801>Phase 4<BR><BASEFONT COLOR=#E0FA76>Socket: <BASEFONT COLOR=#FBE70A>Gem of Intelligence<BASEFONT COLOR=#68FCAD><br>+5 Intelligence" );
 } 
	}
}