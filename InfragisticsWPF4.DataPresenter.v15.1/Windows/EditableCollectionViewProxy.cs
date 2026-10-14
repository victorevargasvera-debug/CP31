using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Data;

namespace Infragistics.Windows
{
	// Token: 0x02000006 RID: 6
	internal class EditableCollectionViewProxy
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002940 File Offset: 0x00000B40
		static EditableCollectionViewProxy()
		{
			if (global::Infragistics.Windows.EditableCollectionViewProxy.s_IEditableCollectionViewType != null)
			{
				global::System.Reflection.MethodInfo[] methods = global::Infragistics.Windows.EditableCollectionViewProxy.s_IEditableCollectionViewType.GetMethods(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
				foreach (global::System.Reflection.MethodInfo methodInfo in methods)
				{
					string name;
					switch (name = methodInfo.Name)
					{
					case "AddNew":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_AddNew = methodInfo;
						break;
					case "CancelEdit":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_CancelEdit = methodInfo;
						break;
					case "CancelNew":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_CancelNew = methodInfo;
						break;
					case "CommitNew":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_CommitNew = methodInfo;
						break;
					case "CommitEdit":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_CommitEdit = methodInfo;
						break;
					case "EditItem":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_EditItem = methodInfo;
						break;
					case "Remove":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_Remove = methodInfo;
						break;
					case "RemoveAt":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_RemoveAt = methodInfo;
						break;
					}
				}
				global::System.Reflection.PropertyInfo[] properties = global::Infragistics.Windows.EditableCollectionViewProxy.s_IEditableCollectionViewType.GetProperties();
				foreach (global::System.Reflection.PropertyInfo propertyInfo in properties)
				{
					string name2;
					switch (name2 = propertyInfo.Name)
					{
					case "CanAddNew":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_CanAddNew = propertyInfo;
						break;
					case "CanCancelEdit":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_CanCancelEdit = propertyInfo;
						break;
					case "CanRemove":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_CanRemove = propertyInfo;
						break;
					case "CurrentAddItem":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_CurrentAddItem = propertyInfo;
						break;
					case "CurrentEditItem":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_CurrentEditItem = propertyInfo;
						break;
					case "IsAddingNew":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_IsAddingNew = propertyInfo;
						break;
					case "IsEditingItem":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_IsEditingItem = propertyInfo;
						break;
					case "NewItemPlaceholderPosition":
						global::Infragistics.Windows.EditableCollectionViewProxy.s_NewItemPlaceholderPosition = propertyInfo;
						break;
					}
				}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002BDB File Offset: 0x00000DDB
		internal EditableCollectionViewProxy(global::System.Windows.Data.CollectionView collectionView)
		{
			this._collectionView = collectionView;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002BEA File Offset: 0x00000DEA
		internal static global::System.Type IEditableCollectionViewType
		{
			get
			{
				return global::Infragistics.Windows.EditableCollectionViewProxy.s_IEditableCollectionViewType;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002BF1 File Offset: 0x00000DF1
		internal global::System.Windows.Data.CollectionView View
		{
			get
			{
				return this._collectionView;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002BF9 File Offset: 0x00000DF9
		public object AddNew()
		{
			return global::Infragistics.Windows.EditableCollectionViewProxy.s_AddNew.Invoke(this._collectionView, null);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002C0C File Offset: 0x00000E0C
		public bool CanAddNew
		{
			get
			{
				return (bool)global::Infragistics.Windows.EditableCollectionViewProxy.s_CanAddNew.GetValue(this._collectionView, null);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002C24 File Offset: 0x00000E24
		public bool CanCancelEdit
		{
			get
			{
				return (bool)global::Infragistics.Windows.EditableCollectionViewProxy.s_CanCancelEdit.GetValue(this._collectionView, null);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002C3C File Offset: 0x00000E3C
		public bool CanRemove
		{
			get
			{
				return (bool)global::Infragistics.Windows.EditableCollectionViewProxy.s_CanRemove.GetValue(this._collectionView, null);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002C54 File Offset: 0x00000E54
		public void CancelEdit()
		{
			global::Infragistics.Windows.EditableCollectionViewProxy.s_CancelEdit.Invoke(this._collectionView, null);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002C68 File Offset: 0x00000E68
		public void CancelNew()
		{
			global::Infragistics.Windows.EditableCollectionViewProxy.s_CancelNew.Invoke(this._collectionView, null);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002C7C File Offset: 0x00000E7C
		public void CommitEdit()
		{
			global::Infragistics.Windows.EditableCollectionViewProxy.s_CommitEdit.Invoke(this._collectionView, null);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002C90 File Offset: 0x00000E90
		public void CommitNew()
		{
			global::Infragistics.Windows.EditableCollectionViewProxy.s_CommitNew.Invoke(this._collectionView, null);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002CA4 File Offset: 0x00000EA4
		public object CurrentAddItem
		{
			get
			{
				return global::Infragistics.Windows.EditableCollectionViewProxy.s_CurrentAddItem.GetValue(this._collectionView, null);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002CB7 File Offset: 0x00000EB7
		public object CurrentEditItem
		{
			get
			{
				return global::Infragistics.Windows.EditableCollectionViewProxy.s_CurrentEditItem.GetValue(this._collectionView, null);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002CCC File Offset: 0x00000ECC
		public void EditItem(object item)
		{
			global::Infragistics.Windows.EditableCollectionViewProxy.s_EditItem.Invoke(this._collectionView, new object[]
			{
				item
			});
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002CF6 File Offset: 0x00000EF6
		public bool IsAddingNew
		{
			get
			{
				return (bool)global::Infragistics.Windows.EditableCollectionViewProxy.s_IsAddingNew.GetValue(this._collectionView, null);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002D0E File Offset: 0x00000F0E
		public bool IsEditingItem
		{
			get
			{
				return (bool)global::Infragistics.Windows.EditableCollectionViewProxy.s_IsEditingItem.GetValue(this._collectionView, null);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002D26 File Offset: 0x00000F26
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002D3E File Offset: 0x00000F3E
		public global::Infragistics.Windows.NewItemPlaceholderPositionProxy NewItemPlaceholderPosition
		{
			get
			{
				return (global::Infragistics.Windows.NewItemPlaceholderPositionProxy)((int)global::Infragistics.Windows.EditableCollectionViewProxy.s_NewItemPlaceholderPosition.GetValue(this._collectionView, null));
			}
			set
			{
				global::Infragistics.Windows.EditableCollectionViewProxy.s_NewItemPlaceholderPosition.SetValue(this._collectionView, value, null);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002D58 File Offset: 0x00000F58
		public void Remove(object item)
		{
			global::Infragistics.Windows.EditableCollectionViewProxy.s_Remove.Invoke(this._collectionView, new object[]
			{
				item
			});
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002D84 File Offset: 0x00000F84
		public void RemoveAt(int index)
		{
			global::Infragistics.Windows.EditableCollectionViewProxy.s_RemoveAt.Invoke(this._collectionView, new object[]
			{
				index
			});
		}

		// Token: 0x0400000F RID: 15
		private global::System.Windows.Data.CollectionView _collectionView;

		// Token: 0x04000010 RID: 16
		private static global::System.Type s_IEditableCollectionViewType = global::System.Type.GetType("System.ComponentModel.IEditableCollectionView, " + typeof(global::System.ComponentModel.ICollectionView).Assembly.FullName);

		// Token: 0x04000011 RID: 17
		private static global::System.Reflection.MethodInfo s_AddNew;

		// Token: 0x04000012 RID: 18
		private static global::System.Reflection.MethodInfo s_CancelEdit;

		// Token: 0x04000013 RID: 19
		private static global::System.Reflection.MethodInfo s_CancelNew;

		// Token: 0x04000014 RID: 20
		private static global::System.Reflection.MethodInfo s_CommitEdit;

		// Token: 0x04000015 RID: 21
		private static global::System.Reflection.MethodInfo s_CommitNew;

		// Token: 0x04000016 RID: 22
		private static global::System.Reflection.MethodInfo s_EditItem;

		// Token: 0x04000017 RID: 23
		private static global::System.Reflection.MethodInfo s_Remove;

		// Token: 0x04000018 RID: 24
		private static global::System.Reflection.MethodInfo s_RemoveAt;

		// Token: 0x04000019 RID: 25
		private static global::System.Reflection.PropertyInfo s_CanAddNew;

		// Token: 0x0400001A RID: 26
		private static global::System.Reflection.PropertyInfo s_CanCancelEdit;

		// Token: 0x0400001B RID: 27
		private static global::System.Reflection.PropertyInfo s_CanRemove;

		// Token: 0x0400001C RID: 28
		private static global::System.Reflection.PropertyInfo s_CurrentAddItem;

		// Token: 0x0400001D RID: 29
		private static global::System.Reflection.PropertyInfo s_CurrentEditItem;

		// Token: 0x0400001E RID: 30
		private static global::System.Reflection.PropertyInfo s_IsAddingNew;

		// Token: 0x0400001F RID: 31
		private static global::System.Reflection.PropertyInfo s_IsEditingItem;

		// Token: 0x04000020 RID: 32
		private static global::System.Reflection.PropertyInfo s_NewItemPlaceholderPosition;
	}
}
