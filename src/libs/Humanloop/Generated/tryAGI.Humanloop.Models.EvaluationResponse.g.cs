
#nullable enable

namespace tryAGI.Humanloop
{
    /// <summary>
    /// Response model for an Evaluation.
    /// </summary>
    public sealed partial class EvaluationResponse
    {
        /// <summary>
        /// Unique identifier for the Evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Total number of Runs in the Evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runsCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RunsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.Humanloop.EvaluationEvaluatorResponse> Evaluators { get; set; }

        /// <summary>
        /// Name of the Evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// ID of the File associated with the Evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileId")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdBy")]
        public global::tryAGI.Humanloop.UserResponse? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// URL to view the Evaluation on Humanloop.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.Humanloop.JsonConverters.EvaluationResponseStatusJsonConverter))]
        public global::tryAGI.Humanloop.EvaluationResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the Evaluation.
        /// </param>
        /// <param name="runsCount">
        /// Total number of Runs in the Evaluation.
        /// </param>
        /// <param name="evaluators"></param>
        /// <param name="name">
        /// Name of the Evaluation.
        /// </param>
        /// <param name="fileId">
        /// ID of the File associated with the Evaluation.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url">
        /// URL to view the Evaluation on Humanloop.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluationResponse(
            string id,
            int runsCount,
            global::System.Collections.Generic.IList<global::tryAGI.Humanloop.EvaluationEvaluatorResponse> evaluators,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? name,
            string? fileId,
            global::tryAGI.Humanloop.UserResponse? createdBy,
            string? url,
            global::tryAGI.Humanloop.EvaluationResponseStatus? status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.RunsCount = runsCount;
            this.Evaluators = evaluators ?? throw new global::System.ArgumentNullException(nameof(evaluators));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.FileId = fileId;
            this.CreatedBy = createdBy;
            this.Url = url;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationResponse" /> class.
        /// </summary>
        public EvaluationResponse()
        {
        }
    }
}