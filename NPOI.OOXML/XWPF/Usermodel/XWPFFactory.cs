using System;
using System.Reflection;
using NPOI.Util;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000035 RID: 53
	public class XWPFFactory : global::NPOI.POIXMLFactory
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x0000702D File Offset: 0x0000522D
		private XWPFFactory()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00007035 File Offset: 0x00005235
		public static global::NPOI.XWPF.UserModel.XWPFFactory GetInstance()
		{
			return global::NPOI.XWPF.UserModel.XWPFFactory.inst;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000703C File Offset: 0x0000523C
		protected override global::NPOI.POIXMLRelation GetDescriptor(string relationshipType)
		{
			return global::NPOI.XWPF.UserModel.XWPFRelation.GetInstance(relationshipType);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00007044 File Offset: 0x00005244
		protected override global::NPOI.POIXMLDocumentPart CreateDocumentPart(global::System.Type cls, global::System.Type[] classes, object[] values)
		{
			if (classes == null)
			{
				classes = new global::System.Type[0];
			}
			global::System.Reflection.ConstructorInfo constructor = cls.GetConstructor(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic, null, classes, null);
			if (constructor == null)
			{
				throw new global::System.MissingMethodException();
			}
			if (values == null)
			{
				values = new object[0];
			}
			return constructor.Invoke(values) as global::NPOI.POIXMLDocumentPart;
		}

		// Token: 0x040001C6 RID: 454
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.XWPF.UserModel.XWPFFactory));

		// Token: 0x040001C7 RID: 455
		private static global::NPOI.XWPF.UserModel.XWPFFactory inst = new global::NPOI.XWPF.UserModel.XWPFFactory();
	}
}
