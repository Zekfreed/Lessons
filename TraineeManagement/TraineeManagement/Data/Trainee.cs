using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraineeManagement.Data
{
    public class Trainee
    {
        public int Id
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public int TraineeshipId
        {
            get; set;
        }

        public int ProfessionId
        {
            get; set;
        }

        public IEnumerable<Traineeship> Traineeships
        {
            get; set;
        }

        public Profession Profession
        {
            get; set;
        }
    }
}
