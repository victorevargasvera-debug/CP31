using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000027 RID: 39
	internal sealed class l
	{
		// Token: 0x06000118 RID: 280 RVA: 0x0001F684 File Offset: 0x0001D884
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(global::Motorola.Common.CustomException.CommonErrorCode A_0)
		{
			short num = (short)1213857793;
			if (num != 0)
			{
			}
			num = (short)756875264;
			short num2 = num;
			num = (short)985716790;
			short num3 = num;
			num = (short)662362166;
			switch (num3 == num)
			{
			}
			num = (short)1416691712;
			if (num != 0)
			{
			}
			this.f = A_0;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0001F734 File Offset: 0x0001D934
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public global::Motorola.Common.CustomException.CommonErrorCode e()
		{
			short num = (short)884080641;
			if (num != 0)
			{
			}
			num = (short)1577451520;
			short num2 = num;
			num = (short)1497349484;
			short num3 = num;
			num = (short)775011692;
			switch (num3 == num)
			{
			}
			num = (short)1916338176;
			if (num != 0)
			{
			}
			return this.f;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0001F7E4 File Offset: 0x0001D9E4
		public l(string A_0, global::Motorola.Common.Communication.CommonUtil.ModelType A_1, string A_2, int A_3)
		{
			this.c = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			try
			{
				this.g = (global::Motorola.Common.Communication.i)A_3;
				this.d = new global::Motorola.Common.Communication.g(A_0, A_1, A_2);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0001F83C File Offset: 0x0001DA3C
		public global::Motorola.Common.Communication.h b(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.LanguagePackData A_1, out global::Motorola.Common.Communication.Pba.LanguagePackData A_2, out global::Motorola.Common.Communication.Pba.LanguagePackData A_3, bool A_4)
		{
			short num = (short)1645266262;
			short num2 = num;
			num = (short)236045654;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1865285632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)513277953;
			if (num != 0)
			{
			}
			num = (short)552730624;
			if (num != 0)
			{
			}
			this.a = A_1;
			this.b();
			global::Motorola.Common.Communication.h result = this.b(A_4, A_0);
			A_2 = this.b;
			A_3 = this.c;
			return result;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0001F90C File Offset: 0x0001DB0C
		private string d()
		{
			int a_ = 9;
			int num;
			short num2;
			string text;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator;
					switch (num)
					{
					case 0:
						num2 = (short)1834876932;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						try
						{
							num2 = (short)444858369;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num2 = (short)643039235;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									text = ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator.Current).radioFilePath;
									num2 = (short)2124808198;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_DA;
									}
									continue;
								case 2:
									if (text.StartsWith(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鷸髺觼ꃾ", a_), global::System.StringComparison.Ordinal))
									{
										num2 = (short)458752007;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								case 3:
									num2 = (short)1000210437;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 4:
									goto IL_1B1;
								case 5:
									goto IL_213;
								case 6:
									num2 = (short)184287233;
									if (num2 != 0)
									{
									}
									if (!string.IsNullOrEmpty(text))
									{
										num2 = (short)1527513092;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									break;
								case 7:
									try
									{
										return text.Substring(text.IndexOf(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꛸", a_), global::System.StringComparison.Ordinal) + 1, 5);
									}
									catch (global::System.Exception)
									{
										break;
									}
									goto IL_1B1;
								}
								IL_14C:
								num2 = (short)758906880;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_DA:
								goto IL_14C;
								IL_1B1:
								num2 = (short)1983119362;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_213:
							return text;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_226;
					case 2:
						goto IL_226;
					case 3:
						if (this.a != null)
						{
							num2 = (short)982188032;
							short num3 = num2;
							num2 = (short)1486487552;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return text;
					case 4:
					{
						if (this.a.LanguagePacks.Count <= 0)
						{
							return text;
						}
						num2 = (short)160292899;
						short num4 = num2;
						num2 = (short)1258741795;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_33;
						default:
							num2 = (short)148504576;
							if (num2 != 0)
							{
							}
							num2 = (short)1883701250;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					goto IL_2D;
					IL_226:
					enumerator = this.a.LanguagePacks.GetEnumerator();
					num2 = (short)1495859201;
					num = (int)((global::System.IntPtr)num2);
				}
				return text;
			}
			IL_2D:
			text = "";
			IL_33:
			num2 = (short)1410400259;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001FC38 File Offset: 0x0001DE38
		private global::Motorola.Common.Communication.h b(bool A_0, global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_1)
		{
			int a_ = 1;
			short num = (short)1329201152;
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
				global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.g.a>.Enumerator enumerator;
				bool a_4;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_47E;
					case 1:
						num = (short)1589706770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)125239306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)572653587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.Common.Communication.CommonUtil.ConnectionType connectionType;
						if (connectionType.Equals(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap))
						{
							num = (short)269156377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EB;
					}
					case 5:
						goto IL_645;
					case 6:
						if (this.g.Equals(global::Motorola.Common.Communication.i.c))
						{
							num = (short)1651769359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_809;
					case 7:
					{
						bool flag;
						if (flag)
						{
							num = (short)807534600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_740;
					}
					case 8:
						num = (short)1338703886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return global::Motorola.Common.Communication.h.a;
					case 10:
						if (string.Equals(this.d(), this.d.p(), global::System.StringComparison.Ordinal))
						{
							num = (short)1009909761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_645;
					case 11:
						goto IL_375;
					case 12:
						goto IL_7B1;
					case 13:
						if (this.d.k().Equals(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("듰鷲鋴鯶郸裺闼", a_)))
						{
							num = (short)552009731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1993605136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (!this.d.q())
						{
							num = (short)665976841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_740;
					case 15:
						num = (short)702349336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						num = (short)750845953;
						if (num != 0)
						{
						}
						if (this.c())
						{
							num = (short)1491337244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag = false;
						num = (short)518651924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::Motorola.Common.Communication.CommonUtil.ConnectionType connectionType = A_1.ConnectionInfo.ConnectionType;
						num = (short)244252676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (!A_0)
						{
							num = (short)1261764629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_645;
					case 19:
					{
						if (this.a.LanguagePacks.Count < 1)
						{
							num = (short)1469972491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.b.LanguagePacks.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.r));
						num = (short)1750007837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (this.g.Equals(global::Motorola.Common.Communication.i.b))
						{
							num = (short)1435697154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_645;
					case 21:
					{
						bool flag = true;
						num = (short)1189871621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
						astroFilePackInfo.fileType = global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest;
						num = (short)78249996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						try
						{
							num = (short)1318387715;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)303104004;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, global::Motorola.Common.Communication.g.a> keyValuePair = enumerator.Current;
									string a_2 = keyValuePair.Value.a;
									string a_3 = this.d.l();
									this.b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.LanguagePack, keyValuePair.Key, a_2, a_3, keyValuePair.Value.b, this.c);
									num = (short)2052653056;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_46B;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_3B5;
									}
									continue;
								case 4:
									num = (short)1083506690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_415:
								num = (short)405405697;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3B5:
								goto IL_415;
							}
							IL_46B:
							goto IL_20A;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_10;
						IL_20A:
						a_4 = false;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2 = this.a.LanguagePacks.GetEnumerator();
						num = (short)209059840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (!A_0)
						{
							num = (short)1382809626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_809;
					case 25:
						goto IL_31F;
					case 26:
						goto IL_2C4;
					case 27:
						if (A_1.ConnectionInfo != null)
						{
							num = (short)680329233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EB;
					case 28:
						goto IL_17F;
					case 29:
					{
						global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
						if (astroFilePackInfo != null)
						{
							num = (short)732233750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.Common.Communication.h.e;
					}
					}
					goto IL_AF;
					Block_10:
					try
					{
						IL_47E:
						num = (short)369033217;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
								if (!enumerator2.MoveNext())
								{
									num = (short)1625358341;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)763035654;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_4C0;
								}
								continue;
							case 2:
							{
								a_4 = true;
								num = (short)255807409;
								short num3 = num;
								num = (short)1687703473;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_500;
								default:
									num = (short)1996226560;
									if (num != 0)
									{
									}
									num = (short)94306307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_57D;
							case 4:
								goto IL_5D8;
							case 5:
								num = (short)2048851972;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
								if (((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator2.Current).radioFilePath == this.d.o())
								{
									goto IL_500;
								}
								break;
							}
							}
							goto IL_4C0;
							IL_500:
							num = (short)476643330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_582:
							num = (short)1874460672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_4C0:
							goto IL_582;
						}
						IL_57D:
						IL_5D8:
						goto IL_184;
					}
					finally
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
						((global::System.IDisposable)enumerator2).Dispose();
					}
					goto IL_5EB;
					IL_184:
					num = (short)1757806619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5EB:
					num = (short)138543117;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_645:
					num = (short)621674503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_740:
					num = (short)633012230;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17F:
				return this.d(a_4);
				IL_2C4:
				return this.d(a_4);
				IL_31F:
				this.b(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_LPK_update_is_not_support_via_POP25);
				return global::Motorola.Common.Communication.h.a;
				IL_375:
				num = (short)1219821568;
				short num4 = num;
				return global::Motorola.Common.Communication.h.a;
				IL_7B1:
				return global::Motorola.Common.Communication.h.e;
				IL_809:
				return this.b(a_4);
				IL_AF:
				enumerator = this.d.d.GetEnumerator();
				num = (short)164560919;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0002048C File Offset: 0x0001E68C
		private bool c()
		{
			short num = (short)1879024675;
			short num2 = num;
			num = (short)2092803107;
			switch (num2 == num)
			{
			}
			num = (short)1343422465;
			if (num != 0)
			{
			}
			num = (short)670564352;
			if (num != 0)
			{
			}
			num = (short)153223168;
			short num3 = num;
			return (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.a.LanguagePacks.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.q)) == null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00020558 File Offset: 0x0001E758
		private global::Motorola.Common.Communication.h d(bool A_0)
		{
			short num = (short)1804009475;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1173930328;
					short num3 = num;
					num = (short)1886372184;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)2117468160;
						if (num != 0)
						{
						}
						num = (short)1975123970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_1B9;
				case 2:
					num = (short)475856897;
					if (num != 0)
					{
					}
					if (A_0)
					{
						num = (short)593952769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E5;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				long num4 = (long)(this.b(this.c) + global::System.Convert.ToInt32(new global::System.IO.FileInfo(this.d.m()).Length) + this.e);
				int num5 = this.b(this.b);
				if (num4 > (long)((ulong)this.a.AvailableSpace + (ulong)((long)num5)))
				{
					goto IL_1BE;
				}
				num = (short)1622016000;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E5:
			num = (short)896204800;
			short num6 = num;
			this.b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest, this.d.n(), this.d.m(), 0, this.c, global::Motorola.Common.Communication.h.d);
			return global::Motorola.Common.Communication.h.d;
			IL_1B9:
			this.b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest, this.d.n(), this.d.m(), 0, this.c, global::Motorola.Common.Communication.h.b);
			return global::Motorola.Common.Communication.h.f;
			IL_1BE:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Radio_does_not_have_enough_free_space);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00020730 File Offset: 0x0001E930
		private global::Motorola.Common.Communication.h c(bool A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return global::Motorola.Common.Communication.h.f;
				case 1:
					if (A_0)
					{
						num2 = (short)1834418176;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.Common.Communication.h.c;
				case 2:
					goto IL_2D5;
				case 3:
				{
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
					astroFilePackInfo.fileType = global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest;
					astroFilePackInfo.sourceFilePath = this.d.n();
					astroFilePackInfo.radioFilePath = null;
					astroFilePackInfo.encFileName = this.d.m();
					num2 = (short)896794624;
					short num3 = num2;
					num2 = (short)609550338;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					if ((long)num4 <= (long)((ulong)this.a.AvailableSpace))
					{
						num2 = (short)1950154762;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					int num5 = this.b(this.b);
					num2 = (short)1337589767;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (A_0)
					{
						num2 = (short)1676148744;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2AB;
				case 6:
				{
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
					while (astroFilePackInfo != null)
					{
						num2 = (short)1455711545;
						short num6 = num2;
						num2 = (short)1297179961;
						switch ((num6 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)98697216;
							if (num2 != 0)
							{
							}
							num2 = (short)1314193411;
							num = (int)((global::System.IntPtr)num2);
							goto IL_0A;
						}
					}
					goto IL_2D5;
				}
				case 7:
				{
					int num5;
					if ((long)num4 <= (long)((ulong)this.a.AvailableSpace + (ulong)((long)num5)))
					{
						num2 = (short)1032323081;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_30B;
				}
				case 8:
					return global::Motorola.Common.Communication.h.f;
				case 9:
					this.b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest, this.d.n(), this.d.m(), 0, this.c, global::Motorola.Common.Communication.h.d);
					num2 = (short)88014853;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					this.b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType.Manifest, this.d.n(), this.d.m(), 0, this.c, global::Motorola.Common.Communication.h.c);
					global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)this.b.LanguagePacks.Find(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.p));
					num2 = (short)1814036486;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_3C;
				IL_2D5:
				num2 = (short)1973944321;
				num = (int)((global::System.IntPtr)num2);
			}
			return global::Motorola.Common.Communication.h.f;
			IL_2AB:
			num2 = (short)1478754305;
			if (num2 != 0)
			{
			}
			return global::Motorola.Common.Communication.h.d;
			IL_30B:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_Radio_does_not_have_enough_free_space);
			IL_3C:
			num4 = this.b(this.c);
			num4 = num4 + global::System.Convert.ToInt32(new global::System.IO.FileInfo(this.d.m()).Length) + this.e;
			num2 = (short)1390084100;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00020A54 File Offset: 0x0001EC54
		private global::Motorola.Common.Communication.h b(bool A_0)
		{
			int a_ = 11;
			short num = (short)139395072;
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
					{
						bool flag = this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.n));
						bool flag2 = this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.m));
						if (flag && flag2)
						{
							num = (short)2125463603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BEB;
					}
					case 1:
						return global::Motorola.Common.Communication.h.a;
					case 2:
						if (count.Equals(0))
						{
							num = (short)413204494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						count = this.b.LanguagePacks.Count;
						num = (short)214237232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (count.Equals(1))
						{
							num = (short)1332084763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144;
					case 4:
						return global::Motorola.Common.Communication.h.a;
					case 5:
						if (count.Equals(0))
						{
							num = (short)541130789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F5;
					case 6:
						goto IL_7C5;
					case 7:
						try
						{
							num = (short)533069825;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)624885764;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F1F;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)794099712;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.LanguagePackBase a_2 = enumerator.Current;
									global::Motorola.Common.Communication.k k;
									k.a(a_2);
									num = (short)527826947;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_F9A;
								}
								IL_F49:
								num = (short)1946222594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F1F:
								goto IL_F49;
							}
							IL_F9A:
							goto IL_EA1;
						}
						finally
						{
							num = (short)1695154177;
							if (num != 0)
							{
							}
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_FD5;
						IL_EA1:
						num = (short)753336369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						return global::Motorola.Common.Communication.h.a;
					case 9:
						if (A_0)
						{
							num = (short)335282198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						count = this.b.LanguagePacks.Count;
						num = (short)1911685122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.l)))
						{
							num = (short)787021843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.Common.Communication.h.e;
					case 11:
						num = (short)461373440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (count.Equals(0))
						{
							num = (short)1710358568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F5;
					case 13:
					{
						num = (short)1956118528;
						short num3 = num;
						bool flag3 = this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.f));
						bool flag4 = this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.e));
						if (flag3 && flag4)
						{
							num = (short)1987903540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE9;
					}
					case 14:
						return global::Motorola.Common.Communication.h.a;
					case 15:
					{
						try
						{
							num = (short)338165763;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									this.c.LanguagePacks.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(a2.c));
									num = (short)958595072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)206569478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_862;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)938082306;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.Pba.AstroFilePackInfo a = (global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator.Current;
									num = (short)1031602181;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									if (this.b.LanguagePacks.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(a2.b)) > 0)
									{
										num = (short)256245761;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									goto IL_95A;
								}
								IL_904:
								num = (short)731709444;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_862:
								goto IL_904;
							}
							IL_95A:
							goto IL_DAF;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_96D;
						IL_DAF:
						global::Motorola.Common.Communication.k k = new global::Motorola.Common.Communication.k();
						k.a(this.c.LanguagePacks);
						enumerator = this.c.LanguagePacks.GetEnumerator();
						num = (short)1425604615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						this.b.LanguagePacks.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.b));
						num = (short)1944846342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)521994253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						if (count.Equals(0))
						{
							num = (short)72810525;
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
						num = (short)432209955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						return global::Motorola.Common.Communication.h.a;
					case 20:
						return global::Motorola.Common.Communication.h.a;
					case 21:
						count = this.c.LanguagePacks.Count;
						num = (short)901447706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_96D;
					case 23:
						if (this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.g)))
						{
							num = (short)2081030152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_144;
					case 24:
						if (this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.c)))
						{
							num = (short)716111888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.Common.Communication.h.e;
					case 25:
						this.c.LanguagePacks = list;
						num = (short)817168437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (count.Equals(0))
						{
							num = (short)1463156779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F5;
					case 27:
						num = (short)1552810007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.k)))
						{
							num = (short)555089951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.Common.Communication.h.e;
					case 29:
						num = (short)746061833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_100B;
					case 31:
						goto IL_FD5;
					case 32:
						if (count.Equals(1))
						{
							num = (short)1940979759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1501233176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (count.Equals(2))
						{
							num = (short)1405026315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BEB;
					case 34:
						return global::Motorola.Common.Communication.h.a;
					case 35:
						try
						{
							num = (short)625344513;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_63A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1D3;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)149356544;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text2 = ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator.Current).sourceFilePath;
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase> list2;
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2 = list2.GetEnumerator();
									num = (short)1621426179;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									try
									{
										num = (short)276758529;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											string text;
											global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
											switch (num2)
											{
											case 0:
												try
												{
													num = (short)1002123268;
													short num4 = num;
													num = (short)1308962820;
													switch ((num4 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														break;
													default:
													{
														num = (short)975831040;
														if (num != 0)
														{
														}
														string text2;
														string text3 = text2.Substring(0, text2.LastIndexOf(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꓺ", a_), global::System.StringComparison.Ordinal));
														try
														{
															switch (0)
															{
															case 0:
																goto IL_37B;
															}
															string text4;
															for (;;)
															{
																IL_33C:
																switch (num2)
																{
																case 0:
																	num = (short)1910046723;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																case 1:
																{
																	global::System.Text.RegularExpressions.Regex regex;
																	global::System.Text.RegularExpressions.Match match = regex.Match(text);
																	num = (short)199557125;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																case 2:
																	this.c.LanguagePacks.Clear();
																	this.b.LanguagePacks.Clear();
																	num = (short)1970143236;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																case 3:
																	goto IL_400;
																case 4:
																	goto IL_4A4;
																case 5:
																{
																	global::System.Text.RegularExpressions.Match match;
																	if (match.Success)
																	{
																		num = (short)498860040;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	goto IL_4A4;
																}
																case 6:
																	if (text3 == text4)
																	{
																		num = (short)2132344842;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	goto IL_5AF;
																case 7:
																	goto IL_4BE;
																case 8:
																{
																	global::System.Text.RegularExpressions.Match match2;
																	global::System.Version version = new global::System.Version(match2.Value);
																	global::System.Text.RegularExpressions.Match match;
																	global::System.Version value = new global::System.Version(match.Value);
																	num = (short)1513291788;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																case 9:
																{
																	global::System.Version version;
																	global::System.Version value;
																	if (version.CompareTo(value) < 0)
																	{
																		num = (short)488701954;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	goto IL_5AF;
																}
																case 10:
																{
																	global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("폺ꇼ鯾⨀异⬄嬆洈\u200a儌ℎ䴐眒㸔㸖", a_));
																	global::System.Text.RegularExpressions.Match match2 = regex.Match(text2);
																	num = (short)1064435723;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																case 11:
																{
																	global::System.Text.RegularExpressions.Match match2;
																	if (match2.Success)
																	{
																		num = (short)596246529;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	goto IL_3DC;
																}
																case 12:
																{
																	global::System.Version version;
																	global::System.Version value;
																	if (version.CompareTo(value) > 0)
																	{
																		num = (short)559546368;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	num = (short)1669136393;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																}
																case 13:
																	goto IL_5C8;
																}
																goto IL_37B;
																IL_4A4:
																num = (short)892076039;
																num2 = (int)((global::System.IntPtr)num);
																continue;
																IL_5AF:
																num = (short)1983447053;
																num2 = (int)((global::System.IntPtr)num);
															}
															IL_3DC:
															throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
															IL_400:
															IL_4BE:
															goto IL_20B;
															IL_5C8:
															break;
															IL_37B:
															text4 = text.Substring(0, text.LastIndexOf(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꓺ", a_), global::System.StringComparison.Ordinal));
															num = (short)1964572678;
															num2 = (int)((global::System.IntPtr)num);
															goto IL_33C;
														}
														catch
														{
														}
														break;
													}
													}
													break;
												}
												catch
												{
													throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.LanguagePack_Astro_One_or_more_files_in_the_RadioLanguagePacks_is_missing);
												}
												goto IL_5DE;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_285;
												}
												continue;
											case 2:
												num = (short)1763966980;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												if (!enumerator2.MoveNext())
												{
													num = (short)356909058;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_5DE;
											case 4:
												goto IL_627;
											}
											IL_28A:
											num = (short)929366019;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_285:
											goto IL_28A;
											IL_5DE:
											text = ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)enumerator2.Current).radioFilePath;
											num = (short)443416576;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_627:
										break;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_63A;
								case 4:
									goto IL_653;
								}
								IL_20B:
								num = (short)886112258;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D3:
								goto IL_20B;
								IL_63A:
								num = (short)2111307780;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_653:
							goto IL_10B0;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_666;
					case 36:
						if (count.Equals(1))
						{
							num = (short)971112489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CD5;
					case 37:
						count = this.b.LanguagePacks.Count;
						num = (short)1105592364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.d)))
						{
							num = (short)2140471316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::Motorola.Common.Communication.h.e;
					case 39:
						if (count.Equals(2))
						{
							num = (short)1125515281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE9;
					case 40:
						return global::Motorola.Common.Communication.h.a;
					case 41:
						goto IL_666;
					case 42:
						num = (short)1014169610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						count = this.b.LanguagePacks.Count;
						num = (short)864288771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (count.Equals(0))
						{
							num = (short)191102980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						count = this.b.LanguagePacks.Count;
						num = (short)894042144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (this.a.LanguagePacks.Exists(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.o)))
						{
							num = (short)1373896738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CD5;
					case 46:
						if (count.Equals(0))
						{
							num = (short)1177485313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B0;
					case 47:
						num = (short)583598118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (count.Equals(1))
						{
							num = (short)1124335658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2129461276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						global::Motorola.Common.Communication.k k;
						if (!k.b())
						{
							num = (short)79888409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C1;
					}
					case 50:
						if (A_0)
						{
							num = (short)2686997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						count = this.c.LanguagePacks.Count;
						num = (short)2109472773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						return global::Motorola.Common.Communication.h.a;
					case 52:
						return global::Motorola.Common.Communication.h.a;
					case 53:
						goto IL_9C1;
					}
					goto IL_10F;
					IL_144:
					count = this.b.LanguagePacks.Count;
					num = (short)8192039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_666:
					num = (short)1545863213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_96D:
					count = this.b.LanguagePacks.Count;
					num = (short)860225572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9C1:
					count = this.c.LanguagePacks.Count;
					num = (short)2069692434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AE9:
					count = this.b.LanguagePacks.Count;
					num = (short)1021444108;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BEB:
					count = this.b.LanguagePacks.Count;
					num = (short)394657838;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CD5:
					count = this.b.LanguagePacks.Count;
					num = (short)402391073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FD5:
					this.b.LanguagePacks.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.j));
					num = (short)1992753182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10B0:
					num = (short)681967666;
					num2 = (int)((global::System.IntPtr)num);
				}
				return global::Motorola.Common.Communication.h.a;
				IL_7C5:
				return global::Motorola.Common.Communication.h.e;
				IL_100B:
				return global::Motorola.Common.Communication.h.e;
				IL_11F5:
				return this.c(A_0);
				IL_10F:
				list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.LanguagePackBase>(this.c.LanguagePacks);
				enumerator = list.GetEnumerator();
				num = (short)243859471;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00021CF4 File Offset: 0x0001FEF4
		private void b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType A_0, string A_1, string A_2, string A_3, int A_4, global::Motorola.Common.Communication.Pba.LanguagePackData A_5)
		{
			short num = (short)9838558;
			short num2 = num;
			num = (short)1358962654;
			switch (num2 == num)
			{
			}
			num = (short)1242955776;
			short num3 = num;
			num = (short)882245632;
			if (num != 0)
			{
			}
			num = (short)807403521;
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

		// Token: 0x06000123 RID: 291 RVA: 0x00021DD4 File Offset: 0x0001FFD4
		private void b(global::Motorola.Common.Communication.Pba.AstroFilePackInfo.LanguagePackType A_0, string A_1, string A_2, int A_3, global::Motorola.Common.Communication.Pba.LanguagePackData A_4, global::Motorola.Common.Communication.h A_5)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.Pba.AstroFilePackInfo astroFilePackInfo;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)738066433;
					if (num2 != 0)
					{
					}
					if (A_5 != global::Motorola.Common.Communication.h.d)
					{
						num2 = (short)1460338689;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19F;
				case 1:
					num2 = (short)1897988103;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1405110830;
					short num3 = num2;
					num2 = (short)1730562606;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_51;
					default:
						num2 = (short)1080688640;
						if (num2 != 0)
						{
						}
						astroFilePackInfo.radioFilePath = A_1;
						num2 = (short)182583302;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
				{
					num2 = (short)1289551872;
					short num4 = num2;
					goto IL_19F;
				}
				case 4:
					goto IL_1BE;
				case 5:
					goto IL_51;
				case 6:
					goto IL_19D;
				case 7:
					if (A_5 == global::Motorola.Common.Communication.h.b)
					{
						num2 = (short)841023491;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C0;
				}
				goto IL_30;
				IL_51:
				if (A_5 == global::Motorola.Common.Communication.h.c)
				{
					num2 = (short)1323827202;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				num2 = (short)47185920;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_19F:
				astroFilePackInfo.sourceFilePath = A_1;
				num2 = (short)1468530692;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_19D:
			IL_1BE:
			IL_1C0:
			astroFilePackInfo.radioFileSize = A_3;
			astroFilePackInfo.encFileName = A_2;
			A_4.LanguagePacks.Add(astroFilePackInfo);
			return;
			IL_30:
			astroFilePackInfo = new global::Motorola.Common.Communication.Pba.AstroFilePackInfo();
			astroFilePackInfo.fileType = A_0;
			num2 = (short)1123876869;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00021FC0 File Offset: 0x000201C0
		private int b(global::Motorola.Common.Communication.Pba.LanguagePackData A_0)
		{
			short num = (short)1149571558;
			short num2 = num;
			num = (short)2146701798;
			switch (num2 == num)
			{
			}
			num = (short)1962672128;
			short num3 = num;
			num = (short)775618561;
			if (num != 0)
			{
			}
			num = (short)1491599360;
			if (num != 0)
			{
			}
			return A_0.LanguagePacks.Sum(new global::System.Func<global::Motorola.Common.Communication.Pba.LanguagePackBase, int>(global::Motorola.Common.Communication.l.<>c.<>9.a));
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00022098 File Offset: 0x00020298
		private void b()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			int count;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!count.Equals(0))
					{
						num2 = (short)528023554;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					num2 = (short)1941617967;
					short num3 = num2;
					num2 = (short)1325776175;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)1931476992;
						short num4 = num2;
						num2 = (short)2051670016;
						if (num2 != 0)
						{
						}
						num2 = (short)1840906241;
						if (num2 != 0)
						{
						}
						this.b = this.a;
						num2 = (short)1545404417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.b = new global::Motorola.Common.Communication.Pba.LanguagePackData();
			count = this.a.LanguagePacks.Count;
			num2 = (short)2057109504;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000221D4 File Offset: 0x000203D4
		public void f()
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)1995898885;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<string> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_372;
					case 1:
					{
						string text;
						if (global::System.IO.File.Exists(text))
						{
							num = (short)1984036870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_372;
					}
					case 2:
					{
						string text;
						if (text != null)
						{
							num = (short)251068423;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_372;
					}
					case 3:
					{
						try
						{
							num = (short)1163919366;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)1812987909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									string text2;
									if (global::System.IO.File.Exists(text2))
									{
										num = (short)2013462535;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									string text2;
									if (text2 != null)
									{
										num = (short)1345323016;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2106785793;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text2 = enumerator.Current;
									num = (short)747110403;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_303;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_218;
									}
									continue;
								case 7:
								{
									string text2;
									global::System.IO.File.SetAttributes(text2, global::System.IO.FileAttributes.Normal);
									global::System.IO.File.Delete(text2);
									num = (short)1468071936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)909312002;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_278:
								num = (short)1244790788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_218:
								goto IL_278;
							}
							IL_303:
							goto IL_79;
						}
						finally
						{
							num = (short)1212284928;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_33A;
									}
									continue;
								case 1:
									goto IL_36F;
								case 2:
									enumerator.Dispose();
									num = (short)612302849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_33A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1941176322;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_36F:;
						}
						goto IL_372;
						IL_79:
						string text = global::System.IO.Directory.GetFiles(this.d.j(), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("洀戂欄怆✈昊挌椎稐", a_), global::System.IO.SearchOption.TopDirectoryOnly).FirstOrDefault<string>();
						num = (short)1464467458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_38A;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_4D;
						}
						continue;
					case 6:
					{
						num = (short)1394741168;
						short num3 = num;
						num = (short)188485552;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)1987313664;
							if (num != 0)
							{
							}
							string text;
							global::System.IO.File.SetAttributes(text, global::System.IO.FileAttributes.Normal);
							global::System.IO.File.Delete(text);
							num = (short)2065891328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 7:
						num = (short)1370161153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4D:
					enumerator = global::System.IO.Directory.EnumerateFiles(this.d.j(), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("⬀ⴂ椄眆戈", a_), global::System.IO.SearchOption.TopDirectoryOnly).Select(new global::System.Func<string, string>(global::Motorola.Common.Communication.l.<>c.<>9.a)).GetEnumerator();
					num = (short)207945731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_372:
					num = (short)213319684;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_38A:;
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1814233089;
			if (num != 0)
			{
			}
			num = (short)592904192;
			short num4 = num;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000225F4 File Offset: 0x000207F4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool r(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1606224260;
			short num2 = num;
			num = (short)1327565188;
			switch (num2 == num)
			{
			}
			num = (short)2026176512;
			short num3 = num;
			num = (short)527171585;
			if (num != 0)
			{
			}
			num = (short)1443561472;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000128 RID: 296 RVA: 0x000226B8 File Offset: 0x000208B8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool q(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1028658792;
			short num2 = num;
			num = (short)1027544680;
			switch (num2 == num)
			{
			}
			num = (short)135397376;
			short num3 = num;
			num = (short)537853953;
			if (num != 0)
			{
			}
			num = (short)841875456;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00022780 File Offset: 0x00020980
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool p(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1929285884;
			short num2 = num;
			num = (short)246518012;
			switch (num2 == num)
			{
			}
			num = (short)1075707904;
			short num3 = num;
			num = (short)540737537;
			if (num != 0)
			{
			}
			num = (short)366739456;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00022848 File Offset: 0x00020A48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool o(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1975908112;
			short num2 = num;
			num = (short)624883472;
			switch (num2 == num)
			{
			}
			num = (short)1310588928;
			short num3 = num;
			num = (short)1074200577;
			if (num != 0)
			{
			}
			num = (short)102957056;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.o();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0002290C File Offset: 0x00020B0C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool n(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)55175836;
			short num2 = num;
			num = (short)390785692;
			switch (num2 == num)
			{
			}
			num = (short)529465344;
			short num3 = num;
			num = (short)1314324480;
			if (num != 0)
			{
			}
			num = (short)1086259201;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000229D0 File Offset: 0x00020BD0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool m(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)511852279;
			short num2 = num;
			num = (short)1289764599;
			switch (num2 == num)
			{
			}
			num = (short)835584000;
			short num3 = num;
			num = (short)1366687745;
			if (num != 0)
			{
			}
			num = (short)568197120;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.o();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00022A98 File Offset: 0x00020C98
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool l(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1240243546;
			short num2 = num;
			num = (short)836083034;
			switch (num2 == num)
			{
			}
			num = (short)1348206592;
			short num3 = num;
			num = (short)1465974784;
			if (num != 0)
			{
			}
			num = (short)352321537;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00022B5C File Offset: 0x00020D5C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1197146113;
			if (num != 0)
			{
			}
			num = (short)865849498;
			short num2 = num;
			num = (short)1422971034;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2015166464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1346109440;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00022C20 File Offset: 0x00020E20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool j(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)495679078;
			short num2 = num;
			num = (short)1934849638;
			switch (num2 == num)
			{
			}
			num = (short)561971200;
			short num3 = num;
			num = (short)1626734593;
			if (num != 0)
			{
			}
			num = (short)772014080;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00022CE4 File Offset: 0x00020EE4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool i(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)176607993;
			short num2 = num;
			num = (short)1584452345;
			switch (num2 == num)
			{
			}
			num = (short)1656815616;
			short num3 = num;
			num = (short)584777728;
			if (num != 0)
			{
			}
			num = (short)1933967361;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00022DA8 File Offset: 0x00020FA8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool h(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1183494138;
			short num2 = num;
			num = (short)397848570;
			switch (num2 == num)
			{
			}
			num = (short)2025127936;
			short num3 = num;
			num = (short)1871446017;
			if (num != 0)
			{
			}
			num = (short)192806912;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.o();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00022E6C File Offset: 0x0002106C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool g(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)276985317;
			short num2 = num;
			num = (short)642151909;
			switch (num2 == num)
			{
			}
			num = (short)649068544;
			short num3 = num;
			num = (short)997195777;
			if (num != 0)
			{
			}
			num = (short)648806400;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.o();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00022F30 File Offset: 0x00021130
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool f(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)381018256;
			short num2 = num;
			num = (short)1681055888;
			switch (num2 == num)
			{
			}
			num = (short)612827136;
			short num3 = num;
			num = (short)1805582336;
			if (num != 0)
			{
			}
			num = (short)1985085441;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00022FF8 File Offset: 0x000211F8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool e(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)176317946;
			short num2 = num;
			num = (short)29779450;
			switch (num2 == num)
			{
			}
			num = (short)2009858048;
			short num3 = num;
			num = (short)819527681;
			if (num != 0)
			{
			}
			num = (short)345767936;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.o();
		}

		// Token: 0x06000135 RID: 309 RVA: 0x000230C0 File Offset: 0x000212C0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)2023871199;
			short num2 = num;
			num = (short)488231647;
			switch (num2 == num)
			{
			}
			num = (short)1889337344;
			short num3 = num;
			num = (short)1705771009;
			if (num != 0)
			{
			}
			num = (short)1968308224;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00023184 File Offset: 0x00021384
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)2021920384;
			short num2 = num;
			num = (short)461966976;
			switch (num2 == num)
			{
			}
			num = (short)1719992320;
			short num3 = num;
			num = (short)1607270401;
			if (num != 0)
			{
			}
			num = (short)1107165184;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0002324C File Offset: 0x0002144C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
		{
			short num = (short)1457694887;
			short num2 = num;
			num = (short)1866836135;
			switch (num2 == num)
			{
			}
			num = (short)432472064;
			short num3 = num;
			num = (short)1931214849;
			if (num != 0)
			{
			}
			num = (short)2080571392;
			if (num != 0)
			{
			}
			return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.d.n();
		}

		// Token: 0x040000A4 RID: 164
		private global::Motorola.Common.Communication.Pba.LanguagePackData a;

		// Token: 0x040000A5 RID: 165
		private global::Motorola.Common.Communication.Pba.LanguagePackData b;

		// Token: 0x040000A6 RID: 166
		private global::Motorola.Common.Communication.Pba.LanguagePackData c;

		// Token: 0x040000A7 RID: 167
		private global::Motorola.Common.Communication.g d;

		// Token: 0x040000A8 RID: 168
		private int e = 512000;

		// Token: 0x040000A9 RID: 169
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.CustomException.CommonErrorCode f;

		// Token: 0x040000AA RID: 170
		private global::Motorola.Common.Communication.i g;

		// Token: 0x02000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000139 RID: 313 RVA: 0x00023324 File Offset: 0x00021524
			internal bool b(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
			{
				short num = (short)692326120;
				short num2 = num;
				num = (short)256577256;
				switch (num2 == num)
				{
				}
				num = (short)431095808;
				short num3 = num;
				num = (short)1298137088;
				if (num != 0)
				{
				}
				num = (short)707395585;
				if (num != 0)
				{
				}
				return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).radioFilePath == this.a.sourceFilePath;
			}

			// Token: 0x0600013A RID: 314 RVA: 0x000233E8 File Offset: 0x000215E8
			internal bool c(global::Motorola.Common.Communication.Pba.LanguagePackBase A_0)
			{
				short num = (short)673794198;
				short num2 = num;
				num = (short)1481918614;
				switch (num2 == num)
				{
				}
				num = (short)707002368;
				short num3 = num;
				num = (short)78053376;
				if (num != 0)
				{
				}
				num = (short)766836737;
				if (num != 0)
				{
				}
				return ((global::Motorola.Common.Communication.Pba.AstroFilePackInfo)A_0).sourceFilePath == this.a.sourceFilePath;
			}

			// Token: 0x040000AB RID: 171
			public global::Motorola.Common.Communication.Pba.AstroFilePackInfo a;
		}
	}
}
