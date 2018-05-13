using System.Runtime.Serialization;

namespace App.Core.Requests
{
    [DataContract]
    public class DeleteTaskRequest{
		[DataMember]
		public int Id { get; set; }
	}    
}