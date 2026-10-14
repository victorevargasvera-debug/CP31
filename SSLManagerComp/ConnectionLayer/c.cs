using System;
using SSLMangrComp.Connectors;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000036 RID: 54
	internal interface c : global::SSLMangrComp.Connectors.b, global::SSLMangrComp.ConnectionLayer.IServerListener
	{
		// Token: 0x06000138 RID: 312
		void SetTimeOutVal(int secsTime);
	}
}
