using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Monday
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProg = new Program();
            myProg.Run();
        }

        private void Run()
        {
            Tower[] towersBegin = new Tower[3];

            for(int i = 0; i< towersBegin.Length; i++)
            {
                towersBegin[i] = new Tower(3);
            }

            Disk disk1 = new Disk(1);
            Disk disk2 = new Disk(2);
            Disk disk3 = new Disk(3);

            towersBegin[0].Insert(disk3);
            towersBegin[0].Insert(disk2);
            towersBegin[0].Insert(disk1);


            /******/
            
            int pos1 = 0;
            int pos2 = 0;
            int pos3 = 0;

            bool incrementing1 = true;
            bool incrementing2 = true;
            bool incrementing3 = true;

            int counter = 1;
            /*
            while(pos3 != 2 || pos2 != 2 || pos1 != 2)
            {
                if (counter == 1 ||counter == 3)
                {
                    int prevPos = pos1;
                    if (incrementing1 == true)
                    {
                        pos1++;

                        towers[pos1].Insert(towers[prevPos].RemoveLast());
                        if(pos1 == 2)
                        {
                            incrementing1 = false;
                        }
                    }
                    else
                    {
                        pos1--;
                        towers[pos1].Insert(towers[prevPos].RemoveLast());
                        if(pos1 == 0)
                        {
                            incrementing1 = true;
                        }
                    }
                }
                else if(counter == 2)
                {
                    int prevPos = pos2;
                    if (incrementing2 == true)
                    {
                        pos2 = pos2 +2;

                        towers[pos2].Insert(towers[prevPos].RemoveLast());

                        if (pos2 == 2)
                        {
                            incrementing2 = false;
                        }
                    }
                    else
                    {
                        pos2 = pos2 -2;
                        towers[pos2].Insert(towers[prevPos].RemoveLast());
                        if (pos2 == 0)
                        {
                            incrementing2 = true;
                        }
                    }
                }
                else if (counter == 4)
                {
                    int prevPos = pos3;
                    if (incrementing3 == true)
                    {
                        pos3++;

                        towers[pos3].Insert(towers[prevPos].RemoveLast());

                        if (pos3 == 3)
                        {
                            incrementing3 = false;
                        }
                    }
                    else
                    {
                        pos3--;
                        towers[pos3].Insert(towers[prevPos].RemoveLast());
                        if (pos3 == 0)
                        {
                            incrementing3 = true;
                        }
                    }
                    
                }
                counter++;
                if (counter == 5)
                {
                    counter = 1;
                }
            }
            */

            towersBegin[0].PrintTower();
            towersBegin[2].PrintTower();
            Tower[] towers = hanoi(towersBegin, pos1, pos2, pos3, counter, incrementing1, incrementing2, incrementing3);
            towers[0].PrintTower();
            towers[2].PrintTower();
            Console.ReadKey();
        }

        public Tower[] hanoi(Tower[] towers, int pos1, int pos2, int pos3, int counter,bool incrementing1, bool incrementing2, bool incrementing3)
        {
            if (counter == 1 || counter == 3)
            {
                int prevPos = pos1;
                if (incrementing1 == true)
                {
                    pos1++;

                    towers[pos1].Insert(towers[prevPos].RemoveLast());
                    if (pos1 == 2)
                    {
                        incrementing1 = false;
                    }
                }
                else
                {
                    pos1--;
                    towers[pos1].Insert(towers[prevPos].RemoveLast());
                    if (pos1 == 0)
                    {
                        incrementing1 = true;
                    }
                }
            }
            else if (counter == 2)
            {
                int prevPos = pos2;
                if (incrementing2 == true)
                {
                    pos2 = pos2 + 2;

                    towers[pos2].Insert(towers[prevPos].RemoveLast());

                    if (pos2 == 2)
                    {
                        incrementing2 = false;
                    }
                }
                else
                {
                    pos2 = pos2 - 2;
                    towers[pos2].Insert(towers[prevPos].RemoveLast());
                    if (pos2 == 0)
                    {
                        incrementing2 = true;
                    }
                }
            }
            else if (counter == 4)
            {
                int prevPos = pos3;
                if (incrementing3 == true)
                {
                    pos3++;

                    towers[pos3].Insert(towers[prevPos].RemoveLast());

                    if (pos3 == 3)
                    {
                        incrementing3 = false;
                    }
                }
                else
                {
                    pos3--;
                    towers[pos3].Insert(towers[prevPos].RemoveLast());
                    if (pos3 == 0)
                    {
                        incrementing3 = true;
                    }
                }

            }
            counter++;
            if (counter == 5)
            {
                counter = 1;
            }

            if(pos1 != 2 || pos2 != 2 || pos3!=2)
            {
               hanoi(towers, pos1, pos2, pos3, counter, incrementing1, incrementing2, incrementing3);
            }

            return towers;
        }
    }
}
