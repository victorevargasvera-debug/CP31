using System;

namespace NPOI
{
	// Token: 0x02000004 RID: 4
	public class POIXMLException : global::System.Exception
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002DE6 File Offset: 0x00000FE6
		public POIXMLException()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002DEE File Offset: 0x00000FEE
		public POIXMLException(string msg) : base(msg)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002DF7 File Offset: 0x00000FF7
		public POIXMLException(string msg, global::System.Exception ex) : base(msg, ex)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002E01 File Offset: 0x00001001
		public POIXMLException(global::System.Exception ex) : base(string.Empty, ex)
		{
		}
	}
}
