using System;
using System.Data.Entity.Core.Mapping.ViewGeneration.Structures;

namespace System.Data.Entity.Core.Mapping.ViewGeneration.Utils
{
	// Token: 0x02000573 RID: 1395
	internal static class ExceptionHelpers
	{
		// Token: 0x060043E9 RID: 17385 RVA: 0x000EBD98 File Offset: 0x000E9F98
		internal static void ThrowMappingException(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog.Record errorRecord, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			global::System.Data.Entity.Core.InternalMappingException ex = new global::System.Data.Entity.Core.InternalMappingException(errorRecord.ToUserString(), errorRecord);
			if (config.IsNormalTracing)
			{
				ex.ErrorLog.PrintTrace();
			}
			throw ex;
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x000EBDC8 File Offset: 0x000E9FC8
		internal static void ThrowMappingException(global::System.Data.Entity.Core.Mapping.ViewGeneration.Structures.ErrorLog errorLog, global::System.Data.Entity.Core.Mapping.ViewGeneration.ConfigViewGenerator config)
		{
			global::System.Data.Entity.Core.InternalMappingException ex = new global::System.Data.Entity.Core.InternalMappingException(errorLog.ToUserString(), errorLog);
			if (config.IsNormalTracing)
			{
				ex.ErrorLog.PrintTrace();
			}
			throw ex;
		}
	}
}
