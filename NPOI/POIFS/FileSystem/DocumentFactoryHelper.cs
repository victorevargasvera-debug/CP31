using System;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.POIFS.Crypt;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002D1 RID: 721
	public class DocumentFactoryHelper
	{
		// Token: 0x060013D7 RID: 5079 RVA: 0x0003BA60 File Offset: 0x00039C60
		public static global::NPOI.Util.InputStream GetDecryptedStream(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs, string password)
		{
			global::NPOI.POIFS.Crypt.Decryptor instance = global::NPOI.POIFS.Crypt.Decryptor.GetInstance(new global::NPOI.POIFS.Crypt.EncryptionInfo(fs));
			global::NPOI.Util.InputStream result;
			try
			{
				bool flag = false;
				if (password != null && instance.VerifyPassword(password))
				{
					flag = true;
				}
				if (!flag && instance.VerifyPassword(global::NPOI.POIFS.Crypt.Decryptor.DEFAULT_PASSWORD))
				{
					flag = true;
				}
				if (flag)
				{
					result = new global::NPOI.POIFS.FileSystem.DocumentFactoryHelper.FilterInputStream1(instance.GetDataStream(fs.Root), fs);
				}
				else
				{
					if (password != null)
					{
						throw new global::NPOI.EncryptedDocumentException("Password incorrect");
					}
					throw new global::NPOI.EncryptedDocumentException("The supplied spreadsheet is protected, but no password was supplied");
				}
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.IO.IOException("password does not match", innerException);
			}
			return result;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0003BAEC File Offset: 0x00039CEC
		public static bool HasOOXMLHeader(global::System.IO.Stream inp)
		{
			byte[] array = new byte[4];
			int num = global::NPOI.Util.IOUtils.ReadFully(inp, array);
			if (inp is global::NPOI.Util.PushbackStream)
			{
				((global::NPOI.Util.PushbackStream)inp).Position -= 4L;
			}
			else
			{
				inp.Position = 0L;
			}
			return num == 4 && array[0] == global::NPOI.POIFS.Common.POIFSConstants.OOXML_FILE_HEADER[0] && array[1] == global::NPOI.POIFS.Common.POIFSConstants.OOXML_FILE_HEADER[1] && array[2] == global::NPOI.POIFS.Common.POIFSConstants.OOXML_FILE_HEADER[2] && array[3] == global::NPOI.POIFS.Common.POIFSConstants.OOXML_FILE_HEADER[3];
		}

		// Token: 0x020005AA RID: 1450
		private class FilterInputStream1 : global::NPOI.Util.FilterInputStream
		{
			// Token: 0x06003489 RID: 13449 RVA: 0x000A356B File Offset: 0x000A176B
			public FilterInputStream1(global::NPOI.Util.InputStream input, global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs) : base(input)
			{
				this.fs = fs;
			}

			// Token: 0x0600348A RID: 13450 RVA: 0x000A357B File Offset: 0x000A177B
			public override void Close()
			{
				this.fs.Close();
				base.Close();
			}

			// Token: 0x04001923 RID: 6435
			private global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs;
		}
	}
}
