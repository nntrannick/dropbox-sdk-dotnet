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
    /// <para>Liked a file comment.</para>
    /// </summary>
    public class FileLikeCommentDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileLikeCommentDetails> Encoder = new FileLikeCommentDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileLikeCommentDetails> Decoder = new FileLikeCommentDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileLikeCommentDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="targetIndex">Target asset index.</param>
        /// <param name="commentText">Comment text. Might be missing due to historical data
        /// gap.</param>
        public FileLikeCommentDetails(long targetIndex,
                                      string commentText = null)
        {
            this.TargetIndex = targetIndex;
            this.CommentText = commentText;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileLikeCommentDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileLikeCommentDetails()
        {
        }

        /// <summary>
        /// <para>Target asset index.</para>
        /// </summary>
        public long TargetIndex { get; protected set; }

        /// <summary>
        /// <para>Comment text. Might be missing due to historical data gap.</para>
        /// </summary>
        public string CommentText { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileLikeCommentDetails" />.</para>
        /// </summary>
        private class FileLikeCommentDetailsEncoder : enc.StructEncoder<FileLikeCommentDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileLikeCommentDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("target_index", value.TargetIndex, writer, enc.Int64Encoder.Instance);
                if (value.CommentText != null)
                {
                    WriteProperty("comment_text", value.CommentText, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileLikeCommentDetails" />.</para>
        /// </summary>
        private class FileLikeCommentDetailsDecoder : enc.StructDecoder<FileLikeCommentDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileLikeCommentDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileLikeCommentDetails Create()
            {
                return new FileLikeCommentDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileLikeCommentDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "target_index":
                        value.TargetIndex = enc.Int64Decoder.Instance.Decode(reader);
                        break;
                    case "comment_text":
                        value.CommentText = enc.StringDecoder.Instance.Decode(reader);
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
