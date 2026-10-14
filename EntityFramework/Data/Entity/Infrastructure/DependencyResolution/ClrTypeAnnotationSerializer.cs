using System;
using System.IO;
using System.Reflection;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002A9 RID: 681
	internal class ClrTypeAnnotationSerializer : global::System.Data.Entity.Infrastructure.IMetadataAnnotationSerializer
	{
		// Token: 0x06002198 RID: 8600 RVA: 0x0005D550 File Offset: 0x0005B750
		public string Serialize(string name, object value)
		{
			return ((global::System.Type)value).AssemblyQualifiedName;
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x0005D560 File Offset: 0x0005B760
		public object Deserialize(string name, string value)
		{
			try
			{
				return global::System.Type.GetType(value, false);
			}
			catch (global::System.IO.FileLoadException)
			{
			}
			catch (global::System.Reflection.TargetInvocationException)
			{
			}
			catch (global::System.BadImageFormatException)
			{
			}
			return null;
		}
	}
}
