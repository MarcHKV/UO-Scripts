using System;
using System.Collections.Generic;
using Server.Items;
using Server.Mobiles;

namespace Server.Engines.BulkOrders
{
    [TypeAlias("Scripts.Engines.BulkOrders.SmallBOD")]
    public abstract class SmallBOD : Item, IBOD
    {
        public abstract BODType BODType { get; }

        private int m_AmountCur, m_AmountMax;
        private Type m_Type;
        private int m_Number;
        private int m_Graphic;
        private int m_GraphicHue;
        private bool m_RequireExceptional;
        private BulkMaterialType m_Material;

        [Constructable]
        public SmallBOD(int hue, int amountMax, Type type, int number, int graphic, bool requireExeptional, BulkMaterialType material, int graphichue = 0)
            : base(Core.AOS ? 0x2258 : 0x14EF)
        {
            Weight = 1.0;
            Hue = hue; // Blacksmith: 0x44E; Tailoring: 0x483
            LootType = LootType.Blessed;

            m_AmountMax = amountMax;
            m_Type = type;
            m_Number = number;
            m_Graphic = graphic;
            m_GraphicHue = graphichue;
            m_RequireExceptional = requireExeptional;
            m_Material = material;
        }

        public SmallBOD()
            : base(Core.AOS ? 0x2258 : 0x14EF)
        {
            Weight = 1.0;
            LootType = LootType.Blessed;
        }

        public SmallBOD(Serial serial)
            : base(serial)
        {
        }

