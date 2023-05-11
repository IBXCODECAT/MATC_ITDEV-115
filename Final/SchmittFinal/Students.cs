using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SchmittFinal
{
    internal class Students
    {
        private List<Student> studentList;

        public string PopulateStudents(string path)
        {
            //this is the method you need to implement...NO CONSOLE LOGIC in this file.
            //use the parameter path for file name, and return an error string!!

            //1) create instance of theStudentList (theStudentList = new List<Student>();)
            //2) create an instance of the StreamReader Class to read the data from the file named in the variable path
            //3) Open the File and read line by line using theReadLIne command
            //4) split the line
            //5) create one instance of Student, fill in id, first and last through the constructor
            //6) now loop through remaining fields 3 - 23 for earned and possible and set though method EnterGrade.
            //7) call CalGrade on the Student object - that sets the average and grade.
            //8) Add that Student to theStudentList (theStudentList.Add(aStudent);)
            //9) read next line and loop until null or line = ""
            //10) Close the file

            //do not forgot to use a Try/Catch block.

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
                string[] strData = block.Split('\'');

                //Declare an integer array to store numeric parsable data with it's length minimalized to the numeric parsable blocks offset
                int[] intData = new int[strData.Length - numericParsableBlockStartIndex];

                //for each index that can be parsed through the integer parser...
                for (int i = numericParsableBlockStartIndex; i <= strData.Length; i++)
                {
                    //Set the value at the integer array's calculated index to the parsed value for the index of the parsable integer
                    intData[i - numericParsableBlockStartIndex] = int.Parse(strData[i]);
                }

                //Create a new object and populate it with the set of metadata (indicies [0], [1], [2])
                Student s = new Student(strData[0], strData[1], strData[2]);

                //For each parsed integer data point in our array of parsed integers
                for(int i = 0; i < intData.Length; i += numericBatchSize)
                {
                    //Enter the data for this object in the appropriate batches
                    s.EnterGrade(intData[i], intData[i + numericBatchSize - 1]);
                }

                //Add our newly constructed object to the list of constructed objects
                studentList.Add(s);
            }

            return "Read successfull!";
        }

        public int ListLength
        {
            get { return studentList.Count; }
        }

        public string StudentID(int index)
        {
            return studentList.ElementAt(index).ID;
        }

        public string StudentLastName(int index)
        {
            return studentList.ElementAt(index).NameLast;
        }

        public string StudentGrade(int index)
        {

            return studentList.ElementAt(index).LetterGrade;
        }

        public float StudentAverage(int index)
        {

            return studentList.ElementAt(index).Average;
        }

    }

}