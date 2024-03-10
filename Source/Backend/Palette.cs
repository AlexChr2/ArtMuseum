using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ergasia3.Source.Backend
{
	public static class Palette
	{

		public static ColorMatrix[] ColorMap { get; } =
		[
			new ColorMatrix(
				[Color.DarkSlateBlue,
				 Color.MediumSlateBlue,
				 Color.Snow]
				),
			new ColorMatrix(
				[Color.FromArgb( 255, 43, 45, 66 ),
				 Color.FromArgb( 255, 141, 153, 174 ),
				 Color.FromArgb( 255, 237, 242, 244 )]
				),
			new ColorMatrix(
				[Color.FromArgb( 255, 61, 64, 91 ),
				 Color.FromArgb( 255, 224, 122, 95 ),
				 Color.FromArgb( 255, 244, 241, 222 )]
				),
			new ColorMatrix(
				[Color.FromArgb( 255, 147, 129, 255 ),
				 Color.FromArgb( 255, 184, 184, 255 ),
				 Color.FromArgb( 255, 248, 247, 255 )]
				),
		];

		// a recursive function to apply a color palette to any form or panel and
		// all the controls inside them
		public static void ApplyColorMatrix( Control container, int paletteIndex )
		{
			foreach( Control control in container.Controls )
			{
				if( control is Panel || control is Label ||
					control is Button || control is PictureBox ||
					control is ListView || control is TextBox ||
					control is RichTextBox )
				{
					var backColor = control.BackColor;
					var foreColor = control.ForeColor;

					if( isInColorList( Palette.DarkColors, backColor ) )
						backColor = Palette.DarkColors[ paletteIndex ];

					if( isInColorList( Palette.MediumColors, backColor ) )
						backColor = Palette.MediumColors[ paletteIndex ];

					if( isInColorList( Palette.FrontColors, backColor ) )
						backColor = Palette.FrontColors[ paletteIndex ];

					if( isInColorList( Palette.DarkColors, foreColor ) )
						foreColor = Palette.DarkColors[ paletteIndex ];

					if( isInColorList( Palette.MediumColors, foreColor ) )
						foreColor = Palette.MediumColors[ paletteIndex ];

					if( isInColorList( Palette.FrontColors, foreColor ) )
						foreColor = Palette.FrontColors[ paletteIndex ];

					control.BackColor = backColor;
					control.ForeColor = foreColor;
				}

				ApplyColorMatrix( control, paletteIndex );
			}
		}

		private static bool isInColorList( Color[] colorList, Color targetColor )
		{
			foreach ( Color color in colorList )
				if ( color == targetColor )
					return true;
			return false;
		}

		public static Color[] DarkColors { get; } =
		[
			ColorMap[ 0 ].Color1,
			ColorMap[ 1 ].Color1,
			ColorMap[ 2 ].Color1,
			ColorMap[ 3 ].Color1
		];

		public static Color[] MediumColors { get; } =
		[
			ColorMap[ 0 ].Color2,
			ColorMap[ 1 ].Color2,
			ColorMap[ 2 ].Color2,
			ColorMap[ 3 ].Color2
		];

		public static Color[] FrontColors { get; } =
		[
			ColorMap[ 0 ].Color3,
			ColorMap[ 1 ].Color3,
			ColorMap[ 2 ].Color3,
			ColorMap[ 3 ].Color3
		];

		public readonly struct ColorMatrix( Color[] colorMatrix)
		{
			internal Color Color1 { get; } = colorMatrix[ 0 ];
			internal Color Color2 { get; } = colorMatrix[ 1 ];
			internal Color Color3 { get; } = colorMatrix[ 2 ];
		}
	}
}