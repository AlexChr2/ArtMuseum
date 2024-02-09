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

		public static ColorMatrix CurrentMatrix { get; set; } = ColorMap[ 0 ];

		public readonly struct ColorMatrix( Color[] colorMatrix)
		{
			internal Color Color1 { get; } = colorMatrix[ 0 ];
			internal Color Color2 { get; } = colorMatrix[ 1 ];
			internal Color Color3 { get; } = colorMatrix[ 2 ];
		}
	}
}