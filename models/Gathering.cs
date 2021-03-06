using System;
using System.Collections.Generic;

namespace SecretSanta.Models
{
    
    public class Gathering : List<Person>
    {
        private string _infoPath;
        
        public Gathering(string infoPath){
            _infoPath = infoPath;
        }
        ///<summary>
        ///Validates if the supplied gather is valid
        ///all family members of a user should be members
        ///of the gather.
        ///</summary>
        public bool Validate()
        {
            return true;  
        } 
        
        ///<summary>
        ///Assignes everyone people for secret santa. 
        ///<param ref="numberOfPlayers">The number of people to assign
        ///should be less than the number of people in the group</param>
        ///</summary>
        public bool Shuffle(int numberOfPlayers = 1)
        {
            if(numberOfPlayers >= this.Count){
                return false;
            }
            
            return true;
        }
        
        ///<summary>
        ///Creates CSV file to display information about the group
        ///includes who should be assigned to whom
        ///</summary>
        public void CreateCsv()
        {
            
        }
    }
    
}