using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using CefSharp.Structs;

namespace CefSharp.Wpf.Rendering
{
	// Token: 0x0200000C RID: 12
	public class AllocHGlobalWritableBitmapRenderHandler : global::CefSharp.Wpf.IRenderHandler, global::System.IDisposable
	{
		// Token: 0x06000158 RID: 344 RVA: 0x00005390 File Offset: 0x00003590
		public AllocHGlobalWritableBitmapRenderHandler(double dpiX, double dpiY, bool invalidateDirtyRect = true, global::System.Windows.Threading.DispatcherPriority dispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Render)
		{
			this.dpiX = dpiX;
			this.dpiY = dpiY;
			this.dispatcherPriority = dispatcherPriority;
			this.view = new global::CefSharp.Wpf.Rendering.AllocHGlobalWritableBitmapRenderHandler.PaintElement(dpiX, dpiY, invalidateDirtyRect);
			this.popup = new global::CefSharp.Wpf.Rendering.AllocHGlobalWritableBitmapRenderHandler.PaintElement(dpiX, dpiY, invalidateDirtyRect);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000159 RID: 345 RVA: 0x000053E0 File Offset: 0x000035E0
		public bool IsDisposed
		{
			get
			{
				return global::System.Threading.Interlocked.CompareExchange(ref this.disposeSignaled, 1, 1) == 1;
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000053F2 File Offset: 0x000035F2
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00005404 File Offset: 0x00003604
		protected virtual void Dispose(bool disposing)
		{
			if (global::System.Threading.Interlocked.CompareExchange(ref this.disposeSignaled, 1, 0) != 0)
			{
				return;
			}
			if (!disposing)
			{
				return;
			}
			object obj = this.lockObject;
			lock (obj)
			{
				global::CefSharp.Wpf.Rendering.AllocHGlobalWritableBitmapRenderHandler.PaintElement paintElement = this.view;
				if (paintElement != null)
				{
					paintElement.Dispose();
				}
				global::CefSharp.Wpf.Rendering.AllocHGlobalWritableBitmapRenderHandler.PaintElement paintElement2 = this.popup;
				if (paintElement2 != null)
				{
					paintElement2.Dispose();
				}
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00005474 File Offset: 0x00003674
		void global::CefSharp.Wpf.IRenderHandler.OnAcceleratedPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr sharedHandle)
		{
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005478 File Offset: 0x00003678
		void global::CefSharp.Wpf.IRenderHandler.OnPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr buffer, int width, int height, global::System.Windows.Controls.Image image)
		{
			object obj = this.lockObject;
			lock (obj)
			{
				if (!this.IsDisposed && !image.Dispatcher.HasShutdownStarted)
				{
					global::CefSharp.Wpf.Rendering.AllocHGlobalWritableBitmapRenderHandler.PaintElement paintElement = isPopup ? this.popup : this.view;
					if (paintElement != null)
					{
						paintElement.UpdateBuffer(dirtyRect, buffer, width, height, image);
					}
					if (paintElement != null)
					{
						paintElement.UpdateImage(this.lockObject);
					}
				}
			}
		}

		// Token: 0x04000087 RID: 135
		private readonly double dpiX;

		// Token: 0x04000088 RID: 136
		private readonly double dpiY;

		// Token: 0x04000089 RID: 137
		private readonly global::CefSharp.Wpf.Rendering.AllocHGlobalWritableBitmapRenderHandler.PaintElement view;

		// Token: 0x0400008A RID: 138
		private readonly global::CefSharp.Wpf.Rendering.AllocHGlobalWritableBitmapRenderHandler.PaintElement popup;

		// Token: 0x0400008B RID: 139
		private readonly global::System.Windows.Threading.DispatcherPriority dispatcherPriority;

		// Token: 0x0400008C RID: 140
		private readonly object lockObject = new object();

		// Token: 0x0400008D RID: 141
		private int disposeSignaled;

		// Token: 0x02000040 RID: 64
		private class PaintElement
		{
			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000268 RID: 616 RVA: 0x00008F2E File Offset: 0x0000712E
			// (set) Token: 0x06000269 RID: 617 RVA: 0x00008F36 File Offset: 0x00007136
			internal bool IsDirty { get; set; }

			// Token: 0x0600026A RID: 618 RVA: 0x00008F3F File Offset: 0x0000713F
			internal PaintElement(double dpiX, double dpiY, bool invalidateDirtyRect)
			{
				this.dpiX = dpiX;
				this.dpiY = dpiY;
				this.invalidateDirtyRect = invalidateDirtyRect;
			}

			// Token: 0x0600026B RID: 619 RVA: 0x00008F5C File Offset: 0x0000715C
			internal void Dispose()
			{
				this.image = null;
				if (this.buffer != global::System.IntPtr.Zero)
				{
					global::System.Runtime.InteropServices.Marshal.FreeHGlobal(this.buffer);
					this.buffer = global::System.IntPtr.Zero;
				}
			}

			// Token: 0x0600026C RID: 620 RVA: 0x00008F90 File Offset: 0x00007190
			internal void UpdateBuffer(global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr sourceBuffer, int width, int height, global::System.Windows.Controls.Image image)
			{
				this.imageSize = width * height * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel;
				if (this.bufferSize < this.imageSize)
				{
					global::System.Runtime.InteropServices.Marshal.FreeHGlobal(this.buffer);
					this.buffer = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(this.imageSize);
					this.bufferSize = this.imageSize;
				}
				this.width = width;
				this.height = height;
				this.dirtyRect = dirtyRect;
				global::CefSharp.NativeMethodWrapper.MemoryCopy(this.buffer, sourceBuffer, this.imageSize);
				this.image = image;
				this.IsDirty = true;
			}

			// Token: 0x0600026D RID: 621 RVA: 0x0000901C File Offset: 0x0000721C
			internal void UpdateImage(object lockObject)
			{
				this.image.Dispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					object lockObject2 = lockObject;
					lock (lockObject2)
					{
						if (this.IsDirty && this.image != null)
						{
							global::System.Windows.Media.Imaging.WriteableBitmap writeableBitmap = this.image.Source as global::System.Windows.Media.Imaging.WriteableBitmap;
							bool flag2 = writeableBitmap == null || writeableBitmap.PixelWidth != this.width || writeableBitmap.PixelHeight != this.height;
							if (flag2)
							{
								if (this.image.Source != null)
								{
									this.image.Source = null;
									global::System.GC.Collect(1);
								}
								writeableBitmap = (this.image.Source = new global::System.Windows.Media.Imaging.WriteableBitmap(this.width, this.height, this.dpiX, this.dpiY, global::CefSharp.Wpf.Rendering.AbstractRenderHandler.PixelFormat, null));
							}
							if (writeableBitmap != null)
							{
								if (this.invalidateDirtyRect)
								{
									global::System.Windows.Int32Rect sourceRect = new global::System.Windows.Int32Rect(this.dirtyRect.X, this.dirtyRect.Y, this.dirtyRect.Width, this.dirtyRect.Height);
									writeableBitmap.Lock();
									writeableBitmap.WritePixels(sourceRect, this.buffer, this.imageSize, this.width * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel, sourceRect.X, sourceRect.Y);
									writeableBitmap.Unlock();
								}
								else
								{
									global::System.Windows.Int32Rect sourceRect2 = new global::System.Windows.Int32Rect(0, 0, this.width, this.height);
									writeableBitmap.Lock();
									writeableBitmap.WritePixels(sourceRect2, this.buffer, this.imageSize, this.width * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel, sourceRect2.X, sourceRect2.Y);
									writeableBitmap.Unlock();
								}
							}
							this.IsDirty = false;
						}
					}
				}), global::System.Array.Empty<object>());
			}

			// Token: 0x040001F5 RID: 501
			private readonly double dpiX;

			// Token: 0x040001F6 RID: 502
			private readonly double dpiY;

			// Token: 0x040001F7 RID: 503
			private global::System.Windows.Controls.Image image;

			// Token: 0x040001F8 RID: 504
			private int width;

			// Token: 0x040001F9 RID: 505
			private int height;

			// Token: 0x040001FA RID: 506
			private global::CefSharp.Structs.Rect dirtyRect;

			// Token: 0x040001FB RID: 507
			private global::System.IntPtr buffer;

			// Token: 0x040001FC RID: 508
			private int bufferSize;

			// Token: 0x040001FD RID: 509
			private int imageSize;

			// Token: 0x040001FE RID: 510
			private readonly bool invalidateDirtyRect;
		}
	}
}
