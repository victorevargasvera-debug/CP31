using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace TTSBridge
{
	// Token: 0x0200000A RID: 10
	public static class TTSFunctions
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002641 File Offset: 0x00000841
		static TTSFunctions()
		{
			global::TTSBridge.TTSFunctions.AddEnvironmentPaths(new string[]
			{
				global::TTSBridge.TTSFunctions.GetPlatformSpecificDependencyPath()
			});
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002658 File Offset: 0x00000858
		private static string GetPlatformSpecificDependencyPath()
		{
			string str = global::System.Environment.Is64BitProcess ? "x64" : "x86";
			return global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location), "speech\\components\\" + str + "\\");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000026A0 File Offset: 0x000008A0
		private static void AddEnvironmentPaths(params string[] paths)
		{
			string[] second = new string[]
			{
				global::System.Environment.GetEnvironmentVariable("PATH") ?? string.Empty
			};
			string value = string.Join(global::System.IO.Path.PathSeparator.ToString(), paths.Concat(second).Distinct<string>());
			global::System.Environment.SetEnvironmentVariable("PATH", value);
		}

		// Token: 0x0600002D RID: 45
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern void printDebug();

		// Token: 0x0600002E RID: 46
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public static extern global::System.IntPtr getCallbackPtr();

		// Token: 0x0600002F RID: 47
		[global::System.Runtime.InteropServices.DllImport("vplatform.dll", EntryPoint = "vplatform_GetInterfaces")]
		private static extern uint vplatform64_GetInterfaces(ref global::TTSBridge.TTSFunctions.VE_INSTALL pInstall, ref global::TTSBridge.TTSFunctions.VPLATFORM_RESOURCES pResources);

		// Token: 0x06000030 RID: 48
		[global::System.Runtime.InteropServices.DllImport("vplatform.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "vplatform_GetInterfaces")]
		private static extern uint vplatform32_GetInterfaces(ref global::TTSBridge.TTSFunctions.VE_INSTALL pInstall, ref global::TTSBridge.TTSFunctions.VPLATFORM_RESOURCES pResources);

		// Token: 0x06000031 RID: 49 RVA: 0x000026F4 File Offset: 0x000008F4
		public static uint vplatform_GetInterfaces(ref global::TTSBridge.TTSFunctions.VE_INSTALL pInstall, ref global::TTSBridge.TTSFunctions.VPLATFORM_RESOURCES pResources)
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.vplatform64_GetInterfaces(ref pInstall, ref pResources);
			}
			return global::TTSBridge.TTSFunctions.vplatform32_GetInterfaces(ref pInstall, ref pResources);
		}

		// Token: 0x06000032 RID: 50
		[global::System.Runtime.InteropServices.DllImport("vplatform.dll", EntryPoint = "vplatform_ReleaseInterfaces")]
		private static extern uint vplatform64_ReleaseInterfaces(ref global::TTSBridge.TTSFunctions.VE_INSTALL pInstall);

		// Token: 0x06000033 RID: 51
		[global::System.Runtime.InteropServices.DllImport("vplatform.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "vplatform_ReleaseInterfaces")]
		private static extern uint vplatform32_ReleaseInterfaces(ref global::TTSBridge.TTSFunctions.VE_INSTALL pInstall);

		// Token: 0x06000034 RID: 52 RVA: 0x0000270D File Offset: 0x0000090D
		public static uint vplatform_ReleaseInterfaces(ref global::TTSBridge.TTSFunctions.VE_INSTALL pInstall)
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.vplatform64_ReleaseInterfaces(ref pInstall);
			}
			return global::TTSBridge.TTSFunctions.vplatform32_ReleaseInterfaces(ref pInstall);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002724 File Offset: 0x00000924
		public static uint vplatform_CleanupInterfaces(ref global::TTSBridge.TTSFunctions.VE_INSTALL pInstall)
		{
			return global::TTSBridge.TTSFunctions.vplatform_ReleaseInterfaces(ref pInstall);
		}

		// Token: 0x06000036 RID: 54
		[global::System.Runtime.InteropServices.DllImport("ve.dll", EntryPoint = "ve_ttsInitialize")]
		private static extern uint ve64_ttsInitialize(ref global::TTSBridge.TTSFunctions.VE_INSTALL pResources, ref global::TTSBridge.TTSFunctions.VE_HSPEECH phTtsCl);

		// Token: 0x06000037 RID: 55
		[global::System.Runtime.InteropServices.DllImport("ve.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ve_ttsInitialize")]
		private static extern uint ve32_ttsInitialize(ref global::TTSBridge.TTSFunctions.VE_INSTALL pResources, ref global::TTSBridge.TTSFunctions.VE_HSPEECH phTtsCl);

		// Token: 0x06000038 RID: 56 RVA: 0x0000272C File Offset: 0x0000092C
		public static uint ve_ttsInitialize(ref global::TTSBridge.TTSFunctions.VE_INSTALL pResources, ref global::TTSBridge.TTSFunctions.VE_HSPEECH phTtsCl)
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.ve64_ttsInitialize(ref pResources, ref phTtsCl);
			}
			return global::TTSBridge.TTSFunctions.ve32_ttsInitialize(ref pResources, ref phTtsCl);
		}

		// Token: 0x06000039 RID: 57
		[global::System.Runtime.InteropServices.DllImport("ve.dll", EntryPoint = "ve_ttsOpen")]
		private static extern uint ve64_ttsOpen(global::TTSBridge.TTSFunctions.VE_HSPEECH hTtsCl, global::System.IntPtr hHeap, global::System.IntPtr hLog, ref global::TTSBridge.TTSFunctions.VE_HSAFE phTtsInst);

		// Token: 0x0600003A RID: 58
		[global::System.Runtime.InteropServices.DllImport("ve.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ve_ttsOpen")]
		private static extern uint ve32_ttsOpen(global::TTSBridge.TTSFunctions.VE_HSPEECH hTtsCl, global::System.IntPtr hHeap, global::System.IntPtr hLog, ref global::TTSBridge.TTSFunctions.VE_HSAFE phTtsInst);

		// Token: 0x0600003B RID: 59 RVA: 0x00002745 File Offset: 0x00000945
		public static uint ve_ttsOpen(global::TTSBridge.TTSFunctions.VE_HSPEECH hTtsCl, global::System.IntPtr hHeap, global::System.IntPtr hLog, ref global::TTSBridge.TTSFunctions.VE_HSAFE phTtsInst)
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.ve64_ttsOpen(hTtsCl, hHeap, hLog, ref phTtsInst);
			}
			return global::TTSBridge.TTSFunctions.ve32_ttsOpen(hTtsCl, hHeap, hLog, ref phTtsInst);
		}

		// Token: 0x0600003C RID: 60
		[global::System.Runtime.InteropServices.DllImport("ve.dll", EntryPoint = "ve_ttsSetOutDevice")]
		private static extern uint ve64_ttsSetOutDevice(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst, ref global::TTSBridge.TTSFunctions.VE_OUTDEVINFO pOutDevInfo);

		// Token: 0x0600003D RID: 61
		[global::System.Runtime.InteropServices.DllImport("ve.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ve_ttsSetOutDevice")]
		private static extern uint ve32_ttsSetOutDevice(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst, ref global::TTSBridge.TTSFunctions.VE_OUTDEVINFO pOutDevInfo);

		// Token: 0x0600003E RID: 62 RVA: 0x00002762 File Offset: 0x00000962
		public static uint ve_ttsSetOutDevice(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst, ref global::TTSBridge.TTSFunctions.VE_OUTDEVINFO pOutDevInfo)
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.ve64_ttsSetOutDevice(hTtsInst, ref pOutDevInfo);
			}
			return global::TTSBridge.TTSFunctions.ve32_ttsSetOutDevice(hTtsInst, ref pOutDevInfo);
		}

		// Token: 0x0600003F RID: 63
		[global::System.Runtime.InteropServices.DllImport("ve.dll", EntryPoint = "ve_ttsProcessText2Speech")]
		private static extern uint ve64_ttsProcessText2Speech(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst, ref global::TTSBridge.TTSFunctions.VE_INTEXT pInText);

		// Token: 0x06000040 RID: 64
		[global::System.Runtime.InteropServices.DllImport("ve.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ve_ttsProcessText2Speech")]
		private static extern uint ve32_ttsProcessText2Speech(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst, ref global::TTSBridge.TTSFunctions.VE_INTEXT pInText);

		// Token: 0x06000041 RID: 65 RVA: 0x0000277B File Offset: 0x0000097B
		public static uint ve_ttsProcessText2Speech(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst, ref global::TTSBridge.TTSFunctions.VE_INTEXT pInText)
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.ve64_ttsProcessText2Speech(hTtsInst, ref pInText);
			}
			return global::TTSBridge.TTSFunctions.ve32_ttsProcessText2Speech(hTtsInst, ref pInText);
		}

		// Token: 0x06000042 RID: 66
		[global::System.Runtime.InteropServices.DllImport("ve.dll", EntryPoint = "ve_ttsClose")]
		private static extern uint ve64_ttsClose(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst);

		// Token: 0x06000043 RID: 67
		[global::System.Runtime.InteropServices.DllImport("ve.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ve_ttsClose")]
		private static extern uint ve32_ttsClose(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst);

		// Token: 0x06000044 RID: 68 RVA: 0x00002794 File Offset: 0x00000994
		public static uint ve_ttsClose(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst)
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.ve64_ttsClose(hTtsInst);
			}
			return global::TTSBridge.TTSFunctions.ve32_ttsClose(hTtsInst);
		}

		// Token: 0x06000045 RID: 69
		[global::System.Runtime.InteropServices.DllImport("ve.dll", EntryPoint = "ve_ttsUnInitialize")]
		private static extern uint ve64_ttsUnInitialize(global::TTSBridge.TTSFunctions.VE_HSPEECH hTtsCl);

		// Token: 0x06000046 RID: 70
		[global::System.Runtime.InteropServices.DllImport("ve.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ve_ttsUnInitialize")]
		private static extern uint ve32_ttsUnInitialize(global::TTSBridge.TTSFunctions.VE_HSPEECH hTtsCl);

		// Token: 0x06000047 RID: 71 RVA: 0x000027AB File Offset: 0x000009AB
		public static uint ve_ttsUnInitialize(global::TTSBridge.TTSFunctions.VE_HSPEECH hTtsCl)
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.ve64_ttsUnInitialize(hTtsCl);
			}
			return global::TTSBridge.TTSFunctions.ve32_ttsUnInitialize(hTtsCl);
		}

		// Token: 0x06000048 RID: 72
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", EntryPoint = "ve_hardcodeParams")]
		private static extern uint ve64_hardcodeParams(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst, global::TTSBridge.TTSFunctions.VE_PARAM[] pTtsParam, ushort usNbrOfParam);

		// Token: 0x06000049 RID: 73
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "ve_hardcodeParams")]
		private static extern uint ve32_hardcodeParams(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst, global::TTSBridge.TTSFunctions.VE_PARAM[] pTtsParam, ushort usNbrOfParam);

		// Token: 0x0600004A RID: 74 RVA: 0x000027C2 File Offset: 0x000009C2
		public static uint ve_hardcodeParams(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst, global::TTSBridge.TTSFunctions.VE_PARAM[] pTtsParam, ushort usNbrOfParam)
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.ve64_hardcodeParams(hTtsInst, pTtsParam, usNbrOfParam);
			}
			return global::TTSBridge.TTSFunctions.ve32_hardcodeParams(hTtsInst, pTtsParam, usNbrOfParam);
		}

		// Token: 0x0600004B RID: 75
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", EntryPoint = "spx_resamplerInit")]
		private static extern global::System.IntPtr spx64_resamplerInit(uint channels, uint sampleIn, uint sampleOut, int quality, out int err);

		// Token: 0x0600004C RID: 76
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "spx_resamplerInit")]
		private static extern global::System.IntPtr spx32_resamplerInit(uint channels, uint sampleIn, uint sampleOut, int quality, out int err);

		// Token: 0x0600004D RID: 77 RVA: 0x000027DD File Offset: 0x000009DD
		public static global::System.IntPtr spx_resamplerInit(uint channels, uint sampleIn, uint sampleOut, int quality, out int err)
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.spx64_resamplerInit(channels, sampleIn, sampleOut, quality, out err);
			}
			return global::TTSBridge.TTSFunctions.spx32_resamplerInit(channels, sampleIn, sampleOut, quality, out err);
		}

		// Token: 0x0600004E RID: 78
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", EntryPoint = "spx_resamplerWriteIntSample")]
		private static extern int spx64_resamplerWriteIntSample(global::System.IntPtr st, uint channel_index, global::System.IntPtr input, ref uint in_len, short[] output, ref uint out_len);

		// Token: 0x0600004F RID: 79
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "spx_resamplerWriteIntSample")]
		private static extern int spx32_resamplerWriteIntSample(global::System.IntPtr st, uint channel_index, global::System.IntPtr input, ref uint in_len, short[] output, ref uint out_len);

		// Token: 0x06000050 RID: 80 RVA: 0x000027FE File Offset: 0x000009FE
		public static int spx_resamplerWriteIntSample(global::System.IntPtr st, uint channel_index, global::System.IntPtr input, ref uint in_len, short[] output, ref uint out_len)
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.spx64_resamplerWriteIntSample(st, channel_index, input, ref in_len, output, ref out_len);
			}
			return global::TTSBridge.TTSFunctions.spx32_resamplerWriteIntSample(st, channel_index, input, ref in_len, output, ref out_len);
		}

		// Token: 0x06000051 RID: 81
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", EntryPoint = "spx_resamplerDestroy")]
		private static extern void spx64_resamplerDestroy(global::System.IntPtr st);

		// Token: 0x06000052 RID: 82
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "spx_resamplerDestroy")]
		private static extern void spx32_resamplerDestroy(global::System.IntPtr st);

		// Token: 0x06000053 RID: 83 RVA: 0x00002823 File Offset: 0x00000A23
		public static void spx_resamplerDestroy(global::System.IntPtr st)
		{
			if (global::System.IntPtr.Size == 8)
			{
				global::TTSBridge.TTSFunctions.spx64_resamplerDestroy(st);
				return;
			}
			global::TTSBridge.TTSFunctions.spx32_resamplerDestroy(st);
		}

		// Token: 0x06000054 RID: 84
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", EntryPoint = "amr_EncoderInit")]
		private static extern global::System.IntPtr amr64_EncoderInit();

		// Token: 0x06000055 RID: 85
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "amr_EncoderInit")]
		private static extern global::System.IntPtr amr32_EncoderInit();

		// Token: 0x06000056 RID: 86 RVA: 0x0000283A File Offset: 0x00000A3A
		public static global::System.IntPtr amr_EncoderInit()
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.amr64_EncoderInit();
			}
			return global::TTSBridge.TTSFunctions.amr32_EncoderInit();
		}

		// Token: 0x06000057 RID: 87
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", EntryPoint = "amr_EncoderWriteSample")]
		private static extern int amr64_EncoderWriteSample(global::System.IntPtr amrEnc, short[] speech, byte[] encoded);

		// Token: 0x06000058 RID: 88
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "amr_EncoderWriteSample")]
		private static extern int amr32_EncoderWriteSample(global::System.IntPtr amrEnc, short[] speech, byte[] encoded);

		// Token: 0x06000059 RID: 89 RVA: 0x0000284F File Offset: 0x00000A4F
		public static int amr_EncoderWriteSample(global::System.IntPtr amrEnc, short[] speech, byte[] encoded)
		{
			if (global::System.IntPtr.Size == 8)
			{
				return global::TTSBridge.TTSFunctions.amr64_EncoderWriteSample(amrEnc, speech, encoded);
			}
			return global::TTSBridge.TTSFunctions.amr32_EncoderWriteSample(amrEnc, speech, encoded);
		}

		// Token: 0x0600005A RID: 90
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", EntryPoint = "amr_EncoderDestroy")]
		private static extern void amr64_EncoderDestroy(global::System.IntPtr amrEnc);

		// Token: 0x0600005B RID: 91
		[global::System.Runtime.InteropServices.DllImport("VeWrapper.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl, EntryPoint = "amr_EncoderDestroy")]
		private static extern void amr32_EncoderDestroy(global::System.IntPtr amrEnc);

		// Token: 0x0600005C RID: 92 RVA: 0x0000286A File Offset: 0x00000A6A
		public static void amr_EncoderDestroy(global::System.IntPtr amrEnc)
		{
			if (global::System.IntPtr.Size == 8)
			{
				global::TTSBridge.TTSFunctions.amr64_EncoderDestroy(amrEnc);
				return;
			}
			global::TTSBridge.TTSFunctions.amr32_EncoderDestroy(amrEnc);
		}

		// Token: 0x04000013 RID: 19
		private const string PathVariable = "PATH";

		// Token: 0x04000014 RID: 20
		private const int VE_MAX_STRING_LENGTH = 128;

		// Token: 0x02000013 RID: 19
		public struct VE_HEAP_INTERFACE
		{
			// Token: 0x0400003C RID: 60
			public global::System.IntPtr pfMalloc;

			// Token: 0x0400003D RID: 61
			public global::System.IntPtr pfCalloc;

			// Token: 0x0400003E RID: 62
			public global::System.IntPtr pfRealloc;
		}

		// Token: 0x02000014 RID: 20
		public struct VE_CRITSEC_INTERFACE
		{
			// Token: 0x0400003F RID: 63
			public global::System.IntPtr pfOpen;

			// Token: 0x04000040 RID: 64
			public global::System.IntPtr pfClose;

			// Token: 0x04000041 RID: 65
			public global::System.IntPtr pfEnter;

			// Token: 0x04000042 RID: 66
			public global::System.IntPtr pfLeave;
		}

		// Token: 0x02000015 RID: 21
		public struct VE_DATA_STREAM_INTERFACE
		{
			// Token: 0x04000043 RID: 67
			public global::System.IntPtr pfOpen;

			// Token: 0x04000044 RID: 68
			public global::System.IntPtr pfClose;

			// Token: 0x04000045 RID: 69
			public global::System.IntPtr pfRead;

			// Token: 0x04000046 RID: 70
			public global::System.IntPtr pfSeek;

			// Token: 0x04000047 RID: 71
			public global::System.IntPtr pfGetSize;

			// Token: 0x04000048 RID: 72
			public global::System.IntPtr pfError;

			// Token: 0x04000049 RID: 73
			public global::System.IntPtr pfWrite;
		}

		// Token: 0x02000016 RID: 22
		public struct VE_DATA_MAPPING_INTERFACE
		{
			// Token: 0x0400004A RID: 74
			public global::System.IntPtr pfOpen;

			// Token: 0x0400004B RID: 75
			public global::System.IntPtr pfClose;

			// Token: 0x0400004C RID: 76
			public global::System.IntPtr pfMap;

			// Token: 0x0400004D RID: 77
			public global::System.IntPtr pfUnmap;

			// Token: 0x0400004E RID: 78
			public global::System.IntPtr pfFreeze;
		}

		// Token: 0x02000017 RID: 23
		public struct VE_LOG_INTERFACE
		{
			// Token: 0x0400004F RID: 79
			public global::System.IntPtr pfError;

			// Token: 0x04000050 RID: 80
			public global::System.IntPtr pfDiagnostic;

			// Token: 0x04000051 RID: 81
			public global::System.IntPtr pfOutEvent;
		}

		// Token: 0x02000018 RID: 24
		public struct VE_CLOCK_INTERFACE
		{
			// Token: 0x04000052 RID: 82
			public global::System.IntPtr pfGetRelativeTime;
		}

		// Token: 0x02000019 RID: 25
		public struct VE_INSTALL
		{
			// Token: 0x04000053 RID: 83
			public ushort fmtVersion;

			// Token: 0x04000054 RID: 84
			public global::System.IntPtr pBinBrokerInfo;

			// Token: 0x04000055 RID: 85
			public global::System.IntPtr pIHeap;

			// Token: 0x04000056 RID: 86
			public global::System.IntPtr hHeap;

			// Token: 0x04000057 RID: 87
			public global::System.IntPtr pICritSec;

			// Token: 0x04000058 RID: 88
			public global::System.IntPtr hCSClass;

			// Token: 0x04000059 RID: 89
			public global::System.IntPtr pIDataStream;

			// Token: 0x0400005A RID: 90
			public global::System.IntPtr pIDataMapping;

			// Token: 0x0400005B RID: 91
			public global::System.IntPtr hDataClass;

			// Token: 0x0400005C RID: 92
			public global::System.IntPtr pILog;

			// Token: 0x0400005D RID: 93
			public global::System.IntPtr hLog;

			// Token: 0x0400005E RID: 94
			public global::System.IntPtr pIClock;

			// Token: 0x0400005F RID: 95
			public global::System.IntPtr hClock;
		}

		// Token: 0x0200001A RID: 26
		public struct VE_HSPEECH
		{
			// Token: 0x04000060 RID: 96
			public global::System.IntPtr pHandleData;

			// Token: 0x04000061 RID: 97
			public uint u32Check;
		}

		// Token: 0x0200001B RID: 27
		public struct VPLATFORM_MEMBLOCK
		{
			// Token: 0x04000062 RID: 98
			public global::System.IntPtr pStart;

			// Token: 0x04000063 RID: 99
			public global::System.UIntPtr cByte;

			// Token: 0x04000064 RID: 100
			public uint cFlags;
		}

		// Token: 0x0200001C RID: 28
		public struct VPLATFORM_RESOURCES
		{
			// Token: 0x04000065 RID: 101
			public ushort fmtVersion;

			// Token: 0x04000066 RID: 102
			public ushort u16NbrOfDataInstall;

			// Token: 0x04000067 RID: 103
			public global::System.IntPtr apDataInstall;

			// Token: 0x04000068 RID: 104
			public global::TTSBridge.TTSFunctions.VPLATFORM_MEMBLOCK stHeap;

			// Token: 0x04000069 RID: 105
			public global::System.IntPtr pDatPtr_Table;

			// Token: 0x0400006A RID: 106
			public global::System.IntPtr szBinaryBrokerFile;

			// Token: 0x0400006B RID: 107
			public global::System.IntPtr szFileListFile;

			// Token: 0x0400006C RID: 108
			public uint bFlags;

			// Token: 0x0400006D RID: 109
			public uint rfu1;
		}

		// Token: 0x0200001D RID: 29
		public struct VE_HSAFE
		{
			// Token: 0x0400006E RID: 110
			public global::System.IntPtr pHandleData;

			// Token: 0x0400006F RID: 111
			public uint u32Check;
		}

		// Token: 0x0200001E RID: 30
		public enum VE_PARAMID
		{
			// Token: 0x04000071 RID: 113
			VE_PARAM_LANGUAGE = 1,
			// Token: 0x04000072 RID: 114
			VE_PARAM_VOICE,
			// Token: 0x04000073 RID: 115
			VE_PARAM_VOICE_OPERATING_POINT,
			// Token: 0x04000074 RID: 116
			VE_PARAM_FREQUENCY,
			// Token: 0x04000075 RID: 117
			VE_PARAM_EXTRAESCLANG,
			// Token: 0x04000076 RID: 118
			VE_PARAM_EXTRAESCTN,
			// Token: 0x04000077 RID: 119
			VE_PARAM_TYPE_OF_CHAR,
			// Token: 0x04000078 RID: 120
			VE_PARAM_VOLUME,
			// Token: 0x04000079 RID: 121
			VE_PARAM_SPEECHRATE,
			// Token: 0x0400007A RID: 122
			VE_PARAM_PITCH,
			// Token: 0x0400007B RID: 123
			VE_PARAM_WAITFACTOR,
			// Token: 0x0400007C RID: 124
			VE_PARAM_READMODE,
			// Token: 0x0400007D RID: 125
			VE_PARAM_TEXTMODE,
			// Token: 0x0400007E RID: 126
			VE_PARAM_MAX_INPUT_LENGTH,
			// Token: 0x0400007F RID: 127
			VE_PARAM_LIDSCOPE,
			// Token: 0x04000080 RID: 128
			VE_PARAM_LIDVOICESWITCH,
			// Token: 0x04000081 RID: 129
			VE_PARAM_LIDMODE,
			// Token: 0x04000082 RID: 130
			VE_PARAM_LIDLANGUAGES,
			// Token: 0x04000083 RID: 131
			VE_PARAM_MARKER_MODE,
			// Token: 0x04000084 RID: 132
			VE_PARAM_INITMODE,
			// Token: 0x04000085 RID: 133
			VE_PARAM_VOP_VERSION,
			// Token: 0x04000086 RID: 134
			VE_PARAM_DISABLE_FINAL_SILENCE
		}

		// Token: 0x0200001F RID: 31
		public struct VE_PARAM_VALUE
		{
			// Token: 0x04000087 RID: 135
			public ushort usValue;

			// Token: 0x04000088 RID: 136
			[global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.ByValTStr, SizeConst = 128)]
			public string szStringValue;
		}

		// Token: 0x02000020 RID: 32
		public struct VE_PARAM
		{
			// Token: 0x04000089 RID: 137
			public global::TTSBridge.TTSFunctions.VE_PARAMID eID;

			// Token: 0x0400008A RID: 138
			public global::TTSBridge.TTSFunctions.VE_PARAM_VALUE uValue;
		}

		// Token: 0x02000021 RID: 33
		public struct VE_OUTDEVINFO
		{
			// Token: 0x0400008B RID: 139
			public global::System.IntPtr pUserData;

			// Token: 0x0400008C RID: 140
			public global::TTSBridge.TTSFunctions.CallbackOutNotify pfOutNotify;
		}

		// Token: 0x02000022 RID: 34
		public enum VE_MSG
		{
			// Token: 0x0400008E RID: 142
			VE_MSG_BEGINPROCESS = 1,
			// Token: 0x0400008F RID: 143
			VE_MSG_ENDPROCESS,
			// Token: 0x04000090 RID: 144
			VE_MSG_PROCESS = 4,
			// Token: 0x04000091 RID: 145
			VE_MSG_OUTBUFREQ = 8,
			// Token: 0x04000092 RID: 146
			VE_MSG_OUTBUFDONE = 16,
			// Token: 0x04000093 RID: 147
			VE_MSG_STOP = 32,
			// Token: 0x04000094 RID: 148
			VE_MSG_PAUSE = 64,
			// Token: 0x04000095 RID: 149
			VE_MSG_RESUME = 128,
			// Token: 0x04000096 RID: 150
			VE_MSG_TAIBEGIN = 256,
			// Token: 0x04000097 RID: 151
			VE_MSG_TAIEND = 512,
			// Token: 0x04000098 RID: 152
			VE_MSG_TAIBUFREQ = 1024,
			// Token: 0x04000099 RID: 153
			VE_MSG_TAIBUFDONE = 2048
		}

		// Token: 0x02000023 RID: 35
		public struct VE_CALLBACKMSG
		{
			// Token: 0x0400009A RID: 154
			public global::TTSBridge.TTSFunctions.VE_MSG eMessage;

			// Token: 0x0400009B RID: 155
			public int lValue;

			// Token: 0x0400009C RID: 156
			public global::System.IntPtr pParam;
		}

		// Token: 0x02000024 RID: 36
		public enum VE_TEXTFORMAT
		{
			// Token: 0x0400009E RID: 158
			VE_NORM_TEXT,
			// Token: 0x0400009F RID: 159
			VE_SSML_TEXT
		}

		// Token: 0x02000025 RID: 37
		public struct VE_INTEXT
		{
			// Token: 0x040000A0 RID: 160
			public global::TTSBridge.TTSFunctions.VE_TEXTFORMAT eTextFormat;

			// Token: 0x040000A1 RID: 161
			public global::System.UIntPtr cntTextLength;

			// Token: 0x040000A2 RID: 162
			public global::System.IntPtr szInText;
		}

		// Token: 0x02000026 RID: 38
		public enum VE_AUDIOFORMAT
		{
			// Token: 0x040000A4 RID: 164
			VE_16LINEAR,
			// Token: 0x040000A5 RID: 165
			VE_MU_LAW,
			// Token: 0x040000A6 RID: 166
			VE_A_LAW
		}

		// Token: 0x02000027 RID: 39
		public struct VE_OUTDATA
		{
			// Token: 0x040000A7 RID: 167
			public global::TTSBridge.TTSFunctions.VE_AUDIOFORMAT eAudioFormat;

			// Token: 0x040000A8 RID: 168
			public global::System.UIntPtr cntPcmBufLen;

			// Token: 0x040000A9 RID: 169
			public global::System.IntPtr pOutPcmBuf;

			// Token: 0x040000AA RID: 170
			public global::System.UIntPtr cntMrkListLen;

			// Token: 0x040000AB RID: 171
			public global::System.IntPtr pMrkList;
		}

		// Token: 0x02000028 RID: 40
		private struct VPLATFORM_DATA_CLASS_S
		{
			// Token: 0x040000AC RID: 172
			public global::System.IntPtr hHeap;

			// Token: 0x040000AD RID: 173
			public global::System.IntPtr pPlatformInfo;

			// Token: 0x040000AE RID: 174
			public global::System.IntPtr szBrokerInfo;

			// Token: 0x040000AF RID: 175
			public global::System.IntPtr pFileList;

			// Token: 0x040000B0 RID: 176
			public global::System.IntPtr pStreamClassData;

			// Token: 0x040000B1 RID: 177
			public uint bErrorCheck;
		}

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x0600007A RID: 122
		[global::System.Runtime.InteropServices.UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
		public delegate uint CallbackOutNotify(global::TTSBridge.TTSFunctions.VE_HSAFE hTtsInst, global::System.IntPtr pUserData, ref global::TTSBridge.TTSFunctions.VE_CALLBACKMSG pcbMessage);
	}
}
