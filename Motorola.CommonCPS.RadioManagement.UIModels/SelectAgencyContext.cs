using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.Security.SamlCommonUtility.DMHttpClients;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000031 RID: 49
	public class SelectAgencyContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00011300 File Offset: 0x0000F500
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000113B0 File Offset: 0x0000F5B0
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo> AvailableAgencies
		{
			get
			{
				short num = (short)1166053509;
				short num2 = num;
				num = (short)577867909;
				switch (num2 == num)
				{
				}
				num = (short)1650589696;
				if (num != 0)
				{
				}
				num = (short)191823873;
				if (num != 0)
				{
				}
				num = (short)1086455808;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1498152960;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)338789974;
					short num3 = num;
					num = (short)268011094;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1594753024;
						short num4 = num;
						num = (short)341704705;
						if (num != 0)
						{
						}
						num = (short)1151270912;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_CA;
							}
							continue;
						case 1:
							return;
						case 2:
							this.a = value;
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext.get_AvailableAgencies())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)992804865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_CA:
					if (value == this.a)
					{
						break;
					}
					num = (short)584646658;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00011500 File Offset: 0x0000F700
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000115B0 File Offset: 0x0000F7B0
		public global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo SelectedAgency
		{
			get
			{
				short num = (short)271712257;
				if (num != 0)
				{
				}
				num = (short)1704928696;
				short num2 = num;
				num = (short)433399224;
				switch (num2 == num)
				{
				}
				num = (short)338165760;
				if (num != 0)
				{
				}
				num = (short)383909888;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)1903689728;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1169747386;
					short num3 = num;
					num = (short)2006576570;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1222443008;
						short num4 = num;
						num = (short)1296171008;
						if (num != 0)
						{
						}
						num = (short)468189185;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_CA;
							}
							continue;
						case 1:
							return;
						case 2:
							this.b = value;
							base.RaisePropertyChanged<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext.get_SelectedAgency())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)263716865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_CA:
					if (value == this.b)
					{
						break;
					}
					num = (short)1253244930;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00011700 File Offset: 0x0000F900
		// (set) Token: 0x0600011D RID: 285 RVA: 0x000117AC File Offset: 0x0000F9AC
		public string UserName
		{
			get
			{
				short num = (short)1965778458;
				short num2 = num;
				num = (short)991061530;
				switch (num2 == num)
				{
				}
				num = (short)1794965505;
				if (num != 0)
				{
				}
				num = (short)1893662720;
				if (num != 0)
				{
				}
				num = (short)780926976;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)45678592;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)627506471;
					short num3 = num;
					num = (short)1057226023;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)6094848;
						short num4 = num;
						num = (short)282329088;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_A3;
							}
							continue;
						case 1:
							goto IL_11D;
						case 2:
							this.c = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext.get_UserName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1963655169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_A3:
					if (!(value != this.UserName))
					{
						break;
					}
					num = (short)979238914;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11D:
				num = (short)2087583745;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00011900 File Offset: 0x0000FB00
		public string WelcomeUser
		{
			get
			{
				short num = (short)1251847265;
				short num2 = num;
				num = (short)603434081;
				switch (num2 == num)
				{
				}
				num = (short)1936982017;
				if (num != 0)
				{
				}
				num = (short)440991744;
				if (num != 0)
				{
				}
				num = (short)2103967744;
				short num3 = num;
				return string.Format(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Welcome_User, this.c);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600011F RID: 287 RVA: 0x000119B8 File Offset: 0x0000FBB8
		public string Header
		{
			get
			{
				short num = (short)653674891;
				short num2 = num;
				num = (short)267864459;
				switch (num2 == num)
				{
				}
				num = (short)116785153;
				if (num != 0)
				{
				}
				num = (short)691142656;
				if (num != 0)
				{
				}
				num = (short)559939584;
				short num3 = num;
				return string.Format(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Select_Agency_Label, this.c);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000120 RID: 288 RVA: 0x00011A70 File Offset: 0x0000FC70
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00011B20 File Offset: 0x0000FD20
		public bool SubmitSuccess
		{
			get
			{
				short num = (short)1183562162;
				short num2 = num;
				num = (short)812759474;
				switch (num2 == num)
				{
				}
				num = (short)2112815105;
				if (num != 0)
				{
				}
				num = (short)680984576;
				if (num != 0)
				{
				}
				num = (short)1856831488;
				short num3 = num;
				return this.d;
			}
			set
			{
				short num = (short)489291776;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)188194147;
					short num3 = num;
					num = (short)2071567715;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)351338496;
						short num4 = num;
						num = (short)188547072;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_A6;
							}
							continue;
						case 1:
							goto IL_11D;
						case 2:
							this.d = value;
							base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectAgencyContext.get_SubmitSuccess())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)823394305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_A6:
					if (value == this.d)
					{
						return;
					}
					num = (short)1463681026;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11D:
				num = (short)724893697;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x04000088 RID: 136
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo> a = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo>();

		// Token: 0x04000089 RID: 137
		private global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo b;

		// Token: 0x0400008A RID: 138
		private string c;

		// Token: 0x0400008B RID: 139
		private bool d;
	}
}
