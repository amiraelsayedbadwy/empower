using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Empower.Droid
{
    public static class Utils
    {
        public static float ConvertPixelToDp(Context context, float px)
        {
            return px / context.Resources.DisplayMetrics.Density;
        }

        public static float ConvertDpToPixel(Context context, float dp)
        {
            return dp * context.Resources.DisplayMetrics.Density;
        }
    }
}