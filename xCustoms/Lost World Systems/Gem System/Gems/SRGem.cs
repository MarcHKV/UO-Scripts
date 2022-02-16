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
	public class SRGem : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public SRGem() : this( 1 )
		{
			Name = "<BASEFONT COLOR=#838682>Gem of SelfRepair";
			ItemID = 7955;
			Hue = 975;
		}

		[Constructable]
		public SRGem( int amount ) : base( 0xF25 )
		{
			Stackable = false;
			Amount = amount;
		}

		public SRGem( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#E0FA76>Armor: +5 self repair<BR>Shield: +5 self repair<BR>Weapon: +5 self repair" );
 } 
	}
}