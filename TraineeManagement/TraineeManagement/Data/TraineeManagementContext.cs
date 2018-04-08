using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraineeManagement.Data
{
    public class TraineeManagementContext : DbContext
    {
        public DbSet<Trainee> Trainees
        {
            get; set;
        }

        public DbSet<Traineeship> TraineeShips
        {
            get; set;
        }

        public DbSet<Profession> Professions
        {
            get; set;
        }

        public TraineeManagementContext(DbContextOptions<TraineeManagementContext> options) : base(options)
        {

        }
    }
}
