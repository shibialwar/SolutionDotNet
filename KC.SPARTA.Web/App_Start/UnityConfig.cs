using System;
using Unity;
using KC.SPARTA.Interface.Business;
using KC.SPARTA.Business;
using KC.SPARTA.Model.Model;
using KC.SPARTA.Common.Constants;
using KC.SPARTA.Rule;
using System.Web;
using KC.SPARTA.Interface.Service;
using KC.SPARTA.Authentication;
using AutoMapper;
using KC.SPARTA.DataAccess;
using Unity.Lifetime;

namespace KC.SPARTA.Web
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        #region TypeRegisteration

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            //Register AutoMappers
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutomapperBootstrap());
            });
            container.RegisterInstance<IMapper>(config.CreateMapper());

            //User Registeration is for all regions & can also be specifict to the region
            //If specific to region the unit has to be resolved in base controllers 
            container.RegisterType<IUserProvider, UserProvider>();
            

            RegisterTypesAPAC(container);
            RegisterTypesEMEA(container);
            RegisterTypesNA(container);
        }

        /// <summary>
        /// Register only for the APAC components
        /// </summary>
        /// <param name="container"></param>
        public static void RegisterTypesAPAC(IUnityContainer container)
        {
            // TODO: Register your type's mappings here.
            //APAC DB Connection
            container.RegisterInstance<DbConnection>(new ApacDbConnection(), new ContainerControlledLifetimeManager());

            container.RegisterType<IRule, APACRule>(AppConstants.Region.APAC);
            container.RegisterType<IBusinessSample, SampleAPACBiz>(AppConstants.Region.APAC);

        }

        /// <summary>
        /// Register only for the EMEA components
        /// </summary>
        /// <param name="container"></param>
        public static void RegisterTypesEMEA(IUnityContainer container)
        {
            container.RegisterInstance<DbConnection>(new EmeaDbConnection(), new ContainerControlledLifetimeManager());
            // TODO: Register your type's mappings here.
            container.RegisterType<IRule, EMEARule>(AppConstants.Region.EMEA);
            
            
        }


        /// <summary>
        /// Register only for the APAC components
        /// </summary>
        /// <param name="container"></param>
        public static void RegisterTypesNA(IUnityContainer container)
        {
            // TODO: Register your type's mappings here.
            container.RegisterType<IRule, NARule>(AppConstants.Region.NA);
        }


        #endregion TypeRegisteration
    }
}