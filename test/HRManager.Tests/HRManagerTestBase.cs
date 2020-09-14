using System;
using System.Threading.Tasks;
using Abp.TestBase;
using HRManager.EntityFrameworkCore;
using HRManager.Tests.TestDatas;

namespace HRManager.Tests
{
    public class HRManagerTestBase : AbpIntegratedTestBase<HRManagerTestModule>
    {
        public HRManagerTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<HRManagerDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<HRManagerDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<HRManagerDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<HRManagerDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<HRManagerDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<HRManagerDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<HRManagerDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<HRManagerDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
