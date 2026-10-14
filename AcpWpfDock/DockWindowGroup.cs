using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Xml;
using DevComponents.WpfDock.Converters;

namespace DevComponents.WpfDock
{
	// Token: 0x02000024 RID: 36
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_GroupCaption", Type = typeof(global::System.Windows.Controls.Decorator))]
	public class DockWindowGroup : global::System.Windows.Controls.Primitives.Selector
	{
		// Token: 0x060001D5 RID: 469 RVA: 0x00034818 File Offset: 0x00032A18
		static DockWindowGroup()
		{
			int a_ = 15;
			short num = (short)713193531;
			short num2 = num;
			num = (short)949581883;
			switch (num2 == num)
			{
			default:
			{
				num = (short)44236800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1555169281;
			if (num != 0)
			{
			}
			num = (short)526123008;
			if (num != 0)
			{
			}
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfDock.DockWindowGroup)));
			global::DevComponents.WpfDock.DockWindowGroup.a = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鷍뗏뻑뇓뗕곗뿙룛鷝迟賡郣菥蛧黩", a_), typeof(object), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfDock.DockWindowGroup.SelectedContentProperty = global::DevComponents.WpfDock.DockWindowGroup.a.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowGroup.c = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鷍뗏뻑뇓뗕곗뿙룛鷝迟賡郣菥蛧黩룫语鷯英飳韵賷鿹", a_), typeof(global::System.Windows.DataTemplate), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfDock.DockWindowGroup.SelectedContentTemplateProperty = global::DevComponents.WpfDock.DockWindowGroup.c.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowGroup.d = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鷍뗏뻑뇓뗕곗뿙룛鷝迟賡郣菥蛧黩룫语鷯英飳韵賷鿹꿻鯽泿朁會爅朇砉", a_), typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfDock.DockWindowGroup.SelectedContentTemplateSelectorProperty = global::DevComponents.WpfDock.DockWindowGroup.d.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowGroup.SelectedContentHeaderProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鷍뗏뻑뇓뗕곗뿙룛鷝迟賡郣菥蛧黩ꓫ语釯雱釳蓵", a_), typeof(object), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfDock.DockWindowGroup.ContentTemplateProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("跍뿏병ꃓ돕뛗껙裛믝跟鋡裣蟥鳧迩", a_), typeof(global::System.Windows.DataTemplate), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfDock.DockWindowGroup.ContentTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("跍뿏병ꃓ돕뛗껙裛믝跟鋡裣蟥鳧迩뿫语鳯韱音苵韷裹", a_), typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfDock.DockWindowGroup.e = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蟍ꏏ铑룓맕맗껙뗛냝蟟", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfDock.DockWindowGroup.IsFloatingProperty = global::DevComponents.WpfDock.DockWindowGroup.e.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowGroup.f = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("髍뇏냑苓뿕ꯗ동뻛럝賟诡郣鿥", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockWindowGroup.a)));
			global::DevComponents.WpfDock.DockWindowGroup.TabVisibilityProperty = global::DevComponents.WpfDock.DockWindowGroup.f.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowGroup.g = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("跍뇏병韓뫕럗꧙맛", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfDock.DockWindowGroup.CanCloseProperty = global::DevComponents.WpfDock.DockWindowGroup.g.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowGroup.h = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("跍뇏병闓ꏕ곗뗙铛럝蓟蟡", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfDock.DockWindowGroup.CanAutoHideProperty = global::DevComponents.WpfDock.DockWindowGroup.h.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowGroup.i = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蟍ꏏ鏑ꇓꋕ럗鋙뗛뫝藟", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::DevComponents.WpfDock.DockWindowGroup.IsAutoHideProperty = global::DevComponents.WpfDock.DockWindowGroup.i.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowGroup.j = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("臍ꃏꛑ뷓맕뛗꧙釛믝軟韡", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));
			global::DevComponents.WpfDock.DockWindowGroup.OptionsMenuProperty = global::DevComponents.WpfDock.DockWindowGroup.j.DependencyProperty;
			global::DevComponents.WpfDock.DockWindowGroup.b = global::System.Windows.DependencyProperty.RegisterReadOnly(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鷍뗏뻑뇓뗕곗뿙룛髝迟臡迣뇥臧蓩裫臭蟯", a_), typeof(global::DevComponents.WpfDock.DockWindow), typeof(global::DevComponents.WpfDock.DockWindowGroup), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfDock.DockWindowGroup.SelectedDockWindowProperty = global::DevComponents.WpfDock.DockWindowGroup.b.DependencyProperty;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00034C38 File Offset: 0x00032E38
		public DockWindowGroup()
		{
			this.y = global::System.Guid.NewGuid().ToString();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00034C88 File Offset: 0x00032E88
		public override void OnApplyTemplate()
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_61;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)1980563457;
					if (num2 != 0)
					{
					}
					this.aa.PreviewMouseLeftButtonDown -= this.b;
					num2 = (short)1042350085;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_3A3;
				case 2:
					if (this.ac != null)
					{
						num2 = (short)554369027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4A7;
				case 3:
					this.ac.Opened += this.b;
					num2 = (short)1518272516;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_319;
				case 5:
					goto IL_449;
				case 6:
					goto IL_F4;
				case 7:
					if (this.ab != null)
					{
						num2 = (short)2061172746;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F7;
				case 8:
					if (this.aa != null)
					{
						num2 = (short)61276171;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F4;
				case 9:
				{
					this.r.MouseLeftButtonDown += this.a;
					this.r.MouseMove += this.a;
					this.r.MouseLeave += this.b;
					num2 = (short)177733632;
					short num3 = num2;
					num2 = (short)1292042241;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					this.ab.Opened += this.a;
					num2 = (short)1803681807;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					this.aa.PreviewMouseLeftButtonDown += this.b;
					this.aa.PreviewMouseRightButtonUp += this.c;
					num2 = (short)145620998;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (this.aa != null)
					{
						num2 = (short)245497856;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_449;
				case 13:
					if (this.r != null)
					{
						num2 = (short)128516112;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B8;
				case 14:
					goto IL_47F;
				case 15:
					goto IL_1F7;
				case 16:
					this.r.MouseLeftButtonDown -= this.a;
					this.r.MouseMove -= this.a;
					this.r.MouseLeave -= this.b;
					num2 = (short)1088618513;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					goto IL_1B8;
				}
				goto IL_61;
				IL_F4:
				this.ab = (base.GetTemplateChild(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("諄럆뷈ꋊꋌꇎꋐ黒냔맖곘", a_)) as global::System.Windows.Controls.ContextMenu);
				num2 = (short)1671299079;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1B8:
				num2 = (short)923467788;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F7:
				this.ac = (base.GetTemplateChild(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鋄껆ꟈ꿊ꋌ룎鷐뫒ꛔꏖ", a_)) as global::System.Windows.Controls.ContextMenu);
				num2 = (short)1956708354;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_449:
				this.r = (base.GetTemplateChild(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("闄蛆鯈鿊鋌裎ꏐ볒ꃔꟖ高뫚규ꯞ裠賢诤", a_)) as global::System.Windows.UIElement);
				num2 = (short)1407254542;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_319:
			goto IL_4A7;
			IL_3A3:
			goto IL_154;
			IL_4A7:
			this.z = (base.GetTemplateChild(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("闄蛆鯈鿊鋌鯎냐뇒藔뛖럘뻚뇜", a_)) as global::System.Windows.Controls.Panel);
			this.ad = (base.GetTemplateChild(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("賄꧆ꟈ껊뿌賎뻐뷒ꇔ닖럘꿚", a_)) as global::System.Windows.UIElement);
			this.e();
			return;
			IL_61:
			num2 = (short)1189844796;
			short num4 = num2;
			num2 = (short)1166513980;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_47F:
				if (this.r != null)
				{
					num2 = (short)152961033;
					num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				break;
			default:
				num2 = (short)1581514752;
				if (num2 != 0)
				{
				}
				base.OnApplyTemplate();
				num2 = (short)1547567117;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			IL_154:
			this.ad = null;
			this.aa = (base.GetTemplateChild(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("諄럆뷈ꋊꋌꇎꋐ釒ꃔꏖ귘듚돜", a_)) as global::System.Windows.Controls.Button);
			num2 = (short)150863880;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00035180 File Offset: 0x00033380
		internal global::System.Windows.UIElement InnerContent
		{
			get
			{
				short num = (short)503955810;
				short num2 = num;
				num = (short)603046242;
				switch (num2 == num)
				{
				default:
				{
					num = (short)544079872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1214316545;
				if (num != 0)
				{
				}
				num = (short)1787822080;
				if (num != 0)
				{
				}
				return this.ad;
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00035230 File Offset: 0x00033430
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1516371969;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E7;
				case 1:
					num = (short)642187265;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 2:
					this.a(this.ac);
					num = (short)1498939392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_58:
				num = (short)18264862;
				short num3 = num;
				num = (short)1937290014;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)498139136;
					if (num != 0)
					{
					}
					if (!global::DevComponents.WpfDock.DockSite.GetIsDocument(this))
					{
						goto IL_E9;
					}
					break;
				}
				num = (short)1272578050;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E7:
			IL_E9:
			num = (short)1854930944;
			short num4 = num;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00035350 File Offset: 0x00033550
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 2;
			short num = (short)1312292864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::DevComponents.WpfDock.DockSite dockSite;
				for (;;)
				{
					IL_30:
					global::System.Collections.IEnumerator enumerator;
					global::DevComponents.WpfDock.DockLocalization systemText;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1772617763;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Windows.Controls.MenuItem menuItem;
								switch (num2)
								{
								case 1:
									if (menuItem != null)
									{
										num = (short)905052183;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)1370685453;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									menuItem = (enumerator.Current as global::System.Windows.Controls.MenuItem);
									num = (short)1744896001;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									string name;
									if (!(name == global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("賀ꛂꯄ닆蛈믊만ꛎ뻐뷒釔룖뫘냚볜뷞跠蛢", a_)))
									{
										num = (short)1141571593;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									menuItem.Header = systemText.OptionsMenuDockableText;
									num = (short)124452898;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_749;
								case 5:
									menuItem.IsChecked = (!this.SelectedDockWindow.IsFloating && !this.SelectedDockWindow.IsAutoHide && !global::DevComponents.WpfDock.DockSite.GetIsDocument(this.SelectedDockWindow));
									num = (short)1860960277;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)1025245213;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									menuItem.IsChecked = true;
									num = (short)107347985;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1789722651;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									menuItem.IsChecked = this.SelectedDockWindow.IsFloating;
									num = (short)790167582;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									menuItem.IsEnabled = true;
									menuItem.IsChecked = this.SelectedDockWindow.IsAutoHide;
									num = (short)1230962707;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									num = (short)248315908;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_687;
								case 15:
									num = (short)1840185370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									if (this.SelectedDockWindow != null)
									{
										num = (short)2104885259;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									menuItem.IsEnabled = false;
									num = (short)1031340032;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									menuItem.Visibility = (this.SelectedDockWindow.CanDockAsDocument ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
									num = (short)1914044444;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									if (!global::DevComponents.WpfDock.DockSite.GetIsDocument(this))
									{
										num = (short)1494024207;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_687;
								case 22:
									num = (short)2096234501;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
								{
									string name = menuItem.Name;
									num = (short)1734279206;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 24:
								{
									string name;
									if (!(name == global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("賀ꛂꯄ닆蛈믊만ꛎ뻐뷒鷔뻖뷘뻚", a_)))
									{
										num = (short)1868169247;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									menuItem.Header = systemText.OptionsMenuHideText;
									num = (short)2037907468;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 25:
									if (this.SelectedDockWindow != null)
									{
										num = (short)887095335;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									menuItem.IsEnabled = false;
									num = (short)103153701;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									if (!this.SelectedDockWindow.CanAutoHide)
									{
										num = (short)570294286;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 27:
								{
									string name;
									if (!(name == global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("賀ꛂꯄ닆蛈믊만ꛎ뻐뷒臔뛖믘맚룜믞ꗠ賢蛤", a_)))
									{
										num = (short)685703175;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									menuItem.Header = systemText.OptionsMenuTabbedDocumentText;
									num = (short)9764889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 28:
									if (global::DevComponents.WpfDock.DockSite.GetIsDocument(this.SelectedDockWindow))
									{
										num = (short)469565448;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 29:
								{
									string name;
									if (!(name == global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("賀ꛂꯄ닆蛈믊만ꛎ뻐뷒铔ꋖ귘듚關뛞藠蛢", a_)))
									{
										num = (short)1269694496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									menuItem.Header = systemText.OptionsMenuAutoHideText;
									num = (short)91881488;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 31:
									num = (short)2071265300;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
									num = (short)989462552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									if (this.SelectedDockWindow != null)
									{
										num = (short)1325203466;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 34:
									if (this.SelectedDockWindow != null)
									{
										num = (short)1423048726;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 35:
									switch (0)
									{
									case 0:
										goto IL_171;
									}
									continue;
								case 36:
									num = (short)994902019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 38:
								{
									string name;
									if (!(name == global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("賀ꛂꯄ닆蛈믊만ꛎ뻐뷒鏔믖뛘뫚꧜뛞迠蓢", a_)))
									{
										num = (short)1959198756;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									menuItem.Header = systemText.OptionsMenuFloatingText;
									num = (short)1006764065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 39:
									menuItem.IsEnabled = true;
									num = (short)962068498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_171;
								IL_687:
								menuItem.IsEnabled = false;
								num = (short)91881478;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6F1:
								num = (short)1275199490;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_171:
								goto IL_6F1;
							}
							IL_749:
							goto IL_84B;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_76B;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_758:
								switch (num2)
								{
								case 0:
									goto IL_812;
								case 1:
									goto IL_789;
								case 2:
								{
									disposable.Dispose();
									num = (short)1648627478;
									short num3 = num;
									num = (short)1469910806;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_789;
									default:
										num = (short)943783936;
										if (num != 0)
										{
										}
										num = (short)1634861056;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_76B;
								IL_789:
								if (disposable == null)
								{
									break;
								}
								num = (short)681443330;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_812:
							goto EndFinally_22;
							IL_76B:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)2041970689;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_758;
							EndFinally_22:;
						}
						goto IL_815;
					case 1:
						if (dockSite == null)
						{
							num = (short)801308674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_815;
					case 2:
						goto IL_7B;
					}
					goto IL_43;
					IL_815:
					systemText = dockSite.SystemText;
					enumerator = ((global::System.Collections.IEnumerable)this.ab.Items).GetEnumerator();
					num = (short)1101463552;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7B:
				num = (short)877789185;
				if (num != 0)
				{
				}
				return;
				IL_84B:
				num = (short)1288830976;
				short num4 = num;
				return;
				IL_43:
				dockSite = this.a(true);
				num = (short)882835457;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00035BF0 File Offset: 0x00033DF0
		private void a(global::System.Windows.Controls.ContextMenu A_0)
		{
			short num = (short)1163722752;
			short num2 = num;
			num = (short)1864570456;
			short num3 = num;
			num = (short)1339496024;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)525271040;
				if (num != 0)
				{
				}
				num = (short)1798307841;
				if (num != 0)
				{
				}
				num = (short)82837504;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					A_0.Items.Clear();
					global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
					try
					{
						num = (short)1560215562;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Windows.Controls.MenuItem menuItem;
							global::DevComponents.WpfDock.DockWindow dockWindow;
							switch (num4)
							{
							case 0:
								goto IL_298;
							case 1:
								A_0.Items.Add(menuItem);
								num = (short)1530396675;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)253231109;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (dockWindow != null)
								{
									num = (short)993394690;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 4:
								menuItem.IsChecked = true;
								num = (short)792920075;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								if (dockWindow.IsSelected)
								{
									num = (short)2009923588;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_19E;
							case 6:
							{
								if (dockWindow != null)
								{
									num = (short)893059085;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.Controls.HeaderedContentControl headeredContentControl;
								menuItem.Header = global::DevComponents.WpfDock.DockWindowGroup.a(headeredContentControl.Header);
								num = (short)314966016;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								object obj;
								if (((global::System.Windows.Controls.HeaderedContentControl)obj).Visibility == global::System.Windows.Visibility.Visible)
								{
									num = (short)430899216;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
							{
								object obj;
								if (obj is global::System.Windows.Controls.HeaderedContentControl)
								{
									num = (short)1070071817;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 9:
								num = (short)544407559;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								switch (0)
								{
								case 0:
									goto IL_148;
								}
								continue;
							case 11:
								goto IL_19E;
							case 12:
								if (menuItem.Header != null)
								{
									num = (short)1169620993;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 13:
								menuItem.Header = global::DevComponents.WpfDock.DockWindowGroup.a(dockWindow.Header);
								menuItem.Icon = global::DevComponents.WpfDock.DockWindowGroup.a(dockWindow.Image);
								num = (short)375586831;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								goto IL_410;
							case 15:
								goto IL_298;
							case 16:
							{
								object obj;
								dockWindow = (obj as global::DevComponents.WpfDock.DockWindow);
								global::System.Windows.Controls.HeaderedContentControl headeredContentControl = obj as global::System.Windows.Controls.HeaderedContentControl;
								menuItem = new global::System.Windows.Controls.MenuItem();
								num = (short)490799110;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 18:
								num = (short)1700659214;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 19:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1404502034;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								object obj = enumerator.Current;
								num = (short)128647176;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_148;
							IL_19E:
							menuItem.Command = global::DevComponents.WpfDock.DockWindow.SelectWindow;
							menuItem.CommandTarget = dockWindow;
							num = (short)1092157457;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_257:
							num = (short)1023803411;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_148:
							goto IL_257;
							IL_298:
							num = (short)614989836;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_410:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_42F;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_41C:
							switch (num4)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)168558594;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_486;
							case 1:
								goto IL_484;
							case 2:
								disposable.Dispose();
								num = (short)998309889;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42F;
						}
						IL_484:
						IL_486:
						break;
						IL_42F:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)253689856;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_41C;
					}
					break;
				}
				}
				break;
			}
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000360A0 File Offset: 0x000342A0
		internal static object a(object A_0)
		{
			short num = (short)1551892483;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0 is string)
					{
						num = (short)499712004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1063911429;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_58;
				case 2:
					return A_0;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 4:
					goto IL_17B;
				case 5:
				{
					num = (short)837156864;
					short num3 = num;
					if (A_0.GetType().IsValueType)
					{
						num = (short)793444354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17D;
				}
				}
				IL_3E:
				if (A_0 == null)
				{
					num = (short)2098200577;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1464729600;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_58:
			num = (short)1747442580;
			short num4 = num;
			num = (short)432462740;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_17B:
				return A_0.ToString();
			default:
				num = (short)36503553;
				if (num != 0)
				{
				}
				num = (short)29753344;
				if (num != 0)
				{
				}
				return null;
			}
			return A_0;
			IL_17D:
			return global::System.Windows.Markup.XamlReader.Load(global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(global::System.Windows.Markup.XamlWriter.Save(A_0))));
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00036240 File Offset: 0x00034440
		private void c(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1009214985;
			short num2 = num;
			num = (short)1565681161;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1739128832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1722351617;
			if (num != 0)
			{
			}
			num = (short)554958848;
			if (num != 0)
			{
			}
			A_1.Handled = true;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000362F4 File Offset: 0x000344F4
		private void b(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)45744133;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Controls.ContextMenu contextMenu;
				global::System.Windows.Controls.ContextMenu contextMenu2;
				switch (num2)
				{
				case 0:
					num = (short)1771044865;
					if (num != 0)
					{
					}
					num = (short)381026308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (contextMenu != null)
					{
						num = (short)686620680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					if (this.SelectedDockWindow.CustomOptionsMenu != null)
					{
						num = (short)1423441931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FF;
				case 3:
					if (this.SelectedDockWindow != null)
					{
						num = (short)1285029894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FF;
				case 4:
					contextMenu2 = this.ab;
					goto IL_237;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 6:
					num = (short)233439234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)343947878;
					short num3 = num;
					num = (short)599210598;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_179;
					default:
						goto IL_1C5;
					}
					break;
				}
				case 8:
					A_1.Handled = true;
					contextMenu.PlacementTarget = this.aa;
					contextMenu.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Bottom;
					contextMenu.IsOpen = true;
					goto IL_179;
				case 9:
					goto IL_1FF;
				case 10:
					contextMenu2 = this.ac;
					goto IL_237;
				case 11:
				{
					num = (short)113967104;
					short num4 = num;
					contextMenu = this.SelectedDockWindow.CustomOptionsMenu;
					num = (short)386138121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_54:
				if (!global::DevComponents.WpfDock.DockSite.GetIsDocument(this))
				{
					num = (short)1387069440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1795162122;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_179:
				num = (short)1394016263;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1FF:
				num = (short)2117074945;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_237:
				contextMenu = contextMenu2;
				num = (short)1059258371;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1C5:
			num = (short)355729408;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00036578 File Offset: 0x00034778
		private void b(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			short num = (short)918683651;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1527639754;
				short num3 = num;
				num = (short)206499530;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1822752768;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						if (!dockSite.IsDockingInProgress)
						{
							num = (short)950468609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						dockSite.a(this, false, global::DevComponents.WpfDock.eEventActionSource.Mouse);
						num = (short)1460731906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return;
					case 3:
						num = (short)1208614913;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CA;
						}
						continue;
					case 4:
						if (!global::DevComponents.WpfDock.i.a(this.s))
						{
							num = (short)647757829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						num = (short)1740898311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					case 7:
						if (!this.x)
						{
							num = (short)2019950604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						num = (short)1827536900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)12976128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						if (dockSite != null)
						{
							num = (short)1944584201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 11:
					{
						num = (short)1011154944;
						short num4 = num;
						if (A_1.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
						{
							num = (short)1968635912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 12:
					{
						this.s = default(global::System.Windows.Point);
						global::DevComponents.WpfDock.DockSite dockSite = this.GetDockSite();
						num = (short)1730281482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_CA:
					if (this.ae)
					{
						num = (short)2051538950;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)180944907;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0003680C File Offset: 0x00034A0C
		public global::DevComponents.WpfDock.DockSite GetDockSite()
		{
			short num = (short)856031233;
			if (num != 0)
			{
			}
			num = (short)1048641536;
			short num2 = num;
			num = (short)201599228;
			short num3 = num;
			num = (short)1909729532;
			switch (num3 == num)
			{
			}
			num = (short)1465778176;
			if (num != 0)
			{
			}
			return this.a(false);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000368BC File Offset: 0x00034ABC
		private global::DevComponents.WpfDock.DockSite a(bool A_0)
		{
			short num = (short)453115907;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.x)
					{
						goto IL_135;
					}
					goto IL_17D;
				case 1:
					num = (short)404488192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_10F;
				case 3:
					num = (short)1896546305;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 4:
				{
					num = (short)1815740416;
					short num3 = num;
					num = (short)266272773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					num = (short)72533912;
					short num4 = num;
					num = (short)173328280;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_135;
					default:
						num = (short)1697841152;
						if (num != 0)
						{
						}
						if (this.af != null)
						{
							num = (short)1170145282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17D;
					}
					break;
				}
				}
				IL_65:
				if (A_0)
				{
					num = (short)1348272129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_17D;
				IL_135:
				num = (short)2104098820;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			return this.af;
			IL_17D:
			return global::DevComponents.WpfDock.DockSite.a(this);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00036A4C File Offset: 0x00034C4C
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00036AF8 File Offset: 0x00034CF8
		internal global::DevComponents.WpfDock.DockSite OwnerSite
		{
			get
			{
				short num = (short)1321061674;
				short num2 = num;
				num = (short)1549585706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1636499456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)711327744;
				if (num != 0)
				{
				}
				num = (short)1025114113;
				if (num != 0)
				{
				}
				return this.af;
			}
			set
			{
				short num = (short)77991149;
				short num2 = num;
				num = (short)560598253;
				switch (num2 == num)
				{
				default:
				{
					num = (short)397410304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1787887616;
				if (num != 0)
				{
				}
				num = (short)613548033;
				if (num != 0)
				{
				}
				this.af = value;
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00036BA8 File Offset: 0x00034DA8
		private void a(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			short num = (short)2049966083;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1200319612;
				short num3 = num;
				num = (short)1552313468;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)1741815808;
					if (num != 0)
					{
					}
					global::DevComponents.WpfDock.DockSite dockSite;
					switch (num2)
					{
					case 0:
						if (!this.x)
						{
							num = (short)1855455233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						global::System.Windows.Point position = A_1.GetPosition(this);
						num = (short)584318983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					case 4:
					{
						global::System.Windows.Point position;
						if (global::System.Math.Abs(position.Y - this.s.Y) >= 4.0)
						{
							num = (short)393805829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 5:
						goto IL_F5;
					case 6:
					{
						num = (short)27656193;
						if (num != 0)
						{
						}
						num = (short)477036544;
						short num4 = num;
						num = (short)361562123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::System.Windows.Point position;
						if (global::System.Math.Abs(position.X - this.s.X) < 4.0)
						{
							num = (short)1678049292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F5;
					}
					case 8:
						num = (short)1370619904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						dockSite.a(this, false, global::DevComponents.WpfDock.eEventActionSource.Mouse);
						num = (short)162267138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (dockSite != null)
						{
							num = (short)305922057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						if (!global::DevComponents.WpfDock.i.a(this.s))
						{
							num = (short)1476526088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						num = (short)605159428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A4:
					if (A_1.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
					{
						num = (short)714801158;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					return;
					IL_F5:
					this.s = default(global::System.Windows.Point);
					dockSite = this.GetDockSite();
					num = (short)549060618;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00036E80 File Offset: 0x00035080
		private void a(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)996343810;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1B4;
				case 1:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						global::DevComponents.WpfDock.DockSite dockSite;
						for (;;)
						{
							IL_69:
							switch (num2)
							{
							case 0:
								if (dockSite != null)
								{
									num = (short)457048068;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_105;
							case 1:
								dockSite.Focus();
								goto IL_EC;
							case 2:
								goto IL_1A7;
							case 3:
								if (dockSite != null)
								{
									num = (short)780992513;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_145;
							case 4:
								dockSite.FloatWindow(this);
								num = (short)69140486;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_145;
							case 6:
								goto IL_105;
							}
							goto IL_8B;
							IL_EC:
							num = (short)714735621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_145:
							num = (short)298076219;
							short num3 = num;
							num = (short)1692420155;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_EC;
							default:
								num = (short)1109590016;
								if (num != 0)
								{
								}
								num = (short)101515266;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_105:
							this.s = default(global::System.Windows.Point);
							num = (short)463273987;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1A7:
						return;
						IL_8B:
						this.ae = true;
						dockSite = this.GetDockSite();
						num = (short)1278672896;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_69;
					}
					finally
					{
						this.ae = false;
					}
					goto IL_1B4;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 3:
					return;
				case 4:
					if (!A_1.Handled)
					{
						num = (short)1188888577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_218;
				}
				IL_39:
				if (A_1.ClickCount == 2)
				{
					num = (short)1080688640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_218;
				IL_1B4:
				num = (short)1781792769;
				if (num != 0)
				{
				}
				num = (short)846331908;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_218:
				num = (short)1070530560;
				short num4 = num;
				this.s = A_1.GetPosition(this);
				num = (short)2114191363;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00037114 File Offset: 0x00035314
		internal void e()
		{
			short num = (short)518552542;
			short num2 = num;
			num = (short)761166814;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1968832512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1918500865;
			if (num != 0)
			{
			}
			num = (short)854261760;
			if (num != 0)
			{
			}
			this.g();
			this.f();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000371C8 File Offset: 0x000353C8
		internal void f()
		{
			short num = (short)1083179012;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.Controls.HeaderedContentControl headeredContentControl;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1ED;
				case 1:
				{
					num = (short)1463746560;
					short num3 = num;
					global::System.Windows.Controls.ContentPresenter contentPresenter;
					contentPresenter.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Stretch;
					contentPresenter.VerticalAlignment = global::System.Windows.VerticalAlignment.Stretch;
					goto IL_143;
				}
				case 2:
				{
					global::System.Windows.Controls.ContentPresenter contentPresenter;
					if (contentPresenter != null)
					{
						num = (short)419364865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1ED;
				}
				case 3:
					if (headeredContentControl != null)
					{
						num = (short)2002976776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				case 5:
					return;
				case 6:
					num = (short)1256914955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)1929562482;
					short num4 = num;
					num = (short)76007794;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_143;
					default:
						num = (short)934608896;
						if (num != 0)
						{
						}
						num = (short)1148911629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
				{
					this.SelectedDockWindow = (headeredContentControl as global::DevComponents.WpfDock.DockWindow);
					this.SelectedContent = headeredContentControl.Content;
					global::System.Windows.Controls.ContentPresenter contentPresenter = this.h();
					num = (short)541261826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (headeredContentControl.ContentTemplate == null)
					{
						num = (short)1557659654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16E;
				case 10:
					goto IL_109;
				case 11:
					if (headeredContentControl.ContentTemplateSelector != null)
					{
						num = (short)1868103690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.SelectedContentTemplate = this.ContentTemplate;
					this.SelectedContentTemplateSelector = this.ContentTemplateSelector;
					num = (short)801374213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_1C0;
				case 13:
					if (!this.x)
					{
						num = (short)1074003980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_5E:
				if (base.SelectedIndex < 0)
				{
					num = (short)1085014023;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				headeredContentControl = this.b();
				num = (short)1055916035;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_143:
				num = (short)752549888;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1ED:
				num = (short)414646281;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_109:
			IL_16E:
			this.SelectedContentTemplate = headeredContentControl.ContentTemplate;
			this.SelectedContentTemplateSelector = headeredContentControl.ContentTemplateSelector;
			return;
			IL_1C0:
			num = (short)2118516737;
			if (num != 0)
			{
			}
			this.SelectedContent = null;
			this.SelectedDockWindow = null;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000374D0 File Offset: 0x000356D0
		internal void g()
		{
			short num = (short)410845186;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Controls.HeaderedContentControl headeredContentControl;
				switch (num2)
				{
				case 0:
				{
					num = (short)2050293760;
					short num3 = num;
					num = (short)94893186;
					short num4 = num;
					num = (short)300086402;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AC;
					default:
						num = (short)670892032;
						if (num != 0)
						{
						}
						this.SelectedContentHeader = this.b(headeredContentControl.Header);
						num = (short)172818436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (!this.x)
					{
						num = (short)1630994438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)1808269313;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					continue;
				case 3:
					if (headeredContentControl != null)
					{
						goto IL_AC;
					}
					return;
				case 4:
					return;
				case 5:
					num = (short)501153793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_12B;
				}
				IL_69:
				if (base.SelectedIndex < 0)
				{
					num = (short)351862789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				headeredContentControl = this.b();
				num = (short)319029251;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AC:
				num = (short)1875247104;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12B:
			this.SelectedContentHeader = null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00037684 File Offset: 0x00035884
		internal object b(object A_0)
		{
			short num = (short)657326082;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_4B;
				case 1:
					if (A_0 is string)
					{
						num = (short)959184899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					goto IL_84;
				}
				IL_34:
				if (A_0 == null)
				{
					num = (short)376897536;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)312999937;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_4B:
			return null;
			IL_4D:
			return A_0.ToString();
			IL_84:
			num = (short)246677505;
			if (num != 0)
			{
			}
			goto IL_4D;
			IL_AE:
			num = (short)986742018;
			short num3 = num;
			num = (short)1442741506;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_4D;
			case 1:
				break;
			default:
			{
				num = (short)723648512;
				short num4 = num;
				break;
			}
			}
			num = (short)940244992;
			if (num != 0)
			{
			}
			return global::System.Windows.Markup.XamlReader.Load(global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(global::System.Windows.Markup.XamlWriter.Save(A_0))));
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000377CC File Offset: 0x000359CC
		internal global::System.Windows.Controls.ContentPresenter h()
		{
			int a_ = 6;
			short num = (short)1671761398;
			short num2 = num;
			num = (short)530517494;
			switch (num2 == num)
			{
			}
			num = (short)22872065;
			if (num != 0)
			{
			}
			num = (short)56950784;
			if (num != 0)
			{
			}
			num = (short)215810048;
			short num3 = num;
			return base.GetTemplateChild(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("闄蛆鯈鿊鋌鯎냐뇒雔룖럘꿚룜뇞闠ꯢ諤铦鷨", a_)) as global::System.Windows.Controls.ContentPresenter;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00037898 File Offset: 0x00035A98
		protected override void OnInitialized(global::System.EventArgs e)
		{
			int a_ = 15;
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
					property.SetValue(this, false, null);
					num2 = (short)1858994178;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_D3;
				case 2:
					goto IL_141;
				}
				goto IL_25;
			}
			IL_141:
			goto IL_143;
			IL_25:
			num2 = (short)331360614;
			short num3 = num2;
			num2 = (short)1956981094;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D3:
				num2 = (short)1907556353;
				if (num2 != 0)
				{
				}
				if (property != null)
				{
					num2 = (short)74973184;
					num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				goto IL_143;
			case 1:
				break;
			default:
			{
				num2 = (short)1029767168;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)612564992;
			if (num2 != 0)
			{
			}
			base.OnInitialized(e);
			property = base.GetType().GetProperty(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("跍뇏병蟓돕듗뿙뿛ꫝ귟韡裣鋥臧髩胫语", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
			num2 = (short)1070071809;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
			IL_143:
			base.ItemContainerGenerator.StatusChanged += this.a;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00037A00 File Offset: 0x00035C00
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)947060739;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (base.HasItems)
					{
						num = (short)301400071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19D;
				case 1:
				{
					num = (short)909908415;
					short num3 = num;
					num = (short)1477843391;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13F;
					default:
						num = (short)2065629184;
						if (num != 0)
						{
						}
						base.SelectedIndex = 0;
						num = (short)571604997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 4:
					goto IL_13F;
				case 5:
				{
					num = (short)1294401536;
					short num4 = num;
					goto IL_19D;
				}
				case 6:
					num = (short)669581312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)2101805060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_44:
				num = (short)516030465;
				if (num != 0)
				{
				}
				if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
				{
					num = (short)1668218886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_13F:
				if (base.SelectedIndex < 0)
				{
					num = (short)424935425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_19D:
				this.e();
				this.UpdateTabVisibility();
				num = (short)1120534530;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00037BD0 File Offset: 0x00035DD0
		protected override void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			short num = (short)565178953;
			short num2 = num;
			num = (short)536212041;
			switch (num2 == num)
			{
			}
			num = (short)2071396353;
			if (num != 0)
			{
			}
			num = (short)2005860352;
			if (num != 0)
			{
			}
			num = (short)1179648000;
			short num3 = num;
			base.OnSelectionChanged(e);
			this.e();
			this.a();
			this.i();
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00037C94 File Offset: 0x00035E94
		internal void i()
		{
			short num = (short)1150550016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9E;
				}
				bool flag;
				for (;;)
				{
					IL_27:
					global::System.Windows.Visibility visibility;
					global::System.Windows.Visibility visibility2;
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						num = (short)764805127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.SelectedDockWindow != null)
						{
							num = (short)273547264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0;
					case 2:
						visibility = global::System.Windows.Visibility.Collapsed;
						goto IL_27A;
					case 3:
						visibility = global::System.Windows.Visibility.Visible;
						goto IL_27A;
					case 4:
						if (this.OptionsMenu != visibility2)
						{
							num = (short)1012596753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						if (this.SelectedDockWindow != null)
						{
							num = (short)837025810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D4;
					case 6:
						this.CanClose = flag;
						num = (short)2025193498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!this.SelectedDockWindow.OptionsMenu)
						{
							num = (short)1085079562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2112684035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_191;
					case 9:
					{
						this.IsAutoHide = flag2;
						num = (short)272142092;
						short num3 = num;
						num = (short)1715375884;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_172;
						default:
							num = (short)748552192;
							if (num != 0)
							{
							}
							num = (short)652804110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						goto IL_172;
					case 11:
						flag = this.SelectedDockWindow.CanClose;
						num = (short)1306001416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_387;
					case 13:
						num = (short)1313931265;
						if (num != 0)
						{
						}
						goto IL_E0;
					case 14:
						goto IL_215;
					case 15:
						if (this.CanAutoHide != flag3)
						{
							num = (short)586481689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C8;
					case 16:
						if (this.SelectedDockWindow != null)
						{
							num = (short)1237843968;
							short num4 = num;
							num = (short)1886322708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_387;
					case 17:
						this.OptionsMenu = visibility2;
						num = (short)830275608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						flag3 = this.SelectedDockWindow.CanAutoHide;
						num = (short)1569325075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_1D4;
					case 20:
						flag2 = this.SelectedDockWindow.IsAutoHide;
						num = (short)241893388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (this.CanClose != flag)
						{
							num = (short)541786118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_344;
					case 22:
						goto IL_3C8;
					case 23:
						if (this.SelectedDockWindow != null)
						{
							num = (short)2052194315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191;
					case 24:
						return;
					case 25:
						this.CanAutoHide = flag3;
						num = (short)745537558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_344;
					case 27:
						if (this.IsAutoHide != flag2)
						{
							num = (short)1392377865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_215;
					}
					goto IL_9E;
					IL_E0:
					num = (short)699662340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_172:
					num = (short)993525762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_191:
					num = (short)164757525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D4:
					num = (short)2059468815;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_215:
					visibility2 = global::System.Windows.Visibility.Visible;
					num = (short)1133051905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27A:
					visibility2 = visibility;
					num = (short)952107021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_344:
					flag3 = false;
					num = (short)2043740165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_387:
					num = (short)576192539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C8:
					flag2 = false;
					num = (short)1741684752;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_9E:
				flag = false;
				num = (short)1173291031;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001EF RID: 495 RVA: 0x00038194 File Offset: 0x00036394
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00038250 File Offset: 0x00036450
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::DevComponents.WpfDock.DockWindow SelectedDockWindow
		{
			get
			{
				short num = (short)1997908606;
				short num2 = num;
				num = (short)1377020542;
				switch (num2 == num)
				{
				}
				num = (short)1254293505;
				if (num != 0)
				{
				}
				num = (short)522125312;
				if (num != 0)
				{
				}
				num = (short)1324875776;
				short num3 = num;
				return (global::DevComponents.WpfDock.DockWindow)base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.SelectedDockWindowProperty);
			}
			internal set
			{
				short num = (short)1664261127;
				short num2 = num;
				num = (short)1801559047;
				switch (num2 == num)
				{
				}
				num = (short)1070792704;
				if (num != 0)
				{
				}
				num = (short)2077032449;
				if (num != 0)
				{
				}
				num = (short)1590820864;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.b, value);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00038304 File Offset: 0x00036504
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x000383BC File Offset: 0x000365BC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object SelectedContent
		{
			get
			{
				short num = (short)805585290;
				short num2 = num;
				num = (short)569590154;
				switch (num2 == num)
				{
				}
				num = (short)367460353;
				if (num != 0)
				{
				}
				num = (short)389480448;
				if (num != 0)
				{
				}
				num = (short)1792933888;
				short num3 = num;
				return base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.SelectedContentProperty);
			}
			internal set
			{
				short num = (short)2070845156;
				short num2 = num;
				num = (short)592942820;
				switch (num2 == num)
				{
				}
				num = (short)217120768;
				if (num != 0)
				{
				}
				num = (short)26017793;
				if (num != 0)
				{
				}
				num = (short)735707136;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.a, value);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00038474 File Offset: 0x00036674
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x0003852C File Offset: 0x0003672C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.DataTemplate SelectedContentTemplate
		{
			get
			{
				short num = (short)1235124073;
				short num2 = num;
				num = (short)131497833;
				switch (num2 == num)
				{
				}
				num = (short)1352990720;
				if (num != 0)
				{
				}
				num = (short)1577254913;
				if (num != 0)
				{
				}
				num = (short)330694656;
				short num3 = num;
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.SelectedContentTemplateProperty);
			}
			internal set
			{
				short num = (short)20250625;
				if (num != 0)
				{
				}
				num = (short)1401036729;
				short num2 = num;
				num = (short)1576476601;
				switch (num2 == num)
				{
				}
				num = (short)1955135488;
				if (num != 0)
				{
				}
				num = (short)989986816;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.c, value);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000385E0 File Offset: 0x000367E0
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x0003869C File Offset: 0x0003689C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Controls.DataTemplateSelector SelectedContentTemplateSelector
		{
			get
			{
				short num = (short)812324408;
				short num2 = num;
				num = (short)1886197304;
				switch (num2 == num)
				{
				}
				num = (short)353042433;
				if (num != 0)
				{
				}
				num = (short)1364197376;
				if (num != 0)
				{
				}
				num = (short)853671936;
				short num3 = num;
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.SelectedContentTemplateSelectorProperty);
			}
			internal set
			{
				short num = (short)31347189;
				short num2 = num;
				num = (short)2092650997;
				switch (num2 == num)
				{
				}
				num = (short)1974009857;
				if (num != 0)
				{
				}
				num = (short)1477050368;
				if (num != 0)
				{
				}
				num = (short)1138491392;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.d, value);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00038750 File Offset: 0x00036950
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00038804 File Offset: 0x00036A04
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object SelectedContentHeader
		{
			get
			{
				short num = (short)313916742;
				short num2 = num;
				num = (short)404356422;
				switch (num2 == num)
				{
				}
				num = (short)988151809;
				if (num != 0)
				{
				}
				num = (short)836370432;
				if (num != 0)
				{
				}
				num = (short)746717184;
				short num3 = num;
				return base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.SelectedContentHeaderProperty);
			}
			internal set
			{
				short num = (short)84608176;
				short num2 = num;
				num = (short)435225776;
				switch (num2 == num)
				{
				}
				num = (short)1681129472;
				if (num != 0)
				{
				}
				num = (short)474939393;
				if (num != 0)
				{
				}
				num = (short)2030239744;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.SelectedContentHeaderProperty, value);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000388B8 File Offset: 0x00036AB8
		// (set) Token: 0x060001FA RID: 506 RVA: 0x00038970 File Offset: 0x00036B70
		public global::System.Windows.DataTemplate ContentTemplate
		{
			get
			{
				short num = (short)2113601537;
				if (num != 0)
				{
				}
				num = (short)1854670171;
				short num2 = num;
				num = (short)1358300507;
				switch (num2 == num)
				{
				}
				num = (short)613089280;
				if (num != 0)
				{
				}
				num = (short)1500512256;
				short num3 = num;
				return (global::System.Windows.DataTemplate)base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.ContentTemplateProperty);
			}
			set
			{
				short num = (short)2034363145;
				short num2 = num;
				num = (short)1046342409;
				switch (num2 == num)
				{
				}
				num = (short)63832064;
				if (num != 0)
				{
				}
				num = (short)1698627585;
				if (num != 0)
				{
				}
				num = (short)1574830080;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.ContentTemplateProperty, value);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00038A28 File Offset: 0x00036C28
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00038AE4 File Offset: 0x00036CE4
		public global::System.Windows.Controls.DataTemplateSelector ContentTemplateSelector
		{
			get
			{
				short num = (short)1336130760;
				short num2 = num;
				num = (short)67812552;
				switch (num2 == num)
				{
				}
				num = (short)1554382849;
				if (num != 0)
				{
				}
				num = (short)1735393280;
				if (num != 0)
				{
				}
				num = (short)1142226944;
				short num3 = num;
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.ContentTemplateSelectorProperty);
			}
			set
			{
				short num = (short)915573029;
				short num2 = num;
				num = (short)1629391141;
				switch (num2 == num)
				{
				}
				num = (short)1503985665;
				if (num != 0)
				{
				}
				num = (short)415629312;
				if (num != 0)
				{
				}
				num = (short)1828978688;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.ContentTemplateSelectorProperty, value);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00038B9C File Offset: 0x00036D9C
		private global::System.Windows.Controls.HeaderedContentControl b()
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::System.Windows.Controls.HeaderedContentControl headeredContentControl;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (base.SelectedItem != null)
					{
						goto IL_114;
					}
					return headeredContentControl;
				case 1:
				{
					num2 = (short)155953850;
					short num3 = num2;
					num2 = (short)1165470394;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_114;
					default:
					{
						num2 = (short)1006370816;
						if (num2 != 0)
						{
						}
						headeredContentControl = (base.ItemContainerGenerator.ContainerFromItem(base.SelectedItem) as global::System.Windows.Controls.HeaderedContentControl);
						num2 = (short)2049441792;
						short num4 = num2;
						num2 = (short)786300931;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (headeredContentControl == null)
					{
						num2 = (short)1754595333;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return headeredContentControl;
				case 3:
					return headeredContentControl;
				case 4:
					num2 = (short)506265600;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)650969094;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (base.ItemsSource != null)
					{
						num2 = (short)906166276;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return headeredContentControl;
				}
				goto IL_2C;
				IL_114:
				num2 = (short)403374081;
				num = (int)((global::System.IntPtr)num2);
			}
			return headeredContentControl;
			IL_2C:
			headeredContentControl = (base.SelectedItem as global::System.Windows.Controls.HeaderedContentControl);
			num2 = (short)395837441;
			if (num2 != 0)
			{
			}
			num2 = (short)1286864898;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00038D60 File Offset: 0x00036F60
		internal bool CanFloat
		{
			get
			{
				short num = (short)1232535553;
				if (num != 0)
				{
				}
				if (base.SelectedItem is global::DevComponents.WpfDock.DockWindow)
				{
					num = (short)1165994086;
					short num2 = num;
					num = (short)732276838;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)909443072;
						if (num != 0)
						{
						}
						num = (short)350617600;
						short num3 = num;
						break;
					}
					}
					return ((global::DevComponents.WpfDock.DockWindow)base.SelectedItem).CanFloat;
				}
				return true;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00038E2C File Offset: 0x0003702C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool CanDockTop
		{
			get
			{
				if (base.SelectedItem is global::DevComponents.WpfDock.DockWindow)
				{
					short num = (short)175028120;
					short num2 = num;
					num = (short)257537944;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2098593792;
						if (num != 0)
						{
						}
						num = (short)471007233;
						if (num != 0)
						{
						}
						num = (short)1321992192;
						short num3 = num;
						break;
					}
					}
					return ((global::DevComponents.WpfDock.DockWindow)base.SelectedItem).CanDockTop;
				}
				return true;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00038EFC File Offset: 0x000370FC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public bool CanDockBottom
		{
			get
			{
				short num;
				if (base.SelectedItem is global::DevComponents.WpfDock.DockWindow)
				{
					num = (short)120153303;
					short num2 = num;
					num = (short)1756914903;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)338296832;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)682885120;
					short num3 = num;
					return ((global::DevComponents.WpfDock.DockWindow)base.SelectedItem).CanDockBottom;
				}
				num = (short)1060700161;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00038FC8 File Offset: 0x000371C8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool CanDockLeft
		{
			get
			{
				if (base.SelectedItem is global::DevComponents.WpfDock.DockWindow)
				{
					short num = (short)1759838209;
					if (num != 0)
					{
					}
					num = (short)766791679;
					short num2 = num;
					num = (short)663441407;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)65536;
						if (num != 0)
						{
						}
						num = (short)1546059776;
						short num3 = num;
						break;
					}
					}
					return ((global::DevComponents.WpfDock.DockWindow)base.SelectedItem).CanDockLeft;
				}
				return true;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0003909C File Offset: 0x0003729C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public bool CanDockRight
		{
			get
			{
				if (base.SelectedItem is global::DevComponents.WpfDock.DockWindow)
				{
					short num = (short)448810474;
					short num2 = num;
					num = (short)1504398826;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1287782400;
						if (num != 0)
						{
						}
						num = (short)726925313;
						if (num != 0)
						{
						}
						num = (short)16646144;
						short num3 = num;
						break;
					}
					}
					return ((global::DevComponents.WpfDock.DockWindow)base.SelectedItem).CanDockRight;
				}
				return true;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00039168 File Offset: 0x00037368
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool CanDockAsDocument
		{
			get
			{
				if (base.SelectedItem is global::DevComponents.WpfDock.DockWindow)
				{
					short num = (short)887178595;
					short num2 = num;
					num = (short)940655971;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1301938177;
						if (num != 0)
						{
						}
						num = (short)855179264;
						if (num != 0)
						{
						}
						num = (short)322240512;
						short num3 = num;
						break;
					}
					}
					return ((global::DevComponents.WpfDock.DockWindow)base.SelectedItem).CanDockAsDocument;
				}
				return true;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00039238 File Offset: 0x00037438
		// (set) Token: 0x06000205 RID: 517 RVA: 0x0003932C File Offset: 0x0003752C
		internal global::System.Windows.Rect FloatingRect
		{
			get
			{
				if (base.SelectedItem is global::DevComponents.WpfDock.DockWindow)
				{
					short num = (short)1769621221;
					short num2 = num;
					num = (short)1480672997;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2071134209;
						if (num != 0)
						{
						}
						num = (short)229572608;
						if (num != 0)
						{
						}
						num = (short)838205440;
						short num3 = num;
						break;
					}
					}
					return ((global::DevComponents.WpfDock.DockWindow)base.SelectedItem).FloatingRect;
				}
				return new global::System.Windows.Rect(100.0, 100.0, 150.0, 200.0);
			}
			set
			{
				short num = (short)1359413249;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_54;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						goto IL_A6;
					}
					IL_31:
					if (base.SelectedItem is global::DevComponents.WpfDock.DockWindow)
					{
						num = (short)479657984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A6;
					IL_54:
					((global::DevComponents.WpfDock.DockWindow)base.SelectedItem).FloatingRect = value;
					num = (short)1758134272;
					short num3 = num;
					num = (short)930349058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A6:
					num = (short)954541379;
					short num4 = num;
					num = (short)1494820163;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_54;
					default:
						goto IL_DB;
					}
				}
				IL_DB:
				num = (short)1732640768;
				if (num != 0)
				{
				}
				num = (short)1542782977;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00039454 File Offset: 0x00037654
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00039514 File Offset: 0x00037714
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsFloating
		{
			get
			{
				short num = (short)30408705;
				if (num != 0)
				{
				}
				num = (short)1450769409;
				short num2 = num;
				num = (short)676068353;
				switch (num2 == num)
				{
				}
				num = (short)1800339456;
				if (num != 0)
				{
				}
				num = (short)1845035008;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.IsFloatingProperty);
			}
			internal set
			{
				short num = (short)72382101;
				short num2 = num;
				num = (short)2072213141;
				switch (num2 == num)
				{
				}
				num = (short)1185087488;
				if (num != 0)
				{
				}
				num = (short)945684481;
				if (num != 0)
				{
				}
				num = (short)1229193216;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.e, value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000208 RID: 520 RVA: 0x000395D0 File Offset: 0x000377D0
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00039688 File Offset: 0x00037888
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Visibility TabVisibility
		{
			get
			{
				short num = (short)1553332530;
				short num2 = num;
				num = (short)564328754;
				switch (num2 == num)
				{
				}
				num = (short)1819148289;
				if (num != 0)
				{
				}
				num = (short)1329463296;
				if (num != 0)
				{
				}
				num = (short)269156352;
				short num3 = num;
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.TabVisibilityProperty);
			}
			internal set
			{
				short num = (short)2078081025;
				if (num != 0)
				{
				}
				num = (short)1934109198;
				short num2 = num;
				num = (short)2117282318;
				switch (num2 == num)
				{
				}
				num = (short)2122383360;
				if (num != 0)
				{
				}
				num = (short)520880128;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.f, value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00039740 File Offset: 0x00037940
		// (set) Token: 0x0600020B RID: 523 RVA: 0x000397F8 File Offset: 0x000379F8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool CanClose
		{
			get
			{
				short num = (short)73200049;
				short num2 = num;
				num = (short)276558257;
				switch (num2 == num)
				{
				}
				num = (short)1395261440;
				if (num != 0)
				{
				}
				num = (short)599654401;
				if (num != 0)
				{
				}
				num = (short)1224867840;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.CanCloseProperty);
			}
			internal set
			{
				short num = (short)1083431156;
				short num2 = num;
				num = (short)1644026100;
				switch (num2 == num)
				{
				}
				num = (short)1508638721;
				if (num != 0)
				{
				}
				num = (short)273154048;
				if (num != 0)
				{
				}
				num = (short)1136918528;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.g, value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000398B4 File Offset: 0x00037AB4
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0003996C File Offset: 0x00037B6C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool CanAutoHide
		{
			get
			{
				short num = (short)1042109665;
				short num2 = num;
				num = (short)189093089;
				switch (num2 == num)
				{
				}
				num = (short)854458368;
				short num3 = num;
				num = (short)1235025920;
				if (num != 0)
				{
				}
				num = (short)736034817;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.CanAutoHideProperty);
			}
			internal set
			{
				short num = (short)635653844;
				short num2 = num;
				num = (short)223760084;
				switch (num2 == num)
				{
				}
				num = (short)184090624;
				short num3 = num;
				num = (short)508690433;
				if (num != 0)
				{
				}
				num = (short)2063204352;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.h, value);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00039A24 File Offset: 0x00037C24
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00039ADC File Offset: 0x00037CDC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsAutoHide
		{
			get
			{
				short num = (short)1865317757;
				short num2 = num;
				num = (short)304381309;
				switch (num2 == num)
				{
				}
				num = (short)382992384;
				short num3 = num;
				num = (short)322764801;
				if (num != 0)
				{
				}
				num = (short)346816512;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.IsAutoHideProperty);
			}
			internal set
			{
				short num = (short)1466814232;
				short num2 = num;
				num = (short)334810904;
				switch (num2 == num)
				{
				}
				num = (short)156106752;
				short num3 = num;
				num = (short)948764672;
				if (num != 0)
				{
				}
				num = (short)339410945;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.i, value);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00039B98 File Offset: 0x00037D98
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00039C50 File Offset: 0x00037E50
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Visibility OptionsMenu
		{
			get
			{
				short num = (short)2106729490;
				short num2 = num;
				num = (short)382936082;
				switch (num2 == num)
				{
				}
				num = (short)1991114752;
				short num3 = num;
				num = (short)1839661057;
				if (num != 0)
				{
				}
				num = (short)544669696;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfDock.DockWindowGroup.OptionsMenuProperty);
			}
			internal set
			{
				short num = (short)199950337;
				if (num != 0)
				{
				}
				num = (short)1729651863;
				short num2 = num;
				num = (short)1110336663;
				switch (num2 == num)
				{
				default:
				{
					num = (short)588054528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1351745536;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindowGroup.j, value);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00039D0C File Offset: 0x00037F0C
		internal int VisibleItemsCount
		{
			get
			{
				short num = (short)1201078272;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					int num3 = 0;
					global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
					try
					{
						num = (short)990314501;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Windows.FrameworkElement frameworkElement;
								if (frameworkElement.Visibility == global::System.Windows.Visibility.Visible)
								{
									num = (short)1655504898;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2018770950;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object item = enumerator.Current;
								global::System.Windows.FrameworkElement frameworkElement = base.ItemContainerGenerator.ContainerFromItem(item) as global::System.Windows.FrameworkElement;
								num = (short)353304584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								num3++;
								num = (short)1890189319;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)529268736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_172;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_78;
								}
								continue;
							case 6:
								num = (short)991428612;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								global::System.Windows.FrameworkElement frameworkElement;
								if (frameworkElement != null)
								{
									num = (short)670892035;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_C2:
							num = (short)1594163201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_78:
							goto IL_C2;
						}
						IL_172:;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1BB;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_181:
							num = (short)233177089;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								goto IL_264;
							case 1:
								goto IL_242;
							case 2:
							{
								num = (short)1929476689;
								short num4 = num;
								num = (short)995261009;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_242;
								default:
									num = (short)1264582656;
									if (num != 0)
									{
									}
									if (disposable != null)
									{
										num = (short)1015152641;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_266;
								}
								break;
							}
							}
							goto IL_1BB;
							IL_242:
							disposable.Dispose();
							num = (short)1803157504;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_264:
						IL_266:
						goto EndFinally_7;
						IL_1BB:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)767623170;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_181;
						EndFinally_7:;
					}
					num = (short)514981888;
					short num5 = num;
					return num3;
				}
				}
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00039FC8 File Offset: 0x000381C8
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			short num = (short)1716125696;
			short num2 = num;
			num = (short)897489418;
			short num3 = num;
			num = (short)1372625418;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A2:
				num = (short)706215940;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1421606912;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9A;
				}
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					return;
				case 1:
					num = (short)1354301441;
					if (num != 0)
					{
					}
					((global::DevComponents.WpfDock.DockWindow)element).a(this);
					num = (short)998309888;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1174863875;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (element is global::DevComponents.WpfDock.DockWindow)
					{
						num = (short)1199112193;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					if (element != item)
					{
						num = (short)1514471426;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_9A;
			}
			return;
			IL_9A:
			base.PrepareContainerForItemOverride(element, item);
			goto IL_A2;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0003A134 File Offset: 0x00038334
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)897253376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1575747584;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					global::System.Collections.IEnumerator enumerator;
					global::DevComponents.WpfDock.DockSite dockSite;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 1:
						num = (short)353370116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)1871773700;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::DevComponents.WpfDock.DockWindow dockWindow2;
								switch (num2)
								{
								case 0:
									if (flag)
									{
										num = (short)1525612546;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_972;
								case 1:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									if (dockWindow != null)
									{
										num = (short)1222049803;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									base.AddLogicalChild(dockWindow2);
									num = (short)1082130440;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_81F;
									}
									continue;
								case 5:
								{
									if (dockWindow2 != null)
									{
										num = (short)1227096074;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj;
									global::DevComponents.WpfDock.DockWindow dockWindow = base.ItemContainerGenerator.ContainerFromItem(obj) as global::DevComponents.WpfDock.DockWindow;
									num = (short)1791819777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)242155527;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj = enumerator.Current;
									dockWindow2 = (obj as global::DevComponents.WpfDock.DockWindow);
									num = (short)1284964357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1415118857;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_972;
								case 9:
									goto IL_9AF;
								case 10:
									num = (short)271187968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow;
									dockWindow.m();
									num = (short)159055884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_862:
								num = (short)912457734;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_81F:
								goto IL_862;
								IL_972:
								dockWindow2.m();
								num = (short)669908995;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_9AF:
							goto IL_663;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_9D1;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_9BE:
								switch (num2)
								{
								case 0:
									goto IL_A27;
								case 1:
									disposable.Dispose();
									num = (short)2097283072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)1422655489;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A29;
								}
								goto IL_9D1;
							}
							IL_A27:
							IL_A29:
							goto EndFinally_38;
							IL_9D1:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1380712450;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_9BE;
							EndFinally_38:;
						}
						goto IL_A2A;
					case 3:
						num = (short)1721565201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (base.Items.Count > 0)
						{
							num = (short)377552899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_734;
					case 5:
						try
						{
							num = (short)1311571969;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_221;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_171;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)72548360;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj2 = enumerator.Current;
									num = (short)2126315527;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1823932425;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									object obj2;
									base.SelectedItem = obj2;
									num = (short)1748631557;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_28A;
								case 6:
									goto IL_2E5;
								case 7:
								{
									object obj2;
									if (obj2 is global::System.Windows.UIElement)
									{
										num = (short)1514668035;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									base.SelectedItem = obj2;
									num = (short)88604672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1611005958;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									num = (short)296210212;
									short num3 = num;
									num = (short)1255132964;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_221;
									default:
									{
										num = (short)1380384768;
										if (num != 0)
										{
										}
										object obj2;
										if ((obj2 as global::System.Windows.UIElement).Visibility == global::System.Windows.Visibility.Visible)
										{
											num = (short)1471086596;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								}
								IL_28F:
								num = (short)587202562;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_171:
								goto IL_28F;
							}
							IL_221:
							IL_28A:
							IL_2E5:
							goto IL_734;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_307;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2F4:
								switch (num2)
								{
								case 0:
									goto IL_35D;
								case 1:
									disposable.Dispose();
									num = (short)1515782144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (disposable != null)
									{
										num = (short)820641793;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_35F;
								}
								goto IL_307;
							}
							IL_35D:
							IL_35F:
							goto EndFinally_37;
							IL_307:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1236598786;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2F4;
							EndFinally_37:;
						}
						goto Block_4;
					case 6:
						if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
						{
							num = (short)191627274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_663;
					case 7:
						try
						{
							num = (short)564658186;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::DevComponents.WpfDock.DockWindow dockWindow4;
								switch (num2)
								{
								case 1:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow3;
									if (dockWindow3 != null)
									{
										num = (short)2141978632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (dockWindow4 != null)
									{
										num = (short)429326343;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj3;
									global::DevComponents.WpfDock.DockWindow dockWindow3 = base.ItemContainerGenerator.ContainerFromItem(obj3) as global::DevComponents.WpfDock.DockWindow;
									num = (short)2023948289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_BF0;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)12517385;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj3 = enumerator.Current;
									dockWindow4 = (obj3 as global::DevComponents.WpfDock.DockWindow);
									num = (short)942866434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									base.AddLogicalChild(dockWindow4);
									num = (short)1724841987;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (flag)
									{
										num = (short)2015166469;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BF0;
								case 7:
									num = (short)1084358662;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::DevComponents.WpfDock.DockWindow dockWindow3;
									dockWindow3.m();
									num = (short)423821323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)256638988;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_AD7;
									}
									continue;
								case 12:
									goto IL_C68;
								}
								goto IL_AD7;
								IL_BF0:
								dockWindow4.m();
								num = (short)556990464;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C11:
								num = (short)849281028;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AD7:
								goto IL_C11;
							}
							IL_C68:
							goto IL_B7;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_C8A;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_C77:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1139998722;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)1144455168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_CE2;
								case 2:
									goto IL_CE0;
								}
								goto IL_C8A;
							}
							IL_CE0:
							IL_CE2:
							goto EndFinally_36;
							IL_C8A:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1785987073;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_C77;
							EndFinally_36:;
						}
						goto IL_CE3;
					case 8:
						goto IL_5C6;
					case 9:
						if (e.NewItems != null)
						{
							num = (short)1509621776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B7;
					case 10:
						enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
						num = (short)1107230722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_6C4;
					case 12:
						if (dockSite != null)
						{
							num = (short)740360205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CE3;
					case 13:
						dockSite.UpdateIsDocument(this);
						num = (short)368181259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_A2A;
					case 15:
					{
						num = (short)77594624;
						short num4 = num;
						goto IL_360;
					}
					case 16:
						enumerator = e.NewItems.GetEnumerator();
						num = (short)683671559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
						{
							num = (short)816054280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_734;
					case 18:
						if (e.OldItems != null)
						{
							num = (short)524222478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EF;
					}
					IL_90:
					if (base.SelectedIndex == -1)
					{
						num = (short)1357381633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_734;
					IL_B7:
					num = (short)1999765522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C6:
					enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
					num = (short)1730478085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_360:
						num = (short)1138622468;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::DevComponents.WpfDock.DockWindow dockWindow6;
							switch (num2)
							{
							case 0:
								num = (short)35586060;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::DevComponents.WpfDock.DockWindow dockWindow5;
								dockWindow5.m();
								num = (short)2106130437;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::DevComponents.WpfDock.DockWindow dockWindow5;
								if (dockWindow5 != null)
								{
									num = (short)781647873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								num = (short)1107296265;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_3BA;
								}
								continue;
							case 6:
								goto IL_413;
							case 8:
								base.RemoveLogicalChild(dockWindow6);
								num = (short)1951531014;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								goto IL_54B;
							case 10:
							{
								if (dockWindow6 != null)
								{
									num = (short)1873674240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object obj4;
								global::DevComponents.WpfDock.DockWindow dockWindow5 = base.ItemContainerGenerator.ContainerFromItem(obj4) as global::DevComponents.WpfDock.DockWindow;
								num = (short)178388994;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 11:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1273430019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object obj4 = enumerator.Current;
								dockWindow6 = (obj4 as global::DevComponents.WpfDock.DockWindow);
								num = (short)961019914;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 12:
								if (flag)
								{
									num = (short)990248968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_413;
							}
							goto IL_3BA;
							IL_413:
							dockWindow6.m();
							num = (short)21757959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_4F6:
							num = (short)553648139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3BA:
							goto IL_4F6;
						}
						IL_54B:
						goto IL_5EF;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_56D;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_55A:
							switch (num2)
							{
							case 0:
								goto IL_5C3;
							case 1:
								disposable.Dispose();
								num = (short)1239220224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (disposable != null)
								{
									num = (short)1185349633;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5C5;
							}
							goto IL_56D;
						}
						IL_5C3:
						IL_5C5:
						goto EndFinally_35;
						IL_56D:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)134348802;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_55A;
						EndFinally_35:;
					}
					goto IL_5C6;
					IL_5EF:
					this.a();
					this.UpdateTabVisibility();
					dockSite = this.GetDockSite();
					num = (short)207552513;
					if (num != 0)
					{
					}
					num = (short)106954764;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_663:
					num = (short)1962409993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_734:
					flag = (base.ItemsSource != null);
					num = (short)2100494342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A2A:
					enumerator = e.OldItems.GetEnumerator();
					num = (short)366739471;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_6C4:
				IL_CE3:
				base.OnItemsChanged(e);
				return;
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0003AE90 File Offset: 0x00039090
		public void UpdateTabVisibility()
		{
			short num = (short)1871446023;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Windows.Visibility visibility;
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (!global::DevComponents.WpfDock.DockSite.GetIsDocument(this))
					{
						num = (short)2024341509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_73;
				case 2:
					return;
				case 3:
				{
					num = (short)1340652285;
					short num3 = num;
					num = (short)1441184509;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EA;
					default:
					{
						num = (short)1760362496;
						short num4 = num;
						num = (short)829095936;
						if (num != 0)
						{
						}
						if (this.VisibleItemsCount <= 1)
						{
							num = (short)1538129926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73;
					}
					}
					break;
				}
				case 4:
					goto IL_EA;
				case 5:
					visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)1575223305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1227489281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 8:
					if (this.TabVisibility != visibility)
					{
						num = (short)1692794884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					num = (short)369295361;
					if (num != 0)
					{
					}
					goto IL_73;
				}
				IL_4C:
				if (base.ItemContainerGenerator.Status != global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
				{
					num = (short)861274114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				visibility = global::System.Windows.Visibility.Visible;
				num = (short)2031419395;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_73:
				num = (short)1328480264;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EA:
				this.TabVisibility = visibility;
				num = (short)1830289408;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0003B0AC File Offset: 0x000392AC
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1185939456;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::DevComponents.WpfDock.DockWindowGroup dockWindowGroup = (global::DevComponents.WpfDock.DockWindowGroup)A_0;
				global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)dockWindowGroup.Items).GetEnumerator();
				try
				{
					num = (short)197918727;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							global::DevComponents.WpfDock.DockWindow dockWindow;
							if (dockWindow == null)
							{
								num = (short)1775566853;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_180;
						}
						case 2:
							goto IL_180;
						case 3:
						{
							global::DevComponents.WpfDock.DockWindow dockWindow;
							if (dockWindow != null)
							{
								num = (short)1318649862;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							num = (short)625934345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							object obj;
							global::DevComponents.WpfDock.DockWindow dockWindow = dockWindowGroup.ItemContainerGenerator.ContainerFromItem(obj) as global::DevComponents.WpfDock.DockWindow;
							num = (short)1864499202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::DevComponents.WpfDock.DockWindow dockWindow;
							dockWindow.g();
							num = (short)991035392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							switch (0)
							{
							case 0:
								goto IL_82;
							}
							continue;
						case 8:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1968766977;
								if (num != 0)
								{
								}
								num = (short)1676738564;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							object obj = enumerator.Current;
							global::DevComponents.WpfDock.DockWindow dockWindow = obj as global::DevComponents.WpfDock.DockWindow;
							num = (short)940376065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_1D1;
						}
						IL_B1:
						num = (short)313393160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_82:
						goto IL_B1;
						IL_180:
						num = (short)510001155;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1D1:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_1F3;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_1E0:
						switch (num2)
						{
						case 0:
							disposable.Dispose();
							goto IL_286;
						case 1:
						{
							if (disposable == null)
							{
								goto IL_2A1;
							}
							num = (short)171953936;
							short num3 = num;
							num = (short)1553977104;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_286;
							default:
								num = (short)2036465664;
								if (num != 0)
								{
								}
								num = (short)131399680;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_29F;
						}
						goto IL_1F3;
						IL_286:
						num = (short)515440642;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_29F:
					IL_2A1:
					goto EndFinally_7;
					IL_1F3:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)135528449;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_1E0;
					EndFinally_7:;
				}
				num = (short)1605042176;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0003B3A4 File Offset: 0x000395A4
		public void UpdateVisibility()
		{
			short num = (short)792072899;
			short num2 = num;
			num = (short)1985286851;
			switch (num2 == num)
			{
			}
			num = (short)1194852352;
			short num3 = num;
			num = (short)782565376;
			if (num != 0)
			{
			}
			num = (short)1728708609;
			if (num != 0)
			{
			}
			this.f(this.VisibleItemsCount > 0);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0003B45C File Offset: 0x0003965C
		internal void f(bool A_0)
		{
			short num = (short)273874945;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)722105763;
				short num3 = num;
				num = (short)1382315427;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)395247616;
					short num4 = num;
					num = (short)843186176;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_1A5;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_BF;
						}
						continue;
					case 2:
						if (base.Visibility != global::System.Windows.Visibility.Visible)
						{
							num = (short)1405878278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0;
					case 3:
						if (base.Parent is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)757137408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_E0;
					case 5:
						base.Visibility = global::System.Windows.Visibility.Collapsed;
						num = (short)1709178883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						base.Visibility = global::System.Windows.Visibility.Visible;
						num = (short)1911947268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (base.Parent is global::DevComponents.WpfDock.SplitPanel)
						{
							num = (short)1163329545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						return;
					case 9:
						goto IL_1A7;
					}
					IL_BF:
					if (!A_0)
					{
						num = (short)1908408325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1429602306;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E0:
					num = (short)1968963591;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_1A7:
				num = (short)335937537;
				if (num != 0)
				{
				}
				((global::DevComponents.WpfDock.SplitPanel)base.Parent).UpdateAutoVisibility();
				num = (short)1618673672;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1A5:
			((global::DevComponents.WpfDock.SplitPanel)base.Parent).UpdateAutoVisibility();
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0003B698 File Offset: 0x00039898
		internal bool IsMouseInsideTabPanel
		{
			get
			{
				short num;
				while (this.z != null)
				{
					num = (short)746311652;
					short num2 = num;
					num = (short)835178468;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)558956544;
						if (num != 0)
						{
						}
						num = (short)1438449664;
						short num3 = num;
						global::System.Windows.Point position = global::System.Windows.Input.Mouse.GetPosition(this.z);
						global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, this.z.ActualWidth, this.z.ActualHeight);
						return rect.Contains(position);
					}
					}
				}
				num = (short)377749505;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0003B794 File Offset: 0x00039994
		public void SelectDifferentTab()
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (base.SelectedIndex > 0)
					{
						num2 = (short)866517001;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1332609032;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_85;
				case 3:
					goto IL_85;
				case 4:
					if (this.SelectedDockWindow != null)
					{
						num2 = (short)1528692743;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					flag = this.SelectedDockWindow.IsKeyboardFocusWithin;
					num2 = (short)1225129995;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (this.SelectedDockWindow != null)
					{
						num2 = (short)1747189765;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DD;
				case 7:
					num2 = (short)450625537;
					if (num2 != 0)
					{
					}
					this.SelectedDockWindow.FocusContent();
					num2 = (short)951255040;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (base.Items.Count > 1)
					{
						num2 = (short)229507085;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					base.SelectedIndex = -1;
					num2 = (short)660078595;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)787152896;
					short num3 = num2;
					this.g(true);
					num2 = (short)2055604285;
					short num4 = num2;
					num2 = (short)1451296829;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DB;
					default:
						num2 = (short)1061552128;
						if (num2 != 0)
						{
						}
						num2 = (short)2008088578;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 10:
					if (flag)
					{
						num2 = (short)1580400652;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					goto IL_DD;
				case 12:
					num2 = (short)1741619204;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					this.h(true);
					num2 = (short)1176764430;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_DB;
				}
				goto IL_4C;
				IL_85:
				num2 = (short)1079509002;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_DB:
				goto IL_85;
				IL_DD:
				num2 = (short)921960449;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_4C:
			flag = false;
			num2 = (short)101711878;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0003BA74 File Offset: 0x00039C74
		internal bool g(bool A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)211419136;
					short num3 = num2;
					num4 = this.a(base.Items.Count, -1);
					num2 = (short)432209921;
					if (num2 != 0)
					{
					}
					num2 = (short)45809670;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					num2 = (short)952395552;
					short num5 = num2;
					num2 = (short)582117152;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AD;
					default:
						num2 = (short)1637220352;
						if (num2 != 0)
						{
						}
						if (base.SelectedIndex <= 0)
						{
							num2 = (short)1007419397;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num4 = this.a(base.SelectedIndex, -1);
						num2 = (short)1907490825;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num4 = this.a(base.Items.Count, -1);
					num2 = (short)653590535;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (A_0)
					{
						goto IL_1AD;
					}
					return false;
				case 4:
					return false;
				case 5:
					num2 = (short)625672195;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_1F2;
				case 7:
					goto IL_1F2;
				case 8:
					if (num4 < 0)
					{
						num2 = (short)426377220;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22F;
				case 9:
					if (num4 < 0 && A_0)
					{
						num2 = (short)53084162;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F2;
				}
				goto IL_38;
				IL_1AD:
				num2 = (short)1619197952;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F2:
				num2 = (short)82706440;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_22F:
			base.SelectedIndex = num4;
			return true;
			IL_38:
			num4 = -1;
			num2 = (short)238157825;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0003BCB8 File Offset: 0x00039EB8
		internal bool h(bool A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = this.a(-1, 1);
					num3 = (short)118685702;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
				{
					num3 = (short)1913609521;
					short num4 = num3;
					num3 = (short)2007063857;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_177;
					default:
						num3 = (short)810352640;
						if (num3 != 0)
						{
						}
						if (base.SelectedIndex >= base.Items.Count - 1)
						{
							num3 = (short)235667461;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num2 = this.a(base.SelectedIndex, 1);
						num3 = (short)1357774857;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 2:
					num2 = this.a(-1, 1);
					num3 = (short)237043719;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					if (A_0)
					{
						goto IL_177;
					}
					return false;
				case 4:
					return false;
				case 5:
					num3 = (short)894107651;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
					goto IL_190;
				case 7:
					goto IL_190;
				case 8:
					num3 = (short)18219009;
					if (num3 != 0)
					{
					}
					if (num2 < 0)
					{
						num3 = (short)1156907012;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_21B;
				case 9:
					if (num2 < 0 && A_0)
					{
						num3 = (short)900399106;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_190;
				}
				goto IL_38;
				IL_177:
				num3 = (short)469565440;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_190:
				num3 = (short)1796079616;
				short num5 = num3;
				num3 = (short)1872822280;
				num = (int)((global::System.IntPtr)num3);
			}
			return false;
			IL_21B:
			base.SelectedIndex = num2;
			return true;
			IL_38:
			num2 = -1;
			num3 = (short)1013514241;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0003BEE8 File Offset: 0x0003A0E8
		private int a(int A_0, int A_1)
		{
			short num = (short)698155008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				int num4;
				int num5;
				int num6;
				for (;;)
				{
					IL_27:
					global::System.Windows.UIElement uielement;
					switch (num2)
					{
					case 0:
						if (A_0 <= 0)
						{
							num = (short)1357578245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_137;
					case 1:
						return -1;
					case 2:
						goto IL_281;
					case 3:
					{
						if (A_1 < 0)
						{
							num = (short)1418002439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)599965461;
						short num3 = num;
						num = (short)1554890517;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_114;
						default:
							num = (short)304807936;
							if (num != 0)
							{
							}
							num = (short)1621426186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)1420427273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return -1;
					case 6:
						goto IL_114;
					case 7:
						num4 = 0;
						num5 = -1;
						num = (short)841547776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (num4 == num6)
						{
							num = (short)648413185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 += num5;
						uielement = (base.ItemContainerGenerator.ContainerFromIndex(num6) as global::System.Windows.UIElement);
						num = (short)14680070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (uielement.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1677066251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_137;
					case 10:
						num = (short)1005780993;
						if (num != 0)
						{
						}
						if (A_0 >= num4)
						{
							num = (short)225640450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_137;
					case 11:
						return num6;
					}
					goto IL_5E;
					IL_114:
					if (uielement != null)
					{
						num = (short)1274675204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_137:
					num = (short)51183624;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num6;
				IL_281:
				num = (short)206962688;
				short num7 = num;
				return -1;
				IL_5E:
				num6 = A_0;
				num4 = base.Items.Count - 1;
				num5 = 1;
				num = (short)1951531011;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0003C17C File Offset: 0x0003A37C
		private void a()
		{
			short num = (short)959840256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				int num3;
				int num4;
				bool flag;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						if (num3 > num4)
						{
							num = (short)864354312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Windows.UIElement uielement = base.ItemContainerGenerator.ContainerFromIndex(num3) as global::System.Windows.UIElement;
						num = (short)134414340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Windows.UIElement uielement;
						global::System.Windows.Controls.Panel.SetZIndex(uielement, 10000);
						num = (short)1288503298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_C0;
					case 3:
					{
						num = (short)869007361;
						if (num != 0)
						{
						}
						global::System.Windows.UIElement uielement;
						global::System.Windows.Controls.Panel.SetZIndex(uielement, 9999);
						flag = false;
						num = (short)328400901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Windows.UIElement uielement;
						if (uielement != null)
						{
							num = (short)325976071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13C;
					}
					case 5:
						goto IL_13C;
					case 6:
						goto IL_212;
					case 7:
						num = (short)1963720718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						return;
					case 9:
						goto IL_212;
					case 10:
						if (flag)
						{
							num = (short)1911685132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13C;
					case 11:
					{
						global::System.Windows.UIElement uielement;
						if (uielement.Visibility == global::System.Windows.Visibility.Visible)
						{
							num = (short)1778319363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13C;
					}
					case 12:
						goto IL_1AA;
					case 13:
						goto IL_C0;
					case 14:
					{
						if (num3 == base.SelectedIndex)
						{
							num = (short)1557266433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1703608320;
						short num5 = num;
						global::System.Windows.UIElement uielement;
						global::System.Windows.Controls.Panel.SetZIndex(uielement, num4 - num3);
						num = (short)922419213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6B;
					IL_C0:
					num = (short)1503330314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13C:
					num3++;
					num = (short)1603993609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AA:
					num = (short)588251147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_212:
					num = (short)1095778380;
					short num6 = num;
					num = (short)1592082508;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AA;
					default:
						num = (short)1406664704;
						if (num != 0)
						{
						}
						num = (short)1889206272;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return;
				IL_6B:
				num4 = base.Items.Count - 1;
				flag = true;
				num3 = 0;
				num = (short)1542389766;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0003C49C File Offset: 0x0003A69C
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			short num = (short)44171265;
			if (num != 0)
			{
			}
			num = (short)522865096;
			short num2 = num;
			num = (short)1091848648;
			switch (num2 == num)
			{
			}
			num = (short)1049100288;
			if (num != 0)
			{
			}
			num = (short)978190336;
			short num3 = num;
			return item is global::DevComponents.WpfDock.DockWindow;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0003C550 File Offset: 0x0003A750
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			short num = (short)1872090267;
			short num2 = num;
			num = (short)978375835;
			switch (num2 == num)
			{
			}
			num = (short)641728513;
			if (num != 0)
			{
			}
			num = (short)1678245888;
			if (num != 0)
			{
			}
			num = (short)2130837504;
			short num3 = num;
			return new global::DevComponents.WpfDock.DockWindow();
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0003C600 File Offset: 0x0003A800
		[global::System.ComponentModel.Browsable(false)]
		public string Id
		{
			get
			{
				short num = (short)323092481;
				if (num != 0)
				{
				}
				num = (short)1642419806;
				short num2 = num;
				num = (short)324163166;
				switch (num2 == num)
				{
				}
				num = (short)1534918656;
				if (num != 0)
				{
				}
				num = (short)1526464512;
				short num3 = num;
				return this.y;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0003C6B4 File Offset: 0x0003A8B4
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0003C760 File Offset: 0x0003A960
		internal global::DevComponents.WpfDock.eDockSide LastDockSide
		{
			get
			{
				short num = (short)1308607630;
				short num2 = num;
				num = (short)691913870;
				switch (num2 == num)
				{
				}
				num = (short)3211264;
				if (num != 0)
				{
				}
				num = (short)1166802945;
				if (num != 0)
				{
				}
				num = (short)1227096064;
				short num3 = num;
				return this.t;
			}
			set
			{
				short num = (short)85445056;
				short num2 = num;
				num = (short)644991424;
				switch (num2 == num)
				{
				}
				num = (short)668729345;
				if (num != 0)
				{
				}
				num = (short)2064842752;
				if (num != 0)
				{
				}
				num = (short)531890176;
				short num3 = num;
				this.t = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0003C810 File Offset: 0x0003AA10
		// (set) Token: 0x06000225 RID: 549 RVA: 0x0003C8C0 File Offset: 0x0003AAC0
		internal global::DevComponents.WpfDock.eDockSide LastDockReference
		{
			get
			{
				short num = (short)1431675999;
				short num2 = num;
				num = (short)694985823;
				switch (num2 == num)
				{
				}
				num = (short)1117257728;
				if (num != 0)
				{
				}
				num = (short)759758849;
				if (num != 0)
				{
				}
				num = (short)653131776;
				short num3 = num;
				return this.u;
			}
			set
			{
				short num = (short)1831356840;
				short num2 = num;
				num = (short)534596008;
				switch (num2 == num)
				{
				}
				num = (short)1957822464;
				if (num != 0)
				{
				}
				num = (short)714342401;
				if (num != 0)
				{
				}
				num = (short)6553600;
				short num3 = num;
				this.u = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0003C970 File Offset: 0x0003AB70
		// (set) Token: 0x06000227 RID: 551 RVA: 0x0003CA20 File Offset: 0x0003AC20
		internal string LastDockReferenceId
		{
			get
			{
				short num = (short)90399641;
				short num2 = num;
				num = (short)105276313;
				switch (num2 == num)
				{
				}
				num = (short)1950679041;
				if (num != 0)
				{
				}
				num = (short)313131008;
				if (num != 0)
				{
				}
				num = (short)1920794624;
				short num3 = num;
				return this.v;
			}
			set
			{
				short num = (short)2022209220;
				short num2 = num;
				num = (short)1968928452;
				switch (num2 == num)
				{
				}
				num = (short)1710620672;
				if (num != 0)
				{
				}
				num = (short)1317208065;
				if (num != 0)
				{
				}
				num = (short)21168128;
				short num3 = num;
				this.v = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0003CAD0 File Offset: 0x0003ACD0
		// (set) Token: 0x06000229 RID: 553 RVA: 0x0003CB80 File Offset: 0x0003AD80
		internal bool LastDockIsFullSizeDock
		{
			get
			{
				short num = (short)701384072;
				short num2 = num;
				num = (short)28329352;
				switch (num2 == num)
				{
				}
				num = (short)167378945;
				if (num != 0)
				{
				}
				num = (short)1700855808;
				if (num != 0)
				{
				}
				num = (short)1242693632;
				short num3 = num;
				return this.w;
			}
			set
			{
				short num = (short)1638268929;
				if (num != 0)
				{
				}
				num = (short)1950949455;
				short num2 = num;
				num = (short)1486102607;
				switch (num2 == num)
				{
				}
				num = (short)624885760;
				if (num != 0)
				{
				}
				num = (short)533463040;
				short num3 = num;
				this.w = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0003CC30 File Offset: 0x0003AE30
		// (set) Token: 0x0600022B RID: 555 RVA: 0x0003CCE4 File Offset: 0x0003AEE4
		internal bool LastIsDocument
		{
			get
			{
				short num = (short)194151991;
				short num2 = num;
				num = (short)797935159;
				switch (num2 == num)
				{
				}
				num = (short)2132475905;
				if (num != 0)
				{
				}
				num = (short)503906304;
				if (num != 0)
				{
				}
				num = (short)963444736;
				short num3 = num;
				return this.ag;
			}
			set
			{
				short num = (short)876216321;
				if (num != 0)
				{
				}
				num = (short)2057893291;
				short num2 = num;
				num = (short)78509483;
				switch (num2 == num)
				{
				}
				num = (short)782237696;
				if (num != 0)
				{
				}
				num = (short)1979842560;
				short num3 = num;
				this.ag = value;
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0003CD94 File Offset: 0x0003AF94
		internal void s()
		{
			for (;;)
			{
				IL_00:
				short num = (short)1121124352;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						this.h(false);
						num = (short)1223557122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					}
					IL_30:
					if (base.SelectedIndex != -1)
					{
						return;
					}
					num = (short)1453663367;
					short num3 = num;
					num = (short)1882858631;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
					{
						num = (short)212992000;
						short num4 = num;
						num = (short)270860289;
						if (num != 0)
						{
						}
						num = (short)635502592;
						if (num != 0)
						{
						}
						num = (short)1204813825;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0003CEB8 File Offset: 0x0003B0B8
		internal global::System.Windows.Controls.ContextMenu OptionsContextMenu
		{
			get
			{
				short num = (short)1325758720;
				short num2 = num;
				num = (short)1595177216;
				switch (num2 == num)
				{
				}
				num = (short)367394817;
				if (num != 0)
				{
				}
				num = (short)1534001152;
				if (num != 0)
				{
				}
				num = (short)475136000;
				short num3 = num;
				return this.ab;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0003CF64 File Offset: 0x0003B164
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				short num = (short)1859321856;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1223229440;
					num2 = (int)((global::System.IntPtr)num);
					global::System.Collections.Generic.List<object> list;
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_4F;
							}
							continue;
						case 1:
						{
							num = (short)775553025;
							if (num != 0)
							{
							}
							num = (short)523348068;
							short num3 = num;
							num = (short)810330212;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2BD;
							default:
								num = (short)193658880;
								if (num != 0)
								{
								}
								goto IL_256;
							}
							break;
						}
						case 2:
							try
							{
								num = (short)829292547;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)417267718;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										object obj = enumerator.Current;
										num = (short)1700855810;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										object obj;
										if (obj is global::DevComponents.WpfDock.DockWindow)
										{
											num = (short)2135818244;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_12D;
										}
										continue;
									case 4:
									{
										object obj;
										list.Add(obj);
										num = (short)655228929;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_1DF;
									case 6:
										num = (short)462028805;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_16C:
									num = (short)2140667904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_12D:
									goto IL_16C;
								}
								IL_1DF:
								goto IL_2B1;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_201;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_1EE:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1433731073;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_255;
									case 1:
										disposable.Dispose();
										num = (short)49676290;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_253;
									}
									goto IL_201;
								}
								IL_253:
								IL_255:
								goto EndFinally_7;
								IL_201:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1396244480;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1EE;
								EndFinally_7:;
							}
							goto IL_256;
						}
						IL_4F:
						if (base.ItemsSource != null)
						{
							num = (short)752812033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BD;
						IL_256:
						list = new global::System.Collections.Generic.List<object>();
						enumerator = ((global::System.Collections.IEnumerable)base.Items).GetEnumerator();
						num = (short)1793982464;
						short num4 = num;
						num = (short)857145346;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2B1:
					return list.GetEnumerator();
					IL_2BD:
					return base.LogicalChildren;
				}
				}
			}
		}

		// Token: 0x04000113 RID: 275
		public static readonly global::System.Windows.DependencyProperty SelectedContentProperty;

		// Token: 0x04000114 RID: 276
		private static readonly global::System.Windows.DependencyPropertyKey a;

		// Token: 0x04000115 RID: 277
		public static readonly global::System.Windows.DependencyProperty SelectedDockWindowProperty;

		// Token: 0x04000116 RID: 278
		private static readonly global::System.Windows.DependencyPropertyKey b;

		// Token: 0x04000117 RID: 279
		public static readonly global::System.Windows.DependencyProperty SelectedContentTemplateProperty;

		// Token: 0x04000118 RID: 280
		private static readonly global::System.Windows.DependencyPropertyKey c;

		// Token: 0x04000119 RID: 281
		public static readonly global::System.Windows.DependencyProperty SelectedContentTemplateSelectorProperty;

		// Token: 0x0400011A RID: 282
		private static readonly global::System.Windows.DependencyPropertyKey d;

		// Token: 0x0400011B RID: 283
		public static readonly global::System.Windows.DependencyProperty SelectedContentHeaderProperty;

		// Token: 0x0400011C RID: 284
		public static readonly global::System.Windows.DependencyProperty ContentTemplateSelectorProperty;

		// Token: 0x0400011D RID: 285
		public static readonly global::System.Windows.DependencyProperty ContentTemplateProperty;

		// Token: 0x0400011E RID: 286
		public static readonly global::System.Windows.DependencyProperty IsFloatingProperty;

		// Token: 0x0400011F RID: 287
		private static readonly global::System.Windows.DependencyPropertyKey e;

		// Token: 0x04000120 RID: 288
		public static readonly global::System.Windows.DependencyProperty TabVisibilityProperty;

		// Token: 0x04000121 RID: 289
		private static readonly global::System.Windows.DependencyPropertyKey f;

		// Token: 0x04000122 RID: 290
		public static readonly global::System.Windows.DependencyProperty CanCloseProperty;

		// Token: 0x04000123 RID: 291
		private static readonly global::System.Windows.DependencyPropertyKey g;

		// Token: 0x04000124 RID: 292
		public static readonly global::System.Windows.DependencyProperty CanAutoHideProperty;

		// Token: 0x04000125 RID: 293
		private static readonly global::System.Windows.DependencyPropertyKey h;

		// Token: 0x04000126 RID: 294
		public static readonly global::System.Windows.DependencyProperty IsAutoHideProperty;

		// Token: 0x04000127 RID: 295
		private static readonly global::System.Windows.DependencyPropertyKey i;

		// Token: 0x04000128 RID: 296
		public static readonly global::System.Windows.DependencyProperty OptionsMenuProperty;

		// Token: 0x04000129 RID: 297
		private static readonly global::System.Windows.DependencyPropertyKey j;

		// Token: 0x0400012A RID: 298
		private const string k = "PART_TabContentHost";

		// Token: 0x0400012B RID: 299
		private const string l = "PART_GroupCaption";

		// Token: 0x0400012C RID: 300
		private const string m = "OptionsButton";

		// Token: 0x0400012D RID: 301
		private const string n = "OptionsMenu";

		// Token: 0x0400012E RID: 302
		private const string o = "WindowList";

		// Token: 0x0400012F RID: 303
		private const string p = "PART_TabPanel";

		// Token: 0x04000130 RID: 304
		private const string q = "InnerContent";

		// Token: 0x04000131 RID: 305
		private global::System.Windows.UIElement r;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Point s;

		// Token: 0x04000133 RID: 307
		private global::DevComponents.WpfDock.eDockSide t = global::DevComponents.WpfDock.eDockSide.Left;

		// Token: 0x04000134 RID: 308
		private global::DevComponents.WpfDock.eDockSide u = global::DevComponents.WpfDock.eDockSide.Left;

		// Token: 0x04000135 RID: 309
		private string v = "";

		// Token: 0x04000136 RID: 310
		private bool w;

		// Token: 0x04000137 RID: 311
		internal bool x;

		// Token: 0x04000138 RID: 312
		private string y = "";

		// Token: 0x04000139 RID: 313
		private global::System.Windows.Controls.Panel z;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Controls.Button aa;

		// Token: 0x0400013B RID: 315
		private global::System.Windows.Controls.ContextMenu ab;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Controls.ContextMenu ac;

		// Token: 0x0400013D RID: 317
		private global::System.Windows.UIElement ad;

		// Token: 0x0400013E RID: 318
		private bool ae;

		// Token: 0x0400013F RID: 319
		private global::DevComponents.WpfDock.DockSite af;

		// Token: 0x04000140 RID: 320
		private bool ag;
	}
}
