using CalculaJurosService.Infrastructure.Enums;
using System.Text;

namespace CalculaJurosService.Infrastructure.DataTransferObjects
{
    public class ObjectReplyDTO
    {
        #region Fields

        private readonly StringBuilder message;

        #endregion

        #region Constructors

        public ObjectReplyDTO()
        {
            this.message = new StringBuilder();
        }

        #endregion

        #region Properties

        public string StatusReply { get { return this.StatusReplyCode.ToString(); } }

        public ObjectReplyEnum StatusReplyCode { get; set; }

        public string Message
        {
            get
            {
                return this.message.ToString();
            }

            set
            {
                this.message.AppendLine(value);
            }
        }

        #endregion
    }
}