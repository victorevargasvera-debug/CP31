using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000126 RID: 294
	internal class ModelHashCalculator
	{
		// Token: 0x06001484 RID: 5252 RVA: 0x000347D8 File Offset: 0x000329D8
		public virtual string Calculate(global::System.Data.Entity.Infrastructure.DbCompiledModel compiledModel)
		{
			global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo = compiledModel.ProviderInfo;
			global::System.Data.Entity.DbModelBuilder dbModelBuilder = compiledModel.CachedModelBuilder.Clone();
			global::System.Data.Entity.Internal.EdmMetadataContext.ConfigureEdmMetadata(dbModelBuilder.ModelConfiguration);
			global::System.Data.Entity.Core.Metadata.Edm.EdmModel database = dbModelBuilder.Build(providerInfo).DatabaseMapping.Database;
			database.SchemaVersion = 2.0;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			using (global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(stringBuilder, new global::System.Xml.XmlWriterSettings
			{
				Indent = true
			}))
			{
				new global::System.Data.Entity.Core.Metadata.Edm.SsdlSerializer().Serialize(database, providerInfo.ProviderInvariantName, providerInfo.ProviderManifestToken, xmlWriter, true);
			}
			return global::System.Data.Entity.Internal.ModelHashCalculator.ComputeSha256Hash(stringBuilder.ToString());
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0003487C File Offset: 0x00032A7C
		private static string ComputeSha256Hash(string input)
		{
			byte[] array = global::System.Data.Entity.Internal.ModelHashCalculator.GetSha256HashAlgorithm().ComputeHash(global::System.Text.Encoding.ASCII.GetBytes(input));
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(array.Length * 2);
			foreach (byte b in array)
			{
				stringBuilder.Append(b.ToString("X2", global::System.Globalization.CultureInfo.InvariantCulture));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x000348DC File Offset: 0x00032ADC
		private static global::System.Security.Cryptography.SHA256 GetSha256HashAlgorithm()
		{
			global::System.Security.Cryptography.SHA256 result;
			try
			{
				result = new global::System.Security.Cryptography.SHA256CryptoServiceProvider();
			}
			catch (global::System.PlatformNotSupportedException)
			{
				result = new global::System.Security.Cryptography.SHA256Managed();
			}
			return result;
		}
	}
}
