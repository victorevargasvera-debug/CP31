using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001B2 RID: 434
	internal class XmlSerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
	{
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x0002E838 File Offset: 0x0002CA38
		public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
		{
			get
			{
				if (this._props == null)
				{
					this._props = this.GetSerializedProperties();
				}
				return this._props;
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0002E854 File Offset: 0x0002CA54
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertySerializationInfo> GetSerializedProperties()
		{
			return new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertySerializationInfo>
			{
				new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(string), "Type"),
				new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(string), "Data")
			};
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x0002E89C File Offset: 0x0002CA9C
		private global::System.Xml.Serialization.XmlSerializer GetSerializer(global::System.Type type)
		{
			if (this._serializerCache == null)
			{
				this._serializerCache = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Xml.Serialization.XmlSerializer>();
			}
			global::System.Xml.Serialization.XmlSerializer xmlSerializer;
			if (!this._serializerCache.TryGetValue(type, out xmlSerializer))
			{
				try
				{
					xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(type);
				}
				catch
				{
					xmlSerializer = null;
				}
				this._serializerCache[type] = xmlSerializer;
			}
			return xmlSerializer;
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x0002E8F8 File Offset: 0x0002CAF8
		private static global::System.Type GetTypeHelper(string name)
		{
			try
			{
				foreach (global::System.Reflection.Assembly assembly in global::System.AppDomain.CurrentDomain.GetAssemblies())
				{
					global::System.Type type = assembly.GetType(name);
					if (null != type)
					{
						return type;
					}
				}
			}
			catch
			{
			}
			return null;
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x0002E954 File Offset: 0x0002CB54
		public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			global::System.Type type = obj.GetType();
			global::System.Xml.Serialization.XmlSerializer serializer = this.GetSerializer(type);
			if (null == type)
			{
				return null;
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			serializer.Serialize(memoryStream, obj);
			memoryStream.Position = 0L;
			byte[] buffer = memoryStream.GetBuffer();
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary["Type"] = type.FullName;
			dictionary["Data"] = global::System.Convert.ToBase64String(buffer);
			memoryStream.Close();
			memoryStream.Dispose();
			return dictionary;
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x0002E9D8 File Offset: 0x0002CBD8
		public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
		{
			global::System.Type type = null;
			object obj;
			if (values.TryGetValue("Type", out obj))
			{
				type = global::Infragistics.Windows.Internal.XmlSerializationInfo.GetTypeHelper((string)obj);
			}
			global::System.Xml.Serialization.XmlSerializer xmlSerializer = (null != type) ? this.GetSerializer(type) : null;
			if (xmlSerializer != null && values.TryGetValue("Data", out obj))
			{
				byte[] buffer = global::System.Convert.FromBase64String((string)obj);
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(buffer);
				object result = xmlSerializer.Deserialize(memoryStream);
				memoryStream.Close();
				memoryStream.Dispose();
				return result;
			}
			return null;
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0002EA58 File Offset: 0x0002CC58
		public bool IsTypeSupported(global::System.Type type)
		{
			return null != this.GetSerializer(type);
		}

		// Token: 0x040007F8 RID: 2040
		internal const string ELEMENT_NAME = "XmlSerializerData";

		// Token: 0x040007F9 RID: 2041
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertySerializationInfo> _props;

		// Token: 0x040007FA RID: 2042
		private global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Xml.Serialization.XmlSerializer> _serializerCache;
	}
}
