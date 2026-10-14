using System;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000B6 RID: 182
	public class RadioLicenseFeatureViewBase : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::Motorola.CommonCPS.RadioManagement.UIModels.ICopyable
	{
		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x000649BC File Offset: 0x00062BBC
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x00064A6C File Offset: 0x00062C6C
		public bool CapacityMaxLicense
		{
			get
			{
				short num = (short)1458569216;
				short num2 = num;
				num = (short)1192641309;
				short num3 = num;
				num = (short)1616397085;
				switch (num3 == num)
				{
				}
				num = (short)1621098497;
				if (num != 0)
				{
				}
				num = (short)579928064;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)2005925888;
				short num2 = num;
				num = (short)179202350;
				short num3 = num;
				num = (short)288057646;
				switch (num3 == num)
				{
				}
				num = (short)1837105153;
				if (num != 0)
				{
				}
				num = (short)68419584;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00064B1C File Offset: 0x00062D1C
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00064BCC File Offset: 0x00062DCC
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1121386496;
				short num2 = num;
				num = (short)542431309;
				short num3 = num;
				num = (short)625662029;
				switch (num3 == num)
				{
				}
				num = (short)674103297;
				if (num != 0)
				{
				}
				num = (short)1292238848;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)1756889088;
				short num2 = num;
				num = (short)255592900;
				short num3 = num;
				num = (short)830671300;
				switch (num3 == num)
				{
				}
				num = (short)1017643009;
				if (num != 0)
				{
				}
				num = (short)1280442368;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00064C80 File Offset: 0x00062E80
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00064D30 File Offset: 0x00062F30
		public string FeatureID
		{
			get
			{
				short num = (short)1311440896;
				short num2 = num;
				num = (short)1656376281;
				short num3 = num;
				num = (short)200100825;
				switch (num3 == num)
				{
				}
				num = (short)1922170880;
				if (num != 0)
				{
				}
				num = (short)1005518849;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)864813057;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == this.a)
						{
							num = (short)553517063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a = value;
						num = (short)398000129;
						if (num != 0)
						{
						}
						num = (short)1319763974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 2:
					{
						num = (short)1323737252;
						short num3 = num;
						num = (short)1365876900;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1179123712;
							if (num != 0)
							{
							}
							num = (short)1142685696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (!base.IsLoading)
						{
							num = (short)1122959360;
							short num4 = num;
							num = (short)792592389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						return;
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase.get_FeatureID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)849018884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_62;
					case 7:
						return;
					}
					IL_45:
					if (value != null)
					{
						num = (short)373751810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_62:
					this.a = value;
					num = (short)847118339;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x00064F38 File Offset: 0x00063138
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00064FE8 File Offset: 0x000631E8
		public string FeatureName
		{
			get
			{
				short num = (short)145555456;
				short num2 = num;
				num = (short)1891172353;
				if (num != 0)
				{
				}
				num = (short)639171458;
				short num3 = num;
				num = (short)1089469314;
				switch (num3 == num)
				{
				}
				num = (short)1795031040;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1600913409;
				if (num != 0)
				{
				}
				num = (short)2067398657;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == this.b)
						{
							num = (short)1473183751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b = value;
						num = (short)298647558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_6A;
						}
						continue;
					case 2:
					{
						num = (short)2116906696;
						short num3 = num;
						num = (short)655257288;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1455030272;
							if (num != 0)
							{
							}
							num = (short)2009661440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						num = (short)1046020096;
						short num4 = num;
						if (!base.IsLoading)
						{
							num = (short)1647312901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						return;
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase.get_FeatureName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)419102724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_86;
					case 7:
						return;
					}
					IL_6A:
					if (value != null)
					{
						num = (short)441581570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_86:
					this.b = value;
					num = (short)1215365123;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x000651F0 File Offset: 0x000633F0
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x000652A4 File Offset: 0x000634A4
		public string FeatureNotice
		{
			get
			{
				short num = (short)685965312;
				short num2 = num;
				num = (short)1603962791;
				short num3 = num;
				num = (short)1915193255;
				switch (num3 == num)
				{
				}
				num = (short)540213249;
				if (num != 0)
				{
				}
				num = (short)1451884544;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)70778881;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == this.c)
						{
							num = (short)957022215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.c = value;
						num = (short)1690107910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 2:
					{
						num = (short)1872625665;
						if (num != 0)
						{
						}
						num = (short)1400617545;
						short num3 = num;
						num = (short)824752713;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)778698752;
							if (num != 0)
							{
							}
							num = (short)2132869120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						num = (short)80609280;
						short num4 = num;
						if (!base.IsLoading)
						{
							num = (short)446693381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						return;
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase.get_FeatureNotice())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1265500164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_87;
					case 7:
						return;
					}
					IL_45:
					if (value != null)
					{
						num = (short)41091074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_87:
					this.c = value;
					num = (short)1208221699;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x000654B0 File Offset: 0x000636B0
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x00065560 File Offset: 0x00063760
		public string FeatureSummary
		{
			get
			{
				short num = (short)1456799744;
				short num2 = num;
				num = (short)1860571958;
				short num3 = num;
				num = (short)2126517046;
				switch (num3 == num)
				{
				}
				num = (short)1223950336;
				if (num != 0)
				{
				}
				num = (short)867237889;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)913309697;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == this.d)
						{
							num = (short)216530951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.d = value;
						num = (short)1588264966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 2:
					{
						num = (short)886046721;
						if (num != 0)
						{
						}
						num = (short)346554628;
						short num3 = num;
						num = (short)1704526084;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)752222208;
							if (num != 0)
							{
							}
							num = (short)2105671680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						num = (short)803864576;
						short num4 = num;
						if (!base.IsLoading)
						{
							num = (short)1411514373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						return;
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase.get_FeatureSummary())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1225654276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_8B;
					case 7:
						return;
					}
					IL_45:
					if (value != null)
					{
						num = (short)1427374082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8B:
					this.d = value;
					num = (short)1370554371;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00065768 File Offset: 0x00063968
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x00065818 File Offset: 0x00063A18
		public string ModelNumber
		{
			get
			{
				short num = (short)1400766464;
				short num2 = num;
				num = (short)2016726195;
				short num3 = num;
				num = (short)983485619;
				switch (num3 == num)
				{
				}
				num = (short)1377763328;
				if (num != 0)
				{
				}
				num = (short)842530817;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)156237825;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == this.f)
						{
							num = (short)1895104519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.f = value;
						num = (short)774897670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 2:
					{
						num = (short)1795474973;
						short num3 = num;
						num = (short)27117085;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)779550720;
							if (num != 0)
							{
							}
							num = (short)190185472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (!base.IsLoading)
						{
							num = (short)108527616;
							short num4 = num;
							num = (short)2046558213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						return;
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase.get_ModelNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1135345668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_62;
					case 7:
						goto IL_17B;
					}
					IL_45:
					if (value != null)
					{
						num = (short)34734082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_62:
					this.f = value;
					num = (short)1886388227;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17B:
				num = (short)1352663041;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00065A1C File Offset: 0x00063C1C
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00065AD0 File Offset: 0x00063CD0
		public string RadioCount
		{
			get
			{
				short num = (short)478674944;
				short num2 = num;
				num = (short)1744047427;
				short num3 = num;
				num = (short)607849795;
				switch (num3 == num)
				{
				}
				num = (short)1220739073;
				if (num != 0)
				{
				}
				num = (short)1618804736;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)163250177;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == this.e)
						{
							num = (short)1981612039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e = value;
						num = (short)1877606406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 2:
					{
						num = (short)12036762;
						short num3 = num;
						num = (short)1538632346;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2044526592;
							if (num != 0)
							{
							}
							num = (short)1679622144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						num = (short)1598947329;
						if (num != 0)
						{
						}
						num = (short)379387904;
						short num4 = num;
						if (!base.IsLoading)
						{
							num = (short)2076639237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						return;
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase.get_RadioCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)395247620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_63;
					case 7:
						return;
					}
					IL_45:
					if (value != null)
					{
						num = (short)1017249794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_63:
					this.e = value;
					num = (short)766115843;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00065CD4 File Offset: 0x00063ED4
		public void CopyFrom(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase source)
		{
			int a_ = 10;
			short num = (short)377356288;
			short num2 = num;
			num = (short)952440574;
			short num3 = num;
			num = (short)1094391550;
			switch (num3 == num)
			{
			}
			num = (short)1797455872;
			if (num != 0)
			{
			}
			num = (short)1668808705;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CopyObjectPublicProperties(source, this, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ፄ♆╈≊⥌⹎═㱒❔", a_));
		}

		// Token: 0x040002E4 RID: 740
		private string a;

		// Token: 0x040002E5 RID: 741
		private string b;

		// Token: 0x040002E6 RID: 742
		private string c;

		// Token: 0x040002E7 RID: 743
		private string d;

		// Token: 0x040002E8 RID: 744
		private string e;

		// Token: 0x040002E9 RID: 745
		private string f;

		// Token: 0x040002EA RID: 746
		private global::System.Guid? g = new global::System.Guid?(global::System.Guid.NewGuid());

		// Token: 0x040002EB RID: 747
		private bool h;
	}
}
