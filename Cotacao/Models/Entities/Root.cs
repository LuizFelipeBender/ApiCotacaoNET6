using Newtonsoft.Json;
namespace Cotacao.Models.Entities
{
    public class Root
    {

        public int Id { get; set; }

        public USDBRL ?USDBRL { get; set; }
        public EURBRL ?EURBRL { get; set; }
        public BTCBRL ?BTCBRL { get; set; }
	  	public RUBBRL ?RUBBRL { get; set; }	

        public MOEDAS? MOEDAS { get; set; }
    

        [JsonProperty(PropertyName = "CNYBRL")]
        public MoedaGenerica? MoedaGenericas { get; set; }
    }

    

    }
