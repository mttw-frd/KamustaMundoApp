
// Matthew Ferdinand B. Curameng from Year 2 Block - D
// for OOP subject by Marco Yimyaem

// Create a Student Profile template using struct
struct student_struct
{
    public string Name { get; set; }
    public int English { get; set; }
    public int Math { get; set; }
    public int Computer { get; set; }

    public int Total { get; set; }

    // Struct function to collect information for variables with formatting
    // Uses IntPrompt function from Task5 class as prompts
    public void Student_Profiler()
    {
        Console.Write("Enter Student Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter English Marks (Out Of 100): ");
        English = Task5.IntPrompt();

        Console.Write("Enter Math Marks (Out Of 100): ");
        Math = Task5.IntPrompt();

        Console.Write("Enter Computer Marks (Out Of 100): ");
        Computer = Task5.IntPrompt();

        Total = English + Math + Computer;

        Console.WriteLine("*********************************************");
    }
}

class Task5
{
    static void Main(String[] args)
    {       
            // Prompts the total amount of students to list, creates a temp sized array of student_struct with it
            Console.Write("Enter Total Students: ");
            int array_size = IntPrompt();
            student_struct[] students = new student_struct[array_size];
            student_struct temp;

        //student_struct[] sorted_students = new student_struct[array_size];

            // Prompt user for student's profile info using the array's size
            for (int i = 0; i < students.Length; i++)
            {
                student_struct new_student = new student_struct();
                new_student.Student_Profiler();
                //add student into students array
                students[i] = new_student;
            }

            // Sort profiles in the array using a bubble sorter, puts highest Total in the first of the array and so on
            for (int x = 0; x < students.Length; x++)
            {
                for (int y = 0; y < students.Length - 1; y++)
                {
                    if (students[y].Total < students[y + 1].Total)
                    {
                        temp = students[y + 1];
                        students[y + 1] = students[y];
                        students[y] = temp;
                    }
                }
            }

            // Print the rankings of the profiles, using the for loop's x in place of the position

            Console.WriteLine("****************Report Card*******************");

            for(int x = 0; x < students.Length; x++)
            {
                Console.Write("Student Name: " + students[x].Name);
                Console.Write(", Position: " + (x + 1));
                Console.WriteLine(", Total: " + students[x].Total);
                Console.WriteLine("****************************************");    
            }

    }

    // Function to parse string inputs into ints, also prevents if it uses letters or exceeds 100
    public static int IntPrompt()
    {
        Start:
            int output_int = 0;
            string str = "";
            str = Console.ReadLine();

            // Check if value is parseable into int, falses if not
            bool check = int.TryParse(str, out output_int);

            if(!check)
            {       
                // Print warning and go back to Start if letters are found
                    Console.WriteLine("You can only input numbers.");
                    goto Start;
            }
            else if (output_int > 100)
            {
                 // Print warning and go back to Start if it exceeds 100
                    Console.WriteLine("You can only input a maximum of 100.");
                    goto Start;           
            }
        // Return values back to function caller
        return output_int;
    }
}