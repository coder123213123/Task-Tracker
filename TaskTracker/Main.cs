using System;

namespace TaskTracker
{
    class Program
    {
        // Main method: Entry point of the application
        private static void Main(string[] args)
        {
            // Create an instance of DataOps (defined elsewhere)
            DataOps dataOps = new DataOps();

            dataOps.ReadFile();

            
        }
    }
}
