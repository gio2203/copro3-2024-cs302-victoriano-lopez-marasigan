using System;
namespace TheShadowKnight
{
    interface ICharacterCreation
    {
        void setInfo(String PN, String PR, String PG, String PHS, String PHC, String PEC, String PST, String PM, String PC, String PE, String PF);
        void setInfo(int strength, int agility, int intelligence, int dexterity, int luck);
        void setInfo(bool moustache, bool beard, bool goatee, bool headband, bool earrings, bool necklace, bool ring);
        void showInfo();
        void showStats();
        void showAdditionals();
    }
}
