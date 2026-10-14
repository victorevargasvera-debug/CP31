using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace Infragistics.Windows.Internal
{
	// Token: 0x0200018D RID: 397
	internal class XmlSerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
	{
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0002A0D8 File Offset: 0x000282D8
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

		// Token: 0x06000D3C RID: 3388 RVA: 0x0002A0F4 File Offset: 0x000282F4
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertySerializationInfo> GetSerializedProperties()
		{
			return new global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertySerializationInfo>
			{
				new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(string), "Type"),
				new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(string), "Data")
			};
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x0002A13C File Offset: 0x0002833C
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

		// Token: 0x06000D3E RID: 3390 RVA: 0x0002A198 File Offset: 0x00028398
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

		// Token: 0x06000D3F RID: 3391 RVA: 0x0002A1F4 File Offset: 0x000283F4
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

		// Token: 0x06000D40 RID: 3392 RVA: 0x0002A278 File Offset: 0x00028478
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

		// Token: 0x06000D41 RID: 3393 RVA: 0x0002A2F8 File Offset: 0x000284F8
		public bool IsTypeSupported(global::System.Type type)
		{
			return null != this.GetSerializer(type);
		}

		// Token: 0x040006D1 RID: 1745
		internal const string ELEMENT_NAME = "XmlSerializerData";

		// Token: 0x040006D2 RID: 1746
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Internal.PropertySerializationInfo> _props;

		// Token: 0x040006D3 RID: 1747
		private global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Xml.Serialization.XmlSerializer> _serializerCache;
	}
}
