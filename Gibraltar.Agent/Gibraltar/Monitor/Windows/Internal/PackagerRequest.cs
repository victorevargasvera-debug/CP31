using System;
using Gibraltar.Data;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001F0 RID: 496
	internal class PackagerRequest
	{
		// Token: 0x0600185B RID: 6235 RVA: 0x00054100 File Offset: 0x00052300
		public PackagerRequest() : this(global::Gibraltar.Monitor.Log.SessionSummary.Product, global::Gibraltar.Monitor.Log.SessionSummary.Application)
		{
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x0005411C File Offset: 0x0005231C
		public PackagerRequest(string productName, string applicationName)
		{
			if (string.IsNullOrEmpty(productName))
			{
				throw new global::System.ArgumentNullException("A product name must be specified");
			}
			this.ProductName = productName;
			this.ApplicationName = applicationName;
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x00054148 File Offset: 0x00052348
		// (set) Token: 0x0600185E RID: 6238 RVA: 0x00054150 File Offset: 0x00052350
		public bool AllowEmail { get; set; }

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x0005415C File Offset: 0x0005235C
		// (set) Token: 0x06001860 RID: 6240 RVA: 0x00054164 File Offset: 0x00052364
		public bool AllowServer { get; set; }

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x00054170 File Offset: 0x00052370
		// (set) Token: 0x06001862 RID: 6242 RVA: 0x00054178 File Offset: 0x00052378
		public bool AllowFile { get; set; }

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x00054184 File Offset: 0x00052384
		// (set) Token: 0x06001864 RID: 6244 RVA: 0x0005418C File Offset: 0x0005238C
		public bool AllowRemovableMedia { get; set; }

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x00054198 File Offset: 0x00052398
		// (set) Token: 0x06001866 RID: 6246 RVA: 0x000541A0 File Offset: 0x000523A0
		public global::Gibraltar.Monitor.Windows.Internal.PackageTransport Transport { get; set; }

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x000541AC File Offset: 0x000523AC
		// (set) Token: 0x06001868 RID: 6248 RVA: 0x000541B4 File Offset: 0x000523B4
		public string DestinationEmailAddress { get; set; }

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x000541C0 File Offset: 0x000523C0
		// (set) Token: 0x0600186A RID: 6250 RVA: 0x000541C8 File Offset: 0x000523C8
		public string FromEmailAddress { get; set; }

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x000541D4 File Offset: 0x000523D4
		// (set) Token: 0x0600186C RID: 6252 RVA: 0x000541DC File Offset: 0x000523DC
		public string FileNamePath { get; set; }

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x000541E8 File Offset: 0x000523E8
		// (set) Token: 0x0600186E RID: 6254 RVA: 0x000541F0 File Offset: 0x000523F0
		public global::Gibraltar.Data.SessionCriteria Criteria { get; set; }

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x000541FC File Offset: 0x000523FC
		// (set) Token: 0x06001870 RID: 6256 RVA: 0x00054204 File Offset: 0x00052404
		public string ProductName { get; private set; }

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x00054210 File Offset: 0x00052410
		// (set) Token: 0x06001872 RID: 6258 RVA: 0x00054218 File Offset: 0x00052418
		public string ApplicationName { get; private set; }

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x00054224 File Offset: 0x00052424
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x0005422C File Offset: 0x0005242C
		public string EmailServer { get; set; }

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x00054238 File Offset: 0x00052438
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x00054240 File Offset: 0x00052440
		public int ServerPort { get; set; }

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x0005424C File Offset: 0x0005244C
		// (set) Token: 0x06001878 RID: 6264 RVA: 0x00054254 File Offset: 0x00052454
		public bool UseSsl { get; set; }

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x00054260 File Offset: 0x00052460
		// (set) Token: 0x0600187A RID: 6266 RVA: 0x00054268 File Offset: 0x00052468
		public string EmailServerUser { get; set; }

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x00054274 File Offset: 0x00052474
		// (set) Token: 0x0600187C RID: 6268 RVA: 0x0005427C File Offset: 0x0005247C
		public string EmailServerPassword { get; set; }

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x00054288 File Offset: 0x00052488
		public bool CoversCurrentApplication
		{
			get
			{
				bool result = true;
				if (!this.ProductName.Equals(global::Gibraltar.Monitor.Log.SessionSummary.Product, global::System.StringComparison.OrdinalIgnoreCase))
				{
					result = false;
				}
				else if (!string.IsNullOrEmpty(this.ApplicationName) && !this.ApplicationName.Equals(global::Gibraltar.Monitor.Log.SessionSummary.Application, global::System.StringComparison.OrdinalIgnoreCase))
				{
					result = false;
				}
				return result;
			}
		}
	}
}
