using ViewComponent.Models;

namespace ViewComponent.ViewComponents;

using Microsoft.AspNetCore.Mvc;

public class GridViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(List<Person> persons)
    {
        return View("Sample", persons);
    }
}
