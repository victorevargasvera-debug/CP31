using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200009B RID: 155
	public class NullField : global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase, global::Motorola.CommonCPS.RadioManagement.UIModels.IBoolEdit, global::Motorola.CommonCPS.RadioManagement.UIModels.IFieldEdit, global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit, global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit, global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x000538D0 File Offset: 0x00051AD0
		public override bool IsVisible
		{
			get
			{
				short num = (short)1506279424;
				short num2 = num;
				num = (short)810806722;
				short num3 = num;
				num = (short)1502866882;
				switch (num3 == num)
				{
				}
				num = (short)400752640;
				if (num != 0)
				{
				}
				num = (short)779288577;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00053978 File Offset: 0x00051B78
		public override bool IsEditable
		{
			get
			{
				short num = (short)659947520;
				short num2 = num;
				num = (short)957489759;
				short num3 = num;
				num = (short)1586963039;
				switch (num3 == num)
				{
				}
				num = (short)627441664;
				if (num != 0)
				{
				}
				num = (short)1937768449;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00053A20 File Offset: 0x00051C20
		public override bool IsApplicable
		{
			get
			{
				short num = (short)558628864;
				short num2 = num;
				num = (short)1401749505;
				if (num != 0)
				{
				}
				num = (short)2033522029;
				short num3 = num;
				num = (short)273028461;
				switch (num3 == num)
				{
				}
				num = (short)1312751616;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00053ACC File Offset: 0x00051CCC
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00053B78 File Offset: 0x00051D78
		public bool IsChecked
		{
			get
			{
				short num = (short)1587937280;
				short num2 = num;
				num = (short)784182705;
				short num3 = num;
				num = (short)515812785;
				switch (num3 == num)
				{
				}
				num = (short)936574977;
				if (num != 0)
				{
				}
				num = (short)165543936;
				if (num != 0)
				{
				}
				return true;
			}
			set
			{
				short num = (short)1126760448;
				short num2 = num;
				num = (short)682652139;
				short num3 = num;
				num = (short)158101995;
				switch (num3 == num)
				{
				}
				num = (short)111280128;
				if (num != 0)
				{
				}
				num = (short)1839333377;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00053C20 File Offset: 0x00051E20
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> Items
		{
			get
			{
				short num = (short)966721536;
				short num2 = num;
				num = (short)2138750090;
				short num3 = num;
				num = (short)410631306;
				switch (num3 == num)
				{
				}
				num = (short)1899888640;
				if (num != 0)
				{
				}
				num = (short)1658388481;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00053CD0 File Offset: 0x00051ED0
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x00053D7C File Offset: 0x00051F7C
		public int SelectedIndex
		{
			get
			{
				short num = (short)1934098432;
				short num2 = num;
				num = (short)862885646;
				short num3 = num;
				num = (short)255432462;
				switch (num3 == num)
				{
				}
				num = (short)672530433;
				if (num != 0)
				{
				}
				num = (short)609681408;
				if (num != 0)
				{
				}
				return -1;
			}
			set
			{
				short num = (short)2002780160;
				short num2 = num;
				num = (short)1130592211;
				short num3 = num;
				num = (short)908818387;
				switch (num3 == num)
				{
				}
				num = (short)1373110273;
				if (num != 0)
				{
				}
				num = (short)988086272;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x00053E28 File Offset: 0x00052028
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x00053ED4 File Offset: 0x000520D4
		public bool SortedDefaultValue
		{
			get
			{
				short num = (short)750583808;
				short num2 = num;
				num = (short)402673195;
				short num3 = num;
				num = (short)1587760683;
				switch (num3 == num)
				{
				}
				num = (short)983040001;
				if (num != 0)
				{
				}
				num = (short)1860108288;
				if (num != 0)
				{
				}
				return true;
			}
			set
			{
				short num = (short)851509248;
				short num2 = num;
				num = (short)1762933165;
				short num3 = num;
				num = (short)1591425453;
				switch (num3 == num)
				{
				}
				num = (short)1186791424;
				if (num != 0)
				{
				}
				num = (short)1627324417;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x00053F80 File Offset: 0x00052180
		public bool IsReferField
		{
			get
			{
				short num = (short)1497694208;
				short num2 = num;
				num = (short)1950169400;
				short num3 = num;
				num = (short)2128099640;
				switch (num3 == num)
				{
				}
				num = (short)1454833665;
				if (num != 0)
				{
				}
				num = (short)2106327040;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00054028 File Offset: 0x00052228
		public decimal Max
		{
			get
			{
				short num = (short)1637351424;
				short num2 = num;
				num = (short)1204551681;
				if (num != 0)
				{
				}
				num = (short)1084860932;
				short num3 = num;
				num = (short)758557188;
				switch (num3 == num)
				{
				}
				num = (short)743374848;
				if (num != 0)
				{
				}
				return 2m;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x000540DC File Offset: 0x000522DC
		public decimal Min
		{
			get
			{
				short num = (short)1431371776;
				short num2 = num;
				num = (short)1758966684;
				short num3 = num;
				num = (short)2073015196;
				switch (num3 == num)
				{
				}
				num = (short)681312256;
				if (num != 0)
				{
				}
				num = (short)1462370305;
				if (num != 0)
				{
				}
				return 0m;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x0005418C File Offset: 0x0005238C
		public decimal[][] RangeSection
		{
			get
			{
				short num = (short)789905408;
				short num2 = num;
				num = (short)476660790;
				short num3 = num;
				num = (short)599475254;
				switch (num3 == num)
				{
				}
				num = (short)1614479360;
				if (num != 0)
				{
				}
				num = (short)724500481;
				if (num != 0)
				{
				}
				return null;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00054234 File Offset: 0x00052434
		public decimal Step
		{
			get
			{
				short num = (short)791801608;
				short num2 = num;
				num = (short)1894117128;
				switch (num2 == num)
				{
				default:
				{
					num = (short)45481984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)248905728;
				if (num != 0)
				{
				}
				num = (short)211681281;
				if (num != 0)
				{
				}
				return 1m;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x000542E4 File Offset: 0x000524E4
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x00054394 File Offset: 0x00052594
		public decimal Value
		{
			get
			{
				short num = (short)1852439678;
				short num2 = num;
				num = (short)1439104126;
				switch (num2 == num)
				{
				default:
				{
					num = (short)720699392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1729953793;
				if (num != 0)
				{
				}
				num = (short)710803456;
				if (num != 0)
				{
				}
				return 0m;
			}
			set
			{
				short num = (short)580647520;
				short num2 = num;
				num = (short)743373408;
				switch (num2 == num)
				{
				default:
				{
					num = (short)708378624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)538050561;
				if (num != 0)
				{
				}
				num = (short)471138304;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0005443C File Offset: 0x0005263C
		public global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<decimal, string>> CustomValueChoiceMap
		{
			get
			{
				short num = (short)1755300840;
				short num2 = num;
				num = (short)323339240;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1396703232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)553385984;
				if (num != 0)
				{
				}
				num = (short)1789853697;
				if (num != 0)
				{
				}
				return new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<decimal, string>>();
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x000544EC File Offset: 0x000526EC
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x0005459C File Offset: 0x0005279C
		public string Text
		{
			get
			{
				short num = (short)2104158608;
				short num2 = num;
				num = (short)1752361360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2026176512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2033057793;
				if (num != 0)
				{
				}
				num = (short)1921384448;
				if (num != 0)
				{
				}
				return "";
			}
			set
			{
				short num = (short)1660509836;
				short num2 = num;
				num = (short)1796955788;
				switch (num2 == num)
				{
				default:
				{
					num = (short)515440640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)686882817;
				if (num != 0)
				{
				}
				num = (short)1275396096;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00054644 File Offset: 0x00052844
		public int MaxLength
		{
			get
			{
				short num = (short)379650049;
				if (num != 0)
				{
				}
				num = (short)1922498560;
				short num2 = num;
				num = (short)212698310;
				short num3 = num;
				num = (short)543392966;
				switch (num3 == num)
				{
				}
				num = (short)1064239104;
				if (num != 0)
				{
				}
				return 1000;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x000546F4 File Offset: 0x000528F4
		public override bool IsPasteable
		{
			get
			{
				short num = (short)1329594369;
				if (num != 0)
				{
				}
				num = (short)60358656;
				short num2 = num;
				num = (short)943967593;
				short num3 = num;
				num = (short)625331561;
				switch (num3 == num)
				{
				}
				num = (short)1265238016;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x000547A0 File Offset: 0x000529A0
		public void RefreshChoices(bool isSortRequired)
		{
			short num = (short)1005710104;
			short num2 = num;
			num = (short)1579346712;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1721368576;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)306708480;
			if (num != 0)
			{
			}
			num = (short)1650720769;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0005484C File Offset: 0x00052A4C
		public void Increase()
		{
			short num = (short)902525515;
			short num2 = num;
			num = (short)43938379;
			switch (num2 == num)
			{
			default:
			{
				num = (short)117178368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)827129856;
			if (num != 0)
			{
			}
			num = (short)1809776641;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x000548F8 File Offset: 0x00052AF8
		public void Decrease()
		{
			short num = (short)1811182665;
			short num2 = num;
			num = (short)1912108105;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2065432576;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)900661249;
			if (num != 0)
			{
			}
			num = (short)1373831168;
			if (num != 0)
			{
			}
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x000549A4 File Offset: 0x00052BA4
		public override string ToString()
		{
			short num = (short)1623105740;
			short num2 = num;
			num = (short)1149083852;
			switch (num2 == num)
			{
			default:
			{
				num = (short)469368832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1543110657;
			if (num != 0)
			{
			}
			num = (short)531890176;
			if (num != 0)
			{
			}
			return string.Empty;
		}

		// Token: 0x040002A4 RID: 676
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> a = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem>();
	}
}
