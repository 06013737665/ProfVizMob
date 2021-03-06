using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Profissao_Vizinha.Custom
{



    [ContentProperty("SourceImage")]
    public class PlatformImageExtension : IMarkupExtension<string>
    {

        public string SourceImage { get; set; }

        public string ProvideValue(IServiceProvider serviceProvider)
        {
           if (SourceImage == null)
                return null;

            string imagePath;
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    imagePath = SourceImage;
                    break;
                case Device.iOS:
                    imagePath = SourceImage + ".png";
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }
            return imagePath;
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }
    }


}
