using System;

public class Assigment1
{
    private string _studentName;
    private string _topic;

    private Assignment1(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

}
