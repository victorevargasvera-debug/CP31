using System;
using System.Collections.Generic;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;

namespace TTSBridge
{
	// Token: 0x0200000B RID: 11
	public class Vocalizer : global::System.IDisposable
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00002881 File Offset: 0x00000A81
		private Vocalizer()
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002894 File Offset: 0x00000A94
		private Vocalizer(global::System.IO.DirectoryInfo languagePath, string voiceName, global::TTSBridge.IAudioFormat format, global::System.IO.DirectoryInfo tempDirectory, ushort volume)
		{
			this.mFormat = format;
			this.mTempDirectory = tempDirectory;
			this.install.fmtVersion = 1312;
			this.stResources.fmtVersion = 512;
			this.stResources.u16NbrOfDataInstall = 1;
			this.stResources.apDataInstall = global::System.Runtime.InteropServices.Marshal.AllocCoTaskMem(global::System.IntPtr.Size);
			this.languagePathPtr = global::System.Runtime.InteropServices.Marshal.StringToCoTaskMemUni(languagePath.FullName);
			this.stResources.apDataInstall = global::System.Runtime.InteropServices.Marshal.StringToCoTaskMemUni(languagePath.FullName);
			global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::System.IntPtr>(this.languagePathPtr, this.stResources.apDataInstall, false);
			uint num = global::TTSBridge.TTSFunctions.vplatform_GetInterfaces(ref this.install, ref this.stResources);
			if (num != 0U)
			{
				throw new global::TTSBridge.VocalizerException("Could not setup platform interfaces", num);
			}
			num = global::TTSBridge.TTSFunctions.ve_ttsInitialize(ref this.install, ref this.speech);
			if (num != 0U)
			{
				throw new global::TTSBridge.VocalizerException("Could not initialize TTS", num);
			}
			num = global::TTSBridge.TTSFunctions.ve_ttsOpen(this.speech, this.install.hHeap, this.install.hLog, ref this.ttsInstance);
			if (num != 0U)
			{
				throw new global::TTSBridge.VocalizerException("Could not start TTS", num);
			}
			global::TTSBridge.TTSFunctions.VE_PARAM[] array = new global::TTSBridge.TTSFunctions.VE_PARAM[3];
			array[0].eID = global::TTSBridge.TTSFunctions.VE_PARAMID.VE_PARAM_VOICE;
			array[0].uValue.usValue = 0;
			array[0].uValue.szStringValue = voiceName;
			array[1].eID = global::TTSBridge.TTSFunctions.VE_PARAMID.VE_PARAM_TYPE_OF_CHAR;
			array[1].uValue.usValue = 1;
			array[2].eID = global::TTSBridge.TTSFunctions.VE_PARAMID.VE_PARAM_VOLUME;
			array[2].uValue.usValue = volume;
			num = global::TTSBridge.TTSFunctions.ve_hardcodeParams(this.ttsInstance, array, (ushort)array.Length);
			if (num != 0U)
			{
				throw new global::TTSBridge.VocalizerException("Failed to set TTS parameters", num);
			}
			this.info.pUserData = new global::System.IntPtr(0);
			this.info.pfOutNotify = new global::TTSBridge.TTSFunctions.CallbackOutNotify(this.PCMNotify);
			num = global::TTSBridge.TTSFunctions.ve_ttsSetOutDevice(this.ttsInstance, ref this.info);
			if (num != 0U)
			{
				throw new global::TTSBridge.VocalizerException("Failed to configure output device", num);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002A9C File Offset: 0x00000C9C
		public void play(string synthesize)
		{
			global::TTSBridge.IAudioFormat audioFormat = this.mFormat;
			this.mFormat = new global::TTSBridge.WaveFormat(global::TTSBridge.Vocalizer.DEFAULT_SAMPLING_RATE, 10);
			string text = global::System.IO.Path.Combine(this.mTempDirectory.FullName, "tmp.wav");
			this.saveToFile(synthesize, text);
			new global::System.Media.SoundPlayer(text).Play();
			this.mFormat = audioFormat;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002AF4 File Offset: 0x00000CF4
		public byte[] saveToBuffer(string synthesize)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			this.outputFile = this.mFormat.createAudioWriter(memoryStream);
			this.performTTS(synthesize);
			return memoryStream.ToArray();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002B26 File Offset: 0x00000D26
		public void saveToFile(string synthesize, string fileName)
		{
			this.outputFile = this.mFormat.createAudioWriter(fileName);
			this.performTTS(synthesize);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002B44 File Offset: 0x00000D44
		private void performTTS(string synthesize)
		{
			global::TTSBridge.TTSFunctions.VE_INTEXT ve_INTEXT = default(global::TTSBridge.TTSFunctions.VE_INTEXT);
			ve_INTEXT.szInText = global::System.Runtime.InteropServices.Marshal.StringToCoTaskMemUni(synthesize);
			ve_INTEXT.eTextFormat = global::TTSBridge.TTSFunctions.VE_TEXTFORMAT.VE_NORM_TEXT;
			ve_INTEXT.cntTextLength = new global::System.UIntPtr((uint)(synthesize.Length * 2));
			global::TTSBridge.TTSFunctions.ve_ttsProcessText2Speech(this.ttsInstance, ref ve_INTEXT);
			global::System.Runtime.InteropServices.Marshal.FreeCoTaskMem(ve_INTEXT.szInText);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002B9C File Offset: 0x00000D9C
		private uint PCMNotify(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst, global::System.IntPtr pUserData, ref global::TTSBridge.TTSFunctions.VE_CALLBACKMSG pcbMessage)
		{
			global::TTSBridge.TTSFunctions.VE_MSG eMessage = pcbMessage.eMessage;
			if (eMessage <= global::TTSBridge.TTSFunctions.VE_MSG.VE_MSG_ENDPROCESS)
			{
				if (eMessage != global::TTSBridge.TTSFunctions.VE_MSG.VE_MSG_BEGINPROCESS)
				{
					if (eMessage == global::TTSBridge.TTSFunctions.VE_MSG.VE_MSG_ENDPROCESS)
					{
						global::System.Runtime.InteropServices.Marshal.FreeCoTaskMem(this.pcmBufferPtr);
						this.pcmBufferPtr = global::System.IntPtr.Zero;
						this.mResampler.Dispose();
						this.outputFile.finish();
					}
				}
				else
				{
					this.mResampler = new global::TTSBridge.Resampler(global::TTSBridge.Vocalizer.DEFAULT_SAMPLING_RATE, this.mFormat.getSampleRate(), this.mFormat.getSampleQuality(), this.mFormat.getSampleSize());
					this.pcmBufferPtr = global::System.Runtime.InteropServices.Marshal.AllocCoTaskMem((int)(this.mFormat.getSampleSize() * 2U));
				}
			}
			else if (eMessage != global::TTSBridge.TTSFunctions.VE_MSG.VE_MSG_OUTBUFREQ)
			{
				if (eMessage == global::TTSBridge.TTSFunctions.VE_MSG.VE_MSG_OUTBUFDONE)
				{
					global::TTSBridge.TTSFunctions.VE_OUTDATA ve_OUTDATA = global::System.Runtime.InteropServices.Marshal.PtrToStructure<global::TTSBridge.TTSFunctions.VE_OUTDATA>(pcbMessage.pParam);
					global::TTSBridge.Resampler.ResampledBuffer resampledBuffer = this.mResampler.writeSample(this.pcmBufferPtr, ve_OUTDATA.cntPcmBufLen.ToUInt32() / 2U);
					this.outputFile.writePCMChunk(resampledBuffer.buffer, 0, (int)resampledBuffer.size);
				}
			}
			else
			{
				global::TTSBridge.TTSFunctions.VE_OUTDATA structure = global::System.Runtime.InteropServices.Marshal.PtrToStructure<global::TTSBridge.TTSFunctions.VE_OUTDATA>(pcbMessage.pParam);
				structure.cntPcmBufLen = new global::System.UIntPtr(this.mFormat.getSampleSize() * 2U);
				structure.pOutPcmBuf = this.pcmBufferPtr;
				global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::TTSBridge.TTSFunctions.VE_OUTDATA>(structure, pcbMessage.pParam, true);
			}
			return 0U;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002CD7 File Offset: 0x00000ED7
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002CE8 File Offset: 0x00000EE8
		protected virtual void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				global::TTSBridge.TTSFunctions.ve_ttsClose(this.ttsInstance);
				global::TTSBridge.TTSFunctions.ve_ttsUnInitialize(this.speech);
				global::TTSBridge.TTSFunctions.vplatform_CleanupInterfaces(ref this.install);
				if (this.pcmBufferPtr != global::System.IntPtr.Zero)
				{
					global::System.Runtime.InteropServices.Marshal.FreeCoTaskMem(this.pcmBufferPtr);
					this.pcmBufferPtr = global::System.IntPtr.Zero;
				}
				global::System.Runtime.InteropServices.Marshal.FreeCoTaskMem(this.languagePathPtr);
				global::System.Runtime.InteropServices.Marshal.FreeCoTaskMem(this.stResources.apDataInstall);
				this.isDisposed = true;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002D6C File Offset: 0x00000F6C
		~Vocalizer()
		{
			this.Dispose(false);
		}

		// Token: 0x04000015 RID: 21
		private static uint DEFAULT_SAMPLING_RATE = 22000U;

		// Token: 0x04000016 RID: 22
		private global::TTSBridge.TTSFunctions.VE_INSTALL install;

		// Token: 0x04000017 RID: 23
		private global::TTSBridge.TTSFunctions.VE_HSPEECH speech;

		// Token: 0x04000018 RID: 24
		private global::TTSBridge.TTSFunctions.VE_HSAFE ttsInstance;

		// Token: 0x04000019 RID: 25
		private global::TTSBridge.TTSFunctions.VPLATFORM_RESOURCES stResources;

		// Token: 0x0400001A RID: 26
		private global::TTSBridge.TTSFunctions.VE_OUTDEVINFO info;

		// Token: 0x0400001B RID: 27
		private global::System.IntPtr languagePathPtr;

		// Token: 0x0400001C RID: 28
		private global::System.IntPtr pcmBufferPtr = global::System.IntPtr.Zero;

		// Token: 0x0400001D RID: 29
		private global::TTSBridge.IAudioWriter outputFile;

		// Token: 0x0400001E RID: 30
		private global::TTSBridge.Resampler mResampler;

		// Token: 0x0400001F RID: 31
		private global::TTSBridge.IAudioFormat mFormat;

		// Token: 0x04000020 RID: 32
		private global::System.IO.DirectoryInfo mTempDirectory;

		// Token: 0x04000021 RID: 33
		private bool isDisposed;

		// Token: 0x04000022 RID: 34
		private static global::System.Collections.Generic.Dictionary<global::TTSBridge.Vocalizer.OUTPUT_FORMAT, uint> SAMPLE_MAP = new global::System.Collections.Generic.Dictionary<global::TTSBridge.Vocalizer.OUTPUT_FORMAT, uint>
		{
			{
				global::TTSBridge.Vocalizer.OUTPUT_FORMAT.WAV,
				2048U
			},
			{
				global::TTSBridge.Vocalizer.OUTPUT_FORMAT.AMRNB,
				440U
			}
		};

		// Token: 0x0200002A RID: 42
		public enum OUTPUT_FORMAT
		{
			// Token: 0x040000B3 RID: 179
			WAV,
			// Token: 0x040000B4 RID: 180
			AMRNB
		}

		// Token: 0x0200002B RID: 43
		public class Builder
		{
			// Token: 0x0600007D RID: 125 RVA: 0x00003032 File Offset: 0x00001232
			public global::TTSBridge.Vocalizer.Builder setTemporaryPlayDirectory(global::System.IO.DirectoryInfo tempDirectory)
			{
				this.mTempDirectory = tempDirectory;
				return this;
			}

			// Token: 0x0600007E RID: 126 RVA: 0x0000303C File Offset: 0x0000123C
			public global::TTSBridge.Vocalizer.Builder setVoice(string voiceName)
			{
				this.mVoiceName = voiceName;
				return this;
			}

			// Token: 0x0600007F RID: 127 RVA: 0x00003046 File Offset: 0x00001246
			public global::TTSBridge.Vocalizer.Builder setOuputFormat(global::TTSBridge.IAudioFormat format)
			{
				this.mFormat = format;
				return this;
			}

			// Token: 0x06000080 RID: 128 RVA: 0x00003050 File Offset: 0x00001250
			public global::TTSBridge.Vocalizer.Builder setVolumeLevel(ushort level)
			{
				if (level > 100 || level < 0)
				{
					throw new global::TTSBridge.VocalizerException("Invalid volume level, must be a value between 0 - 100");
				}
				this.mVolume = level;
				return this;
			}

			// Token: 0x06000081 RID: 129 RVA: 0x0000306E File Offset: 0x0000126E
			public global::TTSBridge.Vocalizer build(global::System.IO.DirectoryInfo vocalizerData)
			{
				return new global::TTSBridge.Vocalizer(vocalizerData, this.mVoiceName, this.mFormat, this.mTempDirectory, this.mVolume);
			}

			// Token: 0x040000B5 RID: 181
			private string mVoiceName = "samantha";

			// Token: 0x040000B6 RID: 182
			private global::TTSBridge.IAudioFormat mFormat = new global::TTSBridge.WaveFormat(global::TTSBridge.Vocalizer.DEFAULT_SAMPLING_RATE, 10);

			// Token: 0x040000B7 RID: 183
			private global::System.IO.DirectoryInfo mTempDirectory = new global::System.IO.DirectoryInfo(global::System.IO.Directory.GetCurrentDirectory());

			// Token: 0x040000B8 RID: 184
			private ushort mVolume = 80;
		}
	}
}
