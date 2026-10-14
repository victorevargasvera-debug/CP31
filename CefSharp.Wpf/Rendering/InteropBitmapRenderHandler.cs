using System;
using System.IO.MemoryMappedFiles;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Threading;
using CefSharp.Structs;
using Microsoft.Win32.SafeHandles;

namespace CefSharp.Wpf.Rendering
{
	// Token: 0x0200000E RID: 14
	public class InteropBitmapRenderHandler : global::CefSharp.Wpf.Rendering.AbstractRenderHandler
	{
		// Token: 0x06000162 RID: 354 RVA: 0x00005603 File Offset: 0x00003803
		public InteropBitmapRenderHandler(global::System.Windows.Threading.DispatcherPriority dispatcherPriority = global::System.Windows.Threading.DispatcherPriority.Render)
		{
			this.dispatcherPriority = dispatcherPriority;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00005614 File Offset: 0x00003814
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
					base.ReleaseMemoryMappedView(ref mappedFile, ref viewAccessor);
					mappedFile = global::System.IO.MemoryMappedFiles.MemoryMappedFile.CreateNew(null, (long)num2, global::System.IO.MemoryMappedFiles.MemoryMappedFileAccess.ReadWrite);
					viewAccessor = mappedFile.CreateViewAccessor();
					currentSize.Height = (double)height;
					currentSize.Width = (double)width;
				}
				global::CefSharp.NativeMethodWrapper.MemoryCopy(viewAccessor.SafeMemoryMappedViewHandle.DangerousGetHandle(), buffer, num2);
				global::Microsoft.Win32.SafeHandles.SafeMemoryMappedFileHandle backBufferHandle = mappedFile.SafeMemoryMappedFileHandle;
				image.Dispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					object lockObject2 = this.lockObject;
					lock (lockObject2)
					{
						if (!backBufferHandle.IsClosed && !backBufferHandle.IsInvalid)
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
									int stride = width * global::CefSharp.Wpf.Rendering.AbstractRenderHandler.BytesPerPixel;
									global::System.Windows.Interop.InteropBitmap source = (global::System.Windows.Interop.InteropBitmap)global::System.Windows.Interop.Imaging.CreateBitmapSourceFromMemorySection(backBufferHandle.DangerousGetHandle(), width, height, global::CefSharp.Wpf.Rendering.AbstractRenderHandler.PixelFormat, stride, 0);
									image.Source = source;
								}
								else if (image.Source != null)
								{
									global::System.Windows.Int32Rect value = new global::System.Windows.Int32Rect(dirtyRect.X, dirtyRect.Y, dirtyRect.Width, dirtyRect.Height);
									global::System.Windows.Interop.InteropBitmap interopBitmap = (global::System.Windows.Interop.InteropBitmap)image.Source;
									interopBitmap.Invalidate(new global::System.Windows.Int32Rect?(value));
								}
							}
						}
					}
				}), this.dispatcherPriority, global::System.Array.Empty<object>());
			}
		}
	}
}
