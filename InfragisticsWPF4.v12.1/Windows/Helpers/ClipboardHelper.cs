using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000104 RID: 260
	public static class ClipboardHelper
	{
		// Token: 0x060009B7 RID: 2487 RVA: 0x00020130 File Offset: 0x0001E330
		public static void Clear()
		{
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper._wpfClipboardFailed)
			{
				try
				{
					global::System.Windows.Clipboard.Clear();
					return;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.ClipboardHelper._wpfClipboardFailed = true;
				}
			}
			global::Infragistics.Windows.Helpers.ClipboardHelper.ClearWinFormClipboard();
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0002016C File Offset: 0x0001E36C
		public static global::System.Windows.IDataObject CreateDataObject()
		{
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper._wpfClipboardFailed)
			{
				try
				{
					return new global::System.Windows.DataObject();
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.ClipboardHelper._wpfClipboardFailed = true;
				}
			}
			return global::Infragistics.Windows.Helpers.ClipboardHelper.CreateWinFormDataObject();
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x000201A8 File Offset: 0x0001E3A8
		public static global::System.Windows.IDataObject GetDataObject()
		{
			global::System.Windows.IDataObject winFormDataObject;
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper.GetDataObject(10, 100, out winFormDataObject))
			{
				winFormDataObject = global::Infragistics.Windows.Helpers.ClipboardHelper.GetWinFormDataObject();
			}
			return winFormDataObject;
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x000201CC File Offset: 0x0001E3CC
		private static bool GetDataObject(int retryTimes, int retryDelay, out global::System.Windows.IDataObject dataObject)
		{
			dataObject = null;
			if (retryTimes < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("retryTimes");
			}
			if (retryDelay < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("retryDelay");
			}
			if (global::Infragistics.Windows.Helpers.ClipboardHelper._isClr4)
			{
				retryTimes = 0;
			}
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper._wpfClipboardFailed)
			{
				for (int i = retryTimes; i >= 0; i--)
				{
					try
					{
						dataObject = global::System.Windows.Clipboard.GetDataObject();
						return true;
					}
					catch (global::System.Security.SecurityException)
					{
						global::Infragistics.Windows.Helpers.ClipboardHelper._wpfClipboardFailed = true;
						break;
					}
					catch (global::System.Runtime.InteropServices.ExternalException)
					{
						if (i == 0)
						{
							throw;
						}
						global::System.Threading.Thread.Sleep(retryDelay);
					}
				}
			}
			return false;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00020258 File Offset: 0x0001E458
		public static string GetText()
		{
			return global::Infragistics.Windows.Helpers.ClipboardHelper.GetText(global::System.Windows.TextDataFormat.UnicodeText);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00020260 File Offset: 0x0001E460
		public static string GetText(global::System.Windows.TextDataFormat format)
		{
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper._wpfClipboardFailed)
			{
				try
				{
					return global::System.Windows.Clipboard.GetText(format);
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.ClipboardHelper._wpfClipboardFailed = true;
				}
			}
			return global::Infragistics.Windows.Helpers.ClipboardHelper.GetWinFormText(format);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000202A0 File Offset: 0x0001E4A0
		public static bool SetDataObject(object data)
		{
			return global::Infragistics.Windows.Helpers.ClipboardHelper.SetDataObject(data, false);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x000202A9 File Offset: 0x0001E4A9
		public static bool SetDataObject(object data, bool copy)
		{
			return global::Infragistics.Windows.Helpers.ClipboardHelper.SetDataObject(data, copy, 10, 100);
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x000202B8 File Offset: 0x0001E4B8
		public static bool SetDataObject(object data, bool copy, int retryTimes, int retryDelay)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(data, "data");
			if (retryTimes < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("retryTimes");
			}
			if (retryDelay < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("retryDelay");
			}
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper._wpfClipboardFailed)
			{
				int num = retryTimes;
				if (global::Infragistics.Windows.Helpers.ClipboardHelper._isClr4)
				{
					num = global::System.Math.Max((retryTimes - 1) / 10, 0);
				}
				for (int i = num; i >= 0; i--)
				{
					try
					{
						global::System.Windows.Clipboard.SetDataObject(data, copy);
						return true;
					}
					catch (global::System.Security.SecurityException)
					{
						global::Infragistics.Windows.Helpers.ClipboardHelper._wpfClipboardFailed = true;
						break;
					}
					catch (global::System.Runtime.InteropServices.ExternalException)
					{
						if (i == 0)
						{
							throw;
						}
						global::System.Threading.Thread.Sleep(retryDelay);
					}
				}
			}
			return global::Infragistics.Windows.Helpers.ClipboardHelper.SetWinFormDataObject(data, copy, retryTimes, retryDelay);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00020360 File Offset: 0x0001E560
		public static bool SetText(string text)
		{
			return global::Infragistics.Windows.Helpers.ClipboardHelper.SetText(text, global::System.Windows.TextDataFormat.UnicodeText);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0002036C File Offset: 0x0001E56C
		public static bool SetText(string text, global::System.Windows.TextDataFormat format)
		{
			global::Infragistics.Windows.Helpers.ClipboardHelper.VerifyNotNull(text, "text");
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper._wpfClipboardFailed)
			{
				try
				{
					global::System.Windows.Clipboard.SetText(text, format);
					return true;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.ClipboardHelper._wpfClipboardFailed = true;
				}
			}
			return global::Infragistics.Windows.Helpers.ClipboardHelper.SetWinFormText(text, format);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000203B8 File Offset: 0x0001E5B8
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static void ClearWinFormClipboard()
		{
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper._winFormClipboardFailed)
			{
				try
				{
					global::System.Windows.Forms.Clipboard.Clear();
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.ClipboardHelper._winFormClipboardFailed = true;
				}
			}
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000203EC File Offset: 0x0001E5EC
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.Windows.IDataObject CreateWinFormDataObject()
		{
			global::System.Windows.IDataObject result = null;
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper._winFormClipboardFailed)
			{
				try
				{
					result = new global::Infragistics.Windows.Helpers.ClipboardHelper.WinToWpfDataObject(new global::System.Windows.Forms.DataObject());
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.ClipboardHelper._winFormClipboardFailed = true;
				}
			}
			return result;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0002042C File Offset: 0x0001E62C
		private static string GetDataFormat(global::System.Windows.TextDataFormat format)
		{
			switch (format)
			{
			case global::System.Windows.TextDataFormat.Text:
				return global::System.Windows.DataFormats.Text;
			case global::System.Windows.TextDataFormat.UnicodeText:
				return global::System.Windows.DataFormats.UnicodeText;
			case global::System.Windows.TextDataFormat.Rtf:
				return global::System.Windows.DataFormats.Rtf;
			case global::System.Windows.TextDataFormat.Html:
				return global::System.Windows.DataFormats.Html;
			case global::System.Windows.TextDataFormat.CommaSeparatedValue:
				return global::System.Windows.DataFormats.CommaSeparatedValue;
			case global::System.Windows.TextDataFormat.Xaml:
				return global::System.Windows.DataFormats.Xaml;
			default:
				return global::System.Windows.DataFormats.UnicodeText;
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00020484 File Offset: 0x0001E684
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static global::System.Windows.IDataObject GetWinFormDataObject()
		{
			global::System.Windows.IDataObject result = null;
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper._winFormClipboardFailed)
			{
				try
				{
					global::System.Windows.Forms.IDataObject dataObject = global::System.Windows.Forms.Clipboard.GetDataObject();
					if (dataObject != null)
					{
						result = new global::Infragistics.Windows.Helpers.ClipboardHelper.WinToWpfDataObject(dataObject);
					}
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.ClipboardHelper._winFormClipboardFailed = true;
				}
			}
			return result;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000204C8 File Offset: 0x0001E6C8
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static object GetWinFormData(string format)
		{
			object result = null;
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper._winFormClipboardFailed)
			{
				try
				{
					global::System.Windows.Forms.IDataObject dataObject = global::System.Windows.Forms.Clipboard.GetDataObject();
					if (dataObject != null)
					{
						bool autoConvert = global::Infragistics.Windows.Helpers.ClipboardHelper.ShouldAutoConvert(format);
						result = dataObject.GetData(format, autoConvert);
					}
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.ClipboardHelper._winFormClipboardFailed = true;
				}
			}
			return result;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00020514 File Offset: 0x0001E714
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static string GetWinFormText(global::System.Windows.TextDataFormat format)
		{
			string dataFormat = global::Infragistics.Windows.Helpers.ClipboardHelper.GetDataFormat(format);
			return ((string)global::Infragistics.Windows.Helpers.ClipboardHelper.GetWinFormData(dataFormat)) ?? string.Empty;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0002053C File Offset: 0x0001E73C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static bool SetWinFormText(string text, global::System.Windows.TextDataFormat format)
		{
			string dataFormat = global::Infragistics.Windows.Helpers.ClipboardHelper.GetDataFormat(format);
			return global::Infragistics.Windows.Helpers.ClipboardHelper.SetWinFormData(dataFormat, text);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00020558 File Offset: 0x0001E758
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static bool SetWinFormData(string format, object data)
		{
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper._winFormClipboardFailed)
			{
				try
				{
					global::System.Windows.Forms.DataObject dataObject = new global::System.Windows.Forms.DataObject();
					bool autoConvert = global::Infragistics.Windows.Helpers.ClipboardHelper.ShouldAutoConvert(format);
					dataObject.SetData(format, autoConvert, data);
					global::System.Windows.Forms.Clipboard.SetDataObject(dataObject, true);
					return true;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.ClipboardHelper._winFormClipboardFailed = true;
				}
				return false;
			}
			return false;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000205AC File Offset: 0x0001E7AC
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static bool SetWinFormDataObject(object data, bool copy, int retryTimes, int retryDelay)
		{
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper._winFormClipboardFailed)
			{
				try
				{
					global::System.Windows.IDataObject dataObject = data as global::System.Windows.IDataObject;
					if (dataObject != null)
					{
						data = new global::Infragistics.Windows.Helpers.ClipboardHelper.WpfToWinDataObject(dataObject);
					}
					global::System.Windows.Forms.Clipboard.SetDataObject(data, copy, retryTimes, retryDelay);
					return true;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.Helpers.ClipboardHelper._winFormClipboardFailed = true;
				}
				return false;
			}
			return false;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000205FC File Offset: 0x0001E7FC
		private static bool ShouldAutoConvert(string format)
		{
			return format == global::System.Windows.DataFormats.FileDrop || format == global::System.Windows.DataFormats.Bitmap;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00020618 File Offset: 0x0001E818
		private static void VerifyNotNull(object value, string name)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException(name);
			}
		}

		// Token: 0x040003E6 RID: 998
		private const int DefaultRetryCount = 10;

		// Token: 0x040003E7 RID: 999
		private const int DefaultRetryDelay = 100;

		// Token: 0x040003E8 RID: 1000
		private static bool _wpfClipboardFailed;

		// Token: 0x040003E9 RID: 1001
		private static bool _winFormClipboardFailed;

		// Token: 0x040003EA RID: 1002
		private static readonly bool _isClr4 = global::System.Environment.Version.Major >= 4;

		// Token: 0x02000105 RID: 261
		private class WinToWpfDataObject : global::System.Windows.IDataObject
		{
			// Token: 0x060009CD RID: 2509 RVA: 0x00020624 File Offset: 0x0001E824
			internal WinToWpfDataObject(global::System.Windows.Forms.IDataObject winDataObject)
			{
				global::Infragistics.Windows.Utilities.ThrowIfNull(winDataObject, "winDataObject");
				this._winDataObject = winDataObject;
			}

			// Token: 0x060009CE RID: 2510 RVA: 0x0002063E File Offset: 0x0001E83E
			public object GetData(string format, bool autoConvert)
			{
				return this._winDataObject.GetData(format, autoConvert);
			}

			// Token: 0x060009CF RID: 2511 RVA: 0x0002064D File Offset: 0x0001E84D
			public object GetData(global::System.Type format)
			{
				return this._winDataObject.GetData(format);
			}

			// Token: 0x060009D0 RID: 2512 RVA: 0x0002065B File Offset: 0x0001E85B
			public object GetData(string format)
			{
				return this._winDataObject.GetData(format);
			}

			// Token: 0x060009D1 RID: 2513 RVA: 0x00020669 File Offset: 0x0001E869
			public bool GetDataPresent(string format, bool autoConvert)
			{
				return this._winDataObject.GetDataPresent(format, autoConvert);
			}

			// Token: 0x060009D2 RID: 2514 RVA: 0x00020678 File Offset: 0x0001E878
			public bool GetDataPresent(global::System.Type format)
			{
				return this._winDataObject.GetDataPresent(format);
			}

			// Token: 0x060009D3 RID: 2515 RVA: 0x00020686 File Offset: 0x0001E886
			public bool GetDataPresent(string format)
			{
				return this._winDataObject.GetDataPresent(format);
			}

			// Token: 0x060009D4 RID: 2516 RVA: 0x00020694 File Offset: 0x0001E894
			public string[] GetFormats(bool autoConvert)
			{
				return this._winDataObject.GetFormats(autoConvert);
			}

			// Token: 0x060009D5 RID: 2517 RVA: 0x000206A2 File Offset: 0x0001E8A2
			public string[] GetFormats()
			{
				return this._winDataObject.GetFormats();
			}

			// Token: 0x060009D6 RID: 2518 RVA: 0x000206AF File Offset: 0x0001E8AF
			public void SetData(string format, object data, bool autoConvert)
			{
				this._winDataObject.SetData(format, autoConvert, data);
			}

			// Token: 0x060009D7 RID: 2519 RVA: 0x000206BF File Offset: 0x0001E8BF
			public void SetData(global::System.Type format, object data)
			{
				this._winDataObject.SetData(format, data);
			}

			// Token: 0x060009D8 RID: 2520 RVA: 0x000206CE File Offset: 0x0001E8CE
			public void SetData(string format, object data)
			{
				this._winDataObject.SetData(format, data);
			}

			// Token: 0x060009D9 RID: 2521 RVA: 0x000206DD File Offset: 0x0001E8DD
			public void SetData(object data)
			{
				this._winDataObject.SetData(data);
			}

			// Token: 0x040003EB RID: 1003
			private global::System.Windows.Forms.IDataObject _winDataObject;
		}

		// Token: 0x02000106 RID: 262
		private class WpfToWinDataObject : global::System.Windows.Forms.IDataObject
		{
			// Token: 0x060009DA RID: 2522 RVA: 0x000206EB File Offset: 0x0001E8EB
			internal WpfToWinDataObject(global::System.Windows.IDataObject wpfDataObject)
			{
				this._wpfDataObject = wpfDataObject;
			}

			// Token: 0x060009DB RID: 2523 RVA: 0x000206FA File Offset: 0x0001E8FA
			public object GetData(global::System.Type format)
			{
				return this._wpfDataObject.GetData(format);
			}

			// Token: 0x060009DC RID: 2524 RVA: 0x00020708 File Offset: 0x0001E908
			public object GetData(string format)
			{
				return this._wpfDataObject.GetData(format);
			}

			// Token: 0x060009DD RID: 2525 RVA: 0x00020716 File Offset: 0x0001E916
			public object GetData(string format, bool autoConvert)
			{
				return this._wpfDataObject.GetData(format, autoConvert);
			}

			// Token: 0x060009DE RID: 2526 RVA: 0x00020725 File Offset: 0x0001E925
			public bool GetDataPresent(global::System.Type format)
			{
				return this._wpfDataObject.GetDataPresent(format);
			}

			// Token: 0x060009DF RID: 2527 RVA: 0x00020733 File Offset: 0x0001E933
			public bool GetDataPresent(string format)
			{
				return this._wpfDataObject.GetDataPresent(format);
			}

			// Token: 0x060009E0 RID: 2528 RVA: 0x00020741 File Offset: 0x0001E941
			public bool GetDataPresent(string format, bool autoConvert)
			{
				return this._wpfDataObject.GetDataPresent(format, autoConvert);
			}

			// Token: 0x060009E1 RID: 2529 RVA: 0x00020750 File Offset: 0x0001E950
			public string[] GetFormats()
			{
				return this._wpfDataObject.GetFormats();
			}

			// Token: 0x060009E2 RID: 2530 RVA: 0x0002075D File Offset: 0x0001E95D
			public string[] GetFormats(bool autoConvert)
			{
				return this._wpfDataObject.GetFormats(autoConvert);
			}

			// Token: 0x060009E3 RID: 2531 RVA: 0x0002076B File Offset: 0x0001E96B
			public void SetData(object data)
			{
				this._wpfDataObject.SetData(data);
			}

			// Token: 0x060009E4 RID: 2532 RVA: 0x00020779 File Offset: 0x0001E979
			public void SetData(global::System.Type format, object data)
			{
				this._wpfDataObject.SetData(format, data);
			}

			// Token: 0x060009E5 RID: 2533 RVA: 0x00020788 File Offset: 0x0001E988
			public void SetData(string format, object data)
			{
				this._wpfDataObject.SetData(format, data);
			}

			// Token: 0x060009E6 RID: 2534 RVA: 0x00020797 File Offset: 0x0001E997
			public void SetData(string format, bool autoConvert, object data)
			{
				this._wpfDataObject.SetData(format, data, autoConvert);
			}

			// Token: 0x040003EC RID: 1004
			private global::System.Windows.IDataObject _wpfDataObject;
		}
	}
}
