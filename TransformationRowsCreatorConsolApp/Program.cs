using System;
using System.IO;
using System.Linq;

namespace TransformationRowsCreatorConsolApp
{

  
    class Program
    {

        public static void CreateUrlRewritesIpRestrictioins(string desctinationPath, string mainIP, int first, int last)
        {
            using (FileStream f = new FileStream(desctinationPath, FileMode.Append, FileAccess.Write))
            using (StreamWriter s = new StreamWriter(f))
            {
                for (int i = first; i < last + 1; i++)
                {
                    s.WriteLine("  <add xdt:Transform=\"Insert\" key=\"{0}\" value=\"{1}\" />", mainIP + i.ToString(), "allow");
                }
            }
            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            if (args.Any())
            {
                CreateUrlRewritesIpRestrictioins(args[0], "5.101.139.", 2, 6);
            }
            else
            {
                CreateUrlRewritesIpRestrictioins(@"C:\privateTransorm.xml", "10.101.139.", 2, 6);
            }
            Console.WriteLine("Done");
            Console.ReadKey();

        }
    }
}
