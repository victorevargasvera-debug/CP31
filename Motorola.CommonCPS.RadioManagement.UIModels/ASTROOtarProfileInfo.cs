using System;
using System.Globalization;
using System.Linq.Expressions;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000006 RID: 6
	public class ASTROOtarProfileInfo : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO>
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00004708 File Offset: 0x00002908
		private global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO SummaryEntity
		{
			get
			{
				short num = (short)1607310703;
				short num2 = num;
				num = (short)1185586543;
				switch (num2 == num)
				{
				}
				num = (short)1081802753;
				if (num != 0)
				{
				}
				num = (short)165871616;
				if (num != 0)
				{
				}
				num = (short)237371392;
				short num3 = num;
				return base.Entity;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000047BC File Offset: 0x000029BC
		public ASTROOtarProfileInfo() : base(new global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO())
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000047E4 File Offset: 0x000029E4
		public ASTROOtarProfileInfo(global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO summary) : base(summary ?? new global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO())
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00004818 File Offset: 0x00002A18
		public global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO APXOtarProfileInfoDTO
		{
			get
			{
				short num = (short)1911910644;
				short num2 = num;
				num = (short)2065985780;
				switch (num2 == num)
				{
				}
				num = (short)1370947585;
				if (num != 0)
				{
				}
				num = (short)1540423680;
				if (num != 0)
				{
				}
				num = (short)1581187072;
				short num3 = num;
				return this.SummaryEntity;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000048CC File Offset: 0x00002ACC
		// (set) Token: 0x06000030 RID: 48 RVA: 0x0000497C File Offset: 0x00002B7C
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1191270416;
				short num2 = num;
				num = (short)651778064;
				switch (num2 == num)
				{
				}
				num = (short)567934977;
				if (num != 0)
				{
				}
				num = (short)209780736;
				if (num != 0)
				{
				}
				num = (short)237895680;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)329196908;
				short num2 = num;
				num = (short)336340332;
				switch (num2 == num)
				{
				}
				num = (short)530251777;
				if (num != 0)
				{
				}
				num = (short)1956184064;
				if (num != 0)
				{
				}
				num = (short)1558773760;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00004A2C File Offset: 0x00002C2C
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00004AE0 File Offset: 0x00002CE0
		public int RadioCount
		{
			get
			{
				short num = (short)700382627;
				short num2 = num;
				num = (short)158006691;
				switch (num2 == num)
				{
				}
				num = (short)943980544;
				if (num != 0)
				{
				}
				num = (short)737935361;
				if (num != 0)
				{
				}
				num = (short)1485438976;
				short num3 = num;
				return this.SummaryEntity.ReferenceCount;
			}
			set
			{
				short num = (short)321126401;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_121;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
					{
						this.SummaryEntity.ReferenceCount = value;
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo.get_RadioCount())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1571028993;
						if (num != 0)
						{
						}
						num = (short)2002892382;
						short num3 = num;
						num = (short)342472286;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_121;
						default:
							num = (short)576454656;
							if (num != 0)
							{
							}
							num = (short)297271296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_31:
					if (value == this.SummaryEntity.ReferenceCount)
					{
						break;
					}
					num = (short)1348665346;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_121:
				num = (short)474939392;
				short num4 = num;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00004C3C File Offset: 0x00002E3C
		public string SerialNumber
		{
			get
			{
				short num = (short)1885788930;
				short num2 = num;
				num = (short)336059138;
				switch (num2 == num)
				{
				}
				num = (short)1436352513;
				if (num != 0)
				{
				}
				num = (short)786432;
				if (num != 0)
				{
				}
				num = (short)1645740032;
				short num3 = num;
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Views_OtarProfile_PseudoSerialNumber, this.RadioCount);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004D00 File Offset: 0x00002F00
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public string OtarProfileName
		{
			get
			{
				short num = (short)1331453604;
				short num2 = num;
				num = (short)23748260;
				switch (num2 == num)
				{
				}
				num = (short)162988033;
				if (num != 0)
				{
				}
				num = (short)1764425728;
				if (num != 0)
				{
				}
				num = (short)200867840;
				short num3 = num;
				return this.SummaryEntity.OtarProfileName;
			}
			set
			{
				short num = (short)1781530625;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_127;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 2:
					{
						this.SummaryEntity.OtarProfileName = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo.get_OtarProfileName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)726138881;
						if (num != 0)
						{
						}
						num = (short)1481057444;
						short num3 = num;
						num = (short)639706276;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_127;
						default:
							num = (short)2091319296;
							if (num != 0)
							{
							}
							num = (short)1526005760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_32:
					if (!(value != this.SummaryEntity.OtarProfileName))
					{
						break;
					}
					num = (short)1754005506;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_127:
				num = (short)1203634176;
				short num4 = num;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00004F14 File Offset: 0x00003114
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00004FD4 File Offset: 0x000031D4
		public bool IndependentList
		{
			get
			{
				short num = (short)1205041983;
				short num2 = num;
				num = (short)878541631;
				switch (num2 == num)
				{
				}
				num = (short)1901068289;
				if (num != 0)
				{
				}
				num = (short)1200750592;
				if (num != 0)
				{
				}
				num = (short)1993342976;
				short num3 = num;
				return this.SummaryEntity.IndependentList.Value;
			}
			set
			{
				short num = (short)1867907073;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_112;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
					{
						this.SummaryEntity.IndependentList = new bool?(value);
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo.get_IndependentList())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1437858408;
						short num3 = num;
						num = (short)1196292712;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_112;
						default:
							num = (short)198246400;
							if (num != 0)
							{
							}
							num = (short)765591552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_31:
					bool? independentList = this.SummaryEntity.IndependentList;
					if (value == independentList.GetValueOrDefault() & independentList != null)
					{
						goto IL_13C;
					}
					num = (short)1602355202;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_112:
				num = (short)230227969;
				if (num != 0)
				{
				}
				IL_13C:
				num = (short)1510473728;
				short num4 = num;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00005148 File Offset: 0x00003348
		public string OtarID
		{
			get
			{
				int a_ = 5;
				short num = (short)2076269923;
				short num2 = num;
				num = (short)527785315;
				switch (num2 == num)
				{
				}
				num = (short)734789633;
				if (num != 0)
				{
				}
				num = (short)730857472;
				if (num != 0)
				{
				}
				num = (short)656343040;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渿汁橃", a_);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00005208 File Offset: 0x00003408
		public string ConfigurationName
		{
			get
			{
				int a_ = 9;
				short num = (short)1235599448;
				short num2 = num;
				num = (short)1493352536;
				switch (num2 == num)
				{
				}
				num = (short)217776128;
				if (num != 0)
				{
				}
				num = (short)134414337;
				if (num != 0)
				{
				}
				num = (short)1945239552;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("橃桅晇", a_);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000052C8 File Offset: 0x000034C8
		public string TemplateName
		{
			get
			{
				int a_ = 17;
				short num = (short)333405429;
				short num2 = num;
				num = (short)906910965;
				switch (num2 == num)
				{
				}
				num = (short)770703361;
				if (num != 0)
				{
				}
				num = (short)905248768;
				if (num != 0)
				{
				}
				num = (short)1994915840;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("手恍繏", a_);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00005388 File Offset: 0x00003588
		public string RadioAlias
		{
			get
			{
				int a_ = 6;
				short num = (short)1639645185;
				if (num != 0)
				{
				}
				num = (short)1198649781;
				short num2 = num;
				num = (short)669708725;
				switch (num2 == num)
				{
				}
				num = (short)328007680;
				if (num != 0)
				{
				}
				num = (short)149684224;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("潀浂歄", a_);
			}
		}

		// Token: 0x04000006 RID: 6
		private global::System.Guid? a = new global::System.Guid?(global::System.Guid.NewGuid());
	}
}
