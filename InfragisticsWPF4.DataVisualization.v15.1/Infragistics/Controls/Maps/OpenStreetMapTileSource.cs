using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Maps
{
	// Token: 0x02000063 RID: 99
	public sealed class OpenStreetMapTileSource : global::Infragistics.Controls.Maps.MapTileSource
	{
		// Token: 0x060005D5 RID: 1493 RVA: 0x0001692A File Offset: 0x00014B2A
		public OpenStreetMapTileSource() : base(134217728, 134217728, 256, 256, 0)
		{
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00016948 File Offset: 0x00014B48
		protected override void GetTileLayers(int tileLevel, int tilePositionX, int tilePositionY, global::System.Collections.Generic.IList<object> tileImageLayerSources)
		{
			int num = tileLevel - 8;
			if (num > 0)
			{
				string text = "http://tile.openstreetmap.org/{Z}/{X}/{Y}.png";
				text = text.Replace("{Z}", num.ToString());
				text = text.Replace("{X}", tilePositionX.ToString());
				text = text.Replace("{Y}", tilePositionY.ToString());
				tileImageLayerSources.Add(new global::System.Uri(text));
			}
		}

		// Token: 0x04000261 RID: 609
		private const string TilePathMapnik = "http://tile.openstreetmap.org/{Z}/{X}/{Y}.png";
	}
}
