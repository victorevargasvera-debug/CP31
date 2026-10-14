using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000094 RID: 148
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal abstract class JsonSerializerInternalBase
	{
		// Token: 0x0600075E RID: 1886 RVA: 0x0001D7F5 File Offset: 0x0001B9F5
		protected JsonSerializerInternalBase(global::Newtonsoft.Json.JsonSerializer serializer)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(serializer, "serializer");
			this.Serializer = serializer;
			this.TraceWriter = serializer.TraceWriter;
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0001D81B File Offset: 0x0001BA1B
		internal global::Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> DefaultReferenceMappings
		{
			get
			{
				if (this._mappings == null)
				{
					this._mappings = new global::Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object>(global::System.Collections.Generic.EqualityComparer<string>.Default, new global::Newtonsoft.Json.Serialization.JsonSerializerInternalBase.ReferenceEqualsEqualityComparer(), "A different value already has the Id '{0}'.", "A different Id has already been assigned for value '{0}'. This error may be caused by an object being reused multiple times during deserialization and can be fixed with the setting ObjectCreationHandling.Replace.");
				}
				return this._mappings;
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0001D84C File Offset: 0x0001BA4C
		protected global::Newtonsoft.Json.NullValueHandling ResolvedNullValueHandling([global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonObjectContract containerContract, global::Newtonsoft.Json.Serialization.JsonProperty property)
		{
			global::Newtonsoft.Json.NullValueHandling? nullValueHandling = property.NullValueHandling;
			if (nullValueHandling != null)
			{
				return nullValueHandling.GetValueOrDefault();
			}
			global::Newtonsoft.Json.NullValueHandling? nullValueHandling2 = (containerContract != null) ? containerContract.ItemNullValueHandling : null;
			if (nullValueHandling2 == null)
			{
				return this.Serializer._nullValueHandling;
			}
			return nullValueHandling2.GetValueOrDefault();
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0001D8A2 File Offset: 0x0001BAA2
		private global::Newtonsoft.Json.Serialization.ErrorContext GetErrorContext([global::System.Runtime.CompilerServices.Nullable(2)] object currentObject, [global::System.Runtime.CompilerServices.Nullable(2)] object member, string path, global::System.Exception error)
		{
			if (this._currentErrorContext == null)
			{
				this._currentErrorContext = new global::Newtonsoft.Json.Serialization.ErrorContext(currentObject, member, path, error);
			}
			if (this._currentErrorContext.Error != error)
			{
				throw new global::System.InvalidOperationException("Current error context error is different to requested error.");
			}
			return this._currentErrorContext;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0001D8DC File Offset: 0x0001BADC
		protected void ClearErrorContext()
		{
			if (this._currentErrorContext == null)
			{
				throw new global::System.InvalidOperationException("Could not clear error context. Error context is already null.");
			}
			this._currentErrorContext = null;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0001D8F8 File Offset: 0x0001BAF8
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		protected bool IsErrorHandled(object currentObject, global::Newtonsoft.Json.Serialization.JsonContract contract, object keyValue, global::Newtonsoft.Json.IJsonLineInfo lineInfo, [global::System.Runtime.CompilerServices.Nullable(1)] string path, [global::System.Runtime.CompilerServices.Nullable(1)] global::System.Exception ex)
		{
			global::Newtonsoft.Json.Serialization.ErrorContext errorContext = this.GetErrorContext(currentObject, keyValue, path, ex);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Error && !errorContext.Traced)
			{
				errorContext.Traced = true;
				string text = (base.GetType() == typeof(global::Newtonsoft.Json.Serialization.JsonSerializerInternalWriter)) ? "Error serializing" : "Error deserializing";
				if (contract != null)
				{
					string str = text;
					string str2 = " ";
					global::System.Type underlyingType = contract.UnderlyingType;
					text = str + str2 + ((underlyingType != null) ? underlyingType.ToString() : null);
				}
				text = text + ". " + ex.Message;
				if (!(ex is global::Newtonsoft.Json.JsonException))
				{
					text = global::Newtonsoft.Json.JsonPosition.FormatMessage(lineInfo, path, text);
				}
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Error, text, ex);
			}
			if (contract != null && currentObject != null)
			{
				contract.InvokeOnError(currentObject, this.Serializer.Context, errorContext);
			}
			if (!errorContext.Handled)
			{
				this.Serializer.OnError(new global::Newtonsoft.Json.Serialization.ErrorEventArgs(currentObject, errorContext));
			}
			return errorContext.Handled;
		}

		// Token: 0x040002AA RID: 682
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::Newtonsoft.Json.Serialization.ErrorContext _currentErrorContext;

		// Token: 0x040002AB RID: 683
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private global::Newtonsoft.Json.Utilities.BidirectionalDictionary<string, object> _mappings;

		// Token: 0x040002AC RID: 684
		internal readonly global::Newtonsoft.Json.JsonSerializer Serializer;

		// Token: 0x040002AD RID: 685
		[global::System.Runtime.CompilerServices.Nullable(2)]
		internal readonly global::Newtonsoft.Json.Serialization.ITraceWriter TraceWriter;

		// Token: 0x040002AE RID: 686
		[global::System.Runtime.CompilerServices.Nullable(2)]
		protected global::Newtonsoft.Json.Serialization.JsonSerializerProxy InternalSerializer;

		// Token: 0x020001A5 RID: 421
		[global::System.Runtime.CompilerServices.Nullable(0)]
		private class ReferenceEqualsEqualityComparer : global::System.Collections.Generic.IEqualityComparer<object>
		{
			// Token: 0x06000F2B RID: 3883 RVA: 0x00042BDE File Offset: 0x00040DDE
			bool global::System.Collections.Generic.IEqualityComparer<object>.Equals(object x, object y)
			{
				return x == y;
			}

			// Token: 0x06000F2C RID: 3884 RVA: 0x00042BE4 File Offset: 0x00040DE4
			int global::System.Collections.Generic.IEqualityComparer<object>.GetHashCode(object obj)
			{
				return global::System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(obj);
			}
		}
	}
}
