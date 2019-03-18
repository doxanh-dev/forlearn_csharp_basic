using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace DataTemplateDonGian
{
    public class PersonImageConverter: IValueConverter
    {
        #region Hàm chuyển đổi từ đường dẫn ảnh sang đối tượng Bitmap: IValueConverter Members
        /// <summary>
        /// Hàm chuyển đổi từ đường dẫn ảnh sang đối tượng Bitmap
        /// </summary>
        public object Convert(object value, Type targetType,
        object parameter, System.Globalization.CultureInfo culture)
        {
            string imageName = value.ToString();
            Uri uri = new Uri(imageName, UriKind.RelativeOrAbsolute);
            BitmapFrame source = BitmapFrame.Create(uri);
            return source;
        }
        public object ConvertBack(object value, Type targetType,
        object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
