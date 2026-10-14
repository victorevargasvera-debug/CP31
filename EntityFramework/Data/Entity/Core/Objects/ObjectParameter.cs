using System;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects.ELinq;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000418 RID: 1048
	public sealed class ObjectParameter
	{
		// Token: 0x06003235 RID: 12853 RVA: 0x000A0690 File Offset: 0x0009E890
		internal static bool ValidateParameterName(string name)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree.IsValidParameterName(name);
		}

		// Token: 0x06003236 RID: 12854 RVA: 0x000A0698 File Offset: 0x0009E898
		public ObjectParameter(string name, global::System.Type type)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(type, "type");
			if (!global::System.Data.Entity.Core.Objects.ObjectParameter.ValidateParameterName(name))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectParameter_InvalidParameterName(name), "name");
			}
			this._name = name;
			this._type = type;
			this._mappableType = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetNonNullableType(this._type);
		}

		// Token: 0x06003237 RID: 12855 RVA: 0x000A06FC File Offset: 0x0009E8FC
		public ObjectParameter(string name, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(name, "name");
			global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
			if (!global::System.Data.Entity.Core.Objects.ObjectParameter.ValidateParameterName(name))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectParameter_InvalidParameterName(name), "name");
			}
			this._name = name;
			this._type = value.GetType();
			this._value = value;
			this._mappableType = global::System.Data.Entity.Core.Objects.ELinq.TypeSystem.GetNonNullableType(this._type);
		}

		// Token: 0x06003238 RID: 12856 RVA: 0x000A076C File Offset: 0x0009E96C
		private ObjectParameter(global::System.Data.Entity.Core.Objects.ObjectParameter template)
		{
			this._name = template._name;
			this._type = template._type;
			this._mappableType = template._mappableType;
			this._effectiveType = template._effectiveType;
			this._value = template._value;
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06003239 RID: 12857 RVA: 0x000A07BB File Offset: 0x0009E9BB
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x0600323A RID: 12858 RVA: 0x000A07C3 File Offset: 0x0009E9C3
		public global::System.Type ParameterType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x0600323B RID: 12859 RVA: 0x000A07CB File Offset: 0x0009E9CB
		// (set) Token: 0x0600323C RID: 12860 RVA: 0x000A07D3 File Offset: 0x0009E9D3
		public object Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x0600323D RID: 12861 RVA: 0x000A07DC File Offset: 0x0009E9DC
		// (set) Token: 0x0600323E RID: 12862 RVA: 0x000A07E4 File Offset: 0x0009E9E4
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage
		{
			get
			{
				return this._effectiveType;
			}
			set
			{
				this._effectiveType = value;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x0600323F RID: 12863 RVA: 0x000A07ED File Offset: 0x0009E9ED
		internal global::System.Type MappableType
		{
			get
			{
				return this._mappableType;
			}
		}

		// Token: 0x06003240 RID: 12864 RVA: 0x000A07F5 File Offset: 0x0009E9F5
		internal global::System.Data.Entity.Core.Objects.ObjectParameter ShallowCopy()
		{
			return new global::System.Data.Entity.Core.Objects.ObjectParameter(this);
		}

		// Token: 0x06003241 RID: 12865 RVA: 0x000A0800 File Offset: 0x0009EA00
		internal bool ValidateParameterType(global::System.Data.Entity.Core.Metadata.Edm.ClrPerspective perspective)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type;
			return perspective.TryGetType(this._mappableType, out type) && global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsScalarType(type);
		}

		// Token: 0x04001076 RID: 4214
		private readonly string _name;

		// Token: 0x04001077 RID: 4215
		private readonly global::System.Type _type;

		// Token: 0x04001078 RID: 4216
		private readonly global::System.Type _mappableType;

		// Token: 0x04001079 RID: 4217
		private global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _effectiveType;

		// Token: 0x0400107A RID: 4218
		private object _value;
	}
}
