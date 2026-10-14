using System;
using System.Data.Entity.Resources;
using System.Globalization;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004B2 RID: 1202
	[global::System.Serializable]
	public sealed class EdmSchemaError : global::System.Data.Entity.Core.Metadata.Edm.EdmError
	{
		// Token: 0x06003B3E RID: 15166 RVA: 0x000C2CF2 File Offset: 0x000C0EF2
		public EdmSchemaError(string message, int errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity) : this(message, errorCode, severity, null)
		{
		}

		// Token: 0x06003B3F RID: 15167 RVA: 0x000C2CFE File Offset: 0x000C0EFE
		internal EdmSchemaError(string message, int errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity, global::System.Exception exception)
		{
			this._line = -1;
			this._column = -1;
			this._stackTrace = string.Empty;
			base..ctor(message);
			this.Initialize(errorCode, severity, null, -1, -1, exception);
		}

		// Token: 0x06003B40 RID: 15168 RVA: 0x000C2D2D File Offset: 0x000C0F2D
		internal EdmSchemaError(string message, int errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity, string schemaLocation, int line, int column) : this(message, errorCode, severity, schemaLocation, line, column, null)
		{
		}

		// Token: 0x06003B41 RID: 15169 RVA: 0x000C2D40 File Offset: 0x000C0F40
		internal EdmSchemaError(string message, int errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity, string schemaLocation, int line, int column, global::System.Exception exception)
		{
			this._line = -1;
			this._column = -1;
			this._stackTrace = string.Empty;
			base..ctor(message);
			if (severity < global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Warning || severity > global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error)
			{
				throw new global::System.ArgumentOutOfRangeException("severity", severity, global::System.Data.Entity.Resources.Strings.ArgumentOutOfRange(severity));
			}
			this.Initialize(errorCode, severity, schemaLocation, line, column, exception);
		}

		// Token: 0x06003B42 RID: 15170 RVA: 0x000C2DA4 File Offset: 0x000C0FA4
		private void Initialize(int errorCode, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity, string schemaLocation, int line, int column, global::System.Exception exception)
		{
			if (errorCode < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("errorCode", errorCode, global::System.Data.Entity.Resources.Strings.ArgumentOutOfRangeExpectedPostiveNumber(errorCode));
			}
			this._errorCode = errorCode;
			this._severity = severity;
			this._schemaLocation = schemaLocation;
			this._line = line;
			this._column = column;
			if (exception != null)
			{
				this._stackTrace = exception.StackTrace;
			}
		}

		// Token: 0x06003B43 RID: 15171 RVA: 0x000C2E08 File Offset: 0x000C1008
		public override string ToString()
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity = this.Severity;
			string text;
			if (severity != global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Warning)
			{
				if (severity == global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error)
				{
					text = global::System.Data.Entity.Resources.Strings.GeneratorErrorSeverityError;
				}
				else
				{
					text = global::System.Data.Entity.Resources.Strings.GeneratorErrorSeverityUnknown;
				}
			}
			else
			{
				text = global::System.Data.Entity.Resources.Strings.GeneratorErrorSeverityWarning;
			}
			string result;
			if (string.IsNullOrEmpty(this.SchemaName) && this.Line < 0 && this.Column < 0)
			{
				result = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "{0} {1:0000}: {2}", new object[]
				{
					text,
					this.ErrorCode,
					base.Message
				});
			}
			else
			{
				result = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "{0}({1},{2}) : {3} {4:0000}: {5}", new object[]
				{
					(this.SchemaName == null) ? global::System.Data.Entity.Resources.Strings.SourceUriUnknown : this.SchemaName,
					this.Line,
					this.Column,
					text,
					this.ErrorCode,
					base.Message
				});
			}
			return result;
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06003B44 RID: 15172 RVA: 0x000C2EF1 File Offset: 0x000C10F1
		public int ErrorCode
		{
			get
			{
				return this._errorCode;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06003B45 RID: 15173 RVA: 0x000C2EF9 File Offset: 0x000C10F9
		// (set) Token: 0x06003B46 RID: 15174 RVA: 0x000C2F01 File Offset: 0x000C1101
		public global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity Severity
		{
			get
			{
				return this._severity;
			}
			set
			{
				this._severity = value;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06003B47 RID: 15175 RVA: 0x000C2F0A File Offset: 0x000C110A
		public int Line
		{
			get
			{
				return this._line;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x000C2F12 File Offset: 0x000C1112
		public int Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06003B49 RID: 15177 RVA: 0x000C2F1A File Offset: 0x000C111A
		public string SchemaLocation
		{
			get
			{
				return this._schemaLocation;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06003B4A RID: 15178 RVA: 0x000C2F22 File Offset: 0x000C1122
		public string SchemaName
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError.GetNameFromSchemaLocation(this.SchemaLocation);
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06003B4B RID: 15179 RVA: 0x000C2F2F File Offset: 0x000C112F
		public string StackTrace
		{
			get
			{
				return this._stackTrace;
			}
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x000C2F38 File Offset: 0x000C1138
		private static string GetNameFromSchemaLocation(string schemaLocation)
		{
			if (string.IsNullOrEmpty(schemaLocation))
			{
				return schemaLocation;
			}
			int num = global::System.Math.Max(schemaLocation.LastIndexOf('/'), schemaLocation.LastIndexOf('\\'));
			int num2 = num + 1;
			if (num < 0)
			{
				return schemaLocation;
			}
			if (num2 >= schemaLocation.Length)
			{
				return string.Empty;
			}
			return schemaLocation.Substring(num2);
		}

		// Token: 0x0400147A RID: 5242
		private int _errorCode;

		// Token: 0x0400147B RID: 5243
		private global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity _severity;

		// Token: 0x0400147C RID: 5244
		private string _schemaLocation;

		// Token: 0x0400147D RID: 5245
		private int _line;

		// Token: 0x0400147E RID: 5246
		private int _column;

		// Token: 0x0400147F RID: 5247
		private string _stackTrace;
	}
}
