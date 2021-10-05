using System;

namespace Array_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {
                   "1. Justin",
                   "2. Matt",
                    "3. Logan",
                   "4. Raston",
                   "5. Yousif",
                   "6. Yash",
                   "7. Chris",
                   "8. Radeen",
                   "9. Josh",
                   "10. Aron",
                   "11. Kasean",
                   "12. Scott",
                   "13. Delmar",
                   "14. Brandon"
                   };
            string[] hometown =
            {
                "Wyoming, MI",
                "Flint, MI",
                "Plymouth, MI",
                "Zeeland, MI",
                "Oak Park, MI",
                "Detroit, MI",
                "Novi, MI",
                "Warren, MI",
                "Northville, MI",
                "Berea. KY",
                "Detroit, MI",
                "Lansing, MI",
                "Detroit, MI",
                "Novi, MI",
            };
            string[] favFood =
            {
                "Baja Blast",
                "How Wings",
                "Fuyuns",
                "Vanilla Instant Pudding",
                "Deep Dish Pizza",
                "Hot Cheeto Puffs",
                "Tacos",
                "Mexican",
                "Naleśniki",
                "Sushi",
                "Steak",
                "Nashville Chickn",
                "Vietnamese Food",
                "Sushi",
            };
            

            foreach (string student in names)
            {
                Console.WriteLine($"{student}");
            }
            
            bool runProgram = true;
            
            while (runProgram)
            {
                bool validInput = false;
                bool validInfo = false;

                while (!validInput)
                {
                    Console.WriteLine("Please enter a student number: ");
                    string selectedStudent = Console.ReadLine();
                    int i;
                    bool success = int.TryParse(selectedStudent, out i);
                    if (success == true && 0 < i && i < 15)
                    {
                        int studentNumber = int.Parse(selectedStudent) - 1;
                        validInput = true;
                        Console.WriteLine($"You have selected {names[studentNumber].Substring(3)}.");
                                              
                        
                        while (!validInfo)
                        {
                            Console.WriteLine($"What would you like to know about {names[studentNumber].Substring(3)}?" +
                               $"\nPlease enter hometown or favorite food.");
                            string wannaKnow = Console.ReadLine();
                           
                            
                            if (wannaKnow == "hometown")
                            {
                                Console.WriteLine($"{names[studentNumber].Substring(3)}'s hometown is {hometown[studentNumber]}");
                                if (knowMore() == true)
                                {
                                    validInfo = false;
                                }
                                else
                                {
                                    Console.WriteLine("Okay, you are leaving this student's profile and may select a new one");
                                    validInfo = true;
                                }

                            }


                            else if (wannaKnow == "favorite food")
                            {
                                Console.WriteLine($"{names[studentNumber].Substring(3)}'s favorite food is {favFood[studentNumber]}");
                                if (knowMore() == true)
                                {
                                    validInfo = false;
                                }
                                else
                                {
                                    Console.WriteLine("Okay, you are leaving this student's profile and may select a new one");
                                    validInfo = true;
                                }

                            }
                           
                            
                            else
                            {
                                Console.WriteLine("We do not have that information. Please try again");
                            }
                           

                            }
                        }
                    
                    else
                    {
                        Console.WriteLine("We do not have record of that student.");
                        validInput = false;
                    }


                }
                
                if(knowMore()==true)
                {
                    runProgram = true;
                }
                else
                {
                    runProgram = false;
                }
                
                }




            }
        static bool knowMore()
        {
            bool validEntry = false;
            bool response = true;
            while (validEntry == false)
            {
      
                Console.WriteLine("Would you like to know more? Y / N");
                string entry = Console.ReadLine().ToLower();

                if (entry == "y")
                {
                    validEntry = true;
                    response = true;

                }

                else if (entry == "n")
                {
                    validEntry = true;
                    response = false;

                }

                else
                {
                    Console.WriteLine("Invalid Input. Please try again");

                }
                
            }
            return response;
           
        }
    }
       
    }


