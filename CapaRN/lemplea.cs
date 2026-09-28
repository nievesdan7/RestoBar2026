using CapaAD;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaRN
{
    public class lemplea
    {
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
        public bool capsestper
        {
            get { return this._capsestper; }
            set { this._capsestper = value; }
        }
        public DateTime capsfeccre
        {
            get { return this._capsfeccre; }
            set { this._capsfeccre = value; }
        }
        public DateTime capsfecmod
        {
            get { return this._capsfecmod; }
            set { this._capsfecmod = value; }
        }
        public string capsnumdoc
        {
            get { return this._capsnumdoc; }
            set { this._capsnumdoc = value; }
        }
        public string capsnomper
        {
            get { return this._capsnomper; }
            set { this._capsnomper = value; }
        }
        public string papscodper
        {
            get { return this._papscodper; }
            set { this._papscodper = value; }
        }
        public string capsapemat
        {
            get { return this._capsapemat; }
            set { this._capsapemat = value; }
        }
        public string capsdirper
        {
            get { return this._capsdirper; }
            set { this._capsdirper = value; }
        }
        public string capstelper
        {
            get { return this._capstelper; }
            set { this._capstelper = value; }
        }
        public string capscorele
        {
            get { return this._capscorele; }
            set { this._capscorele = value; }
        }
        public string capsapepat
        {
            get { return this._capsapepat; }
            set { this._capsapepat = value; }
        }
        public string capstipper
        {
            get { return this._capstipper; }
            set { this._capstipper = value; }
        }
        public string capstipdoc
        {
            get { return this._capstipdoc; }
            set { this._capstipdoc = value; }
        }

        public DateTime caelfecmod
        {
            get { return this._caelfecmod; }
            set { this._caelfecmod = value; }
        }
        public DateTime caelfecing
        {
            get { return this._caelfecing; }
            set { this._caelfecing = value; }
        }
        public DateTime caelfecsal
        {
            get { return this._caelfecsal; }
            set { this._caelfecsal = value; }
        }
        public decimal caelsalemp
        {
            get { return this._caelsalemp; }
            set { this._caelsalemp = value; }
        }
        public bool caelestemp
        {
            get { return this._caelestemp; }
            set { this._caelestemp = value; }
        }
        public DateTime caelfeccre
        {
            get { return this._caelfeccre; }
            set { this._caelfeccre = value; }
        }
        public string faelcodper
        {
            get { return this._faelcodper; }
            set { this._faelcodper = value; }
        }
        
        public string caeltipemp
        {
            get { return this._caeltipemp; }
            set { this._caeltipemp = value; }
        }
        public string paelcodemp
        {
            get { return this._paelcodemp; }
            set { this._paelcodemp = value; }
        }
        #endregion

        #region Constructor
        public lemplea()
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

            this._caelfecmod = DateTime.Now;
            this._caelfecing = DateTime.Now;
            this._caelfecsal = DateTime.Now;
            this._caelsalemp = 0;
            this._caelestemp = true;
            this._caelfeccre = DateTime.Now;
            this._faelcodper = "";            
            this._caeltipemp = "";
            this.Conexion = new CLConexionPGSQL();
        }
        #endregion

        #region Metodos       
        public List<lemplea> Lista(string where)
        {
            List<lemplea> ListaResultado = new List<lemplea>();
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
                                "capstipdoc," +
                                "caelfecmod," +
                                "caelfecing," +
                                "caelfecsal," +
                                "caelsalemp," +
                                "caelestemp," +
                                "caelfeccre," +
                                "faelcodper," +                                
                                "caeltipemp," +
                                "paelcodemp " +
                         "from aperson,aemplea " +
                         "where " +
                                "aperson.papscodper = aemplea.faelcodper ";
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
                    lemplea Auxiliar = new lemplea();
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
                    Auxiliar.caelfecmod = ResultadoConsulta.GetDateTime(13);
                    Auxiliar.caelfecing = ResultadoConsulta.GetDateTime(14);
                    Auxiliar.caelfecsal = ResultadoConsulta.GetDateTime(15);
                    Auxiliar.caelsalemp = ResultadoConsulta.GetDecimal(16);
                    Auxiliar.caelestemp = ResultadoConsulta.GetBoolean(17);
                    Auxiliar.caelfeccre = ResultadoConsulta.GetDateTime(18);
                    Auxiliar.faelcodper = ResultadoConsulta.GetString(19);                    
                    Auxiliar.caeltipemp = ResultadoConsulta.GetString(20);
                    Auxiliar.paelcodemp = ResultadoConsulta.GetString(21);
                    ListaResultado.Add(Auxiliar);
                }

            }
            this.Conexion.Desconectar();
            return ListaResultado;
        }
        #endregion
    }
}
