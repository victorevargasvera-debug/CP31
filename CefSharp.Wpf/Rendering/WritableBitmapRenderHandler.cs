using System;
using System.IO.MemoryMappedFiles;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using CefSharp.Structs;
using Microsoft.Win32.SafeHandles;

namespace CefSharp.Wpf.Rendering
{
	// Token: 0x0200000F RID: 15
	public class WritableBitmapRenderHandler : global::CefSharp.Wpf.Rendering.AbstractRenderHandler
	{
		// Token: 0x06000164 RID: 356 RVA: 0x00005764 File Offset: 0x00003964
		public WritableBitmapRenderHandler(double dpiX, double dpiY, bool invalidateDirtyRect = true, global::System.Windows.Threading.DispatcherPriority dispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Render)
		{
			this.dpiX = dpiX;
			this.dpiY = dpiY;
			this.invalidateDirtyRect = invalidateDirtyRect;
			this.dispatcherPriority = dispatcherPriority;
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00005789 File Offset: 0x00003989
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00005791 File Offset: 0x00003991
		public bool CopyOnlyDirtyRect { get; set; }

		// Token: 0x06000167 RID: 359 RVA: 0x0000579C File Offset: 0x0000399C
		protected override void CreateOrUpdateBitmap(bool isPopup, global::CefSharp.Structs.Rect dirtyRect, global::System.IntPtr buffer, int width, int height, global::System.Windows.Controls.Image image, ref global::System.Windows.Size currentSize, ref global::System.IO.MemoryMappedFiles.MemoryMappedFile mappedFile, ref global::System.IO.MemoryMappedFiles.MemoryMappedViewAccessor viewAccessor)
		{
			bool createNewBitmap = false;
			object lockObject = this.lockObject;
			lock (lockObject)
			{
				int num = width * height;
				int num2 = num * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel;
				createNewBitmap = (mappedFile == null || currentSize.Height != (double)height || currentSize.Width != (double)width);
				if (createNewBitmap)
				{
					if (viewAccessor == null || viewAccessor.Capacity < (long)num2)
					{
						base.ReleaseMemoryMappedView(ref mappedFile, ref viewAccessor);
						mappedFile = global::System.IO.MemoryMappedFiles.MemoryMappedFile.CreateNew(null, (long)num2, global::System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite);
						viewAccessor = mappedFile.CreateViewAccessor();
					}
					currentSize.Height = (double)height;
					currentSize.Width = (double)width;
				}
				if (this.CopyOnlyDirtyRect)
				{
					if (width == dirtyRect.Width && height == dirtyRect.Height)
					{
						global::CefSharp.NativeMethodWrapper.MemoryCopy(viewAccessor.SafeMemoryMappedViewHandle.DangerousGetHandle(), buffer, num2);
					}
					else
					{
						for (int i = width * dirtyRect.Y + dirtyRect.X; i < (dirtyRect.Y + dirtyRect.Height) * width; i += width)
						{
							global::CefSharp.NativeMethodWrapper.MemoryCopy(viewAccessor.SafeMemoryMappedViewHandle.DangerousGetHandle() + i * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel, buffer + i * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel, dirtyRect.Width * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel);
						}
					}
				}
				else
				{
					global::CefSharp.NativeMethodWrapper.MemoryCopy(viewAccessor.SafeMemoryMappedViewHandle.DangerousGetHandle(), buffer, num2);
				}
				global::Microsoft.Win32.SafeHandles.SafeMemoryMappedViewHandle sourceBuffer = viewAccessor.SafeMemoryMappedViewHandle;
				image.Dispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					object lockObject2 = this.lockObject;
					lock (lockObject2)
					{
						if (!sourceBuffer.IsClosed && !sourceBuffer.IsInvalid)
						{
							global::System.Windows.Size size = isPopup ? this.popupSize : this.viewSize;
							if (size.Width == (double)width && size.Height == (double)height)
							{
								if (createNewBitmap)
								{
									if (image.Source != null)
									{
										image.Source = null;
										global::System.GC.Collect(1);
									}
									image.Source = new global::System.Windows.Media.Imaging.WriteableBitmap(width, height, this.dpiX, this.dpiY, global::CefSharp.Wpf.Rendering.AbstractRenderHandler.PixelFormat, null);
								}
								int num3 = width * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel;
								int num4 = num3 * height;
								global::System.Windows.Media.Imaging.WriteableBitmap writeableBitmap = (global::System.Windows.Media.Imaging.WriteableBitmap)image.Source;
								if (width <= writeableBitmap.PixelWidth && height <= writeableBitmap.PixelHeight)
								{
									if (this.invalidateDirtyRect)
									{
										global::System.Windows.Int32Rect sourceRect = new global::System.Windows.Int32Rect(dirtyRect.X, dirtyRect.Y, dirtyRect.Width, dirtyRect.Height);
										writeableBitmap.Lock();
										writeableBitmap.WritePixels(sourceRect, sourceBuffer.DangerousGetHandle(), num4, num3, dirtyRect.X, dirtyRect.Y);
										writeableBitmap.Unlock();
									}
									else
									{
										global::System.Windows.Int32Rect sourceRect2 = new global::System.Windows.Int32Rect(0, 0, width, height);
										writeableBitmap.Lock();
										writeableBitmap.WritePixels(sourceRect2, sourceBuffer.DangerousGetHandle(), num4, num3);
										writeableBitmap.Unlock();
									}
								}
							}
						}
					}
				}), this.dispatcherPriority, global::System.Array.Empty<object>());
			}
		}

		// Token: 0x04000091 RID: 145
		private readonly double dpiX;

		// Token: 0x04000092 RID: 146
		private readonly double dpiY;

		// Token: 0x04000093 RID: 147
		private readonly bool invalidateDirtyRect;
	}
}
