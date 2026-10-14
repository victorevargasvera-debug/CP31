using System;
using System.Collections.Generic;
using System.Reflection;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200052F RID: 1327
	public class DefaultEscherRecordFactory : global::NPOI.DDF.IEscherRecordFactory
	{
		// Token: 0x060031CC RID: 12748 RVA: 0x00096A38 File Offset: 0x00094C38
		public virtual global::NPOI.DDF.EscherRecord CreateRecord(byte[] data, int offset)
		{
			short @short = global::NPOI.Util.LittleEndian.GetShort(data, offset);
			short short2 = global::NPOI.Util.LittleEndian.GetShort(data, offset + 2);
			if (global::NPOI.DDF.DefaultEscherRecordFactory.IsContainer(@short, short2))
			{
				return new global::NPOI.DDF.EscherContainerRecord
				{
					RecordId = short2,
					Options = @short
				};
			}
			if (short2 >= -4072 && short2 <= -3817)
			{
				global::NPOI.DDF.EscherBlipRecord escherBlipRecord;
				if (short2 == -4065 || short2 == -4067 || short2 == -4066)
				{
					escherBlipRecord = new global::NPOI.DDF.EscherBitmapBlip();
				}
				else if (short2 == -4070 || short2 == -4069 || short2 == -4068)
				{
					escherBlipRecord = new global::NPOI.DDF.EscherMetafileBlip();
				}
				else
				{
					escherBlipRecord = new global::NPOI.DDF.EscherBlipRecord();
				}
				escherBlipRecord.RecordId = short2;
				escherBlipRecord.Options = @short;
				return escherBlipRecord;
			}
			global::System.Reflection.ConstructorInfo constructorInfo = null;
			if (global::NPOI.DDF.DefaultEscherRecordFactory.recordsMap.ContainsKey(short2))
			{
				constructorInfo = global::NPOI.DDF.DefaultEscherRecordFactory.recordsMap[short2];
			}
			global::NPOI.DDF.EscherRecord escherRecord = null;
			if (constructorInfo == null)
			{
				return new global::NPOI.DDF.UnknownEscherRecord();
			}
			try
			{
				escherRecord = (global::NPOI.DDF.EscherRecord)constructorInfo.Invoke(new object[0]);
			}
			catch (global::System.Exception)
			{
				return new global::NPOI.DDF.UnknownEscherRecord();
			}
			escherRecord.RecordId = short2;
			escherRecord.Options = @short;
			return escherRecord;
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x00096B50 File Offset: 0x00094D50
		private static global::System.Collections.Generic.Dictionary<short, global::System.Reflection.ConstructorInfo> RecordsToMap(global::System.Type[] records)
		{
			global::System.Collections.Generic.Dictionary<short, global::System.Reflection.ConstructorInfo> dictionary = new global::System.Collections.Generic.Dictionary<short, global::System.Reflection.ConstructorInfo>();
			global::System.Type[] types = new global::System.Type[0];
			foreach (global::System.Type type in records)
			{
				short key = 0;
				try
				{
					key = (short)type.GetField("RECORD_ID").GetValue(null);
				}
				catch (global::System.Exception)
				{
					throw new global::NPOI.Util.RecordFormatException("Unable to determine record types");
				}
				global::System.Reflection.ConstructorInfo constructor;
				try
				{
					constructor = type.GetConstructor(types);
				}
				catch (global::System.Exception e)
				{
					throw new global::NPOI.Util.RuntimeException(e);
				}
				dictionary.Add(key, constructor);
			}
			return dictionary;
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x00096BE0 File Offset: 0x00094DE0
		public static bool IsContainer(short options, short recordId)
		{
			return (recordId >= -4096 && recordId <= -4091) || (recordId != -4083 && (options & 15) == 15);
		}

		// Token: 0x0400163C RID: 5692
		private static global::System.Type[] escherRecordClasses = new global::System.Type[]
		{
			typeof(global::NPOI.DDF.EscherBSERecord),
			typeof(global::NPOI.DDF.EscherOptRecord),
			typeof(global::NPOI.DDF.EscherTertiaryOptRecord),
			typeof(global::NPOI.DDF.EscherClientAnchorRecord),
			typeof(global::NPOI.DDF.EscherDgRecord),
			typeof(global::NPOI.DDF.EscherSpgrRecord),
			typeof(global::NPOI.DDF.EscherSpRecord),
			typeof(global::NPOI.DDF.EscherClientDataRecord),
			typeof(global::NPOI.DDF.EscherDggRecord),
			typeof(global::NPOI.DDF.EscherSplitMenuColorsRecord),
			typeof(global::NPOI.DDF.EscherChildAnchorRecord),
			typeof(global::NPOI.DDF.EscherTextboxRecord)
		};

		// Token: 0x0400163D RID: 5693
		private static global::System.Collections.Generic.Dictionary<short, global::System.Reflection.ConstructorInfo> recordsMap = global::NPOI.DDF.DefaultEscherRecordFactory.RecordsToMap(global::NPOI.DDF.DefaultEscherRecordFactory.escherRecordClasses);
	}
}
