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
	public class BlackKnightsEarringsiiii : GoldEarrings
	{
		public override int LabelNumber{ get{ return 1061103; } } // Black Knights Earrings
		public override int ArtifactRarity{ get{ return 6; } }

		[Constructable]
		public BlackKnightsEarringsiiii()  
		{
		    LootType = LootType.Regular;
		    Name = "<BASEFONT COLOR=#FD8801>Black Knight's Earrings"; 
		    Hue = 1175;
			Attributes.RegenHits = 2;
			Attributes.AttackChance = 5;
			Attributes.Luck = 5;
			SkillBonuses.SetValues( 0, SkillName.Parry, 5.0 );
		}

		public BlackKnightsEarringsiiii( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#FD8801>Phase 4<BR><BASEFONT COLOR=#75FBEB>You noticed there's a socket in the item<BR><BASEFONT COLOR=#E0FA76>Socket: Empty" );
 } 
	}
}