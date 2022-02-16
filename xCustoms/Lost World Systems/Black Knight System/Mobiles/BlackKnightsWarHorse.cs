//////////////////////////////////////////////////////////
//		Creator: Murrer 		Scripter: Murrer		//
//				Server: Lost World UO					//
//////////////////////////////////////////////////////////
//						Testers							//
//////////////////////////////////////////////////////////
//			  Murrer									//
////////////////////////////////////////////////////////// 

using System;
using System.Collections;
using Server.Mobiles;

namespace Server.Mobiles
{
	[CorpseName( "The corpse of a Black Knight's War Horse" )]
	public class BlackKnightsWarHorse : BaseWarHorse
	{

		[Constructable]
		public BlackKnightsWarHorse() :  base( 0x78, 0x3EAF, AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{
			
			BaseSoundID = 0xA8;

			SetStr( 75, 100 );
			SetDex( 75, 100 );
			SetInt( 75, 100 );

			SetHits( 75, 125 );
			SetMana( 100, 100 );
			SetStam( 100, 100 );

			SetDamage( 2, 5 );

			SetDamageType( ResistanceType.Physical, 50 );
			SetDamageType( ResistanceType.Fire, 50 );
			
			SetResistance( ResistanceType.Physical, 50, 65 );
			SetResistance( ResistanceType.Poison, 50, 65 );
			SetResistance( ResistanceType.Energy, 50, 65 );
			SetResistance( ResistanceType.Cold, 50, 65 );
			SetResistance( ResistanceType.Fire, 50, 65 );
			

			SetSkill( SkillName.MagicResist, 70.0, 90.0 );
			SetSkill( SkillName.Tactics, 78.0, 100.0 );
			SetSkill( SkillName.Wrestling, 80.0, 90.0 );

			Fame = 800;
			Karma = -1500;

			Tamable = true;
			ControlSlots = 3;
			MinTameSkill = 100.0;
			
			Name = "Black Knight's War Horse";
			Hue = 1175;
			
			VirtualArmor = 10;
		}
		public override bool AutoDispel{ get{ return true; } }
		public override bool Unprovokable{ get{ return true; } }
		public override Poison PoisonImmune{ get{ return Poison.Lethal; } }
		// TODO: "This creature can breath chaos.

		public void DrainLife()
		{
			ArrayList list = new ArrayList();

			foreach ( Mobile m in this.GetMobilesInRange( 3 ) )
			{
				if ( m == this || !CanBeHarmful( m ) )
					continue;
				
				if ( m is BaseCreature && (((BaseCreature)m).Controlled || ((BaseCreature)m).Summoned || ((BaseCreature)m).Team != this.Team) )
					list.Add( m );
				if ( m is BaseCreature )
					list.Add( m );
				else if ( m.Player )
					list.Add( m );
				
			}

			foreach ( Mobile m in list )
			{
				DoHarmful( m );

				m.FixedParticles( 0x374A, 10, 15, 5013, 0x496, 0, EffectLayer.Waist );
				m.PlaySound( 0x231 );

				m.SendMessage( "The Black Knight's War Horse sucks out your life force!" );

				int toDrain = Utility.RandomMinMax( 10, 15 );

				Hits += toDrain;
				m.Damage( toDrain, this );
			}
		}

		public override void OnGaveMeleeAttack( Mobile defender )
		{
			base.OnGaveMeleeAttack( defender );

			if ( 0.13 >= Utility.RandomDouble() )
				DrainLife();
		}

		public override void OnGotMeleeAttack( Mobile attacker )
		{
			base.OnGotMeleeAttack( attacker );

			if ( 0.13 >= Utility.RandomDouble() )
				DrainLife();
		}

		public BlackKnightsWarHorse( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 );
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			int version = reader.ReadInt();
		}
	}
}