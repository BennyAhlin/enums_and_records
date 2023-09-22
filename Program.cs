//enums 

using enums_and_records;

Day today = Day.Thursday;

Console.WriteLine(today);


//records

Student student1 = new Student(Name: "Benny", Birthday: "1988-07-09");
Student student2 = new Student(Name: "Dan", Birthday: "1988-01-15");


Console.WriteLine(student1);
Console.WriteLine(student2);
//skriv ut all info om studenten

Console.WriteLine(student1.Name);
Console.WriteLine(student1.Birthday);
//söker specifikt för namn eller birthday


Console.WriteLine(student1.Birthday == student2.Birthday);
//true or false?


List<Student> students = new List<Student>()
{
    new Student(Name: "Benny", Birthday: "1988-07-09"),
    new Student(Name: "Dan", Birthday: "1988-01-15"),
    new Student(Name: "Arvid", Birthday: "2003-10-16"),
    new Student(Name: "Manuel", Birthday: "2000-10-02"),
};

foreach (Student student in students)
{
    Console.WriteLine(student);
}