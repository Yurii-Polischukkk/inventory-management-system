using IMS.Shared;

namespace IMS.WebApp.Services
{
    public class InventoryService: ServiceBase<Inventory>
    {
        public InventoryService(ApplicationDbContext context) : base(context)
        {

        }
    }
}
