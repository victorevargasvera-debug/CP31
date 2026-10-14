using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000054 RID: 84
	public class CellBinding : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0000F21B File Offset: 0x0000D41B
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0000F223 File Offset: 0x0000D423
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Data.BindingBase Binding
		{
			get
			{
				return this._binding;
			}
			set
			{
				if (value != this._binding)
				{
					this._binding = value;
					this.OnPropertyChanged("Binding");
				}
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0000F240 File Offset: 0x0000D440
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0000F248 File Offset: 0x0000D448
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.DefaultValue(null)]
		public string Property
		{
			get
			{
				return this._property;
			}
			set
			{
				if (value != this._property)
				{
					global::Infragistics.Windows.DataPresenter.CellBinding.ValidateProperty(this._target, value);
					this._property = value;
					this.OnPropertyChanged("Property");
				}
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0000F276 File Offset: 0x0000D476
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x0000F27E File Offset: 0x0000D47E
		[global::System.ComponentModel.DefaultValue(global::Infragistics.Windows.DataPresenter.CellBindingTarget.Editor)]
		[global::System.ComponentModel.Bindable(false)]
		public global::Infragistics.Windows.DataPresenter.CellBindingTarget Target
		{
			get
			{
				return this._target;
			}
			set
			{
				if (value != this._target)
				{
					global::Infragistics.CoreUtilities.ValidateEnum(typeof(global::Infragistics.Windows.DataPresenter.CellBindingTarget), value);
					global::Infragistics.Windows.DataPresenter.CellBinding.ValidateProperty(value, this._property);
					this._target = value;
					this.OnPropertyChanged("Target");
				}
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		internal void ApplyBinding(global::System.Windows.FrameworkElement element)
		{
			global::System.Windows.DependencyProperty dp = this.GetDp(element);
			if (dp != null && this._binding != null)
			{
				element.SetBinding(dp, this._binding);
			}
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000F2EC File Offset: 0x0000D4EC
		internal void ClearBinding(global::System.Windows.FrameworkElement element)
		{
			global::System.Windows.DependencyProperty dp = this.GetDp(element);
			if (dp != null)
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(element, dp);
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000F30C File Offset: 0x0000D50C
		internal global::Infragistics.Windows.DataPresenter.CellBinding Clone()
		{
			return new global::Infragistics.Windows.DataPresenter.CellBinding
			{
				_binding = this._binding,
				_property = this._property,
				_propertyDp = this._propertyDp,
				_target = this._target
			};
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000F350 File Offset: 0x0000D550
		internal global::System.Windows.DependencyProperty GetDp(global::System.Windows.FrameworkElement element)
		{
			if (this._propertyDp == null)
			{
				if (!string.IsNullOrEmpty(this._property))
				{
					foreach (object obj in global::System.ComponentModel.TypeDescriptor.GetProperties(element.GetType()))
					{
						global::System.ComponentModel.PropertyDescriptor propertyDescriptor = (global::System.ComponentModel.PropertyDescriptor)obj;
						if (propertyDescriptor.Name == this._property)
						{
							global::System.ComponentModel.DependencyPropertyDescriptor dependencyPropertyDescriptor = global::System.ComponentModel.DependencyPropertyDescriptor.FromProperty(propertyDescriptor);
							if (dependencyPropertyDescriptor != null)
							{
								this._propertyDp = dependencyPropertyDescriptor.DependencyProperty;
								return this._propertyDp;
							}
							this.LogError(string.Format("Property '{0}' specified on CellBinding is not a DependencyProperty on target '{1}'", this._property, this._target));
						}
					}
					this.LogError(string.Format("Property '{0}' specified on CellBinding was not found on target '{1}'", this._property, this._target));
				}
				else
				{
					this.LogError("Property not specified on CellBinding");
				}
			}
			if (this._binding == null)
			{
				this.LogError(string.Format("No Binding was specified on CellBinding for property '{0}' on target '{1}'", this._property, this._target));
			}
			return this._propertyDp;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000F47C File Offset: 0x0000D67C
		private void LogError(string message)
		{
			if (this._wasErrorLogged)
			{
				this._wasErrorLogged = true;
				global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerError(message);
			}
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000F494 File Offset: 0x0000D694
		private static void ValidateProperty(global::Infragistics.Windows.DataPresenter.CellBindingTarget target, string property)
		{
			bool flag = true;
			if (property != null)
			{
				if (!(property == "Value"))
				{
					if (property == "Text")
					{
						flag = (target != global::Infragistics.Windows.DataPresenter.CellBindingTarget.Editor);
					}
				}
				else
				{
					flag = false;
				}
			}
			if (!flag)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_15", new object[]
				{
					property,
					target
				}));
			}
		}

		// Token: 0x0400011E RID: 286
		private global::System.Windows.Data.BindingBase _binding;

		// Token: 0x0400011F RID: 287
		private string _property;

		// Token: 0x04000120 RID: 288
		private global::System.Windows.DependencyProperty _propertyDp;

		// Token: 0x04000121 RID: 289
		private bool _wasErrorLogged;

		// Token: 0x04000122 RID: 290
		private global::Infragistics.Windows.DataPresenter.CellBindingTarget _target;
	}
}
