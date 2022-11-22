using DataModel;

namespace DFB.DB
{

    public static class DBhelper
    {
        public static void Initialize(DFBContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
