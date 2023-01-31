using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

internal class ToDoTask
{
    private string? _task;
    private int _id;

    public ToDoTask(string? task, int id)
    {
        _task = task;
        _id = id;
        Console.WriteLine($"Была создана задача\nC индексом:{_id}\nСама задача:{_task}");
    }


}