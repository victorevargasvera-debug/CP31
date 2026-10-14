using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using CommonUtility;

namespace Motorola.CommonCPS.Common.CommonUtility
{
	// Token: 0x0200000C RID: 12
	public static class JobErrorParameterConverter
	{
		// Token: 0x06000034 RID: 52 RVA: 0x000058D8 File Offset: 0x00003AD8
		public static string ConverterParameterArrayToString(string[] parameterArray)
		{
			int a_ = 7;
			short num = (short)1312161792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_50;
				}
				string result;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.List<string>.Enumerator enumerator;
					int num4;
					global::System.Xml.XmlDocument xmlDocument;
					global::System.Xml.XmlNode xmlNode;
					switch (num2)
					{
					case 0:
						if (parameterArray != null)
						{
							num = (short)104857603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						return result;
					case 2:
						if (parameterArray != null)
						{
							num = (short)1194655745;
							if (num != 0)
							{
							}
							num = (short)1106051076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
						goto IL_184;
					case 4:
					{
						num = (short)497614848;
						short num3 = num;
						goto IL_283;
					}
					case 5:
					{
						try
						{
							num = (short)341180416;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_C2;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)569835523;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string innerText = enumerator.Current;
									string name = global::CommonUtility.VersionUtility.b("瘷唹堻嬽", a_) + num4.ToString();
									global::System.Xml.XmlElement xmlElement = xmlDocument.CreateElement(name);
									xmlElement.InnerText = innerText;
									xmlNode.AppendChild(xmlElement);
									num = (short)774897665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)2113011716;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_171;
								}
								IL_C4:
								num = (short)1965490178;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C2:
								goto IL_C4;
							}
							IL_171:
							goto IL_213;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_184;
						IL_213:
						result = xmlDocument.OuterXml.ToString();
						num = (short)1603850304;
						short num5 = num;
						num = (short)1285410880;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_283;
						default:
							num = (short)1517420544;
							if (num != 0)
							{
							}
							num = (short)142606337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_50;
					IL_184:
					global::System.Collections.Generic.List<string> list = parameterArray.ToList<string>();
					num = (short)1259601922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_283:
					xmlDocument = new global::System.Xml.XmlDocument();
					global::System.Xml.XmlElement newChild = xmlDocument.CreateElement(global::CommonUtility.VersionUtility.b("樷唹医䨽", a_));
					xmlDocument.AppendChild(newChild);
					xmlNode = xmlDocument.SelectSingleNode(global::CommonUtility.VersionUtility.b("樷唹医䨽", a_));
					num4 = 0;
					enumerator = list.GetEnumerator();
					num = (short)1775566853;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_50:
				result = null;
				num = (short)1829044224;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005BDC File Offset: 0x00003DDC
		public static string[] ConverterStringToParameterArray(string strParameters)
		{
			short num = (short)1047789569;
			if (num != 0)
			{
			}
			num = (short)1189478400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1596981248;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)116326400;
					short num3 = num;
					string[] result;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 1:
						goto IL_C3;
					case 2:
						try
						{
							num = (short)203091677;
							short num4 = num;
							num = (short)1038216925;
							global::System.Collections.Generic.List<string> list;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
							{
								num = (short)46727168;
								if (num != 0)
								{
								}
								list = new global::System.Collections.Generic.List<string>();
								global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
								xmlDocument.LoadXml(strParameters);
								global::System.Collections.IEnumerator enumerator = xmlDocument.DocumentElement.GetEnumerator();
								try
								{
									num = (short)2060582912;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_16D;
											}
											continue;
										case 2:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)596312067;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
											list.Add(xmlNode.InnerText);
											num = (short)2026438657;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											num = (short)486080516;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
											goto IL_1ED;
										}
										IL_16F:
										num = (short)1009844226;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_16D:
										goto IL_16F;
									}
									IL_1ED:;
								}
								finally
								{
									switch (0)
									{
									case 0:
										goto IL_20C;
									}
									global::System.IDisposable disposable;
									for (;;)
									{
										IL_1F9:
										switch (num2)
										{
										case 0:
											if (disposable != null)
											{
												num = (short)2098397185;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_265;
										case 1:
											disposable.Dispose();
											num = (short)1071448066;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_263;
										}
										goto IL_20C;
									}
									IL_263:
									IL_265:
									break;
									IL_20C:
									disposable = (enumerator as global::System.IDisposable);
									num = (short)23855104;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_1F9;
								}
								break;
							}
							}
							return list.ToArray();
						}
						catch
						{
							return result;
						}
						goto IL_272;
					}
					IL_A2:
					if (string.IsNullOrWhiteSpace(strParameters))
					{
						num = (short)72220673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_272:
					result = null;
					num = (short)1537867778;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C3:
				return null;
			}
		}
	}
}
