using Module3.Models;

namespace Module3.DI
{
    public interface IToDoItemRepository
    {
        List<ToDoItem> List();
        int Count();
        int CountIsDone();
        double Agv();

    }
}
