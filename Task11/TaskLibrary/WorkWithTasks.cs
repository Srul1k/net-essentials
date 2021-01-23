using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskLibrary
{
    public static class WorkWithTasks
    {
        public static Task CreateTask(CancellationToken ct = default)
        {
            Random rnd = new Random();
            int iterationsMax = rnd.Next(5, 30);

            return Task.Run(() =>
            {
                for (int i = 0; i < iterationsMax; i++)
                {
                    if (ct.IsCancellationRequested)
                    {
                        return;
                    }

                    Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId}. " +
                        $"IterationsMax: {iterationsMax}. IterationCurrent: {i}");
                    Thread.Sleep(rnd.Next(200, 300));
                }
            });
        }
    }
}
