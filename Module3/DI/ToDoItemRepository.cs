using Module3.Models;

namespace Module3.DI
{
    public class ToDoItemRepository : IToDoItemRepository
    {
        //private readonly ToDoItem _toDoItem;
        public ToDoItemRepository()
        {            
        }

        public double Agv()
        {
            var list = List();
            int sum = 0;
            var count = 0;
            foreach (var item in list)
            {
                sum += item.Priority;
                count++;
            }
            var avg = sum / count;
            return avg;
        }

        public int Count()
        {
            var list = List();
            var count = 0;
            foreach (var item in list) {
                count++;
            }
            return count;
        }
        public int CountIsDone()
        {
            var list = List();
            var count = 0;
            foreach (var item in list)
            {
                if (item.IsDone == true)
                    count++;
            }
            return count;
        }

        public List<ToDoItem> List()
        {
            var list = new List<ToDoItem>(){
                new ToDoItem() {Name = "Task 1", Priority = 1, IsDone = true},
                new ToDoItem() {Name = "Task 2", Priority = 2, IsDone = false},
                new ToDoItem() {Name = "Task 3", Priority = 3, IsDone = false},
                new ToDoItem() {Name = "Task 4", Priority = 4, IsDone = true},
                new ToDoItem() {Name = "Task 5", Priority = 5, IsDone = false},
            };
            return list;
        }
    }
}
