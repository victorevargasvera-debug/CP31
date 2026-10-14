using System;
using System.IO;

namespace TTSBridge
{
	// Token: 0x0200000E RID: 14
	public class WaveStreamWriter : global::System.IDisposable, global::TTSBridge.IAudioWriter
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00002E3A File Offset: 0x0000103A
		public WaveStreamWriter(uint sampleRate, byte numChannels, byte bitSize, string outputFile)
		{
			this.stream = new global::System.IO.FileStream(outputFile, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write);
			this.initializeHeader(sampleRate, numChannels, bitSize);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002E5A File Offset: 0x0000105A
		public WaveStreamWriter(uint sampleRate, byte numChannels, byte bitSize, global::System.IO.MemoryStream stream)
		{
			this.stream = stream;
			this.initializeHeader(sampleRate, numChannels, bitSize);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002E74 File Offset: 0x00001074
		private void initializeHeader(uint sampleRate, byte numChannels, byte bitSize)
		{
			this.stream.Write(global::TTSBridge.WaveStreamWriter.WAV_HEADER, 0, global::TTSBridge.WaveStreamWriter.WAV_HEADER.Length);
			this.stream.Write(global::System.BitConverter.GetBytes(sampleRate), 0, 4);
			this.stream.Write(global::System.BitConverter.GetBytes(sampleRate * (uint)numChannels * (uint)bitSize / 8U), 0, 4);
			this.stream.Write(global::System.BitConverter.GetBytes((ushort)(numChannels * bitSize / 8)), 0, 2);
			this.stream.Write(global::System.BitConverter.GetBytes((ushort)bitSize), 0, 2);
			this.stream.Write(global::TTSBridge.WaveStreamWriter.WAV_DATA, 0, 4);
			this.stream.Write(global::System.BitConverter.GetBytes(0U), 0, 4);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002F15 File Offset: 0x00001115
		public void writePCMChunk(byte[] buffer, int offset, int size)
		{
			this.bufferSize += (uint)size;
			this.stream.Write(buffer, offset, size);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002F34 File Offset: 0x00001134
		public void writePCMChunk(short[] buffer, int offset, int size)
		{
			this.bufferSize += (uint)(size * 2);
			byte[] array = new byte[size * 2];
			int count = array.Length - offset * 2;
			global::System.Buffer.BlockCopy(buffer, offset, array, 0, count);
			this.stream.Write(array, offset, count);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002F7C File Offset: 0x0000117C
		public void finish()
		{
			if (!this.streamFinished)
			{
				this.stream.Seek(4L, global::System.IO.SeekOrigin.Begin);
				this.stream.Write(global::System.BitConverter.GetBytes(36U + this.bufferSize), 0, 4);
				this.stream.Seek(40L, global::System.IO.SeekOrigin.Begin);
				this.stream.Write(global::System.BitConverter.GetBytes(this.bufferSize), 0, 4);
				this.stream.Close();
				this.streamFinished = true;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002FF5 File Offset: 0x000011F5
		public void Dispose()
		{
			this.finish();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000026 RID: 38
		private global::System.IO.Stream stream;

		// Token: 0x04000027 RID: 39
		private uint bufferSize;

		// Token: 0x04000028 RID: 40
		private bool streamFinished;

		// Token: 0x04000029 RID: 41
		private static byte[] WAV_HEADER = new byte[]
		{
			82,
			73,
			70,
			70,
			0,
			0,
			0,
			0,
			87,
			65,
			86,
			69,
			102,
			109,
			116,
			32,
			16,
			0,
			0,
			0,
			1,
			0,
			1,
			0
		};

		// Token: 0x0400002A RID: 42
		private static byte[] WAV_DATA = new byte[]
		{
			100,
			97,
			116,
			97
		};
	}
}
