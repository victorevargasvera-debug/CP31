using System;
using System.Collections.Generic;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x02000542 RID: 1346
	public class EscherPropertyFactory
	{
		// Token: 0x060032E2 RID: 13026 RVA: 0x0009F124 File Offset: 0x0009D324
		public global::System.Collections.Generic.List<global::NPOI.DDF.EscherProperty> CreateProperties(byte[] data, int offset, short numProperties)
		{
			global::System.Collections.Generic.List<global::NPOI.DDF.EscherProperty> list = new global::System.Collections.Generic.List<global::NPOI.DDF.EscherProperty>();
			int num = offset;
			for (int i = 0; i < (int)numProperties; i++)
			{
				short @short = global::NPOI.Util.LittleEndian.GetShort(data, num);
				int @int = global::NPOI.Util.LittleEndian.GetInt(data, num + 2);
				short propertyId = @short & 16383;
				bool flag = (@short & short.MinValue) != 0;
				byte propertyType = global::NPOI.DDF.EscherProperties.GetPropertyType(propertyId);
				if (propertyType == 1)
				{
					list.Add(new global::NPOI.DDF.EscherBoolProperty(@short, @int));
				}
				else if (propertyType == 2)
				{
					list.Add(new global::NPOI.DDF.EscherRGBProperty(@short, @int));
				}
				else if (propertyType == 3)
				{
					list.Add(new global::NPOI.DDF.EscherShapePathProperty(@short, @int));
				}
				else if (!flag)
				{
					list.Add(new global::NPOI.DDF.EscherSimpleProperty(@short, @int));
				}
				else if (propertyType == 5)
				{
					list.Add(new global::NPOI.DDF.EscherArrayProperty(@short, new byte[@int]));
				}
				else
				{
					list.Add(new global::NPOI.DDF.EscherComplexProperty(@short, new byte[@int]));
				}
				num += 6;
			}
			foreach (object obj in list)
			{
				global::NPOI.DDF.EscherProperty escherProperty = (global::NPOI.DDF.EscherProperty)obj;
				if (escherProperty is global::NPOI.DDF.EscherComplexProperty)
				{
					if (escherProperty is global::NPOI.DDF.EscherArrayProperty)
					{
						num += ((global::NPOI.DDF.EscherArrayProperty)escherProperty).SetArrayData(data, num);
					}
					else
					{
						byte[] complexData = ((global::NPOI.DDF.EscherComplexProperty)escherProperty).ComplexData;
						int num2 = data.Length - num;
						if (num2 < complexData.Length)
						{
							throw new global::System.InvalidOperationException(string.Concat(new string[]
							{
								"Could not read complex escher property, lenght was ",
								complexData.Length.ToString(),
								", but had only ",
								num2.ToString(),
								" bytes left"
							}));
						}
						global::System.Array.Copy(data, num, complexData, 0, complexData.Length);
						num += complexData.Length;
					}
				}
			}
			return list;
		}
	}
}
