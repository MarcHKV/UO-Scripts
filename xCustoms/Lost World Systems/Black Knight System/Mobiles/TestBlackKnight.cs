//////////////////////////////////////////////////////////
//		Creator: Murrer 		Scripter: Murrer		//
//				Server: Lost World UO					//
//////////////////////////////////////////////////////////
//						Testers							//
//////////////////////////////////////////////////////////
//			  Murrer				Camelin				//				
//			  Rook813									//
////////////////////////////////////////////////////////// 

using System;
using Server;
using Server.Misc;
using Server.Items;

namespace Server.Mobiles 
{ 
	[CorpseName( "A Black Knight's corpse" )] 
	public class TestBlackKnight : BaseCreature 
	{ 
		[Constructable] 
		public TestBlackKnight() : base( AIType.AI_Melee, FightMode.Closest, 10, 1, 0.2, 0.4 )
		{ 
			
			Name = "The Black Knight [Test]";
			Body = 400;
			Hue = 33770;  

			SetStr( 1, 1 );
			SetDex( 1, 1 );
			SetInt( 1, 1 );

			SetHits( 1, 1 );

			SetDamage( 1, 1 );

			//SetDamageType( ResistanceType.Physical, 1 );

			SetResistance( ResistanceType.Physical, 0, 1 );
			SetResistance( ResistanceType.Fire, 0, 1 );
			SetResistance( ResistanceType.Poison, 0, 1 );
			SetResistance( ResistanceType.Energy, 0, 1 );
			SetResistance( ResistanceType.Cold, 0, 1 );

			
			SetSkill( SkillName.Tactics, 51.0, 81.0 );
			SetSkill( SkillName.MagicResist, 31.0, 50.5 );
		
			SetSkill( SkillName.Meditation, 51.0, 81.0 );
			SetSkill( SkillName.Focus, 51.0, 81.0 );
			SetSkill( SkillName.Swords, 97.0, 120.0 );

	switch ( Utility.Random( 20 ))
			{
				case 0: AddItem( new BlackKnightsBracelet() ); break;
				case 1: AddItem( new BlackKnightsRobe() ); break;
				case 2: AddItem( new BlackKnightsSword() ); break;
				case 3: AddItem( new BlackKnightsShield() ); break;
				case 4: AddItem( new BlackKnightsRing() ); break;
				case 5: AddItem( new BlackKnightsEarrings() ); break;
				case 6: AddItem( new BlackKnightsHelm() ); break;
				case 7: AddItem( new BlackKnightsGorget() ); break;
				case 8: AddItem( new BlackKnightsLegs() ); break;
				case 9: AddItem( new BlackKnightsGloves() ); break;
				case 10: AddItem( new BlackKnightsArms() ); break;
				case 11: AddItem( new BlackKnightsBreastplate() ); break;
					
				}
				

			Fame = 250;
			Karma = -25000;
			PackGold( 30, 50 );
			//AddItem( new BlackKnightsSoul());
			VirtualArmor = 1;



			Item hair = new Item( Utility.RandomList( 0x203B, 0x2049, 0x2048, 0x204A ) );
			
				hair.Hue = 1150;
				hair.Layer = Layer.Hair;
				hair.Movable = false;
				AddItem( hair );
            

			

			
			BlackKnightsLegs Legs = new BlackKnightsLegs();
			Legs.Movable = false;
			AddItem(Legs);
			
			BlackKnightsGloves Gloves = new BlackKnightsGloves();
			Gloves.Movable = false;
			AddItem(Gloves);
			
			BlackKnightsGorget Gorget = new BlackKnightsGorget();
			Gorget.Movable = false;
			AddItem(Gorget);
			
			BlackKnightsRingiiii Ring = new BlackKnightsRingiiii();
			Ring.Movable = false;
			AddItem(Ring);
			
	
						BlackKnightsEarringsiiii Earrings = new BlackKnightsEarringsiiii();
			Earrings.Movable = false;
			AddItem(Earrings);
	
						BlackKnightsBraceletiiii Bracelet = new BlackKnightsBraceletiiii();
			Bracelet.Movable = false;
			AddItem(Bracelet);
	
			
			BlackKnightsShieldii Shield = new BlackKnightsShieldii();
			Shield.Movable = false;
			AddItem(Shield);
			
			BlackKnightsSwordiiii Sword = new BlackKnightsSwordiiii();
			Sword.Movable = false;
			AddItem(Sword);				
							
			BlackKnightsRobeiii Robe = new BlackKnightsRobeiii();
			Robe.Movable = false;
   			AddItem(Robe);
   			
			
			
			//mount disappears after riders death
			EtherealHorse EtherealHorse = new EtherealHorse();
        	EtherealHorse.Hue = 1175;
			EtherealHorse.Rider = this; 
			
			//mount stays after riders death
        		//new BlackKnightsWarHorse().Rider = this;

			}

		
		public TestBlackKnight( Serial serial ) : base( serial )
		{
		}
        public override bool AlwaysMurderer{ get{ return true; } }
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
