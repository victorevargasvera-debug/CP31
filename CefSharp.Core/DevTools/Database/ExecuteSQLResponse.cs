using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Database
{
	// Token: 0x02000294 RID: 660
	[global::System.Runtime.Serialization.DataContract]
	public class ExecuteSQLResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x00016588 File Offset: 0x00014788
		// (set) Token: 0x060013F4 RID: 5108 RVA: 0x00016590 File Offset: 0x00014790
		[global::System.Runtime.Serialization.DataMember]
		internal string[] columnNames { get; set; }

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00016599 File Offset: 0x00014799
		public string[] ColumnNames
		{
			get
			{
				return this.columnNames;
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x000165A1 File Offset: 0x000147A1
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x000165A9 File Offset: 0x000147A9
		[global::System.Runtime.Serialization.DataMember]
		internal object[] values { get; set; }

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x000165B2 File Offset: 0x000147B2
		public object[] Values
		{
			get
			{
				return this.values;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x000165BA File Offset: 0x000147BA
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x000165C2 File Offset: 0x000147C2
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Database.Error sqlError { get; set; }

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x000165CB File Offset: 0x000147CB
		public global::CefSharp.DevTools.Database.Error SqlError
		{
			get
			{
				return this.sqlError;
			}
		}
	}
}
