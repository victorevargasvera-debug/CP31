using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SpecialFeatures.RadioLanguagePack
{
	// Token: 0x020000BD RID: 189
	public class BinarySeralizeDeserialize
	{
		// Token: 0x06000C2F RID: 3119 RVA: 0x000FCE94 File Offset: 0x000FB094
		internal static byte[] Serialize(object instance)
		{
			short num = (short)1964867510;
			short num2 = num;
			num = (short)377454518;
			byte[] result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1137901568;
				short num3 = num;
				num = (short)1268514816;
				if (num != 0)
				{
				}
				num = (short)352714753;
				if (num != 0)
				{
				}
				result = null;
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(memoryStream, instance);
					result = memoryStream.ToArray();
				}
				finally
				{
					num = (short)90046465;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)1928724482;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_EA;
							}
							continue;
						case 2:
							goto IL_11D;
						}
						IL_EA:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)494927872;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_11D:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x000FCFD4 File Offset: 0x000FB1D4
		internal static T Deserialize<T>(byte[] array)
		{
			global::System.IO.MemoryStream memoryStream = null;
			T result;
			short num;
			try
			{
				memoryStream = new global::System.IO.MemoryStream(array);
				result = (T)((object)new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(memoryStream));
			}
			finally
			{
				num = (short)599195650;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_D7;
					case 1:
					{
						num = (short)728595920;
						short num3 = num;
						num = (short)2059042256;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D9;
						default:
							num = (short)1806893056;
							if (num != 0)
							{
							}
							memoryStream.Close();
							num = (short)454623232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_51;
						}
						continue;
					}
					IL_51:
					if (memoryStream == null)
					{
						break;
					}
					num = (short)462880769;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D7:
				IL_D9:
				memoryStream = null;
			}
			num = (short)9175041;
			if (num != 0)
			{
			}
			num = (short)1148452864;
			short num4 = num;
			return result;
		}
	}
}
