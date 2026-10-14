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
	// Token: 0x02000068 RID: 104
	public class ASTROSystemViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>
	{
		// Token: 0x06000359 RID: 857 RVA: 0x0005164C File Offset: 0x0004F84C
		public ASTROSystemViewProvider(global::System.Guid? groupId)
		{
			this.a = groupId;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00051668 File Offset: 0x0004F868
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> FetchRange(int startIndex, int length, out int milliseconds)
		{
			int a_ = 5;
			short num = (short)1340604416;
			switch (num)
			{
			default:
			{
				num = (short)1071448065;
				if (num != 0)
				{
				}
				num = (short)2004418560;
				short num2 = num;
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>();
				global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer automaticPerformanceMeasurer = global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceMeasure.StartNewAutomatic(new global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationType.ViewLoad, global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䴞䀠䜢䰤䠦न砪听尮䔰嘲場䐶", a_)), null);
				try
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary> enumerator = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListAllRadioSystems(this.a, startIndex, length).GetEnumerator();
					try
					{
						num = (short)943390723;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 1:
								num = (short)971898884;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)286982145;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem item = enumerator.Current.ToUiModel(false);
								list.Add(item);
								num = (short)747241472;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_FE;
								}
								continue;
							case 4:
								goto IL_17B;
							}
							IL_12E:
							num = (short)2021720066;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_FE:
							goto IL_12E;
						}
						IL_17B:;
					}
					finally
					{
						num = (short)829489153;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)369295362;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1B2;
								}
								continue;
							case 2:
								goto IL_237;
							}
							IL_1B2:
							if (enumerator == null)
							{
								break;
							}
							num = (short)578760385;
							short num4 = num;
							num = (short)2119970497;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)995819520;
								if (num != 0)
								{
								}
								num = (short)535363584;
								num3 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_237:;
					}
				}
				finally
				{
					num = (short)2051014657;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							automaticPerformanceMeasurer.Dispose();
							num = (short)1482883074;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_26C;
							}
							continue;
						case 2:
							goto IL_2A5;
						}
						IL_26C:
						if (automaticPerformanceMeasurer == null)
						{
							break;
						}
						num = (short)288358400;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2A5:;
				}
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
			}
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00051964 File Offset: 0x0004FB64
		public int GetTotalCount()
		{
			short num = (short)1633746945;
			if (num != 0)
			{
			}
			num = (short)698023936;
			short num2 = num;
			num = (short)1071060834;
			short num3 = num;
			num = (short)1021581154;
			switch (num3 == num)
			{
			}
			num = (short)939917312;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetAllRadioSystemSummariesCount(this.a);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00051A20 File Offset: 0x0004FC20
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem item)
		{
			short num = (short)219365815;
			short num2 = num;
			num = (short)984105399;
			switch (num2 == num)
			{
			default:
			{
				num = (short)22151168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)102563840;
			if (num != 0)
			{
			}
			num = (short)363134977;
			if (num != 0)
			{
			}
			item.a();
		}

		// Token: 0x04000097 RID: 151
		private global::System.Guid? a;
	}
}
