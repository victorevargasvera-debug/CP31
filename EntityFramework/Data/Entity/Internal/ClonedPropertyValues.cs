using System;
using System.Collections.Generic;
using System.Data.Common;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000FF RID: 255
	internal class ClonedPropertyValues : global::System.Data.Entity.Internal.InternalPropertyValues
	{
		// Token: 0x0600127E RID: 4734 RVA: 0x0002F810 File Offset: 0x0002DA10
		internal ClonedPropertyValues(global::System.Data.Entity.Internal.InternalPropertyValues original, global::System.Data.Common.DbDataRecord valuesRecord = null) : base(original.InternalContext, original.ObjectType, original.IsEntityValues)
		{
			this._propertyNames = original.PropertyNames;
			this._propertyValues = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Internal.ClonedPropertyValuesItem>(this._propertyNames.Count);
			foreach (string text in this._propertyNames)
			{
				global::System.Data.Entity.Internal.IPropertyValuesItem item = original.GetItem(text);
				object obj = item.Value;
				global::System.Data.Entity.Internal.InternalPropertyValues internalPropertyValues = obj as global::System.Data.Entity.Internal.InternalPropertyValues;
				if (internalPropertyValues != null)
				{
					global::System.Data.Common.DbDataRecord valuesRecord2 = (valuesRecord == null) ? null : ((global::System.Data.Common.DbDataRecord)valuesRecord[text]);
					obj = new global::System.Data.Entity.Internal.ClonedPropertyValues(internalPropertyValues, valuesRecord2);
				}
				else if (valuesRecord != null)
				{
					obj = valuesRecord[text];
					if (obj == global::System.DBNull.Value)
					{
						obj = null;
					}
				}
				this._propertyValues[text] = new global::System.Data.Entity.Internal.ClonedPropertyValuesItem(text, obj, item.Type, item.IsComplex);
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0002F900 File Offset: 0x0002DB00
		protected override global::System.Data.Entity.Internal.IPropertyValuesItem GetItemImpl(string propertyName)
		{
			return this._propertyValues[propertyName];
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x0002F90E File Offset: 0x0002DB0E
		public override global::System.Collections.Generic.ISet<string> PropertyNames
		{
			get
			{
				return this._propertyNames;
			}
		}

		// Token: 0x04000920 RID: 2336
		private readonly global::System.Collections.Generic.ISet<string> _propertyNames;

		// Token: 0x04000921 RID: 2337
		private readonly global::System.Collections.Generic.IDictionary<string, global::System.Data.Entity.Internal.ClonedPropertyValuesItem> _propertyValues;
	}
}
