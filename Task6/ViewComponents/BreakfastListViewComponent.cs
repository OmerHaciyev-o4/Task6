using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Task6.Entities;
using Task6.Models;
using Task6.Services;

namespace Task6.ViewComponents
{
    public class BreakfastListViewComponent : ViewComponent
    {
        private readonly IRepository<Breakfast> _repository;

        public BreakfastListViewComponent(IRepository<Breakfast> repository)
        {
            _repository = repository;
        }

        public ViewViewComponentResult Invoke()
        {
            return View(new BreakfastListViewModel()
            {
                Breakfasts = _repository.GetAll()
            });
        }
    }
}