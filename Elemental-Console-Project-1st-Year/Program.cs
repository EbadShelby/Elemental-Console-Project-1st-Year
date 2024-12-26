using System;

namespace Elemental_Console_Project_1st_Year
{
    internal class Program
    {
        static string[,] elementsData = {
        {"1", "Hydrogen", "H", "1.008"},
        {"2", "Helium", "He", "4.0026"},
        {"3", "Lithium", "Li", "6.94"},
        {"4", "Beryllium", "Be", "9.0122"},
        {"5", "Boron", "B", "10.81"},
        {"6", "Carbon", "C", "12.011"},
        {"7", "Nitrogen", "N", "14.007"},
        {"8", "Oxygen", "O", "15.999"},
        {"9", "Fluorine", "F", "18.998"},
        {"10", "Neon", "Ne", "20.180"},
        {"11", "Sodium", "Na", "22.990"},
        {"12", "Magnesium", "Mg", "24.305"},
        {"13", "Aluminum", "Al", "26.982"},
        {"14", "Silicon", "Si", "28.085"},
        {"15", "Phosphorus", "P", "30.974"},
        {"16", "Sulfur", "S", "32.06"},
        {"17", "Chlorine", "Cl", "35.45"},
        {"18", "Argon", "Ar", "39.948"},
        {"19", "Potassium", "K", "39.098"},
        {"20", "Calcium", "Ca", "40.078"},
        {"21", "Scandium", "Sc", "44.956"},
        {"22", "Titanium", "Ti", "47.867"},
        {"23", "Vanadium", "V", "50.942"},
        {"24", "Chromium", "Cr", "51.996"},
        {"25", "Manganese", "Mn", "54.938"},
        {"26", "Iron", "Fe", "55.845"},
        {"27", "Cobalt", "Co", "58.933"},
        {"28", "Nickel", "Ni", "58.693"},
        {"29", "Copper", "Cu", "63.546"},
        {"30", "Zinc", "Zn", "65.38"},
        {"31", "Gallium", "Ga", "69.723"},
        {"32", "Germanium", "Ge", "72.63"},
        {"33", "Arsenic", "As", "74.922"},
        {"34", "Selenium", "Se", "78.971"},
        {"35", "Bromine", "Br", "79.904"},
        {"36", "Krypton", "Kr", "83.798"},
        {"37", "Rubidium", "Rb", "85.468"},
        {"38", "Strontium", "Sr", "87.62"},
        {"39", "Yttrium", "Y", "88.906"},
        {"40", "Zirconium", "Zr", "91.224"},
        {"41", "Niobium", "Nb", "92.906"},
        {"42", "Molybdenum", "Mo", "95.95"},
        {"43", "Technetium", "Tc", "98"},
        {"44", "Ruthenium", "Ru", "101.07"},
        {"45", "Rhodium", "Rh", "102.91"},
        {"46", "Palladium", "Pd", "106.42"},
        {"47", "Silver", "Ag", "107.87"},
        {"48", "Cadmium", "Cd", "112.41"},
        {"49", "Indium", "In", "114.82"},
        {"50", "Tin", "Sn", "118.71"},
        {"51", "Antimony", "Sb", "121.76"},
        {"52", "Tellurium", "Te", "127.6"},
        {"53", "Iodine", "I", "126.9"},
        {"54", "Xenon", "Xe", "131.29"},
        {"55", "Cesium", "Cs", "132.91"},
        {"56", "Barium", "Ba", "137.33"},
        {"57", "Lanthanum", "La", "138.91"},
        {"58", "Cerium", "Ce", "140.12"},
        {"59", "Praseodymium", "Pr", "140.91"},
        {"60", "Neodymium", "Nd", "144.24"},
        {"61", "Promethium", "Pm", "145"},
        {"62", "Samarium", "Sm", "150.36"},
        {"63", "Europium", "Eu", "151.96"},
        {"64", "Gadolinium", "Gd", "157.25"},
        {"65", "Terbium", "Tb", "158.93"},
        {"66", "Dysprosium", "Dy", "162.5"},
        {"67", "Holmium", "Ho", "164.93"},
        {"68", "Erbium", "Er", "167.26"},
        {"69", "Thulium", "Tm", "168.93"},
        {"70", "Ytterbium", "Yb", "173.05"},
        {"71", "Lutetium", "Lu", "174.97"},
        {"72", "Hafnium", "Hf", "178.49"},
        {"73", "Tantalum", "Ta", "180.95"},
        {"74", "Tungsten", "W", "183.84"},
        {"75", "Rhenium", "Re", "186.21"},
        {"76", "Osmium", "Os", "190.23"},
        {"77", "Iridium", "Ir", "192.22"},
        {"78", "Platinum", "Pt", "195.08"},
        {"79", "Gold", "Au", "196.97"},
        {"80", "Mercury", "Hg", "200.59"},
        {"81", "Thallium", "Tl", "204.38"},
        {"82", "Lead", "Pb", "207.2"},
        {"83", "Bismuth", "Bi", "208.98"},
        {"84", "Polonium", "Po", "209"},
        {"85", "Astatine", "At", "210"},
        {"86", "Radon", "Rn", "222"},
        {"87", "Francium", "Fr", "223"},
        {"88", "Radium", "Ra", "226"},
        {"89", "Actinium", "Ac", "227"},
        {"90", "Thorium", "Th", "232.04"},
        {"91", "Protactinium", "Pa", "231.04"},
        {"92", "Uranium", "U", "238.03"},
        {"93", "Neptunium", "Np", "237"},
        {"94", "Plutonium", "Pu", "244"},
        {"95", "Americium", "Am", "243"},
        {"96", "Curium", "Cm", "247"},
        {"97", "Berkelium", "Bk", "247"},
        {"98", "Californium", "Cf", "251"},
        {"99", "Einsteinium", "Es", "252"},
        {"100", "Fermium", "Fm", "257"},
        {"101", "Mendelevium", "Md", "258"},
        {"102", "Nobelium", "No", "259"},
        {"103", "Lawrencium", "Lr", "266"},
        {"104", "Rutherfordium", "Rf", "267"},
        {"105", "Dubnium", "Db", "268"},
        {"106", "Seaborgium", "Sg", "269"},
        {"107", "Bohrium", "Bh", "270"},
        {"108", "Hassium", "Hs", "269"},
        {"109", "Meitnerium", "Mt", "278"},
        {"110", "Darmstadtium", "Ds", "281"},
        {"111", "Roentgenium", "Rg", "282"},
        {"112", "Copernicium", "Cn", "285"},
        {"113", "Nihonium", "Nh", "286"},
        {"114", "Flerovium", "Fl", "289"},
        {"115", "Moscovium", "Mc", "290"},
        {"116", "Livermorium", "Lv", "293"},
        {"117", "Tennessine", "Ts", "294"},
        {"118", "Oganesson", "Og", "294"}
    };
        static void Main(string[] args)
        {
            Console.WriteLine("================================================================");
            Console.WriteLine("|                     | Elemental Console |                    |");
            Console.WriteLine("================================================================");
            Console.WriteLine("|                   -- Log In Your Account --                  |");
            Console.WriteLine("----------------------------------------------------------------");

            string correctUsername = "user01";
            string correctPassword = "pass01";

            int attempts = 0;
            int maxAttempts = 3;

            while (true)
            {
                Console.Write("Enter Username: ");
                string userName = Console.ReadLine();
                Console.Write("Enter Password: ");
                string passWord = Console.ReadLine();

                if (userName == correctUsername && passWord == correctPassword)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Login successful! Welcome to the Elemental Console, " + correctUsername + "!");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    break;
                }
                else
                {
                    attempts++;
                    int attemptsLeft = maxAttempts - attempts;
                    Console.WriteLine($"Incorrect username or password. {attemptsLeft} attempt's left.");
                    Console.WriteLine("");
                    if (attempts >= 3)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No more attempts left. try again later. Exiting......");
                        return;
                    }
                }
            }

