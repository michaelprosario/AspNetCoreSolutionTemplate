using System.Runtime.Serialization;

namespace App.Core.Requests
{
    [DataContract]
    public class ListTasksRequest{
        [DataMember]
        public int Id { get; set; }
    }   
}