using BookStoreBusinessLogic.BusinessLogic;
using BookStoreBusinessLogic.Interfaces;
using BookStoreDBImplementation.Implementations;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace BookStoreView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var unityContainer = BuildUnityContainer();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(unityContainer.Resolve<MainForm>());
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IBookLogic, BookLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderLogic, OrderLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<IAuthorLogic, AuthorLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<IPublishingLogic, PublishingLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<ICustomerLogic, CustomerLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<IWarehouseLogic, WarehouseLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<IAddressLogic, AddressLogic>(new
                HierarchicalLifetimeManager());
            currentContainer.RegisterType<MainLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}
