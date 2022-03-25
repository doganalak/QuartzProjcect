using Quartz;
using System;
using System.Threading.Tasks;

namespace QuartzProjcect.Quartz
{
    [DisallowConcurrentExecution]
    public class HelloWorldJob2 : IJob
    {
        public HelloWorldJob2()
        {

        }
        public Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine($"Job 2 zaman dilim {DateTime.Now:U}");
            return Task.CompletedTask;
        }
    }
}
