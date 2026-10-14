using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000063 RID: 99
	public class ASTROOtarProfileViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>
	{
		// Token: 0x0600034C RID: 844 RVA: 0x00050A18 File Offset: 0x0004EC18
		public ASTROOtarProfileViewProvider(global::System.Guid? groupId)
		{
			this.a = groupId;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00050A34 File Offset: 0x0004EC34
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> FetchRange(int startIndex, int length, out int milliseconds)
		{
			int a_ = 17;
			short num = (short)1950875648;
			switch (num)
			{
			default:
			{
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>();
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.StartNewAutomatic(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ViewLoad, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("搪夬丮䌰ጲ攴䔶嘸崺吼匾⑀あ", a_)), null);
				try
				{
					num = (short)1287323649;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.Radio> enumerator;
						global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> apxotarProfiles;
						switch (num2)
						{
						case 0:
							goto IL_29A;
						case 1:
						{
							num = (short)1639429707;
							short num3 = num;
							num = (short)226211403;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_29A;
							default:
								num = (short)444203008;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_D9;
								}
								continue;
							}
							break;
						}
						case 2:
						{
							try
							{
								num = (short)1828978688;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_2D9;
										}
										continue;
									case 1:
										num = (short)262209538;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_363;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)681377793;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.Server.EntityModel.Radio radio = enumerator.Current;
										global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Add(radio.Uuid, radio);
										num = (short)1820327940;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_2DB:
									num = (short)475463683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2D9:
									goto IL_2DB;
								}
								IL_363:;
							}
							finally
							{
								num = (short)1858273281;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_3D3;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_39A;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)514064384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_39A:
									if (enumerator == null)
									{
										break;
									}
									num = (short)744488962;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3D3:;
							}
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> enumerator2 = apxotarProfiles.GetEnumerator();
							num = (short)39976960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_D9;
						IL_FD:
						global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance;
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> source;
						global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO, global::System.Guid> selector;
						enumerator = instance.GetRadiosForOtarProfileValidation(source.Select(selector).Distinct<global::System.Guid>().ToList<global::System.Guid>(), 50).GetEnumerator();
						num = (short)93913090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_25E:
						selector = (global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarProfileViewProvider.<>c.<>9__2_0 = new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO, global::System.Guid>(global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarProfileViewProvider.<>c.<>9.a));
						goto IL_FD;
						IL_D9:
						instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false);
						apxotarProfiles = instance.GetAPXOtarProfiles(this.a, startIndex, length);
						source = apxotarProfiles;
						if ((selector = global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarProfileViewProvider.<>c.<>9__2_0) == null)
						{
							goto IL_25E;
						}
						goto IL_FD;
						IL_29A:
						try
						{
							num = (short)2038038528;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_16E;
									}
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)599130116;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile item = enumerator2.Current.ToUiModel(false);
									list.Add(item);
									num = (short)2127757315;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1ED;
								case 4:
									num = (short)1968111618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_19F:
								num = (short)909705217;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16E:
								goto IL_19F;
							}
							IL_1ED:
							break;
						}
						finally
						{
							num = (short)1706426369;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_25B;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_224;
									}
									continue;
								case 2:
									enumerator2.Dispose();
									num = (short)1664024576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_224:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1287847938;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_25B:;
						}
						goto IL_25E;
					}
				}
				finally
				{
					num = (short)915603457;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_43E;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_409;
							}
							continue;
						case 2:
							automaticPerformanceMeasurer.Dispose();
							num = (short)1391591424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_409:
						if (automaticPerformanceMeasurer == null)
						{
							break;
						}
						num = (short)1277165570;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_43E:;
				}
				num = (short)1380909057;
				if (num != 0)
				{
				}
				num = (short)316407808;
				short num4 = num;
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
			}
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00050F2C File Offset: 0x0004F12C
		public int GetTotalCount()
		{
			short num = (short)591331328;
			short num2 = num;
			num = (short)1457283670;
			short num3 = num;
			num = (short)2022728278;
			switch (num3 == num)
			{
			}
			num = (short)904855553;
			if (num != 0)
			{
			}
			num = (short)779354112;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetAPXOtarProfilesCount(this.a);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00050FEC File Offset: 0x0004F1EC
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile item)
		{
			short num = (short)1170866176;
			short num2 = num;
			num = (short)130652186;
			short num3 = num;
			num = (short)946903066;
			switch (num3 == num)
			{
			}
			num = (short)1769799680;
			if (num != 0)
			{
			}
			num = (short)1367015425;
			if (num != 0)
			{
			}
			item.a();
		}

		// Token: 0x04000093 RID: 147
		private global::System.Guid? a;
	}
}
