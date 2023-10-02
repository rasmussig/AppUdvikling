using System;
namespace Modul8_BlazorApp1.Client.Model
{ 

public class ToDoItem : IComparable<ToDoItem>
    {
    public string? Title { get; set; } //? indikere at egenskaben kan have en værdi af "Null"
    public bool IsDone { get; set; }

    public string Priority { get; set; }

    public int CompareTo(ToDoItem other)
        {
            // Sammenlign prioritet ved at sammenligne deres strengværdier
            return string.Compare(Priority, other.Priority, StringComparison.OrdinalIgnoreCase);
        }
    }
}