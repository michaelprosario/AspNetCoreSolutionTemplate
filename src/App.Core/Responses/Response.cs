using System.Runtime.Serialization;
using App.Core.Enums;

namespace App.Core.Responses
{
    [DataContract]
    public class Response{

        [DataMember]
        public ResponseCode Code {get; set; }

        [DataMember]
        public string Message { get; set; }
    }   
}