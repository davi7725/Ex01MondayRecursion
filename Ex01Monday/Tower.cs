using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Monday
{
    class Tower
    {
        Disk[] disks;
        int index = 0;

        public Tower(int size)
        {
            disks = new Disk[size];
        }

        public bool Remove(Disk diskObj)
        {
            bool couldRemove = false;

            for (int i = 0; i < index; i++)
            {
                if (disks[i].Size == diskObj.Size)
                {
                    couldRemove = true;
                    disks[i] = null;
                }
            }

            if (couldRemove == true)
            {
                index--;
            }

            return couldRemove;
        }

        public Disk RemoveLast()
        {
            Disk returningDisk = null;

            if (index > 0)
            {
                returningDisk = disks[index - 1];
                disks[index - 1] = null;
                index--;
            }

            return returningDisk;
        }

        public bool Insert(Disk diskObj)
        {
            bool couldInsert = false;
            if (index == 0)
            {
                disks[index] = diskObj;
                couldInsert = true;
            }
            else
            {
                if (disks[index - 1].Size > diskObj.Size)
                {
                    disks[index] = diskObj;
                    couldInsert = true;
                }
            }

            if (couldInsert == true)
            {
                index++;
            }

            return couldInsert;
        }

        public void PrintTower()
        {

            Console.WriteLine("BEGINNING OF TOWER");
            foreach (Disk d in disks)
            {
                if (d != null)
                {
                    Console.WriteLine(d.Size);
                }
            }
            Console.WriteLine("END OF TOWER");
        }
    }
}
