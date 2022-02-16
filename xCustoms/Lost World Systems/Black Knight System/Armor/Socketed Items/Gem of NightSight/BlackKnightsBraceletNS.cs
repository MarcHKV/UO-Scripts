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
	public class BlackKnightsBraceletNS : GoldBracelet
	{
		public override int LabelNumber{ get{ return 1061103; } } // Black Knights Bracelet
		public override int ArtifactRarity{ get{ return 6; } }

		[Constructable]
		public BlackKnightsBraceletNS()  
		{
		    LootType = LootType.Regular;
		    Name = "<BASEFONT COLOR=#FD8801>Black Knight's Bracelet"; 
		    Hue = 1175;
			Attributes.BonusHits = 7;
			Attributes.WeaponDamage = 5;
			Attributes.NightSight = 1;
			SkillBonuses.SetValues( 0, SkillName.Tactics, 5.0 );
		}

		public BlackKnightsBraceletNS( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#FD8801>Phase 4<BR><BASEFONT COLOR=#E0FA76>Socket: <BASEFONT COLOR=#35AEFC>Gem of NightSight<BASEFONT COLOR=#68FCAD><br>Night Sight" );
 } 
	}
}