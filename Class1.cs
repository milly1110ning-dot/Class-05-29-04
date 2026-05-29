using System;
using System.Runtime.ConstrainedExecution;

public class Student
{
	public int Mid;
	public int Final;
	public Student(int m,int f)
	{
		Mid = m;
		Final = f;
	}
	public static Student operator+(Student s1,Student s2)
	{
		Student temp = new Student(0, 0);
		temp.Mid = (s1.Mid + s2.Mid) / 2;
		temp,Final = (s1.Final + s2.Final) / 2;
		return temp;
		
	}
}
