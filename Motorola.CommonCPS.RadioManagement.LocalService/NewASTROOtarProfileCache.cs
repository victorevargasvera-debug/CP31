using System;
using System.Collections.Generic;
using System.Threading;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000021 RID: 33
	public class NewASTROOtarProfileCache
	{
		// Token: 0x06000179 RID: 377 RVA: 0x0001951C File Offset: 0x0001771C
		private NewASTROOtarProfileCache()
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600017A RID: 378 RVA: 0x0001953C File Offset: 0x0001773C
		public static global::Motorola.CommonCPS.RadioManagement.LocalService.NewASTROOtarProfileCache Instance
		{
			get
			{
				short num = (short)522511704;
				short num2 = num;
				num = (short)1592649048;
				switch (num2 == num)
				{
				default:
				{
					num = (short)610402304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)262864896;
				if (num != 0)
				{
				}
				num = (short)1494482945;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.LocalService.NewASTROOtarProfileCache.a;
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000195EC File Offset: 0x000177EC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile GetCachedNewProfile(global::System.Guid legacyGuid)
		{
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile result;
			for (;;)
			{
				global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> obj = this.b;
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
								num2 = (short)208994307;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							result = this.b[legacyGuid];
							num2 = (short)1519321090;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							goto IL_81;
						case 2:
							goto IL_AC;
						case 3:
							result = null;
							num2 = (short)2136080385;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2B;
					}
					IL_81:
					IL_AC:
					goto IL_140;
					IL_2B:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num2 = (short)368640000;
					num = (int)((global::System.IntPtr)num2);
					goto IL_15;
				}
				finally
				{
					num2 = (short)548274176;
					int num = (int)((global::System.IntPtr)num2);
					for (;;)
					{
						switch (num)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_E1;
							}
							continue;
						case 1:
							goto IL_13D;
						case 2:
							num2 = (short)2051342337;
							if (num2 != 0)
							{
							}
							global::System.Threading.Monitor.Exit(obj);
							num2 = (short)303038465;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						IL_E1:
						if (!flag)
						{
							break;
						}
						num2 = (short)1195638786;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_13D:;
				}
				IL_140:
				num2 = (short)736886784;
				short num3 = num2;
				num2 = (short)2082415377;
				short num4 = num2;
				num2 = (short)431956753;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_19E;
				}
			}
			IL_19E:
			num2 = (short)1057161216;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000197C0 File Offset: 0x000179C0
		public void Add(global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> list)
		{
			short num = (short)532545536;
			switch (num)
			{
			default:
			{
				num = (short)1069416448;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> obj;
					bool flag;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					case 1:
					{
						num = (short)1463153940;
						short num3 = num;
						num = (short)1791620372;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						case 1:
							break;
						default:
						{
							num = (short)909377536;
							short num4 = num;
							break;
						}
						}
						num = (short)1649016832;
						if (num != 0)
						{
						}
						try
						{
							global::System.Threading.Monitor.Enter(obj, ref flag);
							using (global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>.KeyCollection.Enumerator enumerator = list.Keys.GetEnumerator())
							{
								num = (short)380305411;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1C4;
									case 1:
									{
										global::System.Guid key;
										this.b[key] = list[key];
										num = (short)502333445;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_CD;
										}
										continue;
									case 4:
									{
										global::System.Guid key;
										if (this.b.ContainsKey(key))
										{
											num = (short)644546561;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										this.b.Add(key, list[key]);
										num = (short)649658370;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										num = (short)1975582720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1310261254;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Guid key = enumerator.Current;
										num = (short)364445700;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_111:
									num = (short)1422655495;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_CD:
									goto IL_111;
								}
								IL_1C4:
								return;
							}
						}
						finally
						{
							num = (short)1320353792;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_209;
									}
									continue;
								case 1:
									goto IL_23E;
								case 2:
									global::System.Threading.Monitor.Exit(obj);
									num = (short)1272774657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_209:
								if (!flag)
								{
									break;
								}
								num = (short)756482050;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_23E:;
						}
						goto IL_241;
					}
					case 2:
						return;
					}
					IL_50:
					if (list == null)
					{
						num = (short)820051970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_241:
					num = (short)717291521;
					if (num != 0)
					{
					}
					obj = this.b;
					flag = false;
					num = (short)63438849;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00019B08 File Offset: 0x00017D08
		public void Clear()
		{
			global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> obj = this.b;
			bool flag = false;
			short num;
			try
			{
				num = (short)677904385;
				if (num != 0)
				{
				}
				global::System.Threading.Monitor.Enter(obj, ref flag);
				this.b.Clear();
			}
			finally
			{
				num = (short)1077805056;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						IL_62:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 1:
						goto IL_B4;
					case 2:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)833552385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7E:
					if (flag)
					{
						num = (short)849477634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B4:
					num = (short)1890082140;
					short num3 = num;
					num = (short)660299100;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_62;
					default:
						goto IL_EA;
					}
				}
				IL_EA:
				num = (short)1808531456;
				if (num != 0)
				{
				}
			}
			num = (short)1835991040;
			short num4 = num;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00019C50 File Offset: 0x00017E50
		// Note: this type is marked as 'beforefieldinit'.
		static NewASTROOtarProfileCache()
		{
			short num = (short)2015376063;
			short num2 = num;
			num = (short)1565405887;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1324482560;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)16056321;
			if (num != 0)
			{
			}
			num = (short)362217472;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.NewASTROOtarProfileCache.a = new global::Motorola.CommonCPS.RadioManagement.LocalService.NewASTROOtarProfileCache();
		}

		// Token: 0x04000038 RID: 56
		private static readonly global::Motorola.CommonCPS.RadioManagement.LocalService.NewASTROOtarProfileCache a;

		// Token: 0x04000039 RID: 57
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile> b = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>();
	}
}
