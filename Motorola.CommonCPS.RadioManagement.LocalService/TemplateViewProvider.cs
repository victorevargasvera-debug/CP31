using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000AF RID: 175
	public class TemplateViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x0005B5C4 File Offset: 0x000597C4
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)800784385;
			if (num != 0)
			{
			}
			num = (short)1510801408;
			short num2 = num;
			num = (short)405741920;
			short num3 = num;
			num = (short)1489707360;
			switch (num3 == num)
			{
			}
			num = (short)888602624;
			if (num != 0)
			{
			}
			global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
			stopwatch.Start();
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> result = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListTemplateSummaries(startIndex, length).ToUiModel(false);
			stopwatch.Stop();
			milliseconds = (int)stopwatch.ElapsedMilliseconds;
			return result;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0005B698 File Offset: 0x00059898
		public int GetTotalCount()
		{
			short num = (short)773946877;
			short num2 = num;
			num = (short)1758625277;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1166737408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1164640257;
			if (num != 0)
			{
			}
			num = (short)331022336;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetTemplateCount();
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0005B74C File Offset: 0x0005994C
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase item)
		{
			short num = (short)507834647;
			short num2 = num;
			num = (short)964096279;
			switch (num2 == num)
			{
			default:
			{
				num = (short)245497856;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)810745857;
			if (num != 0)
			{
			}
			num = (short)1311178752;
			if (num != 0)
			{
			}
			item.a();
		}
	}
}
