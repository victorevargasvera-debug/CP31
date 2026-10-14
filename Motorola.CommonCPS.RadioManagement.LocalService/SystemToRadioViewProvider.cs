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
	// Token: 0x020000A5 RID: 165
	public class SystemToRadioViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x0005A250 File Offset: 0x00058450
		public SystemToRadioViewProvider(global::System.Guid? groupId, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo sysInfo)
		{
			this.a = sysInfo;
			this.b = groupId;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0005A274 File Offset: 0x00058474
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num;
			for (;;)
			{
				num = (short)872873984;
				switch (num)
				{
				default:
				{
					num = (short)1042130965;
					short num2 = num;
					num = (short)1061398549;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_7B;
					}
					goto Block_0;
				}
				}
			}
			Block_0:
			num = (short)829685760;
			short num3 = num;
			IL_7B:
			num = (short)1384382464;
			if (num != 0)
			{
			}
			global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
			stopwatch.Start();
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> list = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListRadiosByRadioSystem(this.b, this.a.GetRawObject(), startIndex, length, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>();
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary>.Enumerator enumerator = list.GetEnumerator();
			try
			{
				num = (short)1041104899;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)715390980;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem item = enumerator.Current.ToUiModel(false);
						list2.Add(item);
						num = (short)1317076993;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_187;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_109;
						}
						continue;
					case 4:
						num = (short)1831141378;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_137:
					num = (short)502071296;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_109:
					goto IL_137;
				}
				IL_187:;
			}
			finally
			{
				num = (short)1499594753;
				if (num != 0)
				{
				}
				((global::System.IDisposable)enumerator).Dispose();
			}
			stopwatch.Stop();
			milliseconds = (int)stopwatch.ElapsedMilliseconds;
			return list2;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0005A460 File Offset: 0x00058660
		public int GetTotalCount()
		{
			short num = (short)696312947;
			short num2 = num;
			num = (short)1911219315;
			switch (num2 == num)
			{
			}
			num = (short)1635713024;
			short num3 = num;
			num = (short)254017537;
			if (num != 0)
			{
			}
			num = (short)1133248512;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioCountBySystem(this.b, this.a.GetRawObject());
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0005A524 File Offset: 0x00058724
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem item)
		{
			short num = (short)1041028913;
			short num2 = num;
			num = (short)1274664753;
			switch (num2 == num)
			{
			}
			num = (short)1154023424;
			short num3 = num;
			num = (short)1241448448;
			if (num != 0)
			{
			}
			num = (short)1159004161;
			if (num != 0)
			{
			}
			item.a();
		}

		// Token: 0x040000CE RID: 206
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo a;

		// Token: 0x040000CF RID: 207
		private global::System.Guid? b;
	}
}
