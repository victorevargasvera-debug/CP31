using System;
using System.Collections.Generic;
using System.IO;
using Motorola.Common.BinarySerializer;

namespace AcpFileHandlerLib
{
	// Token: 0x02000007 RID: 7
	public interface IAcpFileHandler
	{
		// Token: 0x06000043 RID: 67
		void WriteFile<T>(T writeBuffer, global::AcpFileHandlerLib.AcpFileHeader fileHeader, string filePath, bool encrypt);

		// Token: 0x06000044 RID: 68
		void WriteFile(byte[] writeBuffer, global::AcpFileHandlerLib.AcpFileHeader fileHeader, string filePath, bool encrypt, global::System.IO.FileMode fileMode);

		// Token: 0x06000045 RID: 69
		void ReadFile<T>(out T readBuffer, out global::AcpFileHandlerLib.AcpFileHeader fileHeader, string filePath, bool decrypt, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> allowedTypes);

		// Token: 0x06000046 RID: 70
		void ReadFile<T>(out T readBuffer, string filePath, bool decrypt, global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> allowedTypes);

		// Token: 0x06000047 RID: 71
		void ReadFile(out byte[] readBuffer, out global::AcpFileHandlerLib.AcpFileHeader fileHeader, string filePath, bool decrypt);

		// Token: 0x06000048 RID: 72
		void ReadFile(out byte[] readBuffer, string filePath, bool decrypt);

		// Token: 0x06000049 RID: 73
		global::AcpFileHandlerLib.AcpFileHeader ReadHeader(string filePath);

		// Token: 0x0600004A RID: 74
		byte[] EncodeStringToByteArray(string str);

		// Token: 0x0600004B RID: 75
		string DecodeByteArrayToString(byte[] bytes);
	}
}
