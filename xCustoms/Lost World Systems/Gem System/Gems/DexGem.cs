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
	public class DexGem : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public DexGem() : this( 1 )
		{
			Name = "<BASEFONT COLOR=#31C41A>Gem of Dexterity";
			ItemID = 7955;
			Hue = 1268;
		}

		[Constructable]
		public DexGem( int amount ) : base( 0xF25 )
		{
			Stackable = false;
			Amount = amount;
		}

		public DexGem( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#E0FA76>Jewels: +5 Dexterity<BR>Clothing: +5 Stamina/+1 Stamina Regeneration<BR>Armor: +2% Reflect/+3% Defend chance<BR>Shield: +2% Reflect/+3% Defend chance<BR>Weapon: +5% Attack Speed" );
 } 
	}
}