using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200008B RID: 139
	public class ProfileToRadioViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>
	{
		// Token: 0x060003C4 RID: 964 RVA: 0x000571DC File Offset: 0x000553DC
		public ProfileToRadioViewProvider(global::System.Guid? groupId, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo profileInfo)
		{
			this.a = profileInfo;
			this.b = groupId;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00057200 File Offset: 0x00055400
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)1830905122;
			short num2 = num;
			num = (short)1944282402;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_22C;
			case 1:
				break;
			default:
			{
				num = (short)499384320;
				short num3 = num;
				break;
			}
			}
			num = (short)972357633;
			if (num != 0)
			{
			}
			num = (short)352780288;
			if (num != 0)
			{
			}
			num = (short)711000064;
			global::System.Diagnostics.Stopwatch stopwatch;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> list;
			switch (num)
			{
			default:
			{
				stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> enumerable = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListRadiosByProfile(this.b, this.a.ProfileName, (int)this.a.SystemType.Value, startIndex, length);
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary> enumerator = enumerable.GetEnumerator();
				try
				{
					num = (short)1839333377;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_1BC;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_13F;
							}
							continue;
						case 3:
							num = (short)746717184;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)230621187;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile item = enumerator.Current.ToUiModel(false);
							list.Add(item);
							num = (short)468713474;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_16E:
						num = (short)1854668804;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_13F:
						goto IL_16E;
					}
					IL_1BC:;
				}
				finally
				{
					num = (short)71106560;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1F1;
							}
							continue;
						case 1:
							goto IL_229;
						case 2:
							enumerator.Dispose();
							num = (short)1578500097;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1F1:
						if (enumerator == null)
						{
							break;
						}
						num = (short)871235586;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_229:;
				}
				break;
			}
			}
			IL_22C:
			stopwatch.Stop();
			milliseconds = (int)stopwatch.ElapsedMilliseconds;
			return list;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x0005745C File Offset: 0x0005565C
		public int GetTotalCount()
		{
			short num = (short)815508837;
			short num2 = num;
			num = (short)1640476005;
			switch (num2 == num)
			{
			}
			num = (short)486277121;
			if (num != 0)
			{
			}
			num = (short)1504509952;
			if (num != 0)
			{
			}
			num = (short)389218304;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetRadioCountByProfile(this.b, this.a.ProfileName, (int)this.a.SystemType.Value);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00057534 File Offset: 0x00055734
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile item)
		{
			short num = (short)92019632;
			short num2 = num;
			num = (short)1173953456;
			switch (num2 == num)
			{
			}
			num = (short)656474113;
			if (num != 0)
			{
			}
			num = (short)1320026112;
			if (num != 0)
			{
			}
			num = (short)1291911168;
			short num3 = num;
			item.a();
		}

		// Token: 0x040000BB RID: 187
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo a;

		// Token: 0x040000BC RID: 188
		private global::System.Guid? b;
	}
}
