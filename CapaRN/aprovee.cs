using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aprovee {

		#region Campos
            private bool _capvestpro;
            private DateTime _capvfeccre;
            private DateTime _capvfecmod;
            private string _capvnitpro;
            private string _papvcodpro;
            private string _capvnumcue;
            private string _capvnomcon;
            private string _capvtelcon;
            private string _capvbannom;
            private string _fapvcodper;
            private string _capvrazsoc;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public bool capvestpro
            { 
                get{ return this._capvestpro;}
                set{ this._capvestpro = value;}
            } 
		    public DateTime capvfeccre
            { 
                get{ return this._capvfeccre;}
                set{ this._capvfeccre = value;}
            } 
		    public DateTime capvfecmod
            { 
                get{ return this._capvfecmod;}
                set{ this._capvfecmod = value;}
            } 
		    public string capvnitpro
            { 
                get{ return this._capvnitpro;}
                set{ this._capvnitpro = value;}
            } 
		    public string papvcodpro
            { 
                get{ return this._papvcodpro;}
                set{ this._papvcodpro = value;}
            } 
		    public string capvnumcue
            { 
                get{ return this._capvnumcue;}
                set{ this._capvnumcue = value;}
            } 
		    public string capvnomcon
            { 
                get{ return this._capvnomcon;}
                set{ this._capvnomcon = value;}
            } 
		    public string capvtelcon
            { 
                get{ return this._capvtelcon;}
                set{ this._capvtelcon = value;}
            } 
		    public string capvbannom
            { 
                get{ return this._capvbannom;}
                set{ this._capvbannom = value;}
            } 
		    public string fapvcodper
            { 
                get{ return this._fapvcodper;}
                set{ this._fapvcodper = value;}
            } 
		    public string capvrazsoc
            { 
                get{ return this._capvrazsoc;}
                set{ this._capvrazsoc = value;}
            } 
        #endregion

        #region Constructor
            public aprovee()
            { 
		        this._capvestpro = true;
		        this._capvfeccre = DateTime.Now;
		        this._capvfecmod = DateTime.Now;
		        this._capvnitpro = "";
		        this._papvcodpro = "";
		        this._capvnumcue = "";
		        this._capvnomcon = "";
		        this._capvtelcon = "";
		        this._capvbannom = "";
		        this._fapvcodper = "";
		        this._capvrazsoc = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "capvestpro," +
                                     "capvfeccre," +
                                     "capvfecmod," +
                                     "capvnitpro," +
                                     "papvcodpro," +
                                     "capvnumcue," +
                                     "capvnomcon," +
                                     "capvtelcon," +
                                     "capvbannom," +
                                     "fapvcodper," +
                                     "capvrazsoc " + 
                             "from aprovee " +
                             "where "+
                                    "papvcodpro = @papvcodpro";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@papvcodpro",this._papvcodpro);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._capvestpro=ResultadoConsulta.GetBoolean(0);
                    this._capvfeccre=ResultadoConsulta.GetDateTime(1);
                    this._capvfecmod=ResultadoConsulta.GetDateTime(2);
                    this._capvnitpro=ResultadoConsulta.GetString(3);
                    this._papvcodpro=ResultadoConsulta.GetString(4);
                    this._capvnumcue=ResultadoConsulta.GetString(5);
                    this._capvnomcon=ResultadoConsulta.GetString(6);
                    this._capvtelcon=ResultadoConsulta.GetString(7);
                    this._capvbannom=ResultadoConsulta.GetString(8);
                    this._fapvcodper=ResultadoConsulta.GetString(9);
                    this._capvrazsoc=ResultadoConsulta.GetString(10);
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
                                     "capvestpro," +
                                     "capvfeccre," +
                                     "capvfecmod," +
                                     "capvnitpro," +
                                     "papvcodpro," +
                                     "capvnumcue," +
                                     "capvnomcon," +
                                     "capvtelcon," +
                                     "capvbannom," +
                                     "fapvcodper," +
                                     "capvrazsoc " + 
                             "from aprovee " +
                             "where " +
                                    "papvcodpro = @papvcodpro";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@papvcodpro",this._papvcodpro);

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
			        string sql = "insert into aprovee (" +
                                                       "capvestpro," +
                                                       "capvfeccre," +
                                                       "capvfecmod," +
                                                       "capvnitpro," +
                                                       "papvcodpro," +
                                                       "capvnumcue," +
                                                       "capvnomcon," +
                                                       "capvtelcon," +
                                                       "capvbannom," +
                                                       "fapvcodper," +
                                                       "capvrazsoc" +
                                                       ") " +
	                             "values (" + 
                                          "@capvestpro," +
                                          "@capvfeccre," +
                                          "@capvfecmod," +
                                          "@capvnitpro," +
                                          "@papvcodpro," +
                                          "@capvnumcue," +
                                          "@capvnomcon," +
                                          "@capvtelcon," +
                                          "@capvbannom," +
                                          "@fapvcodper," +
                                          "@capvrazsoc" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroLogico("@capvestpro",this._capvestpro);
                    this.Conexion.AsignarParametroFechaHora("@capvfeccre",this._capvfeccre);
                    this.Conexion.AsignarParametroFechaHora("@capvfecmod",this._capvfecmod);
                    this.Conexion.AsignarParametroCadena("@capvnitpro",this._capvnitpro);
                    this.Conexion.AsignarParametroCadena("@papvcodpro",this._papvcodpro);
                    this.Conexion.AsignarParametroCadena("@capvnumcue",this._capvnumcue);
                    this.Conexion.AsignarParametroCadena("@capvnomcon",this._capvnomcon);
                    this.Conexion.AsignarParametroCadena("@capvtelcon",this._capvtelcon);
                    this.Conexion.AsignarParametroCadena("@capvbannom",this._capvbannom);
                    this.Conexion.AsignarParametroCadena("@fapvcodper",this._fapvcodper);
                    this.Conexion.AsignarParametroCadena("@capvrazsoc",this._capvrazsoc);

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
			        string sql = "update aprovee set " +
                                                     "capvestpro = @capvestpro, " +
                                                     "capvfeccre = @capvfeccre, " +
                                                     "capvfecmod = @capvfecmod, " +
                                                     "capvnitpro = @capvnitpro, " +
                                                     "capvnumcue = @capvnumcue, " +
                                                     "capvnomcon = @capvnomcon, " +
                                                     "capvtelcon = @capvtelcon, " +
                                                     "capvbannom = @capvbannom, " +
                                                     "fapvcodper = @fapvcodper, " +
                                                     "capvrazsoc = @capvrazsoc" +
                                 " where " +
                                        "papvcodpro = @papvcodpro";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroLogico("@capvestpro",this._capvestpro);
                    this.Conexion.AsignarParametroFechaHora("@capvfeccre",this._capvfeccre);
                    this.Conexion.AsignarParametroFechaHora("@capvfecmod",this._capvfecmod);
                    this.Conexion.AsignarParametroCadena("@capvnitpro",this._capvnitpro);
                    this.Conexion.AsignarParametroCadena("@papvcodpro",this._papvcodpro);
                    this.Conexion.AsignarParametroCadena("@capvnumcue",this._capvnumcue);
                    this.Conexion.AsignarParametroCadena("@capvnomcon",this._capvnomcon);
                    this.Conexion.AsignarParametroCadena("@capvtelcon",this._capvtelcon);
                    this.Conexion.AsignarParametroCadena("@capvbannom",this._capvbannom);
                    this.Conexion.AsignarParametroCadena("@fapvcodper",this._fapvcodper);
                    this.Conexion.AsignarParametroCadena("@capvrazsoc",this._capvrazsoc);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<aprovee> Lista(string where)
            { 
                List<aprovee> ListaResultado = new List<aprovee>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "capvestpro," +
                                     "capvfeccre," +
                                     "capvfecmod," +
                                     "capvnitpro," +
                                     "papvcodpro," +
                                     "capvnumcue," +
                                     "capvnomcon," +
                                     "capvtelcon," +
                                     "capvbannom," +
                                     "fapvcodper," +
                                     "capvrazsoc " + 
                             "from aprovee " ;
 
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
                          aprovee Auxiliar = new aprovee();
                          Auxiliar.capvestpro = ResultadoConsulta.GetBoolean(0);
                          Auxiliar.capvfeccre = ResultadoConsulta.GetDateTime(1);
                          Auxiliar.capvfecmod = ResultadoConsulta.GetDateTime(2);
                          Auxiliar.capvnitpro = ResultadoConsulta.GetString(3);
                          Auxiliar.papvcodpro = ResultadoConsulta.GetString(4);
                          Auxiliar.capvnumcue = ResultadoConsulta.GetString(5);
                          Auxiliar.capvnomcon = ResultadoConsulta.GetString(6);
                          Auxiliar.capvtelcon = ResultadoConsulta.GetString(7);
                          Auxiliar.capvbannom = ResultadoConsulta.GetString(8);
                          Auxiliar.fapvcodper = ResultadoConsulta.GetString(9);
                          Auxiliar.capvrazsoc = ResultadoConsulta.GetString(10);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

