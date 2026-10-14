using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ASK.Interface;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using RFResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.ConvertorExtensions
{
	// Token: 0x02000006 RID: 6
	public static class Enum2ResourceString
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00003B58 File Offset: 0x00001D58
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus radioStatus)
		{
			short num = (short)944701442;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1740767233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_F3;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				switch (radioStatus)
				{
				case global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.New:
					goto IL_A8;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.Ready:
					goto IL_F5;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.Modified:
					goto IL_D6;
				default:
				{
					num = (short)1282070578;
					short num3 = num;
					num = (short)1861408818;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)669712384;
						if (num != 0)
						{
						}
						num = (short)344784896;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_A8:
			num = (short)517734401;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RadioStatus_New;
			IL_D6:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RadioStatus_Modified;
			IL_F3:
			num = (short)1706164224;
			short num4 = num;
			return string.Empty;
			IL_F5:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RadioStatus_Ready;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003C90 File Offset: 0x00001E90
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily)
		{
			short num = (short)675020826;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseRepeater)
					{
						num = (short)311820294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_393;
				case 1:
					num = (short)2006253581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1838874641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (productFamily <= global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Paradise)
					{
						num = (short)1561460746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)937754647;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Matrix)
					{
						num = (short)96796679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_399;
				case 5:
				{
					num = (short)784273383;
					short num3 = num;
					num = (short)94310375;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_174;
					default:
						num = (short)480182272;
						if (num != 0)
						{
						}
						if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
						{
							num = (short)1512439816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17F;
					}
					break;
				}
				case 6:
					num = (short)759234574;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1506082827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)1782382613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)64749568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)2064121860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Paradise)
					{
						num = (short)1018232859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B9;
				case 12:
					if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MatrixRepeater)
					{
						num = (short)394395649;
						if (num != 0)
						{
						}
						num = (short)1090715649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_48F;
				case 13:
					goto IL_334;
				case 14:
					if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseLight)
					{
						num = (short)728891394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_139;
				case 15:
					if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller)
					{
						num = (short)661848084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26E;
				case 16:
					goto IL_350;
				case 17:
					goto IL_3B7;
				case 18:
					num = (short)17498115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (productFamily <= global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseLight)
					{
						num = (short)1175846921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)240123919;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)762970117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC)
					{
						num = (short)2043019288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_274;
				case 22:
					num = (short)1476853772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (productFamily != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Phoenix)
					{
						num = (short)523632662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_179;
				case 24:
					num = (short)230293529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_410;
				case 26:
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					continue;
				case 27:
					goto IL_174;
				}
				IL_95:
				if (productFamily <= global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MatrixRepeater)
				{
					num = (short)637796370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1840644115;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_174:
				num = (short)53805072;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B9:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_ProductFamily_Paradise;
			IL_139:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_ProductFamily_ParadiseLight;
			IL_179:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_ProductFamily_Phoenix;
			IL_17F:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_ProductFamily_MNIS;
			IL_26E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_ProductFamily_DMR3Controller;
			IL_274:
			num = (short)1209204736;
			short num4 = num;
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_ProductFamily_VRC;
			IL_334:
			IL_350:
			goto IL_495;
			IL_393:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_ProductFamily_ParadiseRepeater;
			IL_399:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_ProductFamily_Matrix;
			IL_3B7:
			IL_410:
			goto IL_495;
			IL_48F:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_ProductFamily_MatrixRepeater;
			IL_495:
			return string.Empty;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00004138 File Offset: 0x00002338
		public static string ToResourceString(this global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uiJobStatus)
		{
			short num = (short)2113994754;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1786249217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_18E;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				switch (uiJobStatus)
				{
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Canceled:
					goto IL_201;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Completed:
					goto IL_1EF;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Performed:
					goto IL_146;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Created:
					goto IL_193;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Expired:
					goto IL_13A;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Failed:
					goto IL_15E;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.RunningProcessingJob:
					goto IL_1E9;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Running_Read:
					goto IL_199;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.RunningWaitingForDP:
					goto IL_170;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.RunningWaitingForJP:
					goto IL_1D7;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Running_Write:
					goto IL_19F;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Scheduled:
					goto IL_1DD;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.ScheduledProcessingJob:
					goto IL_1FB;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.WaitingForJP:
					goto IL_158;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred:
					goto IL_134;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_10:
					goto IL_207;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_20:
					goto IL_1E3;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_30:
					goto IL_14C;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_40:
					goto IL_12E;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_50:
					goto IL_1D1;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_60:
					goto IL_20D;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_70:
					goto IL_1CB;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_80:
					goto IL_140;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_90:
					goto IL_164;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_99:
					goto IL_152;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.RunningCodeplugDownloaded:
					goto IL_1F5;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.PackageDownloaded:
					goto IL_16A;
				default:
				{
					num = (short)1789067264;
					short num3 = num;
					num = (short)1678725263;
					short num4 = num;
					num = (short)1116688527;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_207;
					default:
						num = (short)1642659840;
						if (num != 0)
						{
						}
						num = (short)1369702400;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_12E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Transferred_40;
			IL_134:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Transferred;
			IL_13A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Expired;
			IL_140:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Transferred_80;
			IL_146:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Performed;
			IL_14C:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Transferred_30;
			IL_152:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Transferred_99;
			IL_158:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_WaitingForJP;
			IL_15E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Failed;
			IL_164:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Transferred_90;
			IL_16A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_PackageDownloaded;
			IL_170:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_RunningWaitingForDP;
			IL_18E:
			return string.Empty;
			IL_193:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Created;
			IL_199:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Running_Read;
			IL_19F:
			num = (short)1061617665;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Running_Write;
			IL_1CB:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Transferred_70;
			IL_1D1:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Transferred_50;
			IL_1D7:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_RunningWaitingForJP;
			IL_1DD:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Scheduled;
			IL_1E3:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Transferred_20;
			IL_1E9:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_RunningProcessingJob;
			IL_1EF:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Completed;
			IL_1F5:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_CodeplugDownloaded;
			IL_1FB:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_ScheduledProcessingJob;
			IL_201:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Canceled;
			IL_207:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Transferred_10;
			IL_20D:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobStatus_Transferred_60;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00004360 File Offset: 0x00002560
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus jobContainerStatus)
		{
			short num = (short)136708097;
			if (num != 0)
			{
			}
			num = (short)316735490;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)648806401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_E6;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				}
				IL_57:
				switch (jobContainerStatus)
				{
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.PENDING:
					goto IL_9B;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.RUNNING:
					goto IL_F4;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.PERFORMED:
					goto IL_EE;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.FAILED:
					goto IL_95;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.CANCELED:
					goto IL_8F;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.SCHEDULED:
					goto IL_E8;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus.EXPIRED:
					goto IL_A1;
				default:
					num = (short)2146107392;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_8F:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobContainerStatus_Cancelled;
			IL_95:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobContainerStatus_Failed;
			IL_9B:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobContainerStatus_Pending;
			IL_A1:
			num = (short)573505536;
			short num3 = num;
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobContainer_Expired;
			IL_E6:
			num = (short)1846403288;
			short num4 = num;
			num = (short)1596711128;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A1;
			default:
				num = (short)494010368;
				if (num != 0)
				{
				}
				return string.Empty;
			}
			IL_E8:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobContainerStatus_Scheduled;
			IL_EE:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobContainerStatus_Performed;
			IL_F4:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_JobContainerStatus_Running;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000044B8 File Offset: 0x000026B8
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType uiSystemType)
		{
			short num = (short)241565698;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)153026561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_F4;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				}
				IL_32:
				switch (uiSystemType)
				{
				case global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.Other:
					goto IL_F6;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.DMR3:
					goto IL_D7;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.IPProgramSystemType.LE:
					goto IL_D1;
				default:
				{
					num = (short)150547107;
					short num3 = num;
					num = (short)1422142115;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1950416897;
						if (num != 0)
						{
						}
						num = (short)671875072;
						if (num != 0)
						{
						}
						num = (short)719454208;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_D1:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_IPProgramSystem_LE;
			IL_D7:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_IPProgramSystem_DMR3;
			IL_F4:
			num = (short)339279872;
			short num4 = num;
			return string.Empty;
			IL_F6:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_IPProgramSystem_Other;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000045F0 File Offset: 0x000027F0
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? value)
		{
			short num = (short)101187587;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1576927234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType valueOrDefault;
					switch (valueOrDefault)
					{
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.ASTRO:
						goto IL_190;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.MDC:
						goto IL_84;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.TYPEII:
						goto IL_15A;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.DVRS:
						goto IL_8A;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.ASTRO25:
						goto IL_160;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.QCII:
					{
						num = (short)686617375;
						short num3 = num;
						num = (short)50197279;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_107;
						default:
							goto IL_E4;
						}
						break;
					}
					default:
						num = (short)187695104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_A9;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType valueOrDefault = value.GetValueOrDefault();
					goto IL_107;
				}
				}
				IL_38:
				num = (short)2108227585;
				if (num != 0)
				{
				}
				if (value != null)
				{
					num = (short)1952120836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_196;
				IL_107:
				num = (short)925892609;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_84:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.AstroSubSystemType_MDC;
			IL_8A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.AstroSubSystemType_DVRS;
			IL_A9:
			goto IL_196;
			IL_E4:
			num = (short)896335872;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.ResourceRepository.Resources.AstroSubSystemType_QCII;
			IL_15A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.AstroSubSystemType_TypeII;
			IL_160:
			num = (short)680984576;
			short num4 = num;
			return global::Motorola.CommonCPS.ResourceRepository.Resources.AstroSubSystemType_Astro25;
			IL_190:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.AstroSubSystemType_Astro;
			IL_196:
			return string.Empty;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004798 File Offset: 0x00002998
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? value)
		{
			short num = (short)447479811;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1373110274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)601096193;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType valueOrDefault;
					switch (valueOrDefault)
					{
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING:
						goto IL_61;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL:
						goto IL_17E;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.BROADBANDONLY:
						goto IL_5B;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONALBROADBAND:
						goto IL_178;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNKINGBROADBAND:
						goto IL_AB;
					default:
						num = (short)758775808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_A6;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
				{
					num = (short)1246714161;
					short num3 = num;
					num = (short)1919899953;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_184;
					default:
					{
						num = (short)1810628608;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType valueOrDefault = value.GetValueOrDefault();
						num = (short)665387009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_38:
				if (value == null)
				{
					goto IL_184;
				}
				num = (short)1042022404;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_5B:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.AstroSystemType_BroadbandOnly;
			IL_61:
			num = (short)1377632256;
			short num4 = num;
			return global::Motorola.CommonCPS.ResourceRepository.Resources.AstroSystemType_Trunking;
			IL_A6:
			goto IL_184;
			IL_AB:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.AstroSystemType_TrunkingBroadband;
			IL_178:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.AstroSystemType_ConventionalBroadband;
			IL_17E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.AstroSystemType_Conventional;
			IL_184:
			return string.Empty;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00004930 File Offset: 0x00002B30
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType)
		{
			short num = (short)652083204;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (jobType != global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UnAssigned)
					{
						num = (short)1631059970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_44E;
				case 1:
					goto IL_4F0;
				case 2:
					num = (short)991625217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1360195032;
					short num3 = num;
					num = (short)1776676312;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A0;
					default:
						num = (short)215416832;
						if (num != 0)
						{
						}
						num = (short)1027538944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				}
				IL_38:
				switch (jobType)
				{
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read:
					goto IL_3DC;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteNoSwitchover:
					goto IL_3B2;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteWithSwitchover:
					goto IL_4A2;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Switchover:
					goto IL_4F5;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.FactoryReset:
					goto IL_58B;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportArchive:
					goto IL_5D3;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteRadios:
					goto IL_3FA;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.CompleteRadio:
					goto IL_496;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectTemplate:
					goto IL_5D9;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectConfiguration:
					goto IL_5CD;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteTemplate:
					goto IL_49C;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteKeys:
					goto IL_442;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportLanguagePacks:
					goto IL_2C1;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteConfiguration:
					goto IL_3EE;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteSetTelePort:
					goto IL_3D6;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeletePackage:
					goto IL_35E;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportFirmwarePacks:
					goto IL_4A8;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportVAPackage:
					goto IL_400;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportTTSPackage:
					goto IL_358;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportTemplates:
					goto IL_490;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ApplyMVO:
					goto IL_2B5;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ApplyTemplate:
					goto IL_38E;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ApplyConfiguration:
					goto IL_591;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DiscardCodeplugChanges:
					goto IL_364;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpgradeRadio:
					goto IL_2D9;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportRadioFromCSV:
					goto IL_3E8;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportCertificates:
					goto IL_3A0;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ScheduleJob:
					goto IL_3A6;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.MoveDevices:
					goto IL_40C;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Flashport:
					goto IL_5BB;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportCSV:
					goto IL_39A;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpgradeFirmware:
					goto IL_54F;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpgradeLanguagePack:
					goto IL_388;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectLanguagePack:
					goto IL_5A9;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SubmitLicenseAssignment:
					goto IL_531;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.RecoverRadioLicense:
					goto IL_555;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.RestoreRadioLicense:
					goto IL_4C6;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.RecoverCMSCLicense:
					goto IL_436;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.RestoreCMSCLicense:
					goto IL_3CA;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SubmitAppLicense:
					goto IL_50D;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SubmitAppLicenseFile:
					goto IL_4AE;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.CancelJob:
					goto IL_376;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.RecoverAppLicense:
					goto IL_3BE;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpdateRadio:
					goto IL_37C;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.CopyConfiguration:
					goto IL_45A;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportConfiguration:
					goto IL_5A3;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ExportConfiguration:
					goto IL_478;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportGeneralPackages:
					goto IL_313;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportPBBAPKApplication:
					goto IL_507;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportPBBShortcut:
					goto IL_3B8;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportPBBApplicationWidget:
					goto IL_472;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportPBBCertificate:
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpgradeTCMNIS:
					goto IL_5F1;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectPBBAPKApplication:
					goto IL_3F4;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectGeneralPackage:
					goto IL_4CC;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectPBBFirmware:
					goto IL_501;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectApkApplication:
					goto IL_3C4;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectPBBCertificate:
					goto IL_418;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeletePBBPassword:
					goto IL_3AC;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.AddPBBPassword:
					goto IL_5DF;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ChangePBBPasswordID:
					goto IL_513;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ChangePBBPasswordValue:
					goto IL_597;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportPBBHomeSetPackages:
					goto IL_5C1;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SelectPBBHomeSetPackage:
					goto IL_466;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpdatePBBHomeSetPackage:
					goto IL_484;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DuplicatePBBHomeSetPackage:
					goto IL_430;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SavePBBHomeSetPackage:
					goto IL_47E;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SaveAsPBBHomeSetPackage:
					goto IL_406;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ExportPBBHomeSetPackage:
					goto IL_4FB;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.NewPBBHomeSetPackage:
					goto IL_48A;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteJobContainer:
					goto IL_43C;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.MoveQueries:
					goto IL_543;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteQueries:
					goto IL_288;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.UpgradeCodeplugVersion:
					goto IL_2D3;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeletePBBShortcuts:
					goto IL_454;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeletePBBApplicationWidget:
					goto IL_460;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteSystems:
					goto IL_2BB;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ApplyIPProgramSystem:
					goto IL_394;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteSACRecord:
					goto IL_549;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.AddTGSARecords:
					goto IL_412;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeleteTGSARecords:
					goto IL_41E;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.EditSACRecord:
					goto IL_57F;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.EditTGSARecord:
					goto IL_3D0;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportSiSeries:
					goto IL_46C;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportWhiteList:
					goto IL_537;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportSimpleTouch:
					goto IL_30D;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportAPNList:
					goto IL_5E5;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportCACertificatesPackage:
					goto IL_42A;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ImportDVRSFilesPackage:
					goto IL_519;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DeviceCapabilityMigration:
					goto IL_448;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.GroupMigration:
					goto IL_573;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.VAMigration:
					goto IL_579;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.LPMigration:
					goto IL_525;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.PCRTTSMigration:
					goto IL_2C7;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.MatrixKeyMigration:
					goto IL_4BA;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.FWMigration:
					goto IL_282;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.RadioMigration:
					goto IL_4B4;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.JobMigration:
					goto IL_52B;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.TemplateMigration:
					goto IL_53D;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.CodeplugMigration:
					goto IL_382;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ScheduleMigrationJob:
					goto IL_56D;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ApplyTemplateToRadio:
					goto IL_4D2;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.AppMigration:
					goto IL_307;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ProvisioningMigration:
					goto IL_5B5;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.PBBPasswordMigration:
					goto IL_36A;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.FirmwareMigration:
					goto IL_424;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.HomeSetMigration:
					goto IL_51F;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.PBBLicenseMigration:
					goto IL_2CD;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.CodeplugApplicationPairMigration:
					goto IL_3E2;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.PBBFusionCfgMigration:
					goto IL_5EB;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.PBBFusionWifiMigration:
					goto IL_567;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.PBBFusionApplyToRadioMigration:
					goto IL_585;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.CACertificatesMigration:
					goto IL_561;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.DVRSFilesMigration:
					goto IL_4C0;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.RadioConversion:
					goto IL_370;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.TemplateConversion:
					goto IL_55B;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.AutoAdd:
					goto IL_5AF;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.SyncRead:
					goto IL_59D;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ResetPassword:
					goto IL_5C7;
				default:
					num = (short)809828355;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_282:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.FWMigration;
			IL_288:
			num = (short)415039489;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeleteQueries;
			IL_2B5:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ApplyMVO;
			IL_2BB:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeleteSystems;
			IL_2C1:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportLanguagePacks;
			IL_2C7:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.PCRTTSMigration;
			IL_2CD:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_PBBLicenseMigration;
			IL_2D3:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_UpgradeCodeplugVersion;
			IL_2D9:
			num = (short)1555365888;
			short num4 = num;
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_UpgradeRadio;
			IL_307:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_AppMigration;
			IL_30D:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportSimpleTouch;
			IL_313:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ImportPackages;
			IL_358:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportTTSPackage;
			IL_35E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeletePackage;
			IL_364:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DiscardCodeplugChanges;
			IL_36A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_PBBPasswordMigration;
			IL_370:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_Radio_Conversion;
			IL_376:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_CancelJob;
			IL_37C:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_UpdateRadio;
			IL_382:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_CodeplugMigration;
			IL_388:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_UpgradeLanguagePack;
			IL_38E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ApplyTemplate;
			IL_394:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ApplyIPProgramSystem;
			IL_39A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportCSV;
			IL_3A0:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportCertificates;
			IL_3A6:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ScheduleJob;
			IL_3AC:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.DeletePBBPasswordBatchJob;
			IL_3B2:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_Write;
			IL_3B8:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ImportShortcuts;
			IL_3BE:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_RecoverAppLicense;
			IL_3C4:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SelectApkApplicationJobName;
			IL_3CA:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_RestoreCMSCLicense;
			IL_3D0:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_EditTGSARecord;
			IL_3D6:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeleteSetTelePort;
			IL_3DC:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_Read;
			IL_3E2:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_CodeplugApplicationPairMigration;
			IL_3E8:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportRadioFromCSV;
			IL_3EE:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeleteConfiguration;
			IL_3F4:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SelectPBBAPKApplication;
			IL_3FA:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeleteRadios;
			IL_400:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportVAPackage;
			IL_406:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SaveAsPBBHomeSetPackage;
			IL_40C:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_MoveDevices;
			IL_412:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_AddTGSARecords;
			IL_418:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.SelectPBBCertificateJobName;
			IL_41E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeleteTGSARecords;
			IL_424:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_FirmwareMigration;
			IL_42A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportCACertificatesPackage;
			IL_430:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DuplicatePBBHomeSet;
			IL_436:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_RecoverCMSCLicense;
			IL_43C:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeleteJobContainer;
			IL_442:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeleteKeys;
			IL_448:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.DeviceCapabilityMigration;
			IL_44E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_UnAssigned;
			IL_454:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeletePBBShortcut;
			IL_45A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_CopyConfiguration;
			IL_460:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeletePBBApplicationWidget;
			IL_466:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SelectHomeSet;
			IL_46C:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportSiSeries;
			IL_472:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ImportWidgets;
			IL_478:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ExportConfiguration;
			IL_47E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SavePBBHomeSetPackage;
			IL_484:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_UpdateHomeSet;
			IL_48A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_NewPBBHomeSet;
			IL_490:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportTemplates;
			IL_496:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_CompleteRadio;
			IL_49C:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeleteTemplate;
			IL_4A2:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_WriteAndSwitchover;
			IL_4A8:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportFirmwarePacks;
			IL_4AE:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SubmitAppLicenseFile;
			IL_4B4:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RadioMigration;
			IL_4BA:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.MatrixKeyMigration;
			IL_4C0:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.DVRSFilesMigration;
			IL_4C6:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_RestoreRadioLicense;
			IL_4CC:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SelectProvisioningPackage;
			IL_4D2:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ApplyTemplateToRadio;
			IL_4F0:
			goto IL_5F1;
			IL_4F5:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_Switchover;
			IL_4FB:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ExportPBBHomeSet;
			IL_501:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SelectFirmware;
			IL_507:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ImportApps;
			IL_50D:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SubmitAppLicense;
			IL_513:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ChangePBBPasswordIDBatchJob;
			IL_519:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportDVRSFilesPackage;
			IL_51F:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_HomeSetMigration;
			IL_525:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.LPMigration;
			IL_52B:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobMigration;
			IL_531:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SubmitLicenseAssignment;
			IL_537:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportWhiteList;
			IL_53D:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.TemplateMigration;
			IL_543:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_MoveQueries;
			IL_549:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_DeleteSACRecord;
			IL_54F:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_UpgradeFirmware;
			IL_555:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_RecoverRadioLicense;
			IL_55B:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_Template_Conversion;
			IL_561:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.CACertificatesMigration;
			IL_567:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_PBBFusionWifiMigration;
			IL_56D:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ScheduleMigrationJob;
			IL_573:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.GroupMigration;
			IL_579:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.VAMigration;
			IL_57F:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_EditSACRecord;
			IL_585:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_PBBFusionApplyToRadioMigration;
			IL_58B:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_FactoryReset;
			IL_591:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ApplyConfiguration;
			IL_597:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ChangePBBPasswordValueBatchJob;
			IL_59D:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SyncRead;
			IL_5A3:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportConfiguration;
			IL_5A9:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SelectLanguagePack;
			IL_5AF:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_AutoAdd;
			IL_5B5:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ProvisioningMigration;
			IL_5BB:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_Flashport;
			IL_5C1:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PM_ImportHomeSets;
			IL_5C7:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ResetPassword;
			IL_5CD:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SelectConfiguration;
			IL_5D3:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportRadio;
			IL_5D9:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_SelectTemplate;
			IL_5DF:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_AddPBBPassword;
			IL_5E5:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_ImportAPNList;
			IL_5EB:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.JobType_PBBFusionCfgMigration;
			IL_5F1:
			return string.Empty;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00004F34 File Offset: 0x00003134
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.PreferLevel preferenceLevel)
		{
			short num;
			for (;;)
			{
				num = (short)575799298;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)2008875009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_A7;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					num = (short)1723269121;
					if (num != 0)
					{
					}
					switch (preferenceLevel)
					{
					case global::Motorola.CommonCPS.Server.CommonDBConstants.PreferLevel.LEVEL1:
						goto IL_123;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.PreferLevel.LEVEL2:
						goto IL_8A;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.PreferLevel.LEVEL3:
						goto IL_84;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.PreferLevel.LEVEL4:
						goto IL_D1;
					default:
						num = (short)1942224896;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_D1:
				num = (short)941103620;
				short num3 = num;
				num = (short)1832786436;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_107;
				}
			}
			IL_84:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_SiteList_PreferredLevel3;
			IL_8A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_SiteList_PreferredLevel2;
			IL_A7:
			num = (short)1856110592;
			short num4 = num;
			return string.Empty;
			IL_107:
			num = (short)696385536;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_SiteList_PreferredLevel4;
			IL_123:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Model_SiteList_PreferredLevel1;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00005070 File Offset: 0x00003270
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.PcrSystemSubType? subSystemType)
		{
			int a_ = 9;
			short num = (short)1293549572;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)782635327;
					short num3 = num;
					num = (short)74649919;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)24379392;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.CommonDBConstants.PcrSystemSubType valueOrDefault;
						switch (valueOrDefault)
						{
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PcrSystemSubType.NONMSIDMR3:
							goto IL_6A;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PcrSystemSubType.DMREMERALD:
							goto IL_64;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.PcrSystemSubType.PCCEMERALD:
							goto IL_12D;
						default:
							num = (short)467861506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					break;
				}
				case 1:
					goto IL_172;
				case 2:
				{
					num = (short)623247360;
					short num4 = num;
					num = (short)405536769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.PcrSystemSubType valueOrDefault = subSystemType.GetValueOrDefault();
					num = (short)1050017792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				}
				IL_41:
				if (subSystemType == null)
				{
					goto IL_174;
				}
				num = (short)1290403843;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_64:
			return global::RFResourceRepository.RFResources.DMREMERALD;
			IL_6A:
			return global::RFResourceRepository.RFResources.NONMSIDMR3;
			IL_12D:
			num = (short)371261441;
			if (num != 0)
			{
			}
			return global::RFResourceRepository.RFResources.PCCEMERALD;
			IL_172:
			IL_174:
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.b("퇾⼀ⴂ", a_);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00005200 File Offset: 0x00003400
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.PcrSystemSubType subSystemType)
		{
			int a_ = 16;
			short num;
			for (;;)
			{
				num = (short)551288834;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1129185281;
						if (num != 0)
						{
						}
						num = (short)1043726337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_126;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					}
					IL_39:
					switch (subSystemType)
					{
					case global::Motorola.CommonCPS.Server.CommonDBConstants.PcrSystemSubType.NONMSIDMR3:
						goto IL_B7;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.PcrSystemSubType.DMREMERALD:
						goto IL_66;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.PcrSystemSubType.PCCEMERALD:
						goto IL_128;
					default:
						num = (short)1741946880;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_66:
				num = (short)514849281;
				short num3 = num;
				num = (short)1726937601;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_9A;
				}
			}
			IL_9A:
			num = (short)1756037120;
			if (num != 0)
			{
			}
			return global::RFResourceRepository.RFResources.DMREMERALD;
			IL_B7:
			num = (short)1053360128;
			short num4 = num;
			return global::RFResourceRepository.RFResources.NONMSIDMR3;
			IL_126:
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.b("⠅☇␉", a_);
			IL_128:
			return global::RFResourceRepository.RFResources.PCCEMERALD;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000534C File Offset: 0x0000354C
		public static string ToResourceString(this global::ASK.Interface.KeyType systemKeyType)
		{
			short num = (short)2143879169;
			if (num != 0)
			{
			}
			num = (short)1783440604;
			short num2 = num;
			num = (short)686630108;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1068498944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1258422272;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.KeyTypeAndResouceConverter.GetResouce(systemKeyType);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000053F8 File Offset: 0x000035F8
		public static string ToResourceString(this global::ASK.Interface.KeyAccessLevelType systemKeyAccess)
		{
			short num;
			for (;;)
			{
				num = (short)1100349442;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1896284161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11B;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					switch (systemKeyAccess)
					{
					case global::ASK.Interface.KeyAccessLevelType.LIMITED_ACC:
						goto IL_AC;
					case global::ASK.Interface.KeyAccessLevelType.UNLM_ACC:
						goto IL_5C;
					case global::ASK.Interface.KeyAccessLevelType.UNLM_ACC_WITHOUT_WP:
						goto IL_11D;
					default:
						num = (short)1771569152;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_5C:
				num = (short)1483278643;
				short num3 = num;
				num = (short)2689331;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_90;
				}
			}
			IL_90:
			num = (short)1560936448;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ASTRO_ASKAccess_UNLM_ACC;
			IL_AC:
			num = (short)301727744;
			short num4 = num;
			num = (short)354156545;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ASTRO_ASKAccess_LIMITED_ACC;
			IL_11B:
			return string.Empty;
			IL_11D:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.ASTRO_ASKAccess_UNLM_ACC_WITHOUT_WP;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00005530 File Offset: 0x00003730
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType type)
		{
			short num;
			for (;;)
			{
				num = (short)1924333570;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)634781697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_119;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					switch (type)
					{
					case global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType.CONFIGURATION:
						goto IL_AD;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType.SET:
						goto IL_11B;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType.RADIO:
						goto IL_5C;
					default:
						num = (short)1546780672;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_5C:
				num = (short)753692952;
				short num3 = num;
				num = (short)321745176;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_91;
				}
			}
			IL_91:
			num = (short)1544814592;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.ResourceRepository.Resources.DataMiningQueryType_Radio;
			IL_AD:
			num = (short)2064842752;
			short num4 = num;
			num = (short)246349825;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.ResourceRepository.Resources.DataMiningQueryType_Configuration;
			IL_119:
			return string.Empty;
			IL_11B:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.DataMiningQueryType_Set;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00005664 File Offset: 0x00003864
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName region)
		{
			short num;
			for (;;)
			{
				num = (short)1029636098;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1064370177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_AE;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					switch (region)
					{
					case global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NA:
						goto IL_D9;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.LA:
						goto IL_8A;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.EMEA:
						goto IL_90;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.AS:
						goto IL_128;
					default:
						num = (short)1238433793;
						if (num != 0)
						{
						}
						num = (short)109379584;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_D9:
				num = (short)842848379;
				short num3 = num;
				num = (short)822204539;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_10D;
				}
			}
			IL_8A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Region_LA;
			IL_90:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Region_EMEA;
			IL_AE:
			num = (short)1041563648;
			short num4 = num;
			return string.Empty;
			IL_10D:
			num = (short)1512308736;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Region_NA;
			IL_128:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.Region_AS;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000057A4 File Offset: 0x000039A4
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy CFP)
		{
			for (;;)
			{
				IL_00:
				short num = (short)2094989315;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)363200513;
						if (num != 0)
						{
						}
						num = (short)1871970304;
						short num3 = num;
						if (CFP != global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy.ReadWrite)
						{
							goto IL_128;
						}
						num = (short)1415034007;
						short num4 = num;
						num = (short)53130391;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)423362560;
							if (num != 0)
							{
							}
							num = (short)811859969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_123;
					case 2:
						num = (short)57671680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					}
					IL_34:
					if (CFP == global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy.Read)
					{
						goto IL_4E;
					}
					num = (short)1274544130;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_4E:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.CFP_Read;
			IL_123:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.CFP_ReadWrite;
			IL_128:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.CFP_None;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000058E0 File Offset: 0x00003AE0
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy astroPasswordPolicy)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::System.Text.StringBuilder stringBuilder;
			char c;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					stringBuilder.Append(global::Motorola.CommonCPS.ResourceRepository.Resources.ASTROPassword_Write);
					stringBuilder.Append(c);
					num2 = (short)1314258946;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if ((astroPasswordPolicy & global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Read) > global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None)
					{
						num2 = (short)312082443;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				case 2:
					goto IL_B0;
				case 3:
					goto IL_13C;
				case 4:
				{
					num2 = (short)1298624431;
					short num3 = num2;
					num2 = (short)506818479;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15C;
					default:
						num2 = (short)2117795840;
						if (num2 != 0)
						{
						}
						stringBuilder.Append(global::Motorola.CommonCPS.ResourceRepository.Resources.ASTROPassword_None);
						stringBuilder.Append(c);
						num2 = (short)1830354951;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if ((astroPasswordPolicy & global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Write) > global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None)
					{
						goto IL_15C;
					}
					goto IL_B0;
				case 6:
					goto IL_1DA;
				case 7:
					goto IL_1A3;
				case 8:
					if ((astroPasswordPolicy & global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None) > global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None)
					{
						num2 = (short)1873412100;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_294;
				case 9:
					if ((astroPasswordPolicy & global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Open) > global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None)
					{
						num2 = (short)1875968000;
						short num4 = num2;
						num2 = (short)21561354;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1DA;
				case 10:
					stringBuilder.Append(global::Motorola.CommonCPS.ResourceRepository.Resources.ASTROPassword_Open);
					stringBuilder.Append(c);
					num2 = (short)23330822;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					stringBuilder.Append(global::Motorola.CommonCPS.ResourceRepository.Resources.ASTROPassword_Read);
					stringBuilder.Append(c);
					num2 = (short)763035651;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_B0:
				num2 = (short)236716033;
				if (num2 != 0)
				{
				}
				num2 = (short)1767637001;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_13C:
				num2 = (short)448397317;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_15C:
				num2 = (short)1166475264;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1DA:
				num2 = (short)823590920;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1A3:
			IL_294:
			return stringBuilder.ToString().TrimEnd(new char[]
			{
				c
			});
			IL_40:
			c = ',';
			stringBuilder = new global::System.Text.StringBuilder();
			num2 = (short)1231093761;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00005B98 File Offset: 0x00003D98
		public static global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy ConvertToCheckforPassword(string CFPString)
		{
			short num;
			for (;;)
			{
				num = (short)2093744131;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)116981761;
						if (num != 0)
						{
						}
						if (CFPString == global::Motorola.CommonCPS.ResourceRepository.Resources.CFP_Read)
						{
							num = (short)696451073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy.None;
					case 1:
						goto IL_E7;
					case 2:
						goto IL_57;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					}
					IL_34:
					if (CFPString == global::Motorola.CommonCPS.ResourceRepository.Resources.CFP_ReadWrite)
					{
						num = (short)999292930;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1809580032;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_E7:
				num = (short)57017719;
				short num3 = num;
				num = (short)229377399;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_11C;
				}
			}
			IL_57:
			num = (short)205717504;
			short num4 = num;
			return global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy.ReadWrite;
			IL_11C:
			num = (short)776536064;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy.Read;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00005CE0 File Offset: 0x00003EE0
		public static global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? ConvertToRegion(string regionString)
		{
			short num = (short)815792134;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_8B;
				case 1:
				{
					if (regionString == global::Motorola.CommonCPS.ResourceRepository.Resources.Region_EMEA)
					{
						num = (short)843055111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2132493856;
					short num3 = num;
					num = (short)51660320;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_90;
					default:
						num = (short)277676032;
						if (num != 0)
						{
						}
						num = (short)1814298627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
				{
					num = (short)340590592;
					short num4 = num;
					if (regionString == global::Motorola.CommonCPS.ResourceRepository.Resources.Region_LA)
					{
						num = (short)1372913668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1848573953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (regionString == global::Motorola.CommonCPS.ResourceRepository.Resources.Region_NA)
					{
						num = (short)391970821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E7;
				case 4:
					goto IL_141;
				case 5:
					goto IL_1DB;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 7:
					goto IL_D6;
				}
				IL_44:
				num = (short)559153153;
				if (num != 0)
				{
				}
				if (regionString == global::Motorola.CommonCPS.ResourceRepository.Resources.Region_AS)
				{
					num = (short)683933696;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)2095710210;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_8B:
			return new global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.AS);
			IL_90:
			return new global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.EMEA);
			IL_D6:
			goto IL_90;
			IL_141:
			return new global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.LA);
			IL_1DB:
			return new global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NA);
			IL_1E7:
			return null;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00005EE0 File Offset: 0x000040E0
		public static string ToResourceString(this global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType sacDeviceType)
		{
			int a_ = 6;
			short num = (short)1139212289;
			if (num != 0)
			{
			}
			num = (short)300941313;
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
						goto IL_60;
					}
					continue;
				case 2:
				{
					num = (short)2094865836;
					short num3 = num;
					num = (short)1980767660;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)131596288;
						if (num != 0)
						{
						}
						num = (short)2076180480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_60:
				switch (sacDeviceType)
				{
				case global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.MOTOROLADEVICE:
					goto IL_12F;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.NONMOTOROLARADIO:
					goto IL_10A;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.CONSOLE:
					goto IL_135;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.VOICEGATEWAY:
					goto IL_104;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType.DATAGATEWAY:
					goto IL_129;
				default:
				{
					num = (short)1800011776;
					short num4 = num;
					num = (short)1707802626;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_104:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_SACRecord_VOICEGATEWAY;
			IL_10A:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_SACRecord_NONMOTOROLARADIO;
			IL_127:
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.b("틻탽⻿", a_);
			IL_129:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_SACRecord_DATAGATEWAY;
			IL_12F:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_SACRecord_MOTOROLADEVICE;
			IL_135:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_SACRecord_CONSOLE;
		}

		// Token: 0x02000007 RID: 7
		public class KeyTypeAndResouceConverter
		{
			// Token: 0x0600001F RID: 31 RVA: 0x00006038 File Offset: 0x00004238
			private KeyTypeAndResouceConverter()
			{
				this.a.Add(global::ASK.Interface.KeyType.ADVANCED_CONV_SYSTEM_KEY, global::Motorola.CommonCPS.ResourceRepository.Resources.ASTRO_ASKType_ADVANCED_CONV_SYSTEM_KEY);
				this.a.Add(global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY, global::Motorola.CommonCPS.ResourceRepository.Resources.ASTRO_ASKType_ADVANCED_SYSTEM_KEY);
				this.a.Add(global::ASK.Interface.KeyType.ADVANCED_WACN_KEY, global::Motorola.CommonCPS.ResourceRepository.Resources.ASTRO_ASKType_ADVANCED_WACN_KEY);
				this.a.Add(global::ASK.Interface.KeyType.UNDEFINED_KEY, global::Motorola.CommonCPS.ResourceRepository.Resources.ASTRO_ASKType_UNDEFINED_KEY);
				this.a.Add(global::ASK.Interface.KeyType.NONE, global::Motorola.CommonCPS.ResourceRepository.Resources.ASTRO_ASKType_None);
			}

			// Token: 0x06000020 RID: 32 RVA: 0x000060B4 File Offset: 0x000042B4
			public static string GetResouce(global::ASK.Interface.KeyType keyType)
			{
				short num = (short)1866530817;
				if (num != 0)
				{
				}
				num = (short)1488630857;
				short num2 = num;
				num = (short)749515849;
				switch (num2 == num)
				{
				}
				num = (short)1167327232;
				short num3 = num;
				num = (short)2110062592;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.KeyTypeAndResouceConverter.b.a[keyType];
			}

			// Token: 0x06000021 RID: 33 RVA: 0x0000616C File Offset: 0x0000436C
			public static global::ASK.Interface.KeyType GetKeyType(string resouce)
			{
				short num = (short)117394979;
				short num2 = num;
				num = (short)464080419;
				switch (num2 == num)
				{
				}
				num = (short)1539833857;
				if (num != 0)
				{
				}
				num = (short)1618870272;
				short num3 = num;
				num = (short)89718784;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.KeyTypeAndResouceConverter.a a = new global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.KeyTypeAndResouceConverter.a();
				a.a = resouce;
				return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.KeyTypeAndResouceConverter.b.a.FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::ASK.Interface.KeyType, string>, bool>(a.b)).Key;
			}

			// Token: 0x06000022 RID: 34 RVA: 0x00006248 File Offset: 0x00004448
			// Note: this type is marked as 'beforefieldinit'.
			static KeyTypeAndResouceConverter()
			{
				short num = (short)1856924210;
				short num2 = num;
				num = (short)231107122;
				switch (num2 == num)
				{
				}
				num = (short)932708352;
				if (num != 0)
				{
				}
				num = (short)1516240896;
				short num3 = num;
				num = (short)751697921;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.KeyTypeAndResouceConverter.b = new global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.KeyTypeAndResouceConverter();
			}

			// Token: 0x04000004 RID: 4
			private global::System.Collections.Generic.Dictionary<global::ASK.Interface.KeyType, string> a = new global::System.Collections.Generic.Dictionary<global::ASK.Interface.KeyType, string>();

			// Token: 0x04000005 RID: 5
			private static global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.KeyTypeAndResouceConverter b;

			// Token: 0x02000008 RID: 8
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private sealed class a
			{
				// Token: 0x06000024 RID: 36 RVA: 0x00006310 File Offset: 0x00004510
				internal bool b(global::System.Collections.Generic.KeyValuePair<global::ASK.Interface.KeyType, string> A_0)
				{
					short num = (short)488088162;
					short num2 = num;
					num = (short)1012703842;
					switch (num2 == num)
					{
					}
					num = (short)1420886016;
					if (num != 0)
					{
					}
					num = (short)506789888;
					short num3 = num;
					num = (short)1725890561;
					if (num != 0)
					{
					}
					return string.Equals(A_0.Value, this.a, global::System.StringComparison.OrdinalIgnoreCase);
				}

				// Token: 0x04000006 RID: 6
				public string a;
			}
		}

		// Token: 0x02000009 RID: 9
		public class DataMiningAndORConverter
		{
			// Token: 0x06000025 RID: 37 RVA: 0x000063CC File Offset: 0x000045CC
			private DataMiningAndORConverter()
			{
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR.And, global::Motorola.CommonCPS.ResourceRepository.Resources.DataMiningAndOR_And);
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR.Or, global::Motorola.CommonCPS.ResourceRepository.Resources.DataMiningAndOR_Or);
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR.None, string.Empty);
			}

			// Token: 0x06000026 RID: 38 RVA: 0x00006420 File Offset: 0x00004620
			public static string GetResouce(global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR andOr)
			{
				short num = (short)1911438878;
				short num2 = num;
				num = (short)22298142;
				switch (num2 == num)
				{
				}
				num = (short)1341784065;
				if (num != 0)
				{
				}
				num = (short)1668349952;
				short num3 = num;
				num = (short)1301610496;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningAndORConverter.b.a[andOr];
			}

			// Token: 0x06000027 RID: 39 RVA: 0x000064DC File Offset: 0x000046DC
			public static global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR GetAndOR(string resouce)
			{
				short num = (short)934275080;
				short num2 = num;
				num = (short)79489032;
				switch (num2 == num)
				{
				}
				num = (short)1158217728;
				if (num != 0)
				{
				}
				num = (short)29949952;
				short num3 = num;
				num = (short)1000407041;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningAndORConverter.a a = new global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningAndORConverter.a();
				a.a = resouce;
				return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningAndORConverter.b.a.FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR, string>, bool>(a.b)).Key;
			}

			// Token: 0x06000028 RID: 40 RVA: 0x000065B4 File Offset: 0x000047B4
			// Note: this type is marked as 'beforefieldinit'.
			static DataMiningAndORConverter()
			{
				short num = (short)1011915995;
				short num2 = num;
				num = (short)111189211;
				switch (num2 == num)
				{
				}
				num = (short)1803157505;
				if (num != 0)
				{
				}
				num = (short)1298006016;
				short num3 = num;
				num = (short)105447424;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningAndORConverter.b = new global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningAndORConverter();
			}

			// Token: 0x04000007 RID: 7
			private global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR, string> a = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR, string>();

			// Token: 0x04000008 RID: 8
			private static global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningAndORConverter b;

			// Token: 0x0200000A RID: 10
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private sealed class a
			{
				// Token: 0x0600002A RID: 42 RVA: 0x00006678 File Offset: 0x00004878
				internal bool b(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR, string> A_0)
				{
					short num = (short)6094029;
					short num2 = num;
					num = (short)336329933;
					switch (num2 == num)
					{
					}
					num = (short)1880489985;
					if (num != 0)
					{
					}
					num = (short)1228668928;
					short num3 = num;
					num = (short)652410880;
					if (num != 0)
					{
					}
					return string.Equals(A_0.Value, this.a, global::System.StringComparison.OrdinalIgnoreCase);
				}

				// Token: 0x04000009 RID: 9
				public string a;
			}
		}

		// Token: 0x0200000B RID: 11
		public class DataMiningQueryTypeConverter
		{
			// Token: 0x0600002B RID: 43 RVA: 0x00006734 File Offset: 0x00004934
			private DataMiningQueryTypeConverter()
			{
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType.CONFIGURATION, global::Motorola.CommonCPS.ResourceRepository.Resources.DataMiningQueryType_Configuration);
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType.RADIO, global::Motorola.CommonCPS.ResourceRepository.Resources.DataMiningQueryType_Radio);
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType.SET, global::Motorola.CommonCPS.ResourceRepository.Resources.DataMiningQueryType_Set);
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00006788 File Offset: 0x00004988
			public static string GetResouce(global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType queryType)
			{
				short num = (short)704053249;
				if (num != 0)
				{
				}
				num = (short)288738561;
				short num2 = num;
				num = (short)1759497473;
				switch (num2 == num)
				{
				}
				num = (short)2023030784;
				short num3 = num;
				num = (short)444334080;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningQueryTypeConverter.b.a[queryType];
			}

			// Token: 0x0600002D RID: 45 RVA: 0x00006844 File Offset: 0x00004A44
			public static global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType GetQueryType(string resouce)
			{
				short num = (short)2080461178;
				short num2 = num;
				num = (short)990335354;
				switch (num2 == num)
				{
				}
				num = (short)471334913;
				if (num != 0)
				{
				}
				num = (short)437846016;
				short num3 = num;
				num = (short)557580288;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningQueryTypeConverter.a a = new global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningQueryTypeConverter.a();
				a.a = resouce;
				return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningQueryTypeConverter.b.a.FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType, string>, bool>(a.b)).Key;
			}

			// Token: 0x0600002E RID: 46 RVA: 0x00006920 File Offset: 0x00004B20
			// Note: this type is marked as 'beforefieldinit'.
			static DataMiningQueryTypeConverter()
			{
				short num = (short)103088129;
				if (num != 0)
				{
				}
				num = (short)1787746643;
				short num2 = num;
				num = (short)1628559699;
				switch (num2 == num)
				{
				}
				num = (short)1280704512;
				short num3 = num;
				num = (short)1890648064;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningQueryTypeConverter.b = new global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningQueryTypeConverter();
			}

			// Token: 0x0400000A RID: 10
			private readonly global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType, string> a = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType, string>();

			// Token: 0x0400000B RID: 11
			private static global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningQueryTypeConverter b;

			// Token: 0x0200000C RID: 12
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private sealed class a
			{
				// Token: 0x06000030 RID: 48 RVA: 0x000069EC File Offset: 0x00004BEC
				internal bool b(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DataMiningQueryType, string> A_0)
				{
					short num = (short)193580465;
					short num2 = num;
					num = (short)827248049;
					switch (num2 == num)
					{
					}
					num = (short)1376321536;
					if (num != 0)
					{
					}
					num = (short)331153408;
					short num3 = num;
					num = (short)1947402241;
					if (num != 0)
					{
					}
					return string.Equals(A_0.Value, this.a, global::System.StringComparison.OrdinalIgnoreCase);
				}

				// Token: 0x0400000C RID: 12
				public string a;
			}
		}

		// Token: 0x0200000D RID: 13
		public class ButtonBarModeConverter
		{
			// Token: 0x06000031 RID: 49 RVA: 0x00006AAC File Offset: 0x00004CAC
			private ButtonBarModeConverter()
			{
				this.a.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum.IconMode, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ButtonBarMode_IconMode);
				this.a.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum.TextMode, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ButtonBarMode_TextMode);
			}

			// Token: 0x06000032 RID: 50 RVA: 0x00006AEC File Offset: 0x00004CEC
			public static string GetResouce(global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum mode)
			{
				short num = (short)2046653834;
				short num2 = num;
				num = (short)1386313098;
				switch (num2 == num)
				{
				}
				num = (short)1138950144;
				if (num != 0)
				{
				}
				num = (short)406388736;
				short num3 = num;
				num = (short)1324482561;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.ButtonBarModeConverter.b.a[mode];
			}

			// Token: 0x06000033 RID: 51 RVA: 0x00006BA4 File Offset: 0x00004DA4
			public static global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum GetQueryType(string resouce)
			{
				short num = (short)1040342330;
				short num2 = num;
				num = (short)1461804346;
				switch (num2 == num)
				{
				}
				num = (short)1138688001;
				if (num != 0)
				{
				}
				num = (short)1507328;
				short num3 = num;
				num = (short)114425856;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.ButtonBarModeConverter.a a = new global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.ButtonBarModeConverter.a();
				a.a = resouce;
				return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.ButtonBarModeConverter.b.a.FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum, string>, bool>(a.b)).Key;
			}

			// Token: 0x06000034 RID: 52 RVA: 0x00006C80 File Offset: 0x00004E80
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonBarModeConverter()
			{
				short num = (short)674847120;
				short num2 = num;
				num = (short)831478160;
				switch (num2 == num)
				{
				}
				num = (short)180158464;
				if (num != 0)
				{
				}
				num = (short)1491468288;
				short num3 = num;
				num = (short)993001473;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.ButtonBarModeConverter.b = new global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.ButtonBarModeConverter();
			}

			// Token: 0x0400000D RID: 13
			private global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum, string> a = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum, string>();

			// Token: 0x0400000E RID: 14
			private static global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.ButtonBarModeConverter b;

			// Token: 0x0200000E RID: 14
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private sealed class a
			{
				// Token: 0x06000036 RID: 54 RVA: 0x00006D48 File Offset: 0x00004F48
				internal bool b(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum, string> A_0)
				{
					short num = (short)2137806742;
					short num2 = num;
					num = (short)1172526998;
					switch (num2 == num)
					{
					}
					num = (short)1297547265;
					if (num != 0)
					{
					}
					num = (short)713883648;
					short num3 = num;
					num = (short)370540544;
					if (num != 0)
					{
					}
					return string.Equals(A_0.Value, this.a, global::System.StringComparison.OrdinalIgnoreCase);
				}

				// Token: 0x0400000F RID: 15
				public string a;
			}
		}

		// Token: 0x0200000F RID: 15
		public class DataMiningOperatorConverter
		{
			// Token: 0x06000037 RID: 55 RVA: 0x00006E04 File Offset: 0x00005004
			private DataMiningOperatorConverter()
			{
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.LessThan, global::Motorola.CommonCPS.ResourceRepository.Resources.Operator_LessThan);
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.LessEqual, global::Motorola.CommonCPS.ResourceRepository.Resources.Operator_LessEqual);
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.Equal, global::Motorola.CommonCPS.ResourceRepository.Resources.Operator_Equal);
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.MoreEqual, global::Motorola.CommonCPS.ResourceRepository.Resources.Operator_MoreEqual);
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.MoreThan, global::Motorola.CommonCPS.ResourceRepository.Resources.Operator_MoreThan);
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.Unequal, global::Motorola.CommonCPS.ResourceRepository.Resources.Operator_Unequal);
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.Contains, global::Motorola.CommonCPS.ResourceRepository.Resources.Operator_Contains);
				this.a.Add(global::Motorola.CommonCPS.Server.CommonDBConstants.Operator.NotContains, global::Motorola.CommonCPS.ResourceRepository.Resources.Operator_NotContains);
			}

			// Token: 0x06000038 RID: 56 RVA: 0x00006EAC File Offset: 0x000050AC
			public static string GetResouce(global::Motorola.CommonCPS.Server.CommonDBConstants.Operator dataMiningOperator)
			{
				short num = (short)390660097;
				if (num != 0)
				{
				}
				num = (short)1538498512;
				short num2 = num;
				num = (short)17014736;
				switch (num2 == num)
				{
				}
				num = (short)2135425024;
				short num3 = num;
				num = (short)1892876288;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningOperatorConverter.b.a[dataMiningOperator];
			}

			// Token: 0x06000039 RID: 57 RVA: 0x00006F64 File Offset: 0x00005164
			public static global::Motorola.CommonCPS.Server.CommonDBConstants.Operator GetOperator(string resouce)
			{
				short num = (short)550771524;
				short num2 = num;
				num = (short)1654725444;
				switch (num2 == num)
				{
				}
				num = (short)905576449;
				if (num != 0)
				{
				}
				num = (short)1398013952;
				short num3 = num;
				num = (short)879230976;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningOperatorConverter.a a = new global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningOperatorConverter.a();
				a.a = resouce;
				return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningOperatorConverter.b.a.FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.Operator, string>, bool>(a.b)).Key;
			}

			// Token: 0x0600003A RID: 58 RVA: 0x0000703C File Offset: 0x0000523C
			// Note: this type is marked as 'beforefieldinit'.
			static DataMiningOperatorConverter()
			{
				short num = (short)809225402;
				short num2 = num;
				num = (short)1786039482;
				switch (num2 == num)
				{
				}
				num = (short)351207425;
				if (num != 0)
				{
				}
				num = (short)1147666432;
				short num3 = num;
				num = (short)987168768;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningOperatorConverter.b = new global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningOperatorConverter();
			}

			// Token: 0x04000010 RID: 16
			private readonly global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.Operator, string> a = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.Operator, string>();

			// Token: 0x04000011 RID: 17
			private static global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningOperatorConverter b;

			// Token: 0x02000010 RID: 16
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private sealed class a
			{
				// Token: 0x0600003C RID: 60 RVA: 0x00007100 File Offset: 0x00005300
				internal bool b(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.Operator, string> A_0)
				{
					short num = (short)1016970209;
					short num2 = num;
					num = (short)522435553;
					switch (num2 == num)
					{
					}
					num = (short)846987265;
					if (num != 0)
					{
					}
					num = (short)201195520;
					short num3 = num;
					num = (short)1899429888;
					if (num != 0)
					{
					}
					return string.Equals(A_0.Value, this.a, global::System.StringComparison.OrdinalIgnoreCase);
				}

				// Token: 0x04000012 RID: 18
				public string a;
			}
		}
	}
}
