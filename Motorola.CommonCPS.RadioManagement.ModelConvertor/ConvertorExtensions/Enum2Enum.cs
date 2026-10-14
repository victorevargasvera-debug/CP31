using System;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.ConvertorExtensions
{
	// Token: 0x02000005 RID: 5
	public static class Enum2Enum
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000263C File Offset: 0x0000083C
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? ConverterServerJobStatusToUiJobStatus(global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus, global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType? jobType)
		{
			short num = (short)1859387392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_122;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? result;
				for (;;)
				{
					IL_27:
					global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus2;
					global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus cruncherStatus3;
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						return result;
					case 2:
						return result;
					case 3:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobType? jobType2 = jobType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType3 = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read;
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?((jobType2.GetValueOrDefault() == jobType3 & jobType2 != null) ? global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Running_Read : global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Running_Write);
						num = (short)1757872181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (jobStatus != null)
						{
							num = (short)1691222055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
						return result;
					case 6:
						num = (short)390987779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return result;
					case 8:
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.RunningWaitingForDP);
						num = (short)808714295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Scheduled);
						num = (short)270794786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus valueOrDefault;
						switch (valueOrDefault)
						{
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PENDING:
							cruncherStatus2 = cruncherStatus;
							cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.NONE;
							num = (short)1820459026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_RUNNING:
							cruncherStatus2 = cruncherStatus;
							cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.NONE;
							num = (short)1477771323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PERFORMED:
							cruncherStatus2 = cruncherStatus;
							cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.AWAITING_SWITCH_OVER;
							num = (short)988676136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_FAILED:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Failed);
							num = (short)734265360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_EXPIRED:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Expired);
							num = (short)528154651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CANCELED:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Canceled);
							num = (short)401997857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CREATED:
							cruncherStatus2 = cruncherStatus;
							cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.AWAITING_PRE_CHECK;
							num = (short)49348620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_SCHEDULED:
							cruncherStatus2 = cruncherStatus;
							cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.NONE;
							num = (short)93519873;
							if (num != 0)
							{
							}
							num = (short)170786867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred);
							num = (short)1622802445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_10:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_10);
							num = (short)151453721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_20:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_20);
							num = (short)183369749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_30:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_30);
							num = (short)983826439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_40:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_40);
							num = (short)1093730324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_50:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_50);
							num = (short)833945638;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_60:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_60);
							num = (short)1507590192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_70:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_70);
							num = (short)1442119734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_80:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_80);
							num = (short)1262485505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_90:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_90);
							num = (short)1334837276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_TRANSFERRED_99:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Transferred_99);
							num = (short)68485139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_CODEPLUG_DOWNLOADED:
						{
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.RunningCodeplugDownloaded);
							num = (short)1676293837;
							short num3 = num;
							num = (short)1934309069;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_434;
							default:
								num = (short)527958016;
								if (num != 0)
								{
								}
								num = (short)1919615005;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus.JOB_STATUS_PACKAGE_DOWNLOADED:
							result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.PackageDownloaded);
							num = (short)35127353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)768671802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Performed);
						num = (short)1745616896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null)
						{
							num = (short)272760874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						cruncherStatus2 = cruncherStatus;
						cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.PRE_CHECKING;
						num = (short)1700266040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						return result;
					case 14:
						if (cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null)
						{
							num = (short)612761646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 15:
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.ScheduledProcessingJob);
						num = (short)411303983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return result;
					case 17:
						return result;
					case 18:
						if (cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null)
						{
							num = (short)1608187927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						cruncherStatus2 = cruncherStatus;
						cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.AWAITING_SWITCH_OVER;
						num = (short)931987506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						return result;
					case 20:
						return result;
					case 21:
						return result;
					case 22:
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Scheduled);
						num = (short)399638530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.RunningWaitingForDP);
						num = (short)385941547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						return result;
					case 25:
						return result;
					case 26:
						return result;
					case 27:
						return result;
					case 28:
						return result;
					case 29:
						return result;
					case 30:
						if (jobStatus != null)
						{
							num = (short)585629733;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 31:
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Scheduled);
						num = (short)1974599685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null)
						{
							num = (short)716963862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						cruncherStatus2 = cruncherStatus;
						cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.AWAITING_PRE_CHECK;
						num = (short)1338048557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						return result;
					case 34:
						return result;
					case 35:
						return result;
					case 36:
						if (cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null)
						{
							num = (short)1898381327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						cruncherStatus2 = cruncherStatus;
						cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.AWAITING_SWITCH_OVER;
						num = (short)1448149024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)1074135044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						return result;
					case 39:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus valueOrDefault = jobStatus.GetValueOrDefault();
						num = (short)1799684106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						if (cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null)
						{
							num = (short)1113260043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Completed);
						num = (short)468975633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						return result;
					case 42:
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.RunningWaitingForJP);
						num = (short)1485963316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						return result;
					case 44:
						if (cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null)
						{
							num = (short)798949425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						cruncherStatus2 = cruncherStatus;
						cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.POPULATING;
						num = (short)559874062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null)
						{
							num = (short)1410924553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 46:
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.RunningProcessingJob);
						num = (short)823525400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						return result;
					case 48:
						return result;
					case 49:
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.WaitingForJP);
						num = (short)960954409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null)
						{
							num = (short)446103560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 51:
						if (cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null)
						{
							num = (short)1337655327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						cruncherStatus2 = cruncherStatus;
						cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.PRE_CHECKING;
						num = (short)32768036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						return result;
					case 53:
						return result;
					case 54:
						return result;
					case 55:
						return result;
					case 56:
					{
						num = (short)195624960;
						short num4 = num;
						if (cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null)
						{
							num = (short)900530236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 57:
						return result;
					case 58:
						num = (short)699007002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						goto IL_434;
					case 60:
						result = new global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?(global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.RunningProcessingJob);
						num = (short)745078819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_122;
					IL_434:
					if (cruncherStatus2.GetValueOrDefault() == cruncherStatus3 & cruncherStatus2 != null)
					{
						num = (short)705822726;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						cruncherStatus2 = cruncherStatus;
						cruncherStatus3 = global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus.AWAITING_POPULATION;
						num = (short)70123564;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return result;
				IL_122:
				result = null;
				num = (short)661061662;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000031A0 File Offset: 0x000013A0
		public static int ConvertTransportToConnectionMethod(this global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transPort, global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_AD;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_13:
				int? productFamily;
				switch (num)
				{
				case 0:
					goto IL_364;
				case 1:
					if (productFamily.Value != 1024)
					{
						num2 = (short)1449000988;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20B;
				case 2:
					goto IL_2E0;
				case 3:
					if (productFamily.Value == 2048)
					{
						num2 = (short)435748872;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3AB;
				case 4:
					if (radio.IPProgramSystem is global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystemLE)
					{
						num2 = (short)2092695573;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1910439970;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (productFamily.Value != 1024)
					{
						num2 = (short)1710620691;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_175;
				case 6:
					if (num3 == 0)
					{
						num2 = (short)1294336010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return num3;
				case 7:
					if (productFamily != null)
					{
						num2 = (short)163250191;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3 = 16;
					num2 = (short)1980694544;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_175;
				case 9:
					goto IL_1AC;
				case 10:
					goto IL_3E0;
				case 11:
					goto IL_3AB;
				case 12:
				{
					num2 = (short)1174863872;
					short num4 = num2;
					productFamily = radio.ProductFamily;
					num2 = (short)3276801;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
					productFamily = radio.ProductFamily;
					num2 = (short)418316315;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (radio.IPProgramSystem == null)
					{
						num2 = (short)628293649;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1187119108;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					productFamily = radio.ProductFamily;
					num2 = (short)1275723798;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_3AB;
				case 17:
					goto IL_35F;
				case 18:
					if (productFamily.Value == 2048)
					{
						num2 = (short)1115619348;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3 = 16;
					num2 = (short)979238923;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
				{
					num2 = (short)1267316298;
					short num5 = num2;
					num2 = (short)2126558794;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_364;
					default:
						num2 = (short)1861877760;
						if (num2 != 0)
						{
						}
						productFamily = radio.ProductFamily;
						num2 = (short)1121386499;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 20:
					goto IL_20B;
				case 21:
					num3 = 4;
					num2 = (short)167575581;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (productFamily.Value != 512)
					{
						num2 = (short)286326796;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20B;
				case 23:
					productFamily = radio.ProductFamily;
					num2 = (short)1452015647;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					num2 = (short)52559874;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					goto IL_276;
				case 26:
					if (radio.IPProgramSystem is global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystemOther)
					{
						num2 = (short)5701655;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 27:
					if (productFamily.Value != 512)
					{
						num2 = (short)784007198;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_175;
				case 28:
					productFamily = radio.ProductFamily;
					num2 = (short)1161101330;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					goto IL_3AB;
				case 30:
					productFamily = radio.ProductFamily;
					num2 = (short)109117445;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (productFamily != null)
					{
						num2 = (short)1051197453;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3AB;
				case 32:
					return num3;
				case 33:
					goto IL_3AB;
				case 34:
					num2 = (short)1799749633;
					if (num2 != 0)
					{
					}
					if (radio.IPProgramSystem is global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystemDMR3)
					{
						num2 = (short)1178664960;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1549139994;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					switch (transPort)
					{
					case global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.Wired:
						num3 = 1;
						num2 = (short)2018115593;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.OTA:
						num3 = 2;
						num2 = (short)109445152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.WiredOrOTA:
						num3 = 3;
						num2 = (short)734920729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.RRP:
						num2 = (short)422248462;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)1333067800;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 36:
					goto IL_3AB;
				}
				goto IL_AD;
				IL_175:
				num3 = 8;
				num2 = (short)1113325601;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_20B:
				num3 = 8;
				num2 = (short)1733361700;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_364:
				productFamily = radio.ProductFamily;
				num2 = (short)1058799623;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3AB:
				num2 = (short)1347485702;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1AC:
			return num3;
			IL_249:
			throw new global::System.NotSupportedException(global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.b("僿瀁欃瀅愇渉椋樍』嬑䐓㘕䠗栙猛礝刟䌡䤣إ嬧匩弫娭唯弱ᐳ張䬷ᨹ刻儽㐿扁㝃㍅㡇㩉⍋㱍⑏㝑こ硕", a_));
			IL_276:
			IL_2E0:
			return num3;
			IL_35F:
			throw new global::System.InvalidOperationException(global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.b("勿倁吃★簇砉洋怍挏我笓搕気㨙減笝償圡䴣吥䴧天ఫ伭帯ሱ紳昵ᠷ䨹主儽✿ぁ╃⭅桇㥉㕋㵍⑏", a_));
			IL_3E0:
			throw new global::System.InvalidOperationException(global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Extensions.b("仿洁␃攅朇搉戋欍猏昑紓礕瘗㨙焛笝吟䨡䬣䈥ࠧ䰩䌫嬭帯嘱ᐳ倵圷䠹᰻䨽㈿⍁⩃㕅㡇╉㹋㩍灏㍑㩓㉕硗⡙㵛㩝य़ൡ䩣", a_));
			IL_AD:
			num3 = 0;
			num2 = (short)187760675;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00003824 File Offset: 0x00001A24
		public static global::Motorola.CommonCPS.Server.CommonDBConstants.JobType ConverterUiJobTypeToServerJobType(global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType uiJobType, bool isNoSwtchover)
		{
			short num = (short)791412747;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.CommonDBConstants.JobType result;
			for (;;)
			{
				global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType;
				switch (num2)
				{
				case 0:
					return result;
				case 1:
					jobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteWithSwitchover;
					goto IL_1B8;
				case 2:
					return result;
				case 3:
					num = (short)2019753985;
					if (num != 0)
					{
					}
					result = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read;
					num = (short)485687303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return result;
				case 5:
					goto IL_A5;
				case 6:
					return result;
				case 7:
					return result;
				case 8:
					num = (short)1766195201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)606666755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (!isNoSwtchover)
					{
						num = (short)647102472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)136249356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 12:
					jobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteNoSwitchover;
					goto IL_1B8;
				}
				IL_58:
				switch (uiJobType)
				{
				case global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Read:
				{
					num = (short)1717786288;
					short num3 = num;
					num = (short)791566000;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1560281088;
						if (num != 0)
						{
						}
						result = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read;
						num = (short)865271812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Switchover:
					result = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Switchover;
					break;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.Write:
					num = (short)1264910346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.FactoryReset:
					result = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.FactoryReset;
					num = (short)2079850501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case global::Motorola.CommonCPS.RadioManagement.UIModels.ScheduledJobType.PasswordReset:
					result = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.ResetPassword;
					num = (short)715259904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)1845690377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1232338950;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B8:
				result = jobType;
				num = (short)66846722;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A5:
			num = (short)875888640;
			short num4 = num;
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00003A98 File Offset: 0x00001C98
		public static global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption ConverterUIReadyJobtOptionToServerReadyJobtOption(bool generateTemplateOrConfig, bool applyToRadio)
		{
			short num = (short)946222841;
			short num2 = num;
			num = (short)902641401;
			switch (num2 == num)
			{
			}
			num = (short)1893269504;
			if (num != 0)
			{
			}
			num = (short)124387329;
			if (num != 0)
			{
			}
			num = (short)921698304;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.GetServerReadyJobtOption(generateTemplateOrConfig, applyToRadio);
		}
	}
}
