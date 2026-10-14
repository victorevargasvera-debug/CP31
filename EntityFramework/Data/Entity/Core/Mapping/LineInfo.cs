using System;
using System.Xml;
using System.Xml.XPath;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000545 RID: 1349
	internal sealed class LineInfo : global::System.Xml.IXmlLineInfo
	{
		// Token: 0x06004224 RID: 16932 RVA: 0x000DFB7B File Offset: 0x000DDD7B
		internal LineInfo(global::System.Xml.XPath.XPathNavigator nav) : this((global::System.Xml.IXmlLineInfo)nav)
		{
		}

		// Token: 0x06004225 RID: 16933 RVA: 0x000DFB89 File Offset: 0x000DDD89
		internal LineInfo(global::System.Xml.IXmlLineInfo lineInfo)
		{
			this.m_hasLineInfo = lineInfo.HasLineInfo();
			this.m_lineNumber = lineInfo.LineNumber;
			this.m_linePosition = lineInfo.LinePosition;
		}

		// Token: 0x06004226 RID: 16934 RVA: 0x000DFBB5 File Offset: 0x000DDDB5
		private LineInfo()
		{
			this.m_hasLineInfo = false;
			this.m_lineNumber = 0;
			this.m_linePosition = 0;
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06004227 RID: 16935 RVA: 0x000DFBD2 File Offset: 0x000DDDD2
		public int LineNumber
		{
			get
			{
				return this.m_lineNumber;
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06004228 RID: 16936 RVA: 0x000DFBDA File Offset: 0x000DDDDA
		public int LinePosition
		{
			get
			{
				return this.m_linePosition;
			}
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x000DFBE2 File Offset: 0x000DDDE2
		public bool HasLineInfo()
		{
			return this.m_hasLineInfo;
		}

		// Token: 0x040016F7 RID: 5879
		private readonly bool m_hasLineInfo;

		// Token: 0x040016F8 RID: 5880
		private readonly int m_lineNumber;

		// Token: 0x040016F9 RID: 5881
		private readonly int m_linePosition;

		// Token: 0x040016FA RID: 5882
		internal static readonly global::System.Data.Entity.Core.Mapping.LineInfo Empty = new global::System.Data.Entity.Core.Mapping.LineInfo();
	}
}
