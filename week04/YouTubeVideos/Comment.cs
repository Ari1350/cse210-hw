using System;
using System.Dynamic;

class Comment{
    public string _Person {get;set;}
    public string _Text {get; set;}

    public Comment(string person, string text)
    {
        _Person = person;
        _Text = text;
    }
}