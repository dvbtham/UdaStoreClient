using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UdaStore.Client.Core;
using UdaStore.Client.Core.ViewModels;

namespace UdaStore.Client.Components
{
    public class CategoryBreadcrumbViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryBreadcrumbViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IViewComponentResult Invoke(long? categoryId, IEnumerable<long> categoryIds)
        {
            IList<BreadcrumbViewModel> breadcrumbs;
            if (categoryId.HasValue)
            {
                breadcrumbs = Create(categoryId.Value);
            }
            else
            {
                var breadcrumbList = categoryIds.Select(Create).ToList();
                breadcrumbs = breadcrumbList.OrderByDescending(x => x.Count).First();
            }

            return View("/Views/Components/CategoryBreadcrumb.cshtml", breadcrumbs);
        }

        private IList<BreadcrumbViewModel> Create(long categoryId)
        {
            var category = _unitOfWork.Categories.Get(categoryId);
            var breadcrumbModels = new List<BreadcrumbViewModel>
            {
                new BreadcrumbViewModel
                {
                    Text = category.Name,
                    Url = category.SeoTitle
                }
            };
            var parentCategory = category.Parent;
            while (parentCategory != null)
            {
                breadcrumbModels.Insert(0, new BreadcrumbViewModel
                {
                    Text = parentCategory.Name,
                    Url = parentCategory.SeoTitle
                });
                parentCategory = parentCategory.Parent;
            }

            return breadcrumbModels;
        }

    }
}



