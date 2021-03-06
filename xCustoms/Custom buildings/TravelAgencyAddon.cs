
////////////////////////////////////////
//                                     //
//   Generated by CEO's YAAAG - Ver 2  //
// (Yet Another Arya Addon Generator)  //
//    Modified by Hammerhand for       //
//      SA & High Seas content         //
//                                     //
////////////////////////////////////////
using System;
using Server;
using Server.Items;

namespace Server.Items
{
	public class TravelAgencyAddon : BaseAddon
	{
        private static int[,] m_AddOnSimpleComponents = new int[,] {
			  {4167, 4, 2, 19}, {4167, -1, 1, 12}, {4167, -3, 2, 19}// 1	2	3	
			, {4167, 4, 2, 19}, {4555, 0, -1, 10}, {5356, 1, 1, 10}// 4	5	6	
			, {321, 4, 2, 18}, {1224, 3, 1, 1}, {9963, -2, 2, 19}// 8	9	10	
			, {9963, -1, 2, 19}, {9963, 0, 2, 19}, {9963, 1, 2, 19}// 11	12	13	
			, {9963, 2, 2, 19}, {9963, 3, 2, 19}, {9963, 4, 2, 19}// 14	15	16	
			, {9963, 4, 1, 20}, {9963, 3, 1, 21}, {9963, 2, 1, 20}// 17	18	19	
			, {9963, 1, 1, 20}, {9963, 0, 1, 20}, {9963, -1, 1, 20}// 20	21	22	
			, {9963, -2, 1, 20}, {9963, 4, 0, 20}, {9963, 3, 0, 20}// 23	24	25	
			, {9963, 2, 0, 20}, {9963, 1, 0, 20}, {9963, 0, 0, 20}// 26	27	28	
			, {9963, -1, 0, 20}, {9963, -2, 0, 20}, {9962, 4, -1, 17}// 29	30	31	
			, {9962, 3, -1, 17}, {9962, 2, -1, 17}, {9962, 1, -1, 17}// 32	33	34	
			, {9962, 0, -1, 17}, {9962, -1, -1, 17}, {9962, -2, -1, 17}// 35	36	37	
			, {322, 3, 2, 18}, {322, 2, 2, 18}, {322, 1, 2, 18}// 38	39	40	
			, {322, 0, 2, 18}, {322, -1, 2, 18}, {322, -2, 2, 18}// 41	42	43	
			, {323, -3, 2, 18}, {323, -3, 1, 18}, {323, 4, 1, 18}// 44	45	46	
			, {323, 3, -1, 1}, {323, 3, -1, 1}, {298, -3, 2, 1}// 47	48	49	
			, {298, 4, 2, 1}, {6418, -1, 1, 1}, {6430, 3, 1, 1}// 50	51	52	
			, {6419, 4, 1, 1}, {2880, 0, -1, 1}, {2899, 1, -1, 1}// 53	54	55	
			, {2899, -1, -1, 1}, {17629, 2, -1, 0}, {6430, 2, 1, 1}// 56	57	58	
			, {6430, 1, 1, 1}, {6430, 0, 1, 1}, {2715, 3, -1, 1}// 59	60	61	
			, {2712, -2, -1, 1}, {308, 4, 0, 0}, {308, -3, 0, 0}// 62	63	64	
			, {311, 4, -1, 0}, {307, 4, -2, 0}, {304, 3, -2, 0}// 66	67	68	
			, {302, 2, -2, 0}, {304, 0, -2, 0}, {302, -1, -2, 0}// 69	70	71	
			, {1224, 4, 1, 1}, {1224, 4, 0, 1}, {1224, 4, -1, 1}// 72	73	74	
			, {312, -2, -2, 0}, {311, -3, -1, 0}, {298, -3, -2, 0}// 75	76	77	
			, {1224, 4, 2, 1}, {1224, 3, 2, 1}, {1224, 3, 0, 1}// 78	79	80	
			, {1224, 3, -1, 1}, {1224, 2, 2, 1}, {1224, 2, 1, 1}// 81	82	83	
			, {1224, 2, 0, 1}, {1224, 2, -1, 1}, {1224, 1, 2, 1}// 84	85	86	
			, {1224, 1, 1, 1}, {1224, 1, 0, 1}, {1224, 1, -1, 1}// 87	88	89	
			, {1224, 0, 2, 1}, {1224, 0, 1, 1}, {1224, 0, 0, 1}// 90	91	92	
			, {1224, 0, -1, 1}, {1224, -1, 2, 1}, {1224, -1, 1, 1}// 93	94	95	
			, {1224, -1, 0, 1}, {1224, -1, -1, 1}, {1224, -2, 2, 1}// 96	97	98	
			, {1224, -2, 1, 1}, {1224, -2, 0, 1}, {1224, -2, -1, 1}// 99	100	101	
					};

 
            
		public override BaseAddonDeed Deed
		{
			get
			{
				return new TravelAgencyAddonDeed();
			}
		}

		[ Constructable ]
		public TravelAgencyAddon()
		{

            for (int i = 0; i < m_AddOnSimpleComponents.Length / 4; i++)
                AddComponent( new AddonComponent( m_AddOnSimpleComponents[i,0] ), m_AddOnSimpleComponents[i,1], m_AddOnSimpleComponents[i,2], m_AddOnSimpleComponents[i,3] );


			AddComplexComponent( (BaseAddon) this, 2847, 4, 1, 15, 0, 1, "", 1);// 7
			AddComplexComponent( (BaseAddon) this, 314, 1, -2, 0, 0, 42, "", 1);// 65

		}

		public TravelAgencyAddon( Serial serial ) : base( serial )
		{
		}

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource)
        {
            AddComplexComponent(addon, item, xoffset, yoffset, zoffset, hue, lightsource, null, 1);
        }

        private static void AddComplexComponent(BaseAddon addon, int item, int xoffset, int yoffset, int zoffset, int hue, int lightsource, string name, int amount)
        {
            AddonComponent ac;
            ac = new AddonComponent(item);
            if (name != null && name.Length > 0)
                ac.Name = name;
            if (hue != 0)
                ac.Hue = hue;
            if (amount > 1)
            {
                ac.Stackable = true;
                ac.Amount = amount;
            }
            if (lightsource != -1)
                ac.Light = (LightType) lightsource;
            addon.AddComponent(ac, xoffset, yoffset, zoffset);
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}

	public class TravelAgencyAddonDeed : BaseAddonDeed
	{
		public override BaseAddon Addon
		{
			get
			{
				return new TravelAgencyAddon();
			}
		}

		[Constructable]
		public TravelAgencyAddonDeed()
		{
			Name = "TravelAgency";
		}

		public TravelAgencyAddonDeed( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( 0 ); // Version
		}

		public override void	Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}