using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200005A RID: 90
	public class ASTRODataProfileViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>
	{
		// Token: 0x06000335 RID: 821 RVA: 0x0004F634 File Offset: 0x0004D834
		public ASTRODataProfileViewProvider(global::System.Guid? groupId)
		{
			this.a = groupId;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0004F650 File Offset: 0x0004D850
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> FetchRange(int startIndex, int length, out int milliseconds)
		{
			int a_ = 14;
			short num = (short)1601896448;
			switch (num)
			{
			default:
			{
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>();
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.StartNewAutomatic(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ViewLoad, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("氧䬩堫伭ု戱䘳夵帷匹倻嬽㌿", a_)), null);
				try
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> enumerator = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetASTRODataProfiles(this.a, startIndex, length).GetEnumerator();
					try
					{
						num = (short)470876162;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_12C;
							case 1:
								num = (short)1274216448;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_AD;
								}
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)274333697;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile item = enumerator.Current.ToUiModel(false);
								list.Add(item);
								num = (short)1377763332;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_DD:
							num = (short)177078275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_AD:
							goto IL_DD;
						}
						IL_12C:;
					}
					finally
					{
						num = (short)1051656194;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_19A;
							case 1:
								enumerator.Dispose();
								num = (short)1936064512;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_164;
								}
								continue;
							}
							IL_164:
							if (enumerator == null)
							{
								break;
							}
							num = (short)144769025;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_19A:;
					}
				}
				finally
				{
					num = (short)1720123394;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_258;
						case 1:
						{
							num = (short)1101447749;
							short num3 = num;
							num = (short)1154138693;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_258;
							default:
								num = (short)102957056;
								if (num != 0)
								{
								}
								automaticPerformanceMeasurer.Dispose();
								num = (short)1340997632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1D0;
							}
							continue;
						}
						IL_1D0:
						if (automaticPerformanceMeasurer == null)
						{
							goto IL_282;
						}
						num = (short)1355022337;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_258:
					num = (short)1016987649;
					if (num != 0)
					{
					}
					IL_282:;
				}
				num = (short)83165184;
				short num4 = num;
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
			}
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0004F94C File Offset: 0x0004DB4C
		public int GetTotalCount()
		{
			short num = (short)532390460;
			short num2 = num;
			num = (short)1366663740;
			switch (num2 == num)
			{
			}
			num = (short)103088128;
			if (num != 0)
			{
			}
			num = (short)1463091201;
			if (num != 0)
			{
			}
			num = (short)434241536;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetAllDataProfilesCount(this.a);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0004FA08 File Offset: 0x0004DC08
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile item)
		{
			short num = (short)280272457;
			short num2 = num;
			num = (short)527998537;
			switch (num2 == num)
			{
			}
			num = (short)2101870592;
			if (num != 0)
			{
			}
			num = (short)1839333377;
			if (num != 0)
			{
			}
			num = (short)2049507328;
			short num3 = num;
			item.a();
		}

		// Token: 0x0400008C RID: 140
		private global::System.Guid? a;
	}
}
