using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Gibraltar.Data;
using Gibraltar.Server.Client.Data;
using Loupe.Extensibility.Data;

namespace Gibraltar.Server.Data
{
	// Token: 0x02000173 RID: 371
	internal static class DataConverter
	{
		// Token: 0x06000F57 RID: 3927 RVA: 0x000286E8 File Offset: 0x000268E8
		public static bool FromFolderXml(global::Gibraltar.Server.Client.Data.FolderXml folderXml, out global::System.Guid id, out long version, out bool deleted, out string name, out global::System.Guid? parentFolderId, out string typeName, out string selectCriteriaXml, out string invalidMessage)
		{
			bool result = true;
			id = new global::System.Guid(folderXml.id);
			version = folderXml.version;
			deleted = folderXml.deleted;
			invalidMessage = string.Empty;
			name = null;
			typeName = null;
			parentFolderId = null;
			selectCriteriaXml = string.Empty;
			if (folderXml.folderDetail == null)
			{
				result = false;
				invalidMessage = "No folder details were provided\r\n";
			}
			else
			{
				global::Gibraltar.Server.Client.Data.FolderDetailXml folderDetail = folderXml.folderDetail;
				name = folderDetail.name;
				if (string.IsNullOrEmpty(name))
				{
					result = false;
					invalidMessage += "No folder name was provided \r\n";
				}
				if (!string.IsNullOrEmpty(folderDetail.parentFolderId))
				{
					try
					{
						parentFolderId = new global::System.Guid?(new global::System.Guid(folderDetail.parentFolderId));
					}
					catch (global::System.Exception obj)
					{
						global::System.GC.KeepAlive(obj);
						result = false;
						invalidMessage += "The parent folder id wasn't valid\r\n";
					}
				}
				if (folderDetail.folderType == global::Gibraltar.Server.Client.Data.FolderTypeXml.search)
				{
					selectCriteriaXml = folderDetail.selectionCriteriaXml;
					if (string.IsNullOrEmpty(selectCriteriaXml))
					{
						result = false;
						invalidMessage += "No criteria were specified for the search folder\r\n";
					}
				}
				typeName = folderDetail.folderType.ToString();
			}
			return result;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00028828 File Offset: 0x00026A28
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

		// Token: 0x06000F59 RID: 3929 RVA: 0x00028D08 File Offset: 0x00026F08
		public static global::Gibraltar.Server.Client.Data.SessionsListXml ByteArrayToSessionsListXml(byte[] rawData)
		{
			global::Gibraltar.Server.Client.Data.SessionsListXml sessionsListXml = new global::Gibraltar.Server.Client.Data.SessionsListXml();
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(rawData))
			{
				using (global::System.IO.TextReader textReader = new global::System.IO.StreamReader(memoryStream, global::System.Text.Encoding.UTF8))
				{
					using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(textReader))
					{
						if (!xmlReader.ReadToFollowing("SessionsListXml"))
						{
							throw new global::System.IO.InvalidDataException("The provided XML data is not a sessions list");
						}
						string attribute = xmlReader.GetAttribute("version");
						if (!string.IsNullOrEmpty(attribute))
						{
							sessionsListXml.version = long.Parse(attribute);
						}
						if (xmlReader.ReadToFollowing("sessions"))
						{
							global::System.Collections.Generic.List<global::Gibraltar.Server.Client.Data.SessionXml> list = new global::System.Collections.Generic.List<global::Gibraltar.Server.Client.Data.SessionXml>();
							bool flag = true;
							while (flag)
							{
								xmlReader.ReadStartElement();
								if (xmlReader.LocalName.Equals("session"))
								{
									string attribute2 = xmlReader.GetAttribute("id");
									string attribute3 = xmlReader.GetAttribute("version");
									string attribute4 = xmlReader.GetAttribute("deleted");
									list.Add(new global::Gibraltar.Server.Client.Data.SessionXml
									{
										id = attribute2,
										version = long.Parse(attribute3),
										deleted = bool.Parse(attribute4)
									});
									if (!xmlReader.IsEmptyElement)
									{
										xmlReader.ReadEndElement();
									}
								}
								else
								{
									flag = false;
								}
							}
							sessionsListXml.sessions = list.ToArray();
						}
					}
				}
			}
			return sessionsListXml;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00028EB4 File Offset: 0x000270B4
		public static global::Gibraltar.Server.Client.Data.SessionFilesListXml ByteArrayToSessionFilesListXml(byte[] rawData)
		{
			global::Gibraltar.Server.Client.Data.SessionFilesListXml sessionFilesListXml = new global::Gibraltar.Server.Client.Data.SessionFilesListXml();
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(rawData))
			{
				using (global::System.IO.TextReader textReader = new global::System.IO.StreamReader(memoryStream, global::System.Text.Encoding.UTF8))
				{
					using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(textReader))
					{
						if (!xmlReader.ReadToFollowing("SessionFilesListXml"))
						{
							throw new global::System.IO.InvalidDataException("The provided XML data is not a session files list");
						}
						string attribute = xmlReader.GetAttribute("version");
						if (!string.IsNullOrEmpty(attribute))
						{
							sessionFilesListXml.version = long.Parse(attribute);
						}
						if (xmlReader.ReadToFollowing("files"))
						{
							global::System.Collections.Generic.List<global::Gibraltar.Server.Client.Data.SessionFileXml> list = new global::System.Collections.Generic.List<global::Gibraltar.Server.Client.Data.SessionFileXml>();
							bool flag = true;
							while (flag)
							{
								xmlReader.ReadStartElement();
								if (xmlReader.LocalName.Equals("file"))
								{
									string attribute2 = xmlReader.GetAttribute("id");
									string attribute3 = xmlReader.GetAttribute("sequence");
									string attribute4 = xmlReader.GetAttribute("version");
									list.Add(new global::Gibraltar.Server.Client.Data.SessionFileXml
									{
										id = attribute2,
										sequence = (long)int.Parse(attribute3),
										version = long.Parse(attribute4)
									});
									if (!xmlReader.IsEmptyElement)
									{
										xmlReader.ReadEndElement();
									}
								}
								else
								{
									flag = false;
								}
							}
							sessionFilesListXml.files = list.ToArray();
						}
					}
				}
			}
			return sessionFilesListXml;
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00029060 File Offset: 0x00027260
		public static byte[] AutoSendConsentToByteArray(global::Gibraltar.Data.AutoSendConsent consent)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(2048))
			{
				using (global::System.IO.TextWriter textWriter = new global::System.IO.StreamWriter(memoryStream, global::System.Text.Encoding.UTF8))
				{
					using (global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(textWriter, new global::System.Xml.XmlWriterSettings()))
					{
						xmlWriter.WriteStartElement("autoSendConsent");
						global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "id", consent.Id.ToString());
						if (!string.IsNullOrEmpty(consent.ProductName))
						{
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "product", consent.ProductName);
						}
						if (!string.IsNullOrEmpty(consent.ApplicationName))
						{
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "application", consent.ApplicationName);
						}
						if (consent.ApplicationVersion != null)
						{
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "applicationVersion", consent.ApplicationVersion.ToString());
						}
						global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "userPrompts", (long)consent.UserPrompts);
						global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "selectionMade", consent.SelectionMade);
						global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "optIn", consent.OptIn);
						global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "includeDetails", consent.IncludeDetails);
						global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "updatedUser", consent.UpdatedUser);
						global::Gibraltar.Server.Data.DataConverter.DateTimeOffsetToXmlWriter(xmlWriter, "updatedDt", consent.UpdatedDt);
						xmlWriter.WriteEndElement();
						xmlWriter.Flush();
						result = memoryStream.ToArray();
					}
				}
			}
			return result;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00029218 File Offset: 0x00027418
		public static global::Gibraltar.Data.AutoSendConsent ByteArrayToAutoSendConsent(byte[] rawData)
		{
			global::Gibraltar.Data.AutoSendConsent result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(rawData))
			{
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.Load(memoryStream);
				global::System.Xml.XmlNode documentElement = xmlDocument.DocumentElement;
				if (documentElement == null)
				{
					throw new global::Gibraltar.GibraltarException("There is no auto send consent data in the provided raw data");
				}
				global::System.Guid empty = global::System.Guid.Empty;
				string productName = null;
				string applicationName = null;
				string updatedUser = null;
				global::System.Version applicationVersion = null;
				int userPrompts = 0;
				bool selectionMade = false;
				bool optIn = false;
				bool includeDetails = false;
				global::System.DateTimeOffset minValue = global::System.DateTimeOffset.MinValue;
				global::System.Xml.XmlAttribute xmlAttribute = documentElement.Attributes["id"];
				if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.InnerText))
				{
					empty = new global::System.Guid(xmlAttribute.InnerText);
				}
				xmlAttribute = documentElement.Attributes["product"];
				if (xmlAttribute != null)
				{
					productName = xmlAttribute.InnerText;
				}
				xmlAttribute = documentElement.Attributes["application"];
				if (xmlAttribute != null)
				{
					applicationName = xmlAttribute.InnerText;
				}
				xmlAttribute = documentElement.Attributes["applicationVersion"];
				if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.InnerText))
				{
					applicationVersion = new global::System.Version(xmlAttribute.InnerText);
				}
				xmlAttribute = documentElement.Attributes["userPrompts"];
				if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.InnerText))
				{
					userPrompts = int.Parse(xmlAttribute.InnerText);
				}
				xmlAttribute = documentElement.Attributes["selectionMade"];
				if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.InnerText))
				{
					selectionMade = bool.Parse(xmlAttribute.InnerText);
				}
				xmlAttribute = documentElement.Attributes["optIn"];
				if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.InnerText))
				{
					optIn = bool.Parse(xmlAttribute.InnerText);
				}
				xmlAttribute = documentElement.Attributes["includeDetails"];
				if (xmlAttribute != null && !string.IsNullOrEmpty(xmlAttribute.InnerText))
				{
					includeDetails = bool.Parse(xmlAttribute.InnerText);
				}
				xmlAttribute = documentElement.Attributes["updatedUser"];
				if (xmlAttribute != null)
				{
					updatedUser = xmlAttribute.InnerText;
				}
				if (documentElement.HasChildNodes)
				{
					global::System.Xml.XmlNode xmlNode = null;
					foreach (object obj in documentElement.ChildNodes)
					{
						global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj;
						if (xmlNode2.NodeType == global::System.Xml.XmlNodeType.Element)
						{
							string name = xmlNode2.Name;
							if (name == "updatedDt")
							{
								xmlNode = xmlNode2;
							}
							if (xmlNode != null)
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
							minValue = new global::System.DateTimeOffset(global::System.DateTime.Parse(innerText), new global::System.TimeSpan(0, int.Parse(innerText2), 0));
						}
					}
				}
				result = new global::Gibraltar.Data.AutoSendConsent(empty, productName, applicationName, applicationVersion, userPrompts, selectionMade, optIn, includeDetails, minValue, updatedUser);
			}
			return result;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00029588 File Offset: 0x00027788
		public static byte[] SessionXmlToByteArray(global::Gibraltar.Server.Client.Data.SessionXml sessionXml)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(2048))
			{
				using (global::System.IO.TextWriter textWriter = new global::System.IO.StreamWriter(memoryStream, global::System.Text.Encoding.UTF8))
				{
					using (global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(textWriter, new global::System.Xml.XmlWriterSettings()))
					{
						xmlWriter.WriteStartElement("SessionXml");
						global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "id", sessionXml.id);
						global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "version", sessionXml.version);
						global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "deleted", sessionXml.deleted);
						if (sessionXml.isCompleteSpecified)
						{
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "isComplete", sessionXml.isComplete);
						}
						global::Gibraltar.Server.Client.Data.SessionDetailXml sessionDetail = sessionXml.sessionDetail;
						if (sessionDetail != null)
						{
							xmlWriter.WriteStartElement("sessionDetail", "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd");
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "productName", sessionDetail.productName);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "applicationName", sessionDetail.applicationName);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "environmentName", sessionDetail.environmentName);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "promotionLevelName", sessionDetail.promotionLevelName);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "applicationVersion", sessionDetail.applicationVersion);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "applicationType", sessionDetail.applicationType.ToString());
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "applicationDescription", sessionDetail.applicationDescription);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "caption", sessionDetail.caption);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "status", sessionDetail.status.ToString());
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "timeZoneCaption", sessionDetail.timeZoneCaption);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "durationSec", (long)sessionDetail.durationSec);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "agentVersion", sessionDetail.agentVersion);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "userName", sessionDetail.userName);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "userDomainName", sessionDetail.userDomainName);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "hostName", sessionDetail.hostName);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "dnsDomainName", sessionDetail.dnsDomainName);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "isNew", sessionDetail.isNew);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "isComplete", sessionDetail.isComplete);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "messageCount", (long)sessionDetail.messageCount);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "criticalMessageCount", (long)sessionDetail.criticalMessageCount);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "errorMessageCount", (long)sessionDetail.errorMessageCount);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "warningMessageCount", (long)sessionDetail.warningMessageCount);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "updateUser", sessionDetail.updateUser);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "osPlatformCode", (long)sessionDetail.osPlatformCode);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "osVersion", sessionDetail.osVersion);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "osServicePack", sessionDetail.osServicePack);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "osCultureName", sessionDetail.osCultureName);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "osArchitecture", sessionDetail.osArchitecture.ToString());
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "osBootMode", sessionDetail.osBootMode.ToString());
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "osSuiteMaskCode", (long)sessionDetail.osSuiteMaskCode);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "osProductTypeCode", (long)sessionDetail.osProductTypeCode);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "runtimeVersion", sessionDetail.runtimeVersion);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "runtimeArchitecture", sessionDetail.runtimeArchitecture.ToString());
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "currentCultureName", sessionDetail.currentCultureName);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "currentUiCultureName", sessionDetail.currentUiCultureName);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "memoryMb", (long)sessionDetail.memoryMb);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "processors", (long)sessionDetail.processors);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "processorCores", (long)sessionDetail.processorCores);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "userInteractive", sessionDetail.userInteractive);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "terminalServer", sessionDetail.terminalServer);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "screenWidth", (long)sessionDetail.screenWidth);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "screenHeight", (long)sessionDetail.screenHeight);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "colorDepth", (long)sessionDetail.colorDepth);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "commandLine", sessionDetail.commandLine);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "fileSize", sessionDetail.fileSize);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "fileAvailable", sessionDetail.fileAvailable);
							global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "computerId", sessionDetail.computerId);
							global::Gibraltar.Server.Data.DataConverter.DateTimeOffsetXmlToXmlWriter(xmlWriter, "startDt", sessionDetail.startDt);
							global::Gibraltar.Server.Data.DataConverter.DateTimeOffsetXmlToXmlWriter(xmlWriter, "endDt", sessionDetail.endDt);
							global::Gibraltar.Server.Data.DataConverter.DateTimeOffsetXmlToXmlWriter(xmlWriter, "addedDt", sessionDetail.addedDt);
							global::Gibraltar.Server.Data.DataConverter.DateTimeOffsetXmlToXmlWriter(xmlWriter, "updatedDt", sessionDetail.updatedDt);
							xmlWriter.WriteEndElement();
						}
						xmlWriter.WriteEndElement();
						xmlWriter.Flush();
						result = memoryStream.ToArray();
					}
				}
			}
			return result;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00029A80 File Offset: 0x00027C80
		private static void DateTimeOffsetXmlToXmlWriter(global::System.Xml.XmlWriter xmlWriter, string elementName, global::Gibraltar.Server.Client.Data.DateTimeOffsetXml dateTimeOffsetXml)
		{
			if (dateTimeOffsetXml == null)
			{
				return;
			}
			xmlWriter.WriteStartElement(elementName);
			global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "DateTime", dateTimeOffsetXml.DateTime);
			global::Gibraltar.Server.Data.DataConverter.WriteXmlAttribute(xmlWriter, "Offset", (long)dateTimeOffsetXml.Offset);
			xmlWriter.WriteEndElement();
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00029AC8 File Offset: 0x00027CC8
		private static void DateTimeOffsetToXmlWriter(global::System.Xml.XmlWriter xmlWriter, string elementName, global::System.DateTimeOffset dateTimeOffset)
		{
			global::Gibraltar.Server.Data.DataConverter.DateTimeOffsetXmlToXmlWriter(xmlWriter, elementName, global::Gibraltar.Server.Data.DataConverter.ToDateTimeOffsetXml(dateTimeOffset));
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00029AD8 File Offset: 0x00027CD8
		public static global::Gibraltar.Server.Client.Data.ClientRepositoryXml ToClientRepositoryXml(global::System.Guid id, string hostName, string computerKey, string statusName, global::System.DateTimeOffset addedDt, long currentSessionsVersion, string publicKey, global::System.DateTimeOffset lastContactDt)
		{
			return new global::Gibraltar.Server.Client.Data.ClientRepositoryXml
			{
				id = id.ToString(),
				addedDt = global::Gibraltar.Server.Data.DataConverter.ToDateTimeOffsetXml(addedDt),
				computerKey = computerKey,
				currentSessionsVersion = currentSessionsVersion,
				hostName = hostName,
				lastContactDt = global::Gibraltar.Server.Data.DataConverter.ToDateTimeOffsetXml(lastContactDt),
				publicKey = publicKey,
				status = global::Gibraltar.Server.Data.DataConverter.ToClientRepositoryStatusXml(statusName)
			};
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00029B48 File Offset: 0x00027D48
		public static global::Gibraltar.Server.Client.Data.SessionXml ToSessionXml(global::System.Guid id, long version, bool deleted)
		{
			return new global::Gibraltar.Server.Client.Data.SessionXml
			{
				id = id.ToString(),
				version = version,
				deleted = deleted
			};
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00029B80 File Offset: 0x00027D80
		public static global::Gibraltar.Server.Client.Data.SessionXml ToSessionXml(global::Loupe.Extensibility.Data.ISessionSummary sessionSummary)
		{
			if (sessionSummary == null)
			{
				throw new global::System.ArgumentNullException("sessionSummary");
			}
			return global::Gibraltar.Server.Data.DataConverter.ToSessionXml(sessionSummary.Id, sessionSummary.ComputerId, 0L, false, false, true, sessionSummary.StartDateTime, sessionSummary.EndDateTime, sessionSummary.FullyQualifiedUserName, sessionSummary.Product, sessionSummary.Application, sessionSummary.Environment, sessionSummary.PromotionLevel, sessionSummary.ApplicationVersion.ToString(), sessionSummary.ApplicationType.ToString(), sessionSummary.ApplicationDescription, sessionSummary.Caption, sessionSummary.Status.ToString(), sessionSummary.TimeZoneCaption, sessionSummary.StartDateTime, sessionSummary.EndDateTime, global::System.Convert.ToInt32(sessionSummary.Duration.TotalSeconds), sessionSummary.AgentVersion.ToString(), sessionSummary.UserName, sessionSummary.UserDomainName, sessionSummary.HostName, sessionSummary.DnsDomainName, sessionSummary.MessageCount, sessionSummary.CriticalCount, sessionSummary.ErrorCount, sessionSummary.WarningCount, sessionSummary.OSPlatformCode, sessionSummary.OSVersion.ToString(), sessionSummary.OSServicePack, sessionSummary.OSCultureName, sessionSummary.OSArchitecture.ToString(), sessionSummary.OSBootMode.ToString(), sessionSummary.OSSuiteMask, sessionSummary.OSProductType, sessionSummary.RuntimeVersion.ToString(), sessionSummary.RuntimeArchitecture.ToString(), sessionSummary.CurrentCultureName, sessionSummary.CurrentUICultureName, sessionSummary.MemoryMB, sessionSummary.Processors, sessionSummary.ProcessorCores, sessionSummary.UserInteractive, sessionSummary.TerminalServer, sessionSummary.ScreenWidth, sessionSummary.ScreenHeight, sessionSummary.ColorDepth, sessionSummary.CommandLine, false, 0, sessionSummary.Properties);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00029D3C File Offset: 0x00027F3C
		public static global::Gibraltar.Server.Client.Data.SessionXml ToSessionXml(global::System.Guid id, global::System.Guid? computerId, long version, bool deleted, bool IsComplete, bool IsNew, global::System.DateTimeOffset AddedDt, global::System.DateTimeOffset UpdatedDt, string UpdatedUser, string ProductName, string ApplicationName, string environmentName, string promotionLevelName, string ApplicationVersion, string ApplicationTypeName, string ApplicationDescription, string Caption, string StatusName, string TimeZoneCaption, global::System.DateTimeOffset StartDt, global::System.DateTimeOffset EndDt, int DurationSec, string AgentVersion, string UserName, string UserDomainName, string HostName, string DNSDomainName, int MessageCount, int CriticalMessageCount, int ErrorMessageCount, int WarningMessageCount, int OSPlatformCode, string OSVersion, string OSServicePack, string OSCultureName, string OSArchitectureName, string OSBootModeName, int OSSuiteMaskCode, int OSProductTypeCode, string RuntimeVersion, string RuntimeArchitectureName, string CurrentCultureName, string CurrentUICultureName, int MemoryMB, int Processors, int ProcessorCores, bool UserInteractive, bool TerminalServer, int ScreenWidth, int ScreenHeight, int ColorDepth, string CommandLine, bool fileAvailable, int fileSize, global::System.Collections.Generic.IDictionary<string, string> properties)
		{
			global::Gibraltar.Server.Client.Data.SessionXml sessionXml = global::Gibraltar.Server.Data.DataConverter.ToSessionXml(id, version, deleted);
			sessionXml.sessionDetail = new global::Gibraltar.Server.Client.Data.SessionDetailXml
			{
				addedDt = global::Gibraltar.Server.Data.DataConverter.ToDateTimeOffsetXml(AddedDt),
				agentVersion = AgentVersion,
				applicationDescription = ApplicationDescription,
				applicationName = ApplicationName,
				environmentName = environmentName,
				promotionLevelName = promotionLevelName,
				applicationType = global::Gibraltar.Server.Data.DataConverter.ToApplicationTypeXml(ApplicationTypeName),
				applicationVersion = ApplicationVersion,
				caption = Caption,
				colorDepth = ColorDepth,
				commandLine = CommandLine,
				computerId = ((computerId != null) ? computerId.ToString() : null),
				criticalMessageCount = CriticalMessageCount,
				currentCultureName = CurrentCultureName,
				currentUiCultureName = CurrentUICultureName,
				dnsDomainName = DNSDomainName,
				durationSec = DurationSec,
				endDt = global::Gibraltar.Server.Data.DataConverter.ToDateTimeOffsetXml(EndDt),
				errorMessageCount = ErrorMessageCount,
				fileAvailable = fileAvailable,
				fileSize = (long)fileSize,
				hostName = HostName,
				isComplete = IsComplete,
				isNew = IsNew,
				memoryMb = MemoryMB,
				messageCount = MessageCount,
				osArchitecture = global::Gibraltar.Server.Data.DataConverter.ToProcessorArchitectureXml(OSArchitectureName),
				osBootMode = global::Gibraltar.Server.Data.DataConverter.ToBootModeXml(OSBootModeName),
				osCultureName = OSCultureName,
				osPlatformCode = OSPlatformCode,
				osProductTypeCode = OSProductTypeCode,
				osServicePack = OSServicePack,
				osSuiteMaskCode = OSSuiteMaskCode,
				osVersion = OSVersion,
				processorCores = ProcessorCores,
				processors = Processors,
				productName = ProductName,
				runtimeArchitecture = global::Gibraltar.Server.Data.DataConverter.ToProcessorArchitectureXml(RuntimeArchitectureName),
				runtimeVersion = RuntimeVersion,
				screenHeight = ScreenHeight,
				screenWidth = ScreenWidth,
				startDt = global::Gibraltar.Server.Data.DataConverter.ToDateTimeOffsetXml(StartDt),
				status = global::Gibraltar.Server.Data.DataConverter.ToSessionStatusXml(StatusName),
				terminalServer = TerminalServer,
				timeZoneCaption = TimeZoneCaption,
				updatedDt = global::Gibraltar.Server.Data.DataConverter.ToDateTimeOffsetXml(UpdatedDt),
				updateUser = UpdatedUser,
				userDomainName = UserDomainName,
				userInteractive = UserInteractive,
				userName = UserName,
				warningMessageCount = WarningMessageCount,
				properties = global::Gibraltar.Server.Data.DataConverter.ToSessionPropertiesXml(properties)
			};
			return sessionXml;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00029F54 File Offset: 0x00028154
		public static global::Gibraltar.Server.Client.Data.SessionPropertyXml[] ToSessionPropertiesXml(global::System.Collections.Generic.IDictionary<string, string> properties)
		{
			if (properties == null || properties.Count == 0)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::Gibraltar.Server.Client.Data.SessionPropertyXml> list = new global::System.Collections.Generic.List<global::Gibraltar.Server.Client.Data.SessionPropertyXml>(properties.Count);
			foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in properties)
			{
				global::Gibraltar.Server.Client.Data.SessionPropertyXml item = global::Gibraltar.Server.Data.DataConverter.ToSessionPropertyXml(global::System.Guid.NewGuid(), keyValuePair.Key, keyValuePair.Value);
				list.Add(item);
			}
			return list.ToArray();
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00029FE4 File Offset: 0x000281E4
		public static global::Gibraltar.Server.Client.Data.SessionPropertyXml ToSessionPropertyXml(global::System.Guid id, string name, string value)
		{
			return new global::Gibraltar.Server.Client.Data.SessionPropertyXml
			{
				id = id.ToString(),
				name = name,
				value = value
			};
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x0002A01C File Offset: 0x0002821C
		public static global::Gibraltar.Server.Client.Data.SessionFileXml ToSessionFileXml(global::System.Guid id, int sequence, long version)
		{
			return new global::Gibraltar.Server.Client.Data.SessionFileXml
			{
				id = id.ToString(),
				sequence = (long)sequence,
				version = version
			};
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x0002A054 File Offset: 0x00028254
		public static global::Gibraltar.Server.Client.Data.ApplicationTypeXml ToApplicationTypeXml(string typeName)
		{
			return (global::Gibraltar.Server.Client.Data.ApplicationTypeXml)global::System.Enum.Parse(typeof(global::Gibraltar.Server.Client.Data.ApplicationTypeXml), typeName, true);
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x0002A06C File Offset: 0x0002826C
		public static global::Gibraltar.Server.Client.Data.BootModeXml ToBootModeXml(string typeName)
		{
			return (global::Gibraltar.Server.Client.Data.BootModeXml)global::System.Enum.Parse(typeof(global::Gibraltar.Server.Client.Data.BootModeXml), typeName, true);
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x0002A084 File Offset: 0x00028284
		public static global::Gibraltar.Server.Client.Data.ClientRepositoryStatusXml ToClientRepositoryStatusXml(string statusName)
		{
			return (global::Gibraltar.Server.Client.Data.ClientRepositoryStatusXml)global::System.Enum.Parse(typeof(global::Gibraltar.Server.Client.Data.ClientRepositoryStatusXml), statusName, true);
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x0002A09C File Offset: 0x0002829C
		public static global::Gibraltar.Server.Client.Data.FolderTypeXml ToFolderType(string typeName)
		{
			return (global::Gibraltar.Server.Client.Data.FolderTypeXml)global::System.Enum.Parse(typeof(global::Gibraltar.Server.Client.Data.FolderTypeXml), typeName, true);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x0002A0B4 File Offset: 0x000282B4
		public static global::Gibraltar.Server.Client.Data.ProcessorArchitectureXml ToProcessorArchitectureXml(string statusName)
		{
			return (global::Gibraltar.Server.Client.Data.ProcessorArchitectureXml)global::System.Enum.Parse(typeof(global::Gibraltar.Server.Client.Data.ProcessorArchitectureXml), statusName, true);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0002A0CC File Offset: 0x000282CC
		public static global::Gibraltar.Server.Client.Data.SessionStatusXml ToSessionStatusXml(string statusName)
		{
			return (global::Gibraltar.Server.Client.Data.SessionStatusXml)global::System.Enum.Parse(typeof(global::Gibraltar.Server.Client.Data.SessionStatusXml), statusName, true);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0002A0E4 File Offset: 0x000282E4
		public static global::Gibraltar.Server.Client.Data.DateTimeOffsetXml ToDateTimeOffsetXml(global::System.DateTimeOffset dateTime)
		{
			return new global::Gibraltar.Server.Client.Data.DateTimeOffsetXml
			{
				DateTime = dateTime.DateTime,
				Offset = (int)dateTime.Offset.TotalMinutes
			};
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0002A120 File Offset: 0x00028320
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

		// Token: 0x06000F6F RID: 3951 RVA: 0x0002A16C File Offset: 0x0002836C
		public static global::Gibraltar.Server.Client.Data.LogMessageSeverityXml ToLogMessageSeverityXml(string severityName)
		{
			return (global::Gibraltar.Server.Client.Data.LogMessageSeverityXml)global::System.Enum.Parse(typeof(global::Gibraltar.Server.Client.Data.LogMessageSeverityXml), severityName, true);
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0002A184 File Offset: 0x00028384
		public static global::Loupe.Extensibility.Data.LogMessageSeverity FromLogMessageSeverityXml(string severityName)
		{
			return (global::Loupe.Extensibility.Data.LogMessageSeverity)global::System.Enum.Parse(typeof(global::Loupe.Extensibility.Data.LogMessageSeverity), severityName, true);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0002A19C File Offset: 0x0002839C
		public static global::System.Reflection.ProcessorArchitecture FromProcessorArchitectureXml(global::Gibraltar.Server.Client.Data.ProcessorArchitectureXml architectureXml)
		{
			return (global::System.Reflection.ProcessorArchitecture)global::System.Enum.Parse(typeof(global::System.Reflection.ProcessorArchitecture), architectureXml.ToString(), true);
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0002A1C0 File Offset: 0x000283C0
		public static global::System.Windows.Forms.BootMode FromBootModeXml(global::Gibraltar.Server.Client.Data.BootModeXml bootModeXml)
		{
			return (global::System.Windows.Forms.BootMode)global::System.Enum.Parse(typeof(global::System.Windows.Forms.BootMode), bootModeXml.ToString(), true);
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x0002A1E4 File Offset: 0x000283E4
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

		// Token: 0x06000F74 RID: 3956 RVA: 0x0002A204 File Offset: 0x00028404
		private static void WriteXmlAttribute(global::System.Xml.XmlWriter xmlWriter, string name, long value)
		{
			xmlWriter.WriteStartAttribute(name);
			xmlWriter.WriteValue(value);
			xmlWriter.WriteEndAttribute();
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0002A21C File Offset: 0x0002841C
		private static void WriteXmlAttribute(global::System.Xml.XmlWriter xmlWriter, string name, bool value)
		{
			xmlWriter.WriteStartAttribute(name);
			xmlWriter.WriteValue(value);
			xmlWriter.WriteEndAttribute();
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0002A234 File Offset: 0x00028434
		private static void WriteXmlAttribute(global::System.Xml.XmlWriter xmlWriter, string name, global::System.DateTime value)
		{
			xmlWriter.WriteStartAttribute(name);
			xmlWriter.WriteValue(value);
			xmlWriter.WriteEndAttribute();
		}

		// Token: 0x04000530 RID: 1328
		private const string LogCategory = "Loupe.Server.Data";
	}
}
