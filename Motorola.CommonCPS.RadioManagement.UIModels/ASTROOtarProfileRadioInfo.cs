using System;
using System.Globalization;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000007 RID: 7
	public class ASTROOtarProfileRadioInfo : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO>
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0000544C File Offset: 0x0000364C
		private global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO SummaryEntity
		{
			get
			{
				short num = (short)1192958373;
				short num2 = num;
				num = (short)4725157;
				switch (num2 == num)
				{
				}
				num = (short)786694145;
				if (num != 0)
				{
				}
				num = (short)629014528;
				if (num != 0)
				{
				}
				num = (short)23592960;
				short num3 = num;
				return base.Entity;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000054F8 File Offset: 0x000036F8
		public ASTROOtarProfileRadioInfo() : base(new global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO())
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005510 File Offset: 0x00003710
		public ASTROOtarProfileRadioInfo(global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO summary) : base(summary ?? new global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO())
		{
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00005534 File Offset: 0x00003734
		public global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO APXOtarProfileRadioInfoDTO
		{
			get
			{
				short num = (short)1123329333;
				short num2 = num;
				num = (short)872260917;
				switch (num2 == num)
				{
				}
				num = (short)200212480;
				if (num != 0)
				{
				}
				num = (short)128122881;
				if (num != 0)
				{
				}
				num = (short)1287389184;
				short num3 = num;
				return this.SummaryEntity;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000055E4 File Offset: 0x000037E4
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00005698 File Offset: 0x00003898
		public string RadioAlias
		{
			get
			{
				short num = (short)1242429819;
				short num2 = num;
				num = (short)1319500155;
				switch (num2 == num)
				{
				}
				num = (short)479592448;
				if (num != 0)
				{
				}
				num = (short)791347201;
				if (num != 0)
				{
				}
				num = (short)773980160;
				short num3 = num;
				return this.SummaryEntity.RadioAlias;
			}
			set
			{
				short num = (short)346619905;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_101;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
					{
						this.SummaryEntity.RadioAlias = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo.get_RadioAlias())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)24439467;
						short num3 = num;
						num = (short)643230379;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_101;
						default:
							num = (short)1091829760;
							if (num != 0)
							{
							}
							num = (short)1931739136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_30:
					if (!(value != this.SummaryEntity.RadioAlias))
					{
						goto IL_12C;
					}
					num = (short)173801474;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_101:
				num = (short)303300609;
				if (num != 0)
				{
				}
				IL_12C:
				num = (short)1138360320;
				short num4 = num;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000057FC File Offset: 0x000039FC
		// (set) Token: 0x06000043 RID: 67 RVA: 0x000058B0 File Offset: 0x00003AB0
		public string SerialNumber
		{
			get
			{
				short num = (short)1553113040;
				short num2 = num;
				num = (short)780902352;
				switch (num2 == num)
				{
				}
				num = (short)590610433;
				if (num != 0)
				{
				}
				num = (short)784662528;
				if (num != 0)
				{
				}
				num = (short)876740608;
				short num3 = num;
				return this.SummaryEntity.SerialNumber;
			}
			set
			{
				short num = (short)586743809;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_128;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 2:
					{
						num = (short)2054881281;
						if (num != 0)
						{
						}
						this.SummaryEntity.SerialNumber = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo.get_SerialNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)926814170;
						short num3 = num;
						num = (short)1226641370;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_128;
						default:
							num = (short)542572544;
							if (num != 0)
							{
							}
							num = (short)271974400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_32:
					if (!(value != this.SummaryEntity.SerialNumber))
					{
						break;
					}
					num = (short)601620482;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_128:
				num = (short)2083782656;
				short num4 = num;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00005A14 File Offset: 0x00003C14
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00005AD0 File Offset: 0x00003CD0
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)628929261;
				short num2 = num;
				num = (short)57127661;
				switch (num2 == num)
				{
				}
				num = (short)1046020097;
				if (num != 0)
				{
				}
				num = (short)742719488;
				if (num != 0)
				{
				}
				num = (short)1969487872;
				short num3 = num;
				return new global::System.Guid?(this.SummaryEntity.RadioUuid);
			}
			set
			{
				short num = (short)2030370817;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_F1;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
					{
						num = (short)1256914945;
						if (num != 0)
						{
						}
						this.SummaryEntity.RadioUuid = value.Value;
						num = (short)1229210869;
						short num3 = num;
						num = (short)1531593973;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F1;
						default:
							num = (short)15335424;
							if (num != 0)
							{
							}
							num = (short)641335296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_31:
					if (value == null)
					{
						break;
					}
					num = (short)373686274;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F1:
				num = (short)1704394752;
				short num4 = num;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00005BFC File Offset: 0x00003DFC
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00005CB8 File Offset: 0x00003EB8
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus? RadioStatus
		{
			get
			{
				short num = (short)1796058536;
				short num2 = num;
				num = (short)1984015784;
				switch (num2 == num)
				{
				}
				num = (short)1812463617;
				if (num != 0)
				{
				}
				num = (short)2075525120;
				if (num != 0)
				{
				}
				num = (short)1663041536;
				short num3 = num;
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?((global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus)this.SummaryEntity.RadioStatus);
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_34;
				}
				int num;
				short num4;
				global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus? radioStatus2;
				for (;;)
				{
					IL_0A:
					int? num3;
					int? num6;
					switch (num)
					{
					case 0:
					{
						int radioStatus = this.SummaryEntity.RadioStatus;
						int? num2 = num3;
						if (radioStatus == num2.GetValueOrDefault() & num2 != null)
						{
							return;
						}
						num4 = (short)351755221;
						short num5 = num4;
						num4 = (short)108944341;
						switch ((num5 == num4) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B5;
						default:
							num4 = (short)1862270976;
							if (num4 != 0)
							{
							}
							num4 = (short)459341826;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						break;
					}
					case 1:
					{
						int? num2;
						num6 = num2;
						goto IL_186;
					}
					case 2:
						num4 = (short)938475521;
						if (num4 != 0)
						{
						}
						num4 = (short)20905990;
						num = (int)((global::System.IntPtr)num4);
						continue;
					case 3:
					{
						num4 = (short)2128674816;
						short num7 = num4;
						if (radioStatus2 == null)
						{
							num4 = (short)741670919;
							num = (int)((global::System.IntPtr)num4);
							continue;
						}
						num4 = (short)422182917;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					case 4:
						this.SummaryEntity.RadioStatus = num3.Value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo.get_RadioStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num4 = (short)1533345800;
						num = (int)((global::System.IntPtr)num4);
						continue;
					case 5:
						num6 = new int?((int)radioStatus2.GetValueOrDefault());
						goto IL_186;
					case 6:
						goto IL_B5;
					case 7:
					{
						int? num2 = null;
						num4 = (short)293535745;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					case 8:
						return;
					}
					goto IL_34;
					IL_B5:
					if (num3 != null)
					{
						num4 = (short)1361707012;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					break;
					IL_186:
					num3 = num6;
					num4 = (short)585891840;
					num = (int)((global::System.IntPtr)num4);
				}
				return;
				IL_34:
				radioStatus2 = value;
				num4 = (short)2105933827;
				num = (int)((global::System.IntPtr)num4);
				goto IL_0A;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00005F18 File Offset: 0x00004118
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00005FCC File Offset: 0x000041CC
		public int ProfileCount
		{
			get
			{
				short num = (short)241397862;
				short num2 = num;
				num = (short)890400870;
				switch (num2 == num)
				{
				}
				num = (short)2041643009;
				if (num != 0)
				{
				}
				num = (short)811663360;
				if (num != 0)
				{
				}
				num = (short)793640960;
				short num3 = num;
				return this.SummaryEntity.ReferenceCount;
			}
			set
			{
				short num = (short)109969409;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_123;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
					{
						this.SummaryEntity.ReferenceCount = value;
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo.get_ProfileCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1323406242;
						short num3 = num;
						num = (short)5149602;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_123;
						default:
							num = (short)807796736;
							if (num != 0)
							{
							}
							num = (short)922419201;
							if (num != 0)
							{
							}
							num = (short)1849819136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_30:
					if (value == this.SummaryEntity.ReferenceCount)
					{
						break;
					}
					num = (short)221511682;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_123:
				num = (short)980484096;
				short num4 = num;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006128 File Offset: 0x00004328
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000061DC File Offset: 0x000043DC
		public string TemplateName
		{
			get
			{
				short num = (short)931581476;
				short num2 = num;
				num = (short)725077540;
				switch (num2 == num)
				{
				}
				num = (short)801112065;
				if (num != 0)
				{
				}
				num = (short)2131492864;
				if (num != 0)
				{
				}
				num = (short)1213792256;
				short num3 = num;
				return this.SummaryEntity.TemplateName;
			}
			set
			{
				short num = (short)1166213121;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1662058497;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_125;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 2:
					{
						this.SummaryEntity.TemplateName = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo.get_TemplateName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1491145388;
						short num3 = num;
						num = (short)1467093676;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_125;
						default:
							num = (short)584908800;
							if (num != 0)
							{
							}
							num = (short)753008640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_59:
					if (!(value != this.SummaryEntity.TemplateName))
					{
						break;
					}
					num = (short)357433346;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_125:
				num = (short)746520576;
				short num4 = num;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000633C File Offset: 0x0000453C
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000063F0 File Offset: 0x000045F0
		public string ConfigurationName
		{
			get
			{
				short num = (short)1121896805;
				short num2 = num;
				num = (short)299616613;
				switch (num2 == num)
				{
				}
				num = (short)672727041;
				if (num != 0)
				{
				}
				num = (short)1069613056;
				if (num != 0)
				{
				}
				num = (short)1795883008;
				short num3 = num;
				return this.SummaryEntity.ConfigurationName;
			}
			set
			{
				short num = (short)1153695745;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_101;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
					{
						this.SummaryEntity.ConfigurationName = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo.get_ConfigurationName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1640946123;
						short num3 = num;
						num = (short)2063784395;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_101;
						default:
							num = (short)104595456;
							if (num != 0)
							{
							}
							num = (short)239730688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_31:
					if (!(value != this.SummaryEntity.ConfigurationName))
					{
						goto IL_12A;
					}
					num = (short)897843202;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_101:
				num = (short)1766850561;
				if (num != 0)
				{
				}
				IL_12A:
				num = (short)830799872;
				short num4 = num;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00006554 File Offset: 0x00004754
		public string OtarProfileName
		{
			get
			{
				short num = (short)1920008193;
				if (num != 0)
				{
				}
				num = (short)654942330;
				short num2 = num;
				num = (short)1588109434;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1727201280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1756758016;
				if (num != 0)
				{
				}
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_OtarProfile_PseudoOtarProfileName, this.ProfileCount);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00006618 File Offset: 0x00004818
		public string IndependentList
		{
			get
			{
				int a_ = 8;
				short num = (short)1510745827;
				short num2 = num;
				num = (short)613623523;
				switch (num2 == num)
				{
				}
				num = (short)519634944;
				short num3 = num;
				num = (short)66846721;
				if (num != 0)
				{
				}
				num = (short)542507008;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("浂歄楆", a_);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000066D8 File Offset: 0x000048D8
		public string OtarID
		{
			get
			{
				int a_ = 5;
				short num = (short)1427071302;
				short num2 = num;
				num = (short)1996841286;
				switch (num2 == num)
				{
				}
				num = (short)801701888;
				short num3 = num;
				num = (short)1209991168;
				if (num != 0)
				{
				}
				num = (short)1883701249;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渿汁橃", a_);
			}
		}
	}
}
