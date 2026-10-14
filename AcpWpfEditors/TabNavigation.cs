using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000045 RID: 69
	[global::System.ComponentModel.DesignTimeVisible(true)]
	public class TabNavigation : global::System.Windows.Controls.TabControl
	{
		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00061E54 File Offset: 0x00060054
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00061F08 File Offset: 0x00060108
		public object SelectedHeader
		{
			get
			{
				short num = (short)65305412;
				short num2 = num;
				num = (short)1533508420;
				switch (num2 == num)
				{
				}
				num = (short)697106432;
				if (num != 0)
				{
				}
				num = (short)1612120064;
				short num3 = num;
				num = (short)1089273857;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfEditors.TabNavigation.SelectedHeaderProperty);
			}
			set
			{
				short num = (short)530459566;
				short num2 = num;
				num = (short)459221934;
				switch (num2 == num)
				{
				}
				num = (short)1202061313;
				if (num != 0)
				{
				}
				num = (short)712966144;
				short num3 = num;
				num = (short)223543296;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.TabNavigation.SelectedHeaderProperty, value);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00061FC0 File Offset: 0x000601C0
		// (set) Token: 0x060004BA RID: 1210 RVA: 0x00062078 File Offset: 0x00060278
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AnimationEnabled
		{
			get
			{
				short num = (short)138558481;
				short num2 = num;
				num = (short)1115765777;
				switch (num2 == num)
				{
				}
				num = (short)807141377;
				if (num != 0)
				{
				}
				num = (short)1214185472;
				short num3 = num;
				num = (short)569573376;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.TabNavigation.AnimationEnabledProperty);
			}
			set
			{
				short num = (short)161703772;
				short num2 = num;
				num = (short)1717069660;
				switch (num2 == num)
				{
				}
				num = (short)1819410432;
				if (num != 0)
				{
				}
				num = (short)1003028480;
				short num3 = num;
				num = (short)1424097281;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.TabNavigation.AnimationEnabledProperty, value);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00062134 File Offset: 0x00060334
		static TabNavigation()
		{
			int a_ = 5;
			short num = (short)157559539;
			short num2 = num;
			num = (short)2143628019;
			switch (num2 == num)
			{
			}
			num = (short)1582104577;
			if (num != 0)
			{
			}
			num = (short)1217396736;
			short num3 = num;
			num = (short)478478336;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.TabNavigation.SelectedHeaderProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("臑뇓뫕뷗맙꣛믝蓟ꫡ臣蟥賧迩黫", a_), typeof(object), typeof(global::DevComponents.WpfEditors.TabNavigation), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfEditors.TabNavigation.AnimationEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏑뫓뿕뗗믙꣛럝迟賡ꇣ裥觧裩胫语铯", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.TabNavigation), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.TabNavigation.d = null;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.TabNavigation), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.TabNavigation)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::DevComponents.WpfEditors.TabNavigation), global::System.Windows.Controls.Primitives.ButtonBase.ClickEvent, new global::System.Windows.RoutedEventHandler(global::DevComponents.WpfEditors.TabNavigation.a));
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00062298 File Offset: 0x00060498
		public override void OnApplyTemplate()
		{
			int a_ = 18;
			short num = (short)99288184;
			short num2 = num;
			num = (short)1403978872;
			switch (num2 == num)
			{
			}
			num = (short)1605173249;
			if (num != 0)
			{
			}
			num = (short)674758656;
			short num3 = num;
			num = (short)1406402560;
			if (num != 0)
			{
			}
			this.a = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("连ꃠ뇢뇤룦뫨鿪賬鯮铰닲鯴黶铸髺觼雾渀洂", a_)) as global::DevComponents.WpfEditors.StateAnimationControl);
			base.OnApplyTemplate();
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00062370 File Offset: 0x00060570
		protected override void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			int a_ = 19;
			short num = (short)1874657280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A7;
				}
				bool flag;
				for (;;)
				{
					IL_30:
					global::System.Windows.Controls.TabItem tabItem;
					switch (num2)
					{
					case 0:
						if (this.a != null)
						{
							num = (short)367853595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EB;
					case 1:
						num = (short)1641480194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (e.AddedItems != null)
						{
							num = (short)730660885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EB;
					case 3:
						if (e.AddedItems.Count == 1)
						{
							num = (short)372244481;
							if (num != 0)
							{
							}
							num = (short)368050196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EB;
					case 4:
						return;
					case 5:
						goto IL_247;
					case 6:
						if (this.b)
						{
							num = (short)1867055116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54B;
					case 7:
						goto IL_EB;
					case 8:
						if (e.RemovedItems != null)
						{
							num = (short)1368850443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EB;
					case 9:
						if (!this.c)
						{
							num = (short)769064977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54B;
					case 10:
					{
						num = (short)1566572544;
						short num3 = num;
						if (tabItem != null)
						{
							num = (short)362348562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.Data.BindingOperations.ClearBinding(this, global::DevComponents.WpfEditors.TabNavigation.SelectedHeaderProperty);
						this.SelectedHeader = null;
						num = (short)128188441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						num = (short)352443375;
						short num4 = num;
						num = (short)1419828207;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16C;
						default:
							num = (short)1592655872;
							if (num != 0)
							{
							}
							num = (short)695861261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						goto IL_29A;
					case 13:
						if (e.RemovedItems.Count == 1)
						{
							num = (short)25362454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EB;
					case 14:
						if (this.c())
						{
							num = (short)323551233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EB;
					case 15:
						this.a.AnimateStateTransition();
						num = (short)2139881476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)825360390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_16C;
					case 18:
					{
						global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("꣟蟡藣若跧飩", a_));
						binding.Source = tabItem;
						binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
						global::System.Windows.Data.BindingOperations.SetBinding(this, global::DevComponents.WpfEditors.TabNavigation.SelectedHeaderProperty, binding);
						num = (short)611057688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						object item;
						if (base.Items.IndexOf(item) >= base.SelectedIndex)
						{
							num = (short)588709904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29A;
					}
					case 20:
						num = (short)1160708104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)1732640771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						object obj = e.AddedItems[0];
						object item = e.RemovedItems[0];
						num = (short)1270611987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_247;
					case 24:
						goto IL_34C;
					case 25:
						goto IL_34C;
					case 26:
						if (flag)
						{
							num = (short)62652431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 27:
						num = (short)589758478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A7;
					IL_EB:
					this.c = false;
					this.b = false;
					base.OnSelectionChanged(e);
					tabItem = this.b();
					num = (short)555024394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16C:
					this.a.AnimationType = global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromRightToLeft;
					num = (short)1529020421;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_247:
					this.a.StartStateTransition();
					flag = true;
					num = (short)1711800327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29A:
					num = (short)5636105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34C:
					num = (short)428998682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54B:
					this.a.AnimationType = global::DevComponents.WpfEditors.eStateAnimationType.ScrollFromLeftToRight;
					num = (short)1285947415;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_A7:
				flag = false;
				num = (short)1257570304;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000628F4 File Offset: 0x00060AF4
		private bool c()
		{
			if (this.AnimationEnabled)
			{
				short num = (short)1983600368;
				short num2 = num;
				num = (short)1280661232;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1048182785;
					if (num != 0)
					{
					}
					num = (short)85065728;
					short num3 = num;
					num = (short)2000486400;
					if (num != 0)
					{
					}
					return base.IsInitialized;
				}
				}
			}
			return false;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x000629B4 File Offset: 0x00060BB4
		private global::System.Windows.Controls.TabItem b()
		{
			int num;
			short num2;
			object selectedItem;
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
						global::System.Windows.Controls.TabItem tabItem;
						if (tabItem == null)
						{
							num2 = (short)1418461184;
							short num3 = num2;
							num2 = (short)1053425666;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return tabItem;
					}
					case 1:
						goto IL_5A;
					case 2:
					{
						global::System.Windows.Controls.TabItem tabItem = base.ItemContainerGenerator.ContainerFromIndex(base.SelectedIndex) as global::System.Windows.Controls.TabItem;
						num2 = (short)34144259;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
					{
						global::System.Windows.Controls.TabItem tabItem;
						return tabItem;
					}
					case 4:
					{
						if (selectedItem == null)
						{
							num2 = (short)1414725633;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::System.Windows.Controls.TabItem tabItem = selectedItem as global::System.Windows.Controls.TabItem;
						num2 = (short)584318977;
						if (num2 != 0)
						{
						}
						num2 = (short)1668843233;
						short num4 = num2;
						num2 = (short)1449625313;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B;
						default:
							num2 = (short)846200832;
							if (num2 != 0)
							{
							}
							num2 = (short)925761536;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_24;
				}
				IL_5A:
				return null;
			}
			IL_24:
			selectedItem = base.SelectedItem;
			IL_2B:
			num2 = (short)33095684;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00062B34 File Offset: 0x00060D34
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::System.Windows.FrameworkElement frameworkElement;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_146;
				case 1:
				{
					num2 = (short)507343178;
					short num3 = num2;
					num2 = (short)626618698;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_146;
					default:
						num2 = (short)227737600;
						if (num2 != 0)
						{
						}
						num2 = (short)1592655872;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
				{
					num2 = (short)1552416769;
					if (num2 != 0)
					{
					}
					frameworkElement.SetResourceReference(global::System.Windows.FrameworkElement.StyleProperty, global::DevComponents.WpfEditors.TabNavigation.a());
					num2 = (short)363790336;
					short num4 = num2;
					num2 = (short)1007878147;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					return;
				case 4:
					if (frameworkElement is global::System.Windows.Controls.TabItem)
					{
						num2 = (short)922353665;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_24;
				IL_146:
				if (((global::System.Windows.Controls.TabItem)frameworkElement).Style != null)
				{
					break;
				}
				num2 = (short)844169218;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			base.PrepareContainerForItemOverride(element, item);
			frameworkElement = (element as global::System.Windows.FrameworkElement);
			num2 = (short)1332871172;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00062CB0 File Offset: 0x00060EB0
		private static object a()
		{
			int a_ = 4;
			short num = (short)331087873;
			if (num != 0)
			{
			}
			num = (short)709427202;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_12E;
				case 1:
				{
					num = (short)1301051184;
					short num3 = num;
					num = (short)173504304;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6C;
					default:
					{
						num = (short)783089664;
						short num4 = num;
						num = (short)461635584;
						if (num != 0)
						{
						}
						global::DevComponents.WpfEditors.TabNavigation.d = new global::System.Windows.ComponentResourceKey(typeof(global::DevComponents.WpfEditors.TabNavigation), global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("藐닒럔黖귘뻚냜", a_));
						num = (short)289734656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				}
				goto IL_62;
				IL_6C:
				num = (short)1449721857;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_62:
				if (global::DevComponents.WpfEditors.TabNavigation.d == null)
				{
					goto IL_6C;
				}
				break;
			}
			IL_12E:
			return global::DevComponents.WpfEditors.TabNavigation.d;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00062DF4 File Offset: 0x00060FF4
		protected virtual void SelectNextTab()
		{
			short num = (short)1834876931;
			int num2 = (int)((global::System.IntPtr)num);
			int num5;
			for (;;)
			{
				num = (short)1174405120;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					num = (short)2110355888;
					short num4 = num;
					num = (short)342718896;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6D;
					default:
						num = (short)1999765505;
						if (num != 0)
						{
						}
						num = (short)1020264448;
						if (num != 0)
						{
						}
						if (num5 < 0)
						{
							num = (short)783941633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_142;
					}
					break;
				}
				case 1:
					return;
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				}
				goto IL_60;
				IL_6D:
				num = (short)604831746;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_60:
				if (base.Items.Count == 0)
				{
					goto IL_6D;
				}
				num5 = this.a(base.SelectedIndex, 1);
				num = (short)138543104;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_142:
			this.b = true;
			base.SelectedIndex = num5;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00062F54 File Offset: 0x00061154
		protected virtual void SelectPreviousTab()
		{
			short num = (short)597950467;
			int num2 = (int)((global::System.IntPtr)num);
			int num5;
			for (;;)
			{
				num = (short)197459968;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					num = (short)1567128600;
					short num4 = num;
					num = (short)1004436504;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6B;
					default:
						num = (short)1081081856;
						if (num != 0)
						{
						}
						if (num5 < 0)
						{
							num = (short)406126593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					}
					break;
				}
				case 1:
					return;
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				}
				goto IL_5E;
				IL_6B:
				num = (short)2074738690;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5E:
				if (base.Items.Count == 0)
				{
					goto IL_6B;
				}
				num = (short)536608769;
				if (num != 0)
				{
				}
				num5 = this.a(base.SelectedIndex, -1);
				num = (short)83558400;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_13F:
			this.c = true;
			base.SelectedIndex = num5;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000630B0 File Offset: 0x000612B0
		private int a(int A_0, int A_1)
		{
			short num = (short)1211564032;
			switch (num)
			{
			default:
			{
				num = (short)1610874881;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					int num4;
					int num7;
					int num8;
					global::System.Windows.UIElement uielement;
					switch (num2)
					{
					case 0:
						num3 = 0;
						num4 = -1;
						num = (short)1146683423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_D1;
						}
						continue;
					case 2:
						num = (short)369688603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1568408049;
						short num5 = num;
						num = (short)183632369;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22D;
						default:
							num = (short)440860672;
							if (num != 0)
							{
							}
							A_0 = base.Items.Count;
							num3 = 0;
							num = (short)1609891866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_327;
					case 5:
					{
						num = (short)726532096;
						short num6 = num;
						A_0 = -1;
						num3 = base.Items.Count - 1;
						num = (short)1568014348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return num7;
					case 7:
						if (num8 >= 2)
						{
							num = (short)148504589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F5;
					case 8:
						if (A_1 == 1)
						{
							num = (short)993198085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20A;
					case 9:
						goto IL_280;
					case 10:
						if (uielement == null)
						{
							num = (short)859373596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_537;
					case 11:
						A_0 = base.Items.Count;
						num = (short)192086025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_20A;
					case 13:
						return -1;
					case 14:
						return -1;
					case 15:
						goto IL_327;
					case 16:
						return -1;
					case 17:
						goto IL_537;
					case 18:
						num = (short)2037252119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (uielement.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)149487622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F5;
					case 20:
						if (uielement != null)
						{
							num = (short)840761366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F5;
					case 21:
						if (A_1 < 0)
						{
							num = (short)1442316288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)692125720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)1789526017;
						if (num != 0)
						{
						}
						num = (short)695533587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (A_1 == 1)
						{
							num = (short)412352541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 24:
						if (A_0 >= num3)
						{
							num = (short)667353104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_517;
					case 25:
						goto IL_280;
					case 26:
						goto IL_20A;
					case 27:
						if (A_1 == -1)
						{
							num = (short)1590296579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)986578952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						uielement = (base.ItemContainerGenerator.ContainerFromIndex(num7) as global::System.Windows.UIElement);
						num = (short)123797521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						A_0 = -1;
						num = (short)273350681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (num3 == num7)
						{
							num = (short)183107586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D;
					case 31:
						if (A_0 <= 0)
						{
							num = (short)2036596750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_517;
					case 32:
						if (A_0 == base.Items.Count - 1)
						{
							num = (short)430112786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280;
					case 33:
						if (A_1 == -1)
						{
							num = (short)1897005067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BE;
					case 34:
						num = (short)1195048993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D1:
					if (A_0 == 0)
					{
						num = (short)804978722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BE;
					IL_F5:
					num = (short)804585502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BE:
					num = (short)1186136096;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20A:
					num7 = A_0;
					num8++;
					num = (short)49152015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22D:
					num7 += num4;
					uielement = (base.Items[num7] as global::System.Windows.UIElement);
					num = (short)736296970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_280:
					num7 = A_0;
					num3 = base.Items.Count - 1;
					num4 = 1;
					num = (short)2079916053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_327:
					num = (short)25690119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_517:
					num8 = 0;
					num = (short)1181745156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_537:
					num = (short)906166292;
					num2 = (int)((global::System.IntPtr)num);
				}
				return -1;
			}
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000636C4 File Offset: 0x000618C4
		private static void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1951862389;
			short num2 = num;
			num = (short)435162741;
			switch (num2 == num)
			{
			}
			num = (short)1606942720;
			if (num != 0)
			{
			}
			num = (short)533528577;
			if (num != 0)
			{
			}
			num = (short)586022912;
			short num3 = num;
			((global::DevComponents.WpfEditors.TabNavigation)A_0).a(A_1);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00063778 File Offset: 0x00061978
		private void a(global::System.Windows.RoutedEventArgs A_0)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_63;
			}
			short num;
			for (;;)
			{
				IL_13:
				num = (short)235274241;
				if (num != 0)
				{
				}
				int num2;
				switch (num2)
				{
				case 0:
				{
					global::System.Windows.Controls.Button button;
					if (button != null)
					{
						num = (short)1756758021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 1:
				{
					global::System.Windows.Controls.Button button;
					if (button.Name == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("飕뷗ꋙ꣛諝臟胡ꛣ鏥鳧黩菫胭", a_))
					{
						num = (short)724434950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)811270151;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (!A_0.Handled)
					{
						num = (short)85590020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_1DA;
				case 4:
					num = (short)1826160641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)417267714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_228;
				case 7:
				{
					global::System.Windows.Controls.Button button;
					if (button.Name == global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蛕꫗뿙ꫛ럝迟韡韣닥觧裩껫鯭蓯蛱鯳飵", a_))
					{
						num = (short)1063518216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 8:
					goto IL_16A;
				}
				goto IL_63;
			}
			IL_16A:
			goto IL_1B6;
			IL_1DA:
			return;
			IL_228:
			this.SelectNextTab();
			A_0.Handled = true;
			return;
			IL_63:
			num = (short)654694880;
			short num3 = num;
			num = (short)518511072;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1B6:
				this.SelectPreviousTab();
				A_0.Handled = true;
				num = (short)1642135555;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			default:
			{
				num = (short)1704001536;
				if (num != 0)
				{
				}
				num = (short)1928134656;
				short num4 = num;
				global::System.Windows.Controls.Button button = A_0.OriginalSource as global::System.Windows.Controls.Button;
				num = (short)1099628544;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			}
		}

		// Token: 0x0400024E RID: 590
		private global::DevComponents.WpfEditors.StateAnimationControl a;

		// Token: 0x0400024F RID: 591
		public static readonly global::System.Windows.DependencyProperty SelectedHeaderProperty;

		// Token: 0x04000250 RID: 592
		public static readonly global::System.Windows.DependencyProperty AnimationEnabledProperty;

		// Token: 0x04000251 RID: 593
		private bool b;

		// Token: 0x04000252 RID: 594
		private bool c;

		// Token: 0x04000253 RID: 595
		private static global::System.Windows.ComponentResourceKey d;
	}
}
