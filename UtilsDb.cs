using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ImportadorRemisiones
{
    internal class UtilsDb
    {   
        public MySqlDatabase Database { get; set; }

        public UtilsDb()
        {
            Database = new MySqlDatabase();
        }

        public double PesoArticulo(string idArticulo)
        {
            double peso = 0.0;
            // -- consulta del peso
            DataTable result = Database.ResultQuery("SELECT peso FROM tblproductos_ing WHERE idart=" + idArticulo + " LIMIT 1");

            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                peso = double.Parse( dataRow["peso"].ToString() );
            }

            return peso;
        }

        public double Pies2Articulo( string idArticulo )
        {
            double pies = 0.0;

            DataTable result = Database.ResultQuery("select area_real from tblproductos_ing where idart=" + idArticulo + " limit 1");

            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                pies = double.Parse( dataRow["area_real"].ToString() );
            }

            return pies;
        }

        public double GetPrecioArticuloOrden( string idRegOc )
        {
            double precio = 0.0;
            
            DataTable result = Database.ResultQuery("SELECT precio_vta FROM tblorden_compra_articulos WHERE idreg=" + idRegOc + " LIMIT 1");

            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                precio = double.Parse( dataRow["precio_vta"].ToString() );
            }

            return precio;
        }

        public double GetPrecioEmbarque(string idEmb)
        {
            double precio = 0.0;

            DataTable result = Database.ResultQuery("SELECT precio_vta FROM tblembarques WHERE idemb=" + idEmb + " LIMIT 1");

            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                precio = double.Parse(dataRow["precio_vta"].ToString());
            }

            return precio;
        }

        public string GetPoRemision( string idRem )
        {
            string poRem = "";

            DataTable result = Database.ResultQuery("select idoc from tblremisiones_art where idra=" + idRem + " LIMIT 1");

            if ( result.Rows.Count > 0 )
            {
                DataRow dataRow = result.Rows[0];
                int idoc = int.Parse( dataRow["idoc"].ToString() );

                poRem = idoc != 0 ? GetNombrePO(dataRow["idoc"].ToString()) : "CONTADO";
            }
            return poRem;                                                                                                                              
        }

        public string GetNombrePO( string idOc )
        {
            string nombre = "";

            DataTable result = Database.ResultQuery("select porder from tblorden_compra where idoc=" + idOc + " LIMIT 1");

            if (result.Rows.Count > 0) 
            {
                DataRow dataRow = result.Rows[0];
                nombre = dataRow["porder"].ToString();
            }

            return nombre;
        }

        public string GetResistenciaLaminaAsignadaArticulo( string idArt )
        {
            string resistencia = "";

            // -- Obtenemos la lamina utilizada en el articulo
            DataTable result = Database.ResultQuery("select idlamina from tblproductos_laminas_ing where idart=" + idArt + " LIMIT 1");

            if ( result.Rows.Count > 0 )
            {
                DataRow dataRow = result.Rows[0];
                resistencia = GetResistenciaLamina(dataRow["idlamina"].ToString());
            }

            return resistencia;
        }

        public string GetResistenciaLamina( string idLamina )
        {
            string resistencia = "";

            DataTable result = Database.ResultQuery("select resistencia,flauta,papel from tbllaminas where idlamina=" + idLamina + " LIMIT 1");

            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];

                string resist = dataRow["resistencia"].ToString();
                string flauta = dataRow["flauta"].ToString();
                string papel = dataRow["papel"].ToString();

                resistencia = $"{resist} {flauta} {papel}";
            }

            return resistencia;
        }

        public string GetNoPlanoArticulo( string idArticulo )
        {
            string noPlano = "";

            DataTable result = Database.ResultQuery("SELECT noplano FROM tblproductos_ing WHERE idart=" + idArticulo + " LIMIT 1");

            if (result.Rows.Count > 0) {
                DataRow dataRow = result.Rows[0];

                noPlano = dataRow["noplano"].ToString();
            }


            return noPlano;
        }

        public double GetPesoArticulo( string idArticulo )
        {
            double peso = 0.0;

            DataTable result = Database.ResultQuery("select peso from tblproductos_ing where idart=" + idArticulo + " LIMIT 1");

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                peso = double.Parse ( row["peso"].ToString() );
            }

            return peso;
        }

        /**
         * El Id del cliente en realidad es el No. Cliente ojo!!!
         * */
        public double GetIvaCliente(string idcliente)
        {
            double iva = 0;
            DataTable result = Database.ResultQuery("SELECT iva FROM tblclientes WHERE nocliente='" + idcliente + "' LIMIT 1");

            if (result.Rows.Count > 0)
            {
                DataRow dataRow = result.Rows[0];
                iva = double.Parse(dataRow["iva"].ToString());
            }

            return iva;
        }

        public void BanderaFacturaImportada(string idremision)
        {
            Database.NoResultQuery("UPDATE tblremisiones SET estatus='IMPORTADO',facturado_cp=1 WHERE idrem=" + idremision);
        }
    }
}
