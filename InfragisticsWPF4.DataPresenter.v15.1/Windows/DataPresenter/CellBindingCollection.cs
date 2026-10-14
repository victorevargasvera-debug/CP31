using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000055 RID: 85
	public class CellBindingCollection : global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.CellBinding>
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x0000F4F8 File Offset: 0x0000D6F8
		internal CellBindingCollection(global::Infragistics.Windows.DataPresenter.Field owner)
		{
			this._owner = owner;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000F508 File Offset: 0x0000D708
		protected override void ClearItems()
		{
			foreach (global::Infragistics.Windows.DataPresenter.CellBinding binding in this)
			{
				this.OnBindingRemoved(binding);
			}
			base.ClearItems();
			this._cvpBindingCount = 0;
			this._editorBindingCount = 0;
			this._isEnabledBinding = null;
			this._isTabStopBinding = null;
			this._isVisibilityBinding = null;
			this.OnCellBindingsChanged();
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000F580 File Offset: 0x0000D780
		protected override void InsertItem(int index, global::Infragistics.Windows.DataPresenter.CellBinding item)
		{
			base.InsertItem(index, item);
			this.OnBindingAdded(item);
			this.OnCellBindingsChanged();
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000F598 File Offset: 0x0000D798
		protected override void RemoveItem(int index)
		{
			global::Infragistics.Windows.DataPresenter.CellBinding binding = base[index];
			base.RemoveItem(index);
			this.OnBindingRemoved(binding);
			this.OnCellBindingsChanged();
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
		protected override void SetItem(int index, global::Infragistics.Windows.DataPresenter.CellBinding item)
		{
			global::Infragistics.Windows.DataPresenter.CellBinding binding = base[index];
			base.SetItem(index, item);
			this.OnBindingAdded(item);
			this.OnBindingRemoved(binding);
			this.OnCellBindingsChanged();
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0000F5F5 File Offset: 0x0000D7F5
		internal int CvpBindingCount
		{
			get
			{
				return this._cvpBindingCount;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0000F5FD File Offset: 0x0000D7FD
		internal int EditorBindingCount
		{
			get
			{
				return this._editorBindingCount;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000F605 File Offset: 0x0000D805
		internal bool IsEnabledBound
		{
			get
			{
				return this._isEnabledBinding != null;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0000F613 File Offset: 0x0000D813
		internal bool IsTabStopBound
		{
			get
			{
				return this._isTabStopBinding != null;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0000F621 File Offset: 0x0000D821
		internal bool IsVisibilityBound
		{
			get
			{
				return this._isVisibilityBinding != null;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x0000F62F File Offset: 0x0000D82F
		internal int RemovedBindingCount
		{
			get
			{
				if (this._removedBindings == null)
				{
					return 0;
				}
				return this._removedBindings.Count;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000F648 File Offset: 0x0000D848
		private global::System.Windows.Controls.Control CvpProxy
		{
			get
			{
				if (this._cvpProxy == null)
				{
					this._cvpProxy = new global::System.Windows.Controls.Control();
					this._cvpProxy.BeginInit();
					if (this._isEnabledBinding != null)
					{
						this._isEnabledBinding.ApplyBinding(this._cvpProxy);
					}
					if (this._isTabStopBinding != null)
					{
						this._isTabStopBinding.ApplyBinding(this._cvpProxy);
					}
					if (this._isVisibilityBinding != null)
					{
						this._isVisibilityBinding.ApplyBinding(this._cvpProxy);
					}
					this._cvpProxy.EndInit();
				}
				return this._cvpProxy;
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000F6CF File Offset: 0x0000D8CF
		internal void ApplyBindingsToCvp(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			this.ApplyBindingsHelper(cvp, global::Infragistics.Windows.DataPresenter.CellBindingTarget.CellValuePresenter);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000F6D9 File Offset: 0x0000D8D9
		internal void ApplyBindingsToEditor(global::Infragistics.Windows.Editors.ValueEditor editor)
		{
			this.ApplyBindingsHelper(editor, global::Infragistics.Windows.DataPresenter.CellBindingTarget.Editor);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000F6E3 File Offset: 0x0000D8E3
		internal void ApplyAddedBindingsToCvp(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			this.ApplyBindingsHelper(cvp, global::Infragistics.Windows.DataPresenter.CellBindingTarget.CellValuePresenter);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000F6ED File Offset: 0x0000D8ED
		internal void ApplyAddedBindingsToEditor(global::Infragistics.Windows.Editors.ValueEditor editor)
		{
			this.ApplyAddedBindingsHelper(editor, global::Infragistics.Windows.DataPresenter.CellBindingTarget.Editor);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000F6F7 File Offset: 0x0000D8F7
		internal void ClearAddedAndRemovedLists()
		{
			this._removedBindings = null;
			this._addedBindings = null;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000F707 File Offset: 0x0000D907
		internal void ClearAllBindingsOnCvp(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			this.ClearAllBindingsHelper(cvp, global::Infragistics.Windows.DataPresenter.CellBindingTarget.CellValuePresenter);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0000F711 File Offset: 0x0000D911
		internal void ClearAllBindingsOnEditor(global::Infragistics.Windows.Editors.ValueEditor editor)
		{
			this.ClearAllBindingsHelper(editor, global::Infragistics.Windows.DataPresenter.CellBindingTarget.Editor);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000F71B File Offset: 0x0000D91B
		internal void ClearRemovedBindingsOnCvp(global::Infragistics.Windows.DataPresenter.CellValuePresenter cvp)
		{
			this.ClearRemovedBindingsHelper(cvp, global::Infragistics.Windows.DataPresenter.CellBindingTarget.CellValuePresenter);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000F725 File Offset: 0x0000D925
		internal void ClearRemovedBindingsOnEditor(global::Infragistics.Windows.Editors.ValueEditor editor)
		{
			this.ClearRemovedBindingsHelper(editor, global::Infragistics.Windows.DataPresenter.CellBindingTarget.Editor);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000F730 File Offset: 0x0000D930
		internal void InitializeFrom(global::Infragistics.Windows.DataPresenter.CellBindingCollection source)
		{
			if (base.Count > 0)
			{
				base.Clear();
			}
			foreach (global::Infragistics.Windows.DataPresenter.CellBinding cellBinding in source)
			{
				base.Add(cellBinding.Clone());
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000F78C File Offset: 0x0000D98C
		internal bool IsCvpEnabled(global::Infragistics.Windows.DataPresenter.DataRecord rcd)
		{
			if (!this.IsCvpVisible(rcd))
			{
				return false;
			}
			if (this._isEnabledBinding == null)
			{
				return true;
			}
			bool isEnabled;
			try
			{
				this.CvpProxy.DataContext = rcd;
				isEnabled = this._cvpProxy.IsEnabled;
			}
			finally
			{
				this.ReleaseCvpProxyDataContextAsync();
			}
			return isEnabled;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		internal bool IsCvpTabStop(global::Infragistics.Windows.DataPresenter.DataRecord rcd)
		{
			if (!this.IsCvpEnabled(rcd))
			{
				return false;
			}
			if (this._isTabStopBinding == null)
			{
				return true;
			}
			bool isTabStop;
			try
			{
				this.CvpProxy.DataContext = rcd;
				isTabStop = this._cvpProxy.IsTabStop;
			}
			finally
			{
				this.ReleaseCvpProxyDataContextAsync();
			}
			return isTabStop;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000F834 File Offset: 0x0000DA34
		internal bool IsCvpVisible(global::Infragistics.Windows.DataPresenter.DataRecord rcd)
		{
			if (this._isVisibilityBinding == null)
			{
				return true;
			}
			bool result;
			try
			{
				this.CvpProxy.DataContext = rcd;
				result = (this._cvpProxy.Visibility == global::System.Windows.Visibility.Visible);
			}
			finally
			{
				this.ReleaseCvpProxyDataContextAsync();
			}
			return result;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000F880 File Offset: 0x0000DA80
		private void ApplyAddedBindingsHelper(global::System.Windows.FrameworkElement element, global::Infragistics.Windows.DataPresenter.CellBindingTarget target)
		{
			if (this._addedBindings == null)
			{
				return;
			}
			int count = this._addedBindings.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.CellBinding cellBinding = this._addedBindings[i];
				if (cellBinding.Target == target)
				{
					cellBinding.ApplyBinding(element);
				}
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000F8CC File Offset: 0x0000DACC
		private void ApplyBindingsHelper(global::System.Windows.FrameworkElement element, global::Infragistics.Windows.DataPresenter.CellBindingTarget target)
		{
			int i;
			switch (target)
			{
			case global::Infragistics.Windows.DataPresenter.CellBindingTarget.Editor:
				i = this._editorBindingCount;
				break;
			case global::Infragistics.Windows.DataPresenter.CellBindingTarget.CellValuePresenter:
				i = this._cvpBindingCount;
				break;
			default:
				return;
			}
			int num = 0;
			while (i > 0)
			{
				global::Infragistics.Windows.DataPresenter.CellBinding cellBinding = base[num];
				if (cellBinding.Target == target)
				{
					i--;
					if (cellBinding.Target == target)
					{
						cellBinding.ApplyBinding(element);
					}
				}
				num++;
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000F92C File Offset: 0x0000DB2C
		private void ClearAllBindingsHelper(global::System.Windows.FrameworkElement element, global::Infragistics.Windows.DataPresenter.CellBindingTarget target)
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.CellBinding cellBinding = base[i];
				if (cellBinding.Target == target)
				{
					cellBinding.ClearBinding(element);
				}
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000F964 File Offset: 0x0000DB64
		private void ClearRemovedBindingsHelper(global::System.Windows.FrameworkElement element, global::Infragistics.Windows.DataPresenter.CellBindingTarget target)
		{
			if (this._removedBindings == null)
			{
				return;
			}
			int count = this._removedBindings.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.CellBinding cellBinding = this._removedBindings[i];
				if (cellBinding.Target == target)
				{
					cellBinding.ClearBinding(element);
				}
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000F9B0 File Offset: 0x0000DBB0
		private void MaintainSpecialPropFlags(global::Infragistics.Windows.DataPresenter.CellBinding binding, bool isBindingSet)
		{
			string property;
			if (binding.Target == global::Infragistics.Windows.DataPresenter.CellBindingTarget.CellValuePresenter && (property = binding.Property) != null)
			{
				if (property == "IsEnabled")
				{
					this._isEnabledBinding = (isBindingSet ? binding : null);
					return;
				}
				if (property == "IsTabStop")
				{
					this._isTabStopBinding = (isBindingSet ? binding : null);
					return;
				}
				if (!(property == "Visibility"))
				{
					return;
				}
				this._isVisibilityBinding = (isBindingSet ? binding : null);
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000FA24 File Offset: 0x0000DC24
		private void OnBindingAdded(global::Infragistics.Windows.DataPresenter.CellBinding binding)
		{
			binding.PropertyChanged += this.OnBindingPropertyChanged;
			if (this._addedBindings == null)
			{
				this._addedBindings = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellBinding>();
			}
			this._addedBindings.Add(binding);
			if (binding.Target == global::Infragistics.Windows.DataPresenter.CellBindingTarget.Editor)
			{
				this._editorBindingCount++;
			}
			else
			{
				this._cvpBindingCount++;
			}
			this.MaintainSpecialPropFlags(binding, true);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000FA90 File Offset: 0x0000DC90
		private void OnBindingPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Property")
			{
				this._isEnabledBinding = null;
				this._isTabStopBinding = null;
				this._isVisibilityBinding = null;
				foreach (global::Infragistics.Windows.DataPresenter.CellBinding binding in this)
				{
					this.MaintainSpecialPropFlags(binding, true);
				}
			}
			this.OnCellBindingsChanged();
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000FB08 File Offset: 0x0000DD08
		private void OnBindingRemoved(global::Infragistics.Windows.DataPresenter.CellBinding binding)
		{
			binding.PropertyChanged -= this.OnBindingPropertyChanged;
			if (this._removedBindings == null)
			{
				this._removedBindings = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellBinding>();
			}
			this._removedBindings.Add(binding);
			if (binding.Target == global::Infragistics.Windows.DataPresenter.CellBindingTarget.Editor)
			{
				this._editorBindingCount--;
			}
			else
			{
				this._cvpBindingCount--;
			}
			this.MaintainSpecialPropFlags(binding, false);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0000FB74 File Offset: 0x0000DD74
		private void OnCellBindingsChanged()
		{
			this._cvpProxy = null;
			this._owner.OnCellBindingsChanged();
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000FB9E File Offset: 0x0000DD9E
		private void ReleaseCvpProxyDataContextAsync()
		{
			this._cvpProxy.Dispatcher.BeginInvoke(new global::System.Action(delegate()
			{
				if (this._cvpProxy != null)
				{
					this._cvpProxy.DataContext = null;
				}
			}), global::System.Windows.Threading.DispatcherPriority.Background, new object[0]);
		}

		// Token: 0x04000123 RID: 291
		private global::Infragistics.Windows.DataPresenter.Field _owner;

		// Token: 0x04000124 RID: 292
		private int _editorBindingCount;

		// Token: 0x04000125 RID: 293
		private int _cvpBindingCount;

		// Token: 0x04000126 RID: 294
		private global::Infragistics.Windows.DataPresenter.CellBinding _isEnabledBinding;

		// Token: 0x04000127 RID: 295
		private global::Infragistics.Windows.DataPresenter.CellBinding _isTabStopBinding;

		// Token: 0x04000128 RID: 296
		private global::Infragistics.Windows.DataPresenter.CellBinding _isVisibilityBinding;

		// Token: 0x04000129 RID: 297
		private global::System.Windows.Controls.Control _cvpProxy;

		// Token: 0x0400012A RID: 298
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellBinding> _addedBindings;

		// Token: 0x0400012B RID: 299
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellBinding> _removedBindings;
	}
}
