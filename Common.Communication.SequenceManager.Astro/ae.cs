using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001F RID: 31
	internal sealed class ae
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x0001DD84 File Offset: 0x0001BF84
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(global::Motorola.Common.CustomException.CommonErrorCode A_0)
		{
			short num = (short)2002321408;
			short num2 = num;
			num = (short)501779804;
			short num3 = num;
			num = (short)1099664732;
			switch (num3 == num)
			{
			}
			num = (short)2065432577;
			if (num != 0)
			{
			}
			num = (short)736296960;
			if (num != 0)
			{
			}
			this.f = A_0;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0001DE38 File Offset: 0x0001C038
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public global::Motorola.Common.CustomException.CommonErrorCode e()
		{
			short num = (short)71499776;
			short num2 = num;
			num = (short)479341379;
			short num3 = num;
			num = (short)1017129795;
			switch (num3 == num)
			{
			}
			num = (short)1365114881;
			if (num != 0)
			{
			}
			num = (short)80936960;
			if (num != 0)
			{
			}
			return this.f;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0001DEE8 File Offset: 0x0001C0E8
		public ae(string A_0, global::Motorola.Common.Communication.CommonUtil.ModelType A_1, string A_2, int A_3)
		{
			this.c = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			try
			{
				this.g = (global::Motorola.Common.Communication.ab)A_3;
				this.d = new global::Motorola.Common.Communication.z(A_0, A_1, A_2);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0001DF40 File Offset: 0x0001C140
		public global::Motorola.Common.Communication.aa b(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.LanguagePackData A_1, out global::Motorola.Common.Communication.Pba.LanguagePackData A_2, out global::Motorola.Common.Communication.Pba.LanguagePackData A_3, bool A_4)
		{
			short num = (short)643891200;
			short num2 = num;
			num = (short)660939809;
			short num3 = num;
			num = (short)1214194721;
			switch (num3 == num)
			{
			}
			num = (short)78970881;
			if (num != 0)
			{
			}
			num = (short)153419776;
			if (num != 0)
			{
			}
			this.a = A_1;
			this.b();
			global::Motorola.Common.Communication.aa result = this.b(A_4, A_0);
			A_2 = this.b;
			A_3 = this.c;
			return result;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0001E010 File Offset: 0x0001C210
		private string d()
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_57;
			}
			short num;
			int num3;
			string text;
			for (;;)
			{
				IL_13:
				num = (short)1266745344;
				short num2 = num;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator;
				switch (num3)
				{
				case 0:
					goto IL_73;
				case 1:
					num = (short)133038084;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1519814346;
					short num4 = num;
					num = (short)978355914;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_73;
					default:
						num = (short)1537146880;
						if (num != 0)
						{
						}
						goto IL_1F9;
					}
					break;
				}
				case 3:
					try
					{
						num = (short)297926656;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_DC;
								}
								continue;
							case 1:
								goto IL_185;
							case 2:
								if (!string.IsNullOrEmpty(text))
								{
									num = (short)1725693953;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 3:
								num = (short)91684869;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								try
								{
									return text.Substring(text.IndexOf(global::Motorola.Common.Communication.Crc32.c("", a_), global::System.StringComparison.Ordinal) + 1, 5);
								}
								catch (global::System.Exception)
								{
									break;
								}
								goto IL_185;
							case 5:
								goto IL_1E6;
							case 6:
								if (!enumerator.MoveNext())
								{
									num = (short)502202371;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								text = ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator.Current).radioFilePath;
								num = (short)1495203842;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								if (text.StartsWith(global::Motorola.Common.Communication.Crc32.c("쾪첬\udbae", a_), global::System.StringComparison.Ordinal))
								{
									num = (short)2068971524;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							IL_123:
							num = (short)785121286;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_DC:
							goto IL_123;
							IL_185:
							num = (short)1341194247;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1E6:
						return text;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1F9;
				case 4:
					if (this.a.LanguagePacks.Count > 0)
					{
						num = (short)448921601;
						if (num != 0)
						{
						}
						num = (short)682164226;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return text;
				}
				goto IL_57;
				IL_73:
				if (this.a != null)
				{
					num = (short)1305739265;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1F9:
				enumerator = this.a.LanguagePacks.GetEnumerator();
				num = (short)202440707;
				num3 = (int)((global::System.IntPtr)num);
			}
			return text;
			IL_57:
			text = "";
			num = (short)1750794240;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0001E338 File Offset: 0x0001C538
		private global::Motorola.Common.Communication.aa b(bool A_0, global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_1)
		{
			int a_ = 13;
			short num = (short)878379008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AF;
				}
				global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.z.a>.Enumerator enumerator;
				bool a_4;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (!A_0)
						{
							num = (short)182386693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63F;
					case 1:
						num = (short)850395149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.Common.Communication.CommonUtil.ConnectionType connectionType;
						if (connectionType.Equals(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap))
						{
							num = (short)1599406086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E7;
					}
					case 3:
						goto IL_2C9;
					case 4:
					{
						if (this.c())
						{
							num = (short)1771044876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag = false;
						num = (short)419364885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						bool flag = true;
						num = (short)1638268946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_323;
					case 7:
					{
						global::Motorola.Common.Communication.CommonUtil.ConnectionType connectionType = A_1.ConnectionInfo.ConnectionType;
						num = (short)112328706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
						if (astroFilePackInfo != null)
						{
							num = (short)1003028495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.Common.Communication.aa.e;
					}
					case 9:
						return global::Motorola.Common.Communication.aa.a;
					case 10:
						if (this.g.Equals(global::Motorola.Common.Communication.ab.c))
						{
							num = (short)1483931673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7FE;
					case 11:
						if (A_1.ConnectionInfo != null)
						{
							num = (short)1891893255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E7;
					case 12:
						goto IL_156;
					case 13:
					{
						num = (short)995819520;
						short num3 = num;
						if (string.Equals(this.d(), this.d.p(), global::System.StringComparison.Ordinal))
						{
							num = (short)1745551374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63F;
					}
					case 14:
						num = (short)1232732160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
						astroFilePackInfo.fileType = global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest;
						num = (short)292880411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num = (short)982450204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_47F;
					case 18:
						goto IL_63F;
					case 19:
					{
						try
						{
							num = (short)542310403;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_46C;
								case 2:
									num = (short)1786380288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_3B8;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)63635458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, global::Motorola.Common.Communication.z.a> keyValuePair = enumerator.Current;
									string a_2 = keyValuePair.Value.a;
									string a_3 = this.d.l();
									this.b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.LanguagePack, keyValuePair.Key, a_2, a_3, keyValuePair.Value.b, this.c);
									num = (short)1135738881;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_419:
								num = (short)788987908;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3B8:
								goto IL_419;
							}
							IL_46C:
							goto IL_1E3;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_10;
						IL_1E3:
						a_4 = false;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2 = this.a.LanguagePacks.GetEnumerator();
						num = (short)1252655121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (!this.d.q())
						{
							num = (short)1794048009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_733;
					case 21:
						if (this.g.Equals(global::Motorola.Common.Communication.ab.b))
						{
							num = (short)63438849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63F;
					case 22:
						if (this.d.k().Equals(global::Motorola.Common.Communication.Crc32.c("쒩쮫슭\ud9af솱\udcb3", a_)))
						{
							num = (short)2026504208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1313472516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						return global::Motorola.Common.Communication.aa.a;
					case 24:
						if (!A_0)
						{
							num = (short)706674691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7FE;
					case 25:
						num = (short)900857880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						bool flag;
						if (flag)
						{
							num = (short)1434451997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_733;
					}
					case 27:
						goto IL_7A5;
					case 28:
					{
						if (this.a.LanguagePacks.Count < 1)
						{
							num = (short)1672216599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.b.LanguagePacks.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.r));
						num = (short)1481768968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						num = (short)708902913;
						if (num != 0)
						{
						}
						num = (short)1157758996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AF;
					Block_10:
					try
					{
						IL_47F:
						num = (short)109510660;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
							switch (num2)
							{
							case 0:
								a_4 = true;
								num = (short)905773062;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								num = (short)1425735683;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (!enumerator2.MoveNext())
								{
									num = (short)394461185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1083899909;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_5D4;
							case 4:
							{
								num = (short)90360442;
								short num4 = num;
								num = (short)729008762;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_524;
								default:
									num = (short)1211170816;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_50D;
									}
									continue;
								}
								break;
							}
							case 5:
								goto IL_524;
							case 6:
								goto IL_578;
							}
							goto IL_50D;
							IL_524:
							if (((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator2.Current).radioFilePath == this.d.o())
							{
								num = (short)2044264448;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_57D:
							num = (short)2037121026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_50D:
							goto IL_57D;
						}
						IL_578:
						IL_5D4:
						goto IL_15B;
					}
					finally
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
						((global::System.IDisposable)enumerator2).Dispose();
					}
					goto IL_5E7;
					IL_15B:
					num = (short)111214603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E7:
					num = (short)419168278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_63F:
					num = (short)1253834778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_733:
					num = (short)293470218;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_156:
				return this.d(a_4);
				IL_2C9:
				return this.d(a_4);
				IL_323:
				this.b(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_LPK_update_is_not_support_via_POP25);
				return global::Motorola.Common.Communication.aa.a;
				IL_7A5:
				return global::Motorola.Common.Communication.aa.e;
				IL_7FE:
				return this.b(a_4);
				IL_AF:
				enumerator = this.d.d.GetEnumerator();
				num = (short)2065956883;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0001EB80 File Offset: 0x0001CD80
		private bool c()
		{
			short num = (short)55133289;
			short num2 = num;
			num = (short)1056851049;
			switch (num2 == num)
			{
			}
			num = (short)973144065;
			if (num != 0)
			{
			}
			num = (short)1366884352;
			if (num != 0)
			{
			}
			num = (short)1674379264;
			short num3 = num;
			return (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.a.LanguagePacks.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.q)) == null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0001EC4C File Offset: 0x0001CE4C
		private global::Motorola.Common.Communication.aa d(bool A_0)
		{
			short num = (short)1339424770;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_15F;
				case 1:
					goto IL_192;
				case 2:
				{
					num = (short)1090650112;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				}
				case 3:
					if (A_0)
					{
						num = (short)2087976961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_111;
				}
				IL_5D:
				long num4 = (long)(this.b(this.c) + global::System.Convert.ToInt32(new global::System.IO.FileInfo(this.d.m()).Length) + this.e);
				int num5 = this.b(this.b);
				if (num4 > (long)((ulong)this.a.AvailableSpace + (ulong)((long)num5)))
				{
					goto IL_1BD;
				}
				num = (short)1123497651;
				short num6 = num;
				num = (short)463746739;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)293535744;
					if (num != 0)
					{
					}
					num = (short)1077870592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_15F:
				num = (short)1947926531;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_111:
			this.b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest, this.d.n(), this.d.m(), 0, this.c, global::Motorola.Common.Communication.aa.d);
			return global::Motorola.Common.Communication.aa.d;
			IL_192:
			num = (short)1167458305;
			if (num != 0)
			{
			}
			this.b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest, this.d.n(), this.d.m(), 0, this.c, global::Motorola.Common.Communication.aa.b);
			return global::Motorola.Common.Communication.aa.f;
			IL_1BD:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Radio_does_not_have_enough_free_space);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0001EE20 File Offset: 0x0001D020
		private global::Motorola.Common.Communication.aa c(bool A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
				switch (num)
				{
				case 0:
					this.b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest, this.d.n(), this.d.m(), 0, this.c, global::Motorola.Common.Communication.aa.d);
					num2 = (short)601489417;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (A_0)
					{
						num2 = (short)2104360963;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.Common.Communication.aa.c;
				case 2:
					return global::Motorola.Common.Communication.aa.f;
				case 3:
					goto IL_2E2;
				case 4:
					if (astroFilePackInfo != null)
					{
						num2 = (short)1823997962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2AC;
				case 5:
					goto IL_2AC;
				case 6:
					goto IL_15C;
				case 7:
				{
					int num4;
					if ((long)num3 <= (long)((ulong)this.a.AvailableSpace + (ulong)((long)num4)))
					{
						num2 = (short)1920401408;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_30F;
				}
				case 8:
				{
					if ((long)num3 <= (long)((ulong)this.a.AvailableSpace))
					{
						num2 = (short)1729626118;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					int num4 = this.b(this.b);
					num2 = (short)1842544647;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
				{
					if (A_0)
					{
						num2 = (short)1546190850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)255541535;
					short num5 = num2;
					num2 = (short)593445151;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15C;
					default:
						goto IL_26A;
					}
					break;
				}
				case 10:
					astroFilePackInfo.fileType = global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest;
					astroFilePackInfo.sourceFilePath = this.d.n();
					astroFilePackInfo.radioFilePath = null;
					astroFilePackInfo.encFileName = this.d.m();
					num2 = (short)1023803397;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3C;
				IL_15C:
				this.b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest, this.d.n(), this.d.m(), 0, this.c, global::Motorola.Common.Communication.aa.c);
				astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.b.LanguagePacks.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.p));
				num2 = (short)1935278084;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2AC:
				num2 = (short)265748481;
				num = (int)((global::System.IntPtr)num2);
			}
			return global::Motorola.Common.Communication.aa.f;
			IL_26A:
			num2 = (short)1567686656;
			if (num2 != 0)
			{
			}
			return global::Motorola.Common.Communication.aa.d;
			IL_2E2:
			num2 = (short)1392836609;
			if (num2 != 0)
			{
			}
			num2 = (short)587005952;
			short num6 = num2;
			return global::Motorola.Common.Communication.aa.f;
			IL_30F:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Radio_does_not_have_enough_free_space);
			IL_3C:
			num3 = this.b(this.c);
			num3 = num3 + global::System.Convert.ToInt32(new global::System.IO.FileInfo(this.d.m()).Length) + this.e;
			num2 = (short)31522824;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0001F148 File Offset: 0x0001D348
		private global::Motorola.Common.Communication.aa b(bool A_0)
		{
			int a_ = 17;
			short num = (short)962461696;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_10F;
				}
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase> list;
				for (;;)
				{
					IL_30:
					int count;
					switch (num2)
					{
					case 0:
						num = (short)1491075121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						try
						{
							num = (short)1304887296;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_890;
									}
									continue;
								case 1:
									this.c.LanguagePacks.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(a2.c));
									num = (short)1516044290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1137967109;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo a = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator.Current;
									num = (short)599982084;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									if (this.b.LanguagePacks.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(a2.b)) > 0)
									{
										num = (short)485163009;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									num = (short)853475334;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_98D;
								}
								IL_934:
								num = (short)1312423939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_890:
								goto IL_934;
							}
							IL_98D:
							goto IL_E07;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_9A0;
						IL_E07:
						global::Motorola.Common.Communication.ad ad = new global::Motorola.Common.Communication.ad();
						ad.a(this.c.LanguagePacks);
						enumerator = this.c.LanguagePacks.GetEnumerator();
						num = (short)889913372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (A_0)
						{
							num = (short)132710407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						count = this.b.LanguagePacks.Count;
						num = (short)648085547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (count.Equals(0))
						{
							num = (short)694419487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list = null;
						list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.c.LanguagePacks);
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase> list2 = null;
						list2 = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.b.LanguagePacks);
						list2.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.i));
						list2.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.h));
						string text = null;
						string text2 = null;
						enumerator = list.GetEnumerator();
						num = (short)2099970081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return global::Motorola.Common.Communication.aa.a;
					case 5:
						return global::Motorola.Common.Communication.aa.a;
					case 6:
						this.c.LanguagePacks = list;
						num = (short)1636499498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_9A0;
					case 8:
						goto IL_667;
					case 9:
						num = (short)794624032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return global::Motorola.Common.Communication.aa.a;
					case 11:
						if (count.Equals(1))
						{
							num = (short)1749483528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2E;
					case 12:
						return global::Motorola.Common.Communication.aa.a;
					case 13:
					{
						num = (short)1109655552;
						short num3 = num;
						if (count.Equals(0))
						{
							num = (short)1823473680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B5;
					}
					case 14:
						return global::Motorola.Common.Communication.aa.a;
					case 15:
						return global::Motorola.Common.Communication.aa.a;
					case 16:
						return global::Motorola.Common.Communication.aa.a;
					case 17:
						if (count.Equals(1))
						{
							num = (short)79888384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1341063216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_1038;
					case 19:
						goto IL_B14;
					case 20:
						this.b.LanguagePacks.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.b));
						num = (short)834273319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						global::Motorola.Common.Communication.ad ad;
						if (!ad.b())
						{
							num = (short)1231355910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9F6;
					}
					case 22:
						if (this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.k)))
						{
							num = (short)1823866932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.Common.Communication.aa.e;
					case 23:
						if (count.Equals(0))
						{
							num = (short)2071068698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F6;
					case 24:
						if (count.Equals(0))
						{
							num = (short)203292684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						count = this.b.LanguagePacks.Count;
						num = (short)1230045201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.l)))
						{
							num = (short)1486684211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.Common.Communication.aa.e;
					case 26:
						count = this.b.LanguagePacks.Count;
						num = (short)1513226286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (A_0)
						{
							num = (short)993001502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						count = this.c.LanguagePacks.Count;
						num = (short)384761890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						try
						{
							num = (short)293208064;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_F77;
									}
									continue;
								case 1:
									goto IL_FEF;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)13828100;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.LanguagePackBase a_2 = enumerator.Current;
									global::Motorola.Common.Communication.ad ad;
									ad.a(a_2);
									num = (short)571080707;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)896663553;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_FA2:
								num = (short)219217922;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F77:
								goto IL_FA2;
							}
							IL_FEF:
							goto IL_EF8;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1002;
						IL_EF8:
						num = (short)687538197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						bool flag = this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.f));
						bool flag2 = this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.e));
						if (flag && flag2)
						{
							num = (short)1750925322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B19;
					}
					case 30:
						count = this.c.LanguagePacks.Count;
						num = (short)597098519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)1653145602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.g)))
						{
							num = (short)432078901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144;
					case 33:
						try
						{
							num = (short)492437506;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)954597378;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											string text;
											global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
											switch (num2)
											{
											case 0:
												if (!enumerator2.MoveNext())
												{
													num = (short)1110704129;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_5E0;
											case 1:
												num = (short)1887830020;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_287;
												}
												continue;
											case 3:
												try
												{
													string text2;
													string text3 = text2.Substring(0, text2.LastIndexOf(global::Motorola.Common.Communication.Crc32.c("", a_), global::System.StringComparison.Ordinal));
													try
													{
														switch (0)
														{
														case 0:
															goto IL_334;
														}
														string text4;
														for (;;)
														{
															IL_2F5:
															switch (num2)
															{
															case 0:
															{
																global::System.Text.RegularExpressions.Match match;
																if (match.Success)
																{
																	num = (short)1168703493;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																goto IL_4A7;
															}
															case 1:
															{
																num = (short)120160767;
																short num4 = num;
																num = (short)1506116095;
																switch ((num4 == num) ? 1 : 0)
																{
																case 0:
																case 2:
																	goto IL_592;
																default:
																{
																	num = (short)749338624;
																	if (num != 0)
																	{
																	}
																	global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.Communication.Crc32.c("蒫풯馱颵\udeb9鞻黁ꃃ", a_));
																	global::System.Text.RegularExpressions.Match match2 = regex.Match(text2);
																	num = (short)1825112073;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																}
																break;
															}
															case 2:
																goto IL_4C1;
															case 3:
																num = (short)525402123;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															case 4:
															{
																global::System.Version version;
																global::System.Version value;
																if (version.CompareTo(value) < 0)
																{
																	num = (short)1371013128;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																goto IL_5B1;
															}
															case 5:
															{
																global::System.Text.RegularExpressions.Match match2;
																global::System.Version version = new global::System.Version(match2.Value);
																global::System.Text.RegularExpressions.Match match;
																global::System.Version value = new global::System.Version(match.Value);
																num = (short)730726410;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 6:
															{
																global::System.Text.RegularExpressions.Regex regex;
																global::System.Text.RegularExpressions.Match match = regex.Match(text);
																num = (short)132513792;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 7:
																if (text3 == text4)
																{
																	num = (short)385417217;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																goto IL_5B1;
															case 8:
																this.c.LanguagePacks.Clear();
																this.b.LanguagePacks.Clear();
																goto IL_592;
															case 9:
															{
																global::System.Text.RegularExpressions.Match match2;
																if (match2.Success)
																{
																	num = (short)1827995654;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																goto IL_3DE;
															}
															case 10:
															{
																global::System.Version version;
																global::System.Version value;
																if (version.CompareTo(value) > 0)
																{
																	num = (short)849674243;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																num = (short)1228144644;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 11:
																goto IL_401;
															case 12:
																goto IL_5CA;
															case 13:
																goto IL_4A7;
															}
															goto IL_334;
															IL_4A7:
															num = (short)1935540226;
															num2 = (int)((global::System.IntPtr)num);
															continue;
															IL_592:
															num = (short)1986854925;
															num2 = (int)((global::System.IntPtr)num);
															continue;
															IL_5B1:
															num = (short)1847132172;
															num2 = (int)((global::System.IntPtr)num);
														}
														IL_3DE:
														throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
														IL_401:
														IL_4C1:
														goto IL_20E;
														IL_5CA:
														break;
														IL_334:
														text4 = text.Substring(0, text.LastIndexOf(global::Motorola.Common.Communication.Crc32.c("", a_), global::System.StringComparison.Ordinal));
														num = (short)1548550151;
														num2 = (int)((global::System.IntPtr)num);
														goto IL_2F5;
													}
													catch
													{
													}
													break;
												}
												catch
												{
													throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
												}
												goto IL_5E0;
											case 4:
												goto IL_628;
											}
											IL_28C:
											num = (short)548012032;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_287:
											goto IL_28C;
											IL_5E0:
											text = ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator2.Current).radioFilePath;
											num = (short)1135411203;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_628:
										break;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_63B;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1750532099;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text2 = ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator.Current).sourceFilePath;
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase> list2;
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2 = list2.GetEnumerator();
									num = (short)1625358336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1D5;
									}
									continue;
								case 3:
									goto IL_63B;
								case 4:
									goto IL_654;
								}
								IL_20E:
								num = (short)1384710145;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D5:
								goto IL_20E;
								IL_63B:
								num = (short)1054932996;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_654:
							goto IL_10B5;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_667;
					case 34:
						if (count.Equals(0))
						{
							num = (short)11337763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F6;
					case 35:
						count = this.b.LanguagePacks.Count;
						num = (short)1600520216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1911947293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)1688404018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (count.Equals(2))
						{
							num = (short)1653145636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B19;
					case 39:
						goto IL_7F1;
					case 40:
						if (count.Equals(1))
						{
							num = (short)793706541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1635647510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (count.Equals(0))
						{
							num = (short)1159921668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F6;
					case 42:
						goto IL_9F6;
					case 43:
						if (count.Equals(0))
						{
							num = (short)2008809487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						count = this.b.LanguagePacks.Count;
						num = (short)1722351656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (count.Equals(2))
						{
							num = (short)1332740133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C1A;
					case 45:
						num = (short)1496449049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (count.Equals(1))
						{
							num = (short)398065673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144;
					case 47:
						if (this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.o)))
						{
							num = (short)1637613582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2E;
					case 48:
						if (this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.c)))
						{
							num = (short)1521352724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.Common.Communication.aa.e;
					case 49:
						if (this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.d)))
						{
							num = (short)193986579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.Common.Communication.aa.e;
					case 50:
					{
						bool flag3 = this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.n));
						bool flag4 = this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.m));
						if (flag3 && flag4)
						{
							num = (short)1845559301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C1A;
					}
					case 51:
						return global::Motorola.Common.Communication.aa.a;
					case 52:
						goto IL_1002;
					case 53:
						return global::Motorola.Common.Communication.aa.a;
					}
					goto IL_10F;
					IL_144:
					count = this.b.LanguagePacks.Count;
					num = (short)310444070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_667:
					num = (short)2143551535;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A0:
					count = this.b.LanguagePacks.Count;
					num = (short)1572601867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F6:
					count = this.c.LanguagePacks.Count;
					num = (short)1071251459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B19:
					count = this.b.LanguagePacks.Count;
					num = (short)1916076073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C1A:
					count = this.b.LanguagePacks.Count;
					num = (short)1818099725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D2E:
					count = this.b.LanguagePacks.Count;
					num = (short)1097531436;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1002:
					this.b.LanguagePacks.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.j));
					num = (short)563281938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10B5:
					num = (short)780861467;
					num2 = (int)((global::System.IntPtr)num);
				}
				return global::Motorola.Common.Communication.aa.a;
				IL_7F1:
				return global::Motorola.Common.Communication.aa.e;
				IL_B14:
				num = (short)1624899585;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.aa.a;
				IL_1038:
				return global::Motorola.Common.Communication.aa.e;
				IL_11F6:
				return this.c(A_0);
				IL_10F:
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.c.LanguagePacks);
				enumerator = list.GetEnumerator();
				num = (short)102891521;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000203E8 File Offset: 0x0001E5E8
		private void b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType A_0, string A_1, string A_2, string A_3, int A_4, global::Motorola.Common.Communication.Pba.LanguagePackData A_5)
		{
			short num = (short)1631059968;
			short num2 = num;
			num = (short)746275941;
			short num3 = num;
			num = (short)803030117;
			switch (num3 == num)
			{
			}
			num = (short)828702721;
			if (num != 0)
			{
			}
			num = (short)604045312;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = new global::Motorola.Common.Communication.Pba.AstroFilePackInfo();
			astroFilePackInfo.fileType = A_0;
			astroFilePackInfo.sourceFilePath = A_2;
			astroFilePackInfo.radioFileSize = A_4;
			astroFilePackInfo.encFileName = A_3;
			astroFilePackInfo.sourceFileId = A_1;
			A_5.LanguagePacks.Add(astroFilePackInfo);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000204CC File Offset: 0x0001E6CC
		private void b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType A_0, string A_1, string A_2, int A_3, global::Motorola.Common.Communication.Pba.LanguagePackData A_4, global::Motorola.Common.Communication.aa A_5)
		{
			short num = (short)122897750;
			short num2 = num;
			num = (short)326452566;
			global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1A2:
				astroFilePackInfo.sourceFilePath = A_1;
				num = (short)1106509828;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1497563136;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_7A;
				}
				break;
			}
			for (;;)
			{
				IL_54:
				switch (num3)
				{
				case 0:
					goto IL_11E;
				case 1:
					astroFilePackInfo.radioFilePath = A_1;
					num = (short)1870135303;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1801060358;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)2133065728;
					short num4 = num;
					if (A_5 == global::Motorola.Common.Communication.aa.c)
					{
						num = (short)1420886017;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)191037441;
					if (num != 0)
					{
					}
					num = (short)260571141;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_1C0;
				case 5:
					if (A_5 != global::Motorola.Common.Communication.aa.d)
					{
						num = (short)24248322;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A2;
				case 6:
					if (A_5 == global::Motorola.Common.Communication.aa.b)
					{
						num = (short)901840896;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C2;
				case 7:
					goto IL_1A0;
				}
				goto IL_7A;
			}
			IL_11E:
			goto IL_1A2;
			IL_1A0:
			IL_1C0:
			IL_1C2:
			astroFilePackInfo.radioFileSize = A_3;
			astroFilePackInfo.encFileName = A_2;
			A_4.LanguagePacks.Add(astroFilePackInfo);
			return;
			IL_7A:
			astroFilePackInfo = new global::Motorola.Common.Communication.Pba.AstroFilePackInfo();
			astroFilePackInfo.fileType = A_0;
			num = (short)899743747;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000206B8 File Offset: 0x0001E8B8
		private int b(global::Motorola.Common.Communication.Pba.LanguagePackData A_0)
		{
			short num = (short)552927232;
			short num2 = num;
			num = (short)1031667713;
			if (num != 0)
			{
			}
			num = (short)1798438962;
			short num3 = num;
			num = (short)1658126386;
			switch (num3 == num)
			{
			}
			num = (short)642973696;
			if (num != 0)
			{
			}
			return A_0.LanguagePacks.Sum(new global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, int>(global::Motorola.Common.Communication.ae.<>c.<>9.a));
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00020790 File Offset: 0x0001E990
		private void b()
		{
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						this.b = this.a;
						num2 = (short)740098049;
						if (num2 != 0)
						{
						}
						num2 = (short)288161794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
					{
						int count;
						if (!count.Equals(0))
						{
							num2 = (short)661979136;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 2:
						return;
					}
					break;
				}
				IL_1C:
				num2 = (short)1258393266;
				short num3 = num2;
				num2 = (short)943427250;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)2118975488;
					if (num2 != 0)
					{
					}
					num2 = (short)813105152;
					short num4 = num2;
					this.b = new global::Motorola.Common.Communication.Pba.LanguagePackData();
					int count = this.a.LanguagePacks.Count;
					num2 = (short)2072576001;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000208D4 File Offset: 0x0001EAD4
		public void f()
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)853540867;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<string> enumerator;
					switch (num2)
					{
					case 0:
					{
						try
						{
							num = (short)686853301;
							short num3 = num;
							num = (short)1614843061;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_2FD:
								num = (short)990576642;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1574109184;
								if (num != 0)
								{
								}
								num = (short)1726087172;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)892928006;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = enumerator.Current;
									num = (short)465895431;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									string text;
									global::System.IO.File.SetAttributes(text, global::System.IO.FileAttributes.Normal);
									global::System.IO.File.Delete(text);
									num = (short)2078736385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_331;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_241;
									}
									continue;
								case 5:
									num = (short)1384710152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1271398403;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									string text;
									if (text != null)
									{
										num = (short)1168769029;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									string text;
									if (global::System.IO.File.Exists(text))
									{
										goto IL_2FD;
									}
									break;
								}
								}
								IL_2A5:
								num = (short)1027932160;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_241:
								goto IL_2A5;
							}
							IL_331:
							goto IL_7A;
						}
						finally
						{
							num = (short)887816193;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)489160706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_368;
									}
									continue;
								case 2:
									goto IL_39B;
								}
								IL_368:
								if (enumerator == null)
								{
									break;
								}
								num = (short)320012288;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39B:;
						}
						goto IL_39E;
						IL_7A:
						string text2 = global::System.IO.Directory.GetFiles(this.d.j(), global::Motorola.Common.Communication.Crc32.c("삫쾭\udeaf햱骳\udbb5횷\udcb9ힻ", a_), global::System.IO.SearchOption.TopDirectoryOnly).FirstOrDefault<string>();
						num = (short)2016018433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						string text2;
						if (text2 != null)
						{
							num = (short)473432070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39E;
					}
					case 2:
					{
						string text2;
						if (global::System.IO.File.Exists(text2))
						{
							num = (short)1772814343;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39E;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_4E;
						}
						continue;
					case 4:
						goto IL_3B5;
					case 5:
						goto IL_39E;
					case 6:
						num = (short)527433730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						string text2;
						global::System.IO.File.SetAttributes(text2, global::System.IO.FileAttributes.Normal);
						global::System.IO.File.Delete(text2);
						num = (short)539688965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_4E:
					enumerator = global::System.IO.Directory.EnumerateFiles(this.d.j(), global::Motorola.Common.Communication.Crc32.c("蚫肭\udcaf슱\udfb3", a_), global::System.IO.SearchOption.TopDirectoryOnly).Select(new global::System.Func<string, string>(global::Motorola.Common.Communication.ae.<>c.<>9.a)).GetEnumerator();
					num = (short)824836097;
					if (num != 0)
					{
					}
					num = (short)167510016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39E:
					num = (short)1795096580;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3B5:;
			}
			catch (global::System.Exception)
			{
			}
			num = (short)2121203712;
			short num4 = num;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00020CFC File Offset: 0x0001EEFC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool r(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)2128348275;
			short num2 = num;
			num = (short)707265651;
			switch (num2 == num)
			{
			}
			num = (short)247857152;
			if (num != 0)
			{
			}
			num = (short)981663744;
			short num3 = num;
			num = (short)1841233921;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool q(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1031340033;
			if (num != 0)
			{
			}
			num = (short)1986452623;
			short num2 = num;
			num = (short)1052499087;
			switch (num2 == num)
			{
			}
			num = (short)1080950784;
			short num3 = num;
			num = (short)72548352;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00020E84 File Offset: 0x0001F084
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool p(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1854734337;
			if (num != 0)
			{
			}
			num = (short)1715078119;
			short num2 = num;
			num = (short)1376846823;
			switch (num2 == num)
			{
			}
			num = (short)2010906624;
			short num3 = num;
			num = (short)671547392;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00020F44 File Offset: 0x0001F144
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool o(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)564574058;
			short num2 = num;
			num = (short)574928746;
			switch (num2 == num)
			{
			}
			num = (short)1273298944;
			if (num != 0)
			{
			}
			num = (short)784990208;
			short num3 = num;
			num = (short)382009345;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.o();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0002100C File Offset: 0x0001F20C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool n(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)989443049;
			short num2 = num;
			num = (short)1546105833;
			switch (num2 == num)
			{
			}
			num = (short)1048248321;
			if (num != 0)
			{
			}
			num = (short)135004160;
			short num3 = num;
			num = (short)1847132160;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000210D0 File Offset: 0x0001F2D0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool m(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1182163165;
			short num2 = num;
			num = (short)1058365661;
			switch (num2 == num)
			{
			}
			num = (short)1430323200;
			if (num != 0)
			{
			}
			num = (short)1137967104;
			short num3 = num;
			num = (short)797507585;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.o();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00021194 File Offset: 0x0001F394
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool l(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1390855209;
			short num2 = num;
			num = (short)348242985;
			switch (num2 == num)
			{
			}
			num = (short)885587969;
			if (num != 0)
			{
			}
			num = (short)1954152448;
			short num3 = num;
			num = (short)2008023040;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00021258 File Offset: 0x0001F458
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)674134650;
			short num2 = num;
			num = (short)873560698;
			switch (num2 == num)
			{
			}
			num = (short)1979711489;
			if (num != 0)
			{
			}
			num = (short)607191040;
			short num3 = num;
			num = (short)174981120;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0002131C File Offset: 0x0001F51C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool j(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1050196005;
			short num2 = num;
			num = (short)652589093;
			switch (num2 == num)
			{
			}
			num = (short)1435172864;
			if (num != 0)
			{
			}
			num = (short)1998192640;
			short num3 = num;
			num = (short)649068545;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000213E4 File Offset: 0x0001F5E4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool i(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)813296100;
			short num2 = num;
			num = (short)77130212;
			switch (num2 == num)
			{
			}
			num = (short)218693633;
			if (num != 0)
			{
			}
			num = (short)1566638080;
			short num3 = num;
			num = (short)2001731584;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000214A8 File Offset: 0x0001F6A8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool h(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1742023440;
			short num2 = num;
			num = (short)407251728;
			switch (num2 == num)
			{
			}
			num = (short)493748225;
			if (num != 0)
			{
			}
			num = (short)1188233216;
			short num3 = num;
			num = (short)185466880;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.o();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0002156C File Offset: 0x0001F76C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool g(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1620510407;
			short num2 = num;
			num = (short)1692010183;
			switch (num2 == num)
			{
			}
			num = (short)2099576832;
			if (num != 0)
			{
			}
			num = (short)2017656832;
			short num3 = num;
			num = (short)551944193;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.o();
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00021630 File Offset: 0x0001F830
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool f(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)16406584;
			short num2 = num;
			num = (short)1854298168;
			switch (num2 == num)
			{
			}
			num = (short)854917120;
			if (num != 0)
			{
			}
			num = (short)67239936;
			short num3 = num;
			num = (short)2034565121;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000216F8 File Offset: 0x0001F8F8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool e(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1209534251;
			short num2 = num;
			num = (short)1792214827;
			switch (num2 == num)
			{
			}
			num = (short)2061762560;
			if (num != 0)
			{
			}
			num = (short)732626944;
			short num3 = num;
			num = (short)81788929;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.o();
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000217BC File Offset: 0x0001F9BC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)477783293;
			short num2 = num;
			num = (short)1813406973;
			switch (num2 == num)
			{
			}
			num = (short)332201985;
			if (num != 0)
			{
			}
			num = (short)1538457600;
			short num3 = num;
			num = (short)98566144;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00021880 File Offset: 0x0001FA80
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)254401747;
			short num2 = num;
			num = (short)2143083731;
			switch (num2 == num)
			{
			}
			num = (short)2138767360;
			if (num != 0)
			{
			}
			num = (short)481558528;
			short num3 = num;
			num = (short)2116419585;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00021948 File Offset: 0x0001FB48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)318738350;
			short num2 = num;
			num = (short)1516539822;
			switch (num2 == num)
			{
			}
			num = (short)1236533248;
			if (num != 0)
			{
			}
			num = (short)2077491200;
			short num3 = num;
			num = (short)1093599233;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x040000BC RID: 188
		private global::Motorola.Common.Communication.Pba.LanguagePackData a;

		// Token: 0x040000BD RID: 189
		private global::Motorola.Common.Communication.Pba.LanguagePackData b;

		// Token: 0x040000BE RID: 190
		private global::Motorola.Common.Communication.Pba.LanguagePackData c;

		// Token: 0x040000BF RID: 191
		private global::Motorola.Common.Communication.z d;

		// Token: 0x040000C0 RID: 192
		private int e = 512000;

		// Token: 0x040000C1 RID: 193
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.CustomException.CommonErrorCode f;

		// Token: 0x040000C2 RID: 194
		private global::Motorola.Common.Communication.ab g;

		// Token: 0x02000020 RID: 32
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600011A RID: 282 RVA: 0x00021A20 File Offset: 0x0001FC20
			internal bool b(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
			{
				short num = (short)897897562;
				short num2 = num;
				num = (short)254923866;
				switch (num2 == num)
				{
				}
				num = (short)286195712;
				if (num != 0)
				{
				}
				num = (short)1553727488;
				short num3 = num;
				num = (short)863043585;
				if (num != 0)
				{
				}
				return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.a.sourceFilePath;
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00021AE0 File Offset: 0x0001FCE0
			internal bool c(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
			{
				short num = (short)1461045437;
				short num2 = num;
				num = (short)324585661;
				switch (num2 == num)
				{
				}
				num = (short)1688141825;
				if (num != 0)
				{
				}
				num = (short)1035534336;
				short num3 = num;
				num = (short)648347648;
				if (num != 0)
				{
				}
				return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).sourceFilePath == this.a.sourceFilePath;
			}

			// Token: 0x040000C3 RID: 195
			public global::Motorola.Common.Communication.Pba.AstroFilePackInfo a;
		}
	}
}
