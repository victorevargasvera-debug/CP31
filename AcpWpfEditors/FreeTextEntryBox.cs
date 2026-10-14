using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000027 RID: 39
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class FreeTextEntryBox : global::System.Windows.Controls.TextBox
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060001F0 RID: 496 RVA: 0x000269B4 File Offset: 0x00024BB4
		// (remove) Token: 0x060001F1 RID: 497 RVA: 0x00026AE8 File Offset: 0x00024CE8
		public event global::System.EventHandler RevertValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						num2 = (short)100597761;
						if (num2 != 0)
						{
						}
						if (eventHandler == eventHandler2)
						{
							num2 = (short)2140667906;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					case 1:
						goto IL_39;
					case 2:
					{
						num2 = (short)1407140921;
						short num3 = num2;
						num2 = (short)1859535929;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_39;
						default:
							goto IL_E4;
						}
						break;
					}
					}
					goto IL_1C;
					IL_39:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
					num2 = (short)433979392;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E4:
				num2 = (short)765460480;
				short num4 = num2;
				num2 = (short)1128398848;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.a;
				num2 = (short)1318649857;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.EventHandler eventHandler;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						num2 = (short)1570439169;
						if (num2 != 0)
						{
						}
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1763377154;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					case 1:
						goto IL_39;
					case 2:
					{
						num2 = (short)881767409;
						short num3 = num2;
						num2 = (short)1252963313;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_39;
						default:
							goto IL_E7;
						}
						break;
					}
					}
					goto IL_1C;
					IL_39:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
					num2 = (short)1132855296;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E7:
				num2 = (short)1401487360;
				short num4 = num2;
				num2 = (short)305332224;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.a;
				num2 = (short)687079425;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060001F2 RID: 498 RVA: 0x00026C1C File Offset: 0x00024E1C
		// (remove) Token: 0x060001F3 RID: 499 RVA: 0x00026D4C File Offset: 0x00024F4C
		public event global::System.EventHandler ApplyValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)331546626;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 1:
						goto IL_3A;
					case 2:
					{
						num2 = (short)383937018;
						short num3 = num2;
						num2 = (short)2133748218;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3A;
						default:
							goto IL_BA;
						}
						break;
					}
					}
					goto IL_1C;
					IL_3A:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.b, value2, eventHandler2);
					num2 = (short)1888026624;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_BA:
				num2 = (short)1945894912;
				if (num2 != 0)
				{
				}
				num2 = (short)1428946944;
				short num4 = num2;
				num2 = (short)1638531073;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.b;
				num2 = (short)433848321;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						if (eventHandler == eventHandler2)
						{
							num2 = (short)1471414274;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_61;
					case 1:
						num2 = (short)257294337;
						if (num2 != 0)
						{
						}
						goto IL_61;
					case 2:
					{
						num2 = (short)1824281165;
						short num3 = num2;
						num2 = (short)699290189;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_61;
						default:
							goto IL_E7;
						}
						break;
					}
					}
					goto IL_1C;
					IL_61:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.b, value2, eventHandler2);
					num2 = (short)883884032;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E7:
				num2 = (short)68288512;
				short num4 = num2;
				num2 = (short)698220544;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				eventHandler = this.b;
				num2 = (short)793509889;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00026E80 File Offset: 0x00025080
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00026F38 File Offset: 0x00025138
		public global::System.Windows.Visibility WatermarkVisibility
		{
			get
			{
				short num = (short)1205617264;
				short num2 = num;
				num = (short)983057008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)854392832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1966145537;
				if (num != 0)
				{
				}
				num = (short)1456930816;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkVisibilityProperty);
			}
			internal set
			{
				short num = (short)2103752069;
				short num2 = num;
				num = (short)838579589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1407778816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1507262465;
				if (num != 0)
				{
				}
				num = (short)667287552;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.FreeTextEntryBox.c, value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00026FF4 File Offset: 0x000251F4
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x000270AC File Offset: 0x000252AC
		public string WatermarkText
		{
			get
			{
				short num = (short)285147137;
				if (num != 0)
				{
				}
				num = (short)1329528832;
				short num2 = num;
				num = (short)322028696;
				short num3 = num;
				num = (short)1319552152;
				switch (num3 == num)
				{
				}
				num = (short)13828096;
				if (num != 0)
				{
				}
				return (string)base.GetValue(global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkTextProperty);
			}
			set
			{
				short num = (short)1544933128;
				short num2 = num;
				num = (short)1907019528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1926955008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1158283264;
				if (num != 0)
				{
				}
				num = (short)363069441;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkTextProperty, value);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00027164 File Offset: 0x00025364
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00027220 File Offset: 0x00025420
		[global::System.ComponentModel.DefaultValue(global::System.Windows.HorizontalAlignment.Left)]
		[global::System.ComponentModel.Description("Indicates watermark text alignment.")]
		[global::System.ComponentModel.Category("Watermark")]
		public global::System.Windows.HorizontalAlignment WatermarkAlignment
		{
			get
			{
				short num = (short)178697983;
				short num2 = num;
				num = (short)1496430335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1947140096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)865992705;
				if (num != 0)
				{
				}
				num = (short)66453504;
				if (num != 0)
				{
				}
				return (global::System.Windows.HorizontalAlignment)base.GetValue(global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkAlignmentProperty);
			}
			set
			{
				short num = (short)1001062401;
				if (num != 0)
				{
				}
				num = (short)1239678976;
				short num2 = num;
				num = (short)458389416;
				short num3 = num;
				num = (short)1032615848;
				switch (num3 == num)
				{
				}
				num = (short)1387069440;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkAlignmentProperty, value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001FA RID: 506 RVA: 0x000272DC File Offset: 0x000254DC
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0002739C File Offset: 0x0002559C
		[global::System.ComponentModel.Category("Watermark")]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Description("Indicates watermark text brush.")]
		public global::System.Windows.Media.Brush WatermarkBrush
		{
			get
			{
				short num = (short)323298084;
				short num2 = num;
				num = (short)910369572;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1788411904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)999620609;
				if (num != 0)
				{
				}
				num = (short)421199872;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkBrushProperty);
			}
			set
			{
				short num = (short)1651113985;
				if (num != 0)
				{
				}
				num = (short)790953984;
				short num2 = num;
				num = (short)1207755984;
				short num3 = num;
				num = (short)293594320;
				switch (num3 == num)
				{
				}
				num = (short)735510528;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkBrushProperty, value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00027454 File Offset: 0x00025654
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00027514 File Offset: 0x00025714
		[global::System.ComponentModel.Category("Watermark")]
		[global::System.ComponentModel.Description("Indicates watermark hiding behaviour.")]
		public global::DevComponents.WpfEditors.eWatermarkBehavior WatermarkBehavior
		{
			get
			{
				short num = (short)652541953;
				if (num != 0)
				{
				}
				num = (short)833421312;
				short num2 = num;
				num = (short)76796723;
				short num3 = num;
				num = (short)2005914419;
				switch (num3 == num)
				{
				}
				num = (short)749010944;
				if (num != 0)
				{
				}
				return (global::DevComponents.WpfEditors.eWatermarkBehavior)base.GetValue(global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkBehaviorProperty);
			}
			set
			{
				short num = (short)383885552;
				short num2 = num;
				num = (short)372482288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1371144192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379715584;
				if (num != 0)
				{
				}
				num = (short)287375361;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkBehaviorProperty, value);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000275D0 File Offset: 0x000257D0
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::DevComponents.WpfEditors.FreeTextEntryBox freeTextEntryBox;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					freeTextEntryBox.OnWatermarkBehaviorChanged((global::DevComponents.WpfEditors.eWatermarkBehavior)A_1.OldValue, (global::DevComponents.WpfEditors.eWatermarkBehavior)A_1.NewValue);
					num2 = (short)1030422530;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (freeTextEntryBox != null)
					{
						goto IL_3A;
					}
					goto IL_84;
				case 2:
					goto IL_84;
				}
				goto IL_1C;
				IL_3A:
				num2 = (short)837222400;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_84:
				num2 = (short)1022481604;
				short num3 = num2;
				num2 = (short)1650447556;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3A;
				default:
					goto IL_BA;
				}
			}
			IL_BA:
			num2 = (short)1784283137;
			if (num2 != 0)
			{
			}
			num2 = (short)1683423232;
			short num4 = num2;
			num2 = (short)1834156032;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			freeTextEntryBox = (A_0 as global::DevComponents.WpfEditors.FreeTextEntryBox);
			num2 = (short)511967233;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00027700 File Offset: 0x00025900
		protected virtual void OnWatermarkBehaviorChanged(global::DevComponents.WpfEditors.eWatermarkBehavior oldValue, global::DevComponents.WpfEditors.eWatermarkBehavior newValue)
		{
			short num = (short)1745839199;
			short num2 = num;
			num = (short)1033790559;
			switch (num2 == num)
			{
			default:
			{
				num = (short)782696448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)719650817;
			if (num != 0)
			{
			}
			num = (short)577699840;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000277B0 File Offset: 0x000259B0
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::System.Windows.Visibility a_;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_120;
				case 1:
					num2 = (short)974782472;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)890896385;
					if (num2 != 0)
					{
					}
					if (string.IsNullOrEmpty(base.Text))
					{
						num2 = (short)1418985483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_216;
				case 3:
					if (this.WatermarkBehavior == global::DevComponents.WpfEditors.eWatermarkBehavior.HideNonEmpty)
					{
						num2 = (short)1310982148;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_216;
				case 4:
					num2 = (short)1571225602;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (this.WatermarkBehavior == global::DevComponents.WpfEditors.eWatermarkBehavior.HideOnFocus)
					{
						num2 = (short)1598226433;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_252;
				case 6:
					a_ = global::System.Windows.Visibility.Visible;
					num2 = (short)2103050247;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_1A8;
				case 8:
					if (!base.IsFocused)
					{
						num2 = (short)188022790;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_252;
				case 9:
				{
					num2 = (short)1808558205;
					short num3 = num2;
					num2 = (short)661350525;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_120;
					default:
						num2 = (short)1925054464;
						if (num2 != 0)
						{
						}
						if (this.WatermarkEnabled)
						{
							num2 = (short)994705418;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_252;
					}
					break;
				}
				case 10:
					num2 = (short)1431044099;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					a_ = global::System.Windows.Visibility.Visible;
					num2 = (short)1513816064;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_216:
				num2 = (short)1851523077;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_120:
			num2 = (short)1788411904;
			short num4 = num2;
			IL_1A8:
			IL_252:
			this.WatermarkVisibility = a_;
			return;
			IL_40:
			a_ = global::System.Windows.Visibility.Collapsed;
			num2 = (short)2073952265;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00027A18 File Offset: 0x00025C18
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1645798678;
			short num2 = num;
			num = (short)1442833686;
			switch (num2 == num)
			{
			default:
			{
				num = (short)451149824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2092695552;
			if (num != 0)
			{
			}
			num = (short)1785593857;
			if (num != 0)
			{
			}
			this.a();
			base.OnIsKeyboardFocusWithinChanged(e);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00027AD0 File Offset: 0x00025CD0
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)538968065;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			int num2;
			global::DevComponents.WpfEditors.FreeTextEntryBox freeTextEntryBox;
			for (;;)
			{
				IL_31:
				switch (num2)
				{
				case 0:
					freeTextEntryBox.OnWatermarkEnabledChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num = (short)863698946;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (freeTextEntryBox != null)
					{
						goto IL_62;
					}
					goto IL_AD;
				case 2:
					goto IL_AD;
				}
				goto IL_43;
				IL_62:
				num = (short)631963648;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AD:
				num = (short)2033581962;
				short num3 = num;
				num = (short)1596063626;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_62;
				default:
					goto IL_E3;
				}
			}
			IL_E3:
			num = (short)1788739584;
			short num4 = num;
			num = (short)1991704576;
			if (num != 0)
			{
			}
			return;
			IL_43:
			freeTextEntryBox = (A_0 as global::DevComponents.WpfEditors.FreeTextEntryBox);
			num = (short)395051009;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00027C04 File Offset: 0x00025E04
		protected virtual void OnWatermarkEnabledChanged(bool oldValue, bool newValue)
		{
			short num = (short)1004611302;
			short num2 = num;
			num = (short)727525094;
			switch (num2 == num)
			{
			default:
			{
				num = (short)825884672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1721499648;
			if (num != 0)
			{
			}
			num = (short)802029569;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00027CB4 File Offset: 0x00025EB4
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00027D70 File Offset: 0x00025F70
		public bool WatermarkEnabled
		{
			get
			{
				short num = (short)1089208321;
				if (num != 0)
				{
				}
				num = (short)722796544;
				short num2 = num;
				num = (short)1201597006;
				short num3 = num;
				num = (short)1975183950;
				switch (num3 == num)
				{
				}
				num = (short)1784283136;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkEnabledProperty);
			}
			set
			{
				short num = (short)77135873;
				if (num != 0)
				{
				}
				num = (short)2087518208;
				short num2 = num;
				num = (short)1926755865;
				short num3 = num;
				num = (short)318240281;
				switch (num3 == num)
				{
				}
				num = (short)47972352;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkEnabledProperty, value);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00027E2C File Offset: 0x0002602C
		static FreeTextEntryBox()
		{
			int a_ = 7;
			short num = (short)1392930437;
			short num2 = num;
			num = (short)1113026181;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1686896640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1240268801;
			if (num != 0)
			{
			}
			num = (short)1324810240;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.FreeTextEntryBox.c = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菓럕곗뿙껛돝臟郡迣냥臧駩藫賭駯黱鷳苵臷", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfEditors.FreeTextEntryBox), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkVisibilityProperty = global::DevComponents.WpfEditors.FreeTextEntryBox.c.DependencyProperty;
			global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkTextProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菓럕곗뿙껛돝臟郡迣닥跧鋩飫", a_), typeof(string), typeof(global::DevComponents.WpfEditors.FreeTextEntryBox), new global::System.Windows.UIPropertyMetadata(""));
			global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkAlignmentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菓럕곗뿙껛돝臟郡迣꟥蓧菩诫胭鷯韱髳苵", a_), typeof(global::System.Windows.HorizontalAlignment), typeof(global::DevComponents.WpfEditors.FreeTextEntryBox), new global::System.Windows.UIPropertyMetadata(global::System.Windows.HorizontalAlignment.Left));
			global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkBrushProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菓럕곗뿙껛돝臟郡迣ꓥ髧鿩鿫蛭", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.FreeTextEntryBox), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Media.Brushes.DarkGray));
			global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkBehaviorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菓럕곗뿙껛돝臟郡迣ꓥ跧苩跫飭駯鷱蛳", a_), typeof(global::DevComponents.WpfEditors.eWatermarkBehavior), typeof(global::DevComponents.WpfEditors.FreeTextEntryBox), new global::System.Windows.UIPropertyMetadata(global::DevComponents.WpfEditors.eWatermarkBehavior.HideOnFocus, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.FreeTextEntryBox.b)));
			global::DevComponents.WpfEditors.FreeTextEntryBox.WatermarkEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("菓럕곗뿙껛돝臟郡迣ꏥ蛧诩軫苭闯雱", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.FreeTextEntryBox), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.FreeTextEntryBox.a)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.FreeTextEntryBox), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.FreeTextEntryBox)));
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00028084 File Offset: 0x00026284
		private void b(global::System.EventArgs A_0)
		{
			short num = (short)1187708929;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1720451073;
					if (num != 0)
					{
					}
					this.b(this, A_0);
					goto IL_D0;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					goto IL_E7;
				}
				IL_31:
				num = (short)208866648;
				short num3 = num;
				num = (short)1172507992;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D0:
					num = (short)236257282;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1697382400;
					if (num != 0)
					{
					}
					if (this.b == null)
					{
						goto IL_E9;
					}
					num = (short)541458432;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E7:
			IL_E9:
			num = (short)103743488;
			short num4 = num;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000281A4 File Offset: 0x000263A4
		private void a(global::System.EventArgs A_0)
		{
			short num = (short)1277100033;
			if (num != 0)
			{
			}
			num = (short)240123905;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.a(this, A_0);
					goto IL_CF;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 2:
					goto IL_E7;
				}
				IL_58:
				num = (short)35467289;
				short num3 = num;
				num = (short)2116300825;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_CF:
					num = (short)1969750018;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)175374336;
					if (num != 0)
					{
					}
					if (this.a == null)
					{
						goto IL_E9;
					}
					num = (short)1353777152;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_E7:
			IL_E9:
			num = (short)18546688;
			short num4 = num;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000282C4 File Offset: 0x000264C4
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)869269508;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_119;
				case 1:
					this.b(e);
					num = (short)482213891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (e.Key == global::System.Windows.Input.Key.Escape)
					{
						num = (short)1377632261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17B;
				case 3:
					goto IL_179;
				case 4:
				{
					num = (short)1721693617;
					short num3 = num;
					num = (short)16381361;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_179;
					default:
						num = (short)911802369;
						if (num != 0)
						{
						}
						num = (short)334168064;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AF;
						}
						continue;
					}
					break;
				}
				case 5:
				{
					this.a(e);
					num = (short)1919614976;
					short num4 = num;
					num = (short)1360330752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_AF:
				if (e.Key == global::System.Windows.Input.Key.Return)
				{
					num = (short)731447297;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1926168578;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_119:
			IL_179:
			IL_17B:
			base.OnKeyDown(e);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00028454 File Offset: 0x00026654
		protected override void OnTextChanged(global::System.Windows.Controls.TextChangedEventArgs e)
		{
			for (;;)
			{
				IL_00:
				short num = (short)2021523458;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_110;
					case 1:
					{
						num = (short)36831233;
						if (num != 0)
						{
						}
						num = (short)1561198592;
						short num3 = num;
						num = (short)1566561957;
						short num4 = num;
						num = (short)997643941;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)30867456;
							if (num != 0)
							{
							}
							this.b(global::System.EventArgs.Empty);
							num = (short)380698624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (!base.IsFocused)
					{
						goto IL_112;
					}
					num = (short)798818305;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_110:
			IL_112:
			this.a();
			base.OnTextChanged(e);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00028580 File Offset: 0x00026780
		protected override void OnLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)365490510;
			short num2 = num;
			num = (short)908063054;
			switch (num2 == num)
			{
			}
			num = (short)340000768;
			short num3 = num;
			num = (short)96731136;
			if (num != 0)
			{
			}
			num = (short)1456603137;
			if (num != 0)
			{
			}
			this.b(e);
			base.OnLostFocus(e);
		}

		// Token: 0x0400013E RID: 318
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler a;

		// Token: 0x0400013F RID: 319
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler b;

		// Token: 0x04000140 RID: 320
		private static readonly global::System.Windows.DependencyPropertyKey c;

		// Token: 0x04000141 RID: 321
		public static readonly global::System.Windows.DependencyProperty WatermarkVisibilityProperty;

		// Token: 0x04000142 RID: 322
		public static readonly global::System.Windows.DependencyProperty WatermarkTextProperty;

		// Token: 0x04000143 RID: 323
		public static readonly global::System.Windows.DependencyProperty WatermarkAlignmentProperty;

		// Token: 0x04000144 RID: 324
		public static readonly global::System.Windows.DependencyProperty WatermarkBrushProperty;

		// Token: 0x04000145 RID: 325
		public static readonly global::System.Windows.DependencyProperty WatermarkBehaviorProperty;

		// Token: 0x04000146 RID: 326
		public static readonly global::System.Windows.DependencyProperty WatermarkEnabledProperty;
	}
}
