using System.Text.Json.Serialization;
using MOSHOP.DAL.Models;

namespace MOSHOP.DAL.DTO.Requests
{
    public class CheckOutRequest
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public PaymentMethod PaymentMethod { get; set; }
    }
}
