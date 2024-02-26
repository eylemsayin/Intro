using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses = new Course[3];
    //constructor
    public CourseManager()
    {
        Course course1 = new Course();

        //referans oluşturmak
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

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;

    }
    public Course[] GetAll()
    {
        //veri kaynağından çekilir...
        return courses;
    }

}
