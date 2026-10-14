using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;

namespace Gibraltar.Data
{
	// Token: 0x020000E7 RID: 231
	internal static class BinarySerializer
	{
		// Token: 0x0600097C RID: 2428 RVA: 0x00016CAC File Offset: 0x00014EAC
		static BinarySerializer()
		{
			if (global::System.Type.GetType("Mono.Runtime") == null)
			{
				global::Gibraltar.Data.BinarySerializer.s_MonoRuntime = false;
				return;
			}
			global::Gibraltar.Data.BinarySerializer.s_MonoRuntime = true;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00016CD4 File Offset: 0x00014ED4
		public static void SerializeValue(global::System.IO.Stream stream, bool hostValue)
		{
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00016CF8 File Offset: 0x00014EF8
		public static byte[] SerializeValue(bool hostValue)
		{
			if (hostValue)
			{
				return new byte[]
				{
					1
				};
			}
			return new byte[1];
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x00016D14 File Offset: 0x00014F14
		public static void SerializeValue(global::System.IO.Stream stream, global::System.Guid hostValue)
		{
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x00016D38 File Offset: 0x00014F38
		public static byte[] SerializeValue(global::System.Guid hostValue)
		{
			return hostValue.ToByteArray();
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00016D44 File Offset: 0x00014F44
		public static void SerializeValue(global::System.IO.Stream stream, string hostValue)
		{
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x00016D68 File Offset: 0x00014F68
		public static byte[] SerializeValue(string hostValue)
		{
			if (hostValue == null)
			{
				return global::Gibraltar.Data.BinarySerializer.SerializeValue(-1);
			}
			if (string.IsNullOrEmpty(hostValue))
			{
				return global::Gibraltar.Data.BinarySerializer.SerializeValue(0);
			}
			byte[] bytes = global::Gibraltar.Data.BinarySerializer.s_Encoding.GetBytes(hostValue);
			byte[] array = new byte[4 + bytes.Length];
			global::System.Array.Copy(global::Gibraltar.Data.BinarySerializer.SerializeValue(bytes.Length), array, 4);
			global::System.Array.Copy(bytes, 0, array, 4, bytes.Length);
			return array;
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x00016DCC File Offset: 0x00014FCC
		public static void SerializeValue(global::System.IO.Stream stream, global::System.DateTime hostValue)
		{
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x00016DF0 File Offset: 0x00014FF0
		public static byte[] SerializeValue(global::System.DateTime hostValue)
		{
			return global::Gibraltar.Data.BinarySerializer.SerializeValue(new global::System.DateTimeOffset(hostValue));
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00016E00 File Offset: 0x00015000
		public static void SerializeValue(global::System.IO.Stream stream, global::System.DateTimeOffset hostValue)
		{
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00016E24 File Offset: 0x00015024
		public static byte[] SerializeValue(global::System.DateTimeOffset hostValue)
		{
			return global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue.ToString("o", global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00016E3C File Offset: 0x0001503C
		public static void SerializeValue(global::System.IO.Stream stream, global::System.TimeSpan hostValue)
		{
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue.Ticks);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00016E68 File Offset: 0x00015068
		public static byte[] SerializeValue(global::System.TimeSpan hostValue)
		{
			return global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue.Ticks);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00016E78 File Offset: 0x00015078
		public static void SerializeValue(global::System.IO.Stream stream, long hostValue)
		{
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00016E9C File Offset: 0x0001509C
		public static byte[] SerializeValue(long hostValue)
		{
			return global::System.BitConverter.GetBytes(global::System.Net.IPAddress.HostToNetworkOrder(hostValue));
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00016EAC File Offset: 0x000150AC
		public static void SerializeValue(global::System.IO.Stream stream, ulong hostValue)
		{
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00016ED0 File Offset: 0x000150D0
		public static byte[] SerializeValue(ulong hostValue)
		{
			return global::System.BitConverter.GetBytes(global::System.Net.IPAddress.HostToNetworkOrder((long)hostValue));
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00016EE0 File Offset: 0x000150E0
		public static void SerializeValue(global::System.IO.Stream stream, int hostValue)
		{
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00016F04 File Offset: 0x00015104
		public static byte[] SerializeValue(int hostValue)
		{
			return global::System.BitConverter.GetBytes(global::System.Net.IPAddress.HostToNetworkOrder(hostValue));
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00016F14 File Offset: 0x00015114
		public static void SerializeValue(global::System.IO.Stream stream, uint hostValue)
		{
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00016F38 File Offset: 0x00015138
		public static byte[] SerializeValue(uint hostValue)
		{
			return global::System.BitConverter.GetBytes(global::System.Net.IPAddress.HostToNetworkOrder((int)hostValue));
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00016F48 File Offset: 0x00015148
		public static void SerializeValue(global::System.IO.Stream stream, short hostValue)
		{
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00016F6C File Offset: 0x0001516C
		public static byte[] SerializeValue(short hostValue)
		{
			return global::System.BitConverter.GetBytes(global::System.Net.IPAddress.HostToNetworkOrder(hostValue));
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x00016F7C File Offset: 0x0001517C
		public static void SerializeValue(global::System.IO.Stream stream, ushort hostValue)
		{
			byte[] array = global::Gibraltar.Data.BinarySerializer.SerializeValue(hostValue);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x00016FA0 File Offset: 0x000151A0
		public static byte[] SerializeValue(ushort hostValue)
		{
			return global::System.BitConverter.GetBytes(global::System.Net.IPAddress.HostToNetworkOrder((short)hostValue));
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00016FB0 File Offset: 0x000151B0
		public static void DeserializeValue(global::System.IO.Stream networkBytes, out long hostValue)
		{
			byte[] array = new byte[8];
			networkBytes.Read(array, 0, array.Length);
			long network = global::System.BitConverter.ToInt64(array, 0);
			hostValue = global::System.Net.IPAddress.NetworkToHostOrder(network);
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00016FE4 File Offset: 0x000151E4
		public static void DeserializeValue(global::System.IO.Stream networkBytes, out ulong hostValue)
		{
			byte[] array = new byte[8];
			networkBytes.Read(array, 0, array.Length);
			long network = global::System.BitConverter.ToInt64(array, 0);
			hostValue = (ulong)global::System.Net.IPAddress.NetworkToHostOrder(network);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x00017018 File Offset: 0x00015218
		public static void DeserializeValue(global::System.IO.Stream networkBytes, out int hostValue)
		{
			byte[] array = new byte[4];
			networkBytes.Read(array, 0, array.Length);
			int network = global::System.BitConverter.ToInt32(array, 0);
			hostValue = global::System.Net.IPAddress.NetworkToHostOrder(network);
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0001704C File Offset: 0x0001524C
		public static void DeserializeValue(global::System.IO.Stream networkBytes, out uint hostValue)
		{
			byte[] array = new byte[4];
			networkBytes.Read(array, 0, array.Length);
			int network = global::System.BitConverter.ToInt32(array, 0);
			hostValue = (uint)global::System.Net.IPAddress.NetworkToHostOrder(network);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00017080 File Offset: 0x00015280
		public static void DeserializeValue(global::System.IO.Stream networkBytes, out short hostValue)
		{
			byte[] array = new byte[2];
			networkBytes.Read(array, 0, array.Length);
			short network = global::System.BitConverter.ToInt16(array, 0);
			hostValue = global::System.Net.IPAddress.NetworkToHostOrder(network);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x000170B4 File Offset: 0x000152B4
		public static void DeserializeValue(global::System.IO.Stream networkBytes, out ushort hostValue)
		{
			byte[] array = new byte[2];
			networkBytes.Read(array, 0, array.Length);
			short network = global::System.BitConverter.ToInt16(array, 0);
			hostValue = (ushort)global::System.Net.IPAddress.NetworkToHostOrder(network);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x000170EC File Offset: 0x000152EC
		public static void DeserializeValue(global::System.IO.Stream networkBytes, out global::System.TimeSpan hostValue)
		{
			long value;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(networkBytes, out value);
			hostValue = global::System.TimeSpan.FromTicks(value);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00017114 File Offset: 0x00015314
		public static void DeserializeValue(global::System.IO.Stream networkBytes, out global::System.DateTime hostValue)
		{
			global::System.DateTimeOffset dateTimeOffset;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(networkBytes, out dateTimeOffset);
			hostValue = dateTimeOffset.DateTime;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0001713C File Offset: 0x0001533C
		public static void DeserializeValue(global::System.IO.Stream networkBytes, out global::System.DateTimeOffset hostValue)
		{
			string text;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(networkBytes, out text);
			if (!global::Gibraltar.Data.BinarySerializer.s_MonoRuntime)
			{
				hostValue = global::System.DateTimeOffset.ParseExact(text, "o", null);
				return;
			}
			if (text.Length != 33 || text[4] != '-' || text[7] != '-' || text[10] != 'T' || text[13] != ':' || text[16] != ':' || text[19] != '.' || text[30] != ':')
			{
				throw new global::System.FormatException(string.Format("Unrecognized format for DateTimeOffset deserialization: \"{0}\"", text));
			}
			int year = int.Parse(text.Substring(0, 4), global::System.Globalization.NumberStyles.None);
			int month = int.Parse(text.Substring(5, 2), global::System.Globalization.NumberStyles.None);
			int day = int.Parse(text.Substring(8, 2), global::System.Globalization.NumberStyles.None);
			int hour = int.Parse(text.Substring(11, 2), global::System.Globalization.NumberStyles.None);
			int minute = int.Parse(text.Substring(14, 2), global::System.Globalization.NumberStyles.None);
			int second = int.Parse(text.Substring(17, 2), global::System.Globalization.NumberStyles.None);
			int num = int.Parse(text.Substring(20, 7), global::System.Globalization.NumberStyles.None);
			int hours = int.Parse(text.Substring(28, 2), global::System.Globalization.NumberStyles.None);
			int minutes = int.Parse(text.Substring(31, 2), global::System.Globalization.NumberStyles.None);
			global::System.TimeSpan offset = new global::System.TimeSpan(hours, minutes, 0);
			char c = text[27];
			if (c == '-')
			{
				offset = offset.Negate();
			}
			else if (c != '+')
			{
				throw new global::System.FormatException(string.Format("Unrecognized character for time zone offset sign: '{0}'", c));
			}
			hostValue = new global::System.DateTimeOffset(year, month, day, hour, minute, second, offset).AddTicks((long)num);
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x000172FC File Offset: 0x000154FC
		public static void DeserializeValue(global::System.IO.Stream networkBytes, out global::System.Guid hostValue)
		{
			byte[] array = new byte[16];
			networkBytes.Read(array, 0, array.Length);
			hostValue = new global::System.Guid(array);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x00017330 File Offset: 0x00015530
		public static void DeserializeValue(global::System.IO.Stream networkBytes, out bool hostValue)
		{
			if (networkBytes.ReadByte() == 0)
			{
				hostValue = false;
				return;
			}
			hostValue = true;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00017344 File Offset: 0x00015544
		public static void DeserializeValue(global::System.IO.Stream networkBytes, out string hostValue)
		{
			int num;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(networkBytes, out num);
			if (num > 0)
			{
				byte[] array = new byte[num];
				networkBytes.Read(array, 0, array.Length);
				hostValue = global::Gibraltar.Data.BinarySerializer.s_Encoding.GetString(array);
				return;
			}
			if (num == 0)
			{
				hostValue = string.Empty;
				return;
			}
			hostValue = null;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00017398 File Offset: 0x00015598
		public static byte[] CalculateCRC(byte[] data, int length)
		{
			if (length < data.Length)
			{
				byte[] array = new byte[length];
				global::System.Array.Copy(data, array, length);
				data = array;
			}
			byte[] hash = global::Gibraltar.Data.MD5Core.GetHash(data);
			return new byte[]
			{
				hash[0],
				hash[1],
				hash[2],
				hash[3]
			};
		}

		// Token: 0x0400024C RID: 588
		private static readonly global::System.Text.Encoding s_Encoding = new global::System.Text.UTF8Encoding();

		// Token: 0x0400024D RID: 589
		private static readonly bool s_MonoRuntime;
	}
}
