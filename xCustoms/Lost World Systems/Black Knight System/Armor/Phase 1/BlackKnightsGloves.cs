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
	public class BlackKnightsGloves : PlateGloves
	{
		public override int LabelNumber{ get{ return 1060206; } } // Black Knights Gloves
		public override int ArtifactRarity{ get{ return 3; } }

		public override int BasePhysicalResistance{ get{ return 14; } }
		public override int BasePoisonResistance{ get{ return 8; } }
		public override int BaseFireResistance{ get{ return 8; } }
		public override int BaseColdResistance{ get{ return 8; } }
		public override int BaseEnergyResistance{ get{ return 6; } }

		
		public override int InitMinHits{ get{ return 75; } }
		public override int InitMaxHits{ get{ return 75; } }

		[Constructable]
		public BlackKnightsGloves()
		{
			LootType = LootType.Regular;
			Name = "<BASEFONT COLOR=#0198FD>Black Knight's Gloves";
			Hue = 1175;
			ArmorAttributes.LowerStatReq = 5;
			Attributes.WeaponSpeed = 2;
			Attributes.AttackChance = 2;
			
		}

		public BlackKnightsGloves( Serial serial ) : base( serial )
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