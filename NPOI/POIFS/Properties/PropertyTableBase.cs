using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.FileSystem;
using NPOI.POIFS.Storage;

namespace NPOI.POIFS.Properties
{
	// Token: 0x020002B8 RID: 696
	public abstract class PropertyTableBase : global::NPOI.POIFS.FileSystem.BATManaged
	{
		// Token: 0x0600132E RID: 4910 RVA: 0x00039C18 File Offset: 0x00037E18
		public PropertyTableBase(global::NPOI.POIFS.Storage.HeaderBlock header_block)
		{
			this._header_block = header_block;
			this._properties = new global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property>();
			this.AddProperty(new global::NPOI.POIFS.Properties.RootProperty());
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00039C3D File Offset: 0x00037E3D
		public PropertyTableBase(global::NPOI.POIFS.Storage.HeaderBlock header_block, global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property> properties)
		{
			this._header_block = header_block;
			this._properties = properties;
			this.PopulatePropertyTree((global::NPOI.POIFS.Properties.DirectoryProperty)this._properties[0]);
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00039C6A File Offset: 0x00037E6A
		public void AddProperty(global::NPOI.POIFS.Properties.Property property)
		{
			this._properties.Add(property);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00039C78 File Offset: 0x00037E78
		public void RemoveProperty(global::NPOI.POIFS.Properties.Property property)
		{
			this._properties.Remove(property);
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x00039C87 File Offset: 0x00037E87
		public global::NPOI.POIFS.Properties.RootProperty Root
		{
			get
			{
				return (global::NPOI.POIFS.Properties.RootProperty)this._properties[0];
			}
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x00039C9C File Offset: 0x00037E9C
		protected void PopulatePropertyTree(global::NPOI.POIFS.Properties.DirectoryProperty root)
		{
			try
			{
				int index = root.ChildIndex;
				if (global::NPOI.POIFS.Properties.Property.IsValidIndex(index))
				{
					global::System.Collections.Generic.Stack<global::NPOI.POIFS.Properties.Property> stack = new global::System.Collections.Generic.Stack<global::NPOI.POIFS.Properties.Property>();
					stack.Push(this._properties[index]);
					while (stack.Count != 0)
					{
						global::NPOI.POIFS.Properties.Property property = stack.Pop();
						if (property != null)
						{
							root.AddChild(property);
							if (property.IsDirectory)
							{
								this.PopulatePropertyTree((global::NPOI.POIFS.Properties.DirectoryProperty)property);
							}
							index = property.PreviousChildIndex;
							if (global::NPOI.POIFS.Properties.Property.IsValidIndex(index))
							{
								stack.Push(this._properties[index]);
							}
							index = property.NextChildIndex;
							if (global::NPOI.POIFS.Properties.Property.IsValidIndex(index))
							{
								stack.Push(this._properties[index]);
							}
						}
					}
				}
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x00039D5C File Offset: 0x00037F5C
		// (set) Token: 0x06001335 RID: 4917 RVA: 0x00039D69 File Offset: 0x00037F69
		public virtual int StartBlock
		{
			get
			{
				return this._header_block.PropertyStart;
			}
			set
			{
				this._header_block.PropertyStart = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x00008C75 File Offset: 0x00006E75
		public virtual int CountBlocks
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x040007F0 RID: 2032
		protected global::NPOI.POIFS.Storage.HeaderBlock _header_block;

		// Token: 0x040007F1 RID: 2033
		protected global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property> _properties;
	}
}
