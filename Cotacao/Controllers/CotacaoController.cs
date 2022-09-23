using Cotacao.Data;
using Cotacao.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace Cotacao.Controllers
{
    [ApiController]
    [Route("v1/[controller]/")]
    public class CotacaoController : ControllerBase
    {    //FALTA MAPEAR O RETORNO DO JSON ELE TA RETORNANDO JUNTAMENTE DADOS DA SOLICITACAO
         //Retorna a ultima ocorrência das moedas selecionadas.
         //Ex.: https://economia.awesomeapi.com.br/last/USD-BRL,EUR-BRL,BTC-BRL
        private const string LastCoins = "https://economia.awesomeapi.com.br/last/";

        private readonly ILogger<CotacaoController> _logger;
        private readonly ApplicationDbContext _dbContext;
        public CotacaoController(ILogger<CotacaoController> logger, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _logger = logger;
        }


        [HttpGet("ALL")]
        public async Task<IActionResult> GetAll()
        {
            for (int p = 0; p < 60; p++)
            {

                for (int i = 0; i <= 3; i++)
                {

                    List<string>? fibNumbers = new List<string> { "USD-BRL", "EUR-BRL", "BTC-BRL", "RUB-BRL" };

                    // var httpclient = new HttpClient();
                    // var response = await httpclient.GetAsync(LastCoins + fibNumbers[i] );
                    // var result = response.Content.ReadAsStringAsync().Result;
                    // Root ?myDeserializedClass = JsonConvert.DeserializeObject<Root>(response);
                    var client = new RestClient(LastCoins + fibNumbers[i]);
                    var request = new RestRequest("", Method.Get);

                    var response2 = client.Execute(request).Content;
                    Root? myDeserializedClass = JsonConvert.DeserializeObject<Root>(response2);
                    // var response = await client.GetAsync<Root>(request);



                    //  Root ?myDeserializedClass = JsonConvert.DeserializeObject<Root>(response);
                    if (i == 0)
                    {
                        _dbContext.Add(myDeserializedClass.USDBRL);
                        _dbContext.SaveChanges();
                    }
                    else if (i == 1)
                    {
                        _dbContext.Add(myDeserializedClass.EURBRL);
                        _dbContext.SaveChanges();
                    }
                    else if (i == 2)
                    {
                        _dbContext.Add(myDeserializedClass.BTCBRL);
                        _dbContext.SaveChanges();
                    }
                    else if (i == 3)
                    {
                        _dbContext.Add(myDeserializedClass.RUBBRL);
                        _dbContext.SaveChanges();
                    }
                }
                await Task.Delay(30000);
            }

            return Ok(new { msg = "Criado no banco com sucesso" });



            // var client = new RestClient();

            // var request = new RestRequest("", Method.Get);
            // request.AddQueryParameter("Moeda", Moeda);
            // request.AddQueryParameter("Convercao", Convercao);

            // var result = await client.GetAsync<MOEDA>(request);




        }

        [HttpGet(Name = "TestController")]
        public async Task<IActionResult> GetSiglas([FromQuery]string origem , string conversation)

        {   
            string Sigla = $"{origem+"-"+ conversation}";

            var client = new RestClient(LastCoins+Sigla);
            var request = new RestRequest("", Method.Get);

            var response2 = client.Execute(request).Content;
            //Root ?myDeserializedClass = JsonConvert.DeserializeObject<Root>(response2);
            Root ?myDeserializedClass = JsonConvert.DeserializeObject<Root>(response2);
            Root m = new Root();
            
            
            [JsonProperty(PropertyName = "CNYBRL")]
            m.MoedaGenericas = m.MoedaGenericas;
        


            _dbContext.Add(myDeserializedClass.MoedaGenericas);
            _dbContext.SaveChanges();
            
            string sig = origem + conversation;

            return Ok( new {msg = "Criado no banco com sucesso" });
   
        }



        //         private PokemonListViewModel MapToViewModel(NamedAPIResourceList resourceList) {
        //         return new PokemonListViewModel {
        //             Count = resourceList.Count,
        //             Pokemons = resourceList.Results.Select(p => {
        //                 var lastSegment = new Uri(p.Url).Segments.Last(); // 73/
        //                 var id = lastSegment.Remove(lastSegment.Length - 1);

        //                 return new PokemonListItemViewModel { Name = p.Name, Id = int.Parse(id)};
        //             })
        //         };
        //     }

        //     public class PokemonListViewModel {
        //     public int Count { get; set; }
        //     public IEnumerable<PokemonListItemViewModel> Pokemons { get; set; }
        // }
    }
}