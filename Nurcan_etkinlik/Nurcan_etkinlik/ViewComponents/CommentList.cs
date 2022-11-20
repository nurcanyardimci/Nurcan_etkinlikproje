using Microsoft.AspNetCore.Mvc;
using Nurcan_etkinlik.Models;

namespace Nurcan_etkinlik.ViewComponents
{
    public class CommentList : ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>()
            {
                new UserComment()
                {
                   ID=1,
                   UserName="nurcan"
                },
                new UserComment()
                    {
                     ID=2,
                   UserName="nur"

                },
                 new UserComment()
                    {
                     ID=3,
                   UserName="irem"

                }
            };
            return View(commentvalues);
        }
    }
}
