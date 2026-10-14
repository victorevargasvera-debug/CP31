using System;
using System.Runtime.InteropServices;

namespace TTSBridge
{
	// Token: 0x02000009 RID: 9
	internal class Resampler : global::System.IDisposable
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002518 File Offset: 0x00000718
		public Resampler(uint freqIn, uint freqOut, int quality, uint sampleSize)
		{
			this.mFreqIn = freqIn;
			this.mFreqOut = freqOut;
			if (freqIn != freqOut)
			{
				int num;
				this.mSpeexResampler = global::TTSBridge.TTSFunctions.spx_resamplerInit(1U, freqIn, freqOut, quality, out num);
			}
			this.mResampledBuffer = new short[(int)global::System.Math.Ceiling(freqOut * sampleSize / freqIn)];
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002574 File Offset: 0x00000774
		public global::TTSBridge.Resampler.ResampledBuffer writeSample(global::System.IntPtr shortSamplePtr, uint samples)
		{
			uint num = samples;
			uint size = (uint)this.mResampledBuffer.Length;
			if (this.mFreqIn != this.mFreqOut)
			{
				global::TTSBridge.TTSFunctions.spx_resamplerWriteIntSample(this.mSpeexResampler, 0U, shortSamplePtr, ref num, this.mResampledBuffer, ref size);
			}
			else
			{
				global::System.Runtime.InteropServices.Marshal.Copy(shortSamplePtr, this.mResampledBuffer, 0, (int)samples);
			}
			return new global::TTSBridge.Resampler.ResampledBuffer
			{
				buffer = this.mResampledBuffer,
				size = size
			};
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000025E0 File Offset: 0x000007E0
		~Resampler()
		{
			this.Dispose();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000260C File Offset: 0x0000080C
		public void Dispose()
		{
			if (!this.disposedValue)
			{
				if (this.mSpeexResampler != global::System.IntPtr.Zero)
				{
					global::TTSBridge.TTSFunctions.spx_resamplerDestroy(this.mSpeexResampler);
				}
				this.mResampledBuffer = null;
				this.disposedValue = true;
			}
		}

		// Token: 0x0400000E RID: 14
		private global::System.IntPtr mSpeexResampler = global::System.IntPtr.Zero;

		// Token: 0x0400000F RID: 15
		private short[] mResampledBuffer;

		// Token: 0x04000010 RID: 16
		private uint mFreqIn;

		// Token: 0x04000011 RID: 17
		private uint mFreqOut;

		// Token: 0x04000012 RID: 18
		private bool disposedValue;

		// Token: 0x02000012 RID: 18
		public struct ResampledBuffer
		{
			// Token: 0x0400003A RID: 58
			public short[] buffer;

			// Token: 0x0400003B RID: 59
			public uint size;
		}
	}
}
