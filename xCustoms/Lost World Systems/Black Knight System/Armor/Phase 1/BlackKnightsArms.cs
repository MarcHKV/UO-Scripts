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
	public class BlackKnightsArms : PlateArms
	{
		public override int ArtifactRarity{ get{ return 3; } }

		public override int BasePhysicalResistance{ get{ return 14; } }
		public override int BasePoisonResistance{ get{ return 8; } }
		public override int BaseFireResistance{ get{ return 8; } }
		public override int BaseColdResistance{ get{ return 8; } }
		public override int BaseEnergyResistance{ get{ return 6; } }
		
		public override int InitMinHits{ get{ return 75; } }
		public override int InitMaxHits{ get{ return 75; } }

		[Constructable]
		public BlackKnightsArms()
		{
			Weight = 1.0; 
            		Name = "<BASEFONT COLOR=#0198FD>Black Knight's Arms"; 
	
            		Hue = 1175;


			ArmorAttributes.LowerStatReq = 5;
			Attributes.BonusStr = 2;
			Attributes.WeaponDamage = 2;
			
					

			LootType = LootType.Regular;

		}

		public BlackKnightsArms( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 );
		}
		
		public override void Deserialize( GenericReader reader)
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
