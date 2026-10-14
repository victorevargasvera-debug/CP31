using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace NPOI.POIFS.Properties
{
	// Token: 0x020002BA RID: 698
	public class DirectoryProperty : global::NPOI.POIFS.Properties.Property, global::NPOI.POIFS.Properties.Parent, global::NPOI.POIFS.Properties.Child, global::System.Collections.Generic.IEnumerable<global::NPOI.POIFS.Properties.Property>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600133B RID: 4923 RVA: 0x00039D78 File Offset: 0x00037F78
		public DirectoryProperty(string name)
		{
			this._children = new global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property>();
			this._children_names = new global::System.Collections.Generic.List<string>();
			base.Name = name;
			this.Size = 0;
			base.PropertyType = 1;
			base.StartBlock = 0;
			base.NodeColor = 1;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00039DC4 File Offset: 0x00037FC4
		public DirectoryProperty(int index, byte[] array, int offset) : base(index, array, offset)
		{
			this._children = new global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property>();
			this._children_names = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00039DE8 File Offset: 0x00037FE8
		public bool ChangeName(global::NPOI.POIFS.Properties.Property property, string newName)
		{
			string name = property.Name;
			property.Name = newName;
			string name2 = property.Name;
			bool result;
			if (this._children_names.Contains(name2))
			{
				property.Name = name;
				result = false;
			}
			else
			{
				this._children_names.Add(name2);
				this._children_names.Remove(name);
				result = true;
			}
			return result;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00039E3F File Offset: 0x0003803F
		public bool DeleteChild(global::NPOI.POIFS.Properties.Property property)
		{
			bool flag = this._children.Remove(property);
			if (flag)
			{
				this._children_names.Remove(property.Name);
			}
			return flag;
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600133F RID: 4927 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsDirectory
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x00039E64 File Offset: 0x00038064
		public override void PreWrite()
		{
			if (this._children.Count > 0)
			{
				global::NPOI.POIFS.Properties.Property[] array = new global::NPOI.POIFS.Properties.Property[this._children.Count];
				this._children.CopyTo(array, 0);
				global::System.Array.Sort<global::NPOI.POIFS.Properties.Property>(array, new global::NPOI.POIFS.Properties.DirectoryProperty.PropertyComparator());
				int num = array.Length / 2;
				base.ChildProperty = array[num].Index;
				array[0].PreviousChild = null;
				array[0].NextChild = null;
				for (int i = 1; i < num; i++)
				{
					array[i].PreviousChild = array[i - 1];
					array[i].NextChild = null;
				}
				if (num != 0)
				{
					array[num].PreviousChild = array[num - 1];
				}
				if (num != array.Length - 1)
				{
					array[num].NextChild = array[num + 1];
					for (int j = num + 1; j < array.Length - 1; j++)
					{
						array[j].PreviousChild = null;
						array[j].NextChild = array[j + 1];
					}
					array[array.Length - 1].PreviousChild = null;
					array[array.Length - 1].NextChild = null;
					return;
				}
				array[num].NextChild = null;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001341 RID: 4929 RVA: 0x00039F64 File Offset: 0x00038164
		public global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.Properties.Property> Children
		{
			get
			{
				return this._children.GetEnumerator();
			}
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x00039F78 File Offset: 0x00038178
		public void AddChild(global::NPOI.POIFS.Properties.Property property)
		{
			string name = property.Name;
			if (this._children_names.Contains(name))
			{
				throw new global::System.IO.IOException("Duplicate name \"" + name + "\"");
			}
			this._children_names.Add(name);
			this._children.Add(property);
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x00039F64 File Offset: 0x00038164
		public global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.Properties.Property> GetEnumerator()
		{
			return this._children.GetEnumerator();
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x00039F64 File Offset: 0x00038164
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._children.GetEnumerator();
		}

		// Token: 0x040007F2 RID: 2034
		private global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property> _children;

		// Token: 0x040007F3 RID: 2035
		private global::System.Collections.Generic.List<string> _children_names;

		// Token: 0x020005A7 RID: 1447
		public class PropertyComparator : global::System.Collections.Generic.IComparer<global::NPOI.POIFS.Properties.Property>
		{
			// Token: 0x0600347F RID: 13439 RVA: 0x000A3427 File Offset: 0x000A1627
			public override bool Equals(object o)
			{
				return this == o;
			}

			// Token: 0x06003480 RID: 13440 RVA: 0x000A342D File Offset: 0x000A162D
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06003481 RID: 13441 RVA: 0x000A3438 File Offset: 0x000A1638
			public int Compare(global::NPOI.POIFS.Properties.Property o1, global::NPOI.POIFS.Properties.Property o2)
			{
				string value = "_VBA_PROJECT";
				string name = o1.Name;
				string name2 = o2.Name;
				int num = name.Length - name2.Length;
				if (num == 0)
				{
					if (name.Equals(value, global::System.StringComparison.CurrentCulture))
					{
						num = 1;
					}
					else if (name2.Equals(value, global::System.StringComparison.CurrentCulture))
					{
						num = -1;
					}
					else if (name.StartsWith("__", global::System.StringComparison.Ordinal) && name2.StartsWith("__", global::System.StringComparison.Ordinal))
					{
						num = string.Compare(name, name2, global::System.StringComparison.OrdinalIgnoreCase);
					}
					else if (name.StartsWith("__", global::System.StringComparison.Ordinal))
					{
						num = 1;
					}
					else if (name2.StartsWith("__", global::System.StringComparison.Ordinal))
					{
						num = -1;
					}
					else
					{
						num = string.Compare(name, name2, global::System.StringComparison.OrdinalIgnoreCase);
					}
				}
				return num;
			}
		}
	}
}
