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
	public class BlackKnightsGorgetii : PlateGorget
	{
		public override int LabelNumber{ get{ return 1061594; } } // Black Knights Gorget
		public override int ArtifactRarity{ get{ return 4; } }

		public override int InitMinHits{ get{ return 100; } }
		public override int InitMaxHits{ get{ return 100; } }

		public override int BasePhysicalResistance{ get{ return 14; } }
		public override int BasePoisonResistance{ get{ return 8; } }
		public override int BaseFireResistance{ get{ return 8; } }
		public override int BaseColdResistance{ get{ return 8; } }
		public override int BaseEnergyResistance{ get{ return 6; } }
		
		[Constructable]
		public BlackKnightsGorgetii()
		{
			LootType = LootType.Regular;
			Name = "<BASEFONT COLOR=#01FD0E>Black Knight's Gorget";
			Hue = 1175;
			ArmorAttributes.LowerStatReq = 5;
			Attributes.BonusStr = 3;
			Attributes.RegenHits = 2;
			
		}

		public BlackKnightsGorgetii( Serial serial ) : base( serial )
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