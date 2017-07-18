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
    /// <para>Copied the shared file or folder to own Dropbox.</para>
    /// </summary>
    public class SharedContentCopyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedContentCopyDetails> Encoder = new SharedContentCopyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedContentCopyDetails> Decoder = new SharedContentCopyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedContentCopyDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="sharedContentLink">Shared content link.</param>
        /// <param name="srcIndex">Source asset index.</param>
        /// <param name="destIndex">Destination asset index.</param>
        /// <param name="targetIndex">Target asset index.</param>
        /// <param name="sharingPermission">Sharing permission. Might be missing due to
        /// historical data gap.</param>
        public SharedContentCopyDetails(string sharedContentLink,
                                        long srcIndex,
                                        long destIndex,
                                        long targetIndex,
                                        string sharingPermission = null)
        {
            if (sharedContentLink == null)
            {
                throw new sys.ArgumentNullException("sharedContentLink");
            }

            this.SharedContentLink = sharedContentLink;
            this.SrcIndex = srcIndex;
            this.DestIndex = destIndex;
            this.TargetIndex = targetIndex;
            this.SharingPermission = sharingPermission;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedContentCopyDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SharedContentCopyDetails()
        {
        }

        /// <summary>
        /// <para>Shared content link.</para>
        /// </summary>
        public string SharedContentLink { get; protected set; }

        /// <summary>
        /// <para>Source asset index.</para>
        /// </summary>
        public long SrcIndex { get; protected set; }

        /// <summary>
        /// <para>Destination asset index.</para>
        /// </summary>
        public long DestIndex { get; protected set; }

        /// <summary>
        /// <para>Target asset index.</para>
        /// </summary>
        public long TargetIndex { get; protected set; }

        /// <summary>
        /// <para>Sharing permission. Might be missing due to historical data gap.</para>
        /// </summary>
        public string SharingPermission { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedContentCopyDetails" />.</para>
        /// </summary>
        private class SharedContentCopyDetailsEncoder : enc.StructEncoder<SharedContentCopyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedContentCopyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("shared_content_link", value.SharedContentLink, writer, enc.StringEncoder.Instance);
                WriteProperty("src_index", value.SrcIndex, writer, enc.Int64Encoder.Instance);
                WriteProperty("dest_index", value.DestIndex, writer, enc.Int64Encoder.Instance);
                WriteProperty("target_index", value.TargetIndex, writer, enc.Int64Encoder.Instance);
                if (value.SharingPermission != null)
                {
                    WriteProperty("sharing_permission", value.SharingPermission, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedContentCopyDetails" />.</para>
        /// </summary>
        private class SharedContentCopyDetailsDecoder : enc.StructDecoder<SharedContentCopyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedContentCopyDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedContentCopyDetails Create()
            {
                return new SharedContentCopyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedContentCopyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "shared_content_link":
                        value.SharedContentLink = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "src_index":
                        value.SrcIndex = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    case "dest_index":
                        value.DestIndex = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    case "target_index":
                        value.TargetIndex = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    case "sharing_permission":
                        value.SharingPermission = enc.StringDecoder.Instance.Decode(reader);
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
