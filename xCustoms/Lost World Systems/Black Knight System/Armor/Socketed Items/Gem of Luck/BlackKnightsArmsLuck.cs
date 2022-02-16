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
	public class BlackKnightsArmsLuck : PlateArms
	{
		public override int ArtifactRarity{ get{ return 6; } }

		public override int BasePhysicalResistance{ get{ return 17; } }
		public override int BasePoisonResistance{ get{ return 11; } }
		public override int BaseFireResistance{ get{ return 11; } }
		public override int BaseColdResistance{ get{ return 11; } }
		public override int BaseEnergyResistance{ get{ return 9; } }
		
		public override int InitMinHits{ get{ return 175; } }
		public override int InitMaxHits{ get{ return 175; } }

		[Constructable]
		public BlackKnightsArmsLuck()
		{
			Weight = 1.0; 
            		Name = "<BASEFONT COLOR=#FD8801>Black Knight's Arms";  
            		Hue = 1175;


			ArmorAttributes.LowerStatReq = 5;
			Attributes.BonusStr = 5;
			Attributes.WeaponDamage = 5;
					Attributes.Luck = 100;

			LootType = LootType.Regular;

		}

		public BlackKnightsArmsLuck( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#FD8801>Phase 4<BR><BASEFONT COLOR=#E0FA76>Socket: <BASEFONT COLOR=#9D0BAB>Gem of Luck<BASEFONT COLOR=#68FCAD><br>+100 Luck" );
 } 
	}
}