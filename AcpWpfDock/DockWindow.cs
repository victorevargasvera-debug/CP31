using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using DevComponents.WpfDock.Converters;

namespace DevComponents.WpfDock
{
	// Token: 0x02000022 RID: 34
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "TabBorder", Type = typeof(global::System.Windows.Controls.Decorator))]
	public class DockWindow : global::System.Windows.Controls.HeaderedContentControl
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000155 RID: 341 RVA: 0x0002BA30 File Offset: 0x00029C30
		// (remove) Token: 0x06000156 RID: 342 RVA: 0x0002BB6C File Offset: 0x00029D6C
		public event global::System.EventHandler DockParentChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)471859200;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				int num3;
				global::System.EventHandler eventHandler;
				for (;;)
				{
					IL_35:
					global::System.EventHandler eventHandler2;
					switch (num3)
					{
					case 0:
					{
						num = (short)1044911223;
						short num4 = num;
						num = (short)1049498743;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A8;
						default:
							num = (short)1227751424;
							if (num != 0)
							{
							}
							if (eventHandler == eventHandler2)
							{
								num = (short)1531707394;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8B;
						}
						break;
					}
					case 1:
						num = (short)151912449;
						if (num != 0)
						{
						}
						goto IL_8B;
					case 2:
						return;
					}
					goto IL_47;
					IL_A8:
					num = (short)1319108608;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_8B:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.b, value2, eventHandler2);
					goto IL_A8;
				}
				return;
				IL_47:
				eventHandler = this.b;
				num = (short)900399105;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_35;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)1041563648;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num3;
				global::System.EventHandler eventHandler;
				for (;;)
				{
					IL_33:
					global::System.EventHandler eventHandler2;
					switch (num3)
					{
					case 0:
					{
						num = (short)1773185745;
						short num4 = num;
						num = (short)1838197457;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A9;
						default:
							num = (short)28508160;
							if (num != 0)
							{
							}
							if (eventHandler == eventHandler2)
							{
								num = (short)410320898;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_8C;
						}
						break;
					}
					case 1:
						goto IL_8C;
					case 2:
						return;
					}
					goto IL_45;
					IL_A9:
					num = (short)1317797888;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.b, value2, eventHandler2);
					goto IL_A9;
				}
				return;
				IL_45:
				num = (short)28901377;
				if (num != 0)
				{
				}
				eventHandler = this.b;
				num = (short)1333329921;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0002BCA8 File Offset: 0x00029EA8
		// (set) Token: 0x06000158 RID: 344 RVA: 0x0002BD58 File Offset: 0x00029F58
		public object TabToolTip
		{
			get
			{
				short num = (short)1543937612;
				short num2 = num;
				num = (short)1668390476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)257425408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1239941121;
				if (num != 0)
				{
				}
				num = (short)137166848;
				if (num != 0)
				{
				}
				return base.GetValue(global::DevComponents.WpfDock.DockWindow.TabToolTipProperty);
			}
			set
			{
				short num = (short)1063452673;
				if (num != 0)
				{
				}
				num = (short)1359872000;
				short num2 = num;
				num = (short)774394450;
				short num3 = num;
				num = (short)223629906;
				switch (num3 == num)
				{
				}
				num = (short)1832124416;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.TabToolTipProperty, value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0002BE10 File Offset: 0x0002A010
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0002BECC File Offset: 0x0002A0CC
		[global::System.ComponentModel.DefaultValue(false)]
		public bool AutoClose
		{
			get
			{
				short num = (short)1022864187;
				short num2 = num;
				num = (short)150776635;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1876033536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)218169344;
				if (num != 0)
				{
				}
				num = (short)991232001;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.AutoCloseProperty);
			}
			set
			{
				short num = (short)562125296;
				short num2 = num;
				num = (short)1955551728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1646198784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2032140288;
				if (num != 0)
				{
				}
				num = (short)1418919937;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.AutoCloseProperty, value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0002BF8C File Offset: 0x0002A18C
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0002C044 File Offset: 0x0002A244
		public global::System.Windows.Visibility CloseButtonVisibility
		{
			get
			{
				short num = (short)1278405352;
				short num2 = num;
				num = (short)435350248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)610926592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1571618817;
				if (num != 0)
				{
				}
				num = (short)821755904;
				if (num != 0)
				{
				}
				return (global::System.Windows.Visibility)base.GetValue(global::DevComponents.WpfDock.DockWindow.CloseButtonVisibilityProperty);
			}
			set
			{
				short num = (short)1556372789;
				short num2 = num;
				num = (short)1457216821;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1659633664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)432734209;
				if (num != 0)
				{
				}
				num = (short)1664942080;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.CloseButtonVisibilityProperty, value);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0002C0FC File Offset: 0x0002A2FC
		static DockWindow()
		{
			int a_ = 19;
			short num = (short)616694701;
			short num2 = num;
			num = (short)1195639725;
			switch (num2 == num)
			{
			default:
			{
				num = (short)93192192;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)472580097;
			if (num != 0)
			{
			}
			num = (short)1806303232;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.DockWindow.ToggleAutoHide = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蛑믓뇕뿗뛙맛鿝闟雡诣껥臧軩觫", a_), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.OpenAutoHide = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鷑ꓓ돕뛗鯙꧛ꫝ迟ꫡ跣若跧", a_), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.CloseAutoHide = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金룓맕ꯗ뿙鷛ꯝ铟跡곣迥賧迩", a_), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.CloseWindow = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金룓맕ꯗ뿙", a_), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.FloatWindow = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("铑룓맕맗껙", a_), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.ReDockWindow = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("胑뇓鋕럗맙럛", a_), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.DockAsDocumentWindow = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("雑믓뗕돗鯙꿛髝迟臡釣该跧蓩飫", a_), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.SelectWindow = new global::System.Windows.Input.RoutedCommand(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("臑뇓뫕뷗맙꣛觝觟賡胣觥鿧", a_), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.a = new global::System.Windows.Rect(100.0, 100.0, 150.0, 250.0);
			global::DevComponents.WpfDock.DockWindow.TabToolTipProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蛑뗓듕賗뗙돛닝듟诡铣", a_), typeof(object), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.UIPropertyMetadata(null));
			global::DevComponents.WpfDock.DockWindow.AutoCloseProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鏑ꇓꋕ럗駙냛뇝鏟蟡", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfDock.DockWindow.CloseButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金룓맕ꯗ뿙黛ꯝ铟雡诣裥뻧菩鿫蟭鋯鯱飳鿵賷菹", a_), typeof(global::System.Windows.Visibility), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed));
			global::DevComponents.WpfDock.DockWindow.isCPSWindowHidden = false;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfDock.DockWindow)));
			global::DevComponents.WpfDock.DockWindow.IsSelectedProperty = global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty.AddOwner(typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockWindow.b)));
			global::DevComponents.WpfDock.DockWindow.ImageProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鯑맓럕뿗뿙", a_), typeof(object), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));
			global::DevComponents.WpfDock.DockWindow.ImageSourceProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鯑맓럕뿗뿙进뇝闟郡蟣菥", a_), typeof(string), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockWindow.a)));
			global::DevComponents.WpfDock.DockWindow.FloatingRectProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("铑룓맕맗껙뗛냝蟟냡臣藥鳧", a_), typeof(global::System.Windows.Rect), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfDock.DockWindow.a));
			global::DevComponents.WpfDock.DockWindow.CanAutoHideProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金뗓룕駗꿙꣛뇝꣟诡胣菥", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfDock.DockWindow.CanCloseProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金뗓룕鯗뛙돛귝藟", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfDock.DockWindow.CanDockAsDocumentProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金뗓룕鳗뗙뿛뗝ꇟ釡ꃣ觥诧鿩臫语黯蛱", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfDock.DockWindow.CanDockBottomProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金뗓룕鳗뗙뿛뗝ꋟ跡郣鋥蟧蟩", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfDock.DockWindow.CanDockLeftProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金뗓룕鳗뗙뿛뗝곟蟡苣鋥", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfDock.DockWindow.CanDockRightProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金뗓룕鳗뗙뿛뗝닟诡菣軥鳧", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfDock.DockWindow.CanDockTopProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金뗓룕鳗뗙뿛뗝듟跡铣", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfDock.DockWindow.CanFloatProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金뗓룕黗뛙돛뿝铟", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfDock.DockWindow.CanTearOffProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金뗓룕賗뿙뷛곝꿟蓡苣", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::DevComponents.WpfDock.DockWindow.IsAutoHideProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鯑ꟓ韕귗껙돛雝觟蛡臣", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockWindow.e)));
			global::DevComponents.WpfDock.DockWindow.AutoHideOpenProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鏑ꇓꋕ럗鋙뗛뫝藟귡铣菥蛧", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockWindow.d)));
			global::DevComponents.WpfDock.DockWindow.OptionsMenuProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鷑ꓓꋕ뇗뗙닛귝귟蟡諣鏥", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockWindow.c)));
			global::DevComponents.WpfDock.DockWindow.CustomOptionsMenuProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金ꇓꗕ곗뗙뇛針郟雡跣觥蛧駩ꇫ语黯蟱", a_), typeof(global::System.Windows.Controls.ContextMenu), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::DevComponents.WpfDock.DockWindow.c)));
			global::DevComponents.WpfDock.DockWindow.DescriptionProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("雑뇓ꗕ믗꣙뗛껝铟诡诣裥", a_), typeof(string), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(""));
			global::DevComponents.WpfDock.DockWindow.AttentionRequiredProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鏑ꃓꋕ뷗듙꣛럝迟賡뛣菥駧鿩藫鳭闯雱", a_), typeof(bool), typeof(global::DevComponents.WpfDock.DockWindow), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfDock.DockWindow.AutoHideChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鏑ꇓꋕ럗鋙뗛뫝藟ꇡ賣蟥蛧跩觫諭", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.AutoHideOpenChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鏑ꇓꋕ럗鋙뗛뫝藟귡铣菥蛧ꧩ蓫迭黯闱釳鋵", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.ClosingEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金룓맕ꯗ동닛망", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::DevComponents.WpfDock.CancelSourceRoutedEventHandler), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.ClosedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("金룓맕ꯗ뿙룛", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.ActivatedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鏑럓ꋕ뇗곙뷛ꫝ藟蛡", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.DeactivatedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("雑뇓럕믗껙뗛꣝臟雡臣若", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfDock.DockWindow));
			global::DevComponents.WpfDock.DockWindow.TabVisibilityChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("蛑뗓듕軗동꿛럝苟诡裣迥鳧鏩꿫蛭釯鳱鏳鏵鳷", a_), global::System.Windows.RoutingStrategy.Direct, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfDock.DockWindow));
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0002C948 File Offset: 0x0002AB48
		public DockWindow()
		{
			base.Loaded += this.a;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0002C978 File Offset: 0x0002AB78
		public override void OnApplyTemplate()
		{
			int a_ = 16;
			short num = (short)1705772807;
			short num2 = num;
			num = (short)119867143;
			switch (num2 == num)
			{
			default:
			{
				num = (short)991821824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1094582273;
			if (num != 0)
			{
			}
			num = (short)1803616256;
			if (num != 0)
			{
			}
			this.k = (base.GetTemplateChild(global::DevComponents.WpfDock.Converters.IsStringTypeConverter.b("鯎냐뇒韔룖ꯘ뿚룜귞", a_)) as global::System.Windows.Controls.Decorator);
			base.OnApplyTemplate();
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000160 RID: 352 RVA: 0x0002CA50 File Offset: 0x0002AC50
		// (remove) Token: 0x06000161 RID: 353 RVA: 0x0002CB04 File Offset: 0x0002AD04
		public event global::System.Windows.RoutedEventHandler AutoHideChanged
		{
			add
			{
				short num = (short)1595440926;
				short num2 = num;
				num = (short)719224606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)34340864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)644284417;
				if (num != 0)
				{
				}
				num = (short)1760296960;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfDock.DockWindow.AutoHideChangedEvent, value);
			}
			remove
			{
				short num = (short)88279979;
				short num2 = num;
				num = (short)780471211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1442906112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2058420225;
				if (num != 0)
				{
				}
				num = (short)84017152;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfDock.DockWindow.AutoHideChangedEvent, value);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000162 RID: 354 RVA: 0x0002CBB8 File Offset: 0x0002ADB8
		// (remove) Token: 0x06000163 RID: 355 RVA: 0x0002CC6C File Offset: 0x0002AE6C
		public event global::System.Windows.RoutedEventHandler AutoHideOpenChanged
		{
			add
			{
				short num = (short)1515134141;
				short num2 = num;
				num = (short)947395773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)97845248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1315635201;
				if (num != 0)
				{
				}
				num = (short)1008205824;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfDock.DockWindow.AutoHideOpenChangedEvent, value);
			}
			remove
			{
				short num = (short)511375109;
				short num2 = num;
				num = (short)1484453637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)363986944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1409679361;
				if (num != 0)
				{
				}
				num = (short)527171584;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfDock.DockWindow.AutoHideOpenChangedEvent, value);
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000164 RID: 356 RVA: 0x0002CD24 File Offset: 0x0002AF24
		// (remove) Token: 0x06000165 RID: 357 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		public event global::System.Windows.RoutedEventHandler TabVisibilityChanged
		{
			add
			{
				short num = (short)379937162;
				short num2 = num;
				num = (short)549347722;
				switch (num2 == num)
				{
				default:
				{
					num = (short)384696320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)206962689;
				if (num != 0)
				{
				}
				num = (short)735772672;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfDock.DockWindow.TabVisibilityChangedEvent, value);
			}
			remove
			{
				short num = (short)340038507;
				short num2 = num;
				num = (short)2102891371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)191430656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)848560129;
				if (num != 0)
				{
				}
				num = (short)1402011648;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfDock.DockWindow.TabVisibilityChangedEvent, value);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0002CE90 File Offset: 0x0002B090
		internal void g()
		{
			short num = (short)306829220;
			short num2 = num;
			num = (short)893048740;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1075183616;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1499987969;
			if (num != 0)
			{
			}
			num = (short)314966016;
			if (num != 0)
			{
			}
			this.OnTabVisibilityChanged(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfDock.DockWindow.TabVisibilityChangedEvent));
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0002CF48 File Offset: 0x0002B148
		protected virtual void OnTabVisibilityChanged(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1394575644;
			short num2 = num;
			num = (short)565807388;
			switch (num2 == num)
			{
			default:
			{
				num = (short)653131776;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)716111873;
			if (num != 0)
			{
			}
			num = (short)1053556736;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x06000168 RID: 360 RVA: 0x0002CFFC File Offset: 0x0002B1FC
		// (remove) Token: 0x06000169 RID: 361 RVA: 0x0002D0B0 File Offset: 0x0002B2B0
		public event global::DevComponents.WpfDock.CancelSourceRoutedEventHandler Closing
		{
			add
			{
				short num = (short)764227604;
				short num2 = num;
				num = (short)460402708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1513095168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)121700352;
				if (num != 0)
				{
				}
				num = (short)1685323777;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfDock.DockWindow.ClosingEvent, value);
			}
			remove
			{
				short num = (short)1436286977;
				if (num != 0)
				{
				}
				num = (short)1682112512;
				short num2 = num;
				num = (short)360998832;
				short num3 = num;
				num = (short)617965488;
				switch (num3 == num)
				{
				}
				num = (short)1804468224;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfDock.DockWindow.ClosingEvent, value);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600016A RID: 362 RVA: 0x0002D164 File Offset: 0x0002B364
		// (remove) Token: 0x0600016B RID: 363 RVA: 0x0002D218 File Offset: 0x0002B418
		public event global::System.Windows.RoutedEventHandler Closed
		{
			add
			{
				short num = (short)1673973133;
				short num2 = num;
				num = (short)2100874637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1028915200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2113077249;
				if (num != 0)
				{
				}
				num = (short)1951268864;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfDock.DockWindow.ClosedEvent, value);
			}
			remove
			{
				short num = (short)616853203;
				short num2 = num;
				num = (short)1616015059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)573833216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1904803841;
				if (num != 0)
				{
				}
				num = (short)1510998016;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfDock.DockWindow.ClosedEvent, value);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600016C RID: 364 RVA: 0x0002D2D0 File Offset: 0x0002B4D0
		// (remove) Token: 0x0600016D RID: 365 RVA: 0x0002D38C File Offset: 0x0002B58C
		public event global::System.Windows.RoutedEventHandler Activated
		{
			add
			{
				short num = (short)960995640;
				short num2 = num;
				num = (short)670343480;
				switch (num2 == num)
				{
				default:
				{
					num = (short)386924544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)591462400;
				if (num != 0)
				{
				}
				num = (short)946274305;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfDock.DockWindow.ActivatedEvent, value);
			}
			remove
			{
				short num = (short)1389610219;
				short num2 = num;
				num = (short)1576125675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)640221184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)237961217;
				if (num != 0)
				{
				}
				num = (short)1526857728;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfDock.DockWindow.ActivatedEvent, value);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600016E RID: 366 RVA: 0x0002D440 File Offset: 0x0002B640
		// (remove) Token: 0x0600016F RID: 367 RVA: 0x0002D4F8 File Offset: 0x0002B6F8
		public event global::System.Windows.RoutedEventHandler Deactivated
		{
			add
			{
				short num = (short)755467314;
				short num2 = num;
				num = (short)813073458;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1364197376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1447362561;
				if (num != 0)
				{
				}
				num = (short)886898688;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfDock.DockWindow.DeactivatedEvent, value);
			}
			remove
			{
				short num = (short)681863789;
				short num2 = num;
				num = (short)1527278189;
				switch (num2 == num)
				{
				default:
				{
					num = (short)360054784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1710424064;
				if (num != 0)
				{
				}
				num = (short)273154049;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfDock.DockWindow.DeactivatedEvent, value);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0002D5B0 File Offset: 0x0002B7B0
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)384089504;
			short num2 = num;
			num = (short)1243463072;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_A6:
				this.f();
				num = (short)139722752;
				short num3 = num;
				num = (short)673841153;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)97976320;
				if (num != 0)
				{
				}
				num = (short)111869955;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					num = (short)1039204354;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_E8;
				case 2:
					num = (short)1028915201;
					if (num != 0)
					{
					}
					if (!this.AutoHideOpen)
					{
						num = (short)965214212;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14E;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 4:
					goto IL_149;
				}
				IL_85:
				if (!this.IsAutoHide)
				{
					break;
				}
				num = (short)1383727104;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_E8:
			goto IL_14E;
			IL_149:
			goto IL_A6;
			IL_14E:
			base.OnMouseEnter(e);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0002D714 File Offset: 0x0002B914
		private void f()
		{
			short num = (short)2041315329;
			if (num != 0)
			{
			}
			num = (short)585395815;
			short num2 = num;
			num = (short)954429031;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EE:
				this.h = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.Normal);
				this.h.Tick += this.a;
				num = (short)1519779843;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_87;
			default:
			{
				num = (short)517734400;
				short num4 = num;
				goto IL_87;
			}
			}
			for (;;)
			{
				IL_BB:
				switch (num3)
				{
				case 0:
					goto IL_EE;
				case 1:
					goto IL_111;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_D1;
					}
					continue;
				case 3:
					goto IL_14F;
				}
				IL_D1:
				if (this.h == null)
				{
					num = (short)1857028096;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					this.h.Stop();
					num = (short)1915289601;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_111:
			IL_14F:
			this.a(this.h);
			return;
			IL_87:
			num = (short)880672768;
			if (num != 0)
			{
			}
			num = (short)1763246082;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_BB;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0002D880 File Offset: 0x0002BA80
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1839209435;
			short num2 = num;
			num = (short)839261147;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2014969856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1833631745;
			if (num != 0)
			{
			}
			num = (short)1680277504;
			if (num != 0)
			{
			}
			this.a(ref this.h);
			this.AutoHideOpen = true;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0002D93C File Offset: 0x0002BB3C
		private void a(ref global::System.Windows.Threading.DispatcherTimer A_0)
		{
			short num = (short)321585152;
			short num2 = num;
			num = (short)1911685121;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2066958244;
				short num4 = num;
				num = (short)1491552164;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1223491584;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_C1;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					case 2:
						goto IL_E4;
					}
					IL_A6:
					if (A_0 != null)
					{
						num = (short)541851648;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_C1:
				A_0.Stop();
				A_0 = null;
				num = (short)1033109506;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_E4:
			num = (short)1182793729;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0002DA58 File Offset: 0x0002BC58
		private void a(global::System.Windows.Threading.DispatcherTimer A_0)
		{
			short num = (short)1477967873;
			if (num != 0)
			{
			}
			num = (short)1387724800;
			short num2 = num;
			num = (short)1361483123;
			short num3 = num;
			num = (short)799380851;
			switch (num3 == num)
			{
			}
			num = (short)318111744;
			if (num != 0)
			{
			}
			A_0.Interval = global::System.TimeSpan.FromMilliseconds((double)global::System.Windows.SystemParameters.MenuShowDelay * 2.5);
			A_0.Start();
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0002DB20 File Offset: 0x0002BD20
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)296812544;
			short num2 = num;
			num = (short)1756037121;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					global::System.Windows.Rect rect;
					if (!rect.Contains(e.GetPosition(this.k)))
					{
						num = (short)353173507;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B9;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_6B;
					}
					continue;
				case 2:
					goto IL_120;
				case 3:
					this.a(e);
					num = (short)854720514;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::System.Windows.Rect rect = new global::System.Windows.Rect(this.k.RenderSize);
					num = (short)2121138176;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					num = (short)1276038054;
					short num4 = num;
					num = (short)882822054;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19D;
					default:
						num = (short)1233911809;
						if (num != 0)
						{
						}
						num = (short)197394432;
						if (num != 0)
						{
						}
						num = (short)907018246;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					if (this.k != null)
					{
						goto IL_19D;
					}
					goto IL_1B9;
				}
				IL_6B:
				if (base.IsMouseCaptured)
				{
					num = (short)618004485;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_19D:
				num = (short)517406724;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_120:
			IL_1B9:
			base.OnMouseMove(e);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0002DCF0 File Offset: 0x0002BEF0
		private void a(global::System.Windows.Input.MouseEventArgs A_0)
		{
			short num = (short)286523392;
			switch (num)
			{
			default:
			{
				num = (short)1010761743;
				int num2 = (int)((global::System.IntPtr)num);
				global::DevComponents.WpfDock.DockWindowGroup parentGroup;
				bool a_;
				int num6;
				for (;;)
				{
					double num4;
					double num5;
					switch (num2)
					{
					case 0:
						if (parentGroup.VisibleItemsCount > 1)
						{
							num = (short)1928790041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					case 1:
						a_ = false;
						num = (short)2097676296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::System.Windows.Point position;
						global::System.Windows.Rect layoutSlot;
						if (position.Y > layoutSlot.Y)
						{
							num = (short)1163329562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					}
					case 3:
						num = (short)730333200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)539361280;
						short num3 = num;
						num4 = 0.0;
						goto IL_36C;
					}
					case 5:
						goto IL_77E;
					case 6:
					{
						global::System.Windows.Point position;
						if (position.X < num5)
						{
							num = (short)1438580748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6++;
						num = (short)1171456046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1623064596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_2E7;
					case 9:
					{
						global::System.Windows.Point position;
						if (position.X >= num5)
						{
							num = (short)796000261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_174;
					}
					case 10:
						if (parentGroup != null)
						{
							num = (short)458424323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					case 11:
						if (!global::DevComponents.WpfDock.DockSite.GetIsDocument(this))
						{
							num = (short)1946877996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2098659368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num6--;
						num = (short)1192099878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						parentGroup = this.ParentGroup;
						global::System.Windows.Point position = A_0.GetPosition(this);
						global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this);
						num = (short)1586429963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (parentGroup.Items.IndexOf(this) > 0)
						{
							num = (short)812580912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_77E;
					case 15:
						switch (0)
						{
						case 0:
							goto IL_109;
						}
						continue;
					case 16:
						if (parentGroup.IsMouseInsideTabPanel)
						{
							num = (short)154075170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					case 17:
						if (parentGroup != null)
						{
							num = (short)1355350063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E7;
					case 18:
						goto IL_7EA;
					case 19:
						goto IL_323;
					case 20:
						if (!global::DevComponents.WpfDock.i.a(this.i))
						{
							num = (short)2045575203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 21:
						num = (short)1538129937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (base.IsMouseCaptured)
						{
							num = (short)1988165665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6EB;
					case 23:
					{
						global::DevComponents.WpfDock.DockSite dockSite = this.GetDockSite();
						num = (short)2053505066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_174;
					case 25:
						num = (short)1101463554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)512688171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_3EF;
					case 28:
					{
						global::System.Windows.Point position;
						if (position.X > num5)
						{
							num = (short)1994719256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					}
					case 29:
						num = (short)153288732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (parentGroup.VisibleItemsCount == 1)
						{
							num = (short)448331777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E7;
					case 31:
						if (global::DevComponents.WpfDock.DockSite.GetIsDocument(this))
						{
							num = (short)43057173;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E7;
					case 32:
						num = (short)1571225614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						base.ReleaseMouseCapture();
						num = (short)1613168685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)1815019520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)367198226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						global::System.Windows.Rect rect;
						if (rect.Contains(this.i))
						{
							num = (short)1811021847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 37:
						if (parentGroup.Items.IndexOf(this) < parentGroup.Items.Count - 1)
						{
							num = (short)946405405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					case 38:
						goto IL_64C;
					case 39:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						if (dockSite.DockHintOverlay)
						{
							num = (short)450560019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dockSite.a(parentGroup, a_, global::DevComponents.WpfDock.eEventActionSource.Mouse);
						num = (short)1490288667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						num4 = base.ActualHeight;
						goto IL_36C;
					case 41:
					{
						global::System.Windows.Rect rect = new global::System.Windows.Rect(this.k.RenderSize);
						num = (short)1447165988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						if (!dockSite.IsDockingInProgress)
						{
							num = (short)1739980801;
							if (num != 0)
							{
							}
							num = (short)358350861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 43:
					{
						global::System.Windows.Point position;
						global::System.Windows.Rect layoutSlot;
						if (position.Y < layoutSlot.Bottom)
						{
							num = (short)923926560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					}
					case 44:
						num = (short)1441660932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_6EB;
					case 46:
					{
						num = (short)1453304533;
						short num7 = num;
						num = (short)255765205;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7EA;
						default:
							goto IL_889;
						}
						break;
					}
					case 47:
						num = (short)1428881438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						num = (short)479789065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_109:
					if (A_0.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
					{
						num = (short)1620901895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_133:
					num = (short)1250099222;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_174:
					num6 = parentGroup.Items.IndexOf(this);
					parentGroup.Items.Remove(this);
					num = (short)1439301638;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E7:
					num = (short)1769275431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36C:
					num5 = num4;
					num = (short)1585774602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6EB:
					this.i = default(global::System.Windows.Point);
					a_ = true;
					num = (short)209911839;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_77E:
					num = (short)324796453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7EA:
					if (this.k == null)
					{
						return;
					}
					num = (short)1305477161;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2D1:
				parentGroup.Items.Insert(num6, this);
				parentGroup.SelectedItem = this;
				return;
				IL_323:
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::System.Windows.Threading.DispatcherOperationCallback(this.a), new global::DevComponents.WpfDock.DockWindow.a(parentGroup, a_, global::DevComponents.WpfDock.eEventActionSource.Mouse));
				return;
				IL_3EF:
				return;
				IL_64C:
				goto IL_2D1;
				IL_889:
				num = (short)1750532096;
				if (num != 0)
				{
				}
				goto IL_2D1;
			}
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0002E5A0 File Offset: 0x0002C7A0
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			short num = (short)1962213376;
			short num2 = num;
			num = (short)1167982592;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_40;
				case 1:
					goto IL_114;
				case 2:
				{
					this.a(ref this.h);
					num = (short)1268828046;
					short num4 = num;
					num = (short)422233998;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_40;
					default:
						num = (short)40501248;
						if (num != 0)
						{
						}
						num = (short)369098753;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_5C;
				IL_40:
				switch (0)
				{
				case 0:
					IL_5C:
					num = (short)1827602433;
					if (num != 0)
					{
					}
					if (!this.IsAutoHide)
					{
						goto IL_116;
					}
					num = (short)670498818;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_114:
			IL_116:
			base.OnMouseLeave(e);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0002E6CC File Offset: 0x0002C8CC
		private object a(object A_0)
		{
			short num = (short)524681216;
			short num2 = num;
			num = (short)1517312827;
			short num3 = num;
			num = (short)1314741051;
			switch (num3 == num)
			{
			}
			num = (short)279576577;
			if (num != 0)
			{
			}
			num = (short)1516109824;
			if (num != 0)
			{
			}
			global::DevComponents.WpfDock.DockSite dockSite = this.GetDockSite();
			global::DevComponents.WpfDock.DockWindow.a a = A_0 as global::DevComponents.WpfDock.DockWindow.a;
			dockSite.a(a.a, a.b, a.c);
			return null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0002E79C File Offset: 0x0002C99C
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			for (;;)
			{
				IL_00:
				short num = (short)517013504;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num3;
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						num = (short)919797761;
						if (num != 0)
						{
						}
						if (base.IsMouseCaptured)
						{
							num = (short)1672740866;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A;
					case 1:
						goto IL_118;
					case 2:
					{
						base.ReleaseMouseCapture();
						num = (short)200346261;
						short num4 = num;
						num = (short)1084099221;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)559022080;
							if (num != 0)
							{
							}
							num = (short)420675585;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_45:
				this.i = default(global::System.Windows.Point);
				num = (short)214237184;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			IL_118:
			IL_11A:
			base.OnMouseLeftButtonUp(e);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0002E8CC File Offset: 0x0002CACC
		protected override void OnMouseRightButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)508755969;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)107347973;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_16;
				case 2:
					num = (short)912130052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_128;
				case 4:
					if (e.Source == this)
					{
						num = (short)1424752640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A0;
				case 5:
					if (!this.IsSelected)
					{
						num = (short)400031750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A0;
				case 6:
				{
					num = (short)2029389049;
					short num3 = num;
					num = (short)786957561;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16;
					default:
						num = (short)1342504960;
						if (num != 0)
						{
						}
						this.IsSelected = true;
						num = (short)867434499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_6D;
				IL_16:
				num = (short)376438784;
				short num4 = num;
				switch (0)
				{
				case 0:
					IL_6D:
					num = (short)1572208641;
					if (num != 0)
					{
					}
					if (this.IsAutoHide)
					{
						goto IL_1A0;
					}
					num = (short)2120482818;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_128:
			IL_1A0:
			base.OnMouseRightButtonDown(e);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0002EA80 File Offset: 0x0002CC80
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_100;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)18912964;
				short num2 = num;
				num = (short)1723111108;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1304821760;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (this.IsSelected)
						{
							num = (short)837287964;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F0;
					case 1:
					{
						global::System.Windows.Rect rect = new global::System.Windows.Rect(base.RenderSize);
						num = (short)2113011747;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)149422111;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Windows.Rect rect;
						if (rect.Contains(e.GetPosition(this)))
						{
							num = (short)1800536077;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53E;
					}
					case 4:
					{
						global::System.Windows.Rect rect = new global::System.Windows.Rect(this.k.RenderSize);
						num = (short)1985151003;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						this.AutoHideOpen = !this.AutoHideOpen;
						e.Handled = true;
						this.a(ref this.h);
						num = (short)65994767;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						this.FocusContent();
						num = (short)1786707988;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_120;
					case 8:
					{
						global::System.Windows.Rect rect = new global::System.Windows.Rect(base.RenderSize);
						num = (short)1347682307;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (this.CanFloat)
						{
							num = (short)1572208657;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53E;
					case 10:
						goto IL_3EB;
					case 11:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						if (!dockSite.IsDockingInProgress)
						{
							num = (short)361496588;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53E;
					}
					case 12:
						num = (short)906559497;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::DevComponents.WpfDock.DockSite dockSite = this.GetDockSite();
						num = (short)1264975901;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						return;
					case 15:
						goto IL_4BE;
					case 16:
						this.IsSelected = true;
						e.Handled = true;
						num = (short)733872167;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						dockSite.FloatWindow(this, global::DevComponents.WpfDock.eEventActionSource.Mouse, true);
						num = (short)58916889;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)1203961867;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (e.ClickCount == 2)
						{
							num = (short)86966280;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)941621286;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						num = (short)1184497664;
						short num4 = num;
						goto IL_54B;
					}
					case 21:
						if (this.IsAutoHide)
						{
							num = (short)1864564769;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BE;
					case 22:
						if (!e.Handled)
						{
							num = (short)1445330945;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BE;
					case 23:
						num = (short)1243217920;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (!this.IsAutoHide)
						{
							num = (short)386203650;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_459;
					case 25:
						goto IL_169;
					case 26:
						if (!this.IsAutoHide)
						{
							num = (short)615251991;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F0;
					case 27:
					{
						global::System.Windows.Rect rect;
						if (rect.Contains(e.GetPosition(this.k)))
						{
							num = (short)2082144266;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 28:
						num = (short)508624915;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						if (dockSite != null)
						{
							num = (short)916324370;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53E;
					}
					case 30:
						this.i = e.GetPosition(this);
						num = (short)2133852194;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (!this.IsSelected)
						{
							num = (short)461963280;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_459;
					case 32:
						goto IL_414;
					case 33:
						num = (short)1364000790;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (this.k != null)
						{
							num = (short)1798897668;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 35:
					{
						num = (short)260243457;
						if (num != 0)
						{
						}
						global::System.Windows.Rect rect;
						if (rect.Contains(e.GetPosition(this)))
						{
							num = (short)1763049477;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BE;
					}
					case 36:
						if (!base.IsKeyboardFocusWithin)
						{
							num = (short)777781254;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54B;
					case 37:
						if (base.Content is global::System.Windows.UIElement)
						{
							num = (short)216203304;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54B;
					case 38:
						if (this.e())
						{
							num = (short)1553006622;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CB;
					case 39:
						goto IL_4BE;
					case 40:
						num = (short)511901732;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_100;
					IL_3F0:
					this.i = default(global::System.Windows.Point);
					num = (short)1250951200;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_459:
					num = (short)21889045;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BE:
					num = (short)1659109413;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_54B:
					num = (short)1427898394;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_120:
				if (!global::DevComponents.WpfDock.j.c)
				{
					num = (short)12845070;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)2095054872;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return;
			IL_169:
			goto IL_53E;
			IL_2CB:
			this.i = default(global::System.Windows.Point);
			return;
			IL_3EB:
			base.CaptureMouse();
			return;
			IL_414:
			return;
			IL_53E:
			this.i = default(global::System.Windows.Point);
			return;
			IL_100:
			base.OnMouseLeftButtonDown(e);
			num = (short)691208199;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0002F1B0 File Offset: 0x0002D3B0
		public bool FocusContent()
		{
			short num = (short)476774404;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (base.Content is global::System.Windows.UIElement)
					{
						num = (short)315424769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_174;
				case 1:
				{
					num = (short)123509079;
					short num3 = num;
					num = (short)389847383;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)1070071808;
						if (num != 0)
						{
						}
						base.UpdateLayout();
						((global::System.Windows.UIElement)base.Content).MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
						num = (short)263389186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_130;
				case 3:
				{
					num = (short)844169217;
					if (num != 0)
					{
					}
					num = (short)577699840;
					short num4 = num;
					num = (short)869269504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_14;
				}
				goto IL_38;
				IL_14:
				switch (0)
				{
				case 0:
					IL_38:
					if (base.IsKeyboardFocusWithin)
					{
						goto IL_174;
					}
					num = (short)1856307203;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_130:
			IL_174:
			return base.IsKeyboardFocusWithin;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0002F338 File Offset: 0x0002D538
		private bool e()
		{
			short num = (short)758644741;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.ParentGroup != null)
					{
						num = (short)249495555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
				{
					if (global::DevComponents.WpfDock.DockSite.GetIsDocument(this))
					{
						num = (short)392429570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2132148225;
					if (num != 0)
					{
					}
					num = (short)814024064;
					short num3 = num;
					num = (short)573441408;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)522780672;
						if (num != 0)
						{
						}
						num = (short)1006632960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return true;
				case 3:
					goto IL_10B;
				case 4:
					goto IL_5B;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				}
				IL_3C:
				if (!this.CanTearOff)
				{
					num = (short)520617988;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1224802305;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5B:
			num = (short)722993152;
			short num4 = num;
			return false;
			IL_10B:
			return this.ParentGroup.VisibleItemsCount > 1;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600017E RID: 382 RVA: 0x0002F4CC File Offset: 0x0002D6CC
		// (set) Token: 0x0600017F RID: 383 RVA: 0x0002F584 File Offset: 0x0002D784
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsSelected
		{
			get
			{
				short num = (short)736624641;
				if (num != 0)
				{
				}
				num = (short)1676548233;
				short num2 = num;
				num = (short)1052121225;
				switch (num2 == num)
				{
				}
				num = (short)2051407872;
				short num3 = num;
				num = (short)1532624896;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.IsSelectedProperty);
			}
			set
			{
				short num = (short)1274871784;
				short num2 = num;
				num = (short)1668677608;
				switch (num2 == num)
				{
				}
				num = (short)1075707904;
				if (num != 0)
				{
				}
				num = (short)735772672;
				short num3 = num;
				num = (short)1706688513;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.IsSelectedProperty, value);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0002F63C File Offset: 0x0002D83C
		internal void a(global::DevComponents.WpfDock.DockWindowGroup A_0)
		{
			short num = (short)2002291266;
			short num2 = num;
			num = (short)1155304002;
			switch (num2 == num)
			{
			}
			num = (short)915013633;
			if (num != 0)
			{
			}
			num = (short)1374093312;
			short num3 = num;
			num = (short)2015428608;
			if (num != 0)
			{
			}
			this.l = A_0;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0002F6EC File Offset: 0x0002D8EC
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0002F7B0 File Offset: 0x0002D9B0
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::DevComponents.WpfDock.DockWindowGroup ParentGroup
		{
			get
			{
				short num;
				if (base.Parent == null)
				{
					for (;;)
					{
						num = (short)467409819;
						short num2 = num;
						num = (short)1389042587;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_3E;
						}
					}
					IL_3E:
					num = (short)1850015744;
					if (num != 0)
					{
					}
					return this.l;
				}
				num = (short)420806656;
				short num3 = num;
				num = (short)1271463937;
				if (num != 0)
				{
				}
				return base.Parent as global::DevComponents.WpfDock.DockWindowGroup;
			}
			set
			{
				short num = (short)94044170;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfDock.DockWindowGroup parentGroup;
					switch (num2)
					{
					case 0:
						if (parentGroup.SelectedItem == this)
						{
							num = (short)1209073671;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_75;
					case 1:
						value.Items.Add(this);
						num = (short)226099203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (parentGroup != null)
						{
							goto IL_155;
						}
						goto IL_195;
					case 3:
						goto IL_192;
					case 4:
						return;
					case 5:
						num = (short)530317313;
						if (num != 0)
						{
						}
						goto IL_195;
					case 6:
						num = (short)566034432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						parentGroup.SelectDifferentTab();
						num = (short)1020395529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (value != null)
						{
							num = (short)661585921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_209;
					case 9:
						goto IL_75;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					}
					IL_50:
					if (this.ParentGroup == value)
					{
						num = (short)767492100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					parentGroup = this.ParentGroup;
					num = (short)62128130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_75:
					num = (short)1887701292;
					short num3 = num;
					num = (short)380307756;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_155:
						num = (short)1749417990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)1018167296;
						if (num != 0)
						{
						}
						parentGroup.Items.Remove(this);
						num = (short)1448280069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_195:
					num = (short)735248392;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_192:
				IL_209:
				num = (short)554762240;
				short num4 = num;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0002F9F0 File Offset: 0x0002DBF0
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0002FAA8 File Offset: 0x0002DCA8
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanAutoHide
		{
			get
			{
				short num = (short)1978619217;
				short num2 = num;
				num = (short)1167021393;
				switch (num2 == num)
				{
				}
				num = (short)1341390848;
				if (num != 0)
				{
				}
				num = (short)286457856;
				short num3 = num;
				num = (short)157417473;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.CanAutoHideProperty);
			}
			set
			{
				short num = (short)89456641;
				if (num != 0)
				{
				}
				num = (short)754280553;
				short num2 = num;
				num = (short)2067425385;
				switch (num2 == num)
				{
				}
				num = (short)1695154176;
				short num3 = num;
				num = (short)1407778816;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.CanAutoHideProperty, value);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0002FB60 File Offset: 0x0002DD60
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0002FC1C File Offset: 0x0002DE1C
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanClose
		{
			get
			{
				short num = (short)69179447;
				short num2 = num;
				num = (short)750622775;
				switch (num2 == num)
				{
				}
				num = (short)1133510657;
				if (num != 0)
				{
				}
				num = (short)117506048;
				short num3 = num;
				num = (short)1345650688;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.CanCloseProperty);
			}
			set
			{
				short num = (short)1373110273;
				if (num != 0)
				{
				}
				num = (short)1096285921;
				short num2 = num;
				num = (short)400162529;
				switch (num2 == num)
				{
				}
				num = (short)1019150336;
				short num3 = num;
				num = (short)2015035392;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.CanCloseProperty, value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0002FCD8 File Offset: 0x0002DED8
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0002FD94 File Offset: 0x0002DF94
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(true)]
		public bool CanDockAsDocument
		{
			get
			{
				short num = (short)1755967120;
				short num2 = num;
				num = (short)1874914960;
				switch (num2 == num)
				{
				}
				num = (short)1806172160;
				if (num != 0)
				{
				}
				num = (short)1365901312;
				short num3 = num;
				num = (short)1095237633;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.CanDockAsDocumentProperty);
			}
			set
			{
				short num = (short)1582874059;
				short num2 = num;
				num = (short)641252811;
				switch (num2 == num)
				{
				}
				num = (short)270401536;
				if (num != 0)
				{
				}
				num = (short)233897984;
				short num3 = num;
				num = (short)1946353665;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.CanDockAsDocumentProperty, value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0002FE50 File Offset: 0x0002E050
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0002FF08 File Offset: 0x0002E108
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanDockBottom
		{
			get
			{
				short num = (short)969116766;
				short num2 = num;
				num = (short)862358622;
				switch (num2 == num)
				{
				}
				num = (short)1330511872;
				if (num != 0)
				{
				}
				num = (short)900988928;
				short num3 = num;
				num = (short)42729473;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.CanDockBottomProperty);
			}
			set
			{
				short num = (short)1013896959;
				short num2 = num;
				num = (short)977393407;
				switch (num2 == num)
				{
				}
				num = (short)1648820225;
				if (num != 0)
				{
				}
				num = (short)854327296;
				short num3 = num;
				num = (short)1273298944;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.CanDockBottomProperty, value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0002FFC0 File Offset: 0x0002E1C0
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0003007C File Offset: 0x0002E27C
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanDockLeft
		{
			get
			{
				short num = (short)573226767;
				short num2 = num;
				num = (short)2038611727;
				switch (num2 == num)
				{
				}
				num = (short)2011168769;
				if (num != 0)
				{
				}
				num = (short)597426176;
				short num3 = num;
				num = (short)1946288128;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.CanDockLeftProperty);
			}
			set
			{
				short num = (short)165176800;
				short num2 = num;
				num = (short)1570792928;
				switch (num2 == num)
				{
				}
				num = (short)30932993;
				if (num != 0)
				{
				}
				num = (short)767492096;
				short num3 = num;
				num = (short)1886191616;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.CanDockLeftProperty, value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00030138 File Offset: 0x0002E338
		// (set) Token: 0x0600018E RID: 398 RVA: 0x000301F0 File Offset: 0x0002E3F0
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanDockRight
		{
			get
			{
				short num = (short)877569444;
				short num2 = num;
				num = (short)917808548;
				switch (num2 == num)
				{
				}
				num = (short)478019584;
				if (num != 0)
				{
				}
				num = (short)691601408;
				short num3 = num;
				num = (short)1009844225;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.CanDockRightProperty);
			}
			set
			{
				short num = (short)602343832;
				short num2 = num;
				num = (short)464914840;
				switch (num2 == num)
				{
				}
				num = (short)1866465281;
				if (num != 0)
				{
				}
				num = (short)2144403456;
				short num3 = num;
				num = (short)1222967296;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.CanDockRightProperty, value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000302AC File Offset: 0x0002E4AC
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00030364 File Offset: 0x0002E564
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanDockTop
		{
			get
			{
				short num = (short)2076236128;
				short num2 = num;
				num = (short)1779554656;
				switch (num2 == num)
				{
				}
				num = (short)1923219457;
				if (num != 0)
				{
				}
				num = (short)1417805824;
				short num3 = num;
				num = (short)1366556672;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.CanDockTopProperty);
			}
			set
			{
				short num = (short)884657695;
				short num2 = num;
				num = (short)329764383;
				switch (num2 == num)
				{
				}
				num = (short)73334785;
				if (num != 0)
				{
				}
				num = (short)1517486080;
				short num3 = num;
				num = (short)1753350144;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.CanDockTopProperty, value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00030424 File Offset: 0x0002E624
		// (set) Token: 0x06000192 RID: 402 RVA: 0x000304DC File Offset: 0x0002E6DC
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanFloat
		{
			get
			{
				short num = (short)1682587854;
				short num2 = num;
				num = (short)1103970510;
				switch (num2 == num)
				{
				}
				num = (short)164823040;
				if (num != 0)
				{
				}
				num = (short)1967325184;
				short num3 = num;
				num = (short)1609367553;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.CanFloatProperty);
			}
			set
			{
				short num = (short)57252944;
				short num2 = num;
				num = (short)1061592144;
				switch (num2 == num)
				{
				}
				num = (short)1197015041;
				if (num != 0)
				{
				}
				num = (short)109510656;
				short num3 = num;
				num = (short)1950547968;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.CanFloatProperty, value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00030598 File Offset: 0x0002E798
		// (set) Token: 0x06000194 RID: 404 RVA: 0x00030650 File Offset: 0x0002E850
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanTearOff
		{
			get
			{
				short num = (short)902331521;
				short num2 = num;
				num = (short)919305345;
				switch (num2 == num)
				{
				}
				num = (short)304152577;
				if (num != 0)
				{
				}
				num = (short)961544192;
				short num3 = num;
				num = (short)1320026112;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.CanTearOffProperty);
			}
			set
			{
				short num = (short)1774403930;
				short num2 = num;
				num = (short)290603354;
				switch (num2 == num)
				{
				}
				num = (short)1366294528;
				if (num != 0)
				{
				}
				num = (short)1275658240;
				short num3 = num;
				num = (short)874381313;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.CanTearOffProperty, value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0003070C File Offset: 0x0002E90C
		// (set) Token: 0x06000196 RID: 406 RVA: 0x000307C4 File Offset: 0x0002E9C4
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsAutoHide
		{
			get
			{
				short num = (short)769440777;
				short num2 = num;
				num = (short)1201060873;
				switch (num2 == num)
				{
				}
				num = (short)1962016769;
				if (num != 0)
				{
				}
				num = (short)759627776;
				short num3 = num;
				num = (short)1983643648;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.IsAutoHideProperty);
			}
			set
			{
				short num = (short)1290826131;
				short num2 = num;
				num = (short)686125459;
				switch (num2 == num)
				{
				}
				num = (short)2146697217;
				if (num != 0)
				{
				}
				num = (short)500170752;
				short num3 = num;
				num = (short)2059075584;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.IsAutoHideProperty, value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00030884 File Offset: 0x0002EA84
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0003093C File Offset: 0x0002EB3C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.DefaultValue(false)]
		public bool AttentionRequired
		{
			get
			{
				short num = (short)413905783;
				short num2 = num;
				num = (short)2006758263;
				switch (num2 == num)
				{
				}
				num = (short)933822465;
				if (num != 0)
				{
				}
				num = (short)465698816;
				short num3 = num;
				num = (short)1178402816;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.AttentionRequiredProperty);
			}
			set
			{
				short num = (short)1608540374;
				short num2 = num;
				num = (short)662069462;
				switch (num2 == num)
				{
				}
				num = (short)791019521;
				if (num != 0)
				{
				}
				num = (short)74317824;
				short num3 = num;
				num = (short)1906180096;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfDock.DockWindow.AttentionRequiredProperty, value);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000309F8 File Offset: 0x0002EBF8
		private static void e(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)973231406;
			short num2 = num;
			num = (short)372266286;
			switch (num2 == num)
			{
			}
			num = (short)81526785;
			if (num != 0)
			{
			}
			num = (short)1957756928;
			short num3 = num;
			num = (short)572784640;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfDock.DockWindow)A_0).d();
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00030AAC File Offset: 0x0002ECAC
		private void d()
		{
			short num = (short)36831244;
			int num2 = (int)((global::System.IntPtr)num);
			global::DevComponents.WpfDock.DockSite dockSite;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (dockSite == null)
					{
						num = (short)1075445770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_241;
				case 2:
					num = (short)1208418305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_241;
				case 4:
					if (base.IsLoaded)
					{
						num = (short)1509163016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B8;
				case 5:
					if (this.j)
					{
						num = (short)1804140546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.j = true;
					num = (short)111804419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (!this.IsAutoHide)
					{
						num = (short)1738276875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_241;
				case 7:
					num = (short)123666433;
					if (num != 0)
					{
					}
					if (dockSite != null)
					{
						num = (short)2003828745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B8;
				case 8:
					num = (short)194510855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_23C;
				case 10:
					num = (short)2107047942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_B3;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				IL_58:
				if (this.m)
				{
					num = (short)631963648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				dockSite = this.GetDockSite();
				goto IL_FB;
				IL_B8:
				num = (short)37421061;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FB:
				num = (short)1006895108;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_241:
				num = (short)1360042954;
				short num3 = num;
				num = (short)423664586;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_FB;
				default:
					goto IL_275;
				}
			}
			return;
			IL_B3:
			this.j = false;
			return;
			IL_23C:
			bool a_ = !this.j;
			this.j = false;
			dockSite.a(this, this.IsAutoHide, global::DevComponents.WpfDock.eEventActionSource.Code, a_);
			this.a(ref this.h);
			this.OnAutoHideChanged(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfDock.DockWindow.AutoHideChangedEvent, this));
			return;
			IL_275:
			num = (short)136380416;
			if (num != 0)
			{
			}
			num = (short)1259470848;
			short num4 = num;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00030D6C File Offset: 0x0002EF6C
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)160497666;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1961951232;
					short num3 = num;
					num = (short)589256436;
					short num4 = num;
					num = (short)1171871476;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)214761472;
						if (num != 0)
						{
						}
						this.d();
						num = (short)689963009;
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
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)840237057;
				if (num != 0)
				{
				}
				if (!this.j)
				{
					break;
				}
				num = (short)1482883072;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00030E88 File Offset: 0x0002F088
		protected virtual void OnAutoHideChanged(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1148817009;
			short num2 = num;
			num = (short)636259953;
			switch (num2 == num)
			{
			}
			num = (short)1245642753;
			if (num != 0)
			{
			}
			num = (short)1512636416;
			short num3 = num;
			num = (short)258998272;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00030F38 File Offset: 0x0002F138
		protected virtual void OnActivated(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1101414623;
			short num2 = num;
			num = (short)388448479;
			switch (num2 == num)
			{
			}
			num = (short)1995833344;
			if (num != 0)
			{
			}
			num = (short)804716544;
			short num3 = num;
			num = (short)1951727617;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00030FE8 File Offset: 0x0002F1E8
		protected virtual void OnDeactivated(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)500957185;
			if (num != 0)
			{
			}
			num = (short)1180561349;
			short num2 = num;
			num = (short)1953558469;
			switch (num2 == num)
			{
			}
			num = (short)1245577216;
			short num3 = num;
			num = (short)1143472128;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00031098 File Offset: 0x0002F298
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00031150 File Offset: 0x0002F350
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Bindable(true)]
		public bool AutoHideOpen
		{
			get
			{
				short num = (short)976235155;
				short num2 = num;
				num = (short)1705716371;
				switch (num2 == num)
				{
				}
				num = (short)213647361;
				if (num != 0)
				{
				}
				num = (short)99483648;
				if (num != 0)
				{
				}
				num = (short)210960384;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.AutoHideOpenProperty);
			}
			set
			{
				short num = (short)1219120935;
				short num2 = num;
				num = (short)70340391;
				switch (num2 == num)
				{
				}
				num = (short)413990912;
				if (num != 0)
				{
				}
				num = (short)931987457;
				if (num != 0)
				{
				}
				num = (short)769130496;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindow.AutoHideOpenProperty, value);
			}
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0003120C File Offset: 0x0002F40C
		private static void d(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)235392420;
			short num2 = num;
			num = (short)395038116;
			switch (num2 == num)
			{
			}
			num = (short)174129153;
			if (num != 0)
			{
			}
			num = (short)884408320;
			if (num != 0)
			{
			}
			num = (short)1178206208;
			short num3 = num;
			((global::DevComponents.WpfDock.DockWindow)A_0).c();
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000312C0 File Offset: 0x0002F4C0
		private void c()
		{
			short num = (short)1194262538;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)702349313;
					if (num != 0)
					{
					}
					num = (short)323158018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_10B;
				case 2:
					if (this.IsAutoHide)
					{
						num = (short)483262465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_175;
				case 4:
					goto IL_144;
				case 5:
				{
					global::DevComponents.WpfDock.DockSite dockSite;
					this.o = dockSite.e(this);
					num = (short)1231618055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
				{
					if (this.AutoHideOpen)
					{
						num = (short)783613957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::DevComponents.WpfDock.DockSite dockSite;
					dockSite.b(this, dockSite.AnimationEnabled);
					this.o = null;
					num = (short)919339011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_22A;
				case 8:
					return;
				case 9:
				{
					global::DevComponents.WpfDock.DockSite dockSite;
					if (dockSite == null)
					{
						num = (short)220790792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)149684230;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 11:
				{
					if (global::DevComponents.WpfDock.DockWindow.isCPSWindowHidden)
					{
						num = (short)1869283332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::DevComponents.WpfDock.DockSite dockSite = this.GetDockSite();
					num = (short)505479177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_56:
				num = (short)571736064;
				short num3 = num;
				if (this.AutoHideOpen)
				{
					num = (short)571670528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_10B:
				num = (short)523698187;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_144:
			return;
			IL_175:
			num = (short)81192081;
			short num4 = num;
			num = (short)2087904401;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1107165184;
				if (num != 0)
				{
				}
				break;
			}
			IL_22A:
			this.OnAutoHideOpenChanged(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfDock.DockWindow.AutoHideOpenChangedEvent, this));
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0003154C File Offset: 0x0002F74C
		protected virtual void OnAutoHideOpenChanged(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2045019548;
			short num2 = num;
			num = (short)994018716;
			switch (num2 == num)
			{
			}
			num = (short)1065222144;
			if (num != 0)
			{
			}
			num = (short)420020225;
			if (num != 0)
			{
			}
			num = (short)1037369344;
			short num3 = num;
			base.RaiseEvent(e);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x000315FC File Offset: 0x0002F7FC
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x000316B8 File Offset: 0x0002F8B8
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool OptionsMenu
		{
			get
			{
				short num = (short)1319156670;
				short num2 = num;
				num = (short)179289022;
				switch (num2 == num)
				{
				}
				num = (short)1676738560;
				if (num != 0)
				{
				}
				num = (short)1627062273;
				if (num != 0)
				{
				}
				num = (short)1313538048;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfDock.DockWindow.OptionsMenuProperty);
			}
			set
			{
				short num = (short)354627297;
				short num2 = num;
				num = (short)1547841249;
				switch (num2 == num)
				{
				}
				num = (short)1579679745;
				if (num != 0)
				{
				}
				num = (short)1947926528;
				if (num != 0)
				{
				}
				num = (short)1929183232;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindow.OptionsMenuProperty, value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00031774 File Offset: 0x0002F974
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00031830 File Offset: 0x0002FA30
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.ContextMenu CustomOptionsMenu
		{
			get
			{
				short num = (short)1102250500;
				short num2 = num;
				num = (short)451215876;
				switch (num2 == num)
				{
				}
				num = (short)1325400064;
				if (num != 0)
				{
				}
				num = (short)1915158529;
				if (num != 0)
				{
				}
				num = (short)258146304;
				short num3 = num;
				return (global::System.Windows.Controls.ContextMenu)base.GetValue(global::DevComponents.WpfDock.DockWindow.CustomOptionsMenuProperty);
			}
			set
			{
				short num = (short)283321705;
				short num2 = num;
				num = (short)936977769;
				switch (num2 == num)
				{
				}
				num = (short)599326721;
				if (num != 0)
				{
				}
				num = (short)410320896;
				if (num != 0)
				{
				}
				num = (short)1513357312;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindow.CustomOptionsMenuProperty, value);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x000318E8 File Offset: 0x0002FAE8
		private static void c(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)890335109;
			short num2 = num;
			num = (short)2098950021;
			switch (num2 == num)
			{
			}
			num = (short)2092564480;
			if (num != 0)
			{
			}
			num = (short)1523515393;
			if (num != 0)
			{
			}
			num = (short)393150464;
			short num3 = num;
			((global::DevComponents.WpfDock.DockWindow)A_0).b();
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0003199C File Offset: 0x0002FB9C
		private void b()
		{
			short num = (short)1125777409;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
				{
					num = (short)32386378;
					short num3 = num;
					num = (short)1935355210;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B;
					default:
					{
						num = (short)252772352;
						short num4 = num;
						num = (short)952958977;
						if (num != 0)
						{
						}
						num = (short)1226440704;
						if (num != 0)
						{
						}
						this.ParentGroup.i();
						num = (short)689307648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				goto IL_30;
				IL_3B:
				num = (short)540278786;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30:
				if (this.ParentGroup != null)
				{
					goto IL_3B;
				}
				break;
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00031ABC File Offset: 0x0002FCBC
		public global::DevComponents.WpfDock.DockSite GetDockSite()
		{
			short num = (short)1942129112;
			short num2 = num;
			num = (short)1807059416;
			switch (num2 == num)
			{
			}
			num = (short)1135869952;
			if (num != 0)
			{
			}
			num = (short)1770913793;
			if (num != 0)
			{
			}
			num = (short)1780940800;
			short num3 = num;
			return global::DevComponents.WpfDock.DockSite.a(this);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00031B6C File Offset: 0x0002FD6C
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			global::DevComponents.WpfDock.DockWindow dockWindow = A_0 as global::DevComponents.WpfDock.DockWindow;
			short num;
			if ((bool)A_1.NewValue)
			{
				num = (short)289669121;
				if (num != 0)
				{
				}
			}
			else
			{
				num = (short)49088789;
				short num2 = num;
				num = (short)1555564821;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)712179712;
					if (num != 0)
					{
					}
					dockWindow.OnUnselected(new global::System.Windows.RoutedEventArgs(global::System.Windows.Controls.Primitives.Selector.UnselectedEvent, dockWindow));
					return;
				}
			}
			num = (short)1333002240;
			short num3 = num;
			dockWindow.OnSelected(new global::System.Windows.RoutedEventArgs(global::System.Windows.Controls.Primitives.Selector.SelectedEvent, dockWindow));
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00031C4C File Offset: 0x0002FE4C
		protected virtual void OnSelected(global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_97;
			}
			short num;
			int num4;
			for (;;)
			{
				IL_0A:
				num = (short)713159847;
				short num2 = num;
				num = (short)1644295335;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_108;
				case 1:
					break;
				default:
				{
					num = (short)863961088;
					short num3 = num;
					break;
				}
				}
				num = (short)649003008;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
				{
					global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo;
					scrollInfo.MakeVisible(this, new global::System.Windows.Rect(base.RenderSize));
					num = (short)242024449;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_108;
				case 2:
				{
					global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo;
					if (scrollInfo != null)
					{
						num = (short)1797128192;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
					if (global::DevComponents.WpfDock.DockSite.GetIsDocument(this))
					{
						num = (short)1304428548;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
				{
					global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = base.VisualParent as global::System.Windows.Controls.Primitives.IScrollInfo;
					num = (short)1362558978;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_97;
			}
			IL_108:
			num = (short)831062017;
			if (num != 0)
			{
			}
			return;
			IL_97:
			this.a(true, e);
			num = (short)237240323;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00031DCC File Offset: 0x0002FFCC
		protected virtual void OnUnselected(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1599597510;
			short num2 = num;
			num = (short)106490822;
			switch (num2 == num)
			{
			}
			num = (short)1424556032;
			if (num != 0)
			{
			}
			num = (short)1871314945;
			if (num != 0)
			{
			}
			num = (short)1534001152;
			short num3 = num;
			this.a(false, e);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00031E80 File Offset: 0x00030080
		protected override void OnGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_121;
				case 1:
					num2 = (short)231145472;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1621491713;
					if (num2 != 0)
					{
					}
					this.IsSelected = true;
					num2 = (short)537460742;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)97452036;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (e.NewFocus == this)
					{
						num2 = (short)1946419201;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					if (!e.Handled)
					{
						num2 = (short)278724611;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					goto IL_104;
				}
				goto IL_2C;
			}
			IL_104:
			return;
			IL_121:
			if (!this.IsSelected)
			{
				goto IL_12C;
			}
			return;
			IL_2C:
			num2 = (short)1298751918;
			short num3 = num2;
			num2 = (short)1815110062;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_12C:
				num2 = (short)1673789442;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1123549184;
				short num4 = num2;
				num2 = (short)1054408704;
				if (num2 != 0)
				{
				}
				base.OnGotKeyboardFocus(e);
				num2 = (short)1691156485;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0003203C File Offset: 0x0003023C
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			short num = (short)1576534018;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_146;
				case 1:
					goto IL_F3;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 3:
					goto IL_52;
				}
				IL_35:
				if (base.IsKeyboardFocusWithin)
				{
					num = (short)1727266819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1492891030;
				short num3 = num;
				num = (short)2087237014;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1412694016;
					if (num != 0)
					{
					}
					this.OnDeactivated(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfDock.DockWindow.DeactivatedEvent, this));
					num = (short)614203393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_52:
				num = (short)146800640;
				short num4 = num;
				this.OnActivated(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfDock.DockWindow.ActivatedEvent, this));
				num = (short)819789824;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F3:
			num = (short)27787265;
			if (num != 0)
			{
			}
			IL_146:
			base.OnIsKeyboardFocusWithinChanged(e);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00032198 File Offset: 0x00030398
		private void a(bool A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1438384129;
			if (num != 0)
			{
			}
			num = (short)1036714237;
			short num2 = num;
			num = (short)1826291965;
			switch (num2 == num)
			{
			}
			num = (short)65470464;
			if (num != 0)
			{
			}
			num = (short)276234240;
			short num3 = num;
			base.RaiseEvent(A_1);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0003224C File Offset: 0x0003044C
		protected override void OnHeaderChanged(object oldHeader, object newHeader)
		{
			short num = (short)531169283;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2061434881;
					if (num != 0)
					{
					}
					this.ParentGroup.g();
					num = (short)1445211032;
					short num3 = num;
					num = (short)1067854744;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1076297728;
						if (num != 0)
						{
						}
						num = (short)1011220481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_CA;
				case 2:
					if (this.ParentGroup != null)
					{
						num = (short)555614208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_156;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
					num = (short)1836908546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_38:
				if (!base.IsInitialized)
				{
					goto IL_156;
				}
				num = (short)1225785348;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CA:
			num = (short)199491584;
			short num4 = num;
			IL_156:
			base.OnHeaderChanged(oldHeader, newHeader);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000323B8 File Offset: 0x000305B8
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			short num = (short)605945859;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					this.ParentGroup.f();
					num = (short)404015268;
					short num3 = num;
					num = (short)738576548;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1360789504;
						if (num != 0)
						{
						}
						num = (short)1260650497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_CA;
				case 2:
					if (this.ParentGroup != null)
					{
						num = (short)669712384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15A;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 4:
					num = (short)602800130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_39:
				if (!base.IsInitialized)
				{
					goto IL_15A;
				}
				num = (short)452460548;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CA:
			num = (short)432078848;
			short num4 = num;
			num = (short)377552897;
			if (num != 0)
			{
			}
			IL_15A:
			base.OnContentChanged(oldContent, newContent);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00032528 File Offset: 0x00030728
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x000325DC File Offset: 0x000307DC
		[global::System.ComponentModel.Category("Content")]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		public object Image
		{
			get
			{
				short num = (short)920410248;
				short num2 = num;
				num = (short)1622038664;
				switch (num2 == num)
				{
				}
				num = (short)1639907329;
				if (num != 0)
				{
				}
				num = (short)201916416;
				if (num != 0)
				{
				}
				num = (short)1518796800;
				short num3 = num;
				return base.GetValue(global::DevComponents.WpfDock.DockWindow.ImageProperty);
			}
			set
			{
				short num = (short)1209729025;
				if (num != 0)
				{
				}
				num = (short)429746480;
				short num2 = num;
				num = (short)1449552176;
				switch (num2 == num)
				{
				}
				num = (short)1523318784;
				if (num != 0)
				{
				}
				num = (short)1293549568;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindow.ImageProperty, value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00032694 File Offset: 0x00030894
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x0003274C File Offset: 0x0003094C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Category("Content")]
		public string ImageSource
		{
			get
			{
				short num = (short)264412168;
				short num2 = num;
				num = (short)676043784;
				switch (num2 == num)
				{
				}
				num = (short)915079168;
				if (num != 0)
				{
				}
				num = (short)771424257;
				if (num != 0)
				{
				}
				num = (short)1751318528;
				short num3 = num;
				return (string)base.GetValue(global::DevComponents.WpfDock.DockWindow.ImageSourceProperty);
			}
			set
			{
				short num = (short)1287110286;
				short num2 = num;
				num = (short)1858518670;
				switch (num2 == num)
				{
				}
				num = (short)1125646336;
				if (num != 0)
				{
				}
				num = (short)761856001;
				if (num != 0)
				{
				}
				num = (short)1029963776;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindow.ImageSourceProperty, value);
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00032800 File Offset: 0x00030A00
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)15912504;
			short num2 = num;
			num = (short)247320120;
			switch (num2 == num)
			{
			}
			num = (short)119013377;
			if (num != 0)
			{
			}
			num = (short)1678639104;
			if (num != 0)
			{
			}
			num = (short)109182976;
			short num3 = num;
			((global::DevComponents.WpfDock.DockWindow)A_0).a();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000328B4 File Offset: 0x00030AB4
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_175;
				case 1:
				{
					string imageSource;
					if (imageSource.Length == 0)
					{
						goto IL_13C;
					}
					global::System.Windows.Controls.Image image = null;
					num2 = (short)1411055621;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					num2 = (short)255524865;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_155;
				case 4:
				{
					string imageSource;
					if (imageSource != null)
					{
						num2 = (short)737280002;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_177;
				}
				case 5:
				{
					num2 = (short)607518721;
					if (num2 != 0)
					{
					}
					global::System.Windows.Controls.Image image;
					try
					{
						string imageSource;
						global::System.Windows.Media.Imaging.BitmapImage source = new global::System.Windows.Media.Imaging.BitmapImage(new global::System.Uri(imageSource, global::System.UriKind.RelativeOrAbsolute));
						image = new global::System.Windows.Controls.Image();
						image.Source = source;
						image.Stretch = global::System.Windows.Media.Stretch.None;
						goto IL_157;
					}
					catch
					{
						this.Image = null;
					}
					return;
					IL_157:
					this.Image = image;
					num2 = (short)167247872;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_28;
			}
			IL_155:
			goto IL_177;
			IL_175:
			return;
			IL_177:
			this.Image = null;
			return;
			IL_28:
			num2 = (short)1599187464;
			short num3 = num2;
			num2 = (short)1564912136;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_13C:
				num2 = (short)1018691587;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)2045313024;
				short num4 = num2;
				num2 = (short)71041024;
				if (num2 != 0)
				{
				}
				string imageSource = this.ImageSource;
				num2 = (short)1554251780;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00032A80 File Offset: 0x00030C80
		// (set) Token: 0x060001BA RID: 442 RVA: 0x00032B38 File Offset: 0x00030D38
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DefaultValue("")]
		[global::System.ComponentModel.Category("Content")]
		public string Description
		{
			get
			{
				short num = (short)1234195893;
				short num2 = num;
				num = (short)367154613;
				switch (num2 == num)
				{
				}
				num = (short)1414922241;
				if (num != 0)
				{
				}
				num = (short)879624192;
				if (num != 0)
				{
				}
				num = (short)2013724672;
				short num3 = num;
				return (string)base.GetValue(global::DevComponents.WpfDock.DockWindow.DescriptionProperty);
			}
			set
			{
				short num = (short)577696890;
				short num2 = num;
				num = (short)161412218;
				switch (num2 == num)
				{
				}
				num = (short)937099265;
				if (num != 0)
				{
				}
				num = (short)1044578304;
				if (num != 0)
				{
				}
				num = (short)1102577664;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindow.DescriptionProperty, value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00032BF0 File Offset: 0x00030DF0
		// (set) Token: 0x060001BC RID: 444 RVA: 0x00032CA8 File Offset: 0x00030EA8
		[global::System.ComponentModel.Category("Behavior")]
		public global::System.Windows.Rect FloatingRect
		{
			get
			{
				short num = (short)1153176378;
				short num2 = num;
				num = (short)771101498;
				switch (num2 == num)
				{
				}
				num = (short)1724121088;
				if (num != 0)
				{
				}
				num = (short)422182913;
				if (num != 0)
				{
				}
				num = (short)1646067712;
				short num3 = num;
				return (global::System.Windows.Rect)base.GetValue(global::DevComponents.WpfDock.DockWindow.FloatingRectProperty);
			}
			set
			{
				short num = (short)688127084;
				short num2 = num;
				num = (short)1252392044;
				switch (num2 == num)
				{
				}
				num = (short)2033385473;
				if (num != 0)
				{
				}
				num = (short)1388904448;
				if (num != 0)
				{
				}
				num = (short)103940096;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfDock.DockWindow.FloatingRectProperty, value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00032D60 File Offset: 0x00030F60
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(false)]
		public bool IsFloating
		{
			get
			{
				if (this.ParentGroup == null)
				{
					short num = (short)1852178432;
					short num2 = num;
					num = (short)1121953772;
					short num3 = num;
					num = (short)1591584748;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)758448128;
						if (num != 0)
						{
						}
						num = (short)1918107649;
						if (num != 0)
						{
						}
						return false;
					}
				}
				return this.ParentGroup.IsFloating;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00032E24 File Offset: 0x00031024
		public bool Close()
		{
			short num = (short)31940639;
			short num2 = num;
			num = (short)1519476767;
			switch (num2 == num)
			{
			}
			num = (short)484376577;
			if (num != 0)
			{
			}
			num = (short)2087256064;
			if (num != 0)
			{
			}
			num = (short)1060765696;
			short num3 = num;
			return this.Close(global::DevComponents.WpfDock.eEventActionSource.Code);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00032ED8 File Offset: 0x000310D8
		public bool Close(global::DevComponents.WpfDock.eEventActionSource actionSource)
		{
			short num = (short)500891648;
			switch (num)
			{
			default:
			{
				num = (short)762904626;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::DevComponents.WpfDock.DockWindowGroup parentGroup;
					global::DevComponents.WpfDock.DockSite dockSite2;
					int num4;
					bool flag;
					global::DevComponents.WpfDock.CancelSourceRoutedEventArgs cancelSourceRoutedEventArgs;
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this);
						num = (short)1706295336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)873070592;
						short num3 = num;
						global::DevComponents.WpfDock.DockSite dockSite = parentGroup.GetDockSite();
						num = (short)723779595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (this.IsAutoHide)
						{
							num = (short)1622343723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_477;
					case 3:
						if (parentGroup.Items.Count == 0)
						{
							num = (short)1389953025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E8;
					case 4:
					{
						global::System.Windows.Window window;
						this.FloatingRect = new global::System.Windows.Rect(window.Left, window.Top, window.Width, window.Height);
						num = (short)2067005473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_5EB;
					case 6:
						num = (short)535363630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1786642433;
						if (num != 0)
						{
						}
						goto IL_477;
					case 8:
						num = (short)1092943889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_20B;
					case 10:
						goto IL_13E;
					case 11:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						if (dockSite != null)
						{
							num = (short)491520015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E8;
					}
					case 12:
						dockSite2.RestoreLastDockPosition(parentGroup);
						num = (short)758251547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (this.AutoClose)
						{
							goto IL_246;
						}
						return true;
					case 14:
					{
						object[] array;
						if (num4 >= array.Length)
						{
							num = (short)1561657354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj = array[num4];
						num = (short)1026621482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::DevComponents.WpfDock.DockSite dockSite;
						dockSite.Detach(parentGroup);
						num = (short)227868719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_75F;
					case 17:
					{
						object obj;
						if (obj is global::DevComponents.WpfDock.DockWindow)
						{
							num = (short)2036465683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_75F;
					}
					case 18:
						if (parentGroup.VisibleItemsCount == 0)
						{
							num = (short)372965397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						parentGroup.SelectDifferentTab();
						num = (short)167051293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						object obj;
						((global::DevComponents.WpfDock.DockWindow)obj).Close(actionSource);
						num = (short)788332560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (parentGroup.VisibleItemsCount > 0)
						{
							num = (short)298778660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13E;
					case 21:
						parentGroup.UpdateVisibility();
						num = (short)805306377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (this.AutoHideOpen)
						{
							num = (short)225443878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_438;
					case 23:
						if (dockSite2 != null)
						{
							num = (short)328990732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_417;
					case 24:
						if (flag)
						{
							num = (short)637272108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13E;
					case 25:
						goto IL_2A5;
					case 26:
						return false;
					case 27:
						goto IL_417;
					case 28:
						return false;
					case 29:
						goto IL_20B;
					case 30:
						if (parentGroup != null)
						{
							num = (short)913244160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EB;
					case 31:
						goto IL_2A5;
					case 32:
						if (cancelSourceRoutedEventArgs.Cancel)
						{
							num = (short)1880096796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1335885846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_6DE;
					case 34:
						if (parentGroup != null)
						{
							num = (short)617414693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13E;
					case 35:
						if (parentGroup != null)
						{
							num = (short)1565327409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20B;
					case 36:
					{
						num = (short)360807659;
						short num5 = num;
						num = (short)1309375723;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_246;
						default:
						{
							num = (short)1434845184;
							if (num != 0)
							{
							}
							object[] array2 = new object[parentGroup.Items.Count];
							parentGroup.Items.CopyTo(array2, 0);
							object[] array = array2;
							num4 = 0;
							num = (short)1079705625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 37:
						num = (short)926744596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						this.AutoHideOpen = false;
						num = (short)1646198823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_438;
					case 40:
					{
						global::System.Windows.Window window;
						if (window != null)
						{
							num = (short)35848196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6DE;
					}
					case 41:
						goto IL_412;
					case 42:
					{
						object obj;
						if (obj != this)
						{
							num = (short)845742088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_75F;
					}
					case 43:
						this.IsAutoHide = false;
						num = (short)1956249607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						num = (short)895877154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						num = (short)746586142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (parentGroup != null)
						{
							num = (short)1364328499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 47:
						goto IL_3E8;
					case 48:
						if (this.IsFloating)
						{
							num = (short)1527775277;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EB;
					case 49:
						parentGroup.UpdateTabVisibility();
						num = (short)551682066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						switch (0)
						{
						case 0:
							goto IL_115;
						}
						continue;
					case 51:
						parentGroup.Items.Remove(this);
						num = (short)2004353027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_115:
					if (base.Visibility == global::System.Windows.Visibility.Collapsed)
					{
						num = (short)452329498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					cancelSourceRoutedEventArgs = new global::DevComponents.WpfDock.CancelSourceRoutedEventArgs(global::DevComponents.WpfDock.DockWindow.ClosingEvent, this);
					cancelSourceRoutedEventArgs.EventActionSource = actionSource;
					this.OnClosing(cancelSourceRoutedEventArgs);
					num = (short)713097248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13E:
					num = (short)1017446435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20B:
					this.OnClosed(new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfDock.DockWindow.ClosedEvent, this));
					parentGroup = this.ParentGroup;
					num = (short)222167053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_246:
					num = (short)469630982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A5:
					num = (short)1167458318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E8:
					base.Loaded -= this.a;
					num = (short)2055995433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_417:
					flag = true;
					num = (short)621477893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_438:
					num = (short)1509883906;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_477:
					parentGroup = this.ParentGroup;
					flag = false;
					num = (short)479395888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5EB:
					base.Visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)540672024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6DE:
					dockSite2 = this.GetDockSite();
					num = (short)34078743;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_75F:
					num4++;
					num = (short)1465516063;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_412:
				return true;
			}
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000337DC File Offset: 0x000319DC
		protected virtual void OnClosed(global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)154861568;
			short num2 = num;
			num = (short)1251122328;
			short num3 = num;
			num = (short)961780888;
			switch (num3 == num)
			{
			}
			num = (short)1322319872;
			if (num != 0)
			{
			}
			num = (short)863698945;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0003388C File Offset: 0x00031A8C
		protected virtual void OnClosing(global::DevComponents.WpfDock.CancelSourceRoutedEventArgs e)
		{
			short num = (short)9043968;
			short num2 = num;
			num = (short)367766636;
			short num3 = num;
			num = (short)1349889132;
			switch (num3 == num)
			{
			}
			num = (short)1625489409;
			if (num != 0)
			{
			}
			num = (short)1473314816;
			if (num != 0)
			{
			}
			base.RaiseEvent(e);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0003393C File Offset: 0x00031B3C
		public void Open()
		{
			short num = (short)1339817985;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::DevComponents.WpfDock.DockWindowGroup parentGroup;
				switch (num2)
				{
				case 0:
					if (parentGroup != null)
					{
						num = (short)709361666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_14;
				case 2:
					parentGroup.UpdateVisibility();
					num = (short)1610350597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					parentGroup.Visibility = global::System.Windows.Visibility.Visible;
					num = (short)1869873158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				case 5:
					num = (short)115539969;
					if (num != 0)
					{
					}
					if (parentGroup.Visibility != global::System.Windows.Visibility.Visible)
					{
						num = (short)488243200;
						short num3 = num;
						num = (short)434110467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_168;
				case 6:
					goto IL_168;
				case 7:
				{
					num = (short)1057910759;
					short num4 = num;
					num = (short)1860268007;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						goto IL_97;
					}
					break;
				}
				}
				goto IL_44;
				IL_14:
				switch (0)
				{
				case 0:
					IL_44:
					if (base.Visibility == global::System.Windows.Visibility.Visible)
					{
						num = (short)1575682055;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						base.Visibility = global::System.Windows.Visibility.Visible;
						parentGroup = this.ParentGroup;
						num = (short)1926496256;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				continue;
				IL_168:
				parentGroup.UpdateTabVisibility();
				num = (short)1508507652;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_97:
			num = (short)369491968;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x00033B18 File Offset: 0x00031D18
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00033BC8 File Offset: 0x00031DC8
		internal string LastDockWindowGroupId
		{
			get
			{
				short num = (short)269156352;
				short num2 = num;
				num = (short)954505275;
				short num3 = num;
				num = (short)453548091;
				switch (num3 == num)
				{
				}
				num = (short)212992001;
				if (num != 0)
				{
				}
				num = (short)1458044928;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)636813312;
				short num2 = num;
				num = (short)1096925459;
				short num3 = num;
				num = (short)55492883;
				switch (num3 == num)
				{
				}
				num = (short)1059127297;
				if (num != 0)
				{
				}
				num = (short)47906816;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00033C78 File Offset: 0x00031E78
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00033D28 File Offset: 0x00031F28
		internal global::System.Windows.Controls.Dock LastDock
		{
			get
			{
				short num = (short)359268352;
				short num2 = num;
				num = (short)1401521147;
				short num3 = num;
				num = (short)1568965627;
				switch (num3 == num)
				{
				}
				num = (short)671481857;
				if (num != 0)
				{
				}
				num = (short)1421082624;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)984875008;
				short num2 = num;
				num = (short)1748442529;
				short num3 = num;
				num = (short)957685153;
				switch (num3 == num)
				{
				}
				num = (short)1226571777;
				if (num != 0)
				{
				}
				num = (short)1736114176;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00033DD8 File Offset: 0x00031FD8
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00033E88 File Offset: 0x00032088
		internal global::DevComponents.WpfDock.DockWindowGroup LastDockWindowGroup
		{
			get
			{
				short num = (short)564985856;
				short num2 = num;
				num = (short)851836929;
				if (num != 0)
				{
				}
				num = (short)1412538174;
				short num3 = num;
				num = (short)1425317694;
				switch (num3 == num)
				{
				}
				num = (short)1742995456;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1356529664;
				short num2 = num;
				num = (short)1369915081;
				short num3 = num;
				num = (short)187317961;
				switch (num3 == num)
				{
				}
				num = (short)136904705;
				if (num != 0)
				{
				}
				num = (short)1705574400;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00033F38 File Offset: 0x00032138
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00033FE8 File Offset: 0x000321E8
		internal global::System.Windows.Size LastDockedSize
		{
			get
			{
				short num = (short)1771241472;
				short num2 = num;
				num = (short)769292007;
				short num3 = num;
				num = (short)1984722663;
				switch (num3 == num)
				{
				}
				num = (short)1190789121;
				if (num != 0)
				{
				}
				num = (short)49610752;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)393281536;
				short num2 = num;
				num = (short)670960892;
				short num3 = num;
				num = (short)497421564;
				switch (num3 == num)
				{
				}
				num = (short)2132082689;
				if (num != 0)
				{
				}
				num = (short)740163584;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00034098 File Offset: 0x00032298
		// (set) Token: 0x060001CC RID: 460 RVA: 0x0003414C File Offset: 0x0003234C
		internal global::System.Windows.Size LastAutoHideSize
		{
			get
			{
				short num = (short)830078976;
				short num2 = num;
				num = (short)1681069072;
				short num3 = num;
				num = (short)282203152;
				switch (num3 == num)
				{
				}
				num = (short)1583677441;
				if (num != 0)
				{
				}
				num = (short)16056320;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)722206720;
				short num2 = num;
				num = (short)1232417328;
				short num3 = num;
				num = (short)702034480;
				switch (num3 == num)
				{
				}
				num = (short)195690496;
				if (num != 0)
				{
				}
				num = (short)1327693825;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00034200 File Offset: 0x00032400
		internal void m()
		{
			short num = (short)1922957312;
			short num2 = num;
			num = (short)1984325758;
			short num3 = num;
			num = (short)692611198;
			switch (num3 == num)
			{
			}
			num = (short)175046657;
			if (num != 0)
			{
			}
			num = (short)571801600;
			if (num != 0)
			{
			}
			this.OnDockParentChanged(new global::System.EventArgs());
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000342B0 File Offset: 0x000324B0
		protected virtual void OnDockParentChanged(global::System.EventArgs e)
		{
			short num = (short)664911568;
			short num2 = num;
			num = (short)2052570832;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1553006592;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				int num3;
				global::System.EventHandler eventHandler;
				for (;;)
				{
					IL_55:
					switch (num3)
					{
					case 0:
						eventHandler(this, e);
						num = (short)1197211649;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_116;
					case 2:
						if (eventHandler != null)
						{
							num = (short)321978368;
							short num4 = num;
							num = (short)1388118016;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_67;
				}
				IL_116:
				break;
				IL_67:
				num = (short)186580993;
				if (num != 0)
				{
				}
				eventHandler = this.b;
				num = (short)199360514;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_55;
			}
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000343D8 File Offset: 0x000325D8
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x0003448C File Offset: 0x0003268C
		public global::DevComponents.WpfDock.DockWindowGroup PreviousGroup
		{
			get
			{
				short num = (short)1270218752;
				short num2 = num;
				num = (short)1040086288;
				short num3 = num;
				num = (short)1795716368;
				switch (num3 == num)
				{
				}
				num = (short)9895937;
				if (num != 0)
				{
				}
				num = (short)2032271360;
				if (num != 0)
				{
				}
				return this.n;
			}
			set
			{
				short num = (short)1723006976;
				short num2 = num;
				num = (short)1676145536;
				short num3 = num;
				num = (short)1763701632;
				switch (num3 == num)
				{
				}
				num = (short)2132869121;
				if (num != 0)
				{
				}
				num = (short)274333696;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0003453C File Offset: 0x0003273C
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x000345EC File Offset: 0x000327EC
		public global::System.Windows.Controls.Canvas AutoHidePopupWnd
		{
			get
			{
				short num = (short)1353908224;
				short num2 = num;
				num = (short)795934721;
				if (num != 0)
				{
				}
				num = (short)348120628;
				short num3 = num;
				num = (short)697165364;
				switch (num3 == num)
				{
				}
				num = (short)296288256;
				if (num != 0)
				{
				}
				return this.o;
			}
			set
			{
				short num = (short)1021007351;
				short num2 = num;
				num = (short)39933431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)395509760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2126381057;
				if (num != 0)
				{
				}
				num = (short)1933508608;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0003469C File Offset: 0x0003289C
		public bool IsMouseWithinAutoHidePopup()
		{
			short num = (short)174063618;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_141;
				case 1:
					num = (short)101646339;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 3:
				{
					if (!this.o.IsMouseOver)
					{
						num = (short)910426112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)898196184;
					short num3 = num;
					num = (short)827089624;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_40;
					default:
						goto IL_90;
					}
					break;
				}
				}
				goto IL_35;
				IL_40:
				num = (short)1731330049;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35:
				if (this.o != null)
				{
					goto IL_40;
				}
				return false;
			}
			IL_90:
			num = (short)1247805440;
			short num4 = num;
			num = (short)2037907457;
			if (num != 0)
			{
			}
			num = (short)72810496;
			if (num != 0)
			{
			}
			return true;
			IL_141:
			return global::DevComponents.WpfDock.i.a(this.o);
		}

		// Token: 0x040000DB RID: 219
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty;

		// Token: 0x040000DC RID: 220
		public static readonly global::System.Windows.DependencyProperty CanAutoHideProperty;

		// Token: 0x040000DD RID: 221
		public static readonly global::System.Windows.DependencyProperty CanCloseProperty;

		// Token: 0x040000DE RID: 222
		public static readonly global::System.Windows.DependencyProperty CanFloatProperty;

		// Token: 0x040000DF RID: 223
		public static readonly global::System.Windows.DependencyProperty CanTearOffProperty;

		// Token: 0x040000E0 RID: 224
		public static readonly global::System.Windows.DependencyProperty CanDockLeftProperty;

		// Token: 0x040000E1 RID: 225
		public static readonly global::System.Windows.DependencyProperty CanDockRightProperty;

		// Token: 0x040000E2 RID: 226
		public static readonly global::System.Windows.DependencyProperty CanDockTopProperty;

		// Token: 0x040000E3 RID: 227
		public static readonly global::System.Windows.DependencyProperty CanDockBottomProperty;

		// Token: 0x040000E4 RID: 228
		public static readonly global::System.Windows.DependencyProperty CanDockAsDocumentProperty;

		// Token: 0x040000E5 RID: 229
		public static readonly global::System.Windows.DependencyProperty IsAutoHideProperty;

		// Token: 0x040000E6 RID: 230
		public static readonly global::System.Windows.DependencyProperty AutoHideOpenProperty;

		// Token: 0x040000E7 RID: 231
		public static readonly global::System.Windows.DependencyProperty OptionsMenuProperty;

		// Token: 0x040000E8 RID: 232
		public static readonly global::System.Windows.DependencyProperty CustomOptionsMenuProperty;

		// Token: 0x040000E9 RID: 233
		public static readonly global::System.Windows.DependencyProperty ImageProperty;

		// Token: 0x040000EA RID: 234
		public static readonly global::System.Windows.DependencyProperty ImageSourceProperty;

		// Token: 0x040000EB RID: 235
		public static readonly global::System.Windows.DependencyProperty DescriptionProperty;

		// Token: 0x040000EC RID: 236
		public static readonly global::System.Windows.DependencyProperty FloatingRectProperty;

		// Token: 0x040000ED RID: 237
		public static readonly global::System.Windows.DependencyProperty AttentionRequiredProperty;

		// Token: 0x040000EE RID: 238
		public static global::System.Windows.Input.RoutedCommand ToggleAutoHide;

		// Token: 0x040000EF RID: 239
		public static global::System.Windows.Input.RoutedCommand OpenAutoHide;

		// Token: 0x040000F0 RID: 240
		public static global::System.Windows.Input.RoutedCommand CloseAutoHide;

		// Token: 0x040000F1 RID: 241
		public static global::System.Windows.Input.RoutedCommand CloseWindow;

		// Token: 0x040000F2 RID: 242
		public static global::System.Windows.Input.RoutedCommand FloatWindow;

		// Token: 0x040000F3 RID: 243
		public static global::System.Windows.Input.RoutedCommand ReDockWindow;

		// Token: 0x040000F4 RID: 244
		public static global::System.Windows.Input.RoutedCommand DockAsDocumentWindow;

		// Token: 0x040000F5 RID: 245
		public static global::System.Windows.Input.RoutedCommand SelectWindow;

		// Token: 0x040000FC RID: 252
		internal static global::System.Windows.Rect a;

		// Token: 0x040000FD RID: 253
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler b;

		// Token: 0x040000FF RID: 255
		public static readonly global::System.Windows.DependencyProperty TabToolTipProperty;

		// Token: 0x04000100 RID: 256
		public static readonly global::System.Windows.DependencyProperty AutoCloseProperty;

		// Token: 0x04000101 RID: 257
		public static readonly global::System.Windows.DependencyProperty CloseButtonVisibilityProperty;

		// Token: 0x04000102 RID: 258
		private string c = "";

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Controls.Dock d;

		// Token: 0x04000104 RID: 260
		private global::DevComponents.WpfDock.DockWindowGroup e;

		// Token: 0x04000105 RID: 261
		private global::System.Windows.Size f;

		// Token: 0x04000106 RID: 262
		private global::System.Windows.Size g;

		// Token: 0x04000107 RID: 263
		private global::System.Windows.Threading.DispatcherTimer h;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Point i;

		// Token: 0x04000109 RID: 265
		private bool j;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Controls.Decorator k;

		// Token: 0x0400010B RID: 267
		private global::DevComponents.WpfDock.DockWindowGroup l;

		// Token: 0x0400010C RID: 268
		internal bool m;

		// Token: 0x0400010D RID: 269
		public static bool isCPSWindowHidden;

		// Token: 0x0400010E RID: 270
		private global::DevComponents.WpfDock.DockWindowGroup n;

		// Token: 0x0400010F RID: 271
		private global::System.Windows.Controls.Canvas o;

		// Token: 0x02000023 RID: 35
		private class a
		{
			// Token: 0x060001D4 RID: 468 RVA: 0x000347F0 File Offset: 0x000329F0
			public a(global::DevComponents.WpfDock.DockWindowGroup A_0, bool A_1, global::DevComponents.WpfDock.eEventActionSource A_2)
			{
				this.a = A_0;
				this.b = A_1;
				this.c = A_2;
			}

			// Token: 0x04000110 RID: 272
			public global::DevComponents.WpfDock.DockWindowGroup a;

			// Token: 0x04000111 RID: 273
			public bool b;

			// Token: 0x04000112 RID: 274
			public global::DevComponents.WpfDock.eEventActionSource c;
		}
	}
}
