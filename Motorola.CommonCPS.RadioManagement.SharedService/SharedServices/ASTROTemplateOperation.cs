using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ASK.Interface;
using CommonUtility;
using Motorola.Common.CommonLib;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000017 RID: 23
	internal class ASTROTemplateOperation : global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateOperation
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00005334 File Offset: 0x00003534
		public override void UploadPackageFileContentToServer(global::Motorola.CommonCPS.Server.EntityModel.Codeplug Historical_Codeplug, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField> validateEntitySet)
		{
			base.UploadPackageFileContentToServer(Historical_Codeplug, validateEntitySet);
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService templateService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.TemplateService;
			global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate = Historical_Codeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate;
			templateService.UpLoadVAFile(apxtemplate);
			short num;
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement>.Enumerator enumerator = apxtemplate.ASTROVoiceAnnouncements.GetEnumerator())
			{
				num = (short)632744475;
				short num2 = num;
				num = (short)2006903323;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_136:
					num = (short)937426945;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)586809344;
					if (num != 0)
					{
					}
					num = (short)1067450372;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_134;
					case 1:
						goto IL_14D;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1842544640;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement entity = enumerator.Current;
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet, entity);
						num = (short)1082261507;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1151991809;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_DC;
						}
						continue;
					}
					IL_103:
					num = (short)1648623618;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_DC:
					goto IL_103;
				}
				IL_134:
				goto IL_136;
				IL_14D:;
			}
			num = (short)100532224;
			short num4 = num;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000054E4 File Offset: 0x000036E4
		public override global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Package> AnalysisListPackageInfo(string filePath)
		{
			short num = (short)1591090947;
			short num2 = num;
			num = (short)1798381315;
			switch (num2 == num)
			{
			}
			num = (short)488177665;
			if (num != 0)
			{
			}
			num = (short)1235943424;
			short num3 = num;
			num = (short)1518796800;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AnalysisListPackageInfo(filePath);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00005598 File Offset: 0x00003798
		public override bool IsFreon(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string modelNumber)
		{
			short num = (short)782639754;
			short num2 = num;
			num = (short)1715741322;
			switch (num2 == num)
			{
			}
			num = (short)255655937;
			if (num != 0)
			{
			}
			num = (short)1678114816;
			short num3 = num;
			num = (short)222822400;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().IsFreon(modelNumber);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000564C File Offset: 0x0000384C
		public void ValidateAstroWriting(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio, bool enableWritingProtect, int transportPreference, bool isWriteProtected, bool isRestoreJob, bool restoreJob_PbaCanNotBeDirectlyModified, out global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest updatedCP, ref global::System.Collections.ObjectModel.Collection<global::ASK.Interface.ISystemKeyData> attachedASKs, ref bool? isSpecialKeyAttached)
		{
			short num = (short)279109909;
			short num2 = num;
			num = (short)319021333;
			switch (num2 == num)
			{
			}
			num = (short)55574529;
			if (num != 0)
			{
			}
			num = (short)636485632;
			short num3 = num;
			num = (short)2126315520;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().ValidateAstroWriting(radio, enableWritingProtect, transportPreference, isWriteProtected, isRestoreJob, out updatedCP, ref attachedASKs, ref isSpecialKeyAttached);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000570C File Offset: 0x0000390C
		protected override void ExtractInfoToTemplate_Beyond_ParseArchive(byte[] pbaData, global::Motorola.CommonCPS.Server.EntityModel.Radio importingRadio)
		{
			short num = (short)1017315328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack latestASTROLPPackagesByFirmwareVersion;
				global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
						if (pbaObject.LanguagePackData.LanguagePacks != null)
						{
							num = (short)123338752;
							short num3 = num;
							num = (short)2127364101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
					{
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator = pbaObject.LanguagePackData.LanguagePacks.GetEnumerator();
						num = (short)1860894727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						if (latestASTROLPPackagesByFirmwareVersion != null)
						{
							num = (short)57671688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<byte[]> list = global::Motorola.Common.CommonLib.CombineTool.Decode(pbaData);
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(list[0], false);
						global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo a_ = (global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo)global::Motorola.Common.CommonLib.CombineTool.ByteArrayToObject(list[1]);
						num = (short)1970864134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
						if (pbaObject.LanguagePackData.LanguagePacks.Count > 0)
						{
							num = (short)1204617217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						goto IL_2D0;
					case 5:
						num = (short)1283391489;
						if (num != 0)
						{
						}
						num = (short)714997763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
						if (pbaObject.LanguagePackData != null)
						{
							num = (short)384958468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 7:
						try
						{
							num = (short)1666394454;
							short num4 = num;
							num = (short)262285654;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_2A4:
								num = (short)2081226753;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1843462144;
								if (num != 0)
								{
								}
								num = (short)1733165060;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_2BD;
								case 2:
									goto IL_276;
								case 3:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1350172674;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.LanguagePackBase a_2 = enumerator.Current;
									global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo a_;
									this.a(a_2, a_, apxtemplate);
									num = (short)101908480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_23E;
									}
									continue;
								}
								IL_240:
								num = (short)1201209347;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_23E:
								goto IL_240;
							}
							IL_276:
							goto IL_2A4;
							IL_2BD:
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2D0;
					case 8:
						goto IL_CD;
					}
					goto IL_53;
					IL_2D0:
					num = (short)804519936;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CD:
				apxtemplate.ASTROLanguagePack = latestASTROLPPackagesByFirmwareVersion;
				return;
				IL_53:
				base.ExtractInfoToTemplate_Beyond_ParseArchive(pbaData, importingRadio);
				apxtemplate = (importingRadio.WorkingCodeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
				string lpid = ((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).AstroDecodeLanguageIndexToLPID(apxtemplate.LanguageIndex);
				latestASTROLPPackagesByFirmwareVersion = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetLatestASTROLPPackagesByFirmwareVersion(apxtemplate.FirmwareVersion, lpid);
				num = (short)1262223362;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00005A98 File Offset: 0x00003C98
		private void a(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0, global::Motorola.Common.Communication.CommonUtil.AstroDeviceInfo A_1, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate A_2)
		{
			short num = (short)676790272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_69;
				}
				global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
				for (;;)
				{
					IL_27:
					num = (short)1970929665;
					if (num != 0)
					{
					}
					string lpID;
					string packageVersion;
					switch (num2)
					{
					case 0:
						if (global::CommonUtility.ASTROLanguageUtility.Instance.ParseLanguageIDAndVersion(astroFilePackInfo.radioFilePath, out lpID, out packageVersion))
						{
							num = (short)2055340033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_129;
					case 2:
						return;
					case 3:
						return;
					case 4:
					{
						num = (short)1851457536;
						short num3 = num;
						if (!string.IsNullOrEmpty(astroFilePackInfo.radioFilePath))
						{
							num = (short)596443136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1970512434;
						short num4 = num;
						num = (short)1893638706;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_129;
						default:
							num = (short)1139212288;
							if (num != 0)
							{
							}
							num = (short)288751619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_69;
					IL_129:
					global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack astrolanguagePack = new global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack();
					astrolanguagePack.PackageName = string.Empty;
					astrolanguagePack.LpID = lpID;
					astrolanguagePack.PackageVersion = packageVersion;
					global::Motorola.CommonCPS.Server.EntityModel.Package package = astrolanguagePack;
					global::Motorola.CommonCPS.Server.EntityModel.Package package2 = astrolanguagePack;
					global::System.DateTime? dateTime = new global::System.DateTime?(global::System.DateTime.UtcNow);
					package2.CreatedDate = dateTime;
					package.ModifiedDate = dateTime;
					astrolanguagePack.CompatibleVersion = A_1.SoftwareVersion;
					A_2.LanguagePackUuid = new global::System.Guid?(astrolanguagePack.Uuid);
					A_2.ASTROLanguagePack = astrolanguagePack;
					num = (short)1653473282;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_69:
				astroFilePackInfo = (A_0 as global::Motorola.Common.Communication.Pba.AstroFilePackInfo);
				num = (short)1175650308;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
