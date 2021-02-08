using Newtonsoft.Json;

namespace CalculaJurosService.Infrastructure.DataTransferObjects
{
    [JsonObject(IsReference = true)]
    public class ObjectReplyDTO<TObjectReplyDTO> : ObjectReplyDTO
        where TObjectReplyDTO : class
    {
        public TObjectReplyDTO ObjectReplyEntity { get; set; }
    }
}