using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Structures
{
	// Token: 0x020005A8 RID: 1448
	internal sealed class MemberPath : global::System.Data.Entity.Core.Common.Utils.InternalBase, global::System.IEquatable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>
	{
		// Token: 0x06004661 RID: 18017 RVA: 0x000F76BB File Offset: 0x000F58BB
		internal MemberPath(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> path)
		{
			this.m_extent = extent;
			this.m_path = path.ToList<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x000F76D6 File Offset: 0x000F58D6
		internal MemberPath(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent) : this(extent, global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>())
		{
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x000F76E4 File Offset: 0x000F58E4
		internal MemberPath(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member) : this(extent, global::System.Linq.Enumerable.Repeat<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(member, 1))
		{
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x000F76F4 File Offset: 0x000F58F4
		internal MemberPath(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath prefix, global::System.Data.Entity.Core.Metadata.Edm.EdmMember last)
		{
			this.m_extent = prefix.m_extent;
			this.m_path = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(prefix.m_path);
			this.m_path.Add(last);
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x000F7725 File Offset: 0x000F5925
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmMember RootEdmMember
		{
			get
			{
				if (this.m_path.Count <= 0)
				{
					return null;
				}
				return this.m_path[0];
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06004666 RID: 18022 RVA: 0x000F7743 File Offset: 0x000F5943
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmMember LeafEdmMember
		{
			get
			{
				if (this.m_path.Count <= 0)
				{
					return null;
				}
				return this.m_path[this.m_path.Count - 1];
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06004667 RID: 18023 RVA: 0x000F776D File Offset: 0x000F596D
		internal string LeafName
		{
			get
			{
				if (this.m_path.Count == 0)
				{
					return this.m_extent.Name;
				}
				return this.LeafEdmMember.Name;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06004668 RID: 18024 RVA: 0x000F7793 File Offset: 0x000F5993
		internal bool IsComputed
		{
			get
			{
				return this.m_path.Count != 0 && this.RootEdmMember.IsStoreGeneratedComputed;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06004669 RID: 18025 RVA: 0x000F77B0 File Offset: 0x000F59B0
		internal object DefaultValue
		{
			get
			{
				if (this.m_path.Count == 0)
				{
					return null;
				}
				global::System.Data.Entity.Core.Metadata.Edm.Facet facet;
				if (this.LeafEdmMember.TypeUsage.Facets.TryGetValue("DefaultValue", false, out facet))
				{
					return facet.Value;
				}
				return null;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x0600466A RID: 18026 RVA: 0x000F77F3 File Offset: 0x000F59F3
		internal bool IsPartOfKey
		{
			get
			{
				return this.m_path.Count != 0 && global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsPartOfEntityTypeKey(this.LeafEdmMember);
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x0600466B RID: 18027 RVA: 0x000F780F File Offset: 0x000F5A0F
		internal bool IsNullable
		{
			get
			{
				return this.m_path.Count != 0 && global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsMemberNullable(this.LeafEdmMember);
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x0600466C RID: 18028 RVA: 0x000F782C File Offset: 0x000F5A2C
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet
		{
			get
			{
				if (this.m_path.Count == 0)
				{
					return this.m_extent as global::System.Data.Entity.Core.Metadata.Edm.EntitySet;
				}
				if (this.m_path.Count == 1)
				{
					global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = this.RootEdmMember as global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember;
					if (associationEndMember != null)
					{
						return global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntitySetAtEnd((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.m_extent, associationEndMember);
					}
				}
				return null;
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x0600466D RID: 18029 RVA: 0x000F7882 File Offset: 0x000F5A82
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase Extent
		{
			get
			{
				return this.m_extent;
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x0600466E RID: 18030 RVA: 0x000F788A File Offset: 0x000F5A8A
		internal global::System.Data.Entity.Core.Metadata.Edm.EdmType EdmType
		{
			get
			{
				if (this.m_path.Count > 0)
				{
					return this.LeafEdmMember.TypeUsage.EdmType;
				}
				return this.m_extent.ElementType;
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x0600466F RID: 18031 RVA: 0x000F78B8 File Offset: 0x000F5AB8
		internal string CqlFieldAlias
		{
			get
			{
				string text = this.PathToString(new bool?(true));
				if (!text.Contains("_"))
				{
					text = text.Replace('.', '_');
				}
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedName(stringBuilder, text);
				return stringBuilder.ToString();
			}
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x000F78FC File Offset: 0x000F5AFC
		internal bool IsAlwaysDefined(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>> inheritanceGraph)
		{
			if (this.m_path.Count == 0)
			{
				return true;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmMember member = this.m_path.Last<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
			for (int i = 0; i < this.m_path.Count - 1; i++)
			{
				if (global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsMemberNullable(this.m_path[i]))
				{
					return false;
				}
			}
			if (this.m_path[0].DeclaringType is global::System.Data.Entity.Core.Metadata.Edm.AssociationType)
			{
				return true;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = this.m_extent.ElementType as global::System.Data.Entity.Core.Metadata.Edm.EntityType;
			if (entityType == null)
			{
				return true;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 = this.m_path[0].DeclaringType as global::System.Data.Entity.Core.Metadata.Edm.EntityType;
			global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType3 = entityType2.BaseType as global::System.Data.Entity.Core.Metadata.Edm.EntityType;
			return entityType.EdmEquals(entityType2) || global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsParentOf(entityType2, entityType) || entityType3 == null || ((entityType3.Abstract || global::System.Data.Entity.Core.Common.Utils.MetadataHelper.DoesMemberExist(entityType3, member)) && !global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.RecurseToFindMemberAbsentInConcreteType(entityType3, entityType2, member, entityType, inheritanceGraph));
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x000F79E0 File Offset: 0x000F5BE0
		private static bool RecurseToFindMemberAbsentInConcreteType(global::System.Data.Entity.Core.Metadata.Edm.EntityType current, global::System.Data.Entity.Core.Metadata.Edm.EntityType avoidEdge, global::System.Data.Entity.Core.Metadata.Edm.EdmMember member, global::System.Data.Entity.Core.Metadata.Edm.EntityType entitySetType, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Data.Entity.Core.Common.Utils.Set<global::System.Data.Entity.Core.Metadata.Edm.EntityType>> inheritanceGraph)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> source = inheritanceGraph[current];
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityType, bool> <>9__0;
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EntityType, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((global::System.Data.Entity.Core.Metadata.Edm.EntityType type) => !type.EdmEquals(avoidEdge)));
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType in source.Where(predicate))
			{
				if (entitySetType.BaseType == null || !entitySetType.BaseType.EdmEquals(entityType))
				{
					if (!entityType.Abstract && !global::System.Data.Entity.Core.Common.Utils.MetadataHelper.DoesMemberExist(entityType, member))
					{
						return true;
					}
					if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.RecurseToFindMemberAbsentInConcreteType(entityType, current, member, entitySetType, inheritanceGraph))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x000F7A9C File Offset: 0x000F5C9C
		internal void GetIdentifiers(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.CqlIdentifiers identifiers)
		{
			identifiers.AddIdentifier(this.m_extent.Name);
			identifiers.AddIdentifier(this.m_extent.ElementType.Name);
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in this.m_path)
			{
				identifiers.AddIdentifier(edmMember.Name);
			}
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x000F7B1C File Offset: 0x000F5D1C
		internal static bool AreAllMembersNullable(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> members)
		{
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in members)
			{
				if (memberPath.m_path.Count == 0)
				{
					return false;
				}
				if (!memberPath.IsNullable)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x000F7B80 File Offset: 0x000F5D80
		internal static string PropertiesToUserString(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> members, bool fullPath)
		{
			bool flag = true;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in members)
			{
				if (!flag)
				{
					stringBuilder.Append(", ");
				}
				flag = false;
				if (fullPath)
				{
					stringBuilder.Append(memberPath.PathToString(new bool?(false)));
				}
				else
				{
					stringBuilder.Append(memberPath.LeafName);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06004675 RID: 18037 RVA: 0x000F7C08 File Offset: 0x000F5E08
		internal global::System.Text.StringBuilder AsEsql(global::System.Text.StringBuilder inputBuilder, string blockAlias)
		{
			global::System.Text.StringBuilder builder = new global::System.Text.StringBuilder();
			global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedName(builder, blockAlias);
			this.AsCql(delegate(string memberName)
			{
				builder.Append('.');
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedName(builder, memberName);
			}, delegate
			{
				builder.Insert(0, "Key(");
				builder.Append(")");
			}, delegate(global::System.Data.Entity.Core.Metadata.Edm.StructuralType treatAsType)
			{
				builder.Insert(0, "TREAT(");
				builder.Append(" AS ");
				global::System.Data.Entity.Core.Mapping.ViewGeneration.CqlGeneration.CqlWriter.AppendEscapedTypeName(builder, treatAsType);
				builder.Append(')');
			});
			inputBuilder.Append(builder);
			return inputBuilder;
		}

		// Token: 0x06004676 RID: 18038 RVA: 0x000F7C6C File Offset: 0x000F5E6C
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbExpression AsCqt(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression row)
		{
			this.AsCql(delegate(string memberName)
			{
				row = row.Property(memberName);
			}, delegate
			{
				row = row.GetRefKey();
			}, delegate(global::System.Data.Entity.Core.Metadata.Edm.StructuralType treatAsType)
			{
				global::System.Data.Entity.Core.Metadata.Edm.TypeUsage treatType = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(treatAsType);
				row = row.TreatAs(treatType);
			});
			return row;
		}

		// Token: 0x06004677 RID: 18039 RVA: 0x000F7CB8 File Offset: 0x000F5EB8
		internal void AsCql(global::System.Action<string> accessMember, global::System.Action getKey, global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.StructuralType> treatAs)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = this.m_extent.ElementType;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in this.m_path)
			{
				global::System.Data.Entity.Core.Metadata.Edm.RefType refType;
				global::System.Data.Entity.Core.Metadata.Edm.StructuralType type;
				if (global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRefType(edmType))
				{
					refType = (global::System.Data.Entity.Core.Metadata.Edm.RefType)edmType;
					type = refType.ElementType;
				}
				else
				{
					refType = null;
					type = (global::System.Data.Entity.Core.Metadata.Edm.StructuralType)edmType;
				}
				bool flag = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.DoesMemberExist(type, edmMember);
				if (refType != null)
				{
					getKey();
				}
				else if (!flag)
				{
					treatAs(edmMember.DeclaringType);
				}
				accessMember(edmMember.Name);
				edmType = edmMember.TypeUsage.EdmType;
			}
		}

		// Token: 0x06004678 RID: 18040 RVA: 0x000F7D74 File Offset: 0x000F5F74
		public bool Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath right)
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.Equals(this, right);
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x000F7D84 File Offset: 0x000F5F84
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath right = obj as global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath;
			return obj != null && this.Equals(right);
		}

		// Token: 0x0600467A RID: 18042 RVA: 0x000F7DA4 File Offset: 0x000F5FA4
		public override int GetHashCode()
		{
			return global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.EqualityComparer.GetHashCode(this);
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x000F7DB1 File Offset: 0x000F5FB1
		internal bool IsScalarType()
		{
			return this.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.PrimitiveType || this.EdmType.BuiltInTypeKind == global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EnumType;
		}

		// Token: 0x0600467C RID: 18044 RVA: 0x000F7DD4 File Offset: 0x000F5FD4
		internal static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> GetKeyMembers(global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase extent, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(extent);
			return new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>(memberPath.GetMembers(memberPath.Extent.ElementType, null, null, new bool?(true), domainMap));
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x000F7E15 File Offset: 0x000F6015
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> GetMembers(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType, bool? isScalar, bool? isConditional, bool? isPartOfKey, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberDomainMap domainMap)
		{
			global::System.Data.Entity.Core.Metadata.Edm.StructuralType structuralType = (global::System.Data.Entity.Core.Metadata.Edm.StructuralType)edmType;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in structuralType.Members)
			{
				if (edmMember is global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember)
				{
					foreach (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath in new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(this, edmMember).GetMembers(((global::System.Data.Entity.Core.Metadata.Edm.RefType)edmMember.TypeUsage.EdmType).ElementType, isScalar, isConditional, new bool?(true), domainMap))
					{
						yield return memberPath;
					}
					global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> enumerator2 = null;
				}
				bool flag = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsNonRefSimpleMember(edmMember);
				if (isScalar == null)
				{
					goto IL_160;
				}
				bool? flag2 = isScalar;
				bool flag3 = flag;
				if (flag2.GetValueOrDefault() == flag3 & flag2 != null)
				{
					goto IL_160;
				}
				IL_212:
				edmMember = null;
				continue;
				IL_160:
				global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = edmMember as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty;
				if (edmProperty != null)
				{
					bool flag4 = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsPartOfEntityTypeKey(edmProperty);
					if (isPartOfKey != null)
					{
						flag2 = isPartOfKey;
						flag3 = flag4;
						if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
						{
							goto IL_212;
						}
					}
					global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath memberPath2 = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(this, edmProperty);
					bool flag5 = domainMap.IsConditionMember(memberPath2);
					if (isConditional != null)
					{
						flag2 = isConditional;
						flag3 = flag5;
						if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
						{
							goto IL_212;
						}
					}
					yield return memberPath2;
					goto IL_212;
				}
				goto IL_212;
			}
			global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Enumerator enumerator = default(global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x000F7E4C File Offset: 0x000F604C
		internal bool IsEquivalentViaRefConstraint(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath path1)
		{
			if (this.EdmType is global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase || path1.EdmType is global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase || !global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsNonRefSimpleMember(this.LeafEdmMember) || !global::System.Data.Entity.Core.Common.Utils.MetadataHelper.IsNonRefSimpleMember(path1.LeafEdmMember))
			{
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet = this.Extent as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationSet associationSet2 = path1.Extent as global::System.Data.Entity.Core.Metadata.Edm.AssociationSet;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = this.Extent as global::System.Data.Entity.Core.Metadata.Edm.EntitySet;
			global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet2 = path1.Extent as global::System.Data.Entity.Core.Metadata.Edm.EntitySet;
			bool result = false;
			if (associationSet != null && associationSet2 != null)
			{
				if (!associationSet.Equals(associationSet2))
				{
					return false;
				}
				result = global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.AreAssociationEndPathsEquivalentViaRefConstraint(this, path1, associationSet);
			}
			else
			{
				if (entitySet != null && entitySet2 != null)
				{
					using (global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.AssociationSet>.Enumerator enumerator = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetAssociationsForEntitySets(entitySet, entitySet2).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::System.Data.Entity.Core.Metadata.Edm.AssociationSet assocSet = enumerator.Current;
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath correspondingAssociationPath = this.GetCorrespondingAssociationPath(assocSet);
							global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath correspondingAssociationPath2 = path1.GetCorrespondingAssociationPath(assocSet);
							if (global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.AreAssociationEndPathsEquivalentViaRefConstraint(correspondingAssociationPath, correspondingAssociationPath2, assocSet))
							{
								result = true;
								break;
							}
						}
						return result;
					}
				}
				global::System.Data.Entity.Core.Metadata.Edm.AssociationSet assocSet2 = (associationSet != null) ? associationSet : associationSet2;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath assocPath = (this.Extent is global::System.Data.Entity.Core.Metadata.Edm.AssociationSet) ? this : path1;
				global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath correspondingAssociationPath3 = ((this.Extent is global::System.Data.Entity.Core.Metadata.Edm.EntitySet) ? this : path1).GetCorrespondingAssociationPath(assocSet2);
				result = (correspondingAssociationPath3 != null && global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.AreAssociationEndPathsEquivalentViaRefConstraint(assocPath, correspondingAssociationPath3, assocSet2));
			}
			return result;
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x000F7FA4 File Offset: 0x000F61A4
		private static bool AreAssociationEndPathsEquivalentViaRefConstraint(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath assocPath0, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath assocPath1, global::System.Data.Entity.Core.Metadata.Edm.AssociationSet assocSet)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = assocPath0.RootEdmMember as global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember;
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember2 = assocPath1.RootEdmMember as global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember;
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = assocPath0.LeafEdmMember as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty;
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty2 = assocPath1.LeafEdmMember as global::System.Data.Entity.Core.Metadata.Edm.EdmProperty;
			if (associationEndMember == null || associationEndMember2 == null || edmProperty == null || edmProperty2 == null)
			{
				return false;
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationType elementType = assocSet.ElementType;
			bool result = false;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint referentialConstraint in elementType.ReferentialConstraints)
			{
				bool flag = associationEndMember.Name == referentialConstraint.FromRole.Name && associationEndMember2.Name == referentialConstraint.ToRole.Name;
				bool flag2 = associationEndMember2.Name == referentialConstraint.FromRole.Name && associationEndMember.Name == referentialConstraint.ToRole.Name;
				if (flag || flag2)
				{
					global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> readOnlyMetadataCollection = flag ? referentialConstraint.FromProperties : referentialConstraint.ToProperties;
					global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> readOnlyMetadataCollection2 = flag ? referentialConstraint.ToProperties : referentialConstraint.FromProperties;
					int num = readOnlyMetadataCollection.IndexOf(edmProperty);
					int num2 = readOnlyMetadataCollection2.IndexOf(edmProperty2);
					if (num == num2 && num != -1)
					{
						result = true;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x000F8100 File Offset: 0x000F6300
		private global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath GetCorrespondingAssociationPath(global::System.Data.Entity.Core.Metadata.Edm.AssociationSet assocSet)
		{
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember someEndForEntitySet = global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetSomeEndForEntitySet(assocSet, this.m_extent);
			if (someEndForEntitySet == null)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>();
			list.Add(someEndForEntitySet);
			list.AddRange(this.m_path);
			return new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath(assocSet, list);
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x000F8140 File Offset: 0x000F6340
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet GetScopeOfRelationEnd()
		{
			if (this.m_path.Count == 0)
			{
				return null;
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = this.LeafEdmMember as global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember;
			if (associationEndMember == null)
			{
				return null;
			}
			return global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetEntitySetAtEnd((global::System.Data.Entity.Core.Metadata.Edm.AssociationSet)this.m_extent, associationEndMember);
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x000F8180 File Offset: 0x000F6380
		internal string PathToString(bool? forAlias)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (forAlias != null)
			{
				bool? flag = forAlias;
				bool flag2 = true;
				if (flag.GetValueOrDefault() == flag2 & flag != null)
				{
					if (this.m_path.Count == 0)
					{
						return this.m_extent.ElementType.Name;
					}
					stringBuilder.Append(this.m_path[0].DeclaringType.Name);
				}
				else
				{
					stringBuilder.Append(this.m_extent.Name);
				}
			}
			for (int i = 0; i < this.m_path.Count; i++)
			{
				stringBuilder.Append('.');
				stringBuilder.Append(this.m_path[i].Name);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x000F8240 File Offset: 0x000F6440
		internal override void ToCompactString(global::System.Text.StringBuilder builder)
		{
			builder.Append(this.PathToString(new bool?(false)));
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x000F8258 File Offset: 0x000F6458
		internal void ToCompactString(global::System.Text.StringBuilder builder, string instanceToken)
		{
			builder.Append(instanceToken + this.PathToString(null));
		}

		// Token: 0x04001922 RID: 6434
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase m_extent;

		// Token: 0x04001923 RID: 6435
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmMember> m_path;

		// Token: 0x04001924 RID: 6436
		internal static readonly global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath> EqualityComparer = new global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath.Comparer();

		// Token: 0x02000BDA RID: 3034
		private sealed class Comparer : global::System.Collections.Generic.IEqualityComparer<global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath>
		{
			// Token: 0x06006865 RID: 26725 RVA: 0x00162DB4 File Offset: 0x00160FB4
			public bool Equals(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath left, global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath right)
			{
				if (left == right)
				{
					return true;
				}
				if (left == null || right == null)
				{
					return false;
				}
				if (!left.m_extent.Equals(right.m_extent) || left.m_path.Count != right.m_path.Count)
				{
					return false;
				}
				for (int i = 0; i < left.m_path.Count; i++)
				{
					if (!left.m_path[i].Equals(right.m_path[i]))
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x06006866 RID: 26726 RVA: 0x00162E34 File Offset: 0x00161034
			public int GetHashCode(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.MemberPath key)
			{
				int num = key.m_extent.GetHashCode();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmMember edmMember in key.m_path)
				{
					num ^= edmMember.GetHashCode();
				}
				return num;
			}
		}
	}
}
