


using Microsoft.Win32.SafeHandles;
using System.ComponentModel;

//Decalring all the lists
List<string> S_Names = new List<string>();
List<float> S_Marks = new List<float>();
List<string> S_Grade = new List<string>();


//Main Processing input Loop
while (true)
{
    string Name = null;
    float Marks = 0;

    //inputing the student name and marks
    Console.Write("\n\nInput X to Close entry \n Input the student Name: ");
    Name = Console.ReadLine();
    if (Name == "X" || Name == "x") break;
    Console.Write(" Input the Student Marks: ");
    //making a never ending loop for input the right marks
    while (true)
    {
        Marks = float.Parse(Console.ReadLine());
        if (Marks >= 0 && Marks <= 100) break;
        Console.Write("Input the Marks in Range 0-100: ");
    }
    //adding the corect information of the student into the collection
    S_Names.Add(Name);
    S_Marks.Add(Marks);
    Console.WriteLine("\nStudent Name: "+Name+" Student Marks: "+Marks);
}


//processing total average of the marks
float avg = 0;
foreach(float n in S_Marks)
{
    avg += n;
}
Console.WriteLine("\n\nAverage Marks of the Students: " + avg/S_Marks.Count);




//soritng all the students according to their marks
//I know I am over doing just to find the highest and the lowest marks but the data we collected from this process can be used in future.
for (int i = 0; i < S_Marks.Count; i++)
{
    for(int j = i+1; j < S_Marks.Count; j++)
    {
        if (S_Marks[j] > S_Marks[i])
        {
            string temp1= S_Names[i];
            float temp2= S_Marks[i];
            S_Names[i] = S_Names[j];
            S_Marks[i] = S_Marks[j];
            S_Names[j] = temp1;
            S_Marks[j] = temp2;
        }
    }
}


//alocatring the grades to the student accoring to their marks using if else
for(int i = 0; i < S_Marks.Count; i++)
{
    if (S_Marks[i] >= 90)
    {
        S_Grade.Add("Distinction");
    }
    else if (S_Marks[i] >= 70)
    {
        S_Grade.Add("Merit");
    }
    else if (S_Marks[i] >= 50)
    {
        S_Grade.Add("Pass");
    }
    else
    {
        S_Grade.Add("Fail");
    }
}


//print the toper and lower student
Console.WriteLine("\n\n\n\tClass Toper:->Name: " + S_Names[0] + " Marks: " + S_Marks[0] + " Gardes: " + S_Grade[0]);
Console.WriteLine("\tClass Loser:->Name: " + S_Names[S_Grade.Count-1] + " Marks: " + S_Marks[S_Grade.Count-1] + " Gardes: " + S_Grade[S_Grade.Count - 1]);

//print the complete result of the students
Console.WriteLine("\n\nComplete Class Result:\n______________________________________________________");
for (int i = 0;i< S_Grade.Count; i++)
{
    Console.WriteLine("Student-> Name: " + S_Names[i] + " Marks: " + S_Marks[i] + " Gardes: " + S_Grade[i]);
}