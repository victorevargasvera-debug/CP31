using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using TTSBridge;

namespace AcpUITTS
{
	// Token: 0x02000005 RID: 5
	public class ACPTTSVoiceAnnouncement
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00005278 File Offset: 0x00003478
		[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
		public void Play(string speaker, string tts)
		{
			int a_ = 4;
			short num = (short)1167458305;
			if (num != 0)
			{
			}
			global::System.IO.DirectoryInfo temporaryPlayDirectory = new global::System.IO.DirectoryInfo(global::System.IO.Path.GetTempPath());
			string directoryName = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
			if (directoryName == null)
			{
				throw new global::System.NullReferenceException(global::AcpUITTS.ACPTTSVoiceAnnouncement.b("刵儷䠹夻崽㐿ⵁ㙃㽅桇㩉ⵋ㩍㡏牑㵓╕硗㑙⥛㉝౟", a_));
			}
			for (;;)
			{
				global::System.IO.DirectoryInfo directoryInfo = new global::System.IO.DirectoryInfo(global::System.IO.Path.Combine(directoryName, global::AcpUITTS.ACPTTSVoiceAnnouncement.b("䔵䠷弹夻崽⠿ṁ⡃❅♇ⵉ㥋⽍㝏㝑❓", a_)));
				try
				{
					num = (short)814153732;
					int num2 = (int)((global::System.IntPtr)num);
					global::TTSBridge.Vocalizer vocalizer2;
					for (;;)
					{
						global::TTSBridge.Vocalizer vocalizer;
						switch (num2)
						{
						case 0:
							vocalizer = null;
							goto IL_13F;
						case 1:
							goto IL_157;
						case 2:
							vocalizer = null;
							goto IL_13F;
						case 3:
							vocalizer = null;
							goto IL_13F;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_92;
							}
							continue;
						case 5:
							vocalizer = null;
							goto IL_13F;
						}
						IL_92:
						global::TTSBridge.Vocalizer.Builder builder = new global::TTSBridge.Vocalizer.Builder().setTemporaryPlayDirectory(temporaryPlayDirectory);
						if (builder == null)
						{
							num = (short)1211367427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::TTSBridge.Vocalizer.Builder builder2 = builder.setVolumeLevel(60);
						if (builder2 == null)
						{
							num = (short)1550974976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::TTSBridge.Vocalizer.Builder builder3 = builder2.setOuputFormat(new global::TTSBridge.MVAFormat(10));
						if (builder3 == null)
						{
							num = (short)1900085253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::TTSBridge.Vocalizer.Builder builder4 = builder3.setVoice(speaker);
						if (builder4 == null)
						{
							num = (short)1265762306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						vocalizer = builder4.build(directoryInfo);
						IL_13F:
						vocalizer2 = vocalizer;
						num = (short)1310130177;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_157:
					goto IL_159;
					try
					{
						for (;;)
						{
							IL_159:
							num = (short)824311810;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1208745987;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_22A;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_18D;
									}
									continue;
								case 3:
									goto IL_1BC;
								}
								IL_18D:
								if (vocalizer2 == null)
								{
									num = (short)640745472;
									num2 = (int)((global::System.IntPtr)num);
								}
								else
								{
									vocalizer2.play(tts);
									num = (short)1014038529;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_1BC:
							num = (short)1016179707;
							short num3 = num;
							num = (short)319794171;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_1F1;
							}
						}
						IL_1F1:
						num = (short)1765474304;
						if (num != 0)
						{
						}
						IL_22A:
						break;
					}
					finally
					{
						num = (short)1835991041;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_293;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_25F;
								}
								continue;
							case 2:
								((global::System.IDisposable)vocalizer2).Dispose();
								num = (short)1261568000;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_25F:
							if (vocalizer2 == null)
							{
								break;
							}
							num = (short)1944846338;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_293:;
					}
				}
				finally
				{
					try
					{
						num = (short)736690178;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								global::System.IO.File.Delete(directoryInfo.FullName + global::AcpUITTS.ACPTTSVoiceAnnouncement.b("樵䰷圹䰻ွ㜿⍁㉃", a_));
								num = (short)448331779;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_350;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_2CE;
								}
								continue;
							case 3:
								goto IL_339;
							}
							IL_2CE:
							if (global::System.IO.File.Exists(directoryInfo.FullName + global::AcpUITTS.ACPTTSVoiceAnnouncement.b("樵䰷圹䰻ွ㜿⍁㉃", a_)))
							{
								num = (short)1341128704;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_339:
							num = (short)1387069441;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_350:;
					}
					catch
					{
					}
				}
			}
			num = (short)30212096;
			short num4 = num;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005698 File Offset: 0x00003898
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(910594675 + A_1) + (global::System.IntPtr)88 + (global::System.IntPtr)8 + (global::System.IntPtr)94);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x0400001A RID: 26
		private const string a = "speech\\languages";
	}
}
