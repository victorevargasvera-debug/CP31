using System;
using System.Collections.Generic;

namespace Infragistics.Windows.Internal
{
	// Token: 0x020001B6 RID: 438
	internal class ObjectWrapper
	{
		// Token: 0x06000EAF RID: 3759 RVA: 0x0002F666 File Offset: 0x0002D866
		public ObjectWrapper(object value)
		{
			this.Value = value;
		}

		// Token: 0x04000806 RID: 2054
		internal readonly object Value;

		// Token: 0x020001B7 RID: 439
		internal class SerializationInfo : global::Infragistics.Windows.Internal.ObjectSerializationInfo
		{
			// Token: 0x06000EB0 RID: 3760 RVA: 0x0002F678 File Offset: 0x0002D878
			public SerializationInfo()
			{
				this._props = new global::Infragistics.Windows.Internal.PropertySerializationInfo[]
				{
					new global::Infragistics.Windows.Internal.PropertySerializationInfo(typeof(object), "Value")
				};
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0002F6B0 File Offset: 0x0002D8B0
			public override global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Internal.PropertySerializationInfo> SerializedProperties
			{
				get
				{
					return this._props;
				}
			}

			// Token: 0x06000EB2 RID: 3762 RVA: 0x0002F6B8 File Offset: 0x0002D8B8
			public override global::System.Collections.Generic.Dictionary<string, object> Serialize(object obj)
			{
				global::Infragistics.Windows.Internal.ObjectWrapper objectWrapper = (global::Infragistics.Windows.Internal.ObjectWrapper)obj;
				global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
				dictionary["Value"] = objectWrapper.Value;
				return dictionary;
			}

			// Token: 0x06000EB3 RID: 3763 RVA: 0x0002F6E4 File Offset: 0x0002D8E4
			public override object Deserialize(global::System.Collections.Generic.Dictionary<string, object> obj)
			{
				object value;
				if (obj.TryGetValue("Value", out value))
				{
					return new global::Infragistics.Windows.Internal.ObjectWrapper(value);
				}
				return null;
			}

			// Token: 0x04000807 RID: 2055
			private const string ValueProperty = "Value";

			// Token: 0x04000808 RID: 2056
			private global::Infragistics.Windows.Internal.PropertySerializationInfo[] _props;
		}
	}
}
