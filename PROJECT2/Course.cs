using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT2
{
    public class Course
    {
        private int number;
        private string title;
        private string description;
        private int capacity;
        
        public int CourseNumber
        { 
            get { return number; } 
            set { number = value; }
        }
        public string CourseTitle
        { 
            get { return title; } 
            set { title = value; }
        }
        public string CourseDescription
        { 
            get { return description; } 
            set { description = value; }
        }
        public int SeatingCapacity
        {
            get { return capacity; } 
            set { capacity = value; } 
        }
        public List<string> StudentIDs
        {
            get; set;
        }

        public Course(int number, string title, string description, int capacity)
        {
            CourseNumber = number;
            CourseTitle = title;
            CourseDescription = description;
            SeatingCapacity = capacity;
            StudentIDs = new List<string>();
        }
        // Method to register a student to the course
        public bool RegisterStudent(string studentID)
        {
            if (StudentIDs.Count < SeatingCapacity)
            {
                StudentIDs.Add(studentID);
                SeatingCapacity--;  // DECREASE AVAILABLE SEAT COUNT
                return true;
            }
            else
            {
                return false; // COURSE IS FULL
            }
        }
         
        // Method to drop a student from a class
        public bool DropStudent(string studentID)
        {
            if (StudentIDs.Contains(studentID)) 
            {
                StudentIDs.Remove(studentID);
                SeatingCapacity++;
                return true;   // Student dropped successfully
            }
            else
            {
                return false;  // Student not found in the course
            }
        }
       
    }
}
