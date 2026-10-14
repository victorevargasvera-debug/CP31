using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200000E RID: 14
	internal class EditASTROOTARProfileCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00005810 File Offset: 0x00003A10
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2040397824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_D3;
				}
				bool flag;
				bool flag2;
				string text;
				object obj;
				string empty;
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile oldOTARProfile;
				for (;;)
				{
					IL_28:
					global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService iastrouivalidationService;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.OtarFieldType, object> dictionary;
						global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO apxotarProfileDTO;
						this.a(apxradio, dictionary, apxotarProfileDTO);
						num = (short)802488342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)2135752732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)719325601;
						short num3 = num;
						num = (short)2107705761;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_53B;
						default:
							num = (short)440205312;
							if (num != 0)
							{
							}
							goto IL_51B;
						}
						break;
					}
					case 3:
						flag = (bool)paras[4];
						flag2 = true;
						num = (short)454950945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache instance = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance;
						global::System.Guid? radioID = oldOTARProfile.RadioID;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio = instance.GetCachedRadio(radioID.Value) as global::Motorola.CommonCPS.Server.EntityModel.APXRadio;
						num = (short)284098562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						if (apxradio == null)
						{
							goto IL_53B;
						}
						goto IL_633;
					}
					case 6:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						base.ASTROLocalService.RefreshASTROOtarProfilesForOneRadioFromDB(apxradio);
						this.a(oldOTARProfile);
						num = (short)610533414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						int? otarID = oldOTARProfile.OtarID;
						num = (short)728629283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (!flag)
						{
							num = (short)1377697796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51B;
					case 9:
						goto IL_13A;
					case 10:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						if (iastrouivalidationService.ValidateWhenEditOTARProfile(apxradio, text, obj, oldOTARProfile, flag2, out empty))
						{
							num = (short)1995374613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_293;
					}
					case 11:
						goto IL_293;
					case 12:
					{
						bool? independentList;
						bool flag3;
						if (!(independentList.GetValueOrDefault() == flag3 & independentList != null))
						{
							num = (short)451674112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_590;
					}
					case 13:
						if (!flag2)
						{
							num = (short)140050450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_590;
					case 14:
						goto IL_2D1;
					case 15:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						base.ASTROLocalService.RefreshASTROOtarProfilesForRadio(apxradio);
						this.a(oldOTARProfile);
						num = (short)1202847768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio = this.a(oldOTARProfile);
						num = (short)1150943259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (!string.IsNullOrEmpty(empty))
						{
							num = (short)1938685966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_895;
					case 18:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO apxotarProfileDTO;
						bool? independentList = apxotarProfileDTO.IndependentList;
						bool flag3 = true;
						num = (short)118358028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (oldOTARProfile != null)
						{
							num = (short)245432346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CA;
					case 20:
					{
						global::System.Guid? radioID;
						if (radioID != null)
						{
							num = (short)1020985351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CA;
					}
					case 21:
						num = (short)186646558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO apxotarProfileDTO;
						if (oldOTARProfile.ASTROOtarProfileID != apxotarProfileDTO.OtarProfileUuid)
						{
							num = (short)928907270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						base.ASTROLocalService.RefreshASTROOtarProfilesForOneRadioFromCache(apxradio, oldOTARProfile);
						this.UpdateCPValue(apxradio, new global::System.Guid?(apxotarProfileDTO.OtarProfileUuid), apxotarProfileDTO.OtarId);
						num = (short)502595593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_293;
					case 24:
						goto IL_293;
					case 25:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO apxotarProfileDTO;
						if (oldOTARProfile.ASTROOtarProfileID != apxotarProfileDTO.OtarProfileUuid)
						{
							num = (short)398524431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a(oldOTARProfile, apxotarProfileDTO);
						num = (short)1771569189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						global::System.Guid? radioID = oldOTARProfile.RadioID;
						num = (short)894042132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_633;
					case 28:
					{
						if (string.IsNullOrEmpty(text))
						{
							num = (short)981532708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						empty = string.Empty;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio = null;
						num = (short)7929864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						if (iastrouivalidationService != null)
						{
							num = (short)17825792;
							short num4 = num;
							num = (short)1765670952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_293;
					case 30:
					{
						if (flag)
						{
							num = (short)121045031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int? otarID = oldOTARProfile.OtarID;
						num = (short)1890385952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						if (paras.Length >= 5)
						{
							num = (short)890241027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_791;
					case 32:
					{
						int? otarID;
						if (otarID.Value != (int)obj)
						{
							num = (short)1938358306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_293;
					}
					case 33:
						goto IL_791;
					case 34:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						this.UpdateCPValue(apxradio, oldOTARProfile.ID, obj as int?);
						oldOTARProfile.OtarID = (obj as int?);
						num = (short)1599143959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
					{
						num = (short)1896284161;
						if (num != 0)
						{
						}
						int? otarID;
						if (otarID != null)
						{
							num = (short)304218113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CA;
					}
					case 36:
						goto IL_4A0;
					case 37:
						goto IL_293;
					case 38:
						goto IL_13A;
					case 39:
					{
						global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.OtarFieldType, object> dictionary = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.OtarFieldType, object>
						{
							{
								global::Motorola.CommonCPS.Server.CommonDBConstants.OtarFieldType.OtarID,
								obj
							}
						};
						global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> otarProfiles = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)apxradio.WorkingCodeplug).APXOtarProfiles.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile o)
						{
							short num5 = (short)1806215272;
							short num6 = num5;
							num5 = (short)1020700776;
							switch (num6 == num5)
							{
							}
							num5 = (short)635568129;
							if (num5 != 0)
							{
							}
							num5 = (short)585826304;
							if (num5 != 0)
							{
							}
							num5 = (short)427884544;
							short num7 = num5;
							return o.Profile == oldOTARProfile.OtarProfileName;
						}).ToList<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile>();
						global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO apxotarProfileDTO = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AstroOTARProfileService.EditOTARProfilesFields(apxradio, otarProfiles, dictionary).First<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO>();
						num = (short)404815885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						num = (short)36896778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D3;
					IL_13A:
					oldOTARProfile.OtarID = (obj as int?);
					num = (short)182386699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_293:
					num = (short)347471889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51B:
					num = (short)283967493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_53B:
					num = (short)871170064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_590:
					num = (short)1580924953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_633:
					iastrouivalidationService = (base.UIValidateService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService);
					num = (short)2101674013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_791:
					num = (short)1526726675;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1CA:
				throw new global::System.ArgumentNullException();
				IL_2D1:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Special_Display_Msg, empty);
				IL_4A0:
				goto IL_1CA;
				IL_895:
				return oldOTARProfile;
				IL_D3:
				oldOTARProfile = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile);
				text = (paras[1] as string);
				obj = paras[2];
				flag = true;
				flag2 = false;
				num = (short)471072799;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000060B8 File Offset: 0x000042B8
		private void a(global::Motorola.CommonCPS.Server.EntityModel.APXRadio A_0, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.OtarFieldType, object> A_1, global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO A_2)
		{
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> list = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)A_0.WorkingCodeplug).APXOtarProfiles.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile o)
			{
				short num5 = (short)189005824;
				short num6 = num5;
				if (!(o.Profile != A_2.OtarProfileName))
				{
					num5 = (short)359033128;
					short num7 = num5;
					num5 = (short)1773168936;
					switch ((num7 == num5) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num5 = (short)517996545;
						if (num5 != 0)
						{
						}
						num5 = (short)2020671488;
						if (num5 != 0)
						{
						}
						return false;
					}
				}
				bool? independentList = o.IndependentList;
				bool flag = true;
				return !(independentList.GetValueOrDefault() == flag & independentList != null);
			}).ToList<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile>();
			global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AstroOTARProfileService.EditOTARProfilesFields(A_0, list, A_1);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile>.Enumerator enumerator = list.GetEnumerator();
			short num;
			try
			{
				num = (short)78296914;
				short num2 = num;
				num = (short)12433234;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)462422016;
					if (num != 0)
					{
					}
					num = (short)127074308;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_150;
						case 2:
							num = (short)1509949440;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (!enumerator.MoveNext())
							{
								num = (short)499646466;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.OtarID = A_2.OtarId;
							num = (short)1094320129;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_D5;
							}
							continue;
						}
						IL_105:
						num = (short)1555431427;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D5:
						goto IL_105;
					}
					break;
				}
				}
				IL_150:;
			}
			finally
			{
				num = (short)676986881;
				if (num != 0)
				{
				}
				((global::System.IDisposable)enumerator).Dispose();
			}
			num = (short)1589837824;
			short num4 = num;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006294 File Offset: 0x00004494
		private global::Motorola.CommonCPS.Server.EntityModel.APXRadio a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile A_0)
		{
			short num;
			global::System.Guid? radioID;
			global::Motorola.CommonCPS.Server.EntityModel.APXRadio astroradioRawData;
			for (;;)
			{
				num = (short)565182469;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROSystemService astroSystemService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AstroSystemService;
						radioID = A_0.RadioID;
						astroradioRawData = astroSystemService.GetASTRORadioRawData(radioID.Value, false);
						num = (short)1696137217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (astroradioRawData != null)
						{
							num = (short)1931739140;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_164;
					case 2:
					{
						num = (short)299761664;
						short num3 = num;
						radioID = A_0.RadioID;
						num = (short)882442243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (radioID != null)
						{
							num = (short)776994816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_175;
					case 4:
						goto IL_CA;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					}
					IL_3C:
					if (A_0 == null)
					{
						break;
					}
					num = (short)923205634;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_175:
				num = (short)2115308011;
				short num4 = num;
				num = (short)493685227;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1AB;
				}
			}
			IL_CA:
			num = (short)507183105;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache instance = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance;
			radioID = A_0.RadioID;
			instance.Add(radioID.Value, astroradioRawData);
			return astroradioRawData;
			IL_164:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DeviceNoExistForEditTemplate, null);
			IL_1AB:
			num = (short)353697792;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006464 File Offset: 0x00004664
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile A_0, global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO A_1)
		{
			short num = (short)716242944;
			short num2 = num;
			num = (short)154874353;
			short num3 = num;
			num = (short)1983001073;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_111:
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile astrootarProfile = A_1.ToUiModel(false);
				A_0.CopyFrom(astrootarProfile);
				base.ViewCacheNotifier.NotifyViewCacheUpdateItems<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>
				{
					astrootarProfile
				});
				num = (short)820379648;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1077084161;
				if (num != 0)
				{
				}
				num = (short)710213632;
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
			int? otarID;
			int? otarId;
			for (;;)
			{
				IL_A4:
				switch (num4)
				{
				case 0:
					return;
				case 1:
					goto IL_10F;
				case 2:
					if (!(otarID.GetValueOrDefault() == otarId.GetValueOrDefault() & otarID != null == (otarId != null)))
					{
						num = (short)1633419265;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_B6;
			}
			IL_10F:
			goto IL_111;
			IL_B6:
			otarID = A_0.OtarID;
			otarId = A_1.OtarId;
			num = (short)1069940738;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A4;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000065C4 File Offset: 0x000047C4
		public void UpdateCPValue(global::Motorola.CommonCPS.Server.EntityModel.APXRadio aPXRadio, global::System.Guid? profileUUID, int? value)
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
				global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxotarProfile;
				global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxotarProfile2;
				switch (num)
				{
				case 0:
					IL_5E:
					if (aPXRadio.WorkingCodeplug != null)
					{
						num2 = (short)902365194;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_212;
				case 1:
					if (profileUUID != null)
					{
						num2 = (short)482934792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_212;
				case 2:
					num2 = (short)552468486;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> apxotarProfiles = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)aPXRadio.WorkingCodeplug).APXOtarProfiles;
					if (apxotarProfiles == null)
					{
						num2 = (short)2097414145;
						if (num2 != 0)
						{
						}
						num2 = (short)1678376965;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					apxotarProfile = apxotarProfiles.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile x)
					{
						short num5 = (short)1207435264;
						short num6 = num5;
						num5 = (short)553254913;
						if (num5 != 0)
						{
						}
						global::System.Guid uuid = x.Uuid;
						global::System.Guid? profileUUID2 = profileUUID;
						if (profileUUID2 != null)
						{
							num5 = (short)460543544;
							short num7 = num5;
							num5 = (short)1313297976;
							switch ((num7 == num5) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num5 = (short)242810880;
								if (num5 != 0)
								{
								}
								return uuid == profileUUID2.GetValueOrDefault();
							}
						}
						return false;
					}).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile>();
					goto IL_1B2;
				}
				case 4:
					if (apxotarProfile2 != null)
					{
						num2 = (short)1080033280;
						short num3 = num2;
						num2 = (short)1687814146;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_212;
				case 5:
					apxotarProfile = null;
					goto IL_1B2;
				case 6:
					if (value != null)
					{
						num2 = (short)908656649;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_212;
				case 7:
					goto IL_212;
				case 8:
					num2 = (short)778960899;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					apxotarProfile2.OtarID = value;
					num2 = (short)1895235591;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)1076690945;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3C;
				IL_1B2:
				apxotarProfile2 = apxotarProfile;
				num2 = (short)1869938692;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_212:
				num2 = (short)1978168493;
				short num4 = num2;
				num2 = (short)1847620781;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5E;
				default:
					goto IL_249;
				}
			}
			IL_249:
			num2 = (short)989724672;
			if (num2 != 0)
			{
			}
			return;
			IL_3C:
			num2 = (short)871759872;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
