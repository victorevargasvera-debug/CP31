using System;
using System.Collections.Generic;
using System.ComponentModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Enums;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000AD RID: 173
	public abstract class TemplateServiceBase : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000A47 RID: 2631 RVA: 0x0007B7C4 File Offset: 0x000799C4
		public TemplateServiceBase(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase validationServiceBase) : base(serverAccessor, validationServiceBase)
		{
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0007B7DC File Offset: 0x000799DC
		public global::Motorola.CommonCPS.Server.EntityModel.Template GetTemplateByName(string templateName)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Template> templateListByNameList;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (templateListByNameList.Count > 0)
					{
						num2 = (short)1884028929;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_124;
				case 1:
					goto IL_11F;
				case 2:
					if (templateListByNameList != null)
					{
						num2 = (short)1917714435;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_124;
				case 3:
					num2 = (short)1960706048;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_11F:
			num2 = (short)1036194941;
			short num3 = num2;
			num2 = (short)1608520829;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_124:
				num2 = (short)254738432;
				short num4 = num2;
				return null;
			}
			default:
				num2 = (short)205586433;
				if (num2 != 0)
				{
				}
				num2 = (short)1566900224;
				if (num2 != 0)
				{
				}
				return templateListByNameList[0];
			}
			IL_20:
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(templateName);
			templateListByNameList = base.ServerAccessor.GetTemplateListByNameList(list);
			num2 = (short)1556611074;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0007B93C File Offset: 0x00079B3C
		public void EditTemplate(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase temp, out string error)
		{
			int a_ = 0;
			short num = (short)1442054145;
			int num2 = (int)((global::System.IntPtr)num);
			byte[] fileContent;
			global::Motorola.CommonCPS.Server.EntityModel.Template template;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1AF;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					continue;
				case 2:
					goto IL_100;
				case 3:
					goto IL_1CD;
				case 4:
				{
					num = (short)929417783;
					short num3 = num;
					num = (short)1289800247;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AF;
					default:
						goto IL_9A;
					}
					break;
				}
				case 5:
					if (fileContent != null)
					{
						num = (short)1920663554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D2;
				}
				IL_47:
				if (temp == null)
				{
					num = (short)1129316356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				error = string.Empty;
				template = base.ServerAccessor.GetTemplate(temp.TemplateID, true);
				num = (short)1294991360;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AF:
				if (template == null)
				{
					num = (short)1580072963;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					fileContent = base.ServerAccessor.GetFileContent(template.FileUuid.Value);
					num = (short)1003356165;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_9A:
			num = (short)402915328;
			if (num != 0)
			{
			}
			num = (short)542834689;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException();
			IL_100:
			num = (short)852230144;
			short num4 = num;
			((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).EditTemplateByCPS(fileContent, null, template);
			return;
			IL_1CD:
			error = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎖ﺚ붜쒠캢햤쮦좨\udfaa좬辮\ud9b0튲운鞶\udbb8\udeba\ud8bc톾뇂ꃄ꫆ꛈ뷊꣌ꯎ", a_);
			return;
			IL_1D2:
			error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_EditCodeplug_MissArchive;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0007BB24 File Offset: 0x00079D24
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> GetRadioList(global::System.Collections.Generic.IList<global::System.Guid> radioIdList)
		{
			short num = (short)906481505;
			short num2 = num;
			num = (short)592629601;
			switch (num2 == num)
			{
			}
			num = (short)1361182721;
			if (num != 0)
			{
			}
			num = (short)87818240;
			short num3 = num;
			num = (short)2090991616;
			if (num != 0)
			{
			}
			return base.ServerAccessor.GetRadioList(radioIdList, false);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0007BBDC File Offset: 0x00079DDC
		public bool DeleteTemplate(global::System.Guid batchJobContainer, global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase template)
		{
			short num = (short)1703637519;
			short num2 = num;
			num = (short)1916563983;
			switch (num2 == num)
			{
			}
			num = (short)1893138433;
			if (num != 0)
			{
			}
			num = (short)123666432;
			if (num != 0)
			{
			}
			num = (short)406781952;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet set = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet
			{
				RelatedObject = new global::System.Guid?(template.TemplateID),
				Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Template,
				ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>
				{
					new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField
					{
						Uuid = template.TemplateID,
						Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Template,
						Timestamp = template.TimeStamp
					}
				}
			};
			return base.ServerAccessor.DeleteTemplate(new global::System.Guid?(batchJobContainer), template.TemplateID, set, template.Name);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0007BCF4 File Offset: 0x00079EF4
		public void TryDeleteTemplate(global::System.Guid templateUuid)
		{
			short num;
			try
			{
				num = (short)262115025;
				short num2 = num;
				num = (short)804425425;
				switch (num2 == num)
				{
				}
				num = (short)1619656705;
				if (num != 0)
				{
				}
				num = (short)1615396864;
				if (num != 0)
				{
				}
				((global::System.Collections.Generic.ICollection<global::System.Guid>)new global::System.Collections.Generic.List<global::System.Guid>()).Add(templateUuid);
				base.ServerAccessor.DeleteTemplate(null, templateUuid, null, null);
			}
			catch
			{
			}
			num = (short)1903493120;
			short num3 = num;
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0007BDD4 File Offset: 0x00079FD4
		public global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary SaveTemplate(global::Motorola.CommonCPS.Server.EntityModel.Template temp, byte[] fileContent)
		{
			int a_ = 9;
			short num = (short)1008205826;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)232062976;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					num = (short)525729793;
					if (num != 0)
					{
					}
					num = (short)1816370718;
					short num4 = num;
					num = (short)2010422814;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E;
					default:
						goto IL_128;
					}
					break;
				}
				case 1:
				{
					global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = base.ServerAccessor.AddFileContent(fileContent);
					temp.FileUuid = new global::System.Guid?(rmfile.Uuid);
					num = (short)1298726912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_1E;
				}
				goto IL_62;
				IL_1E:
				switch (0)
				{
				case 0:
					IL_62:
					if (fileContent == null)
					{
						goto IL_7B;
					}
					num = (short)542638081;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_7B:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CannotGetFileContentWhenSelectTemplate, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쎡쪣蚥욧얩\ud8ab躭힯ힱ삳隵\udeb7펹킻\udbbdꇁꯃꣅ볇꿉ꋋ뫍", a_));
			IL_128:
			num = (short)1178337280;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(temp);
			validateEntitySet.ValidateEntityList.Add(validatedField);
			validateEntitySet.RelatedObject = new global::System.Guid?(temp.Uuid);
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Template;
			return base.ServerAccessor.SaveTemplate(temp, validateEntitySet);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0007BF68 File Offset: 0x0007A168
		public global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary EditTemplateFields(global::System.Guid templateID, byte[] timeStamp, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>> fieldValues)
		{
			short num = (short)2071213958;
			short num2 = num;
			num = (short)1925199750;
			switch (num2 == num)
			{
			}
			num = (short)137232384;
			if (num != 0)
			{
			}
			num = (short)222298113;
			if (num != 0)
			{
			}
			num = (short)1642070016;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField = new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField();
			validatedField.Uuid = templateID;
			validatedField.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Template;
			validatedField.Timestamp = timeStamp;
			validateEntitySet.ValidateEntityList.Add(validatedField);
			validateEntitySet.RelatedObject = new global::System.Guid?(templateID);
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Template;
			return base.ServerAccessor.EditTemplate(templateID, fieldValues, validateEntitySet);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0007C068 File Offset: 0x0007A268
		public bool IsTemplateNameChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase template)
		{
			short num = (short)900464644;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1E:
				switch (num2)
				{
				case 0:
					goto IL_197;
				case 1:
					goto IL_1CA;
				case 2:
				{
					global::Motorola.CommonCPS.Server.EntityModel.Template template2 = base.ServerAccessor.GetTemplate(template.TemplateID, false);
					if (template2 == null)
					{
						goto Block_2;
					}
					if (string.Equals(template2.Name, template.Name, global::System.StringComparison.Ordinal))
					{
						num = (short)1025310721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1155465221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					return false;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 5:
					while (string.IsNullOrWhiteSpace(template.Name))
					{
						num = (short)31816662;
						short num3 = num;
						num = (short)2001763286;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)876740608;
							if (num != 0)
							{
							}
							num = (short)763756547;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E;
						}
					}
					return true;
				case 6:
					num = (short)1598947328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_40:
				if (template == null)
				{
					num = (short)2002386950;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)178585602;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			Block_2:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_TemplateNotExist);
			IL_197:
			throw new global::System.ArgumentNullException();
			IL_1CA:
			num = (short)444661760;
			short num4 = num;
			num = (short)1341521921;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0007C248 File Offset: 0x0007A448
		public global::Motorola.CommonCPS.Server.EntityModel.Template ParseTemplateFile(string filePath, string password, bool ignorPwdValidation = false)
		{
			short num = (short)1623135870;
			short num2 = num;
			num = (short)1966151294;
			switch (num2 == num)
			{
			}
			num = (short)543490049;
			if (num != 0)
			{
			}
			num = (short)558628864;
			if (num != 0)
			{
			}
			num = (short)1049034752;
			short num3 = num;
			return ((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).ParseTemplateFile(filePath, password, ignorPwdValidation);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0007C304 File Offset: 0x0007A504
		public global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary ImportToServer(global::System.Guid jobContainerGuid, string filePath, global::Motorola.CommonCPS.Server.EntityModel.Template template)
		{
			short num = (short)1482085276;
			short num2 = num;
			num = (short)1200935836;
			switch (num2 == num)
			{
			}
			num = (short)1852243969;
			if (num != 0)
			{
			}
			num = (short)1967194112;
			if (num != 0)
			{
			}
			num = (short)2133983232;
			short num3 = num;
			template = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation as global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateDeviceOperation).PreImportTemplateToServer(filePath, template);
			this.UpLoadVAFile(template);
			this.UpLoadCACertificateFile(template);
			this.UpLoadDVRSFile(template);
			return base.ServerAccessor.ImportTemplate(jobContainerGuid, template);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0007C3E8 File Offset: 0x0007A5E8
		public virtual void UpLoadVAFile(global::Motorola.CommonCPS.Server.EntityModel.Template temp)
		{
			short num = (short)462106850;
			short num2 = num;
			num = (short)819409122;
			switch (num2 == num)
			{
			}
			num = (short)1962672128;
			if (num != 0)
			{
			}
			num = (short)792985601;
			if (num != 0)
			{
			}
			num = (short)132907008;
			short num3 = num;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0007C490 File Offset: 0x0007A690
		public virtual void UpLoadCACertificateFile(global::Motorola.CommonCPS.Server.EntityModel.Template temp)
		{
			short num = (short)51039902;
			short num2 = num;
			num = (short)975752862;
			switch (num2 == num)
			{
			}
			num = (short)500695041;
			if (num != 0)
			{
			}
			num = (short)1283915776;
			if (num != 0)
			{
			}
			num = (short)867106816;
			short num3 = num;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0007C538 File Offset: 0x0007A738
		public virtual void UpLoadDVRSFile(global::Motorola.CommonCPS.Server.EntityModel.Template temp)
		{
			short num = (short)647102465;
			if (num != 0)
			{
			}
			num = (short)1595102598;
			short num2 = num;
			num = (short)1052202374;
			switch (num2 == num)
			{
			}
			num = (short)1887502336;
			if (num != 0)
			{
			}
			num = (short)1390739456;
			short num3 = num;
		}

		// Token: 0x06000A55 RID: 2645
		public abstract global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> PrepareUploadTemplateAndRadio(global::Motorola.CommonCPS.Server.EntityModel.Template source, global::Motorola.CommonCPS.Server.EntityModel.Radio targetDevice, bool isApply = true);

		// Token: 0x06000A56 RID: 2646
		public abstract bool CloneCheck(global::Motorola.CommonCPS.Server.EntityModel.Template template, global::Motorola.CommonCPS.Server.EntityModel.Radio rd, global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType? cmdType = null);

		// Token: 0x06000A57 RID: 2647 RVA: 0x0007C5E0 File Offset: 0x0007A7E0
		public bool PrecheckForApplyTemplate(global::Motorola.CommonCPS.Server.EntityModel.Template rawTemplate, global::Motorola.CommonCPS.Server.EntityModel.Radio rawRadio, global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType cmdType, global::System.Guid orignalTemplateUuid, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase localDevices, out string error)
		{
			int a_ = 16;
			short num = (short)1333657600;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				bool flag3;
				string text;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1714356232;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									string flashcode;
									bool flag = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroCheckHoptionEnable(flashcode, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("鮪骬馮覰莲", a_), rawRadio.ModelNumber);
									string flashcode2;
									bool flag2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroCheckHoptionEnable(flashcode2, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("鮪骬馮覰莲", a_), rawRadio.ModelNumber);
									if (flag)
									{
										num = (short)1683095561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A18;
								}
								case 1:
								{
									global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = rawRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
									if (apxcodeplug == null)
									{
										goto Block_26;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
									byte[] astroPurchasedFlashCode = apxtemplate.AstroPurchasedFlashCode;
									string flashcode2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroDecodeFlashCode(astroPurchasedFlashCode);
									byte[] astroPurchasedFlashCode2 = apxcodeplug.AstroPurchasedFlashCode;
									string flashcode = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroDecodeFlashCode(astroPurchasedFlashCode2);
									num = (short)2101477376;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus radioStatus;
									if (radioStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.New)
									{
										num = (short)1149239299;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A18;
								}
								case 3:
									num = (short)1443561473;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_A0B;
								case 5:
								{
									bool flag2;
									if (!flag2)
									{
										num = (short)969015300;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A18;
								}
								case 6:
									num = (short)35389442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_A31;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_8A8;
									}
									continue;
								case 9:
									num = (short)331087877;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_8A8:
								if (rawRadio.CurrentCodeplug != null)
								{
									num = (short)165150726;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_A18:
								num = (short)1947271175;
								num2 = (int)((global::System.IntPtr)num);
							}
							Block_26:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
							IL_A0B:
							throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateDirectMessageCommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_CannotApplyTemplateWithMsOTAR_To_ImcompatibleDevice);
							IL_A31:
							goto IL_25B;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							error = ex.ToString();
							return false;
						}
						goto IL_A4A;
						IL_25B:
						flag3 = false;
						text = string.Empty;
						num = (short)13500426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						flag3 = this.PrecheckForSaveTemplate(rawRadio, orignalTemplateUuid, out error);
						num = (short)136642569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)430112770;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								bool flag6;
								int? num3;
								bool flag7;
								int? num5;
								int num6;
								switch (num2)
								{
								case 0:
									goto IL_6CA;
								case 1:
								{
									bool flag4;
									if (!flag4)
									{
										num = (short)1224671236;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6B2;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_407;
									}
									continue;
								case 3:
									num = (short)286261264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									string firmwareVersion = rawRadio.CurrentCodeplug.FirmwareVersion;
									string firmwareVersion2 = rawRadio.WorkingCodeplug.FirmwareVersion;
									global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation templateOperation = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance();
									bool flag5 = templateOperation.CheckAstroUpgradeWithLanugagePackIsSupported(firmwareVersion, firmwareVersion2);
									global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
									flag6 = templateOperation.CheckIsSupportedLanguagePack(rawRadio.WorkingCodeplug.FirmwareVersion, apxtemplate.LanguageIndex);
									string value = templateOperation.AstroDecodeLanguageIndexToLPID(apxtemplate.LanguageIndex);
									num = (short)413270021;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									bool flag5;
									if (!flag5)
									{
										num = (short)388431878;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1655046152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1753874442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									int? num4;
									num3 = num4;
									goto IL_539;
								}
								case 8:
									flag7 = false;
									goto IL_62B;
								case 9:
									goto IL_64B;
								case 10:
								{
									string value;
									flag7 = !string.IsNullOrEmpty(value);
									goto IL_62B;
								}
								case 11:
									if (!(num5.GetValueOrDefault() == num6 & num5 != null))
									{
										num = (short)1071972369;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6B2;
								case 12:
								{
									string radioFirmwareVer = rawRadio.CurrentCodeplug.FirmwareVersion;
									global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
									bool flag4 = global::Motorola.CommonCPS.RadioManagement.SharedServices.AutomaticUpgradeLPUtility.ValidateLanguagePackForApplyTemplateToRadio(apxtemplate, radioFirmwareVer);
									int? num7 = rawRadio.WorkingCodeplug.ChangeIndicator;
									num = (short)467009549;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									int? num7;
									if (num7 == null)
									{
										num = (short)1934753807;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1459290126;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									int? num7;
									num3 = new int?(num7.GetValueOrDefault() & 2);
									goto IL_539;
								}
								case 15:
								{
									int? num4 = null;
									num = (short)1255997447;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus radioStatus;
									if (radioStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.New)
									{
										num = (short)1851064332;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6B2;
								}
								case 17:
									num = (short)500695041;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_407:
								if (rawRadio.CurrentCodeplug != null)
								{
									num = (short)444530691;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6B2;
								IL_539:
								num5 = num3;
								num6 = 0;
								num = (short)997720075;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_62B:
								if (flag7 && flag6)
								{
									num = (short)144179209;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6B2:
								num = (short)108789760;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_64B:
							throw global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.CommonExceptionHelper.CreateDirectMessageCommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_CannotApplyTemplateWithLP_To_ImcompatibleDevice);
							IL_6CA:
							goto IL_A4A;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex2)
						{
							string text2;
							if (ex2.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.GenericError)
							{
								if (ex2.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error)
								{
									if (ex2.CommonExceptionData == null)
									{
										text2 = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex2.ErrorCode.ToString(), null);
										goto IL_7A1;
									}
									num = (short)166398871;
									short num8 = num;
									num = (short)1060768663;
									switch ((num8 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)442761216;
										if (num != 0)
										{
										}
										text2 = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex2.ErrorCode.ToString(), ex2.CommonExceptionData.Paramters);
										goto IL_7A1;
									}
								}
							}
							text2 = ex2.Message;
							IL_7A1:
							error = text2;
							return false;
						}
						goto IL_7AE;
					case 3:
						goto IL_180;
					case 4:
						if (rawRadio.WorkingCodeplug != null)
						{
							num = (short)243335168;
							short num9 = num;
							num = (short)1685520391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
						if (string.IsNullOrEmpty(text))
						{
							num = (short)2029322257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA7;
					case 6:
						if (cmdType == global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType.SaveTemplateOnCPS)
						{
							num = (short)1557725185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1696727048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)17694740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (cmdType == global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType.SelectTemplate)
						{
							num = (short)1507343;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_385;
					case 9:
						goto IL_180;
					case 10:
						try
						{
							flag3 = this.CloneCheck(rawTemplate, rawRadio, new global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType?(cmdType));
							goto IL_81C;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex3)
						{
							if (ex3.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.GenericError || ex3.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error)
							{
								text = ex3.Message;
							}
							else
							{
								text = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex3.ErrorCode.ToString(), null);
							}
							goto IL_81C;
						}
						goto IL_180;
						IL_81C:
						num = (short)1255669773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						int? num5 = (rawTemplate as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate).RegionalGovernance;
						int? num7 = (rawRadio.WorkingCodeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate).RegionalGovernance;
						num = (short)87359502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						return false;
					case 13:
						if (!flag3)
						{
							num = (short)52363280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7AE;
					case 14:
					{
						int? num5;
						int? num7;
						if (!(num5.GetValueOrDefault() == num7.GetValueOrDefault() & num5 != null == (num7 != null)))
						{
							num = (short)1568997397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 15:
						flag3 = this.PrecheckForSelectTemplate(rawRadio, localDevices, out error);
						num = (short)1252392963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1592918021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						text = global::Motorola.CommonCPS.ResourceRepository.Resources.FailedToApplyTemplate;
						num = (short)1236795410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_24C;
					case 19:
					{
						if (!flag3)
						{
							num = (short)1630928908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string radioFirmwareVer = string.Empty;
						global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate = rawTemplate as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate;
						global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus radioStatus = (global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus)rawRadio.RadioStatus;
						num = (short)295436289;
						if (num != 0)
						{
						}
						num = (short)669712386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (rawRadio.WorkingCodeplug.Template != null)
						{
							num = (short)780402699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 21:
						goto IL_2FE;
					}
					goto IL_8F;
					IL_180:
					num = (short)121176083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7AE:
					num = (short)1628897284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A4A:
					num = (short)1092681728;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_24C:
				goto IL_AA7;
				IL_2FE:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Device_Has_Different_Regional_Governance;
				return false;
				IL_385:
				throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udba8캪캬잮풰킲\udeb4횸즺ﲼ쾾뇀꿂별鏆곈ꛊ뷌ꏎ냐꟒냔곘뗚뗜뻞迠蟢觤苦짨蓪鷬諮菰鋲致黶雸闺\udcfc", a_));
				IL_AA7:
				error = text;
				return false;
				IL_8F:
				new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet>();
				error = string.Empty;
				flag3 = false;
				num = (short)1106837510;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0007D0EC File Offset: 0x0007B2EC
		public global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyTemplate GetRadioInfoForApplyTemplate(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, global::Motorola.CommonCPS.Server.EntityModel.Template rawTemplate)
		{
			short num = (short)853475329;
			if (num != 0)
			{
			}
			num = (short)822411264;
			short num2 = num;
			num = (short)1126627692;
			short num3 = num;
			num = (short)1399585132;
			switch (num3 == num)
			{
			}
			num = (short)946143232;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyTemplate radioInfoForApplyTemplate = new global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyTemplate();
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> featuresList = null;
			int cfsModelType = 0;
			if (rd.WorkingCodeplug != null)
			{
				if (rd.WorkingCodeplug.Template != null)
				{
					goto IL_CA;
				}
			}
			featuresList = this.GetRadioLicenseFeatures(rd, rawTemplate, out cfsModelType);
			IL_CA:
			radioInfoForApplyTemplate.FeaturesList = featuresList;
			radioInfoForApplyTemplate.RadioUuid = rd.Uuid;
			radioInfoForApplyTemplate.CfsModelType = cfsModelType;
			return radioInfoForApplyTemplate;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0007D1E0 File Offset: 0x0007B3E0
		public global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet GetValidateEntitySetForApplyTemplate(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, global::Motorola.CommonCPS.Server.EntityModel.Template rawTemplate)
		{
			switch (0)
			{
			case 0:
				goto IL_5C;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.ValidatedField validatedField;
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_C1;
				case 1:
					num2 = (short)1871708161;
					if (num2 != 0)
					{
					}
					validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(rd.LastJob);
					num2 = (short)1135149062;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (rd.CurrentCodeplug != null)
					{
						num2 = (short)1028259857;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CF;
				case 3:
					validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(rd.WorkingCodeplug);
					num2 = (short)1656160265;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_1A1;
				case 5:
					goto IL_132;
				case 6:
					if (validatedField == null)
					{
						num2 = (short)2045706244;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					validateEntitySet.ValidateEntityList.Add(validatedField);
					num2 = (short)221577227;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (rd.LastJob != null)
					{
						num2 = (short)67305473;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_38D;
				case 8:
					if (validatedField == null)
					{
						num2 = (short)613089285;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					validateEntitySet.ValidateEntityList.Add(validatedField);
					num2 = (short)1787822098;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (validatedField == null)
					{
						num2 = (short)834207754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					validateEntitySet.ValidateEntityList.Add(validatedField);
					num2 = (short)1081147407;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_2C4;
				case 11:
					goto IL_38D;
				case 12:
					if (rd.WorkingCodeplug != null)
					{
						num2 = (short)1311375363;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_240;
				case 13:
					goto IL_357;
				case 14:
					if (validatedField == null)
					{
						num2 = (short)421396480;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					validateEntitySet.ValidateEntityList.Add(validatedField);
					num2 = (short)1570504711;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_240;
				case 16:
				{
					if (validatedField != null)
					{
						goto IL_3D2;
					}
					num2 = (short)659764118;
					short num3 = num2;
					num2 = (short)1673737110;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2CF;
					default:
						num2 = (short)2134900736;
						if (num2 != 0)
						{
						}
						num2 = (short)1096876045;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 17:
				{
					num2 = (short)1144258560;
					short num4 = num2;
					validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(rd.CurrentCodeplug);
					num2 = (short)1616773128;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 18:
					goto IL_2CF;
				}
				goto IL_5C;
				IL_240:
				num2 = (short)576323586;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2CF:
				validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(rawTemplate);
				num2 = (short)1745158160;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_38D:
				num2 = (short)1519910924;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_C1:
			throw new global::System.Exception();
			IL_132:
			throw new global::System.Exception();
			IL_1A1:
			throw new global::System.Exception();
			IL_2C4:
			throw new global::System.Exception();
			IL_357:
			throw new global::System.Exception();
			IL_3D2:
			validateEntitySet.ValidateEntityList.Add(validatedField);
			return validateEntitySet;
			IL_5C:
			validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.RelatedObject = new global::System.Guid?(rd.Uuid);
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio;
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			validatedField = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.GetValidatedField(rd);
			num2 = (short)359858190;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0007D5CC File Offset: 0x0007B7CC
		public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary, global::Motorola.CommonCPS.Server.EntityModel.TemplateSummary> ApplyTemplateToRadio(global::System.Guid batchJobContainerUuid, global::System.Guid templateUuid, global::Motorola.CommonCPS.Server.EntityModel.RadioInfoForApplyTemplate radioInfo, string batchOpName, global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet, bool returnTemplate = true, bool returnRadioBase = true)
		{
			short num = (short)1788459409;
			short num2 = num;
			num = (short)1273346449;
			switch (num2 == num)
			{
			}
			num = (short)1813381120;
			short num3 = num;
			num = (short)806486017;
			if (num != 0)
			{
			}
			num = (short)503775232;
			if (num != 0)
			{
			}
			return base.ServerAccessor.ApplyTemplateToRadio(batchJobContainerUuid, templateUuid, radioInfo, batchOpName, entitySet, returnTemplate, returnRadioBase);
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0007D690 File Offset: 0x0007B890
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> GetRadioLicenseFeatures(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.EntityModel.Template target, out int cfsModelType)
		{
			short num = (short)543531409;
			short num2 = num;
			num = (short)1837670801;
			switch (num2 == num)
			{
			}
			num = (short)1715208192;
			short num3 = num;
			num = (short)1370095617;
			if (num != 0)
			{
			}
			num = (short)549715968;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().PopulateRadioFeaturesFromCodeplug(radio, target, out cfsModelType);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0007D748 File Offset: 0x0007B948
		public bool PrecheckForSaveTemplate(global::Motorola.CommonCPS.Server.EntityModel.Radio rd, global::System.Guid orignalTemplateUuid, out string error)
		{
			int a_ = 7;
			short num;
			for (;;)
			{
				error = string.Empty;
				if (!base.IsJobProcessingState(rd))
				{
					return true;
				}
				num = (short)211896279;
				short num2 = num;
				num = (short)1215711191;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_54;
				}
			}
			IL_54:
			num = (short)278134784;
			short num3 = num;
			num = (short)376176641;
			if (num != 0)
			{
			}
			num = (short)1486618624;
			if (num != 0)
			{
			}
			error = global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쪝좟잡蒣즧캩얫솭邯\udab1햳삵\uddb7骹\uddbb麽調귁ꛃꇇ꓉鷍돏뫑뇓닕귗뛙맛뫝쳟싡듣菥蛧軩藫胭韯\udef1퓳ꓵ跷铹鋻韽滿攁⠃★朇砉Ⰻ崍朏笑怓甕瀗甙樛笝刟ȡ瘣䌥大弩䔫尭唯嘱ᐳ䔵䰷嬹䠻嬽渿", a_);
			return false;
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0007D824 File Offset: 0x0007BA24
		public bool PrecheckForSelectTemplate(global::Motorola.CommonCPS.Server.EntityModel.Radio rawDevice, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, out string error)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)567869440;
						short num3 = num2;
						if (rawDevice.LastJob != null)
						{
							num2 = (short)1373175817;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_FB;
					}
					case 1:
						num2 = (short)169738241;
						if (num2 != 0)
						{
						}
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(rawDevice.WorkingCodeplug.Timestamp, device.CodeplugTimestamp))
						{
							num2 = (short)1060896776;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 2:
						if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(rawDevice.LastJob.Timestamp, device.JobTimestamp))
						{
							num2 = (short)995885059;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1EC;
					case 3:
						goto IL_FB;
					case 4:
						num2 = (short)1618149377;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						num2 = (short)388759552;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (rawDevice.WorkingCodeplug != null)
						{
							num2 = (short)1323237380;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 7:
						if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(rawDevice.Timestamp, device.RadioTimestamp))
						{
							num2 = (short)128253957;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1EC;
					case 8:
						goto IL_F6;
					case 9:
						num2 = (short)1704984578;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_38;
					IL_FB:
					num2 = (short)173026569;
					short num4 = num2;
					num2 = (short)1235758345;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3F;
					default:
						num2 = (short)366673920;
						if (num2 != 0)
						{
						}
						num2 = (short)1379926022;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_F6:
				IL_1EC:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Device_Updated_By_Another_User;
				return false;
			}
			IL_38:
			error = string.Empty;
			IL_3F:
			num2 = (short)1572667399;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A5E RID: 2654
		public abstract string GetArchieveFileTypeOfPAC();

		// Token: 0x04000176 RID: 374
		protected global::System.ComponentModel.BackgroundWorker progressWorker;

		// Token: 0x04000177 RID: 375
		protected bool isReadingArchive;

		// Token: 0x04000178 RID: 376
		protected string suggestedTemplateName;

		// Token: 0x04000179 RID: 377
		protected global::Motorola.CommonCPS.Server.EntityModel.Template importingTemplate;

		// Token: 0x0400017A RID: 378
		protected int readArchiveProgress;
	}
}
