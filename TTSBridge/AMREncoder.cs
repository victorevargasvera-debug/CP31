using System;

namespace TTSBridge
{
	// Token: 0x02000002 RID: 2
	internal class AMREncoder : global::System.IDisposable
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public void start()
		{
			if (!this.mIsStarted)
			{
				this.mAMRPtr = global::TTSBridge.TTSFunctions.amr_EncoderInit();
				if (this.mAMRPtr != global::System.IntPtr.Zero)
				{
					this.mIsStarted = true;
				}
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002080 File Offset: 0x00000280
		public global::TTSBridge.AMREncoder.Packet writeSample(short[] sample)
		{
			if (this.mEncodedBuf.Length > 160)
			{
				throw new global::System.Exception("Sample size larger than 160 samples!");
			}
			if (!this.mIsStarted)
			{
				throw new global::System.Exception("Encoder not started!");
			}
			return new global::TTSBridge.AMREncoder.Packet
			{
				buffer = this.mEncodedBuf,
				length = global::TTSBridge.TTSFunctions.amr_EncoderWriteSample(this.mAMRPtr, sample, this.mEncodedBuf)
			};
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E9 File Offset: 0x000002E9
		public void stop()
		{
			if (this.mIsStarted)
			{
				global::TTSBridge.TTSFunctions.amr_EncoderDestroy(this.mAMRPtr);
				this.mAMRPtr = global::System.IntPtr.Zero;
				this.mIsStarted = false;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002110 File Offset: 0x00000310
		public void Dispose()
		{
			this.stop();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002118 File Offset: 0x00000318
		~AMREncoder()
		{
			this.Dispose();
		}

		// Token: 0x04000001 RID: 1
		private bool mIsStarted;

		// Token: 0x04000002 RID: 2
		private global::System.IntPtr mAMRPtr = global::System.IntPtr.Zero;

		// Token: 0x04000003 RID: 3
		private byte[] mEncodedBuf = new byte[32];

		// Token: 0x02000010 RID: 16
		public struct Packet
		{
			// Token: 0x0400002E RID: 46
			public byte[] buffer;

			// Token: 0x0400002F RID: 47
			public int length;
		}
	}
}
