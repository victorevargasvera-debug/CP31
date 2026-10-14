using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000060 RID: 96
	public class ASTROOtarProfileToRadioViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>
	{
		// Token: 0x06000344 RID: 836 RVA: 0x000502A0 File Offset: 0x0004E4A0
		public ASTROOtarProfileToRadioViewProvider(global::System.Guid? groupId, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo profileInfo)
		{
			this.a = profileInfo;
			this.b = groupId;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000502C4 File Offset: 0x0004E4C4
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)1624375296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3C;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> list;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> radiosByAPXOtarProfile;
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> enumerator2;
					switch (num2)
					{
					case 0:
						goto IL_2AA;
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false);
						radiosByAPXOtarProfile = instance.GetRadiosByAPXOtarProfile(this.b, this.a.APXOtarProfileInfoDTO, startIndex, length);
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.Radio> enumerator = instance.GetRadiosForOtarProfileValidation(radiosByAPXOtarProfile.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO, global::System.Guid>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarProfileToRadioViewProvider.<>c.<>9.a)).Distinct<global::System.Guid>().ToList<global::System.Guid>(), 50).GetEnumerator();
						num = (short)1776353280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)863430734;
						short num3 = num;
						num = (short)1037494350;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)1144193024;
							short num4 = num;
							num = (short)474415104;
							if (num != 0)
							{
							}
							try
							{
								num = (short)712376320;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1B8;
										}
										continue;
									case 1:
										num = (short)122355714;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_238;
									case 3:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)1327038465;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile item = enumerator2.Current.ToUiModel(false);
										list.Add(item);
										num = (short)227672068;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1BA:
									num = (short)1763966979;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1B8:
									goto IL_1BA;
								}
								IL_238:
								goto IL_402;
							}
							finally
							{
								num = (short)706936833;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_2A7;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_26F;
										}
										continue;
									case 2:
										enumerator2.Dispose();
										num = (short)807993344;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_26F:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1627258882;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2A7:;
							}
							goto Block_3;
						}
						}
						break;
					}
					}
					goto IL_3C;
					Block_3:
					try
					{
						IL_2AA:
						num = (short)67305472;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)240910337;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_30B;
								}
								continue;
							case 1:
								num = (short)1599668226;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_390;
							case 3:
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.Radio> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1953300481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.Radio radio = enumerator.Current;
								global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Add(radio.Uuid, radio);
								num = (short)326172676;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_30D:
							num = (short)1719664643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_30B:
							goto IL_30D;
						}
						IL_390:
						goto IL_96;
					}
					finally
					{
						num = (short)147456001;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.Radio> enumerator;
							switch (num2)
							{
							case 0:
								goto IL_3FF;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_3C9;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)911474688;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_3C9:
							if (enumerator == null)
							{
								break;
							}
							num = (short)189661186;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3FF:;
					}
					break;
					IL_96:
					enumerator2 = radiosByAPXOtarProfile.GetEnumerator();
					num = (short)1069940738;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_402:
				global::System.Diagnostics.Stopwatch stopwatch;
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
				IL_3C:
				stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>();
				num = (short)2123563009;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00050700 File Offset: 0x0004E900
		public int GetTotalCount()
		{
			short num = (short)1664286720;
			short num2 = num;
			num = (short)1353119257;
			short num3 = num;
			num = (short)463992345;
			switch (num3 == num)
			{
			}
			num = (short)1173815297;
			if (num != 0)
			{
			}
			num = (short)1272512512;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadiosByAPXOtarProfileCount(this.b, this.a.APXOtarProfileInfoDTO);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000507C8 File Offset: 0x0004E9C8
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile item)
		{
			short num = (short)1707540480;
			short num2 = num;
			num = (short)920086240;
			short num3 = num;
			num = (short)1130587872;
			switch (num3 == num)
			{
			}
			num = (short)209518592;
			if (num != 0)
			{
			}
			num = (short)1192165377;
			if (num != 0)
			{
			}
			item.a();
		}

		// Token: 0x0400008F RID: 143
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo a;

		// Token: 0x04000090 RID: 144
		private global::System.Guid? b;
	}
}
