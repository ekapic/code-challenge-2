using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    public static class NumberProviderFactory
    {
        public static INumberSource MakeNumberSource(InputType type)
        {
            INumberSource result = null;

            switch (type)
            {
                case InputType.File:
                   result =  new FileNumberSource();
                    break;
                case InputType.Manual:
                    result =  new ConsoleNumberSource();
                    break;
            }
            return result;
        }
    }
}
