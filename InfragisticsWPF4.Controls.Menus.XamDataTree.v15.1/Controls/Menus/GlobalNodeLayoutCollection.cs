using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using Infragistics.Collections;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000020 RID: 32
	public class GlobalNodeLayoutCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Menus.NodeLayout>, global::Infragistics.IProvidePersistenceLookupKeys
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00003520 File Offset: 0x00001720
		internal GlobalNodeLayoutCollection(global::Infragistics.Controls.Menus.XamDataTree tree)
		{
			this._tree = tree;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00003530 File Offset: 0x00001730
		public global::Infragistics.Controls.Menus.NodeLayout FromType(global::System.Type type)
		{
			global::Infragistics.Controls.Menus.NodeLayout result = null;
			if (type != null)
			{
				string b = type.Name.ToLower(global::System.Globalization.CultureInfo.CurrentCulture);
				string b2 = type.FullName.ToLower(global::System.Globalization.CultureInfo.CurrentCulture);
				foreach (global::Infragistics.Controls.Menus.NodeLayout nodeLayout in this.Items)
				{
					string a = (nodeLayout.TargetTypeName != null) ? nodeLayout.TargetTypeName.ToLower(global::System.Globalization.CultureInfo.CurrentCulture) : "";
					if (a == b || a == b2)
					{
						result = nodeLayout;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000035E8 File Offset: 0x000017E8
		public global::Infragistics.Controls.Menus.NodeLayout FromKey(string key)
		{
			global::Infragistics.Controls.Menus.NodeLayout result = null;
			foreach (global::Infragistics.Controls.Menus.NodeLayout nodeLayout in this.Items)
			{
				if (nodeLayout.Key == key)
				{
					result = nodeLayout;
					break;
				}
			}
			return result;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003644 File Offset: 0x00001844
		protected internal void AddItemLocally(global::Infragistics.Controls.Menus.NodeLayout item)
		{
			if (item != null)
			{
				item.IsDefinedGlobally = false;
				this.AddItemSilently(base.Count, item);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003660 File Offset: 0x00001860
		protected virtual global::System.Collections.ObjectModel.Collection<string> GetLookupKeys()
		{
			global::System.Collections.ObjectModel.Collection<string> collection = new global::System.Collections.ObjectModel.Collection<string>();
			foreach (global::Infragistics.Controls.Menus.NodeLayout nodeLayout in this.Items)
			{
				collection.Add(nodeLayout.Key);
			}
			return collection;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000036BC File Offset: 0x000018BC
		protected virtual bool CanRehydrate(global::System.Collections.ObjectModel.Collection<string> lookupKeys)
		{
			if (lookupKeys == null || lookupKeys.Count != this.Items.Count)
			{
				return false;
			}
			for (int i = 0; i < lookupKeys.Count; i++)
			{
				if (lookupKeys[i] != this.Items[i].Key)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003714 File Offset: 0x00001914
		internal global::Infragistics.Controls.Menus.NodeLayout InternalFromType(global::System.Type type)
		{
			foreach (global::Infragistics.Controls.Menus.NodeLayout nodeLayout in this.Items)
			{
				string a = (nodeLayout.TargetTypeName != null) ? nodeLayout.TargetTypeName.ToLower(global::System.Globalization.CultureInfo.CurrentCulture) : "";
				if (nodeLayout.IsDefinedGlobally && (a == type.Name.ToLower(global::System.Globalization.CultureInfo.CurrentCulture) || a == type.FullName.ToLower(global::System.Globalization.CultureInfo.CurrentCulture)))
				{
					return nodeLayout;
				}
			}
			return null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000037BC File Offset: 0x000019BC
		internal global::Infragistics.Controls.Menus.NodeLayout InternalFromKey(string key)
		{
			global::Infragistics.Controls.Menus.NodeLayout result = null;
			foreach (global::Infragistics.Controls.Menus.NodeLayout nodeLayout in this.Items)
			{
				if (nodeLayout.IsDefinedGlobally && nodeLayout.Key == key)
				{
					result = nodeLayout;
					break;
				}
			}
			return result;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003820 File Offset: 0x00001A20
		protected override void OnItemAdded(int index, global::Infragistics.Controls.Menus.NodeLayout item)
		{
			if (item != null)
			{
				if (!string.IsNullOrEmpty(item.Key))
				{
					item.IsDefinedGlobally = true;
				}
				else
				{
					bool flag = false;
					if (item != null)
					{
						flag = global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(item);
					}
					if (!flag)
					{
						throw new global::System.Exception(global::Infragistics.SRDataTree.GetString("DuplicateKeyException"));
					}
				}
			}
			base.OnItemAdded(index, item);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003870 File Offset: 0x00001A70
		protected override void AddItemSilently(int index, global::Infragistics.Controls.Menus.NodeLayout item)
		{
			if (item != null && item.Key == "XamDataTree_Root_XamDataTree" && this._tree != null)
			{
				item.Tree = this._tree;
				if (this._tree.NodesManager != null)
				{
					this._tree.NodesManager.NodeLayout = item;
				}
			}
			base.AddItemSilently(index, item);
		}

		// Token: 0x17000032 RID: 50
		public global::Infragistics.Controls.Menus.NodeLayout this[string key]
		{
			get
			{
				foreach (global::Infragistics.Controls.Menus.NodeLayout nodeLayout in this.Items)
				{
					if (nodeLayout.Key == key)
					{
						return nodeLayout;
					}
				}
				return null;
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003928 File Offset: 0x00001B28
		global::System.Collections.ObjectModel.Collection<string> global::Infragistics.IProvidePersistenceLookupKeys.GetLookupKeys()
		{
			return this.GetLookupKeys();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003930 File Offset: 0x00001B30
		bool global::Infragistics.IProvidePersistenceLookupKeys.CanRehydrate(global::System.Collections.ObjectModel.Collection<string> lookupKeys)
		{
			return this.CanRehydrate(lookupKeys);
		}

		// Token: 0x0400003E RID: 62
		private global::Infragistics.Controls.Menus.XamDataTree _tree;
	}
}
