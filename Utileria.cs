using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using System.Configuration;
using System.Windows.Forms;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace ImportadorRemisiones
{
    class Utileria
    {
        public static int GetTipoMoneda(string tipo)
        {
            int tipoMoneda = 1;
            switch (tipo)
            {
                /*
                // -- Dolares
                case "4002017": // 3.0
                    tipoMoneda = 2;
                    break;

                case "400201740": // 4.0
                    tipoMoneda = 2;
                    break;

                case "400":
                    tipoMoneda = 2;
                    break;

                // -- Pesos
                case "4012017": // 3.0 MN
                    tipoMoneda = 1;
                    break;

                case "401201740": // 4.0 MN
                    tipoMoneda = 1;
                    break;
                *///codigo de manu que cambie para las tipos de facturas que agregue:

                //PESOS
                case "21": //compra
                    tipoMoneda = 1;
                    break;
                case "19": //orden de compra
                    tipoMoneda = 1;
                    break;
                case "218": // material CHINA
                    tipoMoneda = 1;
                    break;
                case "217": // compra SEMILLA
                    tipoMoneda = 1;
                    break;
                case "211": //compras agroquimicos pesos
                    tipoMoneda = 1;
                    break;
                case "213": //compras repuestos pesos
                    tipoMoneda = 1;
                    break;
                case "215": //compras material empque pesos
                    tipoMoneda = 1;
                    break;

                //DOLARES
                case "212": //compras agroquimicas en dolares
                    tipoMoneda = 2;
                    break;
                case "214"://compras repuestos dolares
                    tipoMoneda = 2;
                    break;
                case "216": //compras material empaque dolares
                    tipoMoneda = 1;
                    break;



                default:
                    break;
            }

            return tipoMoneda;
        }

        public static DataRow GetCliente(string clienteid)
        {
            MySqlDatabase mySqlData = new MySqlDatabase();

            DataTable result = mySqlData.ResultQuery($"SELECT * FROM tblclientes WHERE idcliente={clienteid}");

            if (result.Rows.Count > 0)
            {
                return result.Rows[0];
            }
            return null;
        }

        public static DataRow GetClientePorNoCliente(string nocliente)
        {
            MySqlDatabase mySqlData = new MySqlDatabase();

            DataTable result = mySqlData.ResultQuery($"SELECT * FROM tblclientes WHERE nocliente={nocliente}");

            if (result.Rows.Count > 0)
            {
                return result.Rows[0];
            }
            return null;
        }
        public async Task<string> getClienteRow(string idCliente)
        {
            string apiUrl = string.Format(ConfigurationManager.AppSettings["APINODE"]) +"data/orden-cliente";


            using (HttpClient client = new HttpClient())
            {
                var postData = new { cidcliente = idCliente };
                var jsonContent = new StringContent(JsonConvert.SerializeObject(postData), Encoding.UTF8, "application/json");
                // Realizar una solicitud GET al API
                HttpResponseMessage response = await client.PostAsync(apiUrl,jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(apiResponse);

                    return apiResponse;
                }
                else
                {
                    // Manejar el caso en que la solicitud al API no sea exitosa
                    Console.WriteLine("Error en la solicitud al API. Código de estado: " + response.StatusCode);
                    return null;
                }
            }
        }
        public async Task<string> getIdAlmacen(string acidproducto)
        {
            string apiUrl = string.Format(ConfigurationManager.AppSettings["APINODE"]) + "data/precio-articulo";

            using (HttpClient client = new HttpClient())
            {
                var postData = new { cidproducto = acidproducto };
                var jsonContent = new StringContent(JsonConvert.SerializeObject(postData), Encoding.UTF8, "application/json");
                // Realizar una solicitud GET al API
                HttpResponseMessage response = await client.PostAsync(apiUrl, jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(apiResponse);
                    JsonTextReader apiJson = new JsonTextReader(new StringReader(apiResponse));

                    return valueJson(apiJson,"CIDALMACEN");
                }
                else
                {
                    // Manejar el caso en que la solicitud al API no sea exitosa
                    Console.WriteLine("Error en la solicitud al API. Código de estado: " + response.StatusCode);
                    return null;
                }
            }
        }
        public async Task<DataTable> getProductos(string idOrden, string codigo_cliente, int documento_id, int moneda)
        {
            string apiUrl = string.Format(ConfigurationManager.AppSettings["APINODE"]) + "data/productos-cliente?oid="+idOrden.ToString()+"&did="+documento_id.ToString()+"&moneda="+moneda.ToString()+"&aproveedor="+codigo_cliente;


            using (HttpClient client = new HttpClient())
            {
                // Realizar una solicitud GET al API
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //MessageBox.Show("PRODUCTOS:" + apiResponse);
                    DataTable dataTable = new DataTable();
                    dataTable = JsonConvert.DeserializeObject<DataTable>(apiResponse);

                    return dataTable;
                }
                else
                {
                    // Manejar el caso en que la solicitud al API no sea exitosa
                    Console.WriteLine("Error en la solicitud al API. Código de estado: " + response.StatusCode);
                    return null;
                }
            }
        }

        public async Task marcarProductoImportado(string json)
        {
            string apiUrl = string.Format(ConfigurationManager.AppSettings["APINODE"]) + "data/importar-productos";


            using (HttpClient client = new HttpClient())
            {
                var postData = new
                {
                    productosid = json,
                };
                var jsonContent = new StringContent(JsonConvert.SerializeObject(postData), Encoding.UTF8, "application/json");
                // Realizar una solicitud GET al API
                HttpResponseMessage response = await client.PostAsync(apiUrl, jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(apiResponse);
                    Console.WriteLine("jsonList:", json);
                }
                else
                {
                    // Manejar el caso en que la solicitud al API no sea exitosa
                    Console.WriteLine("Error en la solicitud al API. Código de estado: " + response.StatusCode);
                }
            }
        }

        public async Task marcarProductosImportados(string jsonList)
        {
            string apiUrl = string.Format(ConfigurationManager.AppSettings["APINODE"]) + "data/importar-productos";
            

            using (HttpClient client = new HttpClient())
            {
                var postData = new
                {
                    productosid = jsonList,
                };
                var jsonContent = new StringContent(JsonConvert.SerializeObject(postData), Encoding.UTF8, "application/json");
                // Realizar una solicitud GET al API
                HttpResponseMessage response = await client.PostAsync(apiUrl, jsonContent);

                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(apiResponse);
                    Console.WriteLine("jsonList:", jsonList);
                }
                else
                {
                    // Manejar el caso en que la solicitud al API no sea exitosa
                    Console.WriteLine("Error en la solicitud al API. Código de estado: " + response.StatusCode);
                }
            }
        }
        private string valueJson(JsonTextReader reader, string key)
        {
            while (reader.Read())
            {
                //Console.WriteLine("TokenType: {0}, Value: {1}", reader.TokenType, reader.Value);
                if (reader.Value != null)
                {
                    if (reader.Value.ToString() == key)
                    {
                        reader.Read();
                        if (reader.Value != null)
                        {
                            //Console.WriteLine("Key: {0}, Value: {1}", key, reader.Value);
                            return reader.Value.ToString();
                        }
                        else
                        {
                            Console.WriteLine("Token: {0}, Value: null", reader.TokenType);
                            return "";
                        }
                    }
                }
            }
            return "";
        }

        //funcion para obtener el tipo de cambio
        public static async Task<decimal> ObtenerTipoCambio()
        {
            string url = "https://latest.currency-api.pages.dev/v1/currencies/usd.json";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Realiza la solicitud HTTP.
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode(); // Lanza excepción si la solicitud falla.

                    // Obtiene el contenido como string.
                    string json = await response.Content.ReadAsStringAsync();

                    // Deserializa el JSON para extraer el tipo de cambio.
                    var jsonData = JsonConvert.DeserializeObject<RootResponse>(json);
                    if (jsonData != null && jsonData.usd?.mxn != null)
                    {
                        return jsonData.usd.mxn.Value; // Retorna el tipo de cambio.
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al inicializar el tipo de cambio: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // En caso de error, retorna un valor predeterminado.
                return 20m;
            }

            // Valor predeterminado si no se pudo obtener el tipo de cambio.
            return 20m;
        }

        // Clase interna para mapear la estructura JSON.
        private class RootResponse
        {
            public UsdData usd { get; set; }
        }

        private class UsdData
        {
            public decimal? mxn { get; set; }
        }

        /// <summary>
        /// Obtiene una lista de facturas desde una API.
        /// </summary>
        /// <param name="url">La URL de la API.</param>
        /// <returns>Una lista de objetos Factura.</returns>
        public async Task<List<Factura>> GetFacturasFromApiAsyncByOrden(int oid)
        {
            try
            {
                string url = string.Format(ConfigurationManager.AppSettings["APINODE"]) + "data/ordenes-compra/documentos?oid=" + oid.ToString();
                using (HttpClient client = new HttpClient())
                {
                    // Realiza la solicitud HTTP
                    HttpResponseMessage response = await client.GetAsync(url);

                    // Verifica si la respuesta fue exitosa
                    response.EnsureSuccessStatusCode();

                    // Lee el contenido de la respuesta como cadena
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Deserializa el JSON a una lista de objetos 
                    return JsonConvert.DeserializeObject<List<Factura>>(jsonResponse) ?? new List<Factura>();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener o procesar las facturas: {ex.Message}");
                return new List<Factura>(); // Retorna una lista vacía en caso de error
            }
        }

        public class Factura
        {
            public int factura_codigo { get; set; }
            public int moneda_codigo { get; set; }
            public string codigo_cliente { get; set; }
            public int documento_id { get; set; }
        }
    }
}