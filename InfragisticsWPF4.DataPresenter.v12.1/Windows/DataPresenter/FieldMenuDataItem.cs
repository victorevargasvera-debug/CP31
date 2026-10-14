using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200010F RID: 271
	public class FieldMenuDataItem : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0003D29C File Offset: 0x0003B49C
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x0003D2A4 File Offset: 0x0003B4A4
		public global::System.Windows.Input.ICommand Command
		{
			get
			{
				return this._command;
			}
			set
			{
				this.SetField<global::System.Windows.Input.ICommand>(ref this._command, value, "Command");
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x0003D2B9 File Offset: 0x0003B4B9
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x0003D2C1 File Offset: 0x0003B4C1
		public object CommandParameter
		{
			get
			{
				return this._commandParameter;
			}
			set
			{
				this.SetField<object>(ref this._commandParameter, value, "CommandParameter");
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x0003D2D6 File Offset: 0x0003B4D6
		// (set) Token: 0x06000E5A RID: 3674 RVA: 0x0003D2DE File Offset: 0x0003B4DE
		public bool HasResizableItems
		{
			get
			{
				return this._hasResizableItems;
			}
			private set
			{
				this.SetField<bool>(ref this._hasResizableItems, value, "HasResizableItems");
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0003D2F3 File Offset: 0x0003B4F3
		// (set) Token: 0x06000E5C RID: 3676 RVA: 0x0003D2FB File Offset: 0x0003B4FB
		public object Header
		{
			get
			{
				return this._header;
			}
			set
			{
				this.SetField<object>(ref this._header, value, "Header");
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0003D310 File Offset: 0x0003B510
		// (set) Token: 0x06000E5E RID: 3678 RVA: 0x0003D318 File Offset: 0x0003B518
		public global::System.Windows.Media.ImageSource ImageSource
		{
			get
			{
				return this._imageSource;
			}
			set
			{
				this.SetField<global::System.Windows.Media.ImageSource>(ref this._imageSource, value, "ImageSource");
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000E5F RID: 3679 RVA: 0x0003D32D File Offset: 0x0003B52D
		// (set) Token: 0x06000E60 RID: 3680 RVA: 0x0003D335 File Offset: 0x0003B535
		public bool IsCheckable
		{
			get
			{
				return this._isCheckable;
			}
			set
			{
				this.SetField<bool>(ref this._isCheckable, value, "IsCheckable");
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0003D34A File Offset: 0x0003B54A
		// (set) Token: 0x06000E62 RID: 3682 RVA: 0x0003D352 File Offset: 0x0003B552
		public bool IsChecked
		{
			get
			{
				return this._isChecked;
			}
			set
			{
				this.SetField<bool>(ref this._isChecked, value, "IsChecked");
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000E63 RID: 3683 RVA: 0x0003D367 File Offset: 0x0003B567
		// (set) Token: 0x06000E64 RID: 3684 RVA: 0x0003D36F File Offset: 0x0003B56F
		public bool IsControlHost
		{
			get
			{
				return this._isControlHost;
			}
			set
			{
				this.SetField<bool>(ref this._isControlHost, value, "IsControlHost");
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000E65 RID: 3685 RVA: 0x0003D384 File Offset: 0x0003B584
		// (set) Token: 0x06000E66 RID: 3686 RVA: 0x0003D38C File Offset: 0x0003B58C
		public bool IsResizable
		{
			get
			{
				return this._isResizable;
			}
			set
			{
				this.SetField<bool>(ref this._isResizable, value, "IsResizable");
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x0003D3A1 File Offset: 0x0003B5A1
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x0003D3A9 File Offset: 0x0003B5A9
		public bool IsSeparator
		{
			get
			{
				return this._isSeparator;
			}
			set
			{
				this.SetField<bool>(ref this._isSeparator, value, "IsSeparator");
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x0003D3BE File Offset: 0x0003B5BE
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> Items
		{
			get
			{
				if (this._items == null)
				{
					this._items = new global::Infragistics.Windows.DataPresenter.FieldMenuDataItem.FieldMenuDataItemCollection(this);
				}
				return this._items;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x0003D3DA File Offset: 0x0003B5DA
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x0003D3E2 File Offset: 0x0003B5E2
		public bool StaysOpenOnClick
		{
			get
			{
				return this._staysOpenOnClick;
			}
			set
			{
				this.SetField<bool>(ref this._staysOpenOnClick, value, "StaysOpenOnClick");
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0003D3F8 File Offset: 0x0003B5F8
		internal global::Infragistics.Windows.DataPresenter.FieldMenuDataItem Find(global::System.Predicate<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> callback, bool recursive, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> ancestors)
		{
			if (this._items == null)
			{
				return null;
			}
			foreach (global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem in this._items)
			{
				if (callback(fieldMenuDataItem))
				{
					if (ancestors != null)
					{
						ancestors.Add(this);
					}
					return fieldMenuDataItem;
				}
				if (recursive)
				{
					global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem2 = fieldMenuDataItem.Find(callback, true, ancestors);
					if (fieldMenuDataItem2 != null)
					{
						if (ancestors != null)
						{
							ancestors.Add(this);
						}
						return fieldMenuDataItem2;
					}
				}
			}
			return null;
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x0003D480 File Offset: 0x0003B680
		private bool SetField<T>(ref T member, T value, string propertyName)
		{
			if (global::System.Collections.Generic.EqualityComparer<T>.Default.Equals(member, value))
			{
				return false;
			}
			member = value;
			this.OnPropertyChanged(propertyName);
			return true;
		}

		// Token: 0x04000592 RID: 1426
		private bool _isChecked;

		// Token: 0x04000593 RID: 1427
		private bool _isCheckable;

		// Token: 0x04000594 RID: 1428
		private global::System.Windows.Input.ICommand _command;

		// Token: 0x04000595 RID: 1429
		private object _commandParameter;

		// Token: 0x04000596 RID: 1430
		private object _header;

		// Token: 0x04000597 RID: 1431
		private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem.FieldMenuDataItemCollection _items;

		// Token: 0x04000598 RID: 1432
		private global::System.Windows.Media.ImageSource _imageSource;

		// Token: 0x04000599 RID: 1433
		private bool _isSeparator;

		// Token: 0x0400059A RID: 1434
		private bool _isResizable;

		// Token: 0x0400059B RID: 1435
		private bool _hasResizableItems;

		// Token: 0x0400059C RID: 1436
		private bool _staysOpenOnClick;

		// Token: 0x0400059D RID: 1437
		private bool _isControlHost;

		// Token: 0x02000110 RID: 272
		private class FieldMenuDataItemCollection : global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem>
		{
			// Token: 0x06000E6E RID: 3694 RVA: 0x0003D4A6 File Offset: 0x0003B6A6
			internal FieldMenuDataItemCollection(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem owner) : base(true, false)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(owner);
				this._owner = owner;
			}

			// Token: 0x17000328 RID: 808
			// (get) Token: 0x06000E6F RID: 3695 RVA: 0x0003D4BD File Offset: 0x0003B6BD
			protected override bool NotifyItemsChanged
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06000E70 RID: 3696 RVA: 0x0003D4C0 File Offset: 0x0003B6C0
			protected override void OnItemAdding(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem itemAdded)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(itemAdded, "itemAdded");
				base.OnItemAdding(itemAdded);
			}

			// Token: 0x06000E71 RID: 3697 RVA: 0x0003D4D4 File Offset: 0x0003B6D4
			protected override void OnItemAdded(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem itemAdded)
			{
				if (itemAdded.IsResizable)
				{
					this.ResizableItemCount++;
				}
				base.OnItemAdded(itemAdded);
			}

			// Token: 0x06000E72 RID: 3698 RVA: 0x0003D4F3 File Offset: 0x0003B6F3
			protected override void OnItemRemoved(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem itemRemoved)
			{
				if (itemRemoved.IsResizable)
				{
					this.ResizableItemCount--;
				}
				base.OnItemRemoved(itemRemoved);
			}

			// Token: 0x06000E73 RID: 3699 RVA: 0x0003D514 File Offset: 0x0003B714
			protected override void OnItemPropertyChanged(global::Infragistics.Collections.ItemPropertyChangedEventArgs e)
			{
				if (e.PropertyName == "IsResizable")
				{
					global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = e.Item as global::Infragistics.Windows.DataPresenter.FieldMenuDataItem;
					if (fieldMenuDataItem.IsResizable)
					{
						this.ResizableItemCount--;
					}
					else
					{
						this.ResizableItemCount++;
					}
				}
				base.OnItemPropertyChanged(e);
			}

			// Token: 0x17000329 RID: 809
			// (get) Token: 0x06000E74 RID: 3700 RVA: 0x0003D56C File Offset: 0x0003B76C
			// (set) Token: 0x06000E75 RID: 3701 RVA: 0x0003D574 File Offset: 0x0003B774
			internal int ResizableItemCount
			{
				get
				{
					return this._resizableItemCount;
				}
				private set
				{
					if (value != this._resizableItemCount)
					{
						this._resizableItemCount = value;
						this._owner.HasResizableItems = (value > 0);
					}
				}
			}

			// Token: 0x0400059E RID: 1438
			private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem _owner;

			// Token: 0x0400059F RID: 1439
			private int _resizableItemCount;
		}
	}
}
