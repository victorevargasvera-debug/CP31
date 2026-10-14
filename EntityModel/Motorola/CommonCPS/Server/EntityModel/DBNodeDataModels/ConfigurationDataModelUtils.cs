using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels
{
	// Token: 0x020001BE RID: 446
	public class ConfigurationDataModelUtils
	{
		// Token: 0x060016D8 RID: 5848 RVA: 0x000F5EA0 File Offset: 0x000F40A0
		public static byte[] SerializeAndZip(object instance)
		{
			short num = (short)1539630066;
			short num2 = num;
			num = (short)1624564722;
			byte[] result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1574174721;
				if (num != 0)
				{
				}
				num = (short)1712914432;
				if (num != 0)
				{
				}
				num = (short)606208000;
				switch (num)
				{
				default:
				{
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
					try
					{
						global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(memoryStream, global::System.IO.Compression.CompressionLevel.Fastest);
						try
						{
							global::System.Xml.XmlDictionaryWriter xmlDictionaryWriter = global::System.Xml.XmlDictionaryWriter.CreateBinaryWriter(deflateStream);
							try
							{
								new global::System.Runtime.Serialization.DataContractSerializer(instance.GetType()).WriteObject(xmlDictionaryWriter, instance);
								xmlDictionaryWriter.Close();
								result = memoryStream.ToArray();
							}
							finally
							{
								num = (short)1353908224;
								int num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_100;
										}
										continue;
									case 1:
										goto IL_138;
									case 2:
										((global::System.IDisposable)xmlDictionaryWriter).Dispose();
										num = (short)1165033473;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_100:
									if (xmlDictionaryWriter == null)
									{
										break;
									}
									num = (short)1627717634;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_138:;
							}
						}
						finally
						{
							num = (short)1708982272;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_16E;
									}
									continue;
								case 1:
									goto IL_1A4;
								case 2:
									((global::System.IDisposable)deflateStream).Dispose();
									num = (short)456327169;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_16E:
								if (deflateStream == null)
								{
									break;
								}
								num = (short)2122514434;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1A4:;
						}
					}
					finally
					{
						num = (short)1294860288;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1D9;
								}
								continue;
							case 1:
								goto IL_20F;
							case 2:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)624164865;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1D9:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)1561526274;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_20F:;
					}
					break;
				}
				}
				break;
			}
			num = (short)1359413248;
			short num4 = num;
			return result;
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x000F6134 File Offset: 0x000F4334
		public static byte[] SerializeAndZip<T>(object instance)
		{
			short num = (short)1491206144;
			short num2 = num;
			num = (short)1287782401;
			if (num != 0)
			{
			}
			num = (short)1748238336;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				byte[] result;
				try
				{
					global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(memoryStream, global::System.IO.Compression.CompressionLevel.Fastest, true);
					try
					{
						global::System.Xml.XmlDictionaryWriter xmlDictionaryWriter = global::System.Xml.XmlDictionaryWriter.CreateBinaryWriter(new global::System.IO.BufferedStream(deflateStream));
						try
						{
							switch (0)
							{
							case 0:
								goto IL_C0;
							}
							global::System.Collections.Generic.List<global::System.Type> list;
							int num5;
							object[] customAttributes;
							for (;;)
							{
								IL_99:
								switch (num3)
								{
								case 0:
								{
									object obj;
									if (obj is global::System.Runtime.Serialization.KnownTypeAttribute)
									{
										num = (short)701890562;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A5;
								}
								case 1:
								{
									num = (short)1163749002;
									short num4 = num;
									num = (short)911369866;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_13D;
									default:
										goto IL_23C;
									}
									break;
								}
								case 2:
								{
									object obj;
									list.Add((obj as global::System.Runtime.Serialization.KnownTypeAttribute).Type);
									num = (short)1781661703;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_13D;
								case 4:
									goto IL_13D;
								case 5:
									new global::System.Runtime.Serialization.DataContractSerializer(typeof(T)).WriteObject(xmlDictionaryWriter, instance);
									xmlDictionaryWriter.Close();
									result = memoryStream.ToArray();
									num = (short)930283521;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (num5 >= customAttributes.Length)
									{
										num = (short)1481637893;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj = customAttributes[num5];
									num = (short)696778752;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_1A5;
								}
								goto IL_C0;
								IL_13D:
								num = (short)14352390;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A5:
								num5++;
								num = (short)757071875;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_23C:
							num = (short)1237188608;
							if (num != 0)
							{
							}
							return result;
							IL_C0:
							list = new global::System.Collections.Generic.List<global::System.Type>();
							customAttributes = instance.GetType().GetCustomAttributes(typeof(global::System.Runtime.Serialization.KnownTypeAttribute), true);
							num5 = 0;
							num = (short)207552516;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_99;
						}
						finally
						{
							num = (short)1124532224;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_289;
									}
									continue;
								case 1:
									goto IL_2C1;
								case 2:
									((global::System.IDisposable)xmlDictionaryWriter).Dispose();
									num = (short)165871617;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_289:
								if (xmlDictionaryWriter == null)
								{
									break;
								}
								num = (short)1847132162;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_2C1:;
						}
					}
					finally
					{
						num = (short)2071461888;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2F7;
								}
								continue;
							case 1:
								goto IL_32E;
							case 2:
								((global::System.IDisposable)deflateStream).Dispose();
								num = (short)1985413121;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_2F7:
							if (deflateStream == null)
							{
								break;
							}
							num = (short)1847197698;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_32E:;
					}
				}
				finally
				{
					num = (short)366739456;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_365;
							}
							continue;
						case 1:
							goto IL_39B;
						case 2:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)995622913;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_365:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)164167682;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_39B:;
				}
				return result;
			}
			}
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x000F6530 File Offset: 0x000F4730
		public static T DeserializeAndUnzip<T>(byte[] data)
		{
			int a_ = 9;
			short num;
			T result;
			try
			{
				num = (short)159776768;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1225850881;
					if (num != 0)
					{
					}
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(data, false);
					try
					{
						global::System.IO.Compression.DeflateStream deflateStream = new global::System.IO.Compression.DeflateStream(memoryStream, global::System.IO.Compression.CompressionMode.Decompress);
						try
						{
							global::System.Xml.XmlDictionaryReader xmlDictionaryReader = global::System.Xml.XmlDictionaryReader.CreateBinaryReader(new global::System.IO.BufferedStream(deflateStream), new global::System.Xml.XmlDictionaryReaderQuotas
							{
								MaxArrayLength = 8388608,
								MaxStringContentLength = 8388608
							});
							try
							{
								switch (0)
								{
								case 0:
									goto IL_C4;
								}
								global::System.Collections.Generic.List<global::System.Type> list;
								int num3;
								object[] customAttributes;
								for (;;)
								{
									IL_95:
									switch (num2)
									{
									case 0:
									{
										object obj = new global::System.Runtime.Serialization.DataContractSerializer(typeof(T), list).ReadObject(xmlDictionaryReader);
										num = (short)2096889858;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
									{
										object obj2;
										list.Add((obj2 as global::System.Runtime.Serialization.KnownTypeAttribute).Type);
										num = (short)359661573;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										object obj;
										if (obj is T)
										{
											num = (short)737083400;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_258;
									}
									case 3:
									{
										object obj2;
										if (obj2 is global::System.Runtime.Serialization.KnownTypeAttribute)
										{
											num = (short)2127691777;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1CB;
									}
									case 4:
									{
										if (num3 >= customAttributes.Length)
										{
											num = (short)377946112;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										object obj2 = customAttributes[num3];
										num = (short)342556675;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										goto IL_1CB;
									case 6:
										goto IL_218;
									case 7:
										goto IL_1C6;
									case 8:
									{
										object obj;
										result = (T)((object)obj);
										num = (short)1450639367;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										goto IL_218;
									}
									goto IL_C4;
									IL_1CB:
									num3++;
									num = (short)586088457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_218:
									num = (short)1207304196;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1C6:
								goto IL_5BC;
								IL_258:
								throw new global::System.Exception(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("匆愈渊ⴌ怎猐礒瀔琖洘㬚礜稞删䘢圤並䠨䜪䐬售吰圲ᔴ䀶堸䠺ᴼ儾⹀㝂敄⑆♈♊㵌⹎═㩒㝔㭖㱘筚⩜㙞ᕠୢ䕤ᱦ奨ᙪ", a_), typeof(T)));
								IL_C4:
								global::System.Reflection.MemberInfo typeFromHandle = typeof(T);
								list = new global::System.Collections.Generic.List<global::System.Type>();
								customAttributes = typeFromHandle.GetCustomAttributes(typeof(global::System.Runtime.Serialization.KnownTypeAttribute), true);
								num3 = 0;
								num = (short)1377370118;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_95;
							}
							finally
							{
								num = (short)1256652802;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										((global::System.IDisposable)xmlDictionaryReader).Dispose();
										num = (short)1147338753;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_2EA;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_2B3;
										}
										continue;
									}
									IL_2B3:
									if (xmlDictionaryReader == null)
									{
										break;
									}
									num = (short)1902575616;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2EA:;
							}
						}
						finally
						{
							num = (short)1375076354;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)deflateStream).Dispose();
									num = (short)2018246657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_355;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_320;
									}
									continue;
								}
								IL_320:
								if (deflateStream == null)
								{
									break;
								}
								num = (short)914227200;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_355:;
						}
					}
					finally
					{
						num = (short)1232666626;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)127962154;
								short num4 = num;
								num = (short)1886817322;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num = (short)557449216;
									if (num != 0)
									{
									}
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)30081025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_413;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_38B;
								}
								continue;
							}
							IL_38B:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)1277886464;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_413:;
					}
					break;
				}
				}
			}
			catch
			{
				goto IL_5AE;
			}
			global::System.IO.MemoryStream memoryStream2;
			try
			{
				IL_41C:
				global::System.IO.Compression.DeflateStream deflateStream2 = new global::System.IO.Compression.DeflateStream(memoryStream2, global::System.IO.Compression.CompressionMode.Decompress);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_445;
					}
					int num2;
					object obj3;
					for (;;)
					{
						IL_432:
						switch (num2)
						{
						case 0:
							result = (T)((object)obj3);
							num = (short)721682433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_4A7;
						case 2:
							if (obj3 is T)
							{
								num = (short)1290665984;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4AC;
						}
						goto IL_445;
					}
					IL_4A7:
					goto IL_5BC;
					IL_4AC:
					throw new global::System.Exception(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("匆愈渊ⴌ怎猐礒瀔琖洘㬚礜稞删䘢圤並䠨䜪䐬售吰圲ᔴ䀶堸䠺ᴼ儾⹀㝂敄⑆♈♊㵌⹎═㩒㝔㭖㱘筚⩜㙞ᕠୢ䕤ᱦ奨ᙪ", a_), typeof(T)));
					IL_445:
					obj3 = new global::System.Runtime.Serialization.Formatters.Binary.BinaryFormatter().Deserialize(deflateStream2);
					num = (short)1044316162;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_432;
				}
				finally
				{
					num = (short)436011010;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)deflateStream2).Dispose();
							num = (short)280821761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_53E;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_506;
							}
							continue;
						}
						IL_506:
						if (deflateStream2 == null)
						{
							break;
						}
						num = (short)1929641984;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_53E:;
				}
			}
			finally
			{
				num = (short)1131151362;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						((global::System.IDisposable)memoryStream2).Dispose();
						num = (short)1310457857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_5AB;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_573;
						}
						continue;
					}
					IL_573:
					if (memoryStream2 == null)
					{
						break;
					}
					num = (short)1555890176;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_5AB:;
			}
			IL_5AE:
			memoryStream2 = new global::System.IO.MemoryStream(data, false);
			goto IL_41C;
			IL_5BC:
			num = (short)149291008;
			short num5 = num;
			return result;
		}
	}
}
