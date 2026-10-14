using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Infrastructure.Annotations
{
	// Token: 0x020002C7 RID: 711
	internal static class IndexAttributeExtensions
	{
		// Token: 0x06002239 RID: 8761 RVA: 0x0005F8AC File Offset: 0x0005DAAC
		internal static global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult IsCompatibleWith(this global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute me, global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute other, bool ignoreOrder = false)
		{
			if (me == other || other == null)
			{
				return new global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult(true, null);
			}
			string text = null;
			if (me.Name != other.Name)
			{
				text = global::System.Data.Entity.Resources.Strings.ConflictingIndexAttributeProperty("Name", me.Name, other.Name);
			}
			if (!ignoreOrder && me.Order != -1 && other.Order != -1 && me.Order != other.Order)
			{
				text = ((text == null) ? "" : (text + global::System.Environment.NewLine + "\t"));
				text += global::System.Data.Entity.Resources.Strings.ConflictingIndexAttributeProperty("Order", me.Order, other.Order);
			}
			if (me.IsClusteredConfigured && other.IsClusteredConfigured && me.IsClustered != other.IsClustered)
			{
				text = ((text == null) ? "" : (text + global::System.Environment.NewLine + "\t"));
				text += global::System.Data.Entity.Resources.Strings.ConflictingIndexAttributeProperty("IsClustered", me.IsClustered, other.IsClustered);
			}
			if (me.IsUniqueConfigured && other.IsUniqueConfigured && me.IsUnique != other.IsUnique)
			{
				text = ((text == null) ? "" : (text + global::System.Environment.NewLine + "\t"));
				text += global::System.Data.Entity.Resources.Strings.ConflictingIndexAttributeProperty("IsUnique", me.IsUnique, other.IsUnique);
			}
			return new global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult(text == null, text);
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x0005FA24 File Offset: 0x0005DC24
		internal static global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute MergeWith(this global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute me, global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute other, bool ignoreOrder = false)
		{
			if (me == other || other == null)
			{
				return me;
			}
			global::System.Data.Entity.Infrastructure.Annotations.CompatibilityResult compatibilityResult = me.IsCompatibleWith(other, ignoreOrder);
			if (!compatibilityResult)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConflictingIndexAttribute(me.Name, global::System.Environment.NewLine + "\t" + compatibilityResult.ErrorMessage));
			}
			global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute indexAttribute = (me.Name != null) ? new global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute(me.Name) : ((other.Name != null) ? new global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute(other.Name) : new global::System.ComponentModel.DataAnnotations.Schema.IndexAttribute());
			if (!ignoreOrder)
			{
				if (me.Order != -1)
				{
					indexAttribute.Order = me.Order;
				}
				else if (other.Order != -1)
				{
					indexAttribute.Order = other.Order;
				}
			}
			if (me.IsClusteredConfigured)
			{
				indexAttribute.IsClustered = me.IsClustered;
			}
			else if (other.IsClusteredConfigured)
			{
				indexAttribute.IsClustered = other.IsClustered;
			}
			if (me.IsUniqueConfigured)
			{
				indexAttribute.IsUnique = me.IsUnique;
			}
			else if (other.IsUniqueConfigured)
			{
				indexAttribute.IsUnique = other.IsUnique;
			}
			return indexAttribute;
		}
	}
}
