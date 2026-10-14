using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000055 RID: 85
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ColorInputGroup : global::DevComponents.WpfEditors.Primitives.EditorInputGroup
	{
		// Token: 0x06000533 RID: 1331 RVA: 0x00069824 File Offset: 0x00067A24
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_B8;
			}
			short num;
			int num4;
			global::DevComponents.WpfEditors.Primitives.ColorInputGroup colorInputGroup;
			for (;;)
			{
				IL_0A:
				num = (short)173455375;
				short num2 = num;
				num = (short)1946269711;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)27328513;
					if (num != 0)
					{
					}
					num = (short)1768357888;
					short num3 = num;
					num = (short)7995392;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						colorInputGroup.OnColorChanged((global::System.Windows.Media.Color?)A_1.OldValue, (global::System.Windows.Media.Color?)A_1.NewValue);
						num = (short)724566018;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (colorInputGroup != null)
						{
							num = (short)819068928;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					}
					goto IL_B8;
				}
				}
			}
			return;
			IL_B8:
			colorInputGroup = (A_0 as global::DevComponents.WpfEditors.Primitives.ColorInputGroup);
			num = (short)694681601;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0006995C File Offset: 0x00067B5C
		protected virtual void OnColorChanged(global::System.Windows.Media.Color? oldValue, global::System.Windows.Media.Color? newValue)
		{
			short num = (short)831821515;
			short num2 = num;
			num = (short)1567594187;
			switch (num2 == num)
			{
			}
			num = (short)1079050240;
			short num3 = num;
			num = (short)1924595713;
			if (num != 0)
			{
			}
			num = (short)1624571904;
			if (num != 0)
			{
			}
			this.b(newValue);
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00069A0C File Offset: 0x00067C0C
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00069AC4 File Offset: 0x00067CC4
		public global::System.Windows.Media.Color? Color
		{
			get
			{
				short num = (short)107805180;
				short num2 = num;
				num = (short)1576532476;
				switch (num2 == num)
				{
				}
				num = (short)2070609920;
				short num3 = num;
				num = (short)1958739968;
				if (num != 0)
				{
				}
				num = (short)1272381441;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Color?)base.GetValue(global::DevComponents.WpfEditors.Primitives.ColorInputGroup.ColorProperty);
			}
			set
			{
				short num = (short)830732905;
				short num2 = num;
				num = (short)1679751785;
				switch (num2 == num)
				{
				}
				num = (short)1417216000;
				short num3 = num;
				num = (short)529137665;
				if (num != 0)
				{
				}
				num = (short)871235584;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.ColorInputGroup.ColorProperty, value);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00069B7C File Offset: 0x00067D7C
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00069C38 File Offset: 0x00067E38
		public bool EditColorAlphaComponent
		{
			get
			{
				short num = (short)370814369;
				short num2 = num;
				num = (short)493039009;
				switch (num2 == num)
				{
				}
				num = (short)1980039168;
				short num3 = num;
				num = (short)382992384;
				if (num != 0)
				{
				}
				num = (short)22020097;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.ColorInputGroup.EditColorAlphaComponentProperty);
			}
			set
			{
				short num = (short)561416392;
				short num2 = num;
				num = (short)1654819016;
				switch (num2 == num)
				{
				}
				num = (short)1917714432;
				short num3 = num;
				num = (short)190447616;
				if (num != 0)
				{
				}
				num = (short)29163521;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.ColorInputGroup.EditColorAlphaComponentProperty, value);
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00069CF4 File Offset: 0x00067EF4
		public ColorInputGroup()
		{
			int a_ = 10;
			base..ctor();
			this.b = new global::DevComponents.WpfEditors.Primitives.EditorColorSwatch();
			base.Items.Add(this.b);
			this.a = new global::DevComponents.WpfEditors.FreeTextEntryBox();
			this.a.ApplyValue += this.a;
			this.a.RevertValue += this.b;
			this.a.TextChanged += this.a;
			this.a.LostKeyboardFocus += this.a;
			this.a.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
			this.a.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
			this.a.BorderThickness = default(global::System.Windows.Thickness);
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("黖꫘觚룜뻞藠곢诤详部", a_));
			binding.Source = this;
			binding.UpdateSourceTrigger = global::System.Windows.Data.UpdateSourceTrigger.PropertyChanged;
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			this.a.SetBinding(global::System.Windows.Controls.Primitives.TextBoxBase.IsReadOnlyProperty, binding);
			base.Items.Add(this.a);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00069E10 File Offset: 0x00068010
		private void a(object A_0, global::System.Windows.Controls.TextChangedEventArgs A_1)
		{
			short num = (short)214040577;
			if (num != 0)
			{
			}
			num = (short)814354640;
			short num2 = num;
			num = (short)1000345808;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1902968832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1221328896;
			if (num != 0)
			{
			}
			base.IsEmpty = string.IsNullOrEmpty(this.a.Text);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00069ED0 File Offset: 0x000680D0
		private void b(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)2109812333;
			short num2 = num;
			num = (short)1482174061;
			switch (num2 == num)
			{
			}
			num = (short)2023751680;
			short num3 = num;
			num = (short)543621121;
			if (num != 0)
			{
			}
			num = (short)557973504;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00069F78 File Offset: 0x00068178
		private void a(object A_0, global::System.Windows.Input.KeyboardFocusChangedEventArgs A_1)
		{
			short num = (short)1789853697;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1195985783;
				short num3 = num;
				num = (short)644500343;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_E0;
				default:
					num = (short)1734082560;
					if (num != 0)
					{
					}
					num = (short)94437377;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_E0;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A0;
						}
						continue;
					case 2:
						this.ResetValue();
						num = (short)1687289856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A0:
					if (this.a(true))
					{
						return;
					}
					num = (short)909312002;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E0:
			num = (short)1588789248;
			short num4 = num;
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x0006A090 File Offset: 0x00068290
		protected override void ResetValue()
		{
			short num = (short)1918628236;
			short num2 = num;
			num = (short)1879634316;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_94:
				num = (short)2053505025;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1841758208;
				if (num != 0)
				{
				}
				num = (short)818741249;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return;
				case 1:
					if (this.a != null)
					{
						num = (short)751632386;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					num = (short)1891500032;
					short num4 = num;
					this.a.Text = "";
					num = (short)599982080;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_8E;
			}
			return;
			IL_8E:
			base.ResetValue();
			goto IL_94;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0006A1B8 File Offset: 0x000683B8
		private void a(object A_0, global::System.EventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			bool a_;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2007891970;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (A_1 is global::System.Windows.Input.KeyEventArgs)
					{
						num2 = (short)1478557705;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BE;
				case 2:
					if (A_1 is global::System.Windows.Input.KeyEventArgs)
					{
						num2 = (short)1948057608;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					this.ResetValue();
					num2 = (short)1256456197;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_213;
				case 5:
					goto IL_1D1;
				case 6:
					if (((global::System.Windows.Input.KeyEventArgs)A_1).Key == global::System.Windows.Input.Key.Return)
					{
						num2 = (short)1822687243;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BE;
				case 7:
					if (((global::System.Windows.Input.KeyEventArgs)A_1).Key == global::System.Windows.Input.Key.Return)
					{
						num2 = (short)797179907;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					num2 = (short)1990459399;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)317915142;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					if (this.a(a_))
					{
						return;
					}
					num2 = (short)1638470624;
					short num3 = num2;
					num2 = (short)1164186592;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_213;
					default:
					{
						num2 = (short)2049179648;
						short num4 = num2;
						num2 = (short)505479168;
						if (num2 != 0)
						{
						}
						num2 = (short)1192820736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 11:
					a_ = true;
					num2 = (short)1392508932;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_BE:
				num2 = (short)1681588234;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_213:
				goto IL_BE;
			}
			IL_1D1:
			num2 = (short)2145320961;
			if (num2 != 0)
			{
			}
			return;
			IL_40:
			a_ = false;
			num2 = (short)739704833;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0006A41C File Offset: 0x0006861C
		private bool a(bool A_0)
		{
			int a_ = 8;
			short num = (short)979828736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_80;
				}
				string text;
				bool flag;
				object obj;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						num = (short)831389710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1708589056;
						short num3 = num;
						goto IL_3BA;
					}
					case 2:
						num = (short)1583218689;
						if (num != 0)
						{
						}
						if (A_0)
						{
							num = (short)1420886019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1575747592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_CB;
					case 4:
						text = global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_) + text;
						flag = false;
						num = (short)839581697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)410189839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C;
					case 6:
						goto IL_1D9;
					case 7:
						if (obj is global::System.Windows.Media.Color)
						{
							num = (short)1684865034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b(null);
						num = (short)868810761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						if (!(obj is global::System.Windows.Media.Color))
						{
							goto IL_3CE;
						}
						num = (short)502178416;
						short num4 = num;
						num = (short)1188340336;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CB;
						default:
							num = (short)20709376;
							if (num != 0)
							{
							}
							num = (short)715522060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						goto IL_1A9;
					case 10:
					{
						global::System.Windows.Media.Color value = (global::System.Windows.Media.Color)obj;
						this.b(new global::System.Windows.Media.Color?(value));
						num = (short)1449394182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)70385666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						this.a(new global::System.Windows.Media.Color?((global::System.Windows.Media.Color)obj));
						num = (short)277151761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (!flag)
						{
							num = (short)991232011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CE;
					case 14:
						if (!text.StartsWith(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_)))
						{
							num = (short)1013645316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C;
					case 15:
						try
						{
							obj = global::System.Windows.Media.ColorConverter.ConvertFromString(text);
							goto IL_149;
						}
						catch
						{
							flag = true;
							goto IL_149;
						}
						goto Block_9;
						IL_149:
						num = (short)1774649360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (flag)
						{
							num = (short)1559625728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C;
					case 17:
						goto IL_207;
					}
					goto IL_80;
					IL_CB:
					num = (short)1857355783;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10C:
					num = (short)1840775181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_9:
					try
					{
						IL_3BA:
						obj = global::System.Windows.Media.ColorConverter.ConvertFromString(text);
						goto IL_10C;
					}
					catch
					{
						flag = true;
						goto IL_10C;
					}
					break;
				}
				IL_1A9:
				IL_1D9:
				IL_207:
				IL_3CE:
				return !flag;
				IL_80:
				obj = null;
				flag = false;
				text = this.a.Text;
				num = (short)1031405573;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0006A818 File Offset: 0x00068A18
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)1353121793;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)585194585;
				short num3 = num;
				num = (short)906320985;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_EF;
				default:
					num = (short)873005056;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_EF;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					case 2:
						num = (short)1145700353;
						if (num != 0)
						{
						}
						this.a.Focus();
						num = (short)1042743296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7B:
					if (this.a.IsFocused)
					{
						goto IL_119;
					}
					num = (short)721354754;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_EF:
			num = (short)1257046016;
			short num4 = num;
			IL_119:
			base.OnMouseDown(e);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x0006A948 File Offset: 0x00068B48
		private void b(global::System.Windows.Media.Color? A_0)
		{
			short num = (short)1037914729;
			short num2 = num;
			num = (short)1884836457;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_7A:
				if (!this.c)
				{
					goto IL_363;
				}
				num = (short)753991682;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2052718592;
				if (num != 0)
				{
				}
				num = (short)484638721;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_68:
				switch (num3)
				{
				case 0:
					goto IL_37C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 2:
					goto IL_99;
				}
				goto IL_7A;
			}
			IL_99:
			num = (short)1517813761;
			if (num != 0)
			{
			}
			return;
			IL_37C:
			num = (short)1626341376;
			short num4 = num;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_EE;
				}
				global::System.Windows.Media.Color? color;
				global::System.Windows.Media.Color? color2;
				for (;;)
				{
					IL_A8:
					bool flag;
					switch (num3)
					{
					case 0:
						flag = true;
						goto IL_31A;
					case 1:
						goto IL_33B;
					case 2:
						flag = (color.GetValueOrDefault() != color2.GetValueOrDefault());
						goto IL_31A;
					case 3:
						if (color != null != (color2 != null))
						{
							num = (short)1487405069;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2124349448;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						flag = false;
						goto IL_31A;
					case 5:
					{
						string text;
						if (this.a.Text != text)
						{
							num = (short)58195983;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33B;
					}
					case 6:
						this.a.Text = "";
						num = (short)1838284809;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						this.Color = A_0;
						num = (short)1404567566;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (color == null)
						{
							num = (short)1945239563;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)135725058;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_33B;
					case 10:
						goto IL_359;
					case 11:
						num = (short)72286212;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						if (A_0 == null)
						{
							num = (short)602210310;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = this.a(A_0.Value);
						num = (short)961085445;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)1543569408;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_294;
					case 15:
					{
						string text;
						this.a.Text = text;
						this.a.SelectionStart = 0;
						this.a.SelectionLength = this.a.Text.Length;
						num = (short)1315766273;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_EE;
					IL_294:
					num = (short)283377676;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_31A:
					if (flag)
					{
						num = (short)1839136775;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_294;
					IL_33B:
					this.a(A_0);
					num = (short)2124480522;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_359:
				return;
				IL_EE:
				this.c = true;
				color = this.Color;
				color2 = A_0;
				num = (short)656539651;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_A8;
			}
			finally
			{
				this.c = false;
			}
			IL_363:
			num = (short)183107584;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_68;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x0006AD48 File Offset: 0x00068F48
		private string a(global::System.Windows.Media.Color A_0)
		{
			int a_ = 6;
			while (!this.EditColorAlphaComponent)
			{
				short num = (short)316794984;
				short num2 = num;
				num = (short)1403644008;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)196609;
					if (num != 0)
					{
					}
					num = (short)1325662208;
					if (num != 0)
					{
					}
					num = (short)2091515904;
					short num3 = num;
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					stringBuilder.Append(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_));
					stringBuilder.AppendFormat(null, global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꣒臘ꃜ", a_), new object[]
					{
						A_0.R
					});
					stringBuilder.AppendFormat(null, global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꣒臘ꃜ", a_), new object[]
					{
						A_0.G
					});
					stringBuilder.AppendFormat(null, global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꣒臘ꃜ", a_), new object[]
					{
						A_0.B
					});
					return stringBuilder.ToString();
				}
				}
			}
			return A_0.ToString();
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x0006AEB4 File Offset: 0x000690B4
		private void a(global::System.Windows.Media.Color? A_0)
		{
			short num = (short)673185794;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_88;
				case 1:
					goto IL_16E;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
					num = (short)1267138564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)275813847;
					short num3 = num;
					num = (short)61183447;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1544421376;
						if (num != 0)
						{
						}
						if (A_0 == null)
						{
							num = (short)776536065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					this.b.ColorBrush = new global::System.Windows.Media.SolidColorBrush(A_0.Value);
					num = (short)205848576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_38:
				if (this.b == null)
				{
					break;
				}
				num = (short)866320387;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_88:
			return;
			IL_16E:
			num = (short)1111425025;
			if (num != 0)
			{
			}
			num = (short)979632128;
			short num4 = num;
			this.b.ColorBrush = null;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0006B034 File Offset: 0x00069234
		protected override global::System.Windows.Rect GetWatermarkBounds()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::System.Windows.Rect watermarkBounds;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E1;
				case 1:
				{
					double num2 = this.b.RenderSize.Width + 4.0;
					watermarkBounds.Width -= num2;
					watermarkBounds.X += num2;
					num3 = (short)1308098560;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
					if (this.b != null)
					{
						num3 = (short)2006450179;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return watermarkBounds;
				case 3:
					goto IL_87;
				case 4:
				{
					num3 = (short)606065250;
					short num4 = num3;
					num3 = (short)160682594;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_87;
					default:
						num3 = (short)755892224;
						if (num3 != 0)
						{
						}
						if (this.b.Visibility == global::System.Windows.Visibility.Visible)
						{
							num3 = (short)748355585;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						return watermarkBounds;
					}
					break;
				}
				}
				goto IL_24;
				IL_87:
				num3 = (short)602800132;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_E1:
			num3 = (short)139657216;
			short num5 = num3;
			return watermarkBounds;
			IL_24:
			num3 = (short)1546715137;
			if (num3 != 0)
			{
			}
			watermarkBounds = base.GetWatermarkBounds();
			num3 = (short)1774714882;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0006B1DC File Offset: 0x000693DC
		// Note: this type is marked as 'beforefieldinit'.
		static ColorInputGroup()
		{
			int a_ = 1;
			short num = (short)1573458372;
			short num2 = num;
			num = (short)844501444;
			switch (num2 == num)
			{
			}
			num = (short)1137770496;
			short num3 = num;
			num = (short)1730740225;
			if (num != 0)
			{
			}
			num = (short)297664512;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.Primitives.ColorInputGroup.ColorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跍뿏뻑믓ꓕ", a_), typeof(global::System.Windows.Media.Color?), typeof(global::DevComponents.WpfEditors.Primitives.ColorInputGroup), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.ColorInputGroup.a)));
			global::DevComponents.WpfEditors.Primitives.ColorInputGroup.EditColorAlphaComponentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("词듏믑ꃓ闕럗뛙돛곝ꇟ軡铣軥觧ꧩ菫菭胯鷱髳鏵雷軹", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.ColorInputGroup), new global::System.Windows.UIPropertyMetadata(false));
		}

		// Token: 0x04000273 RID: 627
		public static readonly global::System.Windows.DependencyProperty ColorProperty;

		// Token: 0x04000274 RID: 628
		public static readonly global::System.Windows.DependencyProperty EditColorAlphaComponentProperty;

		// Token: 0x04000275 RID: 629
		private global::DevComponents.WpfEditors.FreeTextEntryBox a;

		// Token: 0x04000276 RID: 630
		private new global::DevComponents.WpfEditors.Primitives.EditorColorSwatch b;

		// Token: 0x04000277 RID: 631
		private bool c;
	}
}
