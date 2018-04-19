using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace MySqlBackupTestApp.Properties
{
	// Token: 0x0200001B RID: 27
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0001280D File Offset: 0x00010A0D
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400014B RID: 331
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
