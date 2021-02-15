using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskLibrary
{
    public static class WorkWithTasks
    {
        private static Random rnd = new Random();
        public static Task CreateTask(CancellationToken ct = default)
        {
            int iterationsMax = rnd.Next(5, 30);

            return Task.Run(async () =>
            {
                for (int i = 0; i < iterationsMax; i++)
                {
                    if (ct.IsCancellationRequested)
                    {
                        return;
                    }

                    await Task.Delay(rnd.Next(200, 300));
                    Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId}. " +
                        $"IterationsMax: {iterationsMax}. IterationCurrent: {i}");
                }
            });
        }
    }
}
