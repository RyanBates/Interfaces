using System;
using System.Collections.Generic;

namespace Interfaces
{ 
    namespace Interfaces
    {
        
        public class Player : IFightable       
        {
            private string m_Name;
            private int m_Health;
            private int m_Resource;
            private int m_Power;

            public string name             
            {
                get { return m_Name; }
                set { m_Name = value; }
            }

            public int health
            {
                get { return m_Health; }
                set { m_Health = value; }
            }
            public int resource            {
                get { return m_Resource; }
                set { m_Resource = value; }
            }
            public int power
            {
                get { return m_Power; }
                set { m_Power = value; }
            }


            public Player(string n, int h, int r, int p)
            {
                m_Name = n;
                m_Health = h;
                m_Resource = r;
                m_Power = p;
            }

            public bool Fight(IStats other)
            {
                Console.WriteLine(name + " fights " + other.name);
                other.health -= 5;
                if (other.health <= 0)
                {
                    Console.WriteLine(other.name + " has died!"); 
                    return true;
                }

                return false;
            }
        }

        public class Enemy : IFightable
        {
            private string m_Name;
            private int m_Health;
            private int m_Resource;
            private int m_Power;

            public string name
            {
                get { return m_Name; }
                set { m_Name = value; }
            }

            public int health
            {
                get { return m_Health; }
                set { m_Health = value; }
            }

            public int resource
            {
                get { return m_Resource; }
                set { m_Resource = value; }
            }

            public int power
            {
                get { return m_Power; }
                set { m_Power = value; }
            }

            public Enemy(string n, int h, int r, int p)
            {
                m_Health = h;
                m_Name = n;
                m_Resource = r;
                m_Power = p;
            }

            public bool Fight(IStats other) 
            {
                Console.WriteLine(name + " fights " + other.name);
                other.health -= 5;
                if (other.health <= 0)
                {
                    Console.WriteLine(other.name + " has died!");
                    return true;
                }

                return false;
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                List<IFightable> fight = new List<IFightable>();
                for (int i = 1; i < 5; i++)
                {
                    Enemy enemy = new Enemy("enemy" + i.ToString(), 30, 10, 5);
                    Player player = new Player("player" + i.ToString(), 60, 15, 2);

                    fight.Add(enemy);
                    fight.Add(player);
                }

                foreach (IStats IHateThis in fight)
                {
                    Console.WriteLine(IHateThis.name);
                    Console.WriteLine(IHateThis.health);
                    Console.WriteLine(IHateThis.resource);
                    Console.WriteLine(IHateThis.power);

                }

                for (int en = 0; fight.Count > 1; en++)
                {
                    if (en >= fight.Count)
                    {
                        en = 0;
                    }

                    if (en == fight.Count - 1)
                    {
                        if (fight[en].Fight(fight[0]) == true)
                        {
                            fight.Remove(fight[0]);
                            Console.WriteLine("There are " + fight.Count + " left.");
                        }
                    }

                    else
                    {
                        if (fight[en].Fight(fight[en + 1]) == true)
                        {
                            fight.Remove(fight[en + 1]);
                            Console.WriteLine("There are " + fight.Count + " left.");
                        }
                    }
                }

                Console.WriteLine(fight[0].name + " is the victor!!!!");
                Console.WriteLine("Press any key to exit. . .");
                Console.WriteLine("");
                Console.ReadLine();
            }
        }
    }
}
