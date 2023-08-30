// collections
// array, list, dictionary
using System.Net.Cache;

int age1;// 
int age2;
int age3;// age1, age2, age3, variables, objects, instances

Student st1;// 0
st1 = new Student();
st1.name = "Braden Fisher";
st1.age = 21;
Student st2;
Student st3;

// collections
// array
int[] ageArr;// int[] is the datatype, an array, an integer array, complex, expensive

ageArr = new int[10];// created 10 integer variable
ageArr[0] = 20;// index
Console.WriteLine(ageArr[0]);

//
Student[] stuArr;// datatype is Student[]. array, student array
                 // complex
stuArr = new Student[10];// we have 10 student variables, 10 cards
                         // none students created
stuArr[0] = new Student();

stuArr[0].name = "Tom";

Console.WriteLine(stuArr[0].name);
// Console.WriteLine(stuArr[1].name);
Console.WriteLine(stuArr.Length);

// List
List<Student> stuList;// datatype List, student list, complex, expensive
stuList = new List<Student>();

stuList.Add(new Student());
stuList.Add(new Student());

stuList[1].name = "Tom";
Console.WriteLine(stuList[1].name);
Console.WriteLine(stuList.Count);
// dictionary
// index, key
// name, Student
Dictionary<string, Student> stuDict;// dictionary is the datatype, complex
stuDict = new Dictionary<string, Student>();

Student stu;
stu = new Student();
stu.name = "Tom";
stu.age = 21;
stu.weight = 136.6;

stuDict.Add("Tom", stu);

stuDict["Tom"].name = "TOM";

Console.WriteLine(stuDict["Tom"].age);


class Student// student is the datatype name, complex
{
   public string name;
   public int age;
   public double weight; 
}
