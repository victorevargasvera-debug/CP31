using System;
using System.IO;
using System.Reflection;
using NLog.Common;

namespace NLog.Internal
{
	// Token: 0x020000F8 RID: 248
	internal static class AssemblyHelpers
	{
		// Token: 0x06000C90 RID: 3216 RVA: 0x0001EDE4 File Offset: 0x0001CFE4
		public static global::System.Reflection.Assembly LoadFromPath(string assemblyFileName, string baseDirectory = null)
		{
			string text = (baseDirectory == null) ? assemblyFileName : global::System.IO.Path.Combine(baseDirectory, assemblyFileName);
			global::NLog.Common.InternalLogger.Info<string>("Loading assembly file: {0}", text);
			return global::System.Reflection.Assembly.LoadFrom(text);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x0001EE10 File Offset: 0x0001D010
		public static global::System.Reflection.Assembly LoadFromName(string assemblyName)
		{
			global::NLog.Common.InternalLogger.Info<string>("Loading assembly: {0}", assemblyName);
			return global::System.Reflection.Assembly.Load(assemblyName);
		}
	}
}
