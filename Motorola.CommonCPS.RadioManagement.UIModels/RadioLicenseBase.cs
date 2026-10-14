using System;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000E7 RID: 231
	public class RadioLicenseBase : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::Motorola.CommonCPS.RadioManagement.UIModels.ICopyable
	{
		// Token: 0x06000B07 RID: 2823 RVA: 0x000A6D24 File Offset: 0x000A4F24
		public RadioLicenseBase()
		{
			this.b = string.Empty;
			this.c = string.Empty;
			this.d = string.Empty;
			this.e = string.Empty;
			this.f = string.Empty;
			this.g = null;
			this.i = string.Empty;
			this.j = null;
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x000A6D8C File Offset: 0x000A4F8C
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x000A6E3C File Offset: 0x000A503C
		public bool CapacityMaxLicense
		{
			get
			{
				short num = (short)511566649;
				short num2 = num;
				num = (short)1637475129;
				switch (num2 == num)
				{
				}
				num = (short)1768882176;
				short num3 = num;
				num = (short)181338113;
				if (num != 0)
				{
				}
				num = (short)91226112;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				short num = (short)1389044206;
				short num2 = num;
				num = (short)899949038;
				switch (num2 == num)
				{
				}
				num = (short)1282211840;
				short num3 = num;
				num = (short)66256897;
				if (num != 0)
				{
				}
				num = (short)798883840;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x000A6EEC File Offset: 0x000A50EC
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1655932571;
				short num2 = num;
				num = (short)1500481179;
				switch (num2 == num)
				{
				}
				num = (short)1570439168;
				short num3 = num;
				num = (short)855048192;
				if (num != 0)
				{
				}
				num = (short)1970667521;
				if (num != 0)
				{
				}
				return new global::System.Guid?(this.h);
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x000A6F9C File Offset: 0x000A519C
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x000A704C File Offset: 0x000A524C
		public global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary RawData
		{
			get
			{
				short num = (short)1468806758;
				short num2 = num;
				num = (short)1778857574;
				switch (num2 == num)
				{
				}
				num = (short)869662720;
				short num3 = num;
				num = (short)1317994496;
				if (num != 0)
				{
				}
				num = (short)870449153;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)215416834;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_99;
						case 1:
							num = (short)709427204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_38;
							}
							continue;
						case 3:
							goto IL_14E;
						case 4:
							if (value == this.j)
							{
								num = (short)1267793923;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.j = value;
							num = (short)1212088321;
							if (num != 0)
							{
							}
							num = (short)2080243712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_38:
						if (value == null)
						{
							goto IL_153;
						}
						num = (short)1624244225;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_14E:
					num = (short)1404775096;
					short num3 = num;
					num = (short)55323320;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_FC;
					}
					goto Block_1;
				}
				IL_99:
				goto IL_153;
				Block_1:
				num = (short)192020480;
				short num4 = num;
				IL_FC:
				num = (short)967442432;
				if (num != 0)
				{
				}
				return;
				IL_153:
				this.j = value;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x000A71B4 File Offset: 0x000A53B4
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x000A7264 File Offset: 0x000A5464
		public string RadioAlias
		{
			get
			{
				short num = (short)324403201;
				if (num != 0)
				{
				}
				num = (short)900036915;
				short num2 = num;
				num = (short)1218541875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)503709696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1571291136;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1634926592;
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
						if (!base.IsLoading)
						{
							num = (short)650379267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C6;
					case 2:
						return;
					case 3:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase.get_RadioAlias())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1169686534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1560512862;
						short num3 = num;
						num = (short)403081566;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A8;
						default:
						{
							num = (short)1140195328;
							if (num != 0)
							{
							}
							num = (short)2004353024;
							short num4 = num;
							goto IL_61;
						}
						}
						break;
					}
					case 5:
						num = (short)1224409095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1C3;
					case 7:
						if (value == this.b)
						{
							num = (short)1824849922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b = value;
						goto IL_A8;
					}
					IL_45:
					if (value != null)
					{
						num = (short)1042284549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_61:
					this.b = value;
					num = (short)911867905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A8:
					num = (short)801505284;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1C3:
				IL_1C6:
				num = (short)1074593793;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000A7460 File Offset: 0x000A5660
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x000A7510 File Offset: 0x000A5710
		public string SerialNumber
		{
			get
			{
				short num = (short)567279617;
				if (num != 0)
				{
				}
				num = (short)1809945747;
				short num2 = num;
				num = (short)1099338899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2139357184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1974337536;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1448869888;
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
						if (!base.IsLoading)
						{
							num = (short)740753411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						num = (short)103743489;
						if (num != 0)
						{
						}
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase.get_SerialNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1732837382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)454839193;
						short num3 = num;
						num = (short)353127321;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CE;
						default:
						{
							num = (short)1993080832;
							short num4 = num;
							num = (short)546832384;
							if (num != 0)
							{
							}
							goto IL_62;
						}
						}
						break;
					}
					case 5:
						num = (short)136380423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					case 7:
						if (value == this.c)
						{
							num = (short)2093285378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.c = value;
						goto IL_CE;
					}
					IL_45:
					if (value != null)
					{
						num = (short)1955135493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_62:
					this.c = value;
					num = (short)258932737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CE:
					num = (short)279838724;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x000A770C File Offset: 0x000A590C
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x000A77BC File Offset: 0x000A59BC
		public string FeatureName
		{
			get
			{
				short num = (short)780913438;
				short num2 = num;
				num = (short)688114462;
				switch (num2 == num)
				{
				}
				num = (short)521207808;
				short num3 = num;
				num = (short)1146290177;
				if (num != 0)
				{
				}
				num = (short)521601024;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)2034761728;
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
						if (!base.IsLoading)
						{
							num = (short)1308098563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase.get_FeatureName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1251606534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)468053006;
						short num3 = num;
						num = (short)2112023566;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A9;
						default:
						{
							num = (short)1290141696;
							if (num != 0)
							{
							}
							num = (short)1746337792;
							short num4 = num;
							goto IL_60;
						}
						}
						break;
					}
					case 5:
						num = (short)1733951495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					case 7:
						num = (short)1496383489;
						if (num != 0)
						{
						}
						if (value == this.e)
						{
							num = (short)810942466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.e = value;
						goto IL_A9;
					}
					IL_44:
					if (value != null)
					{
						num = (short)1342701573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_60:
					this.e = value;
					num = (short)266665985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A9:
					num = (short)513540100;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x000A79BC File Offset: 0x000A5BBC
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x000A7A6C File Offset: 0x000A5C6C
		public string FeatureStatus
		{
			get
			{
				short num = (short)1052770305;
				if (num != 0)
				{
				}
				num = (short)357015838;
				short num2 = num;
				num = (short)2021302558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1268383744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)320864256;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1393819648;
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
						if (!base.IsLoading)
						{
							num = (short)1300561923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase.get_FeatureStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)601423878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)504927406;
						short num3 = num;
						num = (short)1861981358;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A9;
						default:
						{
							num = (short)823197696;
							if (num != 0)
							{
							}
							num = (short)1568210944;
							short num4 = num;
							goto IL_62;
						}
						}
						break;
					}
					case 5:
						num = (short)2032467969;
						if (num != 0)
						{
						}
						num = (short)1295122439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					case 7:
						if (value == this.f)
						{
							num = (short)1127022594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.f = value;
						goto IL_A9;
					}
					IL_45:
					if (value != null)
					{
						num = (short)146866181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_62:
					this.f = value;
					num = (short)1832583169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A9:
					num = (short)2119761924;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x000A7C74 File Offset: 0x000A5E74
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x000A7D24 File Offset: 0x000A5F24
		public string ModelNumber
		{
			get
			{
				short num = (short)495845377;
				if (num != 0)
				{
				}
				num = (short)2055378531;
				short num2 = num;
				num = (short)734434915;
				switch (num2 == num)
				{
				}
				num = (short)33161216;
				short num3 = num;
				num = (short)92602368;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)845742080;
				short num2 = num;
				num = (short)390070279;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						return;
					case 1:
						if (value == this.d)
						{
							num = (short)2006908929;
							if (num != 0)
							{
							}
							num = (short)1530003456;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.d = value;
						goto IL_120;
					case 2:
						goto IL_D2;
					case 3:
						return;
					case 4:
					{
						num = (short)1195763773;
						short num4 = num;
						num = (short)1924982845;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_120;
						default:
							num = (short)493158400;
							if (num != 0)
							{
							}
							num = (short)1938817025;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						if (!base.IsLoading)
						{
							num = (short)2022113286;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase.get_ModelNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1716518915;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					}
					IL_6D:
					if (value != null)
					{
						num = (short)454361092;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D2:
					this.d = value;
					num = (short)1447100421;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_120:
					num = (short)762642434;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x000A7F20 File Offset: 0x000A6120
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x000A7FD0 File Offset: 0x000A61D0
		public global::System.Guid? DeviceUuid
		{
			get
			{
				short num = (short)1873862096;
				short num2 = num;
				num = (short)1223417296;
				switch (num2 == num)
				{
				}
				num = (short)1109786624;
				if (num != 0)
				{
				}
				num = (short)1598423040;
				short num3 = num;
				num = (short)825950209;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)707395597;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
					{
						global::System.Guid? guid = value;
						global::System.Guid? guid2 = this.g;
						num = (short)1257963530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Guid? guid;
						global::System.Guid? guid2;
						flag = (guid.GetValueOrDefault() == guid2.GetValueOrDefault());
						goto IL_1D3;
					}
					case 2:
						num = (short)1825374209;
						if (num != 0)
						{
						}
						flag = true;
						goto IL_1D3;
					case 3:
						flag = false;
						goto IL_1D3;
					case 4:
						num = (short)881328130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (!base.IsLoading)
						{
							num = (short)911081480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						return;
					case 7:
					{
						num = (short)1081148721;
						short num3 = num;
						num = (short)64292145;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1986134016;
							if (num != 0)
							{
							}
							goto IL_1F2;
						}
						break;
					}
					case 8:
						base.RaisePropertyChanged<global::System.Guid?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Guid?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase.get_DeviceUuid())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1349845001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_CE;
					case 10:
					{
						num = (short)226230272;
						short num4 = num;
						global::System.Guid? guid;
						global::System.Guid? guid2;
						if (guid != null != (guid2 != null))
						{
							num = (short)2064580619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1865941004;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)603062275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::System.Guid? guid;
						if (guid == null)
						{
							num = (short)652804100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1045037057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					}
					IL_5D:
					if (value != null)
					{
						num = (short)1547567104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F2;
					IL_1D3:
					if (flag)
					{
						num = (short)1622081542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.g = value;
					num = (short)21430279;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F2:
					this.g = value;
					num = (short)6029317;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CE:;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x000A82C8 File Offset: 0x000A64C8
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x000A8378 File Offset: 0x000A6578
		public global::System.Guid RadioLicenseUuid
		{
			get
			{
				short num = (short)790793432;
				short num2 = num;
				num = (short)1063161048;
				switch (num2 == num)
				{
				}
				num = (short)570556417;
				if (num != 0)
				{
				}
				num = (short)316604416;
				short num3 = num;
				num = (short)475791360;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)1854537729;
				if (num != 0)
				{
				}
				num = (short)665583620;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)2064580609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						base.RaisePropertyChanged<global::System.Guid>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Guid>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase.get_RadioLicenseUuid())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1534525443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					}
					IL_61:
					num = (short)1730084864;
					short num3 = num;
					if (value == this.h)
					{
						num = (short)2036072450;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1314334752;
						short num4 = num;
						num = (short)2093754400;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1004797952;
							if (num != 0)
							{
							}
							this.h = value;
							this.h = value;
							num = (short)1762721792;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x000A8520 File Offset: 0x000A6720
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x000A85D0 File Offset: 0x000A67D0
		public string FirmwareVersion
		{
			get
			{
				short num = (short)1403053503;
				short num2 = num;
				num = (short)143648191;
				switch (num2 == num)
				{
				}
				num = (short)1900281856;
				if (num != 0)
				{
				}
				num = (short)717225984;
				short num3 = num;
				num = (short)1365049345;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)783417348;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_140;
					case 1:
					{
						num = (short)361693184;
						short num3 = num;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase.get_FirmwareVersion())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1722548227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1072151927;
						short num4 = num;
						num = (short)805617015;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_140;
						default:
							num = (short)1879048192;
							if (num != 0)
							{
							}
							this.i = value;
							num = (short)1218052097;
							if (num != 0)
							{
							}
							num = (short)247005184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					}
					IL_38:
					if (this.i != value)
					{
						num = (short)1808072706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_140:
					if (base.IsLoading)
					{
						break;
					}
					num = (short)692649985;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x000A876C File Offset: 0x000A696C
		public override int GetHashCode()
		{
			short num = (short)2083906496;
			short num2 = num;
			num = (short)373810112;
			switch (num2 == num)
			{
			}
			num = (short)1638989825;
			if (num != 0)
			{
			}
			num = (short)1440153600;
			short num3 = num;
			num = (short)1357905920;
			if (num != 0)
			{
			}
			return base.GetHashCode();
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x000A881C File Offset: 0x000A6A1C
		public virtual void CopyFrom(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel)
		{
			int a_ = 1;
			short num = (short)1165618901;
			short num2 = num;
			num = (short)6024917;
			switch (num2 == num)
			{
			}
			num = (short)1812987904;
			if (num != 0)
			{
			}
			num = (short)140115968;
			short num3 = num;
			num = (short)1258160129;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CopyObjectPublicProperties(uiModel, this, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("樻弽ⰿ⭁⁃❅㱇╉㹋", a_));
		}

		// Token: 0x04000402 RID: 1026
		private const string a = "ManageRadioLicense";

		// Token: 0x04000403 RID: 1027
		private string b;

		// Token: 0x04000404 RID: 1028
		private string c;

		// Token: 0x04000405 RID: 1029
		private string d;

		// Token: 0x04000406 RID: 1030
		private string e;

		// Token: 0x04000407 RID: 1031
		private string f;

		// Token: 0x04000408 RID: 1032
		private global::System.Guid? g;

		// Token: 0x04000409 RID: 1033
		private global::System.Guid h;

		// Token: 0x0400040A RID: 1034
		private string i;

		// Token: 0x0400040B RID: 1035
		private global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary j;

		// Token: 0x0400040C RID: 1036
		private bool k;
	}
}
