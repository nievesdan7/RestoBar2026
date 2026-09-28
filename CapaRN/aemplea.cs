using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aemplea {

		#region Campos
            private DateTime _caelfecmod;
            private DateTime _caelfecing;
            private DateTime _caelfecsal;
            private decimal _caelsalemp;
            private bool _caelestemp;
            private DateTime _caelfeccre;
            private string _faelcodper;            
            private string _caeltipemp;
            private string _paelcodemp;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public DateTime caelfecmod
            { 
                get{ return this._caelfecmod;}
                set{ this._caelfecmod = value;}
            } 
		    public DateTime caelfecing
            { 
                get{ return this._caelfecing;}
                set{ this._caelfecing = value;}
            } 
		    public DateTime caelfecsal
            { 
                get{ return this._caelfecsal;}
                set{ this._caelfecsal = value;}
            } 
		    public decimal caelsalemp
            { 
                get{ return this._caelsalemp;}
                set{ this._caelsalemp = value;}
            } 
		    public bool caelestemp
            { 
                get{ return this._caelestemp;}
                set{ this._caelestemp = value;}
            } 
		    public DateTime caelfeccre
            { 
                get{ return this._caelfeccre;}
                set{ this._caelfeccre = value;}
            } 
		    public string faelcodper
            { 
                get{ return this._faelcodper;}
                set{ this._faelcodper = value;}
            } 		    
		    public string caeltipemp
            { 
                get{ return this._caeltipemp;}
                set{ this._caeltipemp = value;}
            } 
		    public string paelcodemp
            { 
                get{ return this._paelcodemp;}
                set{ this._paelcodemp = value;}
            } 
        #endregion

        #region Constructor
            public aemplea()
            { 
		        this._caelfecmod = DateTime.Now;
		        this._caelfecing = DateTime.Now;
		        this._caelfecsal = DateTime.Now;
		        this._caelsalemp = 0;
		        this._caelestemp = true;
		        this._caelfeccre = DateTime.Now;
		        this._faelcodper = "";		        
		        this._caeltipemp = "";
		        this._paelcodemp = "";
                this.Conexion = new CLConexionPGSQL();            
            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "caelfecmod," +
                                     "caelfecing," +
                                     "caelfecsal," +
                                     "caelsalemp," +
                                     "caelestemp," +
                                     "caelfeccre," +
                                     "faelcodper," +                                 
                                     "caeltipemp," +
                                     "paelcodemp " + 
                             "from aemplea " +
                             "where "+
                                    "paelcodemp = @paelcodemp";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@paelcodemp",this._paelcodemp);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._caelfecmod=ResultadoConsulta.GetDateTime(0);
                    this._caelfecing=ResultadoConsulta.GetDateTime(1);
                    this._caelfecsal=ResultadoConsulta.GetDateTime(2);
                    this._caelsalemp=ResultadoConsulta.GetDecimal(3);
                    this._caelestemp=ResultadoConsulta.GetBoolean(4);
                    this._caelfeccre=ResultadoConsulta.GetDateTime(5);
                    this._faelcodper=ResultadoConsulta.GetString(6);                   
                    this._caeltipemp=ResultadoConsulta.GetString(7);
                    this._paelcodemp=ResultadoConsulta.GetString(8);
                    this.Conexion.Desconectar();

                    return true;
                }
                else
                {
                    this.Conexion.Desconectar();
                    return false;
                }
            }
            public bool VerificarExistencia()
            { 
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "caelfecmod," +
                                     "caelfecing," +
                                     "caelfecsal," +
                                     "caelsalemp," +
                                     "caelestemp," +
                                     "caelfeccre," +
                                     "faelcodper," +                                     
                                     "caeltipemp," +
                                     "paelcodemp " + 
                             "from aemplea " +
                             "where " +
                                    "paelcodemp = @paelcodemp";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@paelcodemp",this._paelcodemp);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.HasRows)
                {
                this.Conexion.Desconectar();

                    return true;
                }
                else 
                { 

                this.Conexion.Desconectar();
                    return false;
                } 
            } 
            public bool Grabar()
            { 
                if (this.VerificarExistencia())
                {
                    return false;
                }
                else 
                { 
                    this.Conexion.Conectar();
			        string sql = "insert into aemplea (" +
                                                       "caelfecmod," +
                                                       "caelfecing," +
                                                       "caelfecsal," +
                                                       "caelsalemp," +
                                                       "caelestemp," +
                                                       "caelfeccre," +
                                                       "faelcodper," +                                                       
                                                       "caeltipemp," +
                                                       "paelcodemp" +
                                                       ") " +
	                             "values (" + 
                                          "@caelfecmod," +
                                          "@caelfecing," +
                                          "@caelfecsal," +
                                          "@caelsalemp," +
                                          "@caelestemp," +
                                          "@caelfeccre," +
                                          "@faelcodper," +                                          
                                          "@caeltipemp," +
                                          "@paelcodemp" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroFechaHora("@caelfecmod",this._caelfecmod);
                    this.Conexion.AsignarParametroFecha("@caelfecing",this._caelfecing);
                    this.Conexion.AsignarParametroFecha("@caelfecsal",this._caelfecsal);
                    this.Conexion.AsignarParametroDecimal("@caelsalemp",this._caelsalemp);
                    this.Conexion.AsignarParametroLogico("@caelestemp",this._caelestemp);
                    this.Conexion.AsignarParametroFechaHora("@caelfeccre",this._caelfeccre);
                    this.Conexion.AsignarParametroCadena("@faelcodper",this._faelcodper);
                    this.Conexion.AsignarParametroCadena("@caeltipemp",this._caeltipemp);
                    this.Conexion.AsignarParametroCadena("@paelcodemp",this._paelcodemp);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                } 
            } 
            public bool Modificar()
            { 
                if (!this.VerificarExistencia())
                {
                    return false;
                }
                else 
                { 
                    this.Conexion.Conectar();
			        string sql = "update aemplea set " +
                                                     "caelfecmod = @caelfecmod, " +
                                                     "caelfecing = @caelfecing, " +
                                                     "caelfecsal = @caelfecsal, " +
                                                     "caelsalemp = @caelsalemp, " +
                                                     "caelestemp = @caelestemp, " +
                                                     "caelfeccre = @caelfeccre, " +
                                                     "faelcodper = @faelcodper, " +                                                     
                                                     "caeltipemp = @caeltipemp" +
                                 " where " +
                                        "paelcodemp = @paelcodemp";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroFechaHora("@caelfecmod",this._caelfecmod);
                    this.Conexion.AsignarParametroFecha("@caelfecing",this._caelfecing);
                    this.Conexion.AsignarParametroFecha("@caelfecsal",this._caelfecsal);
                    this.Conexion.AsignarParametroDecimal("@caelsalemp",this._caelsalemp);
                    this.Conexion.AsignarParametroLogico("@caelestemp",this._caelestemp);
                    this.Conexion.AsignarParametroFechaHora("@caelfeccre",this._caelfeccre);
                    this.Conexion.AsignarParametroCadena("@faelcodper",this._faelcodper);                   
                    this.Conexion.AsignarParametroCadena("@caeltipemp",this._caeltipemp);
                    this.Conexion.AsignarParametroCadena("@paelcodemp",this._paelcodemp);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<aemplea> Lista(string where)
            { 
                List<aemplea> ListaResultado = new List<aemplea>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "caelfecmod," +
                                     "caelfecing," +
                                     "caelfecsal," +
                                     "caelsalemp," +
                                     "caelestemp," +
                                     "caelfeccre," +
                                     "faelcodper," +                                     
                                     "caeltipemp," +
                                     "paelcodemp " + 
                             "from aemplea " ;
 
                if (where.Replace(" ", "") != "")
                {
                    sql+= "where " + where;
                }

 
                this.Conexion.PrepararComando(sql); 
                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta!=null)
                {
                    while (ResultadoConsulta.Read())
                    {
                          aemplea Auxiliar = new aemplea();
                          Auxiliar.caelfecmod = ResultadoConsulta.GetDateTime(0);
                          Auxiliar.caelfecing = ResultadoConsulta.GetDateTime(1);
                          Auxiliar.caelfecsal = ResultadoConsulta.GetDateTime(2);
                          Auxiliar.caelsalemp = ResultadoConsulta.GetDecimal(3);
                          Auxiliar.caelestemp = ResultadoConsulta.GetBoolean(4);
                          Auxiliar.caelfeccre = ResultadoConsulta.GetDateTime(5);
                          Auxiliar.faelcodper = ResultadoConsulta.GetString(6);                         
                          Auxiliar.caeltipemp = ResultadoConsulta.GetString(7);
                          Auxiliar.paelcodemp = ResultadoConsulta.GetString(8);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

