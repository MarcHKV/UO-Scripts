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
	public class BlackKnightsHelm : PlateHelm
	{
		public override int LabelNumber{ get{ return 1061096; } } // Black Knights Helm
		public override int ArtifactRarity{ get{ return 3; } }

		public override int InitMinHits{ get{ return 75; } }
		public override int InitMaxHits{ get{ return 75; } }

		public override int BasePhysicalResistance{ get{ return 13; } }
		public override int BasePoisonResistance{ get{ return 7; } }
		public override int BaseFireResistance{ get{ return 7; } }
		public override int BaseColdResistance{ get{ return 7; } }
		public override int BaseEnergyResistance{ get{ return 5; } }

		
		[Constructable]
		public BlackKnightsHelm()
		{
			Name = "<BASEFONT COLOR=#0198FD>Black Knight's Helm";
			Hue = 1175;
			Attributes.BonusHits = 3;
			
			ArmorAttributes.LowerStatReq = 5;
			Attributes.ReflectPhysical = 1;
			
		}

		public BlackKnightsHelm( Serial serial ) : base( serial )
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