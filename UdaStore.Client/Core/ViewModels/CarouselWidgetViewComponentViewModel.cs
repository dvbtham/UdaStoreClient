using System.Collections.Generic;

namespace UdaStore.Client.Core.ViewModels
{
    public class CarouselWidgetViewComponentViewModel
    {
        public long Id { get; set; }

        public int DataInterval { get; set; } = 6000;

        public IList<CarouselWidgetViewComponentItemVm> Items { get; set; } = new List<CarouselWidgetViewComponentItemVm>();
    }
}
