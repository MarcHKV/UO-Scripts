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
	public class BlessGem : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public BlessGem() : this( 1 )
		{
			Name = "<BASEFONT COLOR=#AFF3FB>Gem of Blessing";
			ItemID = 7955;
			Hue = 1151;
		}

		[Constructable]
		public BlessGem( int amount ) : base( 0xF25 )
		{
			Stackable = false;
			Amount = amount;
		}

		public BlessGem( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#E0FA76>All items: Blesses the item<br>and grants 50% durability bonus" );
 } 
	}
}