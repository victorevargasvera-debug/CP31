using System;
using System.IO;
using System.Media;
using System.Text;

namespace ACPVoiceAnnouncementLib.SimplePlayer
{
	// Token: 0x02000024 RID: 36
	internal class a
	{
		// Token: 0x06000097 RID: 151 RVA: 0x0000D150 File Offset: 0x0000B350
		internal a()
		{
			this.f = new global::System.Media.SoundPlayer();
			this.g = global::System.IO.Path.GetTempFileName();
			this.h = global::System.IO.Path.GetTempFileName();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000D19C File Offset: 0x0000B39C
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1183290083;
				short num2 = num;
				num = (short)1578668771;
				switch (num2 == num)
				{
				}
				num = (short)1002962945;
				if (num != 0)
				{
				}
				num = (short)856096768;
				if (num != 0)
				{
				}
				this.f.Stop();
				global::System.IO.File.Delete(this.g);
				global::System.IO.File.Delete(this.h);
			}
			catch
			{
			}
			finally
			{
				base.Finalize();
			}
			num = (short)379715584;
			short num3 = num;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000D28C File Offset: 0x0000B48C
		internal bool c(string A_0)
		{
			bool result = false;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				for (;;)
				{
					IL_0E:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1028212248;
						short num3 = num2;
						num2 = (short)1900496408;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)55312384;
							if (num2 != 0)
							{
							}
							result = true;
							break;
						}
						num2 = (short)1805058049;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						goto IL_CE;
					case 2:
						goto IL_E5;
					case 3:
						if (this.b(A_0) == global::ACPVoiceAnnouncementLib.SimplePlayer.ACPSimpleAudioPlayerCompleteCodes.AUDIO_PLAYBACK_STARTED)
						{
							num2 = (short)1899626496;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_CE;
					}
					goto IL_24;
					IL_CE:
					num2 = (short)1966407682;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E5:
				goto IL_EA;
				IL_24:
				this.f.Stop();
				num2 = (short)1595801603;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0E;
			}
			catch
			{
			}
			IL_EA:
			num2 = (short)883818496;
			short num4 = num2;
			num2 = (short)1978531841;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000D3E8 File Offset: 0x0000B5E8
		private global::ACPVoiceAnnouncementLib.SimplePlayer.ACPSimpleAudioPlayerCompleteCodes b(string A_0)
		{
			short num = (short)1725366272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1092878336;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				global::ACPVoiceAnnouncementLib.SimplePlayer.ACPSimpleAudioPlayerCompleteCodes result;
				bool flag;
				global::ACPVoiceAnnouncementLib.SimplePlayer.a.a a;
				for (;;)
				{
					IL_51:
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						if (!flag)
						{
							num = (short)540868610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_477;
					case 2:
						result = global::ACPVoiceAnnouncementLib.SimplePlayer.ACPSimpleAudioPlayerCompleteCodes.AUDIO_PLAYBACK_STARTED;
						num = (short)1524432900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_12C;
							}
							for (;;)
							{
								IL_E5:
								switch (num2)
								{
								case 0:
									goto IL_287;
								case 1:
									num = (short)1145307137;
									if (num != 0)
									{
									}
									result = global::ACPVoiceAnnouncementLib.SimplePlayer.ACPSimpleAudioPlayerCompleteCodes.AUDIO_PLAYBACK_FILE_WRONG_FORMAT;
									num = (short)1492254729;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (a == global::ACPVoiceAnnouncementLib.SimplePlayer.a.a.b)
									{
										num = (short)1459355655;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)626589707;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate().InflateFile(A_0, this.h) == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.VOICE_FILE_CONVERT_SUCCESS)
									{
										num = (short)531562511;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_250;
								case 4:
									if (a == global::ACPVoiceAnnouncementLib.SimplePlayer.a.a.c)
									{
										num = (short)1057161222;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_451;
								case 5:
									goto IL_451;
								case 6:
									num = (short)884932611;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									global::ACPVoiceAnnouncementLib.a.a().inflate_fileInterface(A_0, this.g);
									new global::ACPVoiceAnnouncementLib.WaveFile().a(this.g, this.h);
									this.f.SoundLocation = this.h;
									this.f.Load();
									num = (short)231604236;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									try
									{
										this.f.Play();
										goto IL_451;
									}
									catch
									{
										flag = true;
										goto IL_451;
									}
									goto IL_250;
								case 9:
									goto IL_451;
								case 10:
									try
									{
										this.f.Play();
										goto IL_451;
									}
									catch
									{
										flag = true;
										goto IL_451;
									}
									goto IL_310;
								case 11:
									if (a == global::ACPVoiceAnnouncementLib.SimplePlayer.a.a.d)
									{
										num = (short)1094123521;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)748486660;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									try
									{
										this.f.Play();
										goto IL_451;
									}
									catch
									{
										flag = true;
										goto IL_451;
									}
									goto IL_287;
								case 13:
									goto IL_46A;
								case 14:
									if (a == global::ACPVoiceAnnouncementLib.SimplePlayer.a.a.a)
									{
										num = (short)2068447232;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2B9;
								case 15:
									goto IL_310;
								}
								goto IL_12C;
								IL_250:
								flag = true;
								num = (short)1450442757;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_287:
								this.f.SoundLocation = A_0;
								this.f.Load();
								num = (short)1571291146;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B9:
								num = (short)360382466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_310:
								num = (short)499874669;
								short num4 = num;
								num = (short)464485229;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2B9;
								default:
									num = (short)699924480;
									if (num != 0)
									{
									}
									this.f.SoundLocation = this.h;
									this.f.Load();
									num = (short)1117192200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_451:
								num = (short)308674573;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_46A:
							goto IL_A5;
							IL_12C:
							global::System.IO.BinaryReader binaryReader = new global::System.IO.BinaryReader(new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open));
							byte[] a_ = binaryReader.ReadBytes(19);
							binaryReader.Close();
							a = this.a(a_);
							num = (short)422707214;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_E5;
						}
						catch
						{
							flag = true;
							goto IL_A5;
						}
						goto IL_477;
						IL_A5:
						num = (short)1855979521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return result;
					}
					goto IL_6C;
					IL_477:
					result = global::ACPVoiceAnnouncementLib.SimplePlayer.ACPSimpleAudioPlayerCompleteCodes.AUDIO_PLAYBACK_FILE_OTHER;
					num = (short)409796608;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_6C:
				a = global::ACPVoiceAnnouncementLib.SimplePlayer.a.a.e;
				flag = false;
				num = (short)1927544835;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
		private global::ACPVoiceAnnouncementLib.SimplePlayer.a.a a(byte[] A_0)
		{
			int a_ = 18;
			global::ACPVoiceAnnouncementLib.SimplePlayer.a.a result = global::ACPVoiceAnnouncementLib.SimplePlayer.a.a.e;
			short num;
			try
			{
				num = (short)666763274;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						result = global::ACPVoiceAnnouncementLib.SimplePlayer.a.a.c;
						num = (short)760676359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_28A;
					case 2:
						num = (short)1905131526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)90963969;
						if (num != 0)
						{
						}
						result = global::ACPVoiceAnnouncementLib.SimplePlayer.a.a.a;
						goto IL_A0;
					case 4:
						if (global::System.Text.Encoding.ASCII.GetString(A_0, 0, global::ACPVoiceAnnouncementLib.WaveFileReader.f("โ੄ፆو᥊Ɍ͎ၐ獒͔ᙖ", a_).Length) == global::ACPVoiceAnnouncementLib.WaveFileReader.f("โ੄ፆو᥊Ɍ͎ၐ獒͔ᙖ", a_))
						{
							num = (short)52101120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28A;
					case 5:
						result = global::ACPVoiceAnnouncementLib.SimplePlayer.a.a.b;
						num = (short)778305537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (global::System.Text.Encoding.ASCII.GetString(A_0, 8, 4) == global::ACPVoiceAnnouncementLib.WaveFileReader.f("ᑂфᅆై", a_))
						{
							num = (short)1664024579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28A;
					case 7:
						goto IL_28A;
					case 8:
					{
						if (!(global::System.Text.Encoding.ASCII.GetString(A_0, 0, 6) == global::ACPVoiceAnnouncementLib.WaveFileReader.f("恂摄نш᥊䝌", a_)))
						{
							num = (short)2093023236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2081553991;
						short num3 = num;
						num = (short)404749895;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A0;
						default:
							num = (short)466092032;
							if (num != 0)
							{
							}
							num = (short)439812101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						goto IL_2A3;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_63;
						}
						continue;
					case 11:
						goto IL_28A;
					}
					IL_63:
					if (global::System.Text.Encoding.ASCII.GetString(A_0, 0, 4) == global::ACPVoiceAnnouncementLib.WaveFileReader.f("ᅂౄņ཈", a_))
					{
						num = (short)1238433794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1484587016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A0:
					num = (short)1182007307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28A:
					num = (short)1341521929;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2A3:;
			}
			catch
			{
			}
			num = (short)2101411840;
			short num4 = num;
			return result;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000DBEC File Offset: 0x0000BDEC
		private bool a(string A_0)
		{
			short num = (short)2086404096;
			short num2 = num;
			num = (short)470283799;
			short num3 = num;
			num = (short)1335883287;
			switch (num3 == num)
			{
			}
			num = (short)636223489;
			if (num != 0)
			{
			}
			num = (short)1940586496;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x04000096 RID: 150
		private const string a = "MOTOROLA VOICE FILE";

		// Token: 0x04000097 RID: 151
		private const string b = "MOTOROLA VA";

		// Token: 0x04000098 RID: 152
		private const string c = "#!AMR\n";

		// Token: 0x04000099 RID: 153
		private const string d = "RIFF";

		// Token: 0x0400009A RID: 154
		private const string e = "WAVE";

		// Token: 0x0400009B RID: 155
		private global::System.Media.SoundPlayer f;

		// Token: 0x0400009C RID: 156
		private string g = "";

		// Token: 0x0400009D RID: 157
		private string h = "";

		// Token: 0x02000025 RID: 37
		private enum a
		{
			// Token: 0x0400009F RID: 159
			a,
			// Token: 0x040000A0 RID: 160
			b,
			// Token: 0x040000A1 RID: 161
			c,
			// Token: 0x040000A2 RID: 162
			d,
			// Token: 0x040000A3 RID: 163
			e
		}
	}
}
