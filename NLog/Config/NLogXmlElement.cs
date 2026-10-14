using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;
using NLog.Internal;

namespace NLog.Config
{
	// Token: 0x0200016E RID: 366
	internal class NLogXmlElement
	{
		// Token: 0x06000FEC RID: 4076 RVA: 0x00029364 File Offset: 0x00027564
		public NLogXmlElement(string inputUri) : this()
		{
			using (global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(inputUri))
			{
				xmlReader.MoveToContent();
				this.Parse(xmlReader);
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x000293A8 File Offset: 0x000275A8
		public NLogXmlElement(global::System.Xml.XmlReader reader) : this()
		{
			this.Parse(reader);
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x000293B7 File Offset: 0x000275B7
		private NLogXmlElement()
		{
			this.AttributeValues = new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.OrdinalIgnoreCase);
			this.Children = new global::System.Collections.Generic.List<global::NLog.Config.NLogXmlElement>();
			this._parsingErrors = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x000293E5 File Offset: 0x000275E5
		// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x000293ED File Offset: 0x000275ED
		public string LocalName { get; private set; }

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x000293F6 File Offset: 0x000275F6
		// (set) Token: 0x06000FF2 RID: 4082 RVA: 0x000293FE File Offset: 0x000275FE
		public global::System.Collections.Generic.Dictionary<string, string> AttributeValues { get; private set; }

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00029407 File Offset: 0x00027607
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x0002940F File Offset: 0x0002760F
		public global::System.Collections.Generic.IList<global::NLog.Config.NLogXmlElement> Children { get; private set; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00029418 File Offset: 0x00027618
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x00029420 File Offset: 0x00027620
		public string Value { get; private set; }

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0002942C File Offset: 0x0002762C
		public global::System.Collections.Generic.IEnumerable<global::NLog.Config.NLogXmlElement> Elements(string elementName)
		{
			global::System.Collections.Generic.List<global::NLog.Config.NLogXmlElement> list = new global::System.Collections.Generic.List<global::NLog.Config.NLogXmlElement>();
			foreach (global::NLog.Config.NLogXmlElement nlogXmlElement in this.Children)
			{
				if (nlogXmlElement.LocalName.Equals(elementName, global::System.StringComparison.OrdinalIgnoreCase))
				{
					list.Add(nlogXmlElement);
				}
			}
			return list;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00029490 File Offset: 0x00027690
		public string GetRequiredAttribute(string attributeName)
		{
			string optionalAttribute = this.GetOptionalAttribute(attributeName, null);
			if (optionalAttribute == null)
			{
				throw new global::NLog.NLogConfigurationException(string.Concat(new string[]
				{
					"Expected ",
					attributeName,
					" on <",
					this.LocalName,
					" />"
				}));
			}
			return optionalAttribute;
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x000294E0 File Offset: 0x000276E0
		public bool GetOptionalBooleanAttribute(string attributeName, bool defaultValue)
		{
			string value;
			if (!this.AttributeValues.TryGetValue(attributeName, out value))
			{
				return defaultValue;
			}
			return global::System.Convert.ToBoolean(value, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0002950C File Offset: 0x0002770C
		public bool? GetOptionalBooleanAttribute(string attributeName, bool? defaultValue)
		{
			string value;
			if (!this.AttributeValues.TryGetValue(attributeName, out value))
			{
				return defaultValue;
			}
			if (global::NLog.Internal.StringHelpers.IsNullOrWhiteSpace(value))
			{
				return null;
			}
			return new bool?(global::System.Convert.ToBoolean(value, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00029550 File Offset: 0x00027750
		public string GetOptionalAttribute(string attributeName, string defaultValue)
		{
			string result;
			if (!this.AttributeValues.TryGetValue(attributeName, out result))
			{
				result = defaultValue;
			}
			return result;
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00029570 File Offset: 0x00027770
		public void AssertName(params string[] allowedNames)
		{
			foreach (string value in allowedNames)
			{
				if (this.LocalName.Equals(value, global::System.StringComparison.OrdinalIgnoreCase))
				{
					return;
				}
			}
			throw new global::System.InvalidOperationException(string.Concat(new string[]
			{
				"Assertion failed. Expected element name '",
				string.Join("|", allowedNames),
				"', actual: '",
				this.LocalName,
				"'."
			}));
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x000295E0 File Offset: 0x000277E0
		public global::System.Collections.Generic.IEnumerable<string> GetParsingErrors()
		{
			foreach (string text in this._parsingErrors)
			{
				yield return text;
			}
			global::System.Collections.Generic.List<string>.Enumerator enumerator = default(global::System.Collections.Generic.List<string>.Enumerator);
			foreach (global::NLog.Config.NLogXmlElement nlogXmlElement in this.Children)
			{
				foreach (string text2 in nlogXmlElement.GetParsingErrors())
				{
					yield return text2;
				}
				global::System.Collections.Generic.IEnumerator<string> enumerator3 = null;
			}
			global::System.Collections.Generic.IEnumerator<global::NLog.Config.NLogXmlElement> enumerator2 = null;
			yield break;
			yield break;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x000295F0 File Offset: 0x000277F0
		private void Parse(global::System.Xml.XmlReader reader)
		{
			if (reader.MoveToFirstAttribute())
			{
				do
				{
					if (!this.AttributeValues.ContainsKey(reader.LocalName))
					{
						this.AttributeValues.Add(reader.LocalName, reader.Value);
					}
					else
					{
						string item = string.Format("Duplicate attribute detected. Attribute name: [{0}]. Duplicate value:[{1}], Current value:[{2}]", reader.LocalName, reader.Value, this.AttributeValues[reader.LocalName]);
						this._parsingErrors.Add(item);
					}
				}
				while (reader.MoveToNextAttribute());
				reader.MoveToElement();
			}
			this.LocalName = reader.LocalName;
			if (!reader.IsEmptyElement)
			{
				while (reader.Read() && reader.NodeType != global::System.Xml.XmlNodeType.EndElement)
				{
					if (reader.NodeType == global::System.Xml.XmlNodeType.CDATA || reader.NodeType == global::System.Xml.XmlNodeType.Text)
					{
						this.Value += reader.Value;
					}
					else if (reader.NodeType == global::System.Xml.XmlNodeType.Element)
					{
						this.Children.Add(new global::NLog.Config.NLogXmlElement(reader));
					}
				}
			}
		}

		// Token: 0x04000471 RID: 1137
		private readonly global::System.Collections.Generic.List<string> _parsingErrors;
	}
}
