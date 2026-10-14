using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200008A RID: 138
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public abstract class JsonContract
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0001C45F File Offset: 0x0001A65F
		public global::System.Type UnderlyingType { get; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0001C467 File Offset: 0x0001A667
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x0001C470 File Offset: 0x0001A670
		public global::System.Type CreatedType
		{
			get
			{
				return this._createdType;
			}
			set
			{
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
				this._createdType = value;
				this.IsSealed = this._createdType.IsSealed();
				this.IsInstantiable = (!this._createdType.IsInterface() && !this._createdType.IsAbstract());
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x0001C4CC File Offset: 0x0001A6CC
		public bool? IsReference { get; set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0001C4D5 File Offset: 0x0001A6D5
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x0001C4DD File Offset: 0x0001A6DD
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.JsonConverter Converter { [global::System.Runtime.CompilerServices.NullableContext(2)] get; [global::System.Runtime.CompilerServices.NullableContext(2)] set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0001C4E6 File Offset: 0x0001A6E6
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0001C4EE File Offset: 0x0001A6EE
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.JsonConverter InternalConverter { [global::System.Runtime.CompilerServices.NullableContext(2)] get; [global::System.Runtime.CompilerServices.NullableContext(2)] internal set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x0001C4F7 File Offset: 0x0001A6F7
		public global::System.Collections.Generic.IList<global::Newtonsoft.Json.Serialization.SerializationCallback> OnDeserializedCallbacks
		{
			get
			{
				if (this._onDeserializedCallbacks == null)
				{
					this._onDeserializedCallbacks = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback>();
				}
				return this._onDeserializedCallbacks;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0001C512 File Offset: 0x0001A712
		public global::System.Collections.Generic.IList<global::Newtonsoft.Json.Serialization.SerializationCallback> OnDeserializingCallbacks
		{
			get
			{
				if (this._onDeserializingCallbacks == null)
				{
					this._onDeserializingCallbacks = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback>();
				}
				return this._onDeserializingCallbacks;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x0001C52D File Offset: 0x0001A72D
		public global::System.Collections.Generic.IList<global::Newtonsoft.Json.Serialization.SerializationCallback> OnSerializedCallbacks
		{
			get
			{
				if (this._onSerializedCallbacks == null)
				{
					this._onSerializedCallbacks = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback>();
				}
				return this._onSerializedCallbacks;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0001C548 File Offset: 0x0001A748
		public global::System.Collections.Generic.IList<global::Newtonsoft.Json.Serialization.SerializationCallback> OnSerializingCallbacks
		{
			get
			{
				if (this._onSerializingCallbacks == null)
				{
					this._onSerializingCallbacks = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback>();
				}
				return this._onSerializingCallbacks;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0001C563 File Offset: 0x0001A763
		public global::System.Collections.Generic.IList<global::Newtonsoft.Json.Serialization.SerializationErrorCallback> OnErrorCallbacks
		{
			get
			{
				if (this._onErrorCallbacks == null)
				{
					this._onErrorCallbacks = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationErrorCallback>();
				}
				return this._onErrorCallbacks;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x0001C57E File Offset: 0x0001A77E
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x0001C586 File Offset: 0x0001A786
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		public global::System.Func<object> DefaultCreator { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] get; [param: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0001C58F File Offset: 0x0001A78F
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x0001C597 File Offset: 0x0001A797
		public bool DefaultCreatorNonPublic { get; set; }

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001C5A0 File Offset: 0x0001A7A0
		internal JsonContract(global::System.Type underlyingType)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(underlyingType, "underlyingType");
			this.UnderlyingType = underlyingType;
			underlyingType = global::Newtonsoft.Json.Utilities.ReflectionUtils.EnsureNotByRefType(underlyingType);
			this.IsNullable = global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullable(underlyingType);
			this.NonNullableUnderlyingType = ((this.IsNullable && global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(underlyingType)) ? global::System.Nullable.GetUnderlyingType(underlyingType) : underlyingType);
			this._createdType = (this.CreatedType = this.NonNullableUnderlyingType);
			this.IsConvertable = global::Newtonsoft.Json.Utilities.ConvertUtils.IsConvertible(this.NonNullableUnderlyingType);
			this.IsEnum = this.NonNullableUnderlyingType.IsEnum();
			this.InternalReadType = global::Newtonsoft.Json.ReadType.Read;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001C638 File Offset: 0x0001A838
		internal void InvokeOnSerializing(object o, global::System.Runtime.Serialization.StreamingContext context)
		{
			if (this._onSerializingCallbacks != null)
			{
				foreach (global::Newtonsoft.Json.Serialization.SerializationCallback serializationCallback in this._onSerializingCallbacks)
				{
					serializationCallback(o, context);
				}
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001C694 File Offset: 0x0001A894
		internal void InvokeOnSerialized(object o, global::System.Runtime.Serialization.StreamingContext context)
		{
			if (this._onSerializedCallbacks != null)
			{
				foreach (global::Newtonsoft.Json.Serialization.SerializationCallback serializationCallback in this._onSerializedCallbacks)
				{
					serializationCallback(o, context);
				}
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001C6F0 File Offset: 0x0001A8F0
		internal void InvokeOnDeserializing(object o, global::System.Runtime.Serialization.StreamingContext context)
		{
			if (this._onDeserializingCallbacks != null)
			{
				foreach (global::Newtonsoft.Json.Serialization.SerializationCallback serializationCallback in this._onDeserializingCallbacks)
				{
					serializationCallback(o, context);
				}
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001C74C File Offset: 0x0001A94C
		internal void InvokeOnDeserialized(object o, global::System.Runtime.Serialization.StreamingContext context)
		{
			if (this._onDeserializedCallbacks != null)
			{
				foreach (global::Newtonsoft.Json.Serialization.SerializationCallback serializationCallback in this._onDeserializedCallbacks)
				{
					serializationCallback(o, context);
				}
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0001C7A8 File Offset: 0x0001A9A8
		internal void InvokeOnError(object o, global::System.Runtime.Serialization.StreamingContext context, global::Newtonsoft.Json.Serialization.ErrorContext errorContext)
		{
			if (this._onErrorCallbacks != null)
			{
				foreach (global::Newtonsoft.Json.Serialization.SerializationErrorCallback serializationErrorCallback in this._onErrorCallbacks)
				{
					serializationErrorCallback(o, context, errorContext);
				}
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001C804 File Offset: 0x0001AA04
		internal static global::Newtonsoft.Json.Serialization.SerializationCallback CreateSerializationCallback(global::System.Reflection.MethodInfo callbackMethodInfo)
		{
			return delegate(object o, global::System.Runtime.Serialization.StreamingContext context)
			{
				callbackMethodInfo.Invoke(o, new object[]
				{
					context
				});
			};
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0001C81D File Offset: 0x0001AA1D
		internal static global::Newtonsoft.Json.Serialization.SerializationErrorCallback CreateSerializationErrorCallback(global::System.Reflection.MethodInfo callbackMethodInfo)
		{
			return delegate(object o, global::System.Runtime.Serialization.StreamingContext context, global::Newtonsoft.Json.Serialization.ErrorContext econtext)
			{
				callbackMethodInfo.Invoke(o, new object[]
				{
					context,
					econtext
				});
			};
		}

		// Token: 0x0400024E RID: 590
		internal bool IsNullable;

		// Token: 0x0400024F RID: 591
		internal bool IsConvertable;

		// Token: 0x04000250 RID: 592
		internal bool IsEnum;

		// Token: 0x04000251 RID: 593
		internal global::System.Type NonNullableUnderlyingType;

		// Token: 0x04000252 RID: 594
		internal global::Newtonsoft.Json.ReadType InternalReadType;

		// Token: 0x04000253 RID: 595
		internal global::Newtonsoft.Json.Serialization.JsonContractType ContractType;

		// Token: 0x04000254 RID: 596
		internal bool IsReadOnlyOrFixedSize;

		// Token: 0x04000255 RID: 597
		internal bool IsSealed;

		// Token: 0x04000256 RID: 598
		internal bool IsInstantiable;

		// Token: 0x04000257 RID: 599
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializedCallbacks;

		// Token: 0x04000258 RID: 600
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback> _onDeserializingCallbacks;

		// Token: 0x04000259 RID: 601
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback> _onSerializedCallbacks;

		// Token: 0x0400025A RID: 602
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationCallback> _onSerializingCallbacks;

		// Token: 0x0400025B RID: 603
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		private global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.SerializationErrorCallback> _onErrorCallbacks;

		// Token: 0x0400025C RID: 604
		private global::System.Type _createdType;
	}
}
