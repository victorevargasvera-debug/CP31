using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace Infragistics.Controls.Maps
{
	// Token: 0x0200005D RID: 93
	public abstract class XamMultiScaleTileSource : global::System.Windows.DependencyObject
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x00015EB8 File Offset: 0x000140B8
		protected XamMultiScaleTileSource(long imageWidth, long imageHeight, int tileWidth, int tileHeight, int tileOverlap)
		{
			this._imageWidth = imageWidth;
			this._imageHeight = imageHeight;
			this.TileWidth = tileWidth;
			this.TileHeight = tileHeight;
			this.TileOverlap = tileOverlap;
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00015EE5 File Offset: 0x000140E5
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x00015EED File Offset: 0x000140ED
		public long ImageWidth
		{
			get
			{
				return this._imageWidth;
			}
			protected internal set
			{
				this._imageWidth = value;
				this.InvalidateTileLayer(0, 0, 0, 0);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00015F00 File Offset: 0x00014100
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x00015F08 File Offset: 0x00014108
		public long ImageHeight
		{
			get
			{
				return this._imageHeight;
			}
			protected internal set
			{
				this._imageHeight = value;
				this.InvalidateTileLayer(0, 0, 0, 0);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x00015F1B File Offset: 0x0001411B
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x00015F23 File Offset: 0x00014123
		public int TileWidth { get; private set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00015F2C File Offset: 0x0001412C
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x00015F34 File Offset: 0x00014134
		public int TileHeight { get; private set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00015F3D File Offset: 0x0001413D
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x00015F45 File Offset: 0x00014145
		public int TileOverlap { get; private set; }

		// Token: 0x060005AC RID: 1452 RVA: 0x00015F50 File Offset: 0x00014150
		internal global::System.Uri GetTileUri(int tileLevel, int tilePositionX, int tilePositionY)
		{
			global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
			this.GetTileLayers(tileLevel, tilePositionX, tilePositionY, list);
			global::System.Uri result = null;
			if (list.Count > 0)
			{
				result = (list[0] as global::System.Uri);
			}
			return result;
		}

		// Token: 0x060005AD RID: 1453
		protected abstract void GetTileLayers(int tileLevel, int tilePositionX, int tilePositionY, global::System.Collections.Generic.IList<object> tileImageLayerSources);

		// Token: 0x060005AE RID: 1454 RVA: 0x00015F86 File Offset: 0x00014186
		protected void InvalidateTileLayer(int level, int tilePositionX, int tilePositionY, int tileLayer)
		{
			if (this.MultiScaleImage != null)
			{
				this.MultiScaleImage.InvalidateTileLayer(level, tilePositionX, tilePositionY, tileLayer);
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00015FA0 File Offset: 0x000141A0
		protected internal virtual bool IsImageStreamValid(global::System.IO.Stream stream)
		{
			bool result = false;
			if (stream.Length < 16L)
			{
				return false;
			}
			global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(stream);
			char[] array = new char[16];
			streamReader.Read(array, 0, 16);
			if (((array[1] == 'P' & array[2] == 'N') && array[3] == 'G') | (array[6] == 'J' & array[7] == 'F' & array[8] == 'I' & array[9] == 'F'))
			{
				result = true;
			}
			stream.Seek(0L, global::System.IO.SeekOrigin.Begin);
			return result;
		}

		// Token: 0x0400024C RID: 588
		private long _imageWidth;

		// Token: 0x0400024D RID: 589
		private long _imageHeight;

		// Token: 0x0400024E RID: 590
		internal global::Infragistics.Controls.Maps.XamMultiScaleImage MultiScaleImage;
	}
}
