using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpFileHandlerLib;
using AcpUI.Common;
using AcpUILib;

namespace AcpUI
{
	// Token: 0x02000035 RID: 53
	public partial class AcpTextBoxFileBrowser : UserControl, IAcpUICtrlBase, IAcpUIValueCtrlBase<string>, IAcpUIParentCtrlBase, IAcpUIChildCtrlBase, IAcpUICommon
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000318 RID: 792 RVA: 0x000361C8 File Offset: 0x000343C8
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00036278 File Offset: 0x00034478
		public string Value
		{
			get
			{
				short num = (short)1517289472;
				short num2 = num;
				num = (short)928181607;
				short num3 = num;
				num = (short)1316613479;
				switch (num3 == num)
				{
				}
				num = (short)40828929;
				if (num != 0)
				{
				}
				num = (short)893714432;
				if (num != 0)
				{
				}
				return this.Text;
			}
			set
			{
				short num = (short)1849622528;
				short num2 = num;
				num = (short)736777991;
				short num3 = num;
				num = (short)393565959;
				switch (num3 == num)
				{
				}
				num = (short)1753481217;
				if (num != 0)
				{
				}
				num = (short)1357250560;
				if (num != 0)
				{
				}
				this.Text = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00036328 File Offset: 0x00034528
		// (set) Token: 0x0600031B RID: 795 RVA: 0x000363E4 File Offset: 0x000345E4
		public bool IsAcpValid
		{
			get
			{
				short num = (short)935854080;
				short num2 = num;
				num = (short)1686285289;
				short num3 = num;
				num = (short)2104339433;
				switch (num3 == num)
				{
				}
				num = (short)1610743808;
				if (num != 0)
				{
				}
				num = (short)1149435905;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxFileBrowser.IsAcpValidProperty);
			}
			set
			{
				short num = (short)1707933696;
				short num2 = num;
				num = (short)2076299648;
				short num3 = num;
				num = (short)1958662528;
				switch (num3 == num)
				{
				}
				num = (short)1087897601;
				if (num != 0)
				{
				}
				num = (short)589365248;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxFileBrowser.IsAcpValidProperty, value);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0003649C File Offset: 0x0003469C
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00036554 File Offset: 0x00034754
		public bool IsAcpApplicable
		{
			get
			{
				short num = (short)677511168;
				short num2 = num;
				num = (short)583335937;
				if (num != 0)
				{
				}
				num = (short)129661831;
				short num3 = num;
				num = (short)1543797639;
				switch (num3 == num)
				{
				}
				num = (short)727580672;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxFileBrowser.IsAcpApplicableProperty);
			}
			set
			{
				short num = (short)103481344;
				short num2 = num;
				num = (short)671518375;
				short num3 = num;
				num = (short)442666663;
				switch (num3 == num)
				{
				}
				num = (short)1804271616;
				if (num != 0)
				{
				}
				num = (short)356515841;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxFileBrowser.IsAcpApplicableProperty, value);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0003660C File Offset: 0x0003480C
		// (set) Token: 0x0600031F RID: 799 RVA: 0x000366C4 File Offset: 0x000348C4
		public bool IsAcpEditable
		{
			get
			{
				short num = (short)2130640896;
				short num2 = num;
				num = (short)1973422404;
				short num3 = num;
				num = (short)1430718788;
				switch (num3 == num)
				{
				}
				num = (short)627441665;
				if (num != 0)
				{
				}
				num = (short)1641480192;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxFileBrowser.IsAcpEditableProperty);
			}
			set
			{
				short num = (short)1251606528;
				short num2 = num;
				num = (short)174813083;
				short num3 = num;
				num = (short)1005678491;
				switch (num3 == num)
				{
				}
				num = (short)2078212096;
				if (num != 0)
				{
				}
				num = (short)1922564097;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxFileBrowser.IsAcpEditableProperty, value);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00036780 File Offset: 0x00034980
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00036838 File Offset: 0x00034A38
		public bool IsAcpVisible
		{
			get
			{
				short num = (short)1040973824;
				short num2 = num;
				num = (short)1200876377;
				short num3 = num;
				num = (short)1715596121;
				switch (num3 == num)
				{
				}
				num = (short)2062221312;
				if (num != 0)
				{
				}
				num = (short)2016083969;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxFileBrowser.IsAcpVisibleProperty);
			}
			set
			{
				short num = (short)1770061824;
				short num2 = num;
				num = (short)1764827729;
				short num3 = num;
				num = (short)378151505;
				switch (num3 == num)
				{
				}
				num = (short)422379521;
				if (num != 0)
				{
				}
				num = (short)1403715584;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxFileBrowser.IsAcpVisibleProperty, value);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000322 RID: 802 RVA: 0x000368F0 File Offset: 0x00034AF0
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000369A8 File Offset: 0x00034BA8
		public IAcpUIChildCtrlBase MyLabelCtrl
		{
			get
			{
				short num = (short)1881276416;
				short num2 = num;
				num = (short)1554124284;
				short num3 = num;
				num = (short)601427452;
				switch (num3 == num)
				{
				}
				num = (short)2025062401;
				if (num != 0)
				{
				}
				num = (short)1525350400;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpTextBoxFileBrowser.MyLabelCtrlProperty);
			}
			set
			{
				short num = (short)265355264;
				short num2 = num;
				num = (short)1462455381;
				short num3 = num;
				num = (short)897338453;
				switch (num3 == num)
				{
				}
				num = (short)1296171009;
				if (num != 0)
				{
				}
				num = (short)1114243072;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxFileBrowser.MyLabelCtrlProperty, value);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00036A5C File Offset: 0x00034C5C
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00036B14 File Offset: 0x00034D14
		public IAcpUIChildCtrlBase MyCopyButtonCtrl
		{
			get
			{
				short num = (short)853016576;
				short num2 = num;
				num = (short)1076671166;
				short num3 = num;
				num = (short)669823678;
				switch (num3 == num)
				{
				}
				num = (short)123207681;
				if (num != 0)
				{
				}
				num = (short)325517312;
				if (num != 0)
				{
				}
				return (IAcpUIChildCtrlBase)base.GetValue(AcpTextBoxFileBrowser.MyCopyButtonProperty);
			}
			set
			{
				short num = (short)293666816;
				short num2 = num;
				num = (short)1128732940;
				short num3 = num;
				num = (short)1833048332;
				switch (num3 == num)
				{
				}
				num = (short)1682833408;
				if (num != 0)
				{
				}
				num = (short)1089601537;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxFileBrowser.MyCopyButtonProperty, value);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00036BCC File Offset: 0x00034DCC
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00036C88 File Offset: 0x00034E88
		public AcpFieldBase MyBLObject
		{
			get
			{
				short num = (short)2017198080;
				short num2 = num;
				num = (short)1040565819;
				short num3 = num;
				num = (short)1908327995;
				switch (num3 == num)
				{
				}
				num = (short)1370488832;
				if (num != 0)
				{
				}
				num = (short)1176109057;
				if (num != 0)
				{
				}
				return (AcpFieldBase)base.GetValue(AcpTextBoxFileBrowser.MyBLObjectProperty);
			}
			set
			{
				short num = (short)1012727808;
				short num2 = num;
				num = (short)2033923053;
				short num3 = num;
				num = (short)1763587053;
				switch (num3 == num)
				{
				}
				num = (short)195428353;
				if (num != 0)
				{
				}
				num = (short)1345191936;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxFileBrowser.MyBLObjectProperty, value);
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00036D40 File Offset: 0x00034F40
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00036DF8 File Offset: 0x00034FF8
		public bool AreValuesEqual
		{
			get
			{
				short num = (short)612171776;
				short num2 = num;
				num = (short)2101116538;
				short num3 = num;
				num = (short)875658874;
				switch (num3 == num)
				{
				}
				num = (short)517210113;
				if (num != 0)
				{
				}
				num = (short)2012741632;
				if (num != 0)
				{
				}
				return (bool)base.GetValue(AcpTextBoxFileBrowser.AreValuesEqualProperty);
			}
			set
			{
				short num = (short)993591296;
				short num2 = num;
				num = (short)1936572110;
				short num3 = num;
				num = (short)1203289806;
				switch (num3 == num)
				{
				}
				num = (short)1653932032;
				if (num != 0)
				{
				}
				num = (short)1867382785;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxFileBrowser.AreValuesEqualProperty, value);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00036EB4 File Offset: 0x000350B4
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00036F70 File Offset: 0x00035170
		public Expander MyExpander
		{
			get
			{
				short num = (short)638386176;
				short num2 = num;
				num = (short)253505777;
				short num3 = num;
				num = (short)1230254321;
				switch (num3 == num)
				{
				}
				num = (short)2070937600;
				if (num != 0)
				{
				}
				num = (short)1065549825;
				if (num != 0)
				{
				}
				return (Expander)base.GetValue(AcpTextBoxFileBrowser.MyExpanderProperty);
			}
			set
			{
				short num = (short)485959282;
				short num2 = num;
				num = (short)1038362226;
				switch (num2 == num)
				{
				default:
				{
					num = (short)355663872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2043281409;
				if (num != 0)
				{
				}
				num = (short)153223168;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxFileBrowser.MyExpanderProperty, value);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00037028 File Offset: 0x00035228
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000370E4 File Offset: 0x000352E4
		public IAcpUIParentCtrlBase MyParentCtrl
		{
			get
			{
				short num = (short)788057920;
				short num2 = num;
				num = (short)1872940864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)90177536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)253689857;
				if (num != 0)
				{
				}
				num = (short)1302790144;
				if (num != 0)
				{
				}
				return (IAcpUIParentCtrlBase)base.GetValue(AcpTextBoxFileBrowser.MyParentCtrlProperty);
			}
			set
			{
				short num = (short)1399157865;
				short num2 = num;
				num = (short)1618637929;
				switch (num2 == num)
				{
				default:
				{
					num = (short)866123776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)493944832;
				if (num != 0)
				{
				}
				num = (short)1357512705;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxFileBrowser.MyParentCtrlProperty, value);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00037198 File Offset: 0x00035398
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00037250 File Offset: 0x00035450
		public string Text
		{
			get
			{
				short num = (short)1293418497;
				if (num != 0)
				{
				}
				num = (short)1705377792;
				short num2 = num;
				num = (short)105613227;
				short num3 = num;
				num = (short)1249806251;
				switch (num3 == num)
				{
				}
				num = (short)1648885760;
				if (num != 0)
				{
				}
				return (string)base.GetValue(AcpTextBoxFileBrowser.TextProperty);
			}
			set
			{
				short num = (short)1440400280;
				short num2 = num;
				num = (short)1667416984;
				switch (num2 == num)
				{
				default:
				{
					num = (short)803733504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)85262337;
				if (num != 0)
				{
				}
				num = (short)831389696;
				if (num != 0)
				{
				}
				base.SetValue(AcpTextBoxFileBrowser.TextProperty, value);
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00037304 File Offset: 0x00035504
		// (set) Token: 0x06000331 RID: 817 RVA: 0x000373B0 File Offset: 0x000355B0
		public static Func<SelectionMode, List<string>> SelectVAFileDialog
		{
			[CompilerGenerated]
			get
			{
				short num = (short)1914241685;
				short num2 = num;
				num = (short)2088829589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)207945728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1083244545;
				if (num != 0)
				{
				}
				num = (short)347602944;
				if (num != 0)
				{
				}
				return AcpTextBoxFileBrowser.a;
			}
			[CompilerGenerated]
			set
			{
				short num = (short)1277624321;
				if (num != 0)
				{
				}
				num = (short)799997952;
				short num2 = num;
				num = (short)1043026057;
				short num3 = num;
				num = (short)1160990857;
				switch (num3 == num)
				{
				}
				num = (short)1827536896;
				if (num != 0)
				{
				}
				AcpTextBoxFileBrowser.a = value;
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00037460 File Offset: 0x00035660
		private void OnClick(object A_0, RoutedEventArgs A_1)
		{
			int a_ = 6;
			short num = (short)1204289536;
			switch (num)
			{
			default:
			{
				AppInfoManager.LoadingVoiceData = true;
				string text = string.Empty;
				try
				{
					num = (short)1969029139;
					int num2 = (int)((IntPtr)num);
					for (;;)
					{
						object obj;
						bool? flag;
						bool flag2;
						AcpOpenFileDialog acpOpenFileDialog;
						switch (num2)
						{
						case 0:
							goto IL_473;
						case 1:
							if (obj != null)
							{
								num = (short)347799558;
								num2 = (int)((IntPtr)num);
								continue;
							}
							num = (short)1943142405;
							num2 = (int)((IntPtr)num);
							continue;
						case 2:
							goto IL_45B;
						case 3:
							num = (short)1954349067;
							num2 = (int)((IntPtr)num);
							continue;
						case 4:
							if (flag.GetValueOrDefault() == flag2 & flag != null)
							{
								num = (short)420675597;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_16E;
						case 5:
							if (this.MyBLObject is AcpStringField)
							{
								num = (short)461111305;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_45B;
						case 6:
							goto IL_33B;
						case 7:
							goto IL_1DE;
						case 8:
							goto IL_1DE;
						case 9:
							(this.MyBLObject as AcpStringField).Value = text;
							num = (short)1283325954;
							num2 = (int)((IntPtr)num);
							continue;
						case 10:
							goto IL_16E;
						case 11:
						{
							List<string> list;
							if (list.Count > 0)
							{
								num = (short)1333002260;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_16E;
						}
						case 12:
							if (this.MyBLObject.Name == AcpUI.Common.Utility.c("쾛ﮝ쎟\udda3향쾩\udeab\udaadힱ\udab3펵쪷\udbb9킻ﶽꖿ냁냃꿅껇ꏉ꿋꿍꓏럑鋓뿕듗뿙닛뿝跟蟡믣꟥\udce7\ud9e9\udaeb\udded쓯", a_))
							{
								num = (short)1540751376;
								num2 = (int)((IntPtr)num);
								continue;
							}
							acpOpenFileDialog.Filter = AcpUI.Common.Utility.c("톛풟춡횣즥쒧쮩貫\udfaf\udbb1ힳ펵颷﮹튻킽꾿럁꫃ꗅ귇Ꟊ꧋ꃍ꓏닓뿕듗뿙꿛ﻝ죟죡쫣该黧诩엫鋭\udaef\udcf1駳胵駷", a_);
							num = (short)480706567;
							num2 = (int)((IntPtr)num);
							continue;
						case 13:
							text = acpOpenFileDialog.FileName;
							num = (short)1989410837;
							num2 = (int)((IntPtr)num);
							continue;
						case 14:
							this.b.Text = Path.GetFileName(text);
							obj = (this.MyBLObject as AcpKeyField);
							num = (short)61014017;
							num2 = (int)((IntPtr)num);
							continue;
						case 15:
							if (!string.IsNullOrEmpty(text))
							{
								num = (short)1350238222;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_45B;
						case 16:
							acpOpenFileDialog.Filter = AcpUI.Common.Utility.c("\udf9bﮝ튟횡춣삥솧즩춫\udaad햯銱튳\udfb5풷\udfb9쾻麽뛉𢡊", a_);
							num = (short)2086797320;
							num2 = (int)((IntPtr)num);
							continue;
						case 17:
							goto IL_12A;
						case 18:
						{
							List<string> list;
							if (list != null)
							{
								num = (short)1783496707;
								num2 = (int)((IntPtr)num);
								continue;
							}
							goto IL_16E;
						}
						case 19:
							switch (0)
							{
							case 0:
								goto IL_B9;
							}
							continue;
						case 20:
						{
							List<string> list;
							text = list[0];
							num = (short)215941130;
							num2 = (int)((IntPtr)num);
							continue;
						}
						case 21:
							goto IL_16E;
						case 22:
						{
							List<string> list = AcpTextBoxFileBrowser.SelectVAFileDialog(SelectionMode.Single);
							num = (short)1955267978;
							short num3 = num;
							num = (short)1071777162;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_33B;
							default:
								num = (short)1856176128;
								if (num != 0)
								{
								}
								num = (short)1591738386;
								num2 = (int)((IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_B9:
						if (AcpTextBoxFileBrowser.SelectVAFileDialog != null)
						{
							num = (short)670498838;
							num2 = (int)((IntPtr)num);
							continue;
						}
						acpOpenFileDialog = new AcpOpenFileDialog();
						num = (short)329383948;
						num2 = (int)((IntPtr)num);
						continue;
						IL_16E:
						num = (short)1789591567;
						num2 = (int)((IntPtr)num);
						continue;
						IL_1DE:
						acpOpenFileDialog.MultiSelect = false;
						flag = acpOpenFileDialog.ShowDialog();
						flag2 = true;
						num = (short)689963012;
						num2 = (int)((IntPtr)num);
						continue;
						IL_33B:
						((AcpKeyField)obj).Value = text;
						num = (short)750845969;
						num2 = (int)((IntPtr)num);
						continue;
						IL_45B:
						num = (short)1340211200;
						num2 = (int)((IntPtr)num);
					}
					IL_12A:
					IL_473:;
				}
				finally
				{
					num = (short)73596929;
					if (num != 0)
					{
					}
					AppInfoManager.LoadingVoiceData = false;
				}
				num = (short)508100608;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00037958 File Offset: 0x00035B58
		private void OnLostFocus(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)326565889;
			if (num != 0)
			{
			}
			num = (short)723517440;
			short num2 = num;
			num = (short)490677452;
			short num3 = num;
			num = (short)131015884;
			switch (num3 == num)
			{
			}
			num = (short)938541056;
			if (num != 0)
			{
			}
			this.Text = this.b.Text;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00037A10 File Offset: 0x00035C10
		private void AcpTextBoxFileBrowser_GotFocus(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1347656994;
			short num2 = num;
			num = (short)1819974946;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1256914944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1866334209;
			if (num != 0)
			{
			}
			num = (short)104595456;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00037AB8 File Offset: 0x00035CB8
		protected override void OnGotFocus(RoutedEventArgs e)
		{
			short num = (short)1389747142;
			short num2 = num;
			num = (short)2015353798;
			switch (num2 == num)
			{
			default:
			{
				num = (short)463536128;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1575747584;
			if (num != 0)
			{
			}
			num = (short)1503789057;
			if (num != 0)
			{
			}
			this.b.Focus();
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00037B70 File Offset: 0x00035D70
		public AcpTextBoxFileBrowser()
		{
			this.InitializeComponent();
			base.Focusable = true;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00037C70 File Offset: 0x00035E70
		[GeneratedCode("PresentationBuildTasks", "5.0.17.0")]
		[DebuggerNonUserCode]
		internal Delegate a(Type A_0, string A_1)
		{
			short num = (short)604247166;
			short num2 = num;
			num = (short)2059605118;
			switch (num2 == num)
			{
			default:
			{
				num = (short)320995328;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1259339777;
			if (num != 0)
			{
			}
			num = (short)648151040;
			if (num != 0)
			{
			}
			return Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00037EA8 File Offset: 0x000360A8
		// Note: this type is marked as 'beforefieldinit'.
		static AcpTextBoxFileBrowser()
		{
			int a_ = 6;
			short num = (short)374165864;
			short num2 = num;
			num = (short)675500392;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1206517760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)174391296;
			if (num != 0)
			{
			}
			num = (short)1373569025;
			if (num != 0)
			{
			}
			AcpTextBoxFileBrowser.IsAcpValidProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("햛송풣즧용얫쪭", a_), typeof(bool), typeof(AcpTextBoxFileBrowser), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxFileBrowser.IsAcpApplicableProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("햛송풣\ud8a7\udaa9삫잭펯펱횳\udab5\uddb7", a_), typeof(bool), typeof(AcpTextBoxFileBrowser), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxFileBrowser.IsAcpEditableProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("햛송풣첧쎩\ud8ab쾭튯\udeb1톳", a_), typeof(bool), typeof(AcpTextBoxFileBrowser), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxFileBrowser.IsAcpVisibleProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("햛송풣솧\ud9a9얫청\udcafힱ", a_), typeof(bool), typeof(AcpTextBoxFileBrowser), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
			AcpTextBoxFileBrowser.MyLabelCtrlProperty = DependencyProperty.RegisterAttached(AcpUI.Common.Utility.c("톛쎡욣쎥쒧\ud8ab\udcad\udcaf", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpTextBoxFileBrowser), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxFileBrowser.MyCopyButtonProperty = DependencyProperty.RegisterAttached(AcpUI.Common.Utility.c("톛춡풣\udfa5\udfa9\ud8ab\udaad\udfaf\udcb1습쪷횹", a_), typeof(IAcpUIChildCtrlBase), typeof(AcpTextBoxFileBrowser), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxFileBrowser.MyBLObjectProperty = DependencyProperty.RegisterAttached(AcpUI.Common.Utility.c("톛쒥슧쾩쾫\udaad", a_), typeof(AcpFieldBase), typeof(AcpTextBoxFileBrowser), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxFileBrowser.AreValuesEqualProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("\udd9b얟얣쪥\udda7쾩\udfab솯잱햳\udab5", a_), typeof(bool), typeof(AcpTextBoxFileBrowser), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxFileBrowser.MyExpanderProperty = DependencyProperty.RegisterAttached(AcpUI.Common.Utility.c("톛\udaa1풣장욧캩즫\udcad", a_), typeof(Expander), typeof(AcpTextBoxFileBrowser), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxFileBrowser.MyParentCtrlProperty = DependencyProperty.RegisterAttached(AcpUI.Common.Utility.c("톛쎡횣쎥욧\udea9\udaad슯\udeb1", a_), typeof(IAcpUIParentCtrlBase), typeof(AcpTextBoxFileBrowser), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
			AcpTextBoxFileBrowser.TextProperty = DependencyProperty.Register(AcpUI.Common.Utility.c("좛ﮝ\ud89f횡", a_), typeof(string), typeof(AcpTextBoxFileBrowser), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
		}

		// Token: 0x040001F2 RID: 498
		public static readonly DependencyProperty IsAcpValidProperty;

		// Token: 0x040001F3 RID: 499
		public static readonly DependencyProperty IsAcpApplicableProperty;

		// Token: 0x040001F4 RID: 500
		public static readonly DependencyProperty IsAcpEditableProperty;

		// Token: 0x040001F5 RID: 501
		public static readonly DependencyProperty IsAcpVisibleProperty;

		// Token: 0x040001F6 RID: 502
		public static readonly DependencyProperty MyLabelCtrlProperty;

		// Token: 0x040001F7 RID: 503
		public static readonly DependencyProperty MyCopyButtonProperty;

		// Token: 0x040001F8 RID: 504
		public static readonly DependencyProperty MyBLObjectProperty;

		// Token: 0x040001F9 RID: 505
		public static readonly DependencyProperty AreValuesEqualProperty;

		// Token: 0x040001FA RID: 506
		public static readonly DependencyProperty MyExpanderProperty;

		// Token: 0x040001FB RID: 507
		public static readonly DependencyProperty MyParentCtrlProperty;

		// Token: 0x040001FC RID: 508
		public static readonly DependencyProperty TextProperty;

		// Token: 0x040001FD RID: 509
		[CompilerGenerated]
		private static Func<SelectionMode, List<string>> a;
	}
}
