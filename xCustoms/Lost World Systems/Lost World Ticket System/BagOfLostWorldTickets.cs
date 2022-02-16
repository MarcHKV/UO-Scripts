//////////////////////////////////////////////////////////
//		Creator: Murrer 		Scripter: Murrer		//
//				Server: Lost World UO					//
//////////////////////////////////////////////////////////
//						Testers							//
//////////////////////////////////////////////////////////
//			  Murrer									//
////////////////////////////////////////////////////////// 

using System;
using Server.Items;
using Server.Network;

namespace Server.Items
{
	[Flipable( 0x232A, 0x232B )]
	public class BagOfLostWorldTickets : Bag
	{
		[Constructable]
		public BagOfLostWorldTickets()
		{
		
			Name = "Bag of Lost World Tickets";
			DropItem( new LostWorldTicket(1000) );
			

		}

		public BagOfLostWorldTickets( Serial serial ) : base( serial )
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
	}
}