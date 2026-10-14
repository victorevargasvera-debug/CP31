using System;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Operation.RadioConversion
{
	// Token: 0x02000008 RID: 8
	public class RadioConversionSequence : global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.AbstractConversionSequence, global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.IRadioConversionSequence
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00003530 File Offset: 0x00001730
		public RadioConversionSequence()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003544 File Offset: 0x00001744
		public RadioConversionSequence(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.IMigrationOpUtility migrationOpUtility) : base(serverAccessor, migrationOpUtility)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000355C File Offset: 0x0000175C
		public global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionResult ConvertRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, global::System.Guid? jobContainerGuid, global::System.Guid? rwJobContainerUuid, global::Motorola.CommonCPS.Server.EntityModel.Radio convertedRadio = null)
		{
			short num = (short)706215936;
			switch (num)
			{
			default:
			{
				num = (short)886046729;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionResult radioConvertionResult;
				for (;;)
				{
					bool flag;
					global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
					switch (num2)
					{
					case 0:
						flag = false;
						goto IL_37C;
					case 1:
					{
						global::System.Guid? guid;
						if (guid == null)
						{
							num = (short)2095513615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)37421070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						flag = true;
						goto IL_37C;
					case 3:
						num = (short)979894272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return radioConvertionResult;
					case 5:
					{
						global::System.Guid? guid = device.WorkingTemplateUuid;
						num = (short)399048720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_150;
					case 7:
					{
						num = (short)1380669794;
						short num3 = num;
						num = (short)59201890;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1592197120;
							if (num != 0)
							{
							}
							convertedRadio = this.a(device);
							break;
						}
						num = (short)848691206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (radioConvertionResult != null)
						{
							num = (short)1814036491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return radioConvertionResult;
					case 9:
						num = (short)1648230401;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B2;
						}
						continue;
					case 10:
					{
						global::System.Guid? guid = device.WorkingTemplateUuid;
						global::System.Guid empty = global::System.Guid.Empty;
						num = (short)485490689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						radioConvertionResult.ConvertedRadio = convertedRadio;
						num = (short)1595539460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionOpJobParameter radioConvertionOpJobParameter = new global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionOpJobParameter();
						global::System.Guid? guid = jobContainerGuid;
						radioConvertionOpJobParameter.BatchJobContainerUuid = (guid ?? global::System.Guid.Empty);
						radioConvertionOpJobParameter.RadioUuid = device.DeviceUuid;
						radioConvertionOpJobParameter.Radio = convertedRadio;
						radioConvertionOpJobParameter.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.RadioConversion;
						radioConvertionOpJobParameter.JobDescription = device.SerialNumber;
						radioConvertionOpJobParameter.ReadWriteJobContainerUuid = rwJobContainerUuid;
						radioConvertionOpJobParameter.ValidateEntitySets = validateEntitySet;
						global::Motorola.CommonCPS.Server.EntityModel.RadioConvertionOpJobParameter parameter = radioConvertionOpJobParameter;
						radioConvertionResult = this._serverAccessor.ConvertRadioFromTModeToCMode(parameter);
						num = (short)1515585544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::System.Guid? guid;
						global::System.Guid empty;
						flag = (guid.GetValueOrDefault() != empty);
						goto IL_37C;
					}
					case 14:
					{
						global::System.Guid? guid;
						if (guid == null)
						{
							num = (short)1750269955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)829947917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)731512834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::System.Guid? guid;
						if (guid != null)
						{
							num = (short)1427111946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_150;
					}
					}
					IL_B2:
					num = (short)1838481408;
					short num4 = num;
					if (convertedRadio == null)
					{
						num = (short)443088901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_150:
					validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
					global::Motorola.CommonCPS.Server.EntityModel.ValidatedField item = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField(device.DeviceUuid, global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio, device.RadioTimestamp);
					validateEntitySet.ValidateEntityList.Add(item);
					num = (short)951910412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37C:
					if (!flag)
					{
						goto IL_150;
					}
					num = (short)776798215;
					num2 = (int)((global::System.IntPtr)num);
				}
				return radioConvertionResult;
			}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003954 File Offset: 0x00001B54
		private global::Motorola.CommonCPS.Server.EntityModel.Radio a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			short num = (short)1883570176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::Motorola.CommonCPS.Server.EntityModel.ConvertTRadioInfo convertTRadioFileInfo;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
						{
							global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
							return radio;
						}
						case 1:
							num = (short)1655111689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::System.Guid? archiveFileUuid;
							if (archiveFileUuid == null)
							{
								num = (short)927924225;
								if (num != 0)
								{
								}
								num = (short)1150025736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string templateName = convertTRadioFileInfo.TemplateName;
							string templateComment = convertTRadioFileInfo.TemplateComment;
							global::Motorola.CommonCPS.Server.EntityModel.Radio radio = this._migrationOpUtility.CreateConversionRadioByArchiveFile(convertTRadioFileInfo);
							num = (short)1321205765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							if (convertTRadioFileInfo == null)
							{
								num = (short)1696071684;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Guid? archiveFileUuid = convertTRadioFileInfo.ArchiveFileUuid;
							num = (short)147259394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_B4;
						case 5:
						{
							global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
							if (radio != null)
							{
								num = (short)1755250689;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return radio;
						}
						case 6:
						{
							global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
							radio.WorkMode = global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Configuration;
							radio.DeviceID = radio.SerialNumber;
							string templateName;
							radio.WorkingCodeplug.Configuration.ConfigurationBaseName = templateName;
							string templateComment;
							radio.WorkingCodeplug.Configuration.Comment = templateComment;
							num = (short)1465581568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							num = (short)682258867;
							short num3 = num;
							num = (short)2095870387;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_80;
							default:
								num = (short)2022506496;
								if (num != 0)
								{
								}
								num = (short)929890314;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							goto IL_20E;
						case 9:
						{
							global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
							if (radio.WorkingCodeplug != null)
							{
								num = (short)1512570887;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return radio;
						}
						case 10:
						{
							global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
							if (radio.WorkingCodeplug.Configuration != null)
							{
								num = (short)1788346368;
								short num4 = num;
								num = (short)310509574;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return radio;
						}
						}
						goto IL_5A;
					}
					IL_B4:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DBMIGRATION_RADIO_CONVERSION_INFO_MISSING);
					IL_20E:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_TEMPLATE_NOT_FOUND);
				}
				IL_5A:
				global::Motorola.CommonCPS.Server.EntityModel.RadioConversionRelationshipParameter parameter = new global::Motorola.CommonCPS.Server.EntityModel.RadioConversionRelationshipParameter
				{
					UuidType = global::Motorola.CommonCPS.Server.CommonDBConstants.ProcessType.Radio,
					Uuid = A_0.DeviceUuid
				};
				convertTRadioFileInfo = this._serverAccessor.GetConvertTRadioFileInfo(parameter);
				IL_80:
				num = (short)2048851971;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
