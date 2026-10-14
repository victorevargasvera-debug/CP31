using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000FC RID: 252
	public class RMNumericFieldEditor : global::Motorola.CommonCPS.RadioManagement.Controls.RMCellPresentableFieldEditor, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000711 RID: 1809 RVA: 0x000714FC File Offset: 0x0006F6FC
		public RMNumericFieldEditor()
		{
			this.InitializeComponent();
			base.AlignMainGridMaxWithEditor(this, this.grdMain);
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00071524 File Offset: 0x0006F724
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x000715DC File Offset: 0x0006F7DC
		public bool IsEditorOnly
		{
			get
			{
				short num = (short)68947476;
				short num2 = num;
				num = (short)1147276820;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1735000064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1229062144;
				if (num != 0)
				{
				}
				num = (short)2091712513;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsEditorOnlyProperty);
			}
			set
			{
				short num = (short)585923472;
				short num2 = num;
				num = (short)1307999120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1966145536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1392902145;
				if (num != 0)
				{
				}
				num = (short)1883176960;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsEditorOnlyProperty, value);
			}
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00071698 File Offset: 0x0006F898
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1395453969;
			short num2 = num;
			num = (short)669446161;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)848035840;
				short num3 = num;
				break;
			}
			}
			num = (short)2001338369;
			if (num != 0)
			{
			}
			num = (short)1146159104;
			if (num != 0)
			{
			}
			if ((bool)A_1.NewValue)
			{
				global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor rmnumericFieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor)A_0;
				rmnumericFieldEditor.grdMain.ColumnDefinitions[0].Width = new global::System.Windows.GridLength(0.0);
				rmnumericFieldEditor.grdMain.ColumnDefinitions[1].Width = new global::System.Windows.GridLength(0.0);
				rmnumericFieldEditor.grdMain.ColumnDefinitions[3].Width = global::System.Windows.GridLength.Auto;
				return;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x000717BC File Offset: 0x0006F9BC
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x00071874 File Offset: 0x0006FA74
		public bool IsStepIgnored
		{
			get
			{
				short num = (short)46413343;
				short num2 = num;
				num = (short)151533087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)436338688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1271332865;
				if (num != 0)
				{
				}
				num = (short)172228608;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsStepIgnoredProperty);
			}
			set
			{
				short num = (short)913712788;
				short num2 = num;
				num = (short)396699284;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1044643840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)794886145;
				if (num != 0)
				{
				}
				num = (short)684916736;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsStepIgnoredProperty, value);
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00071930 File Offset: 0x0006FB30
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x000719E8 File Offset: 0x0006FBE8
		public string HexMask
		{
			get
			{
				short num = (short)33566890;
				short num2 = num;
				num = (short)707342506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1208483840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1415643136;
				if (num != 0)
				{
				}
				num = (short)305987585;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.HexMaskProperty);
			}
			set
			{
				short num = (short)169226732;
				short num2 = num;
				num = (short)977154540;
				switch (num2 == num)
				{
				default:
				{
					num = (short)975241216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)846004225;
				if (num != 0)
				{
				}
				num = (short)1122959360;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.HexMaskProperty, value);
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00071AA0 File Offset: 0x0006FCA0
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)120788980;
			short num2 = num;
			num = (short)533075956;
			switch (num2 == num)
			{
			default:
			{
				num = (short)835125248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1183514625;
			if (num != 0)
			{
			}
			num = (short)1097007104;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor rmnumericFieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor)A_0;
			string mask = A_1.NewValue.ToString();
			rmnumericFieldEditor.msiHex.Mask = mask;
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00071B6C File Offset: 0x0006FD6C
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x00071C24 File Offset: 0x0006FE24
		public bool IsHex
		{
			get
			{
				short num = (short)1898315777;
				if (num != 0)
				{
				}
				num = (short)1792933888;
				short num2 = num;
				num = (short)1460406712;
				short num3 = num;
				num = (short)381487544;
				switch (num3 == num)
				{
				}
				num = (short)483721216;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsHexProperty);
			}
			set
			{
				short num = (short)1869338822;
				short num2 = num;
				num = (short)414046406;
				switch (num2 == num)
				{
				default:
				{
					num = (short)146472960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1451098113;
				if (num != 0)
				{
				}
				num = (short)961478656;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsHexProperty, value);
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00071CE0 File Offset: 0x0006FEE0
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00071D98 File Offset: 0x0006FF98
		public string Mask
		{
			get
			{
				short num = (short)800806813;
				short num2 = num;
				num = (short)1985173405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)358481920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)765394945;
				if (num != 0)
				{
				}
				num = (short)536281088;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.MaskProperty);
			}
			set
			{
				short num = (short)1093680952;
				short num2 = num;
				num = (short)109723448;
				switch (num2 == num)
				{
				default:
				{
					num = (short)100990976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)442892289;
				if (num != 0)
				{
				}
				num = (short)102563840;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.MaskProperty, value);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00071E50 File Offset: 0x00070050
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00071F08 File Offset: 0x00070108
		public bool ShowDecimalEditor
		{
			get
			{
				short num = (short)1912394109;
				short num2 = num;
				num = (short)105566589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1768095744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1263796225;
				if (num != 0)
				{
				}
				num = (short)2066743296;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowDecimalEditorProperty);
			}
			set
			{
				short num = (short)1821063544;
				short num2 = num;
				num = (short)202914168;
				switch (num2 == num)
				{
				default:
				{
					num = (short)5767168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)951386113;
				if (num != 0)
				{
				}
				num = (short)1893466112;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowDecimalEditorProperty, value);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00071FC4 File Offset: 0x000701C4
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x0007207C File Offset: 0x0007027C
		public bool ShowHexEditor
		{
			get
			{
				short num = (short)226086083;
				short num2 = num;
				num = (short)1817300163;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1993342976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)503119873;
				if (num != 0)
				{
				}
				num = (short)87949312;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowHexEditorProperty);
			}
			set
			{
				short num = (short)130834227;
				short num2 = num;
				num = (short)1326145331;
				switch (num2 == num)
				{
				default:
				{
					num = (short)633602048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1587544065;
				if (num != 0)
				{
				}
				num = (short)308609024;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowHexEditorProperty, value);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00072134 File Offset: 0x00070334
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x000721EC File Offset: 0x000703EC
		public bool ShowOctEditor
		{
			get
			{
				short num = (short)1189385419;
				short num2 = num;
				num = (short)445486283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2023292928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1074724865;
				if (num != 0)
				{
				}
				num = (short)1027866624;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowOctEditorProperty);
			}
			set
			{
				short num = (short)1324623979;
				short num2 = num;
				num = (short)991701099;
				switch (num2 == num)
				{
				default:
				{
					num = (short)659816448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)327221249;
				if (num != 0)
				{
				}
				num = (short)1604059136;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowOctEditorProperty, value);
			}
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000722A8 File Offset: 0x000704A8
		private void btnLock_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1705920208;
			short num2 = num;
			num = (short)2016364240;
			switch (num2 == num)
			{
			default:
			{
				num = (short)581304320;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)269615104;
			if (num != 0)
			{
			}
			num = (short)341639169;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMButton rmbutton = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMButton;
			rmbutton.Tag = !(bool)rmbutton.Tag;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00072374 File Offset: 0x00070574
		private void fedNumeric_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1041402887;
			short num2 = num;
			num = (short)1275300871;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A5;
			case 1:
				break;
			default:
			{
				num = (short)121831424;
				short num3 = num;
				break;
			}
			}
			num = (short)709689345;
			if (num != 0)
			{
			}
			num = (short)1011941376;
			if (num != 0)
			{
			}
			if (!this.IsStepIgnored)
			{
				this.nmiNumber.SpinIncrement = 0;
				return;
			}
			IL_A5:
			this.grdButtons.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00072444 File Offset: 0x00070644
		private void msiHex_TextChanged(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1911029761;
			if (num != 0)
			{
			}
			num = (short)1473380352;
			short num2 = num;
			num = (short)211318216;
			short num3 = num;
			num = (short)1287026120;
			switch (num3 == num)
			{
			}
			num = (short)2133590016;
			if (num != 0)
			{
			}
			this.msiHex.Text = this.msiHex.Text.ToUpper(global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0007250C File Offset: 0x0007070C
		protected override void OnPreviewKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			int num;
			short num2;
			global::System.Windows.Input.Key key;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)904342682;
						short num3 = num2;
						num2 = (short)285420698;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B;
						default:
							num2 = (short)872742913;
							if (num2 != 0)
							{
							}
							num2 = (short)650182656;
							if (num2 != 0)
							{
							}
							num2 = (short)1404436482;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (key != global::System.Windows.Input.Key.Up)
						{
							num2 = (short)657129472;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.a();
						num2 = (short)462225412;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (key == global::System.Windows.Input.Key.Down)
						{
							num2 = (short)1817313280;
							short num4 = num2;
							num2 = (short)982188035;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 3:
						goto IL_156;
					case 4:
						goto IL_EE;
					}
					goto IL_24;
				}
				IL_EE:
				return;
				IL_156:
				this.b();
				return;
			}
			IL_24:
			key = e.Key;
			IL_2B:
			num2 = (short)107675649;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00072674 File Offset: 0x00070874
		private void msiNumber_PreviewKeyDown(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			int num;
			short num2;
			global::System.Windows.Input.Key key;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)555155457;
						if (num2 != 0)
						{
						}
						num2 = (short)2016681391;
						short num3 = num2;
						num2 = (short)30416303;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B;
						default:
							num2 = (short)287309824;
							if (num2 != 0)
							{
							}
							num2 = (short)377880578;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (key != global::System.Windows.Input.Key.Up)
						{
							num2 = (short)1822162944;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.a();
						num2 = (short)421986308;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (key == global::System.Windows.Input.Key.Down)
						{
							num2 = (short)129236992;
							short num4 = num2;
							num2 = (short)788725763;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 3:
						goto IL_157;
					case 4:
						goto IL_F0;
					}
					goto IL_24;
				}
				IL_F0:
				return;
				IL_157:
				this.b();
				return;
			}
			IL_24:
			key = A_1.Key;
			IL_2B:
			num2 = (short)2142371841;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x000727DC File Offset: 0x000709DC
		private void nmiNumber_PreviewKeyUp(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			int a_ = 9;
			short num = (short)124452867;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)672202753;
					if (num != 0)
					{
					}
					num = (short)38993920;
					short num3 = num;
					num = (short)704446468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_EA;
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 4:
					if (A_1.Key != global::System.Windows.Input.Key.Down)
					{
						num = (short)122159109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EA;
				case 5:
					num = (short)1847721990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_158;
				}
				IL_4A:
				if (this.msiHex.Visibility != global::System.Windows.Visibility.Visible)
				{
					break;
				}
				num = (short)438649756;
				short num4 = num;
				num = (short)909656988;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_158;
				default:
					num = (short)1205141504;
					if (num != 0)
					{
					}
					num = (short)47972352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_EA:
				this.msiHex.Text = global::System.Convert.ToInt64(this.nmiNumber.Value, global::System.Globalization.CultureInfo.CurrentCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("裂", a_), global::System.Globalization.CultureInfo.CurrentCulture);
				num = (short)444923906;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_158:
				if (A_1.Key != global::System.Windows.Input.Key.Up)
				{
					break;
				}
				num = (short)1513947137;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x000729D8 File Offset: 0x00070BD8
		private void rbtIncrease_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1912821654;
			short num2 = num;
			num = (short)1073698710;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1011744768;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)853016576;
			if (num != 0)
			{
			}
			num = (short)1164509185;
			if (num != 0)
			{
			}
			this.SetFocus();
			this.a();
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00072A90 File Offset: 0x00070C90
		private void rbtDecrease_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1634376186;
			short num2 = num;
			num = (short)336370170;
			switch (num2 == num)
			{
			default:
			{
				num = (short)231211008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)847904768;
			if (num != 0)
			{
			}
			num = (short)2011627521;
			if (num != 0)
			{
			}
			this.SetFocus();
			this.b();
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00072B44 File Offset: 0x00070D44
		private void nmiNumber_LostFocus(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)865730561;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1669595137;
						if (num != 0)
						{
						}
						num = (short)874577922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 2:
						if (base.DataContext is global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit)
						{
							num = (short)1269301251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit numericEdit = base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit;
						this.nmiNumber.Value = numericEdit.Value;
						num = (short)228130820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return;
					}
					IL_39:
					if (this.nmiNumber.Value != null)
					{
						return;
					}
					num = (short)925368320;
					short num3 = num;
					num = (short)1166721671;
					short num4 = num;
					num = (short)1891091079;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)861274112;
						if (num != 0)
						{
						}
						num = (short)1950351360;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00072CC8 File Offset: 0x00070EC8
		private void b()
		{
			short num = (short)2072450995;
			short num2 = num;
			num = (short)1699223475;
			switch (num2 == num)
			{
			default:
			{
				num = (short)872611840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1935736833;
			if (num != 0)
			{
			}
			num = (short)339214336;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit numericEdit = base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit;
			numericEdit.Decrease();
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00072D80 File Offset: 0x00070F80
		private void a()
		{
			short num = (short)558628865;
			if (num != 0)
			{
			}
			num = (short)2080964608;
			short num2 = num;
			num = (short)649223032;
			short num3 = num;
			num = (short)365845368;
			switch (num3 == num)
			{
			}
			num = (short)1404305408;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit numericEdit = base.DataContext as global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit;
			numericEdit.Increase();
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00072E3C File Offset: 0x0007103C
		public override void SetFocus()
		{
			short num = (short)1926234118;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E3;
				case 1:
					if (this.msiOct.IsLoaded)
					{
						num = (short)1545994240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_70;
				case 2:
					goto IL_1D8;
				case 3:
				{
					if (!this.msiHex.IsLoaded)
					{
						goto IL_281;
					}
					num = (short)269710010;
					short num3 = num;
					num = (short)966292154;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_234;
					default:
						num = (short)1600126976;
						if (num != 0)
						{
						}
						num = (short)1128660994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					this.msiHex.Focus();
					num = (short)1498939395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)274006017;
					if (num != 0)
					{
					}
					this.msiOct.Focus();
					num = (short)626524161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 7:
					goto IL_234;
				case 8:
					goto IL_141;
				case 9:
					if (this.nmiNumber.IsLoaded)
					{
						num = (short)1252917256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AB;
				}
				IL_4C:
				if (this.ShowHexEditor)
				{
					num = (short)165543940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1738080263;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_234:
				if (this.ShowOctEditor)
				{
					num = (short)2095841285;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					this.nmiNumber.Focus();
					num = (short)864092169;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_70:
			global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.SubscribeOneShot(new global::System.Action<global::System.Windows.RoutedEventHandler>(this.d), new global::System.Action<global::System.Windows.RoutedEventHandler>(this.c), delegate(object A_0, global::System.Windows.RoutedEventArgs A_1)
			{
				short num5 = (short)785383424;
				short num6 = num5;
				num5 = (short)1223164537;
				short num7 = num5;
				num5 = (short)1027408505;
				switch (num7 == num5)
				{
				}
				num5 = (short)1809514497;
				if (num5 != 0)
				{
				}
				num5 = (short)2132606976;
				if (num5 != 0)
				{
				}
				this.msiOct.SelectAll();
			});
			return;
			IL_E3:
			this.msiOct.SelectAll();
			return;
			IL_141:
			this.nmiNumber.SelectAll();
			return;
			IL_1D8:
			num = (short)296157184;
			short num4 = num;
			this.msiHex.SelectAll();
			return;
			IL_281:
			global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.SubscribeOneShot(new global::System.Action<global::System.Windows.RoutedEventHandler>(this.f), new global::System.Action<global::System.Windows.RoutedEventHandler>(this.e), delegate(object A_0, global::System.Windows.RoutedEventArgs A_1)
			{
				short num5 = (short)1720254464;
				short num6 = num5;
				num5 = (short)1649664311;
				short num7 = num5;
				num5 = (short)72933687;
				switch (num7 == num5)
				{
				}
				num5 = (short)791740417;
				if (num5 != 0)
				{
				}
				num5 = (short)461438976;
				if (num5 != 0)
				{
				}
				this.msiHex.SelectAll();
			});
			return;
			IL_2AB:
			global::Motorola.CommonCPS.RadioManagement.Controls.EventHelper.SubscribeOneShot(new global::System.Action<global::System.Windows.RoutedEventHandler>(this.b), new global::System.Action<global::System.Windows.RoutedEventHandler>(this.a), delegate(object A_0, global::System.Windows.RoutedEventArgs A_1)
			{
				short num5 = (short)830865408;
				short num6 = num5;
				num5 = (short)156092971;
				short num7 = num5;
				num5 = (short)2146880043;
				switch (num7 == num5)
				{
				}
				num5 = (short)2108162049;
				if (num5 != 0)
				{
				}
				num5 = (short)1641152512;
				if (num5 != 0)
				{
				}
				this.nmiNumber.SelectAll();
			});
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00073120 File Offset: 0x00071320
		public override void SetCellValuePresenterMode()
		{
			short num = (short)76505444;
			short num2 = num;
			num = (short)746479972;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1898512384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)181534721;
			if (num != 0)
			{
			}
			num = (short)1927282688;
			if (num != 0)
			{
			}
			this.msiHex.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.msiOct.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.nmiNumber.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.msiHex.Background = global::System.Windows.Media.Brushes.Transparent;
			this.msiOct.Background = global::System.Windows.Media.Brushes.Transparent;
			this.nmiNumber.Background = global::System.Windows.Media.Brushes.Transparent;
			this.grdButtons.Visibility = global::System.Windows.Visibility.Hidden;
			this.borderfreeze.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00073240 File Offset: 0x00071440
		public override void HideBorder()
		{
			short num = (short)378350966;
			short num2 = num;
			num = (short)1982213494;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1539112960;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1856897025;
			if (num != 0)
			{
			}
			num = (short)1427963904;
			if (num != 0)
			{
			}
			this.msiHex.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.msiOct.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.nmiNumber.BorderBrush = global::System.Windows.Media.Brushes.Transparent;
			this.msiHex.Background = global::System.Windows.Media.Brushes.Transparent;
			this.msiOct.Background = global::System.Windows.Media.Brushes.Transparent;
			this.nmiNumber.Background = global::System.Windows.Media.Brushes.Transparent;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00073348 File Offset: 0x00071548
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 5;
			short num = (short)1393948624;
			short num2 = num;
			num = (short)1093203920;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)174915584;
				short num3 = num;
				break;
			}
			}
			num = (short)1079902208;
			if (num != 0)
			{
			}
			num = (short)987955201;
			if (num != 0)
			{
			}
			if (!this._contentLoaded)
			{
				this._contentLoaded = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("늜튞캠힢쪤햦욨잪첬膮\udcb2\ud8b4\udab6횸햺ﺼ鋀韄ꛆ귈ꋊꋌ苎냐뷒듔냖볘뛚룜뇞闠췢ꛤ裦蟨鿪鿬胮鷰胲컴银雸雺跼郾漀昂欄猆☈縊縌樎挐瀒稔礖洘椚爜猞删ఢ䌤並䰨䜪䤬䨮唰娲䄴堶䬸䠺ሼ䴾ⱀⵂい⩆ⱈ㥊⑌ⱎ㝐㩒ご㭖㵘㹚㥜㙞ᕠౢᝤ䥦ᅨ੪lͮ", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0007342C File Offset: 0x0007162C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)511877695;
			short num2 = num;
			num = (short)621519423;
			switch (num2 == num)
			{
			default:
			{
				num = (short)367919104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2133852160;
			if (num != 0)
			{
			}
			num = (short)1297416193;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000734DC File Offset: 0x000716DC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)854392833;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1959067650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_18B;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_115;
				case 2:
					goto IL_FB;
				case 3:
					goto IL_1E8;
				case 4:
					goto IL_166;
				case 5:
					goto IL_1DB;
				case 6:
					goto IL_EE;
				case 7:
					goto IL_122;
				case 8:
					goto IL_7E;
				case 9:
					goto IL_190;
				case 10:
					goto IL_108;
				case 11:
					goto IL_12F;
				default:
					num = (short)1223032832;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_7E:
			num = (short)2045133714;
			short num3 = num;
			num = (short)310264722;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_115:
				this.fedNumeric = (global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor)target;
				return;
			default:
				num = (short)1828257792;
				if (num != 0)
				{
				}
				this.rbtIncrease = (global::System.Windows.Controls.Primitives.RepeatButton)target;
				this.rbtIncrease.Click += this.rbtIncrease_Click;
				return;
			}
			IL_EE:
			this.msiOct = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_FB:
			this.grdMain = (global::System.Windows.Controls.Grid)target;
			return;
			IL_108:
			this.borderfreeze = (global::System.Windows.Controls.Border)target;
			return;
			IL_122:
			this.grdButtons = (global::System.Windows.Controls.Grid)target;
			return;
			IL_12F:
			num = (short)1410596864;
			short num4 = num;
			this.btnLock = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_166:
			this.nmiNumber = (global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericInput)target;
			return;
			IL_18B:
			this._contentLoaded = true;
			return;
			IL_190:
			num = (short)21692417;
			if (num != 0)
			{
			}
			this.rbtDecrease = (global::System.Windows.Controls.Primitives.RepeatButton)target;
			this.rbtDecrease.Click += this.rbtDecrease_Click;
			return;
			IL_1DB:
			this.msiHex = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_1E8:
			this.grdeditor = (global::System.Windows.Controls.Grid)target;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000736E8 File Offset: 0x000718E8
		// Note: this type is marked as 'beforefieldinit'.
		static RMNumericFieldEditor()
		{
			int a_ = 3;
			short num = (short)1466105856;
			short num2 = num;
			num = (short)1065871540;
			short num3 = num;
			num = (short)1799088308;
			switch (num3 == num)
			{
			}
			num = (short)2043215873;
			if (num != 0)
			{
			}
			num = (short)402391040;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsEditorOnlyProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("튚\uda9e얠쪢톤좦\udba8쎬쎮좰", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.b)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsStepIgnoredProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("튚첞햠욢햤캨얪슬\uddae풰ힲ", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.HexMaskProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펚슢횤첦", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.IsHexProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("튚힞쒠\udba2", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.MaskProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횚ﲜ쪠", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("철솢삤햦풨", a_)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowDecimalEditorProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좚횠삤쒦삨욪첬쎮ힲ\udcb4쎶횸즺", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowHexEditorProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좚횠삤\udfa6쾪쒬\udbae\udeb0솲", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor.ShowOctEditorProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좚횠욤펦쾪쒬\udbae\udeb0솲", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00073960 File Offset: 0x00071B60
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void f(global::System.Windows.RoutedEventHandler A_0)
		{
			short num = (short)1398734848;
			short num2 = num;
			num = (short)164953475;
			short num3 = num;
			num = (short)826867075;
			switch (num3 == num)
			{
			}
			num = (short)1423638528;
			if (num != 0)
			{
			}
			num = (short)515637249;
			if (num != 0)
			{
			}
			this.msiHex.Loaded += A_0;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00073A14 File Offset: 0x00071C14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void e(global::System.Windows.RoutedEventHandler A_0)
		{
			short num = (short)484311040;
			short num2 = num;
			num = (short)77528642;
			short num3 = num;
			num = (short)434961986;
			switch (num3 == num)
			{
			}
			num = (short)1585971200;
			if (num != 0)
			{
			}
			num = (short)1347092481;
			if (num != 0)
			{
			}
			this.msiHex.Loaded -= A_0;
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00073B84 File Offset: 0x00071D84
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d(global::System.Windows.RoutedEventHandler A_0)
		{
			short num = (short)1328414720;
			short num2 = num;
			num = (short)309105440;
			short num3 = num;
			num = (short)1227002656;
			switch (num3 == num)
			{
			}
			num = (short)1979383809;
			if (num != 0)
			{
			}
			num = (short)926351360;
			if (num != 0)
			{
			}
			this.msiOct.Loaded += A_0;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00073C38 File Offset: 0x00071E38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void c(global::System.Windows.RoutedEventHandler A_0)
		{
			short num = (short)122355712;
			short num2 = num;
			num = (short)1628835518;
			short num3 = num;
			num = (short)575016638;
			switch (num3 == num)
			{
			}
			num = (short)1022230529;
			if (num != 0)
			{
			}
			num = (short)493355008;
			if (num != 0)
			{
			}
			this.msiOct.Loaded -= A_0;
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00073DA4 File Offset: 0x00071FA4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(global::System.Windows.RoutedEventHandler A_0)
		{
			short num = (short)816709632;
			short num2 = num;
			num = (short)1178533889;
			if (num != 0)
			{
			}
			num = (short)1683740230;
			short num3 = num;
			num = (short)993318470;
			switch (num3 == num)
			{
			}
			num = (short)1738932224;
			if (num != 0)
			{
			}
			this.nmiNumber.Loaded += A_0;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00073E5C File Offset: 0x0007205C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(global::System.Windows.RoutedEventHandler A_0)
		{
			short num = (short)894435328;
			short num2 = num;
			num = (short)860354985;
			short num3 = num;
			num = (short)2119563689;
			switch (num3 == num)
			{
			}
			num = (short)470286337;
			if (num != 0)
			{
			}
			num = (short)1204289536;
			if (num != 0)
			{
			}
			this.nmiNumber.Loaded -= A_0;
		}

		// Token: 0x04000345 RID: 837
		public static readonly global::System.Windows.DependencyProperty IsEditorOnlyProperty;

		// Token: 0x04000346 RID: 838
		public static readonly global::System.Windows.DependencyProperty IsStepIgnoredProperty;

		// Token: 0x04000347 RID: 839
		public static readonly global::System.Windows.DependencyProperty HexMaskProperty;

		// Token: 0x04000348 RID: 840
		public static readonly global::System.Windows.DependencyProperty IsHexProperty;

		// Token: 0x04000349 RID: 841
		public static readonly global::System.Windows.DependencyProperty MaskProperty;

		// Token: 0x0400034A RID: 842
		public static readonly global::System.Windows.DependencyProperty ShowDecimalEditorProperty;

		// Token: 0x0400034B RID: 843
		public static readonly global::System.Windows.DependencyProperty ShowHexEditorProperty;

		// Token: 0x0400034C RID: 844
		public static readonly global::System.Windows.DependencyProperty ShowOctEditorProperty;

		// Token: 0x0400034D RID: 845
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericFieldEditor fedNumeric;

		// Token: 0x0400034E RID: 846
		internal global::System.Windows.Controls.Grid grdMain;

		// Token: 0x0400034F RID: 847
		internal global::System.Windows.Controls.Grid grdeditor;

		// Token: 0x04000350 RID: 848
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericInput nmiNumber;

		// Token: 0x04000351 RID: 849
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiHex;

		// Token: 0x04000352 RID: 850
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiOct;

		// Token: 0x04000353 RID: 851
		internal global::System.Windows.Controls.Grid grdButtons;

		// Token: 0x04000354 RID: 852
		internal global::System.Windows.Controls.Primitives.RepeatButton rbtIncrease;

		// Token: 0x04000355 RID: 853
		internal global::System.Windows.Controls.Primitives.RepeatButton rbtDecrease;

		// Token: 0x04000356 RID: 854
		internal global::System.Windows.Controls.Border borderfreeze;

		// Token: 0x04000357 RID: 855
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnLock;

		// Token: 0x04000358 RID: 856
		private bool _contentLoaded;
	}
}
