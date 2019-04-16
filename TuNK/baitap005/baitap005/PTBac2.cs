using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap005
{
    public static class PTBac2
    {
        public static string GiaiPhuongTrinhBac2(float a, float b, float c)
        {
            var result = "";
            if (a != 0)
            {
                var delta = (b * b) - (4 * a * c);

                if (delta < 0)
                {
                    result = "Pt vô nghiệm";
                }
                else if (delta == 0)
                {
                    var x = (-b) / (2 * a);
                    float x_ = (float)Math.Round(x * 100f) / 100f;
                    result = "Pt có nghiệm kép: x1=x1=" + x_;
                }
                else
                {
                    var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    var x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    float x1c = (float)Math.Round(x1 * 100f) / 100f;
                    float x2c = (float)Math.Round(x2 * 100f) / 100f;
                    result = "Pt có 2 nghiệm: x1=" + x1c.ToString() + " và x2=" + x2c.ToString();
                }
                
            }
            else
            {
                //gọi hàm giải phương trình bậc 1
                result = PTBac1.GiaiPhuongTrinhBac1(b, c);
            }

            return result;
        }
    }
}
