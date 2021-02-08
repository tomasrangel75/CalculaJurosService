namespace CalculaJurosService.Infrastructure.DataTransferObjects
{
    public static class ObjectReplyExtension
    {
        #region Methods

        public static ObjectReplyDTO<TObjectReplyDTO> ConvertToObjectReplyGenericDTO<TObjectReplyDTO>(this ObjectReplyDTO objectReplyDTO)
            where TObjectReplyDTO : class
        {
            return Convert<TObjectReplyDTO>(objectReplyDTO);
        }

        public static ObjectReplyDTO ConvertToObjectReplyDTO<TObjectReplyDTO>(this ObjectReplyDTO<TObjectReplyDTO> objectReplyGenericDTO)
            where TObjectReplyDTO : class
        {
            return new ObjectReplyDTO() { Message = objectReplyGenericDTO.Message, StatusReplyCode = objectReplyGenericDTO.StatusReplyCode };
        }

        private static ObjectReplyDTO<TObjectReplyDTO> Convert<TObjectReplyDTO>(ObjectReplyDTO objectReplyDTO)
            where TObjectReplyDTO : class
        {
            return new ObjectReplyDTO<TObjectReplyDTO>() { Message = objectReplyDTO.Message, StatusReplyCode = objectReplyDTO.StatusReplyCode };
        }

        #endregion
    }
}
