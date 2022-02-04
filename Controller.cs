using System.Collections.Generic;

namespace АИС
{
    public class CP
    {
        public static AppDbContext context;

        public static AppDbContext Context
        {
            get { return context; }
            set { context = value; }
        }

        public static void GetContext()
        {
            Context = new AppDbContext();
        }

        public static User CurrentUser { get; set; }
        public static AuthWindow AuthWindow {get;set;}
        public static MainWindow MainWindow { get; set; }
        public static List<Item> Items { get; set; }
        public static int ItemId { get; set; }
        public static int StartItem { get; set; }
        public static double CoomonWeight { get; set; }
    }
}
