using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000060 RID: 96
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class EditorNumericInput : global::DevComponents.WpfEditors.Primitives.EditorInputBase
	{
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00082BB8 File Offset: 0x00080DB8
		// (set) Token: 0x06000631 RID: 1585 RVA: 0x00082C74 File Offset: 0x00080E74
		public bool NavigationKeyValueChange
		{
			get
			{
				short num = (short)2007792345;
				short num2 = num;
				num = (short)107379417;
				switch (num2 == num)
				{
				}
				num = (short)191496192;
				short num3 = num;
				num = (short)184877057;
				if (num != 0)
				{
				}
				num = (short)1786773504;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.NavigationKeyValueChangeProperty);
			}
			set
			{
				short num = (short)35476929;
				short num2 = num;
				num = (short)1657296321;
				switch (num2 == num)
				{
				}
				num = (short)1576861696;
				short num3 = num;
				num = (short)343277569;
				if (num != 0)
				{
				}
				num = (short)116719616;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.NavigationKeyValueChangeProperty, value);
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000632 RID: 1586 RVA: 0x00082D30 File Offset: 0x00080F30
		// (remove) Token: 0x06000633 RID: 1587 RVA: 0x00082DE8 File Offset: 0x00080FE8
		public event global::System.Windows.RoutedEventHandler ValueChanged
		{
			add
			{
				short num = (short)2024853122;
				short num2 = num;
				num = (short)295161474;
				switch (num2 == num)
				{
				}
				num = (short)249364480;
				short num3 = num;
				num = (short)1214578688;
				if (num != 0)
				{
				}
				num = (short)104726529;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.ValueChangedEvent, value);
			}
			remove
			{
				short num = (short)845608227;
				short num2 = num;
				num = (short)1021965603;
				switch (num2 == num)
				{
				}
				num = (short)205062144;
				short num3 = num;
				num = (short)210436097;
				if (num != 0)
				{
				}
				num = (short)1845493760;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.ValueChangedEvent, value);
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000634 RID: 1588 RVA: 0x00082E9C File Offset: 0x0008109C
		// (remove) Token: 0x06000635 RID: 1589 RVA: 0x00082F50 File Offset: 0x00081150
		public event global::System.Windows.RoutedEventHandler PreviewValueChanged
		{
			add
			{
				short num = (short)1015620718;
				short num2 = num;
				num = (short)1890722926;
				switch (num2 == num)
				{
				}
				num = (short)605945856;
				short num3 = num;
				num = (short)2024079361;
				if (num != 0)
				{
				}
				num = (short)1986789376;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.PreviewValueChangedEvent, value);
			}
			remove
			{
				short num = (short)750455445;
				short num2 = num;
				num = (short)73009813;
				switch (num2 == num)
				{
				}
				num = (short)191496192;
				short num3 = num;
				num = (short)1912537089;
				if (num != 0)
				{
				}
				num = (short)1730412544;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.PreviewValueChangedEvent, value);
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00083004 File Offset: 0x00081204
		protected virtual void OnValueChanged()
		{
			global::System.Windows.RoutedEventArgs routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.PreviewValueChangedEvent);
			base.RaiseEvent(routedEventArgs);
			if (!routedEventArgs.Handled)
			{
				short num = (short)262535780;
				short num2 = num;
				num = (short)1867840100;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2015559680;
					short num3 = num;
					num = (short)2060648448;
					if (num != 0)
					{
					}
					num = (short)633798657;
					if (num != 0)
					{
					}
					global::System.Windows.RoutedEventArgs e = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.ValueChangedEvent);
					base.RaiseEvent(e);
					return;
				}
				}
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x000830DC File Offset: 0x000812DC
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00083198 File Offset: 0x00081398
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AllowsNegativeValue
		{
			get
			{
				short num = (short)1330996841;
				short num2 = num;
				num = (short)202466921;
				switch (num2 == num)
				{
				}
				num = (short)999555072;
				short num3 = num;
				num = (short)1679360000;
				if (num != 0)
				{
				}
				num = (short)1097334785;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.AllowsNegativeValueProperty);
			}
			set
			{
				short num = (short)450232321;
				if (num != 0)
				{
				}
				num = (short)1534277346;
				short num2 = num;
				num = (short)548681442;
				switch (num2 == num)
				{
				default:
				{
					num = (short)975896576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)564396032;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.AllowsNegativeValueProperty, value);
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00083250 File Offset: 0x00081450
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1367145154;
			short num2 = num;
			num = (short)1872886466;
			switch (num2 == num)
			{
			}
			num = (short)1281359872;
			short num3 = num;
			num = (short)1670381569;
			if (num != 0)
			{
			}
			num = (short)1229520896;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.Primitives.EditorNumericInput)A_0).OnAllowEmptyStateChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0008331C File Offset: 0x0008151C
		protected virtual void OnAllowEmptyStateChanged(bool oldValue, bool newValue)
		{
			short num = (short)2126164013;
			short num2 = num;
			num = (short)1537716269;
			switch (num2 == num)
			{
			}
			num = (short)2093088768;
			short num3 = num;
			num = (short)201785345;
			if (num != 0)
			{
			}
			num = (short)2046623744;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x000833C8 File Offset: 0x000815C8
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x00083480 File Offset: 0x00081680
		[global::System.ComponentModel.Category("Behavior")]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AllowEmptyState
		{
			get
			{
				short num = (short)1090125825;
				if (num != 0)
				{
				}
				num = (short)1697911009;
				short num2 = num;
				num = (short)311693537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)299040768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)499056640;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.AllowEmptyStateProperty);
			}
			set
			{
				short num = (short)68857632;
				short num2 = num;
				num = (short)1893707552;
				switch (num2 == num)
				{
				}
				num = (short)245956608;
				short num3 = num;
				num = (short)1226375169;
				if (num != 0)
				{
				}
				num = (short)532283392;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.AllowEmptyStateProperty, value);
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0008353C File Offset: 0x0008173C
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)542179343;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.AllowsNegativeValue)
					{
						num = (short)1981743118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F0;
				case 1:
					e.Handled = this.NegateValue();
					num = (short)2007629832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.DecreaseValue();
					e.Handled = true;
					num = (short)68812806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1848180747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (this.NavigationKeyValueChange)
					{
						num = (short)721485837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F1;
				case 5:
					goto IL_EB;
				case 6:
					goto IL_255;
				case 7:
					this.IncreaseValue();
					e.Handled = true;
					num = (short)36175877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_27D;
				case 9:
					num = (short)428670994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)193593344;
					short num3 = num;
					if (e.Key == global::System.Windows.Input.Key.Up)
					{
						num = (short)26017799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F1;
				}
				case 11:
					if (e.Key == global::System.Windows.Input.Key.Down)
					{
						num = (short)1306132482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B0;
				case 12:
					num = (short)1452146708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)1798176778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
				{
					num = (short)511967078;
					short num4 = num;
					num = (short)1935605606;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EB;
					default:
						num = (short)398196736;
						if (num != 0)
						{
						}
						num = (short)1658912787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 15:
					switch (0)
					{
					case 0:
						goto IL_78;
					}
					continue;
				case 16:
					if (this.NavigationKeyValueChange)
					{
						num = (short)132644867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B0;
				case 17:
					goto IL_282;
				case 18:
					if (e.Key != global::System.Windows.Input.Key.Subtract)
					{
						num = (short)1797193740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_282;
				case 19:
					if (!this.IsEmpty)
					{
						num = (short)795869185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B0;
				case 20:
					if (e.Key == global::System.Windows.Input.Key.OemMinus)
					{
						num = (short)1029963793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F0;
				}
				IL_78:
				num = (short)964362241;
				if (num != 0)
				{
				}
				if (!base.IsReadOnly)
				{
					num = (short)659488777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F0:
				num = (short)1102577668;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F1:
				num = (short)1678508048;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_282:
				num = (short)1898250240;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EB:
			IL_255:
			IL_27D:
			IL_3B0:
			base.OnKeyDown(e);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00083900 File Offset: 0x00081B00
		protected override void OnMouseWheel(global::System.Windows.Input.MouseWheelEventArgs e)
		{
			short num = (short)1868562433;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)30146561;
					if (num != 0)
					{
					}
					if (e.Delta > 0)
					{
						num = (short)1308491776;
						short num3 = num;
						num = (short)391512069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.DecreaseValue();
					num = (short)615317436;
					short num4 = num;
					num = (short)760086460;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)1937375232;
						if (num != 0)
						{
						}
						num = (short)1368981508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_15;
				case 2:
					goto IL_187;
				case 3:
					goto IL_1A6;
				case 4:
					goto IL_187;
				case 5:
					this.IncreaseValue();
					num = (short)754319362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)331808768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_41;
				IL_15:
				switch (0)
				{
				case 0:
					IL_41:
					if (base.IsReadOnly)
					{
						goto IL_1A8;
					}
					num = (short)638648326;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_187:
				e.Handled = true;
				num = (short)1908146179;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1A6:
			IL_1A8:
			base.OnMouseWheel(e);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00083ABC File Offset: 0x00081CBC
		public virtual void DecreaseValue()
		{
			short num = (short)859313160;
			short num2 = num;
			num = (short)872944648;
			switch (num2 == num)
			{
			}
			num = (short)1156972544;
			short num3 = num;
			num = (short)238223360;
			if (num != 0)
			{
			}
			num = (short)292093953;
			if (num != 0)
			{
			}
			this.TextInputComplete(true);
			this.ResetUndoStack();
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00083B74 File Offset: 0x00081D74
		public virtual void IncreaseValue()
		{
			short num = (short)1203514884;
			short num2 = num;
			num = (short)299380228;
			switch (num2 == num)
			{
			}
			num = (short)1253179392;
			short num3 = num;
			num = (short)1530265601;
			if (num != 0)
			{
			}
			num = (short)1452408832;
			if (num != 0)
			{
			}
			this.TextInputComplete(true);
			base.ResetInputStack();
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00083C2C File Offset: 0x00081E2C
		protected virtual bool NegateValue()
		{
			short num = (short)886636545;
			if (num != 0)
			{
			}
			num = (short)1132414039;
			short num2 = num;
			num = (short)2122990679;
			switch (num2 == num)
			{
			default:
			{
				num = (short)150798336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)484966400;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00083CD4 File Offset: 0x00081ED4
		protected override bool AcceptKeyPress(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (this.AllowsNegativeValue)
					{
						num2 = (short)1171783682;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_251;
				case 1:
				{
					num2 = (short)1257832448;
					short num3 = num2;
					num2 = (short)931463179;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					num2 = (short)2016215043;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (text == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_))
					{
						num2 = (short)271777799;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_251;
				case 4:
					num2 = (short)1946746880;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (!this.IsEmpty)
					{
						num2 = (short)465633289;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_193;
				case 6:
					goto IL_64;
				case 7:
					num2 = (short)1806434309;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					num2 = (short)2131174801;
					short num4 = num2;
					num2 = (short)1342121361;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
						goto IL_103;
					}
					break;
				}
				case 9:
					num2 = (short)1640562698;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (!this.IsEmpty)
					{
						num2 = (short)996671489;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_251;
				case 11:
					if (base.InputStack == "")
					{
						num2 = (short)1334640648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_251;
				}
				goto IL_49;
				IL_64:
				if (this.IsNumeric(text))
				{
					goto IL_193;
				}
				num2 = (short)813957124;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_103:
			num2 = (short)1277493248;
			if (num2 != 0)
			{
			}
			IL_193:
			e.Handled = true;
			return true;
			IL_251:
			num2 = (short)1135345665;
			if (num2 != 0)
			{
			}
			return false;
			IL_49:
			text = e.Text;
			num2 = (short)713424902;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00083F5C File Offset: 0x0008215C
		protected virtual bool IsNumeric(string t)
		{
			short num = (short)510688411;
			short num2 = num;
			num = (short)470252699;
			switch (num2 == num)
			{
			}
			num = (short)280690688;
			short num3 = num;
			num = (short)248053761;
			if (num != 0)
			{
			}
			num = (short)716570624;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0008400C File Offset: 0x0008220C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			short num = (short)670081396;
			short num2 = num;
			num = (short)1096393076;
			switch (num2 == num)
			{
			}
			num = (short)296550400;
			short num3 = num;
			num = (short)1185087489;
			if (num != 0)
			{
			}
			num = (short)1929576448;
			if (num != 0)
			{
			}
			global::System.Windows.Media.FormattedText formattedText = new global::System.Windows.Media.FormattedText(this.GetMeasureString(), global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture(), global::System.Windows.FlowDirection.LeftToRight, new global::System.Windows.Media.Typeface(base.FontFamily, base.FontStyle, base.FontWeight, base.FontStretch), base.FontSize, base.Foreground);
			availableSize.Width = global::System.Math.Ceiling(formattedText.Width);
			availableSize.Height = global::System.Math.Ceiling(formattedText.Height);
			return availableSize;
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00084118 File Offset: 0x00082318
		protected virtual string GetMeasureString()
		{
			short num = (short)255625079;
			short num2 = num;
			num = (short)511149943;
			switch (num2 == num)
			{
			}
			num = (short)1497759744;
			short num3 = num;
			num = (short)890437633;
			if (num != 0)
			{
			}
			num = (short)1788739584;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x000841C8 File Offset: 0x000823C8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			short num = (short)549210070;
			short num2 = num;
			num = (short)46811094;
			switch (num2 == num)
			{
			}
			num = (short)1072627712;
			short num3 = num;
			num = (short)1239678977;
			if (num != 0)
			{
			}
			num = (short)967114752;
			if (num != 0)
			{
			}
			return base.DesiredSize;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00084278 File Offset: 0x00082478
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			short num = (short)835846144;
			switch (num)
			{
			default:
			{
				num = (short)1863188489;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Media.Brush brush;
					global::System.Windows.Media.FormattedText formattedText;
					global::System.Windows.Media.Brush brush2;
					switch (num2)
					{
					case 0:
						if (brush != null)
						{
							num = (short)140050439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C2;
					case 1:
						goto IL_363;
					case 2:
						goto IL_30D;
					case 3:
					{
						global::System.Windows.Media.MatrixTransform matrixTransform;
						if (matrixTransform != null)
						{
							num = (short)75825160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_363;
					}
					case 4:
					{
						global::System.Windows.Media.MatrixTransform matrixTransform;
						if (matrixTransform != null)
						{
							num = (short)1670905869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D9;
					}
					case 5:
						goto IL_3D7;
					case 6:
					{
						num = (short)56530134;
						short num3 = num;
						num = (short)1630770390;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_135;
						default:
						{
							num = (short)1459159040;
							if (num != 0)
							{
							}
							num = (short)389349377;
							if (num != 0)
							{
							}
							global::System.Windows.Media.MatrixTransform matrixTransform = null;
							num = (short)39256076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 7:
						drawingContext.DrawRectangle(brush, null, new global::System.Windows.Rect(base.RenderSize));
						num = (short)571605006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::System.Windows.Media.MatrixTransform matrixTransform;
						drawingContext.PushTransform(matrixTransform);
						num = (short)1634533377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						continue;
					case 10:
					{
						double m = -1.0;
						double m2 = 1.0;
						double width = formattedText.Width;
						double offsetY = 0.0;
						global::System.Windows.Media.MatrixTransform matrixTransform = new global::System.Windows.Media.MatrixTransform(m, 0.0, 0.0, m2, width, offsetY);
						num = (short)506986498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (brush2 != null)
						{
							num = (short)881131526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D9;
					case 12:
						if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							num = (short)944242698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30D;
					case 13:
						drawingContext.Pop();
						num = (short)1158283269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_1C2;
					}
					goto IL_7F;
					IL_135:
					num = (short)782434304;
					short num4 = num;
					num = (short)35848192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F:
					string renderString = this.GetRenderString();
					brush2 = base.Foreground;
					brush = ((base.Background == null) ? global::System.Windows.Media.Brushes.Transparent : base.Background);
					if (!base.IsEnabled)
					{
						brush2 = base.ForegroundDisabled;
					}
					if (base.IsKeyboardFocused && base.IsEnabled)
					{
						brush = ((base.FocusedBackground != null) ? base.FocusedBackground : this.DefaultHighlightBrush);
						brush2 = ((base.FocusedForeground != null) ? base.FocusedForeground : this.DefaultHighlightTextBrush);
					}
					formattedText = new global::System.Windows.Media.FormattedText(renderString, global::DevComponents.WpfEditors.EditorsSettings.GetActiveCulture(), global::System.Windows.FlowDirection.LeftToRight, new global::System.Windows.Media.Typeface(base.FontFamily, base.FontStyle, base.FontWeight, base.FontStretch), base.FontSize, brush2);
					goto IL_135;
					IL_1C2:
					num = (short)94437387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30D:
					num = (short)551747587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_363:
					drawingContext.DrawText(formattedText, new global::System.Windows.Point(0.0, 0.0));
					num = (short)1818755076;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3D7:
				IL_3D9:
				base.OnRender(drawingContext);
				return;
			}
			}
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00084668 File Offset: 0x00082868
		protected virtual string GetRenderString()
		{
			short num = (short)2109870040;
			short num2 = num;
			num = (short)1819545560;
			switch (num2 == num)
			{
			}
			num = (short)1925906432;
			short num3 = num;
			num = (short)1357774848;
			if (num != 0)
			{
			}
			num = (short)1094057985;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00084718 File Offset: 0x00082918
		protected override bool SetInputStack(string s)
		{
			int a_ = 3;
			short num = (short)1137836033;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					s = s.Substring(1);
					base.SetInputPosition(base.InputPosition - 1);
					num = (short)2137128964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 2:
					goto IL_F7;
				case 3:
				{
					num = (short)1553465344;
					short num3 = num;
					num = (short)1591148546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_B1;
				case 5:
				{
					if (!(s != global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_)))
					{
						goto IL_1EC;
					}
					num = (short)1783556386;
					short num4 = num;
					num = (short)347728162;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F7;
					default:
						num = (short)655032321;
						if (num != 0)
						{
						}
						num = (short)1204289536;
						if (num != 0)
						{
						}
						num = (short)1608581123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					num = (short)236912645;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_49:
				if (base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_))
				{
					num = (short)2057568262;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F7:
				if (!s.StartsWith(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_)))
				{
					break;
				}
				num = (short)15466496;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B1:
			IL_1EC:
			return base.SetInputStack(s);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00084918 File Offset: 0x00082B18
		protected override void OnInputLostFocus()
		{
			int a_ = 16;
			short num = (short)1553530882;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_126;
				case 1:
				{
					num = (short)1937113088;
					short num3 = num;
					num = (short)1627455996;
					short num4 = num;
					num = (short)2096103932;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)4390912;
						if (num != 0)
						{
						}
						num = (short)1841299457;
						if (num != 0)
						{
						}
						this.OnClear();
						num = (short)1936523264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_1D;
				}
				goto IL_39;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_39:
					if (!(base.InputStack == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("", a_)))
					{
						goto IL_128;
					}
					num = (short)546177025;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_126:
			IL_128:
			base.OnInputLostFocus();
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00084A68 File Offset: 0x00082C68
		// Note: this type is marked as 'beforefieldinit'.
		static EditorNumericInput()
		{
			int a_ = 12;
			short num = (short)1401044265;
			short num2 = num;
			num = (short)186727721;
			switch (num2 == num)
			{
			}
			num = (short)187826176;
			short num3 = num;
			num = (short)1611005953;
			if (num != 0)
			{
			}
			num = (short)768278528;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.Primitives.EditorNumericInput.NavigationKeyValueChangeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韘뫚ꯜ뛞蛠苢釤軦蛨藪ꛬ諮裰ꗲ铴鯶賸黺뻼韾怀洂戄戆", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.EditorNumericInput), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfEditors.Primitives.EditorNumericInput.ValueChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("还뫚뇜꫞蓠ꃢ跤蛦蟨質裬诮", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.Primitives.EditorNumericInput));
			global::DevComponents.WpfEditors.Primitives.EditorNumericInput.PreviewValueChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("觘꧚룜꧞裠蛢鋤뇦裨蟪飬諮닰鯲铴駶黸黺駼", a_), global::System.Windows.RoutingStrategy.Tunnel, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.Primitives.EditorNumericInput));
			global::DevComponents.WpfEditors.Primitives.EditorNumericInput.AllowsNegativeValueProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("飘럚뇜냞雠郢ꯤ苦軨諪駬蛮蟰雲ꏴ零闸軺飼", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.EditorNumericInput), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfEditors.Primitives.EditorNumericInput.AllowEmptyStateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("飘럚뇜냞雠ꛢ裤韦鷨鋪뻬鯮郰蟲郴", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.EditorNumericInput), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.Primitives.EditorNumericInput.a)));
		}

		// Token: 0x040002B5 RID: 693
		public static readonly global::System.Windows.DependencyProperty NavigationKeyValueChangeProperty;

		// Token: 0x040002B8 RID: 696
		public static readonly global::System.Windows.DependencyProperty AllowsNegativeValueProperty;

		// Token: 0x040002B9 RID: 697
		public static readonly global::System.Windows.DependencyProperty AllowEmptyStateProperty;
	}
}
