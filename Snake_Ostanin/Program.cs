using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace Snake_Ostanin
{
    class Program
    {
        public static List<Leaders> Leaders = new List<Leaders>();
        public static List<ViewModelUserSettings> remoteIPAddress = new List<ViewModelUserSettings>();
        public static List<ViewModelGame> viewModelGames = new List<ViewModelGame>();
        private static int localPort = 5001;
        public static int MaxSpeed = 15;
        static void Main(string[] args)
        {
        }
    }
}