        [CommandProperty(AccessLevel.GameMaster)]
        public int AmountCur
        {
            get
            {
                return m_AmountCur;
            }
            set
            {
                m_AmountCur = value;
                InvalidateProperties();
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public int AmountMax
        {
            get
            {
                return m_AmountMax;
            }
            set
            {
                m_AmountMax = value;
                InvalidateProperties();
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public virtual Type Type
        {
            get
            {
                return m_Type;
            }
            set
            {
                m_Type = value;
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public int Number
        {
            get
            {
                return m_Number;
            }
            set
            {
                m_Number = value;
                InvalidateProperties();
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public int Graphic
        {
            get
            {
                return m_Graphic;
            }
            set
            {
                m_Graphic = value;
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public int GraphicHue
        {
            get
            {
                return m_GraphicHue;
            }
            set
            {
                m_GraphicHue = value;
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public bool RequireExceptional
        {
            get
            {
                return m_RequireExceptional;
            }
            set
            {
                m_RequireExceptional = value;
                InvalidateProperties();
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public BulkMaterialType Material
        {
            get
            {
                return m_Material;
            }
            set
            {
                m_Material = value;
                InvalidateProperties();
            }
        }
        [CommandProperty(AccessLevel.GameMaster)]
        public bool Complete
        {
            get
            {
                return (m_AmountCur == m_AmountMax);
            }
        }
        public override int LabelNumber
        {
            get
            {
                return 1045151;
            }
        }// a bulk order deed
        public static BulkMaterialType GetRandomMaterial(BulkMaterialType start, double[] chances)
        {
            double random = Utility.RandomDouble();

            for (int i = 0; i < chances.Length; ++i)
            {
                if (random < chances[i])
                    return (i == 0 ? BulkMaterialType.None : start + (i - 1));

                random -= chances[i];
            }

            return BulkMaterialType.None;
        }

        public static BulkMaterialType GetMaterial(CraftResource resource)
        {
            switch ( resource )
            {
                case CraftResource.DullCopper:
                    return BulkMaterialType.DullCopper;
                case CraftResource.ShadowIron:
                    return BulkMaterialType.ShadowIron;
                case CraftResource.Copper:
                    return BulkMaterialType.Copper;
                case CraftResource.Bronze:
                    return BulkMaterialType.Bronze;
                case CraftResource.Gold:
                    return BulkMaterialType.Gold;
                case CraftResource.Agapite:
                    return BulkMaterialType.Agapite;
                case CraftResource.Verite:
                    return BulkMaterialType.Verite;
                case CraftResource.Valorite:
                    return BulkMaterialType.Valorite;
                //daat99 - OWLTR Start - Custom Ore
                case CraftResource.Blaze:
                    return BulkMaterialType.Blaze;
                case CraftResource.Ice:
                    return BulkMaterialType.Ice;
                case CraftResource.Toxic:
                    return BulkMaterialType.Toxic;
                case CraftResource.Electrum:
                    return BulkMaterialType.Electrum;
                case CraftResource.Platinum:
                    return BulkMaterialType.Platinum;
                //daat99 - OWLTR End - Custom Ore
                case CraftResource.SpinedLeather:
                    return BulkMaterialType.Spined;
                case CraftResource.HornedLeather:
                    return BulkMaterialType.Horned;
                case CraftResource.BarbedLeather:
                    return BulkMaterialType.Barbed;
                //daat99 - OWLTR Start - Custom Leather
                case CraftResource.PolarLeather:
                    return BulkMaterialType.Polar;
                case CraftResource.SyntheticLeather:
                    return BulkMaterialType.Synthetic;
                case CraftResource.BlazeLeather:
                    return BulkMaterialType.BlazeL;
                case CraftResource.DaemonicLeather:
                    return BulkMaterialType.Daemonic;
                case CraftResource.ShadowLeather:
                    return BulkMaterialType.Shadow;
                case CraftResource.FrostLeather:
                    return BulkMaterialType.Frost;
                case CraftResource.EtherealLeather:
                    return BulkMaterialType.Ethereal;
                //daat99 - OWLTR End - Custom Leather
                case CraftResource.OakWood:
                    return BulkMaterialType.OakWood;
                case CraftResource.YewWood:
                    return BulkMaterialType.YewWood;
                case CraftResource.AshWood:
                    return BulkMaterialType.AshWood;
                case CraftResource.Heartwood:
                    return BulkMaterialType.Heartwood;
                case CraftResource.Bloodwood:
                    return BulkMaterialType.Bloodwood;
                case CraftResource.Frostwood:
                    return BulkMaterialType.Frostwood;
                //daat99 - OWLTR Start - Custom Wood
                case CraftResource.Ebony:
                    return BulkMaterialType.Ebony;
                case CraftResource.Bamboo:
                    return BulkMaterialType.Bamboo;
                case CraftResource.PurpleHeart:
                    return BulkMaterialType.Purpleheart;
                //daat99 - OWLTR End - Custom Wood
            }

            return BulkMaterialType.None;
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            list.Add(1060654); // small bulk order

            if (m_RequireExceptional)
                list.Add(1045141); // All items must be exceptional.

            //daat99 - OWLTR Start - Custom Resource
            if (m_Material != BulkMaterialType.None)
                list.Add("All items must be crafted with " + LargeBODGump.GetMaterialStringFor(Material));
                //list.Add(SmallBODGump.GetMaterialNumberFor(m_Material)); // All items must be made with x material.
            //daat99 - OWLTR End - Custom Resource

            list.Add(1060656, m_AmountMax.ToString()); // amount to make: ~1_val~
            list.Add(1060658, "#{0}\t{1}", m_Number, m_AmountCur); // ~1_val~: ~2_val~
        }

        public override void OnDoubleClick(Mobile from)
        {
            if (IsChildOf(from.Backpack) || InSecureTrade || RootParent is PlayerVendor)
			{
				EventSink.InvokeBODUsed(new BODUsedEventArgs(from, this));
				from.SendGump(new SmallBODGump(from, this));
			}
            else
			{
				from.SendLocalizedMessage(1045156); // You must have the deed in your backpack to use it.
			}
		}

        public override void OnDoubleClickNotAccessible(Mobile from)
        {
            OnDoubleClick(from);
        }

        public override void OnDoubleClickSecureTrade(Mobile from)
        {
            OnDoubleClick(from);
        }

        public void BeginCombine(Mobile from)
        {
            if (m_AmountCur < m_AmountMax)
                from.Target = new SmallBODTarget(this);
            else
                from.SendLocalizedMessage(1045166); // The maximum amount of requested items have already been combined to this deed.
        }

        public abstract List<Item> ComputeRewards(bool full);

        public abstract int ComputeGold();

        public abstract int ComputeFame();

        public virtual void GetRewards(out Item reward, out int gold, out int fame)
        {
            reward = null;
            gold = ComputeGold();
            fame = ComputeFame();

            if (!BulkOrderSystem.NewSystemEnabled)
            {
                List<Item> rewards = ComputeRewards(false);

                if (rewards.Count > 0)
                {
                    reward = rewards[Utility.Random(rewards.Count)];

                    for (int i = 0; i < rewards.Count; ++i)
                    {
                        if (rewards[i] != reward)
                            rewards[i].Delete();
                    }
                }
            }
        }

        public virtual bool CheckType(Item item)
        {
            return CheckType(item.GetType());
        }

        public virtual bool CheckType(Type itemType)
        {
            return m_Type != null && (itemType == m_Type || itemType.IsSubclassOf(m_Type));
        }

        public void EndCombine(Mobile from, object o)
        {
            if (o is Item && ((Item)o).IsChildOf(from.Backpack))
            {
                Type objectType = o.GetType();
                Item item = o as Item;

                if (m_AmountCur >= m_AmountMax)
                {
                    from.SendLocalizedMessage(1045166); // The maximum amount of requested items have already been combined to this deed.
                }
                else if (!CheckType((Item)o))
                {
                    from.SendLocalizedMessage(1045169); // The item is not in the request.
                }
                else
                {
                    BulkMaterialType material = BulkMaterialType.None;

                    if (o is IResource)
                        material = GetMaterial(((IResource)o).Resource);

                    if (material != m_Material && m_Material != BulkMaterialType.None)
                    {
                        from.SendLocalizedMessage(1157310); // The item is not made from the requested resource.
                    }
                    else
                    {
                        bool isExceptional = false;

                        if (o is IQuality)
                            isExceptional = (((IQuality)o).Quality == ItemQuality.Exceptional);

                        if (m_RequireExceptional && !isExceptional)
                        {
                            from.SendLocalizedMessage(1045167); // The item must be exceptional.
                        }
                        else
                        {
                            if (item.Amount > 1)
                            {
                                if (AmountCur + item.Amount > AmountMax)
                                {
                                    from.SendLocalizedMessage(1157222); // You have provided more than which has been requested by this deed.
                                    return;
                                }
                                else
                                {
                                    AmountCur += item.Amount;
                                    item.Delete();
                                }
                            }
                            else
                            {
                                item.Delete();
                                ++AmountCur;
                            }

                            from.SendLocalizedMessage(1045170); // The item has been combined with the deed.

                            from.SendGump(new SmallBODGump(from, this));

                            if (m_AmountCur < m_AmountMax)
                                BeginCombine(from);
                        }
                    }
                }
            }
            else
            {
                from.SendLocalizedMessage(1045158); // You must have the item in your backpack to target it.
            }
        }

        public static double GetRequiredSkill(BulkMaterialType type)
        {
            double skillReq = 0.0;

            switch (type)
            {
                case BulkMaterialType.DullCopper:
                    skillReq = 65.0;
                    break;
                case BulkMaterialType.ShadowIron:
                    skillReq = 70.0;
                    break;
                case BulkMaterialType.Copper:
                    skillReq = 75.0;
                    break;
                case BulkMaterialType.Bronze:
                    skillReq = 80.0;
                    break;
                case BulkMaterialType.Gold:
                    skillReq = 85.0;
                    break;
                case BulkMaterialType.Agapite:
                    skillReq = 90.0;
                    break;
                case BulkMaterialType.Verite:
                    skillReq = 95.0;
                    break;
                case BulkMaterialType.Valorite:
                    skillReq = 100.0;
                    break;
                //daat99 - OWLTR Start - Custom Ore
                case BulkMaterialType.Blaze:
                    skillReq = 105.0;
                    break;
                case BulkMaterialType.Ice:
                    skillReq = 110.0;
                    break;
                case BulkMaterialType.Toxic:
                    skillReq = 115.0;
                    break;
                case BulkMaterialType.Electrum:
                    skillReq = 120.0;
                    break;
                case BulkMaterialType.Platinum:
                    skillReq = 120.0;
                    break;
                //daat99 - OWLTR End - Custom Ore
                case BulkMaterialType.Spined:
                    skillReq = 65.0;
                    break;
                case BulkMaterialType.Horned:
                    skillReq = 80.0;
                    break;
                case BulkMaterialType.Barbed:
                    skillReq = 99.0;
                    break;
                //daat99 - OWLTR Start - Custom Leather
                case BulkMaterialType.Polar:
                    skillReq = 100.0;
                    break;
                case BulkMaterialType.Synthetic:
                    skillReq = 105.0;
                    break;
                case BulkMaterialType.BlazeL:
                case BulkMaterialType.Daemonic:
                case BulkMaterialType.Shadow:
                    skillReq = 110.0;
                    break;
                case BulkMaterialType.Frost:
                    skillReq = 115.0;
                    break;
                case BulkMaterialType.Ethereal:
                    skillReq = 120.0;
                    break;
                //daat99 - OWLTR End - Custom Leather
                case BulkMaterialType.OakWood:
                    skillReq = 65.0;
                    break;
                case BulkMaterialType.AshWood:
                    skillReq = 75.0;
                    break;
                case BulkMaterialType.YewWood:
                    skillReq = 85.0;
                    break;
                case BulkMaterialType.Heartwood:
                case BulkMaterialType.Bloodwood:
                case BulkMaterialType.Frostwood:
                    skillReq = 95.0;
                    break;
                //daat99 - OWLTR Start - Custom Wood
                case BulkMaterialType.Ebony:
                    skillReq = 100.0;
                    break;
                case BulkMaterialType.Bamboo:
                    skillReq = 105.0;
                    break;
                case BulkMaterialType.Purpleheart:
                    skillReq = 110.0;
                    break;
                case BulkMaterialType.Redwood:
                    skillReq = 115.0;
                    break;
                case BulkMaterialType.Petrified:
                    skillReq = 120.0;
                    break;
                //daat99 - OWLTR End - Custom Wood
            }

            return skillReq;
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)1); // version

            writer.Write(m_GraphicHue);

            writer.Write(m_AmountCur);
            writer.Write(m_AmountMax);
            writer.Write(m_Type == null ? null : m_Type.FullName);
            writer.Write(m_Number);
            writer.Write(m_Graphic);
            writer.Write(m_RequireExceptional);
            writer.Write((int)m_Material);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();

            switch ( version )
            {
                case 1:
                    {
                        m_GraphicHue = reader.ReadInt();
                        goto case 0;
                    }
                case 0:
                    {
                        m_AmountCur = reader.ReadInt();
                        m_AmountMax = reader.ReadInt();

                        string type = reader.ReadString();

                        if (type != null)
                            m_Type = ScriptCompiler.FindTypeByFullName(type);

                        m_Number = reader.ReadInt();
                        m_Graphic = reader.ReadInt();
                        m_RequireExceptional = reader.ReadBool();
                        m_Material = (BulkMaterialType)reader.ReadInt();

                        break;
                    }
            }

            if (Weight == 0.0)
                Weight = 1.0;

            if (Core.AOS && ItemID == 0x14EF)
                ItemID = 0x2258;

            if (Parent == null && Map == Map.Internal && Location == Point3D.Zero)
                Delete();
        }
    }
}
