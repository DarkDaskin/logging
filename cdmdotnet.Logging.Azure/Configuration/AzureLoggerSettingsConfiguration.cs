﻿#region Copyright
// // -----------------------------------------------------------------------
// // <copyright company="cdmdotnet Limited">
// // 	Copyright cdmdotnet Limited. All rights reserved.
// // </copyright>
// // -----------------------------------------------------------------------
#endregion

using System.Configuration;
using cdmdotnet.Logging.Configuration;
using Microsoft.Azure;

namespace cdmdotnet.Logging.Azure.Configuration
{
	/// <summary>
	/// The settings for all <see cref="ILogger"/> instances reading settings from the Azure Portal.
	/// </summary>
	public class AzureLoggerSettingsConfiguration : ILoggerSettings
	{
		#region Implementation of ILoggerSettings

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.EnableSensitive"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public bool EnableSensitive
		{
			get { return bool.Parse(CloudConfigurationManager.GetSetting("EnableLogSensitive", false) ?? CloudConfigurationManager.GetSetting("EnableSensitive", false) ?? "false"); }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.EnableInfo"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public bool EnableInfo
		{
			get { return bool.Parse(CloudConfigurationManager.GetSetting("EnableLogInfo", false) ?? CloudConfigurationManager.GetSetting("EnableInfo", false) ?? "true"); }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.EnableProgress"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public bool EnableProgress
		{
			get { return bool.Parse(CloudConfigurationManager.GetSetting("EnableLogProgress", false) ?? CloudConfigurationManager.GetSetting("EnableProgress", false) ?? "true"); }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.EnableDebug"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public bool EnableDebug
		{
			get { return bool.Parse(CloudConfigurationManager.GetSetting("EnableLogDebug", false) ?? CloudConfigurationManager.GetSetting("EnableDebug", false) ?? "false"); }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.EnableWarning"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public bool EnableWarning
		{
			get { return bool.Parse(CloudConfigurationManager.GetSetting("EnableLogWarning", false) ?? CloudConfigurationManager.GetSetting("EnableWarning", false) ?? "true"); }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.EnableError"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public bool EnableError
		{
			get { return bool.Parse(CloudConfigurationManager.GetSetting("EnableLogError", false) ?? CloudConfigurationManager.GetSetting("EnableError", false) ?? "true"); }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.EnableFatalError"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public bool EnableFatalError
		{
			get { return bool.Parse(CloudConfigurationManager.GetSetting("EnableLogFatalError", false) ?? CloudConfigurationManager.GetSetting("EnableFatalError", false) ?? "true"); }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.EnableThreadedLogging"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public bool EnableThreadedLogging
		{
			get { return bool.Parse(CloudConfigurationManager.GetSetting("EnableThreadedLogging", false) ?? "true"); }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.EnableThreadedLoggingOutput"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public bool EnableThreadedLoggingOutput
		{
			get { return bool.Parse(CloudConfigurationManager.GetSetting("EnableThreadedLoggingOutput", false) ?? "false"); }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.ModuleName"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public string ModuleName
		{
			get { return CloudConfigurationManager.GetSetting("ModuleName", false) ?? "All"; }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.Instance"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public string Instance
		{
			get { return CloudConfigurationManager.GetSetting("Instance", false) ?? "All"; }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.EnvironmentInstance"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public string EnvironmentInstance
		{
			get { return CloudConfigurationManager.GetSetting("EnvironmentInstance", false) ?? "All"; }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.Environment"/> from <see cref="AppSettingsSection"/> of the app.config or web.config file with Azure portal providing runtime overrides.
		/// </summary>
		public string Environment
		{
			get { return CloudConfigurationManager.GetSetting("Environment", false) ?? "Unknown"; }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.SqlDatabaseLogsConnectionStringName"/> from the <see cref="ConfigurationSection"/> in your app.config or web.config file.
		/// </summary>
		public string SqlDatabaseLogsConnectionStringName
		{
			get { return CloudConfigurationManager.GetSetting("SqlDatabaseLogsConnectionStringName", false) ?? "Logs"; }
		}

		/// <summary>
		/// Reads the <see cref="ILoggerSettings.SqlDatabaseTableName"/> from the <see cref="ConfigurationSection"/> in your app.config or web.config file.
		/// </summary>
		public string SqlDatabaseTableName
		{
			get { return CloudConfigurationManager.GetSetting("SqlDatabaseTableName", false) ?? "Logs"; }
		}

		/// <summary>
		/// If true, all log calls will be telemetered.
		/// </summary>
		public bool UseApplicationInsightTelemetryHelper
		{
			get { return bool.Parse(CloudConfigurationManager.GetSetting("UseApplicationInsightTelemetryHelper", false) ?? "false"); }
		}

		/// <summary>
		/// If true, all log calls will be telemetered.
		/// </summary>
		public bool UsePerformanceCounters
		{
			get { return bool.Parse(CloudConfigurationManager.GetSetting("UsePerformanceCounters", false) ?? "false"); }
		}

		#endregion
	}
}