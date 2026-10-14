using System;
using System.Globalization;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000EF RID: 239
	public class ASTROSystemInfo : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary>
	{
		// Token: 0x06000B8C RID: 2956 RVA: 0x000ADF68 File Offset: 0x000AC168
		public ASTROSystemInfo() : base(new global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary())
		{
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000ADF90 File Offset: 0x000AC190
		public ASTROSystemInfo(global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary summary) : base(summary ?? new global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary())
		{
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x000ADFC4 File Offset: 0x000AC1C4
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x000AE074 File Offset: 0x000AC274
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1356791808;
				short num2 = num;
				num = (short)30675288;
				short num3 = num;
				num = (short)63312216;
				switch (num3 == num)
				{
				}
				num = (short)711786496;
				if (num != 0)
				{
				}
				num = (short)1329725441;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1094647808;
				short num2 = num;
				num = (short)602917556;
				short num3 = num;
				num = (short)1300548276;
				switch (num3 == num)
				{
				}
				num = (short)1805582337;
				if (num != 0)
				{
				}
				num = (short)6619136;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x000AE128 File Offset: 0x000AC328
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x000AE1DC File Offset: 0x000AC3DC
		public string SystemName
		{
			get
			{
				short num = (short)1139671040;
				short num2 = num;
				num = (short)1649078152;
				short num3 = num;
				num = (short)984674184;
				switch (num3 == num)
				{
				}
				num = (short)1012400128;
				if (num != 0)
				{
				}
				num = (short)520290305;
				if (num != 0)
				{
				}
				return this.EntitySummary.SystemName;
			}
			set
			{
				short num = (short)1288678221;
				short num2 = num;
				num = (short)1640541005;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1956184064;
					if (num != 0)
					{
					}
					if (value == this.EntitySummary.SystemName)
					{
						num = (short)299499521;
						if (num != 0)
						{
						}
						num = (short)1888288768;
						short num3 = num;
						return;
					}
					break;
				}
				this.EntitySummary.SystemName = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo.get_SystemName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x000AE2DC File Offset: 0x000AC4DC
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x000AE3D4 File Offset: 0x000AC5D4
		public string SystemId
		{
			get
			{
				int a_ = 7;
				short num = (short)1227785373;
				short num2 = num;
				num = (short)143951005;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)213647360;
					if (num != 0)
					{
					}
					num = (short)179896321;
					if (num != 0)
					{
					}
					if (this.EntitySummary.SystemId == null)
					{
						num = (short)346947584;
						short num3 = num;
						return null;
					}
					break;
				}
				return this.EntitySummary.SystemId.Value.ToString(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᩁ", a_), global::System.Globalization.CultureInfo.CurrentCulture);
			}
			set
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					int num3;
					short num4;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
						{
							int num2 = num3;
							int? systemId = this.EntitySummary.SystemId;
							if (!(num2 == systemId.GetValueOrDefault() & systemId != null))
							{
								num4 = (short)2045902850;
								num = (int)((global::System.IntPtr)num4);
								continue;
							}
							return;
						}
						case 1:
							return;
						case 2:
						{
							this.EntitySummary.SystemId = new int?(num3);
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo.get_SystemId())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num4 = (short)740857522;
							short num5 = num4;
							num4 = (short)2120390322;
							switch ((num5 == num4) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num4 = (short)4456449;
								if (num4 != 0)
								{
								}
								num4 = (short)436469760;
								short num6 = num4;
								num4 = (short)1729101824;
								if (num4 != 0)
								{
								}
								num4 = (short)166264833;
								num = (int)((global::System.IntPtr)num4);
								continue;
							}
							}
							break;
						}
						}
						break;
					}
					IL_1C:
					num3 = global::System.Convert.ToInt32(value, 16);
					num4 = (short)1754136576;
					num = (int)((global::System.IntPtr)num4);
					goto IL_0A;
				}
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x000AE550 File Offset: 0x000AC750
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x000AE628 File Offset: 0x000AC828
		public global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? SystemType
		{
			get
			{
				short num = (short)1588349114;
				short num2 = num;
				num = (short)978405562;
				int? systemType;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1184366593;
					if (num != 0)
					{
					}
					num = (short)1261436928;
					if (num != 0)
					{
					}
					systemType = this.EntitySummary.SystemType;
					if (systemType == null)
					{
						num = (short)340721664;
						short num3 = num;
						return null;
					}
					break;
				}
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType)systemType.GetValueOrDefault());
			}
			set
			{
				short num = (short)380895232;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					for (;;)
					{
						IL_1F:
						switch (0)
						{
						case 0:
							goto IL_4C;
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
						for (;;)
						{
							IL_29:
							int? num4;
							int? num5;
							int? num6;
							int? systemType;
							switch (num2)
							{
							case 0:
							{
								num = (short)305788030;
								short num3 = num;
								num = (short)313128062;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1F;
								default:
									num = (short)970194944;
									if (num != 0)
									{
									}
									num4 = new int?((int)astroSystemType.GetValueOrDefault());
									goto IL_133;
								}
								break;
							}
							case 1:
								num5 = null;
								num = (short)2096824323;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (astroSystemType == null)
								{
									num = (short)1241251841;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)862060544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num4 = num5;
								goto IL_133;
							case 4:
							{
								this.EntitySummary.SystemType = num6;
								base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo.get_SystemType())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
								num = (short)399900672;
								short num7 = num;
								num = (short)918880262;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								num = (short)2002452481;
								if (num != 0)
								{
								}
								if (!(num5.GetValueOrDefault() == systemType.GetValueOrDefault() & num5 != null == (systemType != null)))
								{
									num = (short)252116996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return;
							case 6:
								return;
							}
							break;
							IL_133:
							num6 = num4;
							num5 = num6;
							systemType = this.EntitySummary.SystemType;
							num = (short)1353777157;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_4C:
						astroSystemType = value;
						num = (short)2109145090;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_29;
					}
					return;
				}
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x000AE86C File Offset: 0x000ACA6C
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x000AE948 File Offset: 0x000ACB48
		public global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? SubSystemType
		{
			get
			{
				short num = (short)466827662;
				short num2 = num;
				num = (short)756300174;
				int? systemSubType;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)152371200;
					if (num != 0)
					{
					}
					systemSubType = this.EntitySummary.SystemSubType;
					if (systemSubType == null)
					{
						num = (short)1913061377;
						if (num != 0)
						{
						}
						num = (short)578289664;
						short num3 = num;
						return null;
					}
					break;
				}
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType)systemSubType.GetValueOrDefault());
			}
			set
			{
				short num = (short)1479737344;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_4F;
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? astroSystemSubType;
					for (;;)
					{
						IL_28:
						int? num4;
						int? num6;
						int? num7;
						switch (num2)
						{
						case 0:
							return;
						case 1:
						{
							int? num3 = null;
							num = (short)1242824706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							int? num3;
							num4 = num3;
							goto IL_DA;
						}
						case 3:
							if (astroSystemSubType == null)
							{
								num = (short)933560321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)811991044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)116555045;
							short num5 = num;
							num = (short)1132690725;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)1039728640;
								if (num != 0)
								{
								}
								num4 = new int?((int)astroSystemSubType.GetValueOrDefault());
								goto IL_DA;
							}
							break;
						}
						case 5:
							if (!(num6.GetValueOrDefault() == num7.GetValueOrDefault() & num6 != null == (num7 != null)))
							{
								num = (short)1824325638;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 6:
							num = (short)1613758465;
							if (num != 0)
							{
							}
							num = (short)473956359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary apxsystemInfoSummary = this.EntitySummary;
							astroSystemSubType = value;
							int? systemSubType;
							if (astroSystemSubType == null)
							{
								num7 = null;
								systemSubType = num7;
							}
							else
							{
								systemSubType = new int?((int)astroSystemSubType.GetValueOrDefault());
							}
							apxsystemInfoSummary.SystemSubType = systemSubType;
							base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo.get_SubSystemType())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1841430528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_4F;
						IL_DA:
						num6 = num4;
						num7 = this.EntitySummary.SystemSubType;
						num = (short)2048262144;
						short num8 = num;
						num = (short)784334853;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
					IL_4F:
					astroSystemSubType = value;
					num = (short)120193027;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x000AEBCC File Offset: 0x000ACDCC
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x000AEC80 File Offset: 0x000ACE80
		public int RadioCount
		{
			get
			{
				short num = (short)664312323;
				short num2 = num;
				num = (short)550214147;
				switch (num2 == num)
				{
				}
				num = (short)1985609728;
				if (num != 0)
				{
				}
				num = (short)1725300737;
				if (num != 0)
				{
				}
				num = (short)1526923264;
				short num3 = num;
				return this.EntitySummary.RadioCount;
			}
			set
			{
				short num = (short)1776877569;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1066600363;
						short num3 = num;
						num = (short)1987446699;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)985071616;
							if (num != 0)
							{
							}
							break;
						}
						num = (short)2066612224;
						short num4 = num;
						this.EntitySummary.RadioCount = value;
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo.get_RadioCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)557252610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						goto IL_124;
					}
					IL_30:
					if (value == this.EntitySummary.RadioCount)
					{
						return;
					}
					num = (short)727056384;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_124:
				num = (short)244711425;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x000AEDDC File Offset: 0x000ACFDC
		public string CustomID
		{
			get
			{
				int a_ = 7;
				short num = (short)1907941138;
				short num2 = num;
				num = (short)153149202;
				switch (num2 == num)
				{
				}
				num = (short)1233715201;
				if (num != 0)
				{
				}
				num = (short)686030848;
				if (num != 0)
				{
				}
				num = (short)560070656;
				short num3 = num;
				return string.Concat(new string[]
				{
					this.SystemId,
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("潁", a_),
					(this.SystemType != null) ? this.SystemType.ToString() : null,
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("潁", a_),
					(this.SubSystemType != null) ? this.SubSystemType.ToString() : null,
					global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("潁", a_),
					this.SystemName
				});
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x000AEF3C File Offset: 0x000AD13C
		// (set) Token: 0x06000B9C RID: 2972 RVA: 0x000AEFEC File Offset: 0x000AD1EC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("AskRequired")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? AskRequired
		{
			get
			{
				short num = (short)1057323971;
				short num2 = num;
				num = (short)248282051;
				switch (num2 == num)
				{
				}
				num = (short)1090781185;
				if (num != 0)
				{
				}
				num = (short)1240072192;
				if (num != 0)
				{
				}
				num = (short)2058158080;
				short num3 = num;
				return this.EntitySummary.AskRequired;
			}
			set
			{
				short num;
				for (;;)
				{
					bool? flag = value;
					bool? askRequired = this.EntitySummary.AskRequired;
					if (flag.GetValueOrDefault() == askRequired.GetValueOrDefault() & flag != null == (askRequired != null))
					{
						num = (short)1037107201;
						if (num != 0)
						{
						}
						num = (short)907503295;
						short num2 = num;
						num = (short)86927039;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_BA;
						}
						break;
					}
					goto IL_D1;
				}
				num = (short)1848836096;
				short num3 = num;
				IL_BA:
				num = (short)1576009728;
				if (num != 0)
				{
				}
				return;
				IL_D1:
				this.EntitySummary.AskRequired = value;
				base.RaisePropertyChanged<bool?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo.get_AskRequired())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000B9D RID: 2973 RVA: 0x000AF10C File Offset: 0x000AD30C
		public string SerialNumber
		{
			get
			{
				short num = (short)859897857;
				if (num != 0)
				{
				}
				num = (short)2043161829;
				short num2 = num;
				num = (short)1366633701;
				switch (num2 == num)
				{
				}
				num = (short)567017472;
				if (num != 0)
				{
				}
				num = (short)1233846272;
				short num3 = num;
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_ASTROSystem_PeudoSerialNumber, this.RadioCount);
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x000AF1D0 File Offset: 0x000AD3D0
		public string RadioStatus
		{
			get
			{
				int a_ = 13;
				short num = (short)62980097;
				if (num != 0)
				{
				}
				num = (short)1901324831;
				short num2 = num;
				num = (short)1696786975;
				switch (num2 == num)
				{
				}
				num = (short)1696268288;
				if (num != 0)
				{
				}
				num = (short)1380777984;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("晇摉手", a_);
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x000AF290 File Offset: 0x000AD490
		public string TemplateName
		{
			get
			{
				int a_ = 3;
				short num = (short)1933304789;
				short num2 = num;
				num = (short)590865365;
				switch (num2 == num)
				{
				}
				num = (short)1752170496;
				if (num != 0)
				{
				}
				num = (short)260505601;
				if (num != 0)
				{
				}
				num = (short)1533870080;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ွ渿汁", a_);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x000AF350 File Offset: 0x000AD550
		public string ConfigurationName
		{
			get
			{
				int a_ = 3;
				short num = (short)681344983;
				short num2 = num;
				num = (short)2142732247;
				switch (num2 == num)
				{
				}
				num = (short)1910898688;
				if (num != 0)
				{
				}
				num = (short)643629057;
				if (num != 0)
				{
				}
				num = (short)220921856;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ွ渿汁", a_);
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000BA1 RID: 2977 RVA: 0x000AF410 File Offset: 0x000AD610
		public string RadioAlias
		{
			get
			{
				int a_ = 17;
				short num = (short)1639191977;
				short num2 = num;
				num = (short)1571624361;
				switch (num2 == num)
				{
				}
				num = (short)2014707713;
				if (num != 0)
				{
				}
				num = (short)1621295104;
				if (num != 0)
				{
				}
				num = (short)880803840;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("手恍繏", a_);
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x000AF4D0 File Offset: 0x000AD6D0
		public string RadioID
		{
			get
			{
				int a_ = 11;
				short num = (short)1619532300;
				short num2 = num;
				num = (short)277223948;
				switch (num2 == num)
				{
				}
				num = (short)1666121729;
				if (num != 0)
				{
				}
				num = (short)122355712;
				if (num != 0)
				{
				}
				num = (short)1136263168;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("桅晇摉", a_);
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x000AF594 File Offset: 0x000AD794
		private global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary EntitySummary
		{
			get
			{
				short num = (short)1640705145;
				short num2 = num;
				num = (short)21507193;
				switch (num2 == num)
				{
				}
				num = (short)1124663296;
				if (num != 0)
				{
				}
				num = (short)1096548353;
				if (num != 0)
				{
				}
				num = (short)8126464;
				short num3 = num;
				return base.Entity;
			}
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000AF644 File Offset: 0x000AD844
		public global::Motorola.CommonCPS.Server.EntityModel.APXSystemInfoSummary GetRawObject()
		{
			short num = (short)1371042715;
			short num2 = num;
			num = (short)188707739;
			switch (num2 == num)
			{
			}
			num = (short)697565185;
			if (num != 0)
			{
			}
			num = (short)174522368;
			if (num != 0)
			{
			}
			num = (short)916652032;
			short num3 = num;
			return this.EntitySummary;
		}

		// Token: 0x0400042E RID: 1070
		private global::System.Guid? a = new global::System.Guid?(global::System.Guid.NewGuid());
	}
}
