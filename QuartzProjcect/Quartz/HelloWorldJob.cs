using Quartz;
using System;
using System.Threading.Tasks;

namespace QuartzProjcect.Quartz
{
    [DisallowConcurrentExecution]
    public class HelloWorldJob : IJob
    {
        public HelloWorldJob()
        {

        }

        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine($"Job 1 zaman dilim {DateTime.Now:U}");
            return Task.CompletedTask;
        }
    }
}
