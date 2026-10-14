using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000E RID: 14
	public class JSONHelper
	{
		// Token: 0x06000027 RID: 39 RVA: 0x0000411C File Offset: 0x0000231C
		public static T Parse<T>(string json)
		{
			short num = (short)1983243891;
			short num2 = num;
			num = (short)1395648115;
			T result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)119013376;
				if (num != 0)
				{
				}
				num = (short)144703488;
				short num3 = num;
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Text.Encoding.UTF8.GetBytes(json));
				try
				{
					result = (T)((object)new global::System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(T)).ReadObject(memoryStream));
				}
				finally
				{
					num = (short)1258487809;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)1208156162;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_D6;
							}
							continue;
						case 2:
							goto IL_133;
						}
						IL_D6:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)2063400961;
						if (num != 0)
						{
						}
						num = (short)651100160;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_133:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004270 File Offset: 0x00002470
		public static string ToString(object jsonObj)
		{
			short num = (short)1747768521;
			short num2 = num;
			num = (short)1402983625;
			string @string;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1833828352;
				if (num != 0)
				{
				}
				num = (short)352518144;
				short num3 = num;
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					new global::System.Runtime.Serialization.Json.DataContractJsonSerializer(jsonObj.GetType()).WriteObject(memoryStream, jsonObj);
					@string = global::System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
				}
				finally
				{
					num = (short)1018953729;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)2138767362;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1883635713;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_FD;
							}
							continue;
						case 2:
							goto IL_131;
						}
						IL_FD:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)891289600;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_131:;
				}
				break;
			}
			}
			return @string;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000043C4 File Offset: 0x000025C4
		public static T TryDeserializeJson<T>(string json) where T : class
		{
			short num = (short)1533406704;
			short num2 = num;
			num = (short)257748464;
			T result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)495779840;
				if (num != 0)
				{
				}
				num = (short)334495744;
				short num3 = num;
				result = default(T);
				try
				{
					num = (short)225771522;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							result = global::Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
							num = (short)258277377;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_EA;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_B4;
							}
							continue;
						case 3:
							goto IL_FE;
						}
						IL_B4:
						if (json != null)
						{
							num = (short)1530462208;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_EA:
						num = (short)1502806019;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_FE:;
				}
				catch (global::System.Exception)
				{
				}
				break;
			}
			}
			num = (short)1085407233;
			if (num != 0)
			{
			}
			return result;
		}
	}
}
