using System;
using NPOI.POIFS.Properties;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002EA RID: 746
	[global::System.Serializable]
	public abstract class EntryNode : global::NPOI.POIFS.FileSystem.Entry
	{
		// Token: 0x06001551 RID: 5457 RVA: 0x0003FF22 File Offset: 0x0003E122
		protected EntryNode() : this(null, null)
		{
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x0003FF2C File Offset: 0x0003E12C
		protected EntryNode(global::NPOI.POIFS.Properties.Property property, global::NPOI.POIFS.FileSystem.DirectoryNode parent)
		{
			this._property = property;
			this._parent = parent;
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x0003FF42 File Offset: 0x0003E142
		public global::NPOI.POIFS.Properties.Property Property
		{
			get
			{
				return this._property;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x0003FF4A File Offset: 0x0003E14A
		protected bool IsRoot
		{
			get
			{
				return this._parent == null;
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001555 RID: 5461
		protected abstract bool IsDeleteOK { get; }

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x0003FF55 File Offset: 0x0003E155
		public string Name
		{
			get
			{
				return this._property.Name;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x00006EB4 File Offset: 0x000050B4
		public virtual bool IsDirectoryEntry
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x00006EB4 File Offset: 0x000050B4
		public virtual bool IsDocumentEntry
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x0003FF62 File Offset: 0x0003E162
		public global::NPOI.POIFS.FileSystem.DirectoryEntry Parent
		{
			get
			{
				return this._parent;
			}
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x0003FF6C File Offset: 0x0003E16C
		public bool Delete()
		{
			bool result = false;
			if (!this.IsRoot && this.IsDeleteOK)
			{
				result = this._parent.DeleteEntry(this);
			}
			return result;
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x0003FF9C File Offset: 0x0003E19C
		public bool RenameTo(string newName)
		{
			bool result = false;
			if (!this.IsRoot)
			{
				result = this._parent.ChangeName(this.Name, newName);
			}
			return result;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x0003FD6C File Offset: 0x0003DF6C
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0400089A RID: 2202
		protected global::NPOI.POIFS.Properties.Property _property;

		// Token: 0x0400089B RID: 2203
		protected global::NPOI.POIFS.FileSystem.DirectoryNode _parent;
	}
}
