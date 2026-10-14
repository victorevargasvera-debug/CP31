using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000B0 RID: 176
	public class PackageViewProvider<T> : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<T> where T : global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase
	{
		// Token: 0x06000423 RID: 1059 RVA: 0x0005B7FC File Offset: 0x000599FC
		public PackageViewProvider(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type)
		{
			this.a = type;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0005B818 File Offset: 0x00059A18
		public PackageViewProvider(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, int? region)
		{
			this.a = type;
			this.b = region;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0005B83C File Offset: 0x00059A3C
		public global::System.Collections.Generic.IList<T> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)1781570919;
			short num2 = num;
			num = (short)163028327;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1385234432;
				short num3 = num;
				num = (short)909312000;
				if (num != 0)
				{
				}
				num = (short)1943928832;
				switch (num)
				{
				}
				break;
			}
			}
			global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
			stopwatch.Start();
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> packageSummaries = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.PackageManagementService.GetPackageSummaries(startIndex, length, this.a, this.b);
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.PackageSummary> enumerator = packageSummaries.GetEnumerator();
			try
			{
				num = (short)2061238273;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 1:
						switch (0)
						{
						case 0:
							goto IL_104;
						}
						continue;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)705363971;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase packageBase = enumerator.Current.ToUiModel();
						list.Add((T)((object)packageBase));
						num = (short)1137573888;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)1907032068;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_181;
					}
					IL_135:
					num = (short)53084162;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_104:
					goto IL_135;
				}
				IL_181:;
			}
			finally
			{
				num = (short)1742733312;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_1B5;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)1402601474;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1EA;
					}
					IL_1B5:
					if (enumerator == null)
					{
						break;
					}
					num = (short)338362369;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1EA:;
			}
			num = (short)13959169;
			if (num != 0)
			{
			}
			stopwatch.Stop();
			milliseconds = (int)stopwatch.ElapsedMilliseconds;
			return list;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0005BA80 File Offset: 0x00059C80
		public int GetTotalCount()
		{
			short num = (short)1689821915;
			short num2 = num;
			num = (short)895460059;
			switch (num2 == num)
			{
			default:
			{
				num = (short)849739776;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)645136385;
			if (num != 0)
			{
			}
			num = (short)660406272;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetPackagesCount(this.a, this.b);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0005BB44 File Offset: 0x00059D44
		public void SetValidator(T item)
		{
			short num = (short)1075331065;
			short num2 = num;
			num = (short)223166457;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1350303744;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1435041793;
			if (num != 0)
			{
			}
			num = (short)2099511296;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000DC RID: 220
		private readonly global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType a;

		// Token: 0x040000DD RID: 221
		private int? b;
	}
}
