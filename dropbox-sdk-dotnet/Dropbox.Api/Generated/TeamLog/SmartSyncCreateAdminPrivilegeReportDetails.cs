// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Smart Sync non-admin devices report created.</para>
    /// </summary>
    public class SmartSyncCreateAdminPrivilegeReportDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SmartSyncCreateAdminPrivilegeReportDetails> Encoder = new SmartSyncCreateAdminPrivilegeReportDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SmartSyncCreateAdminPrivilegeReportDetails> Decoder = new SmartSyncCreateAdminPrivilegeReportDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SmartSyncCreateAdminPrivilegeReportDetails" /> class.</para>
        /// </summary>
        public SmartSyncCreateAdminPrivilegeReportDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SmartSyncCreateAdminPrivilegeReportDetails"
        /// />.</para>
        /// </summary>
        private class SmartSyncCreateAdminPrivilegeReportDetailsEncoder : enc.StructEncoder<SmartSyncCreateAdminPrivilegeReportDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SmartSyncCreateAdminPrivilegeReportDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SmartSyncCreateAdminPrivilegeReportDetails"
        /// />.</para>
        /// </summary>
        private class SmartSyncCreateAdminPrivilegeReportDetailsDecoder : enc.StructDecoder<SmartSyncCreateAdminPrivilegeReportDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SmartSyncCreateAdminPrivilegeReportDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SmartSyncCreateAdminPrivilegeReportDetails Create()
            {
                return new SmartSyncCreateAdminPrivilegeReportDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SmartSyncCreateAdminPrivilegeReportDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
