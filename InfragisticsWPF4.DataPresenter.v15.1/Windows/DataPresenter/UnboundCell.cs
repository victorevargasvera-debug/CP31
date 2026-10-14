using System;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200004F RID: 79
	public class UnboundCell : global::Infragistics.Windows.DataPresenter.Cell
	{
		// Token: 0x06000401 RID: 1025 RVA: 0x0000E80F File Offset: 0x0000CA0F
		internal UnboundCell(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field) : base(record, field)
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000E81C File Offset: 0x0000CA1C
		internal override void CloneAssociatedCellSettings(global::Infragistics.Windows.DataPresenter.Cell associatedCell)
		{
			base.CloneAssociatedCellSettings(associatedCell);
			global::Infragistics.Windows.DataPresenter.UnboundCell unboundCell = associatedCell as global::Infragistics.Windows.DataPresenter.UnboundCell;
			if (unboundCell != null)
			{
				this._unboundData = unboundCell._unboundData;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0000E846 File Offset: 0x0000CA46
		internal override bool HasCloneableSettings
		{
			get
			{
				return this._unboundData != null || base.HasCloneableSettings;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0000E858 File Offset: 0x0000CA58
		public override bool IsUnbound
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0000E85B File Offset: 0x0000CA5B
		protected override void OnHasListenersChanged()
		{
			base.OnHasListenersChanged();
			if (this.MaintainBindings)
			{
				this.VerifyBindingStatus();
				return;
			}
			this.ClearValueHolder();
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0000E878 File Offset: 0x0000CA78
		internal bool MaintainBindings
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Field field = base.Field;
				if (field != null && global::Infragistics.Windows.DataPresenter.BindingRetentionMode.Retain == field.AlternateBindingRetentionMode)
				{
					return true;
				}
				if (this._valueHolder != null && this._valueHolder.Retain)
				{
					return true;
				}
				if (!global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider.HasPropertyDescriptorFor(this) && global::Infragistics.Windows.DataPresenter.SummaryResultCollection.HasSummaryDependentOn(this, false))
				{
					return true;
				}
				if (field != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager recordManager = base.Record.RecordManager;
					global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection resolvedRecordFilterCollection = (recordManager != null) ? recordManager.RecordFiltersResolved : null;
					bool flag = resolvedRecordFilterCollection != null && resolvedRecordFilterCollection.HasActiveFilter(field);
					if (flag)
					{
						return true;
					}
				}
				return base.HasListeners || base.GetAssociatedCellValuePresenter(false) != null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0000E90C File Offset: 0x0000CB0C
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x0000E928 File Offset: 0x0000CB28
		internal object ValueInternal
		{
			get
			{
				object result;
				string text;
				this.GetValueHelper(out result, out text, true, false);
				return result;
			}
			set
			{
				object value2 = base.Value;
				this.VerifyBindingStatus();
				bool flag = false;
				global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
				global::System.Windows.Data.BindingExpression bindingExpression = null;
				if (this._valueHolder != null)
				{
					bool flag2 = true;
					global::Infragistics.Windows.DataPresenter.Field field = base.Field;
					if (field != null && field.IsBoundToRootProperty && record != null && !record.IsAddRecord && record.DataItem != null)
					{
						bindingExpression = global::System.Windows.Data.BindingOperations.GetBindingExpression(this._valueHolder as global::System.Windows.DependencyObject, global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.ValueProperty);
						if (bindingExpression != null && global::Infragistics.Windows.DataPresenter.GridUtilities.AreEqual(bindingExpression.DataItem, record.DataItem) && !bindingExpression.HasError && bindingExpression.ParentBinding != null)
						{
							global::System.Windows.Data.BindingMode mode = bindingExpression.ParentBinding.Mode;
							if (mode == global::System.Windows.Data.BindingMode.TwoWay || mode == global::System.Windows.Data.BindingMode.OneWayToSource)
							{
								flag = true;
								record.BeginEdit();
							}
							else
							{
								flag2 = false;
							}
						}
					}
					this._valueHolder.Value = value;
					if (!flag2 && global::System.Windows.Data.BindingOperations.GetBindingExpression(this._valueHolder as global::System.Windows.DependencyObject, global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.ValueProperty) == null)
					{
						this._valueHolder.Retain = true;
						return;
					}
					if (!this.MaintainBindings)
					{
						this.ClearValueHolder();
					}
					else if (this._valueHolder != null)
					{
						if (bindingExpression == null)
						{
							bindingExpression = global::System.Windows.Data.BindingOperations.GetBindingExpression(this._valueHolder as global::System.Windows.DependencyObject, global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.ValueProperty);
						}
						if (bindingExpression != null && bindingExpression.Status == global::System.Windows.Data.BindingStatus.Active)
						{
							bindingExpression.UpdateTarget();
						}
					}
				}
				else
				{
					this._unboundData = value;
					this.InternalOnValueChanged(value2, value);
				}
				if (record != null && !flag)
				{
					record.BeginEdit();
				}
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000EA78 File Offset: 0x0000CC78
		internal void InternalOnValueChanged(object oldValue, object newValue)
		{
			base.RaiseAutomationValueChanged(oldValue, newValue);
			base.RaiseValueChangedNotifications();
			global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (this.IsUnbound)
			{
				record.RefreshCellValueHelper(field, newValue);
				record.RefreshDataErrorInfo(field, false);
			}
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = record.RecordManager;
			if (recordManager != null)
			{
				recordManager.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.CellDataChange, record, field);
			}
			record.FireInitializeRecord(true, field.IsSortOrGroupBy);
			global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = base.AssociatedCellValuePresenter;
			if (associatedCellValuePresenter != null)
			{
				associatedCellValuePresenter.SetValueInternal(this.ConvertedValue, false);
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		internal void RefreshBindings()
		{
			this.ClearValueHolder();
			this.VerifyBindingStatus();
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000EB00 File Offset: 0x0000CD00
		internal void RefreshCellValue()
		{
			global::System.Windows.DependencyObject dependencyObject = this._valueHolder as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				global::System.Windows.Data.BindingExpressionBase bindingExpressionBase = global::System.Windows.Data.BindingOperations.GetBindingExpressionBase(dependencyObject, global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.ValueProperty);
				if (bindingExpressionBase != null)
				{
					bindingExpressionBase.UpdateTarget();
				}
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000EB31 File Offset: 0x0000CD31
		internal void ClearValueHolder()
		{
			if (this._valueHolder != null)
			{
				this._valueHolder.ClearBinding();
				this._valueHolder = null;
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000EB50 File Offset: 0x0000CD50
		private void GetValueHelper(out object value, out string error, bool getValue, bool getError)
		{
			value = null;
			error = null;
			this.VerifyBindingStatus();
			if (this._valueHolder != null)
			{
				if (getValue)
				{
					value = this._valueHolder.Value;
				}
				if (getError)
				{
					error = this._valueHolder.DataError;
				}
				if (!this.MaintainBindings)
				{
					this.ClearValueHolder();
					return;
				}
			}
			else if (getValue)
			{
				value = this._unboundData;
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000EBAC File Offset: 0x0000CDAC
		private bool IsSameBinding(global::Infragistics.Windows.DataPresenter.DataRecord dr, global::System.Windows.Data.BindingBase binding, global::System.Windows.PropertyPath bindingPath, global::System.Windows.Data.BindingMode mode)
		{
			if (binding != null)
			{
				global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext valueHolderWithDataContext = this._valueHolder as global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext;
				return valueHolderWithDataContext != null && valueHolderWithDataContext.Binding == binding && global::Infragistics.Windows.DataPresenter.GridUtilities.AreEqual(dr.DataItem, valueHolderWithDataContext.DataContext);
			}
			global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder valueHolder = this._valueHolder as global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder;
			return valueHolder != null && valueHolder.IsSameBinding(this, dr, bindingPath, mode);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000EC04 File Offset: 0x0000CE04
		private void VerifyBindingStatus()
		{
			global::Infragistics.Windows.DataPresenter.Field field = base.Field;
			if (field == null)
			{
				return;
			}
			global::System.Windows.PropertyPath propertyPath = field.GetValue(global::Infragistics.Windows.DataPresenter.UnboundField.BindingPathProperty) as global::System.Windows.PropertyPath;
			global::System.Windows.Data.BindingBase alternateBinding = field.AlternateBinding;
			global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
			if ((propertyPath == null && alternateBinding == null) || record.IsAddRecordTemplate)
			{
				this.ClearValueHolder();
				return;
			}
			global::System.Windows.Data.BindingMode mode = (global::System.Windows.Data.BindingMode)field.GetValue(global::Infragistics.Windows.DataPresenter.UnboundField.BindingModeProperty);
			if (this._valueHolder != null)
			{
				if (this.IsSameBinding(record, alternateBinding, propertyPath, mode))
				{
					return;
				}
				this.ClearValueHolder();
			}
			if (record != null)
			{
				if (alternateBinding != null)
				{
					this._valueHolder = new global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext(this, record, alternateBinding);
					return;
				}
				this._valueHolder = new global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder(this, record, propertyPath, mode);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
		internal string DataErrorInternal
		{
			get
			{
				object obj;
				string result;
				this.GetValueHelper(out obj, out result, false, true);
				return result;
			}
		}

		// Token: 0x0400010C RID: 268
		private object _unboundData;

		// Token: 0x0400010D RID: 269
		private global::Infragistics.Windows.DataPresenter.UnboundCell.IValueHolder _valueHolder;

		// Token: 0x02000050 RID: 80
		private interface IValueHolder
		{
			// Token: 0x06000411 RID: 1041
			void ClearBinding();

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000412 RID: 1042
			// (set) Token: 0x06000413 RID: 1043
			object Value { get; set; }

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000414 RID: 1044
			string DataError { get; }

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x06000415 RID: 1045
			global::Infragistics.Windows.DataPresenter.UnboundCell Cell { get; }

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x06000416 RID: 1046
			// (set) Token: 0x06000417 RID: 1047
			bool Retain { get; set; }
		}

		// Token: 0x02000051 RID: 81
		private class DataErrorHolder
		{
			// Token: 0x06000419 RID: 1049 RVA: 0x0000ECD9 File Offset: 0x0000CED9
			internal DataErrorHolder(global::Infragistics.Windows.DataPresenter.UnboundCell.IValueHolder holder)
			{
				this._holder = holder;
				this.TrackErrors();
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x0600041A RID: 1050 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
			public string DataError
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.GridUtilities.GetValidationErrorText(global::System.Windows.Controls.Validation.GetErrors((global::System.Windows.DependencyObject)this._holder));
				}
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x0000ED14 File Offset: 0x0000CF14
			internal void OnBindingCleared()
			{
				this._errorsPvt = null;
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x0000ED20 File Offset: 0x0000CF20
			internal static bool EnableDataErrorSupportHelper(global::Infragistics.Windows.DataPresenter.UnboundCell cell, global::System.Windows.Data.Binding binding)
			{
				if (cell.Field.SupportDataErrorInfoResolved)
				{
					try
					{
						global::System.Reflection.PropertyInfo propertyInfo = global::Infragistics.Windows.DataPresenter.UnboundCell.DataErrorHolder.g_binding_ValidatesOnDataErrorsProperty;
						if (null != propertyInfo)
						{
							if (binding != null)
							{
								propertyInfo.SetValue(binding, true, null);
							}
							return true;
						}
					}
					catch
					{
					}
					return false;
				}
				return false;
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x0000ED78 File Offset: 0x0000CF78
			private void OnErrorsChanged()
			{
				if (this._errorsPvt != null)
				{
					global::Infragistics.Windows.DataPresenter.UnboundCell cell = this._holder.Cell;
					if (cell != null)
					{
						cell.Record.RefreshDataErrorInfo(cell.Field, false);
					}
				}
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x0000EDAE File Offset: 0x0000CFAE
			internal void OnValueChanged()
			{
				this.TrackErrors();
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x0000EDB6 File Offset: 0x0000CFB6
			internal void TrackErrors()
			{
				if (this._errorsPvt == null)
				{
					this._errorsPvt = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._holder, "(Validation.Errors).Count", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnErrorsChanged));
				}
			}

			// Token: 0x0400010E RID: 270
			private global::Infragistics.Windows.DataPresenter.UnboundCell.IValueHolder _holder;

			// Token: 0x0400010F RID: 271
			private global::Infragistics.Windows.Internal.PropertyValueTracker _errorsPvt;

			// Token: 0x04000110 RID: 272
			internal static readonly global::System.Reflection.PropertyInfo g_binding_ValidatesOnDataErrorsProperty = typeof(global::System.Windows.Data.Binding).GetProperty("ValidatesOnDataErrors");
		}

		// Token: 0x02000052 RID: 82
		private class ValueHolder : global::System.Windows.DependencyObject, global::Infragistics.Windows.DataPresenter.UnboundCell.IValueHolder
		{
			// Token: 0x06000420 RID: 1056 RVA: 0x0000EDE4 File Offset: 0x0000CFE4
			internal ValueHolder(global::Infragistics.Windows.DataPresenter.UnboundCell cell, global::Infragistics.Windows.DataPresenter.DataRecord dr, global::System.Windows.PropertyPath bindingPath, global::System.Windows.Data.BindingMode mode)
			{
				this._cell = cell;
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
				binding.Path = bindingPath;
				binding.Mode = mode;
				binding.Source = dr.DataItem;
				this._dataErrorSupportEnabled = global::Infragistics.Windows.DataPresenter.UnboundCell.DataErrorHolder.EnableDataErrorSupportHelper(cell, binding);
				global::Infragistics.Windows.DataPresenter.Field field = cell.Field;
				binding.ConverterCulture = field.ConverterCultureResolved;
				this._bypassNotifications = true;
				try
				{
					global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.ValueProperty, binding);
					this._binding = binding;
				}
				catch (global::System.Exception innerException)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_6", new object[]
					{
						cell.Field.Name
					}), innerException);
				}
				finally
				{
					this._bypassNotifications = false;
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x06000421 RID: 1057 RVA: 0x0000EEAC File Offset: 0x0000D0AC
			public global::Infragistics.Windows.DataPresenter.UnboundCell Cell
			{
				get
				{
					return this._cell;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x06000422 RID: 1058 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
			public string DataError
			{
				get
				{
					if (this._dataErrorHolder == null)
					{
						this._dataErrorHolder = new global::Infragistics.Windows.DataPresenter.UnboundCell.DataErrorHolder(this);
					}
					return this._dataErrorHolder.DataError;
				}
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x0000EED8 File Offset: 0x0000D0D8
			private static void OnValueChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder valueHolder = target as global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder;
				if (valueHolder != null && !valueHolder._bypassNotifications && valueHolder._cell != null)
				{
					valueHolder._cell.InternalOnValueChanged(e.OldValue, e.NewValue);
					if (valueHolder._dataErrorHolder != null)
					{
						valueHolder._dataErrorHolder.OnValueChanged();
					}
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000424 RID: 1060 RVA: 0x0000EF2B File Offset: 0x0000D12B
			// (set) Token: 0x06000425 RID: 1061 RVA: 0x0000EF38 File Offset: 0x0000D138
			public object Value
			{
				get
				{
					return base.GetValue(global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.ValueProperty);
				}
				set
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.ValueProperty, value);
				}
			}

			// Token: 0x06000426 RID: 1062 RVA: 0x0000EF48 File Offset: 0x0000D148
			internal bool IsSameBinding(global::Infragistics.Windows.DataPresenter.UnboundCell cell, global::Infragistics.Windows.DataPresenter.DataRecord dr, global::System.Windows.PropertyPath bindingPath, global::System.Windows.Data.BindingMode mode)
			{
				if (this._cell != cell || dr == null)
				{
					return false;
				}
				global::System.Windows.Data.Binding binding = this._binding;
				return binding != null && (binding.Path == bindingPath && binding.Mode == mode && binding.Source == dr.DataItem && this._dataErrorSupportEnabled == global::Infragistics.Windows.DataPresenter.UnboundCell.DataErrorHolder.EnableDataErrorSupportHelper(cell, null)) && binding.ConverterCulture == cell.Field.ConverterCultureResolved;
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
			public void ClearBinding()
			{
				this._bypassNotifications = true;
				if (this._dataErrorHolder != null)
				{
					this._dataErrorHolder.OnBindingCleared();
				}
				global::System.Windows.Data.BindingOperations.ClearAllBindings(this);
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000428 RID: 1064 RVA: 0x0000EFD6 File Offset: 0x0000D1D6
			// (set) Token: 0x06000429 RID: 1065 RVA: 0x0000EFDE File Offset: 0x0000D1DE
			public bool Retain { get; set; }

			// Token: 0x04000111 RID: 273
			private global::Infragistics.Windows.DataPresenter.UnboundCell _cell;

			// Token: 0x04000112 RID: 274
			private bool _bypassNotifications;

			// Token: 0x04000113 RID: 275
			private global::System.Windows.Data.Binding _binding;

			// Token: 0x04000114 RID: 276
			private global::Infragistics.Windows.DataPresenter.UnboundCell.DataErrorHolder _dataErrorHolder;

			// Token: 0x04000115 RID: 277
			private bool _dataErrorSupportEnabled;

			// Token: 0x04000116 RID: 278
			internal static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.OnValueChanged)));
		}

		// Token: 0x02000053 RID: 83
		private class ValueHolderWithDataContext : global::System.Windows.FrameworkContentElement, global::Infragistics.Windows.DataPresenter.UnboundCell.IValueHolder
		{
			// Token: 0x0600042B RID: 1067 RVA: 0x0000F020 File Offset: 0x0000D220
			internal ValueHolderWithDataContext(global::Infragistics.Windows.DataPresenter.UnboundCell cell, global::Infragistics.Windows.DataPresenter.DataRecord dr, global::System.Windows.Data.BindingBase binding)
			{
				this._cell = cell;
				this._bypassNotifications = true;
				try
				{
					base.DataContext = dr.DataItem;
					global::System.Windows.Markup.XmlLanguage languageHelper = this.GetLanguageHelper();
					if (languageHelper != null)
					{
						base.Language = languageHelper;
					}
					global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext.ValueProperty, binding);
					this._binding = binding;
				}
				catch (global::System.Exception innerException)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_6", new object[]
					{
						cell.Field.Name
					}), innerException);
				}
				finally
				{
					this._bypassNotifications = false;
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x0600042C RID: 1068 RVA: 0x0000F0C4 File Offset: 0x0000D2C4
			internal global::System.Windows.Data.BindingBase Binding
			{
				get
				{
					return this._binding;
				}
			}

			// Token: 0x0600042D RID: 1069 RVA: 0x0000F0CC File Offset: 0x0000D2CC
			internal global::System.Windows.Markup.XmlLanguage GetLanguageHelper()
			{
				global::System.Globalization.CultureInfo converterCultureResolved = this._cell.Field.ConverterCultureResolved;
				if (converterCultureResolved != null)
				{
					try
					{
						return global::System.Windows.Markup.XmlLanguage.GetLanguage(converterCultureResolved.IetfLanguageTag);
					}
					catch
					{
					}
				}
				return null;
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x0600042E RID: 1070 RVA: 0x0000F114 File Offset: 0x0000D314
			public global::Infragistics.Windows.DataPresenter.UnboundCell Cell
			{
				get
				{
					return this._cell;
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x0600042F RID: 1071 RVA: 0x0000F11C File Offset: 0x0000D31C
			public string DataError
			{
				get
				{
					if (this._dataErrorHolder == null)
					{
						this._dataErrorHolder = new global::Infragistics.Windows.DataPresenter.UnboundCell.DataErrorHolder(this);
					}
					return this._dataErrorHolder.DataError;
				}
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x0000F140 File Offset: 0x0000D340
			private static void OnValueChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext valueHolderWithDataContext = target as global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext;
				if (valueHolderWithDataContext != null && !valueHolderWithDataContext._bypassNotifications && valueHolderWithDataContext._cell != null)
				{
					valueHolderWithDataContext._cell.InternalOnValueChanged(e.OldValue, e.NewValue);
					if (valueHolderWithDataContext._dataErrorHolder != null)
					{
						valueHolderWithDataContext._dataErrorHolder.OnValueChanged();
					}
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000F193 File Offset: 0x0000D393
			// (set) Token: 0x06000432 RID: 1074 RVA: 0x0000F1A0 File Offset: 0x0000D3A0
			public object Value
			{
				get
				{
					return base.GetValue(global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext.ValueProperty);
				}
				set
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext.ValueProperty, value);
				}
			}

			// Token: 0x06000433 RID: 1075 RVA: 0x0000F1AE File Offset: 0x0000D3AE
			public void ClearBinding()
			{
				this._bypassNotifications = true;
				if (this._dataErrorHolder != null)
				{
					this._dataErrorHolder.OnBindingCleared();
				}
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext.ValueProperty);
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000F1D5 File Offset: 0x0000D3D5
			// (set) Token: 0x06000435 RID: 1077 RVA: 0x0000F1DD File Offset: 0x0000D3DD
			public bool Retain { get; set; }

			// Token: 0x04000118 RID: 280
			private global::Infragistics.Windows.DataPresenter.UnboundCell _cell;

			// Token: 0x04000119 RID: 281
			private bool _bypassNotifications;

			// Token: 0x0400011A RID: 282
			private global::System.Windows.Data.BindingBase _binding;

			// Token: 0x0400011B RID: 283
			private global::Infragistics.Windows.DataPresenter.UnboundCell.DataErrorHolder _dataErrorHolder;

			// Token: 0x0400011C RID: 284
			internal static readonly global::System.Windows.DependencyProperty ValueProperty = global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.ValueProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext.OnValueChanged)));
		}
	}
}
