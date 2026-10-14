using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml;

namespace Common.Communication.Simulator
{
	// Token: 0x0200000C RID: 12
	[global::System.Serializable]
	public class VirtualLEDevices
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000092E8 File Offset: 0x000074E8
		public global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo> LESysDeviceList
		{
			get
			{
				short num = (short)1866920274;
				short num2 = num;
				num = (short)1226043730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1356267520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945881089;
				if (num != 0)
				{
				}
				num = (short)851836928;
				if (num != 0)
				{
				}
				return this._leSysDeviceList;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000939C File Offset: 0x0000759C
		public VirtualLEDevices()
		{
			this._leSysDeviceList = new global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo>();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000093BC File Offset: 0x000075BC
		private static string a()
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_74;
			}
			short num;
			int num3;
			string result;
			for (;;)
			{
				IL_13:
				num = (short)1725277233;
				short num2 = num;
				num = (short)2081793073;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)680329216;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_110;
					case 1:
						result = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + global::Common.Communication.Simulator.VirtualLEDevices.b("ᑇ᱉╋㱍⑏❑㕓㩕੗㭙㡛㝝ཟᅡ㡣⩥ⵧ㥩ᕫᵭѯ᝱ᥳ㩵ᅷॹࡻ偽", a_);
						num = (short)1179320323;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (global::System.Reflection.Assembly.GetEntryAssembly() == null)
						{
							num = (short)1211629568;
							short num4 = num;
							num = (short)386203649;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolder + global::Common.Communication.Simulator.VirtualLEDevices.b("ᑇىोᵍ⥏⅑⁓㍕㕗ᙙ㕛ⵝᑟ䱡ᱣ୥ѧ", a_);
						goto IL_F9;
					case 3:
						return result;
					}
					goto IL_74;
				}
				IL_F9:
				num = (short)1850736640;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_110:
			num = (short)93192193;
			if (num != 0)
			{
			}
			return result;
			IL_74:
			result = string.Empty;
			num = (short)421330946;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00009540 File Offset: 0x00007740
		public static global::Common.Communication.Simulator.VirtualLEDevices LoadFromFile()
		{
			short num = (short)649461760;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)568721408;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer;
				global::Common.Communication.Simulator.VirtualLEDevices result;
				string text;
				for (;;)
				{
					IL_4F:
					global::System.Xml.XmlReader xmlReader;
					switch (num2)
					{
					case 0:
					{
						try
						{
							global::System.Xml.XmlDictionaryReader xmlDictionaryReader = global::System.Xml.XmlDictionaryReader.CreateDictionaryReader(xmlReader);
							try
							{
								result = (dataContractSerializer.ReadObject(xmlDictionaryReader) as global::Common.Communication.Simulator.VirtualLEDevices);
								goto IL_24F;
							}
							finally
							{
								num = (short)751108097;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_19A;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_132;
										}
										continue;
									case 2:
										goto IL_1BA;
									}
									IL_132:
									if (xmlDictionaryReader == null)
									{
										break;
									}
									num = (short)1936080598;
									short num4 = num;
									num = (short)778714838;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)506658816;
										if (num != 0)
										{
										}
										num = (short)2114322432;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_19A:
									((global::System.IDisposable)xmlDictionaryReader).Dispose();
									num = (short)492634114;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1BA:;
							}
						}
						finally
						{
							num = (short)5832705;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)xmlReader).Dispose();
									num = (short)1386217474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1F1;
									}
									continue;
								case 2:
									goto IL_227;
								}
								IL_1F1:
								if (xmlReader == null)
								{
									break;
								}
								num = (short)646184960;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_227:;
						}
						goto IL_22A;
						IL_24F:
						global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
						xmlDocument.Load(text);
						xmlDocument.Save(text);
						num = (short)199491587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_22A;
					case 2:
						num = (short)260702209;
						if (num != 0)
						{
						}
						if (global::System.IO.File.Exists(text))
						{
							num = (short)591134721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
						return result;
					}
					goto IL_66;
					IL_22A:
					xmlReader = global::System.Xml.XmlReader.Create(text);
					num = (short)2117730304;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_66:
				dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(global::Common.Communication.Simulator.VirtualLEDevices));
				result = null;
				text = global::Common.Communication.Simulator.VirtualLEDevices.a();
				num = (short)890306562;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000097E8 File Offset: 0x000079E8
		public void SaveToFile()
		{
			short num = (short)1733492737;
			if (num != 0)
			{
			}
			num = (short)1872625664;
			short num2 = num;
			num = (short)2058092544;
			switch (num)
			{
			default:
			{
				global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(global::Common.Communication.Simulator.VirtualLEDevices));
				string text = global::Common.Communication.Simulator.VirtualLEDevices.a();
				global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(text);
				try
				{
					global::System.Xml.XmlDictionaryWriter xmlDictionaryWriter = global::System.Xml.XmlDictionaryWriter.CreateDictionaryWriter(xmlWriter);
					try
					{
						dataContractSerializer.WriteObject(xmlDictionaryWriter, this);
					}
					finally
					{
						num = (short)943063041;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								((global::System.IDisposable)xmlDictionaryWriter).Dispose();
								num = (short)1537933314;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_D5;
								}
								continue;
							case 2:
								goto IL_10E;
							}
							IL_D5:
							if (xmlDictionaryWriter == null)
							{
								break;
							}
							num = (short)661716992;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_10E:;
					}
				}
				finally
				{
					num = (short)1493762049;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							for (;;)
							{
								num = (short)851631510;
								short num4 = num;
								num = (short)1827790230;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_198;
								}
							}
							IL_198:
							num = (short)184287232;
							if (num != 0)
							{
							}
							((global::System.IDisposable)xmlWriter).Dispose();
							num = (short)429850626;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_145;
							}
							continue;
						case 2:
							goto IL_1CD;
						}
						IL_145:
						if (xmlWriter == null)
						{
							break;
						}
						num = (short)416284672;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1CD:;
				}
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.Load(text);
				xmlDocument.Save(text);
				return;
			}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000099F4 File Offset: 0x00007BF4
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1547986815 + A_1) + (global::System.IntPtr)51 + (global::System.IntPtr)58 + (global::System.IntPtr)26 + (global::System.IntPtr)56);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}

		// Token: 0x0400001D RID: 29
		private global::System.Collections.Generic.List<global::Common.Communication.Simulator.LESystemDevicesInfo> _leSysDeviceList;
	}
}
