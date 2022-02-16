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
	public class IntGem : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public IntGem() : this( 1 )
		{
			Name = "<BASEFONT COLOR=#FBE70A>Gem of Intelligence";
			ItemID = 7955;
			Hue = 1360;
		}

		[Constructable]
		public IntGem( int amount ) : base( 0xF25 )
		{
			Stackable = false;
			Amount = amount;
		}

		public IntGem( Serial serial ) : base( serial )
		{
		}

		

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
			}
public override void GetProperties( ObjectPropertyList list )
 {
 base.GetProperties( list );
 list.Add( "<BASEFONT COLOR=#E0FA76>Jewels: +5 Intelligence<BR>Clothing: +5 Mana/+1 Mana Regeneration<BR>Armor: +5% Defend chance<BR>Shield: +5% Defend chance<BR>Weapon: +5% Attack Chance" );
 } 
	}
}