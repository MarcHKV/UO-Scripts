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
using Server.Engines.Craft;

namespace Server.Items
{
	[FlipableAttribute( 0x1022, 0x1023 )]
	public class GemKit : BaseTool
	{
		public override CraftSystem CraftSystem{ get{ return DefGemWorking.CraftSystem; } }

		[Constructable]
		public GemKit() : base( 0x1022 )
		{
			Weight = 2.0;
			Name = "Gem Working Kit";
			UsesRemaining = 1000;
			ItemID = 4135;
		}

		[Constructable]
		public GemKit( int uses ) : base( uses, 0x1022 )
		{
			Weight = 2.0;
		}

		public GemKit( Serial serial ) : base( serial )
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

			if ( Weight == 1.0 )
				Weight = 2.0;
		}
	}
}