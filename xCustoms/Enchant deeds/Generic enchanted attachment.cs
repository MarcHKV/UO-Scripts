using System;
using System.Collections;
using System.Collections.Generic;
using Server.Items;
using Server.Mobiles;



namespace Server.Engines.XmlSpawner2
{
    public class GenericEnchanted : XmlAttachment
    {
		
        [Attachable]
        public GenericEnchanted() {}

       public GenericEnchanted(ASerial serial) : base(serial){}

        public override void Serialize(GenericWriter writer) 
		{
            base.Serialize(writer);

            writer.Write((int)0);
		}

        public override void Deserialize(GenericReader reader) 
		{
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
		
		public override void OnAttach()
        {
            base.OnAttach();

            if (this.AttachedTo is Item)
            {
                ((Item)this.AttachedTo).InvalidateProperties();
			}
		}


		public override void AddProperties(ObjectPropertyList list)
        {
			base.AddProperties(list);
			
			 if (AttachedTo is Item)
             {
				list.Add("<BASEFONT COLOR=#F80BF1>[Enchanted]<BASEFONT COLOR=#FFFFFF>");
				//list.Add("<BASEFONT COLOR=#F80BF1>[Total STR bonus:{0}]<BASEFONT COLOR=#FFFFFF>",AttachedTo.Attributes.BonusStr);
				
			}
        }

       
    }
}