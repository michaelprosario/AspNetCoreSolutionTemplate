using System.Collections.Generic;
using System.Runtime.Serialization;
using App.Core.Entities;

namespace App.Core.Responses
{
    [DataContract]
    public class ListTasksResponse : Response {
        [DataMember]
        public IList<TaskItem> Records { get; set; }        
    }   
}