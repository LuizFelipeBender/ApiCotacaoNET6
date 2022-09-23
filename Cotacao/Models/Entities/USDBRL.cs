using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Linq;
using System.Threading.Tasks;

namespace Cotacao.Models.Entities
{    
    public class MOEDAS
    {
        [Key]
        public int ?Id { get; set; }
        [JsonProperty(PropertyName = "code")]
        [DisplayName("Converter de")]
        [Column("Converter de")]
        public string ?code { get; set; }

        [JsonProperty(PropertyName = "codein")]
        [DisplayName("Converter para")]
        [Column("Converter para")]
        public string ?codein { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        [DisplayName("Descricao da convercao")]
        [Column("Descricao da convercao")]
        public string ?name { get; set; }

        [JsonProperty(PropertyName = "high")]
        [DisplayName("Alta da moeda")]
        [Column("Alta da moeda")]
        public string ?high { get; set; }

        [JsonProperty(PropertyName = "low")]
        [DisplayName("Baixa da Moeda")]
        [Column("Baixa da Moeda")]
        public string ?low { get; set; }


        [JsonProperty(PropertyName = "varBid")]
        [DisplayName("Variação da moeda")]
        [Column("Variação da moeda")]
        public string ?varBid { get; set; }

        [JsonProperty(PropertyName = "pctChange")]
        [DisplayName("Porcetagem de variação")]
        [Column("Porcetagem de variação")]
        public string ?pctChange { get; set; }

        [JsonProperty(PropertyName = "bid")]
        [DisplayName("Compra")]
        [Column("Compra")]
        public string ?bid { get; set; }

        [JsonProperty(PropertyName = "ask")]
        [DisplayName("Venda")]
        [Column("Venda"),]
        public string ?ask { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        [DisplayName("Carimbo de data/hora")]
        [Column("Carimbo de data/hora")]
        public string ?timestamp { get; set; }

        [JsonProperty(PropertyName = "create_date")]
        [DisplayName("Data/Hora")]
        [Column("Data/Hora")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
         public string ?create_date { get; set; }
    }
    public class MoedaGenerica
    {
        [Key]
        public int ?Id { get; set; }
        [JsonProperty(PropertyName = "code")]
        [DisplayName("Converter de")]
        [Column("Converter de")]
        public string ?code { get; set; }

        [JsonProperty(PropertyName = "codein")]
        [DisplayName("Converter para")]
        [Column("Converter para")]
        public string ?codein { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        [DisplayName("Descricao da convercao")]
        [Column("Descricao da convercao")]
        public string ?name { get; set; }

        [JsonProperty(PropertyName = "high")]
        [DisplayName("Alta da moeda")]
        [Column("Alta da moeda")]
        public string ?high { get; set; }

        [JsonProperty(PropertyName = "low")]
        [DisplayName("Baixa da Moeda")]
        [Column("Baixa da Moeda")]
        public string ?low { get; set; }


        [JsonProperty(PropertyName = "varBid")]
        [DisplayName("Variação da moeda")]
        [Column("Variação da moeda")]
        public string ?varBid { get; set; }

        [JsonProperty(PropertyName = "pctChange")]
        [DisplayName("Porcetagem de variação")]
        [Column("Porcetagem de variação")]
        public string ?pctChange { get; set; }

        [JsonProperty(PropertyName = "bid")]
        [DisplayName("Compra")]
        [Column("Compra")]
        public string ?bid { get; set; }

        [JsonProperty(PropertyName = "ask")]
        [DisplayName("Venda")]
        [Column("Venda"),]
        public string ?ask { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        [DisplayName("Carimbo de data/hora")]
        [Column("Carimbo de data/hora")]
        public string ?timestamp { get; set; }

        [JsonProperty(PropertyName = "create_date")]
        [DisplayName("Data/Hora")]
        [Column("Data/Hora")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
         public string ?create_date { get; set; }
    }

        public class USDBRL
    {
        [Key]
        public int ?Id { get; set; }
        [JsonProperty(PropertyName = "code")]
        [DisplayName("Converter de")]
        [Column("Converter de")]
        public string ?code { get; set; }

        [JsonProperty(PropertyName = "codein")]
        [DisplayName("Converter para")]
        [Column("Converter para")]
        public string ?codein { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        [DisplayName("Descricao da convercao")]
        [Column("Descricao da convercao")]
        public string ?name { get; set; }

        [JsonProperty(PropertyName = "high")]
        [DisplayName("Alta da moeda")]
        [Column("Alta da moeda")]
        public string ?high { get; set; }

        [JsonProperty(PropertyName = "low")]
        [DisplayName("Baixa da Moeda")]
        [Column("Baixa da Moeda")]
        public string ?low { get; set; }


        [JsonProperty(PropertyName = "varBid")]
        [DisplayName("Variação da moeda")]
        [Column("Variação da moeda")]
        public string ?varBid { get; set; }

        [JsonProperty(PropertyName = "pctChange")]
        [DisplayName("Porcetagem de variação")]
        [Column("Porcetagem de variação")]
        public string ?pctChange { get; set; }

        [JsonProperty(PropertyName = "bid")]
        [DisplayName("Compra")]
        [Column("Compra")]
        public string ?bid { get; set; }

        [JsonProperty(PropertyName = "ask")]
        [DisplayName("Venda")]
        [Column("Venda"),]
        public string ?ask { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        [DisplayName("Carimbo de data/hora")]
        [Column("Carimbo de data/hora")]
        public string ?timestamp { get; set; }

        [JsonProperty(PropertyName = "create_date")]
        [DisplayName("Data/Hora")]
        [Column("Data/Hora")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
         public string ?create_date { get; set; }
    }
    public class RUBBRL
    {
        [Key]
        public int ?Id { get; set; }
        [JsonProperty(PropertyName = "code")]
        [DisplayName("Converter de")]
        [Column("Converter de")]
        public string ?code { get; set; }

        [JsonProperty(PropertyName = "codein")]
        [DisplayName("Converter para")]
        [Column("Converter para")]
        public string ?codein { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        [DisplayName("Descricao da convercao")]
        [Column("Descricao da convercao")]
        public string ?name { get; set; }

        [JsonProperty(PropertyName = "high")]
        [DisplayName("Alta da moeda")]
        [Column("Alta da moeda")]
        public string ?high { get; set; }

        [JsonProperty(PropertyName = "low")]
        [DisplayName("Baixa da Moeda")]
        [Column("Baixa da Moeda")]
        public string ?low { get; set; }


        [JsonProperty(PropertyName = "varBid")]
        [DisplayName("Variação da moeda")]
        [Column("Variação da moeda")]
        public string ?varBid { get; set; }

        [JsonProperty(PropertyName = "pctChange")]
        [DisplayName("Porcetagem de variação")]
        [Column("Porcetagem de variação")]
        public string ?pctChange { get; set; }

        [JsonProperty(PropertyName = "bid")]
        [DisplayName("Compra")]
        [Column("Compra")]
        public string ?bid { get; set; }

        [JsonProperty(PropertyName = "ask")]
        [DisplayName("Venda")]
        [Column("Venda"),]
        public string ?ask { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        [DisplayName("Carimbo de data/hora")]
        [Column("Carimbo de data/hora")]
        public string ?timestamp { get; set; }

        [JsonProperty(PropertyName = "create_date")]
        [DisplayName("Data/Hora")]
        [Column("Data/Hora")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
         public string ?create_date { get; set; }
    }

     
        public class BTCBRL
    {
        [Key]
        public int ?Id { get; set; }
        [JsonProperty(PropertyName = "code")]
        [DisplayName("Converter de")]
        [Column("Converter de")]
        public string ?code { get; set; }

        [JsonProperty(PropertyName = "codein")]
        [DisplayName("Converter para")]
        [Column("Converter para")]
        public string ?codein { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        [DisplayName("Descricao da convercao")]
        [Column("Descricao da convercao")]
        public string ?name { get; set; }

        [JsonProperty(PropertyName = "high")]
        [DisplayName("Alta da moeda")]
        [Column("Alta da moeda")]
        public string ?high { get; set; }

        [JsonProperty(PropertyName = "low")]
        [DisplayName("Baixa da Moeda")]
        [Column("Baixa da Moeda")]
        public string ?low { get; set; }


        [JsonProperty(PropertyName = "varBid")]
        [DisplayName("Variação da moeda")]
        [Column("Variação da moeda")]
        public string ?varBid { get; set; }

        [JsonProperty(PropertyName = "pctChange")]
        [DisplayName("Porcetagem de variação")]
        [Column("Porcetagem de variação")]
        public string ?pctChange { get; set; }

        [JsonProperty(PropertyName = "bid")]
        [DisplayName("Compra")]
        [Column("Compra")]
        public string ?bid { get; set; }

        [JsonProperty(PropertyName = "ask")]
        [DisplayName("Venda")]
        [Column("Venda"),]
        public string ?ask { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        [DisplayName("Carimbo de data/hora")]
        [Column("Carimbo de data/hora")]
        public string ?timestamp { get; set; }

        [JsonProperty(PropertyName = "create_date")]
        [DisplayName("Data/Hora")]
        [Column("Data/Hora")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
         public string ?create_date { get; set; }
    }
             
        public class EURBRL
    {
        [Key]
        public int ?Id { get; set; }
        [JsonProperty(PropertyName = "code")]
        [DisplayName("Converter de")]
        [Column("Converter de")]
        public string ?code { get; set; }

        [JsonProperty(PropertyName = "codein")]
        [DisplayName("Converter para")]
        [Column("Converter para")]
        public string ?codein { get; set; }
        
        [JsonProperty(PropertyName = "name")]
        [DisplayName("Descricao da convercao")]
        [Column("Descricao da convercao")]
        public string ?name { get; set; }

        [JsonProperty(PropertyName = "high")]
        [DisplayName("Alta da moeda")]
        [Column("Alta da moeda")]
        public string ?high { get; set; }

        [JsonProperty(PropertyName = "low")]
        [DisplayName("Baixa da Moeda")]
        [Column("Baixa da Moeda")]
        public string ?low { get; set; }


        [JsonProperty(PropertyName = "varBid")]
        [DisplayName("Variação da moeda")]
        [Column("Variação da moeda")]
        public string ?varBid { get; set; }

        [JsonProperty(PropertyName = "pctChange")]
        [DisplayName("Porcetagem de variação")]
        [Column("Porcetagem de variação")]
        public string ?pctChange { get; set; }

        [JsonProperty(PropertyName = "bid")]
        [DisplayName("Compra")]
        [Column("Compra")]
        public string ?bid { get; set; }

        [JsonProperty(PropertyName = "ask")]
        [DisplayName("Venda")]
        [Column("Venda"),]
        public string ?ask { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        [DisplayName("Carimbo de data/hora")]
        [Column("Carimbo de data/hora")]
        public string ?timestamp { get; set; }

        [JsonProperty(PropertyName = "create_date")]
        [DisplayName("Data/Hora")]
        [Column("Data/Hora")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
         public string ?create_date { get; set; }
    }
    }
    