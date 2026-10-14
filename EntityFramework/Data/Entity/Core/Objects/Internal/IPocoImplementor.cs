using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000449 RID: 1097
	internal class IPocoImplementor
	{
		// Token: 0x0600358F RID: 13711 RVA: 0x000AAEB0 File Offset: 0x000A90B0
		public IPocoImplementor(global::System.Data.Entity.Core.Metadata.Edm.EntityType ospaceEntityType)
		{
			global::System.Type clrType = ospaceEntityType.ClrType;
			this._referenceProperties = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Reflection.PropertyInfo>>();
			this._collectionProperties = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Reflection.PropertyInfo>>();
			this._implementIEntityWithChangeTracker = (null == clrType.GetInterface(typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker).Name));
			this._implementIEntityWithRelationships = (null == clrType.GetInterface(typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships).Name));
			this.CheckType(ospaceEntityType);
			this._ospaceEntityType = ospaceEntityType;
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x000AAF30 File Offset: 0x000A9130
		private void CheckType(global::System.Data.Entity.Core.Metadata.Edm.EntityType ospaceEntityType)
		{
			this._scalarMembers = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
			this._relationshipMembers = new global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in ospaceEntityType.Members)
			{
				global::System.Reflection.PropertyInfo topProperty = ospaceEntityType.ClrType.GetTopProperty(edmMember.Name);
				if (topProperty != null && global::System.Data.Entity.Core.Objects.Internal.EntityProxyFactory.CanProxySetter(topProperty))
				{
					if (edmMember.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmProperty)
					{
						if (this._implementIEntityWithChangeTracker)
						{
							this._scalarMembers.Add(edmMember);
						}
					}
					else if (edmMember.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.NavigationProperty && this._implementIEntityWithRelationships)
					{
						if (((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty)edmMember).ToEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
						{
							if (topProperty.PropertyType.IsGenericType() && topProperty.PropertyType.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.ICollection<>))
							{
								this._relationshipMembers.Add(edmMember);
							}
						}
						else
						{
							this._relationshipMembers.Add(edmMember);
						}
					}
				}
			}
			if (ospaceEntityType.Members.Count != this._scalarMembers.Count + this._relationshipMembers.Count)
			{
				this._scalarMembers.Clear();
				this._relationshipMembers.Clear();
				this._implementIEntityWithChangeTracker = false;
				this._implementIEntityWithRelationships = false;
			}
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x000AB094 File Offset: 0x000A9294
		public void Implement(global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Action<global::System.Reflection.Emit.FieldBuilder, bool> registerField)
		{
			if (this._implementIEntityWithChangeTracker)
			{
				this.ImplementIEntityWithChangeTracker(typeBuilder, registerField);
			}
			if (this._implementIEntityWithRelationships)
			{
				this.ImplementIEntityWithRelationships(typeBuilder, registerField);
			}
			this._resetFKSetterFlagField = typeBuilder.DefineField("_resetFKSetterFlag", typeof(global::System.Action<object>), global::System.Reflection.FieldAttributes.Private | global::System.Reflection.FieldAttributes.Static);
			this._compareByteArraysField = typeBuilder.DefineField("_compareByteArrays", typeof(global::System.Func<object, object, bool>), global::System.Reflection.FieldAttributes.Private | global::System.Reflection.FieldAttributes.Static);
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06003592 RID: 13714 RVA: 0x000AB0FC File Offset: 0x000A92FC
		public global::System.Type[] Interfaces
		{
			get
			{
				global::System.Collections.Generic.List<global::System.Type> list = new global::System.Collections.Generic.List<global::System.Type>();
				if (this._implementIEntityWithChangeTracker)
				{
					list.Add(typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker));
				}
				if (this._implementIEntityWithRelationships)
				{
					list.Add(typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships));
				}
				return list.ToArray();
			}
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x000AB145 File Offset: 0x000A9345
		private static global::System.Reflection.Emit.DynamicMethod CreateDynamicMethod(string name, global::System.Type returnType, global::System.Type[] parameterTypes)
		{
			return new global::System.Reflection.Emit.DynamicMethod(name, returnType, parameterTypes, true);
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x000AB150 File Offset: 0x000A9350
		public global::System.Reflection.Emit.DynamicMethod CreateInitializeCollectionMethod(global::System.Type proxyType)
		{
			if (this._collectionProperties.Count > 0)
			{
				global::System.Reflection.Emit.DynamicMethod dynamicMethod = global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.CreateDynamicMethod(proxyType.Name + "_InitializeEntityCollections", typeof(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper), new global::System.Type[]
				{
					typeof(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper)
				});
				global::System.Reflection.Emit.ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
				ilgenerator.DeclareLocal(proxyType);
				ilgenerator.DeclareLocal(typeof(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager));
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.GetEntityMethod);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Castclass, proxyType);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Stloc_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.GetRelationshipManagerMethod);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Stloc_1);
				foreach (global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Reflection.PropertyInfo> keyValuePair in this._collectionProperties)
				{
					global::System.Reflection.MethodInfo meth = global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.GetRelatedCollectionMethod.MakeGenericMethod(new global::System.Type[]
					{
						global::System.Data.Entity.Core.EntityUtil.GetCollectionElementType(keyValuePair.Value.PropertyType)
					});
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_0);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldloc_1);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, keyValuePair.Key.RelationshipType.FullName);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, keyValuePair.Key.ToEndMember.Name);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, meth);
					ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, keyValuePair.Value.Setter());
				}
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
				ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
				return dynamicMethod;
			}
			return null;
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x000AB310 File Offset: 0x000A9510
		public bool CanProxyMember(global::System.Data.Entity.Core.Metadata.Edm.EdmMember member)
		{
			return this._scalarMembers.Contains(member) || this._relationshipMembers.Contains(member);
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x000AB330 File Offset: 0x000A9530
		public bool EmitMember(global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, global::System.Reflection.Emit.PropertyBuilder propertyBuilder, global::System.Reflection.PropertyInfo baseProperty, global::System.Data.Entity.Core.Objects.Internal.BaseProxyImplementor baseImplementor)
		{
			if (this._scalarMembers.Contains(member))
			{
				bool isKeyMember = this._ospaceEntityType.KeyMembers.Contains(member.Identity);
				this.EmitScalarSetter(typeBuilder, propertyBuilder, baseProperty, isKeyMember);
				return true;
			}
			if (this._relationshipMembers.Contains(member))
			{
				global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = member as global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty;
				if (navigationProperty.ToEndMember.RelationshipMultiplicity == global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.Many)
				{
					this.EmitCollectionProperty(typeBuilder, propertyBuilder, baseProperty, navigationProperty);
				}
				else
				{
					this.EmitReferenceProperty(typeBuilder, propertyBuilder, baseProperty, navigationProperty);
				}
				baseImplementor.AddBasePropertySetter(baseProperty);
				return true;
			}
			return false;
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x000AB3B8 File Offset: 0x000A95B8
		private void EmitScalarSetter(global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Reflection.Emit.PropertyBuilder propertyBuilder, global::System.Reflection.PropertyInfo baseProperty, bool isKeyMember)
		{
			global::System.Reflection.MethodInfo methodInfo = baseProperty.Setter();
			global::System.Reflection.MethodAttributes methodAttributes = methodInfo.Attributes & global::System.Reflection.MethodAttributes.MemberAccessMask;
			global::System.Reflection.Emit.MethodBuilder methodBuilder = typeBuilder.DefineMethod("set_" + baseProperty.Name, methodAttributes | (global::System.Reflection.MethodAttributes.Virtual | global::System.Reflection.MethodAttributes.HideBySig | global::System.Reflection.MethodAttributes.SpecialName), null, new global::System.Type[]
			{
				baseProperty.PropertyType
			});
			global::System.Reflection.Emit.ILGenerator ilgenerator = methodBuilder.GetILGenerator();
			global::System.Reflection.Emit.Label label = ilgenerator.DefineLabel();
			if (isKeyMember)
			{
				global::System.Reflection.MethodInfo methodInfo2 = baseProperty.Getter();
				if (methodInfo2 != null)
				{
					global::System.Type propertyType = baseProperty.PropertyType;
					if (propertyType == typeof(int) || propertyType == typeof(short) || propertyType == typeof(long) || propertyType == typeof(bool) || propertyType == typeof(byte) || propertyType == typeof(uint) || propertyType == typeof(ulong) || propertyType == typeof(float) || propertyType == typeof(double) || propertyType.IsEnum())
					{
						ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
						ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, methodInfo2);
						ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
						ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Beq_S, label);
					}
					else if (propertyType == typeof(byte[]))
					{
						ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldsfld, this._compareByteArraysField);
						ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
						ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, methodInfo2);
						ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
						ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.FuncInvokeMethod);
						ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Brtrue_S, label);
					}
					else
					{
						global::System.Reflection.MethodInfo declaredMethod = propertyType.GetDeclaredMethod("op_Inequality", new global::System.Type[]
						{
							propertyType,
							propertyType
						});
						if (declaredMethod != null)
						{
							ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
							ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, methodInfo2);
							ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
							ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, declaredMethod);
							ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Brfalse_S, label);
						}
						else
						{
							ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
							ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, methodInfo2);
							if (propertyType.IsValueType())
							{
								ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Box, propertyType);
							}
							ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
							if (propertyType.IsValueType())
							{
								ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Box, propertyType);
							}
							ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.ObjectEqualsMethod);
							ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Brtrue_S, label);
						}
					}
				}
			}
			ilgenerator.BeginExceptionBlock();
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, baseProperty.Name);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, this._entityMemberChanging);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, methodInfo);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, baseProperty.Name);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, this._entityMemberChanged);
			ilgenerator.BeginFinallyBlock();
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldsfld, this._resetFKSetterFlagField);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.InvokeMethod);
			ilgenerator.EndExceptionBlock();
			ilgenerator.MarkLabel(label);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
			propertyBuilder.SetSetMethod(methodBuilder);
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x000AB738 File Offset: 0x000A9938
		private void EmitReferenceProperty(global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Reflection.Emit.PropertyBuilder propertyBuilder, global::System.Reflection.PropertyInfo baseProperty, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navProperty)
		{
			global::System.Reflection.MethodAttributes methodAttributes = baseProperty.Setter().Attributes & global::System.Reflection.MethodAttributes.MemberAccessMask;
			global::System.Reflection.MethodInfo meth = global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.GetRelatedReferenceMethod.MakeGenericMethod(new global::System.Type[]
			{
				baseProperty.PropertyType
			});
			global::System.Reflection.MethodInfo onlyDeclaredMethod = typeof(global::System.Data.Entity.Core.Objects.DataClasses.EntityReference<>).MakeGenericType(new global::System.Type[]
			{
				baseProperty.PropertyType
			}).GetOnlyDeclaredMethod("set_Value");
			global::System.Reflection.Emit.MethodBuilder methodBuilder = typeBuilder.DefineMethod("set_" + baseProperty.Name, methodAttributes | (global::System.Reflection.MethodAttributes.Virtual | global::System.Reflection.MethodAttributes.HideBySig | global::System.Reflection.MethodAttributes.SpecialName), null, new global::System.Type[]
			{
				baseProperty.PropertyType
			});
			global::System.Reflection.Emit.ILGenerator ilgenerator = methodBuilder.GetILGenerator();
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, this._getRelationshipManager);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, navProperty.RelationshipType.FullName);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, navProperty.ToEndMember.Name);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, meth);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, onlyDeclaredMethod);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
			propertyBuilder.SetSetMethod(methodBuilder);
			this._referenceProperties.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Reflection.PropertyInfo>(navProperty, baseProperty));
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x000AB85C File Offset: 0x000A9A5C
		private void EmitCollectionProperty(global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Reflection.Emit.PropertyBuilder propertyBuilder, global::System.Reflection.PropertyInfo baseProperty, global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navProperty)
		{
			global::System.Reflection.MethodAttributes methodAttributes = baseProperty.Setter().Attributes & global::System.Reflection.MethodAttributes.MemberAccessMask;
			string str = global::System.Data.Entity.Resources.Strings.EntityProxyTypeInfo_CannotSetEntityCollectionProperty(propertyBuilder.Name, typeBuilder.Name);
			global::System.Reflection.Emit.MethodBuilder methodBuilder = typeBuilder.DefineMethod("set_" + baseProperty.Name, methodAttributes | (global::System.Reflection.MethodAttributes.Virtual | global::System.Reflection.MethodAttributes.HideBySig | global::System.Reflection.MethodAttributes.SpecialName), null, new global::System.Type[]
			{
				baseProperty.PropertyType
			});
			global::System.Reflection.Emit.ILGenerator ilgenerator = methodBuilder.GetILGenerator();
			global::System.Reflection.Emit.Label label = ilgenerator.DefineLabel();
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, this._getRelationshipManager);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, navProperty.RelationshipType.FullName);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, navProperty.ToEndMember.Name);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.GetRelatedEndMethod);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Beq_S, label);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldstr, str);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Newobj, global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor._invalidOperationConstructorMethod);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Throw);
			ilgenerator.MarkLabel(label);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, baseProperty.Setter());
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
			propertyBuilder.SetSetMethod(methodBuilder);
			this._collectionProperties.Add(new global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Reflection.PropertyInfo>(navProperty, baseProperty));
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x000AB9B0 File Offset: 0x000A9BB0
		private void ImplementIEntityWithChangeTracker(global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Action<global::System.Reflection.Emit.FieldBuilder, bool> registerField)
		{
			this._changeTrackerField = typeBuilder.DefineField("_changeTracker", typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker), global::System.Reflection.FieldAttributes.Private);
			registerField(this._changeTrackerField, false);
			this._entityMemberChanging = typeBuilder.DefineMethod("EntityMemberChanging", global::System.Reflection.MethodAttributes.Private | global::System.Reflection.MethodAttributes.HideBySig, typeof(void), new global::System.Type[]
			{
				typeof(string)
			});
			global::System.Reflection.Emit.ILGenerator ilgenerator = this._entityMemberChanging.GetILGenerator();
			global::System.Reflection.Emit.Label label = ilgenerator.DefineLabel();
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldfld, this._changeTrackerField);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Brfalse_S, label);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldfld, this._changeTrackerField);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.EntityMemberChangingMethod);
			ilgenerator.MarkLabel(label);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
			this._entityMemberChanged = typeBuilder.DefineMethod("EntityMemberChanged", global::System.Reflection.MethodAttributes.Private | global::System.Reflection.MethodAttributes.HideBySig, typeof(void), new global::System.Type[]
			{
				typeof(string)
			});
			global::System.Reflection.Emit.ILGenerator ilgenerator2 = this._entityMemberChanged.GetILGenerator();
			label = ilgenerator2.DefineLabel();
			ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ldfld, this._changeTrackerField);
			ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Brfalse_S, label);
			ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ldfld, this._changeTrackerField);
			ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
			ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Callvirt, global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.EntityMemberChangedMethod);
			ilgenerator2.MarkLabel(label);
			ilgenerator2.Emit(global::System.Reflection.Emit.OpCodes.Ret);
			global::System.Reflection.Emit.MethodBuilder methodBuilder = typeBuilder.DefineMethod("IEntityWithChangeTracker.SetChangeTracker", global::System.Reflection.MethodAttributes.Private | global::System.Reflection.MethodAttributes.Final | global::System.Reflection.MethodAttributes.Virtual | global::System.Reflection.MethodAttributes.HideBySig | global::System.Reflection.MethodAttributes.VtableLayoutMask, typeof(void), new global::System.Type[]
			{
				typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker)
			});
			global::System.Reflection.Emit.ILGenerator ilgenerator3 = methodBuilder.GetILGenerator();
			ilgenerator3.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator3.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_1);
			ilgenerator3.Emit(global::System.Reflection.Emit.OpCodes.Stfld, this._changeTrackerField);
			ilgenerator3.Emit(global::System.Reflection.Emit.OpCodes.Ret);
			typeBuilder.DefineMethodOverride(methodBuilder, global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.SetChangeTrackerMethod);
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x000ABBC4 File Offset: 0x000A9DC4
		private void ImplementIEntityWithRelationships(global::System.Reflection.Emit.TypeBuilder typeBuilder, global::System.Action<global::System.Reflection.Emit.FieldBuilder, bool> registerField)
		{
			this._relationshipManagerField = typeBuilder.DefineField("_relationshipManager", typeof(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager), global::System.Reflection.FieldAttributes.Private);
			registerField(this._relationshipManagerField, true);
			global::System.Reflection.Emit.PropertyBuilder propertyBuilder = typeBuilder.DefineProperty("RelationshipManager", global::System.Reflection.PropertyAttributes.None, typeof(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager), global::System.Type.EmptyTypes);
			this._getRelationshipManager = typeBuilder.DefineMethod("IEntityWithRelationships.get_RelationshipManager", global::System.Reflection.MethodAttributes.Private | global::System.Reflection.MethodAttributes.Final | global::System.Reflection.MethodAttributes.Virtual | global::System.Reflection.MethodAttributes.HideBySig | global::System.Reflection.MethodAttributes.VtableLayoutMask | global::System.Reflection.MethodAttributes.SpecialName, typeof(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager), global::System.Type.EmptyTypes);
			global::System.Reflection.Emit.ILGenerator ilgenerator = this._getRelationshipManager.GetILGenerator();
			global::System.Reflection.Emit.Label label = ilgenerator.DefineLabel();
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldfld, this._relationshipManagerField);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Brtrue_S, label);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Call, global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.CreateRelationshipManagerMethod);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Stfld, this._relationshipManagerField);
			ilgenerator.MarkLabel(label);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldarg_0);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ldfld, this._relationshipManagerField);
			ilgenerator.Emit(global::System.Reflection.Emit.OpCodes.Ret);
			propertyBuilder.SetGetMethod(this._getRelationshipManager);
			typeBuilder.DefineMethodOverride(this._getRelationshipManager, global::System.Data.Entity.Core.Objects.Internal.IPocoImplementor.GetRelationshipManagerMethod);
		}

		// Token: 0x04001145 RID: 4421
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityType _ospaceEntityType;

		// Token: 0x04001146 RID: 4422
		private global::System.Reflection.Emit.FieldBuilder _changeTrackerField;

		// Token: 0x04001147 RID: 4423
		private global::System.Reflection.Emit.FieldBuilder _relationshipManagerField;

		// Token: 0x04001148 RID: 4424
		private global::System.Reflection.Emit.FieldBuilder _resetFKSetterFlagField;

		// Token: 0x04001149 RID: 4425
		private global::System.Reflection.Emit.FieldBuilder _compareByteArraysField;

		// Token: 0x0400114A RID: 4426
		private global::System.Reflection.Emit.MethodBuilder _entityMemberChanging;

		// Token: 0x0400114B RID: 4427
		private global::System.Reflection.Emit.MethodBuilder _entityMemberChanged;

		// Token: 0x0400114C RID: 4428
		private global::System.Reflection.Emit.MethodBuilder _getRelationshipManager;

		// Token: 0x0400114D RID: 4429
		private readonly global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Reflection.PropertyInfo>> _referenceProperties;

		// Token: 0x0400114E RID: 4430
		private readonly global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, global::System.Reflection.PropertyInfo>> _collectionProperties;

		// Token: 0x0400114F RID: 4431
		private bool _implementIEntityWithChangeTracker;

		// Token: 0x04001150 RID: 4432
		private bool _implementIEntityWithRelationships;

		// Token: 0x04001151 RID: 4433
		private global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> _scalarMembers;

		// Token: 0x04001152 RID: 4434
		private global::System.Collections.Generic.HashSet<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> _relationshipMembers;

		// Token: 0x04001153 RID: 4435
		internal static readonly global::System.Reflection.MethodInfo EntityMemberChangingMethod = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker).GetDeclaredMethod("EntityMemberChanging", new global::System.Type[]
		{
			typeof(string)
		});

		// Token: 0x04001154 RID: 4436
		internal static readonly global::System.Reflection.MethodInfo EntityMemberChangedMethod = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityChangeTracker).GetDeclaredMethod("EntityMemberChanged", new global::System.Type[]
		{
			typeof(string)
		});

		// Token: 0x04001155 RID: 4437
		internal static readonly global::System.Reflection.MethodInfo CreateRelationshipManagerMethod = typeof(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager).GetDeclaredMethod("Create", new global::System.Type[]
		{
			typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships)
		});

		// Token: 0x04001156 RID: 4438
		internal static readonly global::System.Reflection.MethodInfo GetRelationshipManagerMethod = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithRelationships).GetDeclaredProperty("RelationshipManager").Getter();

		// Token: 0x04001157 RID: 4439
		internal static readonly global::System.Reflection.MethodInfo GetRelatedReferenceMethod = typeof(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager).GetDeclaredMethod("GetRelatedReference", new global::System.Type[]
		{
			typeof(string),
			typeof(string)
		});

		// Token: 0x04001158 RID: 4440
		internal static readonly global::System.Reflection.MethodInfo GetRelatedCollectionMethod = typeof(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager).GetDeclaredMethod("GetRelatedCollection", new global::System.Type[]
		{
			typeof(string),
			typeof(string)
		});

		// Token: 0x04001159 RID: 4441
		internal static readonly global::System.Reflection.MethodInfo GetRelatedEndMethod = typeof(global::System.Data.Entity.Core.Objects.DataClasses.RelationshipManager).GetDeclaredMethod("GetRelatedEnd", new global::System.Type[]
		{
			typeof(string),
			typeof(string)
		});

		// Token: 0x0400115A RID: 4442
		internal static readonly global::System.Reflection.MethodInfo ObjectEqualsMethod = typeof(object).GetDeclaredMethod("Equals", new global::System.Type[]
		{
			typeof(object),
			typeof(object)
		});

		// Token: 0x0400115B RID: 4443
		private static readonly global::System.Reflection.ConstructorInfo _invalidOperationConstructorMethod = typeof(global::System.InvalidOperationException).GetDeclaredConstructor(new global::System.Type[]
		{
			typeof(string)
		});

		// Token: 0x0400115C RID: 4444
		internal static readonly global::System.Reflection.MethodInfo GetEntityMethod = typeof(global::System.Data.Entity.Core.Objects.Internal.IEntityWrapper).GetDeclaredProperty("Entity").Getter();

		// Token: 0x0400115D RID: 4445
		internal static readonly global::System.Reflection.MethodInfo InvokeMethod = typeof(global::System.Action<object>).GetDeclaredMethod("Invoke", new global::System.Type[]
		{
			typeof(object)
		});

		// Token: 0x0400115E RID: 4446
		internal static readonly global::System.Reflection.MethodInfo FuncInvokeMethod = typeof(global::System.Func<object, object, bool>).GetDeclaredMethod("Invoke", new global::System.Type[]
		{
			typeof(object),
			typeof(object)
		});

		// Token: 0x0400115F RID: 4447
		internal static readonly global::System.Reflection.MethodInfo SetChangeTrackerMethod = typeof(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithChangeTracker).GetOnlyDeclaredMethod("SetChangeTracker");
	}
}
