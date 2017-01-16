using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace calculatorForDevAndPrice
{
    // to do add password admin or user
    class calculatorForDeveloperUsages
    {
        static void Main()
        {
            System.Console.OutputEncoding = System.Text.Encoding.UTF8; // enable to view square meters
            string asterix = "*************";
            Console.WriteLine(@"{0}Little helper for set up proccessors v1.2{0}", asterix);
<<<<<<< HEAD
            string userPassWord = "naskoGed";
=======
            string userPassWord = "XXXX";
>>>>>>> 17929fe4c1afc9803219b998e017ecb3a05c0a2d
            while (!isAuthorizeUser(userPassWord))
            {
                Console.WriteLine("Password is Not Correct. Please try again: ");
            }
            MainMenu();
            string plateOption = (Console.ReadLine().ToLower());
            while (plateOption!="exit")
            {
                switch (plateOption)
                {
                    case "1":// plate option Electra XD
                        ElectraXd();
                        break;
                    case "2":// plate option Elextra MAX
                        ElectraMax();
                        break;
                    case "3"://plate option Capricorn VT
                        CapricornVt();
                        break;
                    case "4":// plate option thrmal PT
                        ThermalPt();
                        break;
                    case "5"://plate option dual xd and max
                        DualProcessing();//Max and XD
                        break;    
                    default:
                        Console.WriteLine("use Plate option form 1 to 5 or \"Exit\" for close the program");
                        break;
                }
                MainMenu();
                plateOption = Console.ReadLine().ToLower();
            }
            //to do exit from exe
            Console.WriteLine("{0}Thank you for use Nasko's program {0}\n\n{0}Press \"Enter\" to close the program{0}", asterix);
            var exit = Console.ReadLine();
        }

        private static string adminFunction()// for future use
        {
            string newUserPassWord= "admin";
            adminMenu();
            string adminOption = Console.ReadLine().ToLower();
            while (adminOption != "back")
            {
                switch (adminOption)
                {
                    case "1"://change user password
                        Console.WriteLine("Please enter new user Password");
                        string changePassWord1 = Console.ReadLine();
                        Console.WriteLine("Please re-enter new user Password");
                        string changePassWord2 = Console.ReadLine();
                        if (changePassWord1 == changePassWord2)
                        {
                            newUserPassWord = changePassWord1;
                            //return userPassWord;
                            Console.WriteLine(newUserPassWord + " newUserPassWord");
                            Console.WriteLine(changePassWord1 + " changePassWord1");
                        }
                        else
                        {
                            Console.WriteLine("The passwords that you enter is not the same. Please try again");
                        }
                    break;

                    default:
                        break;
                }
                adminMenu();
                adminOption = Console.ReadLine().ToLower();
            }
            Console.WriteLine(newUserPassWord + " userPassWord");
            return newUserPassWord;
        }
        private static void adminMenu() // for futire use
        {
            string adminQuestion = "\n Please select option or type \"back\" to return in main menu";
            string adminMenu = "\n 1. Change userPassword";
            Console.WriteLine(adminQuestion + adminMenu);
        }

        private static bool isAuthorizeUser(string userPassWord)
        {
            //bool condition;
            string question = "Please enter your password: ";
            Console.WriteLine(question);
            string inputPassWord = Console.ReadLine();
            
            if (inputPassWord == userPassWord)
                return true;
            else
                return false;
        }       
        private static void ElectraXd()
        {
            string XdOptionMenu = "\nWhich developer customer will use with \"Electra XD\"\nAccredited Kodak Processing Chemistry is option 2 and 4";
            Console.WriteLine(XdOptionMenu);
            DeveloperMenu();
            string devOptionXd = Console.ReadLine().ToLower();

            while (devOptionXd != "back")
            {
                switch (devOptionXd)
                {
                    case "2"://devOptionXd XLo400
                        ElectraXdxLo400(false);
                        break;
                    case "4"://devOptionXd T300
                        ElectraXdT300();
                        break;
                    default:// devOptionXd
                        NotRecommended();
                        break;
                }
                Console.WriteLine(XdOptionMenu);
                DeveloperMenu();
                devOptionXd = Console.ReadLine().ToLower();
            } 
        } //from case 1
        private static void ElectraXdxLo400(bool isElectraMax)
        {
            Console.WriteLine("Set up parameters for \"XLo400\" and \"Electra XD\":");
            Console.Write("Please enter the avarage expouse square meter of plate per day: ");
            double avrPlateDayMax = double.Parse(Console.ReadLine());
            while (avrPlateDayMax < 1 || avrPlateDayMax > 300)// check for big or negative square meter
            {
                Console.WriteLine("Avarage square meter of expouse plate per day must be in range 1-300m²!!!");
                Console.Write("Please enter the avarage expouse square meter of plate per day: ");
                avrPlateDayMax = double.Parse(Console.ReadLine());
            }
            string replenishMode;
            if (!isElectraMax)
            {
                ReplenishModeMenu();
                replenishMode = Console.ReadLine().ToLower();
            }
            else
            {
                replenishMode = "1";
            }
            
            int ReplenishmentRates = 0;
            int antiOxReplenishmentRatesMlSmall = 75;
            double antiOxReplenishmentRatesDaySmall = 1.8;
            int antiOxReplenishmentRatesMlMiddle = 100;
            double antiOxReplenishmentRatesDayMiddle = 2.4;

            while (replenishMode != "back")
            {
                switch (replenishMode)
                {

                    case "1":// XD with xLo400 in Replenisher
                        if (avrPlateDayMax >= 1 && avrPlateDayMax <= 25)
                        {
                            ReplenishmentRates = 60;
                            antiOxReplenishmentRatesMlSmall = 85;
                            antiOxReplenishmentRatesDaySmall = 2;
                            antiOxReplenishmentRatesMlMiddle = 125;
                            antiOxReplenishmentRatesDayMiddle = 3;

                        }
                        else if (avrPlateDayMax > 25 && avrPlateDayMax <= 50)
                        {
                            ReplenishmentRates = 50;
                        }
                        else if (avrPlateDayMax > 50 && avrPlateDayMax <= 125)
                        {
                            ReplenishmentRates = 40;
                        }
                        else if (avrPlateDayMax > 125 && avrPlateDayMax <= 200)
                        {
                            ReplenishmentRates = 30;
                        }
                        else
                        {
                            NotRecommended();
                        }
                        string XdXlo400ReplenishSetup = $"\n - Developer Temperature –> 23 °C \n - Dwell Time -> 25 sec. \n - Developer Life -> 6 - 7 Weeks or Up to 4000 m²\n - Replenishment Rates -> {ReplenishmentRates}/m² \n - Anti Oxidation Replenishment Rates: \n\t*For 850-860 Processors -> {antiOxReplenishmentRatesMlSmall}ml / Hour or {antiOxReplenishmentRatesDaySmall} Litres/Day \n\t*For 1250-1350 Processors -> {antiOxReplenishmentRatesMlMiddle}ml / Hour or {antiOxReplenishmentRatesDayMiddle} Litres/Day \n -Developer filter -> 10 micron cotton wound filter: Change filter every 3000m²";
                        Console.WriteLine(XdXlo400ReplenishSetup);
                        break;


                    case "2"://Xd with xLo400 top up
                        if (avrPlateDayMax >= 1 && avrPlateDayMax <= 25)
                        {
                            ReplenishmentRates = 80;
                            antiOxReplenishmentRatesMlSmall = 85;
                            antiOxReplenishmentRatesDaySmall = 2;
                            antiOxReplenishmentRatesMlMiddle = 125;
                            antiOxReplenishmentRatesDayMiddle = 3;

                        }
                        else if (avrPlateDayMax > 25 && avrPlateDayMax <= 50)
                        {
                            ReplenishmentRates = 70;
                        }
                        else if (avrPlateDayMax > 50 && avrPlateDayMax <= 125)
                        {
                            ReplenishmentRates = 60;
                        }
                        else if (avrPlateDayMax > 125 && avrPlateDayMax < 200)
                        {
                            ReplenishmentRates = 50;
                        }
                        else
                        {
                            ReplenishmentRates = 30;
                        }
                        string XdXlo400TopUpSetup = $"\n - Developer Temperature –> 23 °C \n - Dwell Time-> 25 sec. \n - Developer Life -> 8-9 Weeks or Up to 10000 m² \n - Replenishment Rates-> { ReplenishmentRates}/ m² \n - Anti Oxidation Replenishment Rates: \n\t* For 850 - 860 Processors-> { antiOxReplenishmentRatesMlSmall}ml / Hour or { antiOxReplenishmentRatesDaySmall} Litres / Day \n\t* For 1250 - 1350 Processors-> { antiOxReplenishmentRatesMlMiddle} ml / Hour or { antiOxReplenishmentRatesDayMiddle} Litres / Day \n -Developer filter -> 10 micron cotton wound filter: Change filter every 3000m²";

                        Console.WriteLine(XdXlo400TopUpSetup);
                        break;
                    default:
                        break;
                }
                if (isElectraMax)
                {
                    Console.WriteLine("Type \"back\" to return in previous menu");
                    replenishMode = Console.ReadLine().ToLower();
                    if (replenishMode != "back")
                    {
                        replenishMode = "1";
                    }
                }
                else
                {
                    ReplenishModeMenu();
                    replenishMode = Console.ReadLine().ToLower();
                }
                
            }
        }// from case1 /case 2
        private static void ElectraXdT300()
        {
            Console.WriteLine("Set up parameters for  \"T300\" and \"Electra XD\" ");
            Console.WriteLine("\n - Developer Temperature –> 23 °C \n - Dwell Time -> 25 sec. \n - Developer Life -> 6 - 7 Weeks or Up to 4000 m²\n - Replenishment Rates -> 90-110ml/m² \n - For FM screening the replenishment rate must be set at 110ml/m² \n - Anti Oxidation Replenishment Rates: \n\t* For 850-860 Processors -> 2 Litres/Day \n\t* For 1250-1350 Processors -> 3 Litres/Day \n\t*Kodak T Processor 850 = 50ml/hr; 1250 = 75 ml/hr \n\t*G&J Interplater HD & HDX 85 = 50 ml/hr; HD & HDX 135 = 75 ml/hr \n - Developer filter -> 50 micron cotton wound filter: Change filter every 1000m²");
        }// from case1 /case 4

        private static void ElectraMax()
        {
            string plateMaxMenuQuestion = "\nWhich Developer customer will use with \"Electra Max\" plates? \nAccredited Kodak Processing Chemistry is option 1";
            Console.WriteLine(plateMaxMenuQuestion);
            DeveloperMenu();

            string devOptionMax = Console.ReadLine().ToLower();

            while (devOptionMax != "back")
            {
                switch (devOptionMax)
                {
                    case "1":// devOptionMax developer Elextra Max
                        ElectraMaxMax();
                        break;
                    default:
                        NotRecommended();
                        DeveloperMenu();
                        break;
                }
                Console.WriteLine(plateMaxMenuQuestion);
                DeveloperMenu();
                devOptionMax = Console.ReadLine().ToLower();
            }
        }//from case 2
        private static void ElectraMaxMax()
        {
            Console.WriteLine("Customer use plates \"Electra Max\" and \"Electra Max\" developer");
            Console.Write("Please enter the avarage expouse square meter of plate per day: ");
            double avrPlateDayMax = double.Parse(Console.ReadLine());
            while (avrPlateDayMax < 1 || avrPlateDayMax > 300)// check for big or negative square meter
            {
                Console.WriteLine("Avarage square meter of expouse plate per day must be in range 1-300m² ");
                avrPlateDayMax = double.Parse(Console.ReadLine());
            }
            ReplenishModeMenu();
            string replenishMode = Console.ReadLine().ToLower();

            string platesMaxSetUp = "\n - Developer Temperature –> 23 °C \n - Dwell Time -> 25 sec. \n - Developer Life -> 12-15 Weeks or Up to 12000 m² ";

            while (replenishMode != "back")
            {
                switch (replenishMode)
                {
                    case "1"://replenishMode -> Replenisher Mode
                        Console.WriteLine();
                        Console.WriteLine("\"Electra Max\" plate and \"Electra Max\" developer in Replenisher Mode: ");
                        if (avrPlateDayMax >= 1 && avrPlateDayMax < 100)
                        {
                            Console.WriteLine(" - Replenishment Rates -> 40ml/m² \n - Anti Oxidation Replenishment Rates: \n\t*For 850-860 Processors -> 70 ml/Hour and 1.7 Litres/Day \n\t*For 1250-1350 Processors -> 80 ml / Hour and 1.9 Litres/Day " + platesMaxSetUp);
                            if (avrPlateDayMax < 50)
                            {
                                Console.WriteLine(" - Developer filter -> 10 micron cotton wound filter: Change filter every 3000m²");
                            }
                            else
                            {
                                Console.WriteLine(" - Developer filter -> 50 micron cotton wound filter: Change filter every 1500m²");
                            }
                        }
                        else if (avrPlateDayMax >= 100 && avrPlateDayMax < 150)
                        {
                            Console.WriteLine(" - Replenishment Rates -> 35ml/m² \n - Anti Oxidation Replenishment Rates: \n\t*For 850-860 Processors -> 80 ml/Hour and 1.9 Litres/Day \n\t*For 1250-1350 Processors -> 90 ml / Hour and 2.2 Litres/Day " + platesMaxSetUp);
                        }
                        else if (avrPlateDayMax >= 150 && avrPlateDayMax <= 300)
                        {
                            Console.WriteLine(" - Replenishment Rates -> 30ml/m² \n - Anti Oxidation Replenishment Rates: \n\t*For 850-860 Processors -> Not recommended \n\t*For 1250-1350 Processors -> 100 ml/Hour and 2.4 Litres/Day " + platesMaxSetUp);
                        }
                        break;

                    case "2"://replenishMode-> Top Up Mode
                        Console.WriteLine();
                        Console.WriteLine("\"Electra Max plate\" and \"Electra Max\" developer in Top Up Mode:");
                        if (avrPlateDayMax >= 1 && avrPlateDayMax < 100)
                        {
                            Console.WriteLine(" - Replenishment Rates -> 80ml/m² \n - Anti Oxidation Replenishment Rates: \n      *For 850-860 Processors -> 70 ml/Hour and 1.7 Litres/Day \n      *For 1250-1350 Processors -> 80 ml / Hour and 1.9 Litres/Day " + platesMaxSetUp);
                            if (avrPlateDayMax < 50)
                            {
                                Console.WriteLine(" - Developer filter -> 10 micron cotton wound filter: Change filter every 3000m²");
                            }
                            else
                            {
                                Console.WriteLine(" - Developer filter -> 50 micron cotton wound filter: Change filter every 1500m²");
                            }
                        }
                        else if (avrPlateDayMax >= 100 && avrPlateDayMax < 150)
                        {
                            Console.WriteLine(" - Replenishment Rates -> 70ml/m² \n - Anti Oxidation Replenishment Rates: \n      *For 850-860 Processors -> 80 ml/Hour and 1.9 Litres/Day \n      *For 1250-1350 Processors -> 90 ml / Hour and 2.2 Litres/Day " + platesMaxSetUp);
                        }
                        else if (avrPlateDayMax >= 150 && avrPlateDayMax <= 300)
                        {
                            Console.WriteLine(" - Replenishment Rates -> 60ml/m² \n - Anti Oxidation Replenishment Rates: \n      *For 850-860 Processors -> Not recommended \n      *For 1250-1350 Processors -> 100 ml/Hour and 2.4 Litres/Day " + platesMaxSetUp);
                        }
                        break;
                    default:
                        ReplenishModeMenu();
                        break;
                }
                ReplenishModeMenu();
                replenishMode = Console.ReadLine().ToLower();
            }
        }//form case 2/ case 1

        private static void CapricornVt()
        {
            string plateCapVtMenuQuestion = "\nWhich Developer customer will use with \"Capricorn VT\" plates? \nAccredited Kodak Processing Chemistry is option 3.";

            Console.WriteLine(plateCapVtMenuQuestion);
            DeveloperMenu();
            string devOptionCapVt = Console.ReadLine().ToLower();

            while (devOptionCapVt != "back")
            {
                switch (devOptionCapVt)
                {
                    case "3":
                        CapricornVtGoldStar();
                        break;

                    default:
                        NotRecommended();
                        Console.WriteLine();
                        Console.WriteLine(plateCapVtMenuQuestion);
                        break;
                }
                DeveloperMenu();
                devOptionCapVt = Console.ReadLine().ToLower();
            }
        }//from case 3
        private static void CapricornVtGoldStar()
        {
            Console.WriteLine("Customer use plates \"Capricorn VT\" and \"Goldstar\" Developer");
            ReplenishModeMenu();
            string replenishMode = Console.ReadLine().ToLower();
            string capVtSetUp = "\n - Developer Temperature –> 23 °C \n - Dwell Time -> 36 sec. \n - Developer Life -> 6-7 Weeks or Up to 4000 m² \n - Anti-oxidation replenishment: \n\t*Kodak Mercury T-HD Processor 850 = 2 litres / 24-hour period \n\t*Kodak Mercury T-HD Processor 1250 = 3 litres / 24-hour period \n\t*Kodak T Processor 850 = 50ml/hr; 1250 = 75 ml/hr \n\t*G&J Interplater HD & HDX 85 = 50 ml/hr; HD & HDX 135 = 75 ml/hr \n - Developer filter -> 50 micron cotton wound filter: Change filter every 1000m²";
            while (replenishMode != "back")
            {
                switch (replenishMode)
                {
                    case "1":
                        Console.WriteLine("this is caseReplenisher Mode::");
                        Console.WriteLine(" - Replenishment Rates -> 80-100ml/m² \n - FM screening the replenishment rate must be set at 100 ml /m2. " + capVtSetUp);
                        break;
                    case "2":
                        Console.WriteLine("this is case . Top Up Mode");
                        Console.WriteLine(" - Replenishment Rates -> 100ml-120/m² \n - For FM screening only replenish with Goldstar Premium Replenisher" + capVtSetUp);
                        break;
                    default:
                        break;
                }
                ReplenishModeMenu();
                replenishMode = Console.ReadLine().ToLower();
            }
        }//from case 3 /case 3

        private static void ThermalPt()
        {
            Console.WriteLine(" Customer use plates \"ThermalNews PT\" and \"SP500 Plate Solution\" Developer in Top Up Mode");
            Console.WriteLine("\n - Replenishment Rates -> 30-50/m² \n - Developer Temperature –> 25 °C \n - Dwell Time -> 17 sec. \n - Developer Life -> 8 Weeks or Up to 3500 m² \n - Anti-oxidation replenishment: Solution: Not required \n - Developer filter -> 50 micron cotton wound filter: Change filter every 500-1000m²");
        }//from case 4

        private static void DualProcessing()
        {
            Console.WriteLine("Use only in \"Replenisher Mode\". \"Top Up Mode is not Recommended\"");
            ElectraXdxLo400(true);
        }//from case 5

        private static void MainMenu()
        {
            string mainMenu = "\nWhich type of Plates customer will use: \nPlease select option form 1 to 5; Type \"Exit\" for close the program \n 1. Electra XD\n 2. Electra Max \n 3. Capricorn VT \n 4. ThermalNews PT\n 5. Dual Processing Electra XD and Electra MAX";
            Console.WriteLine(mainMenu);
        }
        private static void DeveloperMenu()
        {
            Console.WriteLine("\nPlease select option or type \"back\" to return in main menu");
            string developerMenu = "\n 1.Elextra Max Solution \n 2.400 xLo Solution \n 3.Goldstar Premium \n 4.T300 Developer \n 5.SP500 Plate Solution";
            Console.WriteLine(developerMenu); 
        }
        private static void ReplenishModeMenu()
        {
            Console.WriteLine("\nPlease select option form 1 or 2; Type \"back\" to return in previous menu");
            string replenishModeMenu = "1. Replenisher Mode \n2. Top Up Mode";
            Console.WriteLine(replenishModeMenu);
        }
        private static void NotRecommended()
        {
            Console.WriteLine("\n***** This is not recommended case! *****");
        }
    }
}
