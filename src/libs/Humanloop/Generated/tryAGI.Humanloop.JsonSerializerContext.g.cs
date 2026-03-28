
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace tryAGI.Humanloop
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::tryAGI.Humanloop.JsonConverters.MonitoringEvaluatorResponseStateJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.MonitoringEvaluatorResponseStateNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ChatMessageRoleJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ChatMessageRoleNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.PromptResponseTypeJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.PromptResponseTypeNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.DatasetResponseTypeJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.DatasetResponseTypeNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.EvaluatorResponseTypeJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.EvaluatorResponseTypeNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.EvaluationResponseStatusJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.EvaluationResponseStatusNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ToolResponseTypeJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ToolResponseTypeNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.FlowResponseTypeJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.FlowResponseTypeNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.AgentResponseTypeJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.AgentResponseTypeNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.UpdateEvaluationStatusRequestStatusJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.UpdateEvaluationStatusRequestStatusNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.EvaluationRunResponseStatusJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.EvaluationRunResponseStatusNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListPromptsOrderJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListPromptsOrderNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListDatasetsOrderJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListDatasetsOrderNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListEvaluatorsOrderJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListEvaluatorsOrderNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListToolsOrderJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListToolsOrderNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListFlowsOrderJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListFlowsOrderNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListAgentsOrderJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListAgentsOrderNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListFilesTypeJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListFilesTypeNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListFilesOrderJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.ListFilesOrderNullableJsonConverter),

            typeof(global::tryAGI.Humanloop.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.UserResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.EnvironmentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.InputResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.MonitoringEvaluatorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.MonitoringEvaluatorResponseState), TypeInfoPropertyName = "MonitoringEvaluatorResponseState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.EvaluatorAggregate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.LinkedToolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ChatMessageRole), TypeInfoPropertyName = "ChatMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.ToolCallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ToolCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ToolCallResponseFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.DatapointResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.DirectoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.ToolFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.LinkedToolResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PromptResponseType), TypeInfoPropertyName = "PromptResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.EnvironmentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.InputResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.MonitoringEvaluatorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.EvaluatorAggregate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PaginatedPromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.PromptResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PromptCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PromptCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PromptLogRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.CreatePromptLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.DatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.DatasetResponseType), TypeInfoPropertyName = "DatasetResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.DatapointResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.DatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PaginatedDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.DatasetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.EvaluatorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.EvaluatorResponseType), TypeInfoPropertyName = "EvaluatorResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.EvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PaginatedEvaluatorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.EvaluatorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.EvaluationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.EvaluationEvaluatorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.EvaluationEvaluatorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.EvaluationResponseStatus), TypeInfoPropertyName = "EvaluationResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.EvaluationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PaginatedEvaluationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.EvaluationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ToolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ToolResponseType), TypeInfoPropertyName = "ToolResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PaginatedToolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.ToolResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.FlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.FlowResponseType), TypeInfoPropertyName = "FlowResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.FlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PaginatedFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.FlowResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.AgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.AgentResponseType), TypeInfoPropertyName = "AgentResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.AgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PaginatedAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.AgentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.AgentCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.AgentCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PromptLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PaginatedLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.PromptLogResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.MoveRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.UpdateVersionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.SetDeploymentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.UpdateMonitoringRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.UpdateMonitoringRequestActivateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.UpdateMonitoringRequestActivateItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.UpdateMonitoringRequestDeactivateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.UpdateMonitoringRequestDeactivateItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.FileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PaginatedFileResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.FileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.CreateDirectoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.UpdateDirectoryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.LogToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.CallToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.LogFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.LogAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.LogEvaluatorRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.CreateLogResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.CallToolResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PopulatePromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.PopulatePromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.DeserializePromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.UpdateEvaluationStatusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.UpdateEvaluationStatusRequestStatus), TypeInfoPropertyName = "UpdateEvaluationStatusRequestStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.EvaluationRunResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.EvaluationRunResponseStatus), TypeInfoPropertyName = "EvaluationRunResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ListPromptsOrder), TypeInfoPropertyName = "ListPromptsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ListDatasetsOrder), TypeInfoPropertyName = "ListDatasetsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ListEvaluatorsOrder), TypeInfoPropertyName = "ListEvaluatorsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ListToolsOrder), TypeInfoPropertyName = "ListToolsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ListFlowsOrder), TypeInfoPropertyName = "ListFlowsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ListAgentsOrder), TypeInfoPropertyName = "ListAgentsOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ListFilesType), TypeInfoPropertyName = "ListFilesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::tryAGI.Humanloop.ListFilesOrder), TypeInfoPropertyName = "ListFilesOrder2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.EvaluationRunResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::tryAGI.Humanloop.DirectoryResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.ToolCallResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.ToolFunction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.LinkedToolResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.EnvironmentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.InputResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.MonitoringEvaluatorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.EvaluatorAggregate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.PromptResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.DatapointResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.DatasetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.EvaluatorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.EvaluationEvaluatorResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.EvaluationResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.ToolResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.FlowResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.AgentResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.PromptLogResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.UpdateMonitoringRequestActivateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.UpdateMonitoringRequestDeactivateItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.FileResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.EvaluationRunResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::tryAGI.Humanloop.DirectoryResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}