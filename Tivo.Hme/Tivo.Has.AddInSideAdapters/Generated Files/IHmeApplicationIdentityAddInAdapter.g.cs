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
    
    public class IHmeApplicationIdentityAddInAdapter
    {
        internal static Tivo.Has.IHmeApplicationIdentity ContractToViewAdapter(Tivo.Has.Contracts.IHmeApplicationIdentityContract contract)
        {
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IHmeApplicationIdentityViewToContractAddInAdapter))))
            {
                return ((IHmeApplicationIdentityViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IHmeApplicationIdentityContractToViewAddInAdapter(contract);
            }
        }
        internal static Tivo.Has.Contracts.IHmeApplicationIdentityContract ViewToContractAdapter(Tivo.Has.IHmeApplicationIdentity view)
        {
            if (view.GetType().Equals(typeof(IHmeApplicationIdentityContractToViewAddInAdapter)))
            {
                return ((IHmeApplicationIdentityContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IHmeApplicationIdentityViewToContractAddInAdapter(view);
            }
        }
    }
}

