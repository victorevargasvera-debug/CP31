using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml.Serialization;
using CommonUtility;

namespace Motorola.CommonCPS.Common.CommonUtility
{
	// Token: 0x02000011 RID: 17
	public class ObjectSeralizeUtility
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00006AE0 File Offset: 0x00004CE0
		public static byte[] Serialize(object instance)
		{
			int a_ = 15;
			short num = (short)923860992;
			short num2 = num;
			num = (short)1595348092;
			short num3 = num;
			num = (short)1549538428;
			byte[] result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)168361984;
				if (num != 0)
				{
				}
				global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("ᬿു♃ⱅⵇ⥉㡋ᵍ㕏⁑㵓㝕㑗㍙♛㭝቟㽡㽣⽥٧౩ͫᱭᵯ፱sή᝷ᑹⅻ╽쉿힉힋\udd8dﶓﮝﶟ", a_));
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(memoryStream, instance);
					byte[] array = memoryStream.ToArray();
					global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("ᬿു♃ⱅⵇ⥉㡋ᵍ㕏⁑㵓㝕㑗㍙♛㭝቟㽡㽣⽥٧౩ͫᱭᵯ፱sή᝷ᑹⅻ╽앿\udb85펇\ud989ﲍ憐ﾕﾙ솛", a_));
					result = array;
				}
				finally
				{
					num = (short)1339686912;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_EF;
							}
							continue;
						case 1:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)2037121026;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_122;
						}
						IL_EF:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)804519937;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_122:;
				}
				break;
			}
			}
			num = (short)597098497;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006C4C File Offset: 0x00004E4C
		public static T Deserialize<T>(byte[] array)
		{
			int a_ = 4;
			short num = (short)152371200;
			short num2 = num;
			num = (short)566988171;
			short num3 = num;
			num = (short)734891403;
			T result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1393623041;
				if (num != 0)
				{
				}
				num = (short)455540736;
				if (num != 0)
				{
				}
				global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("渴砶嬸儺堼尾㕀၂⁄㕆⁈⩊⅌♎⭐㙒❔੖ɘቚ㍜㥞๠ᅢࡤ٦ᵨɪɬŮⱰ⡲㝴ቶṸቺ፼≾\uda80잂力﶐朗쒘", a_));
				global::System.IO.MemoryStream memoryStream = null;
				try
				{
					memoryStream = new global::System.IO.MemoryStream(array);
					result = (T)((object)new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(memoryStream));
				}
				finally
				{
					num = (short)2063990784;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_102;
							}
							continue;
						case 1:
							memoryStream.Close();
							num = (short)62717954;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_137;
						}
						IL_102:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)393871361;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_137:
					memoryStream = null;
					global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("渴砶嬸儺堼尾㕀၂⁄㕆⁈⩊⅌♎⭐㙒❔੖ɘቚ㍜㥞๠ᅢࡤ٦ᵨɪɬŮⱰ⡲ぴ᥶ᵸ♺♼㭾좔", a_));
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006DBC File Offset: 0x00004FBC
		public static byte[] SerializeAndZip(object instance)
		{
			short num = (short)1857224704;
			short num2 = num;
			num = (short)1902727944;
			short num3 = num;
			num = (short)357061384;
			byte[] result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2118844417;
				if (num != 0)
				{
				}
				num = (short)44105728;
				if (num != 0)
				{
				}
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(memoryStream, global::System.IO.Compression.CompressionLevel.Fastest);
					try
					{
						new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Serialize(deflateStream, instance);
						deflateStream.Close();
						result = memoryStream.ToArray();
					}
					finally
					{
						num = (short)754188288;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_FD;
								}
								continue;
							case 1:
								((global::System.IDisposable)deflateStream).Dispose();
								num = (short)1051000834;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_130;
							}
							IL_FD:
							if (deflateStream == null)
							{
								break;
							}
							num = (short)1571291137;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_130:;
					}
				}
				finally
				{
					num = (short)1834090496;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_164;
							}
							continue;
						case 1:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)642973698;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_199;
						}
						IL_164:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)1681195009;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_199:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006F84 File Offset: 0x00005184
		public static T DeserializeAndUnzip<T>(byte[] data)
		{
			int a_ = 4;
			short num = (short)1966931968;
			short num2 = num;
			num = (short)1761673216;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)471334913;
				if (num != 0)
				{
				}
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(data, false);
				T result;
				try
				{
					global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(memoryStream, global::System.IO.Compression.CompressionMode.Decompress);
					try
					{
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						object obj;
						for (;;)
						{
							IL_94:
							switch (num3)
							{
							case 0:
								if (obj is T)
								{
									num = (short)795803649;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_15E;
							case 1:
								goto IL_136;
							case 2:
								goto IL_159;
							}
							goto IL_A7;
						}
						IL_136:
						result = (T)((object)obj);
						goto IL_13F;
						IL_159:
						return result;
						IL_15E:
						throw new global::System.Exception(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::CommonUtility.VersionUtility.b("愴弶尸ᬺ刼崾⭀♂♄㍆楈⽊⡌㱎㑐⅒㱔㙖㕘㉚❜㩞ՠ䍢ቤ٦ᩨ䭪ͬnհ卲ᙴᡶᑸ୺ᱼ୾ꦈﲊﮎ戀뎒Ꞗ", a_), typeof(T)));
						IL_A7:
						num = (short)1701732967;
						short num4 = num;
						num = (short)2106679911;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_13F:
							num = (short)1855389698;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_94;
						default:
							num = (short)1413742592;
							if (num != 0)
							{
							}
							obj = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(deflateStream);
							num = (short)1239875584;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_94;
						}
					}
					finally
					{
						num = (short)1626537984;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1B8;
								}
								continue;
							case 1:
								((global::System.IDisposable)deflateStream).Dispose();
								num = (short)235732994;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1EE;
							}
							IL_1B8:
							if (deflateStream == null)
							{
								break;
							}
							num = (short)1121845249;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1EE:;
					}
				}
				finally
				{
					num = (short)1436483584;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_223;
							}
							continue;
						case 1:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)914358274;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_259;
						}
						IL_223:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)1280704513;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_259:;
				}
				return result;
			}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00007224 File Offset: 0x00005424
		public static void SerializeToFile(string filePath, object instance)
		{
			int a_ = 18;
			short num = (short)1756954625;
			if (num != 0)
			{
			}
			num = (short)1388249088;
			short num2 = num;
			global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("ᡂ੄╆⍈⹊⹌㭎ɐ㙒❔㹖㡘㝚㑜╞Ѡᅢ㡤㱦⁨ժ୬nͰṲᑴͶၸᑺ፼≾\uda80솂킌풎슐ﺖ쒠쪤삨잪좬", a_));
			global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			global::System.IO.Stream stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
			try
			{
				stream.SetLength(0L);
				binaryFormatter.Serialize(stream, instance);
			}
			finally
			{
				num = (short)1060831234;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1649704932;
					short num4 = num;
					num = (short)1300856804;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1777729536;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)stream).Dispose();
							goto IL_12F;
						case 1:
							goto IL_146;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_10F;
							}
							continue;
						}
						IL_10F:
						if (stream != null)
						{
							num = (short)669384704;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_148;
					}
					IL_12F:
					num = (short)814088193;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_146:
				IL_148:;
			}
			global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("ᡂ੄╆⍈⹊⹌㭎ɐ㙒❔㹖㡘㝚㑜╞Ѡᅢ㡤㱦⁨ժ୬nͰṲᑴͶၸᑺ፼≾\uda80욂품킊\ude8c朗ﮖ쮞캠첤쮦첨", a_));
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000073A0 File Offset: 0x000055A0
		public static T DeserializeFromFile<T>(string filePath)
		{
			int a_ = 10;
			global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("怺爼崾⭀♂♄㍆ᩈ⹊㽌♎ぐ㽒㱔ⵖ㱘⥚\\ў⡠ൢͤࡦ᭨٪౬᭮ᡰᱲ᭴⩶≸㥺᡼᡾\ud884\udc86춈ﺌ朗ﮖ\ud99e펠첢좤삨잪좬", a_));
			global::System.IO.Stream stream = null;
			short num;
			T result;
			try
			{
				num = (short)1434124289;
				if (num != 0)
				{
				}
				stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				result = (T)((object)new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(stream));
			}
			finally
			{
				num = (short)603062274;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2114821112;
					short num3 = num;
					num = (short)2005113848;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)486539264;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							stream.Close();
							goto IL_103;
						case 1:
							goto IL_11B;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_E4;
							}
							continue;
						}
						IL_E4:
						if (stream != null)
						{
							num = (short)1386479616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11D;
					}
					IL_103:
					num = (short)1881473025;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				IL_11D:
				stream = null;
				global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("怺爼崾⭀♂♄㍆ᩈ⹊㽌♎ぐ㽒㱔ⵖ㱘⥚\\ў⡠ൢͤࡦ᭨٪౬᭮ᡰᱲ᭴⩶≸㹺፼᭾\udc80\ud882솄愈ﾌﾒﲔﲘ\udd9a철첤쮦첨", a_));
			}
			num = (short)336396288;
			short num4 = num;
			return result;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000751C File Offset: 0x0000571C
		public static T BinaryCloneInstance<T>(T input)
		{
			short num = (short)1758134273;
			if (num != 0)
			{
			}
			num = (short)1108869120;
			short num2 = num;
			global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter binaryFormatter = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			T result;
			try
			{
				binaryFormatter.Serialize(memoryStream, input);
				memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
				result = (T)((object)binaryFormatter.Deserialize(memoryStream));
			}
			finally
			{
				num = (short)315031554;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1707903275;
					short num4 = num;
					num = (short)1623951659;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2055798784;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							goto IL_124;
						case 1:
							goto IL_13C;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_103;
							}
							continue;
						}
						IL_103:
						if (memoryStream != null)
						{
							num = (short)1092550656;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13E;
					}
					IL_124:
					num = (short)1894121473;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_13C:
				IL_13E:;
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000767C File Offset: 0x0000587C
		public static byte[] XmlSerialize(object instance)
		{
			int a_ = 7;
			short num = (short)1640890369;
			if (num != 0)
			{
			}
			num = (short)1638989824;
			short num2 = num;
			global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("挷甹帻吽┿⅁ぃᕅⵇ㡉╋⽍㱏㭑⹓㍕⩗ݙݛ᝝๟ѡୣᑥէ୩ᡫݭὯᱱ⥳⵵㩷ό᭻᝽\udf81\udf83\ude85\udf8bﮑ歹鍊쎝", a_));
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(instance.GetType());
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			byte[] result;
			try
			{
				xmlSerializer.Serialize(memoryStream, instance);
				byte[] array = memoryStream.ToArray();
				global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("挷甹帻吽┿⅁ぃᕅⵇ㡉╋⽍㱏㭑⹓㍕⩗ݙݛ᝝๟ѡୣᑥէ୩ᡫݭὯᱱ⥳⵵㵷ᑹ᡻⍽\udb7f\uda81\udb87ﺋﺑﶓﶗ잙", a_));
				result = array;
			}
			finally
			{
				num = (short)84606978;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1132999482;
					short num4 = num;
					num = (short)1037054778;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1529151488;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							goto IL_144;
						case 1:
							goto IL_15B;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_123;
							}
							continue;
						}
						IL_123:
						if (memoryStream != null)
						{
							num = (short)269352960;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15D;
					}
					IL_144:
					num = (short)1378549761;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_15B:
				IL_15D:;
			}
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000077F8 File Offset: 0x000059F8
		public static T XmlDeserialize<T>(byte[] array)
		{
			int a_ = 15;
			short num = (short)1278017537;
			if (num != 0)
			{
			}
			num = (short)1919549440;
			short num2 = num;
			global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("ᬿു♃ⱅⵇ⥉㡋ᵍ㕏⁑㵓㝕㑗㍙♛㭝቟㽡㽣⽥٧౩ͫᱭᵯ፱sή᝷ᑹⅻ╽쉿힉힋획ﶏﺑ킓ﾙ솟캡춣\udca5춧", a_));
			global::System.IO.MemoryStream memoryStream = null;
			T result;
			try
			{
				memoryStream = new global::System.IO.MemoryStream(array);
				result = (T)((object)new global::System.Xml.Serialization.XmlSerializer(typeof(T)).Deserialize(memoryStream));
			}
			finally
			{
				num = (short)666763266;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1415225054;
					short num4 = num;
					num = (short)381787870;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1765212160;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							memoryStream.Close();
							goto IL_132;
						case 1:
							goto IL_14A;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_111;
							}
							continue;
						}
						IL_111:
						if (memoryStream != null)
						{
							num = (short)458424320;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14C;
					}
					IL_132:
					num = (short)1284374529;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_14A:
				IL_14C:
				memoryStream = null;
				global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("ᬿു♃ⱅⵇ⥉㡋ᵍ㕏⁑㵓㝕㑗㍙♛㭝቟㽡㽣⽥٧౩ͫᱭᵯ፱sή᝷ᑹⅻ╽앿\udb85펇튉풏ﶛ즟\ud8a1솣ﮥ", a_));
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007978 File Offset: 0x00005B78
		public static void XmlSerializeToFile(string xmlFilePath, object instance)
		{
			int a_ = 9;
			short num = (short)1554251777;
			if (num != 0)
			{
			}
			num = (short)188874752;
			short num2 = num;
			global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("愹猻尽⨿❁❃㉅ᭇ⽉㹋❍ㅏ㹑㵓ⱕ㵗⡙ś՝⥟ౡɣ॥ᩧݩ൫ᩭ᥯ᵱᩳ⭵⍷㡹᥻᥽\ud983\udd85킇\udd8dﶓﮝ춡쾥쒧쾩", a_));
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(instance.GetType());
			global::System.IO.Stream stream = new global::System.IO.FileStream(xmlFilePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
			try
			{
				stream.SetLength(0L);
				xmlSerializer.Serialize(stream, instance);
			}
			finally
			{
				num = (short)83165186;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1806947040;
					short num4 = num;
					num = (short)1790169824;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)692125696;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)stream).Dispose();
							goto IL_12F;
						case 1:
							goto IL_147;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_110;
							}
							continue;
						}
						IL_110:
						if (stream != null)
						{
							num = (short)667353088;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_149;
					}
					IL_12F:
					num = (short)2085158913;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_147:
				IL_149:;
			}
			global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("愹猻尽⨿❁❃㉅ᭇ⽉㹋❍ㅏ㹑㵓ⱕ㵗⡙ś՝⥟ౡɣ॥ᩧݩ൫ᩭ᥯ᵱᩳ⭵⍷㽹ቻ᩽\udd7f\ud981\udc83\ud989ﲍ憐ﾕﾙ좛쮡좣쎥", a_));
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00007AF4 File Offset: 0x00005CF4
		public static T XmlDeserializeFromFile<T>(string xmlFilePath)
		{
			int a_ = 6;
			global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("氶瘸夺圼娾≀㝂ᙄ≆㭈≊ⱌ⍎㡐⥒ご╖јZᑜㅞݠౢᝤ੦ࡨὪѬnὰ⹲⹴㕶ᱸᱺᑼᅾ\udc80\ud882\udd84쾊ﲎﲔ爵톢쪤쪦슪솬쪮", a_));
			global::System.IO.Stream stream = null;
			short num;
			T result;
			try
			{
				num = (short)263520257;
				if (num != 0)
				{
				}
				global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));
				stream = new global::System.IO.FileStream(xmlFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				result = (T)((object)xmlSerializer.Deserialize(stream));
			}
			finally
			{
				num = (short)828178434;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)832601956;
					short num3 = num;
					num = (short)663781220;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2097217536;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							stream.Close();
							goto IL_10C;
						case 1:
							goto IL_125;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_ED;
							}
							continue;
						}
						IL_ED:
						if (stream != null)
						{
							num = (short)648937472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_127;
					}
					IL_10C:
					num = (short)127598593;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_125:
				IL_127:
				stream = null;
				global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("氶瘸夺圼娾≀㝂ᙄ≆㭈≊ⱌ⍎㡐⥒ご╖јZᑜㅞݠౢᝤ੦ࡨὪѬnὰ⹲⹴㉶᝸ὺ⁼⑾\ud980쎆ﶎ璉ﺖﺚ\udb9c캠캢캦얨캪", a_));
			}
			num = (short)404946944;
			short num4 = num;
			return result;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00007C78 File Offset: 0x00005E78
		public static T JsonToObject<T>(string jsonString)
		{
			global::System.Runtime.Serialization.Json.DataContractJsonSerializer dataContractJsonSerializer = new global::System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(T));
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Text.Encoding.UTF8.GetBytes(jsonString));
			short num;
			T result;
			try
			{
				num = (short)1918763009;
				if (num != 0)
				{
				}
				result = (T)((object)dataContractJsonSerializer.ReadObject(memoryStream));
			}
			finally
			{
				num = (short)293011458;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1043124783;
					short num3 = num;
					num = (short)213701167;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)215416832;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							goto IL_F7;
						case 1:
							goto IL_10E;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_D7;
							}
							continue;
						}
						IL_D7:
						if (memoryStream != null)
						{
							num = (short)458686464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_110;
					}
					IL_F7:
					num = (short)1909129217;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10E:
				IL_110:;
			}
			num = (short)148897792;
			short num4 = num;
			return result;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00007DD4 File Offset: 0x00005FD4
		public static string ObjectToJson<T>(T data)
		{
			global::System.Runtime.Serialization.Json.DataContractJsonSerializer dataContractJsonSerializer = new global::System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(T));
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			string @string;
			short num;
			try
			{
				dataContractJsonSerializer.WriteObject(memoryStream, data);
				@string = global::System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
			}
			finally
			{
				num = (short)1800404994;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)790879965;
					short num3 = num;
					num = (short)1594089181;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)325058560;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							goto IL_D7;
						case 1:
							goto IL_EF;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_B8;
							}
							continue;
						}
						IL_B8:
						if (memoryStream != null)
						{
							num = (short)915472384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F1;
					}
					IL_D7:
					num = (short)1217789953;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EF:
				IL_F1:;
			}
			num = (short)145227776;
			short num4 = num;
			num = (short)1583218689;
			if (num != 0)
			{
			}
			return @string;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007F38 File Offset: 0x00006138
		public static T DataContract_DeserializeFromFile<T>(string filePath)
		{
			int a_ = 3;
			global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("漳礵娷倹夻崽㐿ᅁ⅃㑅ⅇ⭉⁋❍⩏㝑♓୕͗ፙ㉛㡝ཟၡॣݥᱧͩͫmⵯ⥱㙳፵ί፹ቻ⍽\udb7f욁ﲏﮑ\ude97쮡좣쎥", a_));
			global::System.IO.Stream stream = null;
			T result;
			short num;
			try
			{
				stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				result = (T)((object)new global::System.Runtime.Serialization.DataContractSerializer(typeof(T)).ReadObject(stream));
			}
			finally
			{
				num = (short)605290498;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)147965185;
					short num3 = num;
					num = (short)805029121;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1698496512;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							stream.Close();
							goto IL_E5;
						case 1:
							goto IL_FE;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_C6;
							}
							continue;
						}
						IL_C6:
						if (stream != null)
						{
							num = (short)1342504960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_100;
					}
					IL_E5:
					num = (short)164298753;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FE:
				IL_100:
				stream = null;
				global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("漳礵娷倹夻崽㐿ᅁ⅃㑅ⅇ⭉⁋❍⩏㝑♓୕͗ፙ㉛㡝ཟၡॣݥᱧͩͫmⵯ⥱ㅳᡵᱷ❹❻㩽튓\uda9b첟잡念", a_));
			}
			num = (short)702349312;
			short num4 = num;
			num = (short)305528833;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000080C0 File Offset: 0x000062C0
		public static void DataContract_SerializeToFile(string filePath, object instance)
		{
			int a_ = 12;
			global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(instance.GetType());
			global::System.Diagnostics.Trace.WriteLine(global::CommonUtility.VersionUtility.b("昼瀾⍀⥂⁄⑆㵈ᡊ⡌㵎㡐㉒㥔㹖⍘㹚⽜ɞ㩠⩢୤Ŧ٨ᥪl๮հᩲᩴ᥶⑸⁺㽼᩾\uda86튈\ud88aﶎ璉ﺖﺚ즜쪢즤슦", a_));
			global::System.IO.Stream stream = new global::System.IO.FileStream(filePath, global::System.IO.FileMode.OpenOrCreate, global::System.IO.FileAccess.ReadWrite);
			short num;
			try
			{
				stream.SetLength(0L);
				dataContractSerializer.WriteObject(stream, instance);
			}
			finally
			{
				num = (short)230424578;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)166718662;
					short num3 = num;
					num = (short)37547206;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)647757824;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)stream).Dispose();
							goto IL_E1;
						case 1:
							goto IL_F9;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_C2;
							}
							continue;
						}
						IL_C2:
						if (stream != null)
						{
							num = (short)428212224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FB;
					}
					IL_E1:
					num = (short)786759681;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F9:
				IL_FB:;
			}
			num = (short)760217600;
			short num4 = num;
			num = (short)247660545;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000822C File Offset: 0x0000642C
		public static global::System.Collections.Generic.List<string> GetNonSerializableSubTypes(global::System.Type parent)
		{
			short num = (short)364707840;
			switch (num)
			{
			default:
			{
				num = (short)317284556;
				short num2 = num;
				num = (short)52650188;
				int num4;
				global::System.Collections.Generic.HashSet<string> hashSet;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_1B6:
					int num3;
					global::System.Collections.Generic.List<global::System.Type> list;
					if (num3 >= list.Count)
					{
						num = (short)800325633;
						num4 = (int)((global::System.IntPtr)num);
					}
					else
					{
						int a_ = 0;
						global::System.Collections.Generic.HashSet<string> a_2;
						global::System.Collections.Generic.List<global::System.Type> collection = global::Motorola.CommonCPS.Common.CommonUtility.ObjectSeralizeUtility.a(list[num3], a_2, hashSet, a_);
						list.AddRange(collection);
						num3++;
						num = (short)1630863364;
						num4 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				case 1:
					goto IL_7B;
				default:
				{
					num = (short)1040711680;
					short num5 = num;
					goto IL_7B;
				}
				}
				for (;;)
				{
					IL_DA:
					switch (num4)
					{
					case 0:
						goto IL_19C;
					case 1:
						goto IL_1DC;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_F9;
						}
						continue;
					case 3:
						goto IL_1B6;
					case 4:
						goto IL_19C;
					case 5:
						goto IL_117;
					}
					IL_F9:
					if (null == parent)
					{
						num = (short)731512837;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.Collections.Generic.HashSet<string> a_2 = new global::System.Collections.Generic.HashSet<string>();
					hashSet = new global::System.Collections.Generic.HashSet<string>();
					global::System.Collections.Generic.List<global::System.Type> list = new global::System.Collections.Generic.List<global::System.Type>();
					int a_ = 0;
					global::System.Collections.Generic.List<global::System.Type> collection = global::Motorola.CommonCPS.Common.CommonUtility.ObjectSeralizeUtility.a(parent, a_2, hashSet, a_);
					list.AddRange(collection);
					int num3 = 0;
					num = (short)361824256;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_19C:
					num = (short)81920003;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_117:
				return null;
				IL_1DC:
				return hashSet.ToList<string>();
				IL_7B:
				num = (short)913113089;
				if (num != 0)
				{
				}
				num = (short)1930887168;
				if (num != 0)
				{
				}
				num = (short)237895682;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_DA;
			}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00008420 File Offset: 0x00006620
		private static global::System.Collections.Generic.List<global::System.Type> a(global::System.Type A_0, global::System.Collections.Generic.HashSet<string> A_1, global::System.Collections.Generic.HashSet<string> A_2, int A_3)
		{
			int a_ = 1;
			short num = (short)937361408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C0;
				}
				global::System.Collections.Generic.List<global::System.Type> list;
				string item;
				for (;;)
				{
					IL_31:
					int num3;
					int num5;
					global::System.Reflection.PropertyInfo[] properties;
					switch (num2)
					{
					case 0:
						goto IL_605;
					case 1:
						goto IL_286;
					case 2:
						num = (short)1820131329;
						if (num != 0)
						{
						}
						num = (short)129237010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_286;
					case 4:
					{
						global::System.Type type;
						if (type != A_0)
						{
							num = (short)897318927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_124;
					}
					case 5:
						goto IL_124;
					case 6:
						num = (short)1336082457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						list.AddRange(global::Motorola.CommonCPS.Common.CommonUtility.ObjectSeralizeUtility.a(propertyInfo.PropertyType, A_1, A_2, A_3));
						num = (short)211419139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						global::System.Type[] genericArguments = propertyInfo.PropertyType.GetGenericArguments();
						num3 = 0;
						num = (short)988807180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (propertyInfo.PropertyType.IsGenericType)
						{
							num = (short)1868890120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)204144670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_33F;
					case 11:
						while (!global::Motorola.CommonCPS.Common.CommonUtility.ObjectSeralizeUtility.a(A_0))
						{
							num = (short)1362500845;
							short num4 = num;
							num = (short)1155865837;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)337444864;
								if (num != 0)
								{
								}
								num = (short)2008481808;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_31;
							}
						}
						goto IL_2A7;
					case 12:
						goto IL_60A;
					case 13:
						num = (short)934084636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_378;
					case 15:
					{
						global::System.Type type;
						list.AddRange(global::Motorola.CommonCPS.Common.CommonUtility.ObjectSeralizeUtility.a(type, A_1, A_2, A_3));
						num = (short)546373637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						A_2.Add(item);
						num = (short)799146013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_60A;
					case 18:
						if (!A_0.IsInterface)
						{
							num = (short)767361056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37D;
					case 19:
						if (A_1.Contains(item))
						{
							num = (short)925237275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1502347284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (++A_3 > 7)
						{
							num = (short)1694498816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1887305759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						if (num5 >= properties.Length)
						{
							num = (short)1167458318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Reflection.PropertyInfo propertyInfo = properties[num5];
						num = (short)764739593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (!string.IsNullOrEmpty(A_0.FullName))
						{
							num = (short)312672269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4ED;
					case 23:
						goto IL_47F;
					case 24:
					{
						global::System.Type[] genericArguments;
						if (num3 >= genericArguments.Length)
						{
							num = (short)634650650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Type type = genericArguments[num3];
						num = (short)1564803076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (!(A_0 == typeof(string)))
						{
							num = (short)1749155842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37D;
					case 26:
						num = (short)1212678145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						return list;
					case 28:
					{
						num = (short)34275328;
						short num6 = num;
						if (A_0.FullName.StartsWith(global::CommonUtility.VersionUtility.b("愱䴳䔵䰷弹儻ွ", a_)))
						{
							num = (short)1765802007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4ED;
					}
					case 29:
						goto IL_2A7;
					case 30:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (propertyInfo.GetType() != A_0)
						{
							num = (short)1526595591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_286;
					}
					case 31:
						if (!A_0.IsValueType)
						{
							num = (short)1148190726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37D;
					case 32:
						num = (short)1719271446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_33F;
					}
					goto IL_C0;
					IL_124:
					num3++;
					num = (short)1850540049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_286:
					num5++;
					num = (short)534511649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A7:
					properties = A_0.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic);
					num5 = 0;
					num = (short)857931786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33F:
					num = (short)630652949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4ED:
					num = (short)1719140363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_60A:
					num = (short)618725400;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_378:
				A_1.Add(item);
				return list;
				IL_37D:
				A_1.Add(item);
				return list;
				IL_47F:
				goto IL_37D;
				IL_605:
				return new global::System.Collections.Generic.List<global::System.Type>
				{
					A_0
				};
				IL_C0:
				list = new global::System.Collections.Generic.List<global::System.Type>();
				item = string.Format(global::CommonUtility.VersionUtility.b("䤱г䬵ᠷ䄹഻䌽", a_), A_0.Name, A_0);
				num = (short)1296498707;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00008A80 File Offset: 0x00006C80
		private static bool a(global::System.Type A_0)
		{
			short num = (short)1305753688;
			short num2 = num;
			num = (short)1078147160;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1116667904;
				short num3 = num;
				num = (short)868286465;
				if (num != 0)
				{
				}
				num = (short)41091072;
				if (num != 0)
				{
				}
				if (A_0.IsSerializable)
				{
					return true;
				}
				break;
			}
			}
			return global::System.Attribute.IsDefined(A_0, typeof(global::System.SerializableAttribute));
		}

		// Token: 0x0400001C RID: 28
		private const int a = 7;

		// Token: 0x0400001D RID: 29
		private const string b = "System.";
	}
}
