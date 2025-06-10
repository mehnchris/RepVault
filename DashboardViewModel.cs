using RepVault.Models;
using System.Collections.Generic;

namespace RepVault.ViewModels
{
    public class DashboardViewModel
    {
        public List<RepVaultWorkout> ?LatestWorkouts { get; set; }
        public List<RepVaultGoal> ?ActiveGoals { get; set; }
    }
}
