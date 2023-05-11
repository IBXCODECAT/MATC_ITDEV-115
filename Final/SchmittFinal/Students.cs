using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SchmittFinal
{
    internal static class Students
    {
        private static List<Student> studentList = new List<Student>();

        internal static string PopulateStudents(string path)
        {
            //Clear the current list of students
            studentList.Clear();

            //Instantiate a list to store the blocks we read from the file
            List<string> blocksRead = new List<string>();

            //Purge the list of blocks read to prevent stale data
            blocksRead.Clear();

            try
            {
                //Try to open a data stream at the path specified
                using (StreamReader sr = new StreamReader(path))
                {
                    //Initialize a variable to store block content
                    string blockContent = string.Empty;

                    //While there are still valid non-null blocks in our file, read the block into blockContent...
                    while (!string.IsNullOrEmpty(blockContent = sr.ReadLine()))
                    {
                        //Append the data in blockContent to the list of blocks we've read
                        blocksRead.Add(blockContent);
                    }

                    //Close the stream to prevent dubious reads and clear performance overhead
                    sr.Close();
                }
            }
            catch
            {
                //If we have caught an exception return a dynamic error message
                return $"The file at location \"{path}\" either could not be found or the program does not have permission to read this file!";
            }

            //Declare the index at which the integer parsable blocks start
            const int numericParsableBlockStartIndex = 3;

            //Declare the batch size for reading multiple numeric indicies (for consecutive data that needs to be read together)
            const int numericBatchSize = 2;

            //Foreach block in the blocks we have read...
            foreach (string block in blocksRead)
            {
                //Split the block into string data
                string[] strData = block.Split(',');

                //Declare an integer array to store numeric parsable data with it's length minimalized to the numeric parsable blocks offset
                int[] intData = new int[strData.Length];

                //for each index that can be parsed through the integer parser...
                for (int i = numericParsableBlockStartIndex; i < strData.Length; i++)
                {
                    //Set the value at the integer array's calculated index to the parsed value for the index of the parsable integer
                    intData[i - numericParsableBlockStartIndex] = int.Parse(strData[i]);
                }

                //Create a new object and populate it with the set of metadata (indicies [0], [1], [2])
                Student s = new Student(strData[0], strData[1], strData[2]);

                //For each parsed integer data point in our array of parsed integers
                for(int i = 0; i < intData.Length; i += numericBatchSize)
                {
                    //If this is not the last data parsed integer...
                    if(i < intData.Length - numericBatchSize - 1)
                    {
                        //Enter the data for this object in the appropriate batches
                        s.EnterGrade(intData[i], intData[i + numericBatchSize - 1]);
                    }
                }

                s.CalGrade();

                //Add our newly constructed object to the list of constructed objects
                studentList.Add(s);
            }

            return null;
        }

        internal static int ListLength
        {
            get { return studentList.Count; }
        }

        internal static string StudentID(int index)
        {
            return studentList.ElementAt(index).ID;
        }

        public static string StudentLastName(int index)
        {
            return studentList.ElementAt(index).NameLast;
        }

        internal static string StudentGrade(int index)
        {
            return studentList.ElementAt(index).LetterGrade;
        }

        internal static float StudentAverage(int index)
        {
            return studentList.ElementAt(index).Average;
        }
    }
}