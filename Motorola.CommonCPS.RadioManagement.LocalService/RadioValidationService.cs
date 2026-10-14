using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000056 RID: 86
	public abstract class RadioValidationService : global::Motorola.CommonCPS.RadioManagement.LocalService.IRadioValidationService
	{
		// Token: 0x0600031C RID: 796 RVA: 0x0004DE58 File Offset: 0x0004C058
		public RadioValidationService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer serviceContainer)
		{
			this._serviceContainer = serviceContainer;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0004DE74 File Offset: 0x0004C074
		public virtual void ValidateDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isWriteProtected, bool isGeneratingConfig, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP, out int supportedConnections, out global::Motorola.CommonCPS.Server.CommonDBConstants.JobType correctedJobType)
		{
			short num = (short)723517440;
			short num2 = num;
			num = (short)318439844;
			short num3 = num;
			num = (short)676004260;
			switch (num3 == num)
			{
			}
			num = (short)1700200449;
			if (num != 0)
			{
			}
			num = (short)1838546944;
			if (num != 0)
			{
			}
			this.ValidateDevice(radio, type, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, transport, isWriteProtected, isGeneratingConfig, out updatedCP, out supportedConnections);
			correctedJobType = type;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0004DF34 File Offset: 0x0004C134
		public virtual void ValidateDevice(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isWriteProtected, bool isGeneratingConfig, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP, out int supportedConnections)
		{
			int a_ = 17;
			short num = (short)896270336;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase uivalidateService;
				global::System.Collections.Generic.Dictionary<string, string> dictionary;
				global::System.Collections.Generic.Dictionary<string, string>.Enumerator enumerator2;
				string text;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
						long dvrshashCode = apxtemplate.DVRSHashCode;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator = apxtemplate.ASTRODVRSFiles.GetEnumerator();
						num = (short)2129788929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)714342407;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_468;
								case 1:
									goto IL_485;
								case 2:
									num = (short)2108686349;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)2066743297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
									long dvrshashCode;
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles;
									if (!uivalidateService.FoundInvalidDVRS(new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto(astrodvrsfiles, apxtemplate.Name), dvrshashCode))
									{
										num = (short)1306394630;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_321;
								}
								case 5:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
									if (apxtemplate.ModelNumber != null)
									{
										num = (short)1653604354;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_2E5;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_246;
									}
									continue;
								case 8:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2135949315;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles = enumerator.Current;
									global::System.Guid uuid = astrodvrsfiles.Uuid;
									num = (short)351862789;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles;
									if (!this.a(astrodvrsfiles))
									{
										num = (short)941424640;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									num = (short)1658126345;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									bool value;
									if (value)
									{
										num = (short)1865351178;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									num = (short)1515323396;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
								{
									bool value;
									if (value)
									{
										num = (short)230817804;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2E5;
								}
								case 14:
								{
									bool value;
									if (!value)
									{
										num = (short)1091502095;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)722141195;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									goto IL_31F;
								}
								goto IL_246;
								IL_2E5:
								num = (short)187564046;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_348:
								num = (short)1609367560;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_246:
								goto IL_348;
							}
							IL_31F:
							IL_321:
							throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Invalid_Field_Value, new string[]
							{
								global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("漪第紮戰ጲ猴帶唸帺", a_)
							}));
							IL_468:
							throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DVRS_File_Version_Not_Allowed, new string[]
							{
								global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("漪第紮戰ጲ猴帶唸帺", a_)
							}));
							IL_485:
							goto IL_739;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_498;
					case 2:
						goto IL_498;
					case 3:
						num = (short)1465188360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)1287979009;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
						if (apxtemplate.ASTRODVRSFiles.Any<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>())
						{
							num = (short)1106903040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_739;
					}
					case 5:
						if (radio.RadioStatus != 0)
						{
							num = (short)10092547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_739;
					case 6:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
						bool? dvrshardwareEnable = apxtemplate.DVRSHardwareEnable;
						num = (short)1711276043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						if (!uivalidateService.ValidateAllRadioFields(radio, dictionary))
						{
							num = (short)868876297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate = radio.WorkingCodeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate;
						num = (short)624099340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (type != global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read)
						{
							num = (short)323616770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_739;
					case 9:
						enumerator2 = dictionary.GetEnumerator();
						num = (short)1630863373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)176291840;
						short num3 = num;
						global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
						bool? dvrshardwareEnable = apxtemplate.DVRSHardwareEnable;
						bool value = dvrshardwareEnable.Value;
						num = (short)591462404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						bool? dvrshardwareEnable;
						if (dvrshardwareEnable != null)
						{
							num = (short)720502794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_739;
					}
					case 12:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
						if (apxtemplate != null)
						{
							num = (short)98828294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_739;
					}
					case 13:
						goto IL_1DB;
					}
					goto IL_6F;
					IL_498:
					text = string.Empty;
					num = (short)123207687;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DB:
				try
				{
					num = (short)2111176704;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_605;
							}
							continue;
						case 1:
							goto IL_626;
						case 2:
							num = (short)531365891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							num = (short)860479929;
							short num4 = num;
							num = (short)6414777;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_626;
							default:
								goto IL_70F;
							}
							break;
						}
						case 4:
							if (!enumerator2.MoveNext())
							{
								num = (short)361037826;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							keyValuePair = enumerator2.Current;
							num = (short)1502478337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							text = text + keyValuePair.Key + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ܪ", a_);
							num = (short)1292369926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_605;
						IL_626:
						if (!string.IsNullOrEmpty(keyValuePair.Key))
						{
							num = (short)1035862021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_681:
						num = (short)1839464452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_605:
						goto IL_681;
					}
					IL_70F:
					num = (short)284098560;
					if (num != 0)
					{
					}
					goto IL_599;
				}
				finally
				{
					((global::System.IDisposable)enumerator2).Dispose();
				}
				goto IL_739;
				IL_599:
				text = text.Substring(0, text.Length - 1);
				throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Invalid_Field_Value, new string[]
				{
					text
				}));
				IL_739:
				this.ValidateAnyJob(radio, type, transport, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, isWriteProtected, out updatedCP, out supportedConnections);
				this.RefreshLastProgrammedDate(updatedCP);
				return;
				IL_6F:
				supportedConnections = 0;
				uivalidateService = global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance.UIValidateService;
				updatedCP = null;
				dictionary = new global::System.Collections.Generic.Dictionary<string, string>();
				num = (short)1033109509;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0004E6CC File Offset: 0x0004C8CC
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles A_0)
		{
			short num = (short)1418330112;
			short num2 = num;
			num = (short)294716810;
			short num3 = num;
			num = (short)1078330762;
			switch (num3 == num)
			{
			}
			num = (short)2032861185;
			if (num != 0)
			{
			}
			num = (short)767295488;
			if (num != 0)
			{
			}
			return int.Parse(A_0.PackageVersion) >= 2;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0004E788 File Offset: 0x0004C988
		public void RefreshLastProgrammedDate(global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP)
		{
			for (;;)
			{
				IL_00:
				short num = (short)136577025;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_106;
					case 1:
					{
						num = (short)705973421;
						short num3 = num;
						num = (short)1749830829;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1896284160;
							short num4 = num;
							num = (short)671154176;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A9;
							}
							continue;
						}
						}
						break;
					}
					case 2:
						updatedCP = new global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest();
						num = (short)1636696064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A9:
					num = (short)725352449;
					if (num != 0)
					{
					}
					if (updatedCP != null)
					{
						goto IL_108;
					}
					num = (short)1590689794;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_106:
			IL_108:
			global::System.DateTime now = global::System.DateTime.Now;
			global::System.DateTime dateTime = new global::System.DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, 0);
			updatedCP.LastProgrammedDate = new global::System.DateTime?(dateTime.ToUniversalTime());
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0004E8E0 File Offset: 0x0004CAE0
		protected virtual void ValidateAnyJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, bool isWriteProtected, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest fieldsShallBeUpdated, out int supportedConnections)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_122;
				case 1:
					if (fieldsShallBeUpdated == null)
					{
						num2 = (short)1689321474;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_124;
				case 2:
					fieldsShallBeUpdated = new global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest();
					num2 = (short)1749221376;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_122:
			IL_124:
			this.ExtraValidation(radio, type, transport, fieldsShallBeUpdated);
			this.ValidateChangeIndicator(radio, type, transport, isRestoreJob);
			supportedConnections = transport.ConvertTransportToConnectionMethod(radio);
			return;
			IL_1C:
			num2 = (short)1183907841;
			if (num2 != 0)
			{
			}
			num2 = (short)1065025146;
			short num3 = num2;
			num2 = (short)2142764666;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)1942552576;
				short num4 = num2;
				num2 = (short)1931149312;
				if (num2 != 0)
				{
				}
				this.ValidateStatus(radio, type, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, transport, isWriteProtected, out fieldsShallBeUpdated);
				num2 = (short)537657345;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0004EA34 File Offset: 0x0004CC34
		protected void ValidateStatus(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isWriteProtected, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP)
		{
			short num = (short)1375993856;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_81;
			}
			int num3;
			global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase uivalidateService;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					num = (short)1423245313;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (!uivalidateService.IsRadioSwitchoverRequired(new global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus?(radio.LastJob.JobStatus), new global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus?(radio.LastJob.CruncherStatus)))
					{
						num = (short)2065039377;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)13762568;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1064697860;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (radio.RadioStatus == 0)
					{
						num = (short)573898768;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1487732748;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (type != global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteNoSwitchover)
					{
						num = (short)1663041545;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_238;
				case 6:
					if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Switchover)
					{
						num = (short)1765081101;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					if (radio.LastJob != null)
					{
						num = (short)115408898;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AE;
				case 8:
					if (radio.LastJob != null)
					{
						num = (short)1812660224;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 9:
					num = (short)1307770894;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (!isRestoreJob)
					{
						num = (short)1443364867;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_111;
				case 11:
					goto IL_238;
				case 12:
					if (!this.HasRequiredConfig_For_WriteJob(radio))
					{
						num = (short)1256849423;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_111;
				case 13:
					num = (short)629538823;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (type == global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.WriteWithSwitchover)
					{
						num = (short)6291467;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1720057862;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_2F4;
				case 16:
					goto IL_1D5;
				case 17:
					goto IL_236;
				}
				goto IL_81;
				IL_238:
				num = (short)39780362;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_111:
			num = (short)64639336;
			short num4 = num;
			num = (short)175526248;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_236:
				goto IL_2AE;
			default:
				num = (short)353239040;
				if (num != 0)
				{
				}
				num = (short)2070347777;
				if (num != 0)
				{
				}
				this.ValidateCodeplugVersion(radio);
				this.ValidateWritingJob(radio, transport, isRestoreJob, restoreJob_PbaCanNotBeDirectlyModified, isWriteProtected, out updatedCP);
				return;
			}
			IL_1D5:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidRadiosForAstroWriteTips);
			IL_2AE:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidRadiosForSwitchoverTips);
			IL_2F4:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.MustHaveConfigurationForWriteJob);
			IL_81:
			uivalidateService = global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance.UIValidateService;
			updatedCP = null;
			this.ValidateForeignIP(radio, transport);
			num = (short)963706885;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0004EDC4 File Offset: 0x0004CFC4
		protected virtual void ValidateForeignIP(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport)
		{
			short num = (short)165347328;
			short num2 = num;
			num = (short)1919744578;
			short num3 = num;
			num = (short)581368386;
			switch (num3 == num)
			{
			}
			num = (short)1335099392;
			if (num != 0)
			{
			}
			num = (short)2144272385;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000324 RID: 804
		protected abstract bool HasRequiredConfig_For_WriteJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio);

		// Token: 0x06000325 RID: 805 RVA: 0x0004EE6C File Offset: 0x0004D06C
		protected virtual void ValidateCodeplugVersion(global::Motorola.CommonCPS.Server.EntityModel.Radio radio)
		{
			short num = (short)1172701184;
			short num2 = num;
			num = (short)1191266096;
			short num3 = num;
			num = (short)1063208752;
			switch (num3 == num)
			{
			}
			num = (short)1162018817;
			if (num != 0)
			{
			}
			num = (short)1061093376;
			if (num != 0)
			{
			}
			this._serviceContainer.DeviceOperation.ValidateCodeplugVersion(radio);
		}

		// Token: 0x06000326 RID: 806
		protected abstract void ValidateWritingJob(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, bool isWriteProtected, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP);

		// Token: 0x06000327 RID: 807
		protected abstract void ExtraValidation(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest fieldsShallBeUpdated);

		// Token: 0x06000328 RID: 808
		protected abstract void ValidateChangeIndicator(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType type, global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference transport, bool isRestoreJob);

		// Token: 0x06000329 RID: 809 RVA: 0x0004EF28 File Offset: 0x0004D128
		protected bool IsChangeIndicatorOn(global::Motorola.CommonCPS.Server.EntityModel.Codeplug codeplug, global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeIndicator changeBit)
		{
			short num = (short)1526661120;
			short num2 = num;
			num = (short)1955682466;
			short num3 = num;
			num = (short)1730500770;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1622802433;
				if (num != 0)
				{
				}
				num = (short)1140326400;
				if (num != 0)
				{
				}
				if (codeplug.ChangeIndicator == null)
				{
					return false;
				}
				break;
			}
			return (codeplug.ChangeIndicator.Value & (int)changeBit) == (int)changeBit;
		}

		// Token: 0x04000089 RID: 137
		protected global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer _serviceContainer;
	}
}
