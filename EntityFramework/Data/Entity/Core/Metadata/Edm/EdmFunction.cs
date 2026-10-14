using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004A4 RID: 1188
	public class EdmFunction : global::System.Data.Entity.Core.Metadata.Edm.EdmType
	{
		// Token: 0x06003A5A RID: 14938 RVA: 0x000BFF95 File Offset: 0x000BE195
		internal EdmFunction(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace) : this(name, namespaceName, dataSpace, new global::System.Data.Entity.Core.Metadata.Edm.EdmFunctionPayload())
		{
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x000BFFA8 File Offset: 0x000BE1A8
		internal EdmFunction(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Metadata.Edm.EdmFunctionPayload payload) : base(name, namespaceName, dataSpace)
		{
			this._schemaName = payload.Schema;
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> list = payload.ReturnParameters ?? new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[0];
			foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter in list)
			{
				if (functionParameter == null)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_CollectionParameterElementIsNull("ReturnParameters"));
				}
				if (functionParameter.Mode != global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.ReturnValue)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NonReturnParameterInReturnParameterCollection);
				}
			}
			this._returnParameters = new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>((from returnParameter in list
			select global::System.Data.Entity.Core.Metadata.Edm.SafeLink<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>.BindChild<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(this, global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter.DeclaringFunctionLinker, returnParameter)).ToList<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>());
			if (payload.IsAggregate != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.SetFunctionAttribute(ref this._functionAttributes, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.Aggregate, payload.IsAggregate.Value);
			}
			if (payload.IsBuiltIn != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.SetFunctionAttribute(ref this._functionAttributes, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.BuiltIn, payload.IsBuiltIn.Value);
			}
			if (payload.IsNiladic != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.SetFunctionAttribute(ref this._functionAttributes, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.NiladicFunction, payload.IsNiladic.Value);
			}
			if (payload.IsComposable != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.SetFunctionAttribute(ref this._functionAttributes, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.IsComposable, payload.IsComposable.Value);
			}
			if (payload.IsFromProviderManifest != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.SetFunctionAttribute(ref this._functionAttributes, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.IsFromProviderManifest, payload.IsFromProviderManifest.Value);
			}
			if (payload.IsCachedStoreFunction != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.SetFunctionAttribute(ref this._functionAttributes, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.IsCachedStoreFunction, payload.IsCachedStoreFunction.Value);
			}
			if (payload.IsFunctionImport != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.SetFunctionAttribute(ref this._functionAttributes, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.IsFunctionImport, payload.IsFunctionImport.Value);
			}
			if (payload.ParameterTypeSemantics != null)
			{
				this._parameterTypeSemantics = payload.ParameterTypeSemantics.Value;
			}
			if (payload.StoreFunctionName != null)
			{
				this._storeFunctionNameAttribute = payload.StoreFunctionName;
			}
			if (payload.EntitySets != null)
			{
				if (payload.EntitySets.Count != list.Count)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NumberOfEntitySetsDoesNotMatchNumberOfReturnParameters);
				}
				this._entitySets = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(payload.EntitySets);
			}
			else
			{
				if (this._returnParameters.Count > 1)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.NullEntitySetsForFunctionReturningMultipleResultSets);
				}
				this._entitySets = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>((from p in this._returnParameters
				select null).ToList<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>());
			}
			if (payload.CommandText != null)
			{
				this._commandTextAttribute = payload.CommandText;
			}
			if (payload.Parameters != null)
			{
				foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter2 in payload.Parameters)
				{
					if (functionParameter2 == null)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_CollectionParameterElementIsNull("parameters"));
					}
					if (functionParameter2.Mode == global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.ReturnValue)
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ReturnParameterInInputParameterCollection);
					}
				}
				this._parameters = new global::System.Data.Entity.Core.Metadata.Edm.SafeLinkCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction, global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(this, global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter.DeclaringFunctionLinker, new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(payload.Parameters));
				return;
			}
			this._parameters = new global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(new global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>());
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06003A5C RID: 14940 RVA: 0x000C030C File Offset: 0x000BE50C
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EdmFunction;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06003A5D RID: 14941 RVA: 0x000C0310 File Offset: 0x000BE510
		public override string FullName
		{
			get
			{
				return this.NamespaceName + "." + this.Name;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06003A5E RID: 14942 RVA: 0x000C0328 File Offset: 0x000BE528
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> Parameters
		{
			get
			{
				return this._parameters;
			}
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x000C0330 File Offset: 0x000BE530
		public void AddParameter(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(functionParameter, "functionParameter");
			global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
			if (functionParameter.Mode == global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.ReturnValue)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ReturnParameterInInputParameterCollection);
			}
			this._parameters.Source.Add(functionParameter);
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06003A60 RID: 14944 RVA: 0x000C0369 File Offset: 0x000BE569
		internal bool HasUserDefinedBody
		{
			get
			{
				return this.IsModelDefinedFunction && !string.IsNullOrEmpty(this.CommandTextAttribute);
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06003A61 RID: 14945 RVA: 0x000C0383 File Offset: 0x000BE583
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet, false)]
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet
		{
			get
			{
				if (this._entitySets.Count == 0)
				{
					return null;
				}
				return this._entitySets[0];
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06003A62 RID: 14946 RVA: 0x000C03A0 File Offset: 0x000BE5A0
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.EntitySet, true)]
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> EntitySets
		{
			get
			{
				return this._entitySets;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06003A63 RID: 14947 RVA: 0x000C03A8 File Offset: 0x000BE5A8
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.FunctionParameter, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter ReturnParameter
		{
			get
			{
				return this._returnParameters.FirstOrDefault<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>();
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06003A64 RID: 14948 RVA: 0x000C03B5 File Offset: 0x000BE5B5
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.FunctionParameter, true)]
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> ReturnParameters
		{
			get
			{
				return this._returnParameters;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06003A65 RID: 14949 RVA: 0x000C03BD File Offset: 0x000BE5BD
		// (set) Token: 0x06003A66 RID: 14950 RVA: 0x000C03C5 File Offset: 0x000BE5C5
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public string StoreFunctionNameAttribute
		{
			get
			{
				return this._storeFunctionNameAttribute;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._storeFunctionNameAttribute = value;
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06003A67 RID: 14951 RVA: 0x000C03E0 File Offset: 0x000BE5E0
		internal string FunctionName
		{
			get
			{
				return this.StoreFunctionNameAttribute ?? this.Name;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06003A68 RID: 14952 RVA: 0x000C03F2 File Offset: 0x000BE5F2
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(typeof(global::System.Data.Entity.Core.Metadata.Edm.ParameterTypeSemantics), false)]
		public global::System.Data.Entity.Core.Metadata.Edm.ParameterTypeSemantics ParameterTypeSemanticsAttribute
		{
			get
			{
				return this._parameterTypeSemantics;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06003A69 RID: 14953 RVA: 0x000C03FA File Offset: 0x000BE5FA
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, false)]
		public bool AggregateAttribute
		{
			get
			{
				return this.GetFunctionAttribute(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.Aggregate);
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06003A6A RID: 14954 RVA: 0x000C0403 File Offset: 0x000BE603
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, false)]
		public virtual bool BuiltInAttribute
		{
			get
			{
				return this.GetFunctionAttribute(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.BuiltIn);
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06003A6B RID: 14955 RVA: 0x000C040C File Offset: 0x000BE60C
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, false)]
		public bool IsFromProviderManifest
		{
			get
			{
				return this.GetFunctionAttribute(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.IsFromProviderManifest);
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06003A6C RID: 14956 RVA: 0x000C0416 File Offset: 0x000BE616
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, false)]
		public bool NiladicFunctionAttribute
		{
			get
			{
				return this.GetFunctionAttribute(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.NiladicFunction);
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06003A6D RID: 14957 RVA: 0x000C041F File Offset: 0x000BE61F
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Boolean, false)]
		public bool IsComposableAttribute
		{
			get
			{
				return this.GetFunctionAttribute(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.IsComposable);
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x000C0428 File Offset: 0x000BE628
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public string CommandTextAttribute
		{
			get
			{
				return this._commandTextAttribute;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06003A6F RID: 14959 RVA: 0x000C0430 File Offset: 0x000BE630
		internal bool IsCachedStoreFunction
		{
			get
			{
				return this.GetFunctionAttribute(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.IsCachedStoreFunction);
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x000C043A File Offset: 0x000BE63A
		internal bool IsModelDefinedFunction
		{
			get
			{
				return this.DataSpace == global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace && !this.IsCachedStoreFunction && !this.IsFromProviderManifest && !this.IsFunctionImport;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06003A71 RID: 14961 RVA: 0x000C0460 File Offset: 0x000BE660
		internal bool IsFunctionImport
		{
			get
			{
				return this.GetFunctionAttribute(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.IsFunctionImport);
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06003A72 RID: 14962 RVA: 0x000C046A File Offset: 0x000BE66A
		// (set) Token: 0x06003A73 RID: 14963 RVA: 0x000C0472 File Offset: 0x000BE672
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String, false)]
		public string Schema
		{
			get
			{
				return this._schemaName;
			}
			set
			{
				global::System.Data.Entity.Utilities.Check.NotEmpty(value, "value");
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._schemaName = value;
			}
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x000C0490 File Offset: 0x000BE690
		internal override void SetReadOnly()
		{
			if (!base.IsReadOnly)
			{
				base.SetReadOnly();
				this.Parameters.Source.SetReadOnly();
				foreach (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter in this.ReturnParameters)
				{
					functionParameter.SetReadOnly();
				}
			}
		}

		// Token: 0x06003A75 RID: 14965 RVA: 0x000C0500 File Offset: 0x000BE700
		internal override void BuildIdentity(global::System.Text.StringBuilder builder)
		{
			if (base.CacheIdentity != null)
			{
				builder.Append(base.CacheIdentity);
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.BuildIdentity<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(builder, this.FullName, this.Parameters, (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter param) => param.TypeUsage, (global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter param) => param.Mode);
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x000C0574 File Offset: 0x000BE774
		internal static string BuildIdentity(string functionName, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> functionParameters)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.BuildIdentity<global::System.Data.Entity.Core.Metadata.Edm.TypeUsage>(stringBuilder, functionName, functionParameters, (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage param) => param, (global::System.Data.Entity.Core.Metadata.Edm.TypeUsage param) => global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In);
			return stringBuilder.ToString();
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x000C05D4 File Offset: 0x000BE7D4
		internal static void BuildIdentity<TParameterMetadata>(global::System.Text.StringBuilder builder, string functionName, global::System.Collections.Generic.IEnumerable<TParameterMetadata> functionParameters, global::System.Func<TParameterMetadata, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage> getParameterTypeUsage, global::System.Func<TParameterMetadata, global::System.Data.Entity.Core.Metadata.Edm.ParameterMode> getParameterMode)
		{
			builder.Append(functionName);
			builder.Append('(');
			bool flag = true;
			foreach (TParameterMetadata arg in functionParameters)
			{
				if (flag)
				{
					flag = false;
				}
				else
				{
					builder.Append(",");
				}
				builder.Append(global::System.Data.Entity.Core.Metadata.Edm.Helper.ToString(getParameterMode(arg)));
				builder.Append(' ');
				getParameterTypeUsage(arg).BuildIdentity(builder);
			}
			builder.Append(')');
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x000C0670 File Offset: 0x000BE870
		private bool GetFunctionAttribute(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes attribute)
		{
			return attribute == (attribute & this._functionAttributes);
		}

		// Token: 0x06003A79 RID: 14969 RVA: 0x000C067D File Offset: 0x000BE87D
		private static void SetFunctionAttribute(ref global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes field, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes attribute, bool isSet)
		{
			if (isSet)
			{
				field |= attribute;
				return;
			}
			field ^= (field & attribute);
		}

		// Token: 0x06003A7A RID: 14970 RVA: 0x000C0694 File Offset: 0x000BE894
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmFunction Create(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace, global::System.Data.Entity.Core.Metadata.Edm.EdmFunctionPayload payload, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty> metadataProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			global::System.Data.Entity.Utilities.Check.NotEmpty(namespaceName, "namespaceName");
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = new global::System.Data.Entity.Core.Metadata.Edm.EdmFunction(name, namespaceName, dataSpace, payload);
			if (metadataProperties != null)
			{
				edmFunction.AddMetadataProperties(metadataProperties);
			}
			edmFunction.SetReadOnly();
			return edmFunction;
		}

		// Token: 0x04001411 RID: 5137
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> _returnParameters;

		// Token: 0x04001412 RID: 5138
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter> _parameters;

		// Token: 0x04001413 RID: 5139
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes _functionAttributes = global::System.Data.Entity.Core.Metadata.Edm.EdmFunction.FunctionAttributes.IsComposable;

		// Token: 0x04001414 RID: 5140
		private string _storeFunctionNameAttribute;

		// Token: 0x04001415 RID: 5141
		private readonly global::System.Data.Entity.Core.Metadata.Edm.ParameterTypeSemantics _parameterTypeSemantics;

		// Token: 0x04001416 RID: 5142
		private readonly string _commandTextAttribute;

		// Token: 0x04001417 RID: 5143
		private string _schemaName;

		// Token: 0x04001418 RID: 5144
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> _entitySets;

		// Token: 0x02000ACD RID: 2765
		[global::System.Flags]
		private enum FunctionAttributes : byte
		{
			// Token: 0x04002BB4 RID: 11188
			Aggregate = 1,
			// Token: 0x04002BB5 RID: 11189
			BuiltIn = 2,
			// Token: 0x04002BB6 RID: 11190
			NiladicFunction = 4,
			// Token: 0x04002BB7 RID: 11191
			IsComposable = 8,
			// Token: 0x04002BB8 RID: 11192
			IsFromProviderManifest = 16,
			// Token: 0x04002BB9 RID: 11193
			IsCachedStoreFunction = 32,
			// Token: 0x04002BBA RID: 11194
			IsFunctionImport = 64,
			// Token: 0x04002BBB RID: 11195
			Default = 8
		}
	}
}
