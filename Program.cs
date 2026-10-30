// Student a=new Student("Aakash Sotang Rai");

// int c =(a.study(20,30));
// Console.WriteLine(c);



// Student b=new Student("Sital");
// Console.WriteLine(b.study(30,10));





// class Student{
//     public string Name="";

// public Student(String name)
// {
//     Name=name;
// }

// public void draw()
//     {
//         Console.WriteLine($"name=(Name)");
//     }



//     public int study(int a, int b){
//         return a+b;
//     }
// }







// Student a = new Student();
// Student b = new Student("Ram");
// Student c = new Student("sita ", 21);

// a.show();
// b.show();
// c.show();


// class Student
// {
//     public string Name;
//     public int Age;


//     public Student()
//     { 
//         Name = "Unknown"; 
//         Age=0;
//     }
//     public Student(string name) 
//     {
//         Name = name; Age = 0;
//     }
//     public Student(string name, int age)

//     {
//         Name = name;
//         Age = age;
//     }


//     public void show()
//     {
//         Console.WriteLine($"Name: {Name}, Age: {Age}");
//     }

// }





    Student s = new Student();
    s.SetAge(22);
    Console.WriteLine(s.GetAge());   // Output: 22

class Student
{
    private int age;

    public void SetAge(int newAge)
    {
        if (newAge >= 0 && newAge <= 120)
        {
            age = newAge;
        }
        else
        {
            Console.WriteLine("Invalid age");
        }
    }

    public int GetAge()
    {
        return age;
    }
}




Person p = new Person();
p.Name = "Ram";
Console.WriteLine(p.Name);
class Person
{
    private string name ="";
    public string Name

    {
        get {
            return name;
            }

        set {
            name =  value;
            }
    }
}







