using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000200 RID: 512
	internal class ReflectionSerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
	{
		// Token: 0x06001F69 RID: 8041 RVA: 0x00088E74 File Offset: 0x00087074
		public ReflectionSerializationInfo(global::System.Type type, global::System.Func<object> objectCreator, bool serializeDefaultValues = false)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(type);
			this._type = type;
			this._objectCreator = objectCreator;
			this._serializeDefaultValues = serializeDefaultValues;
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x00088EC4 File Offset: 0x000870C4
		public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
		{
			get
			{
				global::System.Reflection.PropertyInfo[] properties = this._type.GetProperties();
				return from ii in properties
				where ii.CanRead && ii.CanWrite && !global::Infragistics.CoreUtilities.HasItems(ii.GetIndexParameters())
				select new global::Infragistics.Windows.DataPresenter.ReflectionSerializationInfo.ReflectionPropertySerializationInfo(ii);
			}
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00088F22 File Offset: 0x00087122
		private bool ShouldSerialize(global::Infragistics.Windows.DataPresenter.ReflectionSerializationInfo.ReflectionPropertySerializationInfo property, object value)
		{
			return this._serializeDefaultValues || value != null;
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00088F34 File Offset: 0x00087134
		public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = null;
			foreach (global::Infragistics.Windows.Internal.PropertySerializationInfo propertySerializationInfo in this.SerializedProperties)
			{
				global::Infragistics.Windows.DataPresenter.ReflectionSerializationInfo.ReflectionPropertySerializationInfo reflectionPropertySerializationInfo = (global::Infragistics.Windows.DataPresenter.ReflectionSerializationInfo.ReflectionPropertySerializationInfo)propertySerializationInfo;
				object value = reflectionPropertySerializationInfo._prop.GetValue(obj, null);
				if (this.ShouldSerialize(reflectionPropertySerializationInfo, value))
				{
					dictionary = global::Infragistics.Windows.DataPresenter.ScheduleUtilities.AddEntryHelper<string, object>(dictionary, reflectionPropertySerializationInfo.Name, value);
				}
			}
			return dictionary;
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00088FA8 File Offset: 0x000871A8
		public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> values)
		{
			object obj = this._objectCreator();
			foreach (global::Infragistics.Windows.Internal.PropertySerializationInfo propertySerializationInfo in this.SerializedProperties)
			{
				global::Infragistics.Windows.DataPresenter.ReflectionSerializationInfo.ReflectionPropertySerializationInfo reflectionPropertySerializationInfo = (global::Infragistics.Windows.DataPresenter.ReflectionSerializationInfo.ReflectionPropertySerializationInfo)propertySerializationInfo;
				object value;
				if (values.TryGetValue(reflectionPropertySerializationInfo.Name, out value))
				{
					reflectionPropertySerializationInfo._prop.SetValue(obj, value, null);
				}
			}
			return obj;
		}

		// Token: 0x04000D35 RID: 3381
		private global::System.Type _type;

		// Token: 0x04000D36 RID: 3382
		private global::System.Func<object> _objectCreator;

		// Token: 0x04000D37 RID: 3383
		private bool _serializeDefaultValues;

		// Token: 0x02000201 RID: 513
		internal class ReflectionPropertySerializationInfo : global::Infragistics.Windows.Internal.PropertySerializationInfo
		{
			// Token: 0x06001F70 RID: 8048 RVA: 0x00089020 File Offset: 0x00087220
			internal ReflectionPropertySerializationInfo(global::System.Reflection.PropertyInfo prop) : base(prop.PropertyType, prop.Name)
			{
				this._prop = prop;
			}

			// Token: 0x04000D3A RID: 3386
			internal global::System.Reflection.PropertyInfo _prop;
		}
	}
}
