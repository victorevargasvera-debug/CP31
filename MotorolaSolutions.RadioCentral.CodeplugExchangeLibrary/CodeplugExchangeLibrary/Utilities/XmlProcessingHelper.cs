using System;
using System.IO;
using System.Xml.Serialization;

namespace CodeplugExchangeLibrary.Utilities
{
	// Token: 0x02000008 RID: 8
	internal static class XmlProcessingHelper
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00003C14 File Offset: 0x00001E14
		internal static T Deserialize<T>(byte[] bytes)
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(bytes);
			T result;
			short num;
			try
			{
				result = (T)((object)xmlSerializer.Deserialize(memoryStream));
			}
			finally
			{
				num = (short)1313210369;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_E1;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					case 2:
					{
						num = (short)1407362561;
						short num3 = num;
						num = (short)279881217;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E1;
						default:
							num = (short)858652672;
							if (num != 0)
							{
							}
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)24576000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_5D:
					if (memoryStream == null)
					{
						goto IL_10A;
					}
					num = (short)1091174402;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E1:
				num = (short)1630994433;
				if (num != 0)
				{
				}
				IL_10A:;
			}
			num = (short)1704329216;
			short num4 = num;
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003D68 File Offset: 0x00001F68
		internal static byte[] Serialize<T>(T obj)
		{
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			short num;
			byte[] result;
			try
			{
				num = (short)1166802945;
				if (num != 0)
				{
				}
				xmlSerializer.Serialize(memoryStream, obj);
				result = memoryStream.ToArray();
			}
			finally
			{
				num = (short)491061249;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_10C;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					case 2:
					{
						num = (short)1894530763;
						short num3 = num;
						num = (short)340475595;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10C;
						default:
							num = (short)1327235072;
							if (num != 0)
							{
							}
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)322830336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_88:
					if (memoryStream == null)
					{
						break;
					}
					num = (short)819068930;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10C:;
			}
			num = (short)1645740032;
			short num4 = num;
			return result;
		}
	}
}
