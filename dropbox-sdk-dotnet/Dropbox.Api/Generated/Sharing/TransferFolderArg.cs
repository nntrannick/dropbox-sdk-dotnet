// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The transfer folder arg object</para>
    /// </summary>
    public class TransferFolderArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TransferFolderArg> Encoder = new TransferFolderArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TransferFolderArg> Decoder = new TransferFolderArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TransferFolderArg" />
        /// class.</para>
        /// </summary>
        /// <param name="sharedFolderId">The ID for the shared folder.</param>
        /// <param name="toDropboxId">A account or team member ID to transfer ownership
        /// to.</param>
        public TransferFolderArg(string sharedFolderId,
                                 string toDropboxId)
        {
            if (sharedFolderId == null)
            {
                throw new sys.ArgumentNullException("sharedFolderId");
            }
            if (!re.Regex.IsMatch(sharedFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
            {
                throw new sys.ArgumentOutOfRangeException("sharedFolderId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
            }

            if (toDropboxId == null)
            {
                throw new sys.ArgumentNullException("toDropboxId");
            }
            if (toDropboxId.Length < 1)
            {
                throw new sys.ArgumentOutOfRangeException("toDropboxId", "Length should be at least 1");
            }

            this.SharedFolderId = sharedFolderId;
            this.ToDropboxId = toDropboxId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TransferFolderArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TransferFolderArg()
        {
        }

        /// <summary>
        /// <para>The ID for the shared folder.</para>
        /// </summary>
        public string SharedFolderId { get; protected set; }

        /// <summary>
        /// <para>A account or team member ID to transfer ownership to.</para>
        /// </summary>
        public string ToDropboxId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TransferFolderArg" />.</para>
        /// </summary>
        private class TransferFolderArgEncoder : enc.StructEncoder<TransferFolderArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TransferFolderArg value, enc.IJsonWriter writer)
            {
                WriteProperty("shared_folder_id", value.SharedFolderId, writer, enc.StringEncoder.Instance);
                WriteProperty("to_dropbox_id", value.ToDropboxId, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TransferFolderArg" />.</para>
        /// </summary>
        private class TransferFolderArgDecoder : enc.StructDecoder<TransferFolderArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TransferFolderArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TransferFolderArg Create()
            {
                return new TransferFolderArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TransferFolderArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "shared_folder_id":
                        value.SharedFolderId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "to_dropbox_id":
                        value.ToDropboxId = enc.StringDecoder.Instance.Decode(reader);
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
