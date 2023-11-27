using IMS.Shared;

namespace IMS.WebApp.Services
{
    public class ToolsService : ServiceBase<Tools>
    {
        public ToolsService(ApplicationDbContext context) : base(context)
        {

        }
    }
}
