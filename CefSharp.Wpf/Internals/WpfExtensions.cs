using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace CefSharp.Wpf.Internals
{
	// Token: 0x02000019 RID: 25
	public static class WpfExtensions
	{
		// Token: 0x06000194 RID: 404 RVA: 0x000061E8 File Offset: 0x000043E8
		public static global::CefSharp.CefEventFlags GetModifiers(this global::System.Windows.Input.MouseEventArgs e)
		{
			global::CefSharp.CefEventFlags cefEventFlags = global::CefSharp.CefEventFlags.None;
			if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
			{
				cefEventFlags |= global::CefSharp.CefEventFlags.LeftMouseButton;
			}
			if (e.MiddleButton == global::System.Windows.Input.MouseButtonState.Pressed)
			{
				cefEventFlags |= global::CefSharp.CefEventFlags.MiddleMouseButton;
			}
			if (e.RightButton == global::System.Windows.Input.MouseButtonState.Pressed)
			{
				cefEventFlags |= global::CefSharp.CefEventFlags.RightMouseButton;
			}
			return cefEventFlags | global::CefSharp.Wpf.Internals.WpfExtensions.GetModifierKeys(cefEventFlags);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000622B File Offset: 0x0000442B
		public static global::CefSharp.CefEventFlags GetModifiers(this global::System.Windows.DragEventArgs e)
		{
			return global::CefSharp.Wpf.Internals.WpfExtensions.GetModifierKeys(global::CefSharp.CefEventFlags.None);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00006234 File Offset: 0x00004434
		public static global::CefSharp.CefEventFlags GetModifierKeys(global::CefSharp.CefEventFlags modifiers = global::CefSharp.CefEventFlags.None)
		{
			if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftCtrl))
			{
				modifiers |= (global::CefSharp.CefEventFlags.ControlDown | global::CefSharp.CefEventFlags.IsLeft);
			}
			if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightCtrl))
			{
				modifiers |= (global::CefSharp.CefEventFlags.ControlDown | global::CefSharp.CefEventFlags.IsRight);
			}
			if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftShift))
			{
				modifiers |= (global::CefSharp.CefEventFlags.ShiftDown | global::CefSharp.CefEventFlags.IsLeft);
			}
			if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightShift))
			{
				modifiers |= (global::CefSharp.CefEventFlags.ShiftDown | global::CefSharp.CefEventFlags.IsRight);
			}
			if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.LeftAlt))
			{
				modifiers |= (global::CefSharp.CefEventFlags.AltDown | global::CefSharp.CefEventFlags.IsLeft);
			}
			if (global::System.Windows.Input.Keyboard.IsKeyDown(global::System.Windows.Input.Key.RightAlt))
			{
				modifiers |= (global::CefSharp.CefEventFlags.AltDown | global::CefSharp.CefEventFlags.IsRight);
			}
			return modifiers;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000062B0 File Offset: 0x000044B0
		public static global::CefSharp.CefEventFlags GetModifiers(this global::System.Windows.Input.KeyEventArgs e)
		{
			global::CefSharp.CefEventFlags cefEventFlags = global::CefSharp.CefEventFlags.None;
			global::System.Windows.Input.ModifierKeys modifiers = e.KeyboardDevice.Modifiers;
			if (modifiers.HasFlag(global::System.Windows.Input.ModifierKeys.Shift))
			{
				cefEventFlags |= global::CefSharp.CefEventFlags.ShiftDown;
			}
			if (modifiers.HasFlag(global::System.Windows.Input.ModifierKeys.Alt))
			{
				cefEventFlags |= global::CefSharp.CefEventFlags.AltDown;
			}
			if (modifiers.HasFlag(global::System.Windows.Input.ModifierKeys.Control))
			{
				cefEventFlags |= global::CefSharp.CefEventFlags.ControlDown;
			}
			return cefEventFlags;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00006314 File Offset: 0x00004514
		public static global::CefSharp.IDragData GetDragData(this global::System.Windows.DragEventArgs e)
		{
			global::CefSharp.IDragData dragData = global::CefSharp.DragData.Create();
			dragData.IsFile = e.Data.GetDataPresent(global::System.Windows.DataFormats.FileDrop);
			if (dragData.IsFile)
			{
				foreach (string text in (string[])e.Data.GetData(global::System.Windows.DataFormats.FileDrop))
				{
					string fileName = global::System.IO.Path.GetFileName(text);
					dragData.AddFile(text.Replace("\\", "/"), fileName);
				}
			}
			string link = global::CefSharp.Wpf.Internals.WpfExtensions.GetLink(e.Data);
			dragData.IsLink = !string.IsNullOrEmpty(link);
			if (dragData.IsLink)
			{
				dragData.LinkUrl = link;
			}
			dragData.IsFragment = e.Data.GetDataPresent(global::System.Windows.DataFormats.Text);
			if (dragData.IsFragment)
			{
				dragData.FragmentText = (string)e.Data.GetData(global::System.Windows.DataFormats.Text);
				string text2 = (string)e.Data.GetData(global::System.Windows.DataFormats.Html);
				if (text2 != string.Empty)
				{
					dragData.FragmentHtml = text2;
				}
			}
			return dragData;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00006424 File Offset: 0x00004624
		private static string GetLink(global::System.Windows.IDataObject data)
		{
			if (data.GetDataPresent("UniformResourceLocatorW"))
			{
				string text = global::CefSharp.Wpf.Internals.WpfExtensions.ReadUrlFromDragDropData(data, "UniformResourceLocatorW", global::System.Text.Encoding.Unicode);
				if (text != null)
				{
					return text;
				}
			}
			if (data.GetDataPresent("UniformResourceLocator"))
			{
				return global::CefSharp.Wpf.Internals.WpfExtensions.ReadUrlFromDragDropData(data, "UniformResourceLocator", global::System.Text.Encoding.ASCII);
			}
			return null;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00006474 File Offset: 0x00004674
		private static string ReadUrlFromDragDropData(global::System.Windows.IDataObject data, string urlDataFormatName, global::System.Text.Encoding urlEncoding)
		{
			string text;
			using (global::System.IO.Stream stream = (global::System.IO.Stream)data.GetData(urlDataFormatName))
			{
				using (global::System.IO.TextReader textReader = new global::System.IO.StreamReader(stream, urlEncoding))
				{
					text = textReader.ReadToEnd();
				}
			}
			return text.TrimEnd(new char[1]);
		}
	}
}
