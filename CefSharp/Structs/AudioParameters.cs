using System;
using CefSharp.Enums;

namespace CefSharp.Structs
{
	// Token: 0x020000A9 RID: 169
	public struct AudioParameters
	{
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x00008260 File Offset: 0x00006460
		// (set) Token: 0x06000524 RID: 1316 RVA: 0x00008268 File Offset: 0x00006468
		public global::CefSharp.Enums.ChannelLayout ChannelLayout { get; set; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x00008271 File Offset: 0x00006471
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00008279 File Offset: 0x00006479
		public int SampleRate { get; set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00008282 File Offset: 0x00006482
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0000828A File Offset: 0x0000648A
		public int FramesPerBuffer { get; set; }

		// Token: 0x06000529 RID: 1321 RVA: 0x00008293 File Offset: 0x00006493
		public AudioParameters(global::CefSharp.Enums.ChannelLayout channelLayout, int sampleRate, int framesPerBuffer)
		{
			this.ChannelLayout = channelLayout;
			this.SampleRate = sampleRate;
			this.FramesPerBuffer = framesPerBuffer;
		}
	}
}
