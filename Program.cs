public class customer
{
    public string name {get; set;}
     public string email {get; set;}
     public int phone {get; set;}
     string buy()
    {
        string result="";
        result= "customer is buying";
        return result;
    }
    string pay()
    {
        string result="";
        result= "customer is paying";
        return result;
    }
}

public class student
{
    public string name {get; set;}
     public string major {get; set;}
     public int grade {get; set;}
      string study()
    {
        string result="";
        result= "student is studying";
        return result;
    }
    string attedndclass()
    {
        string result="";
        result= "student is attending class";
        return result;
    }
     
}

public class teacher
{
    public double salary {get; set;}
     public string name {get; set;}
     public string subject {get; set;}
      string teaching()
    {
        string result="";
        result= "teacher is teaching";
        return result;
    }
    string ask()
    {
        string result="";
        result= "teacher is asking";
        return result;
    }
}

public class employee
{
    public string name {get; set;}
     public string position {get; set;}
     public string experiences {get; set;}
      string work()
    {
        string result="";
        result= "employee is working";
        return result;
    }
    string getsalary()
    {
        string result="";
        result= "employee is getting salary";
        return result;
    }
}

public class rectangle
{
    public int width {get; set;}
     public int height {get; set;}
      string area()
    {
        string result="";
        result= "the area is calculated";
        return result;
    }
    string perimeter()
    {
        string result="";
        result= "the perimeter is calculated";
        return result;
    }

}

public class square
{
    public int size {get; set;}
     public int width {get; set;}
     public int side {get; set;}
      string area()
    {
        string result="";
        result= "the area is calculated";
        return result;
    }
    string perimeter()
    {
        string result="";
        result= "the perimeter is calculated";
        return result;
    }
}

public class dog
{
    public string name {get; set;}
     public int age {get; set;}
     public string breed {get; set;}
      string eat()
    {
        string result="";
        result= "the dog is eating";
        return result;
    }
    string bark()
    {
        string result="";
        result= "the dog is barking";
        return result;
    }
}

public class cat
{
    public string name {get; set;}
     public string color {get; set;}
     public string gender {get; set;}
      string sleeep()
    {
        string result="";
        result= "the cat is sleeping";
        return result;
    }
    string walk()
    {
        string result="";
        result= "the cat is walking";
        return result;
    }
}