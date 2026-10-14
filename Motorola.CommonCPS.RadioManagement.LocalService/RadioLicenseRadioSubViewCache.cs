using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000076 RID: 118
	public class RadioLicenseRadioSubViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>
	{
		// Token: 0x06000382 RID: 898 RVA: 0x00053BB4 File Offset: 0x00051DB4
		public RadioLicenseRadioSubViewCache(global::System.Guid radioUuid, int featureType = 0) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioLicenseRadioSubViewProvider(radioUuid, featureType), null, 500)
		{
			this.a = radioUuid;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00053BDC File Offset: 0x00051DDC
		public override void ItemChanged<TV>(global::System.Data.Linq.ChangeAction operationType, global::System.Collections.Generic.List<TV> changedItem, global::System.Collections.Generic.List<global::System.Guid> legacyGuidList = null, params object[] otherParameters)
		{
			int a_ = 4;
			short num = (short)520486914;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)1244483336;
					short num3 = num;
					num = (short)283856648;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)507707392;
						if (num != 0)
						{
						}
						global::System.Guid? guid;
						if (guid.Value != this.a)
						{
							num = (short)1698496516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5;
					}
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 3:
				{
					global::System.Collections.Generic.List<global::System.Guid?> list = (changedItem as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>).Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase, global::System.Guid?>(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioLicenseRadioSubViewCache.<>c__2<TV>.<>9.a)).Distinct<global::System.Guid?>().ToList<global::System.Guid?>();
					if (list.Count > 1)
					{
						goto Block_3;
					}
					if (list[0] == null)
					{
						goto Block_4;
					}
					global::System.Guid? guid = list[0];
					num = (short)2019688449;
					if (num != 0)
					{
					}
					num = (short)1579941889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_1B8;
				}
				IL_41:
				if (!base.IsTypeMatchViewCache(typeof(TV)))
				{
					num = (short)1814298624;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1098317827;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return;
			Block_3:
			throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䰝䄟䘡䴣䤥搧䌩伫䬭帯䄱儳搵夷帹唻儽ᘿ⭁⅃ㅅେ⭉⽋♍㕏牑㥓㥕⩗㽙籛⩝࡟͡੣䙥ݧѩ५乭ɯ፱ၳή᝷婹ၻ᝽ꪉ曆ﺍﲗ", a_));
			Block_4:
			throw new global::System.Exception(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䰝䄟䘡䴣䤥搧䌩伫䬭帯䄱儳搵夷帹唻儽ᘿ⭁⅃ㅅେ⭉⽋♍㕏牑♓㝕㱗㍙㍛繝ᕟᝡൣɥ䡧ͩὫ乭ṯݱᡳ᩵", a_));
			IL_1B8:
			num = (short)784072704;
			short num4 = num;
			return;
			IL_1E5:
			base.ItemChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>(operationType, changedItem as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase>, legacyGuidList, otherParameters);
		}

		// Token: 0x040000A5 RID: 165
		private global::System.Guid a;
	}
}
