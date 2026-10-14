using System;
using System.IO;
using System.Xml;

namespace Gibraltar.Server.Client.Data
{
	// Token: 0x02000137 RID: 311
	internal static class DataConverter
	{
		// Token: 0x06000C9E RID: 3230 RVA: 0x00021B34 File Offset: 0x0001FD34
		public static global::Gibraltar.Server.Client.Data.HubConfigurationXml ByteArrayToHubConfigurationXml(byte[] rawData)
		{
			global::Gibraltar.Server.Client.Data.HubConfigurationXml hubConfigurationXml = new global::Gibraltar.Server.Client.Data.HubConfigurationXml();
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(rawData))
			{
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.Load(memoryStream);
				global::System.Xml.XmlNode documentElement = xmlDocument.DocumentElement;
				if (documentElement == null)
				{
					throw new global::Gibraltar.GibraltarException("There is no server configuration data in the provided raw data");
				}
				global::System.Xml.XmlAttribute xmlAttribute = documentElement.Attributes["id"];
				if (xmlAttribute != null)
				{
					hubConfigurationXml.id = xmlAttribute.InnerText;
				}
				xmlAttribute = documentElement.Attributes["redirectRequested"];
				if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.InnerText))
				{
					hubConfigurationXml.redirectRequested = bool.Parse(xmlAttribute.InnerText);
				}
				xmlAttribute = documentElement.Attributes["status"];
				if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.InnerText))
				{
					hubConfigurationXml.status = (global::Gibraltar.Server.Client.Data.HubStatusXml)global::System.Enum.Parse(typeof(global::Gibraltar.Server.Client.Data.HubStatusXml), xmlAttribute.InnerText, true);
				}
				xmlAttribute = documentElement.Attributes["timeToLive"];
				if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.InnerText))
				{
					hubConfigurationXml.timeToLive = int.Parse(xmlAttribute.InnerText);
				}
				xmlAttribute = documentElement.Attributes["protocolVersion"];
				if (xmlAttribute != null)
				{
					hubConfigurationXml.protocolVersion = xmlAttribute.InnerText;
				}
				if (hubConfigurationXml.redirectRequested)
				{
					xmlAttribute = documentElement.Attributes["redirectApplicationBaseDirectory"];
					if (xmlAttribute != null)
					{
						hubConfigurationXml.redirectApplicationBaseDirectory = xmlAttribute.InnerText;
					}
					xmlAttribute = documentElement.Attributes["redirectCustomerName"];
					if (xmlAttribute != null)
					{
						hubConfigurationXml.redirectCustomerName = xmlAttribute.InnerText;
					}
					xmlAttribute = documentElement.Attributes["redirectHostName"];
					if (xmlAttribute != null)
					{
						hubConfigurationXml.redirectHostName = xmlAttribute.InnerText;
					}
					xmlAttribute = documentElement.Attributes["redirectPort"];
					if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.InnerText))
					{
						hubConfigurationXml.redirectPort = int.Parse(xmlAttribute.InnerText);
						hubConfigurationXml.redirectPortSpecified = true;
					}
					xmlAttribute = documentElement.Attributes["redirectUseGibraltarSds"];
					if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.InnerText))
					{
						hubConfigurationXml.redirectUseGibraltarSds = bool.Parse(xmlAttribute.InnerText);
						hubConfigurationXml.redirectUseGibraltarSdsSpecified = true;
					}
					xmlAttribute = documentElement.Attributes["redirectUseSsl"];
					if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.InnerText))
					{
						hubConfigurationXml.redirectUseSsl = bool.Parse(xmlAttribute.InnerText);
						hubConfigurationXml.redirectUseSslSpecified = true;
					}
				}
				if (documentElement.HasChildNodes)
				{
					global::System.Xml.XmlNode xmlNode = null;
					global::System.Xml.XmlNode xmlNode2 = null;
					global::System.Xml.XmlNode xmlNode3 = null;
					foreach (object obj in documentElement.ChildNodes)
					{
						global::System.Xml.XmlNode xmlNode4 = (global::System.Xml.XmlNode)obj;
						if (xmlNode4.NodeType == global::System.Xml.XmlNodeType.Element)
						{
							string name = xmlNode4.Name;
							if (!(name == "expirationDt"))
							{
								if (!(name == "publicKey"))
								{
									if (name == "liveStream")
									{
										xmlNode3 = xmlNode4;
									}
								}
								else
								{
									xmlNode2 = xmlNode4;
								}
							}
							else
							{
								xmlNode = xmlNode4;
							}
							if (xmlNode != null && xmlNode2 != null && xmlNode3 != null)
							{
								break;
							}
						}
					}
					if (xmlNode != null)
					{
						xmlAttribute = xmlNode.Attributes["DateTime"];
						string innerText = xmlAttribute.InnerText;
						xmlAttribute = xmlNode.Attributes["Offset"];
						string innerText2 = xmlAttribute.InnerText;
						if (!string.IsNullOrEmpty(innerText) && !string.IsNullOrEmpty(innerText2))
						{
							hubConfigurationXml.expirationDt = new global::Gibraltar.Server.Client.Data.DateTimeOffsetXml();
							hubConfigurationXml.expirationDt.DateTime = global::System.DateTime.Parse(innerText);
							hubConfigurationXml.expirationDt.Offset = int.Parse(innerText2);
						}
					}
					if (xmlNode2 != null)
					{
						hubConfigurationXml.publicKey = xmlNode2.InnerText;
					}
					if (xmlNode3 != null)
					{
						xmlAttribute = xmlNode3.Attributes["agentPort"];
						string innerText3 = xmlAttribute.InnerText;
						xmlAttribute = xmlNode3.Attributes["clientPort"];
						string innerText4 = xmlAttribute.InnerText;
						xmlAttribute = xmlNode3.Attributes["useSsl"];
						string innerText5 = xmlAttribute.InnerText;
						if (!string.IsNullOrEmpty(innerText3) && !string.IsNullOrEmpty(innerText4) && !string.IsNullOrEmpty(innerText5))
						{
							hubConfigurationXml.liveStream = new global::Gibraltar.Server.Client.Data.LiveStreamServerXml();
							hubConfigurationXml.liveStream.agentPort = int.Parse(innerText3);
							hubConfigurationXml.liveStream.clientPort = int.Parse(innerText4);
							hubConfigurationXml.liveStream.useSsl = bool.Parse(innerText5);
						}
					}
				}
			}
			return hubConfigurationXml;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00022014 File Offset: 0x00020214
		private static void DateTimeOffsetXmlToXmlWriter(global::System.Xml.XmlWriter xmlWriter, string elementName, global::Gibraltar.Server.Client.Data.DateTimeOffsetXml dateTimeOffsetXml)
		{
			if (dateTimeOffsetXml == null)
			{
				return;
			}
			xmlWriter.WriteStartElement(elementName);
			global::Gibraltar.Server.Client.Data.DataConverter.WriteXmlAttribute(xmlWriter, "DateTime", dateTimeOffsetXml.DateTime);
			global::Gibraltar.Server.Client.Data.DataConverter.WriteXmlAttribute(xmlWriter, "Offset", (long)dateTimeOffsetXml.Offset);
			xmlWriter.WriteEndElement();
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0002205C File Offset: 0x0002025C
		private static void DateTimeOffsetToXmlWriter(global::System.Xml.XmlWriter xmlWriter, string elementName, global::System.DateTimeOffset dateTimeOffset)
		{
			global::Gibraltar.Server.Client.Data.DataConverter.DateTimeOffsetXmlToXmlWriter(xmlWriter, elementName, global::Gibraltar.Server.Client.Data.DataConverter.ToDateTimeOffsetXml(dateTimeOffset));
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0002206C File Offset: 0x0002026C
		public static global::Gibraltar.Server.Client.Data.DateTimeOffsetXml ToDateTimeOffsetXml(global::System.DateTimeOffset dateTime)
		{
			return new global::Gibraltar.Server.Client.Data.DateTimeOffsetXml
			{
				DateTime = dateTime.DateTime,
				Offset = (int)dateTime.Offset.TotalMinutes
			};
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000220A8 File Offset: 0x000202A8
		public static global::System.DateTimeOffset FromDateTimeOffsetXml(global::Gibraltar.Server.Client.Data.DateTimeOffsetXml dateTime)
		{
			if (dateTime == null)
			{
				return global::System.DateTimeOffset.MinValue;
			}
			global::System.DateTime dateTime2 = dateTime.DateTime;
			if (dateTime2.Kind != global::System.DateTimeKind.Unspecified)
			{
				dateTime2 = global::System.DateTime.SpecifyKind(dateTime2, global::System.DateTimeKind.Unspecified);
			}
			return new global::System.DateTimeOffset(dateTime2, new global::System.TimeSpan(0, dateTime.Offset, 0));
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x000220F4 File Offset: 0x000202F4
		private static void WriteXmlAttribute(global::System.Xml.XmlWriter xmlWriter, string name, string value)
		{
			if (value == null)
			{
				return;
			}
			xmlWriter.WriteStartAttribute(name);
			xmlWriter.WriteValue(value);
			xmlWriter.WriteEndAttribute();
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00022114 File Offset: 0x00020314
		private static void WriteXmlAttribute(global::System.Xml.XmlWriter xmlWriter, string name, long value)
		{
			xmlWriter.WriteStartAttribute(name);
			xmlWriter.WriteValue(value);
			xmlWriter.WriteEndAttribute();
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0002212C File Offset: 0x0002032C
		private static void WriteXmlAttribute(global::System.Xml.XmlWriter xmlWriter, string name, bool value)
		{
			xmlWriter.WriteStartAttribute(name);
			xmlWriter.WriteValue(value);
			xmlWriter.WriteEndAttribute();
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00022144 File Offset: 0x00020344
		private static void WriteXmlAttribute(global::System.Xml.XmlWriter xmlWriter, string name, global::System.DateTime value)
		{
			xmlWriter.WriteStartAttribute(name);
			xmlWriter.WriteValue(value);
			xmlWriter.WriteEndAttribute();
		}

		// Token: 0x040003CD RID: 973
		private const string LogCategory = "Loupe.Server.Data";
	}
}
