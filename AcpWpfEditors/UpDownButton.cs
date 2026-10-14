using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using DevComponents.WpfEditors.Primitives;

namespace DevComponents.WpfEditors
{
	// Token: 0x02000046 RID: 70
	public class UpDownButton : global::System.Windows.Controls.Control
	{
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x000639C8 File Offset: 0x00061BC8
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00063A80 File Offset: 0x00061C80
		public bool IsUpEnabled
		{
			get
			{
				short num = (short)811895192;
				short num2 = num;
				num = (short)132680088;
				switch (num2 == num)
				{
				}
				num = (short)1174208513;
				if (num != 0)
				{
				}
				num = (short)398589952;
				if (num != 0)
				{
				}
				num = (short)1217593344;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.UpDownButton.IsUpEnabledProperty);
			}
			set
			{
				short num = (short)1502122024;
				short num2 = num;
				num = (short)1504219176;
				switch (num2 == num)
				{
				}
				num = (short)19136513;
				if (num != 0)
				{
				}
				num = (short)552927232;
				if (num != 0)
				{
				}
				num = (short)337772544;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.UpDownButton.IsUpEnabledProperty, value);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00063B40 File Offset: 0x00061D40
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00063BF8 File Offset: 0x00061DF8
		public bool IsDownEnabled
		{
			get
			{
				short num = (short)470897391;
				short num2 = num;
				num = (short)557470447;
				switch (num2 == num)
				{
				}
				num = (short)97779712;
				if (num != 0)
				{
				}
				num = (short)393281537;
				if (num != 0)
				{
				}
				num = (short)826736640;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.UpDownButton.IsDownEnabledProperty);
			}
			set
			{
				short num = (short)66670977;
				short num2 = num;
				num = (short)1794462081;
				switch (num2 == num)
				{
				}
				num = (short)1001521153;
				if (num != 0)
				{
				}
				num = (short)1357119488;
				if (num != 0)
				{
				}
				num = (short)874053632;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.UpDownButton.IsDownEnabledProperty, value);
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060004CC RID: 1228 RVA: 0x00063CB0 File Offset: 0x00061EB0
		// (remove) Token: 0x060004CD RID: 1229 RVA: 0x00063D6C File Offset: 0x00061F6C
		public event global::System.Windows.RoutedEventHandler UpButtonClick
		{
			add
			{
				short num = (short)2081171959;
				short num2 = num;
				num = (short)1082468855;
				switch (num2 == num)
				{
				}
				num = (short)1132331009;
				if (num != 0)
				{
				}
				num = (short)130482176;
				if (num != 0)
				{
				}
				num = (short)1889796096;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.UpDownButton.UpButtonClickEvent, value);
			}
			remove
			{
				short num = (short)1660988540;
				short num2 = num;
				num = (short)718974076;
				switch (num2 == num)
				{
				}
				num = (short)1942487040;
				if (num != 0)
				{
				}
				num = (short)579665921;
				if (num != 0)
				{
				}
				num = (short)504365056;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.UpDownButton.UpButtonClickEvent, value);
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060004CE RID: 1230 RVA: 0x00063E24 File Offset: 0x00062024
		// (remove) Token: 0x060004CF RID: 1231 RVA: 0x00063ED8 File Offset: 0x000620D8
		public event global::System.Windows.RoutedEventHandler PreviewUpButtonClick
		{
			add
			{
				short num = (short)1628625033;
				short num2 = num;
				num = (short)1064491145;
				switch (num2 == num)
				{
				}
				num = (short)1763508224;
				if (num != 0)
				{
				}
				num = (short)1216479233;
				if (num != 0)
				{
				}
				num = (short)475463680;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.UpDownButton.PreviewUpButtonClickEvent, value);
			}
			remove
			{
				short num = (short)867377273;
				short num2 = num;
				num = (short)124461177;
				switch (num2 == num)
				{
				}
				num = (short)754253825;
				if (num != 0)
				{
				}
				num = (short)1391722496;
				if (num != 0)
				{
				}
				num = (short)1441792000;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.UpDownButton.PreviewUpButtonClickEvent, value);
			}
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00063F90 File Offset: 0x00062190
		protected virtual void RaiseUpButtonClick()
		{
			global::System.Windows.RoutedEventArgs routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.UpDownButton.PreviewUpButtonClickEvent);
			base.RaiseEvent(routedEventArgs);
			if (!routedEventArgs.Handled)
			{
				short num = (short)1249570226;
				short num2 = num;
				num = (short)2027744690;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)1804468224;
					short num3 = num;
					break;
				}
				}
				num = (short)445710336;
				if (num != 0)
				{
				}
				num = (short)1782644737;
				if (num != 0)
				{
				}
				global::System.Windows.RoutedEventArgs eventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.UpDownButton.UpButtonClickEvent);
				this.OnUpButtonClick(eventArgs);
				return;
			}
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00064068 File Offset: 0x00062268
		protected virtual void OnUpButtonClick(global::System.Windows.RoutedEventArgs eventArgs)
		{
			short num = (short)664225839;
			short num2 = num;
			num = (short)1730234415;
			switch (num2 == num)
			{
			}
			num = (short)468582401;
			if (num != 0)
			{
			}
			num = (short)1950089216;
			if (num != 0)
			{
			}
			num = (short)1661796352;
			short num3 = num;
			base.RaiseEvent(eventArgs);
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060004D2 RID: 1234 RVA: 0x00064118 File Offset: 0x00062318
		// (remove) Token: 0x060004D3 RID: 1235 RVA: 0x000641D0 File Offset: 0x000623D0
		public event global::System.Windows.RoutedEventHandler DownButtonClick
		{
			add
			{
				short num = (short)1286556128;
				short num2 = num;
				num = (short)2098743776;
				switch (num2 == num)
				{
				}
				num = (short)1968570368;
				if (num != 0)
				{
				}
				num = (short)1474822145;
				if (num != 0)
				{
				}
				num = (short)1939734528;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.UpDownButton.DownButtonClickEvent, value);
			}
			remove
			{
				short num = (short)508580314;
				short num2 = num;
				num = (short)1143820762;
				switch (num2 == num)
				{
				}
				num = (short)954007553;
				if (num != 0)
				{
				}
				num = (short)1283457024;
				if (num != 0)
				{
				}
				num = (short)65208320;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.UpDownButton.DownButtonClickEvent, value);
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060004D4 RID: 1236 RVA: 0x00064288 File Offset: 0x00062488
		// (remove) Token: 0x060004D5 RID: 1237 RVA: 0x00064340 File Offset: 0x00062540
		public event global::System.Windows.RoutedEventHandler PreviewDownButtonClick
		{
			add
			{
				short num = (short)742942393;
				short num2 = num;
				num = (short)1585931961;
				switch (num2 == num)
				{
				}
				num = (short)1056243712;
				if (num != 0)
				{
				}
				num = (short)1147273217;
				if (num != 0)
				{
				}
				num = (short)1512374272;
				short num3 = num;
				base.AddHandler(global::DevComponents.WpfEditors.UpDownButton.PreviewDownButtonClickEvent, value);
			}
			remove
			{
				short num = (short)891814526;
				short num2 = num;
				num = (short)1968505470;
				switch (num2 == num)
				{
				}
				num = (short)371589121;
				if (num != 0)
				{
				}
				num = (short)1007681536;
				if (num != 0)
				{
				}
				num = (short)1774977024;
				short num3 = num;
				base.RemoveHandler(global::DevComponents.WpfEditors.UpDownButton.PreviewDownButtonClickEvent, value);
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000643F4 File Offset: 0x000625F4
		protected virtual void RaiseDownButtonClick()
		{
			global::System.Windows.RoutedEventArgs routedEventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.UpDownButton.PreviewDownButtonClickEvent);
			base.RaiseEvent(routedEventArgs);
			if (!routedEventArgs.Handled)
			{
				short num = (short)97874693;
				short num2 = num;
				num = (short)1535472389;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)2126249984;
					short num3 = num;
					break;
				}
				}
				num = (short)399572992;
				if (num != 0)
				{
				}
				num = (short)1153695745;
				if (num != 0)
				{
				}
				global::System.Windows.RoutedEventArgs eventArgs = new global::System.Windows.RoutedEventArgs(global::DevComponents.WpfEditors.UpDownButton.DownButtonClickEvent);
				this.OnDownButtonClick(eventArgs);
				return;
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000644D0 File Offset: 0x000626D0
		protected virtual void OnDownButtonClick(global::System.Windows.RoutedEventArgs eventArgs)
		{
			short num = (short)733033106;
			short num2 = num;
			num = (short)1376596626;
			switch (num2 == num)
			{
			}
			num = (short)1945042945;
			if (num != 0)
			{
			}
			num = (short)351338496;
			if (num != 0)
			{
			}
			num = (short)1280901120;
			short num3 = num;
			base.RaiseEvent(eventArgs);
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00064580 File Offset: 0x00062780
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00064638 File Offset: 0x00062838
		public bool ButtonsFocusable
		{
			get
			{
				short num = (short)1632501761;
				if (num != 0)
				{
				}
				num = (short)100843731;
				short num2 = num;
				num = (short)1066778835;
				switch (num2 == num)
				{
				}
				num = (short)1950744576;
				if (num != 0)
				{
				}
				num = (short)2060386304;
				short num3 = num;
				return (bool)base.GetValue(global::DevComponents.WpfEditors.UpDownButton.ButtonsFocusableProperty);
			}
			set
			{
				short num = (short)1498992073;
				short num2 = num;
				num = (short)1616301513;
				switch (num2 == num)
				{
				}
				num = (short)1525088256;
				if (num != 0)
				{
				}
				num = (short)1996816385;
				if (num != 0)
				{
				}
				num = (short)822476800;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.UpDownButton.ButtonsFocusableProperty, value);
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x000646F4 File Offset: 0x000628F4
		private static bool b(object A_0)
		{
			short num = (short)1715955090;
			short num2 = num;
			num = (short)768370066;
			switch (num2 == num)
			{
			}
			num = (short)961544193;
			if (num != 0)
			{
			}
			num = (short)85786624;
			if (num != 0)
			{
			}
			num = (short)93061120;
			short num3 = num;
			return (int)A_0 >= 0;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x000647A8 File Offset: 0x000629A8
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00064864 File Offset: 0x00062A64
		public int Delay
		{
			get
			{
				short num = (short)1145851169;
				short num2 = num;
				num = (short)1559383329;
				switch (num2 == num)
				{
				}
				num = (short)287637505;
				if (num != 0)
				{
				}
				num = (short)2074017792;
				if (num != 0)
				{
				}
				num = (short)909836288;
				short num3 = num;
				return (int)base.GetValue(global::DevComponents.WpfEditors.UpDownButton.DelayProperty);
			}
			set
			{
				short num = (short)133633536;
				short num2 = num;
				num = (short)712513024;
				switch (num2 == num)
				{
				}
				num = (short)1783103488;
				if (num != 0)
				{
				}
				num = (short)738721793;
				if (num != 0)
				{
				}
				num = (short)258932736;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.UpDownButton.DelayProperty, value);
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00064920 File Offset: 0x00062B20
		private static bool a(object A_0)
		{
			short num = (short)751216458;
			short num2 = num;
			num = (short)355772234;
			switch (num2 == num)
			{
			}
			num = (short)1100283904;
			if (num != 0)
			{
			}
			num = (short)1173946369;
			if (num != 0)
			{
			}
			num = (short)1334902784;
			short num3 = num;
			return (int)A_0 > 0;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x000649D0 File Offset: 0x00062BD0
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00064A88 File Offset: 0x00062C88
		public int Interval
		{
			get
			{
				short num = (short)334785421;
				short num2 = num;
				num = (short)1278962573;
				switch (num2 == num)
				{
				}
				num = (short)423165953;
				if (num != 0)
				{
				}
				num = (short)953614336;
				if (num != 0)
				{
				}
				num = (short)1057292288;
				short num3 = num;
				return (int)base.GetValue(global::DevComponents.WpfEditors.UpDownButton.IntervalProperty);
			}
			set
			{
				short num = (short)1439877992;
				short num2 = num;
				num = (short)172870504;
				switch (num2 == num)
				{
				}
				num = (short)575340544;
				if (num != 0)
				{
				}
				num = (short)1416626177;
				if (num != 0)
				{
				}
				num = (short)45416448;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.UpDownButton.IntervalProperty, value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00064B44 File Offset: 0x00062D44
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00064C00 File Offset: 0x00062E00
		public global::System.Windows.Controls.ClickMode ClickMode
		{
			get
			{
				short num = (short)1626192002;
				short num2 = num;
				num = (short)679983234;
				switch (num2 == num)
				{
				}
				num = (short)952893441;
				if (num != 0)
				{
				}
				num = (short)2071986176;
				if (num != 0)
				{
				}
				num = (short)442630144;
				short num3 = num;
				return (global::System.Windows.Controls.ClickMode)base.GetValue(global::DevComponents.WpfEditors.UpDownButton.ClickModeProperty);
			}
			set
			{
				short num = (short)2073639855;
				short num2 = num;
				num = (short)997931951;
				switch (num2 == num)
				{
				}
				num = (short)1122304001;
				if (num != 0)
				{
				}
				num = (short)522387456;
				if (num != 0)
				{
				}
				num = (short)992673792;
				short num3 = num;
				base.SetValue(global::DevComponents.WpfEditors.UpDownButton.ClickModeProperty, value);
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00064CBC File Offset: 0x00062EBC
		static UpDownButton()
		{
			int a_ = 17;
			short num = (short)1222014447;
			short num2 = num;
			num = (short)43677167;
			switch (num2 == num)
			{
			}
			num = (short)92274689;
			if (num != 0)
			{
			}
			num = (short)602537984;
			if (num != 0)
			{
			}
			num = (short)533004288;
			short num3 = num;
			global::DevComponents.WpfEditors.UpDownButton.IsUpEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韝鏟럡铣ꏥ蛧诩軫苭闯雱", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.UpDownButton), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.UpDownButton.IsDownEnabledProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韝鏟ꛡ诣釥蛧꿩苫迭鋯黱釳鋵", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.UpDownButton), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.UpDownButton.UpButtonClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("话郟ꃡ釣鋥鳧藩苫귭鳯鯱音鷵", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.UpDownButton));
			global::DevComponents.WpfEditors.UpDownButton.PreviewUpButtonClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軝鋟蟡鋣迥跧鷩맫黭닯蟱胳苵韷铹뿻鋽槿愁漃", a_), global::System.Windows.RoutingStrategy.Tunnel, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.UpDownButton));
			global::DevComponents.WpfEditors.UpDownButton.DownButtonClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髝迟闡諣ꓥ鷧黩飫臭黯뇱飳鿵鯷釹", a_), global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.UpDownButton));
			global::DevComponents.WpfEditors.UpDownButton.PreviewDownButtonClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("軝鋟蟡鋣迥跧鷩꣫臭蟯鳱뛳菵賷軹鏻都䏿渁洃攅指", a_), global::System.Windows.RoutingStrategy.Tunnel, typeof(global::System.Windows.RoutedEventHandler), typeof(global::DevComponents.WpfEditors.UpDownButton));
			global::DevComponents.WpfEditors.UpDownButton.ButtonsFocusableProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鳝闟雡郣觥蛧駩ꫫ臭鏯蟱蟳韵髷雹駻", a_), typeof(bool), typeof(global::DevComponents.WpfEditors.UpDownButton), new global::System.Windows.UIPropertyMetadata(true));
			global::DevComponents.WpfEditors.UpDownButton.DelayProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("髝藟軡藣鿥", a_), typeof(int), typeof(global::DevComponents.WpfEditors.UpDownButton), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfEditors.UpDownButton.b()), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfEditors.UpDownButton.b));
			global::DevComponents.WpfEditors.UpDownButton.IntervalProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("韝軟雡臣铥黧诩胫", a_), typeof(int), typeof(global::DevComponents.WpfEditors.UpDownButton), new global::System.Windows.FrameworkPropertyMetadata(global::DevComponents.WpfEditors.UpDownButton.b()), new global::System.Windows.ValidateValueCallback(global::DevComponents.WpfEditors.UpDownButton.a));
			global::DevComponents.WpfEditors.UpDownButton.ClickModeProperty = global::System.Windows.DependencyProperty.Register(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鷝賟诡蟣跥ꗧ藩裫语", a_), typeof(global::System.Windows.Controls.ClickMode), typeof(global::DevComponents.WpfEditors.UpDownButton), new global::System.Windows.UIPropertyMetadata(global::System.Windows.Controls.ClickMode.Release));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::DevComponents.WpfEditors.UpDownButton), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::DevComponents.WpfEditors.UpDownButton)));
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00064FB0 File Offset: 0x000631B0
		public override void OnApplyTemplate()
		{
			int a_ = 3;
			short num = (short)2076114946;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_21D;
				case 1:
					goto IL_169;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				case 3:
					if (this.b != null)
					{
						num = (short)2015625221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E3;
				case 4:
					this.a.Click += this.b;
					num = (short)615907337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.b.Click += this.a;
					num = (short)1158938624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1843265536;
					short num3 = num;
					if (this.a != null)
					{
						num = (short)1460535300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12A;
				}
				case 7:
					goto IL_255;
				case 8:
					this.a.Click -= this.b;
					goto IL_239;
				case 9:
					goto IL_12A;
				case 10:
					if (this.b != null)
					{
						num = (short)1143144459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_255;
				case 11:
					num = (short)1247215617;
					if (num != 0)
					{
					}
					this.b.Click -= this.a;
					num = (short)145031175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5E:
				if (this.a == null)
				{
					goto IL_169;
				}
				num = (short)2022904358;
				short num4 = num;
				num = (short)1920209446;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_239;
				default:
					num = (short)2022375424;
					if (num != 0)
					{
					}
					num = (short)1715798024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_12A:
				num = (short)207028234;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_169:
				this.a = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鋏ꟑꃓꋕ럗듙觛껝", a_)) as global::System.Windows.Controls.Primitives.ButtonBase);
				num = (short)1651769350;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_239:
				num = (short)1331429377;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_255:
				this.b = (base.GetTemplateChild(global::DevComponents.WpfEditors.Primitives.NumericYearInput.b("鋏ꟑꃓꋕ럗듙飛뇝韟賡", a_)) as global::System.Windows.Controls.Primitives.ButtonBase);
				num = (short)109182979;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_21D:
			IL_2E3:
			base.OnApplyTemplate();
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000652A8 File Offset: 0x000634A8
		private void b(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1197664014;
			short num2 = num;
			num = (short)1821632270;
			switch (num2 == num)
			{
			}
			num = (short)462684161;
			if (num != 0)
			{
			}
			num = (short)1431437312;
			if (num != 0)
			{
			}
			num = (short)2072379392;
			short num3 = num;
			this.RaiseUpButtonClick();
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00065358 File Offset: 0x00063558
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)69408055;
			short num2 = num;
			num = (short)980817207;
			switch (num2 == num)
			{
			}
			num = (short)1278083073;
			if (num != 0)
			{
			}
			num = (short)592052224;
			if (num != 0)
			{
			}
			num = (short)1942290432;
			short num3 = num;
			this.RaiseDownButtonClick();
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00065408 File Offset: 0x00063608
		internal static int b()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
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
					goto IL_5C;
				case 1:
					if (num2 >= 0)
					{
						num3 = (short)2050228227;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_5C;
				case 2:
					if (num2 > 3)
					{
						num3 = (short)179634176;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_150;
				case 3:
					goto IL_118;
				case 4:
					goto IL_116;
				}
				goto IL_24;
				IL_5C:
				num2 = 0;
				num3 = (short)308412416;
				short num4 = num3;
				num3 = (short)501743799;
				short num5 = num3;
				num3 = (short)1395327159;
				switch ((num5 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_118:
					num3 = (short)902889474;
					num = (int)((global::System.IntPtr)num3);
					break;
				default:
					num3 = (short)1978662913;
					if (num3 != 0)
					{
					}
					num3 = (short)910884864;
					if (num3 != 0)
					{
					}
					num3 = (short)1308491780;
					num = (int)((global::System.IntPtr)num3);
					break;
				}
			}
			IL_116:
			IL_150:
			return (num2 + 1) * 250;
			IL_24:
			num2 = global::System.Windows.SystemParameters.KeyboardDelay;
			num3 = (short)1710882817;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00065570 File Offset: 0x00063770
		internal static int a()
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2092957697;
					if (num2 != 0)
					{
					}
					goto IL_5C;
				case 1:
					if (num3 >= 0)
					{
						num2 = (short)135987203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5C;
				case 2:
					if (num3 > 31)
					{
						num2 = (short)568262656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14C;
				case 3:
					goto IL_EB;
				case 4:
					goto IL_E9;
				}
				goto IL_24;
				IL_5C:
				num3 = 31;
				num2 = (short)667549696;
				short num4 = num2;
				num2 = (short)747209926;
				short num5 = num2;
				num2 = (short)2063697094;
				switch ((num5 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_EB:
					num2 = (short)185008130;
					num = (int)((global::System.IntPtr)num2);
					break;
				default:
					num2 = (short)1589641216;
					if (num2 != 0)
					{
					}
					num2 = (short)1442381828;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_E9:
			IL_14C:
			return (31 - num3) * 367 / 31 + 33;
			IL_24:
			num3 = global::System.Windows.SystemParameters.KeyboardSpeed;
			num2 = (short)1765277697;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000254 RID: 596
		private global::System.Windows.Controls.Primitives.ButtonBase a;

		// Token: 0x04000255 RID: 597
		private global::System.Windows.Controls.Primitives.ButtonBase b;

		// Token: 0x04000256 RID: 598
		public static readonly global::System.Windows.DependencyProperty IsUpEnabledProperty;

		// Token: 0x04000257 RID: 599
		public static readonly global::System.Windows.DependencyProperty IsDownEnabledProperty;

		// Token: 0x0400025C RID: 604
		public static readonly global::System.Windows.DependencyProperty ButtonsFocusableProperty;

		// Token: 0x0400025D RID: 605
		public static readonly global::System.Windows.DependencyProperty DelayProperty;

		// Token: 0x0400025E RID: 606
		public static readonly global::System.Windows.DependencyProperty IntervalProperty;

		// Token: 0x0400025F RID: 607
		public static readonly global::System.Windows.DependencyProperty ClickModeProperty;
	}
}
