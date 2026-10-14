using System;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Operation.RadioConversion
{
	// Token: 0x02000009 RID: 9
	public class TemplateConversionSequence : global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.AbstractConversionSequence, global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.ITemplateConversionSequence
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00003C54 File Offset: 0x00001E54
		public TemplateConversionSequence()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003C68 File Offset: 0x00001E68
		public TemplateConversionSequence(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.IMigrationOpUtility migrationOpUtility) : base(serverAccessor, migrationOpUtility)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003C80 File Offset: 0x00001E80
		public global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary ConvertTemplate(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase template, global::System.Guid? jobContainerGuid)
		{
			short num = (short)375521280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				global::System.Guid? guid;
				global::Motorola.CommonCPS.Server.EntityModel.ConvertTRadioInfo convertTRadioFileInfo;
				string configurationBaseName;
				global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
				global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration;
				global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_3B4;
					case 1:
						goto IL_DE;
					case 2:
						goto IL_268;
					case 3:
						if (guid == null)
						{
							num = (short)1139212299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						guid = convertTRadioFileInfo.ConfigurationUuid;
						num = (short)1097072648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						configurationBaseName = template.Name;
						radio = global::Motorola.CommonCPS.RadioManagement.Operation.RadioConversion.MigrationOpUtility.Instance.CreateConversionRadioByArchiveFile(convertTRadioFileInfo);
						num = (short)1458831369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)2011119586;
						short num3 = num;
						num = (short)1352876002;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D8;
						default:
							num = (short)1268842496;
							if (num != 0)
							{
							}
							if (radio != null)
							{
								num = (short)1124270090;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21E;
						}
						break;
					}
					case 6:
						if (convertTRadioFileInfo == null)
						{
							num = (short)509214721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						guid = convertTRadioFileInfo.ArchiveFileUuid;
						num = (short)1314914305;
						if (num != 0)
						{
						}
						num = (short)1306525699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (radio.WorkingCodeplug != null)
						{
							num = (short)364380172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					case 8:
						if (guid == null)
						{
							goto IL_1D8;
						}
						goto IL_1F5;
					case 9:
						num = (short)814350341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)915210247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)1726676992;
						short num4 = num;
						num = (short)2141257728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						configuration = radio.WorkingCodeplug.Configuration;
						configuration.ConfigurationBaseName = configurationBaseName;
						configuration.Comment = template.Comments;
						num = (short)1311047693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_21E;
					}
					goto IL_66;
					IL_1D8:
					num = (short)476053508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21E:
					validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
					guid = template.ID;
					global::Motorola.CommonCPS.Server.EntityModel.ValidatedField item = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField(guid.Value, global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Template, template.TimeStamp);
					validateEntitySet.ValidateEntityList.Add(item);
					num = (short)1169948674;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DE:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.DBMIGRATION_TEMPLATE_CONVERSION_INFO_MISSING);
				IL_1F5:
				throw new global::Motorola.Common.CustomException.CommonException(new global::Motorola.Common.CustomException.CommonExceptionData(global::Motorola.Common.CustomException.CommonErrorCode.CONFIGURATION_ALREADY_CONVERT_BEFORE, new string[]
				{
					template.Name,
					convertTRadioFileInfo.ConfigurationName
				}));
				IL_268:
				global::Motorola.CommonCPS.Server.EntityModel.ImportCFGFromTemplateOpJobParameter importCFGFromTemplateOpJobParameter = new global::Motorola.CommonCPS.Server.EntityModel.ImportCFGFromTemplateOpJobParameter();
				guid = jobContainerGuid;
				importCFGFromTemplateOpJobParameter.BatchJobContainerUuid = (guid ?? global::System.Guid.Empty);
				importCFGFromTemplateOpJobParameter.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.TemplateConversion;
				importCFGFromTemplateOpJobParameter.JobDescription = template.Name;
				importCFGFromTemplateOpJobParameter.Configuration = configuration;
				importCFGFromTemplateOpJobParameter.ValidateEntitySets = validateEntitySet;
				importCFGFromTemplateOpJobParameter.TemplateName = template.Name;
				global::Motorola.CommonCPS.Server.EntityModel.ImportCFGFromTemplateOpJobParameter parameter = importCFGFromTemplateOpJobParameter;
				return this._serverAccessor.ImportCFGFromTemplate(parameter);
				IL_3B4:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_TEMPLATE_NOT_FOUND);
				IL_66:
				radio = null;
				configuration = null;
				configurationBaseName = "";
				global::Motorola.CommonCPS.Server.EntityModel.RadioConversionRelationshipParameter parameter2 = new global::Motorola.CommonCPS.Server.EntityModel.RadioConversionRelationshipParameter
				{
					UuidType = global::Motorola.CommonCPS.Server.CommonDBConstants.ProcessType.Template,
					Uuid = template.TemplateID,
					Timestamp = template.TimeStamp
				};
				convertTRadioFileInfo = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetConvertTRadioFileInfo(parameter2);
				num = (short)705298438;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
