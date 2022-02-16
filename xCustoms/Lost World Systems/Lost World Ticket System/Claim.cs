///daat99 [claim v0.4 tested on runuo 1.0.0
///Basically a player type [claim and click on a corpse that he have looting rights on (he or his pet\summon killed).
///It make sounds when you get gold and when you click at the wrong thing.
///Players can claim human corpses but not player corpses ;)
//////////////////////////////////////////////////////////
//		     Converted to RunUO 2.2 by: Murrer	    	//
//		Tested by: Murrer 		Server: Lost World UO	//
//////////////////////////////////////////////////////////
using System; 
using System.Collections; 
using Server.Items; 
using Server.Targeting; 
using Server.Mobiles; 
using Server.Misc;
using Server.Factions;
using Server.Commands;

namespace Server.Scripts.Commands 
{ 
	public class ClaimCmd 
	{ 
		public static void Initialize() 
		{ 
			CommandHandlers.Register( "Claim", AccessLevel.Player, new CommandEventHandler( Claim_OnCommand ) ); 
		}    
      
		[Usage( "Claim" )] 
		[Description( "Claim a corpse for a Lost World ticket" )] 

		public static void Claim_OnCommand( CommandEventArgs e ) 
		{ 
			e.Mobile.Target = new ClaimCmdTarget(); 
			e.Mobile.SendMessage( "Which corpse do you want to claim for your Lost World ticket" ); 
		}    

		public static void Reclaim( Mobile from ) 
		{ 
			from.Target = new ClaimCmdTarget(); 
			from.SendMessage( "" ); 
		}    

		private class ClaimCmdTarget : Target 
		{ 
			public ClaimCmdTarget() : base( 15, false, TargetFlags.None ) 
			{ 
			} 

			protected override void OnTarget( Mobile from, object target ) 
			{ 
				if (from.Alive == false)
				{
					from.PlaySound(1069); //hey
					from.SendMessage( "Unable to claim" );
				}
				else if ( target is Corpse ) 
				{ 
					Corpse c = (Corpse)target; 
					if (c.Owner != null)
					{
						int amount = 0;
						if (c.Owner.Fame < 0)
							amount = (amount - c.Owner.Fame);
						else
							amount = (amount + c.Owner.Fame);
						if (c.Owner.Karma < 0)
							amount = (amount - c.Owner.Karma);
						else
							amount = (amount + c.Owner.Karma);
						amount = (amount/100);
						if (amount < 10)
							amount = 10;
						if ( c.Owner is PlayerMobile )
						{
							switch ( Utility.Random( 2 ))
							{
								case 0:
								{
									from.PlaySound(1088); //scream
									from.SendMessage( "You can't claim player corpses" ); 
									break;
								}
								case 1:
								{
									from.PlaySound(1086); //oops
									from.SendMessage( "Unable to claim" ); 
									break;
								}
							}
						}
						else if (amount == 10)
						{
							from.SendMessage( "You have been rewarded with a Lost World ticket" ); 
							from.PlaySound(0x2E6); // drop gold sound
							from.AddToBackpack ( new LostWorldTicket(1) );
							((Corpse)c).Delete();
							Reclaim(from);
						}
						else if ( NotorietyHandlers.CorpseNotoriety( from, c ) != Notoriety.Innocent )
						{
							from.SendMessage( "You have been rewarded with a Lost World ticket" ); 
							from.PlaySound(0x2E6); // drop gold sound
							from.AddToBackpack ( new LostWorldTicket(1) );
							((Corpse)c).Delete();
							Reclaim(from);
						}
						else 
						{
							switch ( Utility.Random( 2 ))
							{
								case 0:
								{
									from.PlaySound(1074); //no
									from.SendMessage( " This is not your kill " );
									break;
								}
								case 1:
								{
									from.PlaySound(1069); //hey
									from.SendMessage( "This is not your kill" );
									break;
								}
							}
						}
					} 
				}
				else 
				{ 
					switch ( Utility.Random( 2 ))
					{
						case 0:
						{
							from.PlaySound(1073); //lought
							from.SendMessage( "Unable to claim" ); 
							break;
						}
						case 1:
						{
							from.PlaySound(1066); //giggle
							from.SendMessage( "Unable to claim" ); 
							break;
						}
					}
				} 
			} 
		} 
	} 
}
