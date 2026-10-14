using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Runtime.Serialization;

namespace System.Data.Entity.ModelConfiguration
{
	// Token: 0x02000157 RID: 343
	[global::System.Serializable]
	public class ModelValidationException : global::System.Exception
	{
		// Token: 0x060015ED RID: 5613 RVA: 0x00037DC4 File Offset: 0x00035FC4
		public ModelValidationException()
		{
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00037DCC File Offset: 0x00035FCC
		public ModelValidationException(string message) : base(message)
		{
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00037DD5 File Offset: 0x00035FD5
		public ModelValidationException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00037DDF File Offset: 0x00035FDF
		internal ModelValidationException(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.DataModelErrorEventArgs> validationErrors) : base(validationErrors.ToErrorMessage())
		{
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00037DED File Offset: 0x00035FED
		protected ModelValidationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}
	}
}
