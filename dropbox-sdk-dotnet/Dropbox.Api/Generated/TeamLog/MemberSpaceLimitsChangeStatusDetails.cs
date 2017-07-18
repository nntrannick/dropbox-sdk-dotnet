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
    /// <para>Changed the status with respect to whether the team member is under or over
    /// storage quota specified by policy.</para>
    /// </summary>
    public class MemberSpaceLimitsChangeStatusDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberSpaceLimitsChangeStatusDetails> Encoder = new MemberSpaceLimitsChangeStatusDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberSpaceLimitsChangeStatusDetails> Decoder = new MemberSpaceLimitsChangeStatusDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MemberSpaceLimitsChangeStatusDetails" /> class.</para>
        /// </summary>
        /// <param name="previousStatus">Previous storage quota status.</param>
        /// <param name="newStatus">New storage quota status.</param>
        public MemberSpaceLimitsChangeStatusDetails(SpaceLimitsStatus previousStatus,
                                                    SpaceLimitsStatus newStatus)
        {
            if (previousStatus == null)
            {
                throw new sys.ArgumentNullException("previousStatus");
            }

            if (newStatus == null)
            {
                throw new sys.ArgumentNullException("newStatus");
            }

            this.PreviousStatus = previousStatus;
            this.NewStatus = newStatus;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="MemberSpaceLimitsChangeStatusDetails" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MemberSpaceLimitsChangeStatusDetails()
        {
        }

        /// <summary>
        /// <para>Previous storage quota status.</para>
        /// </summary>
        public SpaceLimitsStatus PreviousStatus { get; protected set; }

        /// <summary>
        /// <para>New storage quota status.</para>
        /// </summary>
        public SpaceLimitsStatus NewStatus { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberSpaceLimitsChangeStatusDetails" />.</para>
        /// </summary>
        private class MemberSpaceLimitsChangeStatusDetailsEncoder : enc.StructEncoder<MemberSpaceLimitsChangeStatusDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberSpaceLimitsChangeStatusDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("previous_status", value.PreviousStatus, writer, global::Dropbox.Api.TeamLog.SpaceLimitsStatus.Encoder);
                WriteProperty("new_status", value.NewStatus, writer, global::Dropbox.Api.TeamLog.SpaceLimitsStatus.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberSpaceLimitsChangeStatusDetails" />.</para>
        /// </summary>
        private class MemberSpaceLimitsChangeStatusDetailsDecoder : enc.StructDecoder<MemberSpaceLimitsChangeStatusDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="MemberSpaceLimitsChangeStatusDetails" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberSpaceLimitsChangeStatusDetails Create()
            {
                return new MemberSpaceLimitsChangeStatusDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberSpaceLimitsChangeStatusDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "previous_status":
                        value.PreviousStatus = global::Dropbox.Api.TeamLog.SpaceLimitsStatus.Decoder.Decode(reader);
                        break;
                    case "new_status":
                        value.NewStatus = global::Dropbox.Api.TeamLog.SpaceLimitsStatus.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
