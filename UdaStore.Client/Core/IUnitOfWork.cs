using UdaStore.Client.Core.Repositories;

namespace UdaStore.Client.Core
{
    public interface IUnitOfWork
    {
        IWidgetInstanceRepository WidgetInstances { get; set; }
        IProductRepository Products { get; set; }
        IUserRepository Users { get; set; }
        IMediaRepository Mediae { get; set; }
        ICategoryRepository Categories { get; set; }
    }
}
