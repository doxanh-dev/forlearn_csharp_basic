using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap005
{
    public static class PTBac1
    {
        public static string GiaiPhuongTrinhBac1(float a, float b)
        {
            var result = "";
            if (a == 0)
            {
                if (b == 0)
                {
                    result = "Pt vô số nghiệm";
                }
                else
                {
                    result = "Pt vô nghiệm";
                }
            }
            else
            {
                var x = -b / a;

                float x_float = (float)Math.Round(x * 100f) / 100f;
                result = "Pt có nghiệm: " + x_float.ToString();
            }

            return result;
        }
    }
}
