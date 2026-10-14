using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls.Primitives;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000025 RID: 37
	[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
	public class InputButtonSettings : global::System.Windows.DependencyObject
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x000251DC File Offset: 0x000233DC
		private static void d(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1909098636;
			short num2 = num;
			num = (short)1390250124;
			global::DevComponents.WpfEditors.InputButtonSettings inputButtonSettings;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D3:
				if (inputButtonSettings == null)
				{
					return;
				}
				num = (short)1801846785;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1944846336;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_65;
				}
				break;
			}
			for (;;)
			{
				IL_53:
				switch (num3)
				{
				case 0:
					goto IL_125;
				case 1:
					inputButtonSettings.OnVisibleChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num = (short)933560320;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_D3;
				}
				goto IL_65;
			}
			IL_125:
			return;
			IL_65:
			num = (short)988348416;
			short num4 = num;
			inputButtonSettings = (A_0 as global::DevComponents.WpfEditors.InputButtonSettings);
			num = (short)335872001;
			if (num != 0)
			{
			}
			num = (short)1177092098;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_53;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00025310 File Offset: 0x00023510
		protected virtual void OnVisibleChanged(bool oldValue, bool newValue)
		{
			short num = (short)1523451501;
			short num2 = num;
			num = (short)862062189;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B4:
				num = (short)1524432896;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1098776576;
				if (num != 0)
				{
				}
				num = (short)860946435;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				num = (short)1379074048;
				short num4 = num;
				switch (num3)
				{
				case 0:
					num = (short)1243807746;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_10C;
				case 2:
					this.b.Visibility = (newValue ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
					num = (short)157089793;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				}
				break;
			}
			IL_A9:
			if (this.b != null)
			{
				goto IL_B4;
			}
			return;
			IL_10C:
			num = (short)646447105;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00025454 File Offset: 0x00023654
		// (set) Token: 0x060001DB RID: 475 RVA: 0x00025510 File Offset: 0x00023710
		public bool Visible
		{
			get
			{
				short num = (short)1416049031;
				short num2 = num;
				num = (short)74264967;
				switch (num2 == num)
				{
				}
				num = (short)802226176;
				short num3 = num;
				num = (short)855441409;
				if (num != 0)
				{
				}
				num = (short)634978304;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputButtonSettings.VisibleProperty);
			}
			set
			{
				short num = (short)44564481;
				if (num != 0)
				{
				}
				num = (short)85709456;
				short num2 = num;
				num = (short)1798099600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2144731136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)158007296;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputButtonSettings.VisibleProperty, value);
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000255C8 File Offset: 0x000237C8
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1408908723;
			short num2 = num;
			num = (short)2102934963;
			global::DevComponents.WpfEditors.InputButtonSettings inputButtonSettings;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D3:
				if (inputButtonSettings == null)
				{
					return;
				}
				num = (short)863961089;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1689321472;
				if (num != 0)
				{
				}
				num = (short)1674182657;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B8;
				}
				break;
			}
			for (;;)
			{
				IL_7C:
				num = (short)194117632;
				short num4 = num;
				switch (num3)
				{
				case 0:
					goto IL_121;
				case 1:
					inputButtonSettings.OnDisplayPositionChanged((int)A_1.OldValue, (int)A_1.NewValue);
					num = (short)1669070848;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_D3;
				}
				goto IL_B8;
			}
			IL_121:
			return;
			IL_B8:
			inputButtonSettings = (A_0 as global::DevComponents.WpfEditors.InputButtonSettings);
			num = (short)2003369986;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7C;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000256F8 File Offset: 0x000238F8
		protected virtual void OnDisplayPositionChanged(int oldValue, int newValue)
		{
			for (;;)
			{
				IL_00:
				short num = (short)387776514;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)398180933;
						short num3 = num;
						num = (short)677626437;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						case 1:
							break;
						default:
						{
							num = (short)845873152;
							short num4 = num;
							break;
						}
						}
						num = (short)1244004352;
						if (num != 0)
						{
						}
						num = (short)1651310593;
						if (num != 0)
						{
						}
						this.a.a(this);
						num = (short)2074607616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (this.a == null)
					{
						return;
					}
					num = (short)2038169601;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00025818 File Offset: 0x00023A18
		// (set) Token: 0x060001DF RID: 479 RVA: 0x000258D0 File Offset: 0x00023AD0
		public int DisplayPosition
		{
			get
			{
				short num = (short)778713908;
				short num2 = num;
				num = (short)417020724;
				switch (num2 == num)
				{
				}
				num = (short)1179123712;
				short num3 = num;
				num = (short)1957494785;
				if (num != 0)
				{
				}
				num = (short)403963904;
				if (num != 0)
				{
				}
				return (int)base.GetValue(global::DevComponents.WpfEditors.InputButtonSettings.DisplayPositionProperty);
			}
			set
			{
				short num = (short)1476376475;
				short num2 = num;
				num = (short)123647899;
				switch (num2 == num)
				{
				}
				num = (short)309919744;
				short num3 = num;
				num = (short)1525940225;
				if (num != 0)
				{
				}
				num = (short)1262944256;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputButtonSettings.DisplayPositionProperty, value);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0002598C File Offset: 0x00023B8C
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1633744679;
			short num2 = num;
			num = (short)911275815;
			global::DevComponents.WpfEditors.InputButtonSettings inputButtonSettings;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AD:
				if (inputButtonSettings == null)
				{
					return;
				}
				num = (short)1650196481;
				if (num != 0)
				{
				}
				num = (short)1372782593;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)851247104;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				break;
			}
			for (;;)
			{
				IL_54:
				switch (num3)
				{
				case 0:
					goto IL_127;
				case 1:
					inputButtonSettings.OnIsEnabledChanged((bool)A_1.OldValue, (bool)A_1.NewValue);
					num = (short)1558183936;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_AD;
				}
				goto IL_66;
			}
			IL_127:
			return;
			IL_66:
			num = (short)177537024;
			short num4 = num;
			inputButtonSettings = (A_0 as global::DevComponents.WpfEditors.InputButtonSettings);
			num = (short)553123842;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00025AC4 File Offset: 0x00023CC4
		protected virtual void OnIsEnabledChanged(bool oldValue, bool newValue)
		{
			for (;;)
			{
				IL_00:
				short num = (short)995033090;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1745341145;
						short num3 = num;
						num = (short)1984088793;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						case 1:
							break;
						default:
						{
							num = (short)2021523456;
							short num4 = num;
							break;
						}
						}
						num = (short)710672385;
						if (num != 0)
						{
						}
						num = (short)2022834176;
						if (num != 0)
						{
						}
						this.b.IsEnabled = newValue;
						num = (short)1966931968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
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
					if (this.b == null)
					{
						return;
					}
					num = (short)1413087233;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00025BE4 File Offset: 0x00023DE4
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00025CA0 File Offset: 0x00023EA0
		public bool IsEnabled
		{
			get
			{
				short num = (short)1905447074;
				short num2 = num;
				num = (short)1838272674;
				switch (num2 == num)
				{
				}
				num = (short)1111293952;
				short num3 = num;
				num = (short)1678245889;
				if (num != 0)
				{
				}
				num = (short)1195114496;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.InputButtonSettings.IsEnabledProperty);
			}
			set
			{
				short num = (short)475354876;
				short num2 = num;
				num = (short)251811580;
				switch (num2 == num)
				{
				}
				num = (short)1834549248;
				short num3 = num;
				num = (short)1664024577;
				if (num != 0)
				{
				}
				num = (short)668532736;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputButtonSettings.IsEnabledProperty, value);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00025D5C File Offset: 0x00023F5C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)484697708;
			short num2 = num;
			num = (short)81127020;
			global::DevComponents.WpfEditors.InputButtonSettings inputButtonSettings;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D3:
				if (inputButtonSettings == null)
				{
					return;
				}
				num = (short)1646592001;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1054408704;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				break;
			}
			for (;;)
			{
				IL_56:
				switch (num3)
				{
				case 0:
					goto IL_11E;
				case 1:
					inputButtonSettings.OnContentChanged(A_1.OldValue, A_1.NewValue);
					num = (short)766705664;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_D3;
				}
				goto IL_68;
			}
			IL_11E:
			return;
			IL_68:
			num = (short)1159004160;
			short num4 = num;
			inputButtonSettings = (A_0 as global::DevComponents.WpfEditors.InputButtonSettings);
			num = (short)1054474241;
			if (num != 0)
			{
			}
			num = (short)648478722;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_56;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00025E8C File Offset: 0x0002408C
		protected virtual void OnContentChanged(object oldValue, object newValue)
		{
			short num = (short)1956577284;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_FA;
				case 1:
					num = (short)1404174339;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					for (;;)
					{
						num = (short)901849288;
						short num3 = num;
						num = (short)579805384;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_BC;
						}
					}
					IL_BC:
					num = (short)606470144;
					if (num != 0)
					{
					}
					((global::System.Windows.Controls.Primitives.ButtonBase)this.b).Content = newValue;
					num = (short)558825472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.b is global::System.Windows.Controls.Primitives.ButtonBase)
					{
						num = (short)1977810946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (this.b == null)
				{
					return;
				}
				num = (short)723124225;
				if (num != 0)
				{
				}
				num = (short)2076573697;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FA:
			num = (short)385613824;
			short num4 = num;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00026000 File Offset: 0x00024200
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x000260B4 File Offset: 0x000242B4
		public object Content
		{
			get
			{
				short num = (short)1106779344;
				short num2 = num;
				num = (short)72752336;
				switch (num2 == num)
				{
				}
				num = (short)1389035520;
				short num3 = num;
				num = (short)506855424;
				if (num != 0)
				{
				}
				num = (short)942931969;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.InputButtonSettings.ContentProperty);
			}
			set
			{
				short num = (short)1481127406;
				short num2 = num;
				num = (short)314717678;
				switch (num2 == num)
				{
				}
				num = (short)887554048;
				short num3 = num;
				num = (short)258998273;
				if (num != 0)
				{
				}
				num = (short)2131034112;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.InputButtonSettings.ContentProperty, value);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00026168 File Offset: 0x00024368
		public InputButtonSettings(global::DevComponents.WpfEditors.InputBaseControl parent)
		{
			this.a = parent;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00026184 File Offset: 0x00024384
		public InputButtonSettings()
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00026198 File Offset: 0x00024398
		// (set) Token: 0x060001EB RID: 491 RVA: 0x0002624C File Offset: 0x0002444C
		internal global::System.Windows.UIElement ButtonReference
		{
			get
			{
				short num = (short)2078318943;
				short num2 = num;
				num = (short)1682612575;
				switch (num2 == num)
				{
				}
				num = (short)1506148352;
				short num3 = num;
				num = (short)1047330816;
				if (num != 0)
				{
				}
				num = (short)1010958337;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1993146368;
				short num2 = num;
				num = (short)1506719983;
				short num3 = num;
				num = (short)1375910127;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_88:
					switch (0)
					{
					case 0:
						goto IL_C4;
					}
					break;
				default:
					num = (short)1507262464;
					if (num != 0)
					{
					}
					num = (short)1513029632;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					IL_92:
					switch (num4)
					{
					case 0:
						goto IL_88;
					case 1:
						goto IL_E9;
					case 2:
						if (this.b is global::System.Windows.Controls.Primitives.ButtonBase)
						{
							num = (short)619839492;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E9;
					case 3:
						this.b.IsEnabled = this.IsEnabled;
						num = (short)1482948615;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)609026049;
						if (num != 0)
						{
						}
						((global::System.Windows.Controls.Primitives.ButtonBase)this.b).Content = null;
						((global::System.Windows.Controls.Primitives.ButtonBase)this.b).Click -= this.a;
						num = (short)880869377;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						((global::System.Windows.Controls.Primitives.ButtonBase)this.b).Content = this.Content;
						((global::System.Windows.Controls.Primitives.ButtonBase)this.b).Click += this.a;
						num = (short)693305350;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_2AD;
					case 7:
						this.b.Visibility = (this.Visible ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
						num = (short)1955004425;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (this.b != null)
						{
							num = (short)888799235;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						if (this.b is global::System.Windows.Controls.Primitives.ButtonBase)
						{
							num = (short)1311834117;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						num = (short)322895874;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C4;
					IL_E9:
					this.b = value;
					num = (short)1356529672;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_2AD:
				return;
				IL_C4:
				if (this.b != value)
				{
					num = (short)441516042;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_92;
				}
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00026508 File Offset: 0x00024708
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1888550914;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_10D;
					case 1:
					{
						num = (short)483065856;
						short num3 = num;
						num = (short)822419869;
						short num4 = num;
						num = (short)1569137053;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1945370624;
							if (num != 0)
							{
							}
							this.a.c(this);
							num = (short)1016266752;
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
					num = (short)398786561;
					if (num != 0)
					{
					}
					if (this.a == null)
					{
						goto IL_10F;
					}
					num = (short)825098241;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_10D:
			IL_10F:
			A_1.Handled = true;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0002662C File Offset: 0x0002482C
		// (set) Token: 0x060001EE RID: 494 RVA: 0x000266DC File Offset: 0x000248DC
		internal global::DevComponents.WpfEditors.InputBaseControl Parent
		{
			get
			{
				short num = (short)507632165;
				short num2 = num;
				num = (short)439867941;
				switch (num2 == num)
				{
				}
				num = (short)974913536;
				short num3 = num;
				num = (short)273743873;
				if (num != 0)
				{
				}
				num = (short)290979840;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)307625986;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							return;
						case 1:
						{
							num = (short)1990524929;
							if (num != 0)
							{
							}
							num = (short)1799815168;
							short num3 = num;
							num = (short)1940636873;
							short num4 = num;
							num = (short)594330825;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)2107113472;
								if (num != 0)
								{
								}
								this.a = value;
								num = (short)1641938944;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_30;
							}
							continue;
						}
						IL_30:
						if (this.a == value)
						{
							return;
						}
						num = (short)76677121;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000267F8 File Offset: 0x000249F8
		// Note: this type is marked as 'beforefieldinit'.
		static InputButtonSettings()
		{
			int a_ = 19;
			short num = (short)807731201;
			if (num != 0)
			{
			}
			num = (short)593611542;
			short num2 = num;
			num = (short)1838467862;
			switch (num2 == num)
			{
			default:
			{
				num = (short)670105600;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)377552896;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.InputButtonSettings.VisibleProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("뛟诡韣迥諧蛩觫", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputButtonSettings), new global::System.Windows.UIPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputButtonSettings.d)));
			global::DevComponents.WpfEditors.InputButtonSettings.DisplayPositionProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꓟ诡韣雥蓧诩闫뻭鿯臱鷳苵釷闹鋻", a_), typeof(int), typeof(global::DevComponents.WpfEditors.InputButtonSettings), new global::System.Windows.UIPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputButtonSettings.c)));
			global::DevComponents.WpfEditors.InputButtonSettings.IsEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꧟釡ꇣ裥觧裩胫语铯", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.InputButtonSettings), new global::System.Windows.UIPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputButtonSettings.b)));
			global::DevComponents.WpfEditors.InputButtonSettings.ContentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("ꏟ跡諣鋥跧蓩飫", a_), typeof(object), typeof(global::DevComponents.WpfEditors.InputButtonSettings), new global::System.Windows.UIPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfEditors.InputButtonSettings.a)));
		}

		// Token: 0x04000135 RID: 309
		private global::DevComponents.WpfEditors.InputBaseControl a;

		// Token: 0x04000136 RID: 310
		public static readonly global::System.Windows.DependencyProperty VisibleProperty;

		// Token: 0x04000137 RID: 311
		public static readonly global::System.Windows.DependencyProperty DisplayPositionProperty;

		// Token: 0x04000138 RID: 312
		public static readonly global::System.Windows.DependencyProperty IsEnabledProperty;

		// Token: 0x04000139 RID: 313
		public static readonly global::System.Windows.DependencyProperty ContentProperty;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.UIElement b;
	}
}
