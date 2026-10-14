using System;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000B5 RID: 181
	public abstract class RadioLicenseRadioViewBase : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::Motorola.CommonCPS.RadioManagement.UIModels.ICopyable
	{
		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x000632F8 File Offset: 0x000614F8
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x000633A8 File Offset: 0x000615A8
		public bool CapacityMaxLicense
		{
			get
			{
				short num = (short)1386086400;
				short num2 = num;
				num = (short)1372521405;
				short num3 = num;
				num = (short)862389181;
				switch (num3 == num)
				{
				}
				num = (short)431882241;
				if (num != 0)
				{
				}
				num = (short)1368719360;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)1294270464;
				short num2 = num;
				num = (short)1780236130;
				short num3 = num;
				num = (short)1236746082;
				switch (num3 == num)
				{
				}
				num = (short)524681217;
				if (num != 0)
				{
				}
				num = (short)353632256;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00063458 File Offset: 0x00061658
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1957822464;
				short num2 = num;
				num = (short)224270666;
				short num3 = num;
				num = (short)694163786;
				switch (num3 == num)
				{
				}
				num = (short)526254081;
				if (num != 0)
				{
				}
				num = (short)484442112;
				if (num != 0)
				{
				}
				return this.g;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0006350C File Offset: 0x0006170C
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x000635BC File Offset: 0x000617BC
		public string FeatureCount
		{
			get
			{
				short num = (short)1824784384;
				short num2 = num;
				num = (short)1997298057;
				short num3 = num;
				num = (short)936794505;
				switch (num3 == num)
				{
				}
				num = (short)1706885121;
				if (num != 0)
				{
				}
				num = (short)298057728;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1540816897;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == this.a)
						{
							num = (short)1114832903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a = value;
						num = (short)34603014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					case 2:
					{
						num = (short)1722940382;
						short num3 = num;
						num = (short)429456350;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)111345665;
							if (num != 0)
							{
							}
							num = (short)1696989184;
							if (num != 0)
							{
							}
							num = (short)1442185216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (!base.IsLoading)
						{
							num = (short)1647968256;
							short num4 = num;
							num = (short)860749829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						return;
					case 5:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase.get_FeatureCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1145044996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_60;
					case 7:
						return;
					}
					IL_44:
					if (value != null)
					{
						num = (short)739049474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_60:
					this.a = value;
					num = (short)1004208131;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x000637C4 File Offset: 0x000619C4
		// (set) Token: 0x060006E1 RID: 1761 RVA: 0x00063874 File Offset: 0x00061A74
		public string FeatureSummary
		{
			get
			{
				short num = (short)1383337304;
				short num2 = num;
				num = (short)1924271448;
				switch (num2 == num)
				{
				}
				num = (short)723714048;
				if (num != 0)
				{
				}
				num = (short)1808072704;
				short num3 = num;
				num = (short)1497104385;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)2137325568;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_45;
							}
							continue;
						case 1:
							goto IL_FB;
						case 2:
							if (value == this.b)
							{
								num = (short)582352897;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.b = value;
							num = (short)21954565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							num = (short)262144000;
							short num3 = num;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase.get_FeatureSummary())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)781647876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_175;
						case 5:
							goto IL_5E;
						case 6:
							if (!base.IsLoading)
							{
								num = (short)1142947843;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 7:
							num = (short)1020198914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_45:
						if (value != null)
						{
							num = (short)2123694087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_5E:
						this.b = value;
						num = (short)906625030;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_175:
					num = (short)150146913;
					short num4 = num;
					num = (short)778637153;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1AA;
					}
				}
				IL_FB:
				num = (short)365953025;
				if (num != 0)
				{
				}
				return;
				IL_1AA:
				num = (short)1960443904;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x00063A6C File Offset: 0x00061C6C
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00063B20 File Offset: 0x00061D20
		public string GroupName
		{
			get
			{
				short num = (short)889503006;
				short num2 = num;
				num = (short)1806286110;
				switch (num2 == num)
				{
				}
				num = (short)2138832897;
				if (num != 0)
				{
				}
				num = (short)1453654016;
				short num3 = num;
				num = (short)1286930432;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)570949632;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_44;
							}
							continue;
						case 1:
							goto IL_12A;
						case 2:
							if (value == this.c)
							{
								num = (short)144900097;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.c = value;
							num = (short)1719205893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase.get_GroupName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1001652228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1A4;
						case 5:
							goto IL_60;
						case 6:
							num = (short)1150746625;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)1373896707;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 7:
							num = (short)1140916226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_44:
						if (value != null)
						{
							num = (short)1830879239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_60:
						this.c = value;
						num = (short)1103495174;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1A4:
					num = (short)1138260509;
					short num3 = num;
					num = (short)2122611229;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1DA;
					}
				}
				IL_12A:
				num = (short)1879965696;
				short num4 = num;
				return;
				IL_1DA:
				num = (short)291438592;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x00063D20 File Offset: 0x00061F20
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x00063DCC File Offset: 0x00061FCC
		public string ModelNumber
		{
			get
			{
				short num = (short)2057372755;
				short num2 = num;
				num = (short)1052968019;
				switch (num2 == num)
				{
				}
				num = (short)877330432;
				if (num != 0)
				{
				}
				num = (short)869203968;
				short num3 = num;
				num = (short)1666252801;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)988610560;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_44;
							}
							continue;
						case 1:
							goto IL_120;
						case 2:
							if (value == this.d)
							{
								num = (short)26214401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.d = value;
							num = (short)727384069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase.get_ModelNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1193869316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_19B;
						case 5:
							goto IL_5E;
						case 6:
							if (!base.IsLoading)
							{
								num = (short)627376131;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 7:
							num = (short)1225392129;
							if (num != 0)
							{
							}
							num = (short)1657798658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_44:
						if (value != null)
						{
							num = (short)540213255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_5E:
						this.d = value;
						num = (short)170328070;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_19B:
					num = (short)58573761;
					short num3 = num;
					num = (short)376816577;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1D1;
					}
				}
				IL_120:
				num = (short)1304559616;
				short num4 = num;
				return;
				IL_1D1:
				num = (short)543621120;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x00063FC4 File Offset: 0x000621C4
		// (set) Token: 0x060006E7 RID: 1767 RVA: 0x00064074 File Offset: 0x00062274
		public string RadioAlias
		{
			get
			{
				short num = (short)1360658433;
				if (num != 0)
				{
				}
				num = (short)1923609669;
				short num2 = num;
				num = (short)489616453;
				switch (num2 == num)
				{
				}
				num = (short)1344143360;
				short num3 = num;
				num = (short)2111242240;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)1271070720;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_45;
							}
							continue;
						case 1:
							goto IL_126;
						case 2:
							if (value == this.e)
							{
								num = (short)332201985;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2097938433;
							if (num != 0)
							{
							}
							this.e = value;
							num = (short)1291386885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase.get_RadioAlias())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)576126980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1A1;
						case 5:
							goto IL_62;
						case 6:
							if (!base.IsLoading)
							{
								num = (short)721682435;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 7:
							num = (short)1950810114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_45:
						if (value != null)
						{
							num = (short)499056647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_62:
						this.e = value;
						num = (short)1606942726;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1A1:
					num = (short)1499158786;
					short num3 = num;
					num = (short)572479746;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1D6;
					}
				}
				IL_126:
				num = (short)309264384;
				short num4 = num;
				return;
				IL_1D6:
				num = (short)1382744064;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00064270 File Offset: 0x00062470
		// (set) Token: 0x060006E9 RID: 1769 RVA: 0x00064320 File Offset: 0x00062520
		public global::System.Guid? RadioGUID
		{
			get
			{
				short num = (short)1821063593;
				short num2 = num;
				num = (short)877148585;
				switch (num2 == num)
				{
				}
				num = (short)1844248577;
				if (num != 0)
				{
				}
				num = (short)1053360128;
				short num3 = num;
				num = (short)408748032;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)1903034369;
				if (num != 0)
				{
				}
				num = (short)1880162309;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
					{
						global::System.Guid? guid;
						if (guid != null)
						{
							num = (short)440270858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1067151439;
						short num3 = num;
						num = (short)500461647;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F4;
						default:
						{
							num = (short)2059468800;
							short num4 = num;
							num = (short)896860160;
							if (num != 0)
							{
							}
							num = (short)1512701958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						flag = true;
						goto IL_245;
					case 2:
						flag = false;
						goto IL_245;
					case 3:
					{
						global::System.Guid? guid = value;
						global::System.Guid? guid2 = this.g;
						num = (short)764018700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_263;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					case 6:
						num = (short)277872641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)881524738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!base.IsLoading)
						{
							num = (short)1110769673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						base.RaisePropertyChanged<global::System.Guid?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Guid?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase.get_RadioGUID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1784872973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::System.Guid? guid;
						global::System.Guid? guid2;
						flag = (guid.GetValueOrDefault() == guid2.GetValueOrDefault());
						goto IL_245;
					}
					case 11:
						return;
					case 12:
					{
						global::System.Guid? guid;
						global::System.Guid? guid2;
						if (guid != null != (guid2 != null))
						{
							num = (short)1267204103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)808124416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_F4;
					}
					IL_82:
					if (value != null)
					{
						num = (short)1583611907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_263;
					IL_245:
					if (flag)
					{
						num = (short)892928011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.g = value;
					num = (short)1995177988;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_263:
					this.g = value;
					num = (short)1339621384;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F4:;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00064614 File Offset: 0x00062814
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x000646C4 File Offset: 0x000628C4
		public string SerialNumber
		{
			get
			{
				short num = (short)1965267935;
				short num2 = num;
				num = (short)1901173727;
				switch (num2 == num)
				{
				}
				num = (short)356450305;
				if (num != 0)
				{
				}
				num = (short)259719168;
				short num3 = num;
				num = (short)223805440;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)1782906880;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_44;
							}
							continue;
						case 1:
							goto IL_FC;
						case 2:
							if (value == this.f)
							{
								num = (short)1637744641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.f = value;
							num = (short)2093350917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseRadioViewBase.get_SerialNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)731512836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_19D;
						case 5:
							goto IL_5D;
						case 6:
							if (!base.IsLoading)
							{
								num = (short)1832386563;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 7:
							num = (short)1564278786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_44:
						if (value != null)
						{
							num = (short)418250759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_5D:
						this.f = value;
						num = (short)615710726;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_19D:
					num = (short)1806034620;
					short num3 = num;
					num = (short)1999627964;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1D2;
					}
				}
				IL_FC:
				num = (short)1489371137;
				if (num != 0)
				{
				}
				num = (short)826933248;
				short num4 = num;
				return;
				IL_1D2:
				num = (short)1847918592;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x000648BC File Offset: 0x00062ABC
		public virtual void CopyFrom(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase source)
		{
			int a_ = 14;
			short num = (short)1753779471;
			short num2 = num;
			num = (short)1113296143;
			switch (num2 == num)
			{
			}
			num = (short)1109458945;
			if (num != 0)
			{
			}
			num = (short)1142489088;
			short num3 = num;
			num = (short)1859387392;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CopyObjectPublicProperties(source, this, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("Ὀ⩊⅌♎㕐㉒⅔㡖⭘", a_));
		}

		// Token: 0x040002DC RID: 732
		private string a;

		// Token: 0x040002DD RID: 733
		private string b;

		// Token: 0x040002DE RID: 734
		private string c;

		// Token: 0x040002DF RID: 735
		private string d;

		// Token: 0x040002E0 RID: 736
		private string e;

		// Token: 0x040002E1 RID: 737
		private string f;

		// Token: 0x040002E2 RID: 738
		private global::System.Guid? g;

		// Token: 0x040002E3 RID: 739
		private bool h;
	}
}
