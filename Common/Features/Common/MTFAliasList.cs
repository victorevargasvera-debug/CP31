using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Common;

namespace Features.Common
{
	// Token: 0x02000006 RID: 6
	public class MTFAliasList
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002904 File Offset: 0x00000B04
		private MTFAliasList()
		{
			this.a = new global::System.Collections.Generic.Dictionary<string, string>();
			this.b = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002930 File Offset: 0x00000B30
		public static global::Features.Common.MTFAliasList Instance
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)647866751;
				short num2 = num;
				num = (short)1330030975;
				switch (num2 == num)
				{
				}
				num = (short)255459329;
				if (num != 0)
				{
				}
				num = (short)227540992;
				short num3 = num;
				num = (short)44433408;
				if (num != 0)
				{
				}
				return global::Features.Common.MTFAliasList.c;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000029E0 File Offset: 0x00000BE0
		public void AddAlias(string alias, string map)
		{
			short num = (short)2039808001;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C9;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 2:
					goto IL_CB;
				case 3:
				{
					if (this.a.ContainsKey(alias))
					{
						num = (short)1024196608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1830242273;
					short num3 = num;
					num = (short)806438881;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CB;
					default:
						goto IL_121;
					}
					break;
				}
				case 4:
					goto IL_8D;
				}
				IL_3A:
				num = (short)619053056;
				short num4 = num;
				if (map == null)
				{
					num = (short)1027276802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8D:
				num = (short)1444085763;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CB:
				map = string.Empty;
				num = (short)318373892;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C9:
			this.a[alias] = map;
			return;
			IL_121:
			num = (short)2101673985;
			if (num != 0)
			{
			}
			num = (short)1135411200;
			if (num != 0)
			{
			}
			this.a.Add(alias, map);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002B5C File Offset: 0x00000D5C
		public string GetAliasMap(string alias)
		{
			short num = (short)1182007297;
			if (num != 0)
			{
			}
			num = (short)954047821;
			short num2 = num;
			num = (short)2091228493;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_AC;
			case 1:
				break;
			default:
			{
				num = (short)1154678784;
				short num3 = num;
				break;
			}
			}
			num = (short)1416495104;
			if (num != 0)
			{
			}
			if (!this.a.ContainsKey(alias))
			{
				return string.Empty;
			}
			IL_AC:
			return this.a[alias];
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002C2C File Offset: 0x00000E2C
		public global::System.Collections.Generic.List<string> GetFreonModelNumber()
		{
			short num = (short)509804544;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)477822976;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				case 1:
					this.a();
					num = (short)110690306;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)2078851639;
					short num4 = num;
					num = (short)58901047;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_F6;
					}
					break;
				}
				}
				IL_58:
				if (this.b.Any<string>())
				{
					goto IL_10F;
				}
				num = (short)1592655873;
				if (num != 0)
				{
				}
				num = (short)1796669441;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F6:
			num = (short)1194786816;
			if (num != 0)
			{
			}
			IL_10F:
			return this.b;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002D50 File Offset: 0x00000F50
		private void a()
		{
			int a_ = 16;
			short num = (short)1038024704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				string aliasMap;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.List<string>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						if (!string.IsNullOrEmpty(aliasMap))
						{
							num = (short)1618149377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_1EB;
					case 2:
					{
						num = (short)226885632;
						short num3 = num;
						try
						{
							num = (short)2100756484;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)2085813406;
									short num4 = num;
									num = (short)882769054;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1036845056;
										if (num != 0)
										{
										}
										num = (short)1949237250;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1330839552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string alias = enumerator.Current;
									string aliasMap2 = global::Features.Common.MTFAliasList.Instance.GetAliasMap(alias);
									this.b.AddRange(global::Features.Common.MTFAliasList.a(aliasMap2));
									num = (short)1355808771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1DB;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_FF;
									}
									continue;
								}
								IL_101:
								num = (short)1394081793;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FF:
								goto IL_101;
							}
							IL_1DB:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1EB;
					}
					}
					goto IL_44;
					IL_1EB:
					enumerator = global::Features.Common.MTFAliasList.a(aliasMap).GetEnumerator();
					num = (short)525664258;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_44:
				num = (short)832372737;
				if (num != 0)
				{
				}
				aliasMap = global::Features.Common.MTFAliasList.Instance.GetAliasMap(global::Common.Product.b("堸帺戼社ፀق੄ॆ", a_));
				num = (short)869269504;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002FB8 File Offset: 0x000011B8
		private static global::System.Collections.Generic.List<string> a(string A_0)
		{
			int a_ = 11;
			short num = (short)979501056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				int num3;
				string[] array;
				global::System.Collections.Generic.List<string> list;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						if (num3 >= array.Length)
						{
							num = (short)1883832321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = array[num3];
						num = (short)2134507522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)1290844999;
						short num4 = num;
						num = (short)183024455;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_115;
						default:
							goto IL_20B;
						}
						break;
					}
					case 2:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)145096709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C0;
					}
					case 3:
						goto IL_C0;
					case 4:
						num = (short)982056961;
						if (num != 0)
						{
						}
						goto IL_19E;
					case 5:
					{
						string text;
						list.Add(text.Trim());
						goto IL_115;
					}
					case 6:
						goto IL_19E;
					}
					goto IL_53;
					IL_C0:
					num3++;
					num = (short)886964228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_115:
					num = (short)2082537472;
					short num5 = num;
					num = (short)761266179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19E:
					num = (short)686620672;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_20B:
				num = (short)898367488;
				if (num != 0)
				{
				}
				return list;
				IL_53:
				list = new global::System.Collections.Generic.List<string>();
				A_0 = A_0.Replace(global::Common.Product.b("ᰳ", a_), "").Replace(global::Common.Product.b("ᴳ", a_), "");
				array = global::System.Text.RegularExpressions.Regex.Split(A_0, global::Common.Product.b("栳䨵搷䘹", a_));
				num3 = 0;
				num = (short)1022754822;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000031E8 File Offset: 0x000013E8
		// Note: this type is marked as 'beforefieldinit'.
		static MTFAliasList()
		{
			short num = (short)1643612615;
			short num2 = num;
			num = (short)1386908103;
			switch (num2 == num)
			{
			}
			num = (short)1031602176;
			short num3 = num;
			num = (short)925958145;
			if (num != 0)
			{
			}
			num = (short)65011712;
			if (num != 0)
			{
			}
			global::Features.Common.MTFAliasList.c = new global::Features.Common.MTFAliasList();
		}

		// Token: 0x04000007 RID: 7
		private global::System.Collections.Generic.Dictionary<string, string> a;

		// Token: 0x04000008 RID: 8
		private global::System.Collections.Generic.List<string> b;

		// Token: 0x04000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static readonly global::Features.Common.MTFAliasList c;
	}
}
