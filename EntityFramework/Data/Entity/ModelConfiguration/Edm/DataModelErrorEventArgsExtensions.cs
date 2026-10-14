using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Text;

namespace System.Data.Entity.ModelConfiguration.Edm
{
	// Token: 0x02000161 RID: 353
	internal static class DataModelErrorEventArgsExtensions
	{
		// Token: 0x06001629 RID: 5673 RVA: 0x00039160 File Offset: 0x00037360
		public static string ToErrorMessage(this global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs> validationErrors)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.AppendLine(global::System.Data.Entity.Resources.Strings.ValidationHeader);
			stringBuilder.AppendLine();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs dataModelErrorEventArgs in validationErrors)
			{
				stringBuilder.AppendLine(global::System.Data.Entity.Resources.Strings.ValidationItemFormat(dataModelErrorEventArgs.Item, dataModelErrorEventArgs.PropertyName, dataModelErrorEventArgs.ErrorMessage));
			}
			return stringBuilder.ToString();
		}
	}
}
