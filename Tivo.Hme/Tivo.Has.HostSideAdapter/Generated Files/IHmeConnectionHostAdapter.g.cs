//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tivo.Has.HostSideAdapters
{
    
    public class IHmeConnectionHostAdapter
    {
        internal static Tivo.Has.IHmeConnection ContractToViewAdapter(Tivo.Has.Contracts.IHmeConnectionContract contract)
        {
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IHmeConnectionViewToContractHostAdapter))))
            {
                return ((IHmeConnectionViewToContractHostAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IHmeConnectionContractToViewHostAdapter(contract);
            }
        }
        internal static Tivo.Has.Contracts.IHmeConnectionContract ViewToContractAdapter(Tivo.Has.IHmeConnection view)
        {
            if (view.GetType().Equals(typeof(IHmeConnectionContractToViewHostAdapter)))
            {
                return ((IHmeConnectionContractToViewHostAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IHmeConnectionViewToContractHostAdapter(view);
            }
        }
    }
}

