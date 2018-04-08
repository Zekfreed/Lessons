using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraineeManagement.Data
{
    public class Traineeship
    {
        public int Id
        {
            get; set;
        }

        public DateTime BeginDate
        {
            get; set;
        }

        public DateTime EndDate
        {
            get; set;
        }

        public int TraineeId
        {
            get; set;
        }

        public Trainee Trainee
        {
            get; set;
        }

    }
}
