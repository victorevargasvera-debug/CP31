using System;
using System.IO;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml.WordProcessing
{
	// Token: 0x02000358 RID: 856
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing", IsNullable = true)]
	[global::System.Serializable]
	public class CT_WrapNone
	{
		// Token: 0x060021D3 RID: 8659 RVA: 0x00058CDE File Offset: 0x00056EDE
		internal void Write(global::System.IO.StreamWriter sw, string nodeName)
		{
			sw.Write(string.Format("<wp:{0}", nodeName));
			sw.Write("/>");
		}
	}
}
