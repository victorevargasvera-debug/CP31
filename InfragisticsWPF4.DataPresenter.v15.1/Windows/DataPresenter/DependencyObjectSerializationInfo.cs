using System;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001EE RID: 494
	internal class DependencyObjectSerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
	{
		// Token: 0x06001ECE RID: 7886 RVA: 0x000874B1 File Offset: 0x000856B1
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

		// Token: 0x06001ECF RID: 7887 RVA: 0x000874F3 File Offset: 0x000856F3
		private static global::Infragistics.Windows.Internal.PropertySerializationInfo[] CreateFromDependencyProperties(global::System.Windows.DependencyProperty[] dpProps)
		{
			return global::System.Array.ConvertAll<global::System.Windows.DependencyProperty, global::Infragistics.Windows.Internal.PropertySerializationInfo>(dpProps, (global::System.Windows.DependencyProperty source) => global::Infragistics.Windows.Internal.PropertySerializationInfo.Create(source));
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x00087518 File Offset: 0x00085718
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

		// Token: 0x06001ED1 RID: 7889 RVA: 0x0008753C File Offset: 0x0008573C
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

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00087594 File Offset: 0x00085794
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

		// Token: 0x04000D01 RID: 3329
		private global::System.Windows.DependencyProperty[] _dpProps;

		// Token: 0x04000D02 RID: 3330
		private global::System.Type _type;

		// Token: 0x04000D03 RID: 3331
		private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
	}
}
