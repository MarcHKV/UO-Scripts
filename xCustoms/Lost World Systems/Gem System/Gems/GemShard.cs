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
	public class GemShard : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public GemShard() : this( 1 )
		{
			Name = "Gem Shard";
			ItemID = 7847;
			Hue = 2513;
		}

		[Constructable]
		public GemShard( int amount ) : base( 0xF25 )
		{
			Stackable = true;
			Amount = amount;
			Name = "Gem Shard";
			ItemID = 7847;
			Hue = 2513;
		
		}

		public GemShard( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#E0FA76>Collect enough to<br>Create a powerful gem" );
 } 
	}
}