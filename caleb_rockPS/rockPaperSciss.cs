using System;
using System.Collections.Generic;

namespace caleb_rockPS
{

  class RockPaperSciss
  {
    private string status;
    private string difficulty;
        public string Status
        {
          get {return status;}
          set
          {
            var statusList = new List<string> {"rock", "paper", "scissors"};
            foreach(string choice in statusList)
            {
              if(value.Equals(choice))
              {
                status += choice;

              }
              
            }
          }
        }
        string Difficulty
        {
          get{return difficulty;}

        }





  }

}