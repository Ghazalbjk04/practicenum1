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
