using System;
using System.Collections.Generic;
using System.Data.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000070 RID: 112
	public class RadioLicenseAllViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>
	{
		// Token: 0x0600036E RID: 878 RVA: 0x000524E4 File Offset: 0x000506E4
		public RadioLicenseAllViewCache(global::System.Guid? groupUuid, int featureType = 0) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioLicenseAllViewProvider(groupUuid, featureType), null, 500)
		{
			this.a = groupUuid;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0005250C File Offset: 0x0005070C
		public override void ItemChanged<TV>(global::System.Data.Linq.ChangeAction operationType, global::System.Collections.Generic.List<TV> changedItem, global::System.Collections.Generic.List<global::System.Guid> legacyGuidList = null, params object[] otherParameters)
		{
			short num = (short)874708992;
			switch (num)
			{
			default:
			{
				num = (short)40239120;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					bool flag2;
					switch (num2)
					{
					case 0:
					{
						global::System.Guid? guid;
						global::System.Guid? guid2;
						if (guid != null != (guid2 != null))
						{
							num = (short)1823997958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)404488203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1017577490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						if (flag)
						{
							num = (short)565641225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						return;
					case 5:
					{
						global::System.Guid? guid;
						global::System.Guid? guid2;
						flag2 = (guid.GetValueOrDefault() != guid2.GetValueOrDefault());
						goto IL_3B6;
					}
					case 6:
						goto IL_20C;
					case 7:
						num = (short)1395654657;
						if (num != 0)
						{
						}
						flag2 = false;
						goto IL_3B6;
					case 8:
					{
						global::System.Guid? guid3 = otherParameters[0] as global::System.Guid?;
						num = (short)856621070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						base.ItemChanged<TV>(operationType, changedItem, legacyGuidList, global::System.Array.Empty<object>());
						num = (short)1560084484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_211;
					case 11:
					{
						global::System.Guid? guid;
						if (guid == null)
						{
							num = (short)569638929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)350617605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (otherParameters != null)
						{
							num = (short)468713473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_211;
					case 13:
						flag2 = true;
						goto IL_3B6;
					case 14:
						if (this.a != null)
						{
							num = (short)1169227791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_211;
					case 15:
					{
						global::System.Guid? guid3;
						global::System.Guid? guid = guid3;
						global::System.Guid? guid2 = this.a;
						num = (short)1712521216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						switch (0)
						{
						case 0:
							goto IL_94;
						}
						continue;
					case 17:
						num = (short)329580551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						num = (short)976275274;
						short num3 = num;
						num = (short)937674570;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_20C;
						case 1:
							break;
						default:
						{
							num = (short)851968000;
							short num4 = num;
							break;
						}
						}
						num = (short)1054081024;
						if (num != 0)
						{
						}
						if (otherParameters.Length != 0)
						{
							num = (short)2008219656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_211;
					}
					case 19:
						flag = false;
						num = (short)2034302986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_94:
					if (typeof(TV) != typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase))
					{
						num = (short)1440350210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = true;
					num = (short)1919221772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20C:
					num = (short)151781389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_211:
					num = (short)344064003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B6:
					if (!flag2)
					{
						goto IL_211;
					}
					num = (short)1431633939;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0400009B RID: 155
		private global::System.Guid? a;
	}
}
