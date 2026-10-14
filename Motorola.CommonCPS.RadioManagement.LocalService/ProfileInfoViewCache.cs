using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000086 RID: 134
	public class ProfileInfoViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo>
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x00056A00 File Offset: 0x00054C00
		public ProfileInfoViewCache(global::System.Guid? groupId) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.ProfileInfoViewCache.ProfileInfoViewProvider(groupId), null, 500)
		{
		}

		// Token: 0x02000087 RID: 135
		public class ProfileInfoViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo>
		{
			// Token: 0x060003BA RID: 954 RVA: 0x00056A20 File Offset: 0x00054C20
			public ProfileInfoViewProvider(global::System.Guid? groupId)
			{
				this.a = groupId;
			}

			// Token: 0x060003BB RID: 955 RVA: 0x00056A3C File Offset: 0x00054C3C
			public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo> FetchRange(int startIndex, int length, out int milliseconds)
			{
				short num = (short)1463883684;
				short num2 = num;
				num = (short)261560228;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_208;
				case 1:
					break;
				default:
				{
					num = (short)479920128;
					short num3 = num;
					break;
				}
				}
				num = (short)180617216;
				if (num != 0)
				{
				}
				num = (short)2010710016;
				global::System.Diagnostics.Stopwatch stopwatch;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo> list;
				switch (num)
				{
				default:
				{
					num = (short)2104164353;
					if (num != 0)
					{
					}
					stopwatch = new global::System.Diagnostics.Stopwatch();
					stopwatch.Start();
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.DataProfileInfo> enumerable = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).ListDataProfileInfo(this.a, startIndex, length);
					list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo>();
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.DataProfileInfo> enumerator = enumerable.GetEnumerator();
					try
					{
						num = (short)1860960257;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								goto IL_199;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_11D;
								}
								continue;
							case 3:
								num = (short)2020343808;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)682950659;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo item = enumerator.Current.ToUiModel();
								list.Add(item);
								num = (short)495976450;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_149:
							num = (short)2132934660;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_11D:
							goto IL_149;
						}
						IL_199:;
					}
					finally
					{
						num = (short)1356922880;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1CD;
								}
								continue;
							case 1:
								goto IL_205;
							case 2:
								enumerator.Dispose();
								num = (short)793378817;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1CD:
							if (enumerator == null)
							{
								break;
							}
							num = (short)198639618;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_205:;
					}
					break;
				}
				}
				IL_208:
				stopwatch.Stop();
				milliseconds = (int)stopwatch.ElapsedMilliseconds;
				return list;
			}

			// Token: 0x060003BC RID: 956 RVA: 0x00056C74 File Offset: 0x00054E74
			public int GetTotalCount()
			{
				short num = (short)359268353;
				if (num != 0)
				{
				}
				num = (short)987345419;
				short num2 = num;
				num = (short)1986114059;
				switch (num2 == num)
				{
				}
				num = (short)25100288;
				if (num != 0)
				{
				}
				num = (short)739508224;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetDataProfileInfoCount(this.a);
			}

			// Token: 0x060003BD RID: 957 RVA: 0x00056D30 File Offset: 0x00054F30
			public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo item)
			{
				short num = (short)1811668833;
				short num2 = num;
				num = (short)572055393;
				switch (num2 == num)
				{
				}
				num = (short)2136145921;
				if (num != 0)
				{
				}
				num = (short)764084224;
				if (num != 0)
				{
				}
				num = (short)1202192384;
				short num3 = num;
			}

			// Token: 0x040000B9 RID: 185
			private global::System.Guid? a;
		}
	}
}
