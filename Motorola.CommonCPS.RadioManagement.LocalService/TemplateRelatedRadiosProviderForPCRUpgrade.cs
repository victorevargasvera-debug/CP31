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
	// Token: 0x020000AB RID: 171
	public class TemplateRelatedRadiosProviderForPCRUpgrade : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair>
	{
		// Token: 0x06000414 RID: 1044 RVA: 0x0005ADBC File Offset: 0x00058FBC
		public TemplateRelatedRadiosProviderForPCRUpgrade(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> templateList, global::System.Guid firmwareID, bool isAllowDowngrade)
		{
			this.a = templateList;
			this.b = firmwareID;
			this.c = isAllowDowngrade;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0005ADE4 File Offset: 0x00058FE4
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)1225694741;
			short num2 = num;
			num = (short)1272421909;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1496842240;
				short num3 = num;
				num = (short)281083904;
				if (num != 0)
				{
				}
				num = (short)1903034368;
				switch (num)
				{
				}
				break;
			}
			}
			global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
			stopwatch.Start();
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> source = this.a;
			global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase, global::System.Guid> selector = new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase, global::System.Guid>(global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateRelatedRadiosProviderForPCRUpgrade.<>c.<>9.a);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair> list;
			for (;;)
			{
				global::System.Collections.Generic.List<global::System.Guid> matrixTemplateUuidList = source.Select(selector).ToList<global::System.Guid>();
				global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary> matchedReferenceRadiosForUpgrade = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DataProviderService.GetMatchedReferenceRadiosForUpgrade(matrixTemplateUuidList, this.b, this.c, startIndex, length);
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair>();
				using (global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary>.Enumerator enumerator = matchedReferenceRadiosForUpgrade.GetEnumerator())
				{
					num = (short)1124466690;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1446117380;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary> a = enumerator.Current;
							num = (short)908853249;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
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
							num = (short)1064697859;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_F0;
							}
							continue;
						case 4:
							num = (short)882376709;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_245;
						}
						IL_1ED:
						num = (short)1365901312;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_F0:
						goto IL_1ED;
					}
					IL_245:
					break;
				}
			}
			num = (short)472645633;
			if (num != 0)
			{
			}
			stopwatch.Stop();
			milliseconds = (int)stopwatch.ElapsedMilliseconds;
			return list;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0005B0F0 File Offset: 0x000592F0
		public int GetTotalCount()
		{
			short num = (short)1528496129;
			if (num != 0)
			{
			}
			num = (short)943980544;
			short num2 = num;
			num = (short)1649391476;
			short num3 = num;
			num = (short)1859827572;
			switch (num3 == num)
			{
			}
			num = (short)1566375936;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DataProviderService.GetUpgradeMatchedMatrixRadiosCount(this.a.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase, global::System.Guid>(global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateRelatedRadiosProviderForPCRUpgrade.<>c.<>9.b)).ToList<global::System.Guid>(), this.b, this.c);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0005B1E8 File Offset: 0x000593E8
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair pair)
		{
			short num = (short)1919097680;
			short num2 = num;
			num = (short)114629456;
			switch (num2 == num)
			{
			default:
			{
				num = (short)43253760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2116812801;
			if (num != 0)
			{
			}
			num = (short)2036727808;
			if (num != 0)
			{
			}
		}

		// Token: 0x040000D5 RID: 213
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> a;

		// Token: 0x040000D6 RID: 214
		private global::System.Guid b;

		// Token: 0x040000D7 RID: 215
		private bool c;

		// Token: 0x020000AC RID: 172
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000419 RID: 1049 RVA: 0x0005B2A4 File Offset: 0x000594A4
			internal bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase A_0)
			{
				short num = (short)537853953;
				if (num != 0)
				{
				}
				num = (short)984743936;
				short num2 = num;
				num = (short)813471029;
				short num3 = num;
				num = (short)1195873589;
				switch (num3 == num)
				{
				}
				num = (short)31064064;
				if (num != 0)
				{
				}
				return A_0.TemplateID == this.a.Key.Uuid;
			}

			// Token: 0x040000D8 RID: 216
			public global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.EntitySummary, global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioSummary> a;
		}
	}
}
