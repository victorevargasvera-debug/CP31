using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000072 RID: 114
	public class RadioLicenseFeatureSubViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00052D24 File Offset: 0x00050F24
		public RadioLicenseFeatureSubViewCache(global::System.Guid? groupID, int featureID, int featureType) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioLicenseFeatureSubViewProvider(groupID, featureID, featureType), null, 500)
		{
			this.a = groupID;
			this.b = featureID;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00052D54 File Offset: 0x00050F54
		public override void ItemChanged<TV>(global::System.Data.Linq.ChangeAction operationType, global::System.Collections.Generic.List<TV> changedItem, global::System.Collections.Generic.List<global::System.Guid> legacyGuidList = null, params object[] otherParameters)
		{
			int a_ = 8;
			short num = (short)1946025997;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					if ((changedItem as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>).Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase, bool>(this.a<TV>)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>().Count == 0)
					{
						num = (short)490471430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_381;
				case 1:
					goto IL_244;
				case 2:
					flag = true;
					goto IL_2D6;
				case 3:
					flag = false;
					goto IL_2D6;
				case 4:
				{
					global::System.Guid? guid;
					if (guid == null)
					{
						num = (short)636157968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2144600075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					global::System.Guid? guid;
					global::System.Guid? guid2;
					if (guid != null != (guid2 != null))
					{
						num = (short)846528521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1894704482;
					short num3 = num;
					num = (short)2012407138;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_244;
					default:
						num = (short)103809024;
						if (num != 0)
						{
						}
						num = (short)203358212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					return;
				case 7:
				{
					num = (short)1020854272;
					short num4 = num;
					if (otherParameters.Length == 0)
					{
						num = (short)2035154952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Guid? guid = otherParameters[0] as global::System.Guid?;
					global::System.Guid? guid2 = this.a;
					num = (short)1299709957;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					goto IL_228;
				case 9:
					num = (short)885260290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					return;
				case 11:
				{
					global::System.Guid? guid;
					global::System.Guid? guid2;
					flag = (guid.GetValueOrDefault() != guid2.GetValueOrDefault());
					goto IL_2D6;
				}
				case 12:
					return;
				case 13:
					switch (0)
					{
					case 0:
						goto IL_73;
					}
					continue;
				case 14:
					return;
				case 15:
					num = (short)220725260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					num = (short)2066415619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_73:
				if (!base.IsTypeMatchViewCache(typeof(TV)))
				{
					num = (short)1435041807;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)589627393;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D6:
				if (flag)
				{
					num = (short)1650327562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)564592640;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_244:
				switch (operationType)
				{
				case global::System.Data.Linq.ChangeAction.None:
					return;
				case global::System.Data.Linq.ChangeAction.Delete:
				case global::System.Data.Linq.ChangeAction.Update:
					goto IL_15A;
				case global::System.Data.Linq.ChangeAction.Insert:
					num = (short)860618759;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)756350990;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_15A:
			base.ItemChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>(operationType, changedItem as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>, legacyGuidList, global::System.Array.Empty<object>());
			return;
			IL_228:
			num = (short)410910721;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("瀡䔣䈥䄧䔩怫䜭匯圱娳䔵崷簹夻弽㐿㝁㙃⍅ᭇ㽉⹋ᡍ㥏㝑⍓ᕕ㥗㥙㑛㭝䁟ౡୣብ䡧൩५ᩭ偯qᕳትᅷᕹ屻᥽ꢇﾏ", a_));
			IL_381:
			base.ItemChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>(operationType, changedItem as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>, null, global::System.Array.Empty<object>());
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000530F8 File Offset: 0x000512F8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a<a>(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase A_0) where a : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			short num = (short)1131953531;
			short num2 = num;
			num = (short)48774523;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1869021184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)101056512;
			if (num != 0)
			{
			}
			num = (short)2146304001;
			if (num != 0)
			{
			}
			return A_0.RawData.FeatureName == this.b;
		}

		// Token: 0x0400009E RID: 158
		private global::System.Guid? a;

		// Token: 0x0400009F RID: 159
		private int b;
	}
}
