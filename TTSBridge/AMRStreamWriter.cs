using System;
using System.IO;
using System.Text;

namespace TTSBridge
{
	// Token: 0x02000004 RID: 4
	internal class AMRStreamWriter : global::System.IDisposable, global::TTSBridge.IAudioWriter
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000021A3 File Offset: 0x000003A3
		public AMRStreamWriter(string outputFile)
		{
			this.mStream = new global::System.IO.FileStream(outputFile, global::System.IO.FileMode.Create, global::System.IO.FileAccess.ReadWrite);
			this.start();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021BF File Offset: 0x000003BF
		public AMRStreamWriter(global::System.IO.MemoryStream stream)
		{
			this.mStream = stream;
			this.start();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021D4 File Offset: 0x000003D4
		protected virtual void start()
		{
			this.initializeHeader();
			this.mAMREncoder = new global::TTSBridge.AMREncoder();
			this.mAMREncoder.start();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000021F2 File Offset: 0x000003F2
		protected virtual void initializeHeader()
		{
			this.mStream.Write(global::TTSBridge.AMRStreamWriter.AMR_HEADER, 0, global::TTSBridge.AMRStreamWriter.AMR_HEADER.Length);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000220C File Offset: 0x0000040C
		public void writePCMChunk(short[] buffer, int offset, int size)
		{
			global::TTSBridge.AMREncoder.Packet packet = this.mAMREncoder.writeSample(buffer);
			this.mStream.Write(packet.buffer, 0, packet.length);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000223E File Offset: 0x0000043E
		public virtual void finish()
		{
			if (!this.mFinished)
			{
				this.mFinished = true;
				this.mAMREncoder.stop();
				this.mStream.Close();
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002268 File Offset: 0x00000468
		~AMRStreamWriter()
		{
			this.Dispose();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002294 File Offset: 0x00000494
		public void Dispose()
		{
			this.finish();
		}

		// Token: 0x04000005 RID: 5
		private static byte[] AMR_HEADER = global::System.Text.Encoding.UTF8.GetBytes("#!AMR\n");

		// Token: 0x04000006 RID: 6
		protected global::System.IO.Stream mStream;

		// Token: 0x04000007 RID: 7
		protected bool mFinished;

		// Token: 0x04000008 RID: 8
		private global::TTSBridge.AMREncoder mAMREncoder;
	}
}
