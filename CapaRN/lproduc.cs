using CapaAD;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaRN
{
    public class lproduc
    {
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

        private bool _cacpestcat;
        private string _pacpcodcat;
        private string _cacpnomcat;
        //Instancia para conexion a PostgreSQL 8.2
        private CLConexionPGSQL Conexion;
        #endregion

        #region Propiedades
        public decimal capdpreven
        {
            get { return this._capdpreven; }
            set { this._capdpreven = value; }
        }
        public decimal capdvolpro
        {
            get { return this._capdvolpro; }
            set { this._capdvolpro = value; }
        }
        public decimal capdpremin
        {
            get { return this._capdpremin; }
            set { this._capdpremin = value; }
        }
        public bool capdconinv
        {
            get { return this._capdconinv; }
            set { this._capdconinv = value; }
        }
        public int capdstopro
        {
            get { return this._capdstopro; }
            set { this._capdstopro = value; }
        }
        public DateTime capdfeccre
        {
            get { return this._capdfeccre; }
            set { this._capdfeccre = value; }
        }
        public DateTime capdfecmod
        {
            get { return this._capdfecmod; }
            set { this._capdfecmod = value; }
        }
        public bool capdestpro
        {
            get { return this._capdestpro; }
            set { this._capdestpro = value; }
        }
        public string fapdcodcat
        {
            get { return this._fapdcodcat; }
            set { this._fapdcodcat = value; }
        }
        public string capdnompro
        {
            get { return this._capdnompro; }
            set { this._capdnompro = value; }
        }
        public string capddespro
        {
            get { return this._capddespro; }
            set { this._capddespro = value; }
        }
        public string capdcodbar
        {
            get { return this._capdcodbar; }
            set { this._capdcodbar = value; }
        }
        public string capdunimed
        {
            get { return this._capdunimed; }
            set { this._capdunimed = value; }
        }
        public string capdmarpro
        {
            get { return this._capdmarpro; }
            set { this._capdmarpro = value; }
        }
        public string capdfotpro
        {
            get { return this._capdfotpro; }
            set { this._capdfotpro = value; }
        }
        public string papdcodpro
        {
            get { return this._papdcodpro; }
            set { this._papdcodpro = value; }
        }
        public bool cacpestcat
        {
            get { return this._cacpestcat; }
            set { this._cacpestcat = value; }
        }
        public string pacpcodcat
        {
            get { return this._pacpcodcat; }
            set { this._pacpcodcat = value; }
        }
        public string cacpnomcat
        {
            get { return this._cacpnomcat; }
            set { this._cacpnomcat = value; }
        }
        #endregion

        #region Constructor
        public lproduc()
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

            this._cacpestcat = true;
            this._pacpcodcat = "";
            this._cacpnomcat = "";
            this.Conexion = new CLConexionPGSQL();
        }
        #endregion

        #region Metodos
        
        public List<lproduc> Lista(string where)
        {
            List<lproduc> ListaResultado = new List<lproduc>();
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
                                "papdcodpro, " +

                                "cacpestcat," +
                                "pacpcodcat," +
                                "cacpnomcat " +
                         "from aproduc,acatpro " +
                         "where " +
                                "aproduc.fapdcodcat = acatpro.pacpcodcat ";
            if (where.Replace(" ", "") != "")
            {
                sql += " and " + where;
            }


            this.Conexion.PrepararComando(sql);
            DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

            if (ResultadoConsulta != null)
            {
                while (ResultadoConsulta.Read())
                {
                    lproduc Auxiliar = new lproduc();
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
                    Auxiliar.cacpestcat = ResultadoConsulta.GetBoolean(16);
                    Auxiliar.pacpcodcat = ResultadoConsulta.GetString(17);
                    Auxiliar.cacpnomcat = ResultadoConsulta.GetString(18);
                    ListaResultado.Add(Auxiliar);
                }

            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }
        #endregion
    }
}
