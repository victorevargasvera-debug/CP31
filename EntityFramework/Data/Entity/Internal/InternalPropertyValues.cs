using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq.Expressions;

namespace System.Data.Entity.Internal
{
	// Token: 0x0200010B RID: 267
	internal abstract class InternalPropertyValues
	{
		// Token: 0x0600130B RID: 4875 RVA: 0x00031094 File Offset: 0x0002F294
		protected InternalPropertyValues(global::System.Data.Entity.Internal.InternalContext internalContext, global::System.Type type, bool isEntityValues)
		{
			this._internalContext = internalContext;
			this._type = type;
			this._isEntityValues = isEntityValues;
		}

		// Token: 0x0600130C RID: 4876
		protected abstract global::System.Data.Entity.Internal.IPropertyValuesItem GetItemImpl(string propertyName);

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x0600130D RID: 4877
		public abstract global::System.Collections.Generic.ISet<string> PropertyNames { get; }

		// Token: 0x0600130E RID: 4878 RVA: 0x000310B4 File Offset: 0x0002F2B4
		public object ToObject()
		{
			object obj = this.CreateObject();
			global::System.Collections.Generic.IDictionary<string, global::System.Action<object, object>> propertySetters = global::System.Data.Entity.Internal.DbHelpers.GetPropertySetters(this._type);
			foreach (string text in this.PropertyNames)
			{
				object obj2 = this.GetItem(text).Value;
				global::System.Data.Entity.Internal.InternalPropertyValues internalPropertyValues = obj2 as global::System.Data.Entity.Internal.InternalPropertyValues;
				if (internalPropertyValues != null)
				{
					obj2 = internalPropertyValues.ToObject();
				}
				global::System.Action<object, object> action;
				if (propertySetters.TryGetValue(text, out action))
				{
					action(obj, obj2);
				}
			}
			return obj;
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00031148 File Offset: 0x0002F348
		private object CreateObject()
		{
			if (this._isEntityValues)
			{
				return this._internalContext.CreateObject(this._type);
			}
			global::System.Func<object> func;
			if (!global::System.Data.Entity.Internal.InternalPropertyValues._nonEntityFactories.TryGetValue(this._type, out func))
			{
				func = global::System.Linq.Expressions.Expression.Lambda<global::System.Func<object>>(global::System.Linq.Expressions.Expression.New(this._type.GetDeclaredConstructor(new global::System.Type[0])), null).Compile();
				global::System.Data.Entity.Internal.InternalPropertyValues._nonEntityFactories.TryAdd(this._type, func);
			}
			return func();
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000311C0 File Offset: 0x0002F3C0
		public void SetValues(object value)
		{
			global::System.Collections.Generic.IDictionary<string, global::System.Func<object, object>> propertyGetters = global::System.Data.Entity.Internal.DbHelpers.GetPropertyGetters(value.GetType());
			foreach (string text in this.PropertyNames)
			{
				global::System.Func<object, object> func;
				if (propertyGetters.TryGetValue(text, out func))
				{
					object obj = func(value);
					global::System.Data.Entity.Internal.IPropertyValuesItem item = this.GetItem(text);
					if (obj == null && item.IsComplex)
					{
						throw global::System.Data.Entity.Resources.Error.DbPropertyValues_ComplexObjectCannotBeNull(text, this._type.Name);
					}
					global::System.Data.Entity.Internal.InternalPropertyValues internalPropertyValues = item.Value as global::System.Data.Entity.Internal.InternalPropertyValues;
					if (internalPropertyValues == null)
					{
						this.SetValue(item, obj);
					}
					else
					{
						internalPropertyValues.SetValues(obj);
					}
				}
			}
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00031278 File Offset: 0x0002F478
		public global::System.Data.Entity.Internal.InternalPropertyValues Clone()
		{
			return new global::System.Data.Entity.Internal.ClonedPropertyValues(this, null);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00031284 File Offset: 0x0002F484
		public void SetValues(global::System.Data.Entity.Internal.InternalPropertyValues values)
		{
			if (!this._type.IsAssignableFrom(values.ObjectType))
			{
				throw global::System.Data.Entity.Resources.Error.DbPropertyValues_AttemptToSetValuesFromWrongType(values.ObjectType.Name, this._type.Name);
			}
			foreach (string text in this.PropertyNames)
			{
				global::System.Data.Entity.Internal.IPropertyValuesItem item = values.GetItem(text);
				if (item.Value == null && item.IsComplex)
				{
					throw global::System.Data.Entity.Resources.Error.DbPropertyValues_NestedPropertyValuesNull(text, this._type.Name);
				}
				this[text] = item.Value;
			}
		}

		// Token: 0x170004D8 RID: 1240
		public object this[string propertyName]
		{
			get
			{
				return this.GetItem(propertyName).Value;
			}
			set
			{
				global::System.Data.Entity.Infrastructure.DbPropertyValues dbPropertyValues = value as global::System.Data.Entity.Infrastructure.DbPropertyValues;
				if (dbPropertyValues != null)
				{
					value = dbPropertyValues.InternalPropertyValues;
				}
				global::System.Data.Entity.Internal.IPropertyValuesItem item = this.GetItem(propertyName);
				global::System.Data.Entity.Internal.InternalPropertyValues internalPropertyValues = item.Value as global::System.Data.Entity.Internal.InternalPropertyValues;
				if (internalPropertyValues == null)
				{
					this.SetValue(item, value);
					return;
				}
				global::System.Data.Entity.Internal.InternalPropertyValues internalPropertyValues2 = value as global::System.Data.Entity.Internal.InternalPropertyValues;
				if (internalPropertyValues2 == null)
				{
					throw global::System.Data.Entity.Resources.Error.DbPropertyValues_AttemptToSetNonValuesOnComplexProperty();
				}
				internalPropertyValues.SetValues(internalPropertyValues2);
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00031396 File Offset: 0x0002F596
		public global::System.Data.Entity.Internal.IPropertyValuesItem GetItem(string propertyName)
		{
			if (!this.PropertyNames.Contains(propertyName))
			{
				throw global::System.Data.Entity.Resources.Error.DbPropertyValues_PropertyDoesNotExist(propertyName, this._type.Name);
			}
			return this.GetItemImpl(propertyName);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x000313C0 File Offset: 0x0002F5C0
		private void SetValue(global::System.Data.Entity.Internal.IPropertyValuesItem item, object newValue)
		{
			if (!global::System.Data.Entity.Internal.DbHelpers.PropertyValuesEqual(item.Value, newValue))
			{
				if (item.Value == null && item.IsComplex)
				{
					throw global::System.Data.Entity.Resources.Error.DbPropertyValues_NestedPropertyValuesNull(item.Name, this._type.Name);
				}
				if (newValue != null && !item.Type.IsAssignableFrom(newValue.GetType()))
				{
					throw global::System.Data.Entity.Resources.Error.DbPropertyValues_WrongTypeForAssignment(newValue.GetType().Name, item.Name, item.Type.Name, this._type.Name);
				}
				item.Value = newValue;
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x0003144C File Offset: 0x0002F64C
		public global::System.Type ObjectType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00031454 File Offset: 0x0002F654
		public global::System.Data.Entity.Internal.InternalContext InternalContext
		{
			get
			{
				return this._internalContext;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x0003145C File Offset: 0x0002F65C
		public bool IsEntityValues
		{
			get
			{
				return this._isEntityValues;
			}
		}

		// Token: 0x0400093D RID: 2365
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<object>> _nonEntityFactories = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<object>>();

		// Token: 0x0400093E RID: 2366
		private readonly global::System.Data.Entity.Internal.InternalContext _internalContext;

		// Token: 0x0400093F RID: 2367
		private readonly global::System.Type _type;

		// Token: 0x04000940 RID: 2368
		private readonly bool _isEntityValues;
	}
}
