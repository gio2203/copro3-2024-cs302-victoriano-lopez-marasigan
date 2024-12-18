using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

namespace TheShadowKnight
{
    class LoadGame
    {
        static int ansInt, charID, charStr, charAgi, charInt, charDex, charLuck;
        static String ans, charName, charRace, charGender, hairStyle, hairColor, eyeColor, skinTone, charMass, charClass, charElement, charFaction, ans1, DBans;
        static bool hasMoustache, hasBeard, hasGoatee, hasHeadband, hasEarrings, hasNecklace, hasRing, error, tryagain;
        public static void LoadCharacter()
        {
            error = true;
            tryagain = true;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                        _____\r\n                        \\   /\r\n                        |   |\r\n           .__.         |   |_____________________________________________\r\n           |  |_________|   |                                              \\\r\n           |  |         |   |________________________________________________\\\r\n _____ _            _____ _               _                 _   __      _       _     _\r\n|_   _| |          /  ___| |             | |               | | / /     (_)     | |   | |\r\n  | | | |__   ___  \\ `--.| |__   __ _  __| | _____      __ | |/ / _ __  _  __ _| |__ | |_\r\n  | | | '_ \\ / _ \\  `--. | '_ \\ / _` |/ _` |/ _ \\ \\ /\\ / / |    \\| '_ \\| |/ _` | '_ \\| __|\r\n  | | | | | |  __/ /\\__/ | | | | (_| | (_| | (_) \\ V  V /  | |\\  | | | | | (_| | | | | |_\r\n  \\_/ |_| |_|\\___| \\____/|_| |_|\\__,_|\\__,_|\\___/ \\_/\\_/   \\_| \\_|_| |_|_|\\__, |_| |_|\\__|\r\n                             _____________________________________________ __/ |\r\n           |  |_________|   |                                             |___/\r\n           |__|         |   |_____________________________________________ /\r\n                        |   |\r\n                        |   |\r\n                        /___\\\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nLOAD GAME");
            SqlConnection connection;
            String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\Users\Admin\Desktop\st\3 1 SEM\Prog 3\TheShadowKnight-master\TheShadowKnight\CharacterDatabase.mdf;Integrated Security=True";
            String selectQueryDB = "SELECT * FROM dbo.CHARACTER_INFO";

            List<StoreCharInfo> charInfo = new List<StoreCharInfo>();

            using (connection = new SqlConnection(connectionString))
            {
                SqlCommand selectFromDB = new SqlCommand(selectQueryDB, connection);

                try
                {
                    connection.Open();
                    SqlDataReader dbReader = selectFromDB.ExecuteReader();


                    while (dbReader.Read())
                    {
                        int charID = Convert.ToInt32(dbReader["char_id"]);
                        string charName = dbReader["char_name"].ToString();
                        string charRace = dbReader["char_race"].ToString();
                        string charGender = dbReader["char_gender"].ToString();
                        string hairStyle = dbReader["char_hairstyle"].ToString();
                        string hairColor = dbReader["char_haircolor"].ToString();
                        string eyeColor = dbReader["char_eyecolor"].ToString();
                        string skinTone = dbReader["char_skintone"].ToString();
                        string charMass = dbReader["char_mass"].ToString();
                        string charClass = dbReader["char_class"].ToString();
                        string charElement = dbReader["char_element"].ToString();
                        string charFaction = dbReader["char_faction"].ToString();
                        int charStr = Convert.ToInt32(dbReader["char_str"]);
                        int charAgi = Convert.ToInt32(dbReader["char_agi"]);
                        int charInt = Convert.ToInt32(dbReader["char_int"]);
                        int charDex = Convert.ToInt32(dbReader["char_dex"]);
                        int charLuck = Convert.ToInt32(dbReader["char_luck"]);
                        bool hasMoustache = Convert.ToBoolean(dbReader["has_moustache"]);
                        bool hasBeard = Convert.ToBoolean(dbReader["has_beard"]);
                        bool hasGoatee = Convert.ToBoolean(dbReader["has_goatee"]);
                        bool hasHeadband = Convert.ToBoolean(dbReader["has_headband"]);
                        bool hasEarrings = Convert.ToBoolean(dbReader["has_earrings"]);
                        bool hasNecklace = Convert.ToBoolean(dbReader["has_necklace"]);
                        bool hasRing = Convert.ToBoolean(dbReader["has_ring"]);


                        charInfo.Add(new StoreCharInfo(charID, charName, charRace, charGender, hairStyle, hairColor, eyeColor, skinTone, charMass,
                            charClass, charElement, charFaction, charStr, charAgi, charInt, charDex, charLuck, hasMoustache, hasBeard, hasGoatee,
                            hasHeadband, hasEarrings, hasNecklace, hasRing));
                    }

                    dbReader.Close();

                    while (true)
                    {
                        Console.WriteLine("[1] View All Character");
                        Console.WriteLine("[2] View Specific Character");
                        Console.WriteLine("[3] Delete a Character");
                        Console.WriteLine("[4] Return to Main Menu");
                        Console.WriteLine("Enter Option: ");
                        DBans = Console.ReadLine();
                    
                        if (DBans == "1")
                        {
                            Console.WriteLine("Loaded Characters:");
                            foreach (var save in charInfo)
                            {
                                Console.WriteLine("[" + save.ID + "] " + save.Name);
                                StoreCharInfo findChar = charInfo.Find(character => character.ID == save.ID);
                                if (findChar != null)
                                {
                                    Console.WriteLine("Character Information:");

                                    Console.WriteLine("Character Name: " + findChar.Name);
                                    Console.WriteLine("Character Race: " + findChar.Race);
                                    Console.WriteLine("Character Gender: " + findChar.Gender);
                                    Console.WriteLine("Character Hairstyle: " + findChar.HairStyle);
                                    Console.WriteLine("Character Haircolor: " + findChar.HairColor);
                                    Console.WriteLine("Character Eyecolor: " + findChar.EyeColor);
                                    Console.WriteLine("Character Skin Tone: " + findChar.SkinTone);
                                    Console.WriteLine("Character Mass: " + findChar.Mass);
                                    Console.WriteLine("Character Class: " + findChar.Class);
                                    Console.WriteLine("Character Element: " + findChar.Element);
                                    Console.WriteLine("Character Faction: " + findChar.Faction);
                                    Console.WriteLine("Character Stats:");
                                    Console.WriteLine("\tStrength: " + findChar.Str);
                                    Console.WriteLine("\tAgility: " + findChar.Agi);
                                    Console.WriteLine("\tIntelligence: " + findChar.Int);
                                    Console.WriteLine("\tDexterity: " + findChar.Dex);
                                    Console.WriteLine("\tLuck: " + findChar.Luck);
                                    Console.WriteLine("Character Additional Features:");
                                    Console.WriteLine("\tCharacter Moustache: " + findChar.Moustache);
                                    Console.WriteLine("\tCharacter Beard: " + findChar.Beard);
                                    Console.WriteLine("\tCharacter Goatee: " + findChar.Goatee);
                                    Console.WriteLine("\tCharacter Headband: " + findChar.Headband);
                                    Console.WriteLine("\tCharacter Earrings: " + findChar.Earrings);
                                    Console.WriteLine("\tCharacter Necklace: " + findChar.Necklace);
                                    Console.WriteLine("\tCharacter Ring: " + findChar.Ring);
                                    Console.WriteLine("\n");
                                }
                            }
                        }
                        else if (DBans == "2")
                        {

                            if (charInfo.Count > 0)
                            {
                                Console.WriteLine("Loaded Characters:");
                                foreach (var save in charInfo)
                                {
                                    Console.WriteLine("[" + save.ID + "] " + save.Name);
                                }


                                Console.WriteLine("Enter the ID of the Character to load: ");
                                int ansInt = Convert.ToInt32(Console.ReadLine());

                                StoreCharInfo findChar = charInfo.Find(character => character.ID == ansInt);
                                if (findChar != null)
                                {
                                    Console.WriteLine("Successfully loaded! ");
                                    Console.WriteLine("\nCharacter Information:");

                                    Console.WriteLine("Character Name: " + findChar.Name);
                                    Console.WriteLine("Character Race: " + findChar.Race);
                                    Console.WriteLine("Character Gender: " + findChar.Gender);
                                    Console.WriteLine("Character Hairstyle: " + findChar.HairStyle);
                                    Console.WriteLine("Character Haircolor: " + findChar.HairColor);
                                    Console.WriteLine("Character Eyecolor: " + findChar.EyeColor);
                                    Console.WriteLine("Character Skin Tone: " + findChar.SkinTone);
                                    Console.WriteLine("Character Mass: " + findChar.Mass);
                                    Console.WriteLine("Character Class: " + findChar.Class);
                                    Console.WriteLine("Character Element: " + findChar.Element);
                                    Console.WriteLine("Character Faction: " + findChar.Faction);
                                    Console.WriteLine("Character Stats:");
                                    Console.WriteLine("\tStrength: " + findChar.Str);
                                    Console.WriteLine("\tAgility: " + findChar.Agi);
                                    Console.WriteLine("\tIntelligence: " + findChar.Int);
                                    Console.WriteLine("\tDexterity: " + findChar.Dex);
                                    Console.WriteLine("\tLuck: " + findChar.Luck);
                                    Console.WriteLine("Character Additional Features:");
                                    Console.WriteLine("\tCharacter Moustache: " + findChar.Moustache);
                                    Console.WriteLine("\tCharacter Beard: " + findChar.Beard);
                                    Console.WriteLine("\tCharacter Goatee: " + findChar.Goatee);
                                    Console.WriteLine("\tCharacter Headband: " + findChar.Headband);
                                    Console.WriteLine("\tCharacter Earrings: " + findChar.Earrings);
                                    Console.WriteLine("\tCharacter Necklace: " + findChar.Necklace);
                                    Console.WriteLine("\tCharacter Ring: " + findChar.Ring);


                                    Console.WriteLine("[1] Go back");
                                    Console.WriteLine("[2] Return to Main Menu");
                                    Console.WriteLine("[3] Delete Character");
                                    Console.WriteLine("[4] Exit");
                                    Console.Write("Enter option: ");
                                    ansInt = Convert.ToInt32(Console.ReadLine());

                                    if (ansInt == 1)
                                    {
                                        Console.Clear();
                                        LoadGame.LoadCharacter();
                                    }
                                    else if (ansInt == 2)
                                    {
                                        Console.Clear();
                                        return;
                                    }
                                    else if (ansInt == 3)
                                    {
                                        DelChar(findChar.ID);
                                        charInfo.Remove(findChar);
                                        while (error == true)
                                        {
                                            Console.Write("Return to Character Menu? [Y/N]: ");
                                            string ans = Console.ReadLine();
                                            if (ans.ToUpper().Equals("Y"))
                                            {
                                                error = false;
                                                Console.Clear();
                                                LoadGame.LoadCharacter();
                                                return;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Exiting in 5 seconds...");
                                                Thread.Sleep(5000);
                                                System.Environment.Exit(0);
                                            }
                                        }
                                    }
                                    else if (ansInt == 4)
                                    {
                                        Console.WriteLine("Thank you for playing the game!");
                                        Console.WriteLine("Exiting in 5 seconds...");
                                        Thread.Sleep(5000);
                                        System.Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid option! Please try again.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Character not found! Please try again.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No saved characters available in the game.");
                                Console.Write("Return to Main menu? [Y/N]: ");
                                string ans = Console.ReadLine();
                                if (ans.ToUpper().Equals("Y"))
                                {
                                    Console.Clear();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Exiting in 5 seconds...");
                                    Thread.Sleep(5000);
                                    System.Environment.Exit(0);
                                }
                            }
                        }
                        else if (DBans == "3")
                        {
                            if (charInfo.Count > 0)
                            {
                                Console.WriteLine("Loaded Characters:");
                                foreach (var save in charInfo)
                                {
                                    Console.WriteLine("[" + save.ID + "] " + save.Name);
                                }


                                Console.WriteLine("Enter the ID of the Character to delete: ");
                                int ansInt = Convert.ToInt32(Console.ReadLine());

                                StoreCharInfo findChar = charInfo.Find(character => character.ID == ansInt);
                                if (findChar != null)
                                {
                                    Console.WriteLine("Successfully loaded! ");
                                    Console.WriteLine("\nCharacter Information:");

                                    Console.WriteLine("Character Name: " + findChar.Name);
                                    Console.WriteLine("Character Race: " + findChar.Race);
                                    Console.WriteLine("Character Gender: " + findChar.Gender);
                                    Console.WriteLine("Character Hairstyle: " + findChar.HairStyle);
                                    Console.WriteLine("Character Haircolor: " + findChar.HairColor);
                                    Console.WriteLine("Character Eyecolor: " + findChar.EyeColor);
                                    Console.WriteLine("Character Skin Tone: " + findChar.SkinTone);
                                    Console.WriteLine("Character Mass: " + findChar.Mass);
                                    Console.WriteLine("Character Class: " + findChar.Class);
                                    Console.WriteLine("Character Element: " + findChar.Element);
                                    Console.WriteLine("Character Faction: " + findChar.Faction);
                                    Console.WriteLine("Character Stats:");
                                    Console.WriteLine("\tStrength: " + findChar.Str);
                                    Console.WriteLine("\tAgility: " + findChar.Agi);
                                    Console.WriteLine("\tIntelligence: " + findChar.Int);
                                    Console.WriteLine("\tDexterity: " + findChar.Dex);
                                    Console.WriteLine("\tLuck: " + findChar.Luck);
                                    Console.WriteLine("Character Additional Features:");
                                    Console.WriteLine("\tCharacter Moustache: " + findChar.Moustache);
                                    Console.WriteLine("\tCharacter Beard: " + findChar.Beard);
                                    Console.WriteLine("\tCharacter Goatee: " + findChar.Goatee);
                                    Console.WriteLine("\tCharacter Headband: " + findChar.Headband);
                                    Console.WriteLine("\tCharacter Earrings: " + findChar.Earrings);
                                    Console.WriteLine("\tCharacter Necklace: " + findChar.Necklace);
                                    Console.WriteLine("\tCharacter Ring: " + findChar.Ring);


                                    Console.WriteLine("\n[1] Delete Character");
                                    Console.WriteLine("[2] Return to Character Menu");
                                    Console.WriteLine("[3] Return to Main Menu");
                                    Console.WriteLine("[4] Exit");
                                    Console.Write("Enter option: ");
                                    ansInt = Convert.ToInt32(Console.ReadLine());

                                    if (ansInt == 1)
                                    {
                                        DelChar(findChar.ID);
                                        charInfo.Remove(findChar);
                                        while (error == true)
                                        {
                                            Console.Write("Return to Character Menu? [Y/N]: ");
                                            string ans = Console.ReadLine();
                                            if (ans.ToUpper().Equals("Y"))
                                            {
                                                error = false;
                                                Console.Clear();
                                                LoadGame.LoadCharacter();
                                                return;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                return;
                                            }
                                        }
                                    }
                                    else if (ansInt == 2)
                                    {
                                        Console.Clear();
                                        LoadGame.LoadCharacter();
                                        return;
                                    }
                                    else if (ansInt == 3)
                                    {
                                        Console.Clear();
                                        return;
                                    }
                                    else if (ansInt == 4)
                                    {
                                        Console.WriteLine("Thank you for playing the game!");
                                        Console.WriteLine("Exiting in 5 seconds...");
                                        Thread.Sleep(5000);
                                        System.Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid option! Please try again.");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("No saved characters available in the game.");
                                Console.Write("Return to Main menu? [Y/N]: ");
                                string ans = Console.ReadLine();
                                if (ans.ToUpper().Equals("Y"))
                                {
                                    Console.Clear();
                                    return;
                                }
                                else
                                {
                                    Console.WriteLine("Exiting in 5 seconds...");
                                    Thread.Sleep(5000);
                                    System.Environment.Exit(0);
                                }
                            }
                        }
                        else if (DBans == "4")
                        {
                            Console.Clear();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Invalid option! Please try again.");
                            continue;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nAn error has occured invalid input.");
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("\nPress any key to continue");
                    ans1 = Console.ReadLine();
                    Console.Clear();
                    return;
                }
            }
        }

        public static void DelChar(int charID)
        {
            string ans;
            SqlConnection connection;

            String connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\Users\Admin\Desktop\st\3 1 SEM\Prog 3\TheShadowKnight-master\TheShadowKnight\CharacterDatabase.mdf;Integrated Security=True";

            using (connection = new SqlConnection(connectionString))
            {
                String deleteQueryDB = "DELETE FROM dbo.CHARACTER_INFO WHERE char_id = " + charID;

                SqlCommand delete = new SqlCommand(deleteQueryDB, connection);

                while (true)
                {
                    Console.Write("Confirm deletion? [Y/N]: ");
                    ans = Console.ReadLine();

                    if (ans.ToUpper().Equals("Y"))
                    {
                        try
                        {
                            connection.Open();
                            delete.ExecuteNonQuery();
                            Console.WriteLine("Character deleted successfully.");
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error in deleting character.");
                            Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                    else if (ans.ToUpper().Equals("N"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid option! Please try again.");
                        continue;
                    }
                }
            }
        }
    }
    class StoreCharInfo
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Race { get; set; }
        public String Gender { get; set; }
        public String HairStyle { get; set; }
        public String HairColor { get; set; }
        public String EyeColor { get; set; }
        public String SkinTone { get; set; }
        public String Mass { get; set; }
        public String Class { get; set; }
        public String Element { get; set; }
        public String Faction { get; set; }
        public int Str { get; set; }
        public int Agi { get; set; }
        public int Int { get; set; }
        public int Dex { get; set; }
        public int Luck { get; set; }
        public bool Moustache { get; set; }
        public bool Beard { get; set; }
        public bool Goatee { get; set; }
        public bool Headband { get; set; }
        public bool Earrings { get; set; }
        public bool Necklace { get; set; }
        public bool Ring { get; set; }

        public StoreCharInfo(int id, String name, String race, String gender, String hairstyle, String haircolor, String eyecolor, String skintone, String mass, String job, String element, String faction, int str, int agi, int inte, int dex, int luck, bool moustache, bool beard, bool goatee, bool headband, bool earrings, bool necklace, bool ring)
        {
            ID = id;
            Name = name;
            Race = race;
            Gender = gender;
            HairStyle = hairstyle;
            HairColor = haircolor;
            EyeColor = eyecolor;
            SkinTone = skintone;
            Mass = mass;
            Class = job;
            Element = element;
            Faction = faction;
            Str = str;
            Agi = agi;
            Int = inte;
            Dex = dex;
            Luck = luck;
            Moustache = moustache;
            Beard = beard;
            Goatee = goatee;
            Headband = headband;
            Earrings = earrings;
            Necklace = necklace;
            Ring = ring;
        }
    }
}
    
