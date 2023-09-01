// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string? menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    // display the top-level menu options
    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();

    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    switch (menuSelection)
    {
        case "1":
            string currentId = "";
            bool isEmptyId = false;
            int petCount = 0;

            foreach (var item in ourAnimals)
            {
                if (item.Contains("ID #:"))
                {
                    currentId = item.Split(":")[1].Trim();

                    if (item.Split(":")[1].Trim().Length == 0)
                    {
                        isEmptyId = true;
                        petCount++;
                    }
                    else
                    {
                        Console.WriteLine();
                        isEmptyId = false;
                    }
                }
                else
                {
                    currentId = "";
                }

                if (!isEmptyId)
                {
                    Console.WriteLine(item);
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine();
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }
            break;

        case "2":
            // Add a new animal friend to the ourAnimals array
            string anotherPet = "y";
            int petCount1 = 0;

            foreach (var pet in ourAnimals)
            {
                if (pet.Contains("ID #:") && pet.Split(":")[1].Trim().Length > 0)
                {
                    petCount1++;
                }
            }

            if (petCount1 < maxPets)
            {
                Console.WriteLine();
                Console.WriteLine($"We currently have {petCount1} pets that need homes. We can manage {(maxPets - petCount1)} more.");
            }

            while (anotherPet == "y" && petCount1 < maxPets)
            {
                bool validEntry = false;
                // get species (cat or dog) - string animalSpecies is a required field 
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");

                    readResult = Console.ReadLine();

                    animalSpecies = readResult.ToLower();

                    // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
                    animalID = animalSpecies.Substring(0, 1) + (petCount1 + 1).ToString();

                    petCount1++;

                    if (readResult != null)
                    {
                        // get the pet's age. can be ? at initial entry. 
                        do
                        {
                            int petAge;

                            Console.WriteLine("Enter the pet's age or enter ? if unknown");

                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalAge = readResult.ToLower();

                                if (animalAge != "?")
                                {
                                    validEntry = int.TryParse(animalAge, out petAge);
                                }
                                else
                                {
                                    validEntry = true;
                                }
                            }
                        } while (validEntry == false);

                        // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
                        do
                        {
                            Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");

                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalPhysicalDescription = readResult.ToLower();

                                if (animalPhysicalDescription == "")
                                {
                                    animalPhysicalDescription = "tbd";
                                }
                            }

                        } while (animalPhysicalDescription == "");

                        // get a description of the pet's personality - animalPersonalityDescription can be blank.
                        do
                        {
                            Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");

                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalPersonalityDescription = readResult.ToLower();

                                if (animalPersonalityDescription == "")
                                {
                                    animalPersonalityDescription = "tbd";
                                }
                            }
                        } while (animalPersonalityDescription == "");

                        // get the pet's nickname. animalNickname can be blank.
                        do
                        {
                            Console.WriteLine("Enter a nickname for the pet");

                            readResult = Console.ReadLine();

                            if (readResult != null)
                            {
                                animalNickname = readResult.ToLower();

                                if (animalNickname == "")
                                {
                                    animalNickname = "tbd";
                                }
                            }
                        } while (animalNickname == "");

                        // store the pet information in the ourAnimals array (zero based)
                        ourAnimals[petCount1, 0] = "ID #: " + animalID;
                        ourAnimals[petCount1, 1] = "Species: " + animalSpecies;
                        ourAnimals[petCount1, 2] = "Age: " + animalAge;
                        ourAnimals[petCount1, 3] = "Nickname: " + animalNickname;
                        ourAnimals[petCount1, 4] = "Physical description: " + animalPhysicalDescription;
                        ourAnimals[petCount1, 5] = "Personality: " + animalPersonalityDescription;

                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // check maxPet limit
                if (petCount1 < maxPets)
                {
                    Console.WriteLine($@"Current pets count is {petCount1}/{maxPets}");
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");

                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount1 >= maxPets)
            {
                Console.WriteLine($@"Current pets count is {petCount1}/{maxPets}, We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }
            break;

        case "3":
        case "4":
        case "5":
        case "6":
        case "7":
        case "8":
            Console.WriteLine($"You selected menu option {menuSelection}.");
            Console.WriteLine("this app feature is coming soon - please check back to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "exit":
            Console.WriteLine($"You have chosed to exit the application!");
            break;
        default:
            Console.WriteLine("Enter correct menu options 1 to 8 or exit");
            break;
    }

    Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    menuSelection = Console.ReadLine();
} while (menuSelection != "exit");




