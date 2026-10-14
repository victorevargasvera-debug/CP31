using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Runtime.Serialization;

namespace System.Data.Entity.Validation
{
	// Token: 0x0200006E RID: 110
	[global::System.Serializable]
	public class DbEntityValidationException : global::System.Data.DataException
	{
		// Token: 0x06000416 RID: 1046 RVA: 0x0000E6BF File Offset: 0x0000C8BF
		public DbEntityValidationException() : this(global::System.Data.Entity.Resources.Strings.DbEntityValidationException_ValidationFailed)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000E6CC File Offset: 0x0000C8CC
		public DbEntityValidationException(string message) : this(message, global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Validation.DbEntityValidationResult>())
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000E6DA File Offset: 0x0000C8DA
		public DbEntityValidationException(string message, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbEntityValidationResult> entityValidationResults) : base(message)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbEntityValidationResult>>(entityValidationResults, "entityValidationResults");
			this.InititializeValidationResults(entityValidationResults);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000E6F6 File Offset: 0x0000C8F6
		public DbEntityValidationException(string message, global::System.Exception innerException) : this(message, global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Validation.DbEntityValidationResult>(), innerException)
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000E705 File Offset: 0x0000C905
		public DbEntityValidationException(string message, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbEntityValidationResult> entityValidationResults, global::System.Exception innerException) : base(message, innerException)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbEntityValidationResult>>(entityValidationResults, "entityValidationResults");
			this.InititializeValidationResults(entityValidationResults);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000E722 File Offset: 0x0000C922
		protected DbEntityValidationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this._entityValidationResults = (global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbEntityValidationResult>)info.GetValue("EntityValidationErrors", typeof(global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbEntityValidationResult>));
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0000E74C File Offset: 0x0000C94C
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbEntityValidationResult> EntityValidationErrors
		{
			get
			{
				return this._entityValidationResults;
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000E754 File Offset: 0x0000C954
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("EntityValidationErrors", this._entityValidationResults);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000E76F File Offset: 0x0000C96F
		private void InititializeValidationResults(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbEntityValidationResult> entityValidationResults)
		{
			this._entityValidationResults = ((entityValidationResults == null) ? new global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbEntityValidationResult>() : entityValidationResults.ToList<global::System.Data.Entity.Validation.DbEntityValidationResult>());
		}

		// Token: 0x0400010D RID: 269
		private global::System.Collections.Generic.IList<global::System.Data.Entity.Validation.DbEntityValidationResult> _entityValidationResults;
	}
}
