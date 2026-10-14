using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200008D RID: 141
	public class RadioToProfileViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>
	{
		// Token: 0x060003C9 RID: 969 RVA: 0x00057604 File Offset: 0x00055804
		public RadioToProfileViewProvider(global::System.Guid radioUuid)
		{
			this.a = radioUuid;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00057620 File Offset: 0x00055820
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)96010240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					break;
				default:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> list;
					global::System.Diagnostics.Stopwatch stopwatch;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
							if (startIndex == 0)
							{
								num = (short)981532674;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_293;
						case 1:
							num = (short)1338507265;
							if (num != 0)
							{
							}
							try
							{
								num = (short)1868103681;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_154;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_D7;
										}
										continue;
									case 3:
										num = (short)1173356544;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1214578691;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile item = enumerator.Current.ToUiModel(false);
										list.Add(item);
										num = (short)1853489154;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_106:
									num = (short)778502148;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_D7:
									goto IL_106;
								}
								IL_154:
								goto IL_282;
							}
							finally
							{
								num = (short)496959488;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> enumerator;
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_18D;
										}
										continue;
									case 1:
										goto IL_1C2;
									case 2:
										enumerator.Dispose();
										num = (short)560463873;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_18D:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1760886786;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1C2:;
							}
							goto IL_1C5;
						case 2:
						{
							num = (short)1276248064;
							short num3 = num;
							goto IL_1C5;
						}
						}
						goto IL_3A;
						IL_1C5:
						num = (short)415449741;
						short num4 = num;
						num = (short)1878540941;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3D;
						default:
						{
							num = (short)2139226112;
							if (num != 0)
							{
							}
							stopwatch = new global::System.Diagnostics.Stopwatch();
							stopwatch.Start();
							global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> enumerable = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListProfilesByRadio(this.a);
							list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>();
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> enumerator = enumerable.GetEnumerator();
							num = (short)56623105;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					IL_282:
					stopwatch.Stop();
					milliseconds = (int)stopwatch.ElapsedMilliseconds;
					return list;
					IL_293:
					return new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>();
				}
				}
				IL_3A:
				milliseconds = 0;
				IL_3D:
				num = (short)1894187008;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x000578D8 File Offset: 0x00055AD8
		public int GetTotalCount()
		{
			short num = (short)1006662052;
			short num2 = num;
			num = (short)1416655268;
			switch (num2 == num)
			{
			}
			num = (short)1992949761;
			if (num != 0)
			{
			}
			num = (short)912982016;
			if (num != 0)
			{
			}
			num = (short)246284288;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetProfileCountByRadio(this.a);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00057994 File Offset: 0x00055B94
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile item)
		{
			short num = (short)997392385;
			if (num != 0)
			{
			}
			num = (short)1400967514;
			short num2 = num;
			num = (short)1406734682;
			switch (num2 == num)
			{
			}
			num = (short)1986527232;
			if (num != 0)
			{
			}
			num = (short)569180160;
			short num3 = num;
			item.a();
		}

		// Token: 0x040000BD RID: 189
		private global::System.Guid a;
	}
}
