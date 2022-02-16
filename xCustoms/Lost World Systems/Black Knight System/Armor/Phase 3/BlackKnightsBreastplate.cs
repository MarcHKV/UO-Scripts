//////////////////////////////////////////////////////////
//		Creator: Murrer 		Scripter: Murrer		//
//				Server: Lost World UO					//
//////////////////////////////////////////////////////////
//						Testers							//
//////////////////////////////////////////////////////////
//			  Murrer				Camelin				//
////////////////////////////////////////////////////////// 

using System;
using Server;

namespace Server.Items
{
	public class BlackKnightsBreastplateiii : PlateChest
	{
		public override int LabelNumber{ get{ return 1061097; } } // Black Knights Breastplate
		public override int ArtifactRarity{ get{ return 5; } }

		public override int BasePhysicalResistance{ get{ return 18; } }
		public override int BasePoisonResistance{ get{ return 12; } }
		public override int BaseFireResistance{ get{ return 12; } }
		public override int BaseColdResistance{ get{ return 12; } }
		public override int BaseEnergyResistance{ get{ return 10; } }
		
		public override int InitMinHits{ get{ return 125; } }
		public override int InitMaxHits{ get{ return 125; } }

		[Constructable]
		public BlackKnightsBreastplateiii()
		{
			LootType = LootType.Regular;
			Name = "<BASEFONT COLOR=#C201FD>Black Knight's Breastplate";
			Hue = 1175;
			Attributes.ReflectPhysical = 5;
			ArmorAttributes.LowerStatReq = 5;
			Attributes.DefendChance = 5;
			Attributes.BonusHits = 3;
		}

		public BlackKnightsBreastplateiii( Serial serial ) : base( serial )
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