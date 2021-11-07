using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FramDemos.QuartzDemo
{
    public class Manager
    {
        public async Task Start()
        {

            //调度器工厂
            ISchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = await factory.GetScheduler();


            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                .WithCronSchedule("0/5 * * * * ?")     //5秒执行一次
                                                       //.StartAt(runTime)
                .Build();
            IJobDetail job = JobBuilder.Create<TimeJob>().WithIdentity("job1", "group1").Build();
            await scheduler.ScheduleJob(job, trigger);

            await scheduler.Start();
        }
    }
}
