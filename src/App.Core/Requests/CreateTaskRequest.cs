using System.Runtime.Serialization;

namespace App.Core.Requests
{
    [DataContract]
    public class CreateTaskRequest{
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool IsComplete { get; set; }
    }   
}