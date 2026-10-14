using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x02000011 RID: 17
	public class ACPVoiceAnnouncementInflateDeflate
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002E18 File Offset: 0x00001018
		public ACPVoiceAnnouncementInflateDeflate()
		{
			this.b = global::ACPVoiceAnnouncementLib.a.a();
			this.c = false;
			this.d = null;
			this.f = null;
			this.e = null;
			this.g = null;
			this.h = global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions.PROMPT_BEFORE_OVERWRITE;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002E60 File Offset: 0x00001060
		static ACPVoiceAnnouncementInflateDeflate()
		{
			short num = (short)1075517133;
			short num2 = num;
			num = (short)716117709;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1572077568;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1719468033;
			if (num != 0)
			{
			}
			num = (short)2090532864;
			if (num != 0)
			{
			}
			global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a = null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002F10 File Offset: 0x00001110
		public void CompressAudioFilesInDirectoryAsync(string inputDirectory, string outputDirectory, global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions overwriteOption, global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressProgress progressDelegate, global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressAskUser userPromptDelegate, global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressCompleted compressCompletedDelegate)
		{
			int a_ = 5;
			short num = (short)579862529;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a = global::System.Threading.SynchronizationContext.Current;
					num = (short)653197325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1580728321;
					if (num != 0)
					{
					}
					num = (short)118896404;
					short num3 = num;
					num = (short)1975990036;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_33E;
					default:
						num = (short)2083389440;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D7;
						}
						continue;
					}
					break;
				}
				case 2:
					goto IL_1B7;
				case 3:
					if (overwriteOption == global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions.PROMPT_BEFORE_OVERWRITE)
					{
						num = (short)522518532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_343;
				case 4:
					num = (short)1091043334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_33E;
				case 6:
					if (userPromptDelegate == null)
					{
						num = (short)1363083264;
						short num4 = num;
						num = (short)1130627074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_343;
				case 7:
					if (!global::System.IO.Directory.Exists(inputDirectory))
					{
						num = (short)1668612101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1164050443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_302;
				case 9:
					if (compressCompletedDelegate == null)
					{
						num = (short)1174339594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2110324739;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_202;
				case 11:
					if (!global::System.IO.Directory.Exists(outputDirectory))
					{
						num = (short)141230088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1159004169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_287;
				case 13:
					if (global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a == null)
					{
						num = (short)670957580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2069823495;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D7:
				if (global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a != null)
				{
					break;
				}
				num = (short)259915776;
				num2 = (int)((global::System.IntPtr)num);
			}
			throw new global::System.InvalidOperationException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("戵倷匹伻ḽ⌿⹁╃㕅㭇橉⽋⽍㹏牑㭓㡕㑗⍙籛㙝şౡc੥൧䩩嵫乭ᅯű൳ᡵ᭷婹๻᭽ﲇꪉ揄낏뒓鍊", a_));
			IL_1B7:
			throw new global::System.ArgumentException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("戵倷弹᰻欽㌿❁㙃晅ᡇ㡉⍋⍍⁏♑瑓㉕㵗㙙㥛㥝şᙡţ䙥էὩὫᩭ偯ၱᅳ噵୷੹᥻ᵽꪉ낏ﲓ뢗ﮝ튟햡횣쾥\udca7쾩貫솭삯욱\uddb3\ud9b5횷骹햻춽鋁雃觅藇髉飋重鋏韑鋓駕諗鿙菛針뛟꟡뛣뇥뫧ꏩ룫꯭", a_));
			IL_202:
			throw new global::System.ArgumentException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("电圷圹䰻刽┿㙁ⵃ⥅♇橉⡋⭍㱏㝑㍓㝕ⱗ㽙籛そ՟ݡcᕥ䡧ṩͫ乭ቯ᝱味յࡷόύ᝽", a_), global::ACPVoiceAnnouncementLib.WaveFileReader.f("唵圷圹䰻䰽┿ㅁ㝃Յ❇❉㱋≍㕏♑ㅓ㉕᱗㽙せ㭝ݟ͡ၣͥ", a_));
			IL_287:
			throw new global::System.InvalidOperationException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("砵圷ᨹ漻䜽⸿⅁ⱃ㑅❇⑉╋㑍ㅏ♑㵓㥕㙗穙Ὓㅝ๟ᙡţṥᱧ䩩⩫ŭկᱱၳ", a_));
			IL_302:
			throw new global::System.IO.DirectoryNotFoundException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("礵䴷丹䰻䬽㐿扁C⽅㩇⽉⽋㩍㽏⁑ⵓ汕硗", a_) + outputDirectory + global::ACPVoiceAnnouncementLib.WaveFileReader.f("ᘵ嘷唹䠻ḽ☿ⵁㅃ⡅ⱇ", a_));
			IL_33E:
			throw new global::System.IO.DirectoryNotFoundException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("缵嘷䨹䤻䨽怿فⵃ㑅ⵇ⥉㡋⅍≏⭑湓癕", a_) + inputDirectory + global::ACPVoiceAnnouncementLib.WaveFileReader.f("ᘵ嘷唹䠻ḽ☿ⵁㅃ⡅ⱇ", a_));
			IL_343:
			this.h = overwriteOption;
			this.c = false;
			global::System.Threading.ParameterizedThreadStart start = new global::System.Threading.ParameterizedThreadStart(this.e);
			this.g = new global::System.Threading.Thread(start);
			this.d = progressDelegate;
			this.e = compressCompletedDelegate;
			this.f = userPromptDelegate;
			this.g.Start(new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a(inputDirectory, outputDirectory));
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000032B4 File Offset: 0x000014B4
		public void CompressAudioFilesInDirectoryAsync(string[] filesToConvert, string inputDirectory, string outputDirectory, global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions overwriteOption, global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressProgress progressDelegate, global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressAskUser userPromptDelegate, global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressCompleted compressCompletedDelegate)
		{
			int a_ = 16;
			short num;
			try
			{
				num = (short)1173094401;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_30F;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 2:
						goto IL_2D2;
					case 3:
						goto IL_109;
					case 4:
						global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a = global::System.Threading.SynchronizationContext.Current;
						num = (short)926482444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (compressCompletedDelegate == null)
						{
							num = (short)1951465478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1849557006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_D2;
					case 7:
					{
						if (filesToConvert == null)
						{
							goto IL_170;
						}
						num = (short)74720275;
						short num3 = num;
						num = (short)1923752979;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_394;
						default:
							num = (short)1317601280;
							if (num != 0)
							{
							}
							num = (short)1826422797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						if (userPromptDelegate == null)
						{
							num = (short)1777664010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					case 9:
						goto IL_404;
					case 10:
						goto IL_240;
					case 11:
						if (filesToConvert.Length == 0)
						{
							num = (short)638779395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1405943813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a == null)
						{
							num = (short)2021916674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)536215570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_394;
					case 14:
						if (overwriteOption == global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions.PROMPT_BEFORE_OVERWRITE)
						{
							num = (short)352059407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					case 15:
						num = (short)1676214280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (!global::System.IO.Directory.Exists(outputDirectory))
						{
							num = (short)1163722752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)333971463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_208;
					case 18:
						if (!global::System.IO.Directory.Exists(inputDirectory))
						{
							num = (short)771162129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1733361680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7A:
					if (global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a == null)
					{
						num = (short)1213595652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10B;
					IL_394:
					num = (short)576651275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_399:
					this.h = overwriteOption;
					this.c = false;
					global::System.Threading.ParameterizedThreadStart start = new global::System.Threading.ParameterizedThreadStart(this.e);
					this.g = new global::System.Threading.Thread(start);
					this.d = progressDelegate;
					this.e = compressCompletedDelegate;
					this.f = userPromptDelegate;
					this.g.Start(new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a(filesToConvert, inputDirectory, outputDirectory));
					num = (short)1613299721;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D2:
				throw new global::System.ArgumentException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("ɀⱂ⡄㝆╈⹊㥌♎㹐㵒畔㍖㱘㝚㡜㡞`ᝢd䝦ݨ๪࡬୮ɰ卲Ŵᡶ奸᥺᡼彾", a_), global::ACPVoiceAnnouncementLib.WaveFileReader.f("≀ⱂ⡄㝆㭈⹊㹌㱎ቐ㱒㡔❖㕘㹚⥜㩞ՠ❢d୦౨౪౬᭮ᑰ", a_));
				IL_109:
				goto IL_170;
				IL_10B:
				throw new global::System.InvalidOperationException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("ᕀ⭂ⱄ㑆楈⡊⅌⹎≐⁒畔㑖㡘㕚絜ぞའརᱤ䝦Ũ੪ͬ୮ᵰᙲ啴䙶奸᩺๼پꖄ慠떔뮚ﲜ뾞햠쪢좤슦", a_));
				IL_170:
				throw new global::System.ArgumentException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("ཀⱂ敄ⅆ⁈❊⡌㱎煐⑒ご╖㱘筚⹜㩞ൠ٢٤፦౨ཪ䵬८ṰŲ啴ᑶᙸᕺ୼᩾ꖊ", a_), global::ACPVoiceAnnouncementLib.WaveFileReader.f("❀⩂⥄≆㩈Ὂ≌౎㹐㵒⍔㉖⭘⽚", a_));
				IL_208:
				throw new global::System.IO.DirectoryNotFoundException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("ࡀⵂ㕄㉆㵈歊ौ♎⍐㙒㙔⍖㙘⥚⑜敞䅠", a_) + inputDirectory + global::ACPVoiceAnnouncementLib.WaveFileReader.f("慀ⵂ⩄㍆楈ⵊ≌㩎㽐㝒", a_));
				IL_240:
				throw new global::System.ArgumentException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("ᕀ⭂⁄杆᱈㡊⡌㵎煐͒❔㡖㑘⭚⥜罞ՠ٢।ɦ๨੪ᥬ੮兰ṲtѶ൸孺ὼ᩾ꆀ떔ﺖﾘ뮚쒠莢쪤톦첨\ud9aa\udaac\uddae\ud8b0잲킴鞶횸쮺즼횾껀귂껆뫈鷌鷎黐黒藔菖蛘駚飜駞껠뇢ꃤ룦ꛨ뷪꣬뷮꛰ꇲ보ꏶ본", a_));
				IL_2D2:
				throw new global::System.InvalidOperationException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("ཀⱂ敄ᑆえ╊⹌❎⍐㱒㭔㹖⍘㩚⥜㙞๠ൢ䕤⑦٨ժᥬ੮॰ݲ啴ㅶᙸ๺፼᭾", a_));
				IL_30F:
				throw new global::System.IO.DirectoryNotFoundException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("เ㙂ㅄ㝆㱈㽊浌୎㡐⅒ご㑖ⵘ㑚⽜♞孠䍢", a_) + outputDirectory + global::ACPVoiceAnnouncementLib.WaveFileReader.f("慀ⵂ⩄㍆楈ⵊ≌㩎㽐㝒", a_));
				IL_404:;
			}
			catch
			{
				global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a = null;
				throw;
			}
			num = (short)340197377;
			if (num != 0)
			{
			}
			num = (short)2121007104;
			short num4 = num;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000373C File Offset: 0x0000193C
		public void DownloadVoiceDataToDirectoryAsync(global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo> voiceDataList, string outputDirectory, global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions overwriteOption, global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressProgress progressDelegate, global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressAskUser userPromptDelegate, global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressCompleted compressCompletedDelegate)
		{
			int a_ = 3;
			short num;
			try
			{
				num = (short)290914304;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					case 1:
						num = (short)1845100545;
						if (num != 0)
						{
						}
						num = (short)182386692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_290;
					case 3:
						global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a = global::System.Threading.SynchronizationContext.Current;
						num = (short)1923874823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (voiceDataList.Count != 0)
						{
							num = (short)535429133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)939021796;
						short num3 = num;
						num = (short)642864612;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1579614208;
							if (num != 0)
							{
							}
							num = (short)1893662728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						if (overwriteOption == global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions.PROMPT_BEFORE_OVERWRITE)
						{
							num = (short)1237123086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_363;
					case 6:
						goto IL_336;
					case 7:
						if (global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a == null)
						{
							num = (short)679477254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1045299210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_13E;
					case 9:
						if (userPromptDelegate == null)
						{
							num = (short)298450956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_363;
					case 10:
						if (!global::System.IO.Directory.Exists(outputDirectory))
						{
							num = (short)1575419906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)683212815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_3CC;
					case 12:
						goto IL_18F;
					case 13:
						if (compressCompletedDelegate == null)
						{
							num = (short)1343291408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)479789061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)1468989449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (voiceDataList != null)
						{
							num = (short)1828126721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D0;
					case 16:
						goto IL_1DB;
					}
					IL_71:
					if (global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a == null)
					{
						num = (short)1384513539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_143;
					IL_363:
					this.h = overwriteOption;
					this.c = false;
					global::System.Threading.ParameterizedThreadStart start = new global::System.Threading.ParameterizedThreadStart(this.d);
					this.g = new global::System.Threading.Thread(start);
					this.d = progressDelegate;
					this.e = compressCompletedDelegate;
					this.f = userPromptDelegate;
					this.g.Start(new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.b(voiceDataList, outputDirectory));
					num = (short)626655243;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13E:
				goto IL_2D0;
				IL_143:
				throw new global::System.InvalidOperationException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("怳帵儷䤹᰻崽ⰿ⍁㝃㕅桇⥉ⵋ⁍灏㵑㩓㩕⅗穙㑛㽝๟١ࡣͥ䡧孩䱫཭ͯୱᩳᕵ塷ࡹ᥻ཽꢇ꺍늑ﾕﾙ", a_));
				IL_18F:
				throw new global::System.ArgumentException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("怳帵崷ᨹ椻䴽┿ぁ摃ᙅ㩇╉⅋㹍⑏牑こ㍕㑗㽙㭛㽝ᑟݡ䑣୥ᵧᥩᡫ乭ቯ᝱味յࡷόύ᝽ꢇ꺍晴뚕鍊힟킡춣튥춧誩쎫\udead쒯\udbb1\udbb3\ud8b5颷펹쾻麽邿郁诃诅飇黉鏋賍闏铑鯓蓕鷗藙鏛裝ꗟ냡돣듥ꇧ뻩ꧫ", a_));
				IL_1DB:
				throw new global::System.ArgumentException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("眳夵唷䨹倻嬽㐿⭁⭃⡅桇⹉⥋≍㕏㕑㕓≕㵗穙㉛㭝՟١ᝣ䙥ᱧթ䱫౭ᕯ剱ݳٵᵷ᥹ᕻ᡽", a_), global::ACPVoiceAnnouncementLib.WaveFileReader.f("圳夵唷䨹主嬽㌿ㅁ݃⥅╇㩉⁋⭍⑏㝑こቕ㵗㙙㥛㥝şᙡţ", a_));
				IL_290:
				throw new global::System.IO.DirectoryNotFoundException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("笳䌵䰷䨹䤻䨽怿فⵃ㑅ⵇ⥉㡋⅍≏⭑湓癕", a_) + outputDirectory + global::ACPVoiceAnnouncementLib.WaveFileReader.f("ᐳ堵圷丹᰻堽⼿㝁⩃≅", a_));
				IL_2D0:
				throw new global::System.ArgumentException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("稳夵ᠷ䰹医圽⌿❁摃≅⥇㹉ⵋ湍❏㝑♓㍕硗⥙㥛㉝՟šၣͥ౧䩩੫ŭɯ剱ၳ᥵ཷᑹၻᅽꪃ", a_), global::ACPVoiceAnnouncementLib.WaveFileReader.f("䈳夵儷夹夻稽ℿ㙁╃੅ⅇ㥉㡋", a_));
				IL_336:
				throw new global::System.InvalidOperationException(global::ACPVoiceAnnouncementLib.WaveFileReader.f("稳夵ᠷ椹䔻倽⌿⩁㙃⥅♇⍉㙋⽍⑏㭑㭓㡕硗ᥙ㍛そᑟݡᱣብ䡧Ⱪͫ᭭ṯᙱ", a_));
				IL_3CC:;
			}
			catch
			{
				global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a = null;
				throw;
			}
			num = (short)2119303168;
			short num4 = num;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003B68 File Offset: 0x00001D68
		public void CancelCompressAudioFilesInDirectory()
		{
			short num = (short)1094347027;
			short num2 = num;
			num = (short)1041328403;
			switch (num2 == num)
			{
			default:
			{
				num = (short)650772480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1274740736;
			if (num != 0)
			{
			}
			num = (short)1301610497;
			if (num != 0)
			{
			}
			this.c = true;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003C1C File Offset: 0x00001E1C
		private void e(object A_0)
		{
			int a_ = 3;
			short num = (short)83361792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a a;
				global::ACPVoiceAnnouncementLib.ACPInflateDeflateUtilities acpinflateDeflateUtilities;
				global::System.Collections.Generic.List<string> list;
				bool flag;
				bool flag2;
				int num4;
				bool flag3;
				for (;;)
				{
					IL_31:
					string text;
					string str;
					string str2;
					string text3;
					switch (num2)
					{
					case 0:
						if (!a.a.EndsWith(global::ACPVoiceAnnouncementLib.WaveFileReader.f("栳", a_)))
						{
							num = (short)754057221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)777322509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_858;
					case 2:
						if (a != null)
						{
							num = (short)292618243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_927;
					case 3:
						try
						{
							num = (short)1679360001;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									list = acpinflateDeflateUtilities.a(a.a, global::ACPVoiceAnnouncementLib.WaveFileReader.f("䌳圵丷", a_));
									num = (short)1780416514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_218;
									}
									continue;
								case 2:
									goto IL_2D9;
								case 3:
									goto IL_2F2;
								case 4:
								{
									num = (short)812858109;
									short num3 = num;
									num = (short)439827197;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_241;
									default:
										num = (short)879951872;
										if (num != 0)
										{
										}
										goto IL_2D9;
									}
									break;
								}
								}
								IL_218:
								if (a.d)
								{
									num = (short)1562836992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								list = a.c;
								IL_241:
								num = (short)452067332;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D9:
								num = (short)653983747;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F2:
							goto IL_7EC;
						}
						catch
						{
							flag = true;
							goto IL_7EC;
						}
						goto IL_2FF;
					case 4:
						text = a.b;
						goto IL_2FF;
					case 5:
						num = (short)1419509770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)1062141956;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string text2;
								switch (num2)
								{
								case 0:
								{
									global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementPromptRequest acpvoiceAnnouncementPromptRequest = new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementPromptRequest(text2);
									global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a.Send(new global::System.Threading.SendOrPostCallback(this.b), acpvoiceAnnouncementPromptRequest);
									num = (short)439287814;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1133772819;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_678;
								case 3:
									flag2 = true;
									num = (short)147259408;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_4B5;
									}
									continue;
								case 5:
									num = (short)1709441044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementPromptRequest acpvoiceAnnouncementPromptRequest;
									if (acpvoiceAnnouncementPromptRequest.ActionToTake == global::ACPVoiceAnnouncementLib.ACPVoiceCompressPromptResponse.SKIP_FILE)
									{
										num = (short)328531971;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1258225672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									flag2 = true;
									num = (short)582680593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementPromptRequest acpvoiceAnnouncementPromptRequest;
									if (acpvoiceAnnouncementPromptRequest.ActionToTake == global::ACPVoiceAnnouncementLib.ACPVoiceCompressPromptResponse.OVERWRITE_ALL_FILES)
									{
										num = (short)960430089;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5A2;
								}
								case 9:
									this.h = global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions.OVERWRITE_ALL_FILES;
									num = (short)28901390;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (!this.c)
									{
										num = (short)1710817281;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7CC;
								case 11:
									goto IL_7E4;
								case 12:
								{
									if (!flag2)
									{
										num = (short)792199186;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes a_2 = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.OUTPUT_VOICE_FILE_ALREADY_EXISTS;
									num = (short)2143223810;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									goto IL_7CC;
								case 14:
									goto IL_5A2;
								case 15:
									goto IL_678;
								case 16:
									goto IL_5A2;
								case 17:
									goto IL_5A2;
								case 18:
								{
									global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes a_2 = this.DeflateFile(str + list[num4], str2 + text2);
									num = (short)1742209039;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
									if (flag3)
									{
										num = (short)130285590;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7CC;
								case 20:
									if (this.h == global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions.PROMPT_BEFORE_OVERWRITE)
									{
										num = (short)1549860864;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1981677589;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									if (this.h == global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions.SKIP_SAME_FILENAME)
									{
										num = (short)2071658503;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5A2;
								case 22:
								{
									global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes a_2;
									global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a.Send(new global::System.Threading.SendOrPostCallback(this.c), new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementProgress(str + list[num4], a_2, list.Count, num4 + 1));
									num = (short)2117271565;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_4B5:
								if (global::System.IO.File.Exists(str2 + text2))
								{
									num = (short)108199941;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5A2:
								num = (short)1957363724;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_678:
								num = (short)1039269898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7CC:
								num = (short)1315373067;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7E4:
							goto IL_1BC;
						}
						catch
						{
							goto IL_825;
						}
						goto IL_7EC;
					case 7:
						if (!this.c)
						{
							num = (short)1837432840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BC;
					case 8:
					{
						string text2 = global::System.IO.Path.GetFileNameWithoutExtension(list[num4]) + global::ACPVoiceAnnouncementLib.WaveFileReader.f("ᨳ嬵丷嬹", a_);
						num = (short)964231174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_825;
					case 10:
						text3 = a.a + global::ACPVoiceAnnouncementLib.WaveFileReader.f("栳", a_);
						goto IL_356;
					case 11:
						goto IL_925;
					case 12:
						if (!flag)
						{
							num = (short)915537934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a.Post(new global::System.Threading.SendOrPostCallback(this.a), new global::ACPVoiceAnnouncementLib.ACPVoiceAnnoucementCompleted());
						num = (short)1444806667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						text3 = a.a;
						goto IL_356;
					case 14:
						num = (short)1118371840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (!a.b.EndsWith(global::ACPVoiceAnnouncementLib.WaveFileReader.f("栳", a_)))
						{
							num = (short)839581715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1514536964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_85D;
					case 17:
						goto IL_85D;
					case 18:
						if (num4 >= list.Count)
						{
							num = (short)1258684425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = false;
						num = (short)1783169031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1861812225;
						if (num != 0)
						{
						}
						num = (short)1548353556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						text = a.b + global::ACPVoiceAnnouncementLib.WaveFileReader.f("栳", a_);
						goto IL_2FF;
					}
					goto IL_8C;
					IL_1BC:
					num4++;
					num = (short)943063056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FF:
					str2 = text;
					num4 = 0;
					num = (short)2027749393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_356:
					str = text3;
					num = (short)88801280;
					short num5 = num;
					num = (short)874446863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7EC:
					num = (short)1676804108;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_825:
					global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a.Post(new global::System.Threading.SendOrPostCallback(this.a), new global::ACPVoiceAnnouncementLib.ACPVoiceAnnoucementCompleted());
					num = (short)1579745281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_85D:
					num = (short)110886930;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_858:
				IL_925:
				IL_927:
				global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a = null;
				return;
				IL_8C:
				list = null;
				num4 = 0;
				flag = false;
				flag3 = false;
				flag2 = false;
				acpinflateDeflateUtilities = new global::ACPVoiceAnnouncementLib.ACPInflateDeflateUtilities();
				a = (A_0 as global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a);
				flag3 = (this.d != null);
				num = (short)759562242;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000458C File Offset: 0x0000278C
		private void d(object A_0)
		{
			int a_ = 8;
			short num = (short)168034304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				int num3;
				global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo> list;
				bool flag;
				global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.b b;
				bool flag2;
				bool flag3;
				for (;;)
				{
					IL_30:
					string text;
					string str;
					string text2;
					switch (num2)
					{
					case 0:
						goto IL_733;
					case 1:
						num = (short)231931910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (num3 >= list.Count)
						{
							num = (short)1176764420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1499398160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_7A7;
					case 4:
					{
						num = (short)1173684224;
						short num4 = num;
						goto IL_132;
					}
					case 5:
						text = b.a;
						goto IL_1FC;
					case 6:
					{
						if (!b.a.EndsWith(global::ACPVoiceAnnouncementLib.WaveFileReader.f("攸", a_)))
						{
							num = (short)432013327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1019844531;
						short num5 = num;
						num = (short)859543475;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_67E;
						default:
							num = (short)2117140480;
							if (num != 0)
							{
							}
							num = (short)2752517;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_612;
					case 8:
						try
						{
							num = (short)507445250;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4E5;
								case 1:
									flag = true;
									num = (short)864485385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2A0;
									}
									continue;
								case 3:
								{
									global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementPromptRequest acpvoiceAnnouncementPromptRequest;
									if (acpvoiceAnnouncementPromptRequest.ActionToTake == global::ACPVoiceAnnouncementLib.ACPVoiceCompressPromptResponse.SKIP_FILE)
									{
										num = (short)1327497217;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)12517388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_545;
								case 5:
									if (flag2)
									{
										num = (short)1005256719;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5B2;
								case 6:
									if (!this.c)
									{
										num = (short)1700134920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5B2;
								case 7:
									if (this.h == global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions.SKIP_SAME_FILENAME)
									{
										num = (short)589955082;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_545;
								case 8:
									num = (short)1489764357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_545;
								case 10:
									flag = true;
									num = (short)820576278;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									if (!flag)
									{
										num = (short)860094480;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes a_2 = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.OUTPUT_VOICE_FILE_ALREADY_EXISTS;
									num = (short)26476544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementPromptRequest acpvoiceAnnouncementPromptRequest;
									if (acpvoiceAnnouncementPromptRequest.ActionToTake == global::ACPVoiceAnnouncementLib.ACPVoiceCompressPromptResponse.OVERWRITE_ALL_FILES)
									{
										num = (short)1646919701;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_545;
								}
								case 13:
									if (this.h == global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions.PROMPT_BEFORE_OVERWRITE)
									{
										num = (short)1416232977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1238761479;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_4E5;
								case 15:
								{
									global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes a_2;
									global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a.Send(new global::System.Threading.SendOrPostCallback(this.c), new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementProgress(list[num3].FileName, a_2, list.Count, num3 + 1));
									num = (short)767164434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
								{
									global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes a_2 = this.DeflateFile(list[num3], str + text2);
									num = (short)434307086;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementPromptRequest acpvoiceAnnouncementPromptRequest = new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementPromptRequest(text2);
									global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a.Send(new global::System.Threading.SendOrPostCallback(this.b), acpvoiceAnnouncementPromptRequest);
									num = (short)371720195;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
									goto IL_5B2;
								case 19:
									goto IL_5CA;
								case 20:
									num = (short)312016909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									this.h = global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions.OVERWRITE_ALL_FILES;
									num = (short)605093892;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									goto IL_545;
								}
								IL_2A0:
								if (global::System.IO.File.Exists(str + text2))
								{
									num = (short)158007316;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_545;
								IL_4E5:
								num = (short)332529670;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_545:
								num = (short)1866465291;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5B2:
								num = (short)1088290835;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5CA:
							goto IL_16B;
						}
						catch
						{
							goto IL_132;
						}
						goto IL_5D5;
					case 9:
						goto IL_166;
					case 10:
						try
						{
							list = b.b;
							goto IL_5D5;
						}
						catch
						{
							flag3 = true;
							goto IL_5D5;
						}
						goto IL_733;
					case 11:
						goto IL_612;
					case 12:
						if (!flag3)
						{
							num = (short)700448769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a.Post(new global::System.Threading.SendOrPostCallback(this.a), new global::ACPVoiceAnnouncementLib.ACPVoiceAnnoucementCompleted());
						num = (short)2048327683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						text = b.a + global::ACPVoiceAnnouncementLib.WaveFileReader.f("攸", a_);
						goto IL_1FC;
					case 14:
						if (b != null)
						{
							num = (short)797835274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A9;
					case 15:
						goto IL_67E;
					case 16:
						num = (short)1060765697;
						if (num != 0)
						{
						}
						if (!this.c)
						{
							num = (short)1375272960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16B;
					}
					goto IL_7B;
					IL_132:
					global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a.Post(new global::System.Threading.SendOrPostCallback(this.a), new global::ACPVoiceAnnouncementLib.ACPVoiceAnnoucementCompleted());
					num = (short)1218314249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16B:
					num3++;
					num = (short)2029191175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FC:
					str = text;
					num3 = 0;
					num = (short)788791307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D5:
					num = (short)2017853452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_612:
					num = (short)677511170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_67E:
					num = (short)673185805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_733:
					text2 = list[num3].FileName + global::ACPVoiceAnnouncementLib.WaveFileReader.f("᜸嘺䬼帾", a_);
					num = (short)257687560;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_166:
				IL_7A7:
				IL_7A9:
				global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.a = null;
				return;
				IL_7B:
				list = null;
				num3 = 0;
				flag3 = false;
				flag2 = false;
				flag = false;
				new global::ACPVoiceAnnouncementLib.ACPInflateDeflateUtilities();
				b = (A_0 as global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate.b);
				flag2 = (this.d != null);
				num = (short)512294926;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004D7C File Offset: 0x00002F7C
		private void c(object A_0)
		{
			short num = (short)1687234136;
			short num2 = num;
			num = (short)1472865880;
			switch (num2 == num)
			{
			}
			num = (short)1165295616;
			short num3 = num;
			num = (short)792068097;
			if (num != 0)
			{
			}
			num = (short)1198981120;
			if (num != 0)
			{
			}
			global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementProgress progress = A_0 as global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementProgress;
			this.d(progress);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004E38 File Offset: 0x00003038
		private void b(object A_0)
		{
			short num = (short)2034077380;
			short num2 = num;
			num = (short)1512148676;
			switch (num2 == num)
			{
			}
			num = (short)1405026304;
			short num3 = num;
			num = (short)1184825345;
			if (num != 0)
			{
			}
			num = (short)408158208;
			if (num != 0)
			{
			}
			global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementPromptRequest request = A_0 as global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementPromptRequest;
			this.f(request);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004EF8 File Offset: 0x000030F8
		private void a(object A_0)
		{
			short num = (short)1104276143;
			short num2 = num;
			num = (short)661842607;
			switch (num2 == num)
			{
			}
			num = (short)1114832896;
			short num3 = num;
			num = (short)1540423681;
			if (num != 0)
			{
			}
			num = (short)82640896;
			if (num != 0)
			{
			}
			global::ACPVoiceAnnouncementLib.ACPVoiceAnnoucementCompleted result = A_0 as global::ACPVoiceAnnouncementLib.ACPVoiceAnnoucementCompleted;
			this.e(result);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004FB4 File Offset: 0x000031B4
		internal int b()
		{
			short num = (short)186311797;
			short num2 = num;
			num = (short)1323689077;
			switch (num2 == num)
			{
			}
			num = (short)586612736;
			short num3 = num;
			num = (short)242089985;
			if (num != 0)
			{
			}
			num = (short)603324416;
			if (num != 0)
			{
			}
			return 1;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005060 File Offset: 0x00003260
		private int a()
		{
			short num = (short)951617565;
			short num2 = num;
			num = (short)717391901;
			switch (num2 == num)
			{
			}
			num = (short)724893696;
			short num3 = num;
			num = (short)791019520;
			if (num != 0)
			{
			}
			num = (short)1368391681;
			if (num != 0)
			{
			}
			return 1;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000510C File Offset: 0x0000330C
		public global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes DeflateFile(string inFileName, string outFileName)
		{
			int a_ = 16;
			short num = (short)2028011520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_61;
				}
				global::System.IO.FileInfo fileInfo;
				global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes acpinflateDeflateCodes;
				global::ACPVoiceAnnouncementLib.WaveFile waveFile;
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
						if (fileInfo.Extension.ToLower() == global::ACPVoiceAnnouncementLib.WaveFileReader.f("潀㑂⑄ㅆ", a_))
						{
							num = (short)512491523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_FORMAT_ERROR;
						num = (short)2143551489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_4B3;
					case 2:
						num = (short)1425145857;
						if (num != 0)
						{
						}
						if (acpinflateDeflateCodes == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.VOICE_FILE_CONVERT_SUCCESS)
						{
							num = (short)1006305288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58F;
					case 3:
					{
						int a_2 = 0;
						num = (short)956563460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (fileInfo.Exists)
						{
							num = (short)1755643910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_DOES_NOT_EXIST;
						num = (short)1727922181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_494;
					case 6:
						goto IL_50C;
					case 7:
						try
						{
							fileInfo = new global::System.IO.FileInfo(inFileName);
							goto IL_416;
						}
						catch
						{
							acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_ERROR;
							goto IL_416;
						}
						goto IL_50C;
					case 8:
					{
						byte[] array = null;
						byte[] array2 = null;
						global::ACPVoiceAnnouncementLib.AMR_COMPRESSION_MODES amr_COMPRESSION_MODES = global::ACPVoiceAnnouncementLib.AMR_COMPRESSION_MODES.MR102;
						num = (short)808386560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_E2;
							}
							for (;;)
							{
								IL_8B:
								byte[] array;
								switch (num2)
								{
								case 0:
									if (waveFile.format.dwSamplesPerSec == 8000U)
									{
										num = (short)1870659603;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29A;
								case 1:
								{
									byte[] array2 = new byte[array.Length];
									num = (short)1694433290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_3E0;
								case 3:
									if (waveFile.format.wChannels == 1)
									{
										num = (short)940376082;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29A;
								case 4:
									goto IL_275;
								case 5:
									goto IL_3E0;
								case 6:
									if (waveFile.format.dwBitsPerSample == 16U)
									{
										num = (short)882311177;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29A;
								case 7:
									goto IL_3F8;
								case 8:
									num = (short)1145569297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)2052128768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									int a_2;
									byte[] array2;
									global::ACPVoiceAnnouncementLib.AMR_COMPRESSION_MODES amr_COMPRESSION_MODES;
									if (this.b.deflate_memoryInterface((int)amr_COMPRESSION_MODES, array, array2, ref a_2) == 0)
									{
										num = (short)1897725963;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.CODEC_ERROR;
									num = (short)1205010437;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									try
									{
										int a_2;
										byte[] array2;
										global::ACPVoiceAnnouncementLib.AMR_COMPRESSION_MODES amr_COMPRESSION_MODES;
										global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass.a(outFileName, global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode.AMR, (int)amr_COMPRESSION_MODES, array2, a_2);
										goto IL_3E0;
									}
									catch (global::ACPVoiceAnnouncementLib.MotVoiceFileException)
									{
										acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.OUTPUT_FILE_ERROR;
										goto IL_3E0;
									}
									goto IL_3C4;
								case 12:
								{
									num = (short)1654366083;
									short num3 = num;
									num = (short)2203523;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_275;
									default:
										num = (short)1314652160;
										if (num != 0)
										{
										}
										if (waveFile.format.wFormatTag == 1)
										{
											num = (short)1990262792;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_29A;
									}
									break;
								}
								case 13:
									goto IL_3E0;
								case 14:
									num = (short)1709047823;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									if (array.Length != 0)
									{
										num = (short)1246101505;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3C4;
								case 16:
									array = waveFile.a();
									num = (short)98828292;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									if (waveFile.data.dSecLength <= 3.0)
									{
										num = (short)797966352;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29A;
								case 18:
									num = (short)1158807564;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									num = (short)393281539;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_E2;
								IL_275:
								if (array != null)
								{
									num = (short)1707409422;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3C4;
								IL_29A:
								acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_FORMAT_ERROR;
								num = (short)882769922;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3C4:
								acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_SIZE_ERROR;
								num = (short)913899533;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3E0:
								num = (short)2004877319;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3F8:
							goto IL_58F;
							IL_E2:
							waveFile.a(inFileName);
							num = (short)470220806;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_8B;
						}
						catch (global::ACPVoiceAnnouncementLib.WaveFileException)
						{
							acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_FORMAT_ERROR;
							goto IL_58F;
						}
						catch (global::System.UnauthorizedAccessException)
						{
							acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_ERROR;
							goto IL_58F;
						}
						catch
						{
							acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.UNKOWN_ERROR;
							goto IL_58F;
						}
						goto IL_416;
					}
					goto IL_61;
					IL_416:
					num = (short)152961026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_50C:
					waveFile = new global::ACPVoiceAnnouncementLib.WaveFile();
					num = (short)539754505;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_494:
				IL_4B3:
				IL_58F:
				num = (short)137232384;
				short num4 = num;
				return acpinflateDeflateCodes;
				IL_61:
				acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.VOICE_FILE_CONVERT_SUCCESS;
				waveFile = null;
				fileInfo = null;
				num = (short)392232967;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005750 File Offset: 0x00003950
		public global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes DeflateFile(global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo vaInfo, string outFileName)
		{
			global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes result;
			short num;
			for (;;)
			{
				result = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.VOICE_FILE_CONVERT_SUCCESS;
				try
				{
					global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass.a(outFileName, vaInfo.CompressionCode, vaInfo.CompressionParam, vaInfo.CompressedData, vaInfo.CompressedDataLength);
				}
				catch (global::ACPVoiceAnnouncementLib.MotVoiceFileException)
				{
					result = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.OUTPUT_FILE_ERROR;
				}
				num = (short)1560766921;
				short num2 = num;
				num = (short)358115785;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_8A;
				}
				break;
			}
			num = (short)750649344;
			short num3 = num;
			IL_8A:
			num = (short)1655570432;
			if (num != 0)
			{
			}
			num = (short)591855617;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005838 File Offset: 0x00003A38
		public global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes InflateFile(string inFileName, string outFileName)
		{
			int a_ = 2;
			short num = (short)81526784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::System.IO.FileInfo fileInfo;
				global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes acpinflateDeflateCodes;
				byte[] array;
				int a_2;
				global::ACPVoiceAnnouncementLib.IInflateDeflate inflateDeflate;
				global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass acpmotVoiceAnnouncementFileClass;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						try
						{
							fileInfo = new global::System.IO.FileInfo(inFileName);
							goto IL_3B1;
						}
						catch
						{
							acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_ERROR;
							goto IL_3B1;
						}
						goto Block_6;
					case 1:
						if (fileInfo.Exists)
						{
							num = (short)1309016071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_DOES_NOT_EXIST;
						num = (short)407240709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)1901920259;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::ACPVoiceAnnouncementLib.WaveFile waveFile;
								switch (num2)
								{
								case 0:
									num = (short)6357005;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!waveFile.a(array, a_2, outFileName))
									{
										num = (short)1869807624;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2F9;
								case 2:
									goto IL_38B;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_11C;
									}
									continue;
								case 4:
									try
									{
										num = (short)1114445263;
										short num3 = num;
										num = (short)218961359;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											IL_288:
											num = (short)1459224578;
											num2 = (int)((global::System.IntPtr)num);
											break;
										default:
											num = (short)147521536;
											if (num != 0)
											{
											}
											num = (short)1666449411;
											num2 = (int)((global::System.IntPtr)num);
											break;
										}
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_280;
											case 1:
												goto IL_2B5;
											case 2:
												goto IL_2A0;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_263;
												}
												continue;
											}
											IL_263:
											if (global::System.IO.File.Exists(outFileName))
											{
												num = (short)291766272;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_2A0:
											num = (short)1803288577;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_280:
										global::System.IO.File.Delete(outFileName);
										goto IL_288;
										IL_2B5:
										goto IL_2F9;
									}
									catch
									{
										goto IL_2F9;
									}
									goto IL_2BA;
								case 5:
									goto IL_38B;
								case 6:
									goto IL_38B;
								case 7:
									if (inflateDeflate.inflate_memoryInterface(acpmotVoiceAnnouncementFileClass.VoiceData, array, ref a_2) == 0)
									{
										num = (short)188809228;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.CODEC_ERROR;
									num = (short)1157300230;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.OUTPUT_FILE_ERROR;
									num = (short)723320836;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_38B;
								case 10:
									array = new byte[64000];
									num = (short)905904135;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_3A3;
								case 12:
									waveFile = new global::ACPVoiceAnnouncementLib.WaveFile();
									num = (short)1401421825;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (acpmotVoiceAnnouncementFileClass.CompressionType == global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode.AMR)
									{
										num = (short)1903820810;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_FORMAT_ERROR;
									num = (short)618070025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_11C:
								if (acpmotVoiceAnnouncementFileClass != null)
								{
									num = (short)1365377024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2BA:
								acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_ERROR;
								num = (short)1717305349;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2F9:
								waveFile.Dispose();
								num = (short)1795817474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_38B:
								num = (short)207224843;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3A3:
							return acpinflateDeflateCodes;
						}
						catch
						{
							return global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.UNKOWN_ERROR;
						}
						goto IL_3B1;
					case 3:
						if (acpinflateDeflateCodes == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.VOICE_FILE_CONVERT_SUCCESS)
						{
							num = (short)1412431874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return acpinflateDeflateCodes;
					case 4:
						num = (short)2102657025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return acpinflateDeflateCodes;
					case 6:
						return acpinflateDeflateCodes;
					case 7:
						num = (short)1714487297;
						if (num != 0)
						{
						}
						goto IL_4E7;
					case 8:
						goto IL_4FC;
					case 9:
						if (fileInfo.Extension.ToLower() == global::ACPVoiceAnnouncementLib.WaveFileReader.f("ᴲ場䄶堸", a_))
						{
							num = (short)91226116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_FORMAT_ERROR;
						num = (short)1688600582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (acpinflateDeflateCodes == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.VOICE_FILE_CONVERT_SUCCESS)
						{
							num = (short)550436872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return acpinflateDeflateCodes;
					}
					goto IL_63;
					IL_3B1:
					num = (short)650117130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					try
					{
						IL_4E7:
						acpmotVoiceAnnouncementFileClass = global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementFileClass.LoadFromFile(inFileName);
						goto IL_40C;
					}
					catch (global::ACPVoiceAnnouncementLib.MotVoiceFileException)
					{
						acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_ERROR;
						goto IL_40C;
					}
					goto IL_4FC;
					IL_40C:
					num = (short)630521859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4FC:
					num = (short)2080899081;
					num2 = (int)((global::System.IntPtr)num);
				}
				return acpinflateDeflateCodes;
				IL_63:
				num = (short)1920139264;
				short num4 = num;
				acpinflateDeflateCodes = global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.VOICE_FILE_CONVERT_SUCCESS;
				array = null;
				a_2 = 0;
				fileInfo = null;
				acpmotVoiceAnnouncementFileClass = null;
				inflateDeflate = global::ACPVoiceAnnouncementLib.a.a();
				num = (short)1374945280;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0400002D RID: 45
		private static global::System.Threading.SynchronizationContext a;

		// Token: 0x0400002E RID: 46
		private global::ACPVoiceAnnouncementLib.IInflateDeflate b;

		// Token: 0x0400002F RID: 47
		private bool c;

		// Token: 0x04000030 RID: 48
		private global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressProgress d;

		// Token: 0x04000031 RID: 49
		private global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressCompleted e;

		// Token: 0x04000032 RID: 50
		private global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementCompressAskUser f;

		// Token: 0x04000033 RID: 51
		private global::System.Threading.Thread g;

		// Token: 0x04000034 RID: 52
		private global::ACPVoiceAnnouncementLib.ACPVoiceCompressOverwriteOptions h;

		// Token: 0x04000035 RID: 53
		private const double i = 3.0;

		// Token: 0x02000012 RID: 18
		private class a
		{
			// Token: 0x0600003B RID: 59 RVA: 0x00005E00 File Offset: 0x00004000
			internal a(string A_0, string A_1)
			{
				this.d = true;
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x0600003C RID: 60 RVA: 0x00005E28 File Offset: 0x00004028
			internal a(string[] A_0, string A_1, string A_2)
			{
				this.d = false;
				this.a = A_1;
				this.b = A_2;
				if (A_0 != null && A_0.Length != 0)
				{
					this.c = A_0.ToList<string>();
				}
			}

			// Token: 0x04000036 RID: 54
			public string a;

			// Token: 0x04000037 RID: 55
			public string b;

			// Token: 0x04000038 RID: 56
			public global::System.Collections.Generic.List<string> c;

			// Token: 0x04000039 RID: 57
			public bool d;
		}

		// Token: 0x02000013 RID: 19
		private class b
		{
			// Token: 0x0600003D RID: 61 RVA: 0x00005E6C File Offset: 0x0000406C
			internal b(global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo> A_0, string A_1)
			{
				this.a = A_1;
				if (A_0 != null && A_0.Count > 0)
				{
					this.b = A_0;
				}
			}

			// Token: 0x0400003A RID: 58
			public string a;

			// Token: 0x0400003B RID: 59
			public global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo> b;
		}
	}
}
