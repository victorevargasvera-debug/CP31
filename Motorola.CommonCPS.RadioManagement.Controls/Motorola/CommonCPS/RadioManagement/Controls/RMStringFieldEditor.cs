using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using TTSBridge;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200011C RID: 284
	public class RMStringFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060008EA RID: 2282 RVA: 0x000937D0 File Offset: 0x000919D0
		public RMStringFieldEditor()
		{
			this.InitializeComponent();
			base.AlignMainGridMaxWithEditor(this, this.grdMain);
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x000937F8 File Offset: 0x000919F8
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x000938B4 File Offset: 0x00091AB4
		public string Mask
		{
			get
			{
				short num = (short)1914035951;
				short num2 = num;
				num = (short)1066393327;
				switch (num2 == num)
				{
				}
				num = (short)1141833728;
				if (num != 0)
				{
				}
				num = (short)328138753;
				if (num != 0)
				{
				}
				num = (short)2068119552;
				short num3 = num;
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.MaskProperty);
			}
			set
			{
				short num = (short)763289422;
				short num2 = num;
				num = (short)913891150;
				switch (num2 == num)
				{
				}
				num = (short)862715905;
				if (num != 0)
				{
				}
				num = (short)2032533504;
				if (num != 0)
				{
				}
				num = (short)159514624;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.MaskProperty, value);
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00093968 File Offset: 0x00091B68
		private static void f(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor rmstringFieldEditor;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1674182657;
					if (num2 != 0)
					{
					}
					rmstringFieldEditor.txbText.Visibility = global::System.Windows.Visibility.Collapsed;
					rmstringFieldEditor.msiText.Visibility = global::System.Windows.Visibility.Visible;
					num2 = (short)2009333763;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (A_1.NewValue != null)
					{
						goto IL_CA;
					}
					return;
				case 2:
				{
					num2 = (short)1528430592;
					short num3 = num2;
					goto IL_A7;
				}
				case 3:
					return;
				case 4:
					if (global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.a(A_1.NewValue as string))
					{
						num2 = (short)1807941637;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A7;
				case 5:
				{
					num2 = (short)432196739;
					short num4 = num2;
					num2 = (short)48811139;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CA;
					default:
					{
						num2 = (short)511442944;
						if (num2 != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput rmmaskedInput = rmstringFieldEditor.msiText;
						rmmaskedInput.ValidateFun = (global::System.Func<object, bool>)global::System.Delegate.Combine(rmmaskedInput.ValidateFun, new global::System.Func<object, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.a));
						rmstringFieldEditor.msiText.ValueChanged += global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.msiText_ValueChanged;
						num2 = (short)1445658626;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_28;
				IL_A7:
				num2 = (short)618725377;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_CA:
				num2 = (short)488505344;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_28:
			rmstringFieldEditor = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor);
			num2 = (short)2060648452;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x00093B54 File Offset: 0x00091D54
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00093C08 File Offset: 0x00091E08
		public bool IsEditorOnly
		{
			get
			{
				short num = (short)1594754466;
				short num2 = num;
				num = (short)1474233762;
				switch (num2 == num)
				{
				}
				num = (short)1184694273;
				if (num != 0)
				{
				}
				num = (short)45154304;
				if (num != 0)
				{
				}
				num = (short)1572995072;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsEditorOnlyProperty);
			}
			set
			{
				short num = (short)1291072430;
				short num2 = num;
				num = (short)1913861038;
				switch (num2 == num)
				{
				}
				num = (short)1142423553;
				if (num != 0)
				{
				}
				num = (short)1056309248;
				if (num != 0)
				{
				}
				num = (short)298844160;
				short num3 = num;
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsEditorOnlyProperty, value);
			}
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00093CC4 File Offset: 0x00091EC4
		private static void e(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			if (!(bool)A_1.NewValue)
			{
				short num = (short)921662590;
				short num2 = num;
				num = (short)1959752830;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)831455232;
					if (num != 0)
					{
					}
					num = (short)1544749056;
					short num3 = num;
					num = (short)36700161;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor rmstringFieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor)A_0;
			rmstringFieldEditor.grdMain.ColumnDefinitions[0].Width = new global::System.Windows.GridLength(0.0);
			rmstringFieldEditor.grdMain.ColumnDefinitions[1].Width = new global::System.Windows.GridLength(0.0);
			rmstringFieldEditor.grdMain.ColumnDefinitions[3].Width = global::System.Windows.GridLength.Auto;
			global::System.Windows.Data.BindingOperations.ClearBinding(rmstringFieldEditor.grdMain, global::System.Windows.FrameworkElement.MaxWidthProperty);
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00093DFC File Offset: 0x00091FFC
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00093EB8 File Offset: 0x000920B8
		public bool UpperCaseOnly
		{
			get
			{
				short num = (short)3948566;
				short num2 = num;
				num = (short)1665679382;
				switch (num2 == num)
				{
				}
				num = (short)409272321;
				if (num != 0)
				{
				}
				num = (short)868024320;
				if (num != 0)
				{
				}
				num = (short)1595015168;
				short num3 = num;
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.UpperCaseOnlyProperty);
			}
			set
			{
				short num = (short)1945632768;
				short num2 = num;
				num = (short)1972565784;
				short num3 = num;
				num = (short)961804056;
				switch (num3 == num)
				{
				}
				num = (short)2017263616;
				if (num != 0)
				{
				}
				num = (short)1051983873;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.UpperCaseOnlyProperty, value);
			}
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00093F78 File Offset: 0x00092178
		private static void d(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)733126923;
			short num2 = num;
			num = (short)1553965323;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_AF;
			case 1:
				break;
			default:
			{
				num = (short)2082799616;
				short num3 = num;
				break;
			}
			}
			num = (short)2133655553;
			if (num != 0)
			{
			}
			num = (short)187760640;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor rmstringFieldEditor = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor;
			if (!(bool)A_1.NewValue)
			{
				rmstringFieldEditor.msiText.TextChanged -= global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.msiText_TextChanged;
				rmstringFieldEditor.txbText.CharacterCasing = global::System.Windows.Controls.CharacterCasing.Normal;
				return;
			}
			IL_AF:
			rmstringFieldEditor.msiText.TextChanged += global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.msiText_TextChanged;
			rmstringFieldEditor.txbText.CharacterCasing = global::System.Windows.Controls.CharacterCasing.Upper;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00094080 File Offset: 0x00092280
		private static void msiText_TextChanged(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1637810176;
			short num2 = num;
			num = (short)1986902985;
			short num3 = num;
			num = (short)565820361;
			switch (num3 == num)
			{
			}
			num = (short)1280573441;
			if (num != 0)
			{
			}
			num = (short)132644864;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput rmmaskedInput = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput;
			rmmaskedInput.Text = rmmaskedInput.Text.ToUpper(global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00094148 File Offset: 0x00092348
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00094200 File Offset: 0x00092400
		public bool IsValueTextBlack
		{
			get
			{
				short num = (short)318963712;
				short num2 = num;
				num = (short)1748961418;
				short num3 = num;
				num = (short)1220937866;
				switch (num3 == num)
				{
				}
				num = (short)2024538113;
				if (num != 0)
				{
				}
				num = (short)1984626688;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsValueTextBlackProperty);
			}
			set
			{
				short num = (short)281214976;
				short num2 = num;
				num = (short)647954433;
				if (num != 0)
				{
				}
				num = (short)96459066;
				short num3 = num;
				num = (short)1290066234;
				switch (num3 == num)
				{
				}
				num = (short)425656320;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsValueTextBlackProperty, value);
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x000942C0 File Offset: 0x000924C0
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor rmstringFieldEditor;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if ((bool)A_1.NewValue)
					{
						num2 = (short)795607041;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)1201635021;
					short num3 = num2;
					num2 = (short)224624333;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_77;
					default:
						num2 = (short)1518272512;
						if (num2 != 0)
						{
						}
						num2 = (short)982646788;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num2 = (short)409075713;
					if (num2 != 0)
					{
					}
					rmstringFieldEditor.txbText.Foreground = global::System.Windows.Media.Brushes.Black;
					goto IL_77;
				case 3:
					goto IL_8F;
				case 4:
					if (rmstringFieldEditor != null)
					{
						num2 = (short)1666121730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_24;
				IL_77:
				num2 = (short)965672963;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_8F:
			num2 = (short)807993344;
			short num4 = num2;
			return;
			IL_24:
			rmstringFieldEditor = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor);
			num2 = (short)2002321408;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00094434 File Offset: 0x00092634
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x000944F0 File Offset: 0x000926F0
		public bool IsSortAsDecimal
		{
			get
			{
				short num = (short)97845248;
				short num2 = num;
				num = (short)263804927;
				short num3 = num;
				num = (short)1497126911;
				switch (num3 == num)
				{
				}
				num = (short)1700134913;
				if (num != 0)
				{
				}
				num = (short)497352704;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsSortAsDecimalProperty);
			}
			set
			{
				short num = (short)1500577792;
				short num2 = num;
				num = (short)1882193921;
				if (num != 0)
				{
				}
				num = (short)1312870369;
				short num3 = num;
				num = (short)40554465;
				switch (num3 == num)
				{
				}
				num = (short)1597243392;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsSortAsDecimalProperty, value);
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x000945A8 File Offset: 0x000927A8
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x00094660 File Offset: 0x00092860
		public bool TextWarpping
		{
			get
			{
				short num = (short)637861888;
				short num2 = num;
				num = (short)2051276801;
				if (num != 0)
				{
				}
				num = (short)697303452;
				short num3 = num;
				num = (short)1657012636;
				switch (num3 == num)
				{
				}
				num = (short)603914240;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.TextWarppingProperty);
			}
			set
			{
				short num = (short)302317568;
				short num2 = num;
				num = (short)526037253;
				short num3 = num;
				num = (short)2118496517;
				switch (num3 == num)
				{
				}
				num = (short)1672544257;
				if (num != 0)
				{
				}
				num = (short)988348416;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.TextWarppingProperty, value);
			}
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0009471C File Offset: 0x0009291C
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor rmstringFieldEditor;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)686294844;
					short num3 = num2;
					num2 = (short)493881148;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_112;
					default:
						num2 = (short)1188888576;
						if (num2 != 0)
						{
						}
						num2 = (short)2017984513;
						if (num2 != 0)
						{
						}
						if (!(bool)A_1.NewValue)
						{
							num2 = (short)767098882;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 1:
					return;
				case 2:
				{
					num2 = (short)1319305216;
					short num4 = num2;
					rmstringFieldEditor.msiText.TextWrapping = global::System.Windows.TextWrapping.NoWrap;
					rmstringFieldEditor.txbText.TextWrapping = global::System.Windows.TextWrapping.NoWrap;
					goto IL_112;
				}
				}
				goto IL_1C;
				IL_112:
				num2 = (short)907018241;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			rmstringFieldEditor = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor);
			num2 = (short)1700134912;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00094854 File Offset: 0x00092A54
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x0009490C File Offset: 0x00092B0C
		public bool PlayButtonVisible
		{
			get
			{
				short num = (short)1503133696;
				short num2 = num;
				num = (short)2060560269;
				short num3 = num;
				num = (short)989374349;
				switch (num3 == num)
				{
				}
				num = (short)1000341504;
				if (num != 0)
				{
				}
				num = (short)929300481;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.PlayButtonVisibleProperty);
			}
			set
			{
				short num = (short)60424192;
				short num2 = num;
				num = (short)1937083201;
				short num3 = num;
				num = (short)1099008833;
				switch (num3 == num)
				{
				}
				num = (short)1170407424;
				if (num != 0)
				{
				}
				num = (short)1648099329;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.PlayButtonVisibleProperty, value);
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000949C4 File Offset: 0x00092BC4
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)521295679;
			short num2 = num;
			num = (short)2031966015;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_AF;
			case 1:
				break;
			default:
			{
				num = (short)2001797120;
				short num3 = num;
				break;
			}
			}
			num = (short)1236008960;
			if (num != 0)
			{
			}
			num = (short)625082369;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor rmstringFieldEditor = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor;
			if (!(bool)A_1.NewValue)
			{
				rmstringFieldEditor.PlayBtn.Visibility = global::System.Windows.Visibility.Collapsed;
				return;
			}
			IL_AF:
			rmstringFieldEditor.PlayBtn.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00094A9C File Offset: 0x00092C9C
		private void btnLock_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)864092160;
			short num2 = num;
			num = (short)1992078114;
			short num3 = num;
			num = (short)1046721314;
			switch (num3 == num)
			{
			}
			num = (short)1063387136;
			if (num != 0)
			{
			}
			num = (short)2142306305;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMButton rmbutton = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMButton;
			rmbutton.Tag = !(bool)rmbutton.Tag;
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00094B64 File Offset: 0x00092D64
		private void PlayBtn_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)2027945984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				string text;
				for (;;)
				{
					IL_32:
					num = (short)656605185;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)598147078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.txbText != null)
						{
							num = (short)1757675520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48D;
					case 2:
						if (text != string.Empty)
						{
							num = (short)608239619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						num = (short)744226816;
						short num3 = num;
						try
						{
							num = (short)1273330229;
							short num4 = num;
							num = (short)183466549;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)1675165696;
								if (num != 0)
								{
								}
								global::System.IO.DirectoryInfo directoryInfo = new global::System.IO.DirectoryInfo(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.ApplicationData));
								try
								{
									switch (0)
									{
									case 0:
										goto IL_150;
									}
									string directoryName;
									for (;;)
									{
										IL_125:
										global::TTSBridge.Vocalizer vocalizer;
										global::TTSBridge.Vocalizer vocalizer2;
										switch (num2)
										{
										case 0:
										{
											global::TTSBridge.Vocalizer.Builder builder = new global::TTSBridge.Vocalizer.Builder().setTemporaryPlayDirectory(directoryInfo);
											if (builder == null)
											{
												num = (short)886374405;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::TTSBridge.Vocalizer.Builder builder2 = builder.setOuputFormat(new global::TTSBridge.MVAFormat(10));
											if (builder2 == null)
											{
												num = (short)1336868872;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::TTSBridge.Vocalizer.Builder builder3 = builder2.setVoice(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횤욦쒨쪪쎬\udbae\ud9b0튲", a_));
											if (builder3 == null)
											{
												num = (short)1390215174;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.IO.DirectoryInfo vocalizerData;
											vocalizer = builder3.build(vocalizerData);
											goto IL_27F;
										}
										case 1:
											goto IL_1A9;
										case 2:
											num = (short)39714817;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
										{
											if (directoryName == null)
											{
												num = (short)1901985794;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											string path = global::System.IO.Path.Combine(directoryName, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횤힦첨캪캬잮\udfb2풴\ud9b6\udeb8캺\udcbc\ud8be꓀냂", a_));
											global::System.IO.DirectoryInfo vocalizerData = new global::System.IO.DirectoryInfo(path);
											num = (short)1401618432;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
											try
											{
												num = (short)281018368;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														switch (0)
														{
														case 0:
															goto IL_2D1;
														}
														continue;
													case 1:
														vocalizer2.play(text);
														num = (short)276889603;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													case 2:
														goto IL_325;
													case 3:
														goto IL_30E;
													}
													IL_2D1:
													if (vocalizer2 != null)
													{
														num = (short)538771457;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													IL_30E:
													num = (short)2026897410;
													num2 = (int)((global::System.IntPtr)num);
												}
												IL_325:;
											}
											finally
											{
												num = (short)1518141440;
												num2 = (int)((global::System.IntPtr)num);
												for (;;)
												{
													switch (num2)
													{
													case 0:
														switch (0)
														{
														case 0:
															goto IL_359;
														}
														continue;
													case 1:
														goto IL_390;
													case 2:
														((global::System.IDisposable)vocalizer2).Dispose();
														num = (short)1786052609;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													IL_359:
													if (vocalizer2 == null)
													{
														break;
													}
													num = (short)308019202;
													num2 = (int)((global::System.IntPtr)num);
												}
												IL_390:;
											}
											num = (short)1083506695;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
											vocalizer = null;
											goto IL_27F;
										case 6:
											vocalizer = null;
											goto IL_27F;
										case 7:
											goto IL_3AC;
										case 8:
											vocalizer = null;
											goto IL_27F;
										}
										goto IL_150;
										IL_27F:
										vocalizer2 = vocalizer;
										num = (short)374145028;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_1A9:
									IL_3AC:
									break;
									IL_150:
									directoryName = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
									num = (short)1937899523;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_125;
								}
								finally
								{
									try
									{
										num = (short)903479296;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_3EA;
												}
												continue;
											case 1:
												global::System.IO.File.Delete(directoryInfo.FullName + global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("捻펦쒨\udbaa莬\ud8ae킰얲", a_));
												num = (short)1455489027;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_472;
											case 3:
												goto IL_459;
											}
											IL_3EA:
											if (global::System.IO.File.Exists(directoryInfo.FullName + global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("捻펦쒨\udbaa莬\ud8ae킰얲", a_)))
											{
												num = (short)1871511553;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_459:
											num = (short)481689602;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_472:;
									}
									catch
									{
									}
								}
								break;
							}
							}
							return;
						}
						catch (global::System.Exception ex)
						{
							string message = ex.Message;
							return;
						}
						goto IL_48D;
					}
					case 4:
						text = this.txbText.Text;
						num = (short)1220214789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_48D;
					case 6:
						if (this.txbText.Text != null)
						{
							num = (short)1783037956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48D;
					}
					goto IL_7B;
					IL_48D:
					num = (short)1922695170;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7B:
				text = string.Empty;
				num = (short)1960181761;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00095140 File Offset: 0x00093340
		public override void SetFocus()
		{
			short num = (short)1883635712;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 1:
					this.txbText.Focus();
					num = (short)535560195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (!this.msiText.IsLoaded)
					{
						goto IL_1D5;
					}
					num = (short)129313020;
					short num3 = num;
					num = (short)563030268;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_49;
					default:
					{
						num = (short)933429248;
						if (num != 0)
						{
						}
						num = (short)317784064;
						short num4 = num;
						num = (short)579403781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 3:
					if (this.txbText.IsLoaded)
					{
						num = (short)1760296964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_120;
				case 4:
					goto IL_193;
				case 5:
					goto IL_11B;
				}
				goto IL_3C;
				IL_49:
				num = (short)1360330753;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C:
				if (string.IsNullOrEmpty(this.Mask))
				{
					goto IL_49;
				}
				this.msiText.Focus();
				num = (short)530186242;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11B:
			this.msiText.SelectAll();
			return;
			IL_120:
			global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.SubscribeOneShot(new global::System.Action<global::System.Windows.RoutedEventHandler>(this.d), new global::System.Action<global::System.Windows.RoutedEventHandler>(this.c), delegate(object A_0, global::System.Windows.RoutedEventArgs A_1)
			{
				short num5 = (short)314365220;
				short num6 = num5;
				num5 = (short)2055197988;
				switch (num6 == num5)
				{
				}
				num5 = (short)2146238464;
				if (num5 != 0)
				{
				}
				num5 = (short)1432485888;
				short num7 = num5;
				num5 = (short)493223937;
				if (num5 != 0)
				{
				}
				this.txbText.SelectAll();
			});
			return;
			IL_193:
			num = (short)436600833;
			if (num != 0)
			{
			}
			this.txbText.SelectAll();
			return;
			IL_1D5:
			global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.SubscribeOneShot(new global::System.Action<global::System.Windows.RoutedEventHandler>(this.b), new global::System.Action<global::System.Windows.RoutedEventHandler>(this.a), delegate(object A_0, global::System.Windows.RoutedEventArgs A_1)
			{
				short num5 = (short)1962803201;
				if (num5 != 0)
				{
				}
				num5 = (short)831090497;
				short num6 = num5;
				num5 = (short)1265528641;
				switch (num6 == num5)
				{
				}
				num5 = (short)929300480;
				short num7 = num5;
				num5 = (short)45809664;
				if (num5 != 0)
				{
				}
				this.msiText.SelectAll();
			});
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0009534C File Offset: 0x0009354C
		public override void SetCellValuePresenterMode()
		{
			short num = (short)888274944;
			short num2 = num;
			num = (short)823698835;
			short num3 = num;
			num = (short)595502483;
			switch (num3 == num)
			{
			}
			num = (short)2039152641;
			if (num != 0)
			{
			}
			num = (short)19660800;
			if (num != 0)
			{
			}
			this.txbText.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.txbText.BorderThickness = new global::System.Windows.Thickness(0.0);
			this.msiText.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.txbText.Background = global::System.Windows.Media.Brushes.Transparent;
			this.msiText.Background = global::System.Windows.Media.Brushes.Transparent;
			this.borderfreeze.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0009545C File Offset: 0x0009365C
		public override void HideBorder()
		{
			short num = (short)1811349504;
			short num2 = num;
			num = (short)2057961473;
			if (num != 0)
			{
			}
			num = (short)2082466390;
			short num3 = num;
			num = (short)1247537750;
			switch (num3 == num)
			{
			}
			num = (short)1476001792;
			if (num != 0)
			{
			}
			this.txbText.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.txbText.BorderThickness = new global::System.Windows.Thickness(0.0);
			this.msiText.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.txbText.Background = global::System.Windows.Media.Brushes.Transparent;
			this.msiText.Background = global::System.Windows.Media.Brushes.Transparent;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00095560 File Offset: 0x00093760
		private static bool a(string A_0)
		{
			short num = (short)373692156;
			short num2 = num;
			num = (short)1929189116;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_7C;
			case 1:
				break;
			default:
			{
				num = (short)420544512;
				short num3 = num;
				break;
			}
			}
			num = (short)63963136;
			if (num != 0)
			{
			}
			if (string.IsNullOrEmpty(A_0))
			{
				return false;
			}
			IL_7C:
			num = (short)47513601;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.regexIpMask.Match(A_0).Success;
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00095628 File Offset: 0x00093828
		private static bool a(object A_0)
		{
			string text;
			for (;;)
			{
				IL_00:
				short num = (short)2123825152;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1219952640;
					short num3 = num;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 1:
						return false;
					case 2:
						return false;
					case 3:
						if (string.IsNullOrWhiteSpace(text))
						{
							num = (short)435027970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_137;
					}
					IL_60:
					if (A_0 == null)
					{
						num = (short)1053884417;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)640927841;
						short num4 = num;
						num = (short)507234401;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)610992128;
							if (num != 0)
							{
							}
							num = (short)826540033;
							if (num != 0)
							{
							}
							text = A_0.ToString();
							num = (short)874250243;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
			}
			return false;
			IL_137:
			return global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.regexIpAddress.Match(text).Success;
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0009577C File Offset: 0x0009397C
		private static void msiText_ValueChanged(object A_0, global::System.EventArgs A_1)
		{
			int a_ = 6;
			short num = (short)1256980480;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7F;
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput rmmaskedInput;
				for (;;)
				{
					IL_30:
					int num3;
					string[] array;
					global::System.Text.StringBuilder stringBuilder;
					string[] array2;
					string value;
					switch (num2)
					{
					case 0:
						goto IL_28E;
					case 1:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)256573442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F5;
					}
					case 2:
						num = (short)891224073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_2F5;
					case 4:
						if (rmmaskedInput.Value != null)
						{
							num = (short)1146093580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_C6;
					case 6:
					{
						if (num3 >= array.Length)
						{
							num = (short)512098314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text2 = array[num3];
						num = (short)1992818704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						string text2;
						stringBuilder.Append(int.Parse(text2, global::System.Globalization.CultureInfo.InvariantCulture).ToString(global::System.Globalization.CultureInfo.InvariantCulture));
						stringBuilder.Append(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("낝", a_));
						num = (short)2034565128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_C6;
					case 9:
					{
						string text;
						if (!text.Contains(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("낝", a_)))
						{
							goto IL_2F5;
						}
						num = (short)1605500929;
						if (num != 0)
						{
						}
						num = (short)1774979997;
						short num4 = num;
						num = (short)135859101;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3EB;
						default:
							num = (short)1064828928;
							if (num != 0)
							{
							}
							num = (short)1158479883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						goto IL_1FD;
					case 11:
					{
						string text;
						array2 = text.Split(new char[]
						{
							'.'
						});
						num = (short)747831311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						string text = rmmaskedInput.Value.ToString();
						value = text;
						stringBuilder = new global::System.Text.StringBuilder();
						num = (short)2014969857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_3EB;
					case 14:
						goto IL_28E;
					case 15:
						if (array2 != null)
						{
							num = (short)1766129677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD;
					case 16:
					{
						string text2;
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)1589575687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						stringBuilder.Append(text2);
						stringBuilder.Append(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("낝", a_));
						num = (short)242221061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						return;
					}
					goto IL_7F;
					IL_C6:
					num3++;
					num = (short)722403328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FD:
					int startIndex = stringBuilder.ToString().LastIndexOf('.');
					value = stringBuilder.ToString().Remove(startIndex);
					num = (short)2015625219;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28E:
					num = (short)1600389120;
					short num5 = num;
					num = (short)1939668998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F5:
					rmmaskedInput.Value = value;
					num = (short)1422721041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EB:
					array = array2;
					num3 = 0;
					num = (short)1594949646;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7F:
				rmmaskedInput = (A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput);
				num = (short)632946692;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00095B98 File Offset: 0x00093D98
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 16;
			if (this._contentLoaded)
			{
				short num = (short)878871085;
				short num2 = num;
				num = (short)1528857133;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)5570561;
					if (num != 0)
					{
					}
					num = (short)1413480448;
					if (num != 0)
					{
					}
					num = (short)2122776576;
					short num3 = num;
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("螧쎫\udaad\udfaf삱\udbb3\udab5\ud9b7钹ﾻ톽궿꿁ꯃꣅ诇髉鿋苏돑냓뿕럗韙뷛냝臟藡臣该跧蓩飫샭돯鷱髳苵諷闹郻跽㯿愁欃欅砇攉戋欍縏昑㬓挕欗缙減紝伟䰡倣吥䜧䘩弫ĭ嘯嬱儳娵尷弹堻圽㐿ⵁ㙃㕅杇㡉⅋㵍⑏⁑㵓㡕㽗㱙㕛㭝౟١ţɥŧṩͫᱭ幯ੱᕳ᭵ᑷ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00095C7C File Offset: 0x00093E7C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)399635973;
			short num2 = num;
			num = (short)28505605;
			switch (num2 == num)
			{
			}
			num = (short)67698689;
			if (num != 0)
			{
			}
			num = (short)1412497408;
			short num3 = num;
			num = (short)501481472;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00095D2C File Offset: 0x00093F2C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1731788802;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1546387457;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1370982631;
					short num3 = num;
					num = (short)826050791;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_169;
					default:
						num = (short)1304887296;
						if (num != 0)
						{
						}
						num = (short)823328769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_15A;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				}
				IL_5A:
				switch (connectionId)
				{
				case 1:
					goto IL_B3;
				case 2:
					goto IL_183;
				case 3:
					goto IL_176;
				case 4:
					goto IL_A6;
				case 5:
					goto IL_15C;
				case 6:
					goto IL_99;
				case 7:
					goto IL_C0;
				case 8:
					goto IL_169;
				default:
					num = (short)709623808;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_99:
			this.borderfreeze = (global::System.Windows.Controls.Border)target;
			return;
			IL_A6:
			this.msiText = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_B3:
			this.fedString = (global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor)target;
			return;
			IL_C0:
			num = (short)1235222528;
			short num4 = num;
			this.btnLock = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_15A:
			this._contentLoaded = true;
			return;
			IL_15C:
			this.txbText = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox)target;
			return;
			IL_169:
			this.PlayBtn = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_176:
			this.borderInvalid = (global::System.Windows.Controls.Border)target;
			return;
			IL_183:
			this.grdMain = (global::System.Windows.Controls.Grid)target;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00095ED0 File Offset: 0x000940D0
		// Note: this type is marked as 'beforefieldinit'.
		static RMStringFieldEditor()
		{
			int a_ = 9;
			short num = (short)1627243812;
			short num2 = num;
			num = (short)764069156;
			switch (num2 == num)
			{
			}
			num = (short)949026817;
			if (num != 0)
			{
			}
			num = (short)543621120;
			short num3 = num;
			num = (short)396558336;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.regexIpMask = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udaa0춢키쪦쮨캪\udfac閮ힲ颴\uddb8邺삼룂ꯄ닆꓈꧊꣌뷎迒뇔𥳐藘뿚ꋞ뷠췢黤触鳨蛪迬諮菰짲꧴鏶퓸ꟺ駼퓾簀异⬄簆月縊怌洎琐愒⼔䬖紘㘚䄜笞ਠ帢", a_));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.regexIpAddress = new global::System.Text.RegularExpressions.Regex(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﾠ订骤鶦鮪肬隮좲蒴鮶誸욺醾룂뫆鋈﯊賐꣒ﯖꛚ隆", a_));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.MaskProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("슢횤첦", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.f)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsEditorOnlyProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킢쎦삨\udfaa슬\uddaeﺰ\uddb2\ud9b4캶", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.e)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.UpperCaseOnlyProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펢햤슦\udba8첬\udcae풰ﲲ\udbb4\udbb6삸", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.d)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsValueTextBlackProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킢욦얨\udeaa좬ﮮ풰쮲솴햸\udaba\udebc풾", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.c)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.IsSortAsDecimalProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("킢좦\udba8\udfaa\udcae횲횴\udeb6풸\udaba톼", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.TextWarppingProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욢\udda4펦ﺨ쪪\udfac\udfae솰\udab2\udbb4킶", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.b)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.PlayButtonVisibleProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾢쒤\udea6\udeaa\ud9ac\udbae\udeb0\uddb2\udeb6쪸튺\udfbc펾꓀", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor.a)));
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00096170 File Offset: 0x00094370
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d(global::System.Windows.RoutedEventHandler A_0)
		{
			short num = (short)218151657;
			short num2 = num;
			num = (short)496417513;
			switch (num2 == num)
			{
			}
			num = (short)818413568;
			if (num != 0)
			{
			}
			num = (short)1153433600;
			short num3 = num;
			num = (short)98304001;
			if (num != 0)
			{
			}
			this.txbText.Loaded += A_0;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00096224 File Offset: 0x00094424
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void c(global::System.Windows.RoutedEventHandler A_0)
		{
			short num = (short)451280897;
			if (num != 0)
			{
			}
			num = (short)1052288516;
			short num2 = num;
			num = (short)1738188292;
			switch (num2 == num)
			{
			}
			num = (short)316735488;
			short num3 = num;
			num = (short)1206779904;
			if (num != 0)
			{
			}
			this.txbText.Loaded -= A_0;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0009638C File Offset: 0x0009458C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(global::System.Windows.RoutedEventHandler A_0)
		{
			short num = (short)94051085;
			short num2 = num;
			num = (short)1379343117;
			switch (num2 == num)
			{
			}
			num = (short)2066612225;
			if (num != 0)
			{
			}
			num = (short)1450967040;
			short num3 = num;
			num = (short)1203896320;
			if (num != 0)
			{
			}
			this.msiText.Loaded += A_0;
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00096440 File Offset: 0x00094640
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::System.Windows.RoutedEventHandler A_0)
		{
			short num = (short)1634911761;
			short num2 = num;
			num = (short)2073544209;
			switch (num2 == num)
			{
			}
			num = (short)772341761;
			if (num != 0)
			{
			}
			num = (short)672661504;
			short num3 = num;
			num = (short)898105344;
			if (num != 0)
			{
			}
			this.msiText.Loaded -= A_0;
		}

		// Token: 0x04000428 RID: 1064
		private static readonly global::System.Text.RegularExpressions.Regex regexIpMask;

		// Token: 0x04000429 RID: 1065
		private static readonly global::System.Text.RegularExpressions.Regex regexIpAddress;

		// Token: 0x0400042A RID: 1066
		private const string languagesPath = "speech\\languages";

		// Token: 0x0400042B RID: 1067
		public static readonly global::System.Windows.DependencyProperty MaskProperty;

		// Token: 0x0400042C RID: 1068
		public static readonly global::System.Windows.DependencyProperty IsEditorOnlyProperty;

		// Token: 0x0400042D RID: 1069
		public static readonly global::System.Windows.DependencyProperty UpperCaseOnlyProperty;

		// Token: 0x0400042E RID: 1070
		public static readonly global::System.Windows.DependencyProperty IsValueTextBlackProperty;

		// Token: 0x0400042F RID: 1071
		public static readonly global::System.Windows.DependencyProperty IsSortAsDecimalProperty;

		// Token: 0x04000430 RID: 1072
		public static readonly global::System.Windows.DependencyProperty TextWarppingProperty;

		// Token: 0x04000431 RID: 1073
		public static readonly global::System.Windows.DependencyProperty PlayButtonVisibleProperty;

		// Token: 0x04000432 RID: 1074
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMStringFieldEditor fedString;

		// Token: 0x04000433 RID: 1075
		internal global::System.Windows.Controls.Grid grdMain;

		// Token: 0x04000434 RID: 1076
		internal global::System.Windows.Controls.Border borderInvalid;

		// Token: 0x04000435 RID: 1077
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiText;

		// Token: 0x04000436 RID: 1078
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMTextBox txbText;

		// Token: 0x04000437 RID: 1079
		internal global::System.Windows.Controls.Border borderfreeze;

		// Token: 0x04000438 RID: 1080
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnLock;

		// Token: 0x04000439 RID: 1081
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton PlayBtn;

		// Token: 0x0400043A RID: 1082
		private bool _contentLoaded;
	}
}
