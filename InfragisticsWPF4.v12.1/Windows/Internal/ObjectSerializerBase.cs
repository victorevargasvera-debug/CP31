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
	// Token: 0x0200018E RID: 398
	public class ObjectSerializerBase
	{
		// Token: 0x06000D42 RID: 3394 RVA: 0x0002A308 File Offset: 0x00028508
		public ObjectSerializerBase()
		{
			this._document = new global::System.Xml.XmlDocument();
			this._registeredInfos = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Infragistics.Windows.Internal.ObjectSerializationInfo>();
			this.RegisterInfo(typeof(global::Infragistics.Windows.Controls.ConditionGroup), new global::Infragistics.Windows.Controls.ConditionGroup.SerializationInfo());
			this.RegisterInfo(typeof(global::Infragistics.Windows.Controls.ComparisonCondition), new global::Infragistics.Windows.Controls.ComparisonCondition.SerializationInfo());
			this.RegisterInfo(typeof(global::Infragistics.Windows.Controls.ComplementCondition), new global::Infragistics.Windows.Controls.ComplementCondition.SerializationInfo());
			global::Infragistics.Windows.Controls.SpecialFilterOperandFactory.RegisterSerializationInfos(this);
			global::Infragistics.Windows.Controls.SpecialFilterOperands.RegisterSerializationInfos(this);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x0002A388 File Offset: 0x00028588
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

		// Token: 0x06000D44 RID: 3396 RVA: 0x0002A3E9 File Offset: 0x000285E9
		protected global::System.Xml.XmlElement CreateNewElement(string name)
		{
			return this._document.CreateElement(name);
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x0002A3F7 File Offset: 0x000285F7
		protected virtual bool ParseAttributeOverride(string attributeValue, global::System.Type propertyType, out object parsedValue)
		{
			parsedValue = null;
			return false;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x0002A3FD File Offset: 0x000285FD
		protected virtual bool ParseElementOverride(global::System.Xml.XmlElement element, global::System.Type propertyType, out object parsedValue)
		{
			parsedValue = null;
			return false;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x0002A403 File Offset: 0x00028603
		protected virtual bool SaveAsAttributeOverride(object obj, global::System.Type propertyType, out string attributeValue)
		{
			attributeValue = null;
			return false;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x0002A409 File Offset: 0x00028609
		protected virtual bool SaveAsElementOverride(object obj, global::System.Type propertyType, out global::System.Xml.XmlElement element)
		{
			element = null;
			return false;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0002A410 File Offset: 0x00028610
		public bool ParseAttribute(global::System.Xml.XmlElement elem, string attributeName, global::System.Type propertyType, out object parsedValue)
		{
			parsedValue = null;
			global::System.Xml.XmlAttribute xmlAttribute = elem.Attributes[attributeName];
			return xmlAttribute != null && this.ParseAttribute(xmlAttribute.Value, propertyType, out parsedValue);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0002A442 File Offset: 0x00028642
		public bool ParseAttribute(string attributeValue, global::System.Type propertyType, out object parsedValue)
		{
			return this.ParseAttributeOverride(attributeValue, propertyType, out parsedValue) || global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.ParseAttrubuteValue(attributeValue, propertyType, out parsedValue);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0002A45E File Offset: 0x0002865E
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

		// Token: 0x06000D4C RID: 3404 RVA: 0x0002A47E File Offset: 0x0002867E
		public bool SaveAsAttribute(object obj, global::System.Type propertyType, out string attributeValue)
		{
			return this.SaveAsAttributeOverride(obj, propertyType, out attributeValue) || global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.ToAttributeValue(obj, propertyType, out attributeValue);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x0002A49A File Offset: 0x0002869A
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

		// Token: 0x06000D4E RID: 3406 RVA: 0x0002A4BC File Offset: 0x000286BC
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

		// Token: 0x06000D4F RID: 3407 RVA: 0x0002A524 File Offset: 0x00028724
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

		// Token: 0x06000D50 RID: 3408 RVA: 0x0002A568 File Offset: 0x00028768
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

		// Token: 0x06000D51 RID: 3409 RVA: 0x0002A5FC File Offset: 0x000287FC
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

		// Token: 0x06000D52 RID: 3410 RVA: 0x0002A7C4 File Offset: 0x000289C4
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

		// Token: 0x06000D53 RID: 3411 RVA: 0x0002A928 File Offset: 0x00028B28
		public void RegisterInfo(global::System.Type type, global::Infragistics.Windows.Internal.ObjectSerializationInfo info)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(info, "info");
			this._registeredInfos[type] = info;
		}

		// Token: 0x040006D4 RID: 1748
		private global::System.Xml.XmlDocument _document;

		// Token: 0x040006D5 RID: 1749
		private global::System.Collections.Generic.Dictionary<global::System.Type, global::Infragistics.Windows.Internal.ObjectSerializationInfo> _registeredInfos;

		// Token: 0x040006D6 RID: 1750
		private global::Infragistics.Windows.Internal.XmlSerializationInfo _xmlSerializationInfo = new global::Infragistics.Windows.Internal.XmlSerializationInfo();

		// Token: 0x0200018F RID: 399
		private class AttributeValueParser
		{
			// Token: 0x06000D54 RID: 3412 RVA: 0x0002A944 File Offset: 0x00028B44
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
				this._knownTypesInfo = list.ToArray();
				this._typeValuePairRegex = new global::System.Text.RegularExpressions.Regex("^ *([^ \\:]+) *\\: *(.*) *$", global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
			}

			// Token: 0x06000D55 RID: 3413 RVA: 0x0002AB38 File Offset: 0x00028D38
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

			// Token: 0x06000D56 RID: 3414 RVA: 0x0002ABA0 File Offset: 0x00028DA0
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

			// Token: 0x06000D57 RID: 3415 RVA: 0x0002AC10 File Offset: 0x00028E10
			private global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo GetTypeInfo(string name, global::System.Type propertyType)
			{
				foreach (global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo typeInfo in this._knownTypesInfo)
				{
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

			// Token: 0x06000D58 RID: 3416 RVA: 0x0002AC78 File Offset: 0x00028E78
			private global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo GetTypeInfo(global::System.Type type)
			{
				foreach (global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo typeInfo in this._knownTypesInfo)
				{
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

			// Token: 0x06000D59 RID: 3417 RVA: 0x0002ACE8 File Offset: 0x00028EE8
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

			// Token: 0x06000D5A RID: 3418 RVA: 0x0002AD4C File Offset: 0x00028F4C
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

			// Token: 0x06000D5B RID: 3419 RVA: 0x0002ADC0 File Offset: 0x00028FC0
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

			// Token: 0x06000D5C RID: 3420 RVA: 0x0002AE3C File Offset: 0x0002903C
			public static bool ParseAttrubuteValue(string attributeValue, global::System.Type propertyType, out object parsedValue)
			{
				return global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.g_instance.ParseAttrubuteValueHelper(attributeValue, propertyType, out parsedValue);
			}

			// Token: 0x06000D5D RID: 3421 RVA: 0x0002AE4B File Offset: 0x0002904B
			public static bool ToAttributeValue(object value, global::System.Type propertyType, out string attributeValue)
			{
				return global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.g_instance.ToAttributeValueHelper(value, propertyType, out attributeValue);
			}

			// Token: 0x040006D7 RID: 1751
			private const char TYPE_NAME_SEPARATOR = ':';

			// Token: 0x040006D8 RID: 1752
			private global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser.TypeInfo[] _knownTypesInfo;

			// Token: 0x040006D9 RID: 1753
			private global::System.Text.RegularExpressions.Regex _typeValuePairRegex;

			// Token: 0x040006DA RID: 1754
			private global::System.Globalization.CultureInfo _cultureInfo;

			// Token: 0x040006DB RID: 1755
			private static global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser g_instance = new global::Infragistics.Windows.Internal.ObjectSerializerBase.AttributeValueParser();

			// Token: 0x02000190 RID: 400
			private class TypeInfo
			{
				// Token: 0x06000D5F RID: 3423 RVA: 0x0002AE66 File Offset: 0x00029066
				internal TypeInfo(global::System.Type type)
				{
					this._type = type;
					this._name = type.Name;
					this._converter = global::System.ComponentModel.TypeDescriptor.GetConverter(type);
				}

				// Token: 0x06000D60 RID: 3424 RVA: 0x0002AE8D File Offset: 0x0002908D
				internal TypeInfo(global::System.Type type, string name, global::System.ComponentModel.TypeConverter converter)
				{
					this._type = type;
					this._name = name;
					this._converter = converter;
				}

				// Token: 0x040006DC RID: 1756
				internal global::System.Type _type;

				// Token: 0x040006DD RID: 1757
				internal global::System.ComponentModel.TypeConverter _converter;

				// Token: 0x040006DE RID: 1758
				internal string _name;
			}
		}
	}
}
