using System;
using System.Runtime.CompilerServices;

namespace Infragistics.Controls.Maps
{
	// Token: 0x0200005E RID: 94
	[global::System.Runtime.CompilerServices.DontObfuscate]
	public abstract class MapTileSource : global::Infragistics.Controls.Maps.XamMultiScaleTileSource
	{
		// Token: 0x060005B0 RID: 1456 RVA: 0x00016021 File Offset: 0x00014221
		protected MapTileSource(int imageWidth, int imageHeight, int tileWidth, int tileHeight, int tileOverlap) : base((long)imageWidth, (long)imageHeight, tileWidth, tileHeight, tileOverlap)
		{
		}
	}
}
