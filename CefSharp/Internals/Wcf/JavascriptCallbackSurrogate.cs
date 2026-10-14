using System;
using System.CodeDom;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace CefSharp.Internals.Wcf
{
	// Token: 0x020000FB RID: 251
	internal sealed class JavascriptCallbackSurrogate : global::System.Runtime.Serialization.IDataContractSurrogate
	{
		// Token: 0x06000762 RID: 1890 RVA: 0x0000C2BA File Offset: 0x0000A4BA
		public JavascriptCallbackSurrogate(global::CefSharp.Internals.IJavascriptCallbackFactory callbackFactory)
		{
			this.callbackFactory = callbackFactory;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0000C2C9 File Offset: 0x0000A4C9
		public global::System.Type GetDataContractType(global::System.Type type)
		{
			if (type == typeof(global::CefSharp.Internals.JavascriptCallback))
			{
				return typeof(global::CefSharp.IJavascriptCallback);
			}
			return type;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0000C2E9 File Offset: 0x0000A4E9
		public object GetObjectToSerialize(object obj, global::System.Type targetType)
		{
			return obj;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0000C2EC File Offset: 0x0000A4EC
		public object GetDeserializedObject(object obj, global::System.Type targetType)
		{
			object result = obj;
			global::CefSharp.Internals.JavascriptCallback javascriptCallback = obj as global::CefSharp.Internals.JavascriptCallback;
			if (javascriptCallback != null)
			{
				result = this.callbackFactory.Create(javascriptCallback);
			}
			return result;
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0000C313 File Offset: 0x0000A513
		public object GetCustomDataToExport(global::System.Reflection.MemberInfo memberInfo, global::System.Type dataContractType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0000C31A File Offset: 0x0000A51A
		public object GetCustomDataToExport(global::System.Type clrType, global::System.Type dataContractType)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0000C321 File Offset: 0x0000A521
		public void GetKnownCustomDataTypes(global::System.Collections.ObjectModel.Collection<global::System.Type> customDataTypes)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0000C328 File Offset: 0x0000A528
		public global::System.Type GetReferencedTypeOnImport(string typeName, string typeNamespace, object customData)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0000C32F File Offset: 0x0000A52F
		public global::System.CodeDom.CodeTypeDeclaration ProcessImportedType(global::System.CodeDom.CodeTypeDeclaration typeDeclaration, global::System.CodeDom.CodeCompileUnit compileUnit)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040003D5 RID: 981
		private readonly global::CefSharp.Internals.IJavascriptCallbackFactory callbackFactory;
	}
}
