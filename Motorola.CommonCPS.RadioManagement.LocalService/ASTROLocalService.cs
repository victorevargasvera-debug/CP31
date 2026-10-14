using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using ASK.Interface;
using CommonASK;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;
using RFResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000003 RID: 3
	public class ASTROLocalService : global::Motorola.CommonCPS.RadioManagement.LocalService.LocalService, global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService, global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService, global::Motorola.CommonCPS.RadioManagement.LocalService.IGeneralPackageLocalService
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> GetASTROSystems(string groupID)
		{
			short num = (short)483393537;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Guid? guid;
			for (;;)
			{
				IL_1F:
				switch (num2)
				{
				case 0:
					goto IL_129;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					goto IL_10F;
				case 3:
					num = (short)1417805824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_35:
				while (string.IsNullOrEmpty(groupID))
				{
					num = (short)1366061894;
					short num3 = num;
					num = (short)1438675782;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1466826752;
						if (num != 0)
						{
						}
						guid = null;
						num = (short)1554382848;
						short num4 = num;
						num = (short)1808793601;
						if (num != 0)
						{
						}
						num = (short)83034114;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1F;
					}
					}
				}
				num = (short)1650458627;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10F:
			global::System.Guid? groupId = guid;
			goto IL_136;
			IL_129:
			groupId = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_136:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROSystemViewCache(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(groupId));
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000226C File Offset: 0x0000046C
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo> GetASTROSystemInfos(string groupID)
		{
			short num = (short)1740046337;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Guid? guid;
			for (;;)
			{
				IL_1E:
				switch (num2)
				{
				case 0:
					goto IL_12C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_111;
				case 3:
					num = (short)1817903104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				while (string.IsNullOrEmpty(groupID))
				{
					num = (short)685876925;
					short num3 = num;
					num = (short)1993189053;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1936785409;
						if (num != 0)
						{
						}
						num = (short)1120665600;
						if (num != 0)
						{
						}
						num = (short)61014016;
						short num4 = num;
						guid = null;
						num = (short)146669570;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1E;
					}
					}
				}
				num = (short)300417027;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_111:
			global::System.Guid? groupId = guid;
			goto IL_139;
			IL_12C:
			groupId = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_139:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.SystemInfoViewCache(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(groupId));
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000023BC File Offset: 0x000005BC
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> GetRadioInfosBySystem(string groupID, string customId)
		{
			short num = (short)616103936;
			switch (num)
			{
			default:
			{
				num = (short)586022915;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo astrosystemInfo;
				string[] array;
				global::System.Guid? groupId;
				for (;;)
				{
					global::System.Guid? guid2;
					global::System.Guid? guid;
					switch (num2)
					{
					case 0:
					{
						num = (short)876150784;
						short num3 = num;
						num = (short)996016129;
						if (num != 0)
						{
						}
						guid = guid2;
						goto IL_10E;
					}
					case 1:
						goto IL_1EC;
					case 2:
						num = (short)124715013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					case 4:
					{
						num = (short)721841948;
						short num4 = num;
						num = (short)1722707740;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_139;
						default:
							num = (short)1631977472;
							if (num != 0)
							{
							}
							astrosystemInfo.SystemType = (string.IsNullOrEmpty(array[1]) ? null : ((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?)global::System.Enum.Parse(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType), array[1])));
							num = (short)215547905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						guid = new global::System.Guid?(global::System.Guid.Parse(groupID));
						goto IL_10E;
					}
					IL_5C:
					if (!string.IsNullOrEmpty(groupID))
					{
						num = (short)2082734082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					guid2 = null;
					num = (short)1974009856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_139:
					num = (short)1686896644;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10E:
					groupId = guid;
					groupId = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(groupId);
					array = customId.Split(new char[]
					{
						'-'
					}, 4, global::System.StringSplitOptions.None);
					astrosystemInfo = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo();
					astrosystemInfo.SystemId = array[0];
					goto IL_139;
				}
				IL_1EC:
				astrosystemInfo.SubSystemType = (string.IsNullOrEmpty(array[2]) ? null : ((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?)global::System.Enum.Parse(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType), array[2])));
				astrosystemInfo.SystemName = array[3];
				return new global::Motorola.CommonCPS.RadioManagement.LocalService.SystemToRadioViewCache(groupId, astrosystemInfo);
			}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000025FC File Offset: 0x000007FC
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo> GetSystemRadioInfos(string groupID)
		{
			short num;
			global::System.Guid? guid;
			for (;;)
			{
				num = (short)433061891;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_99;
					case 1:
						num = (short)1208483842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_127;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					}
					IL_34:
					num = (short)725155841;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(groupID))
					{
						num = (short)599654401;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						guid = null;
						num = (short)2146893824;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_99:
				num = (short)170228354;
				short num3 = num;
				num = (short)820148866;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_CF;
				}
			}
			IL_CF:
			num = (short)1191510016;
			short num4 = num;
			num = (short)1217593344;
			if (num != 0)
			{
			}
			global::System.Guid? groupId = guid;
			goto IL_134;
			IL_127:
			groupId = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_134:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.SystemRadioInfoViewCache(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(groupId));
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002748 File Offset: 0x00000948
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> GetSystemInfosbyRadio(string radioID)
		{
			short num = (short)403663207;
			short num2 = num;
			num = (short)1751607655;
			switch (num2 == num)
			{
			}
			num = (short)472252417;
			if (num != 0)
			{
			}
			num = (short)2080571392;
			short num3 = num;
			num = (short)1918238720;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioToSystemViewCache(new global::System.Guid(radioID));
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002800 File Offset: 0x00000A00
		public global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> RefreshRadioSystemViewForRadio(global::Motorola.CommonCPS.Server.EntityModel.APXRadio radio)
		{
			short num = (short)27328512;
			switch (num)
			{
			default:
			{
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = (global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)radio.CurrentCodeplug;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> list = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListSystemsByRadio(radio.Uuid);
				global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary>.Enumerator enumerator = list.GetEnumerator())
				{
					num = (short)1559232513;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2111176707;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.a a = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.a();
							a.a = enumerator.Current;
							global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem = apxcodeplug.APXRadioSystems.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem, bool>(a.b)).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>();
							num = (short)1460535302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_8C;
							}
							continue;
						case 3:
							num = (short)205651973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.a a;
							global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
							dictionary.Add(apxradioSystem.Uuid, a.a.ToUiModel(true));
							num = (short)1126105090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_1CE;
						case 6:
						{
							global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
							if (apxradioSystem != null)
							{
								num = (short)1901395972;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_F5:
						num = (short)1287175733;
						short num3 = num;
						num = (short)737132085;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1501429760;
							if (num != 0)
							{
							}
							num = (short)1212153856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_8C:
						goto IL_F5;
					}
					IL_1CE:;
				}
				num = (short)2126118912;
				short num4 = num;
				num = (short)538116097;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance.NotifyViewCacheReplaceItems<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>(dictionary);
				global::Motorola.CommonCPS.RadioManagement.LocalService.NewSystemCache.Instance.Add(dictionary);
				return dictionary;
			}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002A74 File Offset: 0x00000C74
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> ListSystemsByRadio(global::Motorola.CommonCPS.Server.EntityModel.Radio rawRadio)
		{
			short num = (short)1556480000;
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
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						if (apxcodeplug.APXRadioSystems != null)
						{
							num = (short)313196546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 1:
						try
						{
							num = (short)889454595;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)721223682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1382350848;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem item = enumerator.Current.ToUiModel(rawRadio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
									list.Add(item);
									num = (short)253427716;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									num = (short)957316880;
									short num3 = num;
									num = (short)1338933008;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_9D;
									default:
										goto IL_17C;
									}
									break;
								}
								case 3:
									goto IL_9D;
								}
								goto IL_C2;
								IL_9D:
								switch (0)
								{
								case 0:
									IL_C2:
									goto IL_F5;
								}
								continue;
								IL_F5:
								num = (short)812515329;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_17C:
							num = (short)1125515264;
							if (num != 0)
							{
							}
							return list;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1A6;
					case 2:
						num = (short)1208090625;
						if (num != 0)
						{
						}
						goto IL_1A6;
					case 3:
						if (apxcodeplug != null)
						{
							num = (short)1357185028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 4:
						num = (short)1725104128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_44;
					IL_1A6:
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>();
					enumerator = apxcodeplug.APXRadioSystems.GetEnumerator();
					num = (short)839647232;
					short num4 = num;
					num = (short)39321601;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_44:
				list = null;
				apxcodeplug = (rawRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				num = (short)885325827;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002D00 File Offset: 0x00000F00
		private global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem a(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem result;
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.b b;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1974534145;
					if (num2 != 0)
					{
					}
					num2 = (short)113748348;
					short num3 = num2;
					num2 = (short)442673532;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1735524352;
						if (num2 != 0)
						{
						}
						if (A_0.Count <= 0)
						{
							return result;
						}
						break;
					}
					num2 = (short)1680670722;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return result;
				case 2:
					result = A_0.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem, bool>(b.b));
					num2 = (short)802619393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (A_0 != null)
					{
						num2 = (short)858193924;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
				{
					num2 = (short)1047592960;
					short num4 = num2;
					num2 = (short)1842085888;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			b = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.b();
			b.a = A_1;
			result = null;
			num2 = (short)1910636547;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002E7C File Offset: 0x0000107C
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> GetASTRODataProfiles(string groupID)
		{
			short num;
			global::System.Guid? guid;
			for (;;)
			{
				num = (short)1606680577;
				if (num != 0)
				{
				}
				num = (short)939851779;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_99;
					case 1:
						num = (short)1717764098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_127;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					}
					IL_5A:
					if (!string.IsNullOrEmpty(groupID))
					{
						num = (short)990052353;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						guid = null;
						num = (short)352649216;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_99:
				num = (short)158197357;
				short num3 = num;
				num = (short)1353377389;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_CF;
				}
			}
			IL_CF:
			num = (short)1640562688;
			short num4 = num;
			num = (short)1306263552;
			if (num != 0)
			{
			}
			global::System.Guid? groupId = guid;
			goto IL_134;
			IL_127:
			groupId = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_134:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTRODataProfileViewCache(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(groupId));
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002FC8 File Offset: 0x000011C8
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> GetRadiosByProfile(string groupID, string customId, string profileName)
		{
			short num = (short)285540352;
			switch (num)
			{
			default:
			{
				global::System.Guid? groupId;
				string[] array;
				for (;;)
				{
					IL_1D:
					num = (short)1131610115;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Guid? guid2;
						global::System.Guid? guid;
						switch (num2)
						{
						case 0:
						{
							num = (short)72783830;
							short num3 = num;
							num = (short)998217686;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D;
							default:
								num = (short)1358888960;
								if (num != 0)
								{
								}
								guid = guid2;
								goto IL_157;
							}
							break;
						}
						case 1:
						{
							num = (short)985530368;
							short num4 = num;
							guid = new global::System.Guid?(global::System.Guid.Parse(groupID));
							goto IL_157;
						}
						case 2:
							goto IL_18B;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_58;
							}
							continue;
						case 4:
							num = (short)457506817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_58:
						num = (short)1682374657;
						if (num != 0)
						{
						}
						if (!string.IsNullOrEmpty(groupID))
						{
							num = (short)658702340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						guid2 = null;
						num = (short)488833024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_157:
						groupId = guid;
						groupId = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(groupId);
						array = customId.Split(new char[]
						{
							'-'
						}, 4, global::System.StringSplitOptions.None);
						num = (short)774504450;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_18B:
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo profileInfo = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo
				{
					SystemType = (string.IsNullOrEmpty(array[0]) ? null : ((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?)global::System.Enum.Parse(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType), array[0]))),
					ProfileName = profileName
				};
				return new global::Motorola.CommonCPS.RadioManagement.LocalService.ProfileToRadioViewCache(groupId, profileInfo);
			}
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000031AC File Offset: 0x000013AC
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> GetProfileInfosbyRadio(string radioID)
		{
			short num = (short)585190439;
			short num2 = num;
			num = (short)1585466407;
			switch (num2 == num)
			{
			}
			num = (short)132710401;
			if (num != 0)
			{
			}
			num = (short)1333264384;
			short num3 = num;
			num = (short)941883392;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioToProfileViewCache(new global::System.Guid(radioID));
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003264 File Offset: 0x00001464
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo> GetASTROProfileInfos(string groupID)
		{
			short num;
			global::System.Guid? guid;
			for (;;)
			{
				num = (short)1640497155;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_74;
					case 1:
						num = (short)313327618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_128;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_35;
						}
						continue;
					}
					IL_35:
					if (!string.IsNullOrEmpty(groupID))
					{
						num = (short)444334081;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						guid = null;
						num = (short)1477050368;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_74:
				num = (short)519817915;
				short num3 = num;
				num = (short)546491067;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A9;
				}
			}
			IL_A9:
			num = (short)1951006720;
			if (num != 0)
			{
			}
			num = (short)1753546752;
			short num4 = num;
			num = (short)1189216257;
			if (num != 0)
			{
			}
			global::System.Guid? groupId = guid;
			goto IL_135;
			IL_128:
			groupId = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_135:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.ProfileInfoViewCache(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(groupId));
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000033B0 File Offset: 0x000015B0
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo> GetProfileRadioInfos(string groupID)
		{
			short num;
			global::System.Guid? guid;
			for (;;)
			{
				num = (short)1673265155;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_73;
					case 1:
						num = (short)201195522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_102;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					}
					IL_34:
					if (!string.IsNullOrEmpty(groupID))
					{
						num = (short)573308929;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						guid = null;
						num = (short)1663041536;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_73:
				num = (short)1496132962;
				short num3 = num;
				num = (short)794897762;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A9;
				}
			}
			IL_A9:
			num = (short)106168320;
			if (num != 0)
			{
			}
			num = (short)2145124352;
			short num4 = num;
			global::System.Guid? groupId = guid;
			goto IL_136;
			IL_102:
			num = (short)1869414401;
			if (num != 0)
			{
			}
			groupId = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_136:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.ProfileRadioInfoViewCache(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(groupId));
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003500 File Offset: 0x00001700
		public void RefreshDataProfileForRadio(global::Motorola.CommonCPS.Server.EntityModel.APXRadio aPXRadio)
		{
			short num = (short)1649344512;
			switch (num)
			{
			default:
			{
				num = (short)73465857;
				if (num != 0)
				{
				}
				num = (short)1301938176;
				short num2 = num;
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = (global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)aPXRadio.CurrentCodeplug;
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> enumerable = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListProfilesByRadio(aPXRadio.Uuid);
				global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> enumerator = enumerable.GetEnumerator();
				try
				{
					num = (short)1421672449;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)624492547;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.c c = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.c();
							c.a = enumerator.Current;
							global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile = apxcodeplug.APXDataProfiles.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile, bool>(c.b)).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>();
							num = (short)103940102;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_DD;
							}
							continue;
						case 3:
							num = (short)2143027205;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.c c;
							global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
							dictionary.Add(apxdataProfile.Uuid, c.a.ToUiModel(true));
							num = (short)1264910338;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_21F;
						case 6:
						{
							global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile;
							if (apxdataProfile != null)
							{
								num = (short)412352516;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_147:
						num = (short)738246090;
						short num4 = num;
						num = (short)49528266;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)597622784;
							if (num != 0)
							{
							}
							num = (short)1728512000;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_DD:
						goto IL_147;
					}
					IL_21F:;
				}
				finally
				{
					num = (short)1050804226;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1676345345;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_289;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_253;
							}
							continue;
						}
						IL_253:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1364656128;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_289:;
				}
				global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance.NotifyViewCacheReplaceItems<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>(dictionary);
				global::Motorola.CommonCPS.RadioManagement.LocalService.NewDataProfileCache.Instance.Add(dictionary);
				return;
			}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000037CC File Offset: 0x000019CC
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> ListProfilesByRadio(global::Motorola.CommonCPS.Server.EntityModel.Radio rawRadio)
		{
			short num = (short)1372520448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> list;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						if (apxcodeplug.APXDataProfiles != null)
						{
							num = (short)1392640000;
							short num3 = num;
							num = (short)1783431170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 1:
						try
						{
							num = (short)867762179;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1779564546;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1200816128;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile item = enumerator.Current.ToUiModel(rawRadio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
									list.Add(item);
									num = (short)435748868;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									num = (short)583406040;
									short num4 = num;
									num = (short)575738328;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_9E;
									default:
										goto IL_17E;
									}
									break;
								}
								case 3:
									goto IL_9E;
								}
								goto IL_C3;
								IL_9E:
								switch (0)
								{
								case 0:
									IL_C3:
									goto IL_F7;
								}
								continue;
								IL_F7:
								num = (short)2013790209;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_17E:
							num = (short)106037248;
							if (num != 0)
							{
							}
							return list;
						}
						finally
						{
							num = (short)507117569;
							if (num != 0)
							{
							}
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1CE;
					case 2:
						goto IL_1CE;
					case 3:
						if (apxcodeplug != null)
						{
							num = (short)1364721668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 4:
						num = (short)1245970432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_43;
					IL_1CE:
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>();
					enumerator = apxcodeplug.APXDataProfiles.GetEnumerator();
					num = (short)1374683137;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_43:
				list = null;
				apxcodeplug = (rawRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				num = (short)1230307331;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003A5C File Offset: 0x00001C5C
		private global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile a(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_1)
		{
			short num = (short)39452673;
			if (num != 0)
			{
			}
			num = (short)505815081;
			short num2 = num;
			num = (short)2070224937;
			switch (num2 == num)
			{
			}
			num = (short)1957953536;
			short num3 = num;
			num = (short)1829961728;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.d d = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.d();
			d.a = A_1;
			return A_0.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile, bool>(d.b));
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003B24 File Offset: 0x00001D24
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> GetASTROOtarProfiles(string groupID)
		{
			short num;
			global::System.Guid? guid;
			for (;;)
			{
				num = (short)1163132931;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_99;
					case 1:
						num = (short)524091394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_129;
					case 3:
						num = (short)1102839809;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					}
					IL_5C:
					if (!string.IsNullOrEmpty(groupID))
					{
						num = (short)622002177;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						guid = null;
						num = (short)1274150912;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_99:
				num = (short)1421368891;
				short num3 = num;
				num = (short)1436573243;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_D0;
				}
			}
			IL_D0:
			num = (short)1271595008;
			short num4 = num;
			num = (short)1260978176;
			if (num != 0)
			{
			}
			global::System.Guid? groupId = guid;
			goto IL_136;
			IL_129:
			groupId = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_136:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarProfileViewCache(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(groupId));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003C74 File Offset: 0x00001E74
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> GetASTRORadiosByOtarProfile(string groupID, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo otarProfileInfo)
		{
			short num;
			global::System.Guid? guid;
			for (;;)
			{
				num = (short)964755459;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_71;
					case 1:
						num = (short)1591803906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_12B;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					}
					IL_34:
					if (!string.IsNullOrEmpty(groupID))
					{
						num = (short)806617089;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						guid = null;
						num = (short)1665597440;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_71:
				num = (short)235995137;
				if (num != 0)
				{
				}
				num = (short)1010859598;
				short num3 = num;
				num = (short)2040364622;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_D1;
				}
			}
			IL_D1:
			num = (short)2122448896;
			short num4 = num;
			num = (short)63176704;
			if (num != 0)
			{
			}
			global::System.Guid? groupId = guid;
			goto IL_138;
			IL_12B:
			groupId = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_138:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarProfileToRadioViewCache(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(groupId), otarProfileInfo);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003DC4 File Offset: 0x00001FC4
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> GetASTROOtarProfileInfosbyRadio(string radioID)
		{
			short num = (short)2082771817;
			short num2 = num;
			num = (short)450073449;
			switch (num2 == num)
			{
			}
			num = (short)435093504;
			if (num != 0)
			{
			}
			num = (short)1486094336;
			short num3 = num;
			num = (short)713687041;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarRadioToProfileViewCache(new global::System.Guid(radioID));
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003E78 File Offset: 0x00002078
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo> GetASTROOtarProfileInfos(string groupID)
		{
			short num = (short)659488768;
			short num2 = num;
			num = (short)298484662;
			short num3 = num;
			num = (short)1677624246;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F8:
				num = (short)1209204736;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1808400384;
				if (num != 0)
				{
				}
				num = (short)1864957955;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				num = (short)121176065;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					goto IL_10D;
				case 1:
					num = (short)589103106;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_128;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_D1;
					}
					continue;
				}
				IL_D1:
				if (string.IsNullOrEmpty(groupID))
				{
					break;
				}
				num = (short)404029441;
				num4 = (int)((global::System.IntPtr)num);
			}
			global::System.Guid? guid = null;
			goto IL_F8;
			IL_10D:
			global::System.Guid? groupId = guid;
			goto IL_135;
			IL_128:
			groupId = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_135:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarProfileInfoViewCache(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(groupId));
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003FC4 File Offset: 0x000021C4
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo> GetASTROOtarProfileRadioInfos(string groupID)
		{
			short num = (short)822476800;
			short num2 = num;
			num = (short)302847102;
			short num3 = num;
			num = (short)298062974;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F6:
				num = (short)1945632771;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)538116096;
				if (num != 0)
				{
				}
				num = (short)1768620032;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				case 1:
					num = (short)322633730;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_125;
				case 3:
					goto IL_10B;
				}
				IL_A9:
				if (string.IsNullOrEmpty(groupID))
				{
					break;
				}
				num = (short)388825089;
				if (num != 0)
				{
				}
				num = (short)1046544385;
				num4 = (int)((global::System.IntPtr)num);
			}
			global::System.Guid? guid = null;
			goto IL_F6;
			IL_10B:
			global::System.Guid? groupId = guid;
			goto IL_132;
			IL_125:
			groupId = new global::System.Guid?(global::System.Guid.Parse(groupID));
			IL_132:
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarProfileRadioInfoViewCache(global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.ConvertGroupID(groupId));
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00004110 File Offset: 0x00002310
		public void RefreshASTROOtarProfilesForOneRadioFromCache(global::Motorola.CommonCPS.Server.EntityModel.APXRadio aPXRadio, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile currentASTROOtarProfile)
		{
			short num = (short)1950003644;
			short num2 = num;
			num = (short)398766524;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_279;
			case 1:
				break;
			default:
			{
				num = (short)665583616;
				short num3 = num;
				break;
			}
			}
			num = (short)1568407552;
			if (num != 0)
			{
			}
			num = (short)1540423680;
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> dictionary;
			switch (num)
			{
			default:
			{
				global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.e e = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.e();
				e.a = currentASTROOtarProfile;
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> enumerable = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)aPXRadio.WorkingCodeplug).APXOtarProfiles.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile, bool>(e.b));
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> enumerator = enumerable.GetEnumerator();
				try
				{
					num = (short)1327038468;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile astrootarProfile;
						switch (num4)
						{
						case 0:
							astrootarProfile.TemplateName = e.a.TemplateName;
							num = (short)1351680001;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1CB;
						case 2:
							if (e.a.TemplateName != null)
							{
								num = (short)1435566080;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CB;
						case 3:
							if (!enumerator.MoveNext())
							{
								num = (short)932118535;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							astrootarProfile = enumerator.Current.ToUiModel(aPXRadio);
							num = (short)2055012354;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_117;
							}
							continue;
						case 5:
							goto IL_20D;
						case 7:
							num = (short)1742798853;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_163:
						num = (short)151977987;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_117:
						goto IL_163;
						IL_1CB:
						dictionary.Add(astrootarProfile.ASTROOtarProfileID, astrootarProfile);
						num = (short)1563623430;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_20D:;
				}
				finally
				{
					num = (short)1699807232;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_241;
							}
							continue;
						case 1:
							goto IL_276;
						case 2:
							enumerator.Dispose();
							num = (short)698286081;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_241:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1983971330;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_276:;
				}
				break;
			}
			}
			IL_279:
			num = (short)1470496769;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance.NotifyViewCacheReplaceItems<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(dictionary);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000043E8 File Offset: 0x000025E8
		public void RefreshASTROOtarProfilesForOneRadioFromDB(global::Motorola.CommonCPS.Server.EntityModel.APXRadio aPXRadio)
		{
			short num = (short)2105564642;
			short num2 = num;
			num = (short)519069154;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_283;
			case 1:
				break;
			default:
			{
				num = (short)1382285312;
				short num3 = num;
				break;
			}
			}
			num = (short)154730496;
			if (num != 0)
			{
			}
			num = (short)1418395649;
			if (num != 0)
			{
			}
			num = (short)716767232;
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> dictionary;
			switch (num)
			{
			default:
			{
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = (global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)aPXRadio.WorkingCodeplug;
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> apxotarProfilesByRadio = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetAPXOtarProfilesByRadio(aPXRadio.Uuid);
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> enumerator = apxotarProfilesByRadio.GetEnumerator();
				try
				{
					num = (short)1433534467;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxotarProfile;
							if (apxotarProfile != null)
							{
								num = (short)637665282;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_215;
						case 2:
						{
							global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxotarProfile;
							global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.f f;
							dictionary.Add(apxotarProfile.Uuid, f.a.ToUiModel(false));
							num = (short)2003173381;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_127;
							}
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)272367622;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.f f = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.f();
							f.a = enumerator.Current;
							global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxotarProfile = apxcodeplug.APXOtarProfiles.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile, bool>(f.b)).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile>();
							num = (short)436207616;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)71892993;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_18C:
						num = (short)1138229252;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_127:
						goto IL_18C;
					}
					IL_215:;
				}
				finally
				{
					num = (short)1642201088;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_249;
							}
							continue;
						case 1:
							goto IL_280;
						case 2:
							enumerator.Dispose();
							num = (short)677117953;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_249:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1877409794;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_280:;
				}
				break;
			}
			}
			IL_283:
			global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance.NotifyViewCacheReplaceItems<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(dictionary);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000046A0 File Offset: 0x000028A0
		public void RefreshASTROOtarProfilesForRadio(global::Motorola.CommonCPS.Server.EntityModel.APXRadio aPXRadio)
		{
			short num = (short)562057295;
			short num2 = num;
			num = (short)1836798031;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_288;
			case 1:
				break;
			default:
			{
				num = (short)739704832;
				short num3 = num;
				break;
			}
			}
			num = (short)1599602688;
			if (num != 0)
			{
			}
			num = (short)1743585280;
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> dictionary;
			switch (num)
			{
			default:
			{
				num = (short)1781137409;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = (global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)aPXRadio.CurrentCodeplug;
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> apxotarProfilesByRadio = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetAPXOtarProfilesByRadio(aPXRadio.Uuid);
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> enumerator = apxotarProfilesByRadio.GetEnumerator();
				try
				{
					num = (short)1968046083;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxotarProfile;
							if (apxotarProfile != null)
							{
								num = (short)177274882;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_21C;
						case 2:
						{
							global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxotarProfile;
							global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.g g;
							dictionary.Add(apxotarProfile.Uuid, g.a.ToUiModel(false));
							num = (short)627507205;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_129;
							}
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1664548870;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.g g = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.g();
							g.a = enumerator.Current;
							global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile apxotarProfile = apxcodeplug.APXOtarProfiles.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile, bool>(g.b)).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile>();
							num = (short)1325727744;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)1995636737;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_191:
						num = (short)1878589444;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_129:
						goto IL_191;
					}
					IL_21C:;
				}
				finally
				{
					num = (short)781647872;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_250;
							}
							continue;
						case 1:
							goto IL_285;
						case 2:
							enumerator.Dispose();
							num = (short)467730433;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_250:
						if (enumerator == null)
						{
							break;
						}
						num = (short)459735042;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_285:;
				}
				break;
			}
			}
			IL_288:
			global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance.NotifyViewCacheReplaceItems<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(dictionary);
			global::Motorola.CommonCPS.RadioManagement.LocalService.NewASTROOtarProfileCache.Instance.Add(dictionary);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004968 File Offset: 0x00002B68
		public override void RefreshASTROOtarProfilesForFillUpDown(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> selectedItems)
		{
			short num = (short)1360148670;
			short num2 = num;
			num = (short)2010921150;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1341390848;
				if (num != 0)
				{
				}
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio>.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.GetRadioList().GetEnumerator())
				{
					num = (short)154599426;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_184;
						case 1:
						{
							string a_ = selectedItems.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile, bool>(h.b)).Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.a)).FirstOrDefault<string>();
							this.a(h.a, a_);
							num = (short)2051342340;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_9C;
							}
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1859125253;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.APXRadio a = (global::Motorola.CommonCPS.Server.EntityModel.APXRadio)enumerator.Current;
							num = (short)2132475905;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)896729088;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E6:
						num = (short)466485251;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_9C:
						goto IL_E6;
					}
					IL_184:;
				}
				break;
			}
			num = (short)1012400129;
			if (num != 0)
			{
			}
			num = (short)1654521856;
			short num4 = num;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004B7C File Offset: 0x00002D7C
		private void a(global::Motorola.CommonCPS.Server.EntityModel.APXRadio A_0, string A_1)
		{
			short num = (short)354186013;
			short num2 = num;
			num = (short)2019259165;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_341:
				num = (short)98959363;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1649737728;
				if (num != 0)
				{
				}
				num = (short)159318016;
				switch (num)
				{
				default:
					num = (short)192282625;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> dictionary;
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> enumerator;
				switch (num3)
				{
				case 0:
					if (dictionary.Count<global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>>() > 0)
					{
						num = (short)331022340;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A3;
					}
					continue;
				case 2:
					try
					{
						num = (short)1597636608;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Guid? id;
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile astrootarProfile;
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_176;
								}
								continue;
							case 1:
								if (id != null)
								{
									num = (short)566820869;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 2:
								num = (short)1516044295;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								astrootarProfile.TemplateName = A_1;
								num = (short)52297736;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								id = astrootarProfile.ID;
								global::System.Guid value = id.Value;
								dictionary.Add(value, astrootarProfile);
								num = (short)535429123;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								if (!enumerator.MoveNext())
								{
									num = (short)564461570;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								astrootarProfile = enumerator.Current.ToUiModel(A_0);
								num = (short)2014445577;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_2AA;
							case 8:
								goto IL_1B0;
							case 9:
								if (A_1 != null)
								{
									num = (short)267649028;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1B0;
							}
							IL_178:
							num = (short)1046413318;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_176:
							goto IL_178;
							IL_1B0:
							id = astrootarProfile.ID;
							num = (short)1531904001;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_2AA:
						goto IL_C3;
					}
					finally
					{
						num = (short)1371865088;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2E3;
								}
								continue;
							case 1:
								goto IL_31A;
							case 2:
								enumerator.Dispose();
								num = (short)177995777;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2E3:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1356398594;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_31A:;
					}
					goto IL_31D;
					IL_C3:
					num = (short)968425472;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_35A;
				case 4:
					goto IL_FB;
				}
				goto IL_A3;
				IL_386:
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> apxotarProfiles;
				global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile, bool> predicate;
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> enumerable = apxotarProfiles.Where(predicate);
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>();
				enumerator = enumerable.GetEnumerator();
				num = (short)1575682050;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_31D:
				predicate = (global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9__25_0 = new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.a));
				goto IL_386;
				IL_A3:
				apxotarProfiles = ((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)A_0.WorkingCodeplug).APXOtarProfiles;
				if ((predicate = global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9__25_0) == null)
				{
					goto IL_31D;
				}
				goto IL_386;
			}
			IL_FB:
			num = (short)1824653313;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance.NotifyViewCacheReplaceItems<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>(dictionary);
			goto IL_341;
			IL_35A:
			num = (short)396754944;
			short num4 = num;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004F5C File Offset: 0x0000315C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> ListASTROOtarProfilesByRadioWorkingCP(global::Motorola.CommonCPS.Server.EntityModel.Radio rawRadio)
		{
			short num = (short)1390411776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> list;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (apxcodeplug != null)
						{
							num = (short)2125856769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 1:
						num = (short)966197250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (apxcodeplug.APXOtarProfiles == null)
						{
							return list;
						}
						num = (short)24117248;
						short num3 = num;
						num = (short)475041775;
						short num4 = num;
						num = (short)594120687;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_183;
						default:
							num = (short)296419328;
							if (num != 0)
							{
							}
							num = (short)1302790148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_183;
					case 4:
						goto IL_158;
					}
					goto IL_42;
					IL_158:
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>();
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile>.Enumerator enumerator = apxcodeplug.APXOtarProfiles.GetEnumerator();
					num = (short)1172439043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_183:
					num = (short)822411265;
					if (num != 0)
					{
					}
					try
					{
						num = (short)1870528512;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_C1;
								}
								continue;
							case 2:
								num = (short)512360452;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)273809410;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile item = enumerator.Current.ToUiModel(rawRadio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
								list.Add(item);
								num = (short)377618433;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_145;
							}
							IL_F4:
							num = (short)1908473859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C1:
							goto IL_F4;
						}
						IL_145:
						break;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_158;
				}
				return list;
				IL_42:
				list = null;
				apxcodeplug = (rawRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				num = (short)1282408448;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000051E0 File Offset: 0x000033E0
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile a(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> A_0, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile A_1)
		{
			short num = (short)95420416;
			short num2 = num;
			num = (short)1697611456;
			short num3 = num;
			num = (short)281640640;
			switch (num3 == num)
			{
			}
			num = (short)226557953;
			if (num != 0)
			{
			}
			num = (short)612761600;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.i i = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.i();
			i.a = A_1;
			return A_0.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile, bool>(i.b));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000052A8 File Offset: 0x000034A8
		public override global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> ListAppLicenses()
		{
			short num = (short)2122121216;
			short num2 = num;
			num = (short)761171163;
			short num3 = num;
			num = (short)1214221531;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1474101248;
				if (num != 0)
				{
				}
				num = (short)55377920;
				switch (num)
				{
				}
				break;
			}
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo>();
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo> enumerator = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.GetRadioMgmtFeature().GetEnumerator();
			try
			{
				num = (short)132710400;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_E9;
						}
						continue;
					case 2:
						num = (short)1237712900;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)80019458;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo appLicenseInfo = enumerator.Current;
						global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo item = new global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo(appLicenseInfo.FeatureName, appLicenseInfo.RadioCapacity.ToString(global::System.Globalization.CultureInfo.CurrentCulture), appLicenseInfo.UsedRadioCount.ToString(global::System.Globalization.CultureInfo.CurrentCulture), null, appLicenseInfo.AppFeatureSummary, appLicenseInfo.FeatureType, appLicenseInfo.Region);
						list.Add(item);
						num = (short)2022572033;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1B2;
					}
					IL_15B:
					num = (short)2095316995;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_E9:
					goto IL_15B;
				}
				IL_1B2:;
			}
			finally
			{
				num = (short)1620508672;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)674758657;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_20F;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)1545469954;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_246;
					}
					IL_20F:
					if (enumerator == null)
					{
						break;
					}
					num = (short)212008961;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_246:;
			}
			return list;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000551C File Offset: 0x0000371C
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> GetFirmwarePackages()
		{
			short num = (short)1203568640;
			short num2 = num;
			num = (short)393154014;
			short num3 = num;
			num = (short)1193610718;
			switch (num3 == num)
			{
			}
			num = (short)1097072641;
			if (num != 0)
			{
			}
			num = (short)157089792;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.FirmwareViewCache();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000055C8 File Offset: 0x000037C8
		public override void CopyRadioIdentity(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioToCopy, out global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> copyRadioIdentityInfo, out global::Motorola.CommonCPS.Server.EntityModel.Radio validateRadio)
		{
			short num = (short)1507328000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> collection;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> apxradioSystems;
					switch (num2)
					{
					case 0:
						if (validateRadio != null)
						{
							num = (short)1296171010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						try
						{
							num = (short)785121280;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_20C;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)971702275;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem = enumerator.Current;
									apxradioSystem.ToUiModel(validateRadio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
									copyRadioIdentityInfo.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>(apxradioSystem.Uuid, apxradioSystem.Timestamp));
									num = (short)229113858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)888799236;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_2AC;
								}
								IL_20E:
								num = (short)1773010945;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20C:
								goto IL_20E;
							}
							IL_2AC:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_4;
					case 2:
					{
						num = (short)2122447032;
						short num3 = num;
						num = (short)240122040;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)1921581057;
							if (num != 0)
							{
							}
							num = (short)1802633216;
							short num4 = num;
							num = (short)135593984;
							if (num != 0)
							{
							}
							copyRadioIdentityInfo.AddRange(collection);
							global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = validateRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
							num = (short)1063059459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
						if (apxcodeplug != null)
						{
							num = (short)323158021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						goto IL_2BF;
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> apxdataProfiles = apxcodeplug.APXDataProfiles;
						apxradioSystems = apxcodeplug.APXRadioSystems;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2 = apxdataProfiles.GetEnumerator();
						num = (short)2000027652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_46;
					Block_4:
					try
					{
						IL_2BF:
						num = (short)965279744;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2F9;
								}
								continue;
							case 1:
							{
								global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2;
								if (!enumerator2.MoveNext())
								{
									num = (short)218169347;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile = enumerator2.Current;
								apxdataProfile.ToUiModel(validateRadio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
								copyRadioIdentityInfo.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>(apxdataProfile.Uuid, apxdataProfile.Timestamp));
								num = (short)1960706050;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								num = (short)2144796676;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_399;
							}
							IL_2FB:
							num = (short)1927806977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2F9:
							goto IL_2FB;
						}
						IL_399:
						goto IL_8D;
					}
					finally
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator2;
						((global::System.IDisposable)enumerator2).Dispose();
					}
					break;
					IL_8D:
					enumerator = apxradioSystems.GetEnumerator();
					num = (short)1748893697;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_46:
				copyRadioIdentityInfo = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>>();
				validateRadio = null;
				base.CopyRadioIdentity(radioToCopy, out collection, out validateRadio);
				num = (short)1873805312;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000059A0 File Offset: 0x00003BA0
		public bool CheckAstroPop25Enabled()
		{
			short num = (short)1381957632;
			short num2 = num;
			num = (short)2120257552;
			short num3 = num;
			num = (short)668176400;
			switch (num3 == num)
			{
			}
			num = (short)710213632;
			if (num != 0)
			{
			}
			num = (short)400883713;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.ValidatePop25Enabled();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00005A58 File Offset: 0x00003C58
		public global::System.Collections.Generic.List<string> GetSupportedCodelugVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string maxCodeplugVersionOfRadio)
		{
			short num = (short)1699676160;
			short num2 = num;
			num = (short)206647991;
			short num3 = num;
			num = (short)210580151;
			switch (num3 == num)
			{
			}
			num = (short)1010171905;
			if (num != 0)
			{
			}
			num = (short)752549888;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.GetSupportedCodelugVersion(productFamily, maxCodeplugVersionOfRadio);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005B10 File Offset: 0x00003D10
		public global::System.Collections.Generic.List<string> GetSupportedCodelugVersion_forUpgradeCPVersion(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily, string maxCodeplugVersionOfRadio)
		{
			short num = (short)1818755072;
			short num2 = num;
			num = (short)1948047322;
			short num3 = num;
			num = (short)17946586;
			switch (num3 == num)
			{
			}
			num = (short)1935867905;
			if (num != 0)
			{
			}
			num = (short)1317339136;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.GetSupportedCodelugVersion_forUpgradeCPVersion(productFamily, maxCodeplugVersionOfRadio);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005BCC File Offset: 0x00003DCC
		public override global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext GenerateSelectFirmwareContext(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios)
		{
			int a_ = 1;
			short num = (short)2008023040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)2048903544;
				short num3 = num;
				num = (short)579389816;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_13F:
					num = (short)483524615;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)2102394880;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_C9;
					}
					break;
				}
				global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext;
				string maximumCpWorkingVer;
				for (;;)
				{
					IL_7A:
					global::System.Collections.Generic.List<string> supportedCodelugVersion;
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily;
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily3;
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> enumerable;
					string text;
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> enumerable2;
					switch (num2)
					{
					case 0:
						if (supportedCodelugVersion.Count > 0)
						{
							num = (short)707198993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_166;
					case 1:
						goto IL_166;
					case 2:
						productFamily = productFamily2.GetValueOrDefault();
						goto IL_318;
					case 3:
						num = (short)1072824334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (productFamily2 == null)
						{
							num = (short)1466499075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1211432962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (productFamily3 != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
						{
							num = (short)1465909260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13F;
					case 6:
						if (enumerable.Count<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>() > 0)
						{
							num = (short)90243083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return selectFirmwareContext;
					case 7:
						enumerable2 = this.LoadAvailableFWPackagesForAMPUpgrade(radios, true, text);
						goto IL_227;
					case 8:
						if (enumerable != null)
						{
							num = (short)1348730896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return selectFirmwareContext;
					case 9:
						return selectFirmwareContext;
					case 10:
						num = (short)1060569089;
						if (num != 0)
						{
						}
						num = (short)1419902976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						selectFirmwareContext.FirmwaresForMaxCodeplugVersion = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>(enumerable);
						selectFirmwareContext.Firmwares = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>(enumerable);
						selectFirmwareContext.SelectedFirmware = selectFirmwareContext.Firmwares[0];
						selectFirmwareContext.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.SelectFirmwareContextValidator();
						num = (short)1720582153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1013186573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						enumerable2 = this.LoadAvailableFWPackagesForASTROUpgrade(radios, true, text);
						goto IL_227;
					case 14:
						productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX;
						goto IL_318;
					case 15:
						if (supportedCodelugVersion != null)
						{
							num = (short)1840840714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_166;
					case 16:
						num = (short)1005387782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						text = supportedCodelugVersion[0];
						selectFirmwareContext.MaxCodeplugVersion = text;
						supportedCodelugVersion.Insert(0, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("娚焜栞䀠娢嘤ܦ䔨䨪夬䨮䈰䜲ᔴ䄶尸䤺丼嘾⹀ⵂ", a_));
						selectFirmwareContext.Codeplugs = new global::System.Collections.ObjectModel.ObservableCollection<string>(supportedCodelugVersion);
						selectFirmwareContext.SelectedCodeplug = supportedCodelugVersion.First<string>();
						num = (short)191758337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C9;
					IL_166:
					num = (short)1429602309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_227:
					enumerable = enumerable2;
					num = (short)254279688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_318:
					productFamily3 = productFamily;
					supportedCodelugVersion = this.GetSupportedCodelugVersion(productFamily3, maximumCpWorkingVer);
					text = null;
					num = (short)1600389120;
					short num4 = num;
					num = (short)119799823;
					num2 = (int)((global::System.IntPtr)num);
				}
				return selectFirmwareContext;
				IL_C9:
				maximumCpWorkingVer = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.GetMaximumCpWorkingVer(radios);
				selectFirmwareContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext();
				selectFirmwareContext.IsRefresh = true;
				selectFirmwareContext.Radios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(radios);
				selectFirmwareContext.IsASKDialogVisible = false;
				productFamily2 = radios[0].ProductFamily;
				num = (short)216662020;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_7A;
			}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00005FF4 File Offset: 0x000041F4
		public override bool CheckFirmwareAfterReadRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext)
		{
			short num = (short)1081839354;
			short num2 = num;
			num = (short)263098106;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_88;
			default:
				num = (short)1662648320;
				if (num != 0)
				{
				}
				num = (short)1940258816;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					break;
				}
				break;
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroradio;
			for (;;)
			{
				IL_71:
				switch (num3)
				{
				case 0:
				{
					bool flag = this.a(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>
					{
						astroradio
					});
					char c = astroradio.FirmwareVersion[0];
					string a = string.Empty;
					char c2 = selectFirmwareContext.SelectedFirmware.Version[0];
					string b = string.Empty;
					if (!char.IsDigit(c))
					{
						a = astroradio.FirmwareVersion.Substring(1);
					}
					if (!char.IsDigit(c2))
					{
						b = selectFirmwareContext.SelectedFirmware.Version.Substring(1);
					}
					if (!flag)
					{
						num = (short)46137346;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 1:
				{
					string a;
					string b;
					if (string.Equals(a, b))
					{
						num = (short)399966211;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 2:
					num = (short)775225345;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1B5;
				}
				goto IL_88;
			}
			IL_1B5:
			num = (short)1318060033;
			if (num != 0)
			{
			}
			num = (short)1473445888;
			short num4 = num;
			return false;
			IL_88:
			astroradio = ((global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.GetRadioByDeviceID(selectFirmwareContext.Radios[0].SerialNumber, false) as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).ToUiModel(true) as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
			selectFirmwareContext.Radios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
			{
				astroradio
			};
			num = (short)2020212736;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_71;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000620C File Offset: 0x0000440C
		public global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> LoadAvailableFWPackagesForASTROUpgrade(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radioList, bool isRefresh, string codeplugVersion = null)
		{
			short num = (short)1867186176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.j j;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> a_;
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
						{
							if (!isRefresh)
							{
								num = (short)477102083;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2058570769;
							short num3 = num;
							num = (short)1470123025;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_7C;
							default:
								num = (short)666370048;
								if (num != 0)
								{
								}
								num = (short)2016346119;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_B8;
						case 2:
							j.a = this.a(radioList.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.a)).Distinct<string>().ToList<string>());
							num = (short)1850015750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_110;
						case 4:
							goto IL_DC;
						case 5:
							num = (short)1282736132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (string.IsNullOrEmpty(j.a))
							{
								num = (short)1138098181;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							a_ = radioList.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(j.b)).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>();
							num = (short)206766080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							num = (short)818479104;
							short num4 = num;
							num = (short)416088065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_4F;
					}
					IL_B8:
					bool flag = this.a(a_);
					goto IL_241;
					IL_DC:
					return null;
					IL_110:
					flag = true;
					IL_241:
					bool isEqual = flag;
					bool isFreon = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).IsFreon(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX, radioList[0].ModelNumber);
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> list = (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROFirmwarePackageService).LoadAvailablePackages(radioList[0].ModelNumber, j.a, isFreon, isEqual, codeplugVersion).ToUimFirmwares<global::Motorola.CommonCPS.Server.EntityModel.Package>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>();
					list.Sort();
					return list;
				}
				}
				IL_4F:
				num = (short)1149894657;
				if (num != 0)
				{
				}
				j = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.j();
				IL_7C:
				num = (short)1600323586;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000064B8 File Offset: 0x000046B8
		public global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> LoadAvailableFWPackagesForAMPUpgrade(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radioList, bool isRefresh, string maxSupportedCodeplugVersion)
		{
			short num = (short)715024913;
			short num2 = num;
			num = (short)1166436881;
			global::System.Collections.Generic.List<string> list;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_220:
				list = radioList.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.d)).Select(new global::System.Func<string, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.a)).ToList<string>();
				num = (short)1303707648;
				short num3 = num;
				num = (short)2070347789;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)493355008;
				if (num != 0)
				{
				}
				num = (short)1841627136;
				num4 = (int)num;
				switch (num4)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_B7;
					}
					break;
				}
				break;
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.k k;
			bool flag;
			bool includeEqualPackageVersion;
			for (;;)
			{
				IL_74:
				bool flag2;
				switch (num4)
				{
				case 0:
					num = (short)487653385;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					global::System.Collections.Generic.List<string> a_ = radioList.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.b)).Distinct<string>().ToList<string>();
					k.a = this.a(a_, out flag);
					num = (short)310640644;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> a_2;
					flag2 = this.a(a_2);
					goto IL_3BC;
				}
				case 3:
					goto IL_2FC;
				case 4:
					if (!flag)
					{
						num = (short)448921600;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BF;
				case 5:
					goto IL_1BF;
				case 6:
					goto IL_220;
				case 7:
					flag2 = true;
					goto IL_3BC;
				case 8:
					if (string.IsNullOrEmpty(k.a))
					{
						num = (short)2099183627;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1624702982;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					global::System.Collections.Generic.List<string> radioSerialNumbers = radioList.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.c)).ToList<string>();
					flag = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).IsFirmwareVersionModified(radioSerialNumbers);
					num = (short)1295384581;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					num = (short)1726480385;
					if (num != 0)
					{
					}
					if (isRefresh)
					{
						num = (short)1988493324;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1823408135;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_1FF;
				case 12:
					num = (short)1940455426;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					if (!list.IsEqualInAll(new global::System.Func<string, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.b)))
					{
						num = (short)325844995;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> a_2 = radioList.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(k.b)).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>();
					num = (short)1565392906;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 14:
					goto IL_3D6;
				}
				goto IL_B7;
				IL_1BF:
				num = (short)684064776;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_3BC:
				includeEqualPackageVersion = flag2;
				num = (short)1118633998;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_1FF:
			return global::System.Linq.Enumerable.Empty<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>();
			IL_2FC:
			return global::System.Linq.Enumerable.Empty<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>();
			IL_3D6:
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IAstroAmpFirmwarePackageService astroAmpFirmwarePackageService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GetPackageManagementService(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP) as global::Motorola.CommonCPS.RadioManagement.SharedServices.IAstroAmpFirmwarePackageService;
			if (astroAmpFirmwarePackageService == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ASTRO_RMC_UpdateRadioData_PackageManagementService_NOT_FOUND);
			}
			string targetModel = list.First<string>();
			string bpSoftwareVersion = (!flag && this.a(radioList)) ? radioList.First<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().BBFBundleVersion : null;
			return astroAmpFirmwarePackageService.LoadAvailablePackages(k.a, targetModel, bpSoftwareVersion, flag, maxSupportedCodeplugVersion, includeEqualPackageVersion).ToUimFirmwares<global::Motorola.CommonCPS.Server.EntityModel.Package>().OrderBy(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.a)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>();
			IL_B7:
			k = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.k();
			num = (short)125108225;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_74;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00006930 File Offset: 0x00004B30
		public void CheckDevicesIsMatchFlashKey(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedRadios, out string newFlashCode, out string warning)
		{
			short num = (short)1931345920;
			short num2 = num;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.Radio> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio>();
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = selectedRadios.GetEnumerator();
			try
			{
				num = (short)1898184707;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_137;
					case 1:
					{
						num = (short)273905448;
						short num4 = num;
						num = (short)1068136232;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)217120768;
							if (num != 0)
							{
							}
							if (!enumerator.MoveNext())
							{
								num = (short)1469120516;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						global::Motorola.CommonCPS.Server.EntityModel.Radio item = enumerator.Current.ToServerModel();
						list.Add(item);
						num = (short)1256849410;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					case 4:
						num = (short)1263403008;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_9E:
					num = (short)932249601;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_72:
					goto IL_9E;
				}
				IL_137:;
			}
			finally
			{
				num = (short)1564803073;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)715063297;
						if (num != 0)
						{
						}
						enumerator.Dispose();
						num = (short)1805123586;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_16E;
						}
						continue;
					case 2:
						goto IL_1CA;
					}
					IL_16E:
					if (enumerator == null)
					{
						break;
					}
					num = (short)329449472;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1CA:;
			}
			(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).CheckDevicesIsMatchFlashKey(list, out newFlashCode, out warning);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00006B40 File Offset: 0x00004D40
		public bool IsRadioSupportWriteLPWhenUpgrade(global::System.Guid radioUuid, string packageVersion)
		{
			short num = (short)108892858;
			short num2 = num;
			num = (short)215454394;
			switch (num2 == num)
			{
			}
			num = (short)754712577;
			if (num != 0)
			{
			}
			num = (short)75628544;
			if (num != 0)
			{
			}
			num = (short)1921843200;
			short num3 = num;
			return (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).IsRadioSupportWriteLPWhenUpgrade(radioUuid, packageVersion);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00006BFC File Offset: 0x00004DFC
		public bool AstroCheckAskEnable(string flashcode, string modelNumber)
		{
			short num = (short)606332921;
			short num2 = num;
			num = (short)1190651897;
			switch (num2 == num)
			{
			}
			num = (short)2123169793;
			if (num != 0)
			{
			}
			num = (short)1452539904;
			if (num != 0)
			{
			}
			num = (short)489357312;
			short num3 = num;
			return (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).AstroCheckAskEnable(flashcode, modelNumber);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00006CBC File Offset: 0x00004EBC
		public void GetRadioDataForQueryRadioOperation(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio astroDevice, global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext context)
		{
			int a_ = 15;
			short num = (short)1483210752;
			switch (num)
			{
			default:
			{
				num = (short)2120417280;
				short num2 = num;
				global::ASK.Interface.ISystemKeyData systemKeyData = null;
				try
				{
					num = (short)962723858;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						int id;
						global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
						bool flag;
						global::ASK.Interface.ISystemKeyData selectSystemKeyData;
						switch (num3)
						{
						case 0:
						{
							int? num4 = astroDevice.OwnerSystemId;
							id = num4.Value;
							systemKeyData = new global::CommonASK.SystemKeyData(global::ASK.Interface.KeyAccessLevelType.UNLM_ACC, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᤨ", a_), false, global::ASK.Interface.KeySource.HARDWARE, id, global::ASK.Interface.KeyType.ADVANCED_WACN_KEY, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᤨ", a_), false);
							num = (short)2066350091;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_105;
						case 2:
							context.WriteProtect = (astroDevice.DisableWriteProtect != null && astroDevice.DisableWriteProtect.Value);
							id = 0;
							num = (short)1119289353;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							int? num4 = astroDevice.OwnerAdvKeyType;
							int num5 = 0;
							num = (short)1087373327;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_64E;
						case 5:
						{
							num = (short)2031370714;
							short num6 = num;
							num = (short)2111914458;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_667;
							default:
								num = (short)1578172416;
								if (num != 0)
								{
								}
								context.AllSystemKeys.Add(systemKeyData);
								context.SelectSystemKeyData = systemKeyData;
								num = (short)2130247686;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_64E;
						case 7:
						{
							int? num4 = astroDevice.OwnerSystemId;
							id = num4.Value;
							systemKeyData = new global::CommonASK.SystemKeyData(global::ASK.Interface.KeyAccessLevelType.UNLM_ACC, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᤨ", a_), false, global::ASK.Interface.KeySource.HARDWARE, id, global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᤨ", a_), false);
							num = (short)1588068371;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							try
							{
								num = (short)1363214343;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)806354952;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::ASK.Interface.ISystemKeyData systemKeyData2 = enumerator.Current;
										num = (short)840499205;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_2EE;
									case 2:
										num = (short)769327107;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										global::ASK.Interface.ISystemKeyData systemKeyData2;
										if (systemKeyData2.SystemIDHex == systemKeyData.SystemIDHex)
										{
											num = (short)1170079750;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
										goto IL_2D6;
									case 5:
									{
										global::ASK.Interface.ISystemKeyData systemKeyData2;
										if (systemKeyData2.Type == systemKeyData.Type)
										{
											num = (short)1808203778;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
									{
										flag = true;
										global::ASK.Interface.ISystemKeyData systemKeyData2;
										selectSystemKeyData = systemKeyData2;
										num = (short)2096037892;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										switch (0)
										{
										case 0:
											goto IL_1E2;
										}
										continue;
									case 8:
										goto IL_2D6;
									}
									IL_29B:
									num = (short)576913408;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1E2:
									goto IL_29B;
									IL_2D6:
									num = (short)1757478913;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_2EE:
								goto IL_138;
							}
							finally
							{
								num = (short)1729953793;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1243086850;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_325;
										}
										continue;
									case 2:
										goto IL_35C;
									}
									IL_325:
									if (enumerator == null)
									{
										break;
									}
									num = (short)706936832;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_35C:;
							}
							goto IL_35F;
							IL_138:
							num = (short)269680652;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (context.SelectedkeyType == global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY)
							{
								num = (short)647233543;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)103612430;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_667;
						case 11:
							goto IL_5AC;
						case 12:
							if (!flag)
							{
								num = (short)296550405;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_35F;
						case 13:
							goto IL_105;
						case 14:
							if (context.SelectedkeyType == global::ASK.Interface.KeyType.ADVANCED_WACN_KEY)
							{
								num = (short)2138308608;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5AC;
						case 15:
						{
							int? num4;
							int num5;
							if (num4.GetValueOrDefault() == num5 & num4 != null)
							{
								num = (short)208863248;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							context.SelectedkeyType = global::ASK.Interface.KeyType.ADVANCED_WACN_KEY;
							num = (short)1425932301;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							context.SelectedkeyType = global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY;
							num = (short)1605238785;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							goto IL_64E;
						case 18:
							switch (0)
							{
							case 0:
								goto IL_CD;
							}
							continue;
						case 19:
							goto IL_5AC;
						}
						IL_CD:
						if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroCheckIsConvOnly(astroDevice.ModelNumber, astroDevice.AstroPurchasedFlashCode))
						{
							num = (short)1143930883;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						context.StrProcStatus = global::RFResourceRepository.RFResources.Cnv_check_for_owner_system_ID;
						num = (short)307757060;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_105:
						num = (short)287309826;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_35F:
						context.SelectSystemKeyData = selectSystemKeyData;
						num = (short)1326120977;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_5AC:
						context.SystemKeyFormRadio = systemKeyData;
						flag = false;
						selectSystemKeyData = new global::CommonASK.SystemKeyData(global::ASK.Interface.KeyAccessLevelType.UNLM_ACC, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᤨ", a_), false, global::ASK.Interface.KeySource.HARDWARE, id, global::ASK.Interface.KeyType.NONE, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᤨ", a_), false);
						enumerator = context.AllSystemKeys.GetEnumerator();
						num = (short)1000341512;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_64E:
						num = (short)1556086794;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_667:;
				}
				catch (global::System.Exception ex)
				{
					context.StrProcStatus = global::RFResourceRepository.RFResources.Query_Radio_Failed + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("नପ", a_) + ex.Message;
				}
				num = (short)994836481;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000073B8 File Offset: 0x000055B8
		public void InitialQueryUpdateRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext context)
		{
			int a_ = 17;
			short num = (short)1730084864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)749076480;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_82;
				}
				global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> loadedASKWithDefault;
				for (;;)
				{
					IL_5B:
					global::System.Collections.Generic.IEnumerator<global::ASK.Interface.ISystemKeyData> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1041694721;
						if (num != 0)
						{
						}
						if (loadedASKWithDefault.Count > 0)
						{
							num = (short)2132344839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_448;
					case 1:
						goto IL_29D;
					case 2:
						num = (short)108724224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						context.AllSystemKeys.Clear();
						num = (short)319946753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (context.AllSystemKeys != null)
						{
							num = (short)854917123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29D;
					case 5:
						try
						{
							num = (short)671416323;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_22A;
								case 1:
									num = (short)1910112256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1660616705;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1295081544;
									short num4 = num;
									num = (short)1044537416;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)466354176;
										if (num != 0)
										{
										}
										global::ASK.Interface.ISystemKeyData item = enumerator.Current;
										context.AllSystemKeys.Add(item);
										num = (short)1283653636;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_152;
									}
									continue;
								}
								IL_154:
								num = (short)597032962;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_152:
								goto IL_154;
							}
							IL_22A:
							goto IL_301;
						}
						finally
						{
							num = (short)1848639489;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)250347522;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_261;
									}
									continue;
								case 2:
									goto IL_29A;
								}
								IL_261:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1745027072;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_29A:;
						}
						goto IL_29D;
					case 6:
						if (loadedASKWithDefault != null)
						{
							num = (short)964624386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_448;
					case 7:
						num = (short)70844420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_82;
					IL_29D:
					enumerator = loadedASKWithDefault.GetEnumerator();
					num = (short)1613758469;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_301:
				global::ASK.Interface.ISystemKeyData item2 = new global::CommonASK.SystemKeyData(global::ASK.Interface.KeyAccessLevelType.UNLM_ACC, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᬪ", a_), false, global::ASK.Interface.KeySource.HARDWARE, 0, global::ASK.Interface.KeyType.NONE, "", false);
				global::ASK.Interface.ISystemKeyData item3 = new global::CommonASK.SystemKeyData(global::ASK.Interface.KeyAccessLevelType.UNLM_ACC, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᬪ", a_), false, global::ASK.Interface.KeySource.HARDWARE, 1, global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY, "", false);
				global::ASK.Interface.ISystemKeyData item4 = new global::CommonASK.SystemKeyData(global::ASK.Interface.KeyAccessLevelType.UNLM_ACC, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ᬪ", a_), false, global::ASK.Interface.KeySource.HARDWARE, 0, global::ASK.Interface.KeyType.ADVANCED_WACN_KEY, "", false);
				context.AllSystemKeys.Insert(0, item4);
				context.AllSystemKeys.Insert(0, item3);
				context.AllSystemKeys.Insert(0, item2);
				context.SelectedkeyType = context.KeyTypes[0];
				context.SelectSystemKeyData = context.AllSystemKeys[0];
				context.WriteProtect = false;
				return;
				IL_448:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ASTRO_RMC_UpdateRadioData_NoAttachedASK);
				IL_82:
				context.KeyTypes = new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.KeyType>();
				context.KeyTypes.Add(global::ASK.Interface.KeyType.NONE);
				context.KeyTypes.Add(global::ASK.Interface.KeyType.ADVANCED_SYSTEM_KEY);
				context.KeyTypes.Add(global::ASK.Interface.KeyType.ADVANCED_WACN_KEY);
				context.AllSystemKeys = new global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData>();
				bool isAttached = true;
				loadedASKWithDefault = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.GetLoadedASKWithDefault(isAttached);
				context.AttachedKeys = loadedASKWithDefault;
				num = (short)806879238;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5B;
			}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00007834 File Offset: 0x00005A34
		public override void TrimCodeplug(global::Motorola.CommonCPS.Server.EntityModel.Codeplug cp)
		{
			short num = (short)428639350;
			short num2 = num;
			num = (short)1305445494;
			switch (num2 == num)
			{
			}
			num = (short)1279524864;
			if (num != 0)
			{
			}
			num = (short)902103041;
			if (num != 0)
			{
			}
			num = (short)1576992768;
			short num3 = num;
			global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug = cp as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug;
			apxcodeplug.UserLoginUnitID = apxcodeplug.UserLoginUnitID.Trim();
			apxcodeplug.UserName = apxcodeplug.UserName.Trim();
			apxcodeplug.BluetoothFriendlyName = apxcodeplug.BluetoothFriendlyName.Trim();
			apxcodeplug.RadioAlias = apxcodeplug.RadioAlias.Trim();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00007928 File Offset: 0x00005B28
		public override global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource> LoadRMResources()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource> observableCollection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return observableCollection;
				case 1:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
					{
						num2 = (short)1290600453;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return observableCollection;
				case 2:
					return observableCollection;
				case 3:
					num2 = (short)1248395265;
					if (num2 != 0)
					{
					}
					observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource
					{
						Name = global::Motorola.CommonCPS.ResourceRepository.Resources.General_SystemKeys
					});
					num2 = (short)1141833728;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
					{
						num2 = (short)215416835;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource
					{
						Name = global::Motorola.CommonCPS.ResourceRepository.Resources.General_DVRS_Files
					});
					observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource
					{
						Name = global::Motorola.CommonCPS.ResourceRepository.Resources.General_LanguagePacks
					});
					num2 = (short)1178861569;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource
					{
						Name = global::Motorola.CommonCPS.ResourceRepository.Resources.General_SystemKeys
					});
					num2 = (short)1756749608;
					short num3 = num2;
					num2 = (short)522772264;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)280559616;
						if (num2 != 0)
						{
						}
						num2 = (short)1465057282;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_28;
			}
			return observableCollection;
			IL_28:
			observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource>();
			observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource
			{
				Name = global::Motorola.CommonCPS.ResourceRepository.Resources.General_Firmware
			});
			observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource
			{
				Name = global::Motorola.CommonCPS.ResourceRepository.Resources.General_VoiceAnnouncements
			});
			observableCollection.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.RMResource
			{
				Name = global::Motorola.CommonCPS.ResourceRepository.Resources.General_CACertificates
			});
			num2 = (short)1764818944;
			short num4 = num2;
			num2 = (short)306511876;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00007B54 File Offset: 0x00005D54
		public override string GetHelpFilePathForTemplate()
		{
			int a_ = 12;
			short num = (short)206438401;
			if (num != 0)
			{
			}
			num = (short)715754776;
			short num2 = num;
			num = (short)1043172632;
			switch (num2 == num)
			{
			}
			num = (short)685244416;
			if (num != 0)
			{
			}
			num = (short)1825898496;
			short num3 = num;
			string empty = string.Empty;
			string currentCulture = base.GetCurrentCulture();
			string str = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("伥䘧丩䤫嘭ḯ娱䀳嬵吷", a_);
			string str2 = global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("渥䴧䘩尫爭", a_) + currentCulture + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("稥", a_);
			return global::System.AppDomain.CurrentDomain.BaseDirectory + str2 + str;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00007C5C File Offset: 0x00005E5C
		protected override bool ValidatePastedRecords(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase pastedRadio, global::Motorola.CommonCPS.Server.EntityModel.Radio validatePasteRadio, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> needValidateRecords, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> pasteRadioIdentityRecordsForServer, out global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo> cannotPasteFieldsList)
		{
			int a_ = 11;
			short num = (short)1461321728;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AF;
				}
				bool flag2;
				global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.l l;
				for (;;)
				{
					IL_30:
					bool flag;
					global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable2;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> list3;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator3;
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					bool? askRequired;
					switch (num2)
					{
					case 0:
						goto IL_D7F;
					case 1:
					{
						global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable;
						if (enumerable != null)
						{
							num = (short)1722417172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_620;
					}
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.m m = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.m();
						m.a = (validatePasteRadio.ToUiModel(true) as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio);
						global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = needValidateRecords.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, bool>(m.b));
						num = (short)1126826006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list = this.ListSystemsByRadio(validatePasteRadio);
						num = (short)409141258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> item;
						global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable = item.Value.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<int, object>, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.a));
						num = (short)1983905793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (!flag)
						{
							num = (short)547291151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_620;
					case 6:
						num = (short)429588509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.m m;
						global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase;
						flag2 = base.CauseInvalidFieldByPaste(m.a, uimodelBase);
						num = (short)1276444672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_620;
					case 9:
						if (enumerable2 != null)
						{
							num = (short)1788870662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_620;
					case 10:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list;
						if (list != null)
						{
							num = (short)1210908699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_292;
					}
					case 11:
						goto IL_CC7;
					case 12:
					{
						global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable;
						if (enumerable.Count<global::System.Collections.Generic.KeyValuePair<int, object>>() > 0)
						{
							num = (short)2074017817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_620;
					}
					case 13:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo> list2;
						bool flag3 = base.ValidatePastedRecords(l.a, validatePasteRadio, needValidateRecords, pasteRadioIdentityRecordsForServer, out list2);
						flag2 = false;
						if (flag3)
						{
							num = (short)45285378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A8;
					}
					case 14:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> item;
						if (item.Value.Count == 0)
						{
							num = (short)704577559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_620;
					}
					case 15:
					{
						string reason;
						cannotPasteFieldsList.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搤否䈨礪䠬帮䐰娲䜴制崸", a_), reason));
						global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable;
						global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> item;
						item.Value.Remove(enumerable.First<global::System.Collections.Generic.KeyValuePair<int, object>>());
						num = (short)775159822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>.Enumerator enumerator = list3.GetEnumerator();
						num = (short)430571544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						num = (short)331808769;
						if (num != 0)
						{
						}
						if (list3 != null)
						{
							num = (short)1050279952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A8;
					case 18:
						try
						{
							num = (short)232325121;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.n n;
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase2;
									flag2 = base.CauseInvalidFieldByPaste(n.a, uimodelBase2);
									num = (short)1488191492;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_15F;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1767702531;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.n n = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.n();
									n.a = enumerator2.Current;
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase2 = needValidateRecords.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, bool>(n.b));
									num = (short)775094280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1890451461;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (flag2)
									{
										num = (short)854982663;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									goto IL_282;
								case 6:
									goto IL_1DE;
								case 7:
									num = (short)994574342;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase2;
									if (uimodelBase2 != null)
									{
										num = (short)1447493632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_229:
								num = (short)2048327682;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_15F:
								goto IL_229;
							}
							IL_1DE:
							IL_282:;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_292;
					case 19:
						if (!flag2)
						{
							num = (short)81854475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A8;
					case 20:
						num = (short)262537228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						try
						{
							num = (short)1749483534;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
								global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType;
								global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem apxradioSystem;
								switch (num2)
								{
								case 0:
									if (systemType.GetValueOrDefault() == astroSystemType & systemType != null)
									{
										num = (short)140312596;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> item2;
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable3 = item2.Value.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<int, object>, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.b));
									goto IL_88C;
								}
								case 2:
								{
									if (!enumerator3.MoveNext())
									{
										num = (short)1067515910;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase a = enumerator3.Current;
									num = (short)1424359429;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable3;
									if (enumerable3.Count<global::System.Collections.Generic.KeyValuePair<int, object>>() > 0)
									{
										num = (short)418250770;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_CB4;
								case 5:
									if (p.a is global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)
									{
										num = (short)240975879;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									num = (short)1556545540;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable4 = pasteRadioIdentityRecordsForServer.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>, bool>(p.b));
									num = (short)22413338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									num = (short)1995551460;
									short num3 = num;
									num = (short)1110487780;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_88C;
									default:
									{
										num = (short)711655424;
										if (num != 0)
										{
										}
										global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable3;
										if (enumerable3 != null)
										{
											num = (short)822149130;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								case 9:
								{
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable4;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> item2 = enumerable4.First<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>();
									num = (short)1939996673;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									num = (short)1626734595;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable4;
									if (enumerable4.Count<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>() > 0)
									{
										num = (short)1585709065;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> list4;
									if (list4.Count > 0)
									{
										num = (short)1623457822;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
								{
									string systemName = apxradioSystem.SystemName;
									string reason;
									cannotPasteFieldsList.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo(global::Motorola.CommonCPS.ResourceRepository.Resources.General_RadioId + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("ത", a_) + systemName + global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("త", a_), reason));
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> item2;
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable3;
									item2.Value.Remove(enumerable3.First<global::System.Collections.Generic.KeyValuePair<int, object>>());
									num = (short)1999306771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									switch (0)
									{
									case 0:
										goto IL_76C;
									}
									continue;
								case 15:
									if (flag)
									{
										num = (short)1537540120;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_771;
								case 16:
									num = (short)1911619596;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									goto IL_771;
								case 18:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> list4 = apxcodeplug.APXRadioSystems.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem, bool>(p.b)).ToList<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>();
									num = (short)1328676892;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> item2;
									if (item2.Value.Count == 0)
									{
										num = (short)571211805;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 20:
									num = (short)1119223835;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									num = (short)701956107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									num = (short)487456793;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									apxcodeplug.AskRequired = askRequired;
									num = (short)1463091217;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
								{
									string reason;
									if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.ValidateRadioIdWithASK(apxradioSystem, apxcodeplug, l.a.ModelNumber, out reason, true))
									{
										num = (short)1879375885;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 26:
								{
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> enumerable4;
									if (enumerable4 != null)
									{
										num = (short)1369178133;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 27:
									if (apxcodeplug.AstroPurchasedFlashCode != null)
									{
										num = (short)1210712087;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 28:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> list4;
									if (list4 != null)
									{
										num = (short)499908624;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 29:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> item2;
									pasteRadioIdentityRecordsForServer.Remove(item2);
									num = (short)743243798;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 30:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> list4;
									apxradioSystem = list4[0];
									apxradioSystem.RadioId = (p.a as global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem).RadioID;
									num = (short)940638223;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_76C;
								IL_771:
								systemType = apxradioSystem.SystemType;
								astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING;
								num = (short)1502412800;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_88C:
								num = (short)1270480904;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B54:
								num = (short)69533698;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_76C:
								goto IL_B54;
							}
							IL_CB4:
							return flag2;
						}
						finally
						{
							((global::System.IDisposable)enumerator3).Dispose();
						}
						goto IL_CC7;
					case 22:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase;
						if (uimodelBase != null)
						{
							num = (short)196739079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D7F;
					}
					case 23:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> item;
						pasteRadioIdentityRecordsForServer.Remove(item);
						num = (short)2031419400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						try
						{
							num = (short)384499713;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.o o;
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase3;
									base.CauseInvalidFieldByPaste(o.a, uimodelBase3);
									num = (short)525664258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4EA;
									}
									continue;
								case 2:
									if (flag2)
									{
										num = (short)1926103043;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									num = (short)2091319303;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1577648133;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_60D;
								case 6:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)128712708;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.o o = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.o();
									o.a = enumerator.Current;
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase3 = needValidateRecords.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, bool>(o.b));
									num = (short)2058485768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_5A4;
								case 8:
								{
									global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase3;
									if (uimodelBase3 != null)
									{
										num = (short)430440448;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_54C:
								num = (short)1953103878;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4EA:
								goto IL_54C;
							}
							IL_5A4:
							IL_60D:
							goto IL_3A8;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_620;
					case 25:
					{
						global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<int, object>> enumerable;
						askRequired = new bool?(global::System.Convert.ToBoolean(enumerable.First<global::System.Collections.Generic.KeyValuePair<int, object>>().Value, global::System.Globalization.CultureInfo.InvariantCulture));
						string reason;
						flag = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.ValidateAstroASKRequirement(validatePasteRadio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio, out reason);
						num = (short)473825285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> item = enumerable2.First<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>();
						num = (short)1742143492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>.Enumerator enumerator2 = list.GetEnumerator();
						num = (short)1796997138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						if (!flag2)
						{
							num = (short)413925379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_292;
					case 29:
					{
						num = (short)1136001024;
						short num4 = num;
						if (enumerable2.Count<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>() > 0)
						{
							num = (short)1392181274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_620;
					}
					}
					goto IL_AF;
					IL_292:
					num = (short)336003091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A8:
					flag = false;
					askRequired = null;
					enumerable2 = pasteRadioIdentityRecordsForServer.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>, bool>(l.b));
					num = (short)1572873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_620:
					apxcodeplug = ((validatePasteRadio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
					enumerator3 = needValidateRecords.GetEnumerator();
					num = (short)1241514005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CC7:
					list3 = this.ListProfilesByRadio(validatePasteRadio);
					num = (short)1514405905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D7F:
					num = (short)1079640092;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag2;
				IL_AF:
				l = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.l();
				l.a = pastedRadio;
				cannotPasteFieldsList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldPasteWarningInfo>();
				num = (short)126287885;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00008BBC File Offset: 0x00006DBC
		protected override void PasteField(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio, global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModelPaste, string fieldName, int? fieldTypeMappedToServer, object fieldNewValue, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>> fieldValueListForServer)
		{
			int a_ = 11;
			short num = (short)1838874624;
			switch (num)
			{
			default:
			{
				num = (short)1125122073;
				int num2 = (int)((global::System.IntPtr)num);
				string value2;
				string text;
				global::System.Reflection.PropertyInfo property;
				for (;;)
				{
					object value;
					bool flag;
					string text2;
					switch (num2)
					{
					case 0:
						if (fieldNewValue == null)
						{
							num = (short)212205594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25E;
					case 1:
						num = (short)14876699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (fieldNewValue == null)
						{
							num = (short)1851785240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FC;
					case 3:
						return;
					case 4:
						goto IL_25E;
					case 5:
						if (fieldNewValue != null)
						{
							num = (short)1190199297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)966590486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (value == null)
						{
							num = (short)637140996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_473;
					case 7:
						value2 = null;
						num = (short)187432983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						value2 = null;
						num = (short)1484128261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num = (short)1620059922;
						short num3 = num;
						num = (short)1667966738;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_503;
						default:
							num = (short)946536448;
							if (num != 0)
							{
							}
							if (fieldNewValue != null)
							{
								num = (short)57147410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 10:
						if (!fieldNewValue.Equals(value))
						{
							num = (short)850067472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						goto IL_30C;
					case 12:
						fieldValueListForServer = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<int, object>>();
						num = (short)431751185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (!flag)
						{
							num = (short)667287559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E5;
					case 14:
						if (string.IsNullOrEmpty(text))
						{
							num = (short)1612578836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E5;
					case 15:
						if (value == null)
						{
							num = (short)820969493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FC;
					case 16:
						goto IL_473;
					case 17:
						goto IL_1AF;
					case 18:
						num = (short)1753808906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (fieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("瀤否䰨太紬昮缰", a_))
						{
							num = (short)1091502088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.PasteField(radio, uiModelPaste, fieldName, fieldTypeMappedToServer, fieldNewValue, fieldValueListForServer);
						num = (short)308281345;
						if (num != 0)
						{
						}
						num = (short)1619525635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)198836237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						return;
					case 22:
						text2 = null;
						goto IL_33A;
					case 23:
						goto IL_39D;
					case 24:
						num = (short)2107047951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						switch (0)
						{
						case 0:
							goto IL_BE;
						}
						continue;
					case 26:
						num = (short)682426374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_503;
					}
					IL_BE:
					if (fieldValueListForServer == null)
					{
						num = (short)2069954572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AF;
					IL_FC:
					num = (short)2045640704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AF:
					property = uiModelPaste.GetType().GetProperty(fieldName);
					value = property.GetValue(uiModelPaste);
					num = (short)772210690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25E:
					num = (short)494403593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E5:
					value2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().AstroPINPasswordConvert(text, true);
					num = (short)1294139403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33A:
					text = text2;
					flag = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.IsIntegrated(radio);
					num = (short)1674510350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_503:
					text2 = fieldNewValue.ToString();
					goto IL_33A;
					IL_473:
					num = (short)808058899;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E2:
				fieldValueListForServer.Add(new global::System.Collections.Generic.KeyValuePair<int, object>(9, value2));
				property.SetValue(uiModelPaste, text, null);
				return;
				IL_30C:
				num = (short)674168832;
				short num4 = num;
				IL_39D:
				goto IL_E2;
			}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000090D8 File Offset: 0x000072D8
		protected override global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> PasteRadioRelatedRecords(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase copiedRadio, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioToPaste, global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> copiedRadioIdentityRecords, global::Motorola.CommonCPS.Server.EntityModel.Radio validateCopyRadio, global::Motorola.CommonCPS.Server.EntityModel.Radio validatePasteRadio, ref global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> needValidateRecords)
		{
			short num = (short)2128674816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>> list3;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list;
						if (list != null)
						{
							num = (short)972029965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
					}
					case 1:
						try
						{
							num = (short)1564409872;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> enumerable;
									if (enumerable.Count<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>>() > 0)
									{
										num = (short)780271626;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_755;
								}
								case 1:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> list2;
									if (list2 != null)
									{
										num = (short)1610743817;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1121386503;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile = enumerator.Current;
									num = (short)1697579009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>? keyValuePair;
									if (keyValuePair != null)
									{
										num = (short)1766785028;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>? keyValuePair;
									list3.Add(keyValuePair.Value);
									num = (short)1132986380;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>? keyValuePair;
									if (keyValuePair != null)
									{
										num = (short)2138177550;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									if (r.a != null)
									{
										num = (short)2034302987;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									num = (short)1678180370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> enumerable;
									if (enumerable != null)
									{
										num = (short)1167851537;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_755;
								}
								case 9:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> list2;
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile a = this.a(list2, astroDataProfile);
									num = (short)1155989510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									num = (short)2107572239;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> enumerable = copiedRadioIdentityRecords.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>, bool>(r.b));
									num = (short)2075721736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									goto IL_65F;
								case 14:
									num = (short)1860042755;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> enumerable;
									if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(r.a.DataProfileTimestamp, enumerable.First<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>>().Value))
									{
										num = (short)242941965;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile astroDataProfile;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>? keyValuePair = base.PasteRecordCommon(radioToPaste, astroDataProfile, r.a, ref needValidateRecords);
									num = (short)1112408069;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									switch (0)
									{
									case 0:
										goto IL_54D;
									}
									continue;
								case 17:
									num = (short)1903427584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_803;
								}
								IL_76B:
								num = (short)2121728002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_54D:
								goto IL_76B;
							}
							IL_65F:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
							IL_755:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
							IL_803:
							return list3;
						}
						finally
						{
							num = (short)2039480321;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_83D;
					case 2:
						if (validateCopyRadio.WorkingCodeplug != null)
						{
							num = (short)976945161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list3;
					case 3:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list4 = this.ListSystemsByRadio(validateCopyRadio);
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list = this.ListSystemsByRadio(validatePasteRadio);
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> list2 = this.ListProfilesByRadio(validateCopyRadio);
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> list5 = this.ListProfilesByRadio(validatePasteRadio);
						num = (short)1391263744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> list5;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>.Enumerator enumerator = list5.GetEnumerator();
						num = (short)361299969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						try
						{
							num = (short)552861712;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>? keyValuePair2;
								global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>> enumerable2;
								global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem astroSystem;
								switch (num2)
								{
								case 0:
									num = (short)1361313802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (keyValuePair2 != null)
									{
										num = (short)2107047945;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									if (keyValuePair2 != null)
									{
										num = (short)1105657863;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									if (q.a != null)
									{
										num = (short)17432580;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									enumerable2 = copiedRadioIdentityRecords.Where(new global::System.Func<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>, bool>(q.b));
									num = (short)2080899084;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)656080914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_30D;
								case 7:
									list3.Add(keyValuePair2.Value);
									num = (short)1051394062;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list4;
									if (list4 != null)
									{
										num = (short)1914961937;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									num = (short)534708226;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (enumerable2.Count<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>>() > 0)
									{
										num = (short)1522270223;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_37A;
								case 11:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>.Enumerator enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1752432645;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									astroSystem = enumerator2.Current;
									num = (short)1812987912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									num = (short)1356342869;
									short num3 = num;
									num = (short)674702933;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2CD;
									default:
										num = (short)1942814720;
										if (num != 0)
										{
										}
										if (enumerable2 != null)
										{
											num = (short)1836384256;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_37A;
									}
									break;
								}
								case 13:
									goto IL_2CD;
								case 15:
									num = (short)1705443341;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									switch (0)
									{
									case 0:
										goto IL_183;
									}
									continue;
								case 17:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list4;
									global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem a = this.a(list4, astroSystem);
									num = (short)1178206211;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
									goto IL_48B;
								}
								goto IL_183;
								IL_2CD:
								if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CompareTimeStamp(q.a.RadioSystemTimestamp, enumerable2.First<global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]>>().Value))
								{
									num = (short)1315766278;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								keyValuePair2 = base.PasteRecordCommon(radioToPaste, astroSystem, q.a, ref needValidateRecords);
								num = (short)1822294017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_312:
								num = (short)1676017675;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_183:
								goto IL_312;
							}
							IL_30D:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
							IL_37A:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date);
							IL_48B:
							goto IL_D2;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_49E;
					case 6:
						num = (short)1680867336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> list5;
						if (list5 != null)
						{
							num = (short)828702724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list3;
					}
					case 8:
						if (validatePasteRadio.WorkingCodeplug != null)
						{
							num = (short)1623785475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list3;
					case 9:
						goto IL_49E;
					case 10:
						if (validatePasteRadio != null)
						{
							num = (short)598802438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list3;
					case 11:
					{
						num = (short)388104192;
						short num4 = num;
						if (validateCopyRadio != null)
						{
							num = (short)376504332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list3;
					}
					case 12:
						goto IL_83D;
					case 13:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>.Enumerator enumerator2 = list.GetEnumerator();
						num = (short)1882128389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_67;
					IL_D2:
					num = (short)527237127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49E:
					num = (short)73072650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_83D:
					num = (short)806420482;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list3;
				IL_67:
				list3 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>>>();
				num = (short)1569128459;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00009A8C File Offset: 0x00007C8C
		private string a(global::System.Collections.Generic.IList<string> A_0)
		{
			short num = (short)211222528;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 1:
					goto IL_18B;
				case 2:
					if (string.Compare(text.Substring(1), A_0[num3].Substring(1), global::System.StringComparison.CurrentCulture) < 0)
					{
						goto IL_1FE;
					}
					goto IL_6F;
				case 3:
					if (A_0.Count != 0)
					{
						num = (short)1738407943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21A;
				case 4:
				{
					num = (short)219960727;
					short num4 = num;
					num = (short)805918103;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1FE;
					default:
						num = (short)167968768;
						if (num != 0)
						{
						}
						goto IL_18B;
					}
					break;
				}
				case 5:
					text = A_0[num3];
					num = (short)179306506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (num3 >= A_0.Count)
					{
						num = (short)652935177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2007695362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					text = A_0.First<string>();
					num3 = 1;
					num = (short)552730625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)264765443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_1C2;
				case 10:
					goto IL_6F;
				}
				IL_50:
				if (A_0 != null)
				{
					num = (short)6291464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_21A;
				IL_6F:
				num3++;
				num = (short)494731268;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_18B:
				num = (short)1830420486;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1FE:
				num = (short)579076101;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1C2:
			num = (short)1741815808;
			short num5 = num;
			return text;
			IL_21A:
			num = (short)2104426497;
			if (num != 0)
			{
			}
			return string.Empty;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00009CE0 File Offset: 0x00007EE0
		private bool a(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> A_0)
		{
			short num = (short)695036102;
			short num2 = num;
			num = (short)1931634886;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			case 1:
				break;
			default:
			{
				num = (short)1535311872;
				short num3 = num;
				break;
			}
			}
			num = (short)1842872321;
			if (num != 0)
			{
			}
			num = (short)1037172736;
			if (num != 0)
			{
			}
			num = (short)1177223168;
			int num4 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_CE;
					}
					continue;
				case 1:
					goto IL_124;
				case 2:
					num = (short)1122500609;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CE:
				if (!A_0.All(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.e)))
				{
					return false;
				}
				num = (short)267386882;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_124:
			return A_0.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, string>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.f)).Distinct<string>().Count<string>() == 1;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00009E4C File Offset: 0x0000804C
		private string a(global::System.Collections.Generic.IList<string> A_0, out bool A_1)
		{
			short num = (short)1743593274;
			short num2 = num;
			num = (short)236003130;
			switch (num2 == num)
			{
			}
			num = (short)749142016;
			short num3 = num;
			num = (short)1778384897;
			if (num != 0)
			{
			}
			num = (short)2014052352;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.s s = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.s();
			s.a = this.a(A_0);
			A_1 = !A_0.All(new global::System.Func<string, bool>(s.b));
			return s.a;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00009F24 File Offset: 0x00008124
		private bool a(global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> A_0)
		{
			short num = (short)1370541748;
			short num2 = num;
			num = (short)1467993780;
			switch (num2 == num)
			{
			}
			num = (short)2021195776;
			short num3 = num;
			num = (short)1817247744;
			if (num != 0)
			{
			}
			num = (short)86966273;
			if (num != 0)
			{
			}
			return A_0.All(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService.<>c.<>9.a));
		}

		// Token: 0x0200000B RID: 11
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000137 RID: 311 RVA: 0x00016530 File Offset: 0x00014730
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem A_0)
			{
				short num = (short)1543352246;
				short num2 = num;
				num = (short)226799542;
				switch (num2 == num)
				{
				}
				num = (short)1732313088;
				short num3 = num;
				num = (short)135659520;
				if (num != 0)
				{
				}
				num = (short)1823342593;
				if (num != 0)
				{
				}
				return A_0.SystemName == this.a.SystemName;
			}

			// Token: 0x04000012 RID: 18
			public global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary a;
		}

		// Token: 0x0200000C RID: 12
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06000139 RID: 313 RVA: 0x00016604 File Offset: 0x00014804
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem A_0)
			{
				short num = (short)1642397696;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType2;
					for (;;)
					{
						IL_28:
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? subSystemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? subSystemType2;
						switch (num2)
						{
						case 0:
							goto IL_1B1;
						case 1:
							goto IL_1B6;
						case 2:
							num = (short)1193607173;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (systemType.GetValueOrDefault() == systemType2.GetValueOrDefault() & systemType != null == (systemType2 != null))
							{
								num = (short)1585971201;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 4:
							if (subSystemType.GetValueOrDefault() == subSystemType2.GetValueOrDefault() & subSystemType != null == (subSystemType2 != null))
							{
								num = (short)941686786;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 5:
						{
							if (!A_0.SystemName.Equals(this.a.SystemName))
							{
								return false;
							}
							num = (short)1775132051;
							short num3 = num;
							num = (short)1281056147;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1B6;
							default:
								num = (short)360841217;
								if (num != 0)
								{
								}
								num = (short)1179975680;
								if (num != 0)
								{
								}
								num = (short)516292608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_47;
						IL_1B6:
						subSystemType = A_0.SubSystemType;
						subSystemType2 = this.a.SubSystemType;
						num = (short)597557252;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1B1:
					return A_0.SystemId == this.a.SystemId;
					IL_47:
					num = (short)779485184;
					short num4 = num;
					systemType = A_0.SystemType;
					systemType2 = this.a.SystemType;
					num = (short)2056192003;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}

			// Token: 0x04000013 RID: 19
			public global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem a;
		}

		// Token: 0x0200000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x0600013B RID: 315 RVA: 0x00016848 File Offset: 0x00014A48
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile A_0)
			{
				short num = (short)1325253001;
				short num2 = num;
				num = (short)1882046857;
				switch (num2 == num)
				{
				}
				num = (short)1447821312;
				short num3 = num;
				num = (short)1690697729;
				if (num != 0)
				{
				}
				num = (short)921436160;
				if (num != 0)
				{
				}
				return A_0.Name == this.a.ProfileName;
			}

			// Token: 0x04000014 RID: 20
			public global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary a;
		}

		// Token: 0x0200000E RID: 14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class d
		{
			// Token: 0x0600013D RID: 317 RVA: 0x0001691C File Offset: 0x00014B1C
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0)
			{
				short num;
				while (!A_0.ProfileName.Equals(this.a.ProfileName))
				{
					num = (short)701909210;
					short num2 = num;
					num = (short)1610172634;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1214840832;
						if (num != 0)
						{
						}
						num = (short)133955584;
						short num3 = num;
						return false;
					}
					}
				}
				num = (short)1788674049;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = A_0.SystemType;
				global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType2 = this.a.SystemType;
				return systemType.GetValueOrDefault() == systemType2.GetValueOrDefault() & systemType != null == (systemType2 != null);
			}

			// Token: 0x04000015 RID: 21
			public global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile a;
		}

		// Token: 0x0200000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class e
		{
			// Token: 0x0600013F RID: 319 RVA: 0x00016A2C File Offset: 0x00014C2C
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile A_0)
			{
				short num = (short)985341644;
				short num2 = num;
				num = (short)1139351244;
				switch (num2 == num)
				{
				}
				num = (short)1352531968;
				short num3 = num;
				num = (short)552468481;
				if (num != 0)
				{
				}
				num = (short)671088640;
				if (num != 0)
				{
				}
				return A_0.Uuid != this.a.ASTROOtarProfileID;
			}

			// Token: 0x04000016 RID: 22
			public global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile a;
		}

		// Token: 0x02000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class f
		{
			// Token: 0x06000141 RID: 321 RVA: 0x00016B00 File Offset: 0x00014D00
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile A_0)
			{
				short num = (short)929579459;
				short num2 = num;
				num = (short)850215363;
				switch (num2 == num)
				{
				}
				num = (short)545718272;
				short num3 = num;
				num = (short)1429274625;
				if (num != 0)
				{
				}
				num = (short)568655872;
				if (num != 0)
				{
				}
				return A_0.Profile == this.a.OtarProfileName;
			}

			// Token: 0x04000017 RID: 23
			public global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO a;
		}

		// Token: 0x02000011 RID: 17
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class g
		{
			// Token: 0x06000143 RID: 323 RVA: 0x00016BD4 File Offset: 0x00014DD4
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile A_0)
			{
				short num = (short)2121990145;
				if (num != 0)
				{
				}
				num = (short)1494414921;
				short num2 = num;
				num = (short)1475212873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1384775680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1311965184;
				if (num != 0)
				{
				}
				return A_0.Profile == this.a.OtarProfileName;
			}

			// Token: 0x04000018 RID: 24
			public global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO a;
		}

		// Token: 0x02000012 RID: 18
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class h
		{
			// Token: 0x06000145 RID: 325 RVA: 0x00016CA8 File Offset: 0x00014EA8
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile A_0)
			{
				global::System.Guid? radioID;
				short num2;
				global::System.Guid uuid;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_20;
					}
					int num;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							return true;
						case 1:
							if (radioID == null)
							{
								num2 = (short)1711931395;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							num2 = (short)1751777282;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							if (radioID == null)
							{
								num2 = (short)855638016;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_148;
						case 3:
							goto IL_94;
						}
						goto IL_20;
					}
					IL_94:
					num2 = (short)1272131142;
					short num3 = num2;
					num2 = (short)183578182;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_C8;
					}
					IL_20:
					num2 = (short)666566657;
					if (num2 != 0)
					{
					}
					radioID = A_0.RadioID;
					uuid = this.a.Uuid;
					num2 = (short)778174465;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_C8:
				num2 = (short)1133969408;
				if (num2 != 0)
				{
				}
				num2 = (short)1230569472;
				short num4 = num2;
				return false;
				IL_148:
				return radioID.GetValueOrDefault() == uuid;
			}

			// Token: 0x04000019 RID: 25
			public global::Motorola.CommonCPS.Server.EntityModel.APXRadio a;
		}

		// Token: 0x02000014 RID: 20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class i
		{
			// Token: 0x06000157 RID: 343 RVA: 0x00017980 File Offset: 0x00015B80
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile A_0)
			{
				short num = (short)1822359553;
				if (num != 0)
				{
				}
				num = (short)202592628;
				short num2 = num;
				num = (short)1905676660;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1612709888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1035534336;
				if (num != 0)
				{
				}
				return A_0.OtarProfileName.Equals(this.a.OtarProfileName);
			}

			// Token: 0x04000029 RID: 41
			public global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile a;
		}

		// Token: 0x02000015 RID: 21
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class j
		{
			// Token: 0x06000159 RID: 345 RVA: 0x00017A54 File Offset: 0x00015C54
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
			{
				short num = (short)1995561323;
				short num2 = num;
				num = (short)1060886891;
				switch (num2 == num)
				{
				}
				num = (short)1549664256;
				short num3 = num;
				num = (short)1828913153;
				if (num != 0)
				{
				}
				num = (short)1953169408;
				if (num != 0)
				{
				}
				return A_0.FirmwareVersion == this.a;
			}

			// Token: 0x0400002A RID: 42
			public string a;
		}

		// Token: 0x02000016 RID: 22
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class k
		{
			// Token: 0x0600015B RID: 347 RVA: 0x00017B20 File Offset: 0x00015D20
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
			{
				short num = (short)465400103;
				short num2 = num;
				num = (short)522940711;
				switch (num2 == num)
				{
				}
				num = (short)78512129;
				if (num != 0)
				{
				}
				num = (short)257949696;
				if (num != 0)
				{
				}
				num = (short)1034944512;
				short num3 = num;
				return A_0.FirmwareVersion == this.a;
			}

			// Token: 0x0400002B RID: 43
			public string a;
		}

		// Token: 0x02000017 RID: 23
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class l
		{
			// Token: 0x0600015D RID: 349 RVA: 0x00017BEC File Offset: 0x00015DEC
			internal bool b(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> A_0)
			{
				short num;
				global::System.Guid? id;
				global::System.Guid deviceUuid;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_6B;
					}
					int num3;
					for (;;)
					{
						IL_0A:
						num = (short)1310370726;
						short num2 = num;
						num = (short)217361318;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)765853696;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								return true;
							case 1:
								if (id == null)
								{
									num = (short)1877999617;
									if (num != 0)
									{
									}
									num = (short)12517378;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1528496131;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_E3;
							case 3:
								if (id == null)
								{
									num = (short)796721152;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_14B;
							}
							goto IL_6B;
						}
					}
					IL_6B:
					id = A_0.Key.ID;
					deviceUuid = this.a.DeviceUuid;
					num = (short)1631584257;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				IL_E3:
				num = (short)640286720;
				short num4 = num;
				return false;
				IL_14B:
				return id.GetValueOrDefault() == deviceUuid;
			}

			// Token: 0x0400002C RID: 44
			public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase a;
		}

		// Token: 0x02000018 RID: 24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class m
		{
			// Token: 0x0600015F RID: 351 RVA: 0x00017D68 File Offset: 0x00015F68
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase A_0)
			{
				short num;
				global::System.Guid? id;
				global::System.Guid? id2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_90;
					}
					int num3;
					for (;;)
					{
						IL_0A:
						num = (short)1312211000;
						short num2 = num;
						num = (short)1905508408;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1449984001;
							if (num != 0)
							{
							}
							num = (short)1114177536;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								return true;
							case 1:
								if (id != null != (id2 != null))
								{
									num = (short)1970929666;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1030488067;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_E1;
							case 3:
								if (id == null)
								{
									num = (short)259850240;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_149;
							}
							goto IL_90;
						}
					}
					IL_90:
					id = A_0.ID;
					id2 = this.a.ID;
					num = (short)1803485185;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				IL_E1:
				num = (short)1534918656;
				short num4 = num;
				return false;
				IL_149:
				return id.GetValueOrDefault() == id2.GetValueOrDefault();
			}

			// Token: 0x0400002D RID: 45
			public global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio a;
		}

		// Token: 0x02000019 RID: 25
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class n
		{
			// Token: 0x06000161 RID: 353 RVA: 0x00017EE8 File Offset: 0x000160E8
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase A_0)
			{
				short num;
				global::System.Guid? id;
				global::System.Guid? id2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_6B;
					}
					int num3;
					for (;;)
					{
						IL_0A:
						num = (short)851405020;
						short num2 = num;
						num = (short)2091346140;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1622016000;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								goto IL_149;
							case 1:
								if (id != null != (id2 != null))
								{
									num = (short)879689730;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1761542147;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								return false;
							case 3:
								if (id == null)
								{
									num = (short)1522335744;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_150;
							}
							goto IL_6B;
						}
					}
					IL_6B:
					id = A_0.ID;
					id2 = this.a.ID;
					num = (short)335085569;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				return false;
				IL_149:
				num = (short)1124728832;
				short num4 = num;
				num = (short)1770848257;
				if (num != 0)
				{
				}
				return true;
				IL_150:
				return id.GetValueOrDefault() == id2.GetValueOrDefault();
			}

			// Token: 0x0400002E RID: 46
			public global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem a;
		}

		// Token: 0x0200001A RID: 26
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class o
		{
			// Token: 0x06000163 RID: 355 RVA: 0x0001806C File Offset: 0x0001626C
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase A_0)
			{
				short num;
				global::System.Guid? id;
				global::System.Guid? id2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					int num3;
					for (;;)
					{
						IL_0A:
						num = (short)1738692714;
						short num2 = num;
						num = (short)1772116074;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1867120640;
							if (num != 0)
							{
							}
							num = (short)570294273;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								return true;
							case 1:
								if (id != null != (id2 != null))
								{
									num = (short)1181679618;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1436024835;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_E2;
							case 3:
								if (id == null)
								{
									num = (short)288620544;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_14B;
							}
							goto IL_91;
						}
					}
					IL_91:
					id = A_0.ID;
					id2 = this.a.ID;
					num = (short)1309278209;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				IL_E2:
				num = (short)558563328;
				short num4 = num;
				return false;
				IL_14B:
				return id.GetValueOrDefault() == id2.GetValueOrDefault();
			}

			// Token: 0x0400002F RID: 47
			public global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile a;
		}

		// Token: 0x0200001B RID: 27
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class p
		{
			// Token: 0x06000165 RID: 357 RVA: 0x000181EC File Offset: 0x000163EC
			internal bool b(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<int, object>>> A_0)
			{
				short num;
				global::System.Guid? id;
				global::System.Guid? id2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					int num3;
					for (;;)
					{
						IL_0A:
						num = (short)1657026372;
						short num2 = num;
						num = (short)18429764;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1249902592;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								return true;
							case 1:
								if (id != null != (id2 != null))
								{
									num = (short)41811970;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)436011011;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_C1;
							case 3:
								if (id == null)
								{
									num = (short)1722155008;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_150;
							}
							goto IL_6A;
						}
					}
					IL_6A:
					id = A_0.Key.ID;
					id2 = this.a.ID;
					num = (short)1238302721;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				IL_C1:
				num = (short)628621313;
				if (num != 0)
				{
				}
				num = (short)1168965632;
				short num4 = num;
				return false;
				IL_150:
				return id.GetValueOrDefault() == id2.GetValueOrDefault();
			}

			// Token: 0x06000166 RID: 358 RVA: 0x0001835C File Offset: 0x0001655C
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem A_0)
			{
				short num = (short)2047845655;
				short num2 = num;
				num = (short)785491223;
				switch (num2 == num)
				{
				}
				num = (short)1120468992;
				if (num != 0)
				{
				}
				num = (short)868941825;
				if (num != 0)
				{
				}
				num = (short)1514930176;
				short num3 = num;
				return A_0.Uuid.Equals(this.a.ID);
			}

			// Token: 0x04000030 RID: 48
			public global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase a;
		}

		// Token: 0x0200001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class q
		{
			// Token: 0x06000168 RID: 360 RVA: 0x0001843C File Offset: 0x0001663C
			internal bool b(global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]> A_0)
			{
				global::System.Guid key;
				global::System.Guid? id;
				short num;
				for (;;)
				{
					key = A_0.Key;
					id = this.a.ID;
					if (id == null)
					{
						break;
					}
					num = (short)1474353534;
					short num2 = num;
					num = (short)1059772798;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7C;
					}
				}
				num = (short)742391809;
				if (num != 0)
				{
				}
				return false;
				IL_7C:
				num = (short)1714880512;
				short num3 = num;
				num = (short)1905262592;
				if (num != 0)
				{
				}
				return key == id.GetValueOrDefault();
			}

			// Token: 0x04000031 RID: 49
			public global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem a;
		}

		// Token: 0x0200001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class r
		{
			// Token: 0x0600016A RID: 362 RVA: 0x00018524 File Offset: 0x00016724
			internal bool b(global::System.Collections.Generic.KeyValuePair<global::System.Guid, byte[]> A_0)
			{
				short num = (short)2075115868;
				short num2 = num;
				num = (short)1990246748;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_91;
				case 1:
					break;
				default:
				{
					num = (short)1542324224;
					short num3 = num;
					break;
				}
				}
				num = (short)2072969216;
				if (num != 0)
				{
				}
				global::System.Guid key = A_0.Key;
				global::System.Guid? id = this.a.ID;
				if (id != null)
				{
					return key == id.GetValueOrDefault();
				}
				IL_91:
				num = (short)1988362241;
				if (num != 0)
				{
				}
				return false;
			}

			// Token: 0x04000032 RID: 50
			public global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile a;
		}

		// Token: 0x0200001E RID: 30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class s
		{
			// Token: 0x0600016C RID: 364 RVA: 0x00018610 File Offset: 0x00016810
			internal bool b(string A_0)
			{
				short num = (short)1751908352;
				short num2 = num;
				num = (short)1252623104;
				short num3 = num;
				num = (short)1599898368;
				switch (num3 == num)
				{
				}
				num = (short)1357447168;
				if (num != 0)
				{
				}
				num = (short)355794945;
				if (num != 0)
				{
				}
				return A_0.Equals(this.a);
			}

			// Token: 0x04000033 RID: 51
			public string a;
		}
	}
}
