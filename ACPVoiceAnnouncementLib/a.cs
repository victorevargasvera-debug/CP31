using System;
using ACPVoiceCompressionLibWrapper;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x02000003 RID: 3
	internal sealed class a
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		internal static global::ACPVoiceAnnouncementLib.IInflateDeflate a()
		{
			short num = (short)1066770368;
			short num2 = num;
			num = (short)1169661888;
			switch (num2 == num)
			{
			}
			num = (short)1496842241;
			if (num != 0)
			{
			}
			num = (short)1196752896;
			if (num != 0)
			{
			}
			num = (short)1698889728;
			short num3 = num;
			return new global::ACPVoiceAnnouncementLib.a.a();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		private a()
		{
		}

		// Token: 0x02000006 RID: 6
		private sealed class a : global::ACPVoiceAnnouncementLib.IInflateDeflate, global::System.IDisposable
		{
			// Token: 0x0600000A RID: 10 RVA: 0x000021E0 File Offset: 0x000003E0
			public int deflate_fileInterface(int mode, string speech_file, string bitstream_file)
			{
				short num = (short)1796743428;
				short num2 = num;
				num = (short)16589060;
				switch (num2 == num)
				{
				}
				num = (short)1292697601;
				if (num != 0)
				{
				}
				num = (short)1134821376;
				if (num != 0)
				{
				}
				num = (short)993329152;
				short num3 = num;
				return global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.DeflateMain_FileInterface(mode, speech_file, bitstream_file);
			}

			// Token: 0x0600000B RID: 11 RVA: 0x00002290 File Offset: 0x00000490
			public int deflate_memoryInterface(int mode, byte[] speech_stream, byte[] bitstream_stream, ref int bitstream_length)
			{
				short num = (short)2090182975;
				short num2 = num;
				num = (short)291547455;
				switch (num2 == num)
				{
				}
				num = (short)1346174977;
				if (num != 0)
				{
				}
				num = (short)1552875520;
				if (num != 0)
				{
				}
				num = (short)1690763264;
				short num3 = num;
				return global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.DeflateMain_MemoryInterface(mode, speech_stream, bitstream_stream, ref bitstream_length);
			}

			// Token: 0x0600000C RID: 12 RVA: 0x00002344 File Offset: 0x00000544
			public int inflate_fileInterface(string bitstream_file, string speech_file)
			{
				short num = (short)117889493;
				short num2 = num;
				num = (short)597809621;
				switch (num2 == num)
				{
				}
				num = (short)27852801;
				if (num != 0)
				{
				}
				num = (short)1524891648;
				if (num != 0)
				{
				}
				num = (short)1144651776;
				short num3 = num;
				return global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.InflateMain_FileInterface(bitstream_file, speech_file);
			}

			// Token: 0x0600000D RID: 13 RVA: 0x000023F4 File Offset: 0x000005F4
			public int inflate_memoryInterface(byte[] bitstream_stream, byte[] speech_stream, ref int speech_stream_length)
			{
				short num = (short)1698859896;
				short num2 = num;
				num = (short)1180601208;
				switch (num2 == num)
				{
				}
				num = (short)540082176;
				if (num != 0)
				{
				}
				num = (short)43581441;
				if (num != 0)
				{
				}
				num = (short)852623360;
				short num3 = num;
				return global::ACPVoiceCompressionLibWrapper.ACPVoiceCompression.InflateMain_MemoryInterface(bitstream_stream, speech_stream, ref speech_stream_length);
			}

			// Token: 0x0600000E RID: 14 RVA: 0x000024A4 File Offset: 0x000006A4
			private void a(bool A_0)
			{
				short num = (short)1755447297;
				if (num != 0)
				{
				}
				num = (short)404357121;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_56;
						}
						continue;
					case 2:
					{
						this.a = true;
						num = (short)1305166084;
						short num3 = num;
						num = (short)53952772;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)198967296;
							if (num != 0)
							{
							}
							num = (short)1673592832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_56:
					if (this.a)
					{
						break;
					}
					num = (short)1491664896;
					short num4 = num;
					num = (short)1599078402;
					num2 = (int)((global::System.IntPtr)num);
				}
			}

			// Token: 0x0600000F RID: 15 RVA: 0x000025C4 File Offset: 0x000007C4
			public void Dispose()
			{
				short num = (short)573285617;
				short num2 = num;
				num = (short)264479985;
				switch (num2 == num)
				{
				}
				num = (short)1165295617;
				if (num != 0)
				{
				}
				num = (short)1599209472;
				if (num != 0)
				{
				}
				num = (short)1042284544;
				short num3 = num;
				this.a(true);
				global::System.GC.SuppressFinalize(this);
			}

			// Token: 0x06000010 RID: 16 RVA: 0x00002678 File Offset: 0x00000878
			protected override void Finalize()
			{
				short num;
				try
				{
					num = (short)367021633;
					short num2 = num;
					num = (short)792153665;
					switch (num2 == num)
					{
					}
					num = (short)222953472;
					if (num != 0)
					{
					}
					this.a(false);
				}
				finally
				{
					base.Finalize();
				}
				num = (short)441122816;
				short num3 = num;
				num = (short)2109997057;
				if (num != 0)
				{
				}
			}

			// Token: 0x0400000D RID: 13
			private bool a;
		}
	}
}
