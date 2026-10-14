using System;
using System.Collections;
using System.Configuration;

namespace NPOI.Util
{
	// Token: 0x02000287 RID: 647
	public class POILogFactory
	{
		// Token: 0x0600115E RID: 4446 RVA: 0x0000253E File Offset: 0x0000073E
		private POILogFactory()
		{
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x000345EF File Offset: 0x000327EF
		public static global::NPOI.Util.POILogger GetLogger(global::System.Type type)
		{
			return global::NPOI.Util.POILogFactory.GetLogger(type.Name);
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x000345FC File Offset: 0x000327FC
		public static global::NPOI.Util.POILogger GetLogger(string cat)
		{
			global::NPOI.Util.POILogger poilogger = null;
			if (global::NPOI.Util.POILogFactory._loggerClassName == null)
			{
				try
				{
					global::NPOI.Util.POILogFactory._loggerClassName = global::System.Configuration.ConfigurationManager.AppSettings["loggername"];
				}
				catch (global::System.Exception)
				{
				}
				if (global::NPOI.Util.POILogFactory._loggerClassName == null)
				{
					global::NPOI.Util.POILogFactory._loggerClassName = global::NPOI.Util.POILogFactory._nullLogger.GetType().Name;
				}
			}
			if (global::NPOI.Util.POILogFactory._loggerClassName.Equals(global::NPOI.Util.POILogFactory._nullLogger.GetType().Name))
			{
				return global::NPOI.Util.POILogFactory._nullLogger;
			}
			if (global::NPOI.Util.POILogFactory._loggers.ContainsKey(cat))
			{
				poilogger = (global::NPOI.Util.POILogger)global::NPOI.Util.POILogFactory._loggers[cat];
			}
			else
			{
				try
				{
					poilogger = (global::System.Activator.CreateInstance(global::System.Type.GetType(global::NPOI.Util.POILogFactory._loggerClassName)) as global::NPOI.Util.POILogger);
					poilogger.Initialize(cat);
				}
				catch (global::System.Exception)
				{
					poilogger = global::NPOI.Util.POILogFactory._nullLogger;
				}
				global::NPOI.Util.POILogFactory._loggers[cat] = poilogger;
			}
			return poilogger;
		}

		// Token: 0x04000758 RID: 1880
		private static global::System.Collections.Hashtable _loggers = new global::System.Collections.Hashtable();

		// Token: 0x04000759 RID: 1881
		private static global::NPOI.Util.POILogger _nullLogger = new global::NPOI.Util.NullLogger();

		// Token: 0x0400075A RID: 1882
		private static string _loggerClassName = null;
	}
}
