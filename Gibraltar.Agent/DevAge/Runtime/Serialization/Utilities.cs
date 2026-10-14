using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DevAge.Runtime.Serialization
{
	// Token: 0x0200028B RID: 651
	internal static class Utilities
	{
		// Token: 0x0600216B RID: 8555 RVA: 0x000770C0 File Offset: 0x000752C0
		public static object BinDeserialize(global::System.IO.Stream p_Stream)
		{
			global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			return binaryFormatter.Deserialize(p_Stream);
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x000770E0 File Offset: 0x000752E0
		public static void BinSerialize(global::System.IO.Stream p_Stream, object p_Object)
		{
			global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			binaryFormatter.Serialize(p_Stream, p_Object);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00077100 File Offset: 0x00075300
		public static object BinDeserialize(string p_strFileName)
		{
			object result;
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(p_strFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read))
			{
				result = global::DevAge.Runtime.Serialization.Utilities.BinDeserialize(fileStream);
				fileStream.Close();
			}
			return result;
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00077148 File Offset: 0x00075348
		public static void BinSerialize(string p_strFileName, object p_Object)
		{
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(p_strFileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write))
			{
				global::DevAge.Runtime.Serialization.Utilities.BinSerialize(fileStream, p_Object);
				fileStream.Close();
			}
		}
	}
}
