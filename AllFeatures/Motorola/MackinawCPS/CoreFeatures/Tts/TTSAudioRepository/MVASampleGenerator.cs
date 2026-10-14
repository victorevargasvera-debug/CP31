using System;
using System.IO;
using System.Reflection;
using AllFeatures;
using TTSBridge;

namespace Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository
{
	// Token: 0x02000055 RID: 85
	public class MVASampleGenerator : global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.ISampleGenerator<global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel>, global::System.IDisposable
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x0004ADB8 File Offset: 0x00048FB8
		public MVASampleGenerator(string speaker)
		{
			int a_ = 11;
			base..ctor();
			this.a = speaker;
			string directoryName = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location);
			if (directoryName == null)
			{
				throw new global::System.NullReferenceException(global::AllFeatures.CodeplugGuid.b("꣋ꟍꋏ럑럓ꋕ럗꣙ꗛﻝ郟菡郣軥죧菩鿫컭黯蟱飳髵", a_));
			}
			global::System.IO.DirectoryInfo vocalizerData = new global::System.IO.DirectoryInfo(global::System.IO.Path.Combine(directoryName, global::AllFeatures.CodeplugGuid.b("뿋뻍뗏럑럓뻕蓗뛙뷛냝蟟韡藣臥跧駩", a_)));
			global::TTSBridge.Vocalizer.Builder builder = new global::TTSBridge.Vocalizer.Builder().setVolumeLevel(60);
			global::TTSBridge.Vocalizer vocalizer;
			if (builder == null)
			{
				vocalizer = null;
			}
			else
			{
				global::TTSBridge.Vocalizer.Builder builder2 = builder.setOuputFormat(new global::TTSBridge.MVAFormat(10));
				if (builder2 == null)
				{
					vocalizer = null;
				}
				else
				{
					global::TTSBridge.Vocalizer.Builder builder3 = builder2.setVoice(speaker);
					vocalizer = ((builder3 != null) ? builder3.build(vocalizerData) : null);
				}
			}
			this.b = vocalizer;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0004AE64 File Offset: 0x00049064
		public global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel GenerateAudioSample(string tts)
		{
			int a_ = 1;
			short num = (short)2004090883;
			int num2 = (int)((global::System.IntPtr)num);
			byte[] array;
			for (;;)
			{
				num = (short)1987706880;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					if (array == null)
					{
						num = (short)2121072641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1300225787;
					short num4 = num;
					num = (short)193978107;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A6;
					default:
						goto IL_14A;
					}
					break;
				}
				case 1:
					goto IL_D7;
				case 2:
					goto IL_83;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				}
				IL_66:
				if (this.b == null)
				{
					num = (short)1856110594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				array = this.b.saveToBuffer(tts);
				IL_A6:
				num = (short)393216000;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_83:
			throw new global::System.NullReferenceException(global::AllFeatures.CodeplugGuid.b("鷁닃꧅ꯇꯉꃋꟍ꫏럑ꛓ뇗꧙ﳛ냝闟軡裣", a_));
			IL_D7:
			num = (short)1730740225;
			if (num != 0)
			{
			}
			throw new global::System.NullReferenceException(global::AllFeatures.CodeplugGuid.b("ꏁ뇃ꋅꇇꗉꟍꏏ뫓ꏕ듗뛙", a_));
			IL_14A:
			num = (short)2091581440;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository.AudioSampleModel(this.a, tts, array, array.Length);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0004AFE4 File Offset: 0x000491E4
		public void Dispose()
		{
			short num = (short)697064230;
			short num2 = num;
			num = (short)1285970726;
			switch (num2 == num)
			{
			}
			num = (short)249102337;
			if (num != 0)
			{
			}
			num = (short)1168900096;
			short num3 = num;
			num = (short)495124480;
			if (num != 0)
			{
			}
			global::TTSBridge.Vocalizer vocalizer = this.b;
			if (vocalizer == null)
			{
				return;
			}
			vocalizer.Dispose();
		}

		// Token: 0x040001DE RID: 478
		private readonly string a;

		// Token: 0x040001DF RID: 479
		private readonly global::TTSBridge.Vocalizer b;

		// Token: 0x040001E0 RID: 480
		private const string c = "speech\\languages";
	}
}
