using System.Threading;
using System.Threading.Tasks;
using TaskLibrary;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main()
        {
            //CreateTaskWithDelay();
            //await Create10TasksWithDelay();
            //await Create10TasksWithoutDelay();
        }

        private static void CreateTaskWithDelay()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(2000);
            CancellationToken token = cancelTokenSource.Token;

            Task task = WorkWithTasks.CreateTask(token);
            task.Wait();
        }

        private static async Task Create10TasksWithDelay()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource(2000);
            CancellationToken token = cancelTokenSource.Token;

            Task[] tasks = new Task[10];

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = WorkWithTasks.CreateTask(token);
            }

            await Task.WhenAll(tasks);
        }

        private static async Task Create10TasksWithoutDelay()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;

            Task[] tasks = new Task[10];

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = WorkWithTasks.CreateTask(token);
            }

            await Task.WhenAny(tasks);
        }
    }
}
