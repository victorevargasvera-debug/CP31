using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Infragistics.Controls.Editors;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000BD RID: 189
	public class RMSpecialNumericFieldEditor : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x0004F48C File Offset: 0x0004D68C
		public RMSpecialNumericFieldEditor()
		{
			int a_ = 3;
			base..ctor();
			this.InitializeComponent();
			this.nmiNumber.Text = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ꪚ", a_);
			this.msiNumber.Text = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ꮚ궜꾞邠", a_);
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0004F4E0 File Offset: 0x0004D6E0
		public global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericInput MyDecTB
		{
			get
			{
				short num = (short)1219691743;
				short num2 = num;
				num = (short)1819739359;
				switch (num2 == num)
				{
				}
				num = (short)793509889;
				if (num != 0)
				{
				}
				num = (short)965410816;
				short num3 = num;
				num = (short)1623326720;
				if (num != 0)
				{
				}
				return this.nmiNumber;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x0004F590 File Offset: 0x0004D790
		public global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput MyHexTB
		{
			get
			{
				short num = (short)1382203966;
				short num2 = num;
				num = (short)286048830;
				switch (num2 == num)
				{
				}
				num = (short)122683393;
				if (num != 0)
				{
				}
				num = (short)1671036928;
				short num3 = num;
				num = (short)1902968832;
				if (num != 0)
				{
				}
				return this.msiNumber;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x0004F640 File Offset: 0x0004D840
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x0004F6F8 File Offset: 0x0004D8F8
		public bool IsEditorOnly
		{
			get
			{
				short num = (short)1441614424;
				short num2 = num;
				num = (short)1968261720;
				switch (num2 == num)
				{
				}
				num = (short)2009530369;
				if (num != 0)
				{
				}
				num = (short)729743360;
				short num3 = num;
				num = (short)594083840;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.IsEditorOnlyProperty);
			}
			set
			{
				short num = (short)1956635033;
				short num2 = num;
				num = (short)1040376217;
				switch (num2 == num)
				{
				}
				num = (short)847577088;
				if (num != 0)
				{
				}
				num = (short)1051983872;
				short num3 = num;
				num = (short)1300103169;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.IsEditorOnlyProperty, value);
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0004F7B0 File Offset: 0x0004D9B0
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			while (!(bool)A_1.NewValue)
			{
				short num = (short)252510208;
				short num2 = num;
				num = (short)1811287425;
				short num3 = num;
				num = (short)1348734337;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)684720129;
					if (num != 0)
					{
					}
					num = (short)1928921088;
					if (num != 0)
					{
					}
					return;
				}
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor rmspecialNumericFieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor)A_0;
			rmspecialNumericFieldEditor.grdMain.ColumnDefinitions[0].Width = new global::System.Windows.GridLength(0.0);
			rmspecialNumericFieldEditor.grdMain.ColumnDefinitions[1].Width = new global::System.Windows.GridLength(0.0);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x0004F8BC File Offset: 0x0004DABC
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x0004F974 File Offset: 0x0004DB74
		public bool IsStepIgnored
		{
			get
			{
				short num = (short)1976127541;
				short num2 = num;
				num = (short)1589268533;
				switch (num2 == num)
				{
				}
				num = (short)564592641;
				if (num != 0)
				{
				}
				num = (short)281542656;
				short num3 = num;
				num = (short)1975451648;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.IsStepIgnoredProperty);
			}
			set
			{
				short num = (short)2136698937;
				short num2 = num;
				num = (short)685404217;
				switch (num2 == num)
				{
				}
				num = (short)1295646720;
				if (num != 0)
				{
				}
				num = (short)1989083136;
				short num3 = num;
				num = (short)1033109505;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.IsStepIgnoredProperty, value);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x0004FA30 File Offset: 0x0004DC30
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x0004FAEC File Offset: 0x0004DCEC
		public string HexMask
		{
			get
			{
				short num = (short)311732314;
				short num2 = num;
				num = (short)1473161306;
				switch (num2 == num)
				{
				}
				num = (short)2142437376;
				if (num != 0)
				{
				}
				num = (short)2125922304;
				short num3 = num;
				num = (short)851771393;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.HexMaskProperty);
			}
			set
			{
				short num = (short)156705727;
				short num2 = num;
				num = (short)146678719;
				switch (num2 == num)
				{
				}
				num = (short)545521665;
				if (num != 0)
				{
				}
				num = (short)1852964864;
				short num3 = num;
				num = (short)189857792;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.HexMaskProperty, value);
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0004FBA0 File Offset: 0x0004DDA0
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)306278355;
			short num2 = num;
			num = (short)166621139;
			switch (num2 == num)
			{
			}
			num = (short)168624128;
			if (num != 0)
			{
			}
			num = (short)322306048;
			short num3 = num;
			num = (short)1742405633;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor rmspecialNumericFieldEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor)A_0;
			string mask = A_1.NewValue.ToString();
			rmspecialNumericFieldEditor.msiNumber.Mask = mask;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0004FC6C File Offset: 0x0004DE6C
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x0004FD28 File Offset: 0x0004DF28
		public bool IsHex
		{
			get
			{
				short num = (short)1716790391;
				short num2 = num;
				num = (short)308880503;
				switch (num2 == num)
				{
				}
				num = (short)1487208448;
				if (num != 0)
				{
				}
				num = (short)1547763712;
				short num3 = num;
				num = (short)846200833;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.IsHexProperty);
			}
			set
			{
				short num = (short)1541103082;
				short num2 = num;
				num = (short)1497193962;
				switch (num2 == num)
				{
				}
				num = (short)814153729;
				if (num != 0)
				{
				}
				num = (short)845676544;
				short num3 = num;
				num = (short)1231224832;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.IsHexProperty, value);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x0004FDE4 File Offset: 0x0004DFE4
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x0004FE9C File Offset: 0x0004E09C
		public string Mask
		{
			get
			{
				short num = (short)1192539623;
				short num2 = num;
				num = (short)406173159;
				switch (num2 == num)
				{
				}
				num = (short)1027080192;
				if (num != 0)
				{
				}
				num = (short)1501364224;
				short num3 = num;
				num = (short)1861353473;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.MaskProperty);
			}
			set
			{
				short num = (short)1344494857;
				short num2 = num;
				num = (short)71064841;
				switch (num2 == num)
				{
				}
				num = (short)380436480;
				if (num != 0)
				{
				}
				num = (short)1801453568;
				short num3 = num;
				num = (short)1240793089;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.MaskProperty, value);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0004FF50 File Offset: 0x0004E150
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00050008 File Offset: 0x0004E208
		public bool ShowDecimalEditor
		{
			get
			{
				short num = (short)510265414;
				short num2 = num;
				num = (short)16386118;
				switch (num2 == num)
				{
				}
				num = (short)2009530369;
				if (num != 0)
				{
				}
				num = (short)731447296;
				short num3 = num;
				num = (short)315424768;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.ShowDecimalEditorProperty);
			}
			set
			{
				short num = (short)1229845652;
				short num2 = num;
				num = (short)1630598292;
				switch (num2 == num)
				{
				}
				num = (short)1772879872;
				if (num != 0)
				{
				}
				num = (short)1125384192;
				short num3 = num;
				num = (short)153288705;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.ShowDecimalEditorProperty, value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x000500C0 File Offset: 0x0004E2C0
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x00050178 File Offset: 0x0004E378
		public bool ShowHexEditor
		{
			get
			{
				short num = (short)1525046328;
				short num2 = num;
				num = (short)358505528;
				switch (num2 == num)
				{
				}
				num = (short)1066074113;
				if (num != 0)
				{
				}
				num = (short)756416512;
				short num3 = num;
				num = (short)1640431616;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.ShowHexEditorProperty);
			}
			set
			{
				short num = (short)371432019;
				short num2 = num;
				num = (short)1225300563;
				switch (num2 == num)
				{
				}
				num = (short)163250177;
				if (num != 0)
				{
				}
				num = (short)25755648;
				short num3 = num;
				num = (short)1866465280;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.ShowHexEditorProperty, value);
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00050234 File Offset: 0x0004E434
		private void btnLock_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)576494493;
			short num2 = num;
			num = (short)1289591709;
			switch (num2 == num)
			{
			}
			num = (short)1197801473;
			if (num != 0)
			{
			}
			num = (short)919076864;
			short num3 = num;
			num = (short)1571946496;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMButton rmbutton = A_0 as global::Motorola.CommonCPS.RadioManagement.Controls.RMButton;
			rmbutton.Tag = !(bool)rmbutton.Tag;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00050300 File Offset: 0x0004E500
		private void fedNumeric_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 3;
			while (this.IsStepIgnored)
			{
				short num = (short)1612972032;
				short num2 = num;
				num = (short)351861199;
				short num3 = num;
				num = (short)453310927;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1185873921;
					if (num != 0)
					{
					}
					num = (short)251789312;
					if (num != 0)
					{
					}
					this.grdButtons.Visibility = global::System.Windows.Visibility.Collapsed;
					return;
				}
			}
			this.nmiNumber.SetBinding(global::Infragistics.Controls.Editors.XamMaskedInput.SpinIncrementProperty, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좚爵토", a_));
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x000503E8 File Offset: 0x0004E5E8
		private void msiNumber_PreviewKeyDown(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.Input.Key key;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (key == global::System.Windows.Input.Key.Down)
					{
						num2 = (short)1230110723;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)1568080797;
					short num3 = num2;
					num2 = (short)1830486941;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_41;
					default:
						num2 = (short)1687814144;
						if (num2 != 0)
						{
						}
						num2 = (short)832176128;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_41;
				case 3:
					goto IL_12B;
				case 4:
					goto IL_EF;
				}
				goto IL_24;
				IL_41:
				if (key != global::System.Windows.Input.Key.Up)
				{
					num2 = (short)90308609;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)1782317056;
					short num4 = num2;
					this.a();
					num2 = (short)959447044;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_EF:
			return;
			IL_12B:
			num2 = (short)1081147393;
			if (num2 != 0)
			{
			}
			this.b();
			return;
			IL_24:
			key = A_1.Key;
			num2 = (short)1679425538;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0005054C File Offset: 0x0004E74C
		private void OnMsiValueChanged(object A_0, global::System.EventArgs A_1)
		{
			int a_ = 17;
			short num = (short)131727360;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)9240576;
				short num3 = num;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 1:
					goto IL_148;
				case 2:
				{
					this.nmiNumber.Text = this.oldNmiValue.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
					this.msiNumber.Text = global::System.Convert.ToInt32(this.nmiNumber.Value, global::System.Globalization.CultureInfo.CurrentCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("", a_), global::System.Globalization.CultureInfo.CurrentCulture);
					num = (short)1566378254;
					short num4 = num;
					num = (short)170985742;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)146407424;
						if (num != 0)
						{
						}
						num = (short)1500250113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_62:
				if (!(this.msiNumber.Text == ""))
				{
					return;
				}
				num = (short)1471938562;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_148:
			num = (short)76808193;
			if (num != 0)
			{
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000506CC File Offset: 0x0004E8CC
		private void msiNumber_TextChanged(object A_0, global::System.EventArgs A_1)
		{
			int a_ = 7;
			if (this.msiNumber.Value != null)
			{
				short num = (short)1030851489;
				short num2 = num;
				num = (short)1752730529;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)242745344;
					if (num != 0)
					{
					}
					num = (short)1940652032;
					short num3 = num;
					num = (short)1299251201;
					if (num != 0)
					{
					}
					break;
				}
				}
				this.nmiNumber.Text = int.Parse((string)this.msiNumber.Value, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.CurrentCulture).ToString(global::System.Globalization.CultureInfo.CurrentCulture);
				return;
			}
			this.nmiNumber.Text = int.Parse(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("꾞", a_), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.CurrentCulture).ToString(global::System.Globalization.CultureInfo.CurrentCulture);
			this.msiNumber.Text = "";
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00050810 File Offset: 0x0004EA10
		private void nmiNumber_TextChanged(object A_0, global::System.EventArgs A_1)
		{
			int a_ = 18;
			short num = (short)1947926528;
			switch (num)
			{
			default:
			{
				num = (short)244645888;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Windows.Media.Color color;
				global::System.Windows.Media.SolidColorBrush foreground;
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8E;
						}
						continue;
					case 1:
						if (base.Name.Contains(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﺩ얯솱삳\ud9b5햷\uddbb\uddbd꺿证ꃃ", a_)))
						{
							num = (short)97976323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E8;
					case 2:
						goto IL_3B1;
					case 3:
						this.max = 1048574;
						num = (short)1927086093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.nmiNumber.Value != null)
						{
							num = (short)1754857487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.nmiNumber.Text = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("鮩", a_);
						this.msiNumber.Text = global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("鮩", a_);
						num = (short)1126105102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_2E8;
					case 6:
						goto IL_20A;
					case 7:
					{
						if (num3 < this.min)
						{
							num = (short)1691418636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1429143552;
						short num4 = num;
						color = (global::System.Windows.Media.Color)global::System.Windows.Media.ColorConverter.ConvertFromString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삫쾭펯\ud9b1", a_));
						this.oldNmiValue = num3;
						num = (short)1102577672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_3B1;
					case 9:
						this.max = 65535;
						num = (short)1362362373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (num3 <= this.max)
						{
							num = (short)10420235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AB;
					case 11:
						num = (short)88866823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_1AB;
					case 13:
						goto IL_2E8;
					case 14:
						goto IL_20A;
					case 15:
						this.msiNumber.Text = global::System.Convert.ToInt32(this.nmiNumber.Value, global::System.Globalization.CultureInfo.CurrentCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("", a_), global::System.Globalization.CultureInfo.CurrentCulture);
						num = (short)1278869510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8E:
					if (base.Name.Contains(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﺩ얯솱삳\ud9b5햷얻춽뒿ꟁ꧃迅곇", a_)))
					{
						num = (short)1274675209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1067319297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AB:
					color = (global::System.Windows.Media.Color)global::System.Windows.Media.ColorConverter.ConvertFromString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("즫쪭", a_));
					num = (short)2121728002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20A:
					color = (global::System.Windows.Media.Color)global::System.Windows.Media.ColorConverter.ConvertFromString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삫쾭펯\ud9b1", a_));
					foreground = new global::System.Windows.Media.SolidColorBrush(color);
					num3 = global::System.Convert.ToInt32(this.nmiNumber.Text, global::System.Globalization.CultureInfo.CurrentCulture);
					num = (short)1672085514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E8:
					this.min = 1;
					num = (short)956628996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B1:
					num = (short)557227050;
					short num5 = num;
					num = (short)866491434;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_3E7;
					}
				}
				IL_3E7:
				num = (short)448921600;
				if (num != 0)
				{
				}
				num = (short)1671299073;
				if (num != 0)
				{
				}
				foreground = new global::System.Windows.Media.SolidColorBrush(color);
				this.nmiNumber.Foreground = foreground;
				this.msiNumber.Foreground = foreground;
				return;
			}
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00050C60 File Offset: 0x0004EE60
		private void nmiNumber_PreviewKeyUp(object A_0, global::System.Windows.Input.KeyEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)1554373928;
			short num2 = num;
			num = (short)957668648;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_121:
				num = (short)757530624;
				short num3 = num;
				num = (short)1205600258;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)611057664;
				if (num != 0)
				{
				}
				num = (short)1636564995;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					if (A_1.Key == global::System.Windows.Input.Key.Up)
					{
						num = (short)1171587073;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_19B;
				case 2:
					goto IL_160;
				case 3:
					num = (short)914096129;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_BC;
					}
					continue;
				case 4:
					num = (short)1352138752;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)798097414;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (A_1.Key != global::System.Windows.Input.Key.Down)
					{
						num = (short)2058027012;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E6;
				}
				IL_BC:
				if (this.msiNumber.Visibility != global::System.Windows.Visibility.Visible)
				{
					return;
				}
				num = (short)246611973;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_E6:
			this.msiNumber.Text = global::System.Convert.ToInt32(this.nmiNumber.Value, global::System.Globalization.CultureInfo.CurrentCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쎚", a_), global::System.Globalization.CultureInfo.CurrentCulture);
			goto IL_121;
			IL_160:
			return;
			IL_19B:
			goto IL_E6;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00050E4C File Offset: 0x0004F04C
		private void rbtIncrease_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)79870108;
			short num2 = num;
			num = (short)1185593500;
			switch (num2 == num)
			{
			}
			num = (short)879558657;
			if (num != 0)
			{
			}
			num = (short)1562247168;
			short num3 = num;
			num = (short)1372192768;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00050EFC File Offset: 0x0004F0FC
		private void rbtDecrease_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1695886208;
			short num2 = num;
			num = (short)894774144;
			switch (num2 == num)
			{
			}
			num = (short)1783955456;
			if (num != 0)
			{
			}
			num = (short)1992949760;
			short num3 = num;
			num = (short)542441473;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00050FAC File Offset: 0x0004F1AC
		private void b()
		{
			int a_ = 9;
			short num = (short)355074051;
			int num2 = (int)((global::System.IntPtr)num);
			int num5;
			for (;;)
			{
				num = (short)1168113664;
				short num3 = num;
				int num6;
				switch (num2)
				{
				case 0:
					if (base.Name.Contains(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("튦\udaa8\udfaa슬슮튲횴\ud9b6\udfba", a_)))
					{
						num = (short)554958849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				case 1:
					this.max = 1048574;
					num = (short)465764354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1E6;
				case 3:
					goto IL_1F;
				case 4:
					goto IL_1E6;
				case 5:
					goto IL_190;
				case 6:
				{
					num = (short)894944685;
					short num4 = num;
					num = (short)394053037;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F;
					default:
						num = (short)107216896;
						if (num != 0)
						{
						}
						this.max = 65535;
						num = (short)1401880580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					num5 = this.max;
					num = (short)897515528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_122;
				case 9:
					if (num6 == 1)
					{
						num = (short)216137729;
						if (num != 0)
						{
						}
						num = (short)1692205063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num5 = num6 - 1;
					num = (short)1832779781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_82;
				IL_1F:
				switch (0)
				{
				case 0:
					IL_82:
					if (base.Name.Contains(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("튦\udaa8\udfaa슬슮쪲운쎶\udcb8횺\udbbe", a_)))
					{
						num = (short)1920532486;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1074331648;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				continue;
				IL_1E6:
				this.min = 1;
				num6 = global::System.Convert.ToInt32(this.nmiNumber.Text, global::System.Globalization.CultureInfo.CurrentCulture);
				num5 = 0;
				num = (short)227803145;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_122:
			IL_190:
			this.nmiNumber.Text = num5.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00051238 File Offset: 0x0004F438
		private void a()
		{
			int a_ = 6;
			short num = (short)1681981443;
			int num2 = (int)((global::System.IntPtr)num);
			int num5;
			for (;;)
			{
				num = (short)700907520;
				short num3 = num;
				int num6;
				switch (num2)
				{
				case 0:
					if (base.Name.Contains(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪝톣향\udca7얩솫玲톯톱\udab3ﾵ\udcb7", a_)))
					{
						num = (short)1479278593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_204;
				case 1:
					num = (short)94502913;
					if (num != 0)
					{
					}
					this.max = 1048574;
					num = (short)278003714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_204;
				case 3:
					goto IL_1D;
				case 4:
					goto IL_204;
				case 5:
					goto IL_1AF;
				case 6:
				{
					num = (short)2032014595;
					short num4 = num;
					num = (short)1258099971;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)1442185216;
						if (num != 0)
						{
						}
						this.max = 65535;
						num = (short)1601896452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					num5 = 1;
					num = (short)1290403848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_118;
				case 9:
					if (num6 >= this.max)
					{
						num = (short)2000683015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num5 = num6 + 1;
					num = (short)275120133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_7D;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_7D:
					if (base.Name.Contains(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪝톣향\udca7얩솫ﶭ즯솱삳펵햷\ud8bb", a_)))
					{
						num = (short)2037710854;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)906428416;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				continue;
				IL_204:
				this.min = 1;
				num6 = global::System.Convert.ToInt32(this.nmiNumber.Text, global::System.Globalization.CultureInfo.CurrentCulture);
				num5 = 0;
				num = (short)106823689;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_118:
			IL_1AF:
			this.nmiNumber.Text = num5.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000514C0 File Offset: 0x0004F6C0
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 2;
			if (this._contentLoaded)
			{
				short num = (short)769193274;
				short num2 = num;
				num = (short)1831597370;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1703215105;
					if (num != 0)
					{
					}
					num = (short)1599602688;
					short num3 = num;
					num = (short)698548224;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("떙톛풟춡횣즥쒧쮩芫\udfaf\udfb1\ud9b3\ud9b5횷惡郁ꗃꋅꇇꗉ臋꿍뻏돑돓돕뗗뿙닛ꫝ컟ꇡ诣裥鳧飩菫苭華짱音駵闷諹鏻都旿氁瀃⤅紇礉椋簍猏紑稓戕樗甙瀛洝༟䌡圣別娧䔩̫尭崯䄱䐳匵嬷匹崻刽⸿㝁⥃⍅㩇⍉⽋⡍㥏㝑㡓㉕㵗㹙㕛⩝ཟၡ䩣ṥ१ݩk", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000515A4 File Offset: 0x0004F7A4
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)1500154150;
			short num2 = num;
			num = (short)1628997926;
			switch (num2 == num)
			{
			}
			num = (short)458424321;
			if (num != 0)
			{
			}
			num = (short)2106130432;
			short num3 = num;
			num = (short)1031143424;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00051658 File Offset: 0x0004F858
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1622540289;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1496444230;
					short num3 = num;
					num = (short)305786182;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_110;
					default:
					{
						num = (short)1095303168;
						if (num != 0)
						{
						}
						num = (short)1661730816;
						short num4 = num;
						num = (short)516554754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					num = (short)2095054849;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 2:
					goto IL_167;
				}
				IL_59:
				switch (connectionId)
				{
				case 1:
					goto IL_11D;
				case 2:
					goto IL_18D;
				case 3:
					goto IL_110;
				case 4:
					goto IL_103;
				case 5:
					goto IL_169;
				case 6:
					goto IL_12A;
				default:
					num = (short)606601216;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_103:
			this.grdButtons = (global::System.Windows.Controls.Grid)target;
			return;
			IL_110:
			this.msiNumber = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)target;
			return;
			IL_11D:
			this.grdMain = (global::System.Windows.Controls.Grid)target;
			return;
			IL_12A:
			this.rbtDecrease = (global::System.Windows.Controls.Primitives.RepeatButton)target;
			this.rbtDecrease.Click += this.rbtDecrease_Click;
			return;
			IL_167:
			this._contentLoaded = true;
			return;
			IL_169:
			this.rbtIncrease = (global::System.Windows.Controls.Primitives.RepeatButton)target;
			this.rbtIncrease.Click += this.rbtIncrease_Click;
			return;
			IL_18D:
			this.nmiNumber = (global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericInput)target;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00051808 File Offset: 0x0004FA08
		// Note: this type is marked as 'beforefieldinit'.
		static RMSpecialNumericFieldEditor()
		{
			int a_ = 3;
			short num = (short)2085814273;
			if (num != 0)
			{
			}
			num = (short)254137563;
			short num2 = num;
			num = (short)1660802267;
			switch (num2 == num)
			{
			}
			num = (short)80281600;
			if (num != 0)
			{
			}
			num = (short)1460666368;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.IsEditorOnlyProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("튚\uda9e얠쪢톤좦\udba8쎬쎮좰", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.b)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.IsStepIgnoredProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("튚첞햠욢햤캨얪슬\uddae풰ힲ", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.HexMaskProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펚슢횤첦", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.IsHexProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("튚힞쒠\udba2", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.MaskProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("횚ﲜ쪠", a_), typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("철솢삤햦풨", a_)));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.ShowDecimalEditorProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좚횠삤쒦삨욪첬쎮ힲ\udcb4쎶횸즺", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor.ShowHexEditorProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("좚횠삤\udfa6쾪쒬\udbae\udeb0솲", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMSpecialNumericFieldEditor), new global::System.Windows.FrameworkPropertyMetadata(false));
		}

		// Token: 0x040001DE RID: 478
		private int max;

		// Token: 0x040001DF RID: 479
		private int min;

		// Token: 0x040001E0 RID: 480
		private int oldNmiValue;

		// Token: 0x040001E1 RID: 481
		public static readonly global::System.Windows.DependencyProperty IsEditorOnlyProperty;

		// Token: 0x040001E2 RID: 482
		public static readonly global::System.Windows.DependencyProperty IsStepIgnoredProperty;

		// Token: 0x040001E3 RID: 483
		public static readonly global::System.Windows.DependencyProperty HexMaskProperty;

		// Token: 0x040001E4 RID: 484
		public static readonly global::System.Windows.DependencyProperty IsHexProperty;

		// Token: 0x040001E5 RID: 485
		public static readonly global::System.Windows.DependencyProperty MaskProperty;

		// Token: 0x040001E6 RID: 486
		public static readonly global::System.Windows.DependencyProperty ShowDecimalEditorProperty;

		// Token: 0x040001E7 RID: 487
		public static readonly global::System.Windows.DependencyProperty ShowHexEditorProperty;

		// Token: 0x040001E8 RID: 488
		internal global::System.Windows.Controls.Grid grdMain;

		// Token: 0x040001E9 RID: 489
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMNumericInput nmiNumber;

		// Token: 0x040001EA RID: 490
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput msiNumber;

		// Token: 0x040001EB RID: 491
		internal global::System.Windows.Controls.Grid grdButtons;

		// Token: 0x040001EC RID: 492
		internal global::System.Windows.Controls.Primitives.RepeatButton rbtIncrease;

		// Token: 0x040001ED RID: 493
		internal global::System.Windows.Controls.Primitives.RepeatButton rbtDecrease;

		// Token: 0x040001EE RID: 494
		private bool _contentLoaded;
	}
}
