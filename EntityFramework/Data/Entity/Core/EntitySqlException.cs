using System;
using System.Data.Entity.Core.Common.EntitySql;
using System.Data.Entity.Resources;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;

namespace System.Data.Entity.Core
{
	// Token: 0x020002D4 RID: 724
	[global::System.Serializable]
	public sealed class EntitySqlException : global::System.Data.Entity.Core.EntityException
	{
		// Token: 0x060022F9 RID: 8953 RVA: 0x000622AD File Offset: 0x000604AD
		public EntitySqlException() : this(global::System.Data.Entity.Resources.Strings.GeneralQueryError)
		{
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x000622BA File Offset: 0x000604BA
		public EntitySqlException(string message) : base(message)
		{
			base.HResult = -2146232006;
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x000622CE File Offset: 0x000604CE
		public EntitySqlException(string message, global::System.Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232006;
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x000622E4 File Offset: 0x000604E4
		private EntitySqlException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			this._errorDescription = info.GetString("ErrorDescription");
			this._errorContext = info.GetString("ErrorContext");
			this.Line = info.GetInt32("Line");
			this.Column = info.GetInt32("Column");
		}

		// Token: 0x060022FD RID: 8957 RVA: 0x0006233D File Offset: 0x0006053D
		internal static global::System.Data.Entity.Core.EntitySqlException Create(global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, string errorMessage, global::System.Exception innerException)
		{
			return global::System.Data.Entity.Core.EntitySqlException.Create(errCtx.CommandText, errorMessage, errCtx.InputPosition, errCtx.ErrorContextInfo, errCtx.UseContextInfoAsResourceIdentifier, innerException);
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x00062360 File Offset: 0x00060560
		internal static global::System.Data.Entity.Core.EntitySqlException Create(string commandText, string errorDescription, int errorPosition, string errorContextInfo, bool loadErrorContextInfoFromResource, global::System.Exception innerException)
		{
			int line;
			int column;
			string errorContext = global::System.Data.Entity.Core.EntitySqlException.FormatErrorContext(commandText, errorPosition, errorContextInfo, loadErrorContextInfoFromResource, out line, out column);
			return new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Core.EntitySqlException.FormatQueryError(errorDescription, errorContext), errorDescription, errorContext, line, column, innerException);
		}

		// Token: 0x060022FF RID: 8959 RVA: 0x0006238E File Offset: 0x0006058E
		private EntitySqlException(string message, string errorDescription, string errorContext, int line, int column, global::System.Exception innerException) : base(message, innerException)
		{
			this._errorDescription = errorDescription;
			this._errorContext = errorContext;
			this.Line = line;
			this.Column = column;
			base.HResult = -2146232006;
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x000623C2 File Offset: 0x000605C2
		public string ErrorDescription
		{
			get
			{
				return this._errorDescription ?? string.Empty;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x000623D3 File Offset: 0x000605D3
		public string ErrorContext
		{
			get
			{
				return this._errorContext ?? string.Empty;
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x000623E4 File Offset: 0x000605E4
		public int Line { get; }

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x000623EC File Offset: 0x000605EC
		public int Column { get; }

		// Token: 0x06002304 RID: 8964 RVA: 0x000623F4 File Offset: 0x000605F4
		internal static string GetGenericErrorMessage(string commandText, int position)
		{
			int num = 0;
			int num2 = 0;
			return global::System.Data.Entity.Core.EntitySqlException.FormatErrorContext(commandText, position, "GenericSyntaxError", true, out num, out num2);
		}

		// Token: 0x06002305 RID: 8965 RVA: 0x00062418 File Offset: 0x00060618
		internal static string FormatErrorContext(string commandText, int errorPosition, string errorContextInfo, bool loadErrorContextInfoFromResource, out int lineNumber, out int columnNumber)
		{
			if (loadErrorContextInfoFromResource)
			{
				errorContextInfo = ((!string.IsNullOrEmpty(errorContextInfo)) ? global::System.Data.Entity.Resources.EntityRes.GetString(errorContextInfo) : string.Empty);
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(commandText.Length);
			foreach (char c in commandText)
			{
				if (global::System.Data.Entity.Core.Common.EntitySql.CqlLexer.IsNewLine(c))
				{
					c = '\n';
				}
				else if ((char.IsControl(c) || char.IsWhiteSpace(c)) && '\r' != c)
				{
					c = ' ';
				}
				stringBuilder.Append(c);
			}
			commandText = stringBuilder.ToString().TrimEnd(new char[]
			{
				'\n'
			});
			string[] array = commandText.Split(new char[]
			{
				'\n'
			}, global::System.StringSplitOptions.None);
			lineNumber = 0;
			columnNumber = errorPosition;
			while (lineNumber < array.Length && columnNumber > array[lineNumber].Length)
			{
				columnNumber -= array[lineNumber].Length + 1;
				lineNumber++;
			}
			lineNumber++;
			columnNumber++;
			stringBuilder = new global::System.Text.StringBuilder();
			if (!string.IsNullOrEmpty(errorContextInfo))
			{
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.CurrentCulture, "{0}, ", new object[]
				{
					errorContextInfo
				});
			}
			if (errorPosition >= 0)
			{
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.CurrentCulture, "{0} {1}, {2} {3}", new object[]
				{
					global::System.Data.Entity.Resources.Strings.LocalizedLine,
					lineNumber,
					global::System.Data.Entity.Resources.Strings.LocalizedColumn,
					columnNumber
				});
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06002306 RID: 8966 RVA: 0x00062578 File Offset: 0x00060778
		private static string FormatQueryError(string errorMessage, string errorContext)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(errorMessage);
			if (!string.IsNullOrEmpty(errorContext))
			{
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.CurrentCulture, " {0} {1}", new object[]
				{
					global::System.Data.Entity.Resources.Strings.LocalizedNear,
					errorContext
				});
			}
			return stringBuilder.Append(".").ToString();
		}

		// Token: 0x06002307 RID: 8967 RVA: 0x000625D0 File Offset: 0x000607D0
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("ErrorDescription", this._errorDescription);
			info.AddValue("ErrorContext", this._errorContext);
			info.AddValue("Line", this.Line);
			info.AddValue("Column", this.Column);
		}

		// Token: 0x04000C06 RID: 3078
		private const int HResultInvalidQuery = -2146232006;

		// Token: 0x04000C07 RID: 3079
		private readonly string _errorDescription;

		// Token: 0x04000C08 RID: 3080
		private readonly string _errorContext;
	}
}
