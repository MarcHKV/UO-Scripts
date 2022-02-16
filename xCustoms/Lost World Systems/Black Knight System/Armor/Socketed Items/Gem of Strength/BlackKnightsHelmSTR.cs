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
	public class BlackKnightsHelmSTR : PlateHelm
	{
		public override int LabelNumber{ get{ return 1061096; } } // Black Knights Helm
		public override int ArtifactRarity{ get{ return 6; } }

		public override int InitMinHits{ get{ return 175; } }
		public override int InitMaxHits{ get{ return 175; } }

		public override int BasePhysicalResistance{ get{ return 16; } }
		public override int BasePoisonResistance{ get{ return 10; } }
		public override int BaseFireResistance{ get{ return 10; } }
		public override int BaseColdResistance{ get{ return 10; } }
		public override int BaseEnergyResistance{ get{ return 8; } }
		
		[Constructable]
		public BlackKnightsHelmSTR()
		{
			Name = "<BASEFONT COLOR=#FD8801>Black Knight's Helm";
			Hue = 1175;
				Attributes.BonusHits = 5;
			Attributes.BonusStr = 3;
			
			ArmorAttributes.LowerStatReq = 5;
			Attributes.ReflectPhysical = 9;
			
		}

		public BlackKnightsHelmSTR( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#FD8801>Phase 4<BR><BASEFONT COLOR=#E0FA76>Socket: <BASEFONT COLOR=#FB0A0E>Gem of Strength<BASEFONT COLOR=#68FCAD><br>+5% Physical Reflect" );
 } 
	}
}