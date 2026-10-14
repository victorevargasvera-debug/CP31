using System;

namespace NLog.Internal.FileAppenders
{
	// Token: 0x02000141 RID: 321
	internal interface IFileAppenderFactory
	{
		// Token: 0x06000E7C RID: 3708
		global::NLog.Internal.FileAppenders.BaseFileAppender Open(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters parameters);
	}
}
