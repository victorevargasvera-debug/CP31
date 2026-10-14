using System;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C7 RID: 455
	internal class DependencyObjectSerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
	{
		// Token: 0x06001ABC RID: 6844 RVA: 0x0007379C File Offset: 0x0007199C
		internal DependencyObjectSerializationInfo(global::System.Type type, global::System.Windows.DependencyProperty[] dpProps)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(type);
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dpProps);
			if (!typeof(global::System.Windows.DependencyObject).IsAssignableFrom(type))
			{
				throw new global::System.ArgumentException();
			}
			this._type = type;
			this._dpProps = dpProps;
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x000737DE File Offset: 0x000719DE
		private static global::Infragistics.Windows.Internal.PropertySerializationInfo[] CreateFromDependencyProperties(global::System.Windows.DependencyProperty[] dpProps)
		{
			return global::System.Array.ConvertAll<global::System.Windows.DependencyProperty, global::Infragistics.Windows.Internal.PropertySerializationInfo>(dpProps, (global::System.Windows.DependencyProperty source) => global::Infragistics.Windows.Internal.PropertySerializationInfo.Create(source));
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x00073803 File Offset: 0x00071A03
		public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
		{
			get
			{
				if (this._props == null)
				{
					this._props = global::Infragistics.Windows.DataPresenter.DependencyObjectSerializationInfo.CreateFromDependencyProperties(this._dpProps);
				}
				return this._props;
			}
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x00073824 File Offset: 0x00071A24
		public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
		{
			global::System.Windows.DependencyObject dependencyObject = (global::System.Windows.DependencyObject)global::System.Activator.CreateInstance(this._type);
			foreach (global::System.Windows.DependencyProperty dependencyProperty in this._dpProps)
			{
				object value;
				if (values.TryGetValue(dependencyProperty.Name, out value))
				{
					dependencyObject.SetValue(dependencyProperty, value);
				}
			}
			return dependencyObject;
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x0007387C File Offset: 0x00071A7C
		public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
		{
			global::System.Windows.DependencyObject dependencyObject = (global::System.Windows.DependencyObject)obj;
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			foreach (global::System.Windows.DependencyProperty dependencyProperty in this._dpProps)
			{
				if (global::Infragistics.Windows.Utilities.ShouldSerialize(dependencyProperty, dependencyObject))
				{
					dictionary[dependencyProperty.Name] = dependencyObject.GetValue(dependencyProperty);
				}
			}
			return dictionary;
		}

		// Token: 0x04000B15 RID: 2837
		private global::System.Windows.DependencyProperty[] _dpProps;

		// Token: 0x04000B16 RID: 2838
		private global::System.Type _type;

		// Token: 0x04000B17 RID: 2839
		private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
	}
}
