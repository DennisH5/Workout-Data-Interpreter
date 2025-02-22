using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class ExerciseDataStorage
    {
        public string ExerciseName;
        public List<Exercise> AllRecords = new List<Exercise>();
        public List<(Month, Exercise)> MonthlyRecords = new List<(Month, Exercise)>();
        public string Difference;

        public ExerciseDataStorage(Exercise exercise)
        {
            ExerciseName = exercise.ExerciseName;
            AllRecords.Add(exercise);
            MonthlyRecordCheck();
        }

        public void AddExercise(Exercise exercise)
        {
            AllRecords.Add(exercise);
            MonthlyRecordCheck(exercise);
        }

        void MonthlyRecordCheck(Exercise exercise)
        {
            if (MonthlyRecords.Exists(x => x.Item1 == exercise.Month))
            {
                var (_, monthlyExercise) = MonthlyRecords.FirstOrDefault(x => x.Item1 == exercise.Month);
                // I need to determine how I'm going to create a weighting algorithm to determine Reps/Weight as a comparison method.
            }
            else
            {
                MonthlyRecords.Add((exercise.Month, exercise));
            }
        }
    }

    public struct Exercise 
    {
        public string ExerciseName;
        public string Repititions;
        public string Weight;
        public Month Month;
        public int Day;
    }

    public enum Month
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December,
    }

    static void Main()
    {
        string sourceFilePath = @"C:\path\to\your\inputfile.txt";
        var listOfFilePath = new List<string>() 
        {
            sourceFilePath + "chest",
            sourceFilePath + "back",
            sourceFilePath + "upper",
            sourceFilePath + "lower",
        };
        
        string destinationFilePath = @"C:\path\to\your\outputfile.txt";
        var data = new List<string>();

        try
        {
            foreach (var filePath in listOfFilePath)
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        data.Add(line);
                    }
                }
            }

            var data = InterpretData(data);
            
            using (StreamWriter writer = new StreamWriter(destinationFilePath))
            {
                foreach
            }

            Console.WriteLine("File content successfully copied.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    List<ExerciseDataStorage> InterpretData(string[] allData)
    {
        var dictionaryOfData = new Dictionary<string, ExerciseDataStorage>();

        foreach (var data in allData)
        {
            var splitDataForExercise = SplitData(data);

            if (dictionaryOfData[splitDataForExercise.ExerciseName] == null)
            {
                dictionaryOfData.Add(splitDataForExercise.ExerciseName, new ExerciseDataStorage(splitDataForExercise));
            }
            else
            {
                dictionaryOfData[splitDataForExercise.ExerciseName].AddExercise(splitDataForExercise);
            }
        }

        return dictionaryOfData.Values.Select(v => v).ToList();
    }

    Exercise SplitData(string data)
    {
        // Split the Data In the Format I Have Chosen
    }
}
