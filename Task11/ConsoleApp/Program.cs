using System.Threading;
using System.Threading.Tasks;
using TaskLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //CreateTaskWithDelay();
            //Create10TasksWithDelay();
            //Create10TasksWithoutDelay();
        }

        static void CreateTaskWithDelay()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(2000);
            CancellationToken token = cancelTokenSource.Token;

            Task task = WorkWithTasks.CreateTask(token);
            task.Wait();
        }

        static void Create10TasksWithDelay()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(2000);
            CancellationToken token = cancelTokenSource.Token;

            Task[] tasks = new Task[10];

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = WorkWithTasks.CreateTask(token);
            }

            Task.WaitAll(tasks);
        }

        static void Create10TasksWithoutDelay()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;

            Task[] tasks = new Task[10];

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = WorkWithTasks.CreateTask(token);
            }

            Task.WaitAny(tasks);
        }
    }
}
