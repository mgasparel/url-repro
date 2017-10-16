using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace url_repro.Pages
{
    public class IndexModel : PageModel
    {
        public int PageNum { get; set; }

        public async Task OnGetAsync([FromRoute] int pageNum = 1)
        {
            PageNum = pageNum;
        }
    }
}
