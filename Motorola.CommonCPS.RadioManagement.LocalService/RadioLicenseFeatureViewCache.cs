using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000074 RID: 116
	public class RadioLicenseFeatureViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase>
	{
		// Token: 0x0600037B RID: 891 RVA: 0x0005359C File Offset: 0x0005179C
		public RadioLicenseFeatureViewCache(global::System.Guid? groupUuid, int featureType = 0) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioLicenseFeatureViewCache.RadioLicenseFeatureViewProvider(groupUuid, featureType), null, 500)
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000535BC File Offset: 0x000517BC
		public RadioLicenseFeatureViewCache(global::System.Guid? groupUuid, int featureType, global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase> provider) : base(provider, null, 500)
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000535D8 File Offset: 0x000517D8
		public override void ItemChanged<TV>(global::System.Data.Linq.ChangeAction operationType, global::System.Collections.Generic.List<TV> changedItem, global::System.Collections.Generic.List<global::System.Guid> legacyGuidList = null, params object[] otherParameters)
		{
			short num = (short)847183876;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					return;
				case 2:
					if (operationType == global::System.Data.Linq.ChangeAction.Insert)
					{
						num = (short)599064581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					num = (short)898105345;
					if (num != 0)
					{
					}
					if (operationType != global::System.Data.Linq.ChangeAction.Delete)
					{
						num = (short)48758790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10D;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 5:
					goto IL_10D;
				case 6:
					num = (short)254279682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_41:
				if (typeof(TV) != typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase))
				{
					num = (short)837484544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1595080707;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10D:
				base.NotifyRefreshAll();
				num = (short)1325782076;
				short num3 = num;
				num = (short)588829756;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)1677590528;
					if (num != 0)
					{
					}
					num = (short)1935147008;
					short num4 = num;
					num = (short)190644225;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x02000075 RID: 117
		public class RadioLicenseFeatureViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase>
		{
			// Token: 0x0600037E RID: 894 RVA: 0x00053788 File Offset: 0x00051988
			public RadioLicenseFeatureViewProvider(global::System.Guid? groupUuid, int ftype = 0)
			{
				this.a = groupUuid;
				this.b = ftype;
			}

			// Token: 0x0600037F RID: 895 RVA: 0x000537AC File Offset: 0x000519AC
			public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase> FetchRange(int startIndex, int length, out int milliseconds)
			{
				short num = (short)356801778;
				short num2 = num;
				num = (short)414014706;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_91;
				case 1:
					break;
				default:
				{
					num = (short)701628416;
					short num3 = num;
					break;
				}
				}
				num = (short)873857024;
				if (num != 0)
				{
				}
				num = (short)1975844864;
				switch (num)
				{
				default:
				{
					IL_91:
					num = (short)2090663937;
					if (num != 0)
					{
					}
					global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
					stopwatch.Start();
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> enumerable = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListRadioFeatureSummaryByFeature(this.a, startIndex, length, this.b);
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase>();
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary> enumerator = enumerable.GetEnumerator();
					try
					{
						num = (short)936116228;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase radioLicenseFeatureViewBase;
								if (radioLicenseFeatureViewBase != null)
								{
									num = (short)120979458;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_1F0;
							case 2:
							{
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase radioLicenseFeatureViewBase;
								list.Add(radioLicenseFeatureViewBase);
								num = (short)1050935302;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								num = (short)1372389377;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_12F;
								}
								continue;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)621477891;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSummary summary = enumerator.Current;
								global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase radioLicenseFeatureViewBase = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioLicenseService.ConvertLicenseSummaryToLicenseFeatureViewBase(summary);
								num = (short)790822912;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_17B:
							num = (short)1796866053;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_12F:
							goto IL_17B;
						}
						IL_1F0:;
					}
					finally
					{
						num = (short)1804992512;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_226;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1229389826;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_25B;
							}
							IL_226:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1534787585;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_25B:;
					}
					stopwatch.Stop();
					milliseconds = (int)stopwatch.ElapsedMilliseconds;
					return list;
				}
				}
			}

			// Token: 0x06000380 RID: 896 RVA: 0x00053A44 File Offset: 0x00051C44
			public int GetTotalCount()
			{
				short num = (short)1352683738;
				short num2 = num;
				num = (short)1988645082;
				switch (num2 == num)
				{
				default:
				{
					num = (short)607649792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)654573569;
				if (num != 0)
				{
				}
				num = (short)2043674624;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListRadioFeatureSummaryByRadio(this.a, this.b);
			}

			// Token: 0x06000381 RID: 897 RVA: 0x00053B04 File Offset: 0x00051D04
			public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseFeatureViewBase item)
			{
				short num = (short)1667825665;
				if (num != 0)
				{
				}
				num = (short)745603072;
				short num2 = num;
				num = (short)332055295;
				short num3 = num;
				num = (short)1268433663;
				switch (num3 == num)
				{
				}
				num = (short)481361920;
				if (num != 0)
				{
				}
				item.Validator = null;
			}

			// Token: 0x040000A3 RID: 163
			private global::System.Guid? a;

			// Token: 0x040000A4 RID: 164
			private int b;
		}
	}
}
