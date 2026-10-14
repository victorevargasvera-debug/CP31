using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using CefSharp.Structs;

namespace CefSharp.Wpf.Rendering
{
	// Token: 0x0200000D RID: 13
	public class DirectWritableBitmapRenderHandler : global::CefSharp.Wpf.IRenderHandler, global::System.IDisposable
	{
		// Token: 0x0600015E RID: 350 RVA: 0x00005500 File Offset: 0x00003700
		public DirectWritableBitmapRenderHandler(double dpiX, double dpiY, bool invalidateDirtyRect = true, global::System.Windows.Threading.DispatcherPriority dispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Render)
		{
			if (!global::CefSharp.Cef.CurrentlyOnThread(global::CefSharp.CefThreadIds.TID_UI))
			{
				throw new global::System.NotSupportedException("Can only be used when CEF is integrated into your WPF Message Loop (MultiThreadedMessageLoop = false).");
			}
			this.dpiX = dpiX;
			this.dpiY = dpiY;
			this.invalidateDirtyRect = invalidateDirtyRect;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005530 File Offset: 0x00003730
		void global::System.IDisposable.Dispose()
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005532 File Offset: 0x00003732
		void global::CefSharp.Wpf.IRenderHandler.OnAcceleratedPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr sharedHandle)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000553C File Offset: 0x0000373C
		void global::CefSharp.Wpf.IRenderHandler.OnPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr buffer, int width, int height, global::System.Windows.Controls.Image image)
		{
			global::System.Windows.Media.Imaging.WriteableBitmap writeableBitmap = image.Source as global::System.Windows.Media.Imaging.WriteableBitmap;
			if (writeableBitmap == null || writeableBitmap.PixelWidth != width || writeableBitmap.PixelHeight != height)
			{
				writeableBitmap = (image.Source = new global::System.Windows.Media.Imaging.WriteableBitmap(width, height, this.dpiX, this.dpiY, global::CefSharp.Wpf.Rendering.AbstractRenderHandler.PixelFormat, null));
			}
			if (writeableBitmap != null)
			{
				writeableBitmap.Lock();
				global::CefSharp.NativeMethodWrapper.MemoryCopy(writeableBitmap.BackBuffer, buffer, writeableBitmap.BackBufferStride * writeableBitmap.PixelHeight);
				if (this.invalidateDirtyRect)
				{
					writeableBitmap.AddDirtyRect(new global::System.Windows.Int32Rect(dirtyRect.X, dirtyRect.Y, dirtyRect.Width, dirtyRect.Height));
				}
				else
				{
					writeableBitmap.AddDirtyRect(new global::System.Windows.Int32Rect(0, 0, writeableBitmap.PixelWidth, writeableBitmap.PixelHeight));
				}
				writeableBitmap.Unlock();
			}
		}

		// Token: 0x0400008E RID: 142
		private readonly double dpiX;

		// Token: 0x0400008F RID: 143
		private readonly double dpiY;

		// Token: 0x04000090 RID: 144
		private readonly bool invalidateDirtyRect;
	}
}
