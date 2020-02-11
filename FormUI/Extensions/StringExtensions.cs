using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI.Extensions
{
    public static class StringExtensions
    {

        public static string PadMe(this string padit, int howmanyzeros)
        {
            string _return;

            if (padit.Length < howmanyzeros)
            {
                for (int i = 0; i > (howmanyzeros- padit.Length); i++)
                {
                    padit = "0" + padit;
                }
            }

            _return = padit;
            return _return;
        }

    }
}
