using HRManager.EntityFrameworkCore;

namespace HRManager.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly HRManagerDbContext _context;

        public TestDataBuilder(HRManagerDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}