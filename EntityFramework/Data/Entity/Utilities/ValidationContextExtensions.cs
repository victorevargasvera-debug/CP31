using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Internal;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000084 RID: 132
	internal static class ValidationContextExtensions
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x0000F3F4 File Offset: 0x0000D5F4
		public static void SetDisplayName(this global::System.ComponentModel.DataAnnotations.ValidationContext validationContext, global::System.Data.Entity.Internal.InternalMemberEntry property, global::System.ComponentModel.DataAnnotations.DisplayAttribute displayAttribute)
		{
			string text = (displayAttribute == null) ? null : displayAttribute.GetName();
			if (property == null)
			{
				global::System.Type objectType = global::System.Data.Entity.Internal.ObjectContextTypeCache.GetObjectType(validationContext.ObjectType);
				validationContext.DisplayName = (text ?? objectType.Name);
				validationContext.MemberName = null;
				return;
			}
			validationContext.DisplayName = (text ?? global::System.Data.Entity.Internal.DbHelpers.GetPropertyPath(property));
			validationContext.MemberName = global::System.Data.Entity.Internal.DbHelpers.GetPropertyPath(property);
		}
	}
}
