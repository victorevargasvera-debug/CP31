using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200012B RID: 299
	public class FieldMenuDataItem : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x0004DD94 File Offset: 0x0004BF94
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x0004DD9C File Offset: 0x0004BF9C
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

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x0004DDB1 File Offset: 0x0004BFB1
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x0004DDB9 File Offset: 0x0004BFB9
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

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x0004DDCE File Offset: 0x0004BFCE
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x0004DDD6 File Offset: 0x0004BFD6
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

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x0004DDEB File Offset: 0x0004BFEB
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x0004DDF3 File Offset: 0x0004BFF3
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

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x0004DE08 File Offset: 0x0004C008
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x0004DE10 File Offset: 0x0004C010
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

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0004DE25 File Offset: 0x0004C025
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x0004DE2D File Offset: 0x0004C02D
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

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x0004DE42 File Offset: 0x0004C042
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x0004DE4A File Offset: 0x0004C04A
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

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x0004DE5F File Offset: 0x0004C05F
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x0004DE67 File Offset: 0x0004C067
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

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x0004DE7C File Offset: 0x0004C07C
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x0004DE84 File Offset: 0x0004C084
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

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x0004DE99 File Offset: 0x0004C099
		// (set) Token: 0x060011C9 RID: 4553 RVA: 0x0004DEA1 File Offset: 0x0004C0A1
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

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x0004DEB6 File Offset: 0x0004C0B6
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

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x0004DED2 File Offset: 0x0004C0D2
		// (set) Token: 0x060011CC RID: 4556 RVA: 0x0004DEDA File Offset: 0x0004C0DA
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

		// Token: 0x060011CD RID: 4557 RVA: 0x0004DEF0 File Offset: 0x0004C0F0
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

		// Token: 0x060011CE RID: 4558 RVA: 0x0004DF78 File Offset: 0x0004C178
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

		// Token: 0x04000731 RID: 1841
		private bool _isChecked;

		// Token: 0x04000732 RID: 1842
		private bool _isCheckable;

		// Token: 0x04000733 RID: 1843
		private global::System.Windows.Input.ICommand _command;

		// Token: 0x04000734 RID: 1844
		private object _commandParameter;

		// Token: 0x04000735 RID: 1845
		private object _header;

		// Token: 0x04000736 RID: 1846
		private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem.FieldMenuDataItemCollection _items;

		// Token: 0x04000737 RID: 1847
		private global::System.Windows.Media.ImageSource _imageSource;

		// Token: 0x04000738 RID: 1848
		private bool _isSeparator;

		// Token: 0x04000739 RID: 1849
		private bool _isResizable;

		// Token: 0x0400073A RID: 1850
		private bool _hasResizableItems;

		// Token: 0x0400073B RID: 1851
		private bool _staysOpenOnClick;

		// Token: 0x0400073C RID: 1852
		private bool _isControlHost;

		// Token: 0x0200012C RID: 300
		private class FieldMenuDataItemCollection : global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem>
		{
			// Token: 0x060011CF RID: 4559 RVA: 0x0004DF9E File Offset: 0x0004C19E
			internal FieldMenuDataItemCollection(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem owner) : base(true, false)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(owner);
				this._owner = owner;
			}

			// Token: 0x17000467 RID: 1127
			// (get) Token: 0x060011D0 RID: 4560 RVA: 0x0004DFB5 File Offset: 0x0004C1B5
			protected override bool NotifyItemsChanged
			{
				get
				{
					return true;
				}
			}

			// Token: 0x060011D1 RID: 4561 RVA: 0x0004DFB8 File Offset: 0x0004C1B8
			protected override void OnItemAdding(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem itemAdded)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(itemAdded, "itemAdded");
				base.OnItemAdding(itemAdded);
			}

			// Token: 0x060011D2 RID: 4562 RVA: 0x0004DFCC File Offset: 0x0004C1CC
			protected override void OnItemAdded(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem itemAdded)
			{
				if (itemAdded.IsResizable)
				{
					this.ResizableItemCount++;
				}
				base.OnItemAdded(itemAdded);
			}

			// Token: 0x060011D3 RID: 4563 RVA: 0x0004DFEB File Offset: 0x0004C1EB
			protected override void OnItemRemoved(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem itemRemoved)
			{
				if (itemRemoved.IsResizable)
				{
					this.ResizableItemCount--;
				}
				base.OnItemRemoved(itemRemoved);
			}

			// Token: 0x060011D4 RID: 4564 RVA: 0x0004E00C File Offset: 0x0004C20C
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

			// Token: 0x17000468 RID: 1128
			// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0004E064 File Offset: 0x0004C264
			// (set) Token: 0x060011D6 RID: 4566 RVA: 0x0004E06C File Offset: 0x0004C26C
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

			// Token: 0x0400073D RID: 1853
			private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem _owner;

			// Token: 0x0400073E RID: 1854
			private int _resizableItemCount;
		}
	}
}
