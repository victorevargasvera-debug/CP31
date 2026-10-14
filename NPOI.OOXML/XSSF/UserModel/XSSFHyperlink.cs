using System;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200008E RID: 142
	public class XSSFHyperlink : global::NPOI.SS.UserModel.IHyperlink
	{
		// Token: 0x0600074D RID: 1869 RVA: 0x00018CED File Offset: 0x00016EED
		public XSSFHyperlink(global::NPOI.SS.UserModel.HyperlinkType type)
		{
			this._type = type;
			this._ctHyperlink = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink();
			this._externalRel = null;
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00018D10 File Offset: 0x00016F10
		public XSSFHyperlink(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink ctHyperlink, global::NPOI.OpenXml4Net.OPC.PackageRelationship hyperlinkRel)
		{
			this._ctHyperlink = ctHyperlink;
			this._externalRel = hyperlinkRel;
			if (this._externalRel == null)
			{
				if (ctHyperlink.location != null)
				{
					this._type = global::NPOI.SS.UserModel.HyperlinkType.Document;
					this._location = ctHyperlink.location;
					return;
				}
				if (ctHyperlink.id != null)
				{
					throw new global::System.InvalidOperationException(string.Concat(new string[]
					{
						"The hyperlink for cell ",
						ctHyperlink.@ref,
						" references relation ",
						ctHyperlink.id,
						", but that didn't exist!"
					}));
				}
				this._type = global::NPOI.SS.UserModel.HyperlinkType.Document;
				return;
			}
			else
			{
				global::System.Uri targetUri = this._externalRel.TargetUri;
				this._location = targetUri.ToString();
				if (ctHyperlink.location != null)
				{
					this._location = this._location + "#" + ctHyperlink.location;
				}
				if (this._location.StartsWith("http://") || this._location.StartsWith("https://") || this._location.StartsWith("ftp://"))
				{
					this._type = global::NPOI.SS.UserModel.HyperlinkType.Url;
					return;
				}
				if (this._location.StartsWith("mailto:"))
				{
					this._type = global::NPOI.SS.UserModel.HyperlinkType.Email;
					return;
				}
				this._type = global::NPOI.SS.UserModel.HyperlinkType.File;
				return;
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00018E3C File Offset: 0x0001703C
		public XSSFHyperlink(global::NPOI.SS.UserModel.IHyperlink other)
		{
			if (other is global::NPOI.XSSF.UserModel.XSSFHyperlink)
			{
				global::NPOI.XSSF.UserModel.XSSFHyperlink xssfhyperlink = (global::NPOI.XSSF.UserModel.XSSFHyperlink)other;
				this._type = xssfhyperlink.Type;
				this._location = xssfhyperlink._location;
				this._externalRel = xssfhyperlink._externalRel;
				this._ctHyperlink = xssfhyperlink._ctHyperlink.Copy();
				return;
			}
			this._type = other.Type;
			this._location = other.Address;
			this._externalRel = null;
			this._ctHyperlink = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink();
			this.SetCellReference(new global::NPOI.SS.Util.CellReference(other.FirstRow, other.FirstColumn));
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00018ED5 File Offset: 0x000170D5
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink GetCTHyperlink()
		{
			return this._ctHyperlink;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00018EDD File Offset: 0x000170DD
		public bool NeedsRelationToo()
		{
			return this._type != global::NPOI.SS.UserModel.HyperlinkType.Document;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00018EEC File Offset: 0x000170EC
		internal void GenerateRelationIfNeeded(global::NPOI.OpenXml4Net.OPC.PackagePart sheetPart)
		{
			if (this._externalRel == null && this.NeedsRelationToo())
			{
				global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship = sheetPart.AddExternalRelationship(this._location, global::NPOI.XSSF.UserModel.XSSFRelation.SHEET_HYPERLINKS.Relation);
				this._ctHyperlink.id = packageRelationship.Id;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00018F31 File Offset: 0x00017131
		public global::NPOI.SS.UserModel.HyperlinkType Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00018F39 File Offset: 0x00017139
		[global::System.Obsolete("use property CellRef")]
		public string GetCellRef()
		{
			return this._ctHyperlink.@ref;
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00018F39 File Offset: 0x00017139
		public string CellRef
		{
			get
			{
				return this._ctHyperlink.@ref;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00018F46 File Offset: 0x00017146
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x00018F4E File Offset: 0x0001714E
		public string Address
		{
			get
			{
				return this._location;
			}
			set
			{
				this.Validate(value);
				this._location = value;
				if (this._type == global::NPOI.SS.UserModel.HyperlinkType.Document)
				{
					this.Location = value;
				}
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00018F70 File Offset: 0x00017170
		private void Validate(string address)
		{
			switch (this._type)
			{
			case global::NPOI.SS.UserModel.HyperlinkType.Url:
			case global::NPOI.SS.UserModel.HyperlinkType.Email:
			case global::NPOI.SS.UserModel.HyperlinkType.File:
			{
				global::System.Uri uri;
				if (!global::System.Uri.TryCreate(address, global::System.UriKind.RelativeOrAbsolute, out uri))
				{
					throw new global::System.ArgumentException("Address of hyperlink must be a valid URI:" + address);
				}
				break;
			}
			case global::NPOI.SS.UserModel.HyperlinkType.Document:
				break;
			default:
				throw new global::System.InvalidOperationException("Invalid Hyperlink type: " + this._type.ToString());
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00018FDB File Offset: 0x000171DB
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00018FE8 File Offset: 0x000171E8
		public string Label
		{
			get
			{
				return this._ctHyperlink.display;
			}
			set
			{
				this._ctHyperlink.display = value;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00018FF6 File Offset: 0x000171F6
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00019003 File Offset: 0x00017203
		public string Location
		{
			get
			{
				return this._ctHyperlink.location;
			}
			set
			{
				this._ctHyperlink.location = value;
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00019011 File Offset: 0x00017211
		public void SetCellReference(string ref1)
		{
			this._ctHyperlink.@ref = ref1;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0001901F File Offset: 0x0001721F
		protected void SetCellReference(global::NPOI.SS.Util.CellReference ref1)
		{
			this.SetCellReference(ref1.FormatAsString());
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00019030 File Offset: 0x00017230
		private global::NPOI.SS.Util.CellReference buildCellReference()
		{
			string text = this._ctHyperlink.@ref;
			if (text == null)
			{
				text = "A1";
			}
			return new global::NPOI.SS.Util.CellReference(text);
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00019058 File Offset: 0x00017258
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x00019065 File Offset: 0x00017265
		public int FirstColumn
		{
			get
			{
				return (int)this.buildCellReference().Col;
			}
			set
			{
				this.SetCellReference(new global::NPOI.SS.Util.CellReference(this.FirstRow, value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00019058 File Offset: 0x00017258
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x00019079 File Offset: 0x00017279
		public int LastColumn
		{
			get
			{
				return (int)this.buildCellReference().Col;
			}
			set
			{
				this.FirstColumn = value;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00019082 File Offset: 0x00017282
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x0001908F File Offset: 0x0001728F
		public int FirstRow
		{
			get
			{
				return this.buildCellReference().Row;
			}
			set
			{
				this.SetCellReference(new global::NPOI.SS.Util.CellReference(value, this.FirstColumn));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x00019082 File Offset: 0x00017282
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x000190A3 File Offset: 0x000172A3
		public int LastRow
		{
			get
			{
				return this.buildCellReference().Row;
			}
			set
			{
				this.FirstRow = value;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x000065E4 File Offset: 0x000047E4
		public string TextMark
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x000190AC File Offset: 0x000172AC
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x000190B9 File Offset: 0x000172B9
		public string Tooltip
		{
			get
			{
				return this._ctHyperlink.tooltip;
			}
			set
			{
				this._ctHyperlink.tooltip = value;
			}
		}

		// Token: 0x040002F4 RID: 756
		private global::NPOI.SS.UserModel.HyperlinkType _type;

		// Token: 0x040002F5 RID: 757
		private global::NPOI.OpenXml4Net.OPC.PackageRelationship _externalRel;

		// Token: 0x040002F6 RID: 758
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Hyperlink _ctHyperlink;

		// Token: 0x040002F7 RID: 759
		private string _location;
	}
}
