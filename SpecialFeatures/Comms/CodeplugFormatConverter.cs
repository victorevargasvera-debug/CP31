using System;
using System.Collections.Generic;
using System.IO;
using Motorola.Common.Communication.CommonUtil;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000172 RID: 370
	public class CodeplugFormatConverter
	{
		// Token: 0x06001279 RID: 4729 RVA: 0x00003708 File Offset: 0x00001908
		public CodeplugFormatConverter()
		{
			this.b = new byte[2];
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00196800 File Offset: 0x00194A00
		internal global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream> Convert(global::Motorola.Common.Communication.CommonUtil.IshItemCollection collection)
		{
			int a_ = 3;
			short num = (short)263585792;
			switch (num)
			{
			default:
			{
				num = (short)10747904;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte key;
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator;
					global::System.Collections.Generic.Dictionary<int, int> dictionary2;
					global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream> dictionary3;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 1:
						try
						{
							num = (short)1956053006;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1904464963;
								short num3 = num;
								num = (short)1434309699;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_4D2;
								default:
								{
									num = (short)1442840576;
									if (num != 0)
									{
									}
									global::Motorola.Common.Communication.CommonUtil.IshHeader key2;
									global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
									global::System.IO.MemoryStream memoryStream;
									switch (num2)
									{
									case 0:
										goto IL_3AC;
									case 1:
										goto IL_3AC;
									case 2:
										goto IL_29A;
									case 3:
										key = 0;
										num = (short)1533739021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										if (key2.PartitionNumber == 210)
										{
											num = (short)775225354;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										key2 = keyValuePair.Key;
										num = (short)1203437577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										key = 2;
										num = (short)2070413313;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										if (!enumerator.MoveNext())
										{
											num = (short)415825928;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										keyValuePair = enumerator.Current;
										key2 = keyValuePair.Key;
										num = (short)395247631;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										num = (short)1868824588;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										if (key2.PartitionNumber == 212)
										{
											num = (short)1915813894;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3AC;
									case 10:
										key = 1;
										num = (short)1578565632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
									{
										global::System.Collections.Generic.Dictionary<int, int> dictionary = dictionary2;
										key2 = keyValuePair.Key;
										memoryStream = new global::System.IO.MemoryStream(dictionary[(int)key2.PartitionNumber]);
										dictionary3.Add((int)key, memoryStream);
										num = (short)1207304194;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										goto IL_4D2;
									case 13:
										goto IL_3AC;
									case 14:
										switch (0)
										{
										case 0:
											goto IL_181;
										}
										continue;
									case 15:
										if (key2.PartitionNumber == 208)
										{
											num = (short)104595459;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										key2 = keyValuePair.Key;
										num = (short)1102446597;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 16:
										if (!dictionary3.TryGetValue((int)key, out memoryStream))
										{
											num = (short)453246987;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_29A;
									}
									IL_1E8:
									num = (short)1746731015;
									num2 = (int)((global::System.IntPtr)num);
									break;
									IL_181:
									goto IL_1E8;
									IL_29A:
									byte[] array = this.b;
									int num4 = 0;
									key2 = keyValuePair.Key;
									array[num4] = (byte)(key2.IshType >> 8);
									byte[] array2 = this.b;
									int num5 = 1;
									key2 = keyValuePair.Key;
									array2[num5] = (byte)key2.IshType;
									memoryStream.Write(this.b, 0, 2);
									byte[] array3 = this.b;
									int num6 = 0;
									key2 = keyValuePair.Key;
									array3[num6] = (byte)(key2.IshID >> 8);
									byte[] array4 = this.b;
									int num7 = 1;
									key2 = keyValuePair.Key;
									array4[num7] = (byte)key2.IshID;
									memoryStream.Write(this.b, 0, 2);
									this.b[0] = (byte)((ushort)keyValuePair.Value.Data.Length >> 8);
									this.b[1] = (byte)((ushort)keyValuePair.Value.Data.Length);
									memoryStream.Write(this.b, 0, 2);
									memoryStream.Write(keyValuePair.Value.Data, 0, keyValuePair.Value.Data.Length);
									num = (short)768802820;
									num2 = (int)((global::System.IntPtr)num);
									break;
									IL_3AC:
									num = (short)1676410896;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
								}
							}
							IL_4D2:
							return dictionary3;
						}
						finally
						{
							num = (short)1124663297;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)388235266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_50B;
									}
									continue;
								case 2:
									goto IL_542;
								}
								IL_50B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1175060480;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_542:;
						}
						goto IL_545;
					case 2:
						goto IL_9B;
					}
					IL_59:
					num = (short)907280385;
					if (num != 0)
					{
					}
					if (collection == null)
					{
						num = (short)1294598146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_545:
					dictionary2 = this.a(collection);
					dictionary3 = new global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream>();
					key = 0;
					enumerator = collection.GetEnumerator();
					num = (short)1036451841;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9B:
				num = (short)1850867712;
				short num8 = num;
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶓ秊", a_));
			}
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00196DB8 File Offset: 0x00194FB8
		internal global::Motorola.Common.Communication.CommonUtil.IshItemCollection Convert(global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream> codeplug)
		{
			int a_ = 16;
			short num = (short)1203372032;
			switch (num)
			{
			default:
			{
				num = (short)1184825345;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte partitionNumber;
					global::System.Collections.Generic.Dictionary<int, global::System.IO.MemoryStream>.Enumerator enumerator;
					global::Motorola.Common.Communication.CommonUtil.IshItemCollection ishItemCollection;
					switch (num2)
					{
					case 0:
						goto IL_74;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 2:
					{
						num = (short)1397559271;
						short num3 = num;
						num = (short)1699876839;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)750911488;
							if (num != 0)
							{
							}
							num = (short)1096482816;
							short num4 = num;
							num = (short)1533345793;
							if (num != 0)
							{
							}
							try
							{
								num = (short)2027618315;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									ushort ishType;
									ushort ishId;
									byte[] array;
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.KeyValuePair<int, global::System.IO.MemoryStream> keyValuePair;
										if (keyValuePair.Key == 2)
										{
											num = (short)180158473;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_384;
									}
									case 1:
									{
										global::System.Collections.Generic.KeyValuePair<int, global::System.IO.MemoryStream> keyValuePair;
										if (keyValuePair.Key == 0)
										{
											num = (short)979959810;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)2041643022;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										partitionNumber = 208;
										num = (short)1229914129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_178;
									case 4:
										partitionNumber = 210;
										num = (short)402194445;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										global::System.Collections.Generic.KeyValuePair<int, global::System.IO.MemoryStream> keyValuePair;
										if (keyValuePair.Value.Position != keyValuePair.Value.Length)
										{
											num = (short)757399564;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										num = (short)737476623;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										num = (short)254148613;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										goto IL_384;
									case 9:
										partitionNumber = 212;
										num = (short)225312776;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1426784262;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.KeyValuePair<int, global::System.IO.MemoryStream> keyValuePair = enumerator.Current;
										num = (short)318898179;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
										switch (0)
										{
										case 0:
											goto IL_EC;
										}
										continue;
									case 12:
										goto IL_2B8;
									case 13:
										goto IL_384;
									case 14:
									{
										global::System.Collections.Generic.KeyValuePair<int, global::System.IO.MemoryStream> keyValuePair;
										if (keyValuePair.Key == 1)
										{
											num = (short)464977924;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1946550272;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 15:
										goto IL_3DB;
									case 16:
									{
										global::System.Collections.Generic.KeyValuePair<int, global::System.IO.MemoryStream> keyValuePair;
										if (keyValuePair.Value.Position >= keyValuePair.Value.Length)
										{
											num = (short)400556039;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										ishType = this.a(keyValuePair.Value);
										ishId = this.a(keyValuePair.Value);
										array = new byte[(int)this.a(keyValuePair.Value)];
										keyValuePair.Value.Read(array, 0, array.Length);
										num = (short)770048001;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 17:
										goto IL_384;
									case 18:
										goto IL_178;
									}
									goto IL_EC;
									IL_178:
									num = (short)2050228240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1CB:
									num = (short)141492234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_EC:
									goto IL_1CB;
									IL_384:
									global::Motorola.Common.Communication.CommonUtil.IshHeader headers = new global::Motorola.Common.Communication.CommonUtil.IshHeader(partitionNumber, ishType, ishId);
									global::Motorola.Common.Communication.CommonUtil.IshItem item = new global::Motorola.Common.Communication.CommonUtil.IshItem(array.Length, array, global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success);
									ishItemCollection.Add(headers, item);
									num = (short)907870226;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2B8:
								throw new global::System.IO.IOException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda92ﮔﮞ膠쪢좤욦캨캪", a_));
								IL_3DB:
								return ishItemCollection;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_3EE;
						}
						}
						break;
					}
					}
					IL_59:
					if (codeplug == null)
					{
						num = (short)778698752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3EE:
					ishItemCollection = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
					partitionNumber = 0;
					enumerator = codeplug.GetEnumerator();
					num = (short)1370816514;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_74:
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﺚ", a_));
			}
			}
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x001972B0 File Offset: 0x001954B0
		private ushort a(global::System.IO.MemoryStream A_0)
		{
			int a_ = 17;
			short num;
			for (;;)
			{
				num = (short)818151424;
				short num2 = num;
				if (A_0.Read(this.b, 0, 2) == 2)
				{
					goto IL_CC;
				}
				num = (short)185173311;
				short num3 = num;
				num = (short)1301447999;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7C;
				}
			}
			IL_7C:
			num = (short)1274740737;
			if (num != 0)
			{
			}
			num = (short)1820590080;
			if (num != 0)
			{
			}
			throw new global::System.IO.IOException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톓ﲗ몙肟톡킣풥춧쮩솫躭슯ힱ햳햵킷\udfb9\ud8bb", a_));
			IL_CC:
			global::System.Array.Reverse(this.b, 0, 2);
			return global::System.BitConverter.ToUInt16(this.b, 0);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x001973A4 File Offset: 0x001955A4
		private global::System.Collections.Generic.Dictionary<int, int> a(global::Motorola.Common.Communication.CommonUtil.IshItemCollection A_0)
		{
			short num = (short)1759182848;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.Dictionary<int, int> dictionary = new global::System.Collections.Generic.Dictionary<int, int>();
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem>> enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)843907072;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)1604531931;
							short num3 = num;
							num = (short)1921791707;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1C9;
							default:
								num = (short)682491904;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_BE;
								}
								continue;
							}
							break;
						}
						case 2:
							num = (short)1897005063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							dictionary.Add((int)keyValuePair.Key.PartitionNumber, 6 + keyValuePair.Value.Data.Length);
							num = (short)310509569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair;
							int num4;
							if (!dictionary.TryGetValue((int)keyValuePair.Key.PartitionNumber, out num4))
							{
								num = (short)970915844;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4 += 6 + keyValuePair.Value.Data.Length;
							dictionary[(int)keyValuePair.Key.PartitionNumber] = num4;
							goto IL_1C9;
						}
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1951596546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommonUtil.IshHeader, global::Motorola.Common.Communication.CommonUtil.IshItem> keyValuePair = enumerator.Current;
							num = (short)367394821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_1FF;
						}
						IL_112:
						num = (short)1456340998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_BE:
						goto IL_112;
						IL_1C9:
						num = (short)929824771;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1FF:;
				}
				finally
				{
					num = (short)798752769;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1738670082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_233;
							}
							continue;
						case 2:
							goto IL_26A;
						}
						IL_233:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1698758656;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_26A:;
				}
				num = (short)880476160;
				short num5 = num;
				num = (short)1335885825;
				if (num != 0)
				{
				}
				return dictionary;
			}
			}
		}

		// Token: 0x040009FE RID: 2558
		private const int a = 6;

		// Token: 0x040009FF RID: 2559
		private byte[] b;
	}
}
