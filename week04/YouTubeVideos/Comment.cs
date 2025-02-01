using System;
using System.Dynamic;

class Comment{
    public string Person {get;set;}
    public string Text {get; set;}

    public Comment(string person, string text)
    {
        Person = person;
        Text = text;
    }
}