using System;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200004E RID: 78
	public class UnboundCell : global::Infragistics.Windows.DataPresenter.Cell
	{
		// Token: 0x060003DA RID: 986 RVA: 0x0000DC4F File Offset: 0x0000BE4F
		internal UnboundCell(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field) : base(record, field)
		{
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000DC5C File Offset: 0x0000BE5C
		internal override void CloneAssociatedCellSettings(global::Infragistics.Windows.DataPresenter.Cell associatedCell)
		{
			base.CloneAssociatedCellSettings(associatedCell);
			global::Infragistics.Windows.DataPresenter.UnboundCell unboundCell = associatedCell as global::Infragistics.Windows.DataPresenter.UnboundCell;
			if (unboundCell != null)
			{
				this._unboundData = unboundCell._unboundData;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0000DC86 File Offset: 0x0000BE86
		internal override bool HasCloneableSettings
		{
			get
			{
				return this._unboundData != null || base.HasCloneableSettings;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0000DC98 File Offset: 0x0000BE98
		public override bool IsUnbound
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000DC9B File Offset: 0x0000BE9B
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

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0000DCB8 File Offset: 0x0000BEB8
		internal bool MaintainBindings
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.UnboundField unboundField = base.Field as global::Infragistics.Windows.DataPresenter.UnboundField;
				return (unboundField != null && global::Infragistics.Windows.DataPresenter.BindingRetentionMode.Retain == unboundField.BindingRetentionMode) || (this._valueHolder != null && this._valueHolder.Retain) || (!global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider.HasPropertyDescriptorFor(this) && global::Infragistics.Windows.DataPresenter.SummaryResultCollection.HasSummaryDependentOn(this, false)) || base.HasListeners || base.GetAssociatedCellValuePresenter(false) != null;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0000DD20 File Offset: 0x0000BF20
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0000DD3C File Offset: 0x0000BF3C
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
				global::System.Windows.Data.BindingExpression bindingExpression = null;
				if (this._valueHolder != null)
				{
					bool flag = true;
					global::Infragistics.Windows.DataPresenter.UnboundField unboundField = base.Field as global::Infragistics.Windows.DataPresenter.UnboundField;
					if (unboundField != null && unboundField.IsBoundToRootProperty)
					{
						global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
						if (record != null && !record.IsAddRecord && record.DataItem != null)
						{
							bindingExpression = global::System.Windows.Data.BindingOperations.GetBindingExpression(this._valueHolder as global::System.Windows.DependencyObject, global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.ValueProperty);
							if (bindingExpression != null && global::Infragistics.Windows.DataPresenter.GridUtilities.AreEqual(bindingExpression.DataItem, record.DataItem) && !bindingExpression.HasError && bindingExpression.ParentBinding != null)
							{
								global::System.Windows.Data.BindingMode mode = bindingExpression.ParentBinding.Mode;
								if (mode == global::System.Windows.Data.BindingMode.TwoWay || mode == global::System.Windows.Data.BindingMode.OneWayToSource)
								{
									record.BeginEdit();
								}
								else
								{
									flag = false;
								}
							}
						}
					}
					this._valueHolder.Value = value;
					if (!flag && global::System.Windows.Data.BindingOperations.GetBindingExpression(this._valueHolder as global::System.Windows.DependencyObject, global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.ValueProperty) == null)
					{
						this._valueHolder.Retain = true;
						return;
					}
					if (!this.MaintainBindings)
					{
						this.ClearValueHolder();
						return;
					}
					if (this._valueHolder != null)
					{
						if (bindingExpression == null)
						{
							bindingExpression = global::System.Windows.Data.BindingOperations.GetBindingExpression(this._valueHolder as global::System.Windows.DependencyObject, global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.ValueProperty);
						}
						if (bindingExpression != null && bindingExpression.Status == global::System.Windows.Data.BindingStatus.Active)
						{
							bindingExpression.UpdateTarget();
							return;
						}
					}
				}
				else
				{
					this._unboundData = value;
					this.InternalOnValueChanged(value2, value);
				}
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000DE84 File Offset: 0x0000C084
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
			record.FireInitializeRecord(true, field.SortStatus != global::Infragistics.Windows.Controls.SortStatus.NotSorted);
			global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = base.AssociatedCellValuePresenter;
			if (associatedCellValuePresenter != null)
			{
				associatedCellValuePresenter.SetValueInternal(this.ConvertedValue, false);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000DF02 File Offset: 0x0000C102
		internal void RefreshBindings()
		{
			this.ClearValueHolder();
			this.VerifyBindingStatus();
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000DF10 File Offset: 0x0000C110
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

		// Token: 0x060003E5 RID: 997 RVA: 0x0000DF41 File Offset: 0x0000C141
		internal void ClearValueHolder()
		{
			if (this._valueHolder != null)
			{
				this._valueHolder.ClearBinding();
				this._valueHolder = null;
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0000DF60 File Offset: 0x0000C160
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

		// Token: 0x060003E7 RID: 999 RVA: 0x0000DFBC File Offset: 0x0000C1BC
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

		// Token: 0x060003E8 RID: 1000 RVA: 0x0000E014 File Offset: 0x0000C214
		private void VerifyBindingStatus()
		{
			global::Infragistics.Windows.DataPresenter.UnboundField unboundField = base.Field as global::Infragistics.Windows.DataPresenter.UnboundField;
			if (unboundField == null)
			{
				return;
			}
			global::System.Windows.PropertyPath bindingPath = unboundField.BindingPath;
			global::System.Windows.Data.BindingBase binding = unboundField.Binding;
			global::Infragistics.Windows.DataPresenter.DataRecord record = base.Record;
			if ((bindingPath == null && binding == null) || record.IsAddRecordTemplate)
			{
				this.ClearValueHolder();
				return;
			}
			global::System.Windows.Data.BindingMode bindingMode = unboundField.BindingMode;
			if (this._valueHolder != null)
			{
				if (this.IsSameBinding(record, binding, bindingPath, bindingMode))
				{
					return;
				}
				this.ClearValueHolder();
			}
			if (record != null)
			{
				if (binding != null)
				{
					this._valueHolder = new global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext(this, record, binding);
					return;
				}
				this._valueHolder = new global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder(this, record, bindingPath, bindingMode);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x0000E0A4 File Offset: 0x0000C2A4
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

		// Token: 0x040000F3 RID: 243
		private object _unboundData;

		// Token: 0x040000F4 RID: 244
		private global::Infragistics.Windows.DataPresenter.UnboundCell.IValueHolder _valueHolder;

		// Token: 0x0200004F RID: 79
		private interface IValueHolder
		{
			// Token: 0x060003EA RID: 1002
			void ClearBinding();

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x060003EB RID: 1003
			// (set) Token: 0x060003EC RID: 1004
			object Value { get; set; }

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x060003ED RID: 1005
			string DataError { get; }

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x060003EE RID: 1006
			global::Infragistics.Windows.DataPresenter.UnboundCell Cell { get; }

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x060003EF RID: 1007
			// (set) Token: 0x060003F0 RID: 1008
			bool Retain { get; set; }
		}

		// Token: 0x02000050 RID: 80
		private class DataErrorHolder
		{
			// Token: 0x060003F2 RID: 1010 RVA: 0x0000E0D9 File Offset: 0x0000C2D9
			internal DataErrorHolder(global::Infragistics.Windows.DataPresenter.UnboundCell.IValueHolder holder)
			{
				this._holder = holder;
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x060003F3 RID: 1011 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
			public string DataError
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.GridUtilities.GetValidationErrorText(global::System.Windows.Controls.Validation.GetErrors((global::System.Windows.DependencyObject)this._holder));
				}
			}

			// Token: 0x060003F4 RID: 1012 RVA: 0x0000E10C File Offset: 0x0000C30C
			internal void OnBindingCleared()
			{
				this._errorsPvt = null;
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x0000E118 File Offset: 0x0000C318
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

			// Token: 0x060003F6 RID: 1014 RVA: 0x0000E170 File Offset: 0x0000C370
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

			// Token: 0x060003F7 RID: 1015 RVA: 0x0000E1A6 File Offset: 0x0000C3A6
			internal void OnValueChanged()
			{
				if (this._errorsPvt == null)
				{
					this._errorsPvt = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._holder, "(Validation.Errors).Count", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnErrorsChanged));
				}
			}

			// Token: 0x040000F5 RID: 245
			private global::Infragistics.Windows.DataPresenter.UnboundCell.IValueHolder _holder;

			// Token: 0x040000F6 RID: 246
			private global::Infragistics.Windows.Internal.PropertyValueTracker _errorsPvt;

			// Token: 0x040000F7 RID: 247
			internal static readonly global::System.Reflection.PropertyInfo g_binding_ValidatesOnDataErrorsProperty = typeof(global::System.Windows.Data.Binding).GetProperty("ValidatesOnDataErrors");
		}

		// Token: 0x02000051 RID: 81
		private class ValueHolder : global::System.Windows.DependencyObject, global::Infragistics.Windows.DataPresenter.UnboundCell.IValueHolder
		{
			// Token: 0x060003F8 RID: 1016 RVA: 0x0000E1D4 File Offset: 0x0000C3D4
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

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0000E29C File Offset: 0x0000C49C
			public global::Infragistics.Windows.DataPresenter.UnboundCell Cell
			{
				get
				{
					return this._cell;
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x060003FA RID: 1018 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
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

			// Token: 0x060003FB RID: 1019 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
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

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x060003FC RID: 1020 RVA: 0x0000E31B File Offset: 0x0000C51B
			// (set) Token: 0x060003FD RID: 1021 RVA: 0x0000E328 File Offset: 0x0000C528
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

			// Token: 0x060003FE RID: 1022 RVA: 0x0000E338 File Offset: 0x0000C538
			internal bool IsSameBinding(global::Infragistics.Windows.DataPresenter.UnboundCell cell, global::Infragistics.Windows.DataPresenter.DataRecord dr, global::System.Windows.PropertyPath bindingPath, global::System.Windows.Data.BindingMode mode)
			{
				if (this._cell != cell || dr == null)
				{
					return false;
				}
				global::System.Windows.Data.Binding binding = this._binding;
				return binding != null && (binding.Path == bindingPath && binding.Mode == mode && binding.Source == dr.DataItem && this._dataErrorSupportEnabled == global::Infragistics.Windows.DataPresenter.UnboundCell.DataErrorHolder.EnableDataErrorSupportHelper(cell, null)) && binding.ConverterCulture == cell.Field.ConverterCultureResolved;
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x0000E3A4 File Offset: 0x0000C5A4
			public void ClearBinding()
			{
				this._bypassNotifications = true;
				if (this._dataErrorHolder != null)
				{
					this._dataErrorHolder.OnBindingCleared();
				}
				global::System.Windows.Data.BindingOperations.ClearAllBindings(this);
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000E3C6 File Offset: 0x0000C5C6
			// (set) Token: 0x06000401 RID: 1025 RVA: 0x0000E3CE File Offset: 0x0000C5CE
			public bool Retain { get; set; }

			// Token: 0x040000F8 RID: 248
			private global::Infragistics.Windows.DataPresenter.UnboundCell _cell;

			// Token: 0x040000F9 RID: 249
			private bool _bypassNotifications;

			// Token: 0x040000FA RID: 250
			private global::System.Windows.Data.Binding _binding;

			// Token: 0x040000FB RID: 251
			private global::Infragistics.Windows.DataPresenter.UnboundCell.DataErrorHolder _dataErrorHolder;

			// Token: 0x040000FC RID: 252
			private bool _dataErrorSupportEnabled;

			// Token: 0x040000FD RID: 253
			internal static readonly global::System.Windows.DependencyProperty ValueProperty = global::System.Windows.DependencyProperty.Register("Value", typeof(object), typeof(global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.OnValueChanged)));
		}

		// Token: 0x02000052 RID: 82
		private class ValueHolderWithDataContext : global::System.Windows.FrameworkContentElement, global::Infragistics.Windows.DataPresenter.UnboundCell.IValueHolder
		{
			// Token: 0x06000403 RID: 1027 RVA: 0x0000E410 File Offset: 0x0000C610
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

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000404 RID: 1028 RVA: 0x0000E4B4 File Offset: 0x0000C6B4
			internal global::System.Windows.Data.BindingBase Binding
			{
				get
				{
					return this._binding;
				}
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x0000E4BC File Offset: 0x0000C6BC
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

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000406 RID: 1030 RVA: 0x0000E504 File Offset: 0x0000C704
			public global::Infragistics.Windows.DataPresenter.UnboundCell Cell
			{
				get
				{
					return this._cell;
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000407 RID: 1031 RVA: 0x0000E50C File Offset: 0x0000C70C
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

			// Token: 0x06000408 RID: 1032 RVA: 0x0000E530 File Offset: 0x0000C730
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

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000E583 File Offset: 0x0000C783
			// (set) Token: 0x0600040A RID: 1034 RVA: 0x0000E590 File Offset: 0x0000C790
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

			// Token: 0x0600040B RID: 1035 RVA: 0x0000E59E File Offset: 0x0000C79E
			public void ClearBinding()
			{
				this._bypassNotifications = true;
				if (this._dataErrorHolder != null)
				{
					this._dataErrorHolder.OnBindingCleared();
				}
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext.ValueProperty);
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x0600040C RID: 1036 RVA: 0x0000E5C5 File Offset: 0x0000C7C5
			// (set) Token: 0x0600040D RID: 1037 RVA: 0x0000E5CD File Offset: 0x0000C7CD
			public bool Retain { get; set; }

			// Token: 0x040000FF RID: 255
			private global::Infragistics.Windows.DataPresenter.UnboundCell _cell;

			// Token: 0x04000100 RID: 256
			private bool _bypassNotifications;

			// Token: 0x04000101 RID: 257
			private global::System.Windows.Data.BindingBase _binding;

			// Token: 0x04000102 RID: 258
			private global::Infragistics.Windows.DataPresenter.UnboundCell.DataErrorHolder _dataErrorHolder;

			// Token: 0x04000103 RID: 259
			internal static readonly global::System.Windows.DependencyProperty ValueProperty = global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolder.ValueProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.UnboundCell.ValueHolderWithDataContext.OnValueChanged)));
		}
	}
}
