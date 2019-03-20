using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bonobo.Parameters
{
    [Serializable]
    public class Parameters:IParameters
    {
        [JsonProperty]
        public string ResourceGroupName 
        {
            get
            {
                if(values == null || !values.ContainsKey("ResourceGroupName"))
                {
                    return null;
                }
                return values["ResourceGroupName"];
            }
            set
            {
                if(values == null)
                {
                    values = new Dictionary<string, string>();
                }
                else
                {
                    if(values.ContainsKey("ResourceGroupName"))
                    {
                        values.Remove("ResourceGroupName");
                    }
                }
                if(!String.IsNullOrWhiteSpace(value))
                {
                    values.Add("ResourceGroupName", value);
                }
            }
        }

        [JsonProperty]
        public Guid SubscriptionId
        {
            get
            {
                if(values == null || !values.ContainsKey("SubscriptionId"))
                {
                    return Guid.Empty;
                }
                if(Guid.TryParse(values["SubscriptionId"], out Guid result))
                {
                    return result;
                }
                return Guid.Empty;
            }
            set
            {
                if(values == null)
                {
                    values = new Dictionary<string, string>();
                }
                else
                {
                    if(values.ContainsKey("SubscriptionId"))
                    {
                        values.Remove("SubscriptionId");
                    }
                }
                if(value != null)
                {
                    values.Add("SubscriptionId", value.ToString());
                }
            }
        }

        private Dictionary<string, string> values = new Dictionary<string, string>();
        public IDictionary<string, string> Values => values;

        [JsonConstructor]
        public Parameters()
        {
            
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}