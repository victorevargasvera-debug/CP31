using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Infragistics.Controls.Maps
{
	// Token: 0x020000F1 RID: 241
	internal class XamMultiScaleImageView
	{
		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0002C708 File Offset: 0x0002A908
		// (set) Token: 0x06000A14 RID: 2580 RVA: 0x0002C710 File Offset: 0x0002A910
		protected global::Infragistics.Controls.Maps.XamMultiScaleImage Model { get; set; }

		// Token: 0x06000A15 RID: 2581 RVA: 0x0002C7CC File Offset: 0x0002A9CC
		public XamMultiScaleImageView(global::Infragistics.Controls.Maps.XamMultiScaleImage model)
		{
			this.Model = model;
			this.FadeTimer.Tick += delegate(object o, global::System.EventArgs e)
			{
				this.Model.FadeTimer_Tick();
			};
			this.SpringTimer.Tick += delegate(object o, global::System.EventArgs e)
			{
				this.Model.SpringTimer_Tick();
			};
			this.Model.ImagePool = new global::Infragistics.StackPool<global::System.Windows.Controls.Image>
			{
				Create = new global::System.Func<global::System.Windows.Controls.Image>(this.Image_Create),
				Activate = new global::System.Action<global::System.Windows.Controls.Image>(this.Image_Activate),
				Deactivate = new global::System.Action<global::System.Windows.Controls.Image>(this.Image_Disactivate),
				Destroy = new global::System.Action<global::System.Windows.Controls.Image>(this.Image_Destroy)
			};
			for (int i = 0; i < 4; i++)
			{
				global::System.Net.WebClient webClient = new global::System.Net.WebClient();
				webClient.DownloadDataCompleted += this.DownloadClient_DownloadDataCompleted;
				this.DownloadClient.Add(webClient);
				this.DownloadTile.Add(null);
			}
			this.Model.CanvasSize = new global::System.Windows.Rect(0.0, 0.0, this.Canvas.ActualWidth, this.Canvas.ActualHeight);
			this.Canvas.SizeChanged += delegate(object o, global::System.Windows.SizeChangedEventArgs e)
			{
				this.Model.CanvasSize = new global::System.Windows.Rect(0.0, 0.0, this.Canvas.ActualWidth, this.Canvas.ActualHeight);
				this.Canvas.Clip = new global::System.Windows.Media.RectangleGeometry
				{
					Rect = new global::System.Windows.Rect(0.0, 0.0, this.Canvas.ActualWidth, this.Canvas.ActualHeight)
				};
				this.Model.Refresh();
			};
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0002C998 File Offset: 0x0002AB98
		private global::System.Windows.Controls.Image Image_Create()
		{
			return new global::System.Windows.Controls.Image
			{
				UseLayoutRounding = false,
				IsHitTestVisible = false
			};
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0002C9BA File Offset: 0x0002ABBA
		private void Image_Activate(global::System.Windows.Controls.Image image)
		{
			this.Canvas.Children.Add(image);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0002C9CE File Offset: 0x0002ABCE
		private void Image_Disactivate(global::System.Windows.Controls.Image image)
		{
			this.Canvas.Children.Remove(image);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0002C9E1 File Offset: 0x0002ABE1
		private void Image_Destroy(global::System.Windows.Controls.Image image)
		{
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0002C9E4 File Offset: 0x0002ABE4
		internal bool ImagesReady()
		{
			bool result = true;
			for (int i = 0; i < this.DownloadTile.Count; i++)
			{
				if (this.DownloadTile[i] != null)
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0002CA1A File Offset: 0x0002AC1A
		internal void SetImagePosition(global::System.Windows.Controls.Image image, double il, double it)
		{
			image.Width = global::System.Math.Round(image.Width);
			image.Height = global::System.Math.Round(image.Height);
			global::System.Windows.Controls.Canvas.SetLeft(image, global::System.Math.Round(il));
			global::System.Windows.Controls.Canvas.SetTop(image, global::System.Math.Round(it));
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0002CA58 File Offset: 0x0002AC58
		internal void CancelDownload(global::Infragistics.Controls.Maps.Tile tile)
		{
			for (int i = 0; i < this.DownloadTile.Count; i++)
			{
				if (tile == this.DownloadTile[i])
				{
					this.DownloadClient[i].CancelAsync();
					return;
				}
			}
			for (int j = 0; j < this.pendingTiles.Count; j++)
			{
				if (this.pendingTiles[j] == tile)
				{
					this.pendingTiles.RemoveAt(j);
					return;
				}
			}
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0002CB27 File Offset: 0x0002AD27
		internal void Download(global::Infragistics.Controls.Maps.Tile tile)
		{
			this.pendingTiles.Add(tile);
			this.pendingTiles.Sort(delegate(global::Infragistics.Controls.Maps.Tile a, global::Infragistics.Controls.Maps.Tile b)
			{
				int num = (a.GhostImage != null) ? (a.GhostImage.Source as global::System.Windows.Media.Imaging.BitmapSource).PixelWidth : 0;
				int value = (b.GhostImage != null) ? (b.GhostImage.Source as global::System.Windows.Media.Imaging.BitmapSource).PixelWidth : 0;
				return num.CompareTo(value);
			});
			this.BumpDownload();
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0002CB64 File Offset: 0x0002AD64
		private void BumpDownload()
		{
			global::Infragistics.Controls.Maps.XamMultiScaleTileSource source;
			try
			{
				source = this.Model.Source;
			}
			catch (global::System.UnauthorizedAccessException)
			{
				return;
			}
			int num = -1;
			if (this.pendingTiles.Count > 0)
			{
				for (int i = 0; i < this.DownloadTile.Count; i++)
				{
					if (this.DownloadTile[i] == null)
					{
						num = i;
						break;
					}
				}
			}
			if (num >= 0)
			{
				global::System.Net.WebClient webClient = this.DownloadClient[num];
				this.DownloadTile[num] = this.pendingTiles[0];
				this.pendingTiles.RemoveAt(0);
				global::System.Uri tileUri = source.GetTileUri(this.DownloadTile[num].Z + 8, this.DownloadTile[num].X, this.DownloadTile[num].Y);
				if (tileUri == null)
				{
					this.DownloadTile[num] = null;
					this.BumpDownload();
					return;
				}
				webClient.DownloadDataAsync(tileUri, num);
			}
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0002CC70 File Offset: 0x0002AE70
		private void DownloadClient_DownloadDataCompleted(object sender, global::System.Net.DownloadDataCompletedEventArgs e)
		{
			int index = (int)e.UserState;
			global::Infragistics.Controls.Maps.Tile tile = this.DownloadTile[index];
			this.DownloadTile[index] = null;
			global::Infragistics.Controls.Maps.XamMultiScaleTileSource source;
			try
			{
				source = this.Model.Source;
			}
			catch (global::System.UnauthorizedAccessException)
			{
				return;
			}
			if (e.Error == null && !e.Cancelled && source != null)
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(e.Result);
				bool flag = this.Model.IsImageStreamValid(memoryStream);
				if (flag)
				{
					global::System.Windows.Media.Imaging.BitmapImage bitmapImage = new global::System.Windows.Media.Imaging.BitmapImage();
					bitmapImage.BeginInit();
					bitmapImage.StreamSource = memoryStream;
					bitmapImage.EndInit();
					global::System.Windows.Media.Imaging.WriteableBitmap writeableBitmap = new global::System.Windows.Media.Imaging.WriteableBitmap(bitmapImage);
					this.Model.CacheBitmap(tile, writeableBitmap);
					if (tile.Image != null)
					{
						tile.Image.Source = null;
						tile.Image.Source = writeableBitmap;
						tile.Image.InvalidateVisual();
						this.Model.StartFade(tile);
					}
				}
			}
			this.BumpDownload();
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0002CD78 File Offset: 0x0002AF78
		internal void SendToBackground(global::System.Windows.Controls.Image image)
		{
			global::System.Windows.Controls.Panel.SetZIndex(image, 0);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0002CD81 File Offset: 0x0002AF81
		internal void SendToForeground(global::System.Windows.Controls.Image image)
		{
			global::System.Windows.Controls.Panel.SetZIndex(image, 1);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0002CD8A File Offset: 0x0002AF8A
		internal bool Ready()
		{
			return this.Model.ContentPresenter != null;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0002CDB4 File Offset: 0x0002AFB4
		internal void Defer(global::System.Action<bool> work)
		{
			if (this.Model.DeferralHandler != null)
			{
				this.Model.DeferralHandler.DeferredRefresh();
				return;
			}
			this.Model.Dispatcher.BeginInvoke(new global::System.Action(delegate()
			{
				work(false);
			}), new object[0]);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0002CE16 File Offset: 0x0002B016
		internal void StartSpringTimer()
		{
			if (!this.SpringTimer.IsEnabled)
			{
				this.SpringTimer.Start();
			}
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0002CE30 File Offset: 0x0002B030
		internal void StopSpringTimer()
		{
			this.SpringTimer.Stop();
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0002CE3D File Offset: 0x0002B03D
		internal void StartFadeTimer()
		{
			if (!this.FadeTimer.IsEnabled)
			{
				this.FadeTimer.Start();
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0002CE57 File Offset: 0x0002B057
		internal void StopFadeTimer()
		{
			if (this.FadeTimer.IsEnabled)
			{
				this.FadeTimer.Stop();
			}
			this.Model.NotifyReady();
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0002CE7C File Offset: 0x0002B07C
		internal void DisableSprings()
		{
			if (this.SpringTimer.IsEnabled)
			{
				this.SpringTimer.Stop();
				this.Model.OnSpringsDisabled();
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0002CEA1 File Offset: 0x0002B0A1
		internal void RefreshCompleted()
		{
			this.Model.NotifyReady();
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0002CEAE File Offset: 0x0002B0AE
		internal void FadingChanged()
		{
		}

		// Token: 0x040003A8 RID: 936
		internal readonly global::System.Windows.Controls.Canvas Canvas = new global::System.Windows.Controls.Canvas
		{
			UseLayoutRounding = false
		};

		// Token: 0x040003A9 RID: 937
		private readonly global::System.Collections.Generic.List<global::System.Net.WebClient> DownloadClient = new global::System.Collections.Generic.List<global::System.Net.WebClient>();

		// Token: 0x040003AA RID: 938
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Maps.Tile> pendingTiles = new global::System.Collections.Generic.List<global::Infragistics.Controls.Maps.Tile>();

		// Token: 0x040003AB RID: 939
		private readonly global::System.Collections.Generic.List<global::Infragistics.Controls.Maps.Tile> DownloadTile = new global::System.Collections.Generic.List<global::Infragistics.Controls.Maps.Tile>();

		// Token: 0x040003AC RID: 940
		private readonly global::System.Windows.Threading.DispatcherTimer FadeTimer = new global::System.Windows.Threading.DispatcherTimer
		{
			Interval = global::System.TimeSpan.FromSeconds(0.05)
		};

		// Token: 0x040003AD RID: 941
		private global::System.Windows.Threading.DispatcherTimer SpringTimer = new global::System.Windows.Threading.DispatcherTimer
		{
			Interval = global::System.TimeSpan.FromSeconds(0.05)
		};
	}
}
