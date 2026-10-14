using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x0200044C RID: 1100
	internal class LazyLoadImplementor
	{
		// Token: 0x060035A6 RID: 13734 RVA: 0x000AC087 File Offset: 0x000AA287
		public LazyLoadImplementor(global::System.Data.Entity.Core.Metadata.Edm.EntityType ospaceEntityType)
		{
			this.CheckType(ospaceEntityType);
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x060035A7 RID: 13735 RVA: 0x000AC096 File Offset: 0x000AA296
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> Members
		{
			get
			{
				return this._members;
			}
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x000AC0A0 File Offset: 0x000AA2A0
		private void CheckType(global::System.Data.Entity.Core.Metadata.Edm.EntityType ospaceEntityType)
		{
			this._members = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in ospaceEntityType.Members)
			{
				global::System.Reflection.PropertyInfo topProperty = ospaceEntityType.ClrType.GetTopProperty(edmMember.Name);
				if (topProperty != null && global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.CanProxyGetter(topProperty) && global::System.Data.Entity.Core.Objects.Internal.LazyLoadBehavior.IsLazyLoadCandidate(ospaceEntityType, edmMember))
				{
					this._members.Add(edmMember);
				}
			}
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x000AC130 File Offset: 0x000AA330
		public bool CanProxyMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return this._members.Contains(member);
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x000AC140 File Offset: 0x000AA340
		public virtual void Implement(global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Action<global::System.Reflection.Emit.FieldBuilder, bool> registerField)
		{
			global::System.Reflection.Emit.FieldBuilder arg = typeBuilder.DefineField("_entityWrapper", typeof(object), global::System.Reflection.FieldAttributes.Public);
			registerField(arg, false);
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x000AC16C File Offset: 0x000AA36C
		public bool EmitMember(global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, global::System.Reflection.Emit.PropertyBuilder propertyBuilder, global::System.Reflection.PropertyInfo baseProperty, global::System.Data.Entity.Core.Objects.Internal.BaseProxyImplementor baseImplementor)
		{
			if (this._members.Contains(member))
			{
				global::System.Reflection.MethodInfo methodInfo = baseProperty.Getter();
				global::System.Reflection.MethodAttributes methodAttributes = methodInfo.Attributes & global::System.Reflection.MethodAttributes.MemberAccessMask;
				global::System.Type type = typeof(global::System.Func<, , >).MakeGenericType(new global::System.Type[]
				{
					typeBuilder,
					baseProperty.PropertyType,
					typeof(bool)
				});
				global::System.Reflection.MethodInfo method = global::System.Reflection.Emit.TypeBuilder.GetMethod(type, typeof(global::System.Func<, , >).GetOnlyDeclaredMethod("Invoke"));
				global::System.Reflection.Emit.FieldBuilder field = typeBuilder.DefineField(global::System.Data.Entity.Core.Objects.Internal.LazyLoadImplementor.GetInterceptorFieldName(baseProperty.Name), type, global::System.Reflection.FieldAttributes.Private | global::System.Reflection.FieldAttributes.Static);
				global::System.Reflection.Emit.MethodBuilder methodBuilder = typeBuilder.DefineMethod("get_" + baseProperty.Name, methodAttributes | (global::System.Reflection.MethodAttributes.Virtual | global::System.Reflection.MethodAttributes.HideBySig | global::System.Reflection.MethodAttributes.SpecialName), baseProperty.PropertyType, global::System.Type.EmptyTypes);
				global::System.Reflection.Emit.ILGenerator ilgenerator = methodBuilder.GetILGenerator();
				global::System.Reflection.Emit.Label label = ilgenerator.DefineLabel();
				ilgenerator.DeclareLocal(baseProperty.PropertyType);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, methodInfo);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Stloc_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldfld, field);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, method);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Brtrue_S, label);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, methodInfo);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
				ilgenerator.MarkLabel(label);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
				propertyBuilder.SetGetMethod(methodBuilder);
				baseImplementor.AddBasePropertyGetter(baseProperty);
				return true;
			}
			return false;
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x000AC303 File Offset: 0x000AA503
		internal static string GetInterceptorFieldName(string memberName)
		{
			return "ef_proxy_interceptorFor" + memberName;
		}

		// Token: 0x04001160 RID: 4448
		private global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> _members;
	}
}
