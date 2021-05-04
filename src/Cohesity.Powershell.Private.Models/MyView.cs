using System.Runtime.Serialization;
using System;

namespace Cohesity.Private.Model
{
    [DataContract]
    public partial class MyView : IEquatable<MyView>
    {
        [DataMember(Name = "createTimeMsecs", EmitDefaultValue = true)]
        public long? CreateTimeMsecs { get; set; }
        public bool Equals(MyView other)
        {
            if(other == null)
            {
                return false;
            }
            return (
                (this.CreateTimeMsecs == other.CreateTimeMsecs)
            );
        }
    }
}