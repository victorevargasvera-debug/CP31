using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;

namespace Infragistics.Controls.Maps
{
	// Token: 0x020000ED RID: 237
	public class XamMultiScaleImage : global::System.Windows.Controls.Control, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060009CB RID: 2507 RVA: 0x0002B1F0 File Offset: 0x000293F0
		public XamMultiScaleImage()
		{
			this.CanvasSize = global::System.Windows.Rect.Empty;
			this.View = new global::Infragistics.Controls.Maps.XamMultiScaleImageView(this);
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Maps.XamMultiScaleImage);
			this.ActualViewportOrigin = this.ViewportOrigin;
			this.ActualViewportWidth = this.ViewportWidth;
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0002B263 File Offset: 0x00029463
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x0002B26B File Offset: 0x0002946B
		internal global::Infragistics.Controls.Maps.XamMultiScaleImageView View { get; set; }

		// Token: 0x060009CE RID: 2510 RVA: 0x0002B274 File Offset: 0x00029474
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.ContentPresenter = (base.GetTemplateChild("ContentPresenter") as global::System.Windows.Controls.ContentPresenter);
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060009CF RID: 2511 RVA: 0x0002B292 File Offset: 0x00029492
		// (set) Token: 0x060009D0 RID: 2512 RVA: 0x0002B29C File Offset: 0x0002949C
		public global::System.Windows.Controls.ContentPresenter ContentPresenter
		{
			get
			{
				return this.contentPresenter;
			}
			private set
			{
				if (this.ContentPresenter != value)
				{
					if (this.ContentPresenter != null)
					{
						this.ContentPresenter.Content = null;
					}
					this.contentPresenter = value;
					if (this.ContentPresenter != null)
					{
						this.ContentPresenter.Content = this.View.Canvas;
					}
					this.Refresh();
				}
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060009D1 RID: 2513 RVA: 0x0002B2F1 File Offset: 0x000294F1
		// (set) Token: 0x060009D2 RID: 2514 RVA: 0x0002B2F9 File Offset: 0x000294F9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::Infragistics.Controls.Maps.IMapRenderDeferralHandler DeferralHandler
		{
			get
			{
				return this._deferralHandler;
			}
			set
			{
				if (this._deferralHandler != null)
				{
					this._deferralHandler.UnRegister(this);
				}
				this._deferralHandler = value;
				if (this._deferralHandler != null)
				{
					this._deferralHandler.Register(this, new global::System.Action<bool>(this.RefreshInternal));
				}
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060009D3 RID: 2515 RVA: 0x0002B336 File Offset: 0x00029536
		// (set) Token: 0x060009D4 RID: 2516 RVA: 0x0002B348 File Offset: 0x00029548
		public global::Infragistics.Controls.Maps.XamMultiScaleTileSource Source
		{
			get
			{
				return (global::Infragistics.Controls.Maps.XamMultiScaleTileSource)base.GetValue(global::Infragistics.Controls.Maps.XamMultiScaleImage.SourceProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.XamMultiScaleImage.SourceProperty, value);
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0002B356 File Offset: 0x00029556
		// (set) Token: 0x060009D6 RID: 2518 RVA: 0x0002B368 File Offset: 0x00029568
		public global::System.Windows.Point ViewportOrigin
		{
			get
			{
				return (global::System.Windows.Point)base.GetValue(global::Infragistics.Controls.Maps.XamMultiScaleImage.ViewportOriginProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.XamMultiScaleImage.ViewportOriginProperty, value);
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x0002B37B File Offset: 0x0002957B
		// (set) Token: 0x060009D8 RID: 2520 RVA: 0x0002B383 File Offset: 0x00029583
		internal global::System.Windows.Point ActualViewportOrigin { get; private set; }

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0002B38C File Offset: 0x0002958C
		// (set) Token: 0x060009DA RID: 2522 RVA: 0x0002B39E File Offset: 0x0002959E
		public double ViewportWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Maps.XamMultiScaleImage.ViewportWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.XamMultiScaleImage.ViewportWidthProperty, value);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060009DB RID: 2523 RVA: 0x0002B3B1 File Offset: 0x000295B1
		// (set) Token: 0x060009DC RID: 2524 RVA: 0x0002B3B9 File Offset: 0x000295B9
		internal double ActualViewportWidth { get; private set; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060009DD RID: 2525 RVA: 0x0002B3C2 File Offset: 0x000295C2
		// (set) Token: 0x060009DE RID: 2526 RVA: 0x0002B3D4 File Offset: 0x000295D4
		public bool UseSprings
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Maps.XamMultiScaleImage.UseSpringsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.XamMultiScaleImage.UseSpringsProperty, value);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060009DF RID: 2527 RVA: 0x0002B3E7 File Offset: 0x000295E7
		// (set) Token: 0x060009E0 RID: 2528 RVA: 0x0002B3F9 File Offset: 0x000295F9
		public global::System.Windows.Media.Animation.IEasingFunction SpringsEasingFunction
		{
			get
			{
				return (global::System.Windows.Media.Animation.IEasingFunction)base.GetValue(global::Infragistics.Controls.Maps.XamMultiScaleImage.SpringsEasingFunctionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Maps.XamMultiScaleImage.SpringsEasingFunctionProperty, value);
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060009E1 RID: 2529 RVA: 0x0002B408 File Offset: 0x00029608
		// (remove) Token: 0x060009E2 RID: 2530 RVA: 0x0002B440 File Offset: 0x00029640
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060009E3 RID: 2531 RVA: 0x0002B478 File Offset: 0x00029678
		protected virtual void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs ea)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, ea);
			}
			string propertyName;
			if ((propertyName = ea.PropertyName) != null)
			{
				if (propertyName == "Source")
				{
					if (this.Source != null)
					{
						this.Source.MultiScaleImage = this;
					}
					this.PurgeCache();
					this.ResetTiles();
					this.Refresh();
					return;
				}
				if (propertyName == "ViewportOrigin")
				{
					this.Spring();
					return;
				}
				if (propertyName == "ViewportWidth")
				{
					this.Spring();
					return;
				}
				if (!(propertyName == "UseSprings"))
				{
					return;
				}
				if (!this.UseSprings)
				{
					this.View.DisableSprings();
				}
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0002B521 File Offset: 0x00029721
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x0002B529 File Offset: 0x00029729
		private int LevelOffset { get; set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x0002B532 File Offset: 0x00029732
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x0002B53A File Offset: 0x0002973A
		private int MaxLevel { get; set; }

		// Token: 0x060009E8 RID: 2536 RVA: 0x0002B544 File Offset: 0x00029744
		private void ResetTiles()
		{
			this.TrashActiveTiles();
			if (this.Source != null)
			{
				this.LevelOffset = global::System.Convert.ToInt32(global::System.Math.Log((double)this.Source.TileWidth, 2.0));
				this.MaxLevel = global::System.Convert.ToInt32(global::System.Math.Log((double)this.Source.ImageWidth, 2.0));
			}
		}

		// Token: 0x060009E9 RID: 2537 RVA: 0x0002B5A9 File Offset: 0x000297A9
		public void InvalidateTileLayer(int level, int tilePositionX, int tilePositionY, int tileLayer)
		{
			this.PurgeCache();
			this.ResetTiles();
			this.Refresh();
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x0002B5C0 File Offset: 0x000297C0
		private void Spring()
		{
			if (this.UseSprings)
			{
				this.SpringStart = global::System.DateTime.Now;
				this.anchorViewportOrigin = this.ActualViewportOrigin;
				this.anchorViewportWidth = this.ActualViewportWidth;
				this.View.StartSpringTimer();
				return;
			}
			this.ActualViewportOrigin = this.ViewportOrigin;
			this.ActualViewportWidth = this.ViewportWidth;
			this.Refresh();
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0002B624 File Offset: 0x00029824
		internal void SpringTimer_Tick()
		{
			double num = 2.0;
			double totalSeconds = (global::System.DateTime.Now - this.SpringStart).TotalSeconds;
			double num2 = global::Infragistics.MathUtil.Clamp(totalSeconds / num, 0.0, 1.0);
			double num3 = (this.SpringsEasingFunction != null) ? this.SpringsEasingFunction.Ease(num2) : num2;
			double num4 = 1.0 - num3;
			this.ActualViewportWidth = this.anchorViewportWidth * num4 + this.ViewportWidth * num3;
			this.ActualViewportOrigin = new global::System.Windows.Point(this.anchorViewportOrigin.X * num4 + this.ViewportOrigin.X * num3, this.anchorViewportOrigin.Y * num4 + this.ViewportOrigin.Y * num3);
			if (num2 >= 1.0)
			{
				this.View.StopSpringTimer();
			}
			this.Refresh();
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x0002B71C File Offset: 0x0002991C
		private int ActiveTileIndex(int x, int y, int z)
		{
			for (int i = 0; i < this.activeTiles.Count; i++)
			{
				if (this.activeTiles[i].X == x && this.activeTiles[i].Y == y && this.activeTiles[i].Z == z)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x0002B780 File Offset: 0x00029980
		internal void RefreshInternal(bool animate)
		{
			this.refreshDeferred = false;
			this._lastReady = false;
			if (this.Source == null || !this.View.Ready() || this.CanvasSize.Width == 0.0 || this.CanvasSize.Height == 0.0)
			{
				return;
			}
			int num = (int)global::System.Math.Ceiling(this.CanvasSize.Width / (double)this.Source.TileWidth);
			int num2 = (int)global::System.Math.Max(1.0, global::System.Math.Floor(-global::System.Math.Log(this.ActualViewportWidth / (double)num, 2.0)));
			if (num2 >= this.MaxLevel - 8)
			{
				num2 = this.MaxLevel - 8 - 1;
			}
			int val = global::System.Convert.ToInt32(global::System.Math.Pow(2.0, (double)num2));
			double actualViewportWidth = this.ActualViewportWidth;
			double num3 = this.CanvasSize.Height * actualViewportWidth / this.CanvasSize.Width;
			double num4 = (double)this.Source.ImageWidth / global::System.Math.Pow(2.0, (double)num2);
			double num5 = (double)this.Source.ImageHeight / global::System.Math.Pow(2.0, (double)num2);
			int num6 = global::System.Math.Max((int)global::System.Math.Floor(this.ActualViewportOrigin.X * (double)this.Source.ImageWidth / num4), 0);
			int num7 = global::System.Math.Min((int)global::System.Math.Ceiling((this.ActualViewportOrigin.X + actualViewportWidth) * (double)this.Source.ImageWidth / num4), val);
			int num8 = global::System.Math.Max((int)global::System.Math.Floor(this.ActualViewportOrigin.Y * (double)this.Source.ImageHeight / num5), 0);
			int num9 = global::System.Math.Min((int)global::System.Math.Ceiling((this.ActualViewportOrigin.Y + num3) * (double)this.Source.ImageWidth / num5), val);
			double num10 = ((double)num6 * num4 - this.ActualViewportOrigin.X * (double)this.Source.ImageWidth) / num4;
			double num11 = ((double)num8 * num5 - this.ActualViewportOrigin.Y * (double)this.Source.ImageHeight) / num5;
			double num12 = actualViewportWidth * (double)this.Source.ImageWidth / num4 * ((double)this.Source.TileWidth / this.CanvasSize.Width);
			global::System.Collections.Generic.List<global::Infragistics.Controls.Maps.Tile> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Maps.Tile>();
			for (int i = num6; i < num7; i++)
			{
				for (int j = num8; j < num9; j++)
				{
					int num13 = this.ActiveTileIndex(i, j, num2);
					if (num13 >= 0)
					{
						list.Add(this.activeTiles[num13]);
						this.activeTiles.RemoveAt(num13);
					}
					else
					{
						list.Add(new global::Infragistics.Controls.Maps.Tile
						{
							X = i,
							Y = j,
							Z = num2
						});
					}
				}
			}
			this.ImagePool.DeferDisactivate = true;
			this.TrashActiveTiles();
			this.activeTiles = list;
			for (int k = 0; k < this.activeTiles.Count; k++)
			{
				if (this.activeTiles[k].Image == null)
				{
					this.activeTiles[k].Image = this.ImagePool.Pop();
					this.activeTiles[k].Image.Opacity = 1.0;
					this.View.SendToBackground(this.activeTiles[k].Image);
					global::System.Windows.Media.Imaging.WriteableBitmap cachedBitmap = this.GetCachedBitmap(this.activeTiles[k]);
					if (cachedBitmap != null)
					{
						this.activeTiles[k].Image.Source = cachedBitmap;
					}
					else
					{
						global::System.Windows.Media.Imaging.WriteableBitmap writeableBitmap = null;
						global::Infragistics.Controls.Maps.Tile tile = new global::Infragistics.Controls.Maps.Tile
						{
							X = this.activeTiles[k].X,
							Y = this.activeTiles[k].Y,
							Z = this.activeTiles[k].Z
						};
						while (tile.Z >= 0 && writeableBitmap == null)
						{
							tile.X >>= 1;
							tile.Y >>= 1;
							tile.Z--;
							writeableBitmap = this.GetCachedBitmap(tile);
						}
						if (writeableBitmap != null)
						{
							int num14 = (int)global::System.Math.Pow(2.0, (double)(this.activeTiles[k].Z - tile.Z));
							int num15 = 256 / num14;
							int x = num15 * (this.activeTiles[k].X % num14);
							int y = num15 * (this.activeTiles[k].Y % num14);
							this.activeTiles[k].GhostImage = this.ImagePool.Pop();
							this.activeTiles[k].GhostImage.Opacity = 1.0;
							this.View.SendToForeground(this.activeTiles[k].GhostImage);
							num15 = global::System.Math.Max(1, num15);
							this.activeTiles[k].GhostImage.Source = new global::System.Windows.Media.Imaging.CroppedBitmap(writeableBitmap, new global::System.Windows.Int32Rect(x, y, num15, num15));
						}
						this.View.Download(this.activeTiles[k]);
					}
				}
				double num16 = (double)this.Source.TileWidth / num12;
				double num17 = (double)this.Source.TileHeight / num12;
				double il = ((double)(this.activeTiles[k].X - num6) + num10) * num16;
				double it = ((double)(this.activeTiles[k].Y - num8) + num11) * num17;
				this.activeTiles[k].Image.Width = num16 + 0.5;
				this.activeTiles[k].Image.Height = num17 + 0.5;
				this.View.SetImagePosition(this.activeTiles[k].Image, il, it);
				if (this.activeTiles[k].GhostImage != null)
				{
					this.activeTiles[k].GhostImage.Width = num16 + 0.5;
					this.activeTiles[k].GhostImage.Height = num17 + 0.5;
					this.View.SetImagePosition(this.activeTiles[k].GhostImage, il, it);
				}
			}
			this.ImagePool.DeferDisactivate = false;
			this.View.RefreshCompleted();
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x0002BE80 File Offset: 0x0002A080
		internal void Refresh()
		{
			if (this.Source == null || !this.View.Ready() || this.CanvasSize.Width == 0.0 || this.CanvasSize.Height == 0.0)
			{
				return;
			}
			if (this.refreshDeferred)
			{
				return;
			}
			this.refreshDeferred = true;
			this.View.Defer(new global::System.Action<bool>(this.RefreshInternal));
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x0002BEFC File Offset: 0x0002A0FC
		private void TrashActiveTiles()
		{
			for (int i = 0; i < this.activeTiles.Count; i++)
			{
				this.View.CancelDownload(this.activeTiles[i]);
				this.CancelFade(this.activeTiles[i]);
				if (this.activeTiles[i].Image != null)
				{
					this.ImagePool.Push(this.activeTiles[i].Image);
					this.activeTiles[i].Image.Source = null;
					this.activeTiles[i].Image = null;
				}
			}
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x0002BFA6 File Offset: 0x0002A1A6
		private void PurgeCache()
		{
			this.cache.Clear();
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x0002BFB4 File Offset: 0x0002A1B4
		private global::System.Windows.Media.Imaging.WriteableBitmap GetCachedBitmap(global::Infragistics.Controls.Maps.Tile tile)
		{
			for (int i = 0; i < this.cache.Count; i++)
			{
				if (this.cache[i].First.X == tile.X && this.cache[i].First.Y == tile.Y && this.cache[i].First.Z == tile.Z)
				{
					return this.cache[i].Second;
				}
			}
			return null;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x0002C044 File Offset: 0x0002A244
		internal void CacheBitmap(global::Infragistics.Controls.Maps.Tile tile, global::System.Windows.Media.Imaging.WriteableBitmap bitmap)
		{
			this.cache.Add(new global::Infragistics.Controls.Maps.Pair<global::Infragistics.Controls.Maps.Tile, global::System.Windows.Media.Imaging.WriteableBitmap>(tile, bitmap));
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060009F3 RID: 2547 RVA: 0x0002C058 File Offset: 0x0002A258
		// (remove) Token: 0x060009F4 RID: 2548 RVA: 0x0002C090 File Offset: 0x0002A290
		public event global::Infragistics.Controls.Maps.ImageStreamValidEventHandler ImageStreamValid;

		// Token: 0x060009F5 RID: 2549 RVA: 0x0002C0C8 File Offset: 0x0002A2C8
		internal bool IsImageStreamValid(global::System.IO.Stream stream)
		{
			bool flag = true;
			if (this.ImageStreamValid != null)
			{
				flag = this.ImageStreamValid(this, new global::Infragistics.Controls.Maps.ImageStreamValidEventArgs(stream));
				if (flag && stream.CanSeek)
				{
					stream.Seek(0L, global::System.IO.SeekOrigin.Begin);
				}
				else if (!flag)
				{
					return false;
				}
			}
			if (flag && this.Source != null)
			{
				if (!this.Source.IsImageStreamValid(stream))
				{
					flag = false;
				}
				if (flag && stream.CanSeek)
				{
					stream.Seek(0L, global::System.IO.SeekOrigin.Begin);
				}
			}
			return flag;
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0002C13F File Offset: 0x0002A33F
		internal bool IsDuringFade()
		{
			return this.fadingTiles.Count != 0;
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060009F7 RID: 2551 RVA: 0x0002C154 File Offset: 0x0002A354
		// (remove) Token: 0x060009F8 RID: 2552 RVA: 0x0002C18C File Offset: 0x0002A38C
		public event global::System.EventHandler<global::System.EventArgs> ImageTilesReady;

		// Token: 0x060009F9 RID: 2553 RVA: 0x0002C1C4 File Offset: 0x0002A3C4
		protected internal void NotifyReady()
		{
			bool flag = true;
			if (this.IsDuringFade())
			{
				flag = false;
			}
			if (!this.View.ImagesReady())
			{
				flag = false;
			}
			if (flag && !this._lastReady && this.ImageTilesReady != null)
			{
				this.ImageTilesReady(this, new global::System.EventArgs());
			}
			this._lastReady = flag;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0002C217 File Offset: 0x0002A417
		internal void StartFade(global::Infragistics.Controls.Maps.Tile tile)
		{
			if (tile.GhostImage != null)
			{
				tile.FadeStart = global::System.DateTime.Now;
				this.fadingTiles.Add(tile);
				this.View.StartFadeTimer();
				return;
			}
			this.NotifyReady();
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0002C24C File Offset: 0x0002A44C
		private void CancelFade(global::Infragistics.Controls.Maps.Tile tile)
		{
			if (tile.GhostImage != null)
			{
				this.ImagePool.Push(tile.GhostImage);
				tile.GhostImage.Source = null;
				tile.GhostImage = null;
				for (int i = 0; i < this.fadingTiles.Count; i++)
				{
					if (this.fadingTiles[i] == tile)
					{
						this.fadingTiles.RemoveAt(i);
						break;
					}
				}
				if (this.fadingTiles.Count == 0)
				{
					this.View.StopFadeTimer();
				}
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0002C2D0 File Offset: 0x0002A4D0
		internal void FadeTimer_Tick()
		{
			global::System.DateTime now = global::System.DateTime.Now;
			double num = 0.5;
			int i = 0;
			while (i < this.fadingTiles.Count)
			{
				double totalSeconds = (now - this.fadingTiles[i].FadeStart).TotalSeconds;
				double num2 = totalSeconds / num;
				num2 = global::Infragistics.MathUtil.Clamp(num2, 0.0, 1.0);
				this.fadingTiles[i].GhostImage.Opacity = 1.0 - num2;
				if (num2 >= 1.0)
				{
					this.ImagePool.Push(this.fadingTiles[i].GhostImage);
					this.fadingTiles[i].GhostImage.Source = null;
					this.fadingTiles[i].GhostImage = null;
					this.fadingTiles.RemoveAt(i);
				}
				else
				{
					i++;
				}
				this.View.FadingChanged();
			}
			if (this.fadingTiles.Count == 0)
			{
				this.View.StopFadeTimer();
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x0002C3F0 File Offset: 0x0002A5F0
		// (set) Token: 0x060009FE RID: 2558 RVA: 0x0002C3F8 File Offset: 0x0002A5F8
		internal global::System.Windows.Rect CanvasSize { get; set; }

		// Token: 0x060009FF RID: 2559 RVA: 0x0002C401 File Offset: 0x0002A601
		internal void OnSpringsDisabled()
		{
			this.ActualViewportWidth = this.ViewportWidth;
			this.ActualViewportOrigin = this.ViewportOrigin;
			this.Refresh();
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0002C421 File Offset: 0x0002A621
		internal void DeferCancelled()
		{
			this.refreshDeferred = false;
		}

		// Token: 0x04000381 RID: 897
		private const string ContentPresenterElementName = "ContentPresenter";

		// Token: 0x04000382 RID: 898
		internal const string SourcePropertyName = "Source";

		// Token: 0x04000383 RID: 899
		internal const string ViewportOriginPropertyName = "ViewportOrigin";

		// Token: 0x04000384 RID: 900
		internal const string ViewportWidthPropertyName = "ViewportWidth";

		// Token: 0x04000385 RID: 901
		internal const string UseSpringsPropertyName = "UseSprings";

		// Token: 0x04000386 RID: 902
		internal const string SpringsEasingFunctionPropertyName = "SpringsEasingFunction";

		// Token: 0x04000387 RID: 903
		internal global::Infragistics.StackPool<global::System.Windows.Controls.Image> ImagePool;

		// Token: 0x04000388 RID: 904
		private global::System.Windows.Controls.ContentPresenter contentPresenter;

		// Token: 0x04000389 RID: 905
		private global::Infragistics.Controls.Maps.IMapRenderDeferralHandler _deferralHandler;

		// Token: 0x0400038A RID: 906
		public static readonly global::System.Windows.DependencyProperty SourceProperty = global::System.Windows.DependencyProperty.Register("Source", typeof(global::Infragistics.Controls.Maps.XamMultiScaleTileSource), typeof(global::Infragistics.Controls.Maps.XamMultiScaleImage), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Maps.XamMultiScaleImage)sender).OnPropertyChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<global::Infragistics.Controls.Maps.XamMultiScaleTileSource>("Source", e.OldValue as global::Infragistics.Controls.Maps.XamMultiScaleTileSource, e.NewValue as global::Infragistics.Controls.Maps.XamMultiScaleTileSource));
		}));

		// Token: 0x0400038B RID: 907
		public static readonly global::System.Windows.DependencyProperty ViewportOriginProperty = global::System.Windows.DependencyProperty.Register("ViewportOrigin", typeof(global::System.Windows.Point), typeof(global::Infragistics.Controls.Maps.XamMultiScaleImage), new global::System.Windows.PropertyMetadata(new global::System.Windows.Point(0.0, 0.0), delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Maps.XamMultiScaleImage)sender).OnPropertyChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Point>("ViewportOrigin", (global::System.Windows.Point)e.OldValue, (global::System.Windows.Point)e.NewValue));
		}));

		// Token: 0x0400038C RID: 908
		public static readonly global::System.Windows.DependencyProperty ViewportWidthProperty = global::System.Windows.DependencyProperty.Register("ViewportWidth", typeof(double), typeof(global::Infragistics.Controls.Maps.XamMultiScaleImage), new global::System.Windows.PropertyMetadata(1.0, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Maps.XamMultiScaleImage)sender).OnPropertyChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<double>("ViewportWidth", (double)e.OldValue, (double)e.NewValue));
		}));

		// Token: 0x0400038D RID: 909
		public static readonly global::System.Windows.DependencyProperty UseSpringsProperty = global::System.Windows.DependencyProperty.Register("UseSprings", typeof(bool), typeof(global::Infragistics.Controls.Maps.XamMultiScaleImage), new global::System.Windows.PropertyMetadata(false, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Maps.XamMultiScaleImage)sender).OnPropertyChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<bool>("UseSprings", (bool)e.OldValue, (bool)e.NewValue));
		}));

		// Token: 0x0400038E RID: 910
		public static readonly global::System.Windows.DependencyProperty SpringsEasingFunctionProperty = global::System.Windows.DependencyProperty.Register("SpringsEasingFunction", typeof(global::System.Windows.Media.Animation.IEasingFunction), typeof(global::Infragistics.Controls.Maps.XamMultiScaleImage), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Maps.XamMultiScaleImage)sender).OnPropertyChanged(new global::Infragistics.Controls.PropertyChangedEventArgs<global::System.Windows.Media.Animation.IEasingFunction>("SpringsEasingFunction", (global::System.Windows.Media.Animation.IEasingFunction)e.OldValue, (global::System.Windows.Media.Animation.IEasingFunction)e.NewValue));
		}));

		// Token: 0x04000390 RID: 912
		private global::System.DateTime SpringStart;

		// Token: 0x04000391 RID: 913
		private global::System.Windows.Point anchorViewportOrigin;

		// Token: 0x04000392 RID: 914
		private double anchorViewportWidth;

		// Token: 0x04000393 RID: 915
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Maps.Tile> activeTiles = new global::System.Collections.Generic.List<global::Infragistics.Controls.Maps.Tile>();

		// Token: 0x04000394 RID: 916
		private bool refreshDeferred;

		// Token: 0x04000395 RID: 917
		private readonly global::System.Collections.Generic.List<global::Infragistics.Controls.Maps.Pair<global::Infragistics.Controls.Maps.Tile, global::System.Windows.Media.Imaging.WriteableBitmap>> cache = new global::System.Collections.Generic.List<global::Infragistics.Controls.Maps.Pair<global::Infragistics.Controls.Maps.Tile, global::System.Windows.Media.Imaging.WriteableBitmap>>();

		// Token: 0x04000397 RID: 919
		private readonly global::System.Collections.Generic.List<global::Infragistics.Controls.Maps.Tile> fadingTiles = new global::System.Collections.Generic.List<global::Infragistics.Controls.Maps.Tile>();

		// Token: 0x04000399 RID: 921
		private bool _lastReady;
	}
}
