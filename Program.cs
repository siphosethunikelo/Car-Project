namespace LMS_Day29_Car_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Name: Siphosethu
             Name: Muji
             Name: Brandon
             */
            string[] province =
                {
                "western cape",
                "northern cape",
                "Free state",
                "Guateng",
                "Mpumalanga",
                "North west",
                "KwaZulu-Natal",
                "Limpopo",
                "Eastern Cape"
            };


            string[][] car1 = new string[3][]
            {
                new string []{"Bmw"},
                new string []{"E92","E90","X5","M2","E36"},
                new string []{"2018","1995","2009","2016","1990" }
            };

            string[][] car2 = new string[3][]
            {
                new string []{"Toyota"},
                new string []{"Fortuner","Hilux","Yaris","Rav4","Corolla" },
                new string []{"2013","2019","2009","2016","1999" }
            };

            string[][] car3 = new string[3][]
            {
                new string []{"Audi"},
                new string []{"A3","A5 Hatchback","Quattro","RS3","RS5"},
                new string []{"2018","2000","2019","2011","2022" }
            };
            string[][] car4 = new string[4][]
            {
                new string []{ "Mercedes Benz" },
                new string []{"AMG C63","AMG G-Wagon"},
                new string []{"2012","2019"},
                new string []{"R250,000.00","R1500000.00"},

            };
            string[][] car5 = new string[4][]
            {
                new string []{"Honda"},
                new string []{"Civic","Accord","Odyssey"},
                new string []{"1999","2010","2022"},
                new string []{ null},

            };
            string[][] car6 = new string[4][]
            {
                new string[]{"Nissan"},
                new string[]{"Sentra","Silvia","350Z","Skyline R34"},
                new string[]{"2000","1983","2008","1999"},
                new string[]{null}
            };
            string[][] car7 = new string[4][]
            {
                new string[]{"Volkswagen"},
                new string[]{ "Golf 5", "Golf 7", "Polo Gti", "Tiguan"},
                new string[]{"2006","2018","2019","2020"},
                new string[]{null}
            };

            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("======================================================================");
            Console.WriteLine("\t\tSipBraMuj & Co Car Browser Solutions".ToUpper());
            Console.WriteLine("======================================================================\n");

            Console.Write("Good Day\nPlease enter your name and ID Number: ");
            string fname = Console.ReadLine();
            string IdNum = Console.ReadLine();
           
            // substringing first name to convert to Uppercase
            string fnme = fname.Substring(0,1);
            fnme = fnme.ToUpper();
            string endNme = fname.Substring(1);
            string upperNme = fnme + endNme;

            // Creating a unique logging name 
            string frstTwoChar = fname.Substring(0, 2);
            frstTwoChar = frstTwoChar.ToUpper();
            string threeCharId = IdNum.Substring(0, 3);
            string uniId = frstTwoChar + threeCharId;
            Console.WriteLine();
            Console.WriteLine($"Good day {fname},\nWelcome to SipBraMuj & Co Car Browser Solutions\nHere is your unique Id {uniId} when logging into our website.");
            Console.WriteLine("======================================================================\n");

            string userinput = "yes";
            userinput = userinput.ToUpper();

            while (userinput == "Y" || userinput == "YES" || userinput == "yes"|| userinput=="Yes")
            {
                Console.WriteLine("These are all the provinces you can browser or purchase a car from.");
                foreach (string prov in province)
                {
                    Console.WriteLine(prov);
                }
                Console.WriteLine("======================================================================\n");
                Console.Write("What province are you looking to purchase a car from: ");
                string vLoc = Console.ReadLine();

                if (vLoc == province[0])
                {
                    Console.Write($"Here are your options for {province[0]}\n");

                    foreach (string CarValue in car1[0])
                    {
                        Console.WriteLine(CarValue);
                        foreach (string Carvale in car2[0])
                            Console.WriteLine(Carvale);
                    }
                    Console.WriteLine("======================================================================\n");
                    Console.Write($"What car brand are you picking: ");
                    string carBrand = Console.ReadLine();
                    Console.WriteLine("======================================================================\n");
                    if (carBrand == car1[0][0])
                    {
                        Console.WriteLine($"You picked a {car1[0][0]}\nHere are your options for a {car1[0][0]}");
                        for (int row = 0; row < car1.Length; row++)
                        {

                            for (int col = 0; col < car1[row].Length; col++)
                            {
                                Console.Write(string.Format("{0,-15}", car1[row][col]));

                            }
                            Console.WriteLine();
                        }
                        Console.Write($"What type of {car1[0][0]}: ");
                        string bmwType = Console.ReadLine();

                        if (bmwType == car1[1][0])
                        {
                            Console.WriteLine($"You picked a {car1[0][0]} {car1[1][0]} {car1[2][0]} model");

                        }
                        else if (bmwType == car1[1][1])
                        {
                            Console.WriteLine($"You picked a {car1[0][0]} {car1[1][1]} {car1[2][1]} model");
                        }
                        else if (bmwType == car1[1][2])
                        {
                            Console.WriteLine($"You picked a {car1[0][0]} {car1[1][2]} {car1[2][2]} model");
                        }
                        else if (bmwType == car1[1][3])
                        {
                            Console.WriteLine($"You picked a {car1[0][0]} {car1[1][3]} {car1[2][3]} model");
                        }
                        else
                        {
                            Console.WriteLine($"You picked a {car1[0][0]} {car1[1][4]} {car1[2][4]} model");
                        }
                    }

                    

                    else if (carBrand == car2[0][0])
                    {
                        Console.WriteLine($"You picked a {car2[0][0]}\nHere are your options for a {car2[0][0]}");
                        for (int row = 0; row < car2.Length; row++)
                        {

                            for (int col = 0; col < car2[row].Length; col++)

                                Console.Write(string.Format("{0,-15}", car2[row][col]));


                            Console.WriteLine();
                        }


                        Console.Write($"What type of {car2[0][0]}:  ");
                        string toyType = Console.ReadLine();

                        if (toyType == car2[1][0])
                        {
                            Console.WriteLine($"You picked a {car2[0][0]} {car2[1][0]} {car2[2][0]} model");

                        }
                        else if (toyType == car2[1][1])
                        {
                            Console.WriteLine($"You picked a {car2[0][0]} {car2[1][1]} {car2[2][1]} model");
                        }
                        else if (toyType == car2[1][2])
                        {
                            Console.WriteLine($"You picked a {car2[0][0]} {car2[1][2]} {car2[2][2]} model");
                        }
                        else if (toyType == car2[1][3])
                        {
                            Console.WriteLine($"You picked a {car2[0][0]} {car2[1][3]} {car2[2][3]} model");
                        }
                        else
                        {
                            Console.WriteLine($"You picked a {car2[0][0]} {car2[1][4]} {car2[2][4]} model");
                        }
                    }
                    Console.WriteLine("======================================================================\n");
                }
                else if (vLoc == province[1])
                {

                    Console.Write($"There are only {car3[0][0]}'s available in the {province[1]}'\n");
                    Console.WriteLine();
                    for (int row = 0; row < car3.Length; row++)
                    {

                        for (int col = 0; col < car3[row].Length; col++)

                            Console.Write(string.Format("{0,-15}", car3[row][col] + " "));


                        Console.WriteLine();
                    }
                    Console.Write($"What car brand are you picking: ");
                    string car2Brand = Console.ReadLine();
                    if (car2Brand == car3[1][0])
                    {
                        Console.WriteLine($"You picked a {car3[0][0]} {car3[1][0]} {car3[2][0]} model");

                    }
                    else if (car2Brand == car3[1][1])
                    {
                        Console.WriteLine($"You picked a {car3[0][0]} {car3[1][1]} {car3[2][1]} model");
                    }
                    else if (car2Brand == car3[1][2])
                    {
                        Console.WriteLine($"You picked a {car3[0][0]} {car3[1][2]} {car3[2][2]} model");
                    }
                    else if (car2Brand != car3[1][3])
                    {
                        Console.WriteLine($"You picked a {car3[0][0]} {car3[1][3]} {car3[2][3]} model");
                    }
                    else
                    {
                        Console.WriteLine($"You picked a {car3[0][0]} {car3[1][4]} {car3[2][4]} model");
                    }
                    Console.WriteLine("======================================================================\n");
                }

                else if (vLoc == province[2])
                {
                    Console.Write($"There are only {car2[0][0]}'s available in the {province[2]}'\n");
                    Console.WriteLine();
                    for (int row = 0; row < car2.Length; row++)
                    {

                        for (int col = 0; col < car2[row].Length; col++)

                            Console.Write(string.Format("{0,-15}", car2[row][col] + " "));


                        Console.WriteLine();
                    }
                    Console.Write($"What type of {car2[0][0]} are you interested: ");
                    string car2Brand = Console.ReadLine();
                    if (car2Brand == car2[1][0])
                    {
                        Console.WriteLine($"You picked a {car2[0][0]} {car2[1][0]} {car2[2][0]} model");

                    }
                    else if (car2Brand == car2[1][1])
                    {
                        Console.WriteLine($"You picked a {car2[0][0]} {car2[1][1]} {car2[2][1]} model");
                    }
                    else if (car2Brand == car2[1][2])
                    {
                        Console.WriteLine($"You picked a {car2[0][0]} {car2[1][2]} {car2[2][2]} model");
                    }
                    else if (car2Brand == car2[1][3])
                    {
                        Console.WriteLine($"You picked a {car2[0][0]} {car2[1][3]} {car2[2][3]} model");
                    }
                    else
                    {
                        Console.WriteLine($"You picked a {car2[0][0]} {car2[1][4]} {car2[2][4]} model");
                    }
                    Console.WriteLine("======================================================================\n");
                }
                else if (vLoc == province[3])
                {
                    Console.Write($"There are only {car5[0][0]}'s available in the {province[3]}'\n");
                    Console.WriteLine();
                    for (int row = 0; row < car5.Length; row++)
                    {

                        for (int col = 0; col < car5[row].Length; col++)

                            Console.Write(string.Format("{0,-15}", car5[row][col] + " "));


                        Console.WriteLine();
                    }
                    Console.Write($"What type of {car5[0][0]} are you interested: ");
                    string carBranProv3 = Console.ReadLine();
                    if (carBranProv3 == car5[1][0])
                    {
                        Console.WriteLine($"You picked a {car5[0][0]} {car5[1][0]} {car5[2][0]} model");
                    }
                    else if (carBranProv3 == car5[1][1])
                    {
                        Console.WriteLine($"You picked a {car5[0][0]} {car5[1][1]} {car5[2][1]} model");
                    }
                    else
                    {
                        Console.WriteLine($"You picked a {car5[0][0]} {car5[1][2]} {car5[2][2]} model");
                    }
                    Console.WriteLine("======================================================================\n");
                }
                else if (vLoc == province[4])
                {
                    //starting point
                    Console.Write($"Here are your options for {province[4]}\n");
                    foreach (string CarValue in car5[0])
                    {
                        Console.WriteLine(CarValue);
                        foreach (string Carvale in car6[0])
                            Console.WriteLine(Carvale);
                    }
                    Console.Write($"What car brand are you picking: ");
                    string CarBranProv4 = Console.ReadLine();
                    if (CarBranProv4 == car5[0][0])
                    {


                        Console.WriteLine($"You picked a {car5[0][0]}\nHere are your options for a {car5[0][0]}");
                        for (int row = 0; row < car1.Length; row++)
                        {

                            for (int col = 0; col < car5[row].Length; col++)
                            {
                                Console.Write(string.Format("{0,-15}", car5[row][col]));

                            }
                            Console.WriteLine();
                        }
                        Console.Write($"What type of {car5[0][0]} : ");
                        string vCar5Prov4 = Console.ReadLine();

                        if (vCar5Prov4 == car5[1][0])
                        {
                            Console.WriteLine($"You picked a {car5[0][0]} {car5[1][0]} {car5[2][0]} model ");

                        }
                        else if (vCar5Prov4 == car5[1][1])
                        {
                            Console.WriteLine($"You picked a {car5[0][0]} {car5[1][1]} {car5[2][1]} model");
                        }
                        else
                        {
                            Console.WriteLine($"You picked a {car5[0][0]} {car5[1][2]} {car5[2][2]} model");
                        }
                        Console.WriteLine("======================================================================\n");
                    }

                    else if (CarBranProv4 == car6[0][0])
                    {
                        Console.WriteLine($"You picked a {car6[0][0]}\nHere are your options for a {car6[0][0]}");
                        for (int row = 0; row < car6.Length; row++)
                        {

                            for (int col = 0; col < car6[row].Length; col++)

                                Console.Write(string.Format("{0,-15}", car6[row][col]));


                            Console.WriteLine();
                        }


                        Console.Write($"What type of {car6[0][0]}:  ");
                        string vCar6Prov4 = Console.ReadLine();

                        if (vCar6Prov4 == car6[1][0])
                        {
                            Console.WriteLine($"You picked a {car6[0][0]} {car6[1][0]} {car6[2][0]} model");

                        }
                        else if (vCar6Prov4 == car6[1][1])
                        {
                            Console.WriteLine($"You picked a {car6[0][0]} {car6[1][1]} {car6[2][1]} model");
                        }
                        else 
                        {
                            Console.WriteLine($"You picked a {car6[0][0]} {car6[1][2]} {car6[2][2]} model");
                        }
                    }Console.WriteLine("======================================================================\n");
                   
                }
                else if (vLoc == province[5])
                {
                    Console.WriteLine($"Due to the high fuel prices our company are unable to deliver cars to {province[5]}");
                }
                else if (vLoc == province[6])
                {
                    Console.WriteLine($"Due to the looting that occured in 2021 in {province[6]}\nour company are unable to take the risk to deliver cars to {province} ");
                }
                                                                                                               
                else if (vLoc == province[7])
                {
                    Console.Write($"There are only {car4[0][0]}'s available in the {province[7]}'\n");
                    Console.WriteLine();
                    for (int row = 0; row < car4.Length; row++)
                    {

                        for (int col = 0; col < car4[row].Length; col++)

                            Console.Write(string.Format("{0,-15}", car4[row][col] + " "));


                        Console.WriteLine();
                    }
                    Console.Write($"What type of {car4[0][0]} are you interested: ");
                    string vCar4Prov7 = Console.ReadLine();
                    if (vCar4Prov7 == car4[1][0])
                    {
                        Console.WriteLine($"You picked a {car4[0][0]} {car4[1][0]} {car4[2][0]} model\nWhich will cost you {car4[3][0]}");
                    }
                    else
                    {
                        Console.WriteLine($"You picked a {car4[0][0]} {car4[1][1]} {car4[2][1]} model\nWhich will cost you {car4[3][1]}");
                    }
                    Console.WriteLine("======================================================================\n");
                }
                else
                // starting point
                {
                    Console.WriteLine($"Here are your options for {province[8]} ");

                    foreach (string CarValue in car6[0])

                    {
                        Console.WriteLine(CarValue);
                        foreach (string Carvale in car7[0])
                            Console.WriteLine(Carvale);
                    }
                    Console.Write($"What car brand are you picking: ");
                    string CarBranProv8 = Console.ReadLine();
                    if (CarBranProv8 == car6[0][0])
                    {
                        Console.WriteLine($"You picked a {car6[0][0]}\nHere are your options for a {car6[0][0]}");
                        for (int row = 0; row < car6.Length; row++)
                        {

                            for (int col = 0; col < car6[row].Length; col++)
                            {
                                Console.Write(string.Format("{0,-15}", car6[row][col]));

                            }
                            Console.WriteLine();
                        }
                        Console.Write($"What type of {car6[0][0]}: ");
                        string vCar5Prov8 = Console.ReadLine();

                        if (vCar5Prov8 == car6[1][0])
                        {
                            Console.WriteLine($"You picked a {car6[0][0]} {car6[1][0]} {car6[2][0]} model ");

                        }
                        else if (vCar5Prov8 == car6[1][1])
                        {
                            Console.WriteLine($"You picked a {car6[0][0]} {car6[1][1]} {car6[2][1]} model");
                        }
                        else
                        {
                            Console.WriteLine($"You picked a {car6[0][0]} {car6[1][2]} {car6[2][2]} model");
                        }

                    }
                    else 
                    {
                        Console.WriteLine($"You picked a {car7[0][0]}\nHere are your options for a {car7[0][0]}");
                        for (int row = 0; row < car7.Length; row++)
                        {

                            for (int col = 0; col < car7[row].Length; col++)

                                Console.Write(string.Format("{0,-15}", car7[row][col]));


                            Console.WriteLine();
                        }


                        Console.Write($"What type of {car7[0][0]}: ");
                        string vCar5Prov8 = Console.ReadLine();

                        if (vCar5Prov8 == car7[1][0])
                        {
                            Console.WriteLine($"You picked a {car7[0][0]} {car7[1][0]} {car7[2][0]} model");

                        }
                        else if (vCar5Prov8 == car7[1][1])
                        {
                            Console.WriteLine($"You picked a {car7[0][0]} {car7[1][1]} {car7[2][1]} model");
                        }
                        else if(vCar5Prov8 == car7[1][2])
                        {
                            Console.WriteLine($"You picked a {car7[0][0]} {car7[1][3]} {car7[2][2]} model");
                        }
                        else if (vCar5Prov8 == car7[1][3])
                        {
                            Console.WriteLine($"You picked a {car7[0][0]} {car7[1][3]} {car7[2][3]} model");
                        }
                        else 
                        {
                            Console.WriteLine($"You picked a {car7[0][0]} {car7[1][4]} {car7[2][4]} model");
                        }


                    }
                    

                }

                Console.WriteLine();
                Console.Write("Do you want to carry on browsing Yes or No: ");
                userinput = Console.ReadLine();
                Console.WriteLine();
            }
            Console.WriteLine($"Thank you,\n{upperNme} for using SipBraMuj & Co Car Browser Solutions\nPlease leave a review or suggestion on how we can improve our website.");
        }
    }
}


