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
	public class BlackKnightsGorgetiii : PlateGorget
	{
		public override int LabelNumber{ get{ return 1061594; } } // Black Knights Gorget
		public override int ArtifactRarity{ get{ return 5; } }

		public override int InitMinHits{ get{ return 125; } }
		public override int InitMaxHits{ get{ return 125; } }

		public override int BasePhysicalResistance{ get{ return 15; } }
		public override int BasePoisonResistance{ get{ return 9; } }
		public override int BaseFireResistance{ get{ return 9; } }
		public override int BaseColdResistance{ get{ return 9; } }
		public override int BaseEnergyResistance{ get{ return 7; } }
		
		[Constructable]
		public BlackKnightsGorgetiii()
		{
			LootType = LootType.Regular;
			Name = "<BASEFONT COLOR=#C201FD>Black Knight's Gorget";
			Hue = 1175;
			ArmorAttributes.LowerStatReq = 5;
			Attributes.BonusStr = 4;
			Attributes.RegenHits = 2;
			Attributes.ReflectPhysical = 1;
			
		}

		public BlackKnightsGorgetiii( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#C201FD>Phase 3<BR><BASEFONT COLOR=#75FBEB>There's something about this item<BR>You noticed there's a hole in the item<BR>But can't figure out what they're for" );
 } 
	}
}