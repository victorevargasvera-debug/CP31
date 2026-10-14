using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using Motorola.Security.SamlCommonUtility.DMHttpClients;

namespace Motorola.Security.SamlCommonUtility
{
	// Token: 0x0200001C RID: 28
	public static class Serializers
	{
		// Token: 0x06000056 RID: 86 RVA: 0x0000790C File Offset: 0x00005B0C
		public static byte[] BinarySerialize<T>(T obj)
		{
			int a_ = 13;
			short num;
			byte[] result;
			try
			{
				num = (short)1606877184;
				switch (num)
				{
				default:
				{
					num = (short)1507983361;
					if (num != 0)
					{
					}
					global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(T));
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
					try
					{
						global::System.Xml.XmlDictionaryWriter xmlDictionaryWriter = global::System.Xml.XmlDictionaryWriter.CreateBinaryWriter(memoryStream);
						try
						{
							dataContractSerializer.WriteObject(xmlDictionaryWriter, obj);
							xmlDictionaryWriter.Flush();
							result = memoryStream.ToArray();
						}
						finally
						{
							num = (short)1725562881;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_F7;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_C1;
									}
									continue;
								case 2:
									((global::System.IDisposable)xmlDictionaryWriter).Dispose();
									num = (short)638386176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_C1:
								if (xmlDictionaryWriter == null)
								{
									break;
								}
								num = (short)1401225218;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F7:;
						}
					}
					finally
					{
						num = (short)607584257;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_164;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_12C;
								}
								continue;
							case 2:
								goto IL_146;
							}
							IL_12C:
							if (memoryStream != null)
							{
								num = (short)1560412162;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_164;
							IL_146:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)184942592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_164:
							num = (short)441716040;
							short num3 = num;
							num = (short)592383304;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_146;
							default:
								goto IL_19A;
							}
						}
						IL_19A:
						num = (short)273874944;
						if (num != 0)
						{
						}
					}
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("\uddb7좹햻\udfbd겿ꯁ뻃Ʂ볇ꏉꏋꃍ韑ꛓꓕ럗꣙ﻝ", a_) + ex.Message);
			}
			num = (short)642514944;
			short num4 = num;
			return result;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007B64 File Offset: 0x00005D64
		public static T BinaryDeserialize<T>(byte[] serializeData)
		{
			int a_ = 8;
			short num = (short)934215680;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				T result;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_DC;
						try
						{
							for (;;)
							{
								IL_DC:
								global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(T));
								global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(serializeData);
								try
								{
									global::System.Xml.XmlDictionaryReader xmlDictionaryReader = global::System.Xml.XmlDictionaryReader.CreateBinaryReader(memoryStream, global::System.Xml.XmlDictionaryReaderQuotas.Max);
									try
									{
										result = (T)((object)dataContractSerializer.ReadObject(xmlDictionaryReader));
									}
									finally
									{
										num = (short)230031361;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_17B;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_146;
												}
												continue;
											case 2:
												((global::System.IDisposable)xmlDictionaryReader).Dispose();
												num = (short)2102394880;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_146:
											if (xmlDictionaryReader == null)
											{
												break;
											}
											num = (short)1942618114;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_17B:;
									}
								}
								finally
								{
									num = (short)749207553;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_1E9;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_1B2;
											}
											continue;
										case 2:
											((global::System.IDisposable)memoryStream).Dispose();
											num = (short)1110507520;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_1B2:
										if (memoryStream == null)
										{
											break;
										}
										num = (short)494075906;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_1E9:;
								}
								num = (short)1531667414;
								short num3 = num;
								num = (short)1733911510;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_221;
								}
							}
							IL_221:
							num = (short)1245184;
							if (num != 0)
							{
							}
							return result;
						}
						catch (global::System.Exception ex)
						{
							throw new global::System.Exception(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("횲잴\udeb6\ud8b8ힺ풼얾ꃀ럂계꣆ꟈ裌뷎ꏐ볒꟔律", a_) + ex.Message);
						}
						goto IL_25E;
					case 1:
						if (serializeData.Length != 0)
						{
							num = (short)1001586688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29A;
					case 2:
						if (serializeData != null)
						{
							num = (short)58195971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29A;
					case 3:
						goto IL_25E;
					}
					goto IL_47;
					IL_25E:
					num = (short)767688705;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_29A:
				return default(T);
				IL_47:
				result = default(T);
				num = (short)1604911104;
				short num4 = num;
				num = (short)2138439681;
				if (num != 0)
				{
				}
				num = (short)1810563074;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007E64 File Offset: 0x00006064
		public static string Serialize<T>(T obj)
		{
			int a_ = 3;
			short num;
			string result;
			try
			{
				num = (short)661454848;
				switch (num)
				{
				default:
				{
					global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));
					global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture);
					try
					{
						xmlSerializer.Serialize(stringWriter, obj);
						result = stringWriter.ToString();
					}
					finally
					{
						num = (short)1805451265;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_C8;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_90;
								}
								continue;
							case 2:
								goto IL_AB;
							}
							IL_90:
							if (stringWriter != null)
							{
								num = (short)1406337026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C8;
							IL_AB:
							((global::System.IDisposable)stringWriter).Dispose();
							num = (short)173932544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C8:
							num = (short)1353556905;
							short num3 = num;
							num = (short)40674217;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_AB;
							default:
								goto IL_FD;
							}
						}
						IL_FD:
						num = (short)4587520;
						if (num != 0)
						{
						}
					}
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ﾫ쮭슯\udbb1햳\udab5톷삹\uddbb쪽ꦿ귁꫃跇룉뻋ꇍꋏ", a_) + ex.Message);
			}
			num = (short)1639251969;
			if (num != 0)
			{
			}
			num = (short)466878464;
			short num4 = num;
			return result;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000802C File Offset: 0x0000622C
		public static T Deserialize<T>(string xml)
		{
			int a_ = 10;
			short num = (short)2105999360;
			switch (num)
			{
			default:
			{
				num = (short)461701120;
				short num2 = num;
				if (!string.IsNullOrWhiteSpace(xml))
				{
					T result;
					try
					{
						num = (short)2132606977;
						if (num != 0)
						{
						}
						global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));
						global::System.IO.StringReader stringReader = new global::System.IO.StringReader(xml);
						try
						{
							result = (T)((object)xmlSerializer.Deserialize(stringReader));
						}
						finally
						{
							num = (short)605552641;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_126;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_EC;
									}
									continue;
								case 2:
									goto IL_108;
								}
								IL_EC:
								if (stringReader != null)
								{
									num = (short)1825570818;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_126;
								IL_108:
								((global::System.IDisposable)stringReader).Dispose();
								num = (short)364904448;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_126:
								num = (short)1783155632;
								short num4 = num;
								num = (short)1969933232;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_108;
								default:
									goto IL_15C;
								}
							}
							IL_15C:
							num = (short)619839488;
							if (num != 0)
							{
							}
						}
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.Exception(global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("킴얶킸\udaba톼횾므ꋂ뇄껆ꛈꗊ諎ꏐꇒ뫔ꗖﯚ", a_) + ex.Message);
					}
					return result;
				}
				return default(T);
			}
			}
		}
	}
}
