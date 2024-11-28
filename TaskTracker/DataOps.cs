using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TaskTracker
{
    public enum Status
    {
        todo = 0,
        in_progress = 1,
        done = 2,
    }

    public class DataStruc
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public Status Status { get; set; } = Status.todo;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }

    public class DataOps
    {
        public void ReadFile()
        {
            try
            {
                string fileName = "Tasks.json";

                if (!File.Exists(fileName))
                {
                    Console.WriteLine("File not found: " + fileName);
                    return;
                }

                string fileContent = File.ReadAllText(fileName);

                // Deserialize JSON into a list of DataStruc objects
                List<DataStruc> tasks = JsonConvert.DeserializeObject<List<DataStruc>>(fileContent);

                if (tasks != null)
                {
                    foreach (var task in tasks)
                    {
                        Console.WriteLine($"Id: {task.Id}, Description: {task.Description}, Status: {task.Status}, CreatedAt: {task.CreatedAt}, UpdatedAt: {task.UpdatedAt}");
                    }
                }
                else
                {
                    Console.WriteLine("No tasks found in the file.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

    }
}
