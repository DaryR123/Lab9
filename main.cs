using System;


class Employee
{
string firstname;
string lastname;
string id;
string address;
string phonenumber;
string title;
string employeestatus;
double yearlysalary;
int age;

Employee()
{
firstname=Unknown;
lastname=Unknown;
id=Unknown;
age=0;
employmentstatus=active;
}
Employee(string firstname, string lastname, string id, int age)
{
firstname=firstname;
lastname=lastname;
id=id;
age=age;
employmentstatus=active;
}
void intro()
{
Console.WriteLine("First Name: " + firstname);
Console.WriteLine("LastName: " + lastname);
Console.WriteLine("ID:" + id);
Console.WriteLine("Age: " + age);
Console.WriteLine("Employment Status:" + employmentstatus);
}
public static Main (string[] args)
{
Employee obj=new Employee();
Obj.intro();
}
}
