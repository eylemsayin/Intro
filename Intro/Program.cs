// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 100000;

//veriables --> camelCase
Console.WriteLine(message1);
bool isAuthenticated = true;

//Condition 
if (isAuthenticated)
{
    Console.WriteLine("Bton--> Hoşgeldin Eylem");

}
else
{
    Console.WriteLine("Sisteme giriş yap...");
}



string[] loans = { "Kredi1", "Kredi2", "Kredi3", "Kredi4", "Kredi5", "Kredi6" }; //db den gelecek

//start condition //increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}
Course course1 = new Course(); //referans oluşturmak
course1.Id = 1;
course1.Name = "C#";
course1.Description = ".Net 8 vs....";
course1.Price = 0;


Course course2 = new Course(); //referans oluşturmak
course2.Id = 1;
course2.Name = "Java";
course2.Description = "Java17 vs....";
course2.Price = 10;


Course course3 = new Course(); //referans oluşturmak
course3.Id = 1;
course3.Name = "Pyhton";
course3.Description = "Pyhton 3.12....";
course3.Price = 20;


Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name +"/" + courses[i].Price);
}


CourseManager courseManager = new ();
courseManager.GetAll();

Console.WriteLine( "Kod bitti...");



