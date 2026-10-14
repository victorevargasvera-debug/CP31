using System;
using System.Text.RegularExpressions;

namespace NPOI
{
	// Token: 0x0200000B RID: 11
	public abstract class POIXMLRelation
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00004021 File Offset: 0x00002221
		public POIXMLRelation(string type, string rel, string defaultName, global::System.Type cls)
		{
			this._type = type;
			this._relation = rel;
			this._defaultName = defaultName;
			this._cls = cls;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004046 File Offset: 0x00002246
		public POIXMLRelation(string type, string rel, string defaultName) : this(type, rel, defaultName, null)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004052 File Offset: 0x00002252
		public string ContentType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000405A File Offset: 0x0000225A
		public string Relation
		{
			get
			{
				return this._relation;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00004062 File Offset: 0x00002262
		public string DefaultFileName
		{
			get
			{
				return this._defaultName;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000406A File Offset: 0x0000226A
		public string GetFileName(int index)
		{
			if (this._defaultName.IndexOf("#") == -1)
			{
				return this.DefaultFileName;
			}
			return this._defaultName.Replace("#", index.ToString());
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000409D File Offset: 0x0000229D
		public int GetFileNameIndex(global::NPOI.POIXMLDocumentPart part)
		{
			return int.Parse(new global::System.Text.RegularExpressions.Regex(this._defaultName.Replace("#", "(\\d+)")).Match(part.GetPackagePart().PartName.Name).Value);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000040D8 File Offset: 0x000022D8
		public global::System.Type RelationClass
		{
			get
			{
				return this._cls;
			}
		}

		// Token: 0x0400001D RID: 29
		protected string _type;

		// Token: 0x0400001E RID: 30
		protected string _relation;

		// Token: 0x0400001F RID: 31
		protected string _defaultName;

		// Token: 0x04000020 RID: 32
		private global::System.Type _cls;
	}
}
