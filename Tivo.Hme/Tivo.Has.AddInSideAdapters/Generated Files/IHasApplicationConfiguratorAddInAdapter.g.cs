//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tivo.Has.AddInSideAdapters
{
    
    public class IHasApplicationConfiguratorAddInAdapter
    {
        internal static Tivo.Has.IHasApplicationConfigurator ContractToViewAdapter(Tivo.Has.Contracts.IHasApplicationConfiguratorContract contract)
        {
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IHasApplicationConfiguratorViewToContractAddInAdapter))))
            {
                return ((IHasApplicationConfiguratorViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IHasApplicationConfiguratorContractToViewAddInAdapter(contract);
            }
        }
        internal static Tivo.Has.Contracts.IHasApplicationConfiguratorContract ViewToContractAdapter(Tivo.Has.IHasApplicationConfigurator view)
        {
            if (view.GetType().Equals(typeof(IHasApplicationConfiguratorContractToViewAddInAdapter)))
            {
                return ((IHasApplicationConfiguratorContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IHasApplicationConfiguratorViewToContractAddInAdapter(view);
            }
        }
    }
}

