namespace Mpc.MyAssociation.Infrastructure.CrossCutting.Settings
{
    public class AppSettings
    {
        public DataBaseSettings DataBaseSettings { get; set; }

        public int PageSize { get; set; } = 200;
    }
}
