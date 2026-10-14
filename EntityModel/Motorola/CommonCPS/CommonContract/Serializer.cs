using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Motorola.CommonCPS.CommonContract
{
	// Token: 0x02000008 RID: 8
	public static class Serializer
	{
		// Token: 0x06000013 RID: 19 RVA: 0x000029A8 File Offset: 0x00000BA8
		public static string Serialize_ToXMLString(object obj)
		{
			short num = (short)496893952;
			short num2 = num;
			num = (short)814578042;
			short num3 = num;
			num = (short)998996346;
			string @string;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1362034689;
				if (num != 0)
				{
				}
				num = (short)1567162368;
				if (num != 0)
				{
				}
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					new global::System.Xml.Serialization.XmlSerializer(obj.GetType()).Serialize(memoryStream, obj);
					@string = global::Motorola.CommonCPS.CommonContract.Serializer.a.GetString(memoryStream.ToArray());
				}
				finally
				{
					num = (short)1107165184;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_F9;
							}
							continue;
						case 1:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)377159682;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_12D;
						}
						IL_F9:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)2024669185;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_12D:;
				}
				break;
			}
			}
			return @string;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002AF8 File Offset: 0x00000CF8
		public static object Deserialize_FromXMLString(string s, global::System.Type type)
		{
			short num = (short)623378432;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.IO.MemoryStream memoryStream;
				switch (num2)
				{
				case 0:
					IL_15:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					goto IL_51;
				case 2:
					try
					{
						return new global::System.Xml.Serialization.XmlSerializer(type).Deserialize(memoryStream);
					}
					finally
					{
						num = (short)1739063296;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_9A;
								}
								continue;
							case 1:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)2121007106;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_CD;
							}
							IL_9A:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)484376577;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_CD:;
					}
					goto IL_D0;
				}
				IL_31:
				if (string.IsNullOrEmpty(s))
				{
					num = (short)1134559233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D0:
				num = (short)664469505;
				if (num != 0)
				{
				}
				memoryStream = new global::System.IO.MemoryStream(global::Motorola.CommonCPS.CommonContract.Serializer.a.GetBytes(s));
				num = (short)153998827;
				short num3 = num;
				num = (short)99276267;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_15;
				default:
				{
					num = (short)1547632640;
					short num4 = num;
					num = (short)510197760;
					if (num != 0)
					{
					}
					num = (short)568918018;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_51:
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public static void SerializeToXmlFile(string xmlFilePath, global::System.Type type, object obj)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::System.Xml.Serialization.XmlSerializer xmlSerializer;
			for (;;)
			{
				IL_0A:
				int num;
				global::System.IO.Stream stream;
				switch (num)
				{
				case 0:
					if (!global::System.IO.Directory.Exists(global::System.IO.Path.GetDirectoryName(xmlFilePath)))
					{
						num2 = (short)500629506;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15D;
				case 1:
					try
					{
						stream.SetLength(0L);
						xmlSerializer.Serialize(stream, obj);
						stream.Flush();
						return;
					}
					finally
					{
						num2 = (short)1063190528;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_127;
								}
								continue;
							case 1:
								((global::System.IDisposable)stream).Dispose();
								num2 = (short)510263298;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_15A;
							}
							IL_127:
							if (stream == null)
							{
								break;
							}
							num2 = (short)749338625;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_15A:;
					}
					goto IL_15D;
				case 2:
					global::System.IO.Directory.CreateDirectory(global::System.IO.Path.GetDirectoryName(xmlFilePath));
					num2 = (short)1579614211;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_15D;
				}
				goto IL_20;
				IL_15D:
				num2 = (short)736952320;
				short num3 = num2;
				stream = new global::System.IO.FileStream(xmlFilePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
				num2 = (short)650641409;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			num2 = (short)1156579329;
			if (num2 != 0)
			{
			}
			xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(type);
			num2 = (short)1909023830;
			short num4 = num2;
			num2 = (short)1736270934;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)1242890240;
				if (num2 != 0)
				{
				}
				num2 = (short)717160448;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002EA4 File Offset: 0x000010A4
		public static object DeserializeFromXmlFile(string xmlFilePath, global::System.Type type)
		{
			short num = (short)476643328;
			short num2 = num;
			num = (short)941492827;
			short num3 = num;
			num = (short)1588529755;
			object result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)136708096;
				if (num != 0)
				{
				}
				global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(type);
				global::System.IO.Stream stream = new global::System.IO.FileStream(xmlFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				try
				{
					result = xmlSerializer.Deserialize(stream);
				}
				finally
				{
					num = (short)849149952;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_C3;
							}
							continue;
						case 1:
							((global::System.IDisposable)stream).Dispose();
							num = (short)488177666;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_121;
						}
						IL_C3:
						if (stream == null)
						{
							break;
						}
						num = (short)899350529;
						if (num != 0)
						{
						}
						num = (short)450428929;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_121:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002FE8 File Offset: 0x000011E8
		public static string Serialize_DataContract_ToXML(object obj)
		{
			short num = (short)1771743615;
			short num2 = num;
			num = (short)1505995135;
			string @string;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2061565953;
				if (num != 0)
				{
				}
				num = (short)247267328;
				if (num != 0)
				{
				}
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					new global::System.Runtime.Serialization.DataContractSerializer(obj.GetType()).WriteObject(memoryStream, obj);
					@string = global::Motorola.CommonCPS.CommonContract.Serializer.a.GetString(memoryStream.ToArray());
				}
				finally
				{
					num = (short)1461780480;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_D1;
							}
							continue;
						case 1:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)900595714;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_106;
						}
						IL_D1:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)276824065;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_106:;
				}
				break;
			}
			}
			num = (short)1973682176;
			short num4 = num;
			return @string;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000313C File Offset: 0x0000133C
		public static void Serialize_DataContract_ToXMLFile(object obj, string xmlFilePath)
		{
			global::System.IO.Stream stream = new global::System.IO.FileStream(xmlFilePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
			short num;
			try
			{
				num = (short)984875009;
				if (num != 0)
				{
				}
				stream.SetLength(0L);
				new global::System.Runtime.Serialization.DataContractSerializer(obj.GetType()).WriteObject(stream, obj);
				stream.Flush();
			}
			finally
			{
				num = (short)1445003265;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_BC;
					case 1:
						IL_6A:
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					case 2:
						((global::System.IDisposable)stream).Dispose();
						num = (short)521404416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_86:
					if (stream != null)
					{
						num = (short)50528258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_BC:
					num = (short)1330890758;
					short num3 = num;
					num = (short)2028652550;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
						goto IL_F1;
					}
				}
				IL_F1:
				num = (short)2103836672;
				if (num != 0)
				{
				}
			}
			num = (short)499122176;
			short num4 = num;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000328C File Offset: 0x0000148C
		public static object Deserialize_DataContract_FromXML(string s, global::System.Type type)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::Motorola.CommonCPS.CommonContract.Serializer.a.GetBytes(s));
			short num;
			object result;
			try
			{
				num = (short)572784641;
				if (num != 0)
				{
				}
				result = new global::System.Runtime.Serialization.DataContractSerializer(type).ReadObject(memoryStream);
			}
			finally
			{
				num = (short)1187577857;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_B3;
					case 1:
						IL_60:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					case 2:
						((global::System.IDisposable)memoryStream).Dispose();
						num = (short)305463296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7C:
					if (memoryStream != null)
					{
						num = (short)27590658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B3:
					num = (short)402849216;
					short num3 = num;
					num = (short)2096496064;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
						goto IL_E7;
					}
				}
				IL_E7:
				num = (short)258473984;
				if (num != 0)
				{
				}
			}
			num = (short)1285357568;
			short num4 = num;
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000033D4 File Offset: 0x000015D4
		public static object Deserialize_DataContract_FromXMLFile(string xmlFilePath, global::System.Type type)
		{
			global::System.IO.Stream stream = new global::System.IO.FileStream(xmlFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
			object result;
			short num;
			try
			{
				result = new global::System.Runtime.Serialization.DataContractSerializer(type).ReadObject(stream);
			}
			finally
			{
				num = (short)1287585793;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_84;
					case 1:
						IL_32:
						switch (0)
						{
						case 0:
							goto IL_4E;
						}
						continue;
					case 2:
						((global::System.IDisposable)stream).Dispose();
						num = (short)1250885632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4E:
					if (stream != null)
					{
						num = (short)1890582530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_84:
					num = (short)970900613;
					short num3 = num;
					num = (short)1812120709;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_32;
					default:
						goto IL_B9;
					}
				}
				IL_B9:
				num = (short)121372672;
				if (num != 0)
				{
				}
			}
			num = (short)1441923073;
			if (num != 0)
			{
			}
			num = (short)899284992;
			short num4 = num;
			return result;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003510 File Offset: 0x00001710
		public static string Serialize_ToXMLZipString(object obj)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			short num;
			string result;
			try
			{
				global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(memoryStream, global::System.IO.Compression.CompressionLevel.Optimal);
				try
				{
					new global::System.Xml.Serialization.XmlSerializer(obj.GetType()).Serialize(deflateStream, obj);
				}
				finally
				{
					num = (short)651427841;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_91;
						case 1:
							IL_3D:
							switch (0)
							{
							case 0:
								goto IL_59;
							}
							continue;
						case 2:
							((global::System.IDisposable)deflateStream).Dispose();
							num = (short)405143552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_59:
						if (deflateStream != null)
						{
							num = (short)894369794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_91:
						num = (short)884899412;
						short num3 = num;
						num = (short)173637204;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3D;
						default:
							goto IL_C6;
						}
					}
					IL_C6:
					num = (short)1285750784;
					if (num != 0)
					{
					}
				}
				result = global::System.Convert.ToBase64String(memoryStream.ToArray());
			}
			finally
			{
				num = (short)1765474305;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_150;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_11D;
						}
						continue;
					case 2:
						((global::System.IDisposable)memoryStream).Dispose();
						num = (short)2135162880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_11D:
					if (memoryStream == null)
					{
						goto IL_17B;
					}
					num = (short)683671554;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_150:
				num = (short)89456641;
				if (num != 0)
				{
				}
				IL_17B:;
			}
			num = (short)1843462144;
			short num4 = num;
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000036E0 File Offset: 0x000018E0
		public static object Deserialize_FromXMLZipString(string s, global::System.Type type)
		{
			short num = (short)958595073;
			if (num != 0)
			{
			}
			num = (short)613875713;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.IO.MemoryStream memoryStream;
				switch (num2)
				{
				case 0:
					try
					{
						global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(memoryStream, global::System.IO.Compression.CompressionMode.Decompress);
						try
						{
							return new global::System.Xml.Serialization.XmlSerializer(type).Deserialize(deflateStream);
						}
						finally
						{
							num = (short)852361217;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_FC;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_C8;
									}
									continue;
								case 2:
									((global::System.IDisposable)deflateStream).Dispose();
									num = (short)825950208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_C8:
								if (deflateStream == null)
								{
									break;
								}
								num = (short)867631106;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FC:;
						}
					}
					finally
					{
						num = (short)2000879617;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_168;
							case 1:
								IL_114:
								switch (0)
								{
								case 0:
									goto IL_130;
								}
								continue;
							case 2:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)1424621568;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_130:
							if (memoryStream != null)
							{
								num = (short)1299578882;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_168:
							num = (short)1418913211;
							short num3 = num;
							num = (short)1038149051;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_114;
							default:
								goto IL_19C;
							}
						}
						IL_19C:
						num = (short)2047803392;
						if (num != 0)
						{
						}
					}
					goto IL_1B2;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 2:
					goto IL_77;
				}
				IL_58:
				if (string.IsNullOrEmpty(s))
				{
					num = (short)923664386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1B2:
				memoryStream = new global::System.IO.MemoryStream(global::System.Convert.FromBase64String(s));
				num = (short)29097984;
				short num4 = num;
				num = (short)1256259584;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_77:
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003914 File Offset: 0x00001B14
		// Note: this type is marked as 'beforefieldinit'.
		static Serializer()
		{
			short num = (short)1710425720;
			short num2 = num;
			num = (short)220595832;
			switch (num2 == num)
			{
			}
			num = (short)1860370433;
			if (num != 0)
			{
			}
			num = (short)2086731776;
			short num3 = num;
			num = (short)1337720832;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.CommonContract.Serializer.a = new global::System.Text.UTF8Encoding();
		}

		// Token: 0x0400000B RID: 11
		private static readonly global::System.Text.Encoding a;
	}
}
