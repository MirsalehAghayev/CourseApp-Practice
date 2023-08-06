using CourseApp.Controllers;
using Service.Helpers.Extetions;


ConsoleColor.Cyan.WriteConsole("Choose one operation:  Student operations: Create - 1 ," +
    " GetAll - 2, Search - 5, Teacher operations: Create - 3, GetAll - 4");

StudentController studentController = new();
TeacherController teacherController = new();  

while (true)
{
    Operation: string operation = Console.ReadLine();

    int operationNum;

    bool isTrueOperation = int.TryParse(operation, out operationNum);

    if (isTrueOperation)
    {
        switch (operationNum)
        {
            case 1:
                studentController.Create();
                break;
            case 2:
                studentController.GetAll();
                break;
            case 3:
                teacherController.Create();
                break;
            case 4:
                teacherController.GetAll();
                break;
            case 5:
                studentController.Search();
                break;
            default:
                break;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Choose correct operation format:");
        goto Operation;
    }
}
