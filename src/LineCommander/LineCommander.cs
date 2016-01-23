using System.Collections.Generic;
using LineCommander.Arguments;

namespace LineCommander
{
    public static class LineCommander
    {
        public static void Parse(string[] args, List<ArgumentSet> argumentSets)
        {
            foreach (var argSet in argumentSets)
            {
                if (argSet.Parse(args))
                {
                    return;
                }
            }
        }

        // error ...
    }
}
