using System;
using Server;
using Server.Engines.Craft;

namespace Server.Items
{
	[Anvil, Flipable( 0xFAF, 0xFB0 )]
	public class ColoredAnvil : Item
	{
		[Constructable]
		//daat99 OWLTR start - custom resource
		public ColoredAnvil() : this( CraftResources.GetHue( (CraftResource)Utility.RandomMinMax( (int)CraftResource.DullCopper, (int)CraftResource.Platinum ) ) )
		//daat99 OWLTR end - custom resource
		{
		}

		[Constructable]
		public ColoredAnvil( int hue ) : base( 0xFAF )
		{
			Hue = hue;
			Weight = 20;
		}

		public ColoredAnvil( Serial serial ) : base( serial )
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
	}
}