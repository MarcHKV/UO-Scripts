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
	public class StrGem : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public StrGem() : this( 1 )
		{
			Name = "<BASEFONT COLOR=#FB0A0E>Gem of Strength"; 
			ItemID = 7955;
			Hue = 38;
		}

		[Constructable]
		public StrGem( int amount ) : base( 0xF25 )
		{
			Stackable = false;
			Amount = amount;
		}

		public StrGem( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#E0FA76>Jewels: +5 Strength<BR>Clothing: +5 HP/+1 HP Regeneration<BR>Armor: +5% Reflect<BR>Shield: +5% Reflect<BR>Weapon: +5% Weapon Damage" );
 } 
	}
}