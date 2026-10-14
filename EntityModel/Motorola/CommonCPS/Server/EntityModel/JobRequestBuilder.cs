using System;
using System.Globalization;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000EF RID: 239
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.JobRequest))]
	[global::System.Serializable]
	public class JobRequestBuilder : global::Motorola.CommonCPS.Server.EntityModel.JobRequest, global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder
	{
		// Token: 0x06000E7B RID: 3707 RVA: 0x00099B4C File Offset: 0x00097D4C
		private JobRequestBuilder(string A_0, global::Motorola.CommonCPS.Server.EntityModel.Radio A_1, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType A_2, global::Motorola.CommonCPS.Server.CommonDBConstants.ConnectionMethod A_3, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption A_4) : base(A_0, A_1, A_2, A_3, A_4)
		{
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00099B68 File Offset: 0x00097D68
		private JobRequestBuilder(string A_0, int A_1, global::Motorola.CommonCPS.Server.EntityModel.Radio A_2, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType A_3, global::Motorola.CommonCPS.Server.CommonDBConstants.ConnectionMethod A_4, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption A_5) : base(A_0, A_1, A_2, A_3, A_4, A_5)
		{
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00099B84 File Offset: 0x00097D84
		private JobRequestBuilder(string A_0, global::Motorola.CommonCPS.Server.EntityModel.MigrationRadioTemplateInfo A_1, global::Motorola.CommonCPS.Server.CommonDBConstants.ConnectionMethod A_2) : base(A_0, A_1, A_2)
		{
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00099B9C File Offset: 0x00097D9C
		public static global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder CreateBuilder(string name, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, global::Motorola.CommonCPS.Server.CommonDBConstants.ConnectionMethod connection, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption options)
		{
			short num = (short)285302084;
			short num2 = num;
			num = (short)1439128900;
			switch (num2 == num)
			{
			}
			num = (short)696385536;
			if (num != 0)
			{
			}
			num = (short)860487681;
			if (num != 0)
			{
			}
			num = (short)1901264896;
			short num3 = num;
			return new global::Motorola.CommonCPS.Server.EntityModel.JobRequestBuilder(name, radio, type, connection, options);
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00099C54 File Offset: 0x00097E54
		public static global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder CreateBuilder(string name, int defermentNumber, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, global::Motorola.CommonCPS.Server.CommonDBConstants.ConnectionMethod connection, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption options)
		{
			short num = (short)905392575;
			short num2 = num;
			num = (short)166998463;
			switch (num2 == num)
			{
			}
			num = (short)1082916864;
			if (num != 0)
			{
			}
			num = (short)906231809;
			if (num != 0)
			{
			}
			num = (short)2070085632;
			short num3 = num;
			return new global::Motorola.CommonCPS.Server.EntityModel.JobRequestBuilder(name, defermentNumber, radio, type, connection, options);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00099D0C File Offset: 0x00097F0C
		public static global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder CreateBuilder(string name, global::Motorola.CommonCPS.Server.EntityModel.MigrationRadioTemplateInfo radioInfo, global::Motorola.CommonCPS.Server.CommonDBConstants.ConnectionMethod connection)
		{
			short num = (short)279556959;
			short num2 = num;
			num = (short)709800799;
			switch (num2 == num)
			{
			}
			num = (short)1790574592;
			if (num != 0)
			{
			}
			num = (short)443285505;
			if (num != 0)
			{
			}
			num = (short)726138880;
			short num3 = num;
			return new global::Motorola.CommonCPS.Server.EntityModel.JobRequestBuilder(name, radioInfo, connection);
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00099DC0 File Offset: 0x00097FC0
		public global::Motorola.CommonCPS.Server.EntityModel.JobRequest Build()
		{
			short num = (short)419148077;
			short num2 = num;
			num = (short)11055405;
			switch (num2 == num)
			{
			}
			num = (short)1064894465;
			if (num != 0)
			{
			}
			num = (short)282198016;
			if (num != 0)
			{
			}
			num = (short)41811968;
			short num3 = num;
			return this;
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00099E6C File Offset: 0x0009806C
		public global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetScheduleDate(global::System.DateTime? startDate, global::System.DateTime? endDate)
		{
			short num = (short)1304453427;
			short num2 = num;
			num = (short)1714381107;
			switch (num2 == num)
			{
			}
			num = (short)530317313;
			if (num != 0)
			{
			}
			num = (short)843644928;
			if (num != 0)
			{
			}
			num = (short)1821835264;
			short num3 = num;
			base.ScheduleStartDate = startDate;
			base.ScheduleEndDate = endDate;
			return this;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00099F24 File Offset: 0x00098124
		public global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetMigrationJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration = null)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Guid? guid;
				switch (num)
				{
				case 0:
					guid = radio.CurrentCodeplug.FileUuid;
					base.OldPBAFileUuid = guid.Value;
					num2 = (short)1866268679;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					base.ConvertionConfigurationUuid = configuration.Uuid;
					num2 = (short)1213267973;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1265238024;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)247821042;
					short num3 = num2;
					num2 = (short)1316123378;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_153;
					default:
						num2 = (short)1691418624;
						if (num2 != 0)
						{
						}
						guid = radio.CurrentCodeplug.FileUuid;
						num2 = (short)1062338566;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_230;
				case 5:
					goto IL_230;
				case 6:
				{
					num2 = (short)1126957056;
					short num4 = num2;
					num2 = (short)563347457;
					if (num2 != 0)
					{
					}
					if (guid.Value != global::System.Guid.Empty)
					{
						goto IL_153;
					}
					return this;
				}
				case 7:
					return this;
				case 8:
					if (configuration != null)
					{
						num2 = (short)624164865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					guid = radio.CurrentCodeplug.ConfigurationUuid;
					base.ConvertionConfigurationUuid = guid.Value;
					num2 = (short)341835780;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (guid != null)
					{
						num2 = (short)2029060099;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return this;
				case 10:
					if (radio.CurrentCodeplug != null)
					{
						num2 = (short)1578500098;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return this;
				}
				goto IL_3C;
				IL_153:
				num2 = (short)916848640;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_230:
				guid = radio.CurrentCodeplug.FileUuid;
				num2 = (short)385810441;
				num = (int)((global::System.IntPtr)num2);
			}
			return this;
			IL_3C:
			base.IsMigrationJob = true;
			num2 = (short)923795466;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000E84 RID: 3716 RVA: 0x0009A1AC File Offset: 0x000983AC
		public global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetMatrixRRPJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, int switchoverDelay, bool isARSSuppression)
		{
			int a_ = 12;
			short num = (short)1875836933;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug matrixCodeplug;
				switch (num2)
				{
				case 0:
					goto IL_16F;
				case 1:
					base.RRPLogicalID = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("焉㰋猍伏椑┓欕䜗愙⸛挝", a_), radio.IPProgramSystem.HostNameOrAddress, radio.IPProgramSystem.Port, matrixCodeplug.RadioId);
					num = (short)286457858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_DC;
				case 3:
					return this;
				case 4:
				{
					num = (short)1196163072;
					short num3 = num;
					if (((long)base.ConnectionMethod & 4L) > 0L)
					{
						num = (short)494469121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DC;
				}
				case 5:
				{
					num = (short)1386535789;
					short num4 = num;
					num = (short)262789997;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16F;
					default:
						num = (short)206700544;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_92;
						}
						continue;
					}
					break;
				}
				}
				IL_92:
				num = (short)1224802305;
				if (num != 0)
				{
				}
				if (radio is global::Motorola.CommonCPS.Server.EntityModel.MatrixRadio)
				{
					num = (short)686882816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_DC:
				base.RadioProductFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Paradise;
				base.MatrixSwitchoverDelayTimer = switchoverDelay;
				base.MatrixARSSuppression = isARSSuppression;
				num = (short)1354432515;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_16F:
				matrixCodeplug = (radio.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug);
				num = (short)1163984900;
				num2 = (int)((global::System.IntPtr)num);
			}
			return this;
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x0009A3A4 File Offset: 0x000985A4
		public global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetSingleRadio(bool isSingleRadioOp)
		{
			short num = (short)1423463142;
			short num2 = num;
			num = (short)38032102;
			switch (num2 == num)
			{
			}
			num = (short)1692925952;
			if (num != 0)
			{
			}
			num = (short)1994129409;
			if (num != 0)
			{
			}
			num = (short)785121280;
			short num3 = num;
			base.IsSROJob = isSingleRadioOp;
			base.HostName = global::System.Environment.MachineName;
			return this;
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x0009A460 File Offset: 0x00098660
		public global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetFirmwareRecoverJob(bool isFirmwareRecoverJob)
		{
			short num = (short)767754241;
			if (num != 0)
			{
			}
			num = (short)1732858288;
			short num2 = num;
			num = (short)887050672;
			switch (num2 == num)
			{
			}
			num = (short)2048000000;
			if (num != 0)
			{
			}
			num = (short)1824456704;
			short num3 = num;
			base.IsFirmwareRecoverJob = isFirmwareRecoverJob;
			return this;
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x0009A510 File Offset: 0x00098710
		public global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetSysCert(bool isUserCertUninstallAll, bool isSysCertDistableAll, bool isSysCertEnableAll)
		{
			short num = (short)134591793;
			short num2 = num;
			num = (short)1625863473;
			switch (num2 == num)
			{
			}
			num = (short)470876161;
			if (num != 0)
			{
			}
			num = (short)1898971136;
			if (num != 0)
			{
			}
			num = (short)1369309184;
			short num3 = num;
			base.IsUserCertUninstallAll = isUserCertUninstallAll;
			base.IsSysCertDisableAll = isSysCertDistableAll;
			base.IsSysCertEnableAll = isSysCertEnableAll;
			return this;
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x0009A5D0 File Offset: 0x000987D0
		public global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetRestoreJob(global::Motorola.CommonCPS.Server.EntityModel.Codeplug restoreCodeplug)
		{
			short num = (short)357957634;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1050171056;
					short num3 = num;
					num = (short)88364720;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_90;
					default:
						goto IL_F0;
					}
					break;
				}
				case 1:
					goto IL_90;
				case 2:
					num = (short)1816723457;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				}
				IL_59:
				base.RestoreCPUuid = ((restoreCodeplug != null) ? new global::System.Guid?(restoreCodeplug.Uuid) : null);
				num = (short)1780940801;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_90:
				base.RestoreConfiguration = ((restoreCodeplug != null) ? restoreCodeplug.Configuration : null);
				num = (short)1608974336;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F0:
			num = (short)528351232;
			if (num != 0)
			{
			}
			num = (short)287768576;
			short num4 = num;
			base.RestoreTemplate = ((restoreCodeplug != null) ? restoreCodeplug.Template : null);
			return this;
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0009A728 File Offset: 0x00098928
		public global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetSecurityField(global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest securityField)
		{
			short num = (short)380255363;
			short num2 = num;
			num = (short)1964063875;
			switch (num2 == num)
			{
			}
			num = (short)1237450753;
			if (num != 0)
			{
			}
			num = (short)1422000128;
			if (num != 0)
			{
			}
			num = (short)136445952;
			short num3 = num;
			base.SecurityFieldRequest = securityField;
			return this;
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0009A7D8 File Offset: 0x000989D8
		public global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetUEFileContent(byte[] ueFile)
		{
			short num = (short)689963808;
			short num2 = num;
			num = (short)167772960;
			switch (num2 == num)
			{
			}
			num = (short)1973682176;
			if (num != 0)
			{
			}
			num = (short)623116289;
			if (num != 0)
			{
			}
			num = (short)1751384064;
			short num3 = num;
			base.UEFileContent = ueFile;
			return this;
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0009A888 File Offset: 0x00098A88
		public global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetPBBFactoryResetJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			short num = (short)1212350466;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)569939644;
				short num3 = num;
				num = (short)1709348540;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1020002305;
					if (num != 0)
					{
					}
					num = (short)613220352;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_E8;
					case 1:
						base.IsFactoryReset = true;
						base.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteNoSwitchover;
						goto IL_D1;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					}
					IL_A1:
					if (base.JobType == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.FactoryReset)
					{
						num = (short)1905786881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EA;
				}
				IL_D1:
				num = (short)2032599040;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E8:
			IL_EA:
			num = (short)549781504;
			short num4 = num;
			return this;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0009A9AC File Offset: 0x00098BAC
		public global::Motorola.CommonCPS.Server.EntityModel.IJobRequestBuilder SetPasswordResetFileContent(byte[] passwordResetFileContent)
		{
			short num = (short)553827157;
			short num2 = num;
			num = (short)1704901461;
			switch (num2 == num)
			{
			}
			num = (short)1508704257;
			if (num != 0)
			{
			}
			num = (short)993787904;
			if (num != 0)
			{
			}
			num = (short)2117730304;
			short num3 = num;
			base.PasswordResetFileContent = passwordResetFileContent;
			return this;
		}
	}
}
