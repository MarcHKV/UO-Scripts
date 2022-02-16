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
	public class BlackKnightsRobe : BaseArmor
	{ 
        public override int ArtifactRarity{ get{return 3; } }

		public override int BasePhysicalResistance{ get{ return 2; } }
		public override int BaseFireResistance{ get{ return 2; } }
		public override int BaseColdResistance{ get{ return 2; } }
		public override int BasePoisonResistance{ get{ return 2; } }
		public override int BaseEnergyResistance{ get{ return 2; } }

		public override int ArmorBase{ get{ return 40; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Cloth; } }

		[Constructable]
		public BlackKnightsRobe() : base( 0x2684 )
		{
			
			Weight = 3.0;
           		LootType = LootType.Regular;
				Name = "<BASEFONT COLOR=#0198FD>Black Knight's Robe";
				Hue = 1175;
				Attributes.Luck = 10;
				Attributes.BonusHits = 5;
			
                        Layer = Layer.OuterTorso;
                        ItemID = 0x2684;

			Weight = 1.0;
		}

		public BlackKnightsRobe( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#0198FD>Phase 1<BASEFONT COLOR=#75FBEB><BR>There is nothing special<BR>about this item" );
 } 
	}
}