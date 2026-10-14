using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using DevComponents.WpfDock.Converters;

namespace DevComponents.WpfDock
{
	// Token: 0x02000026 RID: 38
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DockWindowSelector : global::System.Windows.Controls.Primitives.Selector
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600023D RID: 573 RVA: 0x0003DFF8 File Offset: 0x0003C1F8
		// (set) Token: 0x0600023E RID: 574 RVA: 0x0003E0B0 File Offset: 0x0003C2B0
		public bool CycleAllWindows
		{
			get
			{
				short num = (short)1248402694;
				short num2 = num;
				num = (short)190913798;
				switch (num2 == num)
				{
				}
				num = (short)1076756481;
				if (num != 0)
				{
				}
				num = (short)357564416;
				if (num != 0)
				{
				}
				num = (short)423821312;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindowSelector.CycleAllWindowsProperty);
			}
			set
			{
				short num = (short)95655137;
				short num2 = num;
				num = (short)1951044833;
				switch (num2 == num)
				{
				}
				num = (short)1815805952;
				if (num != 0)
				{
				}
				num = (short)742326273;
				if (num != 0)
				{
				}
				num = (short)1833959424;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowSelector.CycleAllWindowsProperty, value);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0003E16C File Offset: 0x0003C36C
		static DockWindowSelector()
		{
			int a_ = 16;
			short num = (short)575412579;
			short num2 = num;
			num = (short)1747851619;
			switch (num2 == num)
			{
			}
			num = (short)664731649;
			if (num != 0)
			{
			}
			num = (short)138477568;
			if (num != 0)
			{
			}
			num = (short)1444151296;
			short num3 = num;
			global::DevComponents.WpfDock.DockWindowSelector.CycleAllWindowsProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("賎꣐냒맔닖飘럚뇜裞裠跢臤裦黨飪", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindowSelector), new global::System.Windows.UIPropertyMetadata(false));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfDock.DockWindowSelector), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfDock.DockWindowSelector)));
			global::DevComponents.WpfDock.DockWindowSelector.ActiveToolWindowsLabelProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("軎닐꟒볔ꇖ볘迚닜냞跠듢賤触跨蓪髬鳮뷰鋲韴鋶闸", a_), typeof(string), typeof(global::DevComponents.WpfDock.DockWindowSelector), new global::System.Windows.FrameworkPropertyMetadata(""));
			global::DevComponents.WpfDock.DockWindowSelector.ActiveFilesLabelProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("軎닐꟒볔ꇖ볘鷚드돞蓠郢ꧤ蛦诨軪臬", a_), typeof(string), typeof(global::DevComponents.WpfDock.DockWindowSelector), new global::System.Windows.FrameworkPropertyMetadata(""));
			global::DevComponents.WpfDock.DockWindowSelector.a = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鯎뻐볒맔胖냘뗚맜냞雠郢", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<global::DevComponents.WpfDock.DockWindowInfo>), typeof(global::DevComponents.WpfDock.DockWindowSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfDock.DockWindowSelector.ToolWindowsProperty = global::DevComponents.WpfDock.DockWindowSelector.a.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowSelector.e = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鳎듐뿒냔듖귘뻚맜鯞蓠郢蛤闦胨鯪駬蛮黰鷲", a_), typeof(string), typeof(global::DevComponents.WpfDock.DockWindowSelector), new global::System.Windows.FrameworkPropertyMetadata(""));
			global::DevComponents.WpfDock.DockWindowSelector.SelectedDescriptionProperty = global::DevComponents.WpfDock.DockWindowSelector.e.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowSelector.d = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鳎듐뿒냔듖귘뻚맜韞蓠苢臤苦鯨", a_), typeof(object), typeof(global::DevComponents.WpfDock.DockWindowSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfDock.DockWindowSelector.SelectedHeaderProperty = global::DevComponents.WpfDock.DockWindowSelector.d.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowSelector.b = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鳎듐뿒냔듖귘뻚맜雞賠苢苤苦", a_), typeof(object), typeof(global::DevComponents.WpfDock.DockWindowSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfDock.DockWindowSelector.SelectedImageProperty = global::DevComponents.WpfDock.DockWindowSelector.b.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowSelector.c = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鳎듐뿒냔듖귘뻚맜鯞軠胢軤냦胨藪觬胮蛰", a_), typeof(global::DevComponents.WpfDock.DockWindow), typeof(global::DevComponents.WpfDock.DockWindowSelector), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfDock.DockWindowSelector.SelectedDockWindowProperty = global::DevComponents.WpfDock.DockWindowSelector.c.DependencyProperty;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0003E430 File Offset: 0x0003C630
		public DockWindowSelector()
		{
			this.ToolWindows = new global::System.Collections.ObjectModel.ObservableCollection<global::DevComponents.WpfDock.DockWindowInfo>();
			this.ToolWindows.CollectionChanged += this.a;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0003E468 File Offset: 0x0003C668
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)143196160;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)566034433;
				if (num != 0)
				{
				}
				num = (short)1917517824;
				num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.IEnumerator enumerator;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_83;
						}
						continue;
					case 1:
						goto IL_F3;
					case 2:
						if (A_1.OldItems != null)
						{
							num = (short)1443233797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						try
						{
							num = (short)407699458;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1EE;
								case 1:
									num = (short)716308480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_172;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)935657473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::DevComponents.WpfDock.DockWindowInfo child = (global::DevComponents.WpfDock.DockWindowInfo)enumerator.Current;
									base.AddLogicalChild(child);
									num = (short)1173749764;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_174:
								num = (short)1571225603;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_172:
								goto IL_174;
							}
							IL_1EE:
							goto IL_F8;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_210;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1FD:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)15204354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)2144927744;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_264;
								case 2:
									goto IL_262;
								}
								goto IL_210;
							}
							IL_262:
							IL_264:
							goto EndFinally_12;
							IL_210:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1848508417;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1FD;
							EndFinally_12:;
						}
						goto IL_265;
					case 4:
					{
						num = (short)1124270080;
						short num3 = num;
						goto IL_265;
					}
					case 5:
						enumerator = A_1.NewItems.GetEnumerator();
						num = (short)1192361985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_83:
					if (A_1.NewItems != null)
					{
						num = (short)1661665284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_F8:
					num = (short)1227423746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_265:
					enumerator = A_1.NewItems.GetEnumerator();
					num = (short)1853947907;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F3:
				try
				{
					num = (short)1692467202;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_340;
						case 1:
							num = (short)944570368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2C8;
							}
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)399441921;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::DevComponents.WpfDock.DockWindowInfo child2 = (global::DevComponents.WpfDock.DockWindowInfo)enumerator.Current;
							base.RemoveLogicalChild(child2);
							num = (short)808452100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_2CA:
						num = (short)1439236099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C8:
						goto IL_2CA;
					}
					IL_340:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_362;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_34F:
						switch (num2)
						{
						case 0:
							goto IL_3E6;
						case 1:
						{
							if (disposable == null)
							{
								goto IL_409;
							}
							num = (short)708786717;
							short num4 = num;
							num = (short)424426013;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3E6;
							default:
								num = (short)254672896;
								if (num != 0)
								{
								}
								num = (short)61603840;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_407;
						}
						goto IL_362;
						IL_3E6:
						disposable.Dispose();
						num = (short)160956418;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_407:
					IL_409:
					goto EndFinally_11;
					IL_362:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1144127489;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_34F;
					EndFinally_11:;
				}
				return;
			}
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0003E89C File Offset: 0x0003CA9C
		// (set) Token: 0x06000243 RID: 579 RVA: 0x0003E958 File Offset: 0x0003CB58
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::DevComponents.WpfDock.DockWindowInfo> ToolWindows
		{
			get
			{
				short num = (short)1983834561;
				short num2 = num;
				num = (short)489613761;
				switch (num2 == num)
				{
				}
				num = (short)171573248;
				if (num != 0)
				{
				}
				num = (short)499187713;
				if (num != 0)
				{
				}
				num = (short)172818432;
				short num3 = num;
				return (global::System.Collections.ObjectModel.ObservableCollection<global::DevComponents.WpfDock.DockWindowInfo>)base.GetValue(global::DevComponents.WpfDock.DockWindowSelector.ToolWindowsProperty);
			}
			internal set
			{
				short num = (short)1036494825;
				short num2 = num;
				num = (short)1040885737;
				switch (num2 == num)
				{
				}
				num = (short)1645281280;
				if (num != 0)
				{
				}
				num = (short)920453121;
				if (num != 0)
				{
				}
				num = (short)1928658944;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowSelector.a, value);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0003EA10 File Offset: 0x0003CC10
		protected override void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			short num = (short)1827079256;
			short num2 = num;
			num = (short)1368589400;
			switch (num2 == num)
			{
			}
			num = (short)1312555008;
			if (num != 0)
			{
			}
			num = (short)1501495297;
			if (num != 0)
			{
			}
			num = (short)2108293120;
			short num3 = num;
			base.OnSelectionChanged(e);
			this.b();
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0003EACC File Offset: 0x0003CCCC
		protected override void OnInitialized(global::System.EventArgs e)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			global::System.Reflection.PropertyInfo property;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_119;
				case 1:
				{
					if (!(property != null))
					{
						goto IL_142;
					}
					num2 = (short)1286471298;
					short num3 = num2;
					num2 = (short)1444478594;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_119;
					default:
					{
						num2 = (short)1910374400;
						if (num2 != 0)
						{
						}
						num2 = (short)1715601409;
						if (num2 != 0)
						{
						}
						num2 = (short)889323520;
						short num4 = num2;
						num2 = (short)1519321088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_140;
				}
				goto IL_25;
				IL_119:
				property.SetValue(this, false, null);
				num2 = (short)1840250882;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_140:
			IL_142:
			base.ItemContainerGenerator.StatusChanged += this.a;
			return;
			IL_25:
			base.OnInitialized(e);
			property = base.GetType().GetProperty(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蟃Ʂꛇ駉꧋ꋍ뗏뇑ꃓ鯕귗뛙꣛럝郟軡臣", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
			num2 = (short)131923969;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0003EC34 File Offset: 0x0003CE34
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1945567236;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					base.SelectedIndex = 0;
					num = (short)1495269383;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (base.HasItems)
					{
						num = (short)1593966597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12D;
				case 2:
					num = (short)77856776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)956366849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)555941889;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_76;
					}
					continue;
				case 5:
					num = (short)1460011014;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					IL_1B1:
					if (base.SelectedIndex < 0)
					{
						num = (short)1575223296;
						short num3 = num;
						num = (short)571736066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12D;
				case 7:
					goto IL_12D;
				case 8:
					if (this.SelectedToolWindow == null)
					{
						num = (short)333119488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12D;
				case 9:
					return;
				}
				IL_76:
				if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
				{
					num = (short)781123587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_12D:
				this.b();
				num = (short)251693638;
				short num4 = num;
				num = (short)448563782;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1B1;
				default:
					num = (short)985202688;
					if (num != 0)
					{
					}
					num = (short)418447369;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0003EE48 File Offset: 0x0003D048
		private void b()
		{
			for (;;)
			{
				IL_00:
				short num = (short)1366949890;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)298365884;
						short num3 = num;
						num = (short)1155707836;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1227554816;
							if (num != 0)
							{
							}
							num = (short)669843457;
							if (num != 0)
							{
							}
							this.SelectedToolWindow = null;
							num = (short)1843462145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 3:
						goto IL_81;
					case 4:
						if (this.SelectedToolWindow != null)
						{
							num = (short)650969088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_38:
					if (base.SelectedIndex < 0)
					{
						num = (short)1553399808;
						short num4 = num;
						num = (short)1594556419;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::DevComponents.WpfDock.DockWindowInfo dockWindowInfo = base.SelectedItem as global::DevComponents.WpfDock.DockWindowInfo;
						this.SelectedDescription = dockWindowInfo.Description;
						this.SelectedDockWindow = dockWindowInfo.DockWindow;
						this.SelectedHeader = dockWindowInfo.Header;
						this.SelectedImage = dockWindowInfo.Image;
						num = (short)2001076228;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
			IL_81:
			this.SelectedDescription = "";
			this.SelectedDockWindow = null;
			this.SelectedHeader = null;
			this.SelectedImage = null;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0003F00C File Offset: 0x0003D20C
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0003F0C4 File Offset: 0x0003D2C4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object SelectedImage
		{
			get
			{
				short num = (short)490089145;
				short num2 = num;
				num = (short)233384633;
				switch (num2 == num)
				{
				}
				num = (short)1075970049;
				if (num != 0)
				{
				}
				num = (short)688128000;
				if (num != 0)
				{
				}
				num = (short)1998716928;
				short num3 = num;
				return base.GetValue(global::DevComponents.WpfDock.DockWindowSelector.SelectedImageProperty);
			}
			internal set
			{
				short num = (short)16767593;
				short num2 = num;
				num = (short)511040105;
				switch (num2 == num)
				{
				}
				num = (short)1596588032;
				if (num != 0)
				{
				}
				num = (short)1541537793;
				if (num != 0)
				{
				}
				num = (short)1522139136;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowSelector.b, value);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0003F178 File Offset: 0x0003D378
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0003F22C File Offset: 0x0003D42C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object SelectedHeader
		{
			get
			{
				short num = (short)739574014;
				short num2 = num;
				num = (short)2069430526;
				switch (num2 == num)
				{
				}
				num = (short)356122624;
				if (num != 0)
				{
				}
				num = (short)1267269633;
				if (num != 0)
				{
				}
				num = (short)1597964288;
				short num3 = num;
				return base.GetValue(global::DevComponents.WpfDock.DockWindowSelector.SelectedHeaderProperty);
			}
			internal set
			{
				short num = (short)1598816257;
				if (num != 0)
				{
				}
				num = (short)1495729037;
				short num2 = num;
				num = (short)108200845;
				switch (num2 == num)
				{
				}
				num = (short)213319680;
				if (num != 0)
				{
				}
				num = (short)1657602048;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowSelector.d, value);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0003F2E0 File Offset: 0x0003D4E0
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0003F39C File Offset: 0x0003D59C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public string SelectedDescription
		{
			get
			{
				short num = (short)777125889;
				if (num != 0)
				{
				}
				num = (short)1649235073;
				short num2 = num;
				num = (short)1267946625;
				switch (num2 == num)
				{
				}
				num = (short)1844445184;
				if (num != 0)
				{
				}
				num = (short)1073545216;
				short num3 = num;
				return (string)base.GetValue(global::DevComponents.WpfDock.DockWindowSelector.SelectedDescriptionProperty);
			}
			internal set
			{
				short num = (short)326807252;
				short num2 = num;
				num = (short)572632788;
				switch (num2 == num)
				{
				}
				num = (short)1634926592;
				if (num != 0)
				{
				}
				num = (short)1874788353;
				if (num != 0)
				{
				}
				num = (short)228982784;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowSelector.e, value);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0003F450 File Offset: 0x0003D650
		// (set) Token: 0x0600024F RID: 591 RVA: 0x0003F50C File Offset: 0x0003D70C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::DevComponents.WpfDock.DockWindow SelectedDockWindow
		{
			get
			{
				short num = (short)1749942273;
				if (num != 0)
				{
				}
				num = (short)429274310;
				short num2 = num;
				num = (short)1839084742;
				switch (num2 == num)
				{
				}
				num = (short)1572732928;
				if (num != 0)
				{
				}
				num = (short)1739390976;
				short num3 = num;
				return (global::DevComponents.WpfDock.DockWindow)base.GetValue(global::DevComponents.WpfDock.DockWindowSelector.SelectedDockWindowProperty);
			}
			internal set
			{
				short num = (short)459397477;
				short num2 = num;
				num = (short)807786853;
				switch (num2 == num)
				{
				}
				num = (short)952958977;
				if (num != 0)
				{
				}
				num = (short)1861615616;
				if (num != 0)
				{
				}
				num = (short)1099759616;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowSelector.c, value);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0003F5C0 File Offset: 0x0003D7C0
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0003F67C File Offset: 0x0003D87C
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Bindable(true)]
		public string ActiveFilesLabel
		{
			get
			{
				short num = (short)1412427324;
				short num2 = num;
				num = (short)1763831356;
				switch (num2 == num)
				{
				}
				num = (short)2116812801;
				if (num != 0)
				{
				}
				num = (short)1649737728;
				if (num != 0)
				{
				}
				num = (short)458358784;
				short num3 = num;
				return (string)base.GetValue(global::DevComponents.WpfDock.DockWindowSelector.ActiveFilesLabelProperty);
			}
			set
			{
				short num = (short)664861858;
				short num2 = num;
				num = (short)1341258914;
				switch (num2 == num)
				{
				}
				num = (short)1371013121;
				if (num != 0)
				{
				}
				num = (short)1318780928;
				if (num != 0)
				{
				}
				num = (short)823656448;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowSelector.ActiveFilesLabelProperty, value);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0003F730 File Offset: 0x0003D930
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0003F7EC File Offset: 0x0003D9EC
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Content")]
		public string ActiveToolWindowsLabel
		{
			get
			{
				short num = (short)1941186431;
				short num2 = num;
				num = (short)2064066431;
				switch (num2 == num)
				{
				}
				num = (short)1448869888;
				if (num != 0)
				{
				}
				num = (short)991821825;
				if (num != 0)
				{
				}
				num = (short)1492975616;
				short num3 = num;
				return (string)base.GetValue(global::DevComponents.WpfDock.DockWindowSelector.ActiveToolWindowsLabelProperty);
			}
			set
			{
				short num = (short)93147745;
				short num2 = num;
				num = (short)224875105;
				switch (num2 == num)
				{
				}
				num = (short)1134952449;
				if (num != 0)
				{
				}
				num = (short)443875328;
				short num3 = num;
				num = (short)1998913536;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindowSelector.ActiveToolWindowsLabelProperty, value);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0003F8A4 File Offset: 0x0003DAA4
		internal void c()
		{
			short num = (short)1383071744;
			switch (num)
			{
			default:
			{
				num = (short)387776514;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindowInfo> list;
				for (;;)
				{
					int num4;
					switch (num2)
					{
					case 0:
						if (num3 < 0)
						{
							num = (short)187301894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24B;
					case 1:
						num4 = 0;
						num = (short)1983447045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					case 3:
						goto IL_30B;
					case 4:
						goto IL_402;
					case 5:
						if (this.SelectedToolWindow == null)
						{
							num = (short)669122583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = this.ToolWindows.IndexOf(this.SelectedToolWindow);
						num = (short)2130575369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num3 = list.Count - 1;
						num = (short)1873477645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (base.Items.Count > 0)
						{
							num = (short)223215634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)623378449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)886767616;
						short num5 = num;
						num4 = this.ToolWindows.Count - 1;
						num = (short)409862155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (num4 == 0)
						{
							num = (short)871825416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4--;
						num = (short)1018560515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num3 = list.IndexOf(this.SelectedToolWindow);
						num = (short)1586102276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_30B;
					case 12:
						goto IL_30B;
					case 13:
						goto IL_24B;
					case 14:
						if (num3 < base.Items.Count)
						{
							num = (short)560922639;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_362;
					case 15:
						goto IL_28C;
					case 16:
						goto IL_246;
					case 17:
						if (this.ToolWindows.Count > 0)
						{
							num = (short)262864897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						num = (short)768475157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_337;
					case 20:
						if (this.SelectedToolWindow != null)
						{
							num = (short)1425342474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_402;
					case 21:
					{
						if (base.SelectedIndex > 0)
						{
							num = (short)196280336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1128062785;
						short num6 = num;
						num = (short)442818369;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C7;
						default:
							goto IL_504;
						}
						break;
					}
					case 22:
						goto IL_C7;
					case 23:
						num4 = this.ToolWindows.Count - 1;
						num = (short)435552268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A3:
					if (this.a())
					{
						num = (short)909574166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1490616327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C7:
					list = new global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindowInfo>(base.Items.Count + this.ToolWindows.Count);
					global::DevComponents.WpfDock.DockWindowInfo[] array = new global::DevComponents.WpfDock.DockWindowInfo[base.Items.Count];
					base.Items.CopyTo(array, 0);
					list.AddRange(array);
					list.AddRange(this.ToolWindows);
					num3 = base.SelectedIndex;
					num = (short)614596628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24B:
					num = (short)1874591758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30B:
					this.SelectedToolWindow = this.ToolWindows[num4];
					num = (short)1194852371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_402:
					num3--;
					num = (short)1266745344;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_246:
				int selectedIndex = base.SelectedIndex;
				base.SelectedIndex = selectedIndex - 1;
				return;
				IL_28C:
				this.SelectedToolWindow = null;
				base.SelectedItem = list[num3];
				return;
				IL_337:
				num = (short)681639937;
				if (num != 0)
				{
				}
				return;
				IL_362:
				this.SelectedToolWindow = list[num3];
				return;
				IL_504:
				num = (short)1834287104;
				if (num != 0)
				{
				}
				base.SelectedIndex = base.Items.Count - 1;
				return;
			}
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0003FDE0 File Offset: 0x0003DFE0
		internal void d()
		{
			short num = (short)1272446976;
			switch (num)
			{
			default:
			{
				num = (short)1154023426;
				int num2 = (int)((global::System.IntPtr)num);
				int num3;
				global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindowInfo> list;
				for (;;)
				{
					int num4;
					switch (num2)
					{
					case 0:
						if (num3 > list.Count - 1)
						{
							num = (short)1208025094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_271;
					case 1:
						num4 = 0;
						num = (short)530120709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					case 3:
						goto IL_33F;
					case 4:
						goto IL_412;
					case 5:
						if (this.SelectedToolWindow == null)
						{
							num = (short)282263575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = this.ToolWindows.IndexOf(this.SelectedToolWindow);
						num = (short)1725038601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num3 = 0;
						num = (short)266403853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (base.Items.Count > 0)
						{
							num = (short)1603338258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)700645393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num4 = 0;
						num = (short)683606027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (num4 == this.ToolWindows.Count - 1)
						{
							num = (short)1129512960;
							short num5 = num;
							num = (short)2072379400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)1896677379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num3 = list.IndexOf(this.SelectedToolWindow);
						num = (short)401145860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_33F;
					case 12:
						goto IL_33F;
					case 13:
						goto IL_271;
					case 14:
						if (num3 < base.Items.Count)
						{
							num = (short)1343225871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36F;
					case 15:
						goto IL_2B3;
					case 16:
						goto IL_26C;
					case 17:
						num = (short)1670381569;
						if (num != 0)
						{
						}
						if (this.ToolWindows.Count > 0)
						{
							num = (short)428408833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						num = (short)744554517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_36A;
					case 20:
						if (this.SelectedToolWindow != null)
						{
							num = (short)551550986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_412;
					case 21:
					{
						if (base.SelectedIndex < base.Items.Count - 1)
						{
							num = (short)397213712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)789332288;
						short num6 = num;
						num = (short)1594638656;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C9;
						default:
							goto IL_50D;
						}
						break;
					}
					case 22:
						goto IL_C9;
					case 23:
						num4 = 0;
						num = (short)1894973452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A5:
					if (this.a())
					{
						num = (short)2144075798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)41353223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C9:
					list = new global::System.Collections.Generic.List<global::DevComponents.WpfDock.DockWindowInfo>(base.Items.Count + this.ToolWindows.Count);
					global::DevComponents.WpfDock.DockWindowInfo[] array = new global::DevComponents.WpfDock.DockWindowInfo[base.Items.Count];
					base.Items.CopyTo(array, 0);
					list.AddRange(array);
					list.AddRange(this.ToolWindows);
					num3 = base.SelectedIndex;
					num = (short)95354900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_271:
					num = (short)650969102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33F:
					this.SelectedToolWindow = this.ToolWindows[num4];
					num = (short)575995923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_412:
					num3++;
					num = (short)1044119552;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_26C:
				int selectedIndex = base.SelectedIndex;
				base.SelectedIndex = selectedIndex + 1;
				return;
				IL_2B3:
				this.SelectedToolWindow = null;
				base.SelectedItem = list[num3];
				return;
				IL_36A:
				return;
				IL_36F:
				this.SelectedToolWindow = list[num3];
				return;
				IL_50D:
				num = (short)1032060928;
				if (num != 0)
				{
				}
				base.SelectedIndex = 0;
				return;
			}
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00040318 File Offset: 0x0003E518
		private bool a()
		{
			short num = (short)408626782;
			short num2 = num;
			num = (short)735716958;
			switch (num2 == num)
			{
			}
			num = (short)1814102017;
			if (num != 0)
			{
			}
			num = (short)1327562752;
			short num3 = num;
			num = (short)482476032;
			if (num != 0)
			{
			}
			return this.CycleAllWindows;
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000403C8 File Offset: 0x0003E5C8
		// (set) Token: 0x06000258 RID: 600 RVA: 0x00040478 File Offset: 0x0003E678
		internal global::DevComponents.WpfDock.DockWindowInfo SelectedToolWindow
		{
			get
			{
				short num = (short)662313918;
				short num2 = num;
				num = (short)522591166;
				switch (num2 == num)
				{
				}
				num = (short)606076928;
				if (num != 0)
				{
				}
				num = (short)961413120;
				short num3 = num;
				num = (short)163708929;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1966866432;
				short num2 = num;
				num = (short)585105414;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.f.IsSelected = false;
						num = (short)304545796;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)2025003358;
						short num4 = num;
						num = (short)650647902;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B1;
						default:
							num = (short)1374814208;
							if (num != 0)
							{
							}
							if (this.f != null)
							{
								num = (short)418840576;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_94;
						}
						break;
					}
					case 3:
						this.f.IsSelected = true;
						base.SelectedIndex = -1;
						num = (short)1817968641;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_94;
					case 5:
						goto IL_B1;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 7:
						return;
					}
					IL_6D:
					if (this.f == value)
					{
						num = (short)134676487;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1598291970;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_94:
					this.f = value;
					num = (short)2015100933;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_B1:
					if (this.f == null)
					{
						return;
					}
					num = (short)1086062593;
					if (num != 0)
					{
					}
					num = (short)998506499;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x04000146 RID: 326
		public static readonly global::System.Windows.DependencyProperty ToolWindowsProperty;

		// Token: 0x04000147 RID: 327
		private static readonly global::System.Windows.DependencyPropertyKey a;

		// Token: 0x04000148 RID: 328
		public static readonly global::System.Windows.DependencyProperty SelectedImageProperty;

		// Token: 0x04000149 RID: 329
		private static readonly global::System.Windows.DependencyPropertyKey b;

		// Token: 0x0400014A RID: 330
		public static readonly global::System.Windows.DependencyProperty SelectedDockWindowProperty;

		// Token: 0x0400014B RID: 331
		private static readonly global::System.Windows.DependencyPropertyKey c;

		// Token: 0x0400014C RID: 332
		public static readonly global::System.Windows.DependencyProperty SelectedHeaderProperty;

		// Token: 0x0400014D RID: 333
		private static readonly global::System.Windows.DependencyPropertyKey d;

		// Token: 0x0400014E RID: 334
		public static readonly global::System.Windows.DependencyProperty SelectedDescriptionProperty;

		// Token: 0x0400014F RID: 335
		private static readonly global::System.Windows.DependencyPropertyKey e;

		// Token: 0x04000150 RID: 336
		public static readonly global::System.Windows.DependencyProperty ActiveToolWindowsLabelProperty;

		// Token: 0x04000151 RID: 337
		public static readonly global::System.Windows.DependencyProperty ActiveFilesLabelProperty;

		// Token: 0x04000152 RID: 338
		public static readonly global::System.Windows.DependencyProperty CycleAllWindowsProperty;

		// Token: 0x04000153 RID: 339
		private global::DevComponents.WpfDock.DockWindowInfo f;
	}
}
