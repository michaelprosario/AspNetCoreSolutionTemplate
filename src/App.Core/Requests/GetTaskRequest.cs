using System.Runtime.Serialization;

namespace App.Core.Requests
{
    [DataContract]
    public class GetTaskRequest{
        [DataMember]
        public int Id { get; set; }
    }   
}