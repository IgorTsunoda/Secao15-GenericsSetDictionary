using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseSolvedSets.Entities
{
    internal class LogRecords
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is LogRecords)){
                return false;
            }
            LogRecords others = obj as LogRecords;
            return UserName.Equals(others.UserName);
        }
    }
}
