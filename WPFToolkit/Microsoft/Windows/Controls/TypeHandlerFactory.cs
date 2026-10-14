using System;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200002A RID: 42
	internal abstract class TypeHandlerFactory<TypeHandler>
	{
		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000095F8 File Offset: 0x000077F8
		public global::System.Collections.Generic.ICollection<TypeHandler> Handlers
		{
			get
			{
				this.InitializeIfNecessary();
				return this.handlers;
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00009608 File Offset: 0x00007808
		protected TypeHandler GetHandler(global::System.Type type)
		{
			TypeHandler typeHandler;
			if (!this.GetCachedHandler(type, out typeHandler))
			{
				typeHandler = this.DetermineBestHandler(this.GetDefaultHandler(type), type);
				this.CacheHandler(type, typeHandler);
			}
			return typeHandler;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00009638 File Offset: 0x00007838
		protected bool GetCachedHandler(global::System.Type type, out TypeHandler handler)
		{
			this.InitializeIfNecessary();
			return this.handlerCache.TryGetValue(type, out handler);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000964D File Offset: 0x0000784D
		protected void CacheHandler(global::System.Type type, TypeHandler handler)
		{
			this.InitializeIfNecessary();
			this.handlerCache[type] = handler;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00009664 File Offset: 0x00007864
		protected TypeHandler DetermineBestHandler(TypeHandler handler, global::System.Type type)
		{
			this.InitializeIfNecessary();
			global::System.Type type2 = typeof(object);
			global::System.Type c = typeof(object);
			foreach (TypeHandler typeHandler in this.handlers)
			{
				global::System.Type baseType = this.GetBaseType(typeHandler);
				if ((baseType.IsAssignableFrom(type) || (baseType.IsGenericTypeDefinition && global::Microsoft.Windows.Controls.TypeHandlerFactory<TypeHandler>.IsGenericTypeDefinitionOf(baseType, type))) && (type2.IsAssignableFrom(baseType) || (baseType.IsInterface && !baseType.IsAssignableFrom(c))))
				{
					handler = typeHandler;
					type2 = baseType;
					c = global::Microsoft.Windows.Controls.TypeHandlerFactory<TypeHandler>.GetImplementingType(baseType, type);
				}
			}
			return handler;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00009718 File Offset: 0x00007918
		protected static global::System.Type GetImplementingType(global::System.Type baseType, global::System.Type targetType)
		{
			if (!baseType.IsInterface && baseType.IsAssignableFrom(targetType))
			{
				return baseType;
			}
			global::System.Type type = targetType;
			while (type.BaseType != null && global::Microsoft.Windows.Controls.TypeHandlerFactory<TypeHandler>.DoesTypeImplement(baseType, type.BaseType))
			{
				type = type.BaseType;
			}
			return type;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000975A File Offset: 0x0000795A
		private static bool DoesTypeImplement(global::System.Type baseType, global::System.Type targetType)
		{
			return baseType.IsAssignableFrom(targetType) || (baseType.IsGenericTypeDefinition && global::Microsoft.Windows.Controls.TypeHandlerFactory<TypeHandler>.IsGenericTypeDefinitionOf(baseType, targetType));
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00009778 File Offset: 0x00007978
		private static bool IsGenericTypeDefinitionOf(global::System.Type baseDefinition, global::System.Type targetType)
		{
			while (targetType != null)
			{
				global::System.Type genericTypeDefinition = global::Microsoft.Windows.Controls.TypeHandlerFactory<TypeHandler>.GetGenericTypeDefinition(targetType);
				if (genericTypeDefinition != null && baseDefinition.IsAssignableFrom(genericTypeDefinition))
				{
					return true;
				}
				targetType = targetType.BaseType;
			}
			return false;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000097A8 File Offset: 0x000079A8
		private static global::System.Type GetGenericTypeDefinition(global::System.Type type)
		{
			try
			{
				if (type.IsGenericType)
				{
					return type.GetGenericTypeDefinition();
				}
			}
			catch (global::System.InvalidOperationException)
			{
			}
			catch (global::System.NotSupportedException)
			{
			}
			catch (global::System.InvalidCastException)
			{
			}
			catch (global::System.NullReferenceException)
			{
			}
			catch (global::System.Security.SecurityException)
			{
			}
			return null;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000981C File Offset: 0x00007A1C
		protected void RegisterHandler(TypeHandler handler)
		{
			this.InitializeIfNecessary();
			this.handlers.Add(handler);
			this.handlerCache.Clear();
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000983B File Offset: 0x00007A3B
		protected void UnregisterHandler(TypeHandler handler)
		{
			this.InitializeIfNecessary();
			this.handlers.Remove(handler);
			this.handlerCache.Clear();
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600025F RID: 607 RVA: 0x0000985B File Offset: 0x00007A5B
		protected bool IsInitialized
		{
			get
			{
				return this.handlers != null;
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00009869 File Offset: 0x00007A69
		protected virtual void Initialize()
		{
			this.handlers = new global::System.Collections.Generic.List<TypeHandler>();
			this.handlerCache = new global::System.Collections.Generic.Dictionary<global::System.Type, TypeHandler>();
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00009881 File Offset: 0x00007A81
		protected void InitializeIfNecessary()
		{
			if (!this.IsInitialized)
			{
				this.Initialize();
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00009894 File Offset: 0x00007A94
		protected virtual TypeHandler GetDefaultHandler(global::System.Type type)
		{
			return default(TypeHandler);
		}

		// Token: 0x06000263 RID: 611
		protected abstract global::System.Type GetBaseType(TypeHandler handler);

		// Token: 0x04000091 RID: 145
		private global::System.Collections.Generic.List<TypeHandler> handlers;

		// Token: 0x04000092 RID: 146
		private global::System.Collections.Generic.Dictionary<global::System.Type, TypeHandler> handlerCache;
	}
}
