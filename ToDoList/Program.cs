using ToDoList;

internal class Program
{
    static void Main()
    {
        var taskList = new List<ToDoTask>();
        var mainMenu = new SelectableMenu("Добрый день, выберете что-то", new List<string> { "Добавить задачу", "Отметить задачу как выполненую" });
        var createTask = new InputMenu("Введите новую задачу и нажмите Enter", taskList);
        //var completeTask = new SelectableMenu("Какую задачу нужно отметить?", taskList);
        int currentMenu = (int)MenuStages.MainMenu;
        do
        {
            switch (currentMenu)
            {
                
                case var a when a == (int)MenuStages.MainMenu:
                    currentMenu = mainMenu.MoveNextStep();
                    break;
                case var a when a == (int)MenuStages.CreateTask:
                    currentMenu = createTask.MoveNextStep();
                    break;
            }
        } while (true);
    }
}