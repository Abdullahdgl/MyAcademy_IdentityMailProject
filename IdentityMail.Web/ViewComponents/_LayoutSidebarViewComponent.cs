using Microsoft.AspNetCore.Mvc;

namespace IdentityMail.Web.ViewComponents
{
	public class _LayoutSidebarViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
