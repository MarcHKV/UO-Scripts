//Add STR to an item
using System;
using Server.Network;
using Server.Prompts;
using Server.Items;
using Server.Targeting;
using Server;
using Server.Engines.XmlSpawner2;

namespace Server.Items
{
	public class STRIncreaseTarget : Target
	{			
		private STREnchantScroll m_Deed;

		public STRIncreaseTarget( STREnchantScroll deed ) : base( 1, false, TargetFlags.None )
		{
			m_Deed = deed;
		}
		
		protected override void OnTarget( Mobile from, object target )
		{
			int STRAdd = 5; //Amount of STR to be added
			int STRCap = 5; //Limit of STR that an item can have
			
			//Change to false if you don't want it to be used on any of these items
			bool allowWeapon = true;
			bool allowArmor = true;
			bool allowJewel = true;
			bool allowClothing = true;
			bool allowSpellbook = true;
			bool allowTalisman = true;
			bool allowQuiver = true;
			//
			double random = 0.5;
            if (from.Luck >= 1100)
            random = 0.1;
            else if(from.Luck >= 1000)
            random = 0.2;
            else if(from.Luck >= 500)
            random = 0.3;
            else if(from.Luck >= 250)
            random = 0.4;
			//
			if ( target is BaseWeapon && allowWeapon)
			{
				Item item = (Item)target;

				GenericEnchanted enchanted = (GenericEnchanted)XmlAttach.FindAttachment(item, typeof(GenericEnchanted));
                if ( enchanted != null )
                {
                from.SendMessage( "This item is already enchanted." );
                return;
                }
                if (random < Utility.RandomDouble())
                {
                item.Delete();
                from.SendMessage( "Your item has been destroyed." );
                }
					if( item.RootParent != from )
					{
						from.SendMessage( "Item must be on your backpack to be enchanted!" ); 
					}
					else
					{
						STRAdd = STRToAdd(((BaseWeapon)item).Attributes.BonusStr, STRAdd, STRCap, from);
						if( STRAdd > 0 )
						{
							from.PlaySound(0x5B4);
							((BaseWeapon)item).Attributes.BonusStr += STRAdd;
							XmlAttach.AttachTo(item, new GenericEnchanted());
							m_Deed.Delete();
						}
					}
					return;
			}
			else if ( target is BaseArmor && allowArmor )
			{
					Item item = (Item)target;
				GenericEnchanted enchanted = (GenericEnchanted)XmlAttach.FindAttachment(item, typeof(GenericEnchanted));
                if ( enchanted != null )
                {
                from.SendMessage( "This item is already enchanted." );
                return;
                }
                if (random < Utility.RandomDouble())
                {
                item.Delete();
                from.SendMessage( "Your item has been destroyed." );
                }
					if( item.RootParent != from )
					{
						from.SendMessage( "Item must be on your backpack to be enchanted!" ); 
					}
					else
					{
						STRAdd = STRToAdd(((BaseArmor)item).Attributes.BonusStr, STRAdd, STRCap, from);
						if( STRAdd > 0 )
						{
							from.PlaySound(0x5B4);
							((BaseArmor)item).Attributes.BonusStr += STRAdd;
							XmlAttach.AttachTo(item, new GenericEnchanted());
							m_Deed.Delete();
						}
					}
				
			}
			else if ( target is BaseClothing && allowClothing )
			{
					Item item = (Item)target;
					GenericEnchanted enchanted = (GenericEnchanted)XmlAttach.FindAttachment(item, typeof(GenericEnchanted));
                if ( enchanted != null )
                {
                from.SendMessage( "This item is already enchanted." );
                return;
                }
                if (random < Utility.RandomDouble())
                {
                item.Delete();
                from.SendMessage( "Your item has been destroyed." );
                }
					if( item.RootParent != from )
					{
						from.SendMessage( "Item must be on your backpack to be enchanted!" ); 
					}
					else
					{
						STRAdd = STRToAdd(((BaseClothing)item).Attributes.BonusStr, STRAdd, STRCap, from);
						if( STRAdd > 0 )
						{
							from.PlaySound(0x5B4);
							((BaseClothing)item).Attributes.BonusStr += STRAdd;
							XmlAttach.AttachTo(item, new GenericEnchanted());
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseTalisman && allowTalisman )
			{
					Item item = (Item)target;
					GenericEnchanted enchanted = (GenericEnchanted)XmlAttach.FindAttachment(item, typeof(GenericEnchanted));
                if ( enchanted != null )
                {
                from.SendMessage( "This item is already enchanted." );
                return;
                }
                if (random < Utility.RandomDouble())
                {
                item.Delete();
                from.SendMessage( "Your item has been destroyed." );
                }
					if( item.RootParent != from )
					{
						from.SendMessage( "Item must be on your backpack to be enchanted!" ); 
					}
					else
					{
						STRAdd = STRToAdd(((BaseTalisman)item).Attributes.BonusStr, STRAdd, STRCap, from);
						if( STRAdd > 0 )
						{
							from.PlaySound(0x5B4);
							((BaseTalisman)item).Attributes.BonusStr += STRAdd;
							XmlAttach.AttachTo(item, new GenericEnchanted());
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseJewel && allowJewel )
			{
					Item item = (Item)target;
					GenericEnchanted enchanted = (GenericEnchanted)XmlAttach.FindAttachment(item, typeof(GenericEnchanted));
                if ( enchanted != null )
                {
                from.SendMessage( "This item is already enchanted." );
                return;
                }
                if (random < Utility.RandomDouble())
                {
                item.Delete();
                from.SendMessage( "Your item has been destroyed." );
                }
					if( item.RootParent != from )
					{
						from.SendMessage( "Item must be on your backpack to be enchanted!" ); 
					}
					else
					{
						STRAdd = STRToAdd(((BaseJewel)item).Attributes.BonusStr, STRAdd, STRCap, from);
						if( STRAdd > 0 )
						{
							from.PlaySound(0x5B4);
							((BaseJewel)item).Attributes.BonusStr += STRAdd;
							XmlAttach.AttachTo(item, new GenericEnchanted());
							m_Deed.Delete();
						}
					}
			}
			else if ( target is Spellbook && allowSpellbook )
			{
					Item item = (Item)target;
					GenericEnchanted enchanted = (GenericEnchanted)XmlAttach.FindAttachment(item, typeof(GenericEnchanted));
                if ( enchanted != null )
                {
                from.SendMessage( "This item is already enchanted." );
                return;
                }
                if (random < Utility.RandomDouble())
                {
                item.Delete();
                from.SendMessage( "Your item has been destroyed." );
                }
					if( item.RootParent != from )
					{
						from.SendMessage( "Item must be on your backpack to be enchanted!" ); 
					}
					else
					{
						STRAdd = STRToAdd(((Spellbook)item).Attributes.BonusStr, STRAdd, STRCap, from);
						if( STRAdd > 0 )
						{
							from.PlaySound(0x5B4);
							((Spellbook)item).Attributes.BonusStr += STRAdd;
							XmlAttach.AttachTo(item, new GenericEnchanted());
							m_Deed.Delete();
						}
					}
			}
			else if ( target is BaseQuiver && allowQuiver )
			{
					Item item = (Item)target;
					GenericEnchanted enchanted = (GenericEnchanted)XmlAttach.FindAttachment(item, typeof(GenericEnchanted));
                if ( enchanted != null )
                {
                from.SendMessage( "This item is already enchanted." );
                return;
                }
                if (random < Utility.RandomDouble())
                {
                item.Delete();
                from.SendMessage( "Your item has been destroyed." );
                }
					if( item.RootParent != from )
					{
						from.SendMessage( "Item must be on your backpack to be enchanted!" ); 
					}
					else
					{
						STRAdd = STRToAdd(((BaseQuiver)item).Attributes.BonusStr, STRAdd, STRCap, from);
						if( STRAdd > 0 )
						{
							from.PlaySound(0x5B4);
							((BaseQuiver)item).Attributes.BonusStr += STRAdd;
							XmlAttach.AttachTo(item, new GenericEnchanted());
							m_Deed.Delete();
						}
					}
			}
			else
			{
				from.SendMessage( "You cannot use this deed on that!" );
			}
		}
		
		public int STRToAdd(int itemSTR, int STRAdd ,int STRCap, Mobile from)
		{
			int ret = 0;
			if(itemSTR < STRCap)
			{
				if( (itemSTR + STRAdd ) > STRCap )
				{
					ret = STRAdd - ( (itemSTR + STRAdd ) - STRCap );
					from.SendMessage("Your item is now enchanted!");
				}
				else{
					from.SendMessage( "Your item is now enchanted!" );
					ret = STRAdd;
				}
			}
			else
			{
				from.SendMessage( "This item is already enchanted." );
			}
			
			return ret;
		}
	}

	public class STREnchantScroll : Item
	{
		[Constructable]
		public STREnchantScroll() : base( 18095 )
		{
			Weight = 1.0;
			Name = "STR enchant scroll";
			//LootType = LootType.Blessed;
			Hue = 1176;
		}
		public override void GetProperties(ObjectPropertyList list)
        {
        base.GetProperties(list);
        list.Add("<BASEFONT COLOR=#1bf702>[+5 STR]\n[Destroy item chance with 0-249 luck: 50%]\n[Destroy item chance with 250 luck: 40%]\n[Destroy item chance with 500 luck: 30%]\n[Destroy item chance with 1000 luck: 20%]\n[Destroy item chance with 1100 luck: 10%]<BASEFONT COLOR=#FFFFFF>");
        }

		public STREnchantScroll( Serial serial ) : base( serial )
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
			LootType = LootType.Blessed;

			int version = reader.ReadInt();
		}

		public override bool DisplayLootType{ get{ return false; } }

		public override void OnDoubleClick( Mobile from )
		{
			if ( !IsChildOf( from.Backpack ) )
			{
				 from.SendLocalizedMessage( 1042001 ); // That must be in your pack for you to use it.
			}
			else
			{
				from.SendMessage("Which item would you like to increase STR?"  );
				from.Target = new STRIncreaseTarget( this );
			}
		}	
	}
}