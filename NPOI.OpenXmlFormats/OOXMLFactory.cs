using System;
using System.IO;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats
{
	// Token: 0x0200000A RID: 10
	public class OOXMLFactory<T>
	{
		// Token: 0x0600005C RID: 92 RVA: 0x000025F2 File Offset: 0x000007F2
		public OOXMLFactory()
		{
			this.serializerObj = new global::System.Xml.Serialization.XmlSerializer(typeof(T));
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000260F File Offset: 0x0000080F
		public T Parse(global::System.IO.Stream stream)
		{
			T result = (T)((object)this.serializerObj.Deserialize(stream));
			stream.Close();
			return result;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002628 File Offset: 0x00000828
		public T Create()
		{
			return (T)((object)global::System.Activator.CreateInstance(typeof(T)));
		}

		// Token: 0x04000047 RID: 71
		private global::System.Xml.Serialization.XmlSerializer serializerObj;
	}
}
