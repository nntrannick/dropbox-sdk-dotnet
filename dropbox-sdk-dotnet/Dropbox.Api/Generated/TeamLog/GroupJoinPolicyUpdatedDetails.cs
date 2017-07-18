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
    /// <para>Updated a group join policy.</para>
    /// </summary>
    public class GroupJoinPolicyUpdatedDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupJoinPolicyUpdatedDetails> Encoder = new GroupJoinPolicyUpdatedDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupJoinPolicyUpdatedDetails> Decoder = new GroupJoinPolicyUpdatedDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupJoinPolicyUpdatedDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="groupInfo">Group details.</param>
        /// <param name="joinPolicy">Group join policy.</param>
        /// <param name="isAdminManaged">Is admin managed group. Might be missing due to
        /// historical data gap.</param>
        public GroupJoinPolicyUpdatedDetails(GroupLogInfo groupInfo,
                                             GroupJoinPolicy joinPolicy,
                                             bool? isAdminManaged = null)
        {
            if (groupInfo == null)
            {
                throw new sys.ArgumentNullException("groupInfo");
            }

            if (joinPolicy == null)
            {
                throw new sys.ArgumentNullException("joinPolicy");
            }

            this.GroupInfo = groupInfo;
            this.JoinPolicy = joinPolicy;
            this.IsAdminManaged = isAdminManaged;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupJoinPolicyUpdatedDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public GroupJoinPolicyUpdatedDetails()
        {
        }

        /// <summary>
        /// <para>Group details.</para>
        /// </summary>
        public GroupLogInfo GroupInfo { get; protected set; }

        /// <summary>
        /// <para>Group join policy.</para>
        /// </summary>
        public GroupJoinPolicy JoinPolicy { get; protected set; }

        /// <summary>
        /// <para>Is admin managed group. Might be missing due to historical data gap.</para>
        /// </summary>
        public bool? IsAdminManaged { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupJoinPolicyUpdatedDetails" />.</para>
        /// </summary>
        private class GroupJoinPolicyUpdatedDetailsEncoder : enc.StructEncoder<GroupJoinPolicyUpdatedDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupJoinPolicyUpdatedDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("group_info", value.GroupInfo, writer, global::Dropbox.Api.TeamLog.GroupLogInfo.Encoder);
                WriteProperty("join_policy", value.JoinPolicy, writer, global::Dropbox.Api.TeamLog.GroupJoinPolicy.Encoder);
                if (value.IsAdminManaged != null)
                {
                    WriteProperty("is_admin_managed", value.IsAdminManaged.Value, writer, enc.BooleanEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupJoinPolicyUpdatedDetails" />.</para>
        /// </summary>
        private class GroupJoinPolicyUpdatedDetailsDecoder : enc.StructDecoder<GroupJoinPolicyUpdatedDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupJoinPolicyUpdatedDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupJoinPolicyUpdatedDetails Create()
            {
                return new GroupJoinPolicyUpdatedDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupJoinPolicyUpdatedDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "group_info":
                        value.GroupInfo = global::Dropbox.Api.TeamLog.GroupLogInfo.Decoder.Decode(reader);
                        break;
                    case "join_policy":
                        value.JoinPolicy = global::Dropbox.Api.TeamLog.GroupJoinPolicy.Decoder.Decode(reader);
                        break;
                    case "is_admin_managed":
                        value.IsAdminManaged = enc.BooleanDecoder.Instance.Decode(reader);
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
