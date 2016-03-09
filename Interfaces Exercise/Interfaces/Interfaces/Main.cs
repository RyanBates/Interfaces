using System;
using System.Collections.Generic;

namespace Interfaces
{
    public interface IStats
    {
        string name
        {
            get;
            set;
        }

        int health
        {
            get;
            set;
        }

        int resource
        {
            get;
            set;
        }
        int power
        {
            get;
            set;
        }
    }

    public interface IFightable : IStats
    {
        bool Fight(IStats other);
    }
}
