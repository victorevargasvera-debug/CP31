using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Infrastructure.Annotations
{
	// Token: 0x020002C5 RID: 709
	public class IndexAnnotation : global::System.Data.Entity.Infrastructure.Annotations.IMergeableAnnotation
	{
		// Token: 0x0600222B RID: 8747 RVA: 0x0005F0B3 File Offset: 0x0005D2B3
		public IndexAnnotation(global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute indexAttribute)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute>(indexAttribute, "indexAttribute");
			this._indexes.Add(indexAttribute);
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x0005F0DE File Offset: 0x0005D2DE
		public IndexAnnotation(global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute> indexAttributes)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute>>(indexAttributes, "indexAttributes");
			global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation.MergeLists(this._indexes, indexAttributes, null);
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x0005F10A File Offset: 0x0005D30A
		internal IndexAnnotation(global::System.Reflection.PropertyInfo propertyInfo, global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute> indexAttributes)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute>>(indexAttributes, "indexAttributes");
			global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation.MergeLists(this._indexes, indexAttributes, propertyInfo);
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x0005F138 File Offset: 0x0005D338
		private static void MergeLists(global::System.Collections.Generic.ICollection<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute> existingIndexes, global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute> newIndexes, global::System.Reflection.PropertyInfo propertyInfo)
		{
			using (global::System.Collections.Generic.IEnumerator<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute> enumerator = newIndexes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute index = enumerator.Current;
					if (index == null)
					{
						throw new global::System.ArgumentNullException("indexAttribute");
					}
					global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute indexAttribute = existingIndexes.SingleOrDefault((global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute i) => i.Name == index.Name);
					if (indexAttribute == null)
					{
						existingIndexes.Add(index);
					}
					else
					{
						global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult compatibilityResult = index.IsCompatibleWith(indexAttribute, false);
						if (!compatibilityResult)
						{
							string text = global::System.Environment.NewLine + "\t" + compatibilityResult.ErrorMessage;
							throw new global::System.InvalidOperationException((propertyInfo == null) ? global::System.Data.Entity.Resources.Strings.ConflictingIndexAttribute(indexAttribute.Name, text) : global::System.Data.Entity.Resources.Strings.ConflictingIndexAttributesOnProperty(propertyInfo.Name, propertyInfo.ReflectedType.Name, indexAttribute.Name, text));
						}
						existingIndexes.Remove(indexAttribute);
						existingIndexes.Add(index.MergeWith(indexAttribute, false));
					}
				}
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x0005F24C File Offset: 0x0005D44C
		public virtual global::System.Collections.Generic.IEnumerable<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute> Indexes
		{
			get
			{
				return this._indexes;
			}
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x0005F254 File Offset: 0x0005D454
		public virtual global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult IsCompatibleWith(object other)
		{
			if (this == other || other == null)
			{
				return new global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult(true, null);
			}
			global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation indexAnnotation = other as global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation;
			if (indexAnnotation == null)
			{
				return new global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult(false, global::System.Data.Entity.Resources.Strings.IncompatibleTypes(other.GetType().Name, typeof(global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation).Name));
			}
			using (global::System.Collections.Generic.IEnumerator<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute> enumerator = indexAnnotation._indexes.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute newIndex = enumerator.Current;
					global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute indexAttribute = this._indexes.SingleOrDefault((global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute i) => i.Name == newIndex.Name);
					if (indexAttribute != null)
					{
						global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult result = indexAttribute.IsCompatibleWith(newIndex, false);
						if (!result)
						{
							return result;
						}
					}
				}
			}
			return new global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult(true, null);
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x0005F328 File Offset: 0x0005D528
		public virtual object MergeWith(object other)
		{
			if (this == other || other == null)
			{
				return this;
			}
			global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation indexAnnotation = other as global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation;
			if (indexAnnotation == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.IncompatibleTypes(other.GetType().Name, typeof(global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation).Name));
			}
			global::System.Collections.Generic.List<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute> list = this._indexes.ToList<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute>();
			global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation.MergeLists(list, indexAnnotation._indexes, null);
			return new global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotation(list);
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x0005F38A File Offset: 0x0005D58A
		public override string ToString()
		{
			return "IndexAnnotation: " + new global::System.Data.Entity.Infrastructure.Annotations.IndexAnnotationSerializer().Serialize("Index", this);
		}

		// Token: 0x04000BE2 RID: 3042
		public const string AnnotationName = "Index";

		// Token: 0x04000BE3 RID: 3043
		private readonly global::System.Collections.Generic.IList<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute> _indexes = new global::System.Collections.Generic.List<global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute>();
	}
}
