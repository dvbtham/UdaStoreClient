using System;
using System.Linq;
using UdaStore.Client.Core.Entities;
using UdaStore.Client.Core.Repositories;

namespace UdaStore.Client.Persistence.Repositories
{
    public class WidgetInstanceRepository : IWidgetInstanceRepository
    {
        private readonly IUdaStoreDbContext _context;

        public WidgetInstanceRepository(IUdaStoreDbContext context)
        {
            _context = context;
        }
        public IQueryable<WidgetInstance> GetPublished()
        {
            return _context.WidgetInstances.Where(x =>
                x.PublishStart.HasValue && x.PublishStart.Value < DateTimeOffset.Now
                && (!x.PublishEnd.HasValue || x.PublishEnd.Value > DateTimeOffset.Now));
        }
    }
}
