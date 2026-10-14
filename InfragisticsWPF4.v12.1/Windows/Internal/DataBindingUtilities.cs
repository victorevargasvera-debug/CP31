using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Xml;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001C2 RID: 450
	public static class DataBindingUtilities
	{
		// Token: 0x060010BC RID: 4284 RVA: 0x0003C3AE File Offset: 0x0003A5AE
		public static global::System.Collections.IEnumerable GetUnderlyingItemSource(object source)
		{
			return global::Infragistics.Windows.Internal.DataBindingUtilities.GetUnderlyingItemSource(source, true);
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0003C3B8 File Offset: 0x0003A5B8
		public static global::System.Collections.IEnumerable GetUnderlyingItemSource(object source, bool returnCollectionViewsSourceCollection)
		{
			if (source is global::System.ComponentModel.ICollectionViewFactory)
			{
				source = global::System.Windows.Data.CollectionViewSource.GetDefaultView(source);
			}
			global::System.Collections.IEnumerable enumerable;
			if (returnCollectionViewsSourceCollection && source is global::System.ComponentModel.ICollectionView)
			{
				enumerable = ((global::System.ComponentModel.ICollectionView)source).SourceCollection;
			}
			else
			{
				enumerable = (source as global::System.Collections.IEnumerable);
			}
			global::System.ComponentModel.IListSource listSource = enumerable as global::System.ComponentModel.IListSource;
			if (listSource != null)
			{
				enumerable = listSource.GetList();
			}
			if (enumerable == null)
			{
				return source as global::System.Collections.IEnumerable;
			}
			return enumerable;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0003C414 File Offset: 0x0003A614
		public static global::System.ComponentModel.PropertyDescriptorCollection GetXmlNodeProperties(global::System.Xml.XmlNode node)
		{
			global::System.Collections.Generic.List<global::System.ComponentModel.PropertyDescriptor> list = new global::System.Collections.Generic.List<global::System.ComponentModel.PropertyDescriptor>();
			if (node.Attributes != null)
			{
				foreach (object obj in node.Attributes)
				{
					global::System.Xml.XmlAttribute node2 = (global::System.Xml.XmlAttribute)obj;
					list.Add(new global::Infragistics.Windows.Internal.XmlNodePropertyDescriptor(node2));
				}
			}
			if (node.ChildNodes != null)
			{
				int num = 0;
				int num2 = 0;
				foreach (object obj2 in node.ChildNodes)
				{
					global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)obj2;
					if (xmlNode.NodeType == global::System.Xml.XmlNodeType.Element)
					{
						num++;
					}
					else if (xmlNode.NodeType == global::System.Xml.XmlNodeType.Text)
					{
						num++;
						num2++;
					}
				}
				if (num2 > 0 && num > 1)
				{
					list.Add(new global::Infragistics.Windows.Internal.XmlNodePropertyDescriptor("Text"));
				}
				else
				{
					global::System.Collections.Generic.Dictionary<string, global::System.Xml.XmlNode> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Xml.XmlNode>();
					global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Internal.XmlNodePropertyDescriptor> dictionary2 = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Windows.Internal.XmlNodePropertyDescriptor>();
					foreach (object obj3 in node.ChildNodes)
					{
						global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)obj3;
						switch (xmlNode2.NodeType)
						{
						case global::System.Xml.XmlNodeType.Element:
						{
							string name = xmlNode2.Name;
							if (name != null && name.Length > 0)
							{
								if (!dictionary2.ContainsKey(name))
								{
									if (dictionary.ContainsKey(name))
									{
										global::System.Xml.XmlNode xmlNode3 = dictionary[name];
										dictionary.Remove(name);
										dictionary2.Add(name, new global::Infragistics.Windows.Internal.XmlNodePropertyDescriptor(name, xmlNode3.LocalName, true));
									}
									else
									{
										dictionary.Add(name, xmlNode2);
									}
								}
							}
							else
							{
								list.Add(new global::Infragistics.Windows.Internal.XmlNodePropertyDescriptor(xmlNode2));
							}
							break;
						}
						case global::System.Xml.XmlNodeType.Text:
							list.Add(new global::Infragistics.Windows.Internal.XmlNodePropertyDescriptor(xmlNode2));
							break;
						}
					}
					if (dictionary.Count > 0)
					{
						foreach (global::System.Xml.XmlNode xmlNode4 in dictionary.Values)
						{
							global::System.Xml.XmlAttributeCollection attributes = xmlNode4.Attributes;
							string name2 = xmlNode4.Name;
							if (attributes != null && attributes.Count > 0 && name2 != null && name2.Length > 0)
							{
								dictionary2.Add(name2, new global::Infragistics.Windows.Internal.XmlNodePropertyDescriptor(name2, xmlNode4.LocalName, true));
							}
							else
							{
								list.Add(new global::Infragistics.Windows.Internal.XmlNodePropertyDescriptor(xmlNode4));
							}
						}
					}
					if (dictionary2.Count > 0)
					{
						foreach (global::Infragistics.Windows.Internal.XmlNodePropertyDescriptor item in dictionary2.Values)
						{
							list.Add(item);
						}
					}
				}
			}
			global::System.ComponentModel.PropertyDescriptor[] array = new global::System.ComponentModel.PropertyDescriptor[list.Count];
			if (list.Count > 0)
			{
				list.CopyTo(array);
			}
			return new global::System.ComponentModel.PropertyDescriptorCollection(array);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0003C738 File Offset: 0x0003A938
		public static bool IsKnownType(global::System.Type type)
		{
			return global::Infragistics.CoreUtilities.IsKnownType(type);
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x0003C740 File Offset: 0x0003A940
		public static string StripMember(string text)
		{
			if (text == null || text.Length < 1)
			{
				return string.Empty;
			}
			string[] array = text.Split(new char[]
			{
				'.'
			});
			int num = array.Length - 1;
			return array[num];
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0003C77C File Offset: 0x0003A97C
		public static object GetObjectForComparison(object listObject)
		{
			global::System.Data.DataRowView dataRowView = listObject as global::System.Data.DataRowView;
			if (dataRowView != null)
			{
				return dataRowView.Row;
			}
			global::Infragistics.Windows.Helpers.EnumerableObjectWrapper enumerableObjectWrapper = listObject as global::Infragistics.Windows.Helpers.EnumerableObjectWrapper;
			if (enumerableObjectWrapper != null)
			{
				return enumerableObjectWrapper.Items;
			}
			return listObject;
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0003C7AC File Offset: 0x0003A9AC
		public static bool GetDataSourceNullValue(global::System.ComponentModel.PropertyDescriptor propertyDescriptor, out object nullValue)
		{
			global::System.Type componentType = propertyDescriptor.ComponentType;
			if (propertyDescriptor is global::Infragistics.Windows.Internal.DataColumnPropertyDescriptor || typeof(global::System.Data.DataRowView).IsAssignableFrom(componentType) || typeof(global::System.Data.DataRow).IsAssignableFrom(componentType))
			{
				nullValue = global::System.DBNull.Value;
				return true;
			}
			global::System.Type propertyType = propertyDescriptor.PropertyType;
			global::System.Type underlyingType = global::System.Nullable.GetUnderlyingType(propertyType);
			bool flag = null != underlyingType && underlyingType != propertyType;
			if (flag)
			{
				nullValue = null;
				return true;
			}
			global::System.ComponentModel.AttributeCollection attributes = propertyDescriptor.Attributes;
			global::System.ComponentModel.DefaultValueAttribute defaultValueAttribute = (attributes != null) ? ((global::System.ComponentModel.DefaultValueAttribute)attributes[typeof(global::System.ComponentModel.DefaultValueAttribute)]) : null;
			if (defaultValueAttribute != null)
			{
				object value = defaultValueAttribute.Value;
				if (value == null || global::System.DBNull.Value == value)
				{
					nullValue = value;
					return true;
				}
			}
			if (!propertyType.IsValueType)
			{
				if (propertyDescriptor is global::System.ComponentModel.DependencyPropertyDescriptor || propertyDescriptor is global::Infragistics.Windows.Internal.ValuePropertyDescriptor)
				{
					nullValue = null;
					return true;
				}
				global::System.Type type = propertyDescriptor.GetType();
				if ("ReflectPropertyDescriptor" == type.Name)
				{
					nullValue = null;
					return true;
				}
			}
			else
			{
				if (propertyDescriptor is global::System.ComponentModel.DependencyPropertyDescriptor)
				{
					nullValue = global::System.Windows.DependencyProperty.UnsetValue;
					return true;
				}
				if (defaultValueAttribute != null)
				{
					nullValue = defaultValueAttribute.Value;
					return true;
				}
			}
			nullValue = null;
			return false;
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x0003C8CC File Offset: 0x0003AACC
		public static object DataBindConvert(object source, global::System.Type destinationType, global::System.Globalization.CultureInfo culture, string format, global::System.IFormatProvider formatInfo, out bool validConversion)
		{
			validConversion = true;
			if (source == null || source is global::System.DBNull)
			{
				return source;
			}
			global::System.Type type = source.GetType();
			if (destinationType.IsAssignableFrom(type))
			{
				return source;
			}
			global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(type);
			if (converter != null && converter.CanConvertTo(destinationType))
			{
				try
				{
					return converter.ConvertTo(null, culture, source, destinationType);
				}
				catch (global::System.NotSupportedException)
				{
				}
			}
			global::System.ComponentModel.TypeConverter converter2 = global::System.ComponentModel.TypeDescriptor.GetConverter(destinationType);
			if (converter2 != null && converter2.CanConvertFrom(type))
			{
				try
				{
					return converter2.ConvertFrom(null, culture, source);
				}
				catch (global::System.NotSupportedException)
				{
				}
			}
			if (destinationType == typeof(string))
			{
				string text = global::Infragistics.CoreUtilities.ToString(source, format, formatInfo, false);
				return text ?? source.ToString();
			}
			if (source is global::System.IConvertible)
			{
				try
				{
					if (formatInfo != null)
					{
						return global::System.Convert.ChangeType(source, destinationType, formatInfo);
					}
					if (culture != null)
					{
						return global::System.Convert.ChangeType(source, destinationType, culture);
					}
					return global::System.Convert.ChangeType(source, destinationType);
				}
				catch (global::System.InvalidCastException)
				{
				}
			}
			validConversion = false;
			return null;
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x0003C9D8 File Offset: 0x0003ABD8
		public static global::System.Collections.IEnumerable GetSampleData()
		{
			if (global::Infragistics.Windows.Internal.DataBindingUtilities.g_sampleDataProvider == null)
			{
				byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(global::SR.GetString("SampleData_XML"));
				global::System.IO.Stream stream = new global::System.IO.MemoryStream(bytes);
				if (stream != null)
				{
					global::Infragistics.Windows.Internal.DataBindingUtilities.g_sampleDataProvider = new global::System.Windows.Data.XmlDataProvider();
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.Load(stream);
					using (global::Infragistics.Windows.Internal.DataBindingUtilities.g_sampleDataProvider.DeferRefresh())
					{
						global::Infragistics.Windows.Internal.DataBindingUtilities.g_sampleDataProvider.Document = xmlDocument;
						global::Infragistics.Windows.Internal.DataBindingUtilities.g_sampleDataProvider.XPath = "/SampleData/users/user";
						global::Infragistics.Windows.Internal.DataBindingUtilities.g_sampleDataProvider.IsAsynchronous = false;
					}
					global::Infragistics.Windows.Internal.DataBindingUtilities.g_sampleDataProvider.Refresh();
					global::Infragistics.Windows.Internal.DataBindingUtilities.g_sampleDataProvider.InitialLoad();
					stream.Close();
				}
			}
			return global::Infragistics.Windows.Internal.DataBindingUtilities.g_sampleDataProvider.Data as global::System.Collections.IEnumerable;
		}

		// Token: 0x04000869 RID: 2153
		private static global::System.Windows.Data.XmlDataProvider g_sampleDataProvider;

		// Token: 0x020001C3 RID: 451
		// (Invoke) Token: 0x060010C6 RID: 4294
		public delegate global::System.ComponentModel.PropertyDescriptor ValuePropertyDescriptorCreator(global::System.Type type, string name);
	}
}
