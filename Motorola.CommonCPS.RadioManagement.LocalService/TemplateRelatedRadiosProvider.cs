using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000A7 RID: 167
	public class TemplateRelatedRadiosProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair>
	{
		// Token: 0x06000409 RID: 1033 RVA: 0x0005A5F4 File Offset: 0x000587F4
		public TemplateRelatedRadiosProvider(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> templateList)
		{
			this.a = templateList;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0005A610 File Offset: 0x00058810
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num;
			for (;;)
			{
				num = (short)1473314816;
				switch (num)
				{
				default:
				{
					num = (short)1821713615;
					short num2 = num;
					num = (short)548283599;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_7C;
					}
					goto Block_0;
				}
				}
			}
			Block_0:
			num = (short)350420992;
			short num3 = num;
			IL_7C:
			num = (short)307888128;
			if (num != 0)
			{
			}
			global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
			stopwatch.Start();
			global::Motorola.CommonCPS.RadioManagement.SharedServices.IDataProviderService dataProviderService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DataProviderService;
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> source = this.a;
			global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase, global::System.Guid> selector = new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase, global::System.Guid>(global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateRelatedRadiosProvider.<>c.<>9.a);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair> list;
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> referencedRadios = dataProviderService.GetReferencedRadios(source.Select(selector).ToList<global::System.Guid>(), startIndex, length);
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair>();
				using (global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>.Enumerator enumerator = referencedRadios.GetEnumerator())
				{
					num = (short)812908548;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1772158981;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> a = enumerator.Current;
							num = (short)928514050;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase template = this.a.First(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase, bool>(a2.b));
							string errorString = string.Empty;
							if (a2.a.Key.ExceptionData != null)
							{
								errorString = global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(a2.a.Key.ExceptionData.ErrorCode.ToString(), a2.a.Key.ExceptionData.Paramters);
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio = (a2.a.Value == null) ? null : a2.a.Value.ToUiModel(true);
							global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair item = new global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair(template, radio, errorString);
							list.Add(item);
							num = (short)1125974017;
							if (num != 0)
							{
							}
							num = (short)587464704;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_26F;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_FC;
							}
							continue;
						case 5:
							num = (short)1905131523;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_217:
						num = (short)1454440449;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_FC:
						goto IL_217;
					}
					IL_26F:
					break;
				}
			}
			stopwatch.Stop();
			milliseconds = (int)stopwatch.ElapsedMilliseconds;
			return list;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0005A904 File Offset: 0x00058B04
		public int GetTotalCount()
		{
			short num = (short)1606890401;
			short num2 = num;
			num = (short)1015493537;
			switch (num2 == num)
			{
			}
			num = (short)558891008;
			short num3 = num;
			num = (short)2089484288;
			if (num != 0)
			{
			}
			num = (short)844365825;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DataProviderService.GetReferencedRadiosCount(this.a.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase, global::System.Guid>(global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateRelatedRadiosProvider.<>c.<>9.b)).ToList<global::System.Guid>());
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0005A9F0 File Offset: 0x00058BF0
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair pair)
		{
			short num = (short)1003487232;
			short num2 = num;
			num = (short)116108140;
			short num3 = num;
			num = (short)802794348;
			switch (num3 == num)
			{
			}
			num = (short)1991573505;
			if (num != 0)
			{
			}
			num = (short)2029387776;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000D0 RID: 208
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> a;

		// Token: 0x020000A8 RID: 168
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600040E RID: 1038 RVA: 0x0005AAAC File Offset: 0x00058CAC
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase A_0)
			{
				short num = (short)993787904;
				short num2 = num;
				num = (short)782720606;
				short num3 = num;
				num = (short)1029725790;
				switch (num3 == num)
				{
				}
				num = (short)1134952449;
				if (num != 0)
				{
				}
				num = (short)568918016;
				if (num != 0)
				{
				}
				return A_0.TemplateID == this.a.Key.Uuid;
			}

			// Token: 0x040000D1 RID: 209
			public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> a;
		}
	}
}
