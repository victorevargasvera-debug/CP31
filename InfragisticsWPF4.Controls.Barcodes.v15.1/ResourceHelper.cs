using System;
using System.IO;
using System.Reflection;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200001A RID: 26
	public class ResourceHelper
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0000D424 File Offset: 0x0000B624
		private static global::System.IO.Stream GetResource(string filename)
		{
			global::System.Type typeFromHandle = typeof(global::Infragistics.Controls.Barcodes.XamQRCodeBarcode);
			if (global::Infragistics.Controls.Barcodes.ResourceHelper.assembly == null)
			{
				global::Infragistics.Controls.Barcodes.ResourceHelper.assembly = global::System.Reflection.Assembly.GetCallingAssembly();
			}
			if (global::Infragistics.Controls.Barcodes.ResourceHelper.prefix == null)
			{
				global::Infragistics.Controls.Barcodes.ResourceHelper.prefix = typeFromHandle.Namespace + ".Resources.";
			}
			return global::Infragistics.Controls.Barcodes.ResourceHelper.assembly.GetManifestResourceStream(global::Infragistics.Controls.Barcodes.ResourceHelper.prefix + filename);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000D484 File Offset: 0x0000B684
		public static byte[] GetResourceBytes(string filename)
		{
			byte[] result;
			using (global::System.IO.Stream resource = global::Infragistics.Controls.Barcodes.ResourceHelper.GetResource(filename + ".dat"))
			{
				if (resource == null)
				{
					throw new global::System.InvalidOperationException("Resource is not found.");
				}
				byte[] array = new byte[resource.Length];
				int num = 0;
				while ((long)num < resource.Length)
				{
					array[num] = (byte)resource.ReadByte();
					num++;
				}
				result = array;
			}
			return result;
		}

		// Token: 0x040000DD RID: 221
		private static global::System.Reflection.Assembly assembly;

		// Token: 0x040000DE RID: 222
		private static string prefix;
	}
}
