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
	public class BlackKnightsSoul : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public BlackKnightsSoul() : this( 1 )
		{
			Weight = 0.1;
			Name = "Black Knights Soul";
			ItemID = 12679;
			Hue = 2075;
		}

		[Constructable]
		public BlackKnightsSoul( int amount ) : base( 0xF25 )
		{
			Stackable = false;
			Amount = amount;
		}

		public BlackKnightsSoul( Serial serial ) : base( serial )
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
 list.Add( "<ASEFONT COLOR=#E0FA76>An Item Required For<br>Enhancing The Black Knight Set" );
 } 
	}
}