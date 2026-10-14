using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000122 RID: 290
	public static class ClipboardHelper
	{
		// Token: 0x06000AB6 RID: 2742 RVA: 0x00023CF8 File Offset: 0x00021EF8
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

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00023D34 File Offset: 0x00021F34
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

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00023D70 File Offset: 0x00021F70
		public static global::System.Windows.IDataObject GetDataObject()
		{
			global::System.Windows.IDataObject winFormDataObject;
			if (!global::Infragistics.Windows.Helpers.ClipboardHelper.GetDataObject(10, 100, out winFormDataObject))
			{
				winFormDataObject = global::Infragistics.Windows.Helpers.ClipboardHelper.GetWinFormDataObject();
			}
			return winFormDataObject;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00023D94 File Offset: 0x00021F94
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

		// Token: 0x06000ABA RID: 2746 RVA: 0x00023E20 File Offset: 0x00022020
		public static string GetText()
		{
			return global::Infragistics.Windows.Helpers.ClipboardHelper.GetText(global::System.Windows.TextDataFormat.UnicodeText);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00023E28 File Offset: 0x00022028
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

		// Token: 0x06000ABC RID: 2748 RVA: 0x00023E68 File Offset: 0x00022068
		public static bool SetDataObject(object data)
		{
			return global::Infragistics.Windows.Helpers.ClipboardHelper.SetDataObject(data, false);
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00023E71 File Offset: 0x00022071
		public static bool SetDataObject(object data, bool copy)
		{
			return global::Infragistics.Windows.Helpers.ClipboardHelper.SetDataObject(data, copy, 10, 100);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00023E80 File Offset: 0x00022080
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

		// Token: 0x06000ABF RID: 2751 RVA: 0x00023F28 File Offset: 0x00022128
		public static bool SetText(string text)
		{
			return global::Infragistics.Windows.Helpers.ClipboardHelper.SetText(text, global::System.Windows.TextDataFormat.UnicodeText);
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00023F34 File Offset: 0x00022134
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

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00023F80 File Offset: 0x00022180
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

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00023FB4 File Offset: 0x000221B4
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

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00023FF4 File Offset: 0x000221F4
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

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0002404C File Offset: 0x0002224C
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

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00024090 File Offset: 0x00022290
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

		// Token: 0x06000AC6 RID: 2758 RVA: 0x000240DC File Offset: 0x000222DC
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static string GetWinFormText(global::System.Windows.TextDataFormat format)
		{
			string dataFormat = global::Infragistics.Windows.Helpers.ClipboardHelper.GetDataFormat(format);
			return ((string)global::Infragistics.Windows.Helpers.ClipboardHelper.GetWinFormData(dataFormat)) ?? string.Empty;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00024104 File Offset: 0x00022304
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static bool SetWinFormText(string text, global::System.Windows.TextDataFormat format)
		{
			string dataFormat = global::Infragistics.Windows.Helpers.ClipboardHelper.GetDataFormat(format);
			return global::Infragistics.Windows.Helpers.ClipboardHelper.SetWinFormData(dataFormat, text);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00024120 File Offset: 0x00022320
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

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00024174 File Offset: 0x00022374
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

		// Token: 0x06000ACA RID: 2762 RVA: 0x000241C4 File Offset: 0x000223C4
		private static bool ShouldAutoConvert(string format)
		{
			return format == global::System.Windows.DataFormats.FileDrop || format == global::System.Windows.DataFormats.Bitmap;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x000241E0 File Offset: 0x000223E0
		private static void VerifyNotNull(object value, string name)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException(name);
			}
		}

		// Token: 0x04000499 RID: 1177
		private const int DefaultRetryCount = 10;

		// Token: 0x0400049A RID: 1178
		private const int DefaultRetryDelay = 100;

		// Token: 0x0400049B RID: 1179
		private static bool _wpfClipboardFailed;

		// Token: 0x0400049C RID: 1180
		private static bool _winFormClipboardFailed;

		// Token: 0x0400049D RID: 1181
		private static readonly bool _isClr4 = global::System.Environment.Version.Major >= 4;

		// Token: 0x02000123 RID: 291
		private class WinToWpfDataObject : global::System.Windows.IDataObject
		{
			// Token: 0x06000ACC RID: 2764 RVA: 0x000241EC File Offset: 0x000223EC
			internal WinToWpfDataObject(global::System.Windows.Forms.IDataObject winDataObject)
			{
				global::Infragistics.Windows.Utilities.ThrowIfNull(winDataObject, "winDataObject");
				this._winDataObject = winDataObject;
			}

			// Token: 0x06000ACD RID: 2765 RVA: 0x00024206 File Offset: 0x00022406
			public object GetData(string format, bool autoConvert)
			{
				return this._winDataObject.GetData(format, autoConvert);
			}

			// Token: 0x06000ACE RID: 2766 RVA: 0x00024215 File Offset: 0x00022415
			public object GetData(global::System.Type format)
			{
				return this._winDataObject.GetData(format);
			}

			// Token: 0x06000ACF RID: 2767 RVA: 0x00024223 File Offset: 0x00022423
			public object GetData(string format)
			{
				return this._winDataObject.GetData(format);
			}

			// Token: 0x06000AD0 RID: 2768 RVA: 0x00024231 File Offset: 0x00022431
			public bool GetDataPresent(string format, bool autoConvert)
			{
				return this._winDataObject.GetDataPresent(format, autoConvert);
			}

			// Token: 0x06000AD1 RID: 2769 RVA: 0x00024240 File Offset: 0x00022440
			public bool GetDataPresent(global::System.Type format)
			{
				return this._winDataObject.GetDataPresent(format);
			}

			// Token: 0x06000AD2 RID: 2770 RVA: 0x0002424E File Offset: 0x0002244E
			public bool GetDataPresent(string format)
			{
				return this._winDataObject.GetDataPresent(format);
			}

			// Token: 0x06000AD3 RID: 2771 RVA: 0x0002425C File Offset: 0x0002245C
			public string[] GetFormats(bool autoConvert)
			{
				return this._winDataObject.GetFormats(autoConvert);
			}

			// Token: 0x06000AD4 RID: 2772 RVA: 0x0002426A File Offset: 0x0002246A
			public string[] GetFormats()
			{
				return this._winDataObject.GetFormats();
			}

			// Token: 0x06000AD5 RID: 2773 RVA: 0x00024277 File Offset: 0x00022477
			public void SetData(string format, object data, bool autoConvert)
			{
				this._winDataObject.SetData(format, autoConvert, data);
			}

			// Token: 0x06000AD6 RID: 2774 RVA: 0x00024287 File Offset: 0x00022487
			public void SetData(global::System.Type format, object data)
			{
				this._winDataObject.SetData(format, data);
			}

			// Token: 0x06000AD7 RID: 2775 RVA: 0x00024296 File Offset: 0x00022496
			public void SetData(string format, object data)
			{
				this._winDataObject.SetData(format, data);
			}

			// Token: 0x06000AD8 RID: 2776 RVA: 0x000242A5 File Offset: 0x000224A5
			public void SetData(object data)
			{
				this._winDataObject.SetData(data);
			}

			// Token: 0x0400049E RID: 1182
			private global::System.Windows.Forms.IDataObject _winDataObject;
		}

		// Token: 0x02000124 RID: 292
		private class WpfToWinDataObject : global::System.Windows.Forms.IDataObject
		{
			// Token: 0x06000AD9 RID: 2777 RVA: 0x000242B3 File Offset: 0x000224B3
			internal WpfToWinDataObject(global::System.Windows.IDataObject wpfDataObject)
			{
				this._wpfDataObject = wpfDataObject;
			}

			// Token: 0x06000ADA RID: 2778 RVA: 0x000242C2 File Offset: 0x000224C2
			public object GetData(global::System.Type format)
			{
				return this._wpfDataObject.GetData(format);
			}

			// Token: 0x06000ADB RID: 2779 RVA: 0x000242D0 File Offset: 0x000224D0
			public object GetData(string format)
			{
				return this._wpfDataObject.GetData(format);
			}

			// Token: 0x06000ADC RID: 2780 RVA: 0x000242DE File Offset: 0x000224DE
			public object GetData(string format, bool autoConvert)
			{
				return this._wpfDataObject.GetData(format, autoConvert);
			}

			// Token: 0x06000ADD RID: 2781 RVA: 0x000242ED File Offset: 0x000224ED
			public bool GetDataPresent(global::System.Type format)
			{
				return this._wpfDataObject.GetDataPresent(format);
			}

			// Token: 0x06000ADE RID: 2782 RVA: 0x000242FB File Offset: 0x000224FB
			public bool GetDataPresent(string format)
			{
				return this._wpfDataObject.GetDataPresent(format);
			}

			// Token: 0x06000ADF RID: 2783 RVA: 0x00024309 File Offset: 0x00022509
			public bool GetDataPresent(string format, bool autoConvert)
			{
				return this._wpfDataObject.GetDataPresent(format, autoConvert);
			}

			// Token: 0x06000AE0 RID: 2784 RVA: 0x00024318 File Offset: 0x00022518
			public string[] GetFormats()
			{
				return this._wpfDataObject.GetFormats();
			}

			// Token: 0x06000AE1 RID: 2785 RVA: 0x00024325 File Offset: 0x00022525
			public string[] GetFormats(bool autoConvert)
			{
				return this._wpfDataObject.GetFormats(autoConvert);
			}

			// Token: 0x06000AE2 RID: 2786 RVA: 0x00024333 File Offset: 0x00022533
			public void SetData(object data)
			{
				this._wpfDataObject.SetData(data);
			}

			// Token: 0x06000AE3 RID: 2787 RVA: 0x00024341 File Offset: 0x00022541
			public void SetData(global::System.Type format, object data)
			{
				this._wpfDataObject.SetData(format, data);
			}

			// Token: 0x06000AE4 RID: 2788 RVA: 0x00024350 File Offset: 0x00022550
			public void SetData(string format, object data)
			{
				this._wpfDataObject.SetData(format, data);
			}

			// Token: 0x06000AE5 RID: 2789 RVA: 0x0002435F File Offset: 0x0002255F
			public void SetData(string format, bool autoConvert, object data)
			{
				this._wpfDataObject.SetData(format, data, autoConvert);
			}

			// Token: 0x0400049F RID: 1183
			private global::System.Windows.IDataObject _wpfDataObject;
		}
	}
}
