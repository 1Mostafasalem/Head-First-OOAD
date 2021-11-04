using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5.ricksGuitars_mandolins
{
    public enum Style
    {

        A,
        F

    }
    static class StyleMethods
    {
        public static string ToString( Style s)
    {
        switch (s)
        {
            case Style.A: return "A style";
            case Style.F: return "F style";
            default: return "Unspecified";
        }
    }
    }

}





