using System;
using System.Collections.Generic;
using System.Threading;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000022 RID: 34
	public class NewSystemCache
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00019D04 File Offset: 0x00017F04
		private NewSystemCache()
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00019D24 File Offset: 0x00017F24
		public static global::Motorola.CommonCPS.RadioManagement.LocalService.NewSystemCache Instance
		{
			get
			{
				short num = (short)943760247;
				short num2 = num;
				num = (short)1466213239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1784676352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1745027073;
				if (num != 0)
				{
				}
				num = (short)1251737600;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.LocalService.NewSystemCache.a;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00019DD0 File Offset: 0x00017FD0
		public global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem GetCachedNewSystem(global::System.Guid legacyGuid)
		{
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem result;
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> obj = this.b;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_2B;
					}
					int num;
					for (;;)
					{
						IL_15:
						switch (num)
						{
						case 0:
							if (!this.b.ContainsKey(legacyGuid))
							{
								num2 = (short)2120941571;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							result = this.b[legacyGuid];
							num2 = (short)130678786;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							goto IL_84;
						case 2:
							goto IL_AE;
						case 3:
							result = null;
							num2 = (short)1915944961;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2B;
					}
					IL_84:
					IL_AE:
					goto IL_143;
					IL_2B:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num2 = (short)1868103680;
					num = (int)((global::System.IntPtr)num2);
					goto IL_15;
				}
				finally
				{
					num2 = (short)265945088;
					int num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							num2 = (short)287637505;
							if (num2 != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_10B;
							}
							continue;
						case 1:
							goto IL_140;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num2 = (short)1716387841;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						IL_10B:
						if (!flag)
						{
							break;
						}
						num2 = (short)177668098;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_140:;
				}
				IL_143:
				num2 = (short)856195454;
				short num3 = num2;
				num2 = (short)58229118;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_1A2;
				}
				break;
			}
			num2 = (short)1057751040;
			short num4 = num2;
			IL_1A2:
			num2 = (short)102301696;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00019FA8 File Offset: 0x000181A8
		public void Add(global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> list)
		{
			short num = (short)527695872;
			switch (num)
			{
			default:
			{
				num = (short)614727682;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> obj;
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_6B;
					case 1:
						try
						{
							global::System.Threading.Monitor.Enter(obj, ref flag);
							using (global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>.KeyCollection.Enumerator enumerator = list.Keys.GetEnumerator())
							{
								num = (short)1052508166;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
									{
										num = (short)1271821468;
										short num3 = num;
										num = (short)1857123484;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)206241792;
											if (num != 0)
											{
											}
											break;
										}
										break;
									}
									case 2:
										num = (short)1484980228;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)2117664770;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Guid key = enumerator.Current;
										num = (short)60293125;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_20F;
									case 5:
									{
										global::System.Guid key;
										if (this.b.ContainsKey(key))
										{
											num = (short)1987182599;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										this.b.Add(key, list[key]);
										num = (short)256049152;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_CC;
										}
										continue;
									case 7:
									{
										global::System.Guid key;
										this.b[key] = list[key];
										num = (short)1198718977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_111:
									num = (short)767164419;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_CC:
									goto IL_111;
								}
								IL_20F:
								return;
							}
						}
						finally
						{
							num = (short)2117271554;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)679608321;
								if (num != 0)
								{
								}
								switch (num2)
								{
								case 0:
									global::System.Threading.Monitor.Exit(obj);
									num = (short)1571160065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2B0;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_27B;
									}
									continue;
								}
								IL_27B:
								if (!flag)
								{
									break;
								}
								num = (short)138543104;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2B0:;
						}
						goto IL_2B3;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					}
					IL_50:
					if (list == null)
					{
						num = (short)1029963776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2B3:
					obj = this.b;
					flag = false;
					num = (short)388956161;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_6B:
				num = (short)445186048;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0001A2F0 File Offset: 0x000184F0
		public void Clear()
		{
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> obj = this.b;
			bool flag = false;
			short num;
			try
			{
				global::System.Threading.Monitor.Enter(obj, ref flag);
				this.b.Clear();
			}
			finally
			{
				num = (short)1076953090;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)1017053185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_DB;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_54;
						}
						continue;
					}
					IL_54:
					if (!flag)
					{
						break;
					}
					num = (short)1889146900;
					short num3 = num;
					num = (short)551950356;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DB;
					default:
						num = (short)415170560;
						if (num != 0)
						{
						}
						num = (short)588185600;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_DB:;
			}
			num = (short)1104150528;
			short num4 = num;
			num = (short)1073479681;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0001A440 File Offset: 0x00018640
		// Note: this type is marked as 'beforefieldinit'.
		static NewSystemCache()
		{
			short num = (short)1632423430;
			short num2 = num;
			num = (short)413453830;
			switch (num2 == num)
			{
			}
			num = (short)1599406080;
			short num3 = num;
			num = (short)905773056;
			if (num != 0)
			{
			}
			num = (short)352911361;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.NewSystemCache.a = new global::Motorola.CommonCPS.RadioManagement.LocalService.NewSystemCache();
		}

		// Token: 0x0400003A RID: 58
		private static readonly global::Motorola.CommonCPS.RadioManagement.LocalService.NewSystemCache a;

		// Token: 0x0400003B RID: 59
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem> b = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>();
	}
}
