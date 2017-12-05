using System.Linq;
using UdaStore.Client.Core.Entities;

namespace UdaStore.Client.Core.Repositories
{
    public interface IWidgetInstanceRepository
    {
        IQueryable<WidgetInstance> GetPublished();
    }
}
