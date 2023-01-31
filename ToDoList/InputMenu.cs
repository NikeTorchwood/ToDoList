using ToDoList;

internal class InputMenu : IPrintableMenu
{
    private readonly string _title;
    private List<ToDoTask> _tasks;
    public InputMenu(string title, List<ToDoTask> tasks)
    {
        _title = title;
        _tasks = tasks;
    }

    public int MoveNextStep()
    {
        PrintMenu();

        _tasks.Add(new ToDoTask(Console.ReadLine(), _tasks.Count));
        return (int)MenuStages.MainMenu;
    }

    public void PrintMenu()
    {
        Console.WriteLine(_title);
    }
}