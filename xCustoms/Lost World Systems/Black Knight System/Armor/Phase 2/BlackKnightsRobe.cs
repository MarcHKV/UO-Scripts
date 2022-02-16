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
	public class BlackKnightsRobeii : BaseArmor
	{ 
        public override int ArtifactRarity{ get{return 4; } }

		public override int BasePhysicalResistance{ get{ return 3; } }
		public override int BaseFireResistance{ get{ return 3; } }
		public override int BaseColdResistance{ get{ return 3; } }
		public override int BasePoisonResistance{ get{ return 3; } }
		public override int BaseEnergyResistance{ get{ return 3; } }

		public override int ArmorBase{ get{ return 40; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Cloth; } }

		[Constructable]
		public BlackKnightsRobeii() : base( 0x2684 )
		{
			
			Weight = 3.0;
           		LootType = LootType.Regular;
				Name = "<BASEFONT COLOR=#01FD0E>Black Knight's Robe";
				Hue = 1175;
				Attributes.Luck = 15;
				Attributes.BonusHits = 5;
				Attributes.BonusStr = 1;
                        Layer = Layer.OuterTorso;
                        ItemID = 0x2684;

			Weight = 3.0;
		}

		public BlackKnightsRobeii( Serial serial ) : base( serial )
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