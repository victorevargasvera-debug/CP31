using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using ASK.Interface;
using CommonUtility;
using EntityModel.GenericModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.SharedServices.RadioNext;
using Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.RMServerContract.DataQueryObjects;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200006F RID: 111
	internal class ASTROManageRadioLicenseService : global::Motorola.CommonCPS.RadioManagement.SharedServices.ManageRadioLicenseServiceBase
	{
		// Token: 0x06000785 RID: 1925 RVA: 0x0005795C File Offset: 0x00055B5C
		public ASTROManageRadioLicenseService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService pcrValidationService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioLicenseService radioLicenseService) : base(serverAccessor, pcrValidationService, radioLicenseService)
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00057974 File Offset: 0x00055B74
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00057A20 File Offset: 0x00055C20
		protected byte[] OriginalPurchasedFlashCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1336483964;
				short num2 = num;
				num = (short)12394620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)879362048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)159842305;
				if (num != 0)
				{
				}
				num = (short)1263796224;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1567948801;
				if (num != 0)
				{
				}
				num = (short)1344405504;
				short num2 = num;
				num = (short)8830268;
				short num3 = num;
				num = (short)34454844;
				switch (num3 == num)
				{
				}
				num = (short)714932224;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00057AD8 File Offset: 0x00055CD8
		public override global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureFilter PrepareLicenseFilter(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selectedEIDDetails)
		{
			short num = (short)792395777;
			if (num != 0)
			{
			}
			num = (short)1043857408;
			short num2 = num;
			num = (short)1227927226;
			short num3 = num;
			num = (short)1918348986;
			switch (num3 == num)
			{
			}
			num = (short)527499264;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.APXRadioFeatureFilter
			{
				ModelNumber = (selectedEIDDetails[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail).SourceModelNumber,
				SourceFlashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroEncodeFlashCode((selectedEIDDetails[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail).SourceFlashcode),
				TargetFlashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroEncodeFlashCode((selectedEIDDetails[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail).TargetFlashcode)
			};
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00057BE4 File Offset: 0x00055DE4
		public override global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> ConstructEIDDetailList(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> licenseList)
		{
			short num = (short)705298433;
			if (num != 0)
			{
			}
			num = (short)1105395712;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense>.Enumerator enumerator = licenseList.GetEnumerator())
				{
					num = (short)1755185159;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense radioEntitledLicense;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense>.Enumerator enumerator2;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense> source;
						switch (num2)
						{
						case 0:
							goto IL_30B;
						case 2:
							goto IL_3C3;
						case 3:
							num = (short)336134146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (radioEntitledLicense.License is global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.FlashcodeRadioSoftwareLicense)
							{
								num = (short)271450112;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 5:
							try
							{
								num = (short)41222150;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)484311041;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_2F8;
									case 2:
									{
										num = (short)1245427321;
										short num3 = num;
										num = (short)1748350585;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											continue;
										default:
											num = (short)1396375552;
											if (num != 0)
											{
											}
											break;
										}
										break;
									}
									case 3:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)723845120;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense item = enumerator2.Current;
										num = (short)596901893;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										astroeiddetail.LicensedFeatureList.Add(CS$<>8__locals1.item);
										num = (short)2115895298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										if (source.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense f)
										{
											short num5 = (short)111197894;
											short num6 = num5;
											num5 = (short)1069268678;
											switch (num6 == num5)
											{
											default:
											{
												num5 = (short)1259732992;
												short num7 = num5;
												break;
											}
											case true:
												break;
											}
											num5 = (short)1313406977;
											if (num5 != 0)
											{
											}
											num5 = (short)1417478144;
											if (num5 != 0)
											{
											}
											return f.FeatureName == CS$<>8__locals1.item.FeatureName;
										}) == null)
										{
											num = (short)1019412484;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_1C9;
										}
										continue;
									}
									IL_1CB:
									num = (short)790495235;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1C9:
									goto IL_1CB;
								}
								IL_2F8:
								goto IL_121;
							}
							finally
							{
								((global::System.IDisposable)enumerator2).Dispose();
							}
							goto IL_30B;
							IL_121:
							list.Add(astroeiddetail);
							num = (short)1812070401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (!enumerator.MoveNext())
							{
								num = (short)200343555;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							radioEntitledLicense = enumerator.Current;
							num = (short)1863581700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_D4;
							}
							continue;
						}
						IL_144:
						num = (short)844103686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D4:
						goto IL_144;
						IL_30B:
						global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.FlashcodeRadioSoftwareLicense flashcodeRadioSoftwareLicense = radioEntitledLicense.License as global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.FlashcodeRadioSoftwareLicense;
						astroeiddetail = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail
						{
							SourceFlashcode = flashcodeRadioSoftwareLicense.SourceFlashCode,
							TargetFlashcode = flashcodeRadioSoftwareLicense.TargetFlashCode,
							SourceModelNumber = flashcodeRadioSoftwareLicense.ModelNumber
						};
						base.CopyEIDInfo(astroeiddetail, radioEntitledLicense);
						this.SetFeatureName(astroeiddetail.SourceFlashcode, astroeiddetail.SourceModelNumber, out source);
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense> list2;
						this.SetFeatureName(astroeiddetail.TargetFlashcode, astroeiddetail.SourceModelNumber, out list2);
						astroeiddetail.LicensedFeatureList = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense>();
						enumerator2 = list2.GetEnumerator();
						num = (short)1076559877;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3C3:
					goto IL_55;
				}
				goto IL_3D6;
				IL_55:
				num = (short)1022427136;
				short num4 = num;
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail> source2 = list;
				global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail, global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> selector;
				if ((selector = global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROManageRadioLicenseService.<>c.<>9__8_0) != null)
				{
					goto IL_3EF;
				}
				IL_3D6:
				selector = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ASTROManageRadioLicenseService.<>c.<>9__8_0 = delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail eid)
				{
					short num5 = (short)1421990225;
					short num6 = num5;
					num5 = (short)1752488273;
					switch (num6 == num5)
					{
					default:
					{
						num5 = (short)1102381056;
						short num7 = num5;
						break;
					}
					case true:
						break;
					}
					num5 = (short)1601568769;
					if (num5 != 0)
					{
					}
					num5 = (short)1771700224;
					if (num5 != 0)
					{
					}
					return eid;
				});
				IL_3EF:
				return source2.Select(selector).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>();
			}
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00058020 File Offset: 0x00056220
		public override bool ConstructSoftwareLicense(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail theEIDDetail, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> licenseList, out global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense license)
		{
			short num = (short)1537925955;
			short num2 = num;
			num = (short)213246787;
			switch (num2 == num)
			{
			}
			num = (short)1940258816;
			short num3 = num;
			num = (short)295632897;
			if (num != 0)
			{
			}
			num = (short)48234496;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail astroeiddetail = theEIDDetail as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail;
			license = new global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.FlashcodeRadioSoftwareLicense
			{
				AID = astroeiddetail.ActivationID,
				ModelNumber = astroeiddetail.SourceModelNumber,
				SourceFlashCode = astroeiddetail.SourceFlashcode,
				TargetFlashCode = astroeiddetail.TargetFlashcode
			};
			return true;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00058108 File Offset: 0x00056308
		public override global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> GenerateTemplateForSubmission(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, string targetFlashcode, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> swLicenseList, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> requestList, out byte[] newTemplateContent, global::System.Collections.Generic.Dictionary<string, object> syncData, global::ASK.Interface.ISystemKeyData SelectedSystemID = null)
		{
			int a_ = 1;
			short num = (short)1968504832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.AstroUpgradeCodeplugEventArgs astroUpgradeCodeplugEventArgs;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (astroUpgradeCodeplugEventArgs.Syncdata.hOptionAdvancedKeyIDS != null)
						{
							num = (short)583663617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_277;
					case 1:
						for (;;)
						{
							num = (short)1349779457;
							if (num != 0)
							{
							}
							num = (short)2098987008;
							short num3 = num;
							num = (short)783397983;
							short num4 = num;
							num = (short)1112454239;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_19A;
							}
						}
						IL_19A:
						num = (short)1252392960;
						if (num != 0)
						{
						}
						syncData.Add(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힗ﮝ튟삣킥쾩햫節즯슱톳", a_), astroUpgradeCodeplugEventArgs.Syncdata.hOptionAdvancedKeyIDS.OwnerAdvancedKeyType);
						syncData.Add(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("힗ﮝ튟얣얥욧좫", a_), astroUpgradeCodeplugEventArgs.Syncdata.hOptionAdvancedKeyIDS.OwnerWACNID);
						syncData.Add(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킗ﮝ\udba1힣튥춧잩쪭", a_), astroUpgradeCodeplugEventArgs.Syncdata.hOptionAdvancedKeyIDS.OwnerSystemID);
						syncData.Add(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud997첝얟펡톣쾥\udaa7쾩좫", a_), astroUpgradeCodeplugEventArgs.Syncdata.hOptionAdvancedKeyIDS.ASKRequired);
						num = (short)1234501634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_275;
					}
					goto IL_44;
				}
				IL_275:
				IL_277:
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				this.OriginalPurchasedFlashCode = apxcodeplug.AstroPurchasedFlashCode;
				byte[] array;
				syncData.Add(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\ud997쾟톣풥쮧슩춫\uddad햯횱\udab5\ud9b7즹풻ﶽ꾿ꛁꇃ", a_), array);
				(apxcodeplug.Template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate).AstroPurchasedFlashCode = array;
				newTemplateContent = astroUpgradeCodeplugEventArgs.Syncdata.CpFileContent;
				return astroUpgradeCodeplugEventArgs.Syncdata.RadioFeaturesRequest;
				IL_44:
				string firmwareVersion = radio.CurrentCodeplug.FirmwareVersion;
				array = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroEncodeFlashCode(targetFlashcode);
				global::Motorola.CommonCPS.Server.EntityModel.Template template = base.ServerAccessor.GetTemplate(radio.WorkingCodeplug.TemplateUuid.Value, true);
				byte[] fileContent = base.ServerAccessor.GetFileContent(template.FileUuid.Value);
				astroUpgradeCodeplugEventArgs = ((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).AstroUpgradeCodeplug(array, null, radio.ModelNumber, template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate, fileContent, firmwareVersion, null, false, SelectedSystemID);
				apxcodeplug = (radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				apxcodeplug.Template = template;
				num = (short)865730560;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000583E0 File Offset: 0x000565E0
		public override global::EntityModel.GenericModel.CFSUpdateResult SubmitLicenseAssignment(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> EIDDetailList, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device, global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.Dictionary<string, global::System.Guid>> newTemplateDic, global::System.Guid JobContainerGuid, global::ASK.Interface.ISystemKeyData SelectedSystemID)
		{
			short num = (short)1931476992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				int num3;
				byte[] data;
				global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
				global::System.Collections.Generic.Dictionary<string, object> dictionary;
				global::EntityModel.GenericModel.CFSUpdateResult result;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> list2;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> list3;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> list4;
				for (;;)
				{
					IL_27:
					global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail eiddetail;
					global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense item;
					switch (num2)
					{
					case 0:
						num = (short)612433931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (num3 >= EIDDetailList.Count)
						{
							num = (short)816054272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						eiddetail = EIDDetailList[num3];
						num = (short)1624244228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_8CA;
					case 3:
						goto IL_240;
					case 4:
						if (eiddetail.AvailableCount > 0)
						{
							num = (short)484048906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 5:
						goto IL_8CA;
					case 6:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_40E;
							}
							global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplug;
							string targetFlashcode;
							global::Motorola.CommonCPS.Server.EntityModel.Template template;
							global::System.Guid guid;
							for (;;)
							{
								IL_3C3:
								bool isFreon;
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest>.Enumerator enumerator;
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> list;
								switch (num2)
								{
								case 0:
									if (newTemplateDic.ContainsKey(workingCodeplug.TemplateUuid.Value))
									{
										num = (short)1060700167;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_50B;
								case 1:
									if (newTemplateDic[workingCodeplug.TemplateUuid.Value].ContainsKey(targetFlashcode))
									{
										num = (short)138346506;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_50B;
								case 2:
									goto IL_650;
								case 3:
									goto IL_710;
								case 4:
								{
									global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = base.ServerAccessor.AddFileContent(data);
									template.FileUuid = new global::System.Guid?(rmfile.Uuid);
									template.RMFile = rmfile;
									template.Name = global::CommonUtility.NameUtility.GetDefaultSaveAsName(template.Name, true, false);
									num = (short)30998540;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_6C7;
								case 6:
									goto IL_83D;
								case 7:
									num = (short)609026049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (!newTemplateDic.ContainsKey(workingCodeplug.TemplateUuid.Value))
									{
										num = (short)869269515;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_710;
								case 9:
									if (base.ServerAccessor.GetASTROPackagesByTargetModelVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Firmware, template.ModelNumber, template.FirmwareVersion, isFreon, true).Count == 0)
									{
										num = (short)751370245;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7DC;
								case 10:
									guid = newTemplateDic[workingCodeplug.TemplateUuid.Value][targetFlashcode];
									num = (short)302317581;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									newTemplateDic.Add(workingCodeplug.TemplateUuid.Value, new global::System.Collections.Generic.Dictionary<string, global::System.Guid>());
									num = (short)1030291459;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (template is global::Motorola.CommonCPS.Server.EntityModel.APXTemplate)
									{
										num = (short)414384130;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7DC;
								case 13:
									goto IL_50B;
								case 14:
									if (guid == global::System.Guid.Empty)
									{
										num = (short)473300996;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_83D;
								case 15:
									goto IL_8A9;
								case 16:
								{
									try
									{
										num = (short)490995714;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)709754884;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)427229184;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest radioFeatureRequest = enumerator.Current;
												list.Add(new global::Motorola.CommonCPS.Server.EntityModel.RadioFeature
												{
													FeatureName = radioFeatureRequest.FeatureName,
													LicenseName = radioFeatureRequest.LicenseName,
													CurrentStatus = (int)radioFeatureRequest.Status
												});
												num = (short)896466947;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_58C;
												}
												continue;
											case 4:
												goto IL_63D;
											}
											IL_58E:
											num = (short)328073217;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_58C:
											goto IL_58E;
										}
										IL_63D:
										goto IL_86A;
									}
									finally
									{
										((global::System.IDisposable)enumerator).Dispose();
									}
									goto IL_650;
									IL_86A:
									global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet = base.CreateValidateSetForRestoreAndRegisterCFS(radio);
									byte[] response;
									result = base.ServerAccessor.ApplyUpdatedTemplateToRadio(radio.Uuid, guid, list, response, JobContainerGuid, entitySet, dictionary);
									num = (short)1081671695;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_40E;
								IL_50B:
								num = (short)191889422;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_650:
								isFreon = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).IsFreon(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX, template.ModelNumber);
								num = (short)676724745;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_710:
								newTemplateDic[workingCodeplug.TemplateUuid.Value].Add(targetFlashcode, guid);
								num = (short)2040987654;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7DC:
								guid = base.ServerAccessor.SaveNewTemplateForUpgrade(template);
								num = (short)28966920;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_83D:
								list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>();
								enumerator = list2.GetEnumerator();
								num = (short)565903376;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6C7:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_PACKAGE_NOT_FOUND);
							IL_8A9:
							return result;
							IL_40E:
							workingCodeplug = radio.WorkingCodeplug;
							template = workingCodeplug.Template;
							guid = global::System.Guid.Empty;
							targetFlashcode = (EIDDetailList[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail).TargetFlashcode;
							num = (short)1824129024;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_3C3;
						}
						catch (global::Motorola.Common.CustomException.CommonException)
						{
							throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Submit_Err_Update_Template, radio.SerialNumber));
						}
						goto IL_8CA;
					case 7:
						goto IL_36C;
					case 8:
						num = (short)692453377;
						if (num != 0)
						{
						}
						try
						{
							byte[] response = base.RegisterLicense(radio.DeviceID, list3);
							using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>.Enumerator enumerator2 = list4.GetEnumerator())
							{
								num = (short)36110338;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									IL_E5:
									switch (num2)
									{
									case 0:
										num = (short)1733885956;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										while (enumerator2.MoveNext())
										{
											num = (short)711089960;
											short num4 = num;
											num = (short)134831912;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
											{
												num = (short)948633600;
												if (num != 0)
												{
												}
												global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail eiddetail2 = enumerator2.Current;
												int availableCount = eiddetail2.AvailableCount;
												eiddetail2.AvailableCount = availableCount - 1;
												num = (short)295829507;
												num2 = (int)((global::System.IntPtr)num);
												goto IL_E5;
											}
											}
										}
										num = (short)582221824;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_100;
										}
										continue;
									case 4:
										goto IL_1D5;
									}
									IL_102:
									num = (short)1354563585;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_100:
									goto IL_102;
								}
								IL_1D5:;
							}
							goto IL_26F;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							string message;
							if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RMC_License_Error_Already_Registered)
							{
								message = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_License_Error_Already_Registered, radio.SerialNumber);
							}
							else
							{
								message = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null);
							}
							throw new global::Motorola.Common.CustomException.CommonException(message);
						}
						goto IL_240;
						IL_26F:
						num = (short)1464336390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (this.ConstructSoftwareLicense(eiddetail, list3, out item))
						{
							num = (short)1400569859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 10:
						num = (short)906493961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						try
						{
							list2 = this.GenerateTemplateForSubmission(radio, (EIDDetailList[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROEIDDetail).TargetFlashcode, list3, list2, out data, dictionary, SelectedSystemID);
							goto IL_2D5;
						}
						catch (global::Motorola.Common.CustomException.CommonException)
						{
							throw;
						}
						catch
						{
							throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Submit_Err_Generate_Template, radio.SerialNumber));
						}
						goto IL_36C;
						IL_2D5:
						global::Motorola.CommonCPS.Server.EntityModel.Package a_ = null;
						this.a(radio, a_, dictionary);
						byte[] response = null;
						num = (short)894304264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_5E;
					IL_240:
					list4.Add(eiddetail);
					list3.Add(item);
					num = (short)423690247;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36C:
					num = (short)925368320;
					short num5 = num;
					num3++;
					num = (short)459341829;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8CA:
					num = (short)325386241;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_5E:
				radio = this.CheckRadio(device.ID.Value, device);
				dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
				list2 = null;
				data = null;
				list3 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense>();
				list4 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>();
				num3 = 0;
				num = (short)243335170;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00058DF8 File Offset: 0x00056FF8
		public override global::EntityModel.GenericModel.CFSUpdateResult RestoreDevice(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase> selectedList, global::System.Collections.Generic.Dictionary<global::System.Guid, global::System.Collections.Generic.Dictionary<string, global::System.Guid>> newTemplateDic, global::System.Guid JobContainerGuid, global::ASK.Interface.ISystemKeyData SelectedSystemID = null)
		{
			short num = (short)1261476567;
			short num2 = num;
			num = (short)221616855;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
			global::System.Collections.Generic.Dictionary<string, object> dictionary;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_139:
				radio = this.CheckRadio(selectedList[0].DeviceUuid.Value, null);
				dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
				num = (short)505675779;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1958739968;
				if (num != 0)
				{
				}
				num = (short)1050411008;
				short num4 = num;
				num = (short)915996672;
				switch (num)
				{
				default:
					num = (short)499449857;
					if (num != 0)
					{
					}
					num = (short)1856569346;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_137;
				case 1:
					goto IL_10E;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_F1;
					}
					continue;
				case 3:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> list = selectedList.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase license)
					{
						short num5 = (short)600156529;
						short num6 = num5;
						num5 = (short)1083091313;
						switch (num6 == num5)
						{
						default:
						{
							num5 = (short)27525120;
							short num7 = num5;
							break;
						}
						case true:
							break;
						}
						num5 = (short)569966593;
						if (num5 != 0)
						{
						}
						num5 = (short)185597952;
						if (num5 != 0)
						{
						}
						return new global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest(license.RawData.FeatureName, global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus.PendingActive, null, null, "", true);
					}).ToList<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest>();
					byte[] data = null;
					num = (short)1344143364;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					try
					{
						byte[] data;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> list = this.GenerateTemplateForSubmission(radio, (selectedList[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense).FlashCode, null, list, out data, dictionary, SelectedSystemID);
						goto IL_113;
					}
					catch (global::Motorola.Common.CustomException.CommonException)
					{
						throw;
					}
					catch
					{
						throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Submit_Err_Generate_Template, radio.SerialNumber));
					}
					global::EntityModel.GenericModel.CFSUpdateResult result;
					return result;
					IL_113:
					global::Motorola.CommonCPS.Server.EntityModel.Package a_ = null;
					this.a(radio, a_, dictionary);
					num = (short)916193280;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_F1:
				if (selectedList.Count != 0)
				{
					goto IL_139;
				}
				num = (short)949551105;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_10E:
			goto IL_680;
			IL_137:
			try
			{
				switch (0)
				{
				case 0:
					goto IL_1DA;
				}
				global::EntityModel.GenericModel.CFSUpdateResult result;
				global::Motorola.CommonCPS.Server.EntityModel.Codeplug workingCodeplug;
				global::System.Guid guid;
				string key;
				global::Motorola.CommonCPS.Server.EntityModel.Template template;
				for (;;)
				{
					IL_18F:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest>.Enumerator enumerator;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> list2;
					switch (num3)
					{
					case 0:
						if (newTemplateDic.ContainsKey(workingCodeplug.TemplateUuid.Value))
						{
							num = (short)1770717191;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AF;
					case 1:
					{
						try
						{
							num = (short)375783426;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1506934787;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest radioFeatureRequest = enumerator.Current;
									list2.Add(new global::Motorola.CommonCPS.Server.EntityModel.RadioFeature
									{
										FeatureName = radioFeatureRequest.FeatureName,
										LicenseName = radioFeatureRequest.LicenseName,
										CurrentStatus = (int)radioFeatureRequest.Status
									});
									num = (short)1421410305;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_427;
									}
									continue;
								case 3:
									num = (short)165085188;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_4D8;
								}
								IL_484:
								num = (short)527237120;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_427:
								goto IL_484;
							}
							IL_4D8:
							goto IL_621;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_4EB;
						IL_621:
						global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet entitySet = base.CreateValidateSetForRestoreAndRegisterCFS(radio);
						result = base.ServerAccessor.ApplyUpdatedTemplateToRadio(radio.Uuid, guid, list2, null, JobContainerGuid, entitySet, dictionary);
						num = (short)259915791;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						guid = newTemplateDic[workingCodeplug.TemplateUuid.Value][key];
						num = (short)1436090384;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						newTemplateDic.Add(workingCodeplug.TemplateUuid.Value, new global::System.Collections.Generic.Dictionary<string, global::System.Guid>());
						num = (short)1219493896;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						byte[] data;
						global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = base.ServerAccessor.AddFileContent(data);
						template.FileUuid = new global::System.Guid?(rmfile.Uuid);
						template.RMFile = rmfile;
						template.Name = global::CommonUtility.NameUtility.GetDefaultSaveAsName(template.Name, true, false);
						num = (short)1814429705;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						bool isFreon = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).IsFreon(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX, template.ModelNumber);
						num = (short)2067202061;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_3E7;
					case 7:
						num = (short)1106968588;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_5A7;
					case 9:
						if (template is global::Motorola.CommonCPS.Server.EntityModel.APXTemplate)
						{
							num = (short)2025979909;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_518;
					case 10:
						if (!newTemplateDic.ContainsKey(workingCodeplug.TemplateUuid.Value))
						{
							num = (short)104660995;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5A7;
					case 11:
						goto IL_4EB;
					case 12:
						if (newTemplateDic[workingCodeplug.TemplateUuid.Value].ContainsKey(key))
						{
							num = (short)425459714;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AF;
					case 13:
					{
						bool isFreon;
						if (base.ServerAccessor.GetASTROPackagesByTargetModelVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Firmware, template.ModelNumber, template.FirmwareVersion, isFreon, true).Count == 0)
						{
							num = (short)1898577926;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_518;
					}
					case 14:
						if (guid == global::System.Guid.Empty)
						{
							num = (short)1463025668;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4EB;
					case 15:
						goto IL_65F;
					case 16:
						goto IL_2AF;
					}
					goto IL_1DA;
					IL_2AF:
					num = (short)2034565134;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_4EB:
					list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>();
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> list;
					enumerator = list.GetEnumerator();
					num = (short)1662844929;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_518:
					guid = base.ServerAccessor.SaveNewTemplateForUpgrade(template);
					num = (short)1604124682;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A7:
					newTemplateDic[workingCodeplug.TemplateUuid.Value].Add(key, guid);
					num = (short)13172747;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_3E7:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_PACKAGE_NOT_FOUND);
				IL_65F:
				return result;
				IL_1DA:
				workingCodeplug = radio.WorkingCodeplug;
				template = workingCodeplug.Template;
				guid = global::System.Guid.Empty;
				key = global::System.BitConverter.ToString((workingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).AstroPurchasedFlashCode);
				num = (short)467664896;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_18F;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_RestoreDevices_Error, radio.SerialNumber));
			}
			IL_680:
			return null;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00059574 File Offset: 0x00057774
		public override bool CheckFeatureCompatibilityForRecover(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> softwareLicenseList, out string warning)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.FlashcodeRadioSoftwareLicense flashcodeRadioSoftwareLicense;
			string text;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (flashcodeRadioSoftwareLicense.SourceFlashCode == text)
					{
						num2 = (short)846266371;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
				{
					if (!(flashcodeRadioSoftwareLicense.ModelNumber == radio.ModelNumber))
					{
						return false;
					}
					num2 = (short)1168578728;
					short num3 = num2;
					num2 = (short)979769512;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C4;
					default:
						num2 = (short)1788149760;
						if (num2 != 0)
						{
						}
						num2 = (short)903413764;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (flashcodeRadioSoftwareLicense == null)
					{
						num2 = (short)1179910149;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.a(flashcodeRadioSoftwareLicense);
					num2 = (short)1769209856;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_1C4;
				case 4:
					return true;
				case 5:
					goto IL_E7;
				}
				goto IL_28;
				IL_1C4:
				num2 = (short)1564344321;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E7:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Licenses_Recover_LicenseFeatureCompatibility_PACType);
			IL_28:
			num2 = (short)1329790976;
			short num4 = num2;
			num2 = (short)2025652225;
			if (num2 != 0)
			{
			}
			warning = string.Empty;
			global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = radio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
			text = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroDecodeFlashCode(apxcodeplug.AstroPurchasedFlashCode);
			flashcodeRadioSoftwareLicense = (softwareLicenseList[softwareLicenseList.Count - 1] as global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.FlashcodeRadioSoftwareLicense);
			num2 = (short)541655042;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00059758 File Offset: 0x00057958
		public override global::EntityModel.GenericModel.CFSUpdateResult DoRecover(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> radioSoftwareLicense, byte[] capacityResponse)
		{
			short num = (short)1192034304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> radioFeaturesRequest;
				global::EntityModel.GenericModel.CFSUpdateResult result;
				byte[] array;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						if (radioFeaturesRequest.Count <= 0)
						{
							return result;
						}
						num = (short)2069350341;
						short num3 = num;
						num = (short)1623902149;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E5;
						default:
							num = (short)1189216256;
							if (num != 0)
							{
							}
							num = (short)257163266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (radioFeaturesRequest != null)
						{
							num = (short)646905860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						goto IL_E5;
					case 3:
						goto IL_113;
					case 4:
						num = (short)1402273792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_44;
					IL_E5:
					result = base.ServerAccessor.RecoverRadioFeatures(radio.Uuid, radioFeaturesRequest, array, capacityResponse);
					num = (short)1712128003;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_113:
				num = (short)228261888;
				short num4 = num;
				return result;
				IL_44:
				num = (short)1345323009;
				if (num != 0)
				{
				}
				result = null;
				array = null;
				global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.FlashcodeRadioSoftwareLicense flashcodeRadioSoftwareLicense = radioSoftwareLicense[radioSoftwareLicense.Count - 1] as global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.FlashcodeRadioSoftwareLicense;
				array = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroEncodeFlashCode(flashcodeRadioSoftwareLicense.TargetFlashCode);
				radioFeaturesRequest = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().PopulateRadioFeaturesFromFlashCode(array, radio.ModelNumber).RadioFeaturesRequest;
				num = (short)483262465;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00059934 File Offset: 0x00057B34
		protected void SetFeatureName(string flashCode, string modelNumber, out global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense> licenseList)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.Dictionary<int, string> dictionary;
				global::System.Collections.Generic.Dictionary<int, string>.Enumerator enumerator;
				switch (num)
				{
				case 0:
					if (dictionary != null)
					{
						num2 = (short)1297022980;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					num2 = (short)843251713;
					if (num2 != 0)
					{
					}
					if (!string.IsNullOrEmpty(modelNumber))
					{
						num2 = (short)204275717;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					num2 = (short)578027521;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!string.IsNullOrEmpty(flashCode))
					{
						num2 = (short)249823234;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					goto IL_1BF;
				case 5:
					dictionary = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroParseFlashCode(flashCode, modelNumber);
					num2 = (short)917831680;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					try
					{
						num2 = (short)1064566785;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								num2 = (short)1375592476;
								short num3 = num2;
								num2 = (short)160096284;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_AF;
								default:
									num2 = (short)488570880;
									if (num2 != 0)
									{
									}
									break;
								}
								break;
							}
							case 1:
								goto IL_AF;
							case 2:
								goto IL_1AC;
							case 3:
								num2 = (short)369426434;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)828243971;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<int, string> keyValuePair = enumerator.Current;
								licenseList.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense
								{
									FeatureName = keyValuePair.Value
								});
								num2 = (short)668729344;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							goto IL_D3;
							IL_AF:
							switch (0)
							{
							case 0:
								IL_D3:
								goto IL_D5;
							}
							continue;
							IL_D5:
							num2 = (short)1545863172;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1AC:
						return;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1BF;
				}
				goto IL_2C;
				IL_1BF:
				enumerator = dictionary.GetEnumerator();
				num2 = (short)218562566;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_2C:
			licenseList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadioLicense>();
			num2 = (short)857800704;
			short num4 = num2;
			num2 = (short)1412628483;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00059BE8 File Offset: 0x00057DE8
		protected override global::Motorola.CommonCPS.Server.EntityModel.Radio CheckRadio(global::System.Guid deviceId, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase device)
		{
			short num = (short)1495793664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
				int? changeIndicator;
				for (;;)
				{
					IL_27:
					bool? upgradeAbility;
					switch (num2)
					{
					case 0:
						if (upgradeAbility != null)
						{
							num = (short)1798373381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E;
					case 1:
						goto IL_22C;
					case 2:
						if (radio.WorkingCodeplug != null)
						{
							num = (short)1169555457;
							if (num != 0)
							{
							}
							num = (short)162267139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E;
					case 3:
						goto IL_18E;
					case 4:
					{
						num = (short)485715703;
						short num3 = num;
						num = (short)698576631;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18E;
						default:
							num = (short)1040515072;
							if (num != 0)
							{
							}
							changeIndicator = radio.WorkingCodeplug.ChangeIndicator;
							num = (short)1362755592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
					{
						num = (short)161873920;
						short num4 = num;
						upgradeAbility = radio.WorkingCodeplug.UpgradeAbility;
						bool flag = false;
						num = (short)2044788745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (changeIndicator != null)
						{
							num = (short)1234632708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12D;
					case 7:
						goto IL_128;
					case 8:
						if ((changeIndicator.Value & 16) != 0)
						{
							num = (short)1806368769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12D;
					case 9:
					{
						bool flag;
						if (upgradeAbility.GetValueOrDefault() == flag & upgradeAbility != null)
						{
							num = (short)408485895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return radio;
					}
					}
					goto IL_56;
					IL_12D:
					num = (short)487981058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18E:
					upgradeAbility = radio.WorkingCodeplug.UpgradeAbility;
					num = (short)477888512;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_128:
				goto IL_22E;
				IL_22C:
				throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Submit_Fail_OnFlashCodeChange, radio.SerialNumber));
				IL_22E:
				throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Submit_SelectedRadioNoRead, radio.SerialNumber));
				IL_56:
				radio = base.CheckRadio(deviceId, device);
				changeIndicator = radio.WorkingCodeplug.ChangeIndicator;
				num = (short)952893446;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00059EA8 File Offset: 0x000580A8
		protected override global::Motorola.CommonCPS.Server.EntityModel.Radio CheckRadio(string radioSerialNumber)
		{
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
			for (;;)
			{
				num = (short)1225457665;
				if (num != 0)
				{
				}
				radio = base.CheckRadio(radioSerialNumber);
				if (this.CheckPendingLicenseForRecover(radio.RadioFeatures))
				{
					break;
				}
				num = (short)1676166032;
				short num2 = num;
				num = (short)705315728;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8C;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Recover_AstroExistPendingFeature_Error, radioSerialNumber));
			IL_8C:
			num = (short)403177472;
			short num3 = num;
			num = (short)875495424;
			if (num != 0)
			{
			}
			return radio;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00059F84 File Offset: 0x00058184
		private global::Motorola.CommonCPS.Server.EntityModel.Package a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, global::Motorola.CommonCPS.Server.EntityModel.Package A_1, global::System.Collections.Generic.Dictionary<string, object> A_2)
		{
			int a_ = 5;
			short num = (short)1661468672;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1551534910;
				short num3 = num;
				num = (short)291277630;
				global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1B7:
					A_2.Add(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udd9b춝솧\ud8a9솫\ud9ad톯삱톳", a_), astrofirmware);
					A_2.Add(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda9b튟쾡펣장\udaa7쾩嶺\udbad\ud9af횱", a_), astrofirmware.Uuid);
					A_2.Add(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda9b튟쾡펣장\udaa7쾩磌쮭슯솱\uddb3\ud9b5횷", a_), astrofirmware.PackageVersion);
					num = (short)1770258436;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1998323712;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_B6;
					}
					break;
				}
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug a_2;
				for (;;)
				{
					IL_7B:
					global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware2;
					switch (num2)
					{
					case 0:
						A_0.WorkingCodeplug.Template.FirmwareVersion = astrofirmware.PackageVersion;
						num = (short)70254599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int? productFamily = A_0.ProductFamily;
						int num4 = 4096;
						num = (short)1097203714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						int? productFamily;
						int num4;
						if (!(productFamily.GetValueOrDefault() == num4 & productFamily != null))
						{
							num = (short)2076114955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)580190216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (A_0.WorkingCodeplug.Template != null)
						{
							num = (short)43581440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B7;
					case 4:
						return astrofirmware;
					case 5:
						goto IL_12F;
					case 6:
					{
						num = (short)1573453825;
						if (num != 0)
						{
						}
						num = (short)523370496;
						short num5 = num;
						num = (short)114688003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_12A;
					case 8:
						astrofirmware2 = this.b(A_0, a_2);
						goto IL_2FE;
					case 9:
						if (astrofirmware == null)
						{
							num = (short)630784001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F;
					case 10:
						astrofirmware2 = this.a(A_0, a_2);
						goto IL_2FE;
					case 11:
						num = (short)490340362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (astrofirmware != null)
						{
							num = (short)610533382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EE;
					}
					goto IL_B6;
					IL_12F:
					num = (short)1383464972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FE:
					astrofirmware = astrofirmware2;
					num = (short)73793541;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12A:
				goto IL_1B7;
				IL_2EE:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Licenses_Error_No_FW, global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Error_No_FW);
				IL_B6:
				a_2 = (A_0.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				astrofirmware = (A_1 as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware);
				num = (short)265748489;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_7B;
			}
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0005A2D4 File Offset: 0x000584D4
		private global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware b(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_1)
		{
			short num = (short)1981904854;
			short num2 = num;
			num = (short)857634774;
			switch (num2 == num)
			{
			}
			num = (short)728170497;
			if (num != 0)
			{
			}
			num = (short)1138229248;
			short num3 = num;
			num = (short)780206080;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.RMServerContract.DataQueryObjects.AstroAmpFirmwareQuery query = new global::Motorola.CommonCPS.Server.RMServerContract.DataQueryObjects.AstroAmpFirmwareQuery
			{
				ExcludeDifferentialPackages = true,
				TargetModel = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioNext.TargetModelMap.ModelNumber.GetValueOrDefault(A_0.ModelNumber),
				PackageVersion = A_1.FirmwareVersion,
				GetOnlyEqualPackageVersion = true
			};
			return base.ServerAccessor.GetAstroAmpFirmwares(query).SingleOrDefault<global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware>();
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0005A3C4 File Offset: 0x000585C4
		private global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware a(global::Motorola.CommonCPS.Server.EntityModel.Radio A_0, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_1)
		{
			int a_ = 13;
			short num = (short)763101184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AB;
				}
				global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware astrofirmware;
				bool flag2;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROPackage>.Enumerator enumerator;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						return astrofirmware;
					case 1:
					{
						bool flag;
						if (!flag)
						{
							num = (short)1261240340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B9;
					}
					case 2:
						astrofirmware = astrofirmware.SubFirmwares.SingleOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
						{
							int a_2 = 18;
							switch (0)
							{
							case 0:
								goto IL_31;
							}
							int num5;
							bool? flag4;
							bool flag5;
							short num6;
							for (;;)
							{
								IL_13:
								switch (num5)
								{
								case 0:
								{
									flag4 = x.IsOMAPFirmwareUpgradeFile;
									flag5 = true;
									num6 = (short)1915813888;
									short num7 = num6;
									num6 = (short)1297416193;
									if (num6 != 0)
									{
									}
									num6 = (short)1852309506;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								}
								case 1:
								{
									num6 = (short)1185411847;
									short num8 = num6;
									num6 = (short)1065874183;
									switch ((num8 == num6) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_66;
									default:
										num6 = (short)179109888;
										if (num6 != 0)
										{
										}
										if (!(flag4.GetValueOrDefault() == flag5 & flag4 != null))
										{
											num6 = (short)1562705923;
											num5 = (int)((global::System.IntPtr)num6);
											continue;
										}
										return false;
									}
									break;
								}
								case 2:
									if (!(flag4.GetValueOrDefault() == flag5 & flag4 != null))
									{
										num6 = (short)433586180;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									}
									return false;
								case 3:
									goto IL_13C;
								case 4:
									flag4 = x.IsFreonFirmwareUpgradeFile;
									flag5 = true;
									num6 = (short)666566657;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								case 5:
									if (flag4.GetValueOrDefault() == flag5 & flag4 != null)
									{
										goto IL_66;
									}
									return false;
								}
								goto IL_31;
								IL_66:
								num6 = (short)1209335808;
								num5 = (int)((global::System.IntPtr)num6);
							}
							IL_13C:
							return x.TargetModel.Substring(0, 1) == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("", a_2);
							IL_31:
							flag4 = x.IsSubFirmware;
							flag5 = true;
							num6 = (short)511967237;
							num5 = (int)((global::System.IntPtr)num6);
							goto IL_13;
						});
						num = (short)964624393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!flag2)
						{
							num = (short)546111509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return astrofirmware;
					case 4:
						return astrofirmware;
					case 5:
						if (astrofirmware != null)
						{
							num = (short)411041819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return astrofirmware;
					case 6:
					{
						bool flag;
						if (flag2 && flag)
						{
							num = (short)634847248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)440860691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						try
						{
							num = (short)946798599;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1A2;
								case 1:
									num = (short)1147600901;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (astrofirmware.SoftwareVersion == A_1.FirmwareVersion)
									{
										num = (short)1342876007;
										short num3 = num;
										num = (short)987998567;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_173;
										default:
											num = (short)522977280;
											if (num != 0)
											{
											}
											num = (short)1030094851;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								case 3:
									num = (short)297664512;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)61079554;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_29E;
								case 6:
									if (astrofirmware != null)
									{
										num = (short)1252327428;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_14F;
									}
									continue;
								case 8:
									if (!enumerator.MoveNext())
									{
										goto IL_173;
									}
									astrofirmware = (enumerator.Current as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware);
									num = (short)1731330054;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_151:
								num = (short)1540620296;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_14F:
								goto IL_151;
								IL_173:
								num = (short)1256325121;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1A2:
							IL_29E:;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						num = (short)730071045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						bool flag;
						if (!flag2 && flag)
						{
							num = (short)983236623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)114163715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						return astrofirmware;
					case 10:
						goto IL_436;
					case 11:
					{
						bool flag;
						if (!flag)
						{
							num = (short)213123098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return astrofirmware;
					}
					case 12:
						astrofirmware = astrofirmware.SubFirmwares.SingleOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
						{
							int a_2 = 0;
							switch (0)
							{
							case 0:
								goto IL_31;
							}
							int num5;
							short num6;
							bool? flag4;
							bool flag5;
							for (;;)
							{
								IL_13:
								switch (num5)
								{
								case 0:
								{
									num6 = (short)169476096;
									short num7 = num6;
									flag4 = x.IsOMAPFirmwareUpgradeFile;
									flag5 = true;
									num6 = (short)758579202;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								}
								case 1:
								{
									num6 = (short)2125973673;
									short num8 = num6;
									num6 = (short)1320601769;
									switch ((num8 == num6) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_67;
									default:
										num6 = (short)942604289;
										if (num6 != 0)
										{
										}
										num6 = (short)376373248;
										if (num6 != 0)
										{
										}
										if (!(flag4.GetValueOrDefault() == flag5 & flag4 != null))
										{
											num6 = (short)333971459;
											num5 = (int)((global::System.IntPtr)num6);
											continue;
										}
										return false;
									}
									break;
								}
								case 2:
									if (!(flag4.GetValueOrDefault() == flag5 & flag4 != null))
									{
										num6 = (short)560660484;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									}
									return false;
								case 3:
									goto IL_167;
								case 4:
									flag4 = x.IsFreonFirmwareUpgradeFile;
									flag5 = true;
									num6 = (short)1722417153;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								case 5:
									if (flag4.GetValueOrDefault() == flag5 & flag4 != null)
									{
										goto IL_67;
									}
									return false;
								}
								goto IL_31;
								IL_67:
								num6 = (short)1244332032;
								num5 = (int)((global::System.IntPtr)num6);
							}
							IL_167:
							return x.TargetModel.Substring(0, 1) != global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\udf96", a_2);
							IL_31:
							flag4 = x.IsSubFirmware;
							flag5 = true;
							num6 = (short)1242693637;
							num5 = (int)((global::System.IntPtr)num6);
							goto IL_13;
						});
						num = (short)1576468493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						return astrofirmware;
					case 14:
						astrofirmware = astrofirmware.SubFirmwares.SingleOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
						{
							int a_2 = 18;
							switch (0)
							{
							case 0:
								goto IL_29;
							}
							int num5;
							bool? flag4;
							bool flag5;
							short num6;
							for (;;)
							{
								IL_13:
								switch (num5)
								{
								case 0:
									if (flag4.GetValueOrDefault() == flag5 & flag4 != null)
									{
										num6 = (short)810483714;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									}
									return false;
								case 1:
									flag4 = x.IsFreonFirmwareUpgradeFile;
									flag5 = true;
									num6 = (short)1730674688;
									num5 = (int)((global::System.IntPtr)num6);
									continue;
								case 2:
									goto IL_10B;
								case 3:
								{
									num6 = (short)725352448;
									short num7 = num6;
									if (flag4.GetValueOrDefault() == flag5 & flag4 != null)
									{
										num6 = (short)1117388801;
										num5 = (int)((global::System.IntPtr)num6);
										continue;
									}
									return false;
								}
								}
								goto IL_29;
							}
							IL_10B:
							num6 = (short)409895982;
							short num8 = num6;
							num6 = (short)189629486;
							switch ((num8 == num6) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num6 = (short)647692288;
								if (num6 != 0)
								{
								}
								num6 = (short)388300801;
								if (num6 != 0)
								{
								}
								break;
							}
							return x.TargetModel == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("춨슪\udeac첮\udeb2\udab4햶", a_2);
							IL_29:
							flag4 = x.IsSubFirmware;
							flag5 = true;
							num6 = (short)442761219;
							num5 = (int)((global::System.IntPtr)num6);
							goto IL_13;
						});
						num = (short)111607808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1901461506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)503447575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (astrofirmware.SubFirmwares == null)
						{
							num = (short)1314652170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1008336902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)339476481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (flag2)
						{
							num = (short)874381330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B9;
					case 20:
						num = (short)1715798030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)1080098827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)1084096529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						astrofirmware = astrofirmware.SubFirmwares.SingleOrDefault(delegate(global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware x)
						{
							int a_2 = 4;
							switch (0)
							{
							case 0:
								goto IL_50;
							}
							short num5;
							int num6;
							bool? flag4;
							bool flag5;
							for (;;)
							{
								IL_13:
								num5 = (short)479657985;
								if (num5 != 0)
								{
								}
								switch (num6)
								{
								case 0:
									if (flag4.GetValueOrDefault() == flag5 & flag4 != null)
									{
										num5 = (short)1158217730;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									}
									return false;
								case 1:
									flag4 = x.IsFreonFirmwareUpgradeFile;
									flag5 = true;
									num5 = (short)2621440;
									num6 = (int)((global::System.IntPtr)num5);
									continue;
								case 2:
									goto IL_12F;
								case 3:
									if (flag4.GetValueOrDefault() == flag5 & flag4 != null)
									{
										num5 = (short)1249116161;
										num6 = (int)((global::System.IntPtr)num5);
										continue;
									}
									return false;
								}
								goto IL_50;
							}
							IL_12F:
							num5 = (short)1705004148;
							short num7 = num5;
							num5 = (short)1703955572;
							switch ((num7 == num5) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num5 = (short)243007488;
								if (num5 != 0)
								{
								}
								break;
							}
							return x.TargetModel == global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﾚ슠ﲢ햤좦\udba8", a_2);
							IL_50:
							flag4 = x.IsSubFirmware;
							flag5 = true;
							num5 = (short)2078474240;
							short num8 = num5;
							num5 = (short)2047541251;
							num6 = (int)((global::System.IntPtr)num5);
							goto IL_13;
						});
						num = (short)1241645060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						bool flag = A_0.ModelNumber.StartsWith(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("", a_), global::System.StringComparison.Ordinal);
						astrofirmware = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetPackage(astrofirmware.Uuid) as global::Motorola.CommonCPS.Server.EntityModel.ASTROFirmware);
						num = (short)553123865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (astrofirmware != null)
						{
							num = (short)1582235648;
							short num4 = num;
							num = (short)573177878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_438;
					case 26:
						num = (short)1806696460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						num = (short)764018689;
						if (num != 0)
						{
						}
						bool? isVirtualSummaryFirmware = astrofirmware.IsVirtualSummaryFirmware;
						bool flag3 = true;
						num = (short)1987248156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
					{
						bool? isVirtualSummaryFirmware;
						bool flag3;
						if (isVirtualSummaryFirmware.GetValueOrDefault() == flag3 & isVirtualSummaryFirmware != null)
						{
							num = (short)48496664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return astrofirmware;
					}
					}
					goto IL_AB;
					IL_5B9:
					num = (short)894894088;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_436:
				IL_438:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Firmware_NotExist);
				IL_AB:
				astrofirmware = null;
				flag2 = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).IsFreon(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX, A_0.ModelNumber);
				enumerator = base.ServerAccessor.GetASTROPackagesByTargetModelVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Firmware, A_0.ModelNumber, A_1.FirmwareVersion, flag2, true).GetEnumerator();
				num = (short)352649223;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0005AB1C File Offset: 0x00058D1C
		private void a(global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.FlashcodeRadioSoftwareLicense A_0)
		{
			int a_ = 10;
			short num = (short)1608056840;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0.SourceFlashCode != null)
					{
						num = (short)2070740995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					A_0.TargetFlashCode += global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("負鎢閤鞦馨鮪鶬芮膰莲薴螶覸论", a_);
					num = (short)1751056386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
				{
					num = (short)1702019987;
					short num3 = num;
					num = (short)1189397395;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_106;
					default:
						num = (short)966328320;
						if (num != 0)
						{
						}
						num = (short)81592324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_106;
				case 5:
					if (A_0.SourceFlashCode.Length <= 15)
					{
						num = (short)1655963655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_134;
				case 6:
					goto IL_134;
				case 7:
					A_0.SourceFlashCode += global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("負鎢閤鞦馨鮪鶬芮膰莲薴螶覸论", a_);
					num = (short)2068578310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 9:
				{
					num = (short)202768385;
					if (num != 0)
					{
					}
					num = (short)677380096;
					short num4 = num;
					num = (short)153616389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_56:
				if (A_0.SourceFlashCode != null)
				{
					num = (short)1475608585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_134;
				IL_106:
				if (A_0.TargetFlashCode.Length <= 15)
				{
					num = (short)1433927681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_134:
				num = (short)579076096;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0400009A RID: 154
		private const int a = 15;

		// Token: 0x0400009B RID: 155
		private const string b = "-000000-000000";

		// Token: 0x0400009C RID: 156
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte[] c;
	}
}
