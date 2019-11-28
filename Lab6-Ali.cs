using System;

namespace Lab6_Week6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[12];

            Console.WriteLine("{0}{1,15}", "Index", "Month");
            {
                String[] month = new string[12];
                month[0] = "January";
                month[1] = "Febraury";
                month[2] = "March";
                month[3] = "April";
                month[4] = "May";
                month[5] = "June";
                month[6] = "July";
                month[7] = "August";
                month[8] = "September";
                month[9] = "October";
                month[10] = "November";
                month[11] = "December";
                {
                    for (int i = 0; i < 12; i++)
                    {
                        Console.WriteLine(month[i]);
                    }



                }
                {
                    {
                        string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };
                        Console.WriteLine("The Four Seasons");
                        foreach (string season in seasons)
                        {
                            Console.WriteLine(season);

                        }
                        {
                            {


                                int[] randomNumber = new int[1000]; Random random = new Random();
                                for (int i = 0; i < randomNumber.Length; i++)
                                { randomNumber[i] = random.Next(0, 100); }
                                foreach (int i in randomNumber)
                                {
                                    Console.WriteLine(i.ToString());


                                }
                                {
                                    string[] names = { "Allen", "Andy War", "Larry Bird", "Ginger Ale", "Tom Ford" };

                                    int i = 0;
                                    while (i < names.Length)
                                    {
                                        Console.WriteLine(names[i]);
                                        i++;
                                    }
                                    {
                                        string[] name = { "Allen", "Andy War", "Larry Bird", "Ginger Ale", "Tom Ford" };

                                        int i = 0;
                                        while (i < names.Length)
                                        {
                                            Console.WriteLine("{0,2}. {1}", i, names[i]);
                                            i++;
                                        }
                                        {
                                            string[] names = { "Allen", "Andy War", "Larry Bird", "Ginger Ale", "Tom Ford" };

                                            int i = 0;
                                            foreach (string name in names)
                                            {
                                                Console.WriteLine("{0,2}. {1}", i, names[i]);
                                                i++;
                                            }

                                        }


                                    }

                                }



                            }
                        }
                    }
                }
            }
        }
    }
}

    //Question 1. 0,1,2,3
