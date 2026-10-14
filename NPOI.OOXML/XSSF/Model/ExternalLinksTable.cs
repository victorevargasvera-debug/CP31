using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.OpenXmlFormats.Spreadsheet.Document;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Model
{
	// Token: 0x020000E2 RID: 226
	public class ExternalLinksTable : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x06000E14 RID: 3604 RVA: 0x0003088B File Offset: 0x0002EA8B
		public ExternalLinksTable()
		{
			this.link = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalLink();
			this.link.AddNewExternalBook();
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x000308A9 File Offset: 0x0002EAA9
		internal ExternalLinksTable(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
			this.ReadFrom(part.GetInputStream());
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x000308BE File Offset: 0x0002EABE
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public ExternalLinksTable(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000308C8 File Offset: 0x0002EAC8
		public void ReadFrom(global::System.IO.Stream is1)
		{
			try
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.Document.ExternalLinkDocument externalLinkDocument = global::NPOI.OpenXmlFormats.Spreadsheet.Document.ExternalLinkDocument.Parse(global::NPOI.POIXMLDocumentPart.ConvertStreamToXml(is1), global::NPOI.POIXMLDocumentPart.NamespaceManager);
				this.link = externalLinkDocument.ExternalLink;
			}
			catch (global::System.Xml.XmlException ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00030910 File Offset: 0x0002EB10
		public void WriteTo(global::System.IO.Stream out1)
		{
			new global::NPOI.OpenXmlFormats.Spreadsheet.Document.ExternalLinkDocument
			{
				ExternalLink = this.link
			}.Save(out1);
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x0003092C File Offset: 0x0002EB2C
		protected internal override void Commit()
		{
			global::System.IO.Stream outputStream = base.GetPackagePart().GetOutputStream();
			this.WriteTo(outputStream);
			outputStream.Close();
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00030952 File Offset: 0x0002EB52
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalLink CTExternalLink
		{
			get
			{
				return this.link;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0003095C File Offset: 0x0002EB5C
		// (set) Token: 0x06000E1C RID: 3612 RVA: 0x000309B4 File Offset: 0x0002EBB4
		public virtual string LinkedFileName
		{
			get
			{
				string id = this.link.externalBook.id;
				global::NPOI.OpenXml4Net.OPC.PackageRelationship relationship = base.GetPackagePart().GetRelationship(id);
				if (relationship != null)
				{
					global::NPOI.OpenXml4Net.OPC.TargetMode? targetMode = relationship.TargetMode;
					global::NPOI.OpenXml4Net.OPC.TargetMode targetMode2 = global::NPOI.OpenXml4Net.OPC.TargetMode.External;
					if (targetMode.GetValueOrDefault() == targetMode2 & targetMode != null)
					{
						return relationship.TargetUri.ToString();
					}
				}
				return null;
			}
			set
			{
				string id = this.link.externalBook.id;
				if (!string.IsNullOrEmpty(id))
				{
					base.GetPackagePart().RemoveRelationship(id);
				}
				global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship = base.GetPackagePart().AddExternalRelationship(value, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/externalLinkPath");
				this.link.externalBook.id = packageRelationship.Id;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000E1D RID: 3613 RVA: 0x00030A10 File Offset: 0x0002EC10
		public global::System.Collections.Generic.List<string> SheetNames
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetName[] sheetName = this.link.externalBook.sheetNames.sheetName;
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>(sheetName.Length);
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalSheetName ct_ExternalSheetName in sheetName)
				{
					list.Add(ct_ExternalSheetName.val);
				}
				return list;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00030A5C File Offset: 0x0002EC5C
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IName> DefinedNames
		{
			get
			{
				global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedName[] definedName = this.link.externalBook.definedNames.definedName;
				global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IName> list = new global::System.Collections.Generic.List<global::NPOI.SS.UserModel.IName>(definedName.Length);
				foreach (global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedName name in definedName)
				{
					list.Add(new global::NPOI.XSSF.Model.ExternalLinksTable.ExternalName(name, this));
				}
				return list;
			}
		}

		// Token: 0x0400041B RID: 1051
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalLink link;

		// Token: 0x0200014C RID: 332
		protected internal class ExternalName : global::NPOI.SS.UserModel.IName
		{
			// Token: 0x06001069 RID: 4201 RVA: 0x0003938D File Offset: 0x0003758D
			protected internal ExternalName(global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedName name, global::NPOI.XSSF.Model.ExternalLinksTable externalLinkTable)
			{
				this.name = name;
				this.externalLinkTable = externalLinkTable;
			}

			// Token: 0x170003CA RID: 970
			// (get) Token: 0x0600106A RID: 4202 RVA: 0x000393A3 File Offset: 0x000375A3
			// (set) Token: 0x0600106B RID: 4203 RVA: 0x000393B0 File Offset: 0x000375B0
			public string NameName
			{
				get
				{
					return this.name.name;
				}
				set
				{
					this.name.name = value;
				}
			}

			// Token: 0x170003CB RID: 971
			// (get) Token: 0x0600106C RID: 4204 RVA: 0x000393C0 File Offset: 0x000375C0
			public string SheetName
			{
				get
				{
					int sheetIndex = this.SheetIndex;
					if (sheetIndex >= 0)
					{
						return this.externalLinkTable.SheetNames[sheetIndex];
					}
					return null;
				}
			}

			// Token: 0x170003CC RID: 972
			// (get) Token: 0x0600106D RID: 4205 RVA: 0x000393EB File Offset: 0x000375EB
			// (set) Token: 0x0600106E RID: 4206 RVA: 0x00039407 File Offset: 0x00037607
			public int SheetIndex
			{
				get
				{
					if (this.name.IsSetSheetId())
					{
						return (int)this.name.sheetId;
					}
					return -1;
				}
				set
				{
					this.name.sheetId = (uint)value;
				}
			}

			// Token: 0x170003CD RID: 973
			// (get) Token: 0x0600106F RID: 4207 RVA: 0x00039415 File Offset: 0x00037615
			// (set) Token: 0x06001070 RID: 4208 RVA: 0x00039428 File Offset: 0x00037628
			public string RefersToFormula
			{
				get
				{
					return this.name.refersTo.Substring(1);
				}
				set
				{
					this.name.refersTo = "=" + value;
				}
			}

			// Token: 0x170003CE RID: 974
			// (get) Token: 0x06001071 RID: 4209 RVA: 0x00005008 File Offset: 0x00003208
			public bool IsFunctionName
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170003CF RID: 975
			// (get) Token: 0x06001072 RID: 4210 RVA: 0x00005008 File Offset: 0x00003208
			public bool IsDeleted
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170003D0 RID: 976
			// (get) Token: 0x06001073 RID: 4211 RVA: 0x00004FF8 File Offset: 0x000031F8
			// (set) Token: 0x06001074 RID: 4212 RVA: 0x00039440 File Offset: 0x00037640
			public string Comment
			{
				get
				{
					return null;
				}
				set
				{
					throw new global::System.InvalidOperationException("Not Supported");
				}
			}

			// Token: 0x06001075 RID: 4213 RVA: 0x00039440 File Offset: 0x00037640
			public void SetFunction(bool value)
			{
				throw new global::System.InvalidOperationException("Not Supported");
			}

			// Token: 0x04000534 RID: 1332
			private global::NPOI.XSSF.Model.ExternalLinksTable externalLinkTable;

			// Token: 0x04000535 RID: 1333
			private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExternalDefinedName name;
		}
	}
}
