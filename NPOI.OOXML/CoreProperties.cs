using System;
using NPOI.OpenXml4Net.OPC.Internal;

namespace NPOI
{
	// Token: 0x02000006 RID: 6
	public class CoreProperties
	{
		// Token: 0x06000045 RID: 69 RVA: 0x0000300A File Offset: 0x0000120A
		internal CoreProperties(global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart part)
		{
			this.part = part;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003019 File Offset: 0x00001219
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00003026 File Offset: 0x00001226
		public string Category
		{
			get
			{
				return this.part.GetCategoryProperty();
			}
			set
			{
				this.part.SetCategoryProperty(value);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003034 File Offset: 0x00001234
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00003041 File Offset: 0x00001241
		public string ContentStatus
		{
			get
			{
				return this.part.GetContentStatusProperty();
			}
			set
			{
				this.part.SetContentStatusProperty(value);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000304F File Offset: 0x0000124F
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0000305C File Offset: 0x0000125C
		public string ContentType
		{
			get
			{
				return this.part.GetContentTypeProperty();
			}
			set
			{
				this.part.SetContentTypeProperty(value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000306A File Offset: 0x0000126A
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00003077 File Offset: 0x00001277
		public global::System.DateTime? Created
		{
			get
			{
				return this.part.GetCreatedProperty();
			}
			set
			{
				this.part.SetCreatedProperty(value);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003085 File Offset: 0x00001285
		public void SetCreated(string date)
		{
			this.part.SetCreatedProperty(date);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003093 File Offset: 0x00001293
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000030A0 File Offset: 0x000012A0
		public string Creator
		{
			get
			{
				return this.part.GetCreatorProperty();
			}
			set
			{
				this.part.SetCreatorProperty(value);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000030AE File Offset: 0x000012AE
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000030BB File Offset: 0x000012BB
		public string Description
		{
			get
			{
				return this.part.GetDescriptionProperty();
			}
			set
			{
				this.part.SetDescriptionProperty(value);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000030C9 File Offset: 0x000012C9
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000030D6 File Offset: 0x000012D6
		public string Identifier
		{
			get
			{
				return this.part.GetIdentifierProperty();
			}
			set
			{
				this.part.SetIdentifierProperty(value);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000030E4 File Offset: 0x000012E4
		// (set) Token: 0x06000056 RID: 86 RVA: 0x000030F1 File Offset: 0x000012F1
		public string Keywords
		{
			get
			{
				return this.part.GetKeywordsProperty();
			}
			set
			{
				this.part.SetKeywordsProperty(value);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000030FF File Offset: 0x000012FF
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000310C File Offset: 0x0000130C
		public global::System.DateTime? LastPrinted
		{
			get
			{
				return this.part.GetLastPrintedProperty();
			}
			set
			{
				this.part.SetLastPrintedProperty(value);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000311A File Offset: 0x0000131A
		public void SetLastPrinted(string date)
		{
			this.part.SetLastPrintedProperty(date);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003128 File Offset: 0x00001328
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00003135 File Offset: 0x00001335
		public string LastModifiedByUser
		{
			get
			{
				return this.part.GetLastModifiedByProperty();
			}
			set
			{
				this.part.SetLastModifiedByProperty(value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003143 File Offset: 0x00001343
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00003150 File Offset: 0x00001350
		public global::System.DateTime? Modified
		{
			get
			{
				return this.part.GetModifiedProperty();
			}
			set
			{
				this.part.SetModifiedProperty(value);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000315E File Offset: 0x0000135E
		public void SetModified(string date)
		{
			this.part.SetModifiedProperty(date);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000316C File Offset: 0x0000136C
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00003179 File Offset: 0x00001379
		public string Subject
		{
			get
			{
				return this.part.GetSubjectProperty();
			}
			set
			{
				this.part.SetSubjectProperty(value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00003187 File Offset: 0x00001387
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00003194 File Offset: 0x00001394
		public string Title
		{
			get
			{
				return this.part.GetTitleProperty();
			}
			set
			{
				this.part.SetTitleProperty(value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000031A2 File Offset: 0x000013A2
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000031B0 File Offset: 0x000013B0
		public string Revision
		{
			get
			{
				return this.part.GetRevisionProperty();
			}
			set
			{
				try
				{
					long.Parse(value);
					this.part.SetRevisionProperty(value);
				}
				catch (global::System.FormatException)
				{
				}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000031E8 File Offset: 0x000013E8
		public global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart GetUnderlyingProperties()
		{
			return this.part;
		}

		// Token: 0x04000011 RID: 17
		private global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart part;
	}
}
