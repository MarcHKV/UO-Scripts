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
	public class BlackKnightsRobeLuck : BaseArmor
	{ 
        public override int ArtifactRarity{ get{return 6; } }

		public override int BasePhysicalResistance{ get{ return 5; } }
		public override int BaseFireResistance{ get{ return 5; } }
		public override int BaseColdResistance{ get{ return 5; } }
		public override int BasePoisonResistance{ get{ return 5; } } 
		public override int BaseEnergyResistance{ get{ return 5; } }

		public override int ArmorBase{ get{ return 40; } }

		public override ArmorMaterialType MaterialType{ get{ return ArmorMaterialType.Cloth; } }

		[Constructable]
		public BlackKnightsRobeLuck() : base( 0x2684 )
		{
			
			Weight = 3.0;
           		LootType = LootType.Regular;
				Name = "<BASEFONT COLOR=#FD8801>Black Knight's Robe";
				Hue = 1175;
				Attributes.Luck = 125;
				Attributes.BonusHits = 10;
				Attributes.BonusStr = 3;
                        Layer = Layer.OuterTorso;
                        ItemID = 0x2684;

			Weight = 3.0;
		}

		public BlackKnightsRobeLuck( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#FD8801>Phase 4<BR><BASEFONT COLOR=#E0FA76>Socket: <BASEFONT COLOR=#9D0BAB>Gem of Luck<BASEFONT COLOR=#68FCAD><br>+100 Luck" );
 } 
	}
}