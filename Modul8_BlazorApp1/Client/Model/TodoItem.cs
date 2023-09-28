using System;
namespace Modul8_BlazorApp1.Client.Model
{ 

public class ToDoItem
{
    public string? Title { get; set; } //? indikere at egenskaben kan have en værdi af "Null"
    public bool IsDone { get; set; }
}
}