            while (true)
            {
                Console.WriteLine("================================================================");
                Console.WriteLine("|                     | Elemental Console |                    |");
                Console.WriteLine("================================================================");
                Console.WriteLine("|               Simplified Periodic Table Viewer               |");
                Console.WriteLine("|                          and Quizzer                         |");
                Console.WriteLine("================================================================");
                Console.WriteLine("================================================================");
                Console.WriteLine("| 1. View Periodic Table                                       |");
                Console.WriteLine("| 2. Elements Quizzer                                          |");
                Console.WriteLine("| 3. Exit                                                      |");
                Console.WriteLine("================================================================");

                Console.Write("Please indicate your selection: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("");
                    Console.WriteLine("================================================================");
                    Console.WriteLine("|   |               Periodic Table of Elements             |   |");
                    Console.WriteLine("================================================================");
                    Console.WriteLine("");
                    Console.WriteLine("{0,-15} {1,-20} {2,-15} {3,-15}", "Atomic #", "Element Name", "Symbol", "Atomic mass");
                    Console.WriteLine("----------------------------------------------------------------");

                    for (int i = 0; i < elementsData.GetLength(0); i++)
                    {
                        Console.WriteLine("{0,-15} {1,-20} {2,-15} {3, -15}", elementsData[i, 0], elementsData[i, 1], elementsData[i, 2], elementsData[i, 3]);
                    }
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("");

                    while (true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("================================================================");
                        Console.WriteLine("| 1. Back                                                      |");
                        Console.WriteLine("| 2. Exit                                                      |");
                        Console.WriteLine("================================================================");

                        Console.Write("Please indicate your selection: ");
                        string input = Console.ReadLine();

                        if (input == "1")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Back to Main Menu...");
                            Console.WriteLine("");
                            break;
                        }
                        else if (input == "2")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Exiting...");
                            Console.WriteLine("");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid input!!!. Please choose a valid option and try again.");
                            Console.WriteLine("");
                        }
                    }
                    Console.WriteLine("");
                }
                else if (choice == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("================================================================");
                        Console.WriteLine("|                | -- Periodic Table Quizzer -- |              |");
                        Console.WriteLine("|                |   -- Select a Quiz Type --   |              |");
                        Console.WriteLine("================================================================");
                        Console.WriteLine("================================================================");
                        Console.WriteLine("| 1. Name to Atomic Number                                     |");
                        Console.WriteLine("| 2. Name to Symbol                                            |");
                        Console.WriteLine("| 3. Name to Atomic Mass                                       |");
                        Console.WriteLine("| 4. Back                                                      |");
                        Console.WriteLine("| 5. Exit                                                      |");
                        Console.WriteLine("================================================================");

                        Console.Write("Please indicate your selection: ");
                        string quizType = Console.ReadLine();

                        if (quizType == "1")
                        {
                            while (true)
                            {
                                int correctAnswers = 0;
                                int totalQuestions = 1;
                                Random random = new Random();

                                while (true)
                                {
                                    int index = random.Next(0, elementsData.GetLength(0));
                                    string elementName = elementsData[index, 1];
                                    string atomicNumber = elementsData[index, 0];

                                    try
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("================================================================");
                                        Console.WriteLine("|                     Name to Atomic Number                    |");
                                        Console.WriteLine($"|                          Question #{totalQuestions}                         |");
                                        Console.WriteLine("================================================================");

                                        Console.WriteLine($"Element Name: {elementName}");
                                        Console.Write("Guess the atomic number (or type 0 to stop): ");
                                        int guessedAtomicNumber = int.Parse(Console.ReadLine());

                                        if (guessedAtomicNumber == Convert.ToInt32(atomicNumber))
                                        {
                                            Console.WriteLine("----------------------------------------------------------------");
                                            Console.WriteLine("FANTASTIC!!! You Got it Right!");
                                            Console.WriteLine("----------------------------------------------------------------");
                                            totalQuestions++;
                                            correctAnswers++;
                                        }
                                        else if (guessedAtomicNumber == 0)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Quiz Stopped.");
                                            Console.WriteLine("");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("----------------------------------------------------------------");
                                            Console.WriteLine($"Wrong! The correct atomic number is | {atomicNumber} |.");
                                            Console.WriteLine("----------------------------------------------------------------");
                                            totalQuestions++;
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid input! Please enter an integer.");
                                        Console.WriteLine("");
                                    }
                                }

                                Console.WriteLine("================================================================");
                                Console.WriteLine($"|               | Quiz Complete! Your score: {correctAnswers}/{totalQuestions - 1} |             |");
                                Console.WriteLine("================================================================");
                                Console.WriteLine("");

                                Console.WriteLine("");
                                Console.Write("Do you want to play again? (Y/N): ");
                                string playAgain;

                                while (true)
                                {
                                    playAgain = Console.ReadLine().ToUpper();

                                    if (playAgain != "Y" && playAgain != "N")
                                    {
                                        Console.WriteLine("Invalid input!!!. Please choose a valid option and try again.");
                                        Console.WriteLine("");
                                        Console.Write("Do you want to play again? (Y/N): ");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                if (playAgain != "Y")
                                {
                                    Console.WriteLine("");
                                    break;
                                }
                            }
                        }
                        else if (quizType == "2")
                        {
                            while (true)
                            {
                                int correctAnswers = 0;
                                int totalQuestions = 1;
                                Random random = new Random();

                                while (true)
                                {
                                    int index = random.Next(0, elementsData.GetLength(0));
                                    string elementName = elementsData[index, 1];
                                    string symbol = elementsData[index, 2];

                                    try
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("================================================================");
                                        Console.WriteLine("|                          Name to Symbol                      |");
                                        Console.WriteLine($"|                          Question #{totalQuestions}                         |");
                                        Console.WriteLine("================================================================");

                                        Console.WriteLine($"Element Name: {elementName}");
                                        Console.Write("Guess the element symbol (or type 0 to stop): ");
                                        string guessedSymbol = Console.ReadLine();

                                        if (guessedSymbol.ToLower() == symbol.ToLower())
                                        {
                                            Console.WriteLine("----------------------------------------------------------------");
                                            Console.WriteLine("FANTASTIC!!! You Got it Right!");
                                            Console.WriteLine("----------------------------------------------------------------");
                                            correctAnswers++;
                                            totalQuestions++;
                                        }
                                        else if (guessedSymbol == "0")
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Quiz Stopped.");
                                            Console.WriteLine("");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("----------------------------------------------------------------");
                                            Console.WriteLine($"Wrong! The correct symbol is | {symbol} |.");
                                            Console.WriteLine("----------------------------------------------------------------");
                                            totalQuestions++;
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid input! Please enter a valid symbol.");
                                        Console.WriteLine("");
                                    }
                                }

                                Console.WriteLine("================================================================");
                                Console.WriteLine($"|               | Quiz Complete! Your score: {correctAnswers}/{totalQuestions - 1} |             |");
                                Console.WriteLine("================================================================");
                                Console.WriteLine("");

                                Console.WriteLine("");
                                Console.Write("Do you want to play again? (Y/N): ");
                                string playAgain;
                                while (true)
                                {
                                    playAgain = Console.ReadLine().ToUpper();

                                    if (playAgain != "Y" && playAgain != "N")
                                    {
                                        Console.WriteLine("Invalid input!!!. Please choose a valid option and try again.");
                                        Console.WriteLine("");
                                        Console.Write("Do you want to play again? (Y/N): ");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                if (playAgain != "Y")
                                {
                                    Console.WriteLine("");
                                    break;
                                }
                            }
                        }
                        else if (quizType == "3")
                        {
                            while (true)
                            {
                                int correctAnswers = 0;
                                int totalQuestions = 1;
                                Random random = new Random();

                                while (true)
                                {
                                    int index = random.Next(0, elementsData.GetLength(0));
                                    string elementName = elementsData[index, 1];
                                    string atomicMass = elementsData[index, 3];

                                    try
                                    {
                                        Console.WriteLine("");
                                        Console.WriteLine("================================================================");
                                        Console.WriteLine("|                       Name to Atomic Mass                    |");
                                        Console.WriteLine($"|                          Question #  {totalQuestions}                       |");
                                        Console.WriteLine("================================================================");

                                        Console.WriteLine($"Element Name: {elementName}");
                                        Console.Write("Guess the atomic mass (or type 0 to stop): ");
                                        double guessedAtomicMass = double.Parse(Console.ReadLine());

                                        if (guessedAtomicMass == 0)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("Quiz Stopped.");
                                            Console.WriteLine("");
                                            break;
                                        }
                                        else if (guessedAtomicMass == Convert.ToDouble(atomicMass))
                                        {
                                            Console.WriteLine("----------------------------------------------------------------");
                                            Console.WriteLine("FANTASTIC!!! You Got it Right!");
                                            Console.WriteLine("----------------------------------------------------------------");
                                            correctAnswers++;
                                            totalQuestions++;
                                        }
                                        else
                                        {
                                            Console.WriteLine("----------------------------------------------------------------");
                                            Console.WriteLine($"Wrong! The correct atomic mass is | {atomicMass} |.");
                                            Console.WriteLine("----------------------------------------------------------------");
                                            totalQuestions++;
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid input! Please enter a number.");
                                        Console.WriteLine("");
                                    }
                                }

                                Console.WriteLine("================================================================");
                                Console.WriteLine($"|               | Quiz Complete! Your score: {correctAnswers}/{totalQuestions - 1} |             |");
                                Console.WriteLine("================================================================");
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.Write("Do you want to play again? (Y/N): ");
                                string playAgain;

                                while (true)
                                {
                                    playAgain = Console.ReadLine().ToUpper();

                                    if (playAgain != "Y" && playAgain != "N")
                                    {
                                        Console.WriteLine("Invalid input!!!. Please choose a valid option and try again.");
                                        Console.WriteLine("");
                                        Console.Write("Do you want to play again? (Y/N): ");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }

                                if (playAgain != "Y")
                                {
                                    Console.WriteLine("");
                                    break;
                                }
                            }
                        }
                        else if (quizType == "4")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Back to Main Menu...");
                            Console.WriteLine("");
                            break;
                        }
                        else if (quizType == "5")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Exiting...");
                            Console.WriteLine("");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Invalid input!!!. Please choose a valid option and try again.");
                            Console.WriteLine("");
                        }
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Exiting...");
                    Console.WriteLine("");
                    break;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid input!!!. Please choose a valid option and try again.");
                    Console.WriteLine("");
                }
            }
        }
    }
}
