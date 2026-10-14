using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000003 RID: 3
	public class ASTROOtarProfile : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO>, global::System.ComponentModel.IDataErrorInfo
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		private global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO SummaryEntity
		{
			get
			{
				short num = (short)533613994;
				short num2 = num;
				num = (short)800476586;
				switch (num2 == num)
				{
				}
				num = (short)1445265408;
				short num3 = num;
				num = (short)1553596417;
				if (num != 0)
				{
				}
				num = (short)1575813120;
				if (num != 0)
				{
				}
				return base.Entity;
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		public ASTROOtarProfile() : base(new global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO())
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021E4 File Offset: 0x000003E4
		public ASTROOtarProfile(global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO summaryEntity) : base(summaryEntity ?? new global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO())
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002208 File Offset: 0x00000408
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO APXOtarProfileDTO
		{
			get
			{
				short num = (short)19381868;
				short num2 = num;
				num = (short)866238060;
				switch (num2 == num)
				{
				}
				num = (short)2102525952;
				short num3 = num;
				num = (short)1558577152;
				if (num != 0)
				{
				}
				num = (short)2042626049;
				if (num != 0)
				{
				}
				return this.SummaryEntity;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000022B8 File Offset: 0x000004B8
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000236C File Offset: 0x0000056C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Guid? RadioID
		{
			get
			{
				short num = (short)855177101;
				short num2 = num;
				num = (short)641922957;
				switch (num2 == num)
				{
				}
				num = (short)2094530560;
				short num3 = num;
				num = (short)97910785;
				if (num != 0)
				{
				}
				num = (short)782368768;
				if (num != 0)
				{
				}
				return this.SummaryEntity.RadioUuid;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_34;
				}
				int num;
				short num2;
				global::System.Guid? guid;
				global::System.Guid? radioUuid;
				for (;;)
				{
					IL_0A:
					bool flag;
					switch (num)
					{
					case 0:
						num2 = (short)524222468;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
					{
						num2 = (short)1265325221;
						short num3 = num2;
						num2 = (short)828003493;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17E;
						default:
							num2 = (short)89325568;
							if (num2 != 0)
							{
							}
							this.SummaryEntity.RadioUuid = value;
							base.RaisePropertyChanged<global::System.Guid?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Guid?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile.get_RadioID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num2 = (short)194510856;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						if (guid == null)
						{
							num2 = (short)333709312;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_17E;
					case 3:
					{
						num2 = (short)2001731584;
						short num4 = num2;
						num2 = (short)1416167425;
						if (num2 != 0)
						{
						}
						flag = (guid.GetValueOrDefault() != radioUuid.GetValueOrDefault());
						goto IL_113;
					}
					case 4:
						flag = false;
						goto IL_113;
					case 5:
						num2 = (short)206307334;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						flag = true;
						goto IL_113;
					case 7:
						if (guid != null != (radioUuid != null))
						{
							num2 = (short)340262917;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)318636034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						return;
					}
					goto IL_34;
					IL_113:
					if (flag)
					{
						num2 = (short)67502081;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
					IL_17E:
					num2 = (short)1320878083;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_34:
				guid = value;
				radioUuid = this.SummaryEntity.RadioUuid;
				num2 = (short)1889009671;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000025B8 File Offset: 0x000007B8
		// (set) Token: 0x0600000B RID: 11 RVA: 0x0000266C File Offset: 0x0000086C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Guid ASTROOtarProfileID
		{
			get
			{
				short num = (short)552168039;
				short num2 = num;
				num = (short)836135527;
				switch (num2 == num)
				{
				}
				num = (short)722599936;
				short num3 = num;
				num = (short)1137573889;
				if (num != 0)
				{
				}
				num = (short)1828913152;
				if (num != 0)
				{
				}
				return this.SummaryEntity.OtarProfileUuid;
			}
			set
			{
				short num = (short)318308354;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)183238656;
						short num3 = num;
						goto IL_FB;
					}
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					num = (short)1907536835;
					short num4 = num;
					num = (short)1051177923;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_FB:
						this.SummaryEntity.OtarProfileUuid = value;
						base.RaisePropertyChanged<global::System.Guid>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Guid>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile.get_ASTROOtarProfileID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1701511169;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)502923265;
						if (num != 0)
						{
						}
						num = (short)2145124352;
						if (num != 0)
						{
						}
						if (!(value != this.SummaryEntity.OtarProfileUuid))
						{
							return;
						}
						num = (short)1017511936;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000027D0 File Offset: 0x000009D0
		// (set) Token: 0x0600000D RID: 13 RVA: 0x0000288C File Offset: 0x00000A8C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)2104683673;
				short num2 = num;
				num = (short)693890201;
				switch (num2 == num)
				{
				}
				num = (short)2090008576;
				short num3 = num;
				num = (short)307560448;
				if (num != 0)
				{
				}
				num = (short)50003969;
				if (num != 0)
				{
				}
				return new global::System.Guid?(this.SummaryEntity.OtarProfileUuid);
			}
			set
			{
				short num = (short)1176856118;
				short num2 = num;
				num = (short)172254774;
				switch (num2 == num)
				{
				}
				num = (short)705167360;
				short num3 = num;
				num = (short)483000320;
				if (num != 0)
				{
				}
				num = (short)847249409;
				if (num != 0)
				{
				}
				this.SummaryEntity.OtarProfileUuid = (value ?? global::System.Guid.Empty);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000295C File Offset: 0x00000B5C
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002A10 File Offset: 0x00000C10
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string SerialNumber
		{
			get
			{
				short num = (short)463339521;
				if (num != 0)
				{
				}
				num = (short)192123851;
				short num2 = num;
				num = (short)1098879947;
				switch (num2 == num)
				{
				default:
				{
					num = (short)207224832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1713700864;
				if (num != 0)
				{
				}
				return this.SummaryEntity.SerialNumber;
			}
			set
			{
				short num = (short)1843003392;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
						goto IL_127;
					case 2:
					{
						num = (short)1985964069;
						short num3 = num;
						num = (short)1368090661;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1396703232;
							if (num != 0)
							{
							}
							this.SummaryEntity.SerialNumber = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile.get_SerialNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1762328577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_31:
					num = (short)1910767617;
					if (num != 0)
					{
					}
					if (!(value != this.SummaryEntity.SerialNumber))
					{
						return;
					}
					num = (short)1163853826;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_127:
				num = (short)1191903232;
				short num4 = num;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002B70 File Offset: 0x00000D70
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002C30 File Offset: 0x00000E30
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string TemplateName
		{
			get
			{
				short num = (short)1738014720;
				short num2 = num;
				num = (short)89409167;
				short num3 = num;
				num = (short)515655311;
				switch (num3 == num)
				{
				}
				num = (short)1350696960;
				if (num != 0)
				{
				}
				num = (short)391380993;
				if (num != 0)
				{
				}
				return this.SummaryEntity.TemplateName ?? string.Empty;
			}
			set
			{
				short num = (short)1864826880;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						goto IL_127;
					case 2:
					{
						num = (short)1803332908;
						short num3 = num;
						num = (short)162639148;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1278083072;
							if (num != 0)
							{
							}
							this.SummaryEntity.TemplateName = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile.get_TemplateName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)860553217;
							if (num != 0)
							{
							}
							num = (short)1480916993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_30:
					if (!(value != this.SummaryEntity.TemplateName))
					{
						return;
					}
					num = (short)1789329410;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_127:
				num = (short)431095808;
				short num4 = num;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002D90 File Offset: 0x00000F90
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002E50 File Offset: 0x00001050
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string ConfigurationName
		{
			get
			{
				short num = (short)670433280;
				short num2 = num;
				num = (short)1811057822;
				short num3 = num;
				num = (short)310217886;
				switch (num3 == num)
				{
				}
				num = (short)721289217;
				if (num != 0)
				{
				}
				num = (short)216662016;
				if (num != 0)
				{
				}
				return this.SummaryEntity.ConfigurationName ?? string.Empty;
			}
			set
			{
				short num = (short)1149632512;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 1:
						goto IL_100;
					case 2:
					{
						num = (short)1063734011;
						short num3 = num;
						num = (short)1887062779;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)190119936;
							if (num != 0)
							{
							}
							this.SummaryEntity.ConfigurationName = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile.get_ConfigurationName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1064501249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_32:
					if (!(value != this.SummaryEntity.ConfigurationName))
					{
						return;
					}
					num = (short)1792540674;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_100:
				num = (short)722862081;
				if (num != 0)
				{
				}
				num = (short)1199308800;
				short num4 = num;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002FB0 File Offset: 0x000011B0
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00003074 File Offset: 0x00001274
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string RadioAlias
		{
			get
			{
				short num = (short)2020933632;
				short num2 = num;
				num = (short)1401576385;
				short num3 = num;
				num = (short)23419841;
				switch (num3 == num)
				{
				}
				num = (short)893190144;
				if (num != 0)
				{
				}
				num = (short)1841233921;
				if (num != 0)
				{
				}
				return this.SummaryEntity.RadioAlias ?? string.Empty;
			}
			set
			{
				short num = (short)1098121217;
				if (num != 0)
				{
				}
				num = (short)374800384;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					case 1:
						goto IL_128;
					case 2:
					{
						num = (short)1049644039;
						short num3 = num;
						num = (short)444288007;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)93192192;
							if (num != 0)
							{
							}
							this.SummaryEntity.RadioAlias = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile.get_RadioAlias())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1370423297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_57:
					if (!(value != this.SummaryEntity.RadioAlias))
					{
						return;
					}
					num = (short)415367170;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_128:
				num = (short)2090729472;
				short num4 = num;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000031D4 File Offset: 0x000013D4
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00003298 File Offset: 0x00001498
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string OtarProfileName
		{
			get
			{
				short num = (short)2137915392;
				short num2 = num;
				num = (short)1632399954;
				short num3 = num;
				num = (short)971731538;
				switch (num3 == num)
				{
				}
				num = (short)764608513;
				if (num != 0)
				{
				}
				num = (short)1512177664;
				if (num != 0)
				{
				}
				return this.SummaryEntity.OtarProfileName ?? string.Empty;
			}
			set
			{
				short num = (short)764739584;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
						goto IL_101;
					case 2:
					{
						num = (short)662899378;
						short num3 = num;
						num = (short)138218162;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1517158400;
							if (num != 0)
							{
							}
							this.SummaryEntity.OtarProfileName = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile.get_OtarProfileName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)428867585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_31:
					if (!(value != this.SummaryEntity.OtarProfileName))
					{
						return;
					}
					num = (short)1549336578;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_101:
				num = (short)9502721;
				if (num != 0)
				{
				}
				num = (short)1127350272;
				short num4 = num;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000033F8 File Offset: 0x000015F8
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000034AC File Offset: 0x000016AC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? IndependentList
		{
			get
			{
				short num = (short)262930432;
				short num2 = num;
				num = (short)834433336;
				short num3 = num;
				num = (short)1735749944;
				switch (num3 == num)
				{
				}
				num = (short)25493505;
				if (num != 0)
				{
				}
				num = (short)600375296;
				if (num != 0)
				{
				}
				return this.SummaryEntity.IndependentList;
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
				bool? flag;
				bool? independentList;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1907079368;
						short num3 = num2;
						num2 = (short)1467726024;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_116;
						default:
							num2 = (short)1954414592;
							if (num2 != 0)
							{
							}
							if (!(flag.GetValueOrDefault() == independentList.GetValueOrDefault() & flag != null == (independentList != null)))
							{
								num2 = (short)1083834369;
								if (num2 != 0)
								{
								}
								num2 = (short)1527382018;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return;
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_116;
					}
					goto IL_1C;
					IL_116:
					this.SummaryEntity.IndependentList = value;
					base.RaisePropertyChanged<bool?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile.get_IndependentList())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num2 = (short)639303681;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				flag = value;
				independentList = this.SummaryEntity.IndependentList;
				num2 = (short)1425342464;
				short num4 = num2;
				num2 = (short)1517551616;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000362C File Offset: 0x0000182C
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000036E4 File Offset: 0x000018E4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int? OtarID
		{
			get
			{
				short num = (short)557645824;
				short num2 = num;
				num = (short)106036405;
				short num3 = num;
				num = (short)288619701;
				switch (num3 == num)
				{
				}
				num = (short)893779969;
				if (num != 0)
				{
				}
				num = (short)1684013056;
				if (num != 0)
				{
				}
				return this.SummaryEntity.OtarId;
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
				int? num4;
				int? otarId;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1309138244;
						short num3 = num2;
						num2 = (short)1269488964;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_EE;
						default:
							num2 = (short)1110507520;
							if (num2 != 0)
							{
							}
							if (!(num4.GetValueOrDefault() == otarId.GetValueOrDefault() & num4 != null == (otarId != null)))
							{
								num2 = (short)146472962;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_14A;
						}
						break;
					}
					case 1:
						goto IL_148;
					case 2:
						goto IL_EE;
					}
					goto IL_1C;
					IL_EE:
					this.SummaryEntity.OtarId = value;
					base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile.get_OtarID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num2 = (short)1976696833;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_148:
				IL_14A:
				num2 = (short)2020605953;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				num4 = value;
				otarId = this.SummaryEntity.OtarId;
				num2 = (short)773521408;
				short num5 = num2;
				num2 = (short)1363214336;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003864 File Offset: 0x00001A64
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00003914 File Offset: 0x00001B14
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool IsOtarIDEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1288765440;
				short num2 = num;
				num = (short)1204551681;
				if (num != 0)
				{
				}
				num = (short)1236871882;
				short num3 = num;
				num = (short)1043278538;
				switch (num3 == num)
				{
				}
				num = (short)1740636160;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)783089664;
				short num2 = num;
				num = (short)1432299880;
				short num3 = num;
				num = (short)869411176;
				switch (num3 == num)
				{
				}
				num = (short)291700737;
				if (num != 0)
				{
				}
				num = (short)1972043776;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000039C8 File Offset: 0x00001BC8
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00003A78 File Offset: 0x00001C78
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string OTARIDError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1488125952;
				short num2 = num;
				num = (short)147014136;
				short num3 = num;
				num = (short)731529720;
				switch (num3 == num)
				{
				}
				num = (short)1690632193;
				if (num != 0)
				{
				}
				num = (short)13369344;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)219873280;
				short num2 = num;
				num = (short)1051500802;
				short num3 = num;
				num = (short)10920194;
				switch (num3 == num)
				{
				}
				num = (short)601882624;
				if (num != 0)
				{
				}
				num = (short)301531137;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000011 RID: 17
		public override string this[string propertyName]
		{
			get
			{
				int a_ = 0;
				short num = (short)1851981824;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 1:
						num = (short)257294337;
						if (num != 0)
						{
						}
						num = (short)615645187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_12D;
					case 3:
						if (!base.Validate(this.OTARIDError))
						{
							goto IL_115;
						}
						goto IL_E2;
					}
					IL_3D:
					num = (short)351001079;
					short num3 = num;
					num = (short)1896733175;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_115:
						num = (short)289669122;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1617297408;
						if (num != 0)
						{
						}
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("琺䤼帾㍀ੂń", a_)))
						{
							goto IL_157;
						}
						num = (short)1900478465;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_E2:
				return string.Empty;
				IL_12D:
				num = (short)107020288;
				short num4 = num;
				return base.Error;
				IL_157:
				return string.Empty;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003C94 File Offset: 0x00001E94
		public override void CleanErrors()
		{
			short num = (short)587680798;
			short num2 = num;
			num = (short)1714965534;
			switch (num2 == num)
			{
			}
			num = (short)1119354880;
			if (num != 0)
			{
			}
			num = (short)1891762177;
			if (num != 0)
			{
			}
			num = (short)1452474368;
			short num3 = num;
			base.CleanErrors();
			this.OTARIDError = string.Empty;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003D50 File Offset: 0x00001F50
		public override bool IsValidRecord()
		{
			int num;
			short num2;
			bool flag;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_FA;
					case 1:
						goto IL_E0;
					case 2:
					{
						num2 = (short)1870987265;
						if (num2 != 0)
						{
						}
						num2 = (short)7618387;
						short num3 = num2;
						num2 = (short)638271315;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27;
						default:
							num2 = (short)1784152064;
							if (num2 != 0)
							{
							}
							if (flag)
							{
								num2 = (short)254935043;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)2004877313;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						num2 = (short)806617088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20;
				}
				IL_E0:
				return false;
				IL_FA:
				num2 = (short)549978112;
				short num4 = num2;
				return base.Validate(this.OTARIDError);
			}
			}
			IL_20:
			flag = base.IsValidRecord();
			IL_27:
			num2 = (short)61210626;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003E90 File Offset: 0x00002090
		public override global::System.Collections.Generic.Dictionary<string, string> InvalidFieldErrorInfo()
		{
			int a_ = 0;
			int num;
			short num2;
			global::System.Collections.Generic.Dictionary<string, string> dictionary;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						goto IL_10C;
					case 1:
					{
						num2 = (short)116929157;
						short num3 = num2;
						num2 = (short)28193413;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2C;
						default:
							num2 = (short)2123497472;
							if (num2 != 0)
							{
							}
							if (!base.Validate(this.OTARIDError))
							{
								num2 = (short)325451778;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_10E;
						}
						break;
					}
					case 2:
						dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("琺椼績ፀੂń", a_), base.Error);
						num2 = (short)362479616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_25;
				}
				IL_10C:
				IL_10E:
				num2 = (short)1168703488;
				short num4 = num2;
				return dictionary;
			}
			}
			IL_25:
			dictionary = base.InvalidFieldErrorInfo();
			IL_2C:
			num2 = (short)1849884673;
			if (num2 != 0)
			{
			}
			num2 = (short)950272001;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x04000003 RID: 3
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a;

		// Token: 0x04000004 RID: 4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;
	}
}
