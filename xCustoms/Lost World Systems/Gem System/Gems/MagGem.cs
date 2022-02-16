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
	public class MagGem : Item
	{
		public override double DefaultWeight
		{
			get { return 0.1; }
		}

		[Constructable]
		public MagGem() : this( 1 )
		{
			Name = "<BASEFONT COLOR=#B40486>Gem of Sorcery";
			ItemID = 7955;
			Hue = 2642;
		}

		[Constructable]
		public MagGem( int amount ) : base( 0xF25 )
		{
			Stackable = false;
			Amount = amount;
		}

		public MagGem( Serial serial ) : base( serial )
		{
		}

		

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
			}
public override void GetProperties( ObjectPropertyList list )
 {
 base.GetProperties( list );
 list.Add( "<BASEFONT COLOR=#E0FA76>Jewels: +5% Lower Mana Cost/+5% Spell Damage<BR>Clothing: +1 Cast Speed/+1 Cast Recorvery<BR>Armor: +5% Lower reagent cost<BR>Shield: Adds Spellchanneling<BR>Weapon: Adds Spellchanneling" );
 } 
	}
}