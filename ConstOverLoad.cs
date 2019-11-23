using System;
namespace Exercise{
public class ConstOverLoad{
	string Name;
	int Age;
	public ConstOverLoad(string name, int age){
		this.Name = name;
		this.Age = age;
	}
	public ConstOverLoad(string name){
		this.Name = name;
	}
	public string getName(){
		return Name;
	}
	public int getAge(){
		return Age;
	}
	public string Show(){
		return("Name is "+this.getName()+", Age is :"+this.getAge());
	}
}
}