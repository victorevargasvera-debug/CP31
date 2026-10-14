using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core.SchemaObjectModel;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;
using System.Security;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000486 RID: 1158
	internal class AspProxy
	{
		// Token: 0x0600399D RID: 14749 RVA: 0x000BCCA4 File Offset: 0x000BAEA4
		internal bool IsAspNetEnvironment()
		{
			if (!this.TryInitializeWebAssembly())
			{
				return false;
			}
			bool result;
			try
			{
				result = (this.InternalMapWebPath("~") != null);
			}
			catch (global::System.Security.SecurityException)
			{
				result = false;
			}
			catch (global::System.Exception e)
			{
				if (!e.IsCatchableExceptionType())
				{
					throw;
				}
				result = false;
			}
			return result;
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x000BCCFC File Offset: 0x000BAEFC
		public bool TryInitializeWebAssembly()
		{
			if (this._webAssembly != null)
			{
				return true;
			}
			if (this._triedLoadingWebAssembly)
			{
				return false;
			}
			this._triedLoadingWebAssembly = true;
			if (!global::System.Data.Entity.Core.Metadata.Edm.AspProxy.IsSystemWebLoaded())
			{
				return false;
			}
			try
			{
				this._webAssembly = global::System.Reflection.Assembly.Load("System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
				return this._webAssembly != null;
			}
			catch (global::System.Exception e)
			{
				if (!e.IsCatchableExceptionType())
				{
					throw;
				}
			}
			return false;
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x000BCD74 File Offset: 0x000BAF74
		public static bool IsSystemWebLoaded()
		{
			try
			{
				return global::System.AppDomain.CurrentDomain.GetAssemblies().Any((global::System.Reflection.Assembly a) => a.GetName().Name == "System.Web" && a.GetName().GetPublicKeyToken() != null && a.GetName().GetPublicKeyToken().SequenceEqual(global::System.Data.Entity.Core.Metadata.Edm.AspProxy._systemWebPublicKeyToken));
			}
			catch
			{
			}
			return false;
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x000BCDC8 File Offset: 0x000BAFC8
		private void InitializeWebAssembly()
		{
			if (!this.TryInitializeWebAssembly())
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDetermineApplicationContext);
			}
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x000BCDDD File Offset: 0x000BAFDD
		internal string MapWebPath(string path)
		{
			path = this.InternalMapWebPath(path);
			if (path == null)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.InvalidUseOfWebPath("~"));
			}
			return path;
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x000BCDFC File Offset: 0x000BAFFC
		internal string InternalMapWebPath(string path)
		{
			this.InitializeWebAssembly();
			string result;
			try
			{
				result = (string)this._webAssembly.GetType("System.Web.Hosting.HostingEnvironment", true).GetDeclaredMethod("MapPath", new global::System.Type[]
				{
					typeof(string)
				}).Invoke(null, new object[]
				{
					path
				});
			}
			catch (global::System.Reflection.TargetException innerException)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDetermineApplicationContext, innerException);
			}
			catch (global::System.ArgumentException innerException2)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDetermineApplicationContext, innerException2);
			}
			catch (global::System.Reflection.TargetInvocationException innerException3)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDetermineApplicationContext, innerException3);
			}
			catch (global::System.Reflection.TargetParameterCountException innerException4)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDetermineApplicationContext, innerException4);
			}
			catch (global::System.MethodAccessException innerException5)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDetermineApplicationContext, innerException5);
			}
			catch (global::System.MemberAccessException innerException6)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDetermineApplicationContext, innerException6);
			}
			catch (global::System.TypeLoadException innerException7)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDetermineApplicationContext, innerException7);
			}
			return result;
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x000BCF14 File Offset: 0x000BB114
		internal bool HasBuildManagerType()
		{
			global::System.Type type;
			return this.TryGetBuildManagerType(out type);
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x000BCF29 File Offset: 0x000BB129
		private bool TryGetBuildManagerType(out global::System.Type buildManager)
		{
			this.InitializeWebAssembly();
			buildManager = this._webAssembly.GetType("System.Web.Compilation.BuildManager", false);
			return buildManager != null;
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x000BCF4C File Offset: 0x000BB14C
		internal global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> GetBuildManagerReferencedAssemblies()
		{
			global::System.Reflection.MethodInfo referencedAssembliesMethod = this.GetReferencedAssembliesMethod();
			if (referencedAssembliesMethod == null)
			{
				return new global::System.Collections.Generic.List<global::System.Reflection.Assembly>();
			}
			global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> result;
			try
			{
				global::System.Collections.ICollection collection = (global::System.Collections.ICollection)referencedAssembliesMethod.Invoke(null, null);
				if (collection == null)
				{
					result = new global::System.Collections.Generic.List<global::System.Reflection.Assembly>();
				}
				else
				{
					result = collection.Cast<global::System.Reflection.Assembly>();
				}
			}
			catch (global::System.Reflection.TargetException innerException)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDetermineApplicationContext, innerException);
			}
			catch (global::System.Reflection.TargetInvocationException innerException2)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDetermineApplicationContext, innerException2);
			}
			catch (global::System.MethodAccessException innerException3)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToDetermineApplicationContext, innerException3);
			}
			return result;
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x000BCFE8 File Offset: 0x000BB1E8
		internal global::System.Reflection.MethodInfo GetReferencedAssembliesMethod()
		{
			global::System.Type type;
			if (!this.TryGetBuildManagerType(out type))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.UnableToFindReflectedType("System.Web.Compilation.BuildManager", "System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
			}
			return type.GetDeclaredMethod("GetReferencedAssemblies", new global::System.Type[0]);
		}

		// Token: 0x04001314 RID: 4884
		private const string BUILD_MANAGER_TYPE_NAME = "System.Web.Compilation.BuildManager";

		// Token: 0x04001315 RID: 4885
		private const string AspNetAssemblyName = "System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		// Token: 0x04001316 RID: 4886
		private static readonly byte[] _systemWebPublicKeyToken = global::System.Data.Entity.Core.SchemaObjectModel.ScalarType.ConvertToByteArray("b03f5f7f11d50a3a");

		// Token: 0x04001317 RID: 4887
		private global::System.Reflection.Assembly _webAssembly;

		// Token: 0x04001318 RID: 4888
		private bool _triedLoadingWebAssembly;
	}
}
