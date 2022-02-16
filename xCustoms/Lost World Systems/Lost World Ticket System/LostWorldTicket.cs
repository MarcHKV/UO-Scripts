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
	public class LostWorldTicket : Item
	{
		public override double DefaultWeight
		{
			get { return 0.0; }
		}

		[Constructable]
		public LostWorldTicket() : this( 1 )
		{
			Name = "Lost World Ticket";
			ItemID = 7997;
			Hue = 1258;
		}

		[Constructable]
		public LostWorldTicket( int amount ) : base( 0xF25 )
		{
			Stackable = true;
			Amount = amount;
			Name = "Lost World Ticket";
			ItemID = 7997;
			Hue = 1258;
		}

		public LostWorldTicket( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#E0FA76>A lost world reward ticket<br>Used for unique items and artifact enhancement" );
 } 
	}
}