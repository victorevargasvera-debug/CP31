using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Infragistics.Controls.Maps
{
	// Token: 0x020000E9 RID: 233
	internal class TileSubstituteSpatialCache
	{
		// Token: 0x060009B7 RID: 2487 RVA: 0x0002AE62 File Offset: 0x00029062
		public TileSubstituteSpatialCache(global::Infragistics.Controls.Maps.SpatialCache<global::System.Windows.Media.Imaging.BitmapImage> cache, int tileWidth, int tileHeight)
		{
			this._cache = cache;
			this._tileWidth = tileWidth;
			this._tileHeight = tileHeight;
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x0002AE7F File Offset: 0x0002907F
		public int Count
		{
			get
			{
				return this._cache.Count;
			}
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0002AE8C File Offset: 0x0002908C
		public void AddTile(int level, int tileX, int tileY, global::System.Windows.Media.Imaging.BitmapImage bitmapImage)
		{
			this._cache.AddItem(level, tileX, tileY, bitmapImage);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0002AE9E File Offset: 0x0002909E
		public bool ContainsTile(int level, int tileX, int tileY)
		{
			return this._cache.ContainsItem(level, tileX, tileY);
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0002AEB0 File Offset: 0x000290B0
		public global::Infragistics.Controls.Maps.TileSubstituteSpatialCache.TileData GetTileOrSubstitute(int level, int tileX, int tileY)
		{
			global::System.Windows.Media.Imaging.BitmapImage bitmapImage = null;
			global::System.Windows.Controls.Image image = null;
			global::System.Collections.Generic.List<global::System.Windows.Point> list = new global::System.Collections.Generic.List<global::System.Windows.Point>(3);
			while (level > 0)
			{
				bitmapImage = this._cache.GetItem(level, tileX, tileY);
				if (bitmapImage != null)
				{
					break;
				}
				list.Add(new global::System.Windows.Point((double)global::System.Convert.ToInt32((double)tileX % 2.0), (double)global::System.Convert.ToInt32((double)tileY % 2.0)));
				level--;
				tileX = global::System.Convert.ToInt32(tileX / 2);
				tileY = global::System.Convert.ToInt32(tileY / 2);
			}
			if (bitmapImage != null)
			{
				if (list.Count > 0)
				{
					double num = global::System.Math.Pow(2.0, (double)list.Count);
					double num2 = 0.0;
					double num3 = 0.0;
					int i = list.Count - 1;
					int num4 = 1;
					while (i >= 0)
					{
						num2 += list[i].X * ((double)this._tileWidth / global::System.Math.Pow(2.0, (double)num4));
						num3 += list[i].Y * ((double)this._tileHeight / global::System.Math.Pow(2.0, (double)num4));
						i--;
						num4++;
					}
					global::System.Windows.Media.TransformGroup transformGroup = new global::System.Windows.Media.TransformGroup();
					transformGroup.Children.Add(new global::System.Windows.Media.ScaleTransform
					{
						ScaleX = num,
						ScaleY = num
					});
					transformGroup.Children.Add(new global::System.Windows.Media.TranslateTransform
					{
						X = -num2,
						Y = -num3
					});
					int num5 = global::System.Convert.ToInt32((double)this._tileWidth / global::System.Math.Pow(2.0, (double)list.Count));
					int num6 = global::System.Convert.ToInt32((double)this._tileWidth / global::System.Math.Pow(2.0, (double)list.Count));
					if (num5 > 0 || num6 > 0)
					{
						global::System.Windows.Media.Imaging.CroppedBitmap source = new global::System.Windows.Media.Imaging.CroppedBitmap(bitmapImage, new global::System.Windows.Int32Rect(global::System.Convert.ToInt32(num2), global::System.Convert.ToInt32(num3), num5, num6));
						global::System.Windows.Media.Imaging.TransformedBitmap source2 = new global::System.Windows.Media.Imaging.TransformedBitmap(source, new global::System.Windows.Media.ScaleTransform
						{
							ScaleX = num,
							ScaleY = num
						});
						image = new global::System.Windows.Controls.Image
						{
							Source = source2
						};
					}
				}
				else
				{
					image = new global::System.Windows.Controls.Image
					{
						Source = bitmapImage
					};
				}
			}
			bool reloadTile = list.Count > 0 || image == null;
			return new global::Infragistics.Controls.Maps.TileSubstituteSpatialCache.TileData(image, reloadTile);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0002B10F File Offset: 0x0002930F
		public void RemoveTileAt(int level, int tileX, int tileY)
		{
			this._cache.RemoveItemAt(level, tileX, tileY);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0002B11F File Offset: 0x0002931F
		public void RemoveTilesAtLevel(int level)
		{
			this._cache.RemoveItemsAtLevel(level);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0002B12D File Offset: 0x0002932D
		public void ClearLevel(int level, int leftTile, int rightTile, int topTile, int bottomTile)
		{
			this._cache.ClearLevel(level, leftTile, rightTile, topTile, bottomTile);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0002B141 File Offset: 0x00029341
		public void Clear()
		{
			this._cache.Clear();
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0002B14E File Offset: 0x0002934E
		internal void Reset()
		{
			this._cache.Reset();
		}

		// Token: 0x04000376 RID: 886
		private readonly global::Infragistics.Controls.Maps.SpatialCache<global::System.Windows.Media.Imaging.BitmapImage> _cache;

		// Token: 0x04000377 RID: 887
		private readonly int _tileWidth;

		// Token: 0x04000378 RID: 888
		private readonly int _tileHeight;

		// Token: 0x020000EA RID: 234
		internal struct TileData
		{
			// Token: 0x060009C1 RID: 2497 RVA: 0x0002B15B File Offset: 0x0002935B
			public TileData(global::System.Windows.Controls.Image image, bool reloadTile)
			{
				this = default(global::Infragistics.Controls.Maps.TileSubstituteSpatialCache.TileData);
				this.Image = image;
				this.ReloadTile = reloadTile;
			}

			// Token: 0x17000257 RID: 599
			// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0002B172 File Offset: 0x00029372
			// (set) Token: 0x060009C3 RID: 2499 RVA: 0x0002B17A File Offset: 0x0002937A
			public global::System.Windows.Controls.Image Image { get; set; }

			// Token: 0x17000258 RID: 600
			// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0002B183 File Offset: 0x00029383
			// (set) Token: 0x060009C5 RID: 2501 RVA: 0x0002B18B File Offset: 0x0002938B
			public bool ReloadTile { get; set; }
		}
	}
}
