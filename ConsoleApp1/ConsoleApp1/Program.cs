using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new List<Student>
            {
                new Student("Henry", "Post", "ID01"),
                new Student("Jill", "Squill", "ID02"),
            };

            try
            {
                Student s = new Student("Scram", "Jam", "ITS03");
                students.Add(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

    }

}

class Student
{
    private string _first_name;
    public string first_name { get => _first_name; }

    private String _last_name;
    public string last_name { get => _last_name; }

    private String _id;
    string id
    {
        get => _id;
        set
        {
            if (!value.Contains("ID"))
            {
                throw new Exception("ID Must contain \"ID\"!");
            }

            _id = value;
        }
    }

    public Student()
    {

    }

    public Student(string fn, string ln, string id)
    {
        _first_name = fn;
        _last_name = ln;
        this.id = id;
    }

    ~Student()
    {
        Console.WriteLine("I, " + ToString() + ", AM BEING GARBAGE COLLECTED! AAAAA!");
    }

    public string ToString()
    {
        return $"{id}: {first_name} {last_name}";
    }



}
}
