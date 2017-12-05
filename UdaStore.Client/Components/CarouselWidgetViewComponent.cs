using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UdaStore.Client.Core;
using UdaStore.Client.Core.ViewModels;

namespace UdaStore.Client.Components
{
    public class CarouselWidgetViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;

        public CarouselWidgetViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IViewComponentResult Invoke(WidgetInstanceViewModel widgetInstance)
        {
            var model = new CarouselWidgetViewComponentViewModel
            {
                Id = widgetInstance.Id,
                Items = JsonConvert.DeserializeObject<IList<CarouselWidgetViewComponentItemVm>>(widgetInstance.Data)
            };

            foreach (var item in model.Items)
            {
                item.Image = _unitOfWork.Mediae.GetMediaUrl(item.Image);
            }

            return View("/Views/Components/CarouselWidget.cshtml", model);
        }
    }
}
