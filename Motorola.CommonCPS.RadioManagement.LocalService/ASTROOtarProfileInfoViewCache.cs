using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200005B RID: 91
	public class ASTROOtarProfileInfoViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo>
	{
		// Token: 0x06000339 RID: 825 RVA: 0x0004FAB8 File Offset: 0x0004DCB8
		public ASTROOtarProfileInfoViewCache(global::System.Guid? groupId) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarProfileInfoViewCache.ASTROOtarProfileInfoViewProvider(groupId), null, 500)
		{
		}

		// Token: 0x0200005C RID: 92
		public class ASTROOtarProfileInfoViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo>
		{
			// Token: 0x0600033A RID: 826 RVA: 0x0004FAD8 File Offset: 0x0004DCD8
			public ASTROOtarProfileInfoViewProvider(global::System.Guid? groupId)
			{
				this.a = groupId;
			}

			// Token: 0x0600033B RID: 827 RVA: 0x0004FAF4 File Offset: 0x0004DCF4
			public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo> FetchRange(int startIndex, int length, out int milliseconds)
			{
				short num = (short)66060288;
				switch (num)
				{
				default:
				{
					num = (short)957612033;
					if (num != 0)
					{
					}
					global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
					stopwatch.Start();
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO> apxotarProfilesInfo = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetAPXOtarProfilesInfo(this.a, startIndex, length);
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo>();
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileInfoDTO> enumerator = apxotarProfilesInfo.GetEnumerator();
					try
					{
						num = (short)360251394;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_126;
							case 1:
								num = (short)490930176;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_AC;
								}
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1455751169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo item = enumerator.Current.ToUiModel();
								list.Add(item);
								num = (short)1613955076;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_D8:
							num = (short)675414019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_AC:
							goto IL_D8;
						}
						IL_126:;
					}
					finally
					{
						num = (short)467140610;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1E3;
							case 1:
							{
								num = (short)221337061;
								short num3 = num;
								num = (short)1416320485;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1E3;
								default:
									num = (short)1712324608;
									if (num != 0)
									{
									}
									enumerator.Dispose();
									num = (short)990707712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_15D;
								}
								continue;
							}
							IL_15D:
							if (enumerator == null)
							{
								break;
							}
							num = (short)27131905;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1E3:;
					}
					num = (short)923795456;
					short num4 = num;
					stopwatch.Stop();
					milliseconds = (int)stopwatch.ElapsedMilliseconds;
					return list;
				}
				}
			}

			// Token: 0x0600033C RID: 828 RVA: 0x0004FD30 File Offset: 0x0004DF30
			public int GetTotalCount()
			{
				short num = (short)1022754816;
				short num2 = num;
				num = (short)1110708354;
				short num3 = num;
				num = (short)1598230658;
				switch (num3 == num)
				{
				}
				num = (short)1083768833;
				if (num != 0)
				{
				}
				num = (short)87818240;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetAPXOtarProfilesInfoCount(this.a);
			}

			// Token: 0x0600033D RID: 829 RVA: 0x0004FDEC File Offset: 0x0004DFEC
			public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo item)
			{
				short num = (short)1891237888;
				short num2 = num;
				num = (short)1988191105;
				short num3 = num;
				num = (short)1295868801;
				switch (num3 == num)
				{
				}
				num = (short)1592459264;
				if (num != 0)
				{
				}
				num = (short)451018753;
				if (num != 0)
				{
				}
			}

			// Token: 0x0400008D RID: 141
			private global::System.Guid? a;
		}
	}
}
