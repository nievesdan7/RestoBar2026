using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aproduc {

		#region Campos
            private decimal _capdpreven;
            private decimal _capdvolpro;
            private decimal _capdpremin;
            private bool _capdconinv;
            private int _capdstopro;
            private DateTime _capdfeccre;
            private DateTime _capdfecmod;
            private bool _capdestpro;
            private string _fapdcodcat;
            private string _capdnompro;
            private string _capddespro;
            private string _capdcodbar;
            private string _capdunimed;
            private string _capdmarpro;
            private string _capdfotpro;
            private string _papdcodpro;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public decimal capdpreven
            { 
                get{ return this._capdpreven;}
                set{ this._capdpreven = value;}
            } 
		    public decimal capdvolpro
            { 
                get{ return this._capdvolpro;}
                set{ this._capdvolpro = value;}
            } 
		    public decimal capdpremin
            { 
                get{ return this._capdpremin;}
                set{ this._capdpremin = value;}
            } 
		    public bool capdconinv
            { 
                get{ return this._capdconinv;}
                set{ this._capdconinv = value;}
            } 
		    public int capdstopro
            { 
                get{ return this._capdstopro;}
                set{ this._capdstopro = value;}
            } 
		    public DateTime capdfeccre
            { 
                get{ return this._capdfeccre;}
                set{ this._capdfeccre = value;}
            } 
		    public DateTime capdfecmod
            { 
                get{ return this._capdfecmod;}
                set{ this._capdfecmod = value;}
            } 
		    public bool capdestpro
            { 
                get{ return this._capdestpro;}
                set{ this._capdestpro = value;}
            } 
		    public string fapdcodcat
            { 
                get{ return this._fapdcodcat;}
                set{ this._fapdcodcat = value;}
            } 
		    public string capdnompro
            { 
                get{ return this._capdnompro;}
                set{ this._capdnompro = value;}
            } 
		    public string capddespro
            { 
                get{ return this._capddespro;}
                set{ this._capddespro = value;}
            } 
		    public string capdcodbar
            { 
                get{ return this._capdcodbar;}
                set{ this._capdcodbar = value;}
            } 
		    public string capdunimed
            { 
                get{ return this._capdunimed;}
                set{ this._capdunimed = value;}
            } 
		    public string capdmarpro
            { 
                get{ return this._capdmarpro;}
                set{ this._capdmarpro = value;}
            } 
		    public string capdfotpro
            { 
                get{ return this._capdfotpro;}
                set{ this._capdfotpro = value;}
            } 
		    public string papdcodpro
            { 
                get{ return this._papdcodpro;}
                set{ this._papdcodpro = value;}
            } 
        #endregion

        #region Constructor
            public aproduc()
            { 
		        this._capdpreven = 0;
		        this._capdvolpro = 0;
		        this._capdpremin = 0;
		        this._capdconinv = true;
		        this._capdstopro = 0;
		        this._capdfeccre = DateTime.Now;
		        this._capdfecmod = DateTime.Now;
		        this._capdestpro = true;
		        this._fapdcodcat = "";
		        this._capdnompro = "";
		        this._capddespro = "";
		        this._capdcodbar = "";
		        this._capdunimed = "";
		        this._capdmarpro = "";
		        this._capdfotpro = "";
		        this._papdcodpro = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "capdpreven," +
                                     "capdvolpro," +
                                     "capdpremin," +
                                     "capdconinv," +
                                     "capdstopro," +
                                     "capdfeccre," +
                                     "capdfecmod," +
                                     "capdestpro," +
                                     "fapdcodcat," +
                                     "capdnompro," +
                                     "capddespro," +
                                     "capdcodbar," +
                                     "capdunimed," +
                                     "capdmarpro," +
                                     "capdfotpro," +
                                     "papdcodpro " + 
                             "from aproduc " +
                             "where "+
                                    "papdcodpro = @papdcodpro";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@papdcodpro",this._papdcodpro);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._capdpreven=ResultadoConsulta.GetDecimal(0);
                    this._capdvolpro=ResultadoConsulta.GetDecimal(1);
                    this._capdpremin=ResultadoConsulta.GetDecimal(2);
                    this._capdconinv=ResultadoConsulta.GetBoolean(3);
                    this._capdstopro=ResultadoConsulta.GetInt32(4);
                    this._capdfeccre=ResultadoConsulta.GetDateTime(5);
                    this._capdfecmod=ResultadoConsulta.GetDateTime(6);
                    this._capdestpro=ResultadoConsulta.GetBoolean(7);
                    this._fapdcodcat=ResultadoConsulta.GetString(8);
                    this._capdnompro=ResultadoConsulta.GetString(9);
                    this._capddespro=ResultadoConsulta.GetString(10);
                    this._capdcodbar=ResultadoConsulta.GetString(11);
                    this._capdunimed=ResultadoConsulta.GetString(12);
                    this._capdmarpro=ResultadoConsulta.GetString(13);
                    this._capdfotpro=ResultadoConsulta.GetString(14);
                    this._papdcodpro=ResultadoConsulta.GetString(15);
                    this.Conexion.Desconectar();

                    return true;
                }
                else
                {
                    this.Conexion.Desconectar();
                    return false;
                }
            }
            public bool ObtenerDatosCodigo(bool modificar, string cb)
        {
            this.Conexion.Conectar();
            string sql = "select " +
                                "capdpreven," +
                                "capdvolpro," +
                                "capdpremin," +
                                "capdconinv," +
                                "capdstopro," +
                                "capdfeccre," +
                                "capdfecmod," +
                                "capdestpro," +
                                "fapdcodcat," +
                                "capdnompro," +
                                "capddespro," +
                                "capdcodbar," +
                                "capdunimed," +
                                "capdmarpro," +
                                "capdfotpro," +
                                "papdcodpro " +
                         "from aproduc " +
                         "where " +
                                "capdcodbar = @capdcodbar";

            if (modificar)
            {
                sql += " and capdcodbar!='" + cb + "'";
            }
            this.Conexion.PrepararComando(sql);

            this.Conexion.AsignarParametroCadena("@capdcodbar", cb);

            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta.Read())
            {
                this._capdpreven = ResultadoConsulta.GetDecimal(0);
                this._capdvolpro = ResultadoConsulta.GetDecimal(1);
                this._capdpremin = ResultadoConsulta.GetDecimal(2);
                this._capdconinv = ResultadoConsulta.GetBoolean(3);
                this._capdstopro = ResultadoConsulta.GetInt32(4);
                this._capdfeccre = ResultadoConsulta.GetDateTime(5);
                this._capdfecmod = ResultadoConsulta.GetDateTime(6);
                this._capdestpro = ResultadoConsulta.GetBoolean(7);
                this._fapdcodcat = ResultadoConsulta.GetString(8);
                this._capdnompro = ResultadoConsulta.GetString(9);
                this._capddespro = ResultadoConsulta.GetString(10);
                this._capdcodbar = ResultadoConsulta.GetString(11);
                this._capdunimed = ResultadoConsulta.GetString(12);
                this._capdmarpro = ResultadoConsulta.GetString(13);
                this._capdfotpro = ResultadoConsulta.GetString(14);
                this._papdcodpro = ResultadoConsulta.GetString(15);
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
                                     "capdpreven," +
                                     "capdvolpro," +
                                     "capdpremin," +
                                     "capdconinv," +
                                     "capdstopro," +
                                     "capdfeccre," +
                                     "capdfecmod," +
                                     "capdestpro," +
                                     "fapdcodcat," +
                                     "capdnompro," +
                                     "capddespro," +
                                     "capdcodbar," +
                                     "capdunimed," +
                                     "capdmarpro," +
                                     "capdfotpro," +
                                     "papdcodpro " + 
                             "from aproduc " +
                             "where " +
                                    "papdcodpro = @papdcodpro";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@papdcodpro",this._papdcodpro);

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
			        string sql = "insert into aproduc (" +
                                                       "capdpreven," +
                                                       "capdvolpro," +
                                                       "capdpremin," +
                                                       "capdconinv," +
                                                       "capdstopro," +
                                                       "capdfeccre," +
                                                       "capdfecmod," +
                                                       "capdestpro," +
                                                       "fapdcodcat," +
                                                       "capdnompro," +
                                                       "capddespro," +
                                                       "capdcodbar," +
                                                       "capdunimed," +
                                                       "capdmarpro," +
                                                       "capdfotpro," +
                                                       "papdcodpro" +
                                                       ") " +
	                             "values (" + 
                                          "@capdpreven," +
                                          "@capdvolpro," +
                                          "@capdpremin," +
                                          "@capdconinv," +
                                          "@capdstopro," +
                                          "@capdfeccre," +
                                          "@capdfecmod," +
                                          "@capdestpro," +
                                          "@fapdcodcat," +
                                          "@capdnompro," +
                                          "@capddespro," +
                                          "@capdcodbar," +
                                          "@capdunimed," +
                                          "@capdmarpro," +
                                          "@capdfotpro," +
                                          "@papdcodpro" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroDecimal("@capdpreven",this._capdpreven);
                    this.Conexion.AsignarParametroDecimal("@capdvolpro",this._capdvolpro);
                    this.Conexion.AsignarParametroDecimal("@capdpremin",this._capdpremin);
                    this.Conexion.AsignarParametroLogico("@capdconinv",this._capdconinv);
                    this.Conexion.AsignarParametroEntero("@capdstopro",this._capdstopro);
                    this.Conexion.AsignarParametroFechaHora("@capdfeccre",this._capdfeccre);
                    this.Conexion.AsignarParametroFechaHora("@capdfecmod",this._capdfecmod);
                    this.Conexion.AsignarParametroLogico("@capdestpro",this._capdestpro);
                    this.Conexion.AsignarParametroCadena("@fapdcodcat",this._fapdcodcat);
                    this.Conexion.AsignarParametroCadena("@capdnompro",this._capdnompro);
                    this.Conexion.AsignarParametroCadena("@capddespro",this._capddespro);
                    this.Conexion.AsignarParametroCadena("@capdcodbar",this._capdcodbar);
                    this.Conexion.AsignarParametroCadena("@capdunimed",this._capdunimed);
                    this.Conexion.AsignarParametroCadena("@capdmarpro",this._capdmarpro);
                    this.Conexion.AsignarParametroCadena("@capdfotpro",this._capdfotpro);
                    this.Conexion.AsignarParametroCadena("@papdcodpro",this._papdcodpro);

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
			        string sql = "update aproduc set " +
                                                     "capdpreven = @capdpreven, " +
                                                     "capdvolpro = @capdvolpro, " +
                                                     "capdpremin = @capdpremin, " +
                                                     "capdconinv = @capdconinv, " +
                                                     "capdstopro = @capdstopro, " +
                                                     "capdfeccre = @capdfeccre, " +
                                                     "capdfecmod = @capdfecmod, " +
                                                     "capdestpro = @capdestpro, " +
                                                     "fapdcodcat = @fapdcodcat, " +
                                                     "capdnompro = @capdnompro, " +
                                                     "capddespro = @capddespro, " +
                                                     "capdcodbar = @capdcodbar, " +
                                                     "capdunimed = @capdunimed, " +
                                                     "capdmarpro = @capdmarpro, " +
                                                     "capdfotpro = @capdfotpro" +
                                 " where " +
                                        "papdcodpro = @papdcodpro";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroDecimal("@capdpreven",this._capdpreven);
                    this.Conexion.AsignarParametroDecimal("@capdvolpro",this._capdvolpro);
                    this.Conexion.AsignarParametroDecimal("@capdpremin",this._capdpremin);
                    this.Conexion.AsignarParametroLogico("@capdconinv",this._capdconinv);
                    this.Conexion.AsignarParametroEntero("@capdstopro",this._capdstopro);
                    this.Conexion.AsignarParametroFechaHora("@capdfeccre",this._capdfeccre);
                    this.Conexion.AsignarParametroFechaHora("@capdfecmod",this._capdfecmod);
                    this.Conexion.AsignarParametroLogico("@capdestpro",this._capdestpro);
                    this.Conexion.AsignarParametroCadena("@fapdcodcat",this._fapdcodcat);
                    this.Conexion.AsignarParametroCadena("@capdnompro",this._capdnompro);
                    this.Conexion.AsignarParametroCadena("@capddespro",this._capddespro);
                    this.Conexion.AsignarParametroCadena("@capdcodbar",this._capdcodbar);
                    this.Conexion.AsignarParametroCadena("@capdunimed",this._capdunimed);
                    this.Conexion.AsignarParametroCadena("@capdmarpro",this._capdmarpro);
                    this.Conexion.AsignarParametroCadena("@capdfotpro",this._capdfotpro);
                    this.Conexion.AsignarParametroCadena("@papdcodpro",this._papdcodpro);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public bool Eliminar()
            {
                try
                {
                    this.Conexion.Conectar();

                    string sql = "delete from aproduc " +
                                    "where papdcodpro = @papdcodpro";

                    this.Conexion.PrepararComando(sql);

                    // Se asigna únicamente la llave primaria para identificar el registro
                    this.Conexion.AsignarParametroCadena("@papdcodpro", this._papdcodpro);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
                catch (Exception ex)
                {
                    this.Conexion.Desconectar();
                    System.Windows.Forms.MessageBox.Show("Error SQL al eliminar en acatpro: " + ex.Message, "Error BD");
                    return false;
                }
            }
            public List<aproduc> Lista(string where)
                { 
                    List<aproduc> ListaResultado = new List<aproduc>();
                    this.Conexion.Conectar(); 
			        string sql = "select " + 
                                         "capdpreven," +
                                         "capdvolpro," +
                                         "capdpremin," +
                                         "capdconinv," +
                                         "capdstopro," +
                                         "capdfeccre," +
                                         "capdfecmod," +
                                         "capdestpro," +
                                         "fapdcodcat," +
                                         "capdnompro," +
                                         "capddespro," +
                                         "capdcodbar," +
                                         "capdunimed," +
                                         "capdmarpro," +
                                         "capdfotpro," +
                                         "papdcodpro " + 
                                 "from aproduc " ;
 
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
                              aproduc Auxiliar = new aproduc();
                              Auxiliar.capdpreven = ResultadoConsulta.GetDecimal(0);
                              Auxiliar.capdvolpro = ResultadoConsulta.GetDecimal(1);
                              Auxiliar.capdpremin = ResultadoConsulta.GetDecimal(2);
                              Auxiliar.capdconinv = ResultadoConsulta.GetBoolean(3);
                              Auxiliar.capdstopro = ResultadoConsulta.GetInt32(4);
                              Auxiliar.capdfeccre = ResultadoConsulta.GetDateTime(5);
                              Auxiliar.capdfecmod = ResultadoConsulta.GetDateTime(6);
                              Auxiliar.capdestpro = ResultadoConsulta.GetBoolean(7);
                              Auxiliar.fapdcodcat = ResultadoConsulta.GetString(8);
                              Auxiliar.capdnompro = ResultadoConsulta.GetString(9);
                              Auxiliar.capddespro = ResultadoConsulta.GetString(10);
                              Auxiliar.capdcodbar = ResultadoConsulta.GetString(11);
                              Auxiliar.capdunimed = ResultadoConsulta.GetString(12);
                              Auxiliar.capdmarpro = ResultadoConsulta.GetString(13);
                              Auxiliar.capdfotpro = ResultadoConsulta.GetString(14);
                              Auxiliar.papdcodpro = ResultadoConsulta.GetString(15);
                              ListaResultado.Add(Auxiliar);
                        }

                    }
                    this.Conexion.Desconectar();
                    return ListaResultado;
                }
            public List<String> Combo(string campo)
        {
            List<String> ListaResultado = new List<String>();
            this.Conexion.Conectar();
            string sql = "SELECT " +
                            "DISTINCT " + campo + " " +
                            "FROM aproduc " +
                            "WHERE capdestpro = true " +
                            "ORDER BY " + campo;




            this.Conexion.PrepararComando(sql);
            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta != null)
            {
                while (ResultadoConsulta.Read())
                {
                    String Auxiliar = "";
                    Auxiliar = ResultadoConsulta.GetString(0);
                    ListaResultado.Add(Auxiliar);
                }

            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }
        #endregion

    }
}

