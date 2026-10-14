using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;

namespace Common.Communication.Simulator
{
	// Token: 0x02000008 RID: 8
	[global::System.Serializable]
	public class DeviceTypeMap
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00007E80 File Offset: 0x00006080
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00007F2C File Offset: 0x0000612C
		public global::System.Collections.Generic.Dictionary<string, global::Common.Communication.Simulator.DeviceIDInfo> DeviceTypeList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)306118656;
				short num2 = num;
				num = (short)1177681921;
				if (num != 0)
				{
				}
				num = (short)1185498358;
				short num3 = num;
				num = (short)829834486;
				switch (num3 == num)
				{
				}
				num = (short)1570504704;
				if (num != 0)
				{
				}
				return this.<DeviceTypeList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)292159488;
				short num2 = num;
				num = (short)1442093650;
				short num3 = num;
				num = (short)948410962;
				switch (num3 == num)
				{
				}
				num = (short)1582628865;
				if (num != 0)
				{
				}
				num = (short)1829175296;
				if (num != 0)
				{
				}
				this.<DeviceTypeList>k__BackingField = value;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00007FDC File Offset: 0x000061DC
		public DeviceTypeMap()
		{
			this.DeviceTypeList = new global::System.Collections.Generic.Dictionary<string, global::Common.Communication.Simulator.DeviceIDInfo>();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00007FFC File Offset: 0x000061FC
		public static global::Common.Communication.Simulator.DeviceTypeMap LoadFromFile()
		{
			short num = (short)2110783488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer;
				string text;
				global::Common.Communication.Simulator.DeviceTypeMap result;
				for (;;)
				{
					IL_27:
					global::System.Xml.XmlReader xmlReader;
					switch (num2)
					{
					case 0:
						try
						{
							global::System.Xml.XmlDictionaryReader xmlDictionaryReader = global::System.Xml.XmlDictionaryReader.CreateDictionaryReader(xmlReader);
							try
							{
								return dataContractSerializer.ReadObject(xmlDictionaryReader) as global::Common.Communication.Simulator.DeviceTypeMap;
							}
							finally
							{
								num = (short)601882625;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1B9;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_12E;
										}
										continue;
									case 2:
										goto IL_199;
									}
									IL_12E:
									if (xmlDictionaryReader == null)
									{
										break;
									}
									num = (short)547677356;
									short num3 = num;
									num = (short)1415898284;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)896729088;
										if (num != 0)
										{
										}
										num = (short)14024706;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_199:
									((global::System.IDisposable)xmlDictionaryReader).Dispose();
									num = (short)1443758080;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1B9:;
							}
						}
						finally
						{
							num = (short)933167105;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)xmlReader).Dispose();
									num = (short)1087307778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1EF;
									}
									continue;
								case 2:
									goto IL_224;
								}
								IL_1EF:
								if (xmlReader == null)
								{
									break;
								}
								num = (short)945029120;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_224:;
						}
						goto IL_227;
					case 1:
						if (global::System.IO.File.Exists(text))
						{
							num = (short)2048589826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
					{
						num = (short)145358848;
						short num4 = num;
						num = (short)470548481;
						if (num != 0)
						{
						}
						goto IL_227;
					}
					}
					goto IL_3A;
					IL_227:
					xmlReader = global::System.Xml.XmlReader.Create(text);
					num = (short)1907097600;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_3A:
				dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(global::Common.Communication.Simulator.DeviceTypeMap));
				result = null;
				text = global::Common.Communication.Simulator.DeviceTypeMap.a();
				num = (short)817233921;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00008274 File Offset: 0x00006474
		private static string a()
		{
			int a_ = 17;
			switch (0)
			{
			case 0:
				goto IL_9B;
			}
			short num;
			int num3;
			string result;
			for (;;)
			{
				IL_13:
				num = (short)1299677762;
				short num2 = num;
				num = (short)529236546;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1045102593;
					if (num != 0)
					{
					}
					num = (short)1356660736;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return result;
					case 1:
						result = global::System.IO.Path.GetDirectoryName(global::System.Reflection.Assembly.GetExecutingAssembly().Location) + global::Common.Communication.Simulator.VirtualLEDevices.b("౏ё㵓⑕ⱗ⽙㵛㉝㉟͡cཥݧᥩに⩭ᕯѱᵳᕵᵷ⹹ջ๽캁ﲇꒉﲏ", a_);
						num = (short)1274806275;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)592904192;
						short num4 = num;
						if (global::System.Reflection.Assembly.GetEntryAssembly() == null)
						{
							num = (short)979173377;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = global::Common.Communication.Simulator.VRDefinitions.VirtualDeviceFolder + global::Common.Communication.Simulator.VirtualLEDevices.b("౏ᙑㅓ⁕ㅗ㥙㥛੝ᥟቡţ⩥ŧᥩᡫ䁭࡯άᡳ", a_);
						goto IL_122;
					}
					case 3:
						return result;
					}
					goto IL_9B;
				}
				IL_122:
				num = (short)783351808;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_9B:
			result = string.Empty;
			num = (short)934674434;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000083FC File Offset: 0x000065FC
		public void SaveToFile()
		{
			short num = (short)1503985664;
			switch (num)
			{
			default:
			{
				num = (short)138805248;
				short num2 = num;
				global::System.Runtime.Serialization.DataContractSerializer dataContractSerializer = new global::System.Runtime.Serialization.DataContractSerializer(typeof(global::Common.Communication.Simulator.DeviceTypeMap));
				string text = global::Common.Communication.Simulator.DeviceTypeMap.a();
				global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(text);
				try
				{
					num = (short)374603777;
					if (num != 0)
					{
					}
					global::System.Xml.XmlDictionaryWriter xmlDictionaryWriter = global::System.Xml.XmlDictionaryWriter.CreateDictionaryWriter(xmlWriter);
					try
					{
						dataContractSerializer.WriteObject(xmlDictionaryWriter, this);
					}
					finally
					{
						num = (short)943718401;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_143;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_D9;
								}
								continue;
							case 2:
								goto IL_162;
							}
							IL_D9:
							if (xmlDictionaryWriter == null)
							{
								break;
							}
							num = (short)1632129025;
							short num4 = num;
							num = (short)818827265;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)2040528896;
								if (num != 0)
								{
								}
								num = (short)648740864;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_143:
							((global::System.IDisposable)xmlDictionaryWriter).Dispose();
							num = (short)888668162;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_162:;
					}
				}
				finally
				{
					num = (short)473300993;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)xmlWriter).Dispose();
							num = (short)1115291650;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_197;
							}
							continue;
						case 2:
							goto IL_1CD;
						}
						IL_197:
						if (xmlWriter == null)
						{
							break;
						}
						num = (short)1789788160;
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
	}
}
