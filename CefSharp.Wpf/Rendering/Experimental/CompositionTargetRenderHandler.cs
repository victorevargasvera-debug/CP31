using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using CefSharp.Structs;

namespace CefSharp.Wpf.Rendering.Experimental
{
	// Token: 0x02000011 RID: 17
	public class CompositionTargetRenderHandler : global::CefSharp.Wpf.IRenderHandler, global::System.IDisposable
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00005AD4 File Offset: 0x00003CD4
		public CompositionTargetRenderHandler(global::CefSharp.Wpf.ChromiumWebBrowser browser, double dpiX, double dpiY)
		{
			this.browser = browser;
			this.browser.IsVisibleChanged += this.BrowserIsVisibleChanged;
			this.view = new global::CefSharp.Wpf.Rendering.Experimental.CompositionTargetRenderHandler.PaintElement(dpiX, dpiY);
			this.popup = new global::CefSharp.Wpf.Rendering.Experimental.CompositionTargetRenderHandler.PaintElement(dpiX, dpiY);
			if (browser.IsVisible)
			{
				global::System.Windows.Media.CompositionTarget.Rendering += this.OnRendering;
			}
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00005B43 File Offset: 0x00003D43
		private void BrowserIsVisibleChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if ((bool)e.NewValue)
			{
				global::System.Windows.Media.CompositionTarget.Rendering += this.OnRendering;
				return;
			}
			global::System.Windows.Media.CompositionTarget.Rendering -= this.OnRendering;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00005B78 File Offset: 0x00003D78
		void global::System.IDisposable.Dispose()
		{
			global::System.Windows.Media.CompositionTarget.Rendering -= this.OnRendering;
			if (this.browser != null)
			{
				this.browser.IsVisibleChanged -= this.BrowserIsVisibleChanged;
				this.browser = null;
			}
			object obj = this.lockObj;
			lock (obj)
			{
				global::CefSharp.Wpf.Rendering.Experimental.CompositionTargetRenderHandler.PaintElement paintElement = this.view;
				if (paintElement != null)
				{
					paintElement.Dispose();
				}
				this.view = null;
				global::CefSharp.Wpf.Rendering.Experimental.CompositionTargetRenderHandler.PaintElement paintElement2 = this.popup;
				if (paintElement2 != null)
				{
					paintElement2.Dispose();
				}
				this.popup = null;
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00005C1C File Offset: 0x00003E1C
		void global::CefSharp.Wpf.IRenderHandler.OnAcceleratedPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr sharedHandle)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00005C24 File Offset: 0x00003E24
		void global::CefSharp.Wpf.IRenderHandler.OnPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr buffer, int width, int height, global::System.Windows.Controls.Image image)
		{
			if (image.Dispatcher.HasShutdownStarted)
			{
				return;
			}
			object obj = this.lockObj;
			lock (obj)
			{
				global::CefSharp.Wpf.Rendering.Experimental.CompositionTargetRenderHandler.PaintElement paintElement = isPopup ? this.popup : this.view;
				if (paintElement != null)
				{
					paintElement.OnPaint(dirtyRect, buffer, width, height, image);
				}
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00005C94 File Offset: 0x00003E94
		private void OnRendering(object sender, global::System.EventArgs args)
		{
			object obj = this.lockObj;
			lock (obj)
			{
				this.UpdateImage(this.view);
				this.UpdateImage(this.popup);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00005CE8 File Offset: 0x00003EE8
		private void UpdateImage(global::CefSharp.Wpf.Rendering.Experimental.CompositionTargetRenderHandler.PaintElement element)
		{
			if (element != null && element.IsDirty && element.Image != null)
			{
				global::System.Windows.Media.Imaging.WriteableBitmap writeableBitmap = element.Image.Source as global::System.Windows.Media.Imaging.WriteableBitmap;
				if (writeableBitmap == null || writeableBitmap.PixelWidth != element.Width || writeableBitmap.PixelHeight != element.Height)
				{
					writeableBitmap = (element.Image.Source = new global::System.Windows.Media.Imaging.WriteableBitmap(element.Width, element.Height, element.DpiX, element.DpiY, global::CefSharp.Wpf.Rendering.AbstractRenderHandler.PixelFormat, null));
				}
				if (writeableBitmap != null)
				{
					global::CefSharp.Structs.Rect dirtyRect = element.DirtyRect;
					global::System.Windows.Int32Rect sourceRect = new global::System.Windows.Int32Rect(dirtyRect.X, dirtyRect.Y, dirtyRect.Width, dirtyRect.Height);
					writeableBitmap.Lock();
					writeableBitmap.WritePixels(sourceRect, element.Buffer, element.ImageSize, element.Width * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel, sourceRect.X, sourceRect.Y);
					writeableBitmap.Unlock();
				}
				element.IsDirty = false;
			}
		}

		// Token: 0x04000099 RID: 153
		private global::CefSharp.Wpf.Rendering.Experimental.CompositionTargetRenderHandler.PaintElement view;

		// Token: 0x0400009A RID: 154
		private global::CefSharp.Wpf.Rendering.Experimental.CompositionTargetRenderHandler.PaintElement popup;

		// Token: 0x0400009B RID: 155
		private readonly object lockObj = new object();

		// Token: 0x0400009C RID: 156
		private global::CefSharp.Wpf.ChromiumWebBrowser browser;

		// Token: 0x02000044 RID: 68
		private class PaintElement
		{
			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000274 RID: 628 RVA: 0x0000955B File Offset: 0x0000775B
			// (set) Token: 0x06000275 RID: 629 RVA: 0x00009563 File Offset: 0x00007763
			internal double DpiX { get; private set; }

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000276 RID: 630 RVA: 0x0000956C File Offset: 0x0000776C
			// (set) Token: 0x06000277 RID: 631 RVA: 0x00009574 File Offset: 0x00007774
			internal double DpiY { get; private set; }

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000278 RID: 632 RVA: 0x0000957D File Offset: 0x0000777D
			// (set) Token: 0x06000279 RID: 633 RVA: 0x00009585 File Offset: 0x00007785
			internal global::System.Windows.Controls.Image Image { get; set; }

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600027A RID: 634 RVA: 0x0000958E File Offset: 0x0000778E
			// (set) Token: 0x0600027B RID: 635 RVA: 0x00009596 File Offset: 0x00007796
			internal int Width { get; private set; }

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x0600027C RID: 636 RVA: 0x0000959F File Offset: 0x0000779F
			// (set) Token: 0x0600027D RID: 637 RVA: 0x000095A7 File Offset: 0x000077A7
			internal int Height { get; private set; }

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x0600027E RID: 638 RVA: 0x000095B0 File Offset: 0x000077B0
			// (set) Token: 0x0600027F RID: 639 RVA: 0x000095B8 File Offset: 0x000077B8
			internal global::CefSharp.Structs.Rect DirtyRect { get; private set; }

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x06000280 RID: 640 RVA: 0x000095C1 File Offset: 0x000077C1
			// (set) Token: 0x06000281 RID: 641 RVA: 0x000095C9 File Offset: 0x000077C9
			internal global::System.IntPtr Buffer { get; private set; }

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x06000282 RID: 642 RVA: 0x000095D2 File Offset: 0x000077D2
			// (set) Token: 0x06000283 RID: 643 RVA: 0x000095DA File Offset: 0x000077DA
			internal int BufferSize { get; private set; }

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x06000284 RID: 644 RVA: 0x000095E3 File Offset: 0x000077E3
			// (set) Token: 0x06000285 RID: 645 RVA: 0x000095EB File Offset: 0x000077EB
			internal int ImageSize { get; private set; }

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000286 RID: 646 RVA: 0x000095F4 File Offset: 0x000077F4
			// (set) Token: 0x06000287 RID: 647 RVA: 0x000095FC File Offset: 0x000077FC
			internal bool IsDirty { get; set; }

			// Token: 0x06000288 RID: 648 RVA: 0x00009605 File Offset: 0x00007805
			internal PaintElement(double dpiX, double dpiY)
			{
				this.DpiX = dpiX;
				this.DpiY = dpiY;
			}

			// Token: 0x06000289 RID: 649 RVA: 0x0000961B File Offset: 0x0000781B
			internal void Dispose()
			{
				if (this.Buffer != global::System.IntPtr.Zero)
				{
					global::System.Runtime.InteropServices.Marshal.FreeHGlobal(this.Buffer);
					this.Buffer = global::System.IntPtr.Zero;
				}
			}

			// Token: 0x0600028A RID: 650 RVA: 0x00009648 File Offset: 0x00007848
			internal void OnPaint(global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr sourceBuffer, int width, int height, global::System.Windows.Controls.Image image)
			{
				this.ImageSize = width * height * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel;
				if (this.BufferSize < this.ImageSize)
				{
					global::System.Runtime.InteropServices.Marshal.FreeHGlobal(this.Buffer);
					this.Buffer = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(this.ImageSize);
					this.BufferSize = this.ImageSize;
				}
				this.Width = width;
				this.Height = height;
				this.DirtyRect = dirtyRect;
				global::CefSharp.NativeMethodWrapper.MemoryCopy(this.Buffer, sourceBuffer, this.ImageSize);
				this.Image = image;
				this.IsDirty = true;
			}
		}
	}
}
