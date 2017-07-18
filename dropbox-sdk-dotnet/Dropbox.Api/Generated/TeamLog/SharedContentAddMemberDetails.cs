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
    /// <para>Added users and/or groups to the membership of a shared file or folder.</para>
    /// </summary>
    public class SharedContentAddMemberDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentAddMemberDetails> Encoder = new SharedContentAddMemberDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentAddMemberDetails> Decoder = new SharedContentAddMemberDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedContentAddMemberDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="targetIndex">Target asset index.</param>
        /// <param name="originalFolderName">Original shared folder name.</param>
        /// <param name="sharingPermission">Sharing permission. Might be missing due to
        /// historical data gap.</param>
        /// <param name="sharedFolderType">Shared folder type. Might be missing due to
        /// historical data gap.</param>
        public SharedContentAddMemberDetails(long targetIndex,
                                             string originalFolderName = null,
                                             string sharingPermission = null,
                                             string sharedFolderType = null)
        {
            this.TargetIndex = targetIndex;
            this.OriginalFolderName = originalFolderName;
            this.SharingPermission = sharingPermission;
            this.SharedFolderType = sharedFolderType;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedContentAddMemberDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentAddMemberDetails()
        {
        }

        /// <summary>
        /// <para>Target asset index.</para>
        /// </summary>
        public long TargetIndex { get; protected set; }

        /// <summary>
        /// <para>Original shared folder name.</para>
        /// </summary>
        public string OriginalFolderName { get; protected set; }

        /// <summary>
        /// <para>Sharing permission. Might be missing due to historical data gap.</para>
        /// </summary>
        public string SharingPermission { get; protected set; }

        /// <summary>
        /// <para>Shared folder type. Might be missing due to historical data gap.</para>
        /// </summary>
        public string SharedFolderType { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentAddMemberDetails" />.</para>
        /// </summary>
        private class SharedContentAddMemberDetailsEncoder : enc.StructEncoder<SharedContentAddMemberDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentAddMemberDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("target_index", value.TargetIndex, writer, enc.Int64Encoder.Instance);
                if (value.OriginalFolderName != null)
                {
                    WriteProperty("original_folder_name", value.OriginalFolderName, writer, enc.StringEncoder.Instance);
                }
                if (value.SharingPermission != null)
                {
                    WriteProperty("sharing_permission", value.SharingPermission, writer, enc.StringEncoder.Instance);
                }
                if (value.SharedFolderType != null)
                {
                    WriteProperty("shared_folder_type", value.SharedFolderType, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentAddMemberDetails" />.</para>
        /// </summary>
        private class SharedContentAddMemberDetailsDecoder : enc.StructDecoder<SharedContentAddMemberDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedContentAddMemberDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentAddMemberDetails Create()
            {
                return new SharedContentAddMemberDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentAddMemberDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "target_index":
                        value.TargetIndex = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    case "original_folder_name":
                        value.OriginalFolderName = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "sharing_permission":
                        value.SharingPermission = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "shared_folder_type":
                        value.SharedFolderType = enc.StringDecoder.Instance.Decode(reader);
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
