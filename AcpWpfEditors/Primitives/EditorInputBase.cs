using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DevComponents.WpfEditors.Primitives
{
	// Token: 0x02000064 RID: 100
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class EditorInputBase : global::DevComponents.WpfEditors.Primitives.EditorElement
	{
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x0600067A RID: 1658 RVA: 0x00088260 File Offset: 0x00086460
		// (remove) Token: 0x0600067B RID: 1659 RVA: 0x00088394 File Offset: 0x00086594
		public event global::System.EventHandler IsEmptyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					global::System.EventHandler eventHandler;
					global::System.EventHandler eventHandler2;
					switch (num)
					{
					case 0:
						return;
					case 1:
						num2 = (short)1761804289;
						if (num2 != 0)
						{
						}
						goto IL_D6;
					case 2:
						if (eventHandler == eventHandler2)
						{
							goto IL_10E;
						}
						goto IL_D6;
					}
					goto IL_1C;
					IL_D6:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.e, value2, eventHandler2);
					num2 = (short)455344130;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				num2 = (short)1764581078;
				short num3 = num2;
				num2 = (short)682319574;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_10E:
					num2 = (short)406913024;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				default:
				{
					num2 = (short)213319680;
					short num4 = num2;
					num2 = (short)1732050944;
					if (num2 != 0)
					{
					}
					global::System.EventHandler eventHandler = this.e;
					num2 = (short)1089798145;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
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
						return;
					case 1:
					{
						num2 = (short)1046264495;
						short num3 = num2;
						num2 = (short)1847900847;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)814350337;
							if (num2 != 0)
							{
							}
							num2 = (short)117506048;
							if (num2 != 0)
							{
							}
							num2 = (short)1708064768;
							short num4 = num2;
							if (eventHandler == eventHandler2)
							{
								num2 = (short)1068302336;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_39;
						}
						}
						break;
					}
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					IL_39:
					eventHandler2 = eventHandler;
					global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
					eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.e, value2, eventHandler2);
					num2 = (short)1932197889;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				eventHandler = this.e;
				num2 = (short)345964546;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x0600067C RID: 1660 RVA: 0x000884C4 File Offset: 0x000866C4
		// (remove) Token: 0x0600067D RID: 1661 RVA: 0x0008857C File Offset: 0x0008677C
		public event global::System.Windows.RoutedEventHandler InputChanged
		{
			add
			{
				short num = (short)1290993664;
				short num2 = num;
				num = (short)24796671;
				short num3 = num;
				num = (short)1315986943;
				switch (num3 == num)
				{
				}
				num = (short)852295681;
				if (num != 0)
				{
				}
				num = (short)61210624;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.Primitives.EditorInputBase.InputChangedEvent, value);
			}
			remove
			{
				short num = (short)1184235520;
				short num2 = num;
				num = (short)790642699;
				short num3 = num;
				num = (short)600457227;
				switch (num3 == num)
				{
				}
				num = (short)563150848;
				if (num != 0)
				{
				}
				num = (short)552075265;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.Primitives.EditorInputBase.InputChangedEvent, value);
			}
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x0600067E RID: 1662 RVA: 0x00088634 File Offset: 0x00086834
		// (remove) Token: 0x0600067F RID: 1663 RVA: 0x000886EC File Offset: 0x000868EC
		public event global::System.Windows.RoutedEventHandler PreviewInputChanged
		{
			add
			{
				short num = (short)998375424;
				short num2 = num;
				num = (short)651165697;
				if (num != 0)
				{
				}
				num = (short)120508135;
				short num3 = num;
				num = (short)1691209447;
				switch (num3 == num)
				{
				}
				num = (short)1319567360;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.Primitives.EditorInputBase.PreviewInputChangedEvent, value);
			}
			remove
			{
				short num = (short)559546368;
				short num2 = num;
				num = (short)2091901608;
				short num3 = num;
				num = (short)49996456;
				switch (num3 == num)
				{
				}
				num = (short)543096833;
				if (num != 0)
				{
				}
				num = (short)997064704;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.Primitives.EditorInputBase.PreviewInputChangedEvent, value);
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000887A4 File Offset: 0x000869A4
		protected virtual void OnInputChanged()
		{
			short num = (short)921595385;
			short num2 = num;
			num = (short)1279880697;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1190461440;
				if (num != 0)
				{
				}
				global::System.Windows.RoutedEventArgs routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.Primitives.EditorInputBase.PreviewInputChangedEvent);
				base.RaiseEvent(routedEventArgs);
				if (routedEventArgs.Handled)
				{
					num = (short)120127488;
					short num3 = num;
					num = (short)678428673;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			}
			global::System.Windows.RoutedEventArgs routedEventArgs2 = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.Primitives.EditorInputBase.InputChangedEvent);
			base.RaiseEvent(routedEventArgs2);
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06000681 RID: 1665 RVA: 0x00088880 File Offset: 0x00086A80
		// (remove) Token: 0x06000682 RID: 1666 RVA: 0x00088938 File Offset: 0x00086B38
		public event global::System.Windows.RoutedEventHandler ValidateInput
		{
			add
			{
				short num = (short)256311296;
				short num2 = num;
				num = (short)1368477302;
				short num3 = num;
				num = (short)688672374;
				switch (num3 == num)
				{
				}
				num = (short)1110573057;
				if (num != 0)
				{
				}
				num = (short)630652928;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.Primitives.EditorInputBase.ValidateInputEvent, value);
			}
			remove
			{
				short num = (short)385613824;
				short num2 = num;
				num = (short)2012461443;
				short num3 = num;
				num = (short)1290910083;
				switch (num3 == num)
				{
				}
				num = (short)848953345;
				if (num != 0)
				{
				}
				num = (short)525860864;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.Primitives.EditorInputBase.ValidateInputEvent, value);
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000889EC File Offset: 0x00086BEC
		protected virtual void OnValidateInput(global::DevComponents.WpfEditors.Primitives.InputValidationRoutedEventArgs eventArgs)
		{
			short num = (short)635305984;
			short num2 = num;
			num = (short)1780107350;
			short num3 = num;
			num = (short)834422870;
			switch (num3 == num)
			{
			}
			num = (short)2080112641;
			if (num != 0)
			{
			}
			num = (short)80740352;
			if (num != 0)
			{
			}
			base.RaiseEvent(eventArgs);
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00088A9C File Offset: 0x00086C9C
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x00088B54 File Offset: 0x00086D54
		public bool IsReadOnly
		{
			get
			{
				short num = (short)160301056;
				short num2 = num;
				num = (short)1855121605;
				short num3 = num;
				num = (short)1772218565;
				switch (num3 == num)
				{
				}
				num = (short)1620770817;
				if (num != 0)
				{
				}
				num = (short)621740032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputBase.IsReadOnlyProperty);
			}
			set
			{
				short num = (short)22216704;
				short num2 = num;
				num = (short)700912008;
				short num3 = num;
				num = (short)293343624;
				switch (num3 == num)
				{
				}
				num = (short)796459009;
				if (num != 0)
				{
				}
				num = (short)1967718400;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputBase.IsReadOnlyProperty, value);
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00088C10 File Offset: 0x00086E10
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x00088CCC File Offset: 0x00086ECC
		public bool AutoOverwrite
		{
			get
			{
				short num = (short)496041984;
				short num2 = num;
				num = (short)1669546406;
				short num3 = num;
				num = (short)1370505638;
				switch (num3 == num)
				{
				}
				num = (short)1303642113;
				if (num != 0)
				{
				}
				num = (short)203948032;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputBase.AutoOverwriteProperty);
			}
			set
			{
				short num = (short)109838336;
				short num2 = num;
				num = (short)897402366;
				short num3 = num;
				num = (short)1981236734;
				switch (num3 == num)
				{
				}
				num = (short)1571553281;
				if (num != 0)
				{
				}
				num = (short)1293090816;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputBase.AutoOverwriteProperty, value);
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06000688 RID: 1672 RVA: 0x00088D88 File Offset: 0x00086F88
		// (remove) Token: 0x06000689 RID: 1673 RVA: 0x00088E40 File Offset: 0x00087040
		public event global::System.Windows.RoutedEventHandler InputComplete
		{
			add
			{
				short num = (short)546504704;
				short num2 = num;
				num = (short)1685047032;
				short num3 = num;
				num = (short)1062455032;
				switch (num3 == num)
				{
				}
				num = (short)253886465;
				if (num != 0)
				{
				}
				num = (short)1747320832;
				if (num != 0)
				{
				}
				base.AddHandler(global::DevComponents.WpfEditors.Primitives.EditorInputBase.InputCompleteEvent, value);
			}
			remove
			{
				short num = (short)366477312;
				short num2 = num;
				num = (short)441833848;
				short num3 = num;
				num = (short)1850333560;
				switch (num3 == num)
				{
				}
				num = (short)1982595072;
				if (num != 0)
				{
				}
				num = (short)17235969;
				if (num != 0)
				{
				}
				base.RemoveHandler(global::DevComponents.WpfEditors.Primitives.EditorInputBase.InputCompleteEvent, value);
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00088EF4 File Offset: 0x000870F4
		protected virtual void OnInputComplete()
		{
			short num = (short)1503789056;
			short num2 = num;
			num = (short)1571525159;
			short num3 = num;
			num = (short)235639335;
			switch (num3 == num)
			{
			}
			num = (short)1285947393;
			if (num != 0)
			{
			}
			num = (short)1246035968;
			if (num != 0)
			{
			}
			global::System.Windows.RoutedEventArgs routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.Primitives.EditorInputBase.InputCompleteEvent);
			base.RaiseEvent(routedEventArgs);
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00088FB4 File Offset: 0x000871B4
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x0008906C File Offset: 0x0008726C
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Media.Brush FocusedBackground
		{
			get
			{
				short num = (short)1795096576;
				short num2 = num;
				num = (short)1758264097;
				short num3 = num;
				num = (short)1277754145;
				switch (num3 == num)
				{
				}
				num = (short)682229760;
				if (num != 0)
				{
				}
				num = (short)1829437441;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputBase.FocusedBackgroundProperty);
			}
			set
			{
				short num = (short)1214578688;
				short num2 = num;
				num = (short)723163621;
				short num3 = num;
				num = (short)1333500389;
				switch (num3 == num)
				{
				}
				num = (short)1092222977;
				if (num != 0)
				{
				}
				num = (short)1446838272;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputBase.FocusedBackgroundProperty, value);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00089120 File Offset: 0x00087320
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x000891DC File Offset: 0x000873DC
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Appearance")]
		public global::System.Windows.Media.Brush FocusedForeground
		{
			get
			{
				short num = (short)1612447744;
				short num2 = num;
				num = (short)645654460;
				short num3 = num;
				num = (short)804513724;
				switch (num3 == num)
				{
				}
				num = (short)1021378561;
				if (num != 0)
				{
				}
				num = (short)1447624704;
				if (num != 0)
				{
				}
				return (global::System.Windows.Media.Brush)base.GetValue(global::DevComponents.WpfEditors.Primitives.EditorInputBase.FocusedForegroundProperty);
			}
			set
			{
				short num = (short)1058340864;
				short num2 = num;
				num = (short)1937051887;
				short num3 = num;
				num = (short)1279791343;
				switch (num3 == num)
				{
				}
				num = (short)1769930752;
				if (num != 0)
				{
				}
				num = (short)533331969;
				if (num != 0)
				{
				}
				base.SetValue(global::DevComponents.WpfEditors.Primitives.EditorInputBase.FocusedForegroundProperty, value);
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x00089290 File Offset: 0x00087490
		static EditorInputBase()
		{
			int a_ = 5;
			short num = (short)205127680;
			short num2 = num;
			num = (short)282460161;
			if (num != 0)
			{
			}
			num = (short)170599451;
			short num3 = num;
			num = (short)427369499;
			switch (num3 == num)
			{
			}
			num = (short)1771896832;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.Primitives.EditorInputBase.InputChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯑뫓ꛕ귗껙鿛뛝臟賡菣菥賧", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase));
			global::DevComponents.WpfEditors.Primitives.EditorInputBase.PreviewInputChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("苑ꛓ돕껗동맛꧝꧟賡铣鏥鳧ꧩ蓫迭黯闱釳鋵", a_), global::System.Windows.RoutingStrategy.Tunnel, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase));
			global::DevComponents.WpfEditors.Primitives.EditorInputBase.ValidateInputEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("蓑뗓뫕뇗뻙뷛ꫝ藟ꯡ諣雥鷧黩", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase));
			global::DevComponents.WpfEditors.Primitives.EditorInputBase.IsReadOnlyProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯑ꟓ蓕뷗믙룛針軟軡鷣", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfEditors.Primitives.EditorInputBase.AutoOverwriteProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鏑ꇓꋕ럗闙ꫛ믝鋟闡難迥鳧迩", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase), new global::System.Windows.UIPropertyMetadata(false));
			global::DevComponents.WpfEditors.Primitives.EditorInputBase.InputCompleteEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鯑뫓ꛕ귗껙鿛뇝跟鋡裣菥鳧迩", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase));
			global::DevComponents.WpfEditors.Primitives.EditorInputBase.FocusedBackgroundProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("铑믓뗕귗꧙맛뫝ꋟ菡蟣跥迧飩菫鯭黯雱", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::DevComponents.WpfEditors.Primitives.EditorInputBase.FocusedForegroundProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("铑믓뗕귗꧙맛뫝ꛟ跡難菥迧飩菫鯭黯雱", a_), typeof(global::System.Windows.Media.Brush), typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase), new global::System.Windows.FrameworkPropertyMetadata(true));
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::DevComponents.WpfEditors.Primitives.EditorElement.BackgroundProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.Primitives.EditorGroup), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Media.Brushes.Transparent));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase), new global::System.Windows.Input.CommandBinding(global::System.Windows.Input.ApplicationCommands.Undo, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::DevComponents.WpfEditors.Primitives.EditorInputBase.a), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::DevComponents.WpfEditors.Primitives.EditorInputBase.a)));
			global::System.Windows.FrameworkElement.HorizontalAlignmentProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.Primitives.EditorInputBase), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.HorizontalAlignment.Left));
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x00089574 File Offset: 0x00087774
		public EditorInputBase()
		{
			base.FocusVisualStyle = null;
			base.SnapsToDevicePixels = true;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x000895BC File Offset: 0x000877BC
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			short num = (short)833028098;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_118;
				case 1:
					goto IL_A1;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (base.IsKeyboardFocused)
				{
					break;
				}
				num = (short)35235181;
				short num3 = num;
				num = (short)1163240813;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1675034624;
					if (num != 0)
					{
					}
					num = (short)1211105281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A1:
				num = (short)1870462977;
				if (num != 0)
				{
				}
				num = (short)2228224;
				short num4 = num;
				base.Focus();
				e.Handled = true;
				num = (short)137756672;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_118:
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000896EC File Offset: 0x000878EC
		protected virtual string GetInputStringValue()
		{
			short num = (short)1751515136;
			short num2 = num;
			num = (short)1435000070;
			short num3 = num;
			num = (short)1318280454;
			switch (num3 == num)
			{
			}
			num = (short)766181376;
			if (num != 0)
			{
			}
			num = (short)1042153473;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0008979C File Offset: 0x0008799C
		private static void a(object A_0, global::System.Windows.Input.ExecutedRoutedEventArgs A_1)
		{
			short num = (short)2065235968;
			short num2 = num;
			num = (short)1891175137;
			short num3 = num;
			num = (short)556600033;
			switch (num3 == num)
			{
			}
			num = (short)565510145;
			if (num != 0)
			{
			}
			num = (short)1705181184;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.Primitives.EditorInputBase)A_0).OnUndoCommand(A_1);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00089854 File Offset: 0x00087A54
		protected virtual void OnUndoCommand(global::System.Windows.Input.ExecutedRoutedEventArgs args)
		{
			short num = (short)1184432128;
			short num2 = num;
			num = (short)557802875;
			short num3 = num;
			num = (short)21063035;
			switch (num3 == num)
			{
			}
			num = (short)1776484353;
			if (num != 0)
			{
			}
			num = (short)193658880;
			if (num != 0)
			{
			}
			this.OnUndo();
			args.Handled = true;
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0008990C File Offset: 0x00087B0C
		private static void a(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)1567490048;
			short num2 = num;
			num = (short)1492738819;
			short num3 = num;
			num = (short)1824023299;
			switch (num3 == num)
			{
			}
			num = (short)716439552;
			if (num != 0)
			{
			}
			num = (short)234291201;
			if (num != 0)
			{
			}
			((global::DevComponents.WpfEditors.Primitives.EditorInputBase)A_0).OnCanExecuteUndoCommand(A_1);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x000899C0 File Offset: 0x00087BC0
		protected virtual void OnCanExecuteUndoCommand(global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			short num = (short)197656576;
			short num2 = num;
			num = (short)1175059858;
			short num3 = num;
			num = (short)464715154;
			switch (num3 == num)
			{
			}
			num = (short)1366622208;
			if (num != 0)
			{
			}
			num = (short)594870273;
			if (num != 0)
			{
			}
			args.CanExecute = !this.IsReadOnly;
			args.Handled = true;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00089A84 File Offset: 0x00087C84
		protected virtual void OnUndo()
		{
			short num = (short)1406730242;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_A4;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (!this.SetInputStack(this.d))
				{
					break;
				}
				num = (short)399336731;
				short num3 = num;
				num = (short)663184667;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)538247168;
					if (num != 0)
					{
					}
					num = (short)323551233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A4:
				num = (short)1885536257;
				if (num != 0)
				{
				}
				num = (short)548077568;
				short num4 = num;
				this.ResetInputStack();
				this.OnInputKeyAccepted();
				num = (short)649134080;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00089BAC File Offset: 0x00087DAC
		public void UndoInput()
		{
			short num = (short)405209088;
			short num2 = num;
			num = (short)1939765346;
			short num3 = num;
			num = (short)1069643874;
			switch (num3 == num)
			{
			}
			num = (short)822935552;
			if (num != 0)
			{
			}
			num = (short)1136656385;
			if (num != 0)
			{
			}
			this.OnUndo();
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00089C58 File Offset: 0x00087E58
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)99418114;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_110;
				case 1:
					goto IL_C7;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (this.IsReadOnly)
				{
					break;
				}
				num = (short)788864330;
				short num3 = num;
				num = (short)377625930;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1577648129;
					if (num != 0)
					{
					}
					num = (short)1597571072;
					if (num != 0)
					{
					}
					num = (short)71958529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C7:
				num = (short)1736114176;
				short num4 = num;
				this.OnInputKeyDown(e);
				num = (short)1266679808;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_110:
			base.OnKeyDown(e);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00089D80 File Offset: 0x00087F80
		protected virtual void OnInputKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)1436745728;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1E:
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 1:
					return;
				case 2:
					this.ProcessDelete(e);
					num = (short)255918081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					while (e.Key == global::System.Windows.Input.Key.Delete)
					{
						num = (short)766649080;
						short num3 = num;
						num = (short)1855660792;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)216596480;
							short num4 = num;
							num = (short)1197998081;
							if (num != 0)
							{
							}
							num = (short)1101529088;
							if (num != 0)
							{
							}
							num = (short)1578893314;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E;
						}
						}
					}
					return;
				case 4:
					goto IL_55;
				}
				IL_38:
				if (e.Key == global::System.Windows.Input.Key.Back)
				{
					num = (short)945750020;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)385024003;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_55:
			this.ProcessBackSpace(e);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00089EE8 File Offset: 0x000880E8
		protected virtual void OnClear()
		{
			short num = (short)73990146;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					IL_187:
					((global::DevComponents.WpfEditors.Primitives.EditorInputGroup)base.Parent).IsEmpty = true;
					num = (short)1949040641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_D1;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 3:
					num = (short)943587332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)295043072;
					short num3 = num;
					if (base.Parent is global::DevComponents.WpfEditors.Primitives.EditorInputGroup)
					{
						num = (short)1584332800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				}
				case 5:
					this.a = 0;
					num = (short)1430519814;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return;
				case 7:
					if (this.SetInputStack(""))
					{
						num = (short)1439236097;
						if (num != 0)
						{
						}
						num = (short)2105147397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_44:
				if (this.IsEmpty)
				{
					num = (short)422838275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)197132295;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D1:
				num = (short)1217169712;
				short num4 = num;
				num = (short)1113753904;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_187;
				default:
					goto IL_105;
				}
			}
			IL_105:
			num = (short)751894528;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0008A0CC File Offset: 0x000882CC
		protected virtual void ProcessDelete(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)886636546;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_10F;
				case 1:
					goto IL_C8;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (this.IsEmpty)
				{
					break;
				}
				num = (short)69205313;
				short num3 = num;
				num = (short)1237122369;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1093271553;
					if (num != 0)
					{
					}
					num = (short)834273280;
					if (num != 0)
					{
					}
					num = (short)307036161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C8:
				num = (short)1423704064;
				short num4 = num;
				e.Handled = true;
				num = (short)294584320;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			this.OnClear();
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0008A1F0 File Offset: 0x000883F0
		protected virtual void ProcessBackSpace(global::System.Windows.Input.KeyEventArgs e)
		{
			short num = (short)668270596;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.a--;
					num = (short)1520959493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1716968272;
					short num3 = num;
					num = (short)1146411856;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)269352960;
						if (num != 0)
						{
						}
						string inputStack = this.b.Substring(0, this.a - 1) + this.b.Substring(this.a);
						num = (short)788791302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					num = (short)60751881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)396886017;
					if (num != 0)
					{
					}
					num = (short)983826439;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 5:
					goto IL_9A;
				case 6:
				{
					string inputStack;
					if (this.SetInputStack(inputStack))
					{
						num = (short)266534914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_239;
				}
				case 7:
				{
					num = (short)1477705728;
					short num4 = num;
					if (this.a > 0)
					{
						num = (short)1200750593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B2;
				}
				case 8:
					goto IL_1D0;
				case 9:
					if (this.a > 0)
					{
						num = (short)1573847040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_239;
				}
				IL_4E:
				if (this.b.Length > 0)
				{
					num = (short)210042883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1B2:
				this.OnClear();
				num = (short)1075249160;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9A:
			IL_1D0:
			IL_239:
			e.Handled = true;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0008A440 File Offset: 0x00088640
		protected override void OnTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			short num = (short)1610350594;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_10B;
				case 1:
					goto IL_9B;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (this.IsReadOnly)
				{
					break;
				}
				num = (short)399453081;
				short num3 = num;
				num = (short)1158818713;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)6291456;
					if (num != 0)
					{
					}
					num = (short)1935933441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9B:
				num = (short)1091960833;
				if (num != 0)
				{
				}
				num = (short)1401880576;
				short num4 = num;
				this.OnInputKeyPress(e);
				num = (short)91684864;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			e.Handled = true;
			base.OnTextInput(e);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0008A568 File Offset: 0x00088768
		protected virtual void OnInputKeyPress(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			short num = (short)1791623170;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					num = (short)508362753;
					if (num != 0)
					{
					}
					goto IL_C5;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (!this.AcceptKeyPress(e))
				{
					break;
				}
				num = (short)631061514;
				short num3 = num;
				num = (short)627194890;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1473118208;
					if (num != 0)
					{
					}
					num = (short)1316945921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C5:
				num = (short)236519424;
				short num4 = num;
				this.UpdateInputStack(e.Text);
				num = (short)673185792;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0008A688 File Offset: 0x00088888
		protected virtual void UpdateInputStack(string text)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			string text2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					this.a = this.b.Length;
					num2 = (short)1326776326;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_20A;
				case 3:
					num2 = (short)1741815819;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_20A;
				case 5:
					if (this.c)
					{
						num2 = (short)1538850824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)736165889;
					if (num2 != 0)
					{
					}
					text2 = this.b.Substring(0, this.a - 1) + text + this.b.Substring(this.a + text.Length);
					num2 = (short)1047724041;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					IL_15A:
					goto IL_28B;
				case 7:
					if (this.a >= this.b.Length)
					{
						num2 = (short)1621229571;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1148977157;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					text2.Insert(this.a, text);
					num2 = (short)912457730;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_20A;
				case 10:
					this.a += text.Length;
					this.OnInputKeyAccepted();
					num2 = (short)277544960;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
				{
					num2 = (short)1421541376;
					short num3 = num2;
					if (this.a > this.b.Length)
					{
						num2 = (short)1800273921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28B;
				}
				case 12:
					if (this.SetInputStack(text2))
					{
						num2 = (short)1460928522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_44;
				IL_20A:
				num2 = (short)1810563084;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_28B:
				text2 += text;
				num2 = (short)2061476312;
				short num4 = num2;
				num2 = (short)518234584;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_15A;
				default:
					num2 = (short)340721664;
					if (num2 != 0)
					{
					}
					num2 = (short)601161732;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			return;
			IL_44:
			text2 = this.b;
			num2 = (short)2065563655;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0008A990 File Offset: 0x00088B90
		protected virtual void OnInputKeyAccepted()
		{
			short num = (short)2076597838;
			short num2 = num;
			num = (short)1493261902;
			switch (num2 == num)
			{
			default:
			{
				num = (short)833617920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1050083329;
			if (num != 0)
			{
			}
			num = (short)1128398848;
			if (num != 0)
			{
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0008AA38 File Offset: 0x00088C38
		protected virtual bool SetInputStack(string s)
		{
			short num = (short)1378521767;
			short num2 = num;
			num = (short)1701548711;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1375207425;
				if (num != 0)
				{
				}
				num = (short)1000734720;
				short num3 = num;
				num = (short)770244608;
				if (num != 0)
				{
				}
				if (this.ValidateNewInputStack(s))
				{
					this.b = s;
					this.OnInputStackChanged();
					return true;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0008AAF8 File Offset: 0x00088CF8
		protected virtual bool ValidateNewInputStack(string s)
		{
			short num = (short)1135544541;
			short num2 = num;
			num = (short)1083312349;
			switch (num2 == num)
			{
			default:
			{
				num = (short)522321920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1235812353;
			if (num != 0)
			{
			}
			num = (short)608763904;
			if (num != 0)
			{
			}
			global::DevComponents.WpfEditors.Primitives.InputValidationRoutedEventArgs inputValidationRoutedEventArgs = new global::DevComponents.WpfEditors.Primitives.InputValidationRoutedEventArgs(global::DevComponents.WpfEditors.Primitives.EditorInputBase.ValidateInputEvent, this, s);
			this.OnValidateInput(inputValidationRoutedEventArgs);
			return inputValidationRoutedEventArgs.AcceptInput;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0008ABBC File Offset: 0x00088DBC
		protected virtual void OnInputStackChanged()
		{
			short num = (short)1689600275;
			short num2 = num;
			num = (short)206323987;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1955463168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)564264960;
			if (num != 0)
			{
			}
			num = (short)837287937;
			if (num != 0)
			{
			}
			this.OnInputChanged();
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0008AC6C File Offset: 0x00088E6C
		protected virtual bool AcceptKeyPress(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			short num = (short)621470991;
			short num2 = num;
			num = (short)1066591503;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1138491393;
				if (num != 0)
				{
				}
				num = (short)1745027072;
				short num3 = num;
				num = (short)665255936;
				if (num != 0)
				{
				}
				e.Handled = true;
				if (e.Text.Length == 0)
				{
					return false;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0008AD2C File Offset: 0x00088F2C
		protected override void OnGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			short num = (short)2104834148;
			short num2 = num;
			num = (short)1107966052;
			switch (num2 == num)
			{
			default:
			{
				num = (short)189792256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1151991809;
			if (num != 0)
			{
			}
			num = (short)1376256000;
			if (num != 0)
			{
			}
			this.OnInputGotFocus();
			base.OnGotKeyboardFocus(e);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0008ADE4 File Offset: 0x00088FE4
		protected override void OnLostKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			short num = (short)1906026073;
			short num2 = num;
			num = (short)692561497;
			switch (num2 == num)
			{
			default:
			{
				num = (short)182321152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1071841280;
			if (num != 0)
			{
			}
			num = (short)1115815937;
			if (num != 0)
			{
			}
			this.OnInputLostFocus();
			base.OnLostKeyboardFocus(e);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0008AE98 File Offset: 0x00089098
		protected virtual void OnInputGotFocus()
		{
			short num = (short)1384809081;
			short num2 = num;
			num = (short)1458274937;
			switch (num2 == num)
			{
			default:
			{
				num = (short)238092288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)770113537;
			if (num != 0)
			{
			}
			num = (short)804519936;
			if (num != 0)
			{
			}
			this.ResetInputStack();
			this.ResetUndoStack();
			base.InvalidateMeasure();
			base.InvalidateVisual();
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0008AF58 File Offset: 0x00089158
		protected virtual void OnInputLostFocus()
		{
			short num = (short)598802433;
			if (num != 0)
			{
			}
			num = (short)701825024;
			short num2 = num;
			num = (short)697549786;
			short num3 = num;
			num = (short)2015151066;
			switch (num3 == num)
			{
			}
			num = (short)1914437632;
			if (num != 0)
			{
			}
			base.InvalidateMeasure();
			base.InvalidateVisual();
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0008B00C File Offset: 0x0008920C
		protected string InputStack
		{
			get
			{
				short num = (short)2008963046;
				short num2 = num;
				num = (short)959338470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)918355968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2081488897;
				if (num != 0)
				{
				}
				num = (short)629735424;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0008B0B8 File Offset: 0x000892B8
		protected void SetInputPosition(int position)
		{
			short num = (short)1862380985;
			short num2 = num;
			num = (short)742567353;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1741422592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)422969344;
			if (num != 0)
			{
			}
			num = (short)1790902273;
			if (num != 0)
			{
			}
			this.a = position;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x0008B170 File Offset: 0x00089370
		public int InputPosition
		{
			get
			{
				short num = (short)841699450;
				short num2 = num;
				num = (short)173822074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1014038528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1865744385;
				if (num != 0)
				{
				}
				num = (short)502136832;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0008B220 File Offset: 0x00089420
		protected bool IsInputStackEmpty
		{
			get
			{
				short num = (short)508912767;
				short num2 = num;
				num = (short)155346047;
				switch (num2 == num)
				{
				default:
				{
					num = (short)162004992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)123142145;
				if (num != 0)
				{
				}
				num = (short)666632192;
				if (num != 0)
				{
				}
				return this.b.Length == 0;
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0008B2D4 File Offset: 0x000894D4
		protected virtual void ResetUndoStack()
		{
			short num = (short)1812507261;
			short num2 = num;
			num = (short)1140697725;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2049114112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)174260225;
			if (num != 0)
			{
			}
			num = (short)270008320;
			if (num != 0)
			{
			}
			this.d = this.GetInputStringValue();
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0008B384 File Offset: 0x00089584
		protected virtual void TextInputComplete(bool sendNotification)
		{
			short num = (short)1519845378;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_170;
				case 1:
					this.ResetInputStack();
					num = (short)376963072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
				{
					num = (short)984834556;
					short num3 = num;
					num = (short)927490556;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_170;
					default:
					{
						num = (short)821297152;
						if (num != 0)
						{
						}
						num = (short)281870336;
						short num4 = num;
						num = (short)627703809;
						if (num != 0)
						{
						}
						if (sendNotification)
						{
							num = (short)1632043013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 4:
					return;
				case 5:
					this.OnInputComplete();
					num = (short)400818180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				if (this.AutoOverwrite)
				{
					num = (short)340656129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7F:
				num = (short)134414339;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_170:
				goto IL_7F;
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0008B508 File Offset: 0x00089708
		protected void ResetInputStack()
		{
			short num = (short)2002768666;
			short num2 = num;
			num = (short)1421071130;
			switch (num2 == num)
			{
			default:
			{
				num = (short)120258560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2135883777;
			if (num != 0)
			{
			}
			num = (short)1418067968;
			if (num != 0)
			{
			}
			this.b = "";
			this.a = 0;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0008B5C0 File Offset: 0x000897C0
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x0008B670 File Offset: 0x00089870
		public virtual bool IsEmpty
		{
			get
			{
				short num = (short)931613959;
				short num2 = num;
				num = (short)1844399367;
				switch (num2 == num)
				{
				default:
				{
					num = (short)683606016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1159266305;
				if (num != 0)
				{
				}
				num = (short)1191575552;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1059127299;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_174;
					case 1:
						goto IL_1BC;
					case 2:
						IL_1B7:
						goto IL_97;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 4:
						if (base.Parent is global::DevComponents.WpfEditors.Primitives.EditorInputGroup)
						{
							num = (short)2081816576;
							short num3 = num;
							num = (short)583794695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_174;
					case 5:
						num = (short)1610219526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)2033188865;
						if (num != 0)
						{
						}
						if (value)
						{
							num = (short)2065694728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_97;
					case 7:
						((global::DevComponents.WpfEditors.Primitives.EditorInputGroup)base.Parent).UpdateIsEmpty();
						num = (short)1921908736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						this.ResetValue();
						this.ResetInputStack();
						num = (short)2056192002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_49:
					if (value != this.f)
					{
						num = (short)539951109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BC;
					IL_97:
					this.f = value;
					base.InvalidateMeasure();
					base.InvalidateVisual();
					num = (short)1399062532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BC:
					num = (short)2009545402;
					short num4 = num;
					num = (short)84490938;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B7;
					default:
						goto IL_1F0;
					}
					IL_174:
					this.OnIsEmptyChanged();
					num = (short)1091567617;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F0:
				num = (short)1081212928;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0008B884 File Offset: 0x00089A84
		protected virtual void ResetValue()
		{
			short num = (short)1990989122;
			short num2 = num;
			num = (short)1519392066;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1381105664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)545914880;
			if (num != 0)
			{
			}
			num = (short)389218305;
			if (num != 0)
			{
			}
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0008B930 File Offset: 0x00089B30
		protected virtual void OnIsEmptyChanged()
		{
			short num = (short)2112487424;
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
					this.e(this, new global::System.EventArgs());
					num = (short)88080386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1519911160;
					short num3 = num;
					num = (short)1902444792;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_B1;
					}
					break;
				}
				}
				IL_30:
				if (this.e == null)
				{
					goto IL_F1;
				}
				num = (short)826933249;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B1:
			num = (short)1636368385;
			if (num != 0)
			{
			}
			num = (short)213909504;
			if (num != 0)
			{
			}
			IL_F1:
			num = (short)878772224;
			short num4 = num;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0008BA58 File Offset: 0x00089C58
		protected virtual global::System.Windows.Media.Brush DefaultHighlightBrush
		{
			get
			{
				short num = (short)1950430505;
				short num2 = num;
				num = (short)1611871529;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1202061312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)445513729;
				if (num != 0)
				{
				}
				num = (short)340787200;
				if (num != 0)
				{
				}
				return global::System.Windows.SystemColors.HighlightBrush;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0008BB08 File Offset: 0x00089D08
		protected virtual global::System.Windows.Media.Brush DefaultHighlightTextBrush
		{
			get
			{
				short num = (short)1595238764;
				short num2 = num;
				num = (short)912877932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)747503616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)113180673;
				if (num != 0)
				{
				}
				num = (short)1680211968;
				if (num != 0)
				{
				}
				return global::System.Windows.SystemColors.HighlightTextBrush;
			}
		}

		// Token: 0x040002C7 RID: 711
		private int a;

		// Token: 0x040002C8 RID: 712
		private string b = "";

		// Token: 0x040002C9 RID: 713
		private bool c = true;

		// Token: 0x040002CA RID: 714
		private string d = "";

		// Token: 0x040002CB RID: 715
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler e;

		// Token: 0x040002CF RID: 719
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty;

		// Token: 0x040002D0 RID: 720
		public static readonly global::System.Windows.DependencyProperty AutoOverwriteProperty;

		// Token: 0x040002D2 RID: 722
		public static readonly global::System.Windows.DependencyProperty FocusedBackgroundProperty;

		// Token: 0x040002D3 RID: 723
		public static readonly global::System.Windows.DependencyProperty FocusedForegroundProperty;

		// Token: 0x040002D4 RID: 724
		private bool f = true;
	}
}
