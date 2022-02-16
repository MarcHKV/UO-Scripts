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
	public class BlackKnightsGlovesDex : PlateGloves
	{
		public override int LabelNumber{ get{ return 1060206; } } // Black Knights Gloves
		public override int ArtifactRarity{ get{ return 6; } }

		public override int BasePhysicalResistance{ get{ return 17; } }
		public override int BasePoisonResistance{ get{ return 11; } }
		public override int BaseFireResistance{ get{ return 11; } }
		public override int BaseColdResistance{ get{ return 11; } }
		public override int BaseEnergyResistance{ get{ return 9; } }
		
		public override int InitMinHits{ get{ return 175; } }
		public override int InitMaxHits{ get{ return 175; } }

		[Constructable]
		public BlackKnightsGlovesDex()
		{
			LootType = LootType.Regular;
			Name = "<BASEFONT COLOR=#FD8801>Black Knight's Gloves";
			Hue = 1175;
			ArmorAttributes.LowerStatReq = 5;
			Attributes.WeaponSpeed = 5;
			Attributes.AttackChance = 5;
			Attributes.BonusHits = 5;
						Attributes.ReflectPhysical = 2;
	
			Attributes.DefendChance = 3;
						Attributes.BonusStr = 1;
			
		}

		public BlackKnightsGlovesDex( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#FD8801>Phase 4<BR><BASEFONT COLOR=#E0FA76>Socket: <BASEFONT COLOR=#31C41A>Gem of Dexterity<BASEFONT COLOR=#68FCAD><br>+2% Reflect Physical Damage<br>+3% Defend Chance" );
 } 
	}
}