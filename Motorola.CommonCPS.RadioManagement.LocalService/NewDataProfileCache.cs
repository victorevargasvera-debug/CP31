using System;
using System.Collections.Generic;
using System.Threading;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000020 RID: 32
	public class NewDataProfileCache
	{
		// Token: 0x06000173 RID: 371 RVA: 0x00018D38 File Offset: 0x00016F38
		private NewDataProfileCache()
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00018D58 File Offset: 0x00016F58
		public static global::Motorola.CommonCPS.RadioManagement.LocalService.NewDataProfileCache Instance
		{
			get
			{
				short num = (short)623640576;
				short num2 = num;
				num = (short)1127186654;
				short num3 = num;
				num = (short)1121747166;
				switch (num3 == num)
				{
				}
				num = (short)1126760449;
				if (num != 0)
				{
				}
				num = (short)1483210752;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.LocalService.NewDataProfileCache.a;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00018E0C File Offset: 0x0001700C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile GetCachedNewSystem(global::System.Guid legacyGuid)
		{
			short num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile result;
			for (;;)
			{
				num = (short)2023620609;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> obj = this.b;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_53;
					}
					int num2;
					for (;;)
					{
						IL_3D:
						switch (num2)
						{
						case 0:
							if (!this.b.ContainsKey(legacyGuid))
							{
								num = (short)1041367043;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = this.b[legacyGuid];
							num = (short)762052610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_A9;
						case 2:
							goto IL_D2;
						case 3:
							result = null;
							num = (short)1145831425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53;
					}
					IL_A9:
					IL_D2:
					goto IL_13E;
					IL_53:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)1197473792;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_3D;
				}
				finally
				{
					num = (short)1387790336;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_104;
							}
							continue;
						case 1:
							goto IL_13B;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)426704897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_104:
						if (!flag)
						{
							break;
						}
						num = (short)341966850;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_13B:;
				}
				IL_13E:
				num = (short)1926390900;
				short num3 = num;
				num = (short)1692427380;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_173;
				}
			}
			IL_173:
			num = (short)1849360384;
			if (num != 0)
			{
			}
			num = (short)1316618240;
			short num4 = num;
			return result;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00018FE0 File Offset: 0x000171E0
		public void Add(global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> list)
		{
			short num = (short)392429568;
			switch (num)
			{
			default:
			{
				num = (short)832372736;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> obj;
					bool flag;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_52;
						}
						continue;
					case 1:
					{
						num = (short)1023928233;
						short num3 = num;
						num = (short)1940121513;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						case 1:
							break;
						default:
						{
							num = (short)1740636160;
							short num4 = num;
							break;
						}
						}
						num = (short)509280256;
						if (num != 0)
						{
						}
						try
						{
							global::System.Threading.Monitor.Enter(obj, ref flag);
							using (global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>.KeyCollection.Enumerator enumerator = list.Keys.GetEnumerator())
							{
								num = (short)1664548867;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1C5;
									case 1:
									{
										global::System.Guid key;
										this.b[key] = list[key];
										num = (short)1895038981;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_CE;
										}
										continue;
									case 4:
									{
										global::System.Guid key;
										if (this.b.ContainsKey(key))
										{
											num = (short)927399937;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										this.b.Add(key, list[key]);
										num = (short)345440258;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										num = (short)2030370816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1490878470;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Guid key = enumerator.Current;
										num = (short)1595998212;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_114:
									num = (short)255393799;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_CE:
									goto IL_114;
								}
								IL_1C5:
								return;
							}
						}
						finally
						{
							num = (short)1729167360;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_20A;
									}
									continue;
								case 1:
									goto IL_242;
								case 2:
									global::System.Threading.Monitor.Exit(obj);
									num = (short)1791623169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_20A:
								if (!flag)
								{
									break;
								}
								num = (short)1780678658;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_242:;
						}
						goto IL_245;
					}
					case 2:
						return;
					}
					IL_52:
					if (list == null)
					{
						num = (short)2094006274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_245:
					obj = this.b;
					flag = false;
					num = (short)827326465;
					if (num != 0)
					{
					}
					num = (short)454164481;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00019328 File Offset: 0x00017528
		public void Clear()
		{
			short num = (short)1428553728;
			short num2 = num;
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> obj = this.b;
			bool flag = false;
			try
			{
				global::System.Threading.Monitor.Enter(obj, ref flag);
				this.b.Clear();
			}
			finally
			{
				num = (short)1844903936;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						IL_61:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 1:
						goto IL_B4;
					case 2:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)1024196609;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7D:
					if (flag)
					{
						num = (short)2095316994;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B4:
					num = (short)1229923642;
					short num4 = num;
					num = (short)2050565434;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_61;
					default:
						goto IL_E8;
					}
				}
				IL_E8:
				num = (short)625016832;
				if (num != 0)
				{
				}
			}
			num = (short)236584961;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0001946C File Offset: 0x0001766C
		// Note: this type is marked as 'beforefieldinit'.
		static NewDataProfileCache()
		{
			short num = (short)110528440;
			short num2 = num;
			num = (short)1104316344;
			switch (num2 == num)
			{
			default:
			{
				num = (short)772866048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1350631425;
			if (num != 0)
			{
			}
			num = (short)1442250752;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.NewDataProfileCache.a = new global::Motorola.CommonCPS.RadioManagement.LocalService.NewDataProfileCache();
		}

		// Token: 0x04000036 RID: 54
		private static readonly global::Motorola.CommonCPS.RadioManagement.LocalService.NewDataProfileCache a;

		// Token: 0x04000037 RID: 55
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> b = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>();
	}
}
