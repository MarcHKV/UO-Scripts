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
	public class BagOfBKSouls : Bag
	{
		[Constructable]
		public BagOfBKSouls()
		{
		
			Name = "Bag of Black Knights Souls";
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );
			DropItem( new BlackKnightsSoul() );

		}

		public BagOfBKSouls( Serial serial ) : base( serial )
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