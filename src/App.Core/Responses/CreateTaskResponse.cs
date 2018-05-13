using System.Runtime.Serialization;

namespace App.Core.Responses
{
    [DataContract]
    public class CreateTaskResponse : Response {
        [DataMember]
        public long Id { get; set; }
    }   
}