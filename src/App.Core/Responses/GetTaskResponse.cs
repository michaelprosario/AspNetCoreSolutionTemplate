using System.Runtime.Serialization;
using App.Core.Entities;

namespace App.Core.Responses
{
    [DataContract]
    public class GetTaskResponse : Response {
        
        [DataMember]
        public TaskItem Record { get; set; }
    }   
}