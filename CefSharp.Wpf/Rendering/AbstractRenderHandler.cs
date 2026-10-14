using System;
using System.IO.MemoryMappedFiles;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using CefSharp.Structs;

namespace CefSharp.Wpf.Rendering
{
	// Token: 0x0200000B RID: 11
	public abstract class AbstractRenderHandler : global::System.IDisposable, global::CefSharp.Wpf.IRenderHandler
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000523D File Offset: 0x0000343D
		public bool IsDisposed
		{
			get
			{
				return global::System.Threading.Interlocked.CompareExchange(ref this.disposeSignaled, 1, 1) == 1;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000524F File Offset: 0x0000344F
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00005260 File Offset: 0x00003460
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
				this.ReleaseMemoryMappedView(ref this.popupMemoryMappedFile, ref this.popupMemoryMappedViewAccessor);
				this.ReleaseMemoryMappedView(ref this.viewMemoryMappedFile, ref this.viewMemoryMappedViewAccessor);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000052D4 File Offset: 0x000034D4
		protected void ReleaseMemoryMappedView(ref global::System.IO.MemoryMappedFiles.MemoryMappedFile mappedFile, ref global::System.IO.MemoryMappedFiles.MemoryMappedViewAccessor stream)
		{
			if (stream != null)
			{
				stream.Dispose();
				stream = null;
			}
			if (mappedFile != null)
			{
				mappedFile.Dispose();
				mappedFile = null;
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000052F2 File Offset: 0x000034F2
		public virtual void OnAcceleratedPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr sharedHandle)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000052F4 File Offset: 0x000034F4
		public virtual void OnPaint(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr buffer, int width, int height, global::System.Windows.Controls.Image image)
		{
			if (this.IsDisposed || image.Dispatcher.HasShutdownStarted)
			{
				return;
			}
			if (isPopup)
			{
				this.CreateOrUpdateBitmap(isPopup, dirtyRect, buffer, width, height, image, ref this.popupSize, ref this.popupMemoryMappedFile, ref this.popupMemoryMappedViewAccessor);
				return;
			}
			this.CreateOrUpdateBitmap(isPopup, dirtyRect, buffer, width, height, image, ref this.viewSize, ref this.viewMemoryMappedFile, ref this.viewMemoryMappedViewAccessor);
		}

		// Token: 0x06000155 RID: 341
		protected abstract void CreateOrUpdateBitmap(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr buffer, int width, int height, global::System.Windows.Controls.Image image, ref global::System.Windows.Size currentSize, ref global::System.IO.MemoryMappedFiles.MemoryMappedFile mappedFile, ref global::System.IO.MemoryMappedFiles.MemoryMappedViewAccessor viewAccessor);

		// Token: 0x0400007C RID: 124
		internal static readonly global::System.Windows.Media.PixelFormat PixelFormat = global::System.Windows.Media.PixelFormats.Pbgra32;

		// Token: 0x0400007D RID: 125
		internal static int BytesPerPixel = global::CefSharp.Wpf.Rendering.AbstractRenderHandler.PixelFormat.BitsPerPixel / 8;

		// Token: 0x0400007E RID: 126
		protected object lockObject = new object();

		// Token: 0x0400007F RID: 127
		protected global::System.Windows.Size viewSize;

		// Token: 0x04000080 RID: 128
		protected global::System.Windows.Size popupSize;

		// Token: 0x04000081 RID: 129
		protected global::System.Windows.Threading.DispatcherPriority dispatcherPriority;

		// Token: 0x04000082 RID: 130
		protected global::System.IO.MemoryMappedFiles.MemoryMappedFile viewMemoryMappedFile;

		// Token: 0x04000083 RID: 131
		protected global::System.IO.MemoryMappedFiles.MemoryMappedFile popupMemoryMappedFile;

		// Token: 0x04000084 RID: 132
		protected global::System.IO.MemoryMappedFiles.MemoryMappedViewAccessor viewMemoryMappedViewAccessor;

		// Token: 0x04000085 RID: 133
		protected global::System.IO.MemoryMappedFiles.MemoryMappedViewAccessor popupMemoryMappedViewAccessor;

		// Token: 0x04000086 RID: 134
		private int disposeSignaled;
	}
}
