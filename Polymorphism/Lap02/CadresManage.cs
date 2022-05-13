using System;
using System.Collections.Generic;
using System.Text;

namespace Lap02
{
    internal class CadresManage
    {
        internal Cadres[] cadresList;
        internal int MaxCadres;
        internal int NextCadres;
        internal CadresManage()
        {
            cadresList = new Cadres[MaxCadres];
            NextCadres = 0;
            MaxCadres = 100;
        }
        internal CadresManage(Cadres[] cadres, int maxCadres, int nextCadres)
        {
            cadresList = cadres;
            MaxCadres = maxCadres;
            NextCadres = nextCadres;
        }
        internal void addCadres()
        {
            if (NextCadres == MaxCadres)
            {
                Console.WriteLine("Can't add Cadres");
            }
            else
            {
                Console.WriteLine("Add Staff: 0\nAdd Engineer: 1\nAdd Worker: 2\n");
                int type = int.Parse(Console.ReadLine());
                switch (type)
                {
                    case 0:
                        Staff staff = new Staff();
                        staff.inputInfo();
                        cadresList[NextCadres] = staff;
                        NextCadres++;
                        break;
                    case 1:
                        Engineer engineer = new Engineer();
                        engineer.inputInfo();
                        cadresList[NextCadres] = engineer;
                        NextCadres++;
                        break;
                    case 2:
                        Worker worker = new Worker();
                        worker.inputInfo();
                        cadresList[NextCadres] = worker;
                        NextCadres++;
                        break;
                }
            }
        }

        internal void printCadres()
        {
            for (int i = 0; i < NextCadres; i++)
            {
                cadresList[i].showInfo();
            }
        }

        internal void printEngineer()
        {
            for (int i = 0; i < NextCadres; i++)
            {
                if (cadresList[i].GetType() == typeof(Engineer))
                {
                    cadresList[i].showInfo();
                }
            }
        }

        internal void searchByID(string id)
        {
            for (int i = 0; i < NextCadres; i++)
            {
                if (cadresList[i].Id.Equals(id))
                {
                    cadresList[i].showInfo();
                }
            }
                
        }

        internal void searchByName(string name)
        {
            for (int i = 0; i < NextCadres; i++)
            {
                if (cadresList[i].Id.Equals(name))
                {
                    cadresList[i].showInfo();
                }
            }
        }
    }
}
