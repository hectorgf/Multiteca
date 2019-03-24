using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Entities;
using NHibernate.Entities.Juego;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Configuration;

namespace NHibernateApp.Persistence
{
    public class SessionManager
    {
        #region ATRIBUTOS
        private ISessionFactory _sessionFactory;
        private ISession _session;
        #endregion

        #region PROPIEDADES
        /// <summary>
        /// Propiedad sesión de NHibernate
        /// </summary>
        public ISession Session
        {
            get
            {
                if (null == this._session || !this._session.IsOpen)
                    this._session = this.OpenSession();

                return _session;

            }
            set { this._session = value; }
        }
        #endregion

        #region CONSTRUCTOR SINGLETON
        private static volatile SessionManager instance;
        private static object syncRoot = new Object();
        private SessionManager()
        {
        }

        public static SessionManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SessionManager();
                    }
                }

                return instance;
            }
        }
        #endregion

        #region METODOS CONFIGURACIÓN
        /// <summary>
        /// Método que abre la sesión
        /// </summary>
        /// <returns>La sesión activa</returns>
        private ISession OpenSession()
        {
            //Open and return the nhibernate session
            return this.SessionFactory.OpenSession();
        }

        /// <summary>
        /// Método que nos sirve para testear si tenemos conexión con la base de datos
        /// </summary>
        /// <returns>True si hay conexión y false en caso contrario</returns>
        public bool TestConnection()
        {
            ISessionFactory _iSession = this.SessionFactory;

            if (null == _iSession)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Método que crea la session factory
        /// </summary>
        public ISessionFactory SessionFactory
        {
            get
            {
                try
                {
                    //Siempre que no la hayamos creado antes
                    if (_sessionFactory == null)
                    {
                        //Comenzamos la configuración a través de FluentNHibernate
                        var f = Fluently.Configure();

                        //Configuramos la cadena de conexión a la base de datos en este caso utilizamos ORACLE XE 11
                        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Multiteca.mdf;Integrated Security=True";
                        //string connString = ConfigurationManager.ConnectionStrings["MultitecaConnectionString"].ConnectionString;
                        f.Database(MsSqlConfiguration.MsSql2008.ConnectionString(connString).ShowSql());

                        //Mapeo de clases, con solo hacer una referencia a una clase nos mapeara todas las clases
                        f.Mappings(m => m.FluentMappings.AddFromAssemblyOf<JuegoEntity>());

                        //Con esta configuración cualquier modificación en nuestro modelo se aplicará automaticamente en 
                        //f.ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(true, true));
                        //Esta linea de código la descomentaremos y comentaremos la anterios si queremos resetear toda nuestra base de datos
                        //f.ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true,true));

                        //Por último creamos el session factory
                        _sessionFactory = f.BuildSessionFactory();
                    }
                    return _sessionFactory;
                }
                catch (Exception e)
                {
                    throw new NotImplementedException();
                }
            }
        }

        #endregion
    }
}