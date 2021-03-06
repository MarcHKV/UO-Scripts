using System;
using Server.Network;

namespace Server.Items
{
    public class BootsOfBallast : Boots
    {
        public override int LabelNumber { get { return 1154242; } } // Boots of Ballast
        public override bool CanBeWornByGargoyles { get { return true; } }

        [Constructable]
        public BootsOfBallast()
            : base()
        {
            this.Hue = 2969;
            this.LootType = LootType.Blessed;
            this.StrRequirement = 10;
        }
		
		public override void OnDoubleClick(Mobile from)
        {
			base.OnDoubleClick(from);			
			
			from.PublicOverheadMessage(MessageType.Regular, 0x3B2, 1154243); // *You struggle to lift the heavy boots for examination! You determine anyone venturing into the sea wearing such a thing would quickly sink to the bottom*
        }
		
		public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            list.Add(1072351); // Quest Item
        }

        public BootsOfBallast(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}