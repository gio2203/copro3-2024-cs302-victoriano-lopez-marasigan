using System;
using System.Data.SqlClient;

namespace TheShadowKnight
{
    // abstract class 
    public abstract class BaseCharacter
    {
        // encapsulation with setters and getters
        private String name;
        private String race;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Race
        {
            get { return race; }
            set { race = value; }
        }

        public BaseCharacter(String name, String race)
        {
            this.name = name;
            this.race = race;
        }

        // abstract method
        public abstract void ShowInfo();
        public abstract void ShowStats();
    }

    // Polymorphism
    public class PlayerCharacter : BaseCharacter
    {

        private int strength;
        private int agility;
        private int intelligence;
        private int dexterity;
        private int luck;

        public int Strength
        {
            get { return strength; }
            set { strength = value >= 0 ? value : 0; }
        }

        public int Agility
        {
            get { return agility; }
            set { agility = value >= 0 ? value : 0; }
        }

        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value >= 0 ? value : 0; }
        }
        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value >= 0 ? value : 0; }
        }
        public int Luck
        {
            get { return luck; }
            set { luck = value >= 0 ? value : 0; }
        }

        public PlayerCharacter(String name, String race, int str, int agi, int intel, int dex, int luck) : base(name, race)
        {
            Strength = str;
            Agility = agi;
            Intelligence = intel;
            Dexterity = dex;
            Luck = luck;

        }

        //  method overriding
        public override void ShowInfo()
        {
            Console.WriteLine("Name: " + Name + "Race: " + Race);
        }
        // method overriding
        public override void ShowStats()
        {
            Console.WriteLine("Strength: " + Strength +  " Agility: " + Agility + "Intelligence: " + Intelligence + "Dexterity: " + Dexterity + "Luck: " + Luck);
        }
    }

    // polymorphism
    public class CharacterCreator
    {
        public void CreateCharacter()
        {
            Console.WriteLine("Enter Name: ");
            String name = Console.ReadLine();

            Console.WriteLine("Enter Race: ");
            String race = Console.ReadLine();

            // example stats 
            int strength = 10;
            int agility = 15;
            int intelligence = 8;
            int dexterity = 9;
            int luck = 8;


            // instantiate a player character
            BaseCharacter player = new PlayerCharacter(name, race, strength, agility, intelligence, dexterity, luck);

            // Polymorphic behavior
            Console.WriteLine("\nCharacter Details:");
            player.ShowInfo();
            player.ShowStats();
        }
    }
    // struct and inheritance from interface
    public struct CharInfo : ICharacterCreation
    {
        private String PlayerName, PlayerRace, PlayerGender, PlayerHairStyle, PlayerHairColor, PlayerEyeColor, PlayerSkinTone, PlayerMass, PlayerClass, PlayerElement, PlayerFaction;
        private int Str, Agi, Int, Dex, Luck;
        private bool Moustache, Beard, Goatee, Headband, Earrings,
            Necklace, Ring;
        // method overloading and inheritance of method from the interface
        public void setInfo(String PN, String PR, String PG, String PHS, String PHC, String PEC, String PST, String PM, String PC, String PE, String PF)
        {
            this.PlayerName = PN;
            this.PlayerRace = PR;
            this.PlayerGender = PG;
            this.PlayerHairStyle = PHS;
            this.PlayerHairColor = PHC;
            this.PlayerEyeColor = PEC;
            this.PlayerSkinTone = PST;
            this.PlayerMass = PM;
            this.PlayerClass = PC;
            this.PlayerElement = PE;
            this.PlayerFaction = PF;
        }

        public void showInfo()
        {
            Console.WriteLine("   Character Name: " + this.PlayerName);
            Console.WriteLine("   Character Race: " + this.PlayerRace);
            Console.WriteLine("   Character Gender: " + this.PlayerGender);
            Console.WriteLine("   Character Hair Style: " + this.PlayerHairStyle);
            Console.WriteLine("   Character Hair Color: " + this.PlayerHairColor);
            Console.WriteLine("   Character Eye Color: " + this.PlayerEyeColor);
            Console.WriteLine("   Character Skin Tone: " + this.PlayerSkinTone);
            Console.WriteLine("   Character Mass: " + this.PlayerMass);
            Console.WriteLine("   Character Class: " + this.PlayerClass);
            Console.WriteLine("   Character Element: " + this.PlayerElement);
            Console.WriteLine("   Character Faction: " + this.PlayerFaction);
        }
        // method overloading and inheritance of method from the interface
        public void setInfo(int strength, int agility, int intelligence, int dexterity, int luck)
        {
            this.Str = strength;
            this.Agi = agility;
            this.Int = intelligence;
            this.Dex = dexterity;
            this.Luck = luck;
        }

        public void showStats()
        {
            Console.WriteLine("\nCharacter Stats");
            Console.WriteLine("   Character Strength: " + this.Str);
            Console.WriteLine("   Character Agility: " + this.Agi);
            Console.WriteLine("   Character Intelligence: " + this.Int);
            Console.WriteLine("   Character Dexterity: " + this.Dex);
            Console.WriteLine("   Character Luck: " + this.Luck);
        }
        // method overloading and inheritance of method from the interface
        public void setInfo(bool moustache, bool beard, bool goatee, bool headband, bool earrings, bool necklace, bool ring)
        {
            this.Moustache = moustache;
            this.Beard = beard;
            this.Goatee = goatee;
            this.Headband = headband;
            this.Earrings = earrings;
            this.Necklace = necklace;
            this.Ring = ring;
        }

        public void showAdditionals()
        {
            Console.WriteLine("\nCharacter Additional Features");
            Console.WriteLine("   Character Moustache: " + Moustache);
            Console.WriteLine("   Character Beard: " + Beard);
            Console.WriteLine("   Character Goatee: " + Goatee);
            Console.WriteLine("   Character Headband: " + Headband);
            Console.WriteLine("   Character Earrings: " + Earrings);
            Console.WriteLine("   Character Necklace: " + Necklace);
            Console.WriteLine("   Character Ring: " + Ring);
        }
    }

    public class CharacterCreation
    {
        static String ans, charName, charRace, charGender, hairStyle, hairColor,
        eyeColor, skinTone, charMass, charClass, charElement, charFaction, ans1;
        static int statsInput, maxStatsLimit, charStr, charAgi, charInt, charDex, charLuck, ansint = 0;
        static bool hasMoustache = false, hasBeard = false, hasGoatee = false, hasHeadband = false, hasEarrings = false,
        hasNecklace = false, hasRing = false;
        public static void Character()
        {
            CharInfo Player = new CharInfo();
            SqlConnection connection;
            String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\Users\Admin\Desktop\st\3 1 SEM\Prog 3\TheShadowKnight-master\TheShadowKnight\CharacterDatabase.mdf;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            connection.Open();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                        _____\r\n                        \\   /\r\n                        |   |\r\n           .__.         |   |_____________________________________________\r\n           |  |_________|   |                                              \\\r\n           |  |         |   |________________________________________________\\\r\n _____ _            _____ _               _                 _   __      _       _     _\r\n|_   _| |          /  ___| |             | |               | | / /     (_)     | |   | |\r\n  | | | |__   ___  \\ `--.| |__   __ _  __| | _____      __ | |/ / _ __  _  __ _| |__ | |_\r\n  | | | '_ \\ / _ \\  `--. | '_ \\ / _` |/ _` |/ _ \\ \\ /\\ / / |    \\| '_ \\| |/ _` | '_ \\| __|\r\n  | | | | | |  __/ /\\__/ | | | | (_| | (_| | (_) \\ V  V /  | |\\  | | | | | (_| | | | | |_\r\n  \\_/ |_| |_|\\___| \\____/|_| |_|\\__,_|\\__,_|\\___/ \\_/\\_/   \\_| \\_|_| |_|_|\\__, |_| |_|\\__|\r\n                             _____________________________________________ __/ |\r\n           |  |_________|   |                                             |___/\r\n           |__|         |   |_____________________________________________ /\r\n                        |   |\r\n                        |   |\r\n                        /___\\\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nCREATE A NEW CHARACTER");
            try
            {
                while (true)
                {
                    Console.Write("Enter Character Name [Max of 20 characters]: ");
                    charName = Console.ReadLine();

                    if (charName.Length > 20)
                    {
                        Console.WriteLine("Name exceeds limit of 20 characters! Please try again.");
                        continue;
                    }

                    string normalizedInput = charName.ToLower();

                    try
                    {
                        string query = "SELECT char_name FROM dbo.CHARACTER_INFO WHERE LOWER(char_name) = '" + normalizedInput + "'";
                        SqlCommand checkNameCmd = new SqlCommand(query, connection);
                        SqlDataReader reader = checkNameCmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            string existingName = reader["char_name"].ToString();
                            reader.Close();
                            Console.WriteLine("The name \"" + charName + "\" is already taken. (" + existingName + ")");
                            continue;
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred while checking the name. Please try again.");
                        Console.WriteLine("Error: " + ex.Message);
                        continue;
                    }

                    break;
                }


                while (true)
                {
                    Console.WriteLine("Character Race");
                    Console.WriteLine("[1] Human");
                    Console.WriteLine("[2] Elf");
                    Console.WriteLine("[3] Dwarf");
                    Console.WriteLine("[4] Fairy");
                    Console.WriteLine("[5] Beastman");
                    Console.Write("Enter option: ");
                    ans = Console.ReadLine();

                    if (ans.Equals("1"))
                    {
                        charRace = "Human";
                        break;
                    }
                    else if (ans.Equals("2"))
                    {
                        charRace = "Elf";
                        break;
                    }
                    else if (ans.Equals("3"))
                    {
                        charRace = "Dwarf";
                        break;
                    }
                    else if (ans.Equals("4"))
                    {
                        charRace = "Fairy";
                        break;
                    }
                    else if (ans.Equals("5"))
                    {
                        charRace = "Beastman";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Character Gender");
                    Console.WriteLine("[M]ale");
                    Console.WriteLine("[F]emale");
                    Console.Write("Enter option: ");
                    ans = Console.ReadLine();

                    if (ans.ToUpper().Equals("M"))
                    {
                        charGender = "Male";
                        break;
                    }
                    else if (ans.ToUpper().Equals("F"))
                    {
                        charGender = "Female";
                        break;
                    }
                    else
                    {

                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Character Hair Style");
                    Console.WriteLine("[1] Wavy");
                    Console.WriteLine("[2] Spiky");
                    Console.WriteLine("[3] Buzz Cut");
                    Console.WriteLine("[4] Curly");
                    Console.WriteLine("[5] Slicked Back");
                    Console.WriteLine("[6] Fringe");
                    Console.WriteLine("[7] Straight Long");
                    Console.WriteLine("[8] Wavy Long");
                    Console.WriteLine("[9] Braided");
                    Console.WriteLine("[10] Ponytail");
                    Console.WriteLine("[11] Dreadlocks");
                    Console.WriteLine("[12] Fringe Long");
                    Console.Write("Enter option: ");
                    ans = Console.ReadLine();

                    if (ans.Equals("1"))
                    {
                        hairStyle = "Wavy";
                        break;
                    }
                    else if (ans.Equals("2"))
                    {
                        hairStyle = "Spiky";
                        break;
                    }
                    else if (ans.Equals("3"))
                    {
                        hairStyle = "Buzz Cut";
                        break;
                    }
                    else if (ans.Equals("4"))
                    {
                        hairStyle = "Curly";
                        break;
                    }
                    else if (ans.Equals("5"))
                    {
                        hairStyle = "Slicked Back";
                        break;
                    }
                    else if (ans.Equals("6"))
                    {
                        hairStyle = "Fringe";
                        break;
                    }
                    else if (ans.Equals("7"))
                    {
                        hairStyle = "Straight Long";
                        break;
                    }
                    else if (ans.Equals("8"))
                    {
                        hairStyle = "Wavy Long";
                        break;
                    }
                    else if (ans.Equals("9"))
                    {
                        hairStyle = "Braided";
                        break;
                    }
                    else if (ans.Equals("10"))
                    {
                        hairStyle = "Ponytail";
                        break;
                    }
                    else if (ans.Equals("11"))
                    {
                        hairStyle = "Dreadlocks";
                        break;
                    }
                    else if (ans.Equals("12"))
                    {
                        hairStyle = "Fringe Long";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Character Hair Color");
                    Console.WriteLine("[1] Black");
                    Console.WriteLine("[2] Blue");
                    Console.WriteLine("[3] Red");
                    Console.WriteLine("[4] Brown");
                    Console.WriteLine("[5] Gold");
                    Console.WriteLine("[6] Green");
                    Console.WriteLine("[7] Purple");
                    Console.WriteLine("[8] Yellow");
                    Console.WriteLine("[9] Gray");
                    Console.Write("Enter option: ");
                    ans = Console.ReadLine();

                    if (ans.Equals("1"))
                    {
                        hairColor = "Black";
                        break;
                    }
                    else if (ans.Equals("2"))
                    {
                        hairColor = "Blue";
                        break;
                    }
                    else if (ans.Equals("3"))
                    {
                        hairColor = "Red";
                        break;
                    }
                    else if (ans.Equals("4"))
                    {
                        hairColor = "Brown";
                        break;
                    }
                    else if (ans.Equals("5"))
                    {
                        hairColor = "Gold";
                        break;
                    }
                    else if (ans.Equals("6"))
                    {
                        hairColor = "Green";
                        break;
                    }
                    else if (ans.Equals("7"))
                    {
                        hairColor = "Purple";
                        break;
                    }
                    else if (ans.Equals("8"))
                    {
                        hairColor = "Yellow";
                        break;
                    }
                    else if (ans.Equals("9"))
                    {
                        hairColor = "Gray";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Character Eye Color");
                    Console.WriteLine("[1] Black");
                    Console.WriteLine("[2] Blue");
                    Console.WriteLine("[3] Red");
                    Console.WriteLine("[4] Brown");
                    Console.WriteLine("[5] Gold");
                    Console.WriteLine("[6] Green");
                    Console.WriteLine("[7] Purple");
                    Console.WriteLine("[8] Yellow");
                    Console.WriteLine("[9] Gray");
                    Console.Write("Enter option: ");
                    ans = Console.ReadLine();

                    if (ans.Equals("1"))
                    {
                        eyeColor = "Black";
                        break;
                    }
                    else if (ans.Equals("2"))
                    {
                        eyeColor = "Blue";
                        break;
                    }
                    else if (ans.Equals("3"))
                    {
                        eyeColor = "Red";
                        break;
                    }
                    else if (ans.Equals("4"))
                    {
                        eyeColor = "Brown";
                        break;
                    }
                    else if (ans.Equals("5"))
                    {
                        eyeColor = "Gold";
                        break;
                    }
                    else if (ans.Equals("6"))
                    {
                        eyeColor = "Green";
                        break;
                    }
                    else if (ans.Equals("7"))
                    {
                        eyeColor = "Purple";
                        break;
                    }
                    else if (ans.Equals("8"))
                    {
                        eyeColor = "Yellow";
                        break;
                    }
                    else if (ans.Equals("9"))
                    {
                        eyeColor = "Gray";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Character Skin Tone");
                    Console.WriteLine("[1] Light");
                    Console.WriteLine("[2] Fair");
                    Console.WriteLine("[3] Light Brown");
                    Console.WriteLine("[4] Deep Brown");
                    Console.WriteLine("[5] Dark");
                    Console.Write("Enter option: ");
                    ans = Console.ReadLine();

                    if (ans.Equals("1"))
                    {
                        skinTone = "Light";
                        break;
                    }
                    else if (ans.Equals("2"))
                    {
                        skinTone = "Fair";
                        break;
                    }
                    else if (ans.Equals("3"))
                    {
                        skinTone = "Light Brown";
                        break;
                    }
                    else if (ans.Equals("4"))
                    {
                        skinTone = "Deep Brown";
                        break;
                    }
                    else if (ans.Equals("5"))
                    {
                        skinTone = "Dark";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Character Mass");
                    Console.WriteLine("[1] Small");
                    Console.WriteLine("[2] Medium");
                    Console.WriteLine("[3] Normal");
                    Console.WriteLine("[4] Muscular");
                    Console.WriteLine("[5] Bodybuilder");
                    Console.Write("Enter option: ");
                    ans = Console.ReadLine();

                    if (ans.Equals("1"))
                    {
                        charMass = "Small";
                        break;
                    }
                    else if (ans.Equals("2"))
                    {
                        charMass = "Medium";
                        break;
                    }
                    else if (ans.Equals("3"))
                    {
                        charMass = "Normal";
                        break;
                    }
                    else if (ans.Equals("4"))
                    {
                        charMass = "Muscular";
                        break;
                    }
                    else if (ans.Equals("5"))
                    {
                        charMass = "Bodybuilder";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Character Class");
                    Console.WriteLine("[1] Warrior");
                    Console.WriteLine("[2] Archer");
                    Console.WriteLine("[3] Berserker");
                    Console.WriteLine("[4] Mage");
                    Console.WriteLine("[5] Healer");
                    Console.WriteLine("[6] Assassin");
                    Console.WriteLine("[7] Scout");
                    Console.Write("Enter option: ");
                    ans = Console.ReadLine();

                    if (ans.Equals("1"))
                    {
                        charClass = "Warrior";
                        break;
                    }
                    else if (ans.Equals("2"))
                    {
                        charClass = "Archer";
                        break;
                    }
                    else if (ans.Equals("3"))
                    {
                        charClass = "Berserker";
                        break;
                    }
                    else if (ans.Equals("4"))
                    {
                        charClass = "Mage";
                        break;
                    }
                    else if (ans.Equals("5"))
                    {
                        charClass = "Healer";
                        break;
                    }
                    else if (ans.Equals("6"))
                    {
                        charClass = "Assassin";
                        break;
                    }
                    else if (ans.Equals("7"))
                    {
                        charClass = "Scout";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Character Element");
                    Console.WriteLine("[1] Heat");
                    Console.WriteLine("[2] Rain");
                    Console.WriteLine("[3] Earth");
                    Console.WriteLine("[4] Sky");
                    Console.WriteLine("[5] Light");
                    Console.WriteLine("[6] Darkness");
                    Console.Write("Enter option: ");
                    ans = Console.ReadLine();

                    if (ans.Equals("1"))
                    {
                        charElement = "Heat";
                        break;
                    }
                    else if (ans.Equals("2"))
                    {
                        charElement = "Rain";
                        break;
                    }
                    else if (ans.Equals("3"))
                    {
                        charElement = "Earth";
                        break;
                    }
                    else if (ans.Equals("4"))
                    {
                        charElement = "Sky";
                        break;
                    }
                    else if (ans.Equals("5"))
                    {
                        charElement = "Light";
                        break;
                    }
                    else if (ans.Equals("6"))
                    {
                        charElement = "Darkness";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Character Faction");
                    Console.WriteLine("[1] Knights Order");
                    Console.WriteLine("[2] Mercenaries Guild");
                    Console.WriteLine("[3] Merchants Guild");
                    Console.WriteLine("[4] Holy Church");
                    Console.WriteLine("[5] Adventurers Guild");
                    Console.Write("Enter option: ");
                    ans = Console.ReadLine();

                    if (ans.Equals("1"))
                    {
                        charFaction = "Knights Order";
                        break;
                    }
                    else if (ans.Equals("2"))
                    {
                        charFaction = "Mercenaries Guild";
                        break;
                    }
                    else if (ans.Equals("3"))
                    {
                        charFaction = "Merchants Guild";
                        break;
                    }
                    else if (ans.Equals("4"))
                    {
                        charFaction = "Holy Church";
                        break;
                    }
                    else if (ans.Equals("5"))
                    {
                        charFaction = "Adventurers Guild";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }

                Player.setInfo(charName, charRace, charGender, hairStyle, hairColor, eyeColor, skinTone, charMass, charClass, charElement, charFaction);
                maxStatsLimit = 50; 
                charStr = 1;
                charAgi = 1;
                charInt = 1;
                charDex = 1;
                charLuck = 1;
                while (maxStatsLimit > 0)
                {
                    Console.WriteLine("Character Stats");
                    Console.WriteLine("[1]Character Strength: " + charStr);
                    Console.WriteLine("[2]Character Agility: " + charAgi);
                    Console.WriteLine("[3]Character Intelligence: " + charInt);
                    Console.WriteLine("[4]Character Dexterity: " + charDex);
                    Console.WriteLine("[5]Character Luck: " + charLuck);
                    Console.WriteLine("Remaining points to be added in stats: " + maxStatsLimit);
                    Console.WriteLine("Enter option: ");
                    ans = Console.ReadLine();
                    if (ans.Equals("1"))
                    {
                        Console.WriteLine("Add stats to Character Strength: ");
                        statsInput = Convert.ToInt32(Console.ReadLine());

                        if (statsInput <= maxStatsLimit && statsInput >= 1)
                        {
                            charStr += statsInput;
                            maxStatsLimit -= statsInput;
                        }
                        else if (statsInput <= 0)
                        {
                            Console.WriteLine("Negative number detected try again.");
                        }
                        else
                        {
                            Console.WriteLine("Input exceeds remaining points to be added! Please try again.");
                        }
                    }
                    else if (ans.Equals("2"))
                    {
                        Console.WriteLine("Add stats to Character Agility: ");
                        statsInput = Convert.ToInt32(Console.ReadLine());

                        if (statsInput <= maxStatsLimit && statsInput >= 1)
                        {
                            charAgi += statsInput;
                            maxStatsLimit -= statsInput;
                        }
                        else if (statsInput <= 0)
                        {
                            Console.WriteLine("Negative number detected try again.");
                        }
                        else
                        {
                            Console.WriteLine("Input exceeds remaining points to be added! Please try again.");
                        }
                    }
                    else if (ans.Equals("3"))
                    {
                        Console.WriteLine("Add stats to Character Intelligence: ");
                        statsInput = Convert.ToInt32(Console.ReadLine());

                        if (statsInput <= maxStatsLimit && statsInput >= 1)
                        {
                            charInt += statsInput;
                            maxStatsLimit -= statsInput;
                        }
                        else if (statsInput <= 0)
                        {
                            Console.WriteLine("Negative number detected try again.");
                        }
                        else
                        {
                            Console.WriteLine("Input exceeds remaining points to be added! Please try again.");
                        }
                    }
                    else if (ans.Equals("4"))
                    {
                        Console.WriteLine("Add stats to Character Dexterity: ");
                        statsInput = Convert.ToInt32(Console.ReadLine());

                        if (statsInput <= maxStatsLimit && statsInput >= 1)
                        {
                            charDex += statsInput;
                            maxStatsLimit -= statsInput;
                        }
                        else if (statsInput <= 0)
                        {
                            Console.WriteLine("Negative number detected try again.");
                        }
                        else
                        {
                            Console.WriteLine("Input exceeds remaining points to be added! Please try again.");
                        }
                    }
                    else if (ans.Equals("5"))
                    {
                        Console.WriteLine("Add stats to Character Luck: ");
                        statsInput = Convert.ToInt32(Console.ReadLine());

                        if (statsInput <= maxStatsLimit && statsInput >= 1)
                        {
                            charLuck += statsInput;
                            maxStatsLimit -= statsInput;
                        }
                        else if (statsInput <= 0)
                        {
                            Console.WriteLine("Negative number detected try again.");
                        }
                        else
                        {
                            Console.WriteLine("Input exceeds remaining points to be added! Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                Console.WriteLine("You have no remaining points left to be added in Character Stats.");

                Player.setInfo(charStr, charAgi, charInt, charDex, charLuck);

                Console.WriteLine("Character Additional Features");
                while (true)
                {
                    Console.Write("Put a moustache on your character? [Y/N]: ");
                    ans = Console.ReadLine();
                    if (ans.ToUpper().Equals("Y"))
                    {
                        hasMoustache = true;
                        break;
                    }
                    else if (ans.ToUpper().Equals("N"))
                    {
                        hasMoustache = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.Write("Put a beard on your character? [Y/N]: ");
                    ans = Console.ReadLine();
                    if (ans.ToUpper().Equals("Y"))
                    {
                        hasBeard = true;
                        break;
                    }
                    else if (ans.ToUpper().Equals("N"))
                    {
                        hasBeard = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.Write("Put a goatee on your character? [Y/N]: ");
                    ans = Console.ReadLine();
                    if (ans.ToUpper().Equals("Y"))
                    {
                        hasGoatee = true;
                        break;
                    }
                    else if (ans.ToUpper().Equals("N"))
                    {
                        hasGoatee = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.Write("Put a headband on your character? [Y/N]: ");
                    ans = Console.ReadLine();
                    if (ans.ToUpper().Equals("Y"))
                    {
                        hasHeadband = true;
                        break;
                    }
                    else if (ans.ToUpper().Equals("N"))
                    {
                        hasHeadband = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.Write("Put an earrings on your character? [Y/N]: ");
                    ans = Console.ReadLine();
                    if (ans.ToUpper().Equals("Y"))
                    {
                        hasEarrings = true;
                        break;
                    }
                    else if (ans.ToUpper().Equals("N"))
                    {
                        hasEarrings = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.Write("Put a necklace on your character? [Y/N]: ");
                    ans = Console.ReadLine();
                    if (ans.ToUpper().Equals("Y"))
                    {
                        hasNecklace = true;
                        break;
                    }
                    else if (ans.ToUpper().Equals("N"))
                    {
                        hasNecklace = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.Write("Put a ring on your character? [Y/N]: ");
                    ans = Console.ReadLine();
                    if (ans.ToUpper().Equals("Y"))
                    {
                        hasRing = true;
                        break;
                    }
                    else if (ans.ToUpper().Equals("N"))
                    {
                        hasRing = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
                Player.setInfo(hasMoustache, hasBeard, hasGoatee, hasHeadband, hasEarrings, hasNecklace, hasRing);

                try
                {
                    String insertQueryDB = "INSERT INTO dbo.CHARACTER_INFO (char_name, char_race, char_gender, " +
                       "char_hairstyle, char_haircolor, char_eyecolor, char_skintone, char_mass, " +
                       "char_class, char_element, char_faction, char_str, char_agi, char_int, char_dex, char_luck, " +
                       "has_moustache, has_beard, has_goatee, has_headband, has_earrings, has_necklace, has_ring) " +
                       "VALUES ('" + charName + "', '" + charRace + "', '" + charGender + "', '" + hairStyle + "', '" +
                       hairColor + "', '" + eyeColor + "', '" + skinTone + "', '" + charMass + "', '" + charClass + "', '" +
                       charElement + "', '" + charFaction + "', " + charStr + ", " + charAgi + ", " + charInt + ", " +
                       charDex + ", " + charLuck + ", '" + hasMoustache + "','" + hasBeard + "','" + hasGoatee + "','" + 
                       hasHeadband + "','" + hasEarrings + "','" + hasNecklace + "','" + hasRing + "')";

                        SqlCommand insertToDB = new SqlCommand(insertQueryDB, connection);
                        insertToDB.ExecuteNonQuery();
                        Console.WriteLine("\nCharacter has been created.");

                        Player.showInfo();
                        Player.showStats();
                        Player.showAdditionals();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Character creation failed.");
                    Console.WriteLine(ex.Message);
                    System.Environment.Exit(0);
                }
                finally
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nAn error has occured " + ex.Message);
                Console.WriteLine("\nPress any key to continue");
                ans1 = Console.ReadLine();
                Console.Clear();
                return;
            }
        }
    }
}