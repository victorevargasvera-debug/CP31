using System;

namespace ACPVoiceAnnouncementLib
{
	// Token: 0x02000004 RID: 4
	public interface IInflateDeflate : global::System.IDisposable
	{
		// Token: 0x06000006 RID: 6
		int deflate_fileInterface(int mode, string speech_file, string bitstream_file);

		// Token: 0x06000007 RID: 7
		int deflate_memoryInterface(int mode, byte[] speech_stream, byte[] bitstream_stream, ref int bitstream_length);

		// Token: 0x06000008 RID: 8
		int inflate_fileInterface(string bitstream_file, string speech_file);

		// Token: 0x06000009 RID: 9
		int inflate_memoryInterface(byte[] bitstream_stream, byte[] speech_stream, ref int speech_stream_length);
	}
}
