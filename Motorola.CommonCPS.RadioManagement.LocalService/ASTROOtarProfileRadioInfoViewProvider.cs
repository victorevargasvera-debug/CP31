using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200005E RID: 94
	public class ASTROOtarProfileRadioInfoViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo>
	{
		// Token: 0x0600033F RID: 831 RVA: 0x0004FEB8 File Offset: 0x0004E0B8
		public ASTROOtarProfileRadioInfoViewProvider(global::System.Guid? groupId)
		{
			this.a = groupId;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0004FED4 File Offset: 0x0004E0D4
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)722599936;
			switch (num)
			{
			default:
			{
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO> apxotarProfileRadiosInfo = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetAPXOtarProfileRadiosInfo(this.a, startIndex, length);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileRadioInfoDTO> enumerator = apxotarProfileRadiosInfo.GetEnumerator();
				try
				{
					num = (short)145162240;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_85;
							}
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1202651140;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo item = enumerator.Current.ToUiModel();
							list.Add(item);
							num = (short)82182145;
							if (num != 0)
							{
							}
							num = (short)1103888387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_12C;
						case 4:
							num = (short)2001534978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_D8:
						num = (short)1706229761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_85:
						goto IL_D8;
					}
					IL_12C:;
				}
				finally
				{
					num = (short)2093744129;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1EC;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_164;
							}
							continue;
						case 2:
						{
							num = (short)1023612907;
							short num3 = num;
							num = (short)1871189995;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)841351168;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)265420800;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_164:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2125529090;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1EC:;
				}
				num = (short)1855651840;
				short num4 = num;
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
			}
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0005011C File Offset: 0x0004E31C
		public int GetTotalCount()
		{
			short num = (short)462422016;
			short num2 = num;
			num = (short)760896740;
			short num3 = num;
			num = (short)1087069412;
			switch (num3 == num)
			{
			}
			num = (short)243269633;
			if (num != 0)
			{
			}
			num = (short)1841233920;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetAPXOtarProfileRadiosInfoCount(this.a);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x000501D8 File Offset: 0x0004E3D8
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo item)
		{
			short num = (short)822804480;
			short num2 = num;
			num = (short)1656554777;
			short num3 = num;
			num = (short)1071973657;
			switch (num3 == num)
			{
			}
			num = (short)150339585;
			if (num != 0)
			{
			}
			num = (short)1505230848;
			if (num != 0)
			{
			}
		}

		// Token: 0x0400008E RID: 142
		private global::System.Guid? a;
	}
}
