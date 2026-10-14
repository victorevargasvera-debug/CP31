using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Threading;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository
{
	// Token: 0x02000056 RID: 86
	public class TTSMemoryAudioRepository : global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.ITTSAudioRepository<global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel>, global::System.IDisposable
	{
		// Token: 0x06000407 RID: 1031 RVA: 0x0004B0A0 File Offset: 0x000492A0
		private TTSMemoryAudioRepository()
		{
			int a_ = 12;
			this.b = new object();
			base..ctor();
			this.c = new global::System.Runtime.Caching.MemoryCache(global::AllFeatures.CodeplugGuid.b("背ꃎꗐ볒꟔룖뗘뫚鋞胠胢軤軦蟨諪髬곮ꇰꃲ\udbf4듶雸觺飼맾搀戂焄爆笈渊縌ℎ弐簒笔倖䰘刚䤜䬞爠漢䰤否崨Ԫ礬笮戰攲娴帶娸帺簼儾⽀ⱂい⥆⩈⹊⁌⩎㽐❒ᥔ㹖⩘⽚獜୞㕠ぢ⡤ɦѨѪὬ᙮ばٲᅴṶᙸ⥺᡼ཾ力", a_), null);
			this.d = new global::System.Runtime.Caching.CacheItemPolicy();
			global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository.e = null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0004B0F4 File Offset: 0x000492F4
		public static global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository GetInstance(string speaker)
		{
			short num = (short)1749483522;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E3;
				case 1:
					goto IL_98;
				case 2:
				{
					num = (short)1397953463;
					short num3 = num;
					num = (short)344265655;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_98;
					default:
						num = (short)1195114496;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					}
					break;
				}
				}
				IL_7C:
				if (global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository.a == null)
				{
					num = (short)227475457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_98:
				num = (short)1636564993;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository.a = new global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository();
				num = (short)713359360;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E3:
			num = (short)654573568;
			short num4 = num;
			global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository.a.a(speaker);
			return global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository.a;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0004B220 File Offset: 0x00049420
		public void AddOrReplaceAudio(string tts, global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel audioSample)
		{
			object obj = this.b;
			bool flag = false;
			short num;
			try
			{
				global::System.Threading.Monitor.Enter(obj, ref flag);
				this.c.Set(tts, audioSample, this.d, null);
			}
			finally
			{
				num = (short)55640066;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_DD;
					case 1:
						goto IL_C0;
					case 2:
					{
						num = (short)1968149397;
						short num3 = num;
						num = (short)1059623829;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C0;
						default:
							num = (short)2123890688;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A9;
							}
							continue;
						}
						break;
					}
					}
					IL_A9:
					if (flag)
					{
						num = (short)1629487105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_C0:
					global::System.Threading.Monitor.Exit(obj);
					num = (short)455540736;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DD:;
			}
			num = (short)1619722241;
			if (num != 0)
			{
			}
			num = (short)862650368;
			short num4 = num;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0004B370 File Offset: 0x00049570
		public global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel GetAudio(string tts)
		{
			short num = (short)762380288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)268500993;
				if (num != 0)
				{
				}
				object obj = this.b;
				bool flag = false;
				global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel result;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					try
					{
						switch (0)
						{
						case 0:
							goto IL_7F;
						}
						global::System.Runtime.Caching.CacheItem cacheItem;
						for (;;)
						{
							IL_64:
							global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel audioSampleModel;
							switch (num2)
							{
							case 0:
								audioSampleModel = null;
								goto IL_FD;
							case 1:
								num = (short)959053828;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_116;
							case 3:
								if (cacheItem != null)
								{
									num = (short)617349121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1957363712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								audioSampleModel = (cacheItem.Value as global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel);
								goto IL_FD;
							}
							goto IL_7F;
							IL_FD:
							result = audioSampleModel;
							num = (short)1095106562;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_116:
						goto IL_1DE;
						IL_7F:
						cacheItem = this.c.GetCacheItem(tts, null);
						num = (short)340131843;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_64;
					}
					catch (global::System.Exception)
					{
						result = null;
					}
				}
				finally
				{
					for (;;)
					{
						IL_123:
						num = (short)231866369;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1DB;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_155;
								}
								continue;
							case 2:
							{
								num = (short)142972473;
								short num3 = num;
								num = (short)537433657;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_123;
								default:
									num = (short)382337024;
									if (num != 0)
									{
									}
									global::System.Threading.Monitor.Exit(obj);
									num = (short)141033472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_155:
							if (!flag)
							{
								goto IL_1DD;
							}
							num = (short)1953103874;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_1DB:
					IL_1DD:;
				}
				IL_1DE:
				num = (short)515178496;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0004B5A0 File Offset: 0x000497A0
		public bool RemoveAudio(string tts)
		{
			short num = (short)1554122840;
			short num2 = num;
			num = (short)1817839704;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)861208576;
				if (num != 0)
				{
				}
				num = (short)1591672832;
				short num3 = num;
				object obj = this.b;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					try
					{
						result = (this.c.Remove(tts, null) != null);
					}
					catch (global::System.Exception)
					{
						result = false;
					}
				}
				finally
				{
					num = (short)2000027649;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_133;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_D7;
							}
							continue;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1310720;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_D7:
						num = (short)1862205441;
						if (num != 0)
						{
						}
						if (!flag)
						{
							break;
						}
						num = (short)308346882;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_133:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0004B700 File Offset: 0x00049900
		public long GetCount()
		{
			short num = (short)415892605;
			short num2 = num;
			num = (short)1902838909;
			long count;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1593769985;
				if (num != 0)
				{
				}
				num = (short)1329266688;
				if (num != 0)
				{
				}
				num = (short)1556938752;
				short num3 = num;
				object obj = this.b;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					count = this.c.GetCount(null);
				}
				finally
				{
					num = (short)1018560513;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_125;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_F0;
							}
							continue;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1543438336;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_F0:
						if (!flag)
						{
							break;
						}
						num = (short)179372034;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_125:;
				}
				break;
			}
			}
			return count;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0004B848 File Offset: 0x00049A48
		public void Dispose()
		{
			short num = (short)1217331201;
			if (num != 0)
			{
			}
			num = (short)419683433;
			short num2 = num;
			num = (short)989977705;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2077491200;
				if (num != 0)
				{
				}
				num = (short)2007302144;
				short num3 = num;
				object obj = this.b;
				bool flag = false;
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					this.c.Dispose();
				}
				finally
				{
					num = (short)428146689;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_121;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_EE;
							}
							continue;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)853344256;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_EE:
						if (!flag)
						{
							break;
						}
						num = (short)2075590658;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_121:;
				}
				break;
			}
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0004B98C File Offset: 0x00049B8C
		private void a(string A_0)
		{
			short num = (short)652410880;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				object obj = this.b;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					for (;;)
					{
						IL_32:
						switch (num2)
						{
						case 0:
							num = (short)140902401;
							if (num != 0)
							{
							}
							try
							{
								num = (short)1178075139;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 1:
									{
										global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)912654340;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair = enumerator.Current;
										this.c.Remove(keyValuePair.Key, null);
										num = (short)736034816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_1E6;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_15E;
										}
										continue;
									case 4:
										num = (short)814809090;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_160:
									num = (short)687734785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_15E:
									goto IL_160;
								}
								IL_1E6:;
							}
							finally
							{
								for (;;)
								{
									IL_1EB:
									num = (short)935526401;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> enumerator;
										switch (num2)
										{
										case 0:
											goto IL_2A4;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_21D;
											}
											continue;
										case 2:
										{
											num = (short)1362147763;
											short num3 = num;
											num = (short)1432926643;
											switch ((num3 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_1EB;
											default:
												num = (short)1787691008;
												if (num != 0)
												{
												}
												enumerator.Dispose();
												num = (short)919863296;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										IL_21D:
										if (enumerator == null)
										{
											goto IL_2A6;
										}
										num = (short)518324226;
										num2 = (int)((global::System.IntPtr)num);
									}
								}
								IL_2A4:
								IL_2A6:;
							}
							goto IL_2A7;
						case 1:
							if (!string.IsNullOrEmpty(global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository.e))
							{
								num = (short)601882628;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A7;
						case 2:
							goto IL_2C6;
						case 3:
							if (global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository.e != A_0)
							{
								num = (short)121241605;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A7;
						case 4:
							num = (short)2084175875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> enumerator = ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>)this.c).GetEnumerator();
							num = (short)42795008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_51;
						IL_2A7:
						global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository.e = A_0;
						num = (short)870514690;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2C6:
					goto IL_332;
					IL_51:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)846135297;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				finally
				{
					num = (short)1792933889;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_32F;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2FA;
							}
							continue;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1437007872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2FA:
						if (!flag)
						{
							break;
						}
						num = (short)1761935362;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_32F:;
				}
				IL_332:
				num = (short)207224832;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x040001E1 RID: 481
		private static global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.TTSMemoryAudioRepository a;

		// Token: 0x040001E2 RID: 482
		private readonly object b;

		// Token: 0x040001E3 RID: 483
		private readonly global::System.Runtime.Caching.MemoryCache c;

		// Token: 0x040001E4 RID: 484
		private global::System.Runtime.Caching.CacheItemPolicy d;

		// Token: 0x040001E5 RID: 485
		private static string e;
	}
}
