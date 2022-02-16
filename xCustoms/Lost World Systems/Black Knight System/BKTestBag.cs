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
	public class BKTestBag : Bag
	{
		[Constructable]
		public BKTestBag()
		{
		
			Name = "Black Knights Bag";
			DropItem( new BlackKnightsArms() );
			DropItem( new BlackKnightsBreastplate() );
			DropItem( new BlackKnightsEarrings() );
			DropItem( new BlackKnightsBracelet() );
			DropItem( new BlackKnightsRing() );
			DropItem( new BlackKnightsShield() );
			DropItem( new BlackKnightsSword() );
			DropItem( new BlackKnightsLegs() );
			DropItem( new BlackKnightsRobe() );
			DropItem( new BlackKnightsHelm() );
			DropItem( new BlackKnightsGloves() );
			DropItem( new BlackKnightsGorget() );
			DropItem( new BagOfBKSouls() );

		}

		public BKTestBag( Serial serial ) : base( serial )
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