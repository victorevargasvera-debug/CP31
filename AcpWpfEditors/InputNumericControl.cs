using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000018 RID: 24
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class InputNumericControl : global::DevComponents.WpfEditors.InputBaseControl
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600018C RID: 396 RVA: 0x0001F0E4 File Offset: 0x0001D2E4
		// (set) Token: 0x0600018D RID: 397 RVA: 0x0001F19C File Offset: 0x0001D39C
		public bool NavigationKeyValueChange
		{
			get
			{
				short num = (short)2059404919;
				short num2 = num;
				num = (short)1133446775;
				switch (num2 == num)
				{
				}
				num = (short)341770240;
				short num3 = num;
				num = (short)1271463937;
				if (num != 0)
				{
				}
				num = (short)462487552;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputNumericControl.NavigationKeyValueChangeProperty);
			}
			set
			{
				short num = (short)1475893192;
				short num2 = num;
				num = (short)1503418312;
				switch (num2 == num)
				{
				}
				num = (short)23592960;
				short num3 = num;
				num = (short)1445724160;
				if (num != 0)
				{
				}
				num = (short)178782209;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputNumericControl.NavigationKeyValueChangeProperty, value);
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0001F254 File Offset: 0x0001D454
		private new static void d(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1003500172;
			short num2 = num;
			num = (short)512373388;
			global::DevComponents.WpfEditors.InputNumericControl inputNumericControl;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D3:
				if (inputNumericControl == null)
				{
					return;
				}
				num = (short)714342401;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)204013568;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				break;
			}
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					goto IL_125;
				case 1:
					inputNumericControl.OnShowUpDownChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num = (short)126812160;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_D3;
				}
				goto IL_67;
			}
			IL_125:
			return;
			IL_67:
			num = (short)351600640;
			short num4 = num;
			num = (short)141033473;
			if (num != 0)
			{
			}
			inputNumericControl = (A_0 as global::DevComponents.WpfEditors.InputNumericControl);
			num = (short)1824456706;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0001F388 File Offset: 0x0001D588
		protected virtual void OnShowUpDownChanged(bool oldValue, bool newValue)
		{
			short num = (short)1199953734;
			short num2 = num;
			num = (short)1377687366;
			switch (num2 == num)
			{
			}
			num = (short)958332928;
			short num3 = num;
			num = (short)2039283713;
			if (num != 0)
			{
			}
			num = (short)685178880;
			if (num != 0)
			{
			}
			this.e();
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0001F434 File Offset: 0x0001D634
		// (set) Token: 0x06000191 RID: 401 RVA: 0x0001F4F0 File Offset: 0x0001D6F0
		public bool ShowUpDown
		{
			get
			{
				short num = (short)1500361347;
				short num2 = num;
				num = (short)844870275;
				switch (num2 == num)
				{
				}
				num = (short)1893859328;
				short num3 = num;
				num = (short)1530003456;
				if (num != 0)
				{
				}
				num = (short)460652545;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputNumericControl.ShowUpDownProperty);
			}
			set
			{
				short num = (short)634146335;
				short num2 = num;
				num = (short)576409119;
				switch (num2 == num)
				{
				}
				num = (short)2024079360;
				short num3 = num;
				num = (short)1361969153;
				if (num != 0)
				{
				}
				num = (short)968425472;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputNumericControl.ShowUpDownProperty, value);
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000192 RID: 402 RVA: 0x0001F5A8 File Offset: 0x0001D7A8
		// (remove) Token: 0x06000193 RID: 403 RVA: 0x0001F65C File Offset: 0x0001D85C
		public event global::System.Windows.RoutedEventHandler ValueChanged
		{
			add
			{
				short num = (short)1999914348;
				short num2 = num;
				num = (short)1911375212;
				switch (num2 == num)
				{
				}
				num = (short)15335424;
				short num3 = num;
				num = (short)1638334464;
				if (num != 0)
				{
				}
				num = (short)1913126913;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.InputNumericControl.ValueChangedEvent, value);
			}
			remove
			{
				short num = (short)1565351074;
				short num2 = num;
				num = (short)1652776098;
				switch (num2 == num)
				{
				}
				num = (short)1609957376;
				short num3 = num;
				num = (short)248774657;
				if (num != 0)
				{
				}
				num = (short)119734272;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.InputNumericControl.ValueChangedEvent, value);
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0001F710 File Offset: 0x0001D910
		protected virtual void OnValueChanged(global::System.Windows.RoutedEventArgs eventArgs)
		{
			short num = (short)1857430068;
			short num2 = num;
			num = (short)1104880180;
			switch (num2 == num)
			{
			}
			num = (short)1978400768;
			short num3 = num;
			num = (short)1027866625;
			if (num != 0)
			{
			}
			num = (short)1134559232;
			if (num != 0)
			{
			}
			base.RaiseEvent(eventArgs);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001F7C0 File Offset: 0x0001D9C0
		private new static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)2062044351;
			short num2 = num;
			num = (short)285691071;
			global::DevComponents.WpfEditors.InputNumericControl inputNumericControl;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D7:
				if (inputNumericControl == null)
				{
					return;
				}
				num = (short)1510539265;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)541851648;
				if (num != 0)
				{
				}
				num = (short)1889861633;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_BA;
				}
				break;
			}
			for (;;)
			{
				IL_7F:
				num = (short)1840906240;
				short num4 = num;
				switch (num3)
				{
				case 0:
					goto IL_127;
				case 1:
					inputNumericControl.OnShowClearButtonChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num = (short)1273954304;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_D7;
				}
				goto IL_BA;
			}
			IL_127:
			return;
			IL_BA:
			inputNumericControl = (A_0 as global::DevComponents.WpfEditors.InputNumericControl);
			num = (short)508755970;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7F;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001F8F8 File Offset: 0x0001DAF8
		protected virtual void OnShowClearButtonChanged(bool oldValue, bool newValue)
		{
			short num = (short)1624432352;
			short num2 = num;
			num = (short)930012896;
			switch (num2 == num)
			{
			}
			num = (short)732168192;
			short num3 = num;
			num = (short)826998784;
			if (num != 0)
			{
			}
			num = (short)1711407105;
			if (num != 0)
			{
			}
			this.d();
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0001F9A8 File Offset: 0x0001DBA8
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0001FA60 File Offset: 0x0001DC60
		public bool ShowClearButton
		{
			get
			{
				short num = (short)1424282442;
				short num2 = num;
				num = (short)299750218;
				switch (num2 == num)
				{
				}
				num = (short)1783955457;
				if (num != 0)
				{
				}
				num = (short)1675165696;
				short num3 = num;
				num = (short)1820196864;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputNumericControl.ShowClearButtonProperty);
			}
			set
			{
				short num = (short)773277307;
				short num2 = num;
				num = (short)1201358459;
				switch (num2 == num)
				{
				}
				num = (short)2121859073;
				if (num != 0)
				{
				}
				num = (short)1484783616;
				short num3 = num;
				num = (short)410845184;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputNumericControl.ShowClearButtonProperty, value);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0001FB1C File Offset: 0x0001DD1C
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AllowEmptyState
		{
			get
			{
				short num = (short)1467396242;
				short num2 = num;
				num = (short)1426501778;
				switch (num2 == num)
				{
				}
				num = (short)796721153;
				if (num != 0)
				{
				}
				num = (short)1671561216;
				short num3 = num;
				num = (short)475594752;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputNumericControl.AllowEmptyStateProperty);
			}
			set
			{
				short num = (short)1950172704;
				short num2 = num;
				num = (short)1960199712;
				switch (num2 == num)
				{
				}
				num = (short)1437925377;
				if (num != 0)
				{
				}
				num = (short)1232535552;
				short num3 = num;
				num = (short)332922880;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputNumericControl.AllowEmptyStateProperty, value);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0001FC94 File Offset: 0x0001DE94
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0001FD4C File Offset: 0x0001DF4C
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Description("Indicates Numeric String Format that is used to format the numeric value entered for display purpose.")]
		public string DisplayFormat
		{
			get
			{
				short num = (short)94130324;
				short num2 = num;
				num = (short)1704874132;
				switch (num2 == num)
				{
				}
				num = (short)2081161217;
				if (num != 0)
				{
				}
				num = (short)1388707840;
				short num3 = num;
				num = (short)1295384576;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfEditors.InputNumericControl.DisplayFormatProperty);
			}
			set
			{
				short num = (short)1993516828;
				short num2 = num;
				num = (short)1651353372;
				switch (num2 == num)
				{
				}
				num = (short)190840832;
				if (num != 0)
				{
				}
				num = (short)2054553600;
				short num3 = num;
				num = (short)338755585;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputNumericControl.DisplayFormatProperty, value);
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001FE04 File Offset: 0x0001E004
		protected override void OnInputGroupAssigned()
		{
			short num = (short)663359726;
			short num2 = num;
			num = (short)1334513902;
			switch (num2 == num)
			{
			}
			num = (short)1012269057;
			if (num != 0)
			{
			}
			num = (short)169934848;
			short num3 = num;
			num = (short)1722351616;
			if (num != 0)
			{
			}
			this.e();
			this.d();
			this.c();
			this.UpdateInputGroupBindings();
			base.OnInputGroupAssigned();
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0001FEC8 File Offset: 0x0001E0C8
		protected virtual void UpdateInputGroupBindings()
		{
			int a_ = 13;
			global::DevComponents.WpfEditors.Primitives.EditorInputGroup editorInputGroup;
			short num;
			for (;;)
			{
				editorInputGroup = (this.GetInputGroup() as global::DevComponents.WpfEditors.Primitives.EditorInputGroup);
				if (editorInputGroup == null)
				{
					break;
				}
				num = (short)769025467;
				short num2 = num;
				num = (short)1965057467;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_51;
				}
			}
			return;
			IL_51:
			num = (short)1958477825;
			if (num != 0)
			{
			}
			num = (short)133496832;
			if (num != 0)
			{
			}
			num = (short)1455882240;
			short num3 = num;
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跙뷛ꫝ藟郡解蟥髧臩귫苭駯闱髳鯵鷷铹裻", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			editorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkAlignmentProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跙뷛ꫝ藟郡解蟥髧臩껫语飯鏱苳鿵韷裹", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			editorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkBehaviorProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跙뷛ꫝ藟郡解蟥髧臩껫鳭藯臱鳳", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			editorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkBrushProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跙뷛ꫝ藟郡解蟥髧臩ꧫ胭釯郱飳鏵鳷", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			editorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkEnabledProperty, binding);
			binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("跙뷛ꫝ藟郡解蟥髧臩룫语裯蛱", a_));
			binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
			binding.Source = this;
			editorInputGroup.SetBinding(global::DevComponents.WpfEditors.Primitives.EditorInputGroup.WatermarkTextProperty, binding);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00020078 File Offset: 0x0001E278
		private void e()
		{
			global::DevComponents.WpfEditors.Primitives.EditorGroup inputGroup;
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						inputGroup.Items.Remove(this.a);
						num2 = (short)909115394;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_7A;
					case 2:
						goto IL_220;
					case 3:
					{
						num2 = (short)1775501312;
						short num3 = num2;
						if (this.a == null)
						{
							num2 = (short)953876491;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_97;
					}
					case 4:
						num2 = (short)1059061761;
						if (num2 != 0)
						{
						}
						if (inputGroup.Items.Contains(this.a))
						{
							num2 = (short)404946952;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_7F;
					case 5:
						num2 = (short)925761539;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						goto IL_97;
					case 7:
						goto IL_1F3;
					case 8:
						inputGroup.Items.Remove(this.a);
						num2 = (short)333316103;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						if (inputGroup == null)
						{
							num2 = (short)1510277121;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)530055178;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
						if (this.ShowUpDown)
						{
							num2 = (short)212205573;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)985595916;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
						this.a = new global::DevComponents.WpfEditors.Primitives.EditorUpDownButton();
						this.a.AutoChangeItem = this.GetDefaultInputItem();
						this.a.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Right;
						num2 = (short)552271878;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 12:
						if (this.a != null)
						{
							num2 = (short)72876032;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2D3;
					}
					goto IL_44;
					IL_97:
					num2 = (short)664862724;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_7A:
				num2 = (short)1308433704;
				short num4 = num2;
				num2 = (short)1449991464;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_1B4;
				}
				IL_44:
				inputGroup = this.GetInputGroup();
				num2 = (short)3342345;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_7F:
			inputGroup.Items.Insert(this.GetUpDownButtonInsertPosition(), this.a);
			return;
			IL_1B4:
			num2 = (short)1405091840;
			if (num2 != 0)
			{
			}
			return;
			IL_1F3:
			goto IL_7F;
			IL_220:
			IL_2D3:
			this.a = null;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00020360 File Offset: 0x0001E560
		private new void d()
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			global::DevComponents.WpfEditors.Primitives.EditorGroup inputGroup;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					inputGroup.Items.Remove(this.b);
					this.b.Click -= this.b;
					num2 = (short)676397058;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
					goto IL_220;
				case 3:
					if (this.b == null)
					{
						num2 = (short)1279459339;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_8E;
				case 4:
					if (this.ShowUpDown)
					{
						num2 = (short)967639048;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7B;
				case 5:
					num2 = (short)486932483;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_8E;
				case 7:
					goto IL_1DB;
				case 8:
					num2 = (short)393740289;
					if (num2 != 0)
					{
					}
					num3++;
					num2 = (short)1348206599;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (inputGroup == null)
					{
						num2 = (short)179306497;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1321598986;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					num2 = (short)475688247;
					short num4 = num2;
					num2 = (short)1050963255;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8E;
					default:
						num2 = (short)2057175040;
						if (num2 != 0)
						{
						}
						if (this.ShowClearButton)
						{
							num2 = (short)223674373;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1686568972;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
				{
					num2 = (short)275644416;
					short num5 = num2;
					this.b = new global::DevComponents.WpfEditors.Primitives.EditorClearButton();
					this.b.Click += this.b;
					this.b.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Right;
					num2 = (short)272433158;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
					if (this.b != null)
					{
						num2 = (short)375193600;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D7;
				}
				goto IL_44;
				IL_8E:
				num3 = this.GetUpDownButtonInsertPosition();
				num2 = (short)401997828;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_7B:
			inputGroup.Items.Insert(num3, this.b);
			return;
			IL_1DB:
			goto IL_7B;
			IL_220:
			IL_2D7:
			this.b = null;
			return;
			IL_44:
			inputGroup = this.GetInputGroup();
			num2 = (short)57081865;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0002064C File Offset: 0x0001E84C
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1964023204;
			short num2 = num;
			num = (short)284990884;
			switch (num2 == num)
			{
			}
			num = (short)930545665;
			if (num != 0)
			{
			}
			num = (short)1062141952;
			short num3 = num;
			num = (short)1315110912;
			if (num != 0)
			{
			}
			this.ResetValue();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000206FC File Offset: 0x0001E8FC
		protected virtual void ResetValue()
		{
			short num = (short)1984042099;
			short num2 = num;
			num = (short)82842739;
			switch (num2 == num)
			{
			}
			num = (short)668008449;
			if (num != 0)
			{
			}
			num = (short)57737216;
			short num3 = num;
			num = (short)846528512;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000207AC File Offset: 0x0001E9AC
		protected virtual global::DevComponents.WpfEditors.Primitives.EditorInputBase GetDefaultInputItem()
		{
			short num = (short)1761716366;
			short num2 = num;
			num = (short)1914873998;
			switch (num2 == num)
			{
			}
			num = (short)1485504513;
			if (num != 0)
			{
			}
			num = (short)192872448;
			short num3 = num;
			num = (short)2031681536;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0002085C File Offset: 0x0001EA5C
		protected virtual int GetUpDownButtonInsertPosition()
		{
			short num = (short)1426538618;
			short num2 = num;
			num = (short)1683898490;
			switch (num2 == num)
			{
			}
			num = (short)926482433;
			if (num != 0)
			{
			}
			num = (short)1022820352;
			short num3 = num;
			num = (short)1374289920;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0002090C File Offset: 0x0001EB0C
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.InputNumericControl inputNumericControl;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (inputNumericControl != null)
					{
						num2 = (short)1217789954;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					num2 = (short)84199813;
					short num3 = num2;
					num2 = (short)984009093;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)31457280;
						if (num2 != 0)
						{
						}
						num2 = (short)1714683905;
						if (num2 != 0)
						{
						}
						inputNumericControl.OnShowFreeTextChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
						num2 = (short)1138950144;
						short num4 = num2;
						num2 = (short)1031012353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			inputNumericControl = (A_0 as global::DevComponents.WpfEditors.InputNumericControl);
			num2 = (short)988086272;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00020A40 File Offset: 0x0001EC40
		protected virtual void OnShowFreeTextChanged(bool oldValue, bool newValue)
		{
			short num = (short)815782216;
			short num2 = num;
			num = (short)490789192;
			switch (num2 == num)
			{
			}
			num = (short)1914830849;
			if (num != 0)
			{
			}
			num = (short)1103364096;
			short num3 = num;
			num = (short)2117730304;
			if (num != 0)
			{
			}
			this.c();
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00020AEC File Offset: 0x0001ECEC
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00020BA4 File Offset: 0x0001EDA4
		public bool ShowFreeText
		{
			get
			{
				short num = (short)389939201;
				if (num != 0)
				{
				}
				num = (short)467810454;
				short num2 = num;
				num = (short)1046362262;
				switch (num2 == num)
				{
				}
				num = (short)1120337920;
				short num3 = num;
				num = (short)1994981376;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputNumericControl.ShowFreeTextProperty);
			}
			set
			{
				short num = (short)609184760;
				short num2 = num;
				num = (short)1185442808;
				switch (num2 == num)
				{
				}
				num = (short)218300416;
				if (num != 0)
				{
				}
				num = (short)1393098752;
				short num3 = num;
				num = (short)1969750017;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputNumericControl.ShowFreeTextProperty, value);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060001A9 RID: 425 RVA: 0x00020C5C File Offset: 0x0001EE5C
		// (remove) Token: 0x060001AA RID: 426 RVA: 0x00020D14 File Offset: 0x0001EF14
		[global::System.ComponentModel.Category("Free-Text")]
		[global::System.ComponentModel.Description("Occurs if Free-Text entry value is not natively recognized by the control and provides you with opportunity to convert that value to the value control expects.")]
		public event global::System.Windows.RoutedEventHandler ConvertFreeTextEntry
		{
			add
			{
				short num = (short)542799658;
				short num2 = num;
				num = (short)1600943914;
				switch (num2 == num)
				{
				}
				num = (short)2056388609;
				if (num != 0)
				{
				}
				num = (short)1534263296;
				short num3 = num;
				num = (short)1199439872;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.InputNumericControl.ConvertFreeTextEntryEvent, value);
			}
			remove
			{
				short num = (short)1776538644;
				short num2 = num;
				num = (short)369349652;
				switch (num2 == num)
				{
				}
				num = (short)942473216;
				if (num != 0)
				{
				}
				num = (short)1525547008;
				short num3 = num;
				num = (short)647954433;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.InputNumericControl.ConvertFreeTextEntryEvent, value);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00020DCC File Offset: 0x0001EFCC
		protected virtual void OnConvertFreeTextEntry(global::DevComponents.WpfEditors.FreeTextEntryConversionEventArgs eventArgs)
		{
			short num = (short)796196865;
			if (num != 0)
			{
			}
			num = (short)1700527232;
			short num2 = num;
			num = (short)1272249472;
			switch (num2 == num)
			{
			}
			num = (short)1722941440;
			short num3 = num;
			num = (short)1248460800;
			if (num != 0)
			{
			}
			base.RaiseEvent(eventArgs);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00020E7C File Offset: 0x0001F07C
		protected override void UpdateFreeTextBoxValue()
		{
			short num = (short)637927429;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)201665669;
					short num3 = num;
					num = (short)1628187781;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_53;
					default:
					{
						num = (short)146604032;
						short num4 = num;
						num = (short)187301888;
						if (num != 0)
						{
						}
						this.d.Text = this.ToString();
						num = (short)689045510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					this.d.SelectAll();
					num = (short)1513291783;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1712586760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)726335492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!this.c)
					{
						num = (short)1663303682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 6:
					if (!this.d.IsFocused)
					{
						num = (short)1877344257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					return;
				case 8:
					num = (short)556466177;
					if (num != 0)
					{
					}
					if (this.ToString() != this.d.Text)
					{
						num = (short)718864384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_48;
				IL_53:
				num = (short)2130640899;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_48:
				if (this.d != null)
				{
					goto IL_53;
				}
				break;
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00021094 File Offset: 0x0001F294
		protected override bool FocusFirstInput()
		{
			short num = (short)1421213697;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C6;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					num = (short)1789919233;
					if (num != 0)
					{
					}
					num = (short)1798635523;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					IL_A7:
					if (this.FreeTextEntryMode)
					{
						num = (short)1195573248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F0;
				}
				IL_34:
				if (this.SupportsFreeTextEntry)
				{
					num = (short)869597186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F0:
				num = (short)2139667830;
				short num3 = num;
				num = (short)287161718;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A7;
				default:
					goto IL_127;
				}
			}
			IL_C6:
			num = (short)490274816;
			short num4 = num;
			this.IsFreeTextBoxVisible = true;
			return this.d.IsFocused;
			IL_127:
			num = (short)1664221184;
			if (num != 0)
			{
			}
			return base.FocusFirstInput();
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000211E4 File Offset: 0x0001F3E4
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)627900417;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.FreeTextEntryMode)
					{
						num = (short)1318256643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_158;
				case 1:
				{
					num = (short)984875008;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				case 2:
				{
					num = (short)247005173;
					short num4 = num;
					num = (short)973209589;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_153;
					default:
						num = (short)1013186561;
						if (num != 0)
						{
						}
						num = (short)2014576640;
						if (num != 0)
						{
						}
						num = (short)2082406400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_153;
				case 4:
					goto IL_A5;
				}
				IL_62:
				if (this.SupportsFreeTextEntry)
				{
					num = (short)1870331906;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_153:
				this.IsFreeTextBoxVisible = base.IsKeyboardFocusWithin;
				num = (short)57868292;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A5:
			IL_158:
			base.OnIsKeyboardFocusWithinChanged(e);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00021350 File Offset: 0x0001F550
		private new void c()
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			global::DevComponents.WpfEditors.Primitives.EditorGroup inputGroup;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1649147905;
					if (num2 != 0)
					{
					}
					inputGroup.Items.Remove(this.c);
					this.c.Click -= this.a;
					num2 = (short)363921410;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
					goto IL_218;
				case 3:
					if (this.c == null)
					{
						num2 = (short)784531467;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_90;
				case 4:
					if (this.ShowUpDown)
					{
						num2 = (short)1869479944;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7D;
				case 5:
					num2 = (short)787939331;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_90;
				case 7:
					goto IL_1D3;
				case 8:
					num3++;
					num2 = (short)2060582919;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (inputGroup == null)
					{
						num2 = (short)1519714305;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1889206282;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					num2 = (short)1478089151;
					short num4 = num2;
					num2 = (short)1247992255;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_90;
					default:
						num2 = (short)233046016;
						if (num2 != 0)
						{
						}
						if (this.ShowFreeText)
						{
							num2 = (short)628948997;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)670171148;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
				{
					num2 = (short)243859456;
					short num5 = num2;
					this.c = new global::DevComponents.WpfEditors.Primitives.EditorFreeTextButton();
					this.c.IsChecked = this.FreeTextEntryMode;
					this.c.Click += this.a;
					this.c.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Right;
					num2 = (short)138608646;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
					if (this.c != null)
					{
						num2 = (short)276496384;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E5;
				}
				goto IL_44;
				IL_90:
				num3 = this.GetUpDownButtonInsertPosition();
				num2 = (short)2110390276;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_7D:
			inputGroup.Items.Insert(num3, this.c);
			return;
			IL_1D3:
			goto IL_7D;
			IL_218:
			IL_2E5:
			this.c = null;
			return;
			IL_44:
			inputGroup = this.GetInputGroup();
			num2 = (short)360185865;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0002164C File Offset: 0x0001F84C
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)214605827;
			short num2 = num;
			num = (short)1210949635;
			switch (num2 == num)
			{
			}
			num = (short)1348796417;
			if (num != 0)
			{
			}
			num = (short)1251540992;
			short num3 = num;
			num = (short)826605568;
			if (num != 0)
			{
			}
			this.b();
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000216FC File Offset: 0x0001F8FC
		private void b()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::System.Windows.RoutedEventArgs routedEventArgs;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_F9;
				case 1:
					goto IL_1BE;
				case 2:
					if (this.d != null)
					{
						num2 = (short)372244487;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
				{
					num2 = (short)1809737325;
					short num3 = num2;
					num2 = (short)812017261;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_144;
					default:
						goto IL_1F9;
					}
					break;
				}
				case 4:
					this.d.Focus();
					num2 = (short)920846337;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!this.d.IsFocused)
					{
						num2 = (short)768606212;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					base.FocusInput();
					num2 = (short)435159041;
					if (num2 != 0)
					{
					}
					num2 = (short)593166336;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)913309701;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					if (routedEventArgs.Handled)
					{
						num2 = (short)1574830083;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.InputNumericControl.ButtonFreeTextClickEvent);
					base.RaiseEvent(e);
					num2 = (short)519962635;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					if (this.FreeTextEntryMode)
					{
						num2 = (short)291831818;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
					goto IL_144;
				case 11:
					if (!base.IsKeyboardFocusWithin)
					{
						num2 = (short)555417606;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F9;
				}
				goto IL_40;
				IL_F9:
				this.FreeTextEntryMode = !this.FreeTextEntryMode;
				num2 = (short)1157496841;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_144:
				num2 = (short)2028339202;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1BE:
			return;
			IL_1F9:
			num2 = (short)945487872;
			if (num2 != 0)
			{
			}
			return;
			IL_40:
			routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.InputNumericControl.PreviewButtonFreeTextClickEvent);
			base.RaiseEvent(routedEventArgs);
			num2 = (short)1486487552;
			short num4 = num2;
			num2 = (short)2014576648;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060001B2 RID: 434 RVA: 0x000219A4 File Offset: 0x0001FBA4
		// (remove) Token: 0x060001B3 RID: 435 RVA: 0x00021A58 File Offset: 0x0001FC58
		public event global::System.Windows.RoutedEventHandler ButtonFreeTextClick
		{
			add
			{
				short num = (short)1442516929;
				short num2 = num;
				num = (short)738529217;
				switch (num2 == num)
				{
				}
				num = (short)2818048;
				if (num != 0)
				{
				}
				num = (short)949157889;
				if (num != 0)
				{
				}
				num = (short)221249536;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.InputNumericControl.ButtonFreeTextClickEvent, value);
			}
			remove
			{
				short num = (short)2021387540;
				short num2 = num;
				num = (short)740224276;
				switch (num2 == num)
				{
				}
				num = (short)1277362176;
				if (num != 0)
				{
				}
				num = (short)1306394625;
				if (num != 0)
				{
				}
				num = (short)1769603072;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.InputNumericControl.ButtonFreeTextClickEvent, value);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060001B4 RID: 436 RVA: 0x00021B0C File Offset: 0x0001FD0C
		// (remove) Token: 0x060001B5 RID: 437 RVA: 0x00021BC8 File Offset: 0x0001FDC8
		public event global::System.Windows.RoutedEventHandler PreviewButtonFreeTextClick
		{
			add
			{
				short num = (short)218198574;
				short num2 = num;
				num = (short)1176138286;
				switch (num2 == num)
				{
				}
				num = (short)1253900288;
				if (num != 0)
				{
				}
				num = (short)353566721;
				if (num != 0)
				{
				}
				num = (short)1912471552;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.InputNumericControl.PreviewButtonFreeTextClickEvent, value);
			}
			remove
			{
				short num = (short)745314949;
				short num2 = num;
				num = (short)1804114565;
				switch (num2 == num)
				{
				}
				num = (short)1629159425;
				if (num != 0)
				{
				}
				num = (short)1749090304;
				if (num != 0)
				{
				}
				num = (short)1399586816;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.InputNumericControl.PreviewButtonFreeTextClickEvent, value);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00021C7C File Offset: 0x0001FE7C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.InputNumericControl inputNumericControl;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (inputNumericControl == null)
					{
						return;
					}
					num2 = (short)842465280;
					short num3 = num2;
					num2 = (short)1498130596;
					short num4 = num2;
					num2 = (short)923510948;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F4;
					default:
						num2 = (short)1986854912;
						if (num2 != 0)
						{
						}
						num2 = (short)1067057154;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					goto IL_F4;
				}
				goto IL_1C;
				IL_F4:
				inputNumericControl.OnFreeTextEntryModeChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
				num2 = (short)1654980609;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			inputNumericControl = (A_0 as global::DevComponents.WpfEditors.InputNumericControl);
			num2 = (short)1670578177;
			if (num2 != 0)
			{
			}
			num2 = (short)1826553856;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00021DB8 File Offset: 0x0001FFB8
		protected virtual void OnFreeTextEntryModeChanged(bool oldValue, bool newValue)
		{
			short num = (short)929955842;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					this.c.IsChecked = this.FreeTextEntryMode;
					num = (short)370081793;
					if (num != 0)
					{
					}
					num = (short)581435392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 3:
					for (;;)
					{
						this.IsFreeTextBoxVisible = false;
						num = (short)1758495715;
						short num3 = num;
						num = (short)1079673827;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_F5;
						}
					}
					IL_F5:
					num = (short)524550144;
					if (num != 0)
					{
					}
					num = (short)296747013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_61;
				case 5:
				{
					num = (short)865730560;
					short num4 = num;
					goto IL_61;
				}
				case 6:
					if (this.c != null)
					{
						num = (short)1357905921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_41:
				if (!this.FreeTextEntryMode)
				{
					num = (short)2036531203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.a();
				num = (short)1373372420;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_61:
				num = (short)546439174;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00021F68 File Offset: 0x00020168
		private void a()
		{
			short num = (short)2048851968;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
				{
					num = (short)1749876737;
					if (num != 0)
					{
					}
					num = (short)442464283;
					short num3 = num;
					num = (short)1427077147;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_54;
					case 1:
						goto IL_B6;
					}
					goto Block_2;
				}
				case 2:
					if (base.IsKeyboardFocusWithin)
					{
						num = (short)512294913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_135;
				case 3:
					goto IL_54;
				}
				IL_35:
				if (this.FreeTextEntryMode)
				{
					num = (short)1892220931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_135;
				IL_54:
				num = (short)2058420226;
				num2 = (int)((global::System.IntPtr)num);
			}
			Block_2:
			num = (short)168886272;
			short num4 = num;
			IL_B6:
			num = (short)471269376;
			if (num != 0)
			{
			}
			this.IsFreeTextBoxVisible = true;
			return;
			IL_135:
			this.IsFreeTextBoxVisible = false;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x000220B4 File Offset: 0x000202B4
		// (set) Token: 0x060001BA RID: 442 RVA: 0x0002216C File Offset: 0x0002036C
		public bool FreeTextEntryMode
		{
			get
			{
				short num = (short)2088309538;
				short num2 = num;
				num = (short)395383586;
				switch (num2 == num)
				{
				}
				num = (short)886505473;
				if (num != 0)
				{
				}
				num = (short)370540544;
				if (num != 0)
				{
				}
				num = (short)54001664;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputNumericControl.FreeTextEntryModeProperty);
			}
			set
			{
				short num = (short)1788074573;
				short num2 = num;
				num = (short)2090916429;
				switch (num2 == num)
				{
				}
				num = (short)719126528;
				if (num != 0)
				{
				}
				num = (short)1325727745;
				if (num != 0)
				{
				}
				num = (short)1299251200;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.InputNumericControl.FreeTextEntryModeProperty, value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00022228 File Offset: 0x00020428
		protected override bool SupportsFreeTextEntry
		{
			get
			{
				short num = (short)200633406;
				short num2 = num;
				num = (short)796879934;
				switch (num2 == num)
				{
				}
				num = (short)2132672513;
				if (num != 0)
				{
				}
				num = (short)1168572416;
				if (num != 0)
				{
				}
				num = (short)654573568;
				short num3 = num;
				return true;
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000222D4 File Offset: 0x000204D4
		protected override global::System.Windows.Controls.TextBox GetFreeEntryTextBox()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::System.Windows.Controls.TextBox freeEntryTextBox;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (freeEntryTextBox != null)
					{
						num2 = (short)524480461;
						short num3 = num2;
						num2 = (short)209448909;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CC;
						case 1:
							break;
						default:
						{
							num2 = (short)16646144;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1314586624;
						if (num2 != 0)
						{
						}
						num2 = (short)1272446978;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return freeEntryTextBox;
				case 1:
					goto IL_101;
				case 2:
					goto IL_CC;
				}
				goto IL_1C;
				IL_CC:
				freeEntryTextBox.TextAlignment = global::System.Windows.TextAlignment.Right;
				freeEntryTextBox.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Right;
				freeEntryTextBox.BorderThickness = default(global::System.Windows.Thickness);
				num2 = (short)1676148737;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_101:
			num2 = (short)1027014657;
			if (num2 != 0)
			{
			}
			return freeEntryTextBox;
			IL_1C:
			freeEntryTextBox = base.GetFreeEntryTextBox();
			num2 = (short)69861376;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00022420 File Offset: 0x00020620
		// Note: this type is marked as 'beforefieldinit'.
		static InputNumericControl()
		{
			int a_ = 9;
			short num = (short)1822838987;
			short num2 = num;
			num = (short)496128203;
			switch (num2 == num)
			{
			}
			num = (short)1964244993;
			if (num != 0)
			{
			}
			num = (short)1262747648;
			if (num != 0)
			{
			}
			num = (short)599588864;
			short num3 = num;
			global::DevComponents.WpfEditors.InputNumericControl.NavigationKeyValueChangeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("飕맗곙뗛망臟雡跣觥蛧ꇩ觫韭ꛯ鏱飳菵鷷맹铻鿽滿攁愃", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputNumericControl), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfEditors.InputNumericControl.ShowUpDownProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("藕냗뗙ꯛ话郟ꛡ诣釥蛧", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputNumericControl), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputNumericControl.d)));
			global::DevComponents.WpfEditors.InputNumericControl.ValueChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("胕맗뛙꧛믝ꏟ諡藣裥迧迩裫", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.InputNumericControl));
			global::DevComponents.WpfEditors.InputNumericControl.ShowClearButtonProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("藕냗뗙ꯛ鷝賟蟡藣铥ꫧ鿩飫髭鿯鳱", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputNumericControl), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputNumericControl.c)));
			global::DevComponents.WpfEditors.InputNumericControl.AllowEmptyStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韕듗뛙돛꧝ꗟ迡铣鋥釧맩飫迭蓯韱", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputNumericControl), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.InputNumericControl.DisplayFormatProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鋕뇗꧙곛닝臟鯡ꋣ觥髧蟩跫髭", a_), typeof(string), typeof(global::DevComponents.WpfEditors.InputBaseControl), new global::System.Windows.UIPropertyMetadata(""));
			global::DevComponents.WpfEditors.InputNumericControl.ShowFreeTextProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("藕냗뗙ꯛ飝鋟蟡臣닥跧鋩飫", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputNumericControl), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputNumericControl.b)));
			global::DevComponents.WpfEditors.InputNumericControl.ConvertFreeTextEntryEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("闕럗듙ꫛ믝鋟雡ꋣ铥跧迩룫语裯蛱뇳飵賷裹藻", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::DevComponents.WpfEditors.FreeTextEntryConversionEventHandler), typeof(global::DevComponents.WpfEditors.InputBaseControl));
			global::DevComponents.WpfEditors.InputNumericControl.ButtonFreeTextClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("铕귗껙꣛뇝軟ꓡ難菥跧뻩觫雭蓯뇱飳鿵鯷釹", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.InputNumericControl));
			global::DevComponents.WpfEditors.InputNumericControl.PreviewButtonFreeTextClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蛕꫗뿙ꫛ럝藟闡ꛣ鏥鳧黩菫胭뛯胱釳鏵곷鿹蓻諽䏿渁洃攅指", a_), global::System.Windows.RoutingStrategy.Tunnel, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.InputNumericControl));
			global::DevComponents.WpfEditors.InputNumericControl.FreeTextEntryModeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("郕꫗뿙맛諝藟髡郣ꏥ蛧黩黫韭뷯鷱郳鏵", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputNumericControl), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputNumericControl.a)));
		}

		// Token: 0x0400007B RID: 123
		private new global::DevComponents.WpfEditors.Primitives.EditorUpDownButton a;

		// Token: 0x0400007C RID: 124
		private new global::DevComponents.WpfEditors.Primitives.EditorClearButton b;

		// Token: 0x0400007D RID: 125
		public static readonly global::System.Windows.DependencyProperty NavigationKeyValueChangeProperty;

		// Token: 0x0400007E RID: 126
		public static readonly global::System.Windows.DependencyProperty ShowUpDownProperty;

		// Token: 0x04000080 RID: 128
		public static readonly global::System.Windows.DependencyProperty ShowClearButtonProperty;

		// Token: 0x04000081 RID: 129
		public static readonly global::System.Windows.DependencyProperty AllowEmptyStateProperty;

		// Token: 0x04000082 RID: 130
		public static readonly global::System.Windows.DependencyProperty DisplayFormatProperty;

		// Token: 0x04000083 RID: 131
		public static readonly global::System.Windows.DependencyProperty ShowFreeTextProperty;

		// Token: 0x04000085 RID: 133
		private new global::DevComponents.WpfEditors.Primitives.EditorButton c;

		// Token: 0x04000088 RID: 136
		public static readonly global::System.Windows.DependencyProperty FreeTextEntryModeProperty;
	}
}
