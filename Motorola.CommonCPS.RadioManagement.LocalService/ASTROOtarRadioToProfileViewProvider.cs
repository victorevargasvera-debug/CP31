using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000066 RID: 102
	public class ASTROOtarRadioToProfileViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>
	{
		// Token: 0x06000354 RID: 852 RVA: 0x0005123C File Offset: 0x0004F43C
		public ASTROOtarRadioToProfileViewProvider(global::System.Guid radioUuid)
		{
			this.a = radioUuid;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00051258 File Offset: 0x0004F458
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)982581249;
			if (num != 0)
			{
			}
			num = (short)2114256896;
			switch (num)
			{
			default:
			{
				num = (short)1173684224;
				short num2 = num;
				global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
				stopwatch.Start();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>();
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor instance = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false);
				global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> apxotarProfilesByRadio = instance.GetAPXOtarProfilesByRadio(this.a);
				global::Motorola.CommonCPS.Server.EntityModel.Radio radio = instance.GetRadio(this.a, false);
				global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Add(this.a, radio);
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> enumerator = apxotarProfilesByRadio.GetEnumerator();
				try
				{
					num = (short)668925955;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
							for (;;)
							{
								num = (short)1739675445;
								short num4 = num;
								num = (short)80893749;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_193;
								}
							}
							IL_193:
							num = (short)2103050240;
							if (num != 0)
							{
							}
							num = (short)43515908;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1338900481;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile item = enumerator.Current.ToUiModel(false);
							list.Add(item);
							num = (short)1565065216;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_F6;
							}
							continue;
						case 4:
							goto IL_1C1;
						}
						IL_126:
						num = (short)2023882754;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F6:
						goto IL_126;
					}
					IL_1C1:;
				}
				finally
				{
					num = (short)1812660225;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1251803138;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1F6;
							}
							continue;
						case 2:
							goto IL_22D;
						}
						IL_1F6:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1135083520;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_22D:;
				}
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
			}
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000514C4 File Offset: 0x0004F6C4
		public int GetTotalCount()
		{
			short num = (short)1281142162;
			short num2 = num;
			num = (short)703835538;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1610022912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)139591680;
			if (num != 0)
			{
			}
			num = (short)450822145;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetAPXOtarProfilesByRadioCount(this.a);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00051580 File Offset: 0x0004F780
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile item)
		{
			short num = (short)1149428027;
			short num2 = num;
			num = (short)1102176571;
			switch (num2 == num)
			{
			default:
			{
				num = (short)206962688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)853409793;
			if (num != 0)
			{
			}
			num = (short)534904832;
			if (num != 0)
			{
			}
			item.a();
		}

		// Token: 0x04000096 RID: 150
		private global::System.Guid a;
	}
}
