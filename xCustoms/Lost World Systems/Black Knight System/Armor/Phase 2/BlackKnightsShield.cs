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
	public class BlackKnightsShieldii : MetalKiteShield
	{
		public override int LabelNumber{ get{ return 1061602; } } // Black Knights Shield
		public override int ArtifactRarity{ get{ return 4; } }

		public override int BasePhysicalResistance{ get{ return 4; } }
		public override int BaseFireResistance{ get{ return 4; } }
		public override int BaseColdResistance{ get{ return 4; } }
		public override int BasePoisonResistance{ get{ return 4; } }
		public override int BaseEnergyResistance{ get{ return 4; } }
		
		public override int InitMinHits{ get{ return 100; } }
		public override int InitMaxHits{ get{ return 100; } }

		[Constructable]
		public BlackKnightsShieldii()
		{
		    Name = "<BASEFONT COLOR=#01FD0E>Black Knight's Shield";
			Hue = 1175;
				Attributes.ReflectPhysical = 3;
			Attributes.DefendChance = 4;
			Attributes.Luck = 15;
			
		}

		public BlackKnightsShieldii( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize(GenericReader reader)
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
		


public override void GetProperties( ObjectPropertyList list )
 {
 base.GetProperties( list );
 list.Add( "<BASEFONT COLOR=#01FD0E>Phase 2<BR><BASEFONT COLOR=#75FBEB>There's something about this item<BR>But you can't figure out what" );
 } 
	}
}