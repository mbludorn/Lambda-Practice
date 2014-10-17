using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Practice
{
    enum Priority
    {
       Critical, 
        HighImportance,
        NonCritical
    }

    class Ticket
    {
        //Step 1: Declare Properties
        public string ClientName { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public bool Resolve { get; set; }
        public DateTime DateEntered { get; set; }
        public DateTime DateResolved { get; set; }

        //Step 2: Constructor
        public Ticket(string clientName, string description, Priority priority)
        {
            //set our priorities (initalize)
            this.ClientName = clientName;
            this.Description = description;
            this.Priority = priority;
            this.Resolve = false;
            this.DateEntered = DateTime.Now;
        }


            //Step 3: Methods and Functions
            public void ResolveTicket()
            { 
                this.Resolve = true;
                this.DateResolved = DateTime.Now;
            }

            public string GetTicketInfo()
            { 
                return this.ClientName + " - " + this.Description + " - " + this.Priority + "\nResolved: " + this.Resolve;
            }

        }
    }

