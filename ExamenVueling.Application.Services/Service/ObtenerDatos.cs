using ExamenVueling.Application.Dto;
using ExamenVueling.Application.Services.Mappers;
using ExamenVueling.Common.Layer;
using ExamenVueling.Domain.Models;
using ExamenVueling.Infrastructure.Repository.Contracts;
using ExamenVueling.Infrastructure.Repository.Repository;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Application.Services.Service
{
    public class ObtenerDatos
    {
        private readonly IRepository<ClientsEntity> iRepository;

        public ObtenerDatos() : this(new ClientsRepository())
        {
        }

        public ObtenerDatos(ClientsRepository clientsRepository)
        {
            this.iRepository = clientsRepository;
        }



        public async void ObtenerClients(string url)
        {
            HttpClient httpClients = new HttpClient();

            List<ClientsEntity> listado = new List<ClientsEntity>();

            try
            {
                HttpResponseMessage response = httpClients.GetAsync(url).Result;

                if (response.IsSuccessStatusCode)
                {
                    var JsonString = await response.Content.ReadAsStringAsync();
                    DataSet deserialized = JsonConvert.DeserializeObject<DataSet>(JsonString);

                    DataTable dataTable = deserialized.Tables["Clients"];

                    /*
                    foreach (DataRow row in dataTable.Rows)
                    {
                        //Guid originalGuid = Guid.ParseExact(row["id"].ToString(), "D");
                        ClientsDto clientDto = new ClientsDto( Guid.Parse(row["id"].ToString()), row["name"].ToString(), row["email"].ToString(), row["role"].ToString());

                        listado.Add(iRepository.Add(MapperApplicationClients.ClientDtoToClientEntity(clientDto)));
                    }
                    */

                    var jObject = JObject.Parse(JsonString);
                    var jToken = jObject.GetValue("clients");
                    //listado = deserialized;
                    

                    using (TextWriter fichero = new StreamWriter($"C:/Users/formacion/source/repos/ExamenVueling/Logs/texto.json"))
                    {
                        for(int n = 0; n < jToken.Count(); n++ )
                        { 
                            fichero.WriteLine(jToken[n]);
                        }
                    }
                    
                }
            }
            catch (VuelingExceptions ex)
            {
                throw ex;
            }

            /*
            if( listado != null)
            {
                foreach(var cliente in listado)
                {
                    iRepository.Add(cliente);
                }
            }
            */
            
        }
        
    }
}
