using System;
using System.Collections.Generic;
using System.Reflection;
using NLog.Common;
using NLog.Internal;

namespace NLog.Config
{
	// Token: 0x02000169 RID: 361
	internal class MethodFactory<TClassAttributeType, TMethodAttributeType> : global::NLog.Config.INamedItemFactory<global::System.Reflection.MethodInfo, global::System.Reflection.MethodInfo>, global::NLog.Config.IFactory where TClassAttributeType : global::System.Attribute where TMethodAttributeType : global::NLog.Config.NameBaseAttribute
	{
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x000291C1 File Offset: 0x000273C1
		public global::System.Collections.Generic.IDictionary<string, global::System.Reflection.MethodInfo> AllRegisteredItems
		{
			get
			{
				return this._nameToMethodInfo;
			}
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x000291CC File Offset: 0x000273CC
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

		// Token: 0x06000FDF RID: 4063 RVA: 0x00029230 File Offset: 0x00027430
		public void RegisterType(global::System.Type type, string itemNamePrefix)
		{
			if (type.IsDefined(typeof(TClassAttributeType), false))
			{
				foreach (global::System.Reflection.MethodInfo methodInfo in type.GetMethods())
				{
					foreach (TMethodAttributeType tmethodAttributeType in (TMethodAttributeType[])methodInfo.GetCustomAttributes(typeof(TMethodAttributeType), false))
					{
						this.RegisterDefinition(itemNamePrefix + tmethodAttributeType.Name, methodInfo);
					}
				}
			}
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x000292B5 File Offset: 0x000274B5
		public void Clear()
		{
			this._nameToMethodInfo.Clear();
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x000292C2 File Offset: 0x000274C2
		public void RegisterDefinition(string itemName, global::System.Reflection.MethodInfo itemDefinition)
		{
			this._nameToMethodInfo[itemName] = itemDefinition;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x000292D1 File Offset: 0x000274D1
		public bool TryCreateInstance(string itemName, out global::System.Reflection.MethodInfo result)
		{
			return this._nameToMethodInfo.TryGetValue(itemName, out result);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x000292E0 File Offset: 0x000274E0
		public global::System.Reflection.MethodInfo CreateInstance(string itemName)
		{
			global::System.Reflection.MethodInfo result;
			if (this.TryCreateInstance(itemName, out result))
			{
				return result;
			}
			throw new global::NLog.NLogConfigurationException(string.Format("Unknown function: '{0}'", itemName));
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0002930A File Offset: 0x0002750A
		public bool TryGetDefinition(string itemName, out global::System.Reflection.MethodInfo result)
		{
			return this._nameToMethodInfo.TryGetValue(itemName, out result);
		}

		// Token: 0x0400046B RID: 1131
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Reflection.MethodInfo> _nameToMethodInfo = new global::System.Collections.Generic.Dictionary<string, global::System.Reflection.MethodInfo>();
	}
}
