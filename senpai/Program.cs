using System;
using System.Collections.Generic;

namespace senpai
{ 
    /// <summary>
    /// calling an interface 
    /// then nameing it IHighSchooler
    /// and giving it a intager called grade
    /// and a string clalled Sname(SchoolName).
    /// </summary>
    public interface IHighSchooler
    {
        int Grade
        {
            get;
            set;
        }
        string SName
        {
            get;
            set;
        }
    }

    /// <summary>
    /// creates a interface called IMechPilot
    /// then give it a string for MName(Mech Name)
    /// and two integers called Attack and Defence.
    /// </summary>
    public interface IMechPilot
    {
        string MName
        {
            get;
            set;
        }
        int Attack
        {
            get;
            set;
        }
        int Defence
        {
            get;
            set;
        }
    }

    /// <summary>
    /// creates a interface called IMonster
    /// and gives one integer called Level.
    /// </summary>
    public interface IMonster
    {
        int Level
        {
            get;
            set;
        }
    }

    /// <summary>
    /// creates a class that brings in IHighSchooler
    /// and IMechPilot to give them those items.
    /// </summary>
    class Protaginist : IHighSchooler, IMechPilot
    {
        private int m_Grade;
        private string m_SName;
        private int m_Attack;
        private int m_Defence;
        private string m_MName;

        public Protaginist(int g, int a, int d, string n, string m)
        {
            m_Grade = g;
            m_SName = n;
            m_Attack = a;
            m_Defence = d;
            m_MName = m;
        }

        /// <summary>
        /// this is getting the grade from
        /// the IHighSchooler's Interface
        /// and putting it into the protaginist class
        /// </summary>
        public int Grade
        {
            get
            {
                return m_Grade;
            }
            set
            {
                m_Grade = value;
            }
        }
        /// <summary>
        /// this is getting the school name from
        /// the IHighSchooler's Interface
        /// and putting it into the protaginist class
        /// </summary>
        public string SName
        {
            get
            {
                return m_SName;
            }
            set
            {
                m_SName = value;
            }
        }

        /// <summary>
        /// this is bringing the Mecha Name
        /// into the protaginist class
        /// </summary>
        public string MName
        {
            get
            {
                return m_MName;
            }
            set
            {
                m_MName = value;
            }
        }
        /// <summary>
        /// this shows the attack from the IMechPilot 
        /// Interface and puts it into the 
        /// protaginist class
        /// </summary>
        public int Attack
        {
            get
            {
                return m_Attack;
            }
            set
            {
                m_Attack = value;
            }
        }

        /// <summary>
        /// this shows the defence from the IMechPilot 
        /// Interface and puts it into the 
        /// protaginist class
        /// </summary>
        public int Defence
        {
            get
            {
                return m_Defence;
            }
            set
            {
                m_Defence = value;
            }  
        }
    }

    /// <summary>
    /// creates a class that brings in IMechPilot
    /// and IMonster to give them those items.
    /// </summary>
    class SadTwist : IMechPilot, IMonster
    {
        private int m_Attack;
        private int m_Defence;
        private string m_MName;
        private int m_Level;

        public SadTwist(int a, int d, string m, int l)
        {
            m_Attack = a;
            m_Defence = d;
            m_MName = m;
            m_Level = l;
        }

        /// <summary>
        /// this is bringing the Mecha Name
        /// into the SadTwist class.
        /// </summary>
        public string MName
        {
            get
            {
                return m_MName;
            }
            set
            {
                m_MName = value;
            }
        }
        /// <summary>
        /// this shows the attack from the IMechPilot 
        /// Interface and puts it into the 
        /// SadTwist class.
        /// </summary>
        public int Attack
        {
            get
            {
                return m_Attack;
            }
            set
            {
                m_Attack = value;
            }
        }

        /// <summary>
        /// this shows the defence from the IMechPilot 
        /// Interface and puts it into the 
        /// SadTwist class.
        /// </summary>
        public int Defence
        {
            get
            {
                return m_Defence;
            }
            set
            {
                m_Defence = value;
            }
        }

        /// <summary>
        /// this shows the level of the SadTwist 
        /// which comes in from the interface 
        /// IMonster.
        /// </summary>
        public int Level
        {
            get
            {
                return m_Level;
            }
            set
            {
                m_Level = value;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

        }

        void SenpaiNotice(IHighSchooler Senpai)
        {

        }

        void Classmate(IHighSchooler TheSenpai)
        {

        }

        void ItsaAngel(IMonster angel)
        {

        }
    }
}