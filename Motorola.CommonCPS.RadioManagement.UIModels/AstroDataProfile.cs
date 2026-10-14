using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000CA RID: 202
	public class AstroDataProfile : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary>, global::System.ComponentModel.IDataErrorInfo
	{
		// Token: 0x06000939 RID: 2361 RVA: 0x0008B098 File Offset: 0x00089298
		public AstroDataProfile() : base(new global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary())
		{
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0008B0B0 File Offset: 0x000892B0
		public AstroDataProfile(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary summaryEntity) : base(summaryEntity ?? new global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary())
		{
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0008B0D4 File Offset: 0x000892D4
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x0008B184 File Offset: 0x00089384
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string EditingField
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1256471621;
				short num2 = num;
				num = (short)1954692165;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1198587904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)877330433;
				if (num != 0)
				{
				}
				num = (short)304283648;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1042569458;
				short num2 = num;
				num = (short)1814452466;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1540620288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1646133249;
				if (num != 0)
				{
				}
				num = (short)241303552;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x0008B234 File Offset: 0x00089434
		// (set) Token: 0x0600093E RID: 2366 RVA: 0x0008B2E8 File Offset: 0x000894E8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Guid? DeviceID
		{
			get
			{
				short num = (short)554392851;
				short num2 = num;
				num = (short)279928083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)583794688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1644953601;
				if (num != 0)
				{
				}
				num = (short)1828716544;
				if (num != 0)
				{
				}
				return this.SummaryEntity.RadioUuid;
			}
			set
			{
				short num = (short)1230920898;
				short num2 = num;
				num = (short)1064787138;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_ED:
					num = (short)1486946311;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1033764864;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					break;
				}
				global::System.Guid? guid;
				global::System.Guid? radioUuid;
				for (;;)
				{
					IL_53:
					bool flag;
					switch (num3)
					{
					case 0:
						flag = true;
						goto IL_127;
					case 1:
						goto IL_ED;
					case 2:
						return;
					case 3:
						num = (short)494862336;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (guid == null)
						{
							num = (short)37879811;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1413808134;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (guid != null != (radioUuid != null))
						{
							num = (short)1038614528;
							short num4 = num;
							num = (short)41222145;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1353842692;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)335937537;
						if (num != 0)
						{
						}
						flag = (guid.GetValueOrDefault() == radioUuid.GetValueOrDefault());
						goto IL_127;
					case 7:
						flag = false;
						goto IL_127;
					}
					goto IL_79;
					IL_127:
					if (!flag)
					{
						goto IL_1D7;
					}
					num = (short)1766719490;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1D7:
				this.SummaryEntity.RadioUuid = value;
				base.RaisePropertyChanged<global::System.Guid?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Guid?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_DeviceID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				return;
				IL_79:
				guid = value;
				radioUuid = this.SummaryEntity.RadioUuid;
				num = (short)1706754053;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_53;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0008B50C File Offset: 0x0008970C
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x0008B5C0 File Offset: 0x000897C0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Guid AstroDataProfileID
		{
			get
			{
				short num = (short)425797036;
				short num2 = num;
				num = (short)777790892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1603534848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)36765697;
				if (num != 0)
				{
				}
				num = (short)674824192;
				if (num != 0)
				{
				}
				return this.SummaryEntity.Uuid;
			}
			set
			{
				short num;
				while (!(value == this.SummaryEntity.Uuid))
				{
					num = (short)1285910457;
					short num2 = num;
					num = (short)63926201;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)124846080;
						if (num != 0)
						{
						}
						num = (short)1109458945;
						if (num != 0)
						{
						}
						this.SummaryEntity.Uuid = value;
						base.RaisePropertyChanged<global::System.Guid>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Guid>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_AstroDataProfileID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
				}
				num = (short)70189056;
				short num3 = num;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x0008B6C0 File Offset: 0x000898C0
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x0008B778 File Offset: 0x00089978
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)374863189;
				short num2 = num;
				num = (short)547419477;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1799094272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1161035777;
				if (num != 0)
				{
				}
				num = (short)1360723968;
				if (num != 0)
				{
				}
				return new global::System.Guid?(this.SummaryEntity.Uuid);
			}
			set
			{
				short num = (short)318504961;
				if (num != 0)
				{
				}
				num = (short)1441857536;
				short num2 = num;
				num = (short)795689959;
				short num3 = num;
				num = (short)90588135;
				switch (num3 == num)
				{
				}
				num = (short)917962752;
				if (num != 0)
				{
				}
				this.SummaryEntity.Uuid = (value ?? global::System.Guid.Empty);
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0008B84C File Offset: 0x00089A4C
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x0008B900 File Offset: 0x00089B00
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? JobStatus
		{
			get
			{
				short num = (short)1241684771;
				short num2 = num;
				num = (short)1099275043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)68747264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)31784961;
				if (num != 0)
				{
				}
				num = (short)41025536;
				if (num != 0)
				{
				}
				return this.SummaryEntity.JobStatus;
			}
			set
			{
				short num;
				for (;;)
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus = value;
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus2 = this.SummaryEntity.JobStatus;
					if (jobStatus.GetValueOrDefault() == jobStatus2.GetValueOrDefault() & jobStatus != null == (jobStatus2 != null))
					{
						break;
					}
					num = (short)792920065;
					if (num != 0)
					{
					}
					num = (short)1579003933;
					short num2 = num;
					num = (short)1393733661;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_BB;
					}
				}
				num = (short)559808512;
				short num3 = num;
				return;
				IL_BB:
				num = (short)1854341120;
				if (num != 0)
				{
				}
				this.SummaryEntity.JobStatus = value;
				base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_JobStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0008BA20 File Offset: 0x00089C20
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x0008BAE0 File Offset: 0x00089CE0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string SerialNumber
		{
			get
			{
				short num = (short)1462133265;
				short num2 = num;
				num = (short)52650513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)835190784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)757858305;
				if (num != 0)
				{
				}
				num = (short)725090304;
				if (num != 0)
				{
				}
				return this.SummaryEntity.SerialNumber ?? string.Empty;
			}
			set
			{
				short num;
				while (!(value == this.SummaryEntity.SerialNumber))
				{
					num = (short)692357899;
					short num2 = num;
					num = (short)1836616459;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1417347072;
						if (num != 0)
						{
						}
						num = (short)1917517825;
						if (num != 0)
						{
						}
						this.SummaryEntity.SerialNumber = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_SerialNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
				}
				num = (short)1256718336;
				short num3 = num;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x0008BBE0 File Offset: 0x00089DE0
		// (set) Token: 0x06000948 RID: 2376 RVA: 0x0008BCB4 File Offset: 0x00089EB4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus? RadioStatus
		{
			get
			{
				int? radioStatus;
				short num;
				for (;;)
				{
					radioStatus = this.SummaryEntity.RadioStatus;
					if (radioStatus == null)
					{
						break;
					}
					num = (short)1505427457;
					if (num != 0)
					{
					}
					num = (short)1752539682;
					short num2 = num;
					num = (short)404791842;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A5;
					}
				}
				num = (short)1730084864;
				short num3 = num;
				return null;
				IL_A5:
				num = (short)475594752;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?((global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus)radioStatus.GetValueOrDefault());
			}
			set
			{
				short num = (short)1830330207;
				short num2 = num;
				num = (short)1601216351;
				global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus? radioStatus;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D3:
					if (radioStatus == null)
					{
						num = (short)1167261696;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1746731014;
						num3 = (int)((global::System.IntPtr)num);
					}
					break;
				default:
					num = (short)740229120;
					if (num != 0)
					{
					}
					num = (short)1607794688;
					num3 = (int)num;
					switch (num3)
					{
					default:
						switch (0)
						{
						case 0:
							goto IL_94;
						}
						break;
					}
					break;
				}
				for (;;)
				{
					IL_71:
					int? num5;
					int? num6;
					int? num7;
					switch (num3)
					{
					case 0:
					{
						int? num4 = null;
						num = (short)1924071429;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return;
					case 2:
						goto IL_110;
					case 3:
						if (num5.GetValueOrDefault() == num6.GetValueOrDefault() & num5 != null == (num6 != null))
						{
							num = (short)420347905;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)498270210;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_D3;
					case 5:
					{
						int? num4;
						num7 = num4;
						goto IL_18E;
					}
					case 6:
						num7 = new int?((int)radioStatus.GetValueOrDefault());
						goto IL_18E;
					}
					goto IL_94;
					IL_18E:
					num5 = num7;
					num6 = this.SummaryEntity.RadioStatus;
					num = (short)7143425;
					if (num != 0)
					{
					}
					num = (short)704512003;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_110:
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary apxdataProfileSummary = this.SummaryEntity;
				radioStatus = value;
				int? radioStatus2;
				if (radioStatus == null)
				{
					int? num6 = null;
					radioStatus2 = num6;
				}
				else
				{
					radioStatus2 = new int?((int)radioStatus.GetValueOrDefault());
				}
				apxdataProfileSummary.RadioStatus = radioStatus2;
				base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_RadioStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				return;
				IL_94:
				radioStatus = value;
				num = (short)330891264;
				short num8 = num;
				num = (short)124977156;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_71;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0008BF18 File Offset: 0x0008A118
		// (set) Token: 0x0600094A RID: 2378 RVA: 0x0008BFD0 File Offset: 0x0008A1D0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string TemplateName
		{
			get
			{
				short num = (short)790342938;
				short num2 = num;
				num = (short)662809882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)466485248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1020329985;
				if (num != 0)
				{
				}
				num = (short)1756758016;
				if (num != 0)
				{
				}
				return this.SummaryEntity.TemplateName;
			}
			set
			{
				short num;
				while (!(value == this.SummaryEntity.TemplateName))
				{
					num = (short)1849472247;
					short num2 = num;
					num = (short)703444215;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1778188288;
						if (num != 0)
						{
						}
						this.SummaryEntity.TemplateName = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_TemplateName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
				}
				num = (short)271122432;
				short num3 = num;
				num = (short)2091778049;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x0008C0D0 File Offset: 0x0008A2D0
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x0008C184 File Offset: 0x0008A384
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string ConfigurationName
		{
			get
			{
				short num = (short)61311165;
				short num2 = num;
				num = (short)2066122941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1194721280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)693436417;
				if (num != 0)
				{
				}
				num = (short)550109184;
				if (num != 0)
				{
				}
				return this.SummaryEntity.ConfigurationName;
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)1608581121;
					if (num != 0)
					{
					}
					if (value == this.SummaryEntity.ConfigurationName)
					{
						break;
					}
					num = (short)1241586065;
					short num2 = num;
					num = (short)400693649;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9A;
					}
				}
				num = (short)1497563136;
				short num3 = num;
				return;
				IL_9A:
				num = (short)1726152704;
				if (num != 0)
				{
				}
				this.SummaryEntity.ConfigurationName = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_ConfigurationName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x0600094D RID: 2381 RVA: 0x0008C280 File Offset: 0x0008A480
		// (set) Token: 0x0600094E RID: 2382 RVA: 0x0008C340 File Offset: 0x0008A540
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string RadioAlias
		{
			get
			{
				short num = (short)1528858900;
				short num2 = num;
				num = (short)562071828;
				switch (num2 == num)
				{
				default:
				{
					num = (short)795017216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)782630913;
				if (num != 0)
				{
				}
				num = (short)1936982016;
				if (num != 0)
				{
				}
				return this.SummaryEntity.RadioAlias ?? string.Empty;
			}
			set
			{
				short num;
				while (!(value == this.SummaryEntity.RadioAlias))
				{
					num = (short)1554934496;
					short num2 = num;
					num = (short)2040949472;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2131230720;
						if (num != 0)
						{
						}
						this.SummaryEntity.RadioAlias = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_RadioAlias())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						return;
					}
				}
				num = (short)2024996864;
				short num3 = num;
				num = (short)1205796865;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x0008C440 File Offset: 0x0008A640
		// (set) Token: 0x06000950 RID: 2384 RVA: 0x0008C518 File Offset: 0x0008A718
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? SystemType
		{
			get
			{
				int? systemType;
				short num;
				for (;;)
				{
					systemType = this.SummaryEntity.SystemType;
					if (systemType == null)
					{
						break;
					}
					num = (short)658440192;
					short num2 = num;
					num = (short)67088537;
					short num3 = num;
					num = (short)744140953;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_A7;
					}
				}
				num = (short)1313013761;
				if (num != 0)
				{
				}
				return null;
				IL_A7:
				num = (short)361693184;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType)systemType.GetValueOrDefault());
			}
			set
			{
				short num = (short)1091567616;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? astroSystemType;
					for (;;)
					{
						IL_28:
						int? num3;
						int? num6;
						int? num7;
						switch (num2)
						{
						case 0:
						{
							int? num4;
							num3 = num4;
							goto IL_1BB;
						}
						case 1:
							num3 = new int?((int)astroSystemType.GetValueOrDefault());
							goto IL_1BB;
						case 2:
							if (astroSystemType == null)
							{
								num = (short)780206084;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1543634945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_220;
						case 4:
						{
							int? num4 = null;
							goto IL_192;
						}
						case 5:
						{
							num = (short)2108534052;
							short num5 = num;
							num = (short)1858710820;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_192;
							default:
								goto IL_105;
							}
							break;
						}
						case 6:
							if (num6.GetValueOrDefault() == num7.GetValueOrDefault() & num6 != null == (num7 != null))
							{
								num = (short)75366403;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1561853957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B;
						IL_192:
						num = (short)478281728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BB:
						num6 = num3;
						num7 = this.SummaryEntity.SystemType;
						num = (short)1789919238;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_105:
					num = (short)370802688;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary apxdataProfileSummary = this.SummaryEntity;
					int? systemType;
					if (value != null)
					{
						systemType = new int?((int)value.Value);
					}
					else
					{
						int? num7 = null;
						systemType = num7;
					}
					apxdataProfileSummary.SystemType = systemType;
					base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_SystemType())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					return;
					IL_220:
					num = (short)50003969;
					if (num != 0)
					{
					}
					return;
					IL_4B:
					astroSystemType = value;
					num = (short)73465856;
					short num8 = num;
					num = (short)1228865538;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000951 RID: 2385 RVA: 0x0008C784 File Offset: 0x0008A984
		// (set) Token: 0x06000952 RID: 2386 RVA: 0x0008C838 File Offset: 0x0008AA38
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? AutoGenerateIPs
		{
			get
			{
				short num = (short)1634195999;
				short num2 = num;
				num = (short)377543199;
				switch (num2 == num)
				{
				}
				num = (short)552796160;
				short num3 = num;
				num = (short)1436483585;
				if (num != 0)
				{
				}
				num = (short)561381376;
				if (num != 0)
				{
				}
				return this.SummaryEntity.AutoGenerateIPs;
			}
			set
			{
				short num;
				for (;;)
				{
					bool? flag = value;
					bool? autoGenerateIPs = this.SummaryEntity.AutoGenerateIPs;
					if (flag.GetValueOrDefault() == autoGenerateIPs.GetValueOrDefault() & flag != null == (autoGenerateIPs != null))
					{
						num = (short)1819410433;
						if (num != 0)
						{
						}
						num = (short)1765102632;
						short num2 = num;
						num = (short)1345934376;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							goto IL_BD;
						}
						break;
					}
					goto IL_D4;
				}
				num = (short)246218752;
				short num3 = num;
				IL_BD:
				num = (short)976551936;
				if (num != 0)
				{
				}
				return;
				IL_D4:
				this.SummaryEntity.AutoGenerateIPs = value;
				base.RaisePropertyChanged<bool?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_AutoGenerateIPs())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x0008C95C File Offset: 0x0008AB5C
		// (set) Token: 0x06000954 RID: 2388 RVA: 0x0008CA20 File Offset: 0x0008AC20
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string ProfileName
		{
			get
			{
				short num = (short)1890910209;
				if (num != 0)
				{
				}
				num = (short)516828139;
				short num2 = num;
				num = (short)707341291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1404960768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1102774272;
				if (num != 0)
				{
				}
				return this.SummaryEntity.ProfileName ?? string.Empty;
			}
			set
			{
				while (value == this.SummaryEntity.ProfileName)
				{
					short num = (short)992920148;
					short num2 = num;
					num = (short)482984532;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)706215936;
						short num3 = num;
						num = (short)1392508929;
						if (num != 0)
						{
						}
						num = (short)1792344064;
						if (num != 0)
						{
						}
						return;
					}
					}
				}
				this.SummaryEntity.ProfileName = value;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_ProfileName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000955 RID: 2389 RVA: 0x0008CB24 File Offset: 0x0008AD24
		// (set) Token: 0x06000956 RID: 2390 RVA: 0x0008CC1C File Offset: 0x0008AE1C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string PeerIPForGUI
		{
			get
			{
				int a_ = 7;
				while (this.SummaryEntity.PeerIP != null)
				{
					short num = (short)721329827;
					short num2 = num;
					num = (short)266051235;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)409731072;
						short num3 = num;
						num = (short)1214840833;
						if (num != 0)
						{
						}
						num = (short)106299392;
						if (num != 0)
						{
						}
						return this.SummaryEntity.PeerIP.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("汁", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("潁", a_));
					}
					}
				}
				return string.Empty;
			}
			set
			{
				int a_ = 17;
				short num = (short)1521876995;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1400032402;
						short num3 = num;
						num = (short)1265945746;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1431764993;
							if (num != 0)
							{
							}
							num = (short)1555365888;
							if (num != 0)
							{
							}
							if (!(value == this.SummaryEntity.PeerIP))
							{
								num = (short)1261371397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						num = (short)662765568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						value = value.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("態", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("手", a_));
						num = (short)419168260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 4:
						goto IL_9D;
					case 5:
						goto IL_192;
					}
					IL_46:
					if (value != null)
					{
						num = (short)1750597634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_9D:
					num = (short)17039360;
					short num4 = num;
					num = (short)1284898817;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_192:
				this.SummaryEntity.PeerIP = (string.IsNullOrWhiteSpace(value) ? string.Empty : value);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_PeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_PeerIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000957 RID: 2391 RVA: 0x0008CE44 File Offset: 0x0008B044
		// (set) Token: 0x06000958 RID: 2392 RVA: 0x0008CF04 File Offset: 0x0008B104
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("PeerIP")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsPeerIPEditable", 0, true)]
		public string PeerIP
		{
			get
			{
				short num = (short)444006401;
				if (num != 0)
				{
				}
				num = (short)1175312018;
				short num2 = num;
				num = (short)1109776018;
				switch (num2 == num)
				{
				default:
				{
					num = (short)224657408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1767768064;
				if (num != 0)
				{
				}
				return this.SummaryEntity.PeerIP ?? string.Empty;
			}
			set
			{
				short num = (short)1555234817;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_86;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						goto IL_114;
					}
					IL_30:
					if (value == this.SummaryEntity.PeerIP)
					{
						num = (short)166133760;
						short num3 = num;
						num = (short)281411584;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1614610434;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				for (;;)
				{
					IL_86:
					num = (short)912103325;
					short num4 = num;
					num = (short)1106614173;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_BE;
					}
				}
				IL_BE:
				num = (short)1963917313;
				if (num != 0)
				{
				}
				num = (short)1125842944;
				if (num != 0)
				{
				}
				return;
				IL_114:
				this.SummaryEntity.PeerIP = (value ?? string.Empty);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_PeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_PeerIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x0008D0A8 File Offset: 0x0008B2A8
		// (set) Token: 0x0600095A RID: 2394 RVA: 0x0008D1A4 File Offset: 0x0008B3A4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string SubscriberIPForGUI
		{
			get
			{
				int a_ = 4;
				while (this.SummaryEntity.SubscriberIP != null)
				{
					short num = (short)985202689;
					if (num != 0)
					{
					}
					num = (short)1890941581;
					short num2 = num;
					num = (short)509049485;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)1445068800;
						short num3 = num;
						break;
					}
					}
					num = (short)324993024;
					if (num != 0)
					{
					}
					return this.SummaryEntity.SubscriberIP.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᄾ", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ሾ", a_));
				}
				return string.Empty;
			}
			set
			{
				int a_ = 2;
				short num = (short)152305667;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1372065832;
						short num3 = num;
						num = (short)800133160;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1131544577;
							if (num != 0)
							{
							}
							num = (short)272760832;
							if (num != 0)
							{
							}
							if (!(value == this.SummaryEntity.SubscriberIP))
							{
								num = (short)2021195781;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						num = (short)86966272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						value = value.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ြ", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ጼ", a_));
						num = (short)1189675012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 4:
						goto IL_99;
					case 5:
						goto IL_194;
					}
					IL_46:
					if (value != null)
					{
						num = (short)1562836994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_99:
					num = (short)889192448;
					short num4 = num;
					num = (short)469827585;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_194:
				this.SummaryEntity.SubscriberIP = (string.IsNullOrWhiteSpace(value) ? string.Empty : value);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_SubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_SubscriberIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x0008D3CC File Offset: 0x0008B5CC
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x0008D490 File Offset: 0x0008B690
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("SubscriberIP")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsSubscriberIPEditable", 1, true)]
		public string SubscriberIP
		{
			get
			{
				short num = (short)1488369832;
				short num2 = num;
				num = (short)504805544;
				switch (num2 == num)
				{
				}
				num = (short)1670184960;
				short num3 = num;
				num = (short)2141454337;
				if (num != 0)
				{
				}
				num = (short)599785472;
				if (num != 0)
				{
				}
				return this.SummaryEntity.SubscriberIP ?? string.Empty;
			}
			set
			{
				short num = (short)630784001;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1159790593;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_AC;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					case 2:
						goto IL_114;
					}
					IL_57:
					num = (short)1106771968;
					short num3 = num;
					if (value == this.SummaryEntity.SubscriberIP)
					{
						num = (short)1364328448;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1834549250;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				for (;;)
				{
					IL_AC:
					num = (short)1909621430;
					short num4 = num;
					num = (short)1631683254;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_E4;
					}
				}
				IL_E4:
				num = (short)593166336;
				if (num != 0)
				{
				}
				return;
				IL_114:
				this.SummaryEntity.SubscriberIP = (value ?? string.Empty);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_SubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_SubscriberIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x0008D634 File Offset: 0x0008B834
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x0008D728 File Offset: 0x0008B928
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string AirInterfaceIPForGUI
		{
			get
			{
				int a_ = 1;
				while (this.SummaryEntity.AirInterfaceIP != null)
				{
					short num = (short)2119755982;
					short num2 = num;
					num = (short)708634830;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1036976128;
						short num3 = num;
						num = (short)1753481217;
						if (num != 0)
						{
						}
						num = (short)1370554368;
						if (num != 0)
						{
						}
						return this.SummaryEntity.AirInterfaceIP.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ሻ", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᄻ", a_));
					}
					}
				}
				return string.Empty;
			}
			set
			{
				int a_ = 7;
				short num = (short)1450639363;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == this.SummaryEntity.AirInterfaceIP)
						{
							num = (short)826802181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1732968452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_165;
					case 2:
					{
						num = (short)991494144;
						short num3 = num;
						num = (short)277086209;
						if (num != 0)
						{
						}
						value = value.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("潁", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("汁", a_));
						num = (short)1260769732;
						short num4 = num;
						num = (short)8180164;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_165;
						default:
							num = (short)89587712;
							if (num != 0)
							{
							}
							num = (short)544079873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 4:
						goto IL_78;
					case 5:
						return;
					}
					IL_46:
					if (value != null)
					{
						num = (short)446365698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_16F:
					num = (short)921567232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_165:
					goto IL_16F;
				}
				IL_78:
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary apxdataProfileSummary = this.SummaryEntity;
				string airInterfaceIP;
				if ((airInterfaceIP = value) == null)
				{
					airInterfaceIP = string.Empty;
				}
				apxdataProfileSummary.AirInterfaceIP = airInterfaceIP;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_AirInterfaceIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_AirInterfaceIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x0008D95C File Offset: 0x0008BB5C
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x0008DA20 File Offset: 0x0008BC20
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsAirInterfaceIPEditable", 4, true)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("AirInterfaceIP")]
		public string AirInterfaceIP
		{
			get
			{
				short num = (short)1818530548;
				short num2 = num;
				num = (short)1019253492;
				switch (num2 == num)
				{
				}
				num = (short)512950272;
				short num3 = num;
				num = (short)1044185088;
				if (num != 0)
				{
				}
				num = (short)647102465;
				if (num != 0)
				{
				}
				return this.SummaryEntity.AirInterfaceIP ?? string.Empty;
			}
			set
			{
				short num = (short)1090387969;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_82;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						goto IL_E5;
					}
					IL_30:
					if (value == this.SummaryEntity.AirInterfaceIP)
					{
						num = (short)1284571136;
						short num3 = num;
						num = (short)31195136;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1053622274;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				for (;;)
				{
					IL_82:
					num = (short)1150794970;
					short num4 = num;
					num = (short)415022298;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_B8;
					}
				}
				IL_B8:
				num = (short)1847394304;
				if (num != 0)
				{
				}
				return;
				IL_E5:
				num = (short)1023344641;
				if (num != 0)
				{
				}
				this.SummaryEntity.AirInterfaceIP = (value ?? string.Empty);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_AirInterfaceIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_AirInterfaceIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x0008DBBC File Offset: 0x0008BDBC
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x0008DCB8 File Offset: 0x0008BEB8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string BluetoothDUNPeerIPForGUI
		{
			get
			{
				int a_ = 11;
				while (this.SummaryEntity.BluetoothDUNPeerIP != null)
				{
					short num = (short)2085630873;
					short num2 = num;
					num = (short)1260139417;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)336527360;
						short num3 = num;
						num = (short)834011137;
						if (num != 0)
						{
						}
						num = (short)951386112;
						if (num != 0)
						{
						}
						return this.SummaryEntity.BluetoothDUNPeerIP.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("桅", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("歅", a_));
					}
					}
				}
				return string.Empty;
			}
			set
			{
				int a_ = 3;
				short num = (short)238354435;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == this.SummaryEntity.BluetoothDUNPeerIP)
						{
							num = (short)193658885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1571618820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_139;
					case 2:
					{
						num = (short)735182848;
						short num3 = num;
						value = value.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ጽ", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ွ", a_));
						num = (short)182496170;
						short num4 = num;
						num = (short)1947315114;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_139;
						default:
							num = (short)417792000;
							if (num != 0)
							{
							}
							num = (short)26476545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_47;
						}
						continue;
					case 4:
						goto IL_79;
					case 5:
						goto IL_18A;
					}
					IL_47:
					if (value != null)
					{
						num = (short)403439618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_143:
					num = (short)252968960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_139:
					goto IL_143;
				}
				IL_79:
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary apxdataProfileSummary = this.SummaryEntity;
				string bluetoothDUNPeerIP;
				if ((bluetoothDUNPeerIP = value) == null)
				{
					bluetoothDUNPeerIP = string.Empty;
				}
				apxdataProfileSummary.BluetoothDUNPeerIP = bluetoothDUNPeerIP;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_BluetoothDUNPeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_BluetoothDUNPeerIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				return;
				IL_18A:
				num = (short)1975975937;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x0008DEEC File Offset: 0x0008C0EC
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x0008DFAC File Offset: 0x0008C1AC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("BluetoothDUNPeerIP")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsBluetoothDUNPeerIPEditable", 2, true)]
		public string BluetoothDUNPeerIP
		{
			get
			{
				short num = (short)1385562113;
				if (num != 0)
				{
				}
				num = (short)461643858;
				short num2 = num;
				num = (short)1002250322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)172490752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)212074496;
				if (num != 0)
				{
				}
				return this.SummaryEntity.BluetoothDUNPeerIP ?? string.Empty;
			}
			set
			{
				short num = (short)2111766529;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_87;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 2:
						goto IL_112;
					}
					IL_32:
					if (value == this.SummaryEntity.BluetoothDUNPeerIP)
					{
						num = (short)12517376;
						short num3 = num;
						num = (short)1852964864;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)2111766530;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				for (;;)
				{
					IL_87:
					num = (short)1270284289;
					if (num != 0)
					{
					}
					num = (short)655600064;
					short num4 = num;
					num = (short)1152100800;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_E4;
					}
				}
				IL_E4:
				num = (short)1032781824;
				if (num != 0)
				{
				}
				return;
				IL_112:
				this.SummaryEntity.BluetoothDUNPeerIP = (value ?? string.Empty);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_BluetoothDUNPeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_BluetoothDUNPeerIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0008E14C File Offset: 0x0008C34C
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x0008E248 File Offset: 0x0008C448
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string BluetoothDUNSubscriberIPForGUI
		{
			get
			{
				int a_ = 3;
				while (this.SummaryEntity.BluetoothDUNSubscriberIP != null)
				{
					short num = (short)335019263;
					short num2 = num;
					num = (short)1008270591;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1382678528;
						short num3 = num;
						num = (short)1000210433;
						if (num != 0)
						{
						}
						num = (short)314966016;
						if (num != 0)
						{
						}
						return this.SummaryEntity.BluetoothDUNSubscriberIP.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ွ", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ጽ", a_));
					}
					}
				}
				return string.Empty;
			}
			set
			{
				int a_ = 10;
				short num = (short)190513155;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (value == this.SummaryEntity.BluetoothDUNSubscriberIP)
						{
							num = (short)1332674565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)733151236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_160;
					case 2:
					{
						value = value.Replace(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("桄", a_), global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("歄", a_));
						num = (short)1064798459;
						short num3 = num;
						num = (short)24348923;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_160;
						default:
							num = (short)1987575808;
							if (num != 0)
							{
							}
							num = (short)1069219841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						num = (short)1324351489;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					case 4:
						goto IL_9E;
					case 5:
						goto IL_1B0;
					}
					IL_6C:
					if (value != null)
					{
						num = (short)2019229698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_16A:
					num = (short)1727070208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_160:
					goto IL_16A;
				}
				IL_9E:
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary apxdataProfileSummary = this.SummaryEntity;
				string bluetoothDUNSubscriberIP;
				if ((bluetoothDUNSubscriberIP = value) == null)
				{
					bluetoothDUNSubscriberIP = string.Empty;
				}
				apxdataProfileSummary.BluetoothDUNSubscriberIP = bluetoothDUNSubscriberIP;
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_BluetoothDUNSubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_BluetoothDUNSubscriberIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				return;
				IL_1B0:
				num = (short)1978728448;
				short num4 = num;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0008E478 File Offset: 0x0008C678
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x0008E53C File Offset: 0x0008C73C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("BluetoothDUNSubscriberIP")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsBluetoothDUNSubscriberIPEditable", 3, true)]
		public string BluetoothDUNSubscriberIP
		{
			get
			{
				short num = (short)1851992331;
				short num2 = num;
				num = (short)2122328331;
				switch (num2 == num)
				{
				}
				num = (short)983564288;
				short num3 = num;
				num = (short)1377304577;
				if (num != 0)
				{
				}
				num = (short)1319632896;
				if (num != 0)
				{
				}
				return this.SummaryEntity.BluetoothDUNSubscriberIP ?? string.Empty;
			}
			set
			{
				short num = (short)695074817;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_AA;
					case 1:
						num = (short)1646788609;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 2:
						goto IL_10F;
					}
					IL_5A:
					num = (short)1956904960;
					short num3 = num;
					if (value == this.SummaryEntity.BluetoothDUNSubscriberIP)
					{
						num = (short)271384576;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)581566466;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				for (;;)
				{
					IL_AA:
					num = (short)739159695;
					short num4 = num;
					num = (short)43167375;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_E1;
					}
				}
				IL_E1:
				num = (short)817102848;
				if (num != 0)
				{
				}
				return;
				IL_10F:
				this.SummaryEntity.BluetoothDUNSubscriberIP = (value ?? string.Empty);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_BluetoothDUNSubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile.get_BluetoothDUNSubscriberIPForGUI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0008E6DC File Offset: 0x0008C8DC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string CustomID
		{
			get
			{
				int a_ = 18;
				switch (0)
				{
				case 0:
					goto IL_29;
				}
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
				short num2;
				for (;;)
				{
					IL_13:
					int num;
					switch (num)
					{
					case 0:
						goto IL_127;
					case 1:
						if (systemType == null)
						{
							goto IL_C5;
						}
						systemType = this.SystemType;
						num2 = (short)1553137664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
					{
						num2 = (short)1740111872;
						short num3 = num2;
						num2 = (short)1027735555;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
						goto IL_14D;
					}
					goto IL_29;
				}
				IL_127:
				string str = systemType.ToString();
				goto IL_150;
				IL_14D:
				str = null;
				IL_150:
				return str + global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("恌", a_) + this.ProfileName;
				IL_29:
				systemType = this.SystemType;
				num2 = (short)915764113;
				short num4 = num2;
				num2 = (short)1457353617;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_C5:
					num2 = (short)19070978;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				default:
				{
					num2 = (short)542638081;
					if (num2 != 0)
					{
					}
					num2 = (short)1608843264;
					if (num2 != 0)
					{
					}
					num2 = (short)86048769;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				}
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0008E854 File Offset: 0x0008CA54
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x0008E908 File Offset: 0x0008CB08
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? NatEnable
		{
			get
			{
				short num = (short)1829239447;
				short num2 = num;
				num = (short)834206359;
				switch (num2 == num)
				{
				}
				num = (short)630128640;
				short num3 = num;
				num = (short)757006336;
				if (num != 0)
				{
				}
				num = (short)737804289;
				if (num != 0)
				{
				}
				return this.SummaryEntity.NatEnable;
			}
			set
			{
				short num;
				for (;;)
				{
					bool? flag = value;
					bool? natEnable = this.SummaryEntity.NatEnable;
					if (flag.GetValueOrDefault() == natEnable.GetValueOrDefault() & flag != null == (natEnable != null))
					{
						num = (short)1976107009;
						if (num != 0)
						{
						}
						num = (short)1206888098;
						short num2 = num;
						num = (short)908306082;
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
					goto IL_D2;
				}
				num = (short)1691418624;
				short num3 = num;
				IL_BA:
				num = (short)1093468160;
				if (num != 0)
				{
				}
				return;
				IL_D2:
				this.SummaryEntity.NatEnable = value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0008E9F4 File Offset: 0x0008CBF4
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x0008EACC File Offset: 0x0008CCCC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? PacketDataMode
		{
			get
			{
				int? packetDataMode;
				short num;
				for (;;)
				{
					packetDataMode = this.SummaryEntity.PacketDataMode;
					if (packetDataMode != null)
					{
						goto IL_BF;
					}
					num = (short)995544364;
					short num2 = num;
					num = (short)1762118956;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_50;
					}
				}
				IL_50:
				num = (short)568000512;
				short num3 = num;
				num = (short)1479540737;
				if (num != 0)
				{
				}
				num = (short)1979908096;
				if (num != 0)
				{
				}
				return null;
				IL_BF:
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode?((global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode)packetDataMode.GetValueOrDefault());
			}
			set
			{
				short num = (short)1053687808;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode;
					for (;;)
					{
						IL_27:
						int? num3;
						int? num6;
						int? num7;
						switch (num2)
						{
						case 0:
						{
							int? num4;
							num3 = num4;
							goto IL_1BD;
						}
						case 1:
							num3 = new int?((int)packetDataMode.GetValueOrDefault());
							goto IL_1BD;
						case 2:
							if (packetDataMode == null)
							{
								num = (short)38993924;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1169883137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							return;
						case 4:
						{
							num = (short)1910308865;
							if (num != 0)
							{
							}
							int? num4 = null;
							goto IL_195;
						}
						case 5:
						{
							num = (short)785893295;
							short num5 = num;
							num = (short)535414703;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_195;
							default:
								goto IL_12B;
							}
							break;
						}
						case 6:
							if (num6.GetValueOrDefault() == num7.GetValueOrDefault() & num6 != null == (num7 != null))
							{
								num = (short)1669267459;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)646184965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A;
						IL_195:
						num = (short)427819008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BD:
						num6 = num3;
						num7 = this.SummaryEntity.PacketDataMode;
						num = (short)517210118;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_12B:
					num = (short)994181120;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary apxdataProfileSummary = this.SummaryEntity;
					packetDataMode = value;
					int? packetDataMode2;
					if (packetDataMode == null)
					{
						int? num7 = null;
						packetDataMode2 = num7;
					}
					else
					{
						packetDataMode2 = new int?((int)packetDataMode.GetValueOrDefault());
					}
					apxdataProfileSummary.PacketDataMode = packetDataMode2;
					return;
					IL_4A:
					packetDataMode = value;
					num = (short)892534784;
					short num8 = num;
					num = (short)1719336962;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0008ED04 File Offset: 0x0008CF04
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x0008EDB8 File Offset: 0x0008CFB8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? BluetoothEnable
		{
			get
			{
				short num = (short)1003637087;
				short num2 = num;
				num = (short)2095335775;
				switch (num2 == num)
				{
				}
				num = (short)234946560;
				short num3 = num;
				num = (short)1154351105;
				if (num != 0)
				{
				}
				num = (short)98238464;
				if (num != 0)
				{
				}
				return this.SummaryEntity.BluetoothEnable;
			}
			set
			{
				short num;
				for (;;)
				{
					bool? flag = value;
					bool? bluetoothEnable = this.SummaryEntity.BluetoothEnable;
					if (!(flag.GetValueOrDefault() == bluetoothEnable.GetValueOrDefault() & flag != null == (bluetoothEnable != null)))
					{
						goto IL_D3;
					}
					num = (short)1622814017;
					short num2 = num;
					num = (short)1272720705;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6C;
					}
				}
				IL_6C:
				num = (short)1044840448;
				short num3 = num;
				num = (short)2054488065;
				if (num != 0)
				{
				}
				num = (short)938147840;
				if (num != 0)
				{
				}
				return;
				IL_D3:
				this.SummaryEntity.BluetoothEnable = value;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0008EEA4 File Offset: 0x0008D0A4
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x0008EF58 File Offset: 0x0008D158
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? LocationEnable
		{
			get
			{
				short num = (short)1493517164;
				short num2 = num;
				num = (short)408699756;
				switch (num2 == num)
				{
				}
				num = (short)1848377344;
				short num3 = num;
				num = (short)536936449;
				if (num != 0)
				{
				}
				num = (short)407764992;
				if (num != 0)
				{
				}
				return this.SummaryEntity.LocationEnable;
			}
			set
			{
				short num = (short)1415774209;
				if (num != 0)
				{
				}
				bool? flag = value;
				bool? locationEnable = this.SummaryEntity.LocationEnable;
				if (!(flag.GetValueOrDefault() == locationEnable.GetValueOrDefault() & flag != null == (locationEnable != null)))
				{
					num = (short)436197190;
					short num2 = num;
					num = (short)1503450950;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2062876672;
						if (num != 0)
						{
						}
						num = (short)15073280;
						short num3 = num;
						this.SummaryEntity.LocationEnable = value;
						return;
					}
					}
				}
			}
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0008F044 File Offset: 0x0008D244
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0008F0F8 File Offset: 0x0008D2F8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? P25LocationReporting
		{
			get
			{
				short num = (short)632721185;
				short num2 = num;
				num = (short)2029555489;
				switch (num2 == num)
				{
				}
				num = (short)1361182720;
				if (num != 0)
				{
				}
				num = (short)1676869633;
				if (num != 0)
				{
				}
				num = (short)76087296;
				short num3 = num;
				return this.SummaryEntity.P25LocationReporting;
			}
			set
			{
				bool? flag = value;
				bool? p25LocationReporting = this.SummaryEntity.P25LocationReporting;
				if (!(flag.GetValueOrDefault() == p25LocationReporting.GetValueOrDefault() & flag != null == (p25LocationReporting != null)))
				{
					short num = (short)1024983041;
					if (num != 0)
					{
					}
					num = (short)839417554;
					short num2 = num;
					num = (short)936279762;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1378287616;
						if (num != 0)
						{
						}
						num = (short)1034092544;
						short num3 = num;
						this.SummaryEntity.P25LocationReporting = value;
						return;
					}
					}
				}
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0008F1E0 File Offset: 0x0008D3E0
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x0008F294 File Offset: 0x0008D494
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string LocationServerIPAddress
		{
			get
			{
				short num = (short)216336619;
				short num2 = num;
				num = (short)1719077099;
				switch (num2 == num)
				{
				}
				num = (short)308936705;
				if (num != 0)
				{
				}
				num = (short)1513357312;
				if (num != 0)
				{
				}
				num = (short)705363968;
				short num3 = num;
				return this.SummaryEntity.LocationServerIPAddress;
			}
			set
			{
				short num = (short)1782120449;
				if (num != 0)
				{
				}
				if (!(value == this.SummaryEntity.LocationServerIPAddress))
				{
					num = (short)909652183;
					short num2 = num;
					num = (short)978464983;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2038235136;
						if (num != 0)
						{
						}
						num = (short)1920335872;
						short num3 = num;
						this.SummaryEntity.LocationServerIPAddress = value;
						return;
					}
					}
				}
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0008F364 File Offset: 0x0008D564
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x0008F41C File Offset: 0x0008D61C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string BluetoothPANNetworkBaseAddress
		{
			get
			{
				short num = (short)1177969495;
				short num2 = num;
				num = (short)1077764951;
				switch (num2 == num)
				{
				}
				num = (short)87621632;
				if (num != 0)
				{
				}
				num = (short)897187841;
				if (num != 0)
				{
				}
				num = (short)1680998400;
				short num3 = num;
				return this.SummaryEntity.BluetoothPANNetworkBaseAddress;
			}
			set
			{
				if (!(value == this.SummaryEntity.BluetoothPANNetworkBaseAddress))
				{
					short num = (short)592367894;
					short num2 = num;
					num = (short)382062870;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)332857345;
						if (num != 0)
						{
						}
						num = (short)112001024;
						if (num != 0)
						{
						}
						num = (short)75563008;
						short num3 = num;
						this.SummaryEntity.BluetoothPANNetworkBaseAddress = value;
						return;
					}
					}
				}
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0008F4E8 File Offset: 0x0008D6E8
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x0008F5A0 File Offset: 0x0008D7A0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? DirectLocationRegistration
		{
			get
			{
				short num = (short)1294084291;
				short num2 = num;
				num = (short)499787971;
				switch (num2 == num)
				{
				}
				num = (short)1754857472;
				if (num != 0)
				{
				}
				num = (short)483917825;
				if (num != 0)
				{
				}
				num = (short)1029439488;
				short num3 = num;
				return this.SummaryEntity.DirectLocationRegistration;
			}
			set
			{
				bool? flag = value;
				bool? directLocationRegistration = this.SummaryEntity.DirectLocationRegistration;
				if (!(flag.GetValueOrDefault() == directLocationRegistration.GetValueOrDefault() & flag != null == (directLocationRegistration != null)))
				{
					short num = (short)1570401620;
					short num2 = num;
					num = (short)1190751572;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)149749761;
						if (num != 0)
						{
						}
						num = (short)1887174656;
						if (num != 0)
						{
						}
						num = (short)158662656;
						short num3 = num;
						this.SummaryEntity.DirectLocationRegistration = value;
						return;
					}
					}
				}
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0008F688 File Offset: 0x0008D888
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x0008F760 File Offset: 0x0008D960
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? BluetoothDunPeerIpAssignmentType
		{
			get
			{
				int? bluetoothDunPeerIpAssignmentType = this.SummaryEntity.BluetoothDunPeerIpAssignmentType;
				short num;
				if (bluetoothDunPeerIpAssignmentType != null)
				{
					num = (short)1585185669;
					short num2 = num;
					num = (short)956433285;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)426967040;
						if (num != 0)
						{
						}
						num = (short)1710358528;
						short num3 = num;
						return new global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType?((global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType)bluetoothDunPeerIpAssignmentType.GetValueOrDefault());
					}
					}
				}
				num = (short)148176897;
				if (num != 0)
				{
				}
				return null;
			}
			set
			{
				short num = (short)2107375616;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
					for (;;)
					{
						IL_27:
						int? num4;
						int? num5;
						int? num6;
						switch (num2)
						{
						case 0:
							goto IL_21E;
						case 1:
						{
							int? num3 = null;
							num = (short)2019557381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_115;
						case 3:
							num4 = new int?((int)bluetoothDunPeerIpAssignmentType.GetValueOrDefault());
							goto IL_191;
						case 4:
							if (num5.GetValueOrDefault() == num6.GetValueOrDefault() & num5 != null == (num6 != null))
							{
								num = (short)193593344;
								short num7 = num;
								num = (short)2102329344;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)23134210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							int? num3;
							num4 = num3;
							goto IL_191;
						}
						case 6:
							if (bluetoothDunPeerIpAssignmentType == null)
							{
								num = (short)997851137;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)597688323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A;
						IL_191:
						num5 = num4;
						num6 = this.SummaryEntity.BluetoothDunPeerIpAssignmentType;
						num = (short)1506476036;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_115:
					global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary apxdataProfileSummary = this.SummaryEntity;
					bluetoothDunPeerIpAssignmentType = value;
					int? bluetoothDunPeerIpAssignmentType2;
					if (bluetoothDunPeerIpAssignmentType == null)
					{
						int? num6 = null;
						bluetoothDunPeerIpAssignmentType2 = num6;
					}
					else
					{
						bluetoothDunPeerIpAssignmentType2 = new int?((int)bluetoothDunPeerIpAssignmentType.GetValueOrDefault());
					}
					apxdataProfileSummary.BluetoothDunPeerIpAssignmentType = bluetoothDunPeerIpAssignmentType2;
					return;
					IL_21E:
					return;
					IL_4A:
					num = (short)1049703823;
					short num8 = num;
					num = (short)912536975;
					switch ((num8 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1760690177;
						if (num != 0)
						{
						}
						num = (short)1749286912;
						if (num != 0)
						{
						}
						bluetoothDunPeerIpAssignmentType = value;
						num = (short)1204748294;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_27;
					}
					break;
				}
				}
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0008F998 File Offset: 0x0008DB98
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x0008FA58 File Offset: 0x0008DC58
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string AutomaticRegistrationServerAddress
		{
			get
			{
				short num = (short)1338179585;
				if (num != 0)
				{
				}
				num = (short)669864425;
				short num2 = num;
				num = (short)572346857;
				switch (num2 == num)
				{
				}
				num = (short)801701888;
				if (num != 0)
				{
				}
				num = (short)929497088;
				short num3 = num;
				return this.SummaryEntity.AutomaticRegistrationServerAddress ?? string.Empty;
			}
			set
			{
				if (!(value == this.SummaryEntity.AutomaticRegistrationServerAddress))
				{
					short num = (short)252826211;
					short num2 = num;
					num = (short)541446755;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)170917889;
						if (num != 0)
						{
						}
						num = (short)1248526336;
						if (num != 0)
						{
						}
						num = (short)164823040;
						short num3 = num;
						this.SummaryEntity.AutomaticRegistrationServerAddress = value;
						return;
					}
					}
				}
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0008FB20 File Offset: 0x0008DD20
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x0008FBDC File Offset: 0x0008DDDC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int? ArsMode
		{
			get
			{
				short num = (short)68689771;
				short num2 = num;
				num = (short)862986091;
				switch (num2 == num)
				{
				}
				num = (short)601489409;
				if (num != 0)
				{
				}
				num = (short)348258304;
				if (num != 0)
				{
				}
				num = (short)1778909184;
				short num3 = num;
				return this.SummaryEntity.ArsMode;
			}
			set
			{
				short num = (short)452132865;
				if (num != 0)
				{
				}
				int? num2 = value;
				int? arsMode = this.SummaryEntity.ArsMode;
				if (!(num2.GetValueOrDefault() == arsMode.GetValueOrDefault() & num2 != null == (arsMode != null)))
				{
					num = (short)591640209;
					short num3 = num;
					num = (short)1298380433;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2001272832;
						if (num != 0)
						{
						}
						num = (short)2106064896;
						short num4 = num;
						this.SummaryEntity.ArsMode = value;
						return;
					}
					}
				}
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x0008FCC4 File Offset: 0x0008DEC4
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x0008FD74 File Offset: 0x0008DF74
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string SubscriberIPError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1473108821;
				short num2 = num;
				num = (short)1877990229;
				switch (num2 == num)
				{
				}
				num = (short)1887043584;
				if (num != 0)
				{
				}
				num = (short)1523908609;
				if (num != 0)
				{
				}
				num = (short)1070989312;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)177807874;
				short num2 = num;
				num = (short)1774330370;
				switch (num2 == num)
				{
				}
				num = (short)1418002433;
				if (num != 0)
				{
				}
				num = (short)1012662272;
				if (num != 0)
				{
				}
				num = (short)1578762240;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0008FE24 File Offset: 0x0008E024
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x0008FED0 File Offset: 0x0008E0D0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string PeerIPError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)558746595;
				short num2 = num;
				num = (short)1132907491;
				switch (num2 == num)
				{
				}
				num = (short)1234436096;
				if (num != 0)
				{
				}
				num = (short)876216321;
				if (num != 0)
				{
				}
				num = (short)1560412160;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1748952567;
				short num2 = num;
				num = (short)2026235383;
				switch (num2 == num)
				{
				}
				num = (short)702283777;
				if (num != 0)
				{
				}
				num = (short)1996685312;
				if (num != 0)
				{
				}
				num = (short)1289027584;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0008FF80 File Offset: 0x0008E180
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x00090034 File Offset: 0x0008E234
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string BluetoothDUNSubscriberIPError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1842404713;
				short num2 = num;
				num = (short)1328340329;
				switch (num2 == num)
				{
				}
				num = (short)791740417;
				if (num != 0)
				{
				}
				num = (short)997261312;
				if (num != 0)
				{
				}
				num = (short)1383923712;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1853573773;
				short num2 = num;
				num = (short)1401113229;
				switch (num2 == num)
				{
				}
				num = (short)308019201;
				if (num != 0)
				{
				}
				num = (short)697827328;
				if (num != 0)
				{
				}
				num = (short)1643053056;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x000900E4 File Offset: 0x0008E2E4
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x00090194 File Offset: 0x0008E394
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string BluetoothDUNPeerIPError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)781125337;
				short num2 = num;
				num = (short)1556154073;
				switch (num2 == num)
				{
				}
				num = (short)709165057;
				if (num != 0)
				{
				}
				num = (short)1106444288;
				if (num != 0)
				{
				}
				num = (short)416612352;
				short num3 = num;
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1668460581;
				short num2 = num;
				num = (short)1262333989;
				switch (num2 == num)
				{
				}
				num = (short)2106654720;
				if (num != 0)
				{
				}
				num = (short)728236033;
				if (num != 0)
				{
				}
				num = (short)1655046144;
				short num3 = num;
				this.e = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00090244 File Offset: 0x0008E444
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x000902F4 File Offset: 0x0008E4F4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string AirInterfaceIPError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)594891044;
				short num2 = num;
				num = (short)370495780;
				switch (num2 == num)
				{
				}
				num = (short)356253697;
				if (num != 0)
				{
				}
				num = (short)332070912;
				short num3 = num;
				num = (short)297598976;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)208808732;
				short num2 = num;
				num = (short)1246047004;
				switch (num2 == num)
				{
				}
				num = (short)440664064;
				if (num != 0)
				{
				}
				num = (short)1142489088;
				short num3 = num;
				num = (short)1354694657;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x000903A4 File Offset: 0x0008E5A4
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00090454 File Offset: 0x0008E654
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool IsSubscriberIPEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)537820507;
				short num2 = num;
				num = (short)2084732251;
				switch (num2 == num)
				{
				}
				num = (short)713162753;
				if (num != 0)
				{
				}
				num = (short)1760034816;
				short num3 = num;
				num = (short)421265408;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1061572291;
				short num2 = num;
				num = (short)1470451395;
				switch (num2 == num)
				{
				}
				num = (short)815398913;
				if (num != 0)
				{
				}
				num = (short)714604544;
				short num3 = num;
				num = (short)874971136;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x00090508 File Offset: 0x0008E708
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x000905B8 File Offset: 0x0008E7B8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool IsPeerIPEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1426236427;
				short num2 = num;
				num = (short)1971692555;
				switch (num2 == num)
				{
				}
				num = (short)903151617;
				if (num != 0)
				{
				}
				num = (short)1939210240;
				short num3 = num;
				num = (short)1593835520;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)326116847;
				short num2 = num;
				num = (short)1170548207;
				switch (num2 == num)
				{
				}
				num = (short)843186177;
				if (num != 0)
				{
				}
				num = (short)1235746816;
				short num3 = num;
				num = (short)1989935104;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0009066C File Offset: 0x0008E86C
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x0009071C File Offset: 0x0008E91C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool IsBluetoothDUNPeerIPEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1213794662;
				short num2 = num;
				num = (short)841025894;
				switch (num2 == num)
				{
				}
				num = (short)962134017;
				if (num != 0)
				{
				}
				num = (short)605945856;
				short num3 = num;
				num = (short)94175232;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1625411565;
				short num2 = num;
				num = (short)1078710253;
				switch (num2 == num)
				{
				}
				num = (short)253886465;
				if (num != 0)
				{
				}
				num = (short)1361969152;
				short num3 = num;
				num = (short)1996750848;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x000907CC File Offset: 0x0008E9CC
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x0009087C File Offset: 0x0008EA7C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool IsBluetoothDUNSubscriberIPEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)809906478;
				short num2 = num;
				num = (short)559624494;
				switch (num2 == num)
				{
				}
				num = (short)425394176;
				if (num != 0)
				{
				}
				num = (short)832897024;
				short num3 = num;
				num = (short)319553537;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)899539686;
				short num2 = num;
				num = (short)990569190;
				switch (num2 == num)
				{
				}
				num = (short)248315905;
				if (num != 0)
				{
				}
				num = (short)1924726784;
				short num3 = num;
				num = (short)218759168;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0009092C File Offset: 0x0008EB2C
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x000909DC File Offset: 0x0008EBDC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool IsAirInterfaceIPEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)94008636;
				short num2 = num;
				num = (short)540505404;
				switch (num2 == num)
				{
				}
				num = (short)732299265;
				if (num != 0)
				{
				}
				num = (short)457244672;
				short num3 = num;
				num = (short)59047936;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)296550401;
				if (num != 0)
				{
				}
				num = (short)1663150960;
				short num2 = num;
				num = (short)1640278896;
				switch (num2 == num)
				{
				}
				num = (short)1779105792;
				short num3 = num;
				num = (short)302317568;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00090A8C File Offset: 0x0008EC8C
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00090B44 File Offset: 0x0008ED44
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public byte[] DataProfileTimestamp
		{
			get
			{
				short num = (short)1621907885;
				short num2 = num;
				num = (short)1481267629;
				switch (num2 == num)
				{
				}
				num = (short)183697408;
				if (num != 0)
				{
				}
				num = (short)595525632;
				short num3 = num;
				num = (short)1904738305;
				if (num != 0)
				{
				}
				return this.SummaryEntity.Timestamp;
			}
			set
			{
				short num = (short)2037448705;
				if (num != 0)
				{
				}
				num = (short)1307136753;
				short num2 = num;
				num = (short)1780568817;
				switch (num2 == num)
				{
				}
				num = (short)214958080;
				short num3 = num;
				num = (short)1347092480;
				if (num != 0)
				{
				}
				this.SummaryEntity.Timestamp = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00090BFC File Offset: 0x0008EDFC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary SummaryEntityPublic
		{
			get
			{
				short num = (short)977308168;
				short num2 = num;
				num = (short)908691976;
				switch (num2 == num)
				{
				}
				num = (short)1960247297;
				if (num != 0)
				{
				}
				num = (short)1453391872;
				short num3 = num;
				num = (short)309723136;
				if (num != 0)
				{
				}
				return this.SummaryEntity;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x00090CAC File Offset: 0x0008EEAC
		private global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary SummaryEntity
		{
			get
			{
				short num = (short)1838124034;
				short num2 = num;
				num = (short)974687234;
				switch (num2 == num)
				{
				}
				num = (short)698023936;
				if (num != 0)
				{
				}
				num = (short)605028352;
				short num3 = num;
				num = (short)626851841;
				if (num != 0)
				{
				}
				return base.Entity;
			}
		}

		// Token: 0x1700048A RID: 1162
		public override string this[string propertyName]
		{
			get
			{
				int a_ = 7;
				switch (0)
				{
				case 0:
					goto IL_131;
				}
				int num;
				short num2;
				uint num3;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						goto IL_63A;
					case 1:
						goto IL_3D7;
					case 2:
						num2 = (short)920125490;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num2 = (short)291438610;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (num3 <= 1834575210U)
						{
							num2 = (short)1493041157;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)335282233;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						num2 = (short)1894318094;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						num2 = (short)492240961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						if (num3 != 80834809U)
						{
							num2 = (short)1504444419;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)866910253;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						num2 = (short)1945370690;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						goto IL_69A;
					case 10:
						num2 = (short)88539143;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("A⡃㍅ⵇ㹉⍋⅍⑏㩑ၓ͕ᙗख़⥛㱝፟šᙣཥ੧ཀྵṫ❭⁯", a_)))
						{
							num2 = (short)1214578701;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_63F;
					case 12:
						num2 = (short)1216544790;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 13:
						num2 = (short)594673681;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 14:
						if (num3 != 1464523644U)
						{
							num2 = (short)1372127248;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1094713395;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 15:
						if (!base.Validate(this.BluetoothDUNSubscriberIPError))
						{
							num2 = (short)1353842714;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_316;
					case 16:
						num2 = (short)292356137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 17:
						goto IL_70F;
					case 18:
						if (num3 != 633542544U)
						{
							num2 = (short)1025704000;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1046413344;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 19:
						num2 = (short)1767637001;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 20:
						goto IL_808;
					case 21:
						goto IL_A37;
					case 22:
						goto IL_A51;
					case 23:
						num2 = (short)292290607;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 24:
						goto IL_2D2;
					case 25:
						if (!base.Validate(this.BluetoothDUNPeerIPError))
						{
							num2 = (short)966787126;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_223;
					case 26:
						goto IL_67E;
					case 27:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ቁ⅃⍅㩇͉᱋ࡍ㽏⁑ፓ͕ᅗ", a_)))
						{
							num2 = (short)290979873;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_41D;
					case 28:
						if (!base.Validate(this.AirInterfaceIPError))
						{
							num2 = (short)69992469;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_7EB;
					case 29:
						if (!base.Validate(this.SubscriberIPError))
						{
							num2 = (short)1955528734;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_A64;
					case 30:
						goto IL_8F9;
					case 31:
						num2 = (short)329121861;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 32:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ቁ⅃⍅㩇͉᱋", a_)))
						{
							num2 = (short)449118243;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_41D;
					case 33:
						num2 = (short)540475416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 34:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("A⡃㍅ⵇ㹉⍋⅍⑏㩑ၓ͕ᙗਖ਼㥛㭝቟⭡㑣", a_)))
						{
							num2 = (short)503185471;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_464;
					case 35:
						num2 = (short)541589542;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 36:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("́ⵃ㑅Ň⑉㡋⭍≏㑑㕓㕕㵗ፙ౛", a_)))
						{
							num2 = (short)590151711;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_9F7;
					case 37:
						if (num3 != 1157191835U)
						{
							num2 = (short)1089667112;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)964362251;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 38:
						goto IL_ADC;
					case 39:
						goto IL_33B;
					case 40:
						num2 = (short)2049900597;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 41:
						if (num3 != 1834575210U)
						{
							num2 = (short)895680555;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)977141818;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 42:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("A⡃㍅ⵇ㹉⍋⅍⑏㩑ၓ͕ᙗਖ਼㥛㭝቟⭡㑣⁥ݧᡩ⭫㭭㥯", a_)))
						{
							num2 = (short)1381564484;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_464;
					case 43:
						num2 = (short)763232256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 44:
						num2 = (short)1641611265;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 45:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("A⡃㍅ⵇ㹉⍋⅍⑏㩑ၓ͕ᙗख़⥛㱝፟šᙣཥ੧ཀྵṫ❭⁯㑱᭳ѵ㽷⽹㕻", a_)))
						{
							num2 = (short)1906573324;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_63F;
					case 46:
						num2 = (short)1915879484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 47:
						if (num3 != 3526026794U)
						{
							num2 = (short)6225939;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)931790875;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 48:
						goto IL_45F;
					case 49:
						num2 = (short)882114597;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 50:
						goto IL_6F2;
					case 51:
					{
						if (propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅁㅃ⑅㭇⥉㹋❍㉏㝑♓ὕࡗ᱙㍛ⱝ❟㝡ⵣ", a_))
						{
							goto IL_8B9;
						}
						num2 = (short)1621872705;
						short num4 = num2;
						num2 = (short)627036225;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2AF;
						default:
							num2 = (short)929103872;
							if (num2 != 0)
							{
							}
							num2 = (short)377225222;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 52:
						goto IL_9A7;
					case 53:
						if (num3 != 1216208513U)
						{
							num2 = (short)1774387244;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)2131689506;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 54:
						goto IL_4A3;
					case 55:
						if (!base.Validate(this.PeerIPError))
						{
							num2 = (short)2087387184;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_80D;
					case 56:
						goto IL_191;
					case 57:
						if (num3 != 2255350071U)
						{
							num2 = (short)1981743150;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)119865380;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 58:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅁㅃ⑅㭇⥉㹋❍㉏㝑♓ὕࡗ", a_)))
						{
							num2 = (short)595001405;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8B9;
					case 59:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("́ⵃ㑅Ň⑉㡋⭍≏㑑㕓㕕㵗ፙ౛ᡝཟၡ⍣㍥Ⅷ", a_)))
						{
							num2 = (short)333905922;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_9F7;
					case 60:
						if (num3 != 2672840055U)
						{
							num2 = (short)1897988119;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)91553834;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 61:
						goto IL_2AF;
					case 62:
						if (num3 != 736304373U)
						{
							num2 = (short)629997617;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)680198203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 63:
						num2 = (short)236650516;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 64:
						num2 = (short)23986228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 65:
						goto IL_A82;
					case 66:
					{
						if (num3 <= 633542544U)
						{
							num2 = (short)18350090;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1274937344;
						short num5 = num2;
						num2 = (short)1932591166;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 67:
						if (num3 <= 1216208513U)
						{
							num2 = (short)507772936;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)99090436;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 68:
						num2 = (short)1155203111;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 69:
						goto IL_50C;
					}
					goto IL_131;
					IL_2AF:
					num2 = (short)1788674104;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_41D:
					num2 = (short)1751515191;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_464:
					num2 = (short)599785497;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_63F:
					num2 = (short)1873870863;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_8B9:
					num2 = (short)240844829;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_9F7:
					num2 = (short)916455452;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_191:
				goto IL_B2A;
				IL_223:
				return string.Empty;
				IL_2D2:
				goto IL_B2A;
				IL_316:
				return string.Empty;
				IL_33B:
				IL_3D7:
				goto IL_B2A;
				IL_45F:
				return base.Error;
				IL_4A3:
				return base.Error;
				IL_50C:
				num2 = (short)1332412417;
				if (num2 != 0)
				{
				}
				IL_63A:
				goto IL_B2A;
				IL_67E:
				return base.Error;
				IL_69A:
				IL_6F2:
				IL_70F:
				goto IL_B2A;
				IL_7EB:
				return string.Empty;
				IL_808:
				goto IL_B2A;
				IL_80D:
				return string.Empty;
				IL_8F9:
				return base.Error;
				IL_9A7:
				goto IL_B2A;
				IL_A37:
				return base.Error;
				IL_A51:
				goto IL_B2A;
				IL_A64:
				return string.Empty;
				IL_A82:
				IL_ADC:
				IL_B2A:
				return string.Empty;
				IL_131:
				num3 = global::<PrivateImplementationDetails>.ComputeStringHash(propertyName);
				num2 = (short)1095237699;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00091898 File Offset: 0x0008FA98
		[global::System.Obsolete]
		public void RefreshUI()
		{
			int a_ = 7;
			short num = (short)835574420;
			short num2 = num;
			num = (short)947116692;
			switch (num2 == num)
			{
			}
			num = (short)860553216;
			short num3 = num;
			num = (short)1116405761;
			if (num != 0)
			{
			}
			num = (short)2103377920;
			if (num != 0)
			{
			}
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("၁╃≅ⅇ╉Ὃ㩍ㅏ♑⅓╕", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᙁ⅃⭅㡇♉ⵋ㩍㕏᱑㕓㭕㵗", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("၁╃≅ⅇ╉ോ≍㥏㍑❓", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ୁ㝃х⑇㽉⥋㩍㽏㵑⁓㹕ṗ㍙㥛㉝џᅡⅣɥŧṩ൫౭ᱯ᝱", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅁㅃ⑅㭇⥉㹋❍㉏㝑♓ὕࡗ", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᅁㅃ⑅㭇⥉㹋❍㉏㝑♓ὕࡗ᱙㍛ⱝ❟㝡ⵣ", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ቁ⅃⍅㩇͉᱋", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ቁ⅃⍅㩇͉᱋ࡍ㽏⁑ፓ͕ᅗ", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("A⡃㍅ⵇ㹉⍋⅍⑏㩑ၓ͕ᙗਖ਼㥛㭝቟⭡㑣", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("A⡃㍅ⵇ㹉⍋⅍⑏㩑ၓ͕ᙗਖ਼㥛㭝቟⭡㑣⁥ݧᡩ⭫㭭㥯", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("A⡃㍅ⵇ㹉⍋⅍⑏㩑ၓ͕ᙗख़⥛㱝፟šᙣཥ੧ཀྵṫ❭⁯", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("A⡃㍅ⵇ㹉⍋⅍⑏㩑ၓ͕ᙗख़⥛㱝፟šᙣཥ੧ཀྵṫ❭⁯㑱᭳ѵ㽷⽹㕻", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("́ⵃ㑅Ň⑉㡋⭍≏㑑㕓㕕㵗ፙ౛", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("́ⵃ㑅Ň⑉㡋⭍≏㑑㕓㕕㵗ፙ౛ᡝཟၡ⍣㍥Ⅷ", a_));
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00091A64 File Offset: 0x0008FC64
		public override bool Equals(object obj)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)8845198;
					short num3 = num2;
					num2 = (short)482342798;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_54;
					default:
						goto IL_B4;
					}
					break;
				}
				case 1:
					goto IL_54;
				case 2:
					if (obj is global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)
					{
						num2 = (short)1103953921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_1C;
				IL_54:
				result = ((obj as global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile).AstroDataProfileID == this.AstroDataProfileID);
				num2 = (short)1750990848;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_B4:
			num2 = (short)1752891393;
			if (num2 != 0)
			{
			}
			num2 = (short)1070071808;
			short num4 = num2;
			num2 = (short)480903168;
			if (num2 != 0)
			{
			}
			return result;
			IL_1C:
			result = false;
			num2 = (short)1838546946;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00091B90 File Offset: 0x0008FD90
		public override int GetHashCode()
		{
			short num = (short)1296579692;
			short num2 = num;
			num = (short)1815493740;
			switch (num2 == num)
			{
			}
			num = (short)834404352;
			short num3 = num;
			num = (short)1588527105;
			if (num != 0)
			{
			}
			num = (short)1345323008;
			if (num != 0)
			{
			}
			return base.GetHashCode();
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00091C40 File Offset: 0x0008FE40
		public override void CleanErrors()
		{
			short num = (short)272169337;
			short num2 = num;
			num = (short)1926691193;
			switch (num2 == num)
			{
			}
			num = (short)1836384256;
			short num3 = num;
			num = (short)2089091073;
			if (num != 0)
			{
			}
			num = (short)1054539776;
			if (num != 0)
			{
			}
			base.CleanErrors();
			this.SubscriberIPError = string.Empty;
			this.PeerIPError = string.Empty;
			this.BluetoothDUNSubscriberIPError = string.Empty;
			this.BluetoothDUNPeerIPError = string.Empty;
			this.AirInterfaceIPError = string.Empty;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00091D28 File Offset: 0x0008FF28
		public override bool IsValidRecord()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (base.Validate(this.BluetoothDUNPeerIPError))
					{
						num2 = (short)1641480192;
						short num3 = num2;
						num2 = (short)369426437;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_173;
				case 1:
					num2 = (short)436862984;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_14A;
				case 3:
					if (flag)
					{
						num2 = (short)66781188;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_173;
				case 4:
					num2 = (short)49283074;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)332922891;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_18B;
				case 7:
					num2 = (short)1625751562;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (base.Validate(this.BluetoothDUNSubscriberIPError))
					{
						num2 = (short)2011758601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_173;
				case 9:
					num2 = (short)1921515520;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (base.Validate(this.PeerIPError))
					{
						num2 = (short)881655809;
						if (num2 != 0)
						{
						}
						num2 = (short)886964225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_173;
				case 11:
					goto IL_E0;
				}
				goto IL_40;
			}
			IL_E0:
			return base.Validate(this.AirInterfaceIPError);
			IL_18B:
			return false;
			IL_40:
			flag = base.IsValidRecord();
			num2 = (short)200889196;
			short num4 = num2;
			num2 = (short)1698976620;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14A:
				if (base.Validate(this.SubscriberIPError))
				{
					num2 = (short)338952199;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
				num2 = (short)1730740224;
				if (num2 != 0)
				{
				}
				num2 = (short)1550647299;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_173:
			num2 = (short)1099628550;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00091FA0 File Offset: 0x000901A0
		public override global::System.Collections.Generic.Dictionary<string, string> InvalidFieldErrorInfo()
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			short num2;
			global::System.Collections.Generic.Dictionary<string, string> dictionary;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!base.Validate(this.BluetoothDUNSubscriberIPError))
					{
						num2 = (short)406913029;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21C;
				case 1:
				{
					num2 = (short)1980225314;
					short num3 = num2;
					num2 = (short)1974982434;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9B;
					default:
						num2 = (short)1509752832;
						if (num2 != 0)
						{
						}
						if (!base.Validate(this.BluetoothDUNSubscriberIPError))
						{
							num2 = (short)1489240073;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_179;
					}
					break;
				}
				case 2:
					goto IL_9B;
				case 3:
					goto IL_2E0;
				case 4:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("੊⑌㵎ᡐ㵒⅔㉖⭘㵚㱜㱞Ѡ⩢㕤", a_), base.Error);
					num2 = (short)2018377741;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ॊ⅌㩎㑐❒㩔㡖ⵘ㍚ᥜਫ਼⽠ぢၤզᩨࡪὬٮ፰ᙲݴ㹶⥸", a_), base.Error);
					num2 = (short)875626510;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (!base.Validate(this.SubscriberIPError))
					{
						num2 = (short)48103426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_135;
				case 7:
					goto IL_179;
				case 8:
					if (!base.Validate(this.PeerIPError))
					{
						num2 = (short)904658955;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E0;
				case 9:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ॊ⅌㩎㑐❒㩔㡖ⵘ㍚ᥜਫ਼⽠㍢dɦ᭨≪㵬⩮ͰŲᩴն", a_), base.Error);
					num2 = (short)917700615;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_135;
				case 11:
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᭊ⡌⩎⍐ᩒՔ", a_), base.Error);
					num2 = (short)74383363;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (!base.Validate(this.AirInterfaceIPError))
					{
						num2 = (short)1065746436;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return dictionary;
				case 13:
					return dictionary;
				case 14:
				{
					num2 = (short)1834614784;
					short num4 = num2;
					goto IL_21C;
				}
				}
				goto IL_55;
				IL_135:
				num2 = (short)940113928;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_179:
				num2 = (short)1052901388;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_9B:
				num2 = (short)1406926849;
				if (num2 != 0)
				{
				}
				dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᡊ㡌ⵎ≐げ❔㹖㭘㹚⽜ᙞㅠ", a_), base.Error);
				num2 = (short)897318922;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_21C:
				num2 = (short)228917249;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2E0:
				num2 = (short)87293952;
				num = (int)((global::System.IntPtr)num2);
			}
			return dictionary;
			IL_55:
			dictionary = base.InvalidFieldErrorInfo();
			num2 = (short)1656815622;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0400037D RID: 893
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x0400037E RID: 894
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x0400037F RID: 895
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x04000380 RID: 896
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;

		// Token: 0x04000381 RID: 897
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;

		// Token: 0x04000382 RID: 898
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;

		// Token: 0x04000383 RID: 899
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool g;

		// Token: 0x04000384 RID: 900
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool h;

		// Token: 0x04000385 RID: 901
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool i;

		// Token: 0x04000386 RID: 902
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool j;

		// Token: 0x04000387 RID: 903
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;
	}
}
