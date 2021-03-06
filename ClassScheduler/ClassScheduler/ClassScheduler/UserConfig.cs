﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassScheduler
{

    /// <summary>
    /// This class defines a UserConfig object that has the properties 
    /// of the users name and their term of interest.
    /// </summary>
    /// Author: Kostiantyn Makrasnov (variables)
    /// Author: Yuri Fedas (accessor/mutator functions & constructors)

    public class UserConfig
    {
        private string firstName;
        private string lastName;
        private string termInterest;

        public UserConfig()
        {
            firstName = "";
            lastName = "";
            termInterest = "";
        }

        public UserConfig(string firstName, string lastName, string termInterest)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.termInterest = termInterest;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public void setLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public string getTermInterest()
        {
            return termInterest;
        }

        public void setTermInterest(string termInterest)
        {
            this.termInterest = termInterest;
        }
    }
}
