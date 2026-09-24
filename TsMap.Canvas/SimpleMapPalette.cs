using System.Drawing;

namespace TsMap.Canvas
{
    /// <summary>
    /// Nordic Transport Group dark map theme.
    /// NTG CI: ice blue #7BBDE9, white #FFFFFF, rock grey #6E747A.
    /// </summary>
    public class SimpleMapPalette : MapPalette
    {
        public SimpleMapPalette()
        {
            Background = new SolidBrush(Color.FromArgb(17, 24, 32));       // #111820
            Road = new SolidBrush(Color.FromArgb(232, 237, 242));          // #E8EDF2
            PrefabRoad = new SolidBrush(Color.FromArgb(232, 237, 242));
            PrefabLight = new SolidBrush(Color.FromArgb(72, 82, 91));      // dark urban
            PrefabDark = new SolidBrush(Color.FromArgb(43, 51, 59));
            PrefabGreen = new SolidBrush(Color.FromArgb(43, 66, 61));
            CityName = Brushes.White;
            FerryLines = new SolidBrush(Color.FromArgb(123, 189, 233));    // NTG ice blue
            Error = new SolidBrush(Color.FromArgb(255, 100, 100));
        }
    }
}
