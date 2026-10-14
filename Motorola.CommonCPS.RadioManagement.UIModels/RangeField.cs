using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading;
using System.Xml.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000BE RID: 190
	public abstract class RangeField : global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase, global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit, global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit, global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit
	{
		// Token: 0x0600074D RID: 1869 RVA: 0x0006A98C File Offset: 0x00068B8C
		public RangeField()
		{
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x0600074E RID: 1870
		public abstract global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<decimal, string>> CustomValueChoiceMap { get; }

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x0006A9A0 File Offset: 0x00068BA0
		public decimal Max
		{
			get
			{
				short num = (short)1779755916;
				short num2 = num;
				num = (short)1281092492;
				switch (num2 == num)
				{
				}
				num = (short)459407360;
				short num3 = num;
				num = (short)553123841;
				if (num != 0)
				{
				}
				num = (short)1783365632;
				if (num != 0)
				{
				}
				return this.BlMax;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0006AA50 File Offset: 0x00068C50
		public decimal Min
		{
			get
			{
				short num = (short)1224304957;
				short num2 = num;
				num = (short)1183279421;
				switch (num2 == num)
				{
				}
				num = (short)1994522624;
				short num3 = num;
				num = (short)556466177;
				if (num != 0)
				{
				}
				num = (short)2036858880;
				if (num != 0)
				{
				}
				return this.BlMin;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x0006AB00 File Offset: 0x00068D00
		public decimal[][] RangeSection
		{
			get
			{
				short num = (short)535494588;
				short num2 = num;
				num = (short)816906172;
				switch (num2 == num)
				{
				}
				num = (short)1424293888;
				short num3 = num;
				num = (short)417136640;
				if (num != 0)
				{
				}
				num = (short)228392961;
				if (num != 0)
				{
				}
				return this.BlRangeSection;
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x0006ABB0 File Offset: 0x00068DB0
		public decimal Step
		{
			get
			{
				short num = (short)1780882284;
				short num2 = num;
				num = (short)1965431660;
				switch (num2 == num)
				{
				}
				num = (short)1735524352;
				short num3 = num;
				num = (short)1368915969;
				if (num != 0)
				{
				}
				num = (short)137166848;
				if (num != 0)
				{
				}
				return this.BlStep;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0006AC60 File Offset: 0x00068E60
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x0006AD10 File Offset: 0x00068F10
		public decimal Value
		{
			get
			{
				short num = (short)333845061;
				short num2 = num;
				num = (short)759435845;
				switch (num2 == num)
				{
				}
				num = (short)2126249984;
				short num3 = num;
				num = (short)951386112;
				if (num != 0)
				{
				}
				num = (short)18481153;
				if (num != 0)
				{
				}
				return this.BlValue;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_BB;
					case 1:
					{
						num2 = (short)707610558;
						short num3 = num2;
						num2 = (short)960841662;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BB;
						default:
							num2 = (short)1534132224;
							if (num2 != 0)
							{
							}
							if (this.BlValue != value)
							{
								num2 = (short)1822883840;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						break;
					}
					case 2:
						goto IL_E6;
					}
					goto IL_1C;
					IL_BB:
					base.DoModifyBlValue(delegate
					{
						short num5 = (short)649134081;
						if (num5 != 0)
						{
						}
						num5 = (short)445486916;
						short num6 = num5;
						num5 = (short)1992529732;
						switch (num6 == num5)
						{
						}
						num5 = (short)470810624;
						short num7 = num5;
						num5 = (short)1003094016;
						if (num5 != 0)
						{
						}
						this.BlValue = value;
						this.RaisePropertyChanged<decimal>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<decimal>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RangeField)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RangeField.get_Value())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					});
					num2 = (short)1784545282;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E6:
				num2 = (short)2021588992;
				short num4 = num2;
				num2 = (short)637206529;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				num2 = (short)1688338433;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x0006AE58 File Offset: 0x00069058
		public virtual global::System.Type ValueType
		{
			get
			{
				short num = (short)366000271;
				short num2 = num;
				num = (short)559069327;
				switch (num2 == num)
				{
				}
				num = (short)1140064256;
				short num3 = num;
				num = (short)415694849;
				if (num != 0)
				{
				}
				num = (short)1968308224;
				if (num != 0)
				{
				}
				return typeof(decimal);
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x0006AF10 File Offset: 0x00069110
		public decimal MaxOriginal
		{
			get
			{
				short num = (short)2131781598;
				short num2 = num;
				num = (short)1642031070;
				switch (num2 == num)
				{
				}
				num = (short)1186398208;
				short num3 = num;
				num = (short)2135752705;
				if (num != 0)
				{
				}
				num = (short)963510272;
				if (num != 0)
				{
				}
				return this.BlMaxOriginal;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x0006AFBC File Offset: 0x000691BC
		public decimal MinOriginal
		{
			get
			{
				short num = (short)923402241;
				if (num != 0)
				{
				}
				num = (short)1861375238;
				short num2 = num;
				num = (short)288773382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)479133696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)564920320;
				if (num != 0)
				{
				}
				return this.BlMinOriginal;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0006B06C File Offset: 0x0006926C
		public decimal StepOriginal
		{
			get
			{
				short num = (short)1942391393;
				short num2 = num;
				num = (short)1415350881;
				switch (num2 == num)
				{
				}
				num = (short)1333788672;
				short num3 = num;
				num = (short)675872768;
				if (num != 0)
				{
				}
				num = (short)718405633;
				if (num != 0)
				{
				}
				return this.BlStepOriginal;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x0006B11C File Offset: 0x0006931C
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> Items
		{
			get
			{
				short num = (short)1158545408;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)2080561623;
					short num3 = num;
					num = (short)1089460695;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_22F:
						num = (short)1464008706;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)2084241408;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						break;
					}
					int num5;
					decimal step;
					global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> observableCollection;
					for (;;)
					{
						IL_73:
						switch (num2)
						{
						case 0:
						{
							num = (short)973668352;
							short num4 = num;
							goto IL_1F1;
						}
						case 1:
							goto IL_151;
						case 2:
							goto IL_1F1;
						case 3:
							goto IL_EE;
						case 4:
						{
							decimal[][] rangeSection;
							if (num5 >= rangeSection.Length)
							{
								num = (short)41746441;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							decimal[] array = rangeSection[num5];
							decimal d = array[0];
							decimal d2 = array[1];
							num = (short)142409731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							if (step == 0m)
							{
								num = (short)357629960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							decimal[][] rangeSection = this.RangeSection;
							num5 = 0;
							num = (short)1419837440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							num = (short)1844183041;
							if (num != 0)
							{
							}
							decimal d;
							decimal d2;
							if (!(d <= d2))
							{
								num = (short)1910374401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int count = observableCollection.Count;
							global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem item = new global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem(d.ToString(global::System.Globalization.CultureInfo.CurrentCulture));
							observableCollection.Add(item);
							d += step;
							num = (short)431357959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_EE;
						case 8:
							return observableCollection;
						case 9:
							return observableCollection;
						}
						goto IL_A2;
						IL_EE:
						num = (short)147783686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F1:
						num = (short)1466040324;
						num2 = (int)((global::System.IntPtr)num);
					}
					return observableCollection;
					IL_151:
					num5++;
					goto IL_22F;
					IL_A2:
					observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem>();
					step = this.Step;
					num = (short)199294981;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_73;
				}
				}
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x0006B3AC File Offset: 0x000695AC
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x0006B54C File Offset: 0x0006974C
		public int SelectedIndex
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				int num2;
				short num3;
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> items;
				string text;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return num2;
					case 1:
						return -1;
					case 2:
						goto IL_153;
					case 3:
					{
						num3 = (short)1080346588;
						short num4 = num3;
						num3 = (short)452577244;
						switch ((num4 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							return num2;
						default:
							num3 = (short)1025966081;
							if (num3 != 0)
							{
							}
							num3 = (short)1752432640;
							if (num3 != 0)
							{
							}
							if (items[num2].Name == text)
							{
								num3 = (short)351666176;
								short num5 = num3;
								num3 = (short)1522663424;
								num = (int)((global::System.IntPtr)num3);
								continue;
							}
							num2++;
							num3 = (short)178520066;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						break;
					}
					case 4:
						goto IL_153;
					case 5:
						if (num2 >= items.Count)
						{
							num3 = (short)2039283713;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1005912067;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_28;
					IL_153:
					num3 = (short)1001652229;
					num = (int)((global::System.IntPtr)num3);
				}
				return num2;
				IL_28:
				text = this.Text;
				items = this.Items;
				num2 = 0;
				num3 = (short)364511236;
				num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
			set
			{
				short num = (short)1872429057;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1472462848;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						num = (short)1671307902;
						short num4 = num;
						num = (short)1736450686;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)46137344;
							if (num != 0)
							{
							}
							this.Value = decimal.Parse(this.Items[value].Name, global::System.Globalization.CultureInfo.CurrentCulture);
							num = (short)1324220418;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 2:
						goto IL_F9;
					}
					IL_5A:
					if (value == -1)
					{
						return;
					}
					num = (short)116523008;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F9:
				num = (short)1150943233;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0006B67C File Offset: 0x0006987C
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x0006B728 File Offset: 0x00069928
		public bool SortedDefaultValue
		{
			get
			{
				short num = (short)645897779;
				short num2 = num;
				num = (short)245145139;
				switch (num2 == num)
				{
				}
				num = (short)1513029632;
				short num3 = num;
				num = (short)155123712;
				if (num != 0)
				{
				}
				num = (short)386138113;
				if (num != 0)
				{
				}
				return true;
			}
			set
			{
				short num = (short)268196760;
				short num2 = num;
				num = (short)960715672;
				switch (num2 == num)
				{
				}
				num = (short)1661403136;
				short num3 = num;
				num = (short)310247425;
				if (num != 0)
				{
				}
				num = (short)2005008384;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x0006B7D4 File Offset: 0x000699D4
		public bool IsReferField
		{
			get
			{
				short num = (short)1043202049;
				if (num != 0)
				{
				}
				num = (short)632533942;
				short num2 = num;
				num = (short)227783606;
				switch (num2 == num)
				{
				default:
				{
					num = (short)230948864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1530789888;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0006B880 File Offset: 0x00069A80
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x0006B944 File Offset: 0x00069B44
		public virtual string Text
		{
			get
			{
				short num = (short)1617053606;
				short num2 = num;
				num = (short)758400934;
				switch (num2 == num)
				{
				}
				num = (short)2133196800;
				short num3 = num;
				num = (short)1592459265;
				if (num != 0)
				{
				}
				num = (short)1458110464;
				if (num != 0)
				{
				}
				return this.Value.ToString(global::System.Threading.Thread.CurrentThread.CurrentCulture);
			}
			set
			{
				short num = (short)679411713;
				if (num != 0)
				{
				}
				num = (short)489619457;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					decimal value2;
					switch (num2)
					{
					case 0:
					{
						num = (short)1087349075;
						short num3 = num;
						num = (short)1971233107;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1908539392;
							if (num != 0)
							{
							}
							this.Value = value2;
							num = (short)2053111810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						num = (short)96731136;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					}
					case 2:
						return;
					}
					IL_82:
					if (!decimal.TryParse(value, global::System.Globalization.NumberStyles.Number, global::System.Threading.Thread.CurrentThread.CurrentCulture, out value2))
					{
						break;
					}
					num = (short)627245056;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0006BA6C File Offset: 0x00069C6C
		public int MaxLength
		{
			get
			{
				short num = (short)2122904382;
				short num2 = num;
				num = (short)321450814;
				switch (num2 == num)
				{
				}
				num = (short)464912384;
				short num3 = num;
				num = (short)1382350849;
				if (num != 0)
				{
				}
				num = (short)1167458304;
				if (num != 0)
				{
				}
				return 200;
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000762 RID: 1890
		protected abstract bool ForceValueInRange { get; }

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000763 RID: 1891
		protected abstract decimal BlMax { get; }

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000764 RID: 1892
		protected abstract decimal BlMin { get; }

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000765 RID: 1893
		protected abstract decimal BlMaxOriginal { get; }

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000766 RID: 1894
		protected abstract decimal BlMinOriginal { get; }

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000767 RID: 1895
		protected abstract decimal BlStepOriginal { get; }

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000768 RID: 1896
		protected abstract decimal[][] BlRangeSection { get; }

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000769 RID: 1897
		protected abstract decimal BlStep { get; }

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x0600076A RID: 1898
		// (set) Token: 0x0600076B RID: 1899
		protected abstract decimal BlValue { get; set; }

		// Token: 0x0600076C RID: 1900 RVA: 0x0006BB1C File Offset: 0x00069D1C
		public void RefreshChoices(bool isSortRequired)
		{
			short num = (short)1970733057;
			if (num != 0)
			{
			}
			num = (short)1179788850;
			short num2 = num;
			num = (short)1299981874;
			switch (num2 == num)
			{
			default:
			{
				num = (short)555155456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)725483520;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0006BBC4 File Offset: 0x00069DC4
		public virtual string GetCustomToolTip()
		{
			short num = (short)698056295;
			short num2 = num;
			num = (short)1999928935;
			switch (num2 == num)
			{
			}
			num = (short)672202752;
			short num3 = num;
			num = (short)709492736;
			if (num != 0)
			{
			}
			num = (short)1910046721;
			if (num != 0)
			{
			}
			return string.Empty;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0006BC74 File Offset: 0x00069E74
		public void Increase()
		{
			short num = (short)1072365575;
			int num2 = (int)((global::System.IntPtr)num);
			decimal a_;
			decimal a_2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_131;
				case 1:
					goto IL_251;
				case 2:
					goto IL_150;
				case 3:
					num = (short)1820721167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_222;
				case 5:
					goto IL_16C;
				case 6:
					if (!(this.Value > this.MaxOriginal))
					{
						num = (short)1649082371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_131;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 8:
					goto IL_3B7;
				case 9:
					if (!(this.Value < this.MinOriginal))
					{
						num = (short)919142413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_131;
				case 10:
					if (!(this.Value > this.Max))
					{
						num = (short)1642266638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_399;
				case 11:
					num = (short)234553354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_399;
				case 13:
				{
					num = (short)1718808497;
					short num3 = num;
					num = (short)1808723889;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16C;
					default:
						num = (short)301596672;
						if (num != 0)
						{
						}
						num = (short)1205731334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
					num = (short)209715217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if ((this.Value - this.MinOriginal) % this.StepOriginal != 0m)
					{
						num = (short)1689255936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					a_ = this.Value + this.StepOriginal;
					num = (short)980353028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					num = (short)1041170437;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if ((this.Value - this.Min) % this.Step != 0m)
					{
						num = (short)444596236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					a_2 = this.Value + this.Step;
					num = (short)1792147457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6C:
				if (this.ForceValueInRange)
				{
					num = (short)1054343184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)649527305;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_131:
				a_ = this.MinOriginal;
				num = (short)1713111042;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16C:
				if (!(this.Value < this.Min))
				{
					num = (short)2128347147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_399:
				a_2 = this.Min;
				num = (short)99155976;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D9:
			this.Value = this.a(a_2);
			return;
			IL_150:
			IL_222:
			goto IL_3BC;
			IL_251:
			num = (short)1671168001;
			if (num != 0)
			{
			}
			num = (short)1064697856;
			short num4 = num;
			IL_3B7:
			goto IL_D9;
			IL_3BC:
			this.Value = this.b(a_);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0006C04C File Offset: 0x0006A24C
		public void Decrease()
		{
			short num = (short)819003399;
			int num2 = (int)((global::System.IntPtr)num);
			decimal a_;
			decimal a_2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_220;
				case 1:
					num = (short)1443364868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (!(this.Value > this.Max))
					{
						num = (short)609615883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_374;
				case 3:
					if (!(this.Value < this.MinOriginal))
					{
						num = (short)86900750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_130;
				case 4:
					if ((this.Value - this.MinOriginal) % this.StepOriginal != 0m)
					{
						num = (short)1709899793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					a_ = this.Value - this.StepOriginal;
					num = (short)1592328192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!(this.Value > this.MaxOriginal))
					{
						num = (short)1133182977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_130;
				case 6:
					goto IL_16A;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 8:
					if ((this.Value - this.Min) % this.Step != 0m)
					{
						num = (short)1123418121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					a_2 = this.Value - this.Step;
					num = (short)2067398669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_374;
				case 10:
					goto IL_3BB;
				case 11:
				{
					num = (short)287965184;
					short num3 = num;
					num = (short)415498248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					goto IL_14E;
				case 13:
					goto IL_250;
				case 14:
				{
					num = (short)200156360;
					short num4 = num;
					num = (short)344401096;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16A;
					default:
						num = (short)240910336;
						if (num != 0)
						{
						}
						num = (short)1197604869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 15:
					num = (short)1842741254;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					num = (short)1649868802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_130;
				}
				IL_6D:
				if (this.ForceValueInRange)
				{
					num = (short)822542351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2007302147;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_130:
				a_ = this.MaxOriginal;
				num = (short)1757478924;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16A:
				if (!(this.Value < this.Min))
				{
					num = (short)219545616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_374:
				num = (short)1305870337;
				if (num != 0)
				{
				}
				a_2 = this.Max;
				num = (short)1425604618;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D9:
			this.Value = this.a(a_2);
			return;
			IL_14E:
			IL_220:
			goto IL_3C0;
			IL_250:
			IL_3BB:
			goto IL_D9;
			IL_3C0:
			this.Value = this.b(a_);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0006C428 File Offset: 0x0006A628
		public override void RaisePropertyChanged()
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_AE;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_13:
				num = (short)584867766;
				short num2 = num;
				num = (short)1532977078;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)167444480;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_1AB;
					case 1:
						goto IL_216;
					case 2:
						if (!base.IsLoading)
						{
							num = (short)317390859;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F2;
					case 3:
					{
						num = (short)2052718592;
						short num4 = num;
						goto IL_F2;
					}
					case 4:
						this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("᱉ⵋ≍╏㝑", a_));
						num = (short)1110310925;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (!base.IsLoading)
						{
							num = (short)958988289;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AB;
					case 6:
						this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("݉╋⁍", a_));
						num = (short)427687945;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!base.IsLoading)
						{
							num = (short)986447887;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16D;
					case 8:
						goto IL_130;
					case 9:
						num = (short)498991105;
						if (num != 0)
						{
						}
						goto IL_357;
					case 10:
						this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᡉⵋ⁍㝏㝑ݓ㍕㭗⹙㕛ㅝ๟", a_));
						num = (short)1237385224;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("᥉㡋⭍⁏", a_));
						num = (short)1725038595;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (!base.IsLoading)
						{
							num = (short)812843014;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_357;
					case 13:
						goto IL_272;
					case 14:
						if (!base.IsLoading)
						{
							num = (short)344195082;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_130;
					case 15:
						this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("݉ⵋ㙍", a_));
						num = (short)1966276625;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (!base.IsLoading)
						{
							num = (short)1304887300;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					case 17:
						goto IL_16D;
					}
					goto IL_AE;
					IL_F2:
					num = (short)1212743685;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_130:
					num = (short)415432706;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_16D:
					num = (short)1456209932;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AB:
					num = (short)1389690896;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_357:
					num = (short)2079457294;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_216:
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ṉ⥋㙍⑏", a_));
				num = (short)359333888;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_272:
			IL_396:
			base.IsSelfChangeOnly = false;
			return;
			IL_AE:
			base.RaisePropertyChanged();
			num = (short)1446969351;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0006C7D4 File Offset: 0x0006A9D4
		public override string ToString()
		{
			short num;
			string result;
			try
			{
				num = (short)61858909;
				short num2 = num;
				num = (short)1821369437;
				switch (num2 == num)
				{
				}
				num = (short)1703870464;
				if (num != 0)
				{
				}
				result = this.Value.ToString(global::System.Threading.Thread.CurrentThread.CurrentCulture);
			}
			catch (global::System.Exception)
			{
				result = string.Empty;
			}
			num = (short)73531392;
			short num3 = num;
			num = (short)1561788417;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0006C8B4 File Offset: 0x0006AAB4
		protected override global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult PasteFromOverride(global::System.Xml.Linq.XElement xmlElement, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Xml.Linq.XElement>> setsToAdd, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>> setsToRemove, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.PasteContext pasteContext)
		{
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult result;
			short num2;
			string value;
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
						return result;
					case 1:
						num2 = (short)564461569;
						if (num2 != 0)
						{
						}
						this.Text = value;
						result = global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Changed;
						num2 = (short)908460036;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						pasteContext.Statuses.InvalidFieldValue(this, value);
						num2 = (short)1731198976;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						decimal d;
						if (!decimal.TryParse(value, out d))
						{
							num2 = (short)348192768;
							short num3 = num2;
							num2 = (short)1164640258;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)2035154949;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						return result;
					case 5:
					{
						num2 = (short)594165917;
						short num4 = num2;
						num2 = (short)6111389;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_31;
						default:
						{
							num2 = (short)732954624;
							if (num2 != 0)
							{
							}
							decimal d;
							if (this.Value != d)
							{
								num2 = (short)364249089;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						}
						}
						break;
					}
					}
					goto IL_28;
				}
				return result;
			}
			IL_28:
			value = xmlElement.Value;
			result = global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
			IL_31:
			num2 = (short)256376835;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0006CA5C File Offset: 0x0006AC5C
		private static decimal a(decimal A_0, decimal A_1, decimal[][] A_2)
		{
			short num = (short)1509687296;
			switch (num)
			{
			default:
			{
				num = (short)1841561613;
				int num2 = (int)((global::System.IntPtr)num);
				decimal[] array;
				decimal[] array2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_2B0;
					case 1:
						if (array[0] <= A_0)
						{
							num = (short)1998913541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26A;
					case 2:
						num = (short)500760598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)336986112;
						short num3 = num;
						goto IL_43C;
					}
					case 4:
						if (A_1 > A_0)
						{
							num = (short)1510080524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return A_0;
					case 5:
						num = (short)771162119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_343;
					case 7:
						if (array[1] >= A_0)
						{
							num = (short)1971519496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26A;
					case 8:
						return A_0;
					case 9:
						return A_0;
					case 10:
					{
						int num4;
						if (num4 >= A_2.Length)
						{
							num = (short)1562968085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array = A_2[num4];
						num = (short)1110048769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						int num5;
						if (num5 < 0)
						{
							num = (short)730071057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2 = A_2[num5];
						num = (short)148504594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						int num5 = A_2.Length - 1;
						num = (short)1705246736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						switch (0)
						{
						case 0:
							goto IL_A9;
						}
						continue;
					case 14:
					{
						int num4 = 0;
						num = (short)1330446356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_265;
					case 16:
						goto IL_348;
					case 17:
						goto IL_381;
					case 18:
						if (array2[0] <= A_0)
						{
							num = (short)1588920322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B5;
					case 19:
						goto IL_348;
					case 20:
						goto IL_43C;
					case 21:
						num = (short)906231823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (array2[1] >= A_0)
						{
							num = (short)1851326473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B5;
					case 23:
					{
						if (array[0] > A_0)
						{
							num = (short)1917779968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						num4++;
						num = (short)1032388611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						if (!(array2[1] < A_0))
						{
							int num5;
							num5--;
							num = (short)523632659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2031432137;
						short num6 = num;
						num = (short)455946697;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_381;
						default:
							num = (short)1076625408;
							if (num != 0)
							{
							}
							num = (short)2017722374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_A9:
					if (A_1 < A_0)
					{
						num = (short)1443495937;
						if (num != 0)
						{
						}
						num = (short)379518990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)526385156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26A:
					num = (short)1351155735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B5:
					num = (short)1908277272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_348:
					num = (short)24510475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43C:
					num = (short)1358888970;
					num2 = (int)((global::System.IntPtr)num);
				}
				return A_0;
				IL_265:
				return A_0;
				IL_2B0:
				return array[0];
				IL_343:
				return array2[1];
				IL_381:
				return A_0;
			}
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0006CF0C File Offset: 0x0006B10C
		private decimal b(decimal A_0)
		{
			short num = (short)50659331;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)176601555;
					short num3 = num;
					num = (short)337099219;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2AC;
					default:
						num = (short)997130240;
						if (num != 0)
						{
						}
						num = (short)1470103553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (this.Value == this.MaxOriginal)
					{
						num = (short)1856045063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_124;
				case 2:
					return A_0;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				case 4:
					goto IL_161;
				case 5:
					return A_0;
				case 6:
				{
					num = (short)446496768;
					short num4 = num;
					if (A_0 > this.MaxOriginal)
					{
						num = (short)1131216896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_124;
				}
				case 7:
					num = (short)1638465546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (!(A_0 == this.MinOriginal - this.StepOriginal))
					{
						num = (short)3473410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E5;
				case 9:
					num = (short)1565261832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_2AC;
				case 11:
					num = (short)1144651789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (this.RangeSection.Length == 1)
					{
						num = (short)1039597572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2EC;
				case 13:
					if (this.Value == this.MinOriginal)
					{
						num = (short)1150287881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D9;
				}
				IL_5E:
				if (A_0 < this.MinOriginal)
				{
					num = (short)1421279243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1D9;
				IL_124:
				num = (short)1422065676;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D9:
				num = (short)2103115782;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AC:
				if (A_0 == this.MaxOriginal + this.StepOriginal)
				{
					goto IL_1D0;
				}
				num = (short)2100363269;
				num2 = (int)((global::System.IntPtr)num);
			}
			return A_0;
			IL_161:
			num = (short)1919418369;
			if (num != 0)
			{
			}
			return A_0;
			IL_1D0:
			return this.MinOriginal;
			IL_2E5:
			return this.MaxOriginal;
			IL_2EC:
			return global::Motorola.CommonCPS.RadioManagement.UIModels.RangeField.a(A_0, this.Value, this.RangeSection);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0006D218 File Offset: 0x0006B418
		private decimal a(decimal A_0)
		{
			short num = (short)1992753155;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1617319328;
					short num3 = num;
					num = (short)331830688;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2A9;
					default:
						num = (short)162988032;
						if (num != 0)
						{
						}
						num = (short)313589761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (this.Value == this.Max)
					{
						num = (short)512819207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11E;
				case 2:
					return A_0;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 4:
					return A_0;
				case 5:
					return A_0;
				case 6:
				{
					num = (short)693764096;
					short num4 = num;
					if (A_0 > this.Max)
					{
						num = (short)502726656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11E;
				}
				case 7:
					num = (short)1078525962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (!(A_0 == this.Min - this.Step))
					{
						num = (short)1641086978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E3;
				case 9:
					num = (short)855244808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_2A9;
				case 11:
					num = (short)1657208833;
					if (num != 0)
					{
					}
					num = (short)481624077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (this.RangeSection.Length == 1)
					{
						num = (short)251658244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2EA;
				case 13:
					if (this.Value == this.Min)
					{
						num = (short)993394697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D5;
				}
				IL_5D:
				if (A_0 < this.Min)
				{
					num = (short)1767112715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1D5;
				IL_11E:
				num = (short)1519517708;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D5:
				num = (short)2053570566;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A9:
				if (A_0 == this.Max + this.Step)
				{
					goto IL_1CC;
				}
				num = (short)207224837;
				num2 = (int)((global::System.IntPtr)num);
			}
			return A_0;
			IL_1CC:
			return this.Min;
			IL_2E3:
			return this.Max;
			IL_2EA:
			return global::Motorola.CommonCPS.RadioManagement.UIModels.RangeField.a(A_0, this.Value, this.RangeSection);
		}
	}
}
