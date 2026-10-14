using System;
using System.Reflection;
using NPOI.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000083 RID: 131
	public class XSSFFactory : global::NPOI.POIXMLFactory
	{
		// Token: 0x060006C3 RID: 1731 RVA: 0x0000702D File Offset: 0x0000522D
		private XSSFFactory()
		{
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x000175CC File Offset: 0x000157CC
		public static global::NPOI.XSSF.UserModel.XSSFFactory GetInstance()
		{
			return global::NPOI.XSSF.UserModel.XSSFFactory.inst;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x000175D3 File Offset: 0x000157D3
		protected override global::NPOI.POIXMLRelation GetDescriptor(string relationshipType)
		{
			return global::NPOI.XSSF.UserModel.XSSFRelation.GetInstance(relationshipType);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00007044 File Offset: 0x00005244
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

		// Token: 0x040002D9 RID: 729
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.XSSF.UserModel.XSSFFactory));

		// Token: 0x040002DA RID: 730
		private static global::NPOI.XSSF.UserModel.XSSFFactory inst = new global::NPOI.XSSF.UserModel.XSSFFactory();
	}
}
