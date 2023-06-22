using Module3.Models;

namespace Module3.DI
{
    public class ProfileOptionsService
    {
        public List<string> ListGenders()
        {
            // Basic sample
            return new List<string>() { "Female", "Male" };
        }

        public List<State> ListStates()
        {
            // Add a few states
            return new List<State>()
        {
            new State{Name = "Alabama",Code =  "AL" },
            new State{ Name = "Alaska", Code = "AK" },
            new State{ Name = "Ohio", Code = "OH" }
        };
        }

        public List<string> ListColors()
        {
            return new List<string>() { "Blue", "Green", "Red", "Yellow" };
        }
    }
}
