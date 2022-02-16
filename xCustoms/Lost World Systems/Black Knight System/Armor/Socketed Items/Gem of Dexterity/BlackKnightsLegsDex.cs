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
	public class BlackKnightsLegsDex : PlateLegs
	{
		public override int ArtifactRarity{ get{ return 6; } }

		public override int BasePhysicalResistance{ get{ return 18; } }
		public override int BasePoisonResistance{ get{ return 12; } }
		public override int BaseFireResistance{ get{ return 12; } }
		public override int BaseColdResistance{ get{ return 12; } }
		public override int BaseEnergyResistance{ get{ return 10; } }
		
		public override int InitMinHits{ get{ return 175; } }
		public override int InitMaxHits{ get{ return 175; } }

		[Constructable]
		public BlackKnightsLegsDex()
		{
			Weight = 1.0; 
            		Name = "<BASEFONT COLOR=#FD8801>Black Knight's Legs"; 
            		Hue = 1175;

				Attributes.BonusStr = 5;
			ArmorAttributes.LowerStatReq = 5;
			Attributes.RegenHits = 2;
			Attributes.ReflectPhysical = 7;
			Attributes.DefendChance = 5;
			
			LootType = LootType.Regular;

		}

		public BlackKnightsLegsDex( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#FD8801>Phase 4<BR><BASEFONT COLOR=#E0FA76>Socket: <BASEFONT COLOR=#31C41A>Gem of Dexterity<BASEFONT COLOR=#68FCAD><br>+2% Reflect Physical Damage<br>+3% Defend Chance" );
 } 
	}
}
