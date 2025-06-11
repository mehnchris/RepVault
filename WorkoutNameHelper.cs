namespace RepVault.Helpers
{
    public static class WorkoutNameHelper
    {
        public static string Normalize(string input)
        {
            return input.Trim().ToLower().Replace(" ", "");

        }
    }
}
