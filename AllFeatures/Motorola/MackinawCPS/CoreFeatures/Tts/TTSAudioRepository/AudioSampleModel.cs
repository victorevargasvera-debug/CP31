using System;
using System.Runtime.CompilerServices;

namespace Motorola.MackinawCPS.CoreFeatures.Tts.TTSAudioRepository
{
	// Token: 0x02000052 RID: 82
	public class AudioSampleModel
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0004AAC8 File Offset: 0x00048CC8
		public string Tts
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2013021882;
				short num2 = num;
				num = (short)226510522;
				switch (num2 == num)
				{
				}
				num = (short)1674903553;
				if (num != 0)
				{
				}
				num = (short)293208064;
				short num3 = num;
				num = (short)1259012096;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0004AB78 File Offset: 0x00048D78
		public string Speaker
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)308214206;
				short num2 = num;
				num = (short)1556412862;
				switch (num2 == num)
				{
				}
				num = (short)1409875969;
				if (num != 0)
				{
				}
				num = (short)1702625280;
				short num3 = num;
				num = (short)772341760;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0004AC28 File Offset: 0x00048E28
		public byte[] AudioBuffer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1721032860;
				short num2 = num;
				num = (short)1308024988;
				switch (num2 == num)
				{
				}
				num = (short)990117889;
				if (num != 0)
				{
				}
				num = (short)1167523840;
				short num3 = num;
				num = (short)295501824;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0004ACD8 File Offset: 0x00048ED8
		public int AudioBufferLength
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1994292658;
				short num2 = num;
				num = (short)789544370;
				switch (num2 == num)
				{
				}
				num = (short)1598685185;
				if (num != 0)
				{
				}
				num = (short)731512832;
				short num3 = num;
				num = (short)666697728;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0004AD88 File Offset: 0x00048F88
		public AudioSampleModel(string speaker, string tts, byte[] audioBuffer, int audioBufferLength)
		{
			this.b = speaker;
			this.a = tts;
			this.c = audioBuffer;
			this.d = audioBufferLength;
		}

		// Token: 0x040001DA RID: 474
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string a;

		// Token: 0x040001DB RID: 475
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string b;

		// Token: 0x040001DC RID: 476
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly byte[] c;

		// Token: 0x040001DD RID: 477
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly int d;
	}
}
