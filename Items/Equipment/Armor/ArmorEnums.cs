using System;

namespace Server.Items
{
    public enum ArmorDurabilityLevel
    {
        Regular,
        Durable,
        Substantial,
        Massive,
        Fortified,
        Indestructible
    }

    public enum ArmorProtectionLevel
    {
        Regular,
        Defense,
        Guarding,
        Hardening,
        Fortification,
        Invulnerability,
    }

    public enum ArmorBodyType
    {
        Gorget,
        Gloves,
        Helmet,
        Arms,
        Legs, 
        Chest,
        Shield
    }

    public enum ArmorMaterialType
    {
        Cloth,
        Leather,
        Studded,
        Bone,
        Spined,
        Horned,
        Barbed,
		//Daat99 OWLTR Start
        Polar,
        Synthetic,
        BlazeL,
        Daemonic,
        Shadow,
        Frost,
        Ethereal,
        //Daat99 OWLTR End
        Ringmail,
        Chainmail,
        Plate,
        Dragon,
        Wood,
        Stone,
    }

    public enum ArmorMeditationAllowance
    {
        All,
        Half,
        None
    }
}