using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media;
using System.Xml;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001B3 RID: 435
	public class ObjectSerializerBase
	{
		// Token: 0x06000E8F RID: 3727 RVA: 0x0002EA68 File Offset: 0x0002CC68
		public ObjectSerializerBase()
		{
			this._document = new global::System.Xml.XmlDocument();
			this._registeredInfos = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Infragistics.Windows.Internal.ObjectSerializationInfo>();
			this.RegisterInfo(typeof(global::Infragistics.Windows.Controls.ConditionGroup), new global::Infragistics.Windows.Controls.ConditionGroup.SerializationInfo());
			this.RegisterInfo(typeof(global::Infragistics.Windows.Controls.ComparisonCondition), new global::Infragistics.Windows.Controls.ComparisonCondition.SerializationInfo());
			this.RegisterInfo(typeof(global::Infragistics.Windows.Controls.ComplementCondition), new global::Infragistics.Windows.Controls.ComplementCondition.SerializationInfo());
			this.RegisterInfo(typeof(global::Infragistics.Windows.Internal.ObjectWrapper), new global::Infragistics.Windows.Internal.ObjectWrapper.SerializationInfo());
			global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RegisterSerializationInfos(this);
			global::Infragistics.Windows.Controls.SpecialFilterOperands.RegisterSerializationInfos(this);
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0002EAFC File Offset: 0x0002CCFC
		protected bool AppendValueHelper(global::System.Xml.XmlElement parentElem, string attributeName, string elementName, object value, global::System.Type propertyType)
		{
			string value2;
			if (!string.IsNullOrEmpty(attributeName) && this.SaveAsAttribute(value, propertyType, out value2))
			{
				parentElem.SetAttribute(attributeName, value2);
				return true;
			}
			global::System.Xml.XmlElement newChild;
			if (this.InternalSaveAsElement(value, propertyType, out newChild))
			{
				if (!string.IsNullOrEmpty(elementName))
				{
					global::System.Xml.XmlElement xmlElement = this.CreateNewElement(elementName);
					parentElem.AppendChild(xmlElement);
					parentElem = xmlElement;
				}
				parentElem.AppendChild(newChild);
				return true;
			}
			return false;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x0002EB5D File Offset: 0x0002CD5D
		protected global::System.Xml.XmlElement CreateNewElement(string name)
		{
			return this._document.CreateElement(name);
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x0002EB6B File Offset: 0x0002CD6B
		protected virtual bool ParseAttributeOverride(string attributeValue, global::System.Type propertyType, out object parsedValue)
		{
			parsedValue = null;
			return false;
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0002EB71 File Offset: 0x0002CD71
		protected virtual bool ParseElementOverride(global::System.Xml.XmlElement element, global::System.Type propertyType, out object parsedValue)
		{
			parsedValue = null;
			return false;
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x0002EB77 File Offset: 0x0002CD77
		protected virtual bool SaveAsAttributeOverride(object obj, global::System.Type propertyType, out string attributeValue)
		{
			attributeValue = null;
			return false;
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x0002EB7D File Offset: 0x0002CD7D
		protected virtual bool SaveAsElementOverride(object obj, global::System.Type propertyType, out global::System.Xml.XmlElement element)
		{
			element = null;
			return false;
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x0002EB84 File Offset: 0x0002CD84
		public bool ParseAttribute(global::System.Xml.XmlElement elem, string attributeName, global::System.Type propertyType, out object parsedValue)
		{
			parsedValue = null;
			global::System.Xml.XmlAttribute xmlAttribute = elem.Attributes[attributeName];
			return xmlAttribute != null && this.ParseAttribute(xmlAttribute.Value, propertyType, out parsedValue);
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x0002EBB6 File Offset: 0x0002CDB6
		public bool ParseAttribute(string attributeValue, global::System.Type propertyType, out object parsedValue)
		{
			return this.ParseAttributeOverride(attributeValue, propertyType, out parsedValue) || global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.ParseAttrubuteValue(attributeValue, propertyType, out parsedValue);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x0002EBD2 File Offset: 0x0002CDD2
		public bool ParseElement(global::System.Xml.XmlElement element, global::System.Type propertyType, out object parsedValue)
		{
			if (this.ParseElementOverride(element, propertyType, out parsedValue))
			{
				return true;
			}
			if (this.InternalParseElement(element, propertyType, out parsedValue))
			{
				return true;
			}
			parsedValue = null;
			return false;
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0002EBF2 File Offset: 0x0002CDF2
		public bool SaveAsAttribute(object obj, global::System.Type propertyType, out string attributeValue)
		{
			return this.SaveAsAttributeOverride(obj, propertyType, out attributeValue) || global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.ToAttributeValue(obj, propertyType, out attributeValue);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0002EC0E File Offset: 0x0002CE0E
		public bool SaveAsElement(object obj, global::System.Type propertyType, out global::System.Xml.XmlElement element)
		{
			if (this.SaveAsElementOverride(obj, propertyType, out element))
			{
				return true;
			}
			if (this.InternalSaveAsElement(obj, propertyType, out element))
			{
				return true;
			}
			element = null;
			return false;
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0002EC30 File Offset: 0x0002CE30
		private global::System.Xml.XmlElement GetFirstChildElement(global::System.Xml.XmlElement parentElem)
		{
			foreach (object obj in parentElem.ChildNodes)
			{
				global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
				if (xmlNode is global::System.Xml.XmlElement)
				{
					return xmlNode as global::System.Xml.XmlElement;
				}
			}
			return null;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x0002EC98 File Offset: 0x0002CE98
		internal global::Infragistics.Windows.Internal.ObjectSerializationInfo GetRegisteredInfo(global::System.Type type)
		{
			global::Infragistics.Windows.Internal.ObjectSerializationInfo result;
			if (this._registeredInfos.TryGetValue(type, out result))
			{
				return result;
			}
			if (this._xmlSerializationInfo.IsTypeSupported(type))
			{
				result = (this._registeredInfos[type] = this._xmlSerializationInfo);
				return result;
			}
			return null;
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0002ECDC File Offset: 0x0002CEDC
		private global::Infragistics.Windows.Internal.ObjectSerializationInfo GetObjectSerializationInfo(global::System.Xml.XmlElement element, global::System.Type propertyType)
		{
			if ("XmlSerializerData" == element.Name)
			{
				return this._xmlSerializationInfo;
			}
			foreach (global::System.Type type in this._registeredInfos.Keys)
			{
				if (propertyType.IsAssignableFrom(type) && type.Name == element.Name)
				{
					return this.GetRegisteredInfo(type);
				}
			}
			return null;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0002ED70 File Offset: 0x0002CF70
		private bool InternalParseElement(global::System.Xml.XmlElement element, global::System.Type propertyType, out object parsedValue)
		{
			if (element != null && null != propertyType)
			{
				global::Infragistics.Windows.Internal.ObjectSerializationInfo objectSerializationInfo = this.GetObjectSerializationInfo(element, propertyType);
				if (objectSerializationInfo != null)
				{
					global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> serializedProperties = objectSerializationInfo.SerializedProperties;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
					int num = 0;
					foreach (global::Infragistics.Windows.Internal.PropertySerializationInfo propertySerializationInfo in serializedProperties)
					{
						string name = propertySerializationInfo.Name;
						global::System.Type type = propertySerializationInfo.Type;
						if ("[]" == name)
						{
							global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
							foreach (object obj in element.ChildNodes)
							{
								global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj;
								global::System.Xml.XmlElement xmlElement = xmlNode as global::System.Xml.XmlElement;
								object value;
								if (xmlElement != null && this.InternalParseElement(xmlElement, type, out value))
								{
									arrayList.Add(value);
								}
							}
							dictionary[name] = arrayList.ToArray(type);
						}
						else
						{
							global::System.Xml.XmlAttribute xmlAttribute = element.Attributes[name];
							if (xmlAttribute != null)
							{
								object value;
								if (this.ParseAttribute(xmlAttribute.Value, type, out value))
								{
									dictionary[name] = value;
								}
								else
								{
									num++;
								}
							}
							else
							{
								global::System.Xml.XmlElement xmlElement2 = element.SelectSingleNode(name) as global::System.Xml.XmlElement;
								if (xmlElement2 != null)
								{
									xmlElement2 = this.GetFirstChildElement(xmlElement2);
									object value;
									if (xmlElement2 != null && this.InternalParseElement(xmlElement2, type, out value))
									{
										dictionary[name] = value;
									}
									else
									{
										num++;
									}
								}
							}
						}
					}
					parsedValue = objectSerializationInfo.Deserialize(dictionary);
					if (parsedValue != null)
					{
						return true;
					}
				}
			}
			parsedValue = null;
			return false;
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0002EF38 File Offset: 0x0002D138
		public bool InternalSaveAsElement(object obj, global::System.Type propertyType, out global::System.Xml.XmlElement element)
		{
			global::System.Type type = (obj != null) ? obj.GetType() : null;
			if (null != type)
			{
				global::Infragistics.Windows.Internal.ObjectSerializationInfo registeredInfo = this.GetRegisteredInfo(type);
				if (registeredInfo != null)
				{
					string name = type.Name;
					if (registeredInfo is global::Infragistics.Windows.Internal.XmlSerializationInfo)
					{
						name = "XmlSerializerData";
					}
					element = this.CreateNewElement(name);
					global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> serializedProperties = registeredInfo.SerializedProperties;
					global::System.Collections.Generic.Dictionary<string, object> dictionary = registeredInfo.Serialize(obj);
					int num = 0;
					foreach (global::Infragistics.Windows.Internal.PropertySerializationInfo propertySerializationInfo in serializedProperties)
					{
						string name2 = propertySerializationInfo.Name;
						global::System.Type type2 = propertySerializationInfo.Type;
						object obj2;
						if (dictionary.TryGetValue(name2, out obj2))
						{
							if ("[]" == name2)
							{
								global::System.Collections.IEnumerable enumerable = obj2 as global::System.Collections.IEnumerable;
								if (enumerable != null)
								{
									using (global::System.Collections.IEnumerator enumerator2 = enumerable.GetEnumerator())
									{
										while (enumerator2.MoveNext())
										{
											object value = enumerator2.Current;
											if (!this.AppendValueHelper(element, null, null, value, type2))
											{
												num++;
											}
										}
										continue;
									}
								}
								num++;
							}
							else if (!this.AppendValueHelper(element, name2, name2, obj2, type2))
							{
								num++;
							}
						}
					}
					if (num == 0)
					{
						return true;
					}
				}
			}
			element = null;
			return false;
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0002F09C File Offset: 0x0002D29C
		public void RegisterInfo(global::System.Type type, global::Infragistics.Windows.Internal.ObjectSerializationInfo info)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(info, "info");
			this._registeredInfos[type] = info;
		}

		// Token: 0x040007FB RID: 2043
		private global::System.Xml.XmlDocument _document;

		// Token: 0x040007FC RID: 2044
		private global::System.Collections.Generic.Dictionary<global::System.Type, global::Infragistics.Windows.Internal.ObjectSerializationInfo> _registeredInfos;

		// Token: 0x040007FD RID: 2045
		private global::Infragistics.Windows.Internal.XmlSerializationInfo _xmlSerializationInfo = new global::Infragistics.Windows.Internal.XmlSerializationInfo();

		// Token: 0x020001B4 RID: 436
		internal class AttributeValueParser
		{
			// Token: 0x06000EA1 RID: 3745 RVA: 0x0002F0B8 File Offset: 0x0002D2B8
			internal AttributeValueParser()
			{
				this._cultureInfo = global::System.Globalization.CultureInfo.InvariantCulture;
				object[] array = new object[]
				{
					typeof(string),
					null,
					null,
					typeof(sbyte),
					null,
					null,
					typeof(byte),
					null,
					null,
					typeof(short),
					null,
					null,
					typeof(ushort),
					null,
					null,
					typeof(int),
					null,
					null,
					typeof(uint),
					null,
					null,
					typeof(long),
					null,
					null,
					typeof(ulong),
					null,
					null,
					typeof(float),
					null,
					null,
					typeof(double),
					null,
					null,
					typeof(char),
					null,
					null,
					typeof(bool),
					null,
					null,
					typeof(decimal),
					null,
					null,
					typeof(global::System.DateTime),
					null,
					null,
					typeof(string),
					null,
					null,
					typeof(global::System.Windows.Media.Color),
					null,
					new global::System.Windows.Media.ColorConverter(),
					typeof(global::System.Windows.Thickness),
					null,
					new global::System.Windows.ThicknessConverter(),
					typeof(global::System.Windows.Rect),
					null,
					new global::System.Windows.RectConverter(),
					typeof(global::System.Windows.Size),
					null,
					new global::System.Windows.SizeConverter(),
					typeof(global::System.Windows.Point),
					null,
					new global::System.Windows.PointConverter()
				};
				global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo>();
				for (int i = 0; i < array.Length; i += 3)
				{
					global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo typeInfo = new global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo((global::System.Type)array[i]);
					if (array[2 + i] != null)
					{
						typeInfo._converter = (global::System.ComponentModel.TypeConverter)array[2 + i];
					}
					list.Add(typeInfo);
				}
				this._knownTypesInfo = list;
				this._typeValuePairRegex = new global::System.Text.RegularExpressions.Regex("^ *([^ \\:]+) *\\: *(.*) *$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
			}

			// Token: 0x06000EA2 RID: 3746 RVA: 0x0002F2A4 File Offset: 0x0002D4A4
			private bool ConvertFromStringHelper(string valueAsString, global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo typeInfo, out object convertedValue)
			{
				if (typeInfo != null)
				{
					if (typeInfo._converter != null)
					{
						try
						{
							convertedValue = typeInfo._converter.ConvertFromString(null, this._cultureInfo, valueAsString);
							return true;
						}
						catch
						{
							goto IL_42;
						}
					}
					convertedValue = global::Infragistics.CoreUtilities.ConvertDataValue(valueAsString, typeInfo._type, this._cultureInfo, null);
					if (convertedValue != null)
					{
						return true;
					}
				}
				IL_42:
				convertedValue = null;
				return false;
			}

			// Token: 0x06000EA3 RID: 3747 RVA: 0x0002F30C File Offset: 0x0002D50C
			private bool ConvertToStringHelper(object value, out string convertedString)
			{
				convertedString = null;
				if (value == null)
				{
					convertedString = string.Empty;
				}
				else
				{
					global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo typeInfo = this.GetTypeInfo(value.GetType());
					if (typeInfo != null)
					{
						if (typeInfo._converter != null)
						{
							convertedString = typeInfo._converter.ConvertToString(null, this._cultureInfo, value);
						}
						else
						{
							convertedString = (string)global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(string), global::System.Globalization.CultureInfo.InvariantCulture, null);
						}
					}
				}
				return null != convertedString;
			}

			// Token: 0x06000EA4 RID: 3748 RVA: 0x0002F37C File Offset: 0x0002D57C
			private global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo GetTypeInfo(string name, global::System.Type propertyType)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo> knownTypesInfo = this._knownTypesInfo;
				for (int i = 0; i < knownTypesInfo.Count; i++)
				{
					global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo typeInfo = knownTypesInfo[i];
					if (string.Compare(typeInfo._name, name, true, this._cultureInfo) == 0)
					{
						return typeInfo;
					}
				}
				if (null != propertyType)
				{
					propertyType = global::Infragistics.CoreUtilities.GetUnderlyingType(propertyType);
				}
				if (null != propertyType && propertyType.IsEnum)
				{
					return new global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo(propertyType);
				}
				return null;
			}

			// Token: 0x06000EA5 RID: 3749 RVA: 0x0002F3EC File Offset: 0x0002D5EC
			private global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo GetTypeInfo(global::System.Type type)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo> knownTypesInfo = this._knownTypesInfo;
				for (int i = 0; i < knownTypesInfo.Count; i++)
				{
					global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo typeInfo = knownTypesInfo[i];
					if (type == typeInfo._type)
					{
						return typeInfo;
					}
				}
				if (null != type)
				{
					global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(type);
					if (underlyingType != type)
					{
						return this.GetTypeInfo(underlyingType);
					}
				}
				if (null != type && type.IsEnum)
				{
					return new global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo(type);
				}
				return null;
			}

			// Token: 0x06000EA6 RID: 3750 RVA: 0x0002F464 File Offset: 0x0002D664
			private bool ParseAttrubuteValueHelper(string attributeValue, global::System.Type propertyType, out object parsedValue)
			{
				if (!this.ParseTypeValuePair(attributeValue, propertyType, out parsedValue))
				{
					global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo typeInfo = this.GetTypeInfo(propertyType);
					if (typeInfo == null || !this.ConvertFromStringHelper(attributeValue, typeInfo, out parsedValue))
					{
						if (typeInfo != null || !(typeof(object) == propertyType))
						{
							return false;
						}
						parsedValue = attributeValue;
					}
				}
				parsedValue = global::Infragistics.CoreUtilities.ConvertDataValue(parsedValue, propertyType, this._cultureInfo, null);
				return null != parsedValue;
			}

			// Token: 0x06000EA7 RID: 3751 RVA: 0x0002F4C8 File Offset: 0x0002D6C8
			private bool ParseTypeValuePair(string attributeValue, global::System.Type propertyType, out object parsedValue)
			{
				if (attributeValue.IndexOf(':') > 0)
				{
					global::System.Text.RegularExpressions.Match match = this._typeValuePairRegex.Match(attributeValue);
					if (match != null && match.Success)
					{
						string value = match.Groups[1].Value;
						string value2 = match.Groups[2].Value;
						global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo typeInfo = this.GetTypeInfo(value, propertyType);
						if (typeInfo != null && this.ConvertFromStringHelper(value2, typeInfo, out parsedValue))
						{
							return true;
						}
					}
				}
				parsedValue = null;
				return false;
			}

			// Token: 0x06000EA8 RID: 3752 RVA: 0x0002F53C File Offset: 0x0002D73C
			private bool ToAttributeValueHelper(object value, global::System.Type propertyType, out string attributeValue)
			{
				if (this.ConvertToStringHelper(value, out attributeValue))
				{
					global::System.Type type = (value != null) ? global::Infragistics.CoreUtilities.GetUnderlyingType(value.GetType()) : null;
					global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(propertyType);
					bool flag = null != type && type != underlyingType && !(value is string);
					if (flag)
					{
						global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo typeInfo = this.GetTypeInfo(value.GetType());
						if (typeInfo != null)
						{
							attributeValue = typeInfo._name + ":" + attributeValue;
						}
					}
					return true;
				}
				return false;
			}

			// Token: 0x06000EA9 RID: 3753 RVA: 0x0002F5B8 File Offset: 0x0002D7B8
			public static bool ParseAttrubuteValue(string attributeValue, global::System.Type propertyType, out object parsedValue)
			{
				return global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.g_instance.ParseAttrubuteValueHelper(attributeValue, propertyType, out parsedValue);
			}

			// Token: 0x06000EAA RID: 3754 RVA: 0x0002F5C8 File Offset: 0x0002D7C8
			internal static void RegisterType(global::System.Type type)
			{
				global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo typeInfo = global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.g_instance.GetTypeInfo(type);
				if (typeInfo != null && global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.g_instance._knownTypesInfo.IndexOf(typeInfo) < 0)
				{
					global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.g_instance._knownTypesInfo.Add(typeInfo);
				}
			}

			// Token: 0x06000EAB RID: 3755 RVA: 0x0002F607 File Offset: 0x0002D807
			public static bool ToAttributeValue(object value, global::System.Type propertyType, out string attributeValue)
			{
				return global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.g_instance.ToAttributeValueHelper(value, propertyType, out attributeValue);
			}

			// Token: 0x040007FE RID: 2046
			private const char TYPE_NAME_SEPARATOR = ':';

			// Token: 0x040007FF RID: 2047
			private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo> _knownTypesInfo;

			// Token: 0x04000800 RID: 2048
			private global::System.Text.RegularExpressions.Regex _typeValuePairRegex;

			// Token: 0x04000801 RID: 2049
			private global::System.Globalization.CultureInfo _cultureInfo;

			// Token: 0x04000802 RID: 2050
			private static global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser g_instance = new global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser();

			// Token: 0x020001B5 RID: 437
			private class TypeInfo
			{
				// Token: 0x06000EAD RID: 3757 RVA: 0x0002F622 File Offset: 0x0002D822
				internal TypeInfo(global::System.Type type)
				{
					this._type = type;
					this._name = type.Name;
					this._converter = global::System.ComponentModel.TypeDescriptor.GetConverter(type);
				}

				// Token: 0x06000EAE RID: 3758 RVA: 0x0002F649 File Offset: 0x0002D849
				internal TypeInfo(global::System.Type type, string name, global::System.ComponentModel.TypeConverter converter)
				{
					this._type = type;
					this._name = name;
					this._converter = converter;
				}

				// Token: 0x04000803 RID: 2051
				internal global::System.Type _type;

				// Token: 0x04000804 RID: 2052
				internal global::System.ComponentModel.TypeConverter _converter;

				// Token: 0x04000805 RID: 2053
				internal string _name;
			}
		}
	}
}
