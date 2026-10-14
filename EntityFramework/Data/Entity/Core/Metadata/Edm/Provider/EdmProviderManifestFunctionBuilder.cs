using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace System.Data.Entity.Core.Metadata.Edm.Provider
{
	// Token: 0x0200051B RID: 1307
	internal sealed class EdmProviderManifestFunctionBuilder
	{
		// Token: 0x06004084 RID: 16516 RVA: 0x000D82EC File Offset: 0x000D64EC
		internal EdmProviderManifestFunctionBuilder(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType> edmPrimitiveTypes)
		{
			global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] array = new global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[edmPrimitiveTypes.Count];
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType in edmPrimitiveTypes)
			{
				array[(int)primitiveType.PrimitiveTypeKind] = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType);
			}
			this.primitiveTypes = array;
		}

		// Token: 0x06004085 RID: 16517 RVA: 0x000D8360 File Offset: 0x000D6560
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> ToFunctionCollection()
		{
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>(this.functions);
		}

		// Token: 0x06004086 RID: 16518 RVA: 0x000D8370 File Offset: 0x000D6570
		internal static void ForAllBasePrimitiveTypes(global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind> forEachType)
		{
			for (int i = 0; i < 32; i++)
			{
				global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind = (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind)i;
				if (!global::System.Data.Entity.Core.Metadata.Edm.Helper.IsStrongSpatialTypeKind(primitiveTypeKind))
				{
					forEachType(primitiveTypeKind);
				}
			}
		}

		// Token: 0x06004087 RID: 16519 RVA: 0x000D839C File Offset: 0x000D659C
		internal static void ForTypes(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind> typeKinds, global::System.Action<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind> forEachType)
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind obj in typeKinds)
			{
				forEachType(obj);
			}
		}

		// Token: 0x06004088 RID: 16520 RVA: 0x000D83E4 File Offset: 0x000D65E4
		internal void AddAggregate(string aggregateFunctionName, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind collectionArgumentElementTypeKind)
		{
			this.AddAggregate(collectionArgumentElementTypeKind, aggregateFunctionName, collectionArgumentElementTypeKind);
		}

		// Token: 0x06004089 RID: 16521 RVA: 0x000D83F0 File Offset: 0x000D65F0
		internal void AddAggregate(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind returnTypeKind, string aggregateFunctionName, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind collectionArgumentElementTypeKind)
		{
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter = this.CreateReturnParameter(returnTypeKind);
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter2 = this.CreateAggregateParameter(collectionArgumentElementTypeKind);
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = new global::System.Data.Entity.Core.Metadata.Edm.EdmFunction(aggregateFunctionName, "Edm", global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, new global::System.Data.Entity.Core.Metadata.Edm.EdmFunctionPayload
			{
				IsAggregate = new bool?(true),
				IsBuiltIn = new bool?(true),
				ReturnParameters = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[]
				{
					functionParameter
				},
				Parameters = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[]
				{
					functionParameter2
				},
				IsFromProviderManifest = new bool?(true)
			});
			edmFunction.SetReadOnly();
			this.functions.Add(edmFunction);
		}

		// Token: 0x0600408A RID: 16522 RVA: 0x000D8477 File Offset: 0x000D6677
		internal void AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind returnType, string functionName)
		{
			this.AddFunction(returnType, functionName, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>[0]);
		}

		// Token: 0x0600408B RID: 16523 RVA: 0x000D8487 File Offset: 0x000D6687
		internal void AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind returnType, string functionName, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argumentTypeKind, string argumentName)
		{
			this.AddFunction(returnType, functionName, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>[]
			{
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argumentName, argumentTypeKind)
			});
		}

		// Token: 0x0600408C RID: 16524 RVA: 0x000D84A6 File Offset: 0x000D66A6
		internal void AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind returnType, string functionName, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument1TypeKind, string argument1Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument2TypeKind, string argument2Name)
		{
			this.AddFunction(returnType, functionName, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>[]
			{
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument1Name, argument1TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument2Name, argument2TypeKind)
			});
		}

		// Token: 0x0600408D RID: 16525 RVA: 0x000D84D5 File Offset: 0x000D66D5
		internal void AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind returnType, string functionName, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument1TypeKind, string argument1Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument2TypeKind, string argument2Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument3TypeKind, string argument3Name)
		{
			this.AddFunction(returnType, functionName, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>[]
			{
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument1Name, argument1TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument2Name, argument2TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument3Name, argument3TypeKind)
			});
		}

		// Token: 0x0600408E RID: 16526 RVA: 0x000D8514 File Offset: 0x000D6714
		internal void AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind returnType, string functionName, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument1TypeKind, string argument1Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument2TypeKind, string argument2Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument3TypeKind, string argument3Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument4TypeKind, string argument4Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument5TypeKind, string argument5Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument6TypeKind, string argument6Name)
		{
			this.AddFunction(returnType, functionName, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>[]
			{
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument1Name, argument1TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument2Name, argument2TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument3Name, argument3TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument4Name, argument4TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument5Name, argument5TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument6Name, argument6TypeKind)
			});
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x000D8590 File Offset: 0x000D6790
		internal void AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind returnType, string functionName, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument1TypeKind, string argument1Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument2TypeKind, string argument2Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument3TypeKind, string argument3Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument4TypeKind, string argument4Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument5TypeKind, string argument5Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument6TypeKind, string argument6Name, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind argument7TypeKind, string argument7Name)
		{
			this.AddFunction(returnType, functionName, new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>[]
			{
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument1Name, argument1TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument2Name, argument2TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument3Name, argument3TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument4Name, argument4TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument5Name, argument5TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument6Name, argument6TypeKind),
				new global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>(argument7Name, argument7TypeKind)
			});
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x000D861C File Offset: 0x000D681C
		private void AddFunction(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind returnType, string functionName, global::System.Collections.Generic.KeyValuePair<string, global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind>[] parameterDefinitions)
		{
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter functionParameter = this.CreateReturnParameter(returnType);
			global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[] parameters = (from paramDef in parameterDefinitions
			select this.CreateParameter(paramDef.Value, paramDef.Key)).ToArray<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>();
			global::System.Data.Entity.Core.Metadata.Edm.EdmFunction edmFunction = new global::System.Data.Entity.Core.Metadata.Edm.EdmFunction(functionName, "Edm", global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace, new global::System.Data.Entity.Core.Metadata.Edm.EdmFunctionPayload
			{
				IsBuiltIn = new bool?(true),
				ReturnParameters = new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter[]
				{
					functionParameter
				},
				Parameters = parameters,
				IsFromProviderManifest = new bool?(true)
			});
			edmFunction.SetReadOnly();
			this.functions.Add(edmFunction);
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x000D869E File Offset: 0x000D689E
		private global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter CreateParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveParameterType, string parameterName)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter(parameterName, this.primitiveTypes[(int)primitiveParameterType], global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In);
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x000D86AF File Offset: 0x000D68AF
		private global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter CreateAggregateParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind collectionParameterTypeElementTypeKind)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter("collection", global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(this.primitiveTypes[(int)collectionParameterTypeElementTypeKind].EdmType.GetCollectionType()), global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.In);
		}

		// Token: 0x06004093 RID: 16531 RVA: 0x000D86D3 File Offset: 0x000D68D3
		private global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter CreateReturnParameter(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind primitiveReturnType)
		{
			return new global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter("ReturnType", this.primitiveTypes[(int)primitiveReturnType], global::System.Data.Entity.Core.Metadata.Edm.ParameterMode.ReturnValue);
		}

		// Token: 0x04001677 RID: 5751
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction> functions = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmFunction>();

		// Token: 0x04001678 RID: 5752
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage[] primitiveTypes;
	}
}
