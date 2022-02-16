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
	public class BlackKnightsShieldMag : MetalKiteShield
	{
		public override int LabelNumber{ get{ return 1061602; } } // Black Knights Shield
		public override int ArtifactRarity{ get{ return 6; } }

		public override int BasePhysicalResistance{ get{ return 6; } }
		public override int BaseFireResistance{ get{ return 6; } }
		public override int BaseColdResistance{ get{ return 6; } }
		public override int BasePoisonResistance{ get{ return 6; } } 
		public override int BaseEnergyResistance{ get{ return 6; } }
		
		public override int InitMinHits{ get{ return 175; } }
		public override int InitMaxHits{ get{ return 175; } }

		[Constructable]
		public BlackKnightsShieldMag()
		{
		    Name = "<BASEFONT COLOR=#FD8801>Black Knight's Shield";
			Hue = 1175;
			
				Attributes.ReflectPhysical = 5;
				Attributes.SpellChanneling = 1;
				Attributes.DefendChance = 10;
				Attributes.Luck = 25;
			
		}

		public BlackKnightsShieldMag( Serial serial ) : base( serial )
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
 list.Add( "<BASEFONT COLOR=#FD8801>Phase 4<BR><BASEFONT COLOR=#E0FA76>Socket: <BASEFONT COLOR=#B40486>Gem of Sorcery<BASEFONT COLOR=#68FCAD><br>Spell Channeling" );
 } 
	}
}