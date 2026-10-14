using System;
using System.Globalization;
using System.Windows.Input;
using System.Windows.Media;
using AcpUI.Common;
using Infragistics.Windows.Editors;

namespace AcpUI
{
	// Token: 0x0200002B RID: 43
	public class AcpTableTextBoxBase : global::AcpUI.AcpTextBox
	{
		// Token: 0x06000262 RID: 610 RVA: 0x0002CC70 File Offset: 0x0002AE70
		public AcpTableTextBoxBase()
		{
			if (global::System.Globalization.CultureInfo.CurrentUICulture.TextInfo.IsRightToLeft)
			{
				this.a = global::System.Windows.Input.FocusNavigationDirection.Left;
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0002CCA8 File Offset: 0x0002AEA8
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)1582041324;
			short num2 = num;
			num = (short)31590636;
			switch (num2 == num)
			{
			}
			num = (short)1654259712;
			short num3 = num;
			num = (short)2122973185;
			if (num != 0)
			{
			}
			num = (short)1233649664;
			if (num != 0)
			{
			}
			this.AcpTableTextBox_PreviewKeyDown(null, e);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0002CD58 File Offset: 0x0002AF58
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1477533841;
			short num2 = num;
			num = (short)509960337;
			switch (num2 == num)
			{
			}
			num = (short)1603600384;
			short num3 = num;
			num = (short)1354891265;
			if (num != 0)
			{
			}
			num = (short)1420427264;
			if (num != 0)
			{
			}
			this.AcpTableTextBox_PreviewMouseLeftButtonDown(null, e);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0002CE0C File Offset: 0x0002B00C
		public void AcpTableTextBox_PreviewKeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)99090433;
			int num2 = (int)((global::System.IntPtr)num);
			global::Infragistics.Windows.Editors.XamMaskedEditor xamMaskedEditor;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F3;
				case 1:
				{
					num = (short)1258429637;
					short num3 = num;
					num = (short)5053637;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_185;
					default:
						num = (short)204210176;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_96;
						}
						continue;
					}
					break;
				}
				case 2:
					goto IL_185;
				case 3:
					goto IL_B8;
				case 4:
					if (xamMaskedEditor != null)
					{
						num = (short)595591168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Down));
					num = (short)584777733;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					if (e.Key == global::System.Windows.Input.Key.Return)
					{
						num = (short)921108489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B8;
				case 7:
					num = (short)1768357889;
					if (num != 0)
					{
					}
					if (base.IsMasked)
					{
						num = (short)1799159810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					return;
				case 9:
					global::AcpUI.Common.Utility.SaveFieldWithFocus();
					num = (short)1150877699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_96:
				if (e.Key == global::System.Windows.Input.Key.Tab)
				{
					num = (short)1922236424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.CaretBrush = global::System.Windows.Media.Brushes.Black;
				num = (short)723845127;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B8:
				xamMaskedEditor = base.FindVisualChild<global::Infragistics.Windows.Editors.XamMaskedEditor>(this);
				num = (short)904069124;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_185:
				num = (short)3014656;
				short num4 = num;
				num = (short)1823670278;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_F3:
			xamMaskedEditor.Focus();
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0002D03C File Offset: 0x0002B23C
		public void AcpTableTextBox_PreviewMouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1203437568;
			short num2 = num;
			if (!base.IsFocused)
			{
				for (;;)
				{
					num = (short)1464569849;
					short num3 = num;
					num = (short)1563529209;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6A;
					}
				}
				IL_6A:
				num = (short)1032454145;
				if (num != 0)
				{
				}
				num = (short)1606418432;
				if (num != 0)
				{
				}
				base.CaretBrush = global::System.Windows.Media.Brushes.Transparent;
				return;
			}
			base.CaretBrush = global::System.Windows.Media.Brushes.Black;
		}

		// Token: 0x040001AE RID: 430
		private global::System.Windows.Input.FocusNavigationDirection a = global::System.Windows.Input.FocusNavigationDirection.Right;
	}
}
