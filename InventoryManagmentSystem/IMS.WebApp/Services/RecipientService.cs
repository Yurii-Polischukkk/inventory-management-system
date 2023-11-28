using IMS.Shared;
namespace IMS.WebApp.Services
{
    public class RecipientService : ServiceBase<Recipient>
    {
        public RecipientService(ApplicationDbContext context) : base(context)
        {

        }
    }
}
