using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UdaStore.Client.Core;
using UdaStore.Client.Core.Entities;
using UdaStore.Client.Core.ViewModels;

namespace UdaStore.Client.Components
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryMenuViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _unitOfWork.Categories.GetAll().ToList();

            var categoryMenuItems = new List<CategoryMenuItem>();
            foreach (var category in categories.Where(x => !x.ParentId.HasValue))
            {
                var categoryMenuItem = Map(category);
                categoryMenuItems.Add(categoryMenuItem);
            }

            return View("~/Views/Components/Category.cshtml", categoryMenuItems);
        }

        private CategoryMenuItem Map(Category category)
        {
            var categoryMenuItem = new CategoryMenuItem
            {
                Id = category.Id,
                Name = category.Name,
                SeoTitle = category.SeoTitle
            };

            var childCategories = category.InverseParent;
            foreach (var childCategory in childCategories)
            {
                var childCategoryMenuItem = Map(childCategory);
                categoryMenuItem.AddChildItem(childCategoryMenuItem);
            }

            return categoryMenuItem;
        }
    }
}
