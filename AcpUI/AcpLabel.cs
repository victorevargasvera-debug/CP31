using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using AcpBusinessLayer;
using AcpCommonResources;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x02000018 RID: 24
	public class AcpLabel : global::System.Windows.Controls.Label, global::AcpUILib.IAcpUICtrlBase, global::AcpUILib.IAcpUIValueCtrlBase<string>, global::AcpUILib.IAcpUIParentCtrlBase, global::AcpUILib.IAcpUIChildCtrlBase, global::AcpUILib.IAcpUICommon
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000188A8 File Offset: 0x00016AA8
		// (set) Token: 0x06000133 RID: 307 RVA: 0x0001895C File Offset: 0x00016B5C
		public string Value
		{
			get
			{
				short num = (short)1669852594;
				short num2 = num;
				num = (short)826535346;
				switch (num2 == num)
				{
				}
				num = (short)1588723712;
				if (num != 0)
				{
				}
				num = (short)1703149569;
				if (num != 0)
				{
				}
				num = (short)2077163520;
				short num3 = num;
				return (string)base.Content;
			}
			set
			{
				short num = (short)2105547273;
				short num2 = num;
				num = (short)1209014793;
				switch (num2 == num)
				{
				}
				num = (short)1838481408;
				if (num != 0)
				{
				}
				num = (short)1710555137;
				if (num != 0)
				{
				}
				num = (short)511901696;
				short num3 = num;
				base.Content = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00018A0C File Offset: 0x00016C0C
		// (set) Token: 0x06000135 RID: 309 RVA: 0x00018AC8 File Offset: 0x00016CC8
		public bool IsAcpValid
		{
			get
			{
				short num = (short)92020719;
				short num2 = num;
				num = (short)2054823919;
				switch (num2 == num)
				{
				}
				num = (short)661979137;
				if (num != 0)
				{
				}
				num = (short)74842112;
				if (num != 0)
				{
				}
				num = (short)660668416;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpLabel.IsAcpValidProperty);
			}
			set
			{
				short num = (short)2010067256;
				short num2 = num;
				num = (short)303444280;
				switch (num2 == num)
				{
				}
				num = (short)1806303232;
				if (num != 0)
				{
				}
				num = (short)382468097;
				if (num != 0)
				{
				}
				num = (short)1083768832;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpLabel.IsAcpValidProperty, value);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00018B84 File Offset: 0x00016D84
		// (set) Token: 0x06000137 RID: 311 RVA: 0x00018C3C File Offset: 0x00016E3C
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)685964043;
				short num2 = num;
				num = (short)576781067;
				switch (num2 == num)
				{
				}
				num = (short)2037252097;
				if (num != 0)
				{
				}
				num = (short)394919936;
				if (num != 0)
				{
				}
				num = (short)1500053504;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpLabel.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)551026689;
				if (num != 0)
				{
				}
				num = (short)375274108;
				short num2 = num;
				num = (short)671038076;
				switch (num2 == num)
				{
				}
				num = (short)1140260864;
				if (num != 0)
				{
				}
				num = (short)343539712;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpLabel.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000138 RID: 312 RVA: 0x00018CF4 File Offset: 0x00016EF4
		// (set) Token: 0x06000139 RID: 313 RVA: 0x00018DB0 File Offset: 0x00016FB0
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)541047412;
				short num2 = num;
				num = (short)808041076;
				switch (num2 == num)
				{
				}
				num = (short)1598816257;
				if (num != 0)
				{
				}
				num = (short)94633984;
				if (num != 0)
				{
				}
				num = (short)657195008;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpLabel.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1820572913;
				short num2 = num;
				num = (short)613530865;
				switch (num2 == num)
				{
				}
				num = (short)151060481;
				if (num != 0)
				{
				}
				num = (short)408944640;
				if (num != 0)
				{
				}
				num = (short)972816384;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpLabel.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00018E68 File Offset: 0x00017068
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00018F24 File Offset: 0x00017124
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1447424230;
				short num2 = num;
				num = (short)1768943846;
				switch (num2 == num)
				{
				}
				num = (short)793903104;
				if (num != 0)
				{
				}
				num = (short)1765343233;
				if (num != 0)
				{
				}
				num = (short)1489043456;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpLabel.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1044005748;
				short num2 = num;
				num = (short)959202164;
				switch (num2 == num)
				{
				}
				num = (short)2040397825;
				if (num != 0)
				{
				}
				num = (short)827785216;
				if (num != 0)
				{
				}
				num = (short)1567424512;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpLabel.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600013C RID: 316 RVA: 0x00018FDC File Offset: 0x000171DC
		// (set) Token: 0x0600013D RID: 317 RVA: 0x00019098 File Offset: 0x00017298
		public global::AcpUILib.IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)1826798760;
				short num2 = num;
				num = (short)370326696;
				switch (num2 == num)
				{
				}
				num = (short)1583546369;
				if (num != 0)
				{
				}
				num = (short)1519845376;
				if (num != 0)
				{
				}
				num = (short)2125004800;
				short num3 = num;
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpLabel.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)1552906279;
				short num2 = num;
				num = (short)550205479;
				switch (num2 == num)
				{
				}
				num = (short)1921908737;
				if (num != 0)
				{
				}
				num = (short)676724736;
				if (num != 0)
				{
				}
				num = (short)574291968;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpLabel.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00019150 File Offset: 0x00017350
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0001920C File Offset: 0x0001740C
		public global::AcpUILib.IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)46054208;
				short num2 = num;
				num = (short)1921694528;
				switch (num2 == num)
				{
				}
				num = (short)419364864;
				if (num != 0)
				{
				}
				num = (short)1627652097;
				if (num != 0)
				{
				}
				num = (short)515833856;
				short num3 = num;
				return (global::AcpUILib.IAcpUIChildCtrlBase)base.GetValue(global::AcpUI.AcpLabel.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)430333678;
				short num2 = num;
				num = (short)1277255406;
				switch (num2 == num)
				{
				}
				num = (short)1071382529;
				if (num != 0)
				{
				}
				num = (short)254607360;
				if (num != 0)
				{
				}
				num = (short)1334968320;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpLabel.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000140 RID: 320 RVA: 0x000192C0 File Offset: 0x000174C0
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00019378 File Offset: 0x00017578
		public global::AcpBusinessLayer.AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)1422260576;
				short num2 = num;
				num = (short)1741748576;
				switch (num2 == num)
				{
				}
				num = (short)1019674625;
				if (num != 0)
				{
				}
				num = (short)1165099008;
				if (num != 0)
				{
				}
				num = (short)1992097792;
				short num3 = num;
				return (global::AcpBusinessLayer.AcpFieldBase)base.GetValue(global::AcpUI.AcpLabel.MyBLObjectProperty);
			}
			set
			{
				short num = (short)198449225;
				short num2 = num;
				num = (short)858200137;
				switch (num2 == num)
				{
				}
				num = (short)264962048;
				if (num != 0)
				{
				}
				num = (short)661651457;
				if (num != 0)
				{
				}
				num = (short)1480327168;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpLabel.MyBLObjectProperty, value);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00019430 File Offset: 0x00017630
		// (set) Token: 0x06000143 RID: 323 RVA: 0x000194EC File Offset: 0x000176EC
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)235995137;
				if (num != 0)
				{
				}
				num = (short)557557560;
				short num2 = num;
				num = (short)2068621112;
				switch (num2 == num)
				{
				}
				num = (short)312672256;
				if (num != 0)
				{
				}
				num = (short)472514560;
				short num3 = num;
				return (bool)base.GetValue(global::AcpUI.AcpLabel.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)471914624;
				short num2 = num;
				num = (short)2118637696;
				switch (num2 == num)
				{
				}
				num = (short)1257504769;
				if (num != 0)
				{
				}
				num = (short)1004797952;
				if (num != 0)
				{
				}
				num = (short)1346109440;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpLabel.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000195A8 File Offset: 0x000177A8
		// (set) Token: 0x06000145 RID: 325 RVA: 0x00019660 File Offset: 0x00017860
		public global::System.Windows.Controls.Expander MyExpander
		{
			get
			{
				short num = (short)718191811;
				short num2 = num;
				num = (short)200522947;
				switch (num2 == num)
				{
				}
				num = (short)511246336;
				if (num != 0)
				{
				}
				num = (short)1034354689;
				if (num != 0)
				{
				}
				num = (short)1455751168;
				short num3 = num;
				return (global::System.Windows.Controls.Expander)base.GetValue(global::AcpUI.AcpLabel.MyExpanderProperty);
			}
			set
			{
				short num = (short)886072536;
				short num2 = num;
				num = (short)257385688;
				switch (num2 == num)
				{
				}
				num = (short)1403453441;
				if (num != 0)
				{
				}
				num = (short)1322450944;
				if (num != 0)
				{
				}
				num = (short)720764928;
				short num3 = num;
				base.SetValue(global::AcpUI.AcpLabel.MyExpanderProperty, value);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00019714 File Offset: 0x00017914
		// (set) Token: 0x06000147 RID: 327 RVA: 0x000197CC File Offset: 0x000179CC
		public global::AcpUILib.IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)571080705;
				if (num != 0)
				{
				}
				num = (short)627164978;
				short num2 = num;
				num = (short)1244841778;
				switch (num2 == num)
				{
				}
				num = (short)225312768;
				if (num != 0)
				{
				}
				num = (short)627900416;
				short num3 = num;
				return (global::AcpUILib.IAcpUIParentCtrlBase)base.GetValue(global::AcpUI.AcpLabel.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)138003204;
				short num2 = num;
				num = (short)1397605124;
				switch (num2 == num)
				{
				}
				num = (short)731971585;
				if (num != 0)
				{
				}
				num = (short)1624309760;
				short num3 = num;
				num = (short)1914306560;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpLabel.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000148 RID: 328 RVA: 0x00019880 File Offset: 0x00017A80
		// (set) Token: 0x06000149 RID: 329 RVA: 0x00019930 File Offset: 0x00017B30
		public string HelpText
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)659080883;
				short num2 = num;
				num = (short)1707919027;
				switch (num2 == num)
				{
				}
				num = (short)1318649856;
				if (num != 0)
				{
				}
				num = (short)1148387328;
				short num3 = num;
				num = (short)1777205249;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)944504833;
				if (num != 0)
				{
				}
				num = (short)1548944152;
				short num2 = num;
				num = (short)1569587992;
				switch (num2 == num)
				{
				}
				num = (short)205651968;
				short num3 = num;
				num = (short)80805888;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000199E8 File Offset: 0x00017BE8
		private void menuItem_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_A8;
			}
			short num;
			int num4;
			global::System.Windows.Controls.MenuItem menuItem;
			string data;
			for (;;)
			{
				IL_13:
				num = (short)1680998400;
				short num2 = num;
				num = (short)1509711422;
				short num3 = num;
				num = (short)398548542;
				global::AcpUI.AcpLabel acpLabel;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)151126016;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (menuItem != null)
						{
							num = (short)831586309;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
					case 1:
						goto IL_EF;
					case 2:
						goto IL_126;
					case 3:
						if (acpLabel.MyParentCtrl != null)
						{
							num = (short)1449263108;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
					case 4:
						num = (short)823132166;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						acpLabel = (global::AcpUI.AcpLabel)((global::System.Windows.Controls.ContextMenu)menuItem.Parent).PlacementTarget;
						num = (short)421462019;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (acpLabel.MyParentCtrl.MyBLObject != null)
						{
							num = (short)706412545;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
					}
					goto IL_A8;
				}
				IL_EF:
				data = acpLabel.MyParentCtrl.MyBLObject.Path(global::AcpUI.Common.Utility.c("ᦡ", a_));
				num = (short)1051525122;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_126:
			num = (short)1751056385;
			if (num != 0)
			{
			}
			IL_1E5:
			global::System.Windows.Clipboard.SetData(global::System.Windows.DataFormats.UnicodeText, data);
			return;
			IL_A8:
			data = string.Empty;
			menuItem = (A_0 as global::System.Windows.Controls.MenuItem);
			num = (short)1152516096;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00019BE8 File Offset: 0x00017DE8
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00019CA4 File Offset: 0x00017EA4
		public bool AcpLabelFromViewOnlyCtrl
		{
			get
			{
				short num = (short)1314536747;
				short num2 = num;
				num = (short)1969044779;
				switch (num2 == num)
				{
				}
				num = (short)1565523968;
				if (num != 0)
				{
				}
				num = (short)1286078464;
				short num3 = num;
				num = (short)1933312001;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(global::AcpUI.AcpLabel.AcpLabelFromViewOnlyCtrlProperty);
			}
			set
			{
				short num = (short)1392896663;
				short num2 = num;
				num = (short)1178004119;
				switch (num2 == num)
				{
				}
				num = (short)1742864385;
				if (num != 0)
				{
				}
				num = (short)471990272;
				short num3 = num;
				num = (short)882966528;
				if (num != 0)
				{
				}
				base.SetValue(global::AcpUI.AcpLabel.AcpLabelFromViewOnlyCtrlProperty, value);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00019D60 File Offset: 0x00017F60
		public AcpLabel()
		{
			base.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
			base.Loaded += this.AcpLabel_Loaded;
			base.Unloaded += this.AcpLabel_UnLoaded;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00019DA0 File Offset: 0x00017FA0
		private void AcpLabel_Loaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num;
			for (;;)
			{
				num = (short)56950784;
				short num2 = num;
				num = (short)668532737;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_131;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					case 2:
					{
						num = (short)1445855233;
						if (num != 0)
						{
						}
						global::System.Windows.Controls.ContextMenu contextMenu = new global::System.Windows.Controls.ContextMenu();
						this.a = new global::System.Windows.Controls.MenuItem();
						this.a.Header = global::AcpCommonResources.AcpResources.Copy_Public_Tag;
						this.a.Click += this.menuItem_Click;
						contextMenu.Items.Add(this.a);
						base.ContextMenu = contextMenu;
						base.MouseDoubleClick += this.AcpLabel_MouseDoubleClick;
						base.MouseLeftButtonDown += this.AcpLabel_MouseLeftButtonDown;
						num = (short)428998656;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_5B:
					if (this.AcpLabelFromViewOnlyCtrl)
					{
						return;
					}
					num = (short)1004863490;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_131:
				num = (short)784635183;
				short num4 = num;
				num = (short)542348591;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_167;
				}
			}
			IL_167:
			num = (short)2096496640;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00019F2C File Offset: 0x0001812C
		private void AcpLabel_UnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1394999297;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.a != null)
						{
							num = (short)1064960002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 2:
					{
						num = (short)403439616;
						short num3 = num;
						this.a.Click -= this.menuItem_Click;
						num = (short)1732050948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)626327553;
						if (num != 0)
						{
						}
						num = (short)128212441;
						short num4 = num;
						num = (short)1523473881;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1486553088;
							if (num != 0)
							{
							}
							base.MouseDoubleClick -= this.AcpLabel_MouseDoubleClick;
							base.MouseLeftButtonDown -= this.AcpLabel_MouseLeftButtonDown;
							num = (short)1859780608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						return;
					}
					IL_38:
					if (this.AcpLabelFromViewOnlyCtrl)
					{
						return;
					}
					num = (short)1456078851;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0001A0C0 File Offset: 0x000182C0
		private void AcpLabel_MouseDoubleClick(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1468792832;
			short num2 = num;
			if (this.AcpLabelFromViewOnlyCtrl)
			{
				num = (short)1744942067;
				short num3 = num;
				num = (short)468890611;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1278869505;
					if (num != 0)
					{
					}
					num = (short)889913344;
					if (num != 0)
					{
					}
					return;
				}
			}
			global::AcpUI.Common.Utility.b(this.MyParentCtrl);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0001A184 File Offset: 0x00018384
		private void AcpLabel_MouseLeftButtonDown(object A_0, global::System.Windows.Input.MouseButtonEventArgs A_1)
		{
			short num = (short)1242103808;
			short num2 = num;
			if (this.AcpLabelFromViewOnlyCtrl)
			{
				num = (short)1021655259;
				short num3 = num;
				num = (short)1173371099;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1280114689;
					if (num != 0)
					{
					}
					num = (short)597360640;
					if (num != 0)
					{
					}
					return;
				}
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(this.MyParentCtrl);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0001A244 File Offset: 0x00018444
		// Note: this type is marked as 'beforefieldinit'.
		static AcpLabel()
		{
			int a_ = 18;
			short num = (short)468194337;
			short num2 = num;
			num = (short)788927521;
			switch (num2 == num)
			{
			}
			num = (short)1614675969;
			if (num != 0)
			{
			}
			num = (short)2099445760;
			short num3 = num;
			num = (short)2139815936;
			if (num != 0)
			{
			}
			global::AcpUI.AcpLabel.IsAcpValidProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud9a9춭삯햳\udab5톷\udeb9", a_), typeof(bool), typeof(global::AcpUI.AcpLabel), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpLabel.IsAcpApplicableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud9a9춭삯쒳욵풷펹\udfbb\udfbdꊿ껁ꇃ", a_), typeof(bool), typeof(global::AcpUI.AcpLabel), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpLabel.IsAcpEditableProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud9a9춭삯킳\udfb5첷\udbb9\udebb튽ꖿ", a_), typeof(bool), typeof(global::AcpUI.AcpLabel), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpLabel.IsAcpVisibleProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud9a9춭삯\uddb3억톷\ud8b9킻\udbbd", a_), typeof(bool), typeof(global::AcpUI.AcpLabel), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender | global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			global::AcpUI.AcpLabel.MyLabelCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩쾭튯ힱ\ud8b3첷좹킻", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpLabel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpLabel.MyCopyButtonProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩솭삯쮱쎵첷캹펻킽莿뛁뛃꫅", a_), typeof(global::AcpUILib.IAcpUIChildCtrlBase), typeof(global::AcpUI.AcpLabel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpLabel.MyBLObjectProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩ﾯ킱\udeb3펵\udbb7캹", a_), typeof(global::AcpBusinessLayer.AcpFieldBase), typeof(global::AcpUI.AcpLabel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpLabel.AreValuesEqualProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("\ud8a9즫톯\udeb1솳펵쮷ﾹ춻쮽ꆿ껁", a_), typeof(bool), typeof(global::AcpUI.AcpLabel), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpLabel.MyExpanderProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩횭삯펱\udab3튵\uddb7좹", a_), typeof(global::System.Windows.Controls.Expander), typeof(global::AcpUI.AcpLabel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpLabel.MyParentCtrlProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::AcpUI.Common.Utility.c("펩ﲫ쾭슯ힱ\udab3습﮷캹캻튽", a_), typeof(global::AcpUILib.IAcpUIParentCtrlBase), typeof(global::AcpUI.AcpLabel), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
			global::AcpUI.AcpLabel.AcpLabelFromViewOnlyCtrlProperty = global::System.Windows.DependencyProperty.Register(global::AcpUI.Common.Utility.c("즩\udcab톯킱톳\udab5ﺷ좹펻펽隿ꯁꇃ뇅蟇꓉ꃋ럍鏏ꛑꛓ뫕", a_), typeof(bool), typeof(global::AcpUI.AcpLabel), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender));
		}

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Controls.MenuItem a;

		// Token: 0x0400013B RID: 315
		public static readonly global::System.Windows.DependencyProperty IsAcpValidProperty;

		// Token: 0x0400013C RID: 316
		public static readonly global::System.Windows.DependencyProperty IsAcpApplicableProperty;

		// Token: 0x0400013D RID: 317
		public static readonly global::System.Windows.DependencyProperty IsAcpEditableProperty;

		// Token: 0x0400013E RID: 318
		public static readonly global::System.Windows.DependencyProperty IsAcpVisibleProperty;

		// Token: 0x0400013F RID: 319
		public static readonly global::System.Windows.DependencyProperty MyLabelCtrlProperty;

		// Token: 0x04000140 RID: 320
		public static readonly global::System.Windows.DependencyProperty MyCopyButtonProperty;

		// Token: 0x04000141 RID: 321
		public static readonly global::System.Windows.DependencyProperty MyBLObjectProperty;

		// Token: 0x04000142 RID: 322
		public static readonly global::System.Windows.DependencyProperty AreValuesEqualProperty;

		// Token: 0x04000143 RID: 323
		public static readonly global::System.Windows.DependencyProperty MyExpanderProperty;

		// Token: 0x04000144 RID: 324
		public static readonly global::System.Windows.DependencyProperty MyParentCtrlProperty;

		// Token: 0x04000145 RID: 325
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x04000146 RID: 326
		public static readonly global::System.Windows.DependencyProperty AcpLabelFromViewOnlyCtrlProperty;
	}
}
