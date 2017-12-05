using Microsoft.AspNetCore.Hosting;
using UdaStore.Client.Core;
using UdaStore.Client.Core.Repositories;
using UdaStore.Client.Persistence.Repositories;

namespace UdaStore.Client.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly UdaStoreDbContext _context;

        public IWidgetInstanceRepository WidgetInstances { get; set; }
        public IProductRepository Products { get; set; }
        public IUserRepository Users { get; set; }
        public IMediaRepository Mediae { get; set; }
        public ICategoryRepository Categories { get; set; }

        public UnitOfWork(UdaStoreDbContext context, IHostingEnvironment hostingEnvironment)
        {
            Products = new ProductRepository(context);
            Users = new UserRepository(context);
            Categories = new CategoryRepository(context);
            Mediae = new MediaRepository(context, hostingEnvironment);
            WidgetInstances = new WidgetInstanceRepository(context);
            _context = context;
        }

        public void Complete()
        {
            _context.SaveChanges();
        }
    }
}