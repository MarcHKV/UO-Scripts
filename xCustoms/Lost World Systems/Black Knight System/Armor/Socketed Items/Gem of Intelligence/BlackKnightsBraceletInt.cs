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
	public class BlackKnightsBraceletInt : GoldBracelet
	{
		public override int LabelNumber{ get{ return 1061103; } } // Black Knights Bracelet
		public override int ArtifactRarity{ get{ return 6; } }

		[Constructable]
		public BlackKnightsBraceletInt()  
		{
		    LootType = LootType.Regular;
		    Name = "<BASEFONT COLOR=#FD8801>Black Knight's Bracelet"; 
		    Hue = 1175;
			Attributes.BonusHits = 7;
			Attributes.BonusInt = 5;
			Attributes.WeaponDamage = 5;
			SkillBonuses.SetValues( 0, SkillName.Tactics, 5.0 );
		}

		public BlackKnightsBraceletInt( Serial serial ) : base( serial )
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