using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aperson {

		#region Campos
            private bool _capsestper;
            private DateTime _capsfeccre;
            private DateTime _capsfecmod;
            private string _capsnumdoc;
            private string _capsnomper;
            private string _papscodper;
            private string _capsapemat;
            private string _capsdirper;
            private string _capstelper;
            private string _capscorele;
            private string _capsapepat;
            private string _capstipper;
            private string _capstipdoc;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public bool capsestper
            { 
                get{ return this._capsestper;}
                set{ this._capsestper = value;}
            } 
		    public DateTime capsfeccre
            { 
                get{ return this._capsfeccre;}
                set{ this._capsfeccre = value;}
            } 
		    public DateTime capsfecmod
            { 
                get{ return this._capsfecmod;}
                set{ this._capsfecmod = value;}
            } 
		    public string capsnumdoc
            { 
                get{ return this._capsnumdoc;}
                set{ this._capsnumdoc = value;}
            } 
		    public string capsnomper
            { 
                get{ return this._capsnomper;}
                set{ this._capsnomper = value;}
            } 
		    public string papscodper
            { 
                get{ return this._papscodper;}
                set{ this._papscodper = value;}
            } 
		    public string capsapemat
            { 
                get{ return this._capsapemat;}
                set{ this._capsapemat = value;}
            } 
		    public string capsdirper
            { 
                get{ return this._capsdirper;}
                set{ this._capsdirper = value;}
            } 
		    public string capstelper
            { 
                get{ return this._capstelper;}
                set{ this._capstelper = value;}
            } 
		    public string capscorele
            { 
                get{ return this._capscorele;}
                set{ this._capscorele = value;}
            } 
		    public string capsapepat
            { 
                get{ return this._capsapepat;}
                set{ this._capsapepat = value;}
            } 
		    public string capstipper
            { 
                get{ return this._capstipper;}
                set{ this._capstipper = value;}
            } 
		    public string capstipdoc
            { 
                get{ return this._capstipdoc;}
                set{ this._capstipdoc = value;}
            } 
        #endregion

        #region Constructor
            public aperson()
            { 
		        this._capsestper = true;
		        this._capsfeccre = DateTime.Now;
		        this._capsfecmod = DateTime.Now;
		        this._capsnumdoc = "";
		        this._capsnomper = "";
		        this._papscodper = "";
		        this._capsapemat = "";
		        this._capsdirper = "";
		        this._capstelper = "";
		        this._capscorele = "";
		        this._capsapepat = "";
		        this._capstipper = "";
		        this._capstipdoc = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "capsestper," +
                                     "capsfeccre," +
                                     "capsfecmod," +
                                     "capsnumdoc," +
                                     "capsnomper," +
                                     "papscodper," +
                                     "capsapemat," +
                                     "capsdirper," +
                                     "capstelper," +
                                     "capscorele," +
                                     "capsapepat," +
                                     "capstipper," +
                                     "capstipdoc " + 
                             "from aperson " +
                             "where "+
                                    "papscodper = @papscodper";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@papscodper",this._papscodper);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._capsestper=ResultadoConsulta.GetBoolean(0);
                    this._capsfeccre=ResultadoConsulta.GetDateTime(1);
                    this._capsfecmod=ResultadoConsulta.GetDateTime(2);
                    this._capsnumdoc=ResultadoConsulta.GetString(3);
                    this._capsnomper=ResultadoConsulta.GetString(4);
                    this._papscodper=ResultadoConsulta.GetString(5);
                    this._capsapemat=ResultadoConsulta.GetString(6);
                    this._capsdirper=ResultadoConsulta.GetString(7);
                    this._capstelper=ResultadoConsulta.GetString(8);
                    this._capscorele=ResultadoConsulta.GetString(9);
                    this._capsapepat=ResultadoConsulta.GetString(10);
                    this._capstipper=ResultadoConsulta.GetString(11);
                    this._capstipdoc=ResultadoConsulta.GetString(12);
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
                                     "capsestper," +
                                     "capsfeccre," +
                                     "capsfecmod," +
                                     "capsnumdoc," +
                                     "capsnomper," +
                                     "papscodper," +
                                     "capsapemat," +
                                     "capsdirper," +
                                     "capstelper," +
                                     "capscorele," +
                                     "capsapepat," +
                                     "capstipper," +
                                     "capstipdoc " + 
                             "from aperson " +
                             "where " +
                                    "papscodper = @papscodper";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@papscodper",this._papscodper);

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
			        string sql = "insert into aperson (" +
                                                       "capsestper," +
                                                       "capsfeccre," +
                                                       "capsfecmod," +
                                                       "capsnumdoc," +
                                                       "capsnomper," +
                                                       "papscodper," +
                                                       "capsapemat," +
                                                       "capsdirper," +
                                                       "capstelper," +
                                                       "capscorele," +
                                                       "capsapepat," +
                                                       "capstipper," +
                                                       "capstipdoc" +
                                                       ") " +
	                             "values (" + 
                                          "@capsestper," +
                                          "@capsfeccre," +
                                          "@capsfecmod," +
                                          "@capsnumdoc," +
                                          "@capsnomper," +
                                          "@papscodper," +
                                          "@capsapemat," +
                                          "@capsdirper," +
                                          "@capstelper," +
                                          "@capscorele," +
                                          "@capsapepat," +
                                          "@capstipper," +
                                          "@capstipdoc" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroLogico("@capsestper",this._capsestper);
                    this.Conexion.AsignarParametroFechaHora("@capsfeccre",this._capsfeccre);
                    this.Conexion.AsignarParametroFechaHora("@capsfecmod",this._capsfecmod);
                    this.Conexion.AsignarParametroCadena("@capsnumdoc",this._capsnumdoc);
                    this.Conexion.AsignarParametroCadena("@capsnomper",this._capsnomper);
                    this.Conexion.AsignarParametroCadena("@papscodper",this._papscodper);
                    this.Conexion.AsignarParametroCadena("@capsapemat",this._capsapemat);
                    this.Conexion.AsignarParametroCadena("@capsdirper",this._capsdirper);
                    this.Conexion.AsignarParametroCadena("@capstelper",this._capstelper);
                    this.Conexion.AsignarParametroCadena("@capscorele",this._capscorele);
                    this.Conexion.AsignarParametroCadena("@capsapepat",this._capsapepat);
                    this.Conexion.AsignarParametroCadena("@capstipper",this._capstipper);
                    this.Conexion.AsignarParametroCadena("@capstipdoc",this._capstipdoc);

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
			        string sql = "update aperson set " +
                                                     "capsestper = @capsestper, " +
                                                     "capsfeccre = @capsfeccre, " +
                                                     "capsfecmod = @capsfecmod, " +
                                                     "capsnumdoc = @capsnumdoc, " +
                                                     "capsnomper = @capsnomper, " +
                                                     "capsapemat = @capsapemat, " +
                                                     "capsdirper = @capsdirper, " +
                                                     "capstelper = @capstelper, " +
                                                     "capscorele = @capscorele, " +
                                                     "capsapepat = @capsapepat, " +
                                                     "capstipper = @capstipper, " +
                                                     "capstipdoc = @capstipdoc" +
                                 " where " +
                                        "papscodper = @papscodper";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroLogico("@capsestper",this._capsestper);
                    this.Conexion.AsignarParametroFechaHora("@capsfeccre",this._capsfeccre);
                    this.Conexion.AsignarParametroFechaHora("@capsfecmod",this._capsfecmod);
                    this.Conexion.AsignarParametroCadena("@capsnumdoc",this._capsnumdoc);
                    this.Conexion.AsignarParametroCadena("@capsnomper",this._capsnomper);
                    this.Conexion.AsignarParametroCadena("@papscodper",this._papscodper);
                    this.Conexion.AsignarParametroCadena("@capsapemat",this._capsapemat);
                    this.Conexion.AsignarParametroCadena("@capsdirper",this._capsdirper);
                    this.Conexion.AsignarParametroCadena("@capstelper",this._capstelper);
                    this.Conexion.AsignarParametroCadena("@capscorele",this._capscorele);
                    this.Conexion.AsignarParametroCadena("@capsapepat",this._capsapepat);
                    this.Conexion.AsignarParametroCadena("@capstipper",this._capstipper);
                    this.Conexion.AsignarParametroCadena("@capstipdoc",this._capstipdoc);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<aperson> Lista(string where)
            { 
                List<aperson> ListaResultado = new List<aperson>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "capsestper," +
                                     "capsfeccre," +
                                     "capsfecmod," +
                                     "capsnumdoc," +
                                     "capsnomper," +
                                     "papscodper," +
                                     "capsapemat," +
                                     "capsdirper," +
                                     "capstelper," +
                                     "capscorele," +
                                     "capsapepat," +
                                     "capstipper," +
                                     "capstipdoc " + 
                             "from aperson " ;
 
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
                          aperson Auxiliar = new aperson();
                          Auxiliar.capsestper = ResultadoConsulta.GetBoolean(0);
                          Auxiliar.capsfeccre = ResultadoConsulta.GetDateTime(1);
                          Auxiliar.capsfecmod = ResultadoConsulta.GetDateTime(2);
                          Auxiliar.capsnumdoc = ResultadoConsulta.GetString(3);
                          Auxiliar.capsnomper = ResultadoConsulta.GetString(4);
                          Auxiliar.papscodper = ResultadoConsulta.GetString(5);
                          Auxiliar.capsapemat = ResultadoConsulta.GetString(6);
                          Auxiliar.capsdirper = ResultadoConsulta.GetString(7);
                          Auxiliar.capstelper = ResultadoConsulta.GetString(8);
                          Auxiliar.capscorele = ResultadoConsulta.GetString(9);
                          Auxiliar.capsapepat = ResultadoConsulta.GetString(10);
                          Auxiliar.capstipper = ResultadoConsulta.GetString(11);
                          Auxiliar.capstipdoc = ResultadoConsulta.GetString(12);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}

