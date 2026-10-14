using System;
using System.Collections.Generic;
using NLog.Common;
using NLog.Internal;

namespace NLog.Config
{
	// Token: 0x0200015F RID: 351
	internal class Factory<TBaseType, TAttributeType> : global::NLog.Config.INamedItemFactory<TBaseType, global::System.Type>, global::NLog.Config.IFactory where TBaseType : class where TAttributeType : global::NLog.Config.NameBaseAttribute
	{
		// Token: 0x06000F5D RID: 3933 RVA: 0x0002776F File Offset: 0x0002596F
		internal Factory(global::NLog.Config.ConfigurationItemFactory parentFactory)
		{
			this._parentFactory = parentFactory;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00027790 File Offset: 0x00025990
		public void ScanTypes(global::System.Type[] types, string prefix)
		{
			foreach (global::System.Type type in types)
			{
				try
				{
					this.RegisterType(type, prefix);
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Error(ex, "Failed to add type '{0}'.", new object[]
					{
						type.FullName
					});
					if (ex.MustBeRethrown())
					{
						throw;
					}
				}
			}
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x000277F4 File Offset: 0x000259F4
		public void RegisterType(global::System.Type type, string itemNamePrefix)
		{
			global::System.Collections.Generic.IEnumerable<TAttributeType> customAttributes = type.GetCustomAttributes(false);
			if (customAttributes != null)
			{
				foreach (TAttributeType tattributeType in customAttributes)
				{
					this.RegisterDefinition(itemNamePrefix + tattributeType.Name, type);
				}
			}
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00027858 File Offset: 0x00025A58
		public void RegisterNamedType(string itemName, string typeName)
		{
			this._items[itemName] = (() => global::System.Type.GetType(typeName, false));
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0002788A File Offset: 0x00025A8A
		public void Clear()
		{
			this._items.Clear();
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00027898 File Offset: 0x00025A98
		public void RegisterDefinition(string itemName, global::System.Type itemDefinition)
		{
			this._items[itemName] = (() => itemDefinition);
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x000278CC File Offset: 0x00025ACC
		public bool TryGetDefinition(string itemName, out global::System.Type result)
		{
			global::NLog.Config.Factory<TBaseType, TAttributeType>.GetTypeDelegate getTypeDelegate;
			if (!this._items.TryGetValue(itemName, out getTypeDelegate))
			{
				result = null;
				return false;
			}
			bool result2;
			try
			{
				result = getTypeDelegate();
				result2 = (result != null);
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrown())
				{
					throw;
				}
				result = null;
				result2 = false;
			}
			return result2;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00027924 File Offset: 0x00025B24
		public virtual bool TryCreateInstance(string itemName, out TBaseType result)
		{
			global::System.Type itemType;
			if (!this.TryGetDefinition(itemName, out itemType))
			{
				result = default(TBaseType);
				return false;
			}
			result = (TBaseType)((object)this._parentFactory.CreateInstance(itemType));
			return true;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00027964 File Offset: 0x00025B64
		public virtual TBaseType CreateInstance(string name)
		{
			TBaseType result;
			if (this.TryCreateInstance(name, out result))
			{
				return result;
			}
			string text = typeof(TBaseType).Name + " cannot be found: '" + name + "'";
			if (name != null && (name.StartsWith("aspnet", global::System.StringComparison.OrdinalIgnoreCase) || name.StartsWith("iis", global::System.StringComparison.OrdinalIgnoreCase)))
			{
				text += ". Is NLog.Web not included?";
			}
			throw new global::System.ArgumentException(text);
		}

		// Token: 0x0400044E RID: 1102
		private readonly global::System.Collections.Generic.Dictionary<string, global::NLog.Config.Factory<TBaseType, TAttributeType>.GetTypeDelegate> _items = new global::System.Collections.Generic.Dictionary<string, global::NLog.Config.Factory<TBaseType, TAttributeType>.GetTypeDelegate>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400044F RID: 1103
		private readonly global::NLog.Config.ConfigurationItemFactory _parentFactory;

		// Token: 0x02000234 RID: 564
		// (Invoke) Token: 0x06001388 RID: 5000
		private delegate global::System.Type GetTypeDelegate();
	}
}
