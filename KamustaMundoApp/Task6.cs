
// Matthew Ferdinand B. Curameng from Year 2 Block - D
// for OOP subject by Marco Yimyaem

class Task6
{
    static void Main(String[] args)
    {   
        // Create Student "Marco" using class Student
        Student Marco = new Student();
        
        //Initialize Student/Marco variables
        Marco.Name = "Marco";
        Marco.Age = 20;
        Marco.Grade = 85.5;

        //Display Marco's details using class Student's DisplayInfo func
        Marco.DisplayInfo();

        //Get value of Marco's passing graded using class Student's IsPassed func
        Console.WriteLine("Passed: " + Marco.IsPassed());
    }
}

class Student
    {
        // Initialize Name, Age and Grade using auto property

        public string Name { get; set; }

        public int Age { get; set; }

        public double Grade { get; set; }

        // Function to print Name, Age and Grade of said object(student)
        public void DisplayInfo()
          {
        
             Console.WriteLine(Name);
             Console.WriteLine(Age);
             Console.WriteLine(Grade);

          } 
        
        // Function to print if student grade is higher or equal than 75: return true, if not, return false
        public bool IsPassed()
          {
        
            if (Grade >= 75)
                {
                    return true;
                }
            else
                {
                    return false;
                }
          } 

    }