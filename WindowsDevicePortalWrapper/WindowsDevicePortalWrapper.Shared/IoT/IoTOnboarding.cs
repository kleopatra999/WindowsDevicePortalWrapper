﻿//----------------------------------------------------------------------------------------------
// <copyright file="IoTOnboarding.cs" company="Microsoft Corporation">
//     Licensed under the MIT License. See LICENSE.TXT in the project root license information.
// </copyright>
//----------------------------------------------------------------------------------------------

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Microsoft.Tools.WindowsDevicePortal
{
    /// <summary>
    /// Wrappers for some IoT methods.
    /// </summary>
    public partial class DevicePortal
    {
        /// <summary>
        /// Soft AP Settings API
        /// </summary>
        public static readonly string SoftAPSettingsApi = "api/iot/iotonboarding/softapsettings";

        /// <summary>
        /// All Joyn Settings API
        /// </summary>
        public static readonly string AllJoynSettingsApi = "api/iot/iotonboarding/alljoynsettings";

        /// <summary>
        /// Retrieves the Soft AP Settings Info.
        /// </summary>
        /// <returns>SoftAPSettingsInfo for this device.</returns>
        public async Task<SoftAPSettingsInfo> GetSoftAPSettingsInfo()
        {
            return await this.Get<SoftAPSettingsInfo>(SoftAPSettingsApi);
        }

        /// <summary>
        /// Retrieves the All Joyn Settings Info.
        /// </summary>
        /// <returns>AllJoynSettingsInfo for this device.</returns>
        public async Task<AllJoynSettingsInfo> GetAllJoynSettingsInfo()
        {
            return await this.Get<AllJoynSettingsInfo>(AllJoynSettingsApi);
        }

        #region Data contract

        /// <summary>
        /// Object representation for Soft AP Settings.
        /// </summary>
        [DataContract]
        public class SoftAPSettingsInfo
        {
            /// <summary>
            /// Gets whether Soft AP is enabled.
            /// </summary>
            [DataMember(Name = "SoftAPEnabled")]
            public string SoftAPEnabled { get; private set; }

            /// <summary>
            /// Gets the Soft AP Password.
            /// </summary>
            [DataMember(Name = "SoftApPassword")]
            public string SoftApPassword { get; private set; }

            /// <summary>
            /// Gets the Soft AP SSID.
            /// </summary>
            [DataMember(Name = "SoftApSsid")]
            public string SoftApSsid { get; private set; }
        }

        /// <summary>
        /// Object represenation of All Joyn Settings.
        /// </summary>
        [DataContract]
        public class AllJoynSettingsInfo
        {
            /// <summary>
            /// Gets the Default description.
            /// </summary>
            [DataMember(Name = "AllJoynOnboardingDefaultDescription")]
            public string AllJoynOnboardingDefaultDescription { get; private set; }

            /// <summary>
            /// Gets the Default Manufacturer.
            /// </summary>
            [DataMember(Name = "AllJoynOnboardingDefaultManufacturer")]
            public string AllJoynOnboardingDefaultManufacturer { get; private set; }

            /// <summary>
            /// Gets whether this is enabled.
            /// </summary>
            [DataMember(Name = "AllJoynOnboardingEnabled")]
            public string AllJoynOnboardingEnabled { get; private set; }

            /// <summary>
            /// Gets the model number.
            /// </summary>
            [DataMember(Name = "AllJoynOnboardingModelNumber")]
            public string AllJoynOnboardingModelNumber { get; private set; }
        }
        #endregion // Data contract
    }
}
