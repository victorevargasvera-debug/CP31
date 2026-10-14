using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using CefSharp.Structs;

namespace CefSharp.Wpf.Rendering.Experimental
{
	// Token: 0x02000010 RID: 16
	public class ByteArrayWritableBitmapRenderHandler : global::CefSharp.Wpf.IRenderHandler, global::System.IDisposable
	{
		// Token: 0x06000168 RID: 360 RVA: 0x000059E4 File Offset: 0x00003BE4
		public ByteArrayWritableBitmapRenderHandler(double dpiX, double dpiY, bool invalidateDirtyRect = true, global::System.Windows.Threading.DispatcherPriority dispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Render)
		{
			this.dpiX = dpiX;
			this.dpiY = dpiY;
			this.invalidateDirtyRect = invalidateDirtyRect;
			this.dispatcherPriority = dispatcherPriority;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00005A09 File Offset: 0x00003C09
		void global::CefSharp.Wpf.IRenderHandler.OnAcceleratedPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr sharedHandle)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00005A0C File Offset: 0x00003C0C
		void global::CefSharp.Wpf.IRenderHandler.OnPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr buffer, int width, int height, global::System.Windows.Controls.Image image)
		{
			if (image.Dispatcher.HasShutdownStarted)
			{
				return;
			}
			int num = width * height;
			int numberOfBytes = num * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel;
			int stride = width * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel;
			byte[] tempBuffer = new byte[numberOfBytes];
			global::System.Runtime.InteropServices.Marshal.Copy(buffer, tempBuffer, 0, numberOfBytes);
			image.Dispatcher.BeginInvoke(new global::System.Action(delegate()
			{
				global::System.Windows.Media.Imaging.WriteableBitmap writeableBitmap = image.Source as global::System.Windows.Media.Imaging.WriteableBitmap;
				if (writeableBitmap == null || writeableBitmap.PixelHeight != height || writeableBitmap.PixelWidth != width)
				{
					if (image.Source != null)
					{
						image.Source = null;
						global::System.GC.Collect(1);
					}
					writeableBitmap = (image.Source = new global::System.Windows.Media.Imaging.WriteableBitmap(width, height, this.dpiX, this.dpiY, global::CefSharp.Wpf.Rendering.AbstractRenderHandler.PixelFormat, null));
				}
				global::System.IntPtr intPtr = global::System.Runtime.InteropServices.Marshal.UnsafeAddrOfPinnedArrayElement<byte>(tempBuffer, 0);
				if (this.invalidateDirtyRect)
				{
					global::System.Windows.Int32Rect sourceRect = new global::System.Windows.Int32Rect(dirtyRect.X, dirtyRect.Y, dirtyRect.Width, dirtyRect.Height);
					writeableBitmap.Lock();
					writeableBitmap.WritePixels(sourceRect, intPtr, numberOfBytes, stride, dirtyRect.X, dirtyRect.Y);
					writeableBitmap.Unlock();
					return;
				}
				global::System.Windows.Int32Rect sourceRect2 = new global::System.Windows.Int32Rect(0, 0, width, height);
				writeableBitmap.Lock();
				writeableBitmap.WritePixels(sourceRect2, intPtr, numberOfBytes, stride);
				writeableBitmap.Unlock();
			}), this.dispatcherPriority, global::System.Array.Empty<object>());
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00005AD1 File Offset: 0x00003CD1
		void global::System.IDisposable.Dispose()
		{
		}

		// Token: 0x04000095 RID: 149
		private readonly double dpiX;

		// Token: 0x04000096 RID: 150
		private readonly double dpiY;

		// Token: 0x04000097 RID: 151
		private readonly bool invalidateDirtyRect;

		// Token: 0x04000098 RID: 152
		private readonly global::System.Windows.Threading.DispatcherPriority dispatcherPriority;
	}
}